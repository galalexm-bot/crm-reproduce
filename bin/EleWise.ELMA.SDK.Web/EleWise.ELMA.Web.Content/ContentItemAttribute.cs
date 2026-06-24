using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Content;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class ContentItemAttribute : Attribute
{
	public string Name { get; set; }

	public string Description { get; set; }

	public string Image16 { get; set; }

	public string Image24 { get; set; }

	public string Image32 { get; set; }

	public bool Root { get; set; }

	public int Order { get; set; }

	public string Id { get; set; }

	public string Category { get; set; }

	public Type CurrentMatcher { get; set; }

	public Func<RequestContext, int> MatchCurrentDelegate
	{
		get
		{
			if (CurrentMatcher == null)
			{
				return null;
			}
			if (!(ComponentManager.Current.GetExtensionPointByType(CurrentMatcher) is IContentItemCurrentMatcher contentItemCurrentMatcher))
			{
				return null;
			}
			return contentItemCurrentMatcher.MatchCurrent;
		}
	}

	public string GetImage(ObjectIconFormat size = ObjectIconFormat.x16)
	{
		return ContentAction.ImageBySizeAccessor(() => Image16, () => Image24, () => Image32, size);
	}
}
