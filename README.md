# orion:block_containers

Baús e barris. Depende de `orion:containers` + `orion:inventory`.

## Build

```bash
# Via menu em Plugins-Orion/
./build-plugins.sh
# ou:
dotnet build OrionBlockContainers.csproj
```

Evento cancelável: `PlayerOpenContainerSignal` (antes de abrir a UI).

## Provides

- `orion:block_containers`
