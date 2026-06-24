using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Web.Mvc.Portlets.Layouts;

[Component(Order = 30)]
public class CustomLayout : IPortletLayout, IIdentified
{
	public static readonly Guid id = new Guid("5EC69787-EB8F-4FF6-9B1B-8DFA1209985A");

	public Guid Id => id;

	public string Name => SR.T("Настраиваемое");

	public string ImagePreview => null;

	public string ConvertToCustomLayout => null;

	public string TemplatePath => "PortletLayouts/Custom";

	public ZoneDescriptor[] Zones => new ZoneDescriptor[0];

	public object GetId()
	{
		return Id;
	}

	public void SetId(object id)
	{
	}
}
