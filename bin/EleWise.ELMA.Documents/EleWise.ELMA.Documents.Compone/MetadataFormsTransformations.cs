using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class MetadataFormsTransformations : IMetadataFormsTransformations
{
	public void Transformate(EntityMetadata metadata)
	{
		if (metadata.FormsScheme != ClassFormsScheme.FormConstructor && metadata is DocumentMetadata metadata2)
		{
			Transformate(metadata2, ViewType.Display, delegate(ClassDefaultForms df, Guid u)
			{
				df.DisplayUid = u;
			}, new Guid("de8cf73d-aecb-48b2-85f5-42864d5ad8aa"));
			Transformate(metadata2, ViewType.Edit, delegate(ClassDefaultForms df, Guid u)
			{
				df.EditUid = u;
			}, new Guid("1fad0087-513e-4793-b836-a157e35dc131"));
			Transformate(metadata2, ViewType.Create, delegate(ClassDefaultForms df, Guid u)
			{
				df.CreateUid = u;
			}, new Guid("1ea63fc3-cf64-4235-9507-aa1ed6cb7ff9"));
			metadata.FormsScheme = ClassFormsScheme.FormConstructor;
		}
	}

	private void Transformate(DocumentMetadata metadata, ViewType viewType, Action<ClassDefaultForms, Guid> setDefaultForms, Guid defaultUid)
	{
		setDefaultForms(metadata.DefaultForms, defaultUid);
		FormViewItemTransformation transformation = DocumentFormViewTransformate.GetTransformation(metadata, viewType);
		if (transformation != null)
		{
			if (MetadataServiceContext.Service.GetMetadataList().OfType<DocumentMetadata>().Any((DocumentMetadata m) => m.Type == EntityMetadataType.Interface && m.BaseClassUid == metadata.Uid))
			{
				transformation.NewFormUid = Guid.NewGuid();
				transformation.NewFormName = viewType.ToString();
				transformation.NewFormDisplayName = SR.T("{0} ({1})", viewType.GetDisplayName(), metadata.DisplayName);
				setDefaultForms(metadata.DefaultForms, transformation.Uid);
			}
			metadata.FormTransformations.Add(transformation);
		}
	}
}
