FROM debian:buster-slim AS nwnxee-build
RUN buildDeps="build-essential \
  ca-certificates \
  cmake \
  doxygen \
  g++-7 \
  gcc-7 \
  git \
  gperf \
  graphviz \
  libhunspell-dev \
  libseccomp-dev \
  libssl-dev \
  pkg-config \
  zip" \
  && apt update \
  && apt install -y --no-install-recommends $buildDeps \
  && apt clean \
  && rm -r /var/lib/apt/lists /var/cache/apt
RUN git clone --depth 3 https://github.com/nwnxee/unified.git /build-nwnx
WORKDIR /build-nwnx
RUN sed -i s:"file(GLOB plugins Plugins/\*/CMakeLists.txt)":"file(GLOB plugins Plugins/DotNET/CMakeLists.txt)": CMakeLists.txt
RUN cmake . -DCMAKE_BUILD_TYPE=RelWithDebInfo
RUN cmake --build . -j `nproc --all`

# build Managed
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS managed-build
COPY . /Build
WORKDIR /Build
RUN dotnet build --configuration Release -p:Version=1.1.1 -o output

# running image
FROM beamdog/nwserver:8193.16
COPY --from=nwnxee-build build-nwnx/Binaries/ /nwn/nwnx/
COPY --from=nwnxee-build build-nwnx/Scripts/Docker/run-server.patch /nwn
COPY --from=managed-build /Build/NWN.Managed.zip /nwn/Dotnet/Managed.zip
RUN installDeps="apt-transport-https \
  ca-certificates \
  gpg \
  inotify-tools \
  patch \
  wget \
  unzip" \
  && apt-get update \
  && apt-get install -y --no-install-recommends $installDeps \
  && wget -qO- https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > microsoft.asc.gpg \
  && wget -q https://packages.microsoft.com/config/debian/10/prod.list \
  && mv microsoft.asc.gpg /etc/apt/trusted.gpg.d/ \
  && mv prod.list /etc/apt/sources.list.d/microsoft-prod.list \
  && apt-get update \
  && apt-get -y install --no-install-recommends dotnet-sdk-3.1

# Patch run-server.sh with our modifications
RUN patch /nwn/run-server.sh < /nwn/run-server.patch

# Insert managed
RUN cd /nwn/Dotnet/ && unzip Managed.zip && rm Managed.zip

# Security upgrades and remove unneeded packages
RUN removeDeps="apt-transport-https \
  gpg \
  patch \
  unzip \
  wget" \
  apt-get -y upgrade \
  && apt-get -y remove --purge $removeDeps \
  && apt-get -y autoremove \
  && apt-get clean \
  && rm -r /var/cache/apt /var/lib/apt/lists

# Configure nwserver to run with nwnx
ENV NWNX_CORE_LOAD_PATH=/nwn/nwnx/
ENV NWN_LD_PRELOAD="/nwn/nwnx/NWNX_Core.so"
# Use NWNX_ServerLogRedirector as default log manager
ENV NWN_TAIL_LOGS=n \
  NWNX_CORE_LOG_LEVEL=6 \
  NWNX_SERVERLOGREDIRECTOR_LOG_LEVEL=6 \
  NWNX_SKIP_DOTNET=n \
  NWNX_DOTNET_ASSEMBLY=/nwn/Dotnet/NWN.Managed \
  NWM_NLOG_CONFIG=/nwn/home/nlog.config
