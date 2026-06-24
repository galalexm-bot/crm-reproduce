using System;
using System.Collections.Generic;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class ExtensionPointViewItem : ViewItem
{
	public static string SystemGenericComponentKey = "__System_ExtensionPoint_Implementation";

	private string _003CPointId_003Ek__BackingField;

	private Guid _003CTypeUid_003Ek__BackingField;

	private Guid _003CPropertyUid_003Ek__BackingField;

	private bool _003CHideFormComponents_003Ek__BackingField;

	private ActionWithParam<System.Collections.Generic.ICollection<IDataClass>> _003COnLoad_003Ek__BackingField;

	public string PointId
	{
		get
		{
			return _003CPointId_003Ek__BackingField;
		}
		set
		{
			_003CPointId_003Ek__BackingField = value;
		}
	}

	public Guid TypeUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CTypeUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CTypeUid_003Ek__BackingField = value;
		}
	}

	public Guid PropertyUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CPropertyUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CPropertyUid_003Ek__BackingField = value;
		}
	}

	public bool HideFormComponents
	{
		get
		{
			return _003CHideFormComponents_003Ek__BackingField;
		}
		set
		{
			_003CHideFormComponents_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<System.Collections.Generic.ICollection<IDataClass>> OnLoad
	{
		get
		{
			return _003COnLoad_003Ek__BackingField;
		}
		set
		{
			_003COnLoad_003Ek__BackingField = value;
		}
	}
}
