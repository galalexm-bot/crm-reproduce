using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Content.Transformation;

public class WorkplacePagesContainer : IPageTransformationContainer
{
	public static Guid VisibleListUid = new Guid("{8E4C925B-7D23-4F4D-896F-0A2D51C78B15}");

	public static Guid HiddenListUid = new Guid("{9E3E45C3-A7E5-4510-8C04-1B01604B94A0}");

	public Guid Uid { get; set; }

	public List<IPageTransformationContainer> Items { get; set; }

	public static WorkplacePagesContainer Pack(ICollection<IHomePageSetting> pages)
	{
		return new WorkplacePagesContainer
		{
			Uid = Guid.Empty,
			Items = new List<IPageTransformationContainer>
			{
				new WorkplacePagesContainer
				{
					Uid = VisibleListUid,
					Items = GetItems(pages, visible: true)
				},
				new WorkplacePagesContainer
				{
					Uid = HiddenListUid,
					Items = GetItems(pages, visible: false)
				}
			}
		};
	}

	public static List<IHomePageSetting> Unpack(WorkplacePagesContainer container)
	{
		List<IHomePageSetting> list = new List<IHomePageSetting>();
		WorkplacePagesContainer workplacePagesContainer = (WorkplacePagesContainer)container.Items[0];
		WorkplacePagesContainer workplacePagesContainer2 = (WorkplacePagesContainer)container.Items[1];
		for (int i = 0; i < workplacePagesContainer.Items.Count; i++)
		{
			IPageTransformationContainer item = workplacePagesContainer.Items[i].CastAsRealType();
			list.Add(CreateSettings(item, i, visible: true));
		}
		for (int j = 0; j < workplacePagesContainer2.Items.Count; j++)
		{
			IPageTransformationContainer item2 = workplacePagesContainer2.Items[j].CastAsRealType();
			list.Add(CreateSettings(item2, j, visible: false));
		}
		return list;
	}

	private static List<IPageTransformationContainer> GetItems(ICollection<IHomePageSetting> pages, bool visible)
	{
		return (from p in pages
			where (!(p.Page != null && visible)) ? (!p.Visible) : p.Visible
			orderby p.Order
			select new PageV2TransformationContainer
			{
				Page = p.Page.CastAsRealType(),
				Parameters = p.Parameters
			}).Cast<IPageTransformationContainer>().ToList();
	}

	private static IHomePageSetting CreateSettings(IPageTransformationContainer item, int order, bool visible)
	{
		IPortalObject page;
		string parameters;
		if (item is PageV2TransformationContainer pageV2TransformationContainer)
		{
			page = pageV2TransformationContainer.Page;
			parameters = pageV2TransformationContainer.Parameters;
		}
		else
		{
			page = (IPortalObject)item;
			parameters = string.Empty;
		}
		InstanceOf<IHomePageSetting> instanceOf = new InstanceOf<IHomePageSetting>();
		instanceOf.New.Uid = Guid.Empty;
		instanceOf.New.Page = page;
		instanceOf.New.Visible = visible;
		instanceOf.New.Order = order;
		instanceOf.New.Parameters = parameters;
		return instanceOf.New;
	}
}
