using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Web.Mvc.Components.Previews;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IFilePreviewCreatorRenderer
{
	Guid Uid { get; }

	Type CreatorType { get; }

	bool Render(HtmlHelper helper, BinaryFile file);

	string InitFunctionName(string uniquePrefix);

	string CloseFunctionName(string uniquePrefix);

	string CalcToolbarFunctionName(string uniquePrefix);
}
