FROM mcr.microsoft.com/dotnet/sdk:6.0 as sdk
WORKDIR /app
COPY . /app
RUN dotnet publish -c Release -o /app/api "src/Presentation" 

FROM node:16 as node
WORKDIR /app
COPY "src/Presentation" /app
RUN npm install -g npm@7.21.1
RUN npm install
RUN npm run build

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=sdk /app/api /app
COPY --from=node /app/dist /app/wwwroot
ENV ASPNETCORE_URLS=http://*:80
EXPOSE 80
ENTRYPOINT ["dotnet", "Mobnet.Store.Presentation.dll"]