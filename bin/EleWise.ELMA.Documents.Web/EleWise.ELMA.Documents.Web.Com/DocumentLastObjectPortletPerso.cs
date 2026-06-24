using System;
using EleWise.ELMA.BPM.Web.Common.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class DocumentLastObjectPortletPersonalizationConverter : PortletPersonalizationOldConverterExtensions
{
	public override Type OldSettingsType => typeof(LastObjectPortletPersonalization);

	public override Type NewSettingsType => typeof(LastObjectPortletPersonalization);

	public override void Update(PortletPersonalization personalization)
	{
		DocumentDefaultHomePagePortlet.UpdateSettings(personalization);
	}
}
