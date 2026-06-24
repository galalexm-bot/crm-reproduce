using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Components;

[Component]
public class MetadataFormsTransformations : IMetadataFormsTransformations
{
	public void Transformate(EntityMetadata metadata)
	{
		if (metadata.FormsScheme != ClassFormsScheme.FormConstructor && metadata.Type == EntityMetadataType.InterfaceExtension)
		{
			if (metadata.BaseClassUid == new Guid("33a33299-1ca2-409a-84f6-901bf91203b6") || metadata.BaseClassUid == new Guid("75f5a13e-e2f5-4cd3-bfd4-f1aad7f6dd5f") || metadata.BaseClassUid == new Guid("71b18648-1490-47c0-b442-24c2038539f8"))
			{
				Transformate(metadata, CRMContractorFormViewTransformate.GetTransformation, new Guid("f03a2176-2c08-481a-b848-833da4e11f48"), new Guid("D6BD5615-1321-458F-BFD7-5A53486869BE"), new Guid("E7671669-A2A4-49A7-8495-00B130617E61"));
			}
			if (metadata.BaseClassUid == new Guid("d722eb1b-2583-48e6-ace0-e9417b027804"))
			{
				Transformate(metadata, CRMSaleFormViewTransformate.GetTransformation, new Guid("c0a539e1-a9e8-4c62-bf4f-c695a52360a3"), new Guid("1EB0A4E9-826E-47F4-A01C-E221B06AE759"), new Guid("63CB3875-059A-4A49-88C1-85942E893B8C"));
			}
		}
	}

	private void Transformate(EntityMetadata metadata, Func<EntityMetadata, ViewType, FormViewItemTransformation> getTransformation, Guid formUid, Guid createFormUid, Guid editFormUid)
	{
		FormViewItemTransformation formViewItemTransformation = getTransformation(metadata, ViewType.Display);
		if (formViewItemTransformation != null)
		{
			metadata.FormTransformations.Add(formViewItemTransformation);
		}
		FormView formView = metadata.FormViews.FirstOrDefault((FormView v) => v.ViewType == ViewType.Create && v.ViewInCommon);
		FormView formView2 = metadata.FormViews.FirstOrDefault((FormView v) => v.ViewType == ViewType.Edit && v.ViewInCommon);
		if ((formView?.UseRazorView ?? false) == (formView2?.UseRazorView ?? false) && ((formView != null && formView.UseRazorView) ? formView.RazorCommonViewName : null) == ((formView2 != null && formView2.UseRazorView) ? formView2.RazorCommonViewName : null))
		{
			formViewItemTransformation = getTransformation(metadata, ViewType.Edit);
			if (formViewItemTransformation != null)
			{
				metadata.FormTransformations.Add(formViewItemTransformation);
			}
		}
		else
		{
			FormViewItemTransformation formViewItemTransformation2 = getTransformation(metadata, ViewType.Create) ?? new FormViewItemTransformation
			{
				Uid = formUid
			};
			FormViewItemTransformation formViewItemTransformation3 = getTransformation(metadata, ViewType.Edit) ?? new FormViewItemTransformation
			{
				Uid = formUid
			};
			formViewItemTransformation2.NewFormUid = createFormUid;
			formViewItemTransformation2.NewFormName = ViewType.Create.ToString();
			formViewItemTransformation2.NewFormDisplayName = ViewType.Create.GetDisplayName();
			formViewItemTransformation3.NewFormUid = editFormUid;
			formViewItemTransformation3.NewFormName = ViewType.Edit.ToString();
			formViewItemTransformation3.NewFormDisplayName = ViewType.Edit.GetDisplayName();
			metadata.FormTransformations.Add(formViewItemTransformation2);
			metadata.FormTransformations.Add(formViewItemTransformation3);
			metadata.DefaultForms.CreateUid = formViewItemTransformation2.NewFormUid;
			metadata.DefaultForms.EditUid = formViewItemTransformation3.NewFormUid;
		}
		metadata.FormsScheme = ClassFormsScheme.FormConstructor;
	}
}
