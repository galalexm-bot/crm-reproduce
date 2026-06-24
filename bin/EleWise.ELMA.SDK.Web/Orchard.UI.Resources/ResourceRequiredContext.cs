using System.Web.Mvc;

namespace Orchard.UI.Resources;

public class ResourceRequiredContext
{
	public ResourceDefinition Resource { get; set; }

	public RequireSettings Settings { get; set; }

	public string GetResourceUrl(RequireSettings baseSettings, string appPath, bool ssl)
	{
		return Resource.ResolveUrl((baseSettings == null) ? Settings : baseSettings.Combine(Settings), appPath, ssl);
	}

	public TagBuilder GetTagBuilder(RequireSettings baseSettings, string appPath)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		TagBuilder val = new TagBuilder(Resource.TagName);
		val.MergeAttributes<string, string>(Resource.TagBuilder.get_Attributes());
		if (!string.IsNullOrEmpty(Resource.FilePathAttributeName))
		{
			string resourceUrl = GetResourceUrl(baseSettings, appPath, ssl: false);
			if (!string.IsNullOrEmpty(resourceUrl))
			{
				val.MergeAttribute(Resource.FilePathAttributeName, resourceUrl, true);
			}
		}
		return val;
	}
}
