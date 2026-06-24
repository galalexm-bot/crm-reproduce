using System;
using System.Collections;
using System.Web.Mvc;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class EnumInput : BaseInput
{
	public override Guid TypeUid => EnumDescriptor.UID;

	public override string DisplayTemplateName(ControllerContext controllerContext, IPropertyMetadata metadata, Type modelType, ViewAttributes viewAttributes)
	{
		return InputViewName(controllerContext, metadata, modelType, viewAttributes, isEditor: false);
	}

	public override string EditorTemplateName(ControllerContext controllerContext, IPropertyMetadata metadata, Type modelType, ViewAttributes viewAttributes)
	{
		return InputViewName(controllerContext, metadata, modelType, viewAttributes, isEditor: true);
	}

	private string InputViewName(ControllerContext controllerContext, IPropertyMetadata metadata, Type modelType, ViewAttributes viewAttributes, bool isEditor)
	{
		EnumSettings enumSettings = (EnumSettings)metadata.Settings;
		if (isEditor && string.IsNullOrWhiteSpace(viewAttributes.TemplateName) && enumSettings != null)
		{
			switch (enumSettings.DisplayType)
			{
			case EnumDisplayType.HorizontalGroup:
				viewAttributes.TemplateName = "Enum_HorizontalRadio";
				break;
			case EnumDisplayType.VerticalGroup:
				viewAttributes.TemplateName = "Enum_VerticalRadio";
				break;
			case EnumDisplayType.Switch:
				viewAttributes.TemplateName = "Enum_Switch";
				break;
			}
		}
		if (!string.IsNullOrEmpty(viewAttributes.TemplateName) && ViewExists(controllerContext, isEditor, viewAttributes.TemplateName))
		{
			return viewAttributes.TemplateName;
		}
		if (MetadataLoader.LoadMetadata(metadata.SubTypeUid) is EnumMetadata enumMetadata)
		{
			string text = "";
			if (enumSettings != null && enumSettings.RelationType == EnumRelationType.Many && typeof(IEnumerable).IsAssignableFrom(modelType))
			{
				text = "Set";
			}
			string text2 = "/" + enumMetadata.Name + text;
			if (!ViewExists(controllerContext, isEditor, text2))
			{
				return "Enum" + text;
			}
			return text2;
		}
		if (!isEditor)
		{
			return base.DisplayTemplateName(controllerContext, metadata, modelType, viewAttributes);
		}
		return base.EditorTemplateName(controllerContext, metadata, modelType, viewAttributes);
	}

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "Enum";
	}

	protected override bool CheckEnumerable()
	{
		return false;
	}
}
