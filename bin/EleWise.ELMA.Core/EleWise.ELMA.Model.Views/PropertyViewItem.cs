using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Common;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

public class PropertyViewItem : RootViewItem, IFocusable, IViewItemWithPropertyParents, IViewItem, IReactive, ICustomViewNameViewItem
{
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public string property;

		internal bool _003CTypeSettingsAction_003Eb__0(PropertyMetadata a)
		{
			return ((INamedMetadata)a).get_Name() == property;
		}
	}

	private Guid _003CPropertyUid_003Ek__BackingField;

	private ViewAttributes _003CAttributes_003Ek__BackingField;

	private bool _003CIsCustom_003Ek__BackingField;

	private string _003CCustomViewName_003Ek__BackingField;

	private bool _003CEditableInTable_003Ek__BackingField;

	private bool _003COverrideEditableInTable_003Ek__BackingField;

	private FocusableType _003CFocusableType_003Ek__BackingField;

	private System.Collections.Generic.ICollection<Guid> _003CPropertyParents_003Ek__BackingField;

	private PropertiesContainer _003CTypeSettings_003Ek__BackingField;

	[JsonProperty(PropertyName = "Property")]
	public virtual Guid PropertyUid
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

	[NotResettable]
	[DynamicPropertyContainer]
	public ViewAttributes Attributes
	{
		get
		{
			return _003CAttributes_003Ek__BackingField;
		}
		set
		{
			_003CAttributes_003Ek__BackingField = value;
		}
	}

	public bool IsCustom
	{
		get
		{
			return _003CIsCustom_003Ek__BackingField;
		}
		set
		{
			_003CIsCustom_003Ek__BackingField = value;
		}
	}

	public override bool IsHideable => true;

	public string CustomViewName
	{
		get
		{
			return _003CCustomViewName_003Ek__BackingField;
		}
		set
		{
			_003CCustomViewName_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool EditableInTable
	{
		get
		{
			return _003CEditableInTable_003Ek__BackingField;
		}
		set
		{
			_003CEditableInTable_003Ek__BackingField = value;
		}
	}

	public bool OverrideEditableInTable
	{
		get
		{
			return _003COverrideEditableInTable_003Ek__BackingField;
		}
		set
		{
			_003COverrideEditableInTable_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public FocusableType FocusableType
	{
		get
		{
			return _003CFocusableType_003Ek__BackingField;
		}
		set
		{
			_003CFocusableType_003Ek__BackingField = value;
		}
	}

	public virtual bool FocusableEnabled => true;

	[NotResettable]
	public System.Collections.Generic.ICollection<Guid> PropertyParents
	{
		get
		{
			return _003CPropertyParents_003Ek__BackingField;
		}
		set
		{
			_003CPropertyParents_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public override bool? ReadOnly
	{
		get
		{
			return Attributes?.ReadOnly;
		}
		set
		{
			if (Attributes != null)
			{
				Attributes.ReadOnly = value;
			}
		}
	}

	[DynamicProperty(false)]
	public override bool Hide
	{
		get
		{
			return Attributes?.Hide ?? false;
		}
		set
		{
			if (Attributes != null)
			{
				Attributes.Hide = value;
			}
		}
	}

	public PropertiesContainer TypeSettings
	{
		get
		{
			return _003CTypeSettings_003Ek__BackingField;
		}
		set
		{
			_003CTypeSettings_003Ek__BackingField = value;
		}
	}

	public PropertyViewItem()
	{
		CustomViewName = "";
		PropertyParents = new ReactiveCollection<Guid>();
		TypeSettings = new PropertiesContainer();
	}

	internal void TypeSettingsAction(IMetadataServiceContext metadataServiceContext, TypeSettings typeSettings)
	{
		if (typeSettings == null)
		{
			return;
		}
		ReactiveProxy reactiveProxy = ObjectExtensions.As<ReactiveProxy>((object)typeSettings);
		IMetadata metadataByHash = metadataServiceContext.GetMetadataByHash(reactiveProxy.TypeRef);
		ClassMetadata val = (ClassMetadata)(object)((metadataByHash is ClassMetadata) ? metadataByHash : null);
		if (val == null)
		{
			return;
		}
		System.Collections.Generic.IEnumerator<string> enumerator = TypeSettings.GetProperties().GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				_003C_003Ec__DisplayClass47_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass47_0();
				CS_0024_003C_003E8__locals0.property = enumerator.get_Current();
				PropertyMetadata val2 = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)val.get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata a) => ((INamedMetadata)a).get_Name() == CS_0024_003C_003E8__locals0.property));
				if (val2 != null)
				{
					PropertyInfoExpression propertyExpression = metadataServiceContext.GetPropertyExpression((IPropertyMetadata)(object)val2, val);
					object propValue = TypeSettings.GetPropValue(CS_0024_003C_003E8__locals0.property);
					typeSettings.SetAndCreatePlainPropertyValue(propertyExpression.ObjectExpression, propValue);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		if (!Hide && parentViewItem != null)
		{
			if (parentViewItem.IsChildValid(this))
			{
				return parentViewItem is RootViewItem;
			}
			return false;
		}
		return true;
	}

	protected internal override void SetReadOnly()
	{
		base.SetReadOnly();
		if (Attributes != null)
		{
			Attributes.ReadOnly = true;
		}
		EditableInTable = false;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is PropertyViewItem;
	}

	public override bool IsEmpty()
	{
		return false;
	}
}
