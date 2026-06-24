using System;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Components;

public class CRMContactFormViewTransformate
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
			formViewItemTransformation.Uid = new Guid("31ec86ee-5424-4c1a-a5ba-21a6fb29ca53");
			FormView formView2 = metadata.FormViews.FirstOrDefault((FormView v) => v.ViewType == viewType && v.ViewInTab);
			if (formView != null && formView.UseRazorView)
			{
				formViewItemTransformation.Items.Add(ViewItemTransformation.Hide(new Guid("8d1a65d5-b548-45a3-918f-b1db5634d365")));
				PanelViewItem item2 = new PanelViewItem
				{
					Uid = new Guid("913DB55D-457B-4DBE-A0A9-6E5BA0FEDCAB"),
					CustomViewName = formView.RazorCommonViewName
				};
				formViewItemTransformation.Items.Add(ViewItemTransformation.Add(new Guid("08f3242f-af27-41ca-b469-98a1aa484b22"), item2, null, new Guid("8d1a65d5-b548-45a3-918f-b1db5634d365")));
			}
			if (formView2 != null)
			{
				TabViewItem tabViewItem = new TabViewItem
				{
					Uid = new Guid("13994150-46CB-4468-AE1D-2BC9B5E8FD97"),
					Caption = (string.IsNullOrWhiteSpace(formView2.ViewInTabName) ? SR.T("Дополнительные поля") : SR.T(formView2.ViewInTabName)),
					Name = "additionalTab"
				};
				formViewItemTransformation.Items.Add(ViewItemTransformation.Add(new Guid("69a7629a-5b49-46d7-af60-7dd8b35d7029"), tabViewItem, new Guid("08f3242f-af27-41ca-b469-98a1aa484b22"), new Guid("d2d94b4c-fc12-4532-a477-04613b2913af")));
				if (formView2.UseRazorView)
				{
					PanelViewItem item3 = new PanelViewItem
					{
						Uid = new Guid("11DA186D-B9AA-4C1D-8083-E425667450CC"),
						CustomViewName = formView2.RazorTabViewName
					};
					tabViewItem.Items.Add(item3);
					break;
				}
				tabViewItem.HideEmptySettings = HideEmptyEnum.HideEmpty;
				ColumnsLayoutViewItem columnsLayoutViewItem = new ColumnsLayoutViewItem
				{
					Uid = new Guid("C43126BD-C58E-49CF-B688-13EA2DE420E0")
				};
				tabViewItem.Items.Add(columnsLayoutViewItem);
				columnsLayoutViewItem.Items.Add(new ColumnViewItem
				{
					Uid = new Guid("85F3C34E-8F8B-484D-BDFA-F1AF5E62161F")
				});
				columnsLayoutViewItem.Items.Add(new ColumnViewItem
				{
					Uid = new Guid("053C8E14-C498-4CAC-A81C-6F647DFB20EA")
				});
				formViewItemTransformation.Items.Add(ViewItemTransformation.Move(columnsLayoutViewItem.Uid, new Guid("26a21740-0af0-40a0-8230-d9cbebe22f09")));
			}
			break;
		}
		case ViewType.Create:
		case ViewType.Edit:
			formViewItemTransformation.Uid = new Guid("31242876-96ab-4479-95ef-636ffff95f1c");
			if (formView != null && formView.UseRazorView)
			{
				formViewItemTransformation.Items.Add(ViewItemTransformation.Hide(new Guid("3cea8bdc-9f6a-4f2a-860d-e62c0d5b47bb")));
				PanelViewItem item = new PanelViewItem
				{
					Uid = new Guid("29421438-047A-4FB4-95F8-6B46660328E3"),
					CustomViewName = formView.RazorCommonViewName
				};
				formViewItemTransformation.Items.Add(ViewItemTransformation.Add(new Guid("6442e31a-feeb-482c-af66-ece9f732f629"), item, null, new Guid("3cea8bdc-9f6a-4f2a-860d-e62c0d5b47bb")));
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
