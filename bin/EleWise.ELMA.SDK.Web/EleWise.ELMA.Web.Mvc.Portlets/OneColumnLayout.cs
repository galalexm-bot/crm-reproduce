using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Web.Mvc.Portlets.Layouts;

[Component]
public class OneColumnLayout : IPortletLayout, IIdentified
{
	public static readonly Guid id = new Guid("534DCA7C-EF93-468C-A99A-E10FCF1DB6BB");

	private ZoneDescriptor[] _zones;

	public Guid Id => id;

	public string Name => SR.T("Одна колонка");

	public string ImagePreview => null;

	public string ConvertToCustomLayout => "0100";

	public string TemplatePath => "PortletLayouts/OneColumn";

	public ZoneDescriptor[] Zones
	{
		get
		{
			ZoneDescriptor[] array = _zones;
			if (array == null)
			{
				ZoneDescriptor[] obj = new ZoneDescriptor[1]
				{
					new ZoneDescriptor("Single", SR.T("Страница"))
				};
				ZoneDescriptor[] array2 = obj;
				_zones = obj;
				array = array2;
			}
			return array;
		}
	}

	public ZoneDescriptor SingleZone => Zones[0];

	public object GetId()
	{
		return Id;
	}

	public void SetId(object id)
	{
	}
}
