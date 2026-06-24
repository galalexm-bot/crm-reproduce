using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Model.Types.Validation;

namespace EleWise.ELMA.Web.Mvc;

public class ElmaModelValidatorProvider : DataAnnotationsModelValidatorProvider
{
	protected override IEnumerable<ModelValidator> GetValidators(ModelMetadata metadata, ControllerContext context, IEnumerable<Attribute> attributes)
	{
		if (DataAnnotationsModelValidatorProvider.get_AddImplicitRequiredAttributeForValueTypes() && metadata.get_IsRequired() && !attributes.Any((Attribute a) => a is RequiredAttribute))
		{
			attributes = attributes.Concat(new RequiredFieldAttribute[1]
			{
				new RequiredFieldAttribute()
			});
		}
		return ((DataAnnotationsModelValidatorProvider)this).GetValidators(metadata, context, attributes);
	}

	protected override ICustomTypeDescriptor GetTypeDescriptor(Type type)
	{
		return ((AssociatedValidatorProvider)this).GetTypeDescriptor(type);
	}
}
