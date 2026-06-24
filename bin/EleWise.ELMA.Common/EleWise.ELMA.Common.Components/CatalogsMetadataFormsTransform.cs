using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.Common.Components;

[Component(Order = 1000000)]
public class CatalogsMetadataFormsTransformations : IMetadataFormsTransformations
{
	public void Transformate(EntityMetadata metadata)
	{
		if (metadata.FormsScheme != ClassFormsScheme.FormConstructor && metadata.Type != EntityMetadataType.InterfaceExtension)
		{
			bool flag = Transformate(metadata, ViewType.Display, delegate(ClassDefaultForms df, Guid u)
			{
				df.DisplayUid = u;
			});
			flag = Transformate(metadata, ViewType.Edit, delegate(ClassDefaultForms df, Guid u)
			{
				df.EditUid = u;
			}) || flag;
			if (Transformate(metadata, ViewType.Create, delegate(ClassDefaultForms df, Guid u)
			{
				df.CreateUid = u;
			}) || flag)
			{
				metadata.FormsScheme = ClassFormsScheme.FormConstructor;
			}
		}
	}

	private bool Transformate(EntityMetadata metadata, ViewType viewType, Action<ClassDefaultForms, Guid> setDefaultForms)
	{
		FormViewItem form = metadata.DefaultForms.GetForm(viewType) ?? new FormViewItemBuilder(metadata.Uid, viewType).DisplayName(viewType.GetDisplayName()).Name(viewType.ToString()).DefaultContainer()
			.FormView;
		FormViewItemTransformation transformation = CatalogsFormViewTransformate.GetTransformation(metadata, form, viewType);
		if (transformation == null)
		{
			return false;
		}
		form = form.Transformate(transformation);
		int num = metadata.Forms.FindIndex((FormViewItem f) => f.Uid == form.Uid);
		if (num >= 0)
		{
			metadata.Forms[num] = form;
		}
		else
		{
			metadata.Forms.Add(form);
			setDefaultForms(metadata.DefaultForms, form.Uid);
		}
		FormView formView = metadata.FormViews.FirstOrDefault((FormView v) => v.ViewType == viewType && v.ViewInCommon);
		formView.UseRazorView = false;
		formView.RazorCommonViewName = null;
		return true;
	}
}
