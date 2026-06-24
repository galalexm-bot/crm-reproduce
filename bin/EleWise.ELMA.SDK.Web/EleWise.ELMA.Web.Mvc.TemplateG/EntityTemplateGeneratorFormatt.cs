using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.TemplateGenerator;

namespace EleWise.ELMA.Web.Mvc.TemplateGenerators;

[Component]
public class EntityTemplateGeneratorFormatter : ITemplateGeneratorFormatter
{
	private static string IEntityFullName = typeof(IEntity).FullName;

	private const string InputsKey = " EleWise.ELMA.Web.Mvc.TemplateGenerators.IHtmlTemplateInput";

	public string FormatValue(GenerationContext context, FormatedValue value, TemplateRenderMode renderMode)
	{
		Type type = ((value != null && value.Value != null) ? GetEntityType(value.Value.GetType()) : null);
		if (type == null)
		{
			return null;
		}
		MetadataBasedFormat metadataBasedFormat = value.Format as MetadataBasedFormat;
		MetadataBasedValue metadataBasedValue = value as MetadataBasedValue;
		_ = metadataBasedFormat?.PropertyMetadata;
		_ = metadataBasedValue?.Container;
		_ = metadataBasedValue?.ContainerMetadata;
		IEnumerable enumerable = value.Value as IEnumerable;
		if (value.Value is IEntity)
		{
			IEntityTemplateInput entityTemplateInput = FindInput(value.Value.GetType());
			if (entityTemplateInput != null)
			{
				return entityTemplateInput.FormatValue(value.Value, renderMode);
			}
		}
		else if (enumerable != null)
		{
			IEntityTemplateInput entityTemplateInput2 = FindInput(type);
			string value2 = ((entityTemplateInput2 != null) ? entityTemplateInput2.GetListSeparator(renderMode) : ", ");
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = true;
			foreach (object item in enumerable)
			{
				if (item != null)
				{
					if (!flag)
					{
						stringBuilder.Append(value2);
					}
					stringBuilder.Append(context.FormatProvider.FormatValue(new FormatedValue(item)));
					flag = false;
				}
			}
			return stringBuilder.ToString();
		}
		return null;
	}

	private static IEnumerable<IEntityTemplateInput> GetInputs()
	{
		IEnumerable<IEntityTemplateInput> enumerable;
		if (HttpContext.Current != null)
		{
			enumerable = (HttpContext.Current.Items.Contains(" EleWise.ELMA.Web.Mvc.TemplateGenerators.IHtmlTemplateInput") ? ((IEnumerable<IEntityTemplateInput>)HttpContext.Current.Items[" EleWise.ELMA.Web.Mvc.TemplateGenerators.IHtmlTemplateInput"]) : null);
			if (enumerable != null)
			{
				return enumerable;
			}
		}
		enumerable = ComponentManager.Current.GetExtensionPoints<IEntityTemplateInput>();
		if (HttpContext.Current != null)
		{
			HttpContext.Current.Items[" EleWise.ELMA.Web.Mvc.TemplateGenerators.IHtmlTemplateInput"] = enumerable;
		}
		return enumerable;
	}

	private static IEntityTemplateInput FindInput(Type itemType)
	{
		if (itemType == null)
		{
			return null;
		}
		IEntityTemplateInput entityTemplateInput = GetInputs().FirstOrDefault((IEntityTemplateInput i) => i.SupportedTypes.Contains(itemType));
		if (entityTemplateInput != null)
		{
			return entityTemplateInput;
		}
		return FindInput(itemType.BaseType);
	}

	private Type GetEntityType(Type type)
	{
		if (IsEntityType(type))
		{
			return type;
		}
		Type type2 = type.GetInterface(typeof(IEnumerable<>).FullName);
		if (type2 == null)
		{
			type2 = type;
		}
		if (type2 != null && type2.IsGenericType && type2.GetGenericTypeDefinition() == typeof(IEnumerable<>))
		{
			Type type3 = type2.GetGenericArguments()[0];
			if (!IsEntityType(type3))
			{
				return null;
			}
			return type3;
		}
		return null;
	}

	private static bool IsEntityType(Type type)
	{
		if (type == null)
		{
			return false;
		}
		if (type == typeof(IEntity) || typeof(IEntity).IsAssignableFrom(type) || type.GetInterface(IEntityFullName) != null)
		{
			return true;
		}
		return false;
	}
}
