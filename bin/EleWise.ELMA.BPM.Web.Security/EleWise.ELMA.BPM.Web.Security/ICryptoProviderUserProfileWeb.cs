using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
internal interface ICryptoProviderUserProfileWeb
{
	Guid ProviderUid { get; }

	Type ModelType { get; }

	MvcHtmlString RenderEdit(HtmlHelper htmlHelper, IUser user);

	void Save(object model);
}
