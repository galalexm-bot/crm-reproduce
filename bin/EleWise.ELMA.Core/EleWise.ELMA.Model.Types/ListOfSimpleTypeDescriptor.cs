using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

public sealed class ListOfSimpleTypeDescriptor : CLRTypeDescriptor<object, ListOfSimpleTypeSettings>
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public System.Type itemType;

		public ListOfSimpleTypeDescriptor _003C_003E4__this;

		public Func<object> _003C_003E9__1;

		internal object _003CPropertyGetter_003Eb__0(GetterInfo getterInfo, PropertyInfo info)
		{
			return ConvertHelper.GetCollection(itemType, getterInfo.Target, info.Expression, info.ShouldSerialize, _003C_003E4__this.context, () => Activator.CreateInstance(typeof(ReactiveCollection<>).MakeGenericType(new System.Type[1] { itemType })));
		}

		internal object _003CPropertyGetter_003Eb__1()
		{
			return Activator.CreateInstance(typeof(ReactiveCollection<>).MakeGenericType(new System.Type[1] { itemType }));
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public System.Type itemType;

		public ListOfSimpleTypeDescriptor _003C_003E4__this;

		public Func<object> _003C_003E9__1;

		internal void _003CPropertySetter_003Eb__0(SetterInfo setterInfo, PropertyInfo info)
		{
			ConvertHelper.SetCollection(itemType, setterInfo.Target, info.Expression, setterInfo.Value as System.Collections.ICollection, info.ShouldSerialize, _003C_003E4__this.context, () => Activator.CreateInstance(typeof(ReactiveCollection<>).MakeGenericType(new System.Type[1] { itemType })));
		}

		internal object _003CPropertySetter_003Eb__1()
		{
			return Activator.CreateInstance(typeof(ReactiveCollection<>).MakeGenericType(new System.Type[1] { itemType }));
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public System.Type itemType;

		internal object _003CSystemPropertyGetter_003Eb__0()
		{
			return Activator.CreateInstance(typeof(ReactiveCollection<>).MakeGenericType(new System.Type[1] { itemType }));
		}
	}

	private readonly IDescriptorService descriptorService;

	private readonly Dictionary<Guid, System.Type> typeCache;

	private readonly ConvertContext context;

	public static readonly Guid UID = TypeConstants.ListOfSimpleTypeUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Список из простых типов");

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public ListOfSimpleTypeDescriptor(IProxyGeneratorService proxyGeneratorService, IExtendEntityService extendEntityService, IDescriptorService descriptorService, ILogger logger)
		: base(logger)
	{
		this.descriptorService = descriptorService;
		typeCache = new Dictionary<Guid, System.Type>();
		context = new ConvertContext
		{
			ProxyGeneratorService = proxyGeneratorService,
			ExtendEntityService = extendEntityService
		};
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass11_0 obj = new _003C_003Ec__DisplayClass11_0
		{
			_003C_003E4__this = this
		};
		Guid simpleTypeUid = ((ListOfSimpleTypeSettings)propertyInfo.PropertyMetadata.get_Settings()).get_SimpleTypeUid();
		obj.itemType = GetItemType(simpleTypeUid);
		return (GetterInfo getterInfo, PropertyInfo info) => ConvertHelper.GetCollection(obj.itemType, getterInfo.Target, info.Expression, info.ShouldSerialize, obj._003C_003E4__this.context, () => Activator.CreateInstance(typeof(ReactiveCollection<>).MakeGenericType(new System.Type[1] { obj.itemType })));
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass12_0 obj = new _003C_003Ec__DisplayClass12_0
		{
			_003C_003E4__this = this
		};
		Guid simpleTypeUid = ((ListOfSimpleTypeSettings)propertyInfo.PropertyMetadata.get_Settings()).get_SimpleTypeUid();
		obj.itemType = GetItemType(simpleTypeUid);
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			ConvertHelper.SetCollection(obj.itemType, setterInfo.Target, info.Expression, setterInfo.Value as System.Collections.ICollection, info.ShouldSerialize, obj._003C_003E4__this.context, () => Activator.CreateInstance(typeof(ReactiveCollection<>).MakeGenericType(new System.Type[1] { obj.itemType })));
		};
	}

	public override object SystemPropertyGetter(object target, PropertyInfoExpression expression, SystemPropertyInfo propertyInfo)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
		object serviceInfo = propertyInfo.ServiceInfo;
		if (serviceInfo == null)
		{
			return null;
		}
		Guid simpleTypeUid = ObjectExtensions.As<Guid>(serviceInfo.get_Item("SimpleTypeUid"));
		CS_0024_003C_003E8__locals0.itemType = GetItemType(simpleTypeUid);
		return ConvertHelper.GetCollection(CS_0024_003C_003E8__locals0.itemType, target, expression, shouldSerialize: true, null, () => Activator.CreateInstance(typeof(ReactiveCollection<>).MakeGenericType(new System.Type[1] { CS_0024_003C_003E8__locals0.itemType })));
	}

	private System.Type GetItemType(Guid simpleTypeUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		System.Type type = default(System.Type);
		if (typeCache.TryGetValue(simpleTypeUid, ref type))
		{
			return type;
		}
		ITypeDescriptor typeDescriptor = descriptorService.GetTypeDescriptor(simpleTypeUid, Guid.Empty);
		ITypeDescriptor typeDescriptor2 = typeDescriptor;
		if (typeDescriptor2 != null)
		{
			if (typeDescriptor2 is IRuntimeTypeDescriptor runtimeTypeDescriptor)
			{
				type = runtimeTypeDescriptor.RuntimeType;
				typeCache.set_Item(simpleTypeUid, type);
			}
			else
			{
				System.Type firstGenericType = GetFirstGenericType(((object)typeDescriptor).GetType());
				if (firstGenericType != null)
				{
					type = firstGenericType.GetGenericArguments()[0];
					typeCache.set_Item(simpleTypeUid, type);
				}
			}
			return type;
		}
		throw new System.Exception(SR.T("Не найден дескриптор для типа, {0}", simpleTypeUid));
	}

	private static System.Type GetFirstGenericType(System.Type type)
	{
		if (type.get_IsGenericType() && type.GetGenericTypeDefinition() == typeof(TypeDescriptor<>))
		{
			return type;
		}
		if (type.get_BaseType() == null)
		{
			return null;
		}
		return GetFirstGenericType(type.get_BaseType());
	}
}
