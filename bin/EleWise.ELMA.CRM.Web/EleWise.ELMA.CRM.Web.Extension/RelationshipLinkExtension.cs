using System;
using System.Text;
using System.Web.Mvc;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.CRM.Web.Extensions;

public static class RelationshipLinkExtension
{
	public static MvcHtmlString NextRelationshipLink(this HtmlHelper htmlHelper, IRelationship nextRelationship)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		if (nextRelationship == null)
		{
			return MvcHtmlString.Empty;
		}
		TagBuilder val = new TagBuilder("a");
		val.MergeAttribute("href", htmlHelper.Url().Entity(nextRelationship), true);
		val.SetInnerText(nextRelationship.StartDate.ToString("g"));
		StringBuilder stringBuilder = new StringBuilder();
		if (nextRelationship.Completed.HasValue && nextRelationship.Completed.Value)
		{
			stringBuilder.Append("text-decoration: line-through;");
		}
		if (nextRelationship.EndDate < (nextRelationship.DoneDate ?? DateTime.Now))
		{
			stringBuilder.Append("color: Red;");
		}
		val.MergeAttribute("style", stringBuilder.ToString(), true);
		TagBuilder val2 = new TagBuilder("img");
		val2.MergeAttribute("src", htmlHelper.Url().Action("Object", "Images", (object)new
		{
			area = "EleWise.ELMA.SDK.Web",
			id = nextRelationship.TypeUid
		}), true);
		return new MvcHtmlString(val2.ToString((TagRenderMode)0) + "&nbsp;" + val.ToString((TagRenderMode)0));
	}
}
