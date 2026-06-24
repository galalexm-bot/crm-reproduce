using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Actions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IContentDispatchActionProvider
{
	IEnumerable<IContentDispatchAction> GetActions(DispatchActionBuilder builder);
}
