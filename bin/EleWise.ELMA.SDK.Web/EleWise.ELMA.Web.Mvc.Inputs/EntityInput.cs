using System;
using System.Collections;
using System.Web.Mvc;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class EntityInput : BaseInput
{
	public override Guid TypeUid => EntityDescriptor.UID;

	public override string DisplayTemplateName(ControllerContext controllerContext, IPropertyMetadata metadata, Type modelType, ViewAttributes viewAttributes)
	{
		return InputViewName(controllerContext, metadata, modelType, viewAttributes, isEditor: false);
	}

	public override string EditorTemplateName(ControllerContext controllerContext, IPropertyMetadata metadata, Type modelType, ViewAttributes viewAttributes)
	{
		return InputViewName(controllerContext, metadata, modelType, viewAttributes, isEditor: true);
	}

	protected override bool CheckEnumerable()
	{
		return false;
	}

	protected internal virtual bool HasDisplay(IPropertyMetadata metadata, ControllerContext controllerContext)
	{
		if (MetadataLoader.LoadMetadata(metadata.SubTypeUid) is EntityMetadata typeMetadata)
		{
			return InputView(metadata, typeMetadata, controllerContext, isEditor: false).Second;
		}
		return false;
	}

	protected internal virtual bool HasEditor(IPropertyMetadata metadata, ControllerContext controllerContext)
	{
		if (MetadataLoader.LoadMetadata(metadata.SubTypeUid) is EntityMetadata typeMetadata)
		{
			return InputView(metadata, typeMetadata, controllerContext, isEditor: true).Second;
		}
		return false;
	}

	protected internal virtual Pair<string, bool> InputView(IPropertyMetadata metadata, EntityMetadata typeMetadata, ControllerContext controllerContext, bool isEditor, Type modelType = null)
	{
		string text = (((metadata.Settings is EntitySettings entitySettings && entitySettings.RelationType != 0) || (modelType != null && typeof(IEnumerable).IsAssignableFrom(modelType))) ? "Set" : "");
		string text2 = "Entities/" + typeMetadata.Name + text;
		if (!ViewExists(controllerContext, isEditor, text2))
		{
			return new Pair<string, bool>("Entity" + text, second: false);
		}
		return new Pair<string, bool>(text2, second: true);
	}

	private string InputViewName(ControllerContext controllerContext, IPropertyMetadata metadata, Type modelType, ViewAttributes viewAttributes, bool isEditor)
	{
		EntitySettings entitySettings = (EntitySettings)metadata.Settings;
		if (isEditor && string.IsNullOrWhiteSpace(viewAttributes.TemplateName) && entitySettings != null)
		{
			switch (entitySettings.DisplayType)
			{
			case EntityDisplayType.HorizontalGroup:
				viewAttributes.TemplateName = "Entity_Horizontal";
				break;
			case EntityDisplayType.VerticalGroup:
				viewAttributes.TemplateName = "Entity_Vertical";
				break;
			}
		}
		if (!string.IsNullOrEmpty(viewAttributes.TemplateName) && ViewExists(controllerContext, isEditor, viewAttributes.TemplateName))
		{
			return viewAttributes.TemplateName;
		}
		if (MetadataLoader.LoadMetadata(metadata.SubTypeUid) is EntityMetadata typeMetadata)
		{
			return InputView(metadata, typeMetadata, controllerContext, isEditor, modelType).First;
		}
		if (!isEditor)
		{
			return base.DisplayTemplateName(controllerContext, metadata, modelType, viewAttributes);
		}
		return base.EditorTemplateName(controllerContext, metadata, modelType, viewAttributes);
	}

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "Entity";
	}
}
