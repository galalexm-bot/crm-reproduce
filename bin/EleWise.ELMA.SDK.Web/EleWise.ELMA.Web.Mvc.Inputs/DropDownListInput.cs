using System;
using System.Web.Mvc;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class DropDownListInput : BaseInput
{
	public override Guid TypeUid => DropDownListDescriptor.UID;

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
		DropDownListSettings dropDownListSettings = (DropDownListSettings)metadata.Settings;
		if (isEditor && string.IsNullOrWhiteSpace(viewAttributes.TemplateName) && dropDownListSettings != null)
		{
			switch (dropDownListSettings.DisplayType)
			{
			case DropDownListDisplayType.HorizontalGroup:
				viewAttributes.TemplateName = "DropDownList_HorizontalRadio";
				break;
			case DropDownListDisplayType.VerticalGroup:
				viewAttributes.TemplateName = "DropDownList_VerticalRadio";
				break;
			}
		}
		if (!string.IsNullOrEmpty(viewAttributes.TemplateName) && ViewExists(controllerContext, isEditor, viewAttributes.TemplateName))
		{
			return viewAttributes.TemplateName;
		}
		if (!isEditor)
		{
			return base.DisplayTemplateName(controllerContext, metadata, modelType, viewAttributes);
		}
		return base.EditorTemplateName(controllerContext, metadata, modelType, viewAttributes);
	}

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "DropDownList";
	}
}
