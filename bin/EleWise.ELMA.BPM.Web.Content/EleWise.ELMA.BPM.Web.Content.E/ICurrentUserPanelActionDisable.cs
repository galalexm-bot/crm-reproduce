using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.Content.Models;

namespace EleWise.ELMA.BPM.Web.Content.ExtensionPoints;

public interface ICurrentUserPanelActionDisable : ICurrentUserPanelAction
{
	string PropertyName { get; }

	bool IsEnabled(IWorkPlace workPlace);
}
