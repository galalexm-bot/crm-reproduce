using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Web.Mvc.Portlets.Layouts;

[Component]
public class TwoColumn5050Layout : IPortletLayout, IIdentified
{
	private readonly Guid id = new Guid("CC43207E-0BB0-474A-84C4-A851ABAE1E70");

	private ZoneDescriptor[] _zones;

	public Guid Id => id;

	public string Name => SR.T("Две колонки");

	public string ImagePreview => null;

	public string ConvertToCustomLayout => "5050";

	public string TemplatePath => "PortletLayouts/TwoColumn5050";

	public ZoneDescriptor[] Zones
	{
		get
		{
			ZoneDescriptor[] array = _zones;
			if (array == null)
			{
				ZoneDescriptor[] obj = new ZoneDescriptor[2]
				{
					new ZoneDescriptor("Left", SR.T("Левая колонка")),
					new ZoneDescriptor("Right", SR.T("Правая колонка"))
				};
				ZoneDescriptor[] array2 = obj;
				_zones = obj;
				array = array2;
			}
			return array;
		}
	}

	public ZoneDescriptor LeftZone => Zones[0];

	public ZoneDescriptor RightZone => Zones[1];

	public object GetId()
	{
		return Id;
	}

	public void SetId(object id)
	{
	}
}
