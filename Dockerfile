FROM index.docker.io/nwnxee/unified:latest AS nwnxee-files
# managed builder
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS managed-build
COPY . /Build
WORKDIR /Build
RUN dotnet build --configuration Release -p:Version=1.1.1 -o output

# running image
FROM index.docker.io/beamdog/nwserver:8193.16 as nwserver-slim
# copy the files we need from the nwnxee image
COPY --from=nwnxee-files /nwn/run-server.sh /nwn/run-server.sh
COPY --from=nwnxee-files /nwn/nwnx/NWNX_Core.so /nwn/nwnx/NWNX_Core.so
COPY --from=nwnxee-files /nwn/nwnx/NWNX_DotNET.so /nwn/nwnx/NWNX_DotNET.so
# managed files
COPY --from=managed-build /Build/NWN.Managed.zip /nwn/Dotnet/Managed.zip
RUN installDeps="apt-transport-https \
  ca-certificates \
  gpg \
  inotify-tools \
  unzip \
  wget" \
  removeDeps="apt-transport-https \
  gpg \
  unzip \
  wget" \
  dotnetDeps="dotnet-runtime-3.1 \
  dotnet-apphost-pack-3.1" \
  && apt-get update && apt-get install -y --no-install-recommends $installDeps \
  && wget -qO- https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > microsoft.asc.gpg \
  && wget -q https://packages.microsoft.com/config/debian/10/prod.list \
  && mv microsoft.asc.gpg /etc/apt/trusted.gpg.d/ \
  && mv prod.list /etc/apt/sources.list.d/microsoft-prod.list \
  && cd /nwn/Dotnet/ && unzip Managed.zip && rm Managed.zip \
  && apt-get update \
  && apt-get -y install --no-install-recommends $dotnetDeps \
  && apt-get -y remove --purge $removeDeps \
  && rm -rf /var/lib/apt/lists/*

ENV NWNX_CORE_LOAD_PATH=/nwn/nwnx/ \
  NWN_LD_PRELOAD="/nwn/nwnx/NWNX_Core.so" \
  NWN_TAIL_LOGS=n \
  NWNX_CORE_LOG_LEVEL=6 \
  NWNX_SERVERLOGREDIRECTOR_LOG_LEVEL=6 \
  NWNX_SKIP_DOTNET=n \
  NWNX_DOTNET_ASSEMBLY=/nwn/Dotnet/NWN.Managed \
  NWM_NLOG_CONFIG=/nwn/home/nlog.config
