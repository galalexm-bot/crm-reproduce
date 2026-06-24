using EleWise.ELMA.Events;

namespace Orchard.ContentManagement.FieldStorage;

public interface IFieldStorageEvents : IEventHandler
{
	void SetCalled(FieldStorageEventContext context);
}
