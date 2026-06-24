using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Helpers;

internal static class ComputedValueHelper
{
	internal static object GetValue(IDescriptorService descriptorService, Guid typeUid, string value, ConvertContext context, bool? nullable = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (typeUid == ActionDescriptor.UID)
		{
			return ConvertHelper.DeserializeWithType(typeof(ActionValue), value, context);
		}
		ITypeDescriptor typeDescriptor = descriptorService.GetTypeDescriptor(typeUid, Guid.Empty);
		if (typeDescriptor == null)
		{
			return null;
		}
		if (typeDescriptor is EnumDescriptor)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				return null;
			}
			return EnumWrapper.CreateFromString(value);
		}
		if (!(typeDescriptor is IRuntimeTypeDescriptor runtimeTypeDescriptor))
		{
			return null;
		}
		if (nullable.get_HasValue() && nullable.get_Value() && string.IsNullOrWhiteSpace(value))
		{
			if (!typeDescriptor.CanBeNullable)
			{
				return ConvertHelper.DeserializeWithType(runtimeTypeDescriptor.RuntimeType, value, context);
			}
			return null;
		}
		return ConvertHelper.DeserializeWithType(runtimeTypeDescriptor.RuntimeType, value, context);
	}
}
