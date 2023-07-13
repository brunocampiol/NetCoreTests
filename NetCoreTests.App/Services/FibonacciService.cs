namespace NetCoreTests.App.Services
{
    public static class FibonacciService
    {
        // Fibonacci sequence is as follows:
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144.

        public static int NthFibonacciNumber(int nth)
        {
            if ((nth == 0) || (nth == 1)) return nth;
            return (NthFibonacciNumber(nth - 1) + NthFibonacciNumber(nth - 2));
        }
    }
}
