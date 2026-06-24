using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Binders;

namespace EleWise.ELMA.BPM.Web.Common.Components;

public class AttachmentBinder : ElmaModelBinder
{
	private const string CallContextBinaryFileName = "EleWise.ELMA.BPM.Web.Common.Components.AttachmentBinder.BinaryFile";

	private static string _nameOfFile = LinqUtils.NameOf((Expression<Func<IAttachment, object>>)((IAttachment q) => q.File));

	private static BinaryFile File
	{
		get
		{
			if (!ContextVars.TryGetValue<BinaryFile>("EleWise.ELMA.BPM.Web.Common.Components.AttachmentBinder.BinaryFile", out var value))
			{
				return null;
			}
			return value;
		}
		set
		{
			ContextVars.Set("EleWise.ELMA.BPM.Web.Common.Components.AttachmentBinder.BinaryFile", value);
		}
	}

	public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ModelBindingContext val = new ModelBindingContext(bindingContext);
		val.set_ModelName($"{bindingContext.get_ModelName()}.{_nameOfFile}");
		string key = val.get_ModelName() + ".Uid";
		string value = bindingContext.GetValue<string>(key);
		HttpPostedFileBase value2 = bindingContext.GetValue<HttpPostedFileBase>(bindingContext.get_ModelName());
		if (!string.IsNullOrEmpty(val.get_ModelName()) && !val.get_ValueProvider().ContainsPrefix(val.get_ModelName()) && string.IsNullOrEmpty(value) && (value2 == null || string.IsNullOrEmpty(value2.FileName)))
		{
			File = null;
			return base.BindModel(controllerContext, bindingContext);
		}
		if (!(ModelBinders.get_Binders().get_Item(typeof(BinaryFile)).BindModel(controllerContext, val) is BinaryFile binaryFile) || string.IsNullOrWhiteSpace(binaryFile.Name))
		{
			return null;
		}
		File = binaryFile;
		return base.BindModel(controllerContext, bindingContext);
	}

	protected override object GetPropertyValue(ControllerContext controllerContext, ModelBindingContext bindingContext, PropertyDescriptor propertyDescriptor, IModelBinder propertyBinder)
	{
		if ((bindingContext.get_ModelMetadata() != null && bindingContext.get_ModelMetadata().get_ContainerType() != null && typeof(IAttachment).IsAssignableFrom(bindingContext.get_ModelMetadata().get_ContainerType()) && propertyDescriptor.Name == _nameOfFile) || typeof(BinaryFile).IsAssignableFrom(propertyDescriptor.PropertyType))
		{
			return File;
		}
		return ((DefaultModelBinder)this).GetPropertyValue(controllerContext, bindingContext, propertyDescriptor, propertyBinder);
	}
}
