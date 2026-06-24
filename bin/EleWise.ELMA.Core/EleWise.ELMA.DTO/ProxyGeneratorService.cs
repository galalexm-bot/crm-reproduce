using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge;
using Bridge.Html5;
using EleWise.ELMA.Converters;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Core.Engine.Metadata.Services.Abstractions;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Ioc;
using EleWise.ELMA.Model.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Storages;

namespace EleWise.ELMA.DTO;

[Service]
internal sealed class ProxyGeneratorService : IProxyGeneratorServiceInternal, IProxyGeneratorService
{
	[StructLayout(3)]
	private struct _003CGenerateProxyByStringUidAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ReactiveProxy> _003C_003Et__builder;

		public string typeUid;

		public ProxyGeneratorService _003C_003E4__this;

		private Guid _003Cuid_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ProxyGeneratorService proxyGeneratorService = _003C_003E4__this;
			ReactiveProxy result2;
			try
			{
				TaskAwaiter<IMetadata> val;
				if (num != 0)
				{
					_003Cuid_003E5__2 = new Guid(typeUid);
					val = proxyGeneratorService.metadataService.GetMetadataAsync(_003Cuid_003E5__2).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CGenerateProxyByStringUidAsync_003Ed__7>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				IMetadata result = val.GetResult();
				ClassMetadata md;
				if ((md = (ClassMetadata)(object)((result is ClassMetadata) ? result : null)) == null)
				{
					throw new MetadataNotFoundException(_003Cuid_003E5__2);
				}
				result2 = proxyGeneratorService.GenerateProxy(md);
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	internal readonly IMetadataServiceContext metadataService;

	private readonly IDescriptorService descriptorService;

	private readonly System.Collections.Generic.IEnumerable<IValueConverter> converters;

	private readonly IProxyCacheService proxyCacheService;

	private readonly ILazy<IEntityStorage> lazyEntityStorage;

	internal ISystemMetadataService SystemMetadataService;

	private IEntityStorage entityStorage;

	internal IEntityStorage EntityStorage => entityStorage ?? (entityStorage = lazyEntityStorage.Value());

	public ProxyGeneratorService(IMetadataServiceContext metadataService, IDescriptorService descriptorService, System.Collections.Generic.IEnumerable<IValueConverter> converters, IProxyCacheService proxyCacheService, ILazy<IEntityStorage> lazyEntityStorage)
	{
		this.metadataService = metadataService;
		this.descriptorService = descriptorService;
		this.converters = converters;
		this.proxyCacheService = proxyCacheService;
		this.lazyEntityStorage = lazyEntityStorage;
	}

	public System.Threading.Tasks.Task<ReactiveProxy> GenerateProxyByStringUidAsync(string typeUid)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CGenerateProxyByStringUidAsync_003Ed__7 _003CGenerateProxyByStringUidAsync_003Ed__ = default(_003CGenerateProxyByStringUidAsync_003Ed__7);
		_003CGenerateProxyByStringUidAsync_003Ed__._003C_003E4__this = this;
		_003CGenerateProxyByStringUidAsync_003Ed__.typeUid = typeUid;
		_003CGenerateProxyByStringUidAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ReactiveProxy>.Create();
		_003CGenerateProxyByStringUidAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ReactiveProxy> _003C_003Et__builder = _003CGenerateProxyByStringUidAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGenerateProxyByStringUidAsync_003Ed__7>(ref _003CGenerateProxyByStringUidAsync_003Ed__);
		return _003CGenerateProxyByStringUidAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	public ReactiveProxy GenerateProxyByStringUid(string typeUid)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		Guid val = default(Guid);
		((Guid)(ref val))._002Ector(typeUid);
		IMetadata metadata = metadataService.GetMetadata(val);
		ClassMetadata md;
		if ((md = (ClassMetadata)(object)((metadata is ClassMetadata) ? metadata : null)) == null)
		{
			throw new MetadataNotFoundException(val);
		}
		return GenerateProxy(md);
	}

	internal ReactiveProxy GenerateProxyByStringUidOrNull(string typeUid)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		Guid metadataUid = default(Guid);
		((Guid)(ref metadataUid))._002Ector(typeUid);
		IMetadata metadata = metadataService.GetMetadata(metadataUid);
		ClassMetadata md;
		if ((md = (ClassMetadata)(object)((metadata is ClassMetadata) ? metadata : null)) == null)
		{
			return null;
		}
		return GenerateProxy(md);
	}

	public ReactiveProxy GenerateProxy(string hash)
	{
		return GenerateProxyOrNull(hash) ?? throw new ProxyGenerationException(hash);
	}

