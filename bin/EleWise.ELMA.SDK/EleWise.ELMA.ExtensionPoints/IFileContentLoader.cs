using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IFileContentLoader
{
	List<string> Extensions { get; }

	bool NeedHtmlClear { get; }

	string GetText(string fileName);
}
