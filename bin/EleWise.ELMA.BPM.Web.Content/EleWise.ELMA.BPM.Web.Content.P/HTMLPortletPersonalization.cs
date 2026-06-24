using System;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Content.Portlets;

[Serializable]
public class HTMLPortletPersonalization : PortletPersonalization
{
	[Personalization(PersonalizationScope.Shared)]
	[HiddenInput(DisplayValue = false)]
	public string Text { get; set; }

	public HtmlString HtmlText
	{
		get
		{
			return new HtmlString(Text ?? "");
		}
		set
		{
			Text = ((value != null) ? value.ToString() : "");
		}
	}
}
