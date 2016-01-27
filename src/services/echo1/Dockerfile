FROM microsoft/aspnet:1.0.0-rc1-update1

COPY . /app/
WORKDIR /app
RUN ["curl", "-sSL", "https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.sh", "|", "DNX_BRANCH=dev", "sh", "&&", "source", "~/.dnx/dnvm/dnvm.sh"]
RUN ["dnvm", "upgrade", "-r", "coreclr"]
RUN ["dnu", "restore"]

EXPOSE 5004
ENTRYPOINT ["dnx", "-p", "project.json", "web"]
