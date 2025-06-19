# PrimeService

Una biblioteca de .NET para verificar si un número es primo, específicamente optimizada para números del 2 al 20.

## Características

- Verificación rápida de números primos del 2 al 20
- Cobertura completa de pruebas unitarias
- Documentación completa con DocFx
- Integración continua con GitHub Actions

## Instalación

```bash
dotnet add package Primes.Lib
```

## Uso

```csharp
using Primes.Lib;

var primeService = new PrimeService();

// Verificar si un número es primo
bool isPrime = primeService.IsPrime(7); // Returns true
bool isNotPrime = primeService.IsPrime(4); // Returns false
```

## Números Primos del 2 al 20

Los números primos en este rango son: **2, 3, 5, 7, 11, 13, 17, 19**

## Desarrollo

### Prerrequisitos

- .NET 8.0 SDK
- Visual Studio 2022 o VS Code

### Compilación

```bash
dotnet build
```

### Ejecutar Pruebas

```bash
dotnet test
```

### Generar Reporte de Cobertura

```bash
dotnet test --collect:"XPlat Code Coverage"
```

### Generar Documentación

```bash
dotnet tool install -g docfx
docfx docfx.json
```

## Licencia

Este proyecto está bajo la Licencia MIT. Ver el archivo [LICENSE](LICENSE) para más detalles.

## Autor

Angel Vargas Gutierrez 