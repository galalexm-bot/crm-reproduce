using System;
using System.Linq;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.Components;

public class DocumentFormViewTransformate
{
	private static readonly Guid WebDocumentUid = new Guid("07c1ed28-cf39-4c5e-a303-99a045c96558");

	private static bool IsWebDocument(DocumentMetadata metadata)
	{
		if (metadata != null)
		{
			if (!(metadata.Uid == WebDocumentUid) && !(metadata.ImplementationUid == WebDocumentUid))
			{
				return IsWebDocument(MetadataServiceContext.Service.GetMetadata(metadata.BaseClassUid) as DocumentMetadata);
			}
			return true;
		}
		return false;
	}

	public static FormViewItemTransformation GetTransformation(DocumentMetadata metadata, ViewType viewType)
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
			formViewItemTransformation.Uid = new Guid("de8cf73d-aecb-48b2-85f5-42864d5ad8aa");
			FormView formView2 = metadata.FormViews.FirstOrDefault((FormView v) => v.ViewType == viewType && v.ViewInTab);
			if (IsWebDocument(metadata))
			{
				string value = ((formView != null && formView.UseRazorView) ? formView.RazorCommonViewName : ((formView2 != null && formView2.UseRazorView) ? formView2.RazorTabViewName : null));
				if (formView2 != null && !string.IsNullOrWhiteSpace(formView2.ViewInTabName))
				{
					formViewItemTransformation.Items.Add(ViewItemTransformation<TabViewItem>.SetPropertyValue(new Guid("4d0caa53-20d5-416b-811d-1341601bb1d9"), (TabViewItem t) => t.Caption, formView2.ViewInTabName));
				}
				if (!string.IsNullOrWhiteSpace(value))
				{
					formViewItemTransformation.Items.Add(ViewItemTransformation.Hide(new Guid("b0db307e-b292-4031-8010-711fabd950fd")));
					PanelViewItem item2 = new PanelViewItem
					{
						Uid = new Guid("5CD2B13A-BDF6-4D97-B130-A61C2329DF0D"),
						CustomViewName = formView.RazorCommonViewName
					};
					formViewItemTransformation.Items.Add(ViewItemTransformation.Add(new Guid("b0db307e-b292-4031-8010-711fabd950fd"), item2, null, new Guid("b0db307e-b292-4031-8010-711fabd950fd")));
				}
				break;
			}
			if (formView != null && formView.UseRazorView)
			{
				formViewItemTransformation.Items.Add(ViewItemTransformation.Hide(new Guid("45dc9e07-44c3-49a3-8284-65ad98213c80")));
				PanelViewItem item3 = new PanelViewItem
				{
					Uid = new Guid("5CD2B13A-BDF6-4D97-B130-A61C2329DF0D"),
					CustomViewName = formView.RazorCommonViewName
				};
				formViewItemTransformation.Items.Add(ViewItemTransformation.Add(new Guid("4c7245fb-aeee-43c0-bd97-fd031ab8c47a"), item3, null, new Guid("45dc9e07-44c3-49a3-8284-65ad98213c80")));
			}
			if (formView2 != null)
			{
				TabViewItem tabViewItem = new TabViewItem
				{
					Uid = new Guid("D52E1FC7-9EEC-441B-B3F8-6F68456C4BF9"),
					Caption = (string.IsNullOrWhiteSpace(formView2.ViewInTabName) ? SR.T("Атрибуты документа") : SR.T(formView2.ViewInTabName)),
					Name = "additionalTab"
				};
				formViewItemTransformation.Items.Add(ViewItemTransformation.Add(new Guid("0497fc89-c9f0-430c-8409-50f333684d79"), tabViewItem, new Guid("6428a0b4-7572-4a5f-8bb1-cf018f9947b6"), new Guid("17381aff-d41d-4f78-84e7-2d5254a44266")));
				if (formView2.UseRazorView)
				{
					PanelViewItem item4 = new PanelViewItem
					{
						Uid = new Guid("CE6F3FD8-F8E3-4170-89EE-3764E7E7788B"),
						CustomViewName = formView2.RazorTabViewName
					};
					tabViewItem.Items.Add(item4);
					break;
				}
				tabViewItem.HideEmptySettings = HideEmptyEnum.HideEmpty;
				ColumnsLayoutViewItem columnsLayoutViewItem = new ColumnsLayoutViewItem
				{
					Uid = new Guid("1205124B-0FFC-47B0-B55A-07080B9A02E5")
				};
				tabViewItem.Items.Add(columnsLayoutViewItem);
				columnsLayoutViewItem.Items.Add(new ColumnViewItem
				{
					Uid = new Guid("97F48F9B-A67A-4D55-9330-546ED1F80FF3")
				});
				columnsLayoutViewItem.Items.Add(new ColumnViewItem
				{
					Uid = new Guid("677F5554-22FF-4347-B433-4D991AD1ECD6")
				});
				formViewItemTransformation.Items.Add(ViewItemTransformation.Move(columnsLayoutViewItem.Uid, new Guid("26a21740-0af0-40a0-8230-d9cbebe22f09")));
			}
			break;
		}
		case ViewType.Create:
		case ViewType.Edit:
			formViewItemTransformation.Uid = ((viewType == ViewType.Create) ? new Guid("1ea63fc3-cf64-4235-9507-aa1ed6cb7ff9") : new Guid("1fad0087-513e-4793-b836-a157e35dc131"));
			if (formView != null && formView.UseRazorView)
			{
				formViewItemTransformation.Items.Add(ViewItemTransformation.Hide(new Guid("1406815d-910d-4b41-86d8-f991cd2f8dd6")));
				PanelViewItem item = new PanelViewItem
				{
					Uid = new Guid("914802E1-50C1-4AAD-AA51-4D4EADA1A30F"),
					CustomViewName = formView.RazorCommonViewName
				};
				formViewItemTransformation.Items.Add(ViewItemTransformation.Add(new Guid("3f4bdcdb-723d-4469-a969-70b87d5ab321"), item, null, new Guid("1406815d-910d-4b41-86d8-f991cd2f8dd6")));
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
