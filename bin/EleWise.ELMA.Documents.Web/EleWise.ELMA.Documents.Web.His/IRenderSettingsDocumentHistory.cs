using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Documents.Web.History;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IRenderSettingsDocumentHistory
{
	bool CheckType(EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader);

	void Apply(EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader);
}
