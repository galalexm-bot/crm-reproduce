using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Content.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterFavoriteMenuExtension
{
	bool HasMenuItemCode(string activeMenuItemCode);

	Guid GetFilterTreeTypeUid();

	Guid? GetFilterTreeCode();
}
