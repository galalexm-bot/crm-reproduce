using System.Web.Mvc;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Web.Mvc.Extensions;

public static class ModelMetadataExtensions
{
	private const string PROPERTY_METADATA = "ElmaPropertyMetadata";

	private const string CONTAINER_OBJECT = "ElmaContainerObject";

	public static IPropertyMetadata GetPropertyMetadata(this ModelMetadata modelMetadata)
	{
		if (modelMetadata.get_AdditionalValues() != null && modelMetadata.get_AdditionalValues().ContainsKey("ElmaPropertyMetadata"))
		{
			return (IPropertyMetadata)modelMetadata.get_AdditionalValues()["ElmaPropertyMetadata"];
		}
		return null;
	}

	public static void SetPropertyMetadata(this ModelMetadata modelMetadata, IPropertyMetadata propertyMetadata)
	{
		modelMetadata.get_AdditionalValues()["ElmaPropertyMetadata"] = propertyMetadata;
	}

	public static object GetContainerObject(this ModelMetadata modelMetadata)
	{
		if (modelMetadata.get_AdditionalValues() != null && modelMetadata.get_AdditionalValues().ContainsKey("ElmaContainerObject"))
		{
			return modelMetadata.get_AdditionalValues()["ElmaContainerObject"];
		}
		return null;
	}

	public static void SetContainerObject(this ModelMetadata modelMetadata, object container)
	{
		modelMetadata.get_AdditionalValues()["ElmaContainerObject"] = container;
	}
}