	public ReactiveProxy GenerateProxyOrNull(string hash)
	{
		IMetadata metadataByHash = metadataService.GetMetadataByHash(hash);
		ClassMetadata md;
		if ((md = (ClassMetadata)(object)((metadataByHash is ClassMetadata) ? metadataByHash : null)) == null)
		{
			return null;
		}
		return GenerateProxy(md);
	}

	public ReactiveProxy GenerateProxy(ClassMetadata md)
	{
		return GenerateProxyOrNull(md) ?? throw new ProxyGenerationException();
	}

	public ReactiveProxy GenerateProxyOrNull(ClassMetadata md)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (md == null)
		{
			return null;
		}
		Guid uid = ((IMetadata)md).get_Uid();
		string text = ((object)(Guid)(ref uid)).ToString();
		ReactiveProxy reactiveProxy = proxyCacheService.Get(text);
		if (reactiveProxy != null)
		{
			AfterCreate(reactiveProxy, (INamedMetadata)(object)md);
			return reactiveProxy;
		}
		reactiveProxy = new ReactiveProxy(metadataService, this)
		{
			Json = new object(),
			Metadata = md
		};
		DataClassMetadata val;
		if ((val = (DataClassMetadata)(object)((md is DataClassMetadata) ? md : null)) != null)
		{
			WriteTypeAttributes(reactiveProxy, val, text);
			ExtendDataClass(reactiveProxy, (System.Collections.Generic.IEnumerable<DataClassDependency>)val.get_IncludeList());
		}
		EntityMetadata val2;
		if ((val2 = (EntityMetadata)(object)((md is EntityMetadata) ? md : null)) != null)
		{
			WriteEntityTypeAttributes(reactiveProxy, val2, text);
			ExtendEntity(reactiveProxy, val2);
		}
		DefineProps(reactiveProxy, md);
		AfterCreate(reactiveProxy, (INamedMetadata)(object)md);
		proxyCacheService.Add(text, reactiveProxy);
		return reactiveProxy;
	}

	public ReactiveProxy CreateProxy(ClassMetadata metadata, object serializedModel)
	{
		object obj = ((!(serializedModel is string text)) ? JSON.Parse(JSON.Stringify(serializedModel)) : JSON.Parse(text));
		if (metadata is DataClassMetadata)
		{
			ReactiveProxy reactiveProxy = GenerateProxy(metadata);
			ConvertHelper.Reconcile(reactiveProxy, obj, Script.Write<object>("globals.reconcileContext", new object[0]));
			return reactiveProxy;
		}
		return EntityStorage.GetOrAdd(ObjectExtensions.As<string>(obj.get_Item("TypeUid")), ObjectExtensions.As<string>(obj.get_Item("Uid")), obj).As<ReactiveProxy>();
	}

	public System.Collections.Generic.IEnumerable<IPropertyMetadata> DefineProps(ReactiveProxy proxy, ClassMetadata metadata)
	{
		return DefineProps(proxy, metadata, containsAliasProperties: false);
	}

	private System.Collections.Generic.IEnumerable<IPropertyMetadata> DefineProps(ReactiveProxy proxy, ClassMetadata metadata, bool containsAliasProperties)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (proxy == null)
		{
			return (System.Collections.Generic.IEnumerable<IPropertyMetadata>)Enumerable.Empty<IPropertyMetadata>();
		}
		Contract.ArgumentNotNull(metadata, "metadata");
		System.Collections.Generic.IEnumerable<IPropertyMetadata> properties = metadataService.GetProperties(metadata, metadata is EntityMetadata);
		IPropertyMetadata[] array = (IPropertyMetadata[])(object)new IPropertyMetadata[0];
		System.Collections.Generic.IEnumerator<IPropertyMetadata> enumerator = properties.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				IPropertyMetadata current = enumerator.get_Current();
				PropertyInfoExpression propertyExpression = metadataService.GetPropertyExpression(current, metadata);
				if (!proxy.HasProperty(propertyExpression.ObjectExpression) && descriptorService.GetTypeDescriptor(current.get_TypeUid(), current.get_SubTypeUid()) is TypeDescriptor typeDescriptor)
				{
					bool flag = typeDescriptor.ShouldSerialize(current, (IMetadata)(object)metadata);
					if (containsAliasProperties && (((INamedMetadata)current).get_Name() == "Model" || ((INamedMetadata)current).get_Name() == "WorkflowTask"))
					{
						flag = false;
					}
					bool flag2 = typeDescriptor.HasSetter(current);
					bool flag3 = typeDescriptor.IsNullable(current);
					AddPropertyRef(proxy, propertyExpression);
					ClosureHelper.Closure<object, PropertyInfoExpression, PropertyMetadata, TypeDescriptor, bool, bool, bool>(proxy, DefineProperty, new object[7] { proxy, propertyExpression, current, typeDescriptor, flag, flag3, flag2 });
					ArrayExtensions.Push<IPropertyMetadata>(array, (IPropertyMetadata[])(object)new IPropertyMetadata[1] { current });
				}
			}
			return array;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private static void WriteTypeAttributes(ReactiveProxy proxy, DataClassMetadata dataClassMd, string dataClassMdUidString)
	{
		string text = (proxy.TypeRef = dataClassMd.get_TypeRef());
		proxy.Json.set_Item("$t", (object)text);
		proxy.CanCast = new object();
		Script.Write("proxy.$$canCast[{0}] = true", new object[1] { dataClassMdUidString });
	}

	private void WriteEntityTypeAttributes(ReactiveProxy proxy, EntityMetadata entityMetadata, string entityMdUidString)
	{
		proxy.isEntity = true;
		proxy.CanCast = new object();
		CastGeneration(proxy, entityMetadata, entityMdUidString);
	}

	private void CastGeneration(ReactiveProxy proxy, EntityMetadata metadata, string entityMdUidString)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (metadata == null)
		{
			return;
		}
		Script.Write("proxy.$$canCast[{0}] = true", new object[1] { entityMdUidString });
		object[] array = new object[1];
		Guid val = metadata.get_ImplementationUid();
		array[0] = ((object)(Guid)(ref val)).ToString();
		Script.Write("proxy.$$canCast[{0}] = true", array);
		if (!(((ClassMetadata)metadata).get_BaseClassUid() == Guid.Empty))
		{
			IMetadata metadata2 = metadataService.GetMetadata(((ClassMetadata)metadata).get_BaseClassUid());
			EntityMetadata val2 = (EntityMetadata)(object)((metadata2 is EntityMetadata) ? metadata2 : null);
			object entityMdUidString2;
			if (val2 == null)
			{
				entityMdUidString2 = null;
			}
			else
			{
				val = ((IMetadata)val2).get_Uid();
				entityMdUidString2 = ((object)(Guid)(ref val)).ToString();
			}
			CastGeneration(proxy, val2, (string)entityMdUidString2);
		}
	}

	internal static void DefineAliasProperty(object proxy, PropertyInfoExpression originalExpression, PropertyInfoExpression aliasExpression, bool hasSetter)
	{
		ClosureHelper.Closure<object, PropertyInfoExpression, PropertyInfoExpression, bool>(proxy, DefineInterfaceProperty, new object[4] { proxy, aliasExpression, originalExpression, hasSetter });
	}

	private void ExtendDataClass(ReactiveProxy value, System.Collections.Generic.IEnumerable<DataClassDependency> includeList)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		IMetadata[] array = Enumerable.Select<DataClassDependency, IMetadata>(includeList, (Func<DataClassDependency, IMetadata>)((DataClassDependency a) => metadataService.GetMetadata(((Dependency)a).get_HeaderUid()))).ToArray();
		string text = "EleWise.ELMA.Model.Entities.ProcessContext.ViewModelContext";
		IMetadata[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			DataClassMetadata val = (DataClassMetadata)array2[i];
			bool containsAliasProperties = ((ICodeItemMetadata)val).get_FullTypeName() == text;
			object[] array3 = new object[1];
			Guid uid = ((IMetadata)val).get_Uid();
			array3[0] = ((object)(Guid)(ref uid)).ToString();
			Script.Write("value.$$canCast[{0}] = true", array3);
			DefineProps(value, (ClassMetadata)(object)val, containsAliasProperties);
			ExtendDataClass(value, (System.Collections.Generic.IEnumerable<DataClassDependency>)val.get_IncludeList());
		}
	}

	private void ExtendEntity(ReactiveProxy value, EntityMetadata metadata)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		EntityMetadataType type = (EntityMetadataType)metadata.get_Type();
		Guid val = ((type == EntityMetadataType.InterfaceImplementation || type == EntityMetadataType.Entity) ? ((IMetadata)metadata).get_Uid() : metadata.get_ImplementationUid());
		PropertyMetadata val2 = InterfaceCreator.Create<PropertyMetadata>();
		((IPropertyMetadata)val2).set_Settings((TypeSettings)(object)InterfaceCreator.Create<GuidSettings>());
		((INamedMetadata)val2).set_Name("TypeUid");
		string name = ((INamedMetadata)val2).get_Name();
		PropertyInfoExpression propertyInfoExpression = new PropertyInfoExpression
		{
			ObjectExpression = name,
			ExpressionForSerialize = name
		};
		ITypeDescriptor typeDescriptor = descriptorService.GetTypeDescriptor(GuidDescriptor.UID, Guid.Empty);
		ClosureHelper.Closure<object, PropertyInfoExpression, PropertyMetadata, TypeDescriptor, bool, bool, bool>(value, DefineProperty, new object[7] { value, propertyInfoExpression, val2, typeDescriptor, true, false, true });
		value.SetPlainPropertyValue(((INamedMetadata)val2).get_Name(), val);
		AddPropertyRef(value, propertyInfoExpression);
		ValueTuple<PropertyMetadata, ITypeDescriptor> idProperty = metadata.GetIdProperty(descriptorService);
		PropertyMetadata item = idProperty.Item1;
		ITypeDescriptor item2 = idProperty.Item2;
		if (item != null && item2 != null)
		{
			string name2 = ((INamedMetadata)item).get_Name();
			PropertyInfoExpression propertyInfoExpression2 = new PropertyInfoExpression
			{
				ObjectExpression = name2,
				ExpressionForSerialize = name2
			};
			ClosureHelper.Closure<object, PropertyInfoExpression, PropertyMetadata, TypeDescriptor, bool, bool, bool>(value, DefineProperty, new object[7] { value, propertyInfoExpression2, item, item2, true, false, true });
			AddPropertyRef(value, propertyInfoExpression2);
		}
	}

	private static void AddPropertyRef(ReactiveProxy proxy, PropertyInfoExpression expressionInfo)
	{
		proxy.PropertyRef.set_Item(expressionInfo.ExpressionForSerialize, (object)expressionInfo.ObjectExpression);
	}

	private static void AfterCreate(ReactiveProxy proxy, INamedMetadata metadata)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		proxy.TypeName = metadata.get_Name();
		if (metadata is EntityMetadata)
		{
			object json = proxy.Json;
			Guid val = Guid.NewGuid();
			json.SetAndCreatePlainPropertyValue("Uid", ((object)(Guid)(ref val)).ToString());
		}
	}

	private void DefineProperty(object proxy, PropertyInfoExpression expression, PropertyMetadata property, TypeDescriptor descriptor, bool shouldSerialize, bool nullable, bool hasSetter)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		DefaultValueHelper.TryGetInitValue(metadataService, descriptorService, (IPropertyMetadata)(object)property, converters, out var result);
		PropertyInfo obj = new PropertyInfo
		{
			Expression = expression,
			InitValue = result,
			Nullable = nullable,
			PropertyMetadata = (IPropertyMetadata)(object)property,
			ShouldSerialize = shouldSerialize
		};
		Guid subTypeUid = ((IPropertyMetadata)property).get_SubTypeUid();
		obj.SubTypeUid = ((object)(Guid)(ref subTypeUid)).ToString();
		PropertyInfo propertyInfo = obj;
		Func<GetterInfo, PropertyInfo, object> val = descriptor.PropertyGetter(propertyInfo);
		Action<SetterInfo, PropertyInfo> val2 = null;
		if (hasSetter)
		{
			val2 = descriptor.PropertySetter(propertyInfo);
		}
		Script.Write("\r\n                var attributes = {\r\n                    configurable: true,\r\n                    enumerable: true,\r\n                    get: function() {\r\n                        var getterInfo = {\r\n                            Target: this\r\n                        };\r\n                        return Bridge.unbox({2}(getterInfo, {4}));\r\n                    }\r\n                };\r\n                if ({3} != null) {\r\n                    attributes.set = function(v) {\r\n                        var setterInfo = {\r\n                            Target: this,\r\n                            Value: v\r\n                        };\r\n                        {3}(setterInfo, {4});\r\n                    }\r\n                }\r\n                Object.defineProperty({1}, {0}, attributes);\r\n", new object[5] { expression.ObjectExpression, proxy, val, val2, propertyInfo });
	}

	private static void DefineInterfaceProperty(object proxy, PropertyInfoExpression expressionInfo, PropertyInfoExpression originalExpressionInfo, bool hasSetter)
	{
		Script.Write("\r\n                var attributes = {\r\n                    configurable: true,\r\n                    enumerable: true,\r\n                    get: function() {\r\n                        return this[{1}];\r\n                    }\r\n                };\r\n                if (hasSetter) {\r\n                    attributes.set = function(v) {\r\n                        this[{1}] = v;\r\n                    }\r\n                }\r\n                Object.defineProperty({0}, {2}, attributes);\r\n", new object[3] { proxy, originalExpressionInfo.ObjectExpression, expressionInfo.ObjectExpression });
	}

	private static IProxyGeneratorService GetProxyGeneratorService(object obj)
	{
		IProxyGeneratorService proxyGeneratorService = null;
		if (obj != null && obj.HasProperty("$proxyGenerator"))
		{
			proxyGeneratorService = obj.GetPlainPropertyValue<IProxyGeneratorService>("$proxyGenerator");
		}
		return proxyGeneratorService ?? ProxyGeneratorServiceContext.ProxyGenerator;
	}

	private IMetadata _003CExtendDataClass_003Eb__24_0(DataClassDependency a)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetMetadata(((Dependency)a).get_HeaderUid());
	}
}
