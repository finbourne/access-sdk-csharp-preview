FROM mcr.microsoft.com/dotnet/core/sdk:3.1

RUN mkdir -p /usr/src
WORKDIR /usr/src

COPY Finbourne.Access.Sdk.sln /usr/src/
COPY Finbourne.Access.Sdk/Finbourne.Access.Sdk.csproj /usr/src/Finbourne.Access.Sdk/
RUN dotnet restore Finbourne.Access.Sdk

ENTRYPOINT dotnet build --configuration Release --verbosity normal