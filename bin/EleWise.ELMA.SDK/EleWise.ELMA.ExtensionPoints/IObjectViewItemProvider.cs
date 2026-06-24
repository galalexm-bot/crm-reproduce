using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface IObjectViewItemProvider
{
	Guid ProviderUid { get; }

	ViewItem GetViewItem(string viewItemId);
}
