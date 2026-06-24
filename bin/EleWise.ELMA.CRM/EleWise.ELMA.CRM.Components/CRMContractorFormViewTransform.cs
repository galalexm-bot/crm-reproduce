using System;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Components;

public class CRMContractorFormViewTransformate
{
	public static FormViewItemTransformation GetTransformation(EntityMetadata metadata, ViewType viewType)
	{
		if (metadata.FormsScheme == ClassFormsScheme.FormConstructor)
		{
			return null;
		}
		FormView formView = metadata.FormViews.FirstOrDefault((FormView v) => v.ViewType == viewType && v.ViewInCommon);
		FormViewItemTransformation formViewItemTransformation = new FormViewItemTransformation();
		switch (viewType)
		{
		case ViewType.Display:
		{
			formViewItemTransformation.Uid = new Guid("43452920-ec84-4f11-b3c2-4efaeb99540c");
			FormView formView2 = metadata.FormViews.FirstOrDefault((FormView v) => v.ViewType == viewType && v.ViewInTab);
			if (formView != null && formView.UseRazorView)
			{
				formViewItemTransformation.Items.Add(ViewItemTransformation.Hide(new Guid("39478481-49fe-40d3-bb0b-1b370be14ef9")));
				PanelViewItem item2 = new PanelViewItem
				{
					Uid = new Guid("FFA44650-9B42-4329-B9B0-1061915553D4"),
					CustomViewName = formView.RazorCommonViewName
				};
				formViewItemTransformation.Items.Add(ViewItemTransformation.Add(new Guid("a6d7d9a9-1000-4063-b968-898c2f703cd3"), item2, null, new Guid("39478481-49fe-40d3-bb0b-1b370be14ef9")));
			}
			if (formView2 != null)
			{
				TabViewItem tabViewItem = new TabViewItem
				{
					Uid = new Guid("DFC18A34-4805-4167-83EC-5791283A949E"),
					Caption = (string.IsNullOrWhiteSpace(formView2.ViewInTabName) ? SR.T("Дополнительные поля") : SR.T(formView2.ViewInTabName)),
					Name = "additionalTab"
				};
				formViewItemTransformation.Items.Add(ViewItemTransformation.Add(new Guid("bf6e8266-403d-4559-b136-a62e3256fa4d"), tabViewItem, new Guid("a6d7d9a9-1000-4063-b968-898c2f703cd3"), new Guid("66912dcb-adc4-4318-8f0e-09c31017e5ff")));
				if (formView2.UseRazorView)
				{
					PanelViewItem item3 = new PanelViewItem
					{
						Uid = new Guid("DF1BBBDA-4587-4962-B71A-C9F939B47A84"),
						CustomViewName = formView2.RazorTabViewName
					};
					tabViewItem.Items.Add(item3);
					break;
				}
				tabViewItem.HideEmptySettings = HideEmptyEnum.HideEmpty;
				ColumnsLayoutViewItem columnsLayoutViewItem = new ColumnsLayoutViewItem
				{
					Uid = new Guid("AA6B18F3-D8BE-44A2-9987-66915812F216")
				};
				tabViewItem.Items.Add(columnsLayoutViewItem);
				columnsLayoutViewItem.Items.Add(new ColumnViewItem
				{
					Uid = new Guid("FE67043B-D9D5-45AB-AC3D-016D019A897F")
				});
				columnsLayoutViewItem.Items.Add(new ColumnViewItem
				{
					Uid = new Guid("83F3B659-E6BE-4450-B068-49564976E75E")
				});
				formViewItemTransformation.Items.Add(ViewItemTransformation.Move(columnsLayoutViewItem.Uid, new Guid("26a21740-0af0-40a0-8230-d9cbebe22f09")));
			}
			break;
		}
		case ViewType.Create:
		case ViewType.Edit:
			formViewItemTransformation.Uid = new Guid("f03a2176-2c08-481a-b848-833da4e11f48");
			if (formView != null && formView.UseRazorView)
			{
				formViewItemTransformation.Items.Add(ViewItemTransformation.Hide(new Guid("95c632fb-a0ab-4e0d-98d4-36e94bb3e7b2")));
				PanelViewItem item = new PanelViewItem
				{
					Uid = new Guid("01CDF63D-1321-45AE-9DA1-250D4D959FC6"),
					CustomViewName = formView.RazorCommonViewName
				};
				formViewItemTransformation.Items.Add(ViewItemTransformation.Add(new Guid("2ed5fceb-4324-4963-800f-ea64347b8c73"), item, null, new Guid("95c632fb-a0ab-4e0d-98d4-36e94bb3e7b2")));
			}
			break;
		}
		if (!formViewItemTransformation.Items.Any())
		{
			return null;
		}
		return formViewItemTransformation;
	}
}
