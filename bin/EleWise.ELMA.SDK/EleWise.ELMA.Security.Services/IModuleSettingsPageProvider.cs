using System.Web.Mvc;

namespace EleWise.ELMA.Security.Services;

public interface IModuleSettingsPageProvider
{
	string ModuleUid { get; }

	string Image { get; }

	string Text { get; }

	string Description { get; }

	string Url(UrlHelper urlHelper);
}
