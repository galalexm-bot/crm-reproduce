using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Integration.Views;

[Component(Order = 90)]
internal class RelationshipMeetingFormCreator : FormCreator
{
	public override bool CheckType(Type type)
	{
		if (type == null)
		{
			return false;
		}
		if (typeof(IRelationshipMeeting).IsAssignableFrom(type))
		{
			return base.CheckType(type);
		}
		return false;
	}

	public override string OnSubmitScript(HtmlHelper html, string prefix)
	{
		return string.Format("{0}('Form{1}','{1}'); return false;", html.get_ViewData().get_TemplateInfo().GetFullHtmlFieldId("checkEventTimePeriodMeeting"), prefix);
	}
}
