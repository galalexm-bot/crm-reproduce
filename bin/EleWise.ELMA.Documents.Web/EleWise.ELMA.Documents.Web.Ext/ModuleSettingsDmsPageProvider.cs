using System.Web.Mvc;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Documents.Web.Extensions;

public abstract class ModuleSettingsDmsPageProvider : IModuleSettingsDmsPageProvider, IModuleSettingsPageProvider
{
	public abstract string ModuleUid { get; }

	public abstract string Image { get; }

	public abstract string Text { get; }

	public abstract string Description { get; }

	public virtual string Category => string.Empty;

	public abstract string Url(UrlHelper urlHelper);
}
