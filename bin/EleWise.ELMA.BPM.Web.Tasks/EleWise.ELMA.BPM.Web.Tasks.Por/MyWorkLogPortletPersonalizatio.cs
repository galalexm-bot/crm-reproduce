using System;
using System.ComponentModel;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Tasks.Portlets;

[Serializable]
public class MyWorkLogPortletPersonalization : PortletPersonalization
{
	[Personalization(PersonalizationScope.User)]
	[Category("Режим отображения портлета")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(MyWorkLogPortletPersonalization_SR), "P_Mode")]
	public WorkLogSummaryTableMode Mode { get; set; }
}
internal static class MyWorkLogPortletPersonalization_SR
{
	public static string P_Mode => SR.T("Режим отображения портлета");
}
