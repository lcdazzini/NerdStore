using EventStore.ClientAPI;

namespace NerdStore.Core.Data.EventSourcing
{
	public interface IEventStoreService
    {
        IEventStoreConnection GetConnection();
    }
}