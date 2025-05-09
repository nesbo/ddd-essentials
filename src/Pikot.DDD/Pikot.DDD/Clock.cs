namespace Pikot.DDD;

/// <summary>
/// Default implementation of the CURRENT date time provider.
/// </summary>
internal class Clock : IClock
{
    public DateTime UtcNow => DateTime.UtcNow;
    public DateTime Now => DateTime.Now;
    public DateTimeOffset NowWithOffset => DateTimeOffset.Now;
}