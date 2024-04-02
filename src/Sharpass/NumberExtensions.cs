using System.Runtime.CompilerServices;

namespace Sharpass;

public static class NumberExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double ToPercent(this int number) => number / 100d;
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int RoundAwayFromZero(this double number) => (int)Math.Round(number, 2, MidpointRounding.AwayFromZero);
}