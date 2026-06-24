using System;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Components;

public class CRMSaleFormViewTransformate
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
			formViewItemTransformation.Uid = new Guid("8c723a7f-5e62-4f73-ba7e-c1f9e9ca3b06");
			FormView formView2 = metadata.FormViews.FirstOrDefault((FormView v) => v.ViewType == viewType && v.ViewInTab);
			if (formView != null && formView.UseRazorView)
			{
				formViewItemTransformation.Items.Add(ViewItemTransformation.Hide(new Guid("1e2a5108-f3d8-49f0-be72-5a3021e6a966")));
				PanelViewItem item2 = new PanelViewItem
				{
					Uid = new Guid("4DAF2093-8F0A-4112-BA15-AC763ECCB9E0"),
					CustomViewName = formView.RazorCommonViewName
				};
				formViewItemTransformation.Items.Add(ViewItemTransformation.Add(new Guid("7f9147a3-d23e-481c-bf5b-cbffab474d5d"), item2, null, new Guid("1e2a5108-f3d8-49f0-be72-5a3021e6a966")));
			}
			if (formView2 != null)
			{
				TabViewItem tabViewItem = new TabViewItem
				{
					Uid = new Guid("95193273-62E8-4440-A5F8-7F59B3201789"),
					Caption = (string.IsNullOrWhiteSpace(formView2.ViewInTabName) ? SR.T("Дополнительные поля") : SR.T(formView2.ViewInTabName)),
					Name = "additionalTab"
				};
				formViewItemTransformation.Items.Add(ViewItemTransformation.Add(new Guid("583a09f5-28e3-4d47-a375-dbc2290bf817"), tabViewItem, new Guid("810c59d7-4adb-40b9-a8d9-1646d35494ac"), new Guid("e826d1bb-c0e3-415f-b588-cd934e468b62")));
				if (formView2.UseRazorView)
				{
					PanelViewItem item3 = new PanelViewItem
					{
						Uid = new Guid("A1EDDE93-15ED-4444-BB6D-63F1E05097FE"),
						CustomViewName = formView2.RazorTabViewName
					};
					tabViewItem.Items.Add(item3);
					break;
				}
				tabViewItem.HideEmptySettings = HideEmptyEnum.HideEmpty;
				ColumnsLayoutViewItem columnsLayoutViewItem = new ColumnsLayoutViewItem
				{
					Uid = new Guid("6D22F143-25D3-478B-AB79-6056718996D3")
				};
				tabViewItem.Items.Add(columnsLayoutViewItem);
				columnsLayoutViewItem.Items.Add(new ColumnViewItem
				{
					Uid = new Guid("55B48E52-B3F7-4016-BDDC-94D366B74BD3")
				});
				columnsLayoutViewItem.Items.Add(new ColumnViewItem
				{
					Uid = new Guid("A0A94758-E77F-4B3C-AE53-B517FACEBAB1")
				});
				formViewItemTransformation.Items.Add(ViewItemTransformation.Move(columnsLayoutViewItem.Uid, new Guid("26a21740-0af0-40a0-8230-d9cbebe22f09")));
			}
			break;
		}
		case ViewType.Create:
		case ViewType.Edit:
			formViewItemTransformation.Uid = new Guid("c0a539e1-a9e8-4c62-bf4f-c695a52360a3");
			if (formView != null && formView.UseRazorView)
			{
				formViewItemTransformation.Items.Add(ViewItemTransformation.Hide(new Guid("efda70aa-cb35-4e62-a297-768b1c4bc920")));
				PanelViewItem item = new PanelViewItem
				{
					Uid = new Guid("A98D3FA0-6ACF-4CD5-9A95-79FDC15AD519"),
					CustomViewName = formView.RazorCommonViewName
				};
				formViewItemTransformation.Items.Add(ViewItemTransformation.Add(new Guid("1fcc367a-8a97-4e95-a5c0-c2b7e649b84d"), item, null, new Guid("efda70aa-cb35-4e62-a297-768b1c4bc920")));
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
