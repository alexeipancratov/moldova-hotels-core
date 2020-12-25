FROM mcr.microsoft.com/dotnet/sdk:5.0

LABEL name="Alexei Pancratov"

EXPOSE 80
EXPOSE 443

ENV DOTNET_USE_POLLING_FILE_WATCHER=1
ENV ASPNETCORE_URLS=https://+:443;http://+:80

COPY . /globalWebSite
WORKDIR /globalWebSite

CMD ["/bin/bash", "-c", "dotnet restore && dotnet watch run"]