using System;
using System.Web.Mvc;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class BlobInput : BaseInput
{
	public override Guid TypeUid => BlobDescriptor.UID;

	public override MvcHtmlString Display(HtmlHelper html, IPropertyMetadata metadata, ModelMetadata modelMetadata, string expression, ViewAttributes viewAttributes)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		byte[] value = GetValue(modelMetadata);
		return new MvcHtmlString((value != null && value.Length != 0) ? SR.T("<Двоичные данные>") : "");
	}

	public override MvcHtmlString Editor(HtmlHelper html, IPropertyMetadata metadata, ModelMetadata modelMetadata, string expression, ViewAttributes viewAttributes)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		byte[] value = GetValue(modelMetadata);
		return new MvcHtmlString((value != null && value.Length != 0) ? SR.T("<Двоичные данные>") : "");
	}

	private byte[] GetValue(ModelMetadata modelMetadata)
	{
		if (modelMetadata != null && modelMetadata.get_Model() != null)
		{
			return modelMetadata.get_Model() as byte[];
		}
		return null;
	}
}
