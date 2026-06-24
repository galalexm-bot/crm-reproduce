using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Views;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Extensions;

public static class ViewModelPropertyMetadataExtensions
{
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public string queryName;

		internal bool _003CGetComputedEqlProperty_003Eb__1(ComputedValue q)
		{
			return q.get_Name() == queryName;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
	}

	public static bool IsComputedOrInput(this ViewModelPropertyMetadata viewModelPropertyMetadata)
	{
		if (viewModelPropertyMetadata == null)
		{
			return false;
		}
		TypeSettings settings = ((IPropertyMetadata)viewModelPropertyMetadata).get_Settings();
		EntitySettings val;
		if ((val = (EntitySettings)(object)((settings is EntitySettings) ? settings : null)) != null && val.get_IsComputedEqlValue())
		{
			ComputedValue computedEqlProperty = viewModelPropertyMetadata.GetComputedEqlProperty();
			if (computedEqlProperty != null && computedEqlProperty.ComputedValueType != 0)
			{
				return true;
			}
		}
		if (!viewModelPropertyMetadata.get_Input())
		{
			if (viewModelPropertyMetadata.get_ClientOnly() && viewModelPropertyMetadata.get_ComputedValue() != null && viewModelPropertyMetadata.get_ComputedValue().get_ComputedValueType() != 0)
			{
				if (viewModelPropertyMetadata.get_ComputedValue().get_ComputedValueType() != 1 || string.IsNullOrWhiteSpace(viewModelPropertyMetadata.get_ComputedValue().get_MethodName()))
				{
					if (viewModelPropertyMetadata.get_ComputedValue().get_ComputedValueType() == 2)
					{
						return !string.IsNullOrWhiteSpace(viewModelPropertyMetadata.get_ComputedValue().get_CalculateScript());
					}
					return false;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	public static ComputedValue GetComputedEqlProperty(this ViewModelPropertyMetadata viewModelPropertyMetadata)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		if (viewModelPropertyMetadata == null)
		{
			return null;
		}
		ParameterExpression val = Expression.Parameter(typeof(PropertyMetadata), "q");
		CS_0024_003C_003E8__locals0.queryName = DynamicPropertyHelper<PropertyMetadata>.GetExpression<string>(Expression.Lambda<Func<PropertyMetadata, string>>((Expression)(object)Expression.Property((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(EntitySettings)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		ComputedValue val2 = Enumerable.FirstOrDefault<ComputedValue>((System.Collections.Generic.IEnumerable<ComputedValue>)viewModelPropertyMetadata.get_ComputedValues(), (Func<ComputedValue, bool>)((ComputedValue q) => q.get_Name() == CS_0024_003C_003E8__locals0.queryName));
		if (val2 == null)
		{
			return null;
		}
		return DynamicPropertyHelper.ComputedValueMapToObject(val2);
	}
}
