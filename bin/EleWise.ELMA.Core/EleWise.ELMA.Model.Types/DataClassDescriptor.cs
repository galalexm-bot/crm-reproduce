using System;
using System.Collections;
using Bridge;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Engine.Metadata;
using EleWise.ELMA.Core.Engine.Metadata.Services.Abstractions;
using EleWise.ELMA.Core.Engine.Proxy;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 650)]
public class DataClassDescriptor : RefTypeDescriptor<IDataClass, DataClassSettings>
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public PropertyInfo info;

		internal object _003CPropertyGetter_003Eb__2()
		{
			return info.InitValue;
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_1
	{
		public string subTypeUid;

		public DataClassDescriptor _003C_003E4__this;

		internal object _003CPropertyGetter_003Eb__3()
		{
			return ReactiveCollectionExtensions.CreateSpecificCollection(subTypeUid, _003C_003E4__this.context);
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public PropertyInfo info;

		internal object _003CPropertySetter_003Eb__2()
		{
			return info.InitValue;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_1
	{
		public string subTypeUid;

		public DataClassDescriptor _003C_003E4__this;

		internal object _003CPropertySetter_003Eb__3()
		{
			return ReactiveCollectionExtensions.CreateSpecificCollection(subTypeUid, _003C_003E4__this.context);
		}
	}

	private readonly IExtendEntityService extendEntityService;

	private readonly ConvertContext context;

	public static readonly Guid UID = TypeConstants.DataClassUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Структуры обмена данными");

	public override Guid ParentUid => Guid.Empty;

	public DataClassDescriptor(IProxyGeneratorService proxyGeneratorService, IExtendEntityService extendEntityService, ILogger logger)
		: base(logger)
	{
		context = new ConvertContext
		{
			ProxyGeneratorService = proxyGeneratorService,
			ExtendEntityService = extendEntityService
		};
	}

	public override bool IsNullable(IPropertyMetadata property)
	{
		return true;
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (((DataClassSettings)propertyInfo.PropertyMetadata.get_Settings()).get_RelationType() == 0)
		{
			return delegate(GetterInfo getterInfo, PropertyInfo info)
			{
				_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
				CS_0024_003C_003E8__locals0.info = info;
				return ConvertHelper.GetContract(DTOHelper.ProxyType(CS_0024_003C_003E8__locals0.info.SubTypeUid), getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, context, () => CS_0024_003C_003E8__locals0.info.InitValue);
			};
		}
		return delegate(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass11_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_1();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.subTypeUid = info.SubTypeUid;
			return ConvertHelper.GetCollection(ObjectExtensions.As<System.Type>((object)DTOHelper.ProxyType(CS_0024_003C_003E8__locals0.subTypeUid)), getterInfo.Target, info.Expression, info.ShouldSerialize, context, () => ReactiveCollectionExtensions.CreateSpecificCollection(CS_0024_003C_003E8__locals0.subTypeUid, CS_0024_003C_003E8__locals0._003C_003E4__this.context));
		};
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (((DataClassSettings)propertyInfo.PropertyMetadata.get_Settings()).get_RelationType() == 0)
		{
			return delegate(SetterInfo setterInfo, PropertyInfo info)
			{
				_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
				CS_0024_003C_003E8__locals0.info = info;
				ConvertHelper.SetContract(DTOHelper.ProxyType(CS_0024_003C_003E8__locals0.info.SubTypeUid), setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, context, () => CS_0024_003C_003E8__locals0.info.InitValue);
			};
		}
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass12_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_1();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.subTypeUid = info.SubTypeUid;
			ConvertHelper.SetCollection(ObjectExtensions.As<System.Type>((object)DTOHelper.ProxyType(CS_0024_003C_003E8__locals0.subTypeUid)), setterInfo.Target, info.Expression, ObjectExtensions.As<System.Collections.ICollection>(setterInfo.Value), info.ShouldSerialize, context, () => ReactiveCollectionExtensions.CreateSpecificCollection(CS_0024_003C_003E8__locals0.subTypeUid, CS_0024_003C_003E8__locals0._003C_003E4__this.context));
		};
	}

	public override void InitSettingsFromSettings(TypeSettings typeSettings, TypeSettings newSettings)
	{
		DataClassSettings obj = ObjectExtensions.As<DataClassSettings>((object)typeSettings);
		DataClassSettings val = ObjectExtensions.As<DataClassSettings>((object)newSettings);
		obj.set_RelationType(val.get_RelationType());
	}

	public override object SystemPropertyGetter(object target, PropertyInfoExpression expression, SystemPropertyInfo propertyInfo)
	{
		object obj = target.get_Item("$properties");
		if (obj == null)
		{
			Script.Write("properties = Reactive.modules.getReactive().convertHelper.getIProxyProperty()", new object[0]);
			target.set_Item("$properties", obj);
		}
		_ = expression.ObjectExpression;
		object obj2 = null;
		object obj3 = obj2.get_Item("$bridge");
		if (obj3 == null)
		{
			obj3 = new object();
			Script.Write("bridge.$status = 0", new object[0]);
			obj3.set_Item("$cache", (object)null);
			obj2.set_Item("$bridge", obj3);
		}
		if (Script.Write<bool>("bridge.$status === 2 || bridge.$status === 3", new object[0]))
		{
			return obj3.get_Item("$cache");
		}
		ISystemMetadataTypeReferenceStorage systemMetadataTypeReferenceStorage = ObjectExtensions.As<ISystemMetadataTypeReferenceStorage>(propertyInfo.ServiceInfo.get_Item("ISystemMetadataTypeReferenceStorage"));
		ISystemMetadataService systemService = ObjectExtensions.As<ISystemMetadataService>(propertyInfo.ServiceInfo.get_Item("ISystemMetadataService"));
		ISystemMetadataProxyGenerator systemProxyGenerator = ObjectExtensions.As<ISystemMetadataProxyGenerator>(propertyInfo.ServiceInfo.get_Item("ISystemMetadataProxyGenerator"));
		object obj4 = target.get_Item("$jsonObj").get_Item(expression.ExpressionForSerialize);
		if (!propertyInfo.IsCollection)
		{
			ReactiveProxy systemObj = GetSystemObj(obj4, systemService, systemMetadataTypeReferenceStorage, systemProxyGenerator);
			obj3.set_Item("$cache", (object)systemObj);
			Script.Write("bridge.$status = 2", new object[0]);
			return systemObj;
		}
		ReactiveProxy[] array = new ReactiveProxy[0];
		object[] array2 = ObjectExtensions.As<object[]>(obj4) ?? new object[0];
		foreach (object serialized in array2)
		{
			ReactiveProxy systemObj2 = GetSystemObj(serialized, systemService, systemMetadataTypeReferenceStorage, systemProxyGenerator);
			ArrayExtensions.Push<ReactiveProxy>(array, new ReactiveProxy[1] { systemObj2 });
		}
		obj3.set_Item("$cache", (object)array);
		Script.Write("bridge.$status = 2", new object[0]);
		return array;
	}

	private ReactiveProxy GetSystemObj(object serialized, ISystemMetadataService systemService, ISystemMetadataTypeReferenceStorage systemMetadataTypeReferenceStorage, ISystemMetadataProxyGenerator systemProxyGenerator)
	{
		if (serialized == null)
		{
			return null;
		}
		string text = serialized.get_Item("$t").ToString();
		string metadataUid = systemMetadataTypeReferenceStorage.GetMetadataUid(text);
		ISystemMetadata metadata = systemService.GetMetadata(metadataUid);
		ISystemDataClassMetadata val = (ISystemDataClassMetadata)(object)((metadata is ISystemDataClassMetadata) ? metadata : null);
		ReactiveProxy reactiveProxy = ObjectExtensions.As<ReactiveProxy>(systemProxyGenerator.GenerateProxy(systemService, systemMetadataTypeReferenceStorage, val));
		reactiveProxy.Json = serialized;
		reactiveProxy.TypeRef = ObjectExtensions.As<string>(reactiveProxy.Json.get_Item("$t"));
		return reactiveProxy;
	}

	private object _003CPropertyGetter_003Eb__11_0(GetterInfo getterInfo, PropertyInfo info)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0.info = info;
		return ConvertHelper.GetContract(DTOHelper.ProxyType(CS_0024_003C_003E8__locals0.info.SubTypeUid), getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, context, () => CS_0024_003C_003E8__locals0.info.InitValue);
	}

	private object _003CPropertyGetter_003Eb__11_1(GetterInfo getterInfo, PropertyInfo info)
	{
		_003C_003Ec__DisplayClass11_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_1();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.subTypeUid = info.SubTypeUid;
		return ConvertHelper.GetCollection(ObjectExtensions.As<System.Type>((object)DTOHelper.ProxyType(CS_0024_003C_003E8__locals0.subTypeUid)), getterInfo.Target, info.Expression, info.ShouldSerialize, context, () => ReactiveCollectionExtensions.CreateSpecificCollection(CS_0024_003C_003E8__locals0.subTypeUid, CS_0024_003C_003E8__locals0._003C_003E4__this.context));
	}

	private void _003CPropertySetter_003Eb__12_0(SetterInfo setterInfo, PropertyInfo info)
	{
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals0.info = info;
		ConvertHelper.SetContract(DTOHelper.ProxyType(CS_0024_003C_003E8__locals0.info.SubTypeUid), setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, context, () => CS_0024_003C_003E8__locals0.info.InitValue);
	}

	private void _003CPropertySetter_003Eb__12_1(SetterInfo setterInfo, PropertyInfo info)
	{
		_003C_003Ec__DisplayClass12_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_1();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.subTypeUid = info.SubTypeUid;
		ConvertHelper.SetCollection(ObjectExtensions.As<System.Type>((object)DTOHelper.ProxyType(CS_0024_003C_003E8__locals0.subTypeUid)), setterInfo.Target, info.Expression, ObjectExtensions.As<System.Collections.ICollection>(setterInfo.Value), info.ShouldSerialize, context, () => ReactiveCollectionExtensions.CreateSpecificCollection(CS_0024_003C_003E8__locals0.subTypeUid, CS_0024_003C_003E8__locals0._003C_003E4__this.context));
	}
}
