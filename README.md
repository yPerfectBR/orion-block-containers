# Orion Block Containers

Chest and barrel block containers.

- **Manifest id:** `orion:block_containers`
- **Provides:** `orion:block_containers`
- **Depend:** `orion:containers`, `orion:inventory`

## Build

```bash
dotnet build OrionBlockContainers.csproj -c Release
```

Deploy this plugin plus its dependencies under `plugins/{id}/`.

## Events

Cancelable `PlayerOpenContainerSignal` fires before the container UI opens.

## CI

GitHub Actions builds `orion-containers` and `orion-inventory`, then smoke-boots the server with all three plugins loaded.
