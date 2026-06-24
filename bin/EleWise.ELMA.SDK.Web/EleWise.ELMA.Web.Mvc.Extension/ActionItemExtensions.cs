using System.Text;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Extensions;

public static class ActionItemExtensions
{
	public static MvcHtmlString AdditionalJson(this ActionItem actionItem)
	{
		bool flag = false;
		StringBuilder stringBuilder = new StringBuilder();
		if (actionItem.Attributes != null)
		{
			stringBuilder.Append(actionItem.Attributes.ToJsonSlice());
			flag = !stringBuilder.ToString().IsNullOrEmpty();
		}
		if (flag)
		{
			stringBuilder.Append(",");
		}
		if (actionItem.CustomAttributes != null && actionItem.CustomAttributes.Count > 0)
		{
			stringBuilder.Append(actionItem.CustomAttributes.ToJsonSlice());
		}
		string text = stringBuilder.ToString();
		text = (text.IsNullOrEmpty() ? null : ("," + text));
		return MvcHtmlString.Create(text);
	}
}
