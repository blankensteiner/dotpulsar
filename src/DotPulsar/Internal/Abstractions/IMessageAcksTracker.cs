namespace DotPulsar.Internal.Abstractions
{
    using DotPulsar.Abstractions;
    using System.Threading;
    using System.Threading.Tasks;
    public interface IMessageAcksTracker<T>
    {
        T Add(T message);
        T Ack(T message);
        T Nack(T message);
        Task StartTracker(IConsumer consumer, CancellationToken cancellationToken);
    }
}