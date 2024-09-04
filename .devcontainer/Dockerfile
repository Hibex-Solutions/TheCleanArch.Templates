ARG SDK_VERSION="8.0"

FROM mcr.microsoft.com/dotnet/sdk:${SDK_VERSION}
WORKDIR /thecleanarch-templates

RUN apt update && apt full-upgrade -y && apt install ssh -y