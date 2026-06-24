using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Models;

namespace EleWise.ELMA.Model.Types;

[Component]
public abstract class TypeDescriptor<T> : TypeDescriptor
{
	public TypeDescriptor(ILogger logger)
		: base(logger)
	{
	}
}
[Component]
public abstract class TypeDescriptor : ITypeDescriptor, IPropertyTypeInfo, ITypeGenerationInfo, ITypeDescriptorSettingsInit, ISystemDescriptor, ISortedProperty
{
	private readonly ILogger _003CLogger_003Ek__BackingField;

	public ILogger Logger => _003CLogger_003Ek__BackingField;

	public abstract Guid Uid { get; }

	public abstract string Name { get; }

	public virtual bool Visible => true;

	public abstract Guid ParentUid { get; }

	public virtual bool IsGroup => false;

	public virtual Guid SubTypeUid => Guid.Empty;

	public abstract bool UseForEntity { get; }

	public virtual System.Type SettingsType => null;

	public abstract bool CanBeNullable { get; }

	public abstract bool? DefaultNullableValue { get; }

	public TypeDescriptor(ILogger logger)
	{
		_003CLogger_003Ek__BackingField = logger;
	}

	public virtual string GetTypeDisplayName(Guid subTypeUid)
	{
		return Name;
	}

	public virtual bool IsNullable(IPropertyMetadata property)
	{
		PropertyMetadata val;
		if (CanBeNullable && property != null && (val = (PropertyMetadata)(object)((property is PropertyMetadata) ? property : null)) != null)
		{
			return val.get_Nullable();
		}
		return false;
	}

	public virtual bool ShouldSerialize(IPropertyMetadata property, IMetadata metadata)
	{
		ViewModelPropertyMetadata val;
		if ((val = (ViewModelPropertyMetadata)(object)((property is ViewModelPropertyMetadata) ? property : null)) != null)
		{
			return !val.get_ClientOnly();
		}
		return true;
	}

	public virtual bool HasSetter(IPropertyMetadata property)
	{
		ViewModelPropertyMetadata val;
		if ((val = (ViewModelPropertyMetadata)(object)((property is ViewModelPropertyMetadata) ? property : null)) != null)
		{
			return !val.get_Input();
		}
		return true;
	}

	public abstract Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo);

	public abstract Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo);

	public override string ToString()
	{
		return Name;
	}

	public virtual TypeSettings CreateSettings()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		System.Type settingsType = SettingsType;
		if (settingsType == null)
		{
			return null;
		}
		return (TypeSettings)InterfaceCreator.Create(settingsType);
	}

	public virtual void InitSettingsFromSettings(TypeSettings typeSettings, TypeSettings newSettings)
	{
	}

	public virtual object SystemPropertyGetter(object target, PropertyInfoExpression expressionInfo, SystemPropertyInfo propertyInfo)
	{
		PropertyInfo propertyInfo2 = new PropertyInfo
		{
			InitValue = null,
			Expression = expressionInfo,
			Nullable = IsNullable(null),
			ShouldSerialize = true
		};
		GetterInfo getterInfo = new GetterInfo
		{
			Target = target
		};
		return PropertyGetter(propertyInfo2).Invoke(getterInfo, propertyInfo2);
	}

	public virtual bool IsSupportSort()
	{
		return false;
	}
}
[Component]
public abstract class TypeDescriptor<T, SettingsT> : TypeDescriptor<T>
{
	public override System.Type SettingsType => typeof(SettingsT);

	public TypeDescriptor(ILogger logger)
		: base(logger)
	{
	}
}
