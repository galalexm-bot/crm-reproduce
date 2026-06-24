using EleWise.ELMA.Dynamic;
using EleWise.ELMA.Events.Audit;

namespace EleWise.ELMA.Notifications;

public interface IEventNotification : INotification, IExtendedPropertiesContainer
{
	string Event { get; }

	IAuditObject Object { get; }

	IAuditAction Action { get; }
}
