using Primes.Lib;
using Xunit;

namespace Primes.Tests
{
    /// <summary>
    /// Clase de pruebas para el servicio de números primos.
    /// </summary>
    /// <remarks>
    /// Esta clase contiene todas las pruebas unitarias para verificar la funcionalidad
    /// del servicio de números primos, incluyendo casos límite y números del 2 al 20.
    /// </remarks>
    public class PrimeServiceTests
    {
        private readonly PrimeService _primeService;

        /// <summary>
        /// Inicializa una nueva instancia de la clase de pruebas.
        /// </summary>
        /// <remarks>
        /// Crea una instancia del servicio de números primos para ser utilizada en todas las pruebas.
        /// </remarks>
        public PrimeServiceTests()
        {
            _primeService = new PrimeService();
        }

        /// <summary>
        /// Verifica que el número 1 no sea considerado primo.
        /// </summary>
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);
            Assert.False(result, "1 should not be prime");
        }

        /// <summary>
        /// Verifica que los valores menores que 2 no sean considerados primos.
        /// </summary>
        /// <param name="value">El valor a probar.</param>
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.False(result, $"{value} should not be prime");
        }

        /// <summary>
        /// Verifica que los números primos del 2 al 20 sean identificados correctamente.
        /// </summary>
        /// <param name="value">El número primo a verificar.</param>
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(17)]
        [InlineData(19)]
        public void IsPrime_PrimeNumbersFrom2To20_ReturnTrue(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.True(result, $"{value} should be prime");
        }

        /// <summary>
        /// Verifica que los números no primos del 2 al 20 sean identificados correctamente.
        /// </summary>
        /// <param name="value">El número no primo a verificar.</param>
        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(12)]
        [InlineData(14)]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(18)]
        [InlineData(20)]
        public void IsPrime_NonPrimeNumbersFrom2To20_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.False(result, $"{value} should not be prime");
        }

        /// <summary>
        /// Verifica todos los números del 2 al 20 en una sola prueba.
        /// </summary>
        [Fact]
        public void IsPrime_AllNumbersFrom2To20_ReturnCorrectResults()
        {
            // Números primos del 2 al 20
            var primeNumbers = new[] { 2, 3, 5, 7, 11, 13, 17, 19 };
            
            // Números no primos del 2 al 20
            var nonPrimeNumbers = new[] { 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20 };

            // Verificar números primos
            foreach (var prime in primeNumbers)
            {
                var result = _primeService.IsPrime(prime);
                Assert.True(result, $"{prime} should be prime");
            }

            // Verificar números no primos
            foreach (var nonPrime in nonPrimeNumbers)
            {
                var result = _primeService.IsPrime(nonPrime);
                Assert.False(result, $"{nonPrime} should not be prime");
            }
        }
    }
} 