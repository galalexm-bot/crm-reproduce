using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Content.Portlets;

[Serializable]
public class GadgetPortletPersonalization : PortletPersonalization
{
	[Personalization(PersonalizationScope.User)]
	[Required(true)]
	[DisplayName("Url сервера ELMA")]
	public string ServerUrl { get; set; }

	public string GadgetPath { get; set; }

	public Guid GadgetPortletUid { get; set; }

	public Guid GadgetInstanceUid { get; set; }
}
