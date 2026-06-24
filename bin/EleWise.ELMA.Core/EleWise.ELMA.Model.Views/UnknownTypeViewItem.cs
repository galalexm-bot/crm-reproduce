using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Bridge;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Views;

[Rules(/*Could not decode attribute arguments.*/)]
[EditorBrowsable(/*Could not decode attribute arguments.*/)]
[Obsolete("Не использовать")]
internal sealed class UnknownTypeViewItem : ViewItem, IUnknownSerializableType, IHideEmptyViewItem
{
	private object serializedValue;

	private string typeName;

	private HideEmptyEnum _003CHideEmpty_003Ek__BackingField;

	public HideEmptyEnum HideEmpty
	{
		get
		{
			return _003CHideEmpty_003Ek__BackingField;
		}
		set
		{
			_003CHideEmpty_003Ek__BackingField = value;
		}
	}

	public bool IsHideable => true;

	public string GetTypeName()
	{
		return typeName;
	}

	[OnSerialized]
	public void OnSerializedMethod(UnknownObjectWrapper raw)
	{
		if (serializedValue != null)
		{
			raw.Value = serializedValue;
		}
		raw.Value.SetAndCreatePlainPropertyValue("$type", typeName);
	}

	[OnDeserialized]
	public void OnDeserializedMethod(object raw)
	{
		typeName = raw.GetPlainPropertyValue<string>("$type");
		serializedValue = raw;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	public void SetTypeName(string tn)
	{
		typeName = tn;
	}

	protected override string GetDefaultName()
	{
		if (string.IsNullOrWhiteSpace(typeName))
		{
			return base.GetDefaultName();
		}
		string text = typeName;
		string[] array = typeName.Split(new char[1] { ',' });
		if (array.Length > 1)
		{
			text = array[0];
		}
		int num = text.LastIndexOf('.');
		string text2 = text.Substring(num + 1);
		if (!text2.EndsWith("ViewItem"))
		{
			return text2;
		}
		return text2.Substring(0, text2.get_Length() - "ViewItem".get_Length());
	}
}
