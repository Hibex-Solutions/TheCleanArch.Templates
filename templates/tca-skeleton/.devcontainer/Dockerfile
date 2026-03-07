ARG USERNAME=developer
ARG USER_UID=1001
ARG USER_GID=$USER_UID
ARG SDK_VERSION="10.0"
FROM ubuntu:24.04

FROM mcr.microsoft.com/dotnet/sdk:${SDK_VERSION}
WORKDIR /TheCleanArch.Templates.Skeleton

ARG USERNAME
ARG USER_UID
ARG USER_GID
ARG SDK_VERSION
RUN \
    groupadd --gid ${USER_GID} ${USERNAME} && \
    useradd --uid ${USER_UID} --gid ${USER_GID} -m ${USERNAME} && \
    apt-get update && \
    apt-get full-upgrade -y && \
    apt-get install sudo git curl ca-certificates ssh dotnet-sdk-${SDK_VERSION} -y && \
    apt-get autoremove -y && \
    apt-get clean -y && \
    echo ${USERNAME} ALL=\(root\) NOPASSWD:ALL > /etc/sudoers.d/${USERNAME} && \
    chmod 0440 /etc/sudoers.d/${USERNAME}

USER ${USERNAME}
