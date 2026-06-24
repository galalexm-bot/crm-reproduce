using System;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class DefaultInput : BaseInput
{
	public override Guid TypeUid => Guid.Empty;

	public override string EditorTemplateName(ControllerContext controllerContext, IPropertyMetadata metadata, Type modelType, ViewAttributes viewAttributes)
	{
		return GetTemplateName(controllerContext, isEditor: true, modelType, viewAttributes);
	}

	public override string DisplayTemplateName(ControllerContext controllerContext, IPropertyMetadata metadata, Type modelType, ViewAttributes viewAttributes)
	{
		return GetTemplateName(controllerContext, isEditor: false, modelType, viewAttributes);
	}

	private string GetTemplateName(ControllerContext controllerContext, bool isEditor, Type modelType, ViewAttributes viewAttributes)
	{
		string text = ((!string.IsNullOrEmpty(viewAttributes.TemplateName)) ? viewAttributes.TemplateName : modelType.Name);
		if (!ViewExists(controllerContext, isEditor, text))
		{
			return "Default";
		}
		return text;
	}

	protected override bool CheckEnumerable()
	{
		return false;
	}

	protected override Type GetModelType(ModelMetadata metadata)
	{
		if (metadata.get_Model() != null && !metadata.get_ModelType().IsNullableType())
		{
			return metadata.get_Model().GetType();
		}
		return metadata.get_ModelType().GetNonNullableType();
	}
}
