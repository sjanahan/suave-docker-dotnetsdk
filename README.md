## Getting Started
1. `docker pull microsoft/dotnet:2.2-sdk`
1. `docker pull microsoft/dotnet:2.2-runtime`
1. `docker pull microsoft/dotnet:2.2-runtime-deps`
1. `docker build -t sample5 .`
1. `docker run --rm -p 8083:8083 sample5`
