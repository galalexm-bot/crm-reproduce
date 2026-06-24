using System;
using System.Collections.Generic;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 400)]
public class EntityDescriptor : RefTypeDescriptor<Entity, EntitySettings>
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public PropertyInfo info;

		internal object _003CPropertyGetter_003Eb__2()
		{
			return info.InitValue;
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_1
	{
		public string subTypeUid;

		public EntityDescriptor _003C_003E4__this;

		internal object _003CPropertyGetter_003Eb__3()
		{
			return ReactiveCollectionExtensions.CreateSpecificISet(subTypeUid, _003C_003E4__this.context);
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public PropertyInfo info;

		internal object _003CPropertySetter_003Eb__2()
		{
			return info.InitValue;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_1
	{
		public string subTypeUid;

		public EntityDescriptor _003C_003E4__this;

		internal object _003CPropertySetter_003Eb__3()
		{
			return ReactiveCollectionExtensions.CreateSpecificISet(subTypeUid, _003C_003E4__this.context);
		}
	}

	public const string UidPropertyName = "Uid";

	public const string ToStringPropertyName = "$toString";

	protected readonly IExtendEntityService ExtendEntityService;

	internal readonly ConvertContext context;

	public static readonly Guid UID = TypeConstants.EntityUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Все объекты");

	public override Guid ParentUid => Guid.Empty;

	public EntityDescriptor(IProxyGeneratorService proxyGeneratorService, IExtendEntityService extendEntityService, ILogger logger)
		: base(logger)
	{
		ExtendEntityService = extendEntityService;
		context = new ConvertContext
		{
			ProxyGeneratorService = proxyGeneratorService,
			ExtendEntityService = extendEntityService
		};
	}

	public override bool ShouldSerialize(IPropertyMetadata property, IMetadata metadata)
	{
		PropertyMetadata val;
		if (metadata is TablePartMetadata && ((INamedMetadata)property).get_Name() == "Parent" && (val = (PropertyMetadata)(object)((property is PropertyMetadata) ? property : null)) != null)
		{
			return !val.get_IsSystem();
		}
		return base.ShouldSerialize(property, metadata);
	}

	public override bool IsNullable(IPropertyMetadata property)
	{
		return true;
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (((EntitySettings)propertyInfo.PropertyMetadata.get_Settings()).get_RelationType() == 0)
		{
			return delegate(GetterInfo getterInfo, PropertyInfo info)
			{
				_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
				CS_0024_003C_003E8__locals0.info = info;
				return ConvertHelper.GetEntityHeader(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, context, () => CS_0024_003C_003E8__locals0.info.InitValue);
			};
		}
		return delegate(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass14_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_1();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.subTypeUid = info.SubTypeUid;
			return ConvertHelper.GetSetCollection(ObjectExtensions.As<System.Type>((object)DTOHelper.ProxyType(CS_0024_003C_003E8__locals0.subTypeUid)), getterInfo.Target, info.Expression, info.ShouldSerialize, context, () => ReactiveCollectionExtensions.CreateSpecificISet(CS_0024_003C_003E8__locals0.subTypeUid, CS_0024_003C_003E8__locals0._003C_003E4__this.context));
		};
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (((EntitySettings)propertyInfo.PropertyMetadata.get_Settings()).get_RelationType() == 0)
		{
			return delegate(SetterInfo setterInfo, PropertyInfo info)
			{
				_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
				CS_0024_003C_003E8__locals0.info = info;
				ConvertHelper.SetEntityHeader(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, ObjectExtensions.As<Entity>(setterInfo.Value), CS_0024_003C_003E8__locals0.info.ShouldSerialize, context, () => CS_0024_003C_003E8__locals0.info.InitValue);
			};
		}
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass15_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_1();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.subTypeUid = info.SubTypeUid;
			ConvertHelper.SetSetCollection(setterInfo.Target, info.Expression, (System.Collections.Generic.IEnumerable<Entity>)ObjectExtensions.As<System.Collections.Generic.ICollection<Entity>>(setterInfo.Value), info.ShouldSerialize, context, () => ReactiveCollectionExtensions.CreateSpecificISet(CS_0024_003C_003E8__locals0.subTypeUid, CS_0024_003C_003E8__locals0._003C_003E4__this.context));
		};
	}

	public override TypeSettings CreateSettings()
	{
		EntitySettings obj = ObjectExtensions.As<EntitySettings>((object)base.CreateSettings());
		obj.set_MaxCount(100);
		return (TypeSettings)(object)obj;
	}

	public override void InitSettingsFromSettings(TypeSettings typeSettings, TypeSettings newSettings)
	{
		EntitySettings obj = ObjectExtensions.As<EntitySettings>((object)typeSettings);
		EntitySettings val = ObjectExtensions.As<EntitySettings>((object)newSettings);
		obj.set_DisplayType(val.get_DisplayType());
		obj.set_RelationType(val.get_RelationType());
		obj.set_CascadeMode(val.get_CascadeMode());
		obj.set_MaxCount(val.get_MaxCount());
	}

	private object _003CPropertyGetter_003Eb__14_0(GetterInfo getterInfo, PropertyInfo info)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals0.info = info;
		return ConvertHelper.GetEntityHeader(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, context, () => CS_0024_003C_003E8__locals0.info.InitValue);
	}

	private object _003CPropertyGetter_003Eb__14_1(GetterInfo getterInfo, PropertyInfo info)
	{
		_003C_003Ec__DisplayClass14_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_1();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.subTypeUid = info.SubTypeUid;
		return ConvertHelper.GetSetCollection(ObjectExtensions.As<System.Type>((object)DTOHelper.ProxyType(CS_0024_003C_003E8__locals0.subTypeUid)), getterInfo.Target, info.Expression, info.ShouldSerialize, context, () => ReactiveCollectionExtensions.CreateSpecificISet(CS_0024_003C_003E8__locals0.subTypeUid, CS_0024_003C_003E8__locals0._003C_003E4__this.context));
	}

	private void _003CPropertySetter_003Eb__15_0(SetterInfo setterInfo, PropertyInfo info)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals0.info = info;
		ConvertHelper.SetEntityHeader(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, ObjectExtensions.As<Entity>(setterInfo.Value), CS_0024_003C_003E8__locals0.info.ShouldSerialize, context, () => CS_0024_003C_003E8__locals0.info.InitValue);
	}

	private void _003CPropertySetter_003Eb__15_1(SetterInfo setterInfo, PropertyInfo info)
	{
		_003C_003Ec__DisplayClass15_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_1();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.subTypeUid = info.SubTypeUid;
		ConvertHelper.SetSetCollection(setterInfo.Target, info.Expression, (System.Collections.Generic.IEnumerable<Entity>)ObjectExtensions.As<System.Collections.Generic.ICollection<Entity>>(setterInfo.Value), info.ShouldSerialize, context, () => ReactiveCollectionExtensions.CreateSpecificISet(CS_0024_003C_003E8__locals0.subTypeUid, CS_0024_003C_003E8__locals0._003C_003E4__this.context));
	}
}
