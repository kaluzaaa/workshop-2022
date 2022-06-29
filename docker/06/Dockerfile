FROM mcr.microsoft.com/dotnet/sdk:6.0
RUN apt update && apt install -y tree 
COPY . /src
WORKDIR /src
CMD tree