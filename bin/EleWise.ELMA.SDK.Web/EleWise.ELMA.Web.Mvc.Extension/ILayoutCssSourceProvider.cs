using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[Obsolete("Рекоммендуется использовать точку расширения ILayoutLessSourceProvider")]
[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface ILayoutCssSourceProvider
{
	string[] CssSources { get; }
}
