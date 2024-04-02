namespace Sharpass;

public static class SpanExtensions
{
    public static Span<T> ToReadWriteSpan<T>(this ReadOnlySpan<T> readOnlySpan)
    {
        var readWriteSpan = new Span<T>(GC.AllocateUninitializedArray<T>(readOnlySpan.Length));
        readOnlySpan.CopyTo(readWriteSpan);

        return readWriteSpan;
    }
}