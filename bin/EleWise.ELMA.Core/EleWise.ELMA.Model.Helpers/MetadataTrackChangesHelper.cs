using System;
using Bridge.Html5;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Extensions;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Helpers;

public static class MetadataTrackChangesHelper
{
	private static bool _003CScriptChanged_003Ek__BackingField;

	public static bool ScriptChanged
	{
		get
		{
			return _003CScriptChanged_003Ek__BackingField;
		}
		set
		{
			_003CScriptChanged_003Ek__BackingField = value;
		}
	}

	public static void FillOldMetadata(IMetadata metadata)
	{
		ScriptChanged = false;
		if (metadata != null)
		{
			object serializedMetadata = GetSerializedMetadata(metadata);
			metadata.SetAndCreatePlainPropertyValue("$oldJsonObj", JSON.Stringify(serializedMetadata));
		}
	}

	public static void FillOldViewItem(FormViewItem formViewItem)
	{
		if (formViewItem != null)
		{
			string value = formViewItem.Serialize();
			formViewItem.SetAndCreatePlainPropertyValue("$oldJsonObj", value);
		}
	}

	public static bool HasChanges(IMetadata metadata)
	{
		if (ScriptChanged)
		{
			return true;
		}
		if (metadata == null)
		{
			return false;
		}
		string plainPropertyValue = metadata.GetPlainPropertyValue<string>("$oldJsonObj");
		if (string.IsNullOrWhiteSpace(plainPropertyValue))
		{
			return false;
		}
		object serializedMetadata = GetSerializedMetadata(metadata);
		return !ConvertHelper.IsPlainObjectsEquals(JSON.Parse(plainPropertyValue), serializedMetadata);
	}

	public static bool ViewItemHasChanges(FormViewItem formViewItem)
	{
		if (formViewItem == null)
		{
			return false;
		}
		string plainPropertyValue = formViewItem.GetPlainPropertyValue<string>("$oldJsonObj");
		if (string.IsNullOrWhiteSpace(plainPropertyValue))
		{
			return false;
		}
		string text = formViewItem.Serialize();
		return !plainPropertyValue.Equals(text);
	}

	private static object GetSerializedMetadata(IMetadata metadata)
	{
		if (metadata == null)
		{
			return null;
		}
		return ConvertHelper.Serialize(metadata, new SerializationSettings
		{
			Mode = SerializationMode.FullWithInit
		});
	}

	public static bool PageTypeIsSupported(InterfaceBuilderViewMode mode, Guid pageTypeUid)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((mode != InterfaceBuilderViewMode.Design || !(pageTypeUid == MetadataConstants.ComponentMetadataTypeUid)) && !(pageTypeUid == MetadataConstants.DataClassMetadataTypeUid))
		{
			return pageTypeUid == MetadataConstants.FunctionMetadataTypeUid;
		}
		return true;
	}
}
