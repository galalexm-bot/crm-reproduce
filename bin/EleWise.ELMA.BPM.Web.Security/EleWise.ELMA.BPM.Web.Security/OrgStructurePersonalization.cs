using System;
using System.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Security.Portlets;

[Serializable]
public class OrgStructurePersonalization : PortletPersonalization
{
	[Personalization(PersonalizationScope.User)]
	[DefaultValue(true)]
	[Category("Отображение дерева")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_OrgStructurePersonalization), "P_ShowUsers")]
	public virtual bool ShowUsers { get; set; }
}
