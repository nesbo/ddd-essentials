namespace Pikot.DDD.Ports;

/// <summary>
/// Current date and time provider
/// </summary>
public interface IClock
{
    DateTime UtcNow { get; }
    DateTime Now { get; }
    DateTimeOffset NowWithOffset { get; }
}