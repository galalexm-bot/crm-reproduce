using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Converters;

internal sealed class EnumWrapperConverter : BaseValueConverter<EnumWrapper, Guid?>
{
	private EnumDescriptor descriptor;

	public override bool CanConvert(ITypeDescriptor typeDescriptor, System.Type convertType)
	{
		if (!base.CanConvert(typeDescriptor, convertType))
		{
			return false;
		}
		if (!(typeDescriptor is EnumDescriptor enumDescriptor))
		{
			return false;
		}
		if (descriptor == null)
		{
			descriptor = enumDescriptor;
		}
		return true;
	}

	public override EnumWrapper ConvertTo(Guid? value, IPropertyMetadata propertyMetadata)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!DefaultValueHelper.CanBeNullableProperty(descriptor, propertyMetadata) && !value.get_HasValue())
		{
			return null;
		}
		EnumMetadata val = (EnumMetadata)descriptor.metadataServiceContext.GetMetadata(propertyMetadata.get_SubTypeUid());
		EnumMetadataType enumMetadataType = EnumMetadataType.ExtendableEnum;
		Guid val2 = (Guid)(((_003F?)value) ?? Guid.Empty);
		int? intValue = null;
		if (val2 == Guid.Empty && val != null)
		{
			enumMetadataType = (EnumMetadataType)val.get_Type();
			EnumValueMetadata val3 = Enumerable.FirstOrDefault<EnumValueMetadata>((System.Collections.Generic.IEnumerable<EnumValueMetadata>)val.get_Values());
			if (val3 != null)
			{
				val2 = ((IMetadata)val3).get_Uid();
				intValue = val3.get_IntValue();
			}
		}
		return EnumWrapper.CreateBase(val2, intValue, enumMetadataType);
	}

	public override Guid? ConvertFrom(EnumWrapper value)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		return value?.Uid;
	}
}
