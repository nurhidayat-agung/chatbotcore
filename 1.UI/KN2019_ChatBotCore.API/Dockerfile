#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY ["1.UI/KN2019_ChatBotCore.API/KN2019_ChatBotCore.API.csproj", "1.UI/KN2019_ChatBotCore.API/"]
RUN dotnet restore "1.UI/KN2019_ChatBotCore.API/KN2019_ChatBotCore.API.csproj"
COPY . .
WORKDIR "/src/1.UI/KN2019_ChatBotCore.API"
RUN dotnet build "KN2019_ChatBotCore.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "KN2019_ChatBotCore.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "KN2019_ChatBotCore.API.dll"]