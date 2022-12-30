# .NET Microservices

<div align="center">

[![HitCount](https://hits.dwyl.com/rlinsdev/.NET-Microservices.svg?style=flat-square&show=unique)](http://hits.dwyl.com/rlinsdev/.NET-Microservices)

</div>

### Commands Dotnet - Platform Service:
* `dotnet --version`: 7.0.101
* `dotnet new webapi -n PlatformService`
* `dotnet build`
* `dotnet run`

### Commands-PlatformService
* `dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection`
* `dotnet add package Microsoft.EntityFrameworkCore`
* `dotnet add package Microsoft.EntityFrameworkCore.Design`
* `dotnet add package Microsoft.EntityFrameworkCore.InMemory`
* `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`

### Commands Docker:
* `docker build -t [99999]/platformservice .`
* `docker run -p 8080:80 -d [99999]/platformservice`
* `docker ps` Show runing container 
* `docker stop 325c4d758b95` Show runing container 
* `docker start 325c4d758b95` Start stoped container
* `docker push 22369/platformservice` Push img to docker hub

### Commands Kubernetes:
* `kubectl version` 
* `$/k8s>kubectl apply -f platforms-depl.yaml`
* `$/k8s>kubectl get deployments`
* `$/k8s>kubectl get pods`
* `$/k8s>kubectl delete deployment platforms-depl`
* `$/k8s>kubectl apply -f platforms-np-srv.yaml`
* `$/k8s>kubectl get services`

### Commands Dotnet - Commands Service
* `dotnet new webapi -n CommandsService`

### Dev endpoints Platform Service
* GET  http://localhost:5092/api/Platforms
* GET  http://localhost:5092/api/Platforms/{id}
* POST http://localhost:5092/api/Platforms

### Docker endpoints Platform Service
* GET  http://localhost:8080/api/Platforms
* GET  http://localhost:8080/api/Platforms/{id}
* POST http://localhost:8080/api/Platforms

### Tools
* VSCode
* Postman



### Shortcut VsCode
| ShortCut | Obs |
|-|-
|Ctrl + .|Quick fix |
|Ctrl + B|Hide Explorer tab |
|Ctrl + J|Hide Terminal tab |

### Full Course:
* https://github.com/binarythistle/S04E03---.NET-Microservices-Course-
* https://www.youtube.com/watch?v=DgVjEo3OGBI