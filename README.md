# Prerequisites
https://www.docker.com/products/docker-desktop + enabled Kubernetes

# Info

Info about MS and their out of the box Dockerfile
https://docs.microsoft.com/en-us/visualstudio/containers/container-build?view=vs-2019

Introduction to kubernetes

- ELI5 - https://www.cncf.io/the-childrens-illustrated-guide-to-kubernetes/
- ELI5 - https://www.cncf.io/phippy-goes-to-the-zoo-book/
- https://andrewlock.net/deploying-asp-net-core-applications-to-kubernetes-part-1-an-introduction-to-kubernetes/#the-basic-kubernetes-components-for-developers

## Pros

- Rollout deploys
- Recover on fails
- Horizontal scale
- Consistent builds

## Cons

- Added complexity
- Stateless, don't store data inside pods

# Steps

Request date from server  
`curl -H "source:client 1" https://localhost:5001/example`
`curl -H "source:client 2" https://localhost:5001/example`

Build docker image  
`docker build -t server:dev -f Server/Dockerfile .`

Run docker container  
`docker run -itp 80:80 server:dev`

Make request towards docker container  
`curl -H "source:client 1" http://localhost:80/example`  
`curl -H "source:client 2" http://localhost:80/example`

Kubernetes (cd to ./Server)  
`kubectl apply -f .\deployment.yaml`

Display the created deployment, service and pod(s)
`kubectl get all`

Pod logs routed through service  
`kubectl logs service/server-demo-service`

Get all pods  
`kubectl get pods -l app=server-demo`

Make request towards kubernetes  
`curl -H "source:client 1" http://localhost:30007/example`  
`curl -H "source:client 2" http://localhost:30007/example`
