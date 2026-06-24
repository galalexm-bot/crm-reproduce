using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Common.Components;

public class CatalogsFormViewTransformate
{
	public static FormViewItemTransformation GetTransformation(ClassMetadata metadata, FormViewItem formViewItem, ViewType viewType)
	{
		if (metadata.FormsScheme == ClassFormsScheme.FormConstructor)
		{
			return null;
		}
		FormView formView = metadata.FormViews.FirstOrDefault((FormView v) => v.ViewType == viewType && v.ViewInCommon);
		FormViewItemTransformation transformation = new FormViewItemTransformation
		{
			Uid = formViewItem.Uid
		};
		if (formView != null && formView.UseRazorView)
		{
			formViewItem.Items.Each(delegate(ViewItem i)
			{
				transformation.Items.Add(ViewItemTransformation.Hide(i.Uid));
			});
			PanelViewItem item = new PanelViewItem
			{
				CustomViewName = formView.RazorCommonViewName
			};
			transformation.Items.Add(ViewItemTransformation.Add(formViewItem.Uid, item));
		}
		if (!transformation.Items.Any())
		{
			return null;
		}
		return transformation;
	}
}
