FROM mcr.microsoft.com/dotnet/sdk:5.0

LABEL name="Alexei Pancratov"

EXPOSE 81

ENV DOTNET_USE_POLLING_FILE_WATCHER=1
ENV ASPNETCORE_URLS=http://+:81

COPY . /bookingService
WORKDIR /bookingService

CMD ["/bin/bash", "-c", "dotnet restore && dotnet watch run"]