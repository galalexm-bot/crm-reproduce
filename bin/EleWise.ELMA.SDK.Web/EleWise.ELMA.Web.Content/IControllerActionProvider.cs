using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Content;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IControllerActionProvider
{
	[Obsolete("Нужно использовать SR.M при присваивании названий в менюшках")]
	List<string> LocalizedItemsNames { get; }

	[Obsolete("Нужно использовать SR.M при присваивании описаний в менюшках")]
	List<string> LocalizedItemsDescriptions { get; }

	IEnumerable<IContentAction> Actions();

	IEnumerable<IContentCategory> Categories();
}
