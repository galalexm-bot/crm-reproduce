using System;
using System.Web.Mvc;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Types;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Web.Mvc.Inputs;

namespace EleWise.ELMA.Documents.Web.Inputs;

public class DocumentInput : EntityInput
{
	public override Guid TypeUid => DocumentTypeDescriptor.UID;

	protected override Pair<string, bool> InputView(IPropertyMetadata metadata, EntityMetadata typeMetadata, ControllerContext controllerContext, bool isEditor, Type modelType = null)
	{
		if (typeMetadata is DocumentMetadata)
		{
			string text = "Entities/Document";
			if (metadata.Settings is EntitySettings entitySettings && entitySettings.RelationType != 0)
			{
				text += "Set";
			}
			if (ViewExists(controllerContext, isEditor, text))
			{
				return new Pair<string, bool>(text, second: true);
			}
		}
		return base.InputView(metadata, typeMetadata, controllerContext, isEditor, modelType);
	}
}
