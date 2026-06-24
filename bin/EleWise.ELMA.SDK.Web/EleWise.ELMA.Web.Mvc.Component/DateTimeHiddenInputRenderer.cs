using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class DateTimeHiddenInputRenderer : IHiddenInputRenderer
{
	public bool CanRender(HtmlHelper html, string expression, object value, IDictionary<string, object> additionalData = null)
	{
		return value is DateTime;
	}

	public MvcHtmlString Hidden(HtmlHelper html, string expression, object value, IDictionary<string, object> additionalData = null)
	{
		DateTime? dateTime = value as DateTime?;
		if (dateTime.HasValue)
		{
			TZSettings tZSettings = TZ.Client;
			if (additionalData != null && additionalData.ContainsKey("TZ"))
			{
				try
				{
					tZSettings = ((TZSettings)additionalData["TZ"]) ?? TZ.Client;
				}
				catch (Exception)
				{
					throw new Exception("Invalid time zone transformation settings. Set setting by TZ class.");
				}
			}
			dateTime = dateTime.Value.ToClientDateTime(tZSettings);
			MvcHtmlString obj = InputExtensions.Hidden(html, expression, (object)dateTime);
			string text = string.Empty;
			if (tZSettings.Type != 0)
			{
				text = ((HtmlString)(object)InputExtensions.Hidden(html, expression + ".TZ", (object)tZSettings.Offset)).ToHtmlString();
			}
			return MvcHtmlString.Create(((HtmlString)(object)obj).ToHtmlString() + text);
		}
		return InputExtensions.Hidden(html, expression, value);
	}
}
