FROM mcr.microsoft.com/dotnet/sdk:5.0

LABEL name="Alexei Pancratov"

EXPOSE 82

ENV DOTNET_USE_POLLING_FILE_WATCHER=1
ENV ASPNETCORE_URLS=http://+:82

COPY . /searchService
WORKDIR /searchService

CMD ["/bin/bash", "-c", "dotnet restore && dotnet watch run"]