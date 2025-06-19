# PrimeService Documentation

Bienvenido a la documentación de PrimeService, una biblioteca de .NET para verificar números primos.

## Descripción General

PrimeService es una biblioteca especializada en la verificación de números primos, optimizada para el rango del 2 al 20. Proporciona una API simple y eficiente para determinar si un número dado es primo.

## Características Principales

- **Verificación Rápida**: Optimizada para números del 2 al 20
- **Cobertura Completa**: Pruebas unitarias exhaustivas
- **Documentación Detallada**: Documentación completa con ejemplos
- **Integración Continua**: Automatización completa con GitHub Actions

## Números Primos del 2 al 20

Los números primos en este rango son:
- 2, 3, 5, 7, 11, 13, 17, 19

## Uso Básico

```csharp
using Primes.Lib;

var primeService = new PrimeService();

// Verificar números primos
bool isPrime = primeService.IsPrime(7); // true
bool isNotPrime = primeService.IsPrime(4); // false
```

## Casos de Uso

### Verificación de Números Individuales
```csharp
var primeService = new PrimeService();

// Números primos
Assert.True(primeService.IsPrime(2));
Assert.True(primeService.IsPrime(3));
Assert.True(primeService.IsPrime(5));

// Números no primos
Assert.False(primeService.IsPrime(4));
Assert.False(primeService.IsPrime(6));
Assert.False(primeService.IsPrime(8));
```

### Validación de Entrada
```csharp
// Números menores que 2 no son primos
Assert.False(primeService.IsPrime(1));
Assert.False(primeService.IsPrime(0));
Assert.False(primeService.IsPrime(-1));
```

## API Reference

Para información detallada sobre la API, consulte la [Referencia de API](api/).

## Contribución

Este proyecto incluye:
- Pruebas unitarias completas
- Cobertura de código
- Documentación automática
- Integración continua

## Licencia

MIT License - ver el archivo LICENSE para más detalles. 