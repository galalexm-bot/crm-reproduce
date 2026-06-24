using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Web.Mvc;
using Orchard.Localization;

namespace Orchard.Mvc.DataAnnotations;

public class LocalizedModelValidatorProvider : DataAnnotationsModelValidatorProvider
{
	private static readonly Dictionary<Type, Func<ValidationAttribute, Localizer, ValidationAttribute>> _validationAttributes;

	static LocalizedModelValidatorProvider()
	{
		_validationAttributes = new Dictionary<Type, Func<ValidationAttribute, Localizer, ValidationAttribute>>
		{
			{
				typeof(RequiredAttribute),
				(ValidationAttribute attribute, Localizer t) => new LocalizedRequiredAttribute((RequiredAttribute)attribute, t)
			},
			{
				typeof(RangeAttribute),
				(ValidationAttribute attribute, Localizer t) => new LocalizedRangeAttribute((RangeAttribute)attribute, t)
			},
			{
				typeof(StringLengthAttribute),
				(ValidationAttribute attribute, Localizer t) => new LocalizedStringLengthAttribute((StringLengthAttribute)attribute, t)
			},
			{
				typeof(RegularExpressionAttribute),
				(ValidationAttribute attribute, Localizer t) => new LocalizedRegularExpressionAttribute((RegularExpressionAttribute)attribute, t)
			}
		};
		DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof(LocalizedRequiredAttribute), typeof(RequiredAttributeAdapter));
		DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof(LocalizedRangeAttribute), typeof(RangeAttributeAdapter));
		DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof(LocalizedStringLengthAttribute), typeof(StringLengthAttributeAdapter));
		DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof(LocalizedRegularExpressionAttribute), typeof(RegularExpressionAttributeAdapter));
	}

	protected override IEnumerable<ModelValidator> GetValidators(ModelMetadata metadata, ControllerContext context, IEnumerable<Attribute> attributes)
	{
		List<Attribute> list = new List<Attribute>();
		Lazy<Localizer> lazy = new Lazy<Localizer>(() => LocalizationUtilities.Resolve(context, (metadata.get_ContainerType() ?? metadata.get_ModelType()).FullName));
		foreach (Attribute attribute in attributes)
		{
			Attribute localAttribute = attribute;
			Lazy<Localizer> lazy2 = new Lazy<Localizer>(() => LocalizationUtilities.Resolve(context, localAttribute.GetType().FullName));
			ValidationAttribute validationAttribute = attribute as ValidationAttribute;
			if (_validationAttributes.TryGetValue(attribute.GetType(), out var value))
			{
				list.Add(value((ValidationAttribute)attribute, lazy2.Value));
				continue;
			}
			if (validationAttribute != null)
			{
				PropertyInfo property = validationAttribute.GetType().GetProperty("T", typeof(Localizer));
				if (property != null)
				{
					property.SetValue(attribute, lazy2.Value, null);
				}
			}
			if (attribute is DisplayNameAttribute)
			{
				metadata.set_DisplayName(lazy.Value(metadata.get_DisplayName()).Text);
			}
			list.Add(attribute);
		}
		return ((DataAnnotationsModelValidatorProvider)this).GetValidators(metadata, context, (IEnumerable<Attribute>)list);
	}
}
