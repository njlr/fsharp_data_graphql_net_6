FROM mcr.microsoft.com/dotnet/sdk:6.0

# Later version will work
# FROM mcr.microsoft.com/dotnet/sdk:7.0

WORKDIR /home

ADD fsharp-data-graphql-net-6.fsproj .
ADD Program.fs .

ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=true

RUN dotnet build

CMD [ "dotnet", "run" ]
