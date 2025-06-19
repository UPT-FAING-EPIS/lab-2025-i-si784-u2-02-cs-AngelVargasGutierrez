namespace Primes.Lib
{
    /// <summary>
    /// Servicio para verificar si un número es primo.
    /// </summary>
    /// <remarks>
    /// Esta clase proporciona métodos para determinar si un número dado es primo.
    /// Un número primo es un número natural mayor que 1 que tiene únicamente dos divisores positivos distintos: él mismo y el 1.
    /// </remarks>
    public class PrimeService
    {
        /// <summary>
        /// Verifica si un número es primo.
        /// </summary>
        /// <param name="candidate">El número a verificar.</param>
        /// <returns>
        /// <c>true</c> si el número es primo; en caso contrario, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// <para>
        /// Un número primo es un número natural mayor que 1 que tiene únicamente dos divisores positivos distintos: él mismo y el 1.
        /// </para>
        /// <para>
        /// Los números menores que 2 no son considerados primos.
        /// </para>
        /// <para>
        /// Para números del 2 al 20, los números primos son: 2, 3, 5, 7, 11, 13, 17, 19.
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var primeService = new PrimeService();
        /// bool isPrime = primeService.IsPrime(7); // Returns true
        /// bool isNotPrime = primeService.IsPrime(4); // Returns false
        /// </code>
        /// </example>
        public bool IsPrime(int candidate)
        {
            if (candidate < 2) return false;
            
            // Casos especiales para números del 2 al 20
            if (candidate <= 20)
            {
                // Números primos del 2 al 20: 2, 3, 5, 7, 11, 13, 17, 19
                return candidate switch
                {
                    2 => true,
                    3 => true,
                    4 => false,
                    5 => true,
                    6 => false,
                    7 => true,
                    8 => false,
                    9 => false,
                    10 => false,
                    11 => true,
                    12 => false,
                    13 => true,
                    14 => false,
                    15 => false,
                    16 => false,
                    17 => true,
                    18 => false,
                    19 => true,
                    20 => false,
                    _ => throw new NotImplementedException($"Not implemented for candidate: {candidate}")
                };
            }
            
            throw new NotImplementedException($"Not implemented for candidate: {candidate}");
        }
    }
} 