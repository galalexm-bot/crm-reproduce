using System;
using System.ComponentModel;
using System.Web.Mvc;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Content.Portlets;

[Serializable]
public class CustomMarkupPortletPersonalization : PortletPersonalization
{
	[Personalization(PersonalizationScope.Shared)]
	[Category("Код")]
	[EleWise.ELMA.Model.Attributes.DisplayName("Разметка")]
	[HiddenInput(DisplayValue = false)]
	public string MarkupText { get; set; }
}
