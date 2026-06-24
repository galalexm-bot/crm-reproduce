using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using System;
using System.Text;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Extensions
{
    public static class RelationshipLinkExtension
    {
        public static MvcHtmlString NextRelationshipLink(
          this HtmlHelper htmlHelper,
          IRelationship nextRelationship)
        {
            if (nextRelationship == null)
                return MvcHtmlString.Empty;
            TagBuilder tagBuilder1 = new TagBuilder("a");
            tagBuilder1.MergeAttribute("href", htmlHelper.Url().Entity((IEntity)nextRelationship), true);
            tagBuilder1.SetInnerText(nextRelationship.StartDate.ToString("g"));
            StringBuilder stringBuilder = new StringBuilder();
            bool? completed = nextRelationship.Completed;
            if (completed.HasValue)
            {
                completed = nextRelationship.Completed;
                if (completed.Value)
                    stringBuilder.Append("text-decoration: line-through;");
            }
            if (nextRelationship.EndDate < (nextRelationship.DoneDate ?? DateTime.Now))
                stringBuilder.Append("color: Red;");
            tagBuilder1.MergeAttribute("style", stringBuilder.ToString(), true);
            TagBuilder tagBuilder2 = new TagBuilder("img");
            tagBuilder2.MergeAttribute("src", htmlHelper.Url().Action("Object", "Images", (object)new
            {
                area = "EleWise.ELMA.SDK.Web",
                id = nextRelationship.TypeUid
            }), true);
            return new MvcHtmlString(tagBuilder2.ToString(TagRenderMode.Normal) + "&nbsp;" + tagBuilder1.ToString(TagRenderMode.Normal));
        }
    }
}
