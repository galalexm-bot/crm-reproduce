using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Helpers;

public static class PropertyMetadataSettingsHelper
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<PropertyMetadataAdditionalAttribute, bool> _003C_003E9__3_0;

		internal bool _003CIsDeletedProperty_003Eb__3_0(PropertyMetadataAdditionalAttribute a)
		{
			return a.get_AddtibuteName() == "System.ObsoleteAttribute";
		}
	}

	public static bool IsInput(ViewModelPropertyMetadata property)
	{
		if (property != null)
		{
			return property.get_Input();
		}
		return false;
	}

	public static bool IsDynamic(ViewModelPropertyMetadata property)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		ViewModelPropertyMetadata val;
		if (property != null && (val = property) != null && val.get_ClientOnly() && !val.get_Input() && ((IPropertyMetadata)val).get_TypeUid() != ActionDescriptor.UID)
		{
			TypeSettings settings = ((IPropertyMetadata)property).get_Settings();
			EntitySettings val2;
			if ((val2 = (EntitySettings)(object)((settings is EntitySettings) ? settings : null)) != null)
			{
				return !val2.get_IsComputedEqlValue();
			}
			return true;
		}
		return false;
	}

	public static bool IsNullableProperty(this PropertyMetadata propertyMetadata)
	{
		if (propertyMetadata != null)
		{
			return propertyMetadata.get_Nullable();
		}
		return false;
	}

	public static bool IsDeletedProperty(this PropertyMetadata property)
	{
		System.Collections.Generic.ICollection<PropertyMetadataAdditionalAttribute> collection = ((property != null) ? property.get_AdditionalAttributes() : null);
		if (collection == null || collection.get_Count() == 0)
		{
			return false;
		}
		return Enumerable.FirstOrDefault<PropertyMetadataAdditionalAttribute>((System.Collections.Generic.IEnumerable<PropertyMetadataAdditionalAttribute>)collection, (Func<PropertyMetadataAdditionalAttribute, bool>)((PropertyMetadataAdditionalAttribute a) => a.get_AddtibuteName() == "System.ObsoleteAttribute")) != null;
	}

	public static bool CanBeTitle(this PropertyMetadata property, ClassMetadata metadata)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (((IPropertyMetadata)property).get_TypeUid() == StringDescriptor.UID && !(metadata is ComponentContextMetadata))
		{
			return !(metadata is TablePartMetadata);
		}
		return false;
	}

	public static bool IsOutput(ViewModelPropertyMetadata property)
	{
		if (property != null)
		{
			return property.get_Output();
		}
		return false;
	}
}
