using System;
using Bridge;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Engine.Metadata;
using EleWise.ELMA.Core.Engine.Metadata.Include;
using EleWise.ELMA.Core.Engine.Metadata.Services.Abstractions;
using EleWise.ELMA.Core.Engine.Metadata.Types;
using EleWise.ELMA.Core.Engine.Proxy;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Ioc;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Models;

namespace EleWise.ELMA.DTO;

[Service]
internal sealed class SystemProxyGeneratorService : ISystemProxyGeneratorService, ISystemMetadataProxyGenerator
{
	private readonly IMetadataServiceContext metadataService;

	private readonly IDescriptorService descriptorService;

	private readonly IProxyCacheService proxyCacheService;

	private readonly ILazy<ProxyGeneratorService> proxyGeneratorServiceLazy;

	private ProxyGeneratorService proxyGeneratorServiceCache;

	private ProxyGeneratorService ProxyGeneratorService => proxyGeneratorServiceCache ?? (proxyGeneratorServiceCache = proxyGeneratorServiceLazy.Value());

	public SystemProxyGeneratorService(IMetadataServiceContext metadataService, IDescriptorService descriptorService, IProxyCacheService proxyCacheService, ILazy<ProxyGeneratorService> proxyGeneratorServiceLazy)
	{
		this.metadataService = metadataService;
		this.descriptorService = descriptorService;
		this.proxyCacheService = proxyCacheService;
		this.proxyGeneratorServiceLazy = proxyGeneratorServiceLazy;
	}

	public object GenerateProxy(ISystemMetadataService systemMetadataService, ISystemMetadataTypeReferenceStorage systemMetadataTypeReferenceStorage, ISystemDataClassMetadata metadata)
	{
		return GenerateProxyInternal(systemMetadataService, systemMetadataTypeReferenceStorage, metadata);
	}

	private ReactiveProxy GenerateProxyInternal(ISystemMetadataService systemMetadataService, ISystemMetadataTypeReferenceStorage systemMetadataTypeReferenceStorage, ISystemDataClassMetadata metadata)
	{
		string uid = ((ISystemMetadata)metadata).get_Uid();
		ReactiveProxy reactiveProxy = proxyCacheService.Get(uid + "System");
		if (reactiveProxy != null)
		{
			return reactiveProxy;
		}
		string typeReference = systemMetadataTypeReferenceStorage.GetTypeReference(uid);
		ClassMetadata metadata2 = ObjectExtensions.As<ClassMetadata>((object)metadataService.GetMetadataByHash(typeReference)) ?? ObjectExtensions.As<ClassMetadata>((object)metadata);
		reactiveProxy = new ReactiveProxy(metadataService, ProxyGeneratorService)
		{
			Json = new object(),
			Metadata = metadata2
		};
		if (ProxyGeneratorService.SystemMetadataService == null)
		{
			ProxyGeneratorService.SystemMetadataService = systemMetadataService;
		}
		Script.Write("proxy.$shouldObserve = false", new object[0]);
		WriteTypeAttributes(reactiveProxy, typeReference, uid);
		string[] definedIncludes = new string[0];
		DefineProps(systemMetadataService, systemMetadataTypeReferenceStorage, reactiveProxy, metadata, definedIncludes);
		proxyCacheService.Add(uid + "System", reactiveProxy);
		return reactiveProxy;
	}

	private static void WriteTypeAttributes(ReactiveProxy proxy, string typeRef, string dataClassMdUidString)
	{
		proxy.TypeRef = typeRef;
		proxy.Json.set_Item("$t", (object)typeRef);
		proxy.CanCast = new object();
		Script.Write("proxy.$$canCast[{0}] = true", new object[1] { dataClassMdUidString });
	}

	private void DefineProps(ISystemMetadataService systemMetadataService, ISystemMetadataTypeReferenceStorage systemMetadataTypeReferenceStorage, ReactiveProxy proxy, ISystemDataClassMetadata dataClassMetadata, string[] definedIncludes)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		string uid = ((ISystemMetadata)dataClassMetadata).get_Uid();
		if (((System.Array)definedIncludes).IndexOf(uid) != -1)
		{
			return;
		}
		ArrayExtensions.Push<string>(definedIncludes, new string[1] { uid });
		Guid val = default(Guid);
		((Guid)(ref val))._002Ector(uid);
		string typeReference = systemMetadataTypeReferenceStorage.GetTypeReference(uid);
		ISystemPropertyMetadata[] properties = ((ISystemClassMetadata)dataClassMetadata).get_Properties();
		Guid typeUid = default(Guid);
		Guid subTypeUid = default(Guid);
		foreach (ISystemPropertyMetadata val2 in properties)
		{
			((Guid)(ref typeUid))._002Ector(val2.get_TypeUid());
			((Guid)(ref subTypeUid))._002Ector(val2.get_SubTypeUid());
			if (descriptorService.GetTypeDescriptor(typeUid, subTypeUid) is ISystemDescriptor systemDescriptor)
			{
				string name = ((ISystemNamedMetadata)val2).get_Name();
				string objectExpression = $"{name}${val:n}";
				string expressionForSerialize = typeReference + "$" + name;
				PropertyInfoExpression propertyInfoExpression = new PropertyInfoExpression
				{
					ObjectExpression = objectExpression,
					ExpressionForSerialize = expressionForSerialize
				};
				ISystemTypeSettings settings = val2.get_Settings();
				SystemPropertyInfo systemPropertyInfo = CreateSystemPropertyInfo(settings, systemMetadataService, systemMetadataTypeReferenceStorage);
				ClosureHelper.Closure<object, PropertyInfoExpression, ISystemDescriptor, SystemPropertyInfo>(proxy, DefineProperty, new object[4] { proxy, propertyInfoExpression, systemDescriptor, systemPropertyInfo });
				AddPropertyRef(proxy, propertyInfoExpression);
			}
		}
		ISystemDataClassDependency[] includeList = dataClassMetadata.get_IncludeList();
		for (int i = 0; i < includeList.Length; i++)
		{
			string headerUid = ((ISystemDependency)includeList[i]).get_HeaderUid();
			Script.Write("proxy.$$canCast[{0}] = true", new object[1] { headerUid });
			ISystemMetadata metadata = systemMetadataService.GetMetadata(headerUid);
			ISystemDataClassMetadata dataClassMetadata2 = (ISystemDataClassMetadata)(object)((metadata is ISystemDataClassMetadata) ? metadata : null);
			DefineProps(systemMetadataService, systemMetadataTypeReferenceStorage, proxy, dataClassMetadata2, definedIncludes);
		}
	}

	private static void AddPropertyRef(ReactiveProxy proxy, PropertyInfoExpression expressionInfo)
	{
		proxy.PropertyRef.set_Item(expressionInfo.ExpressionForSerialize, (object)expressionInfo.ObjectExpression);
	}

	private SystemPropertyInfo CreateSystemPropertyInfo(ISystemTypeSettings systemTypeSettings, ISystemMetadataService systemMetadataService, ISystemMetadataTypeReferenceStorage systemMetadataTypeReferenceStorage)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		SystemPropertyInfo systemPropertyInfo = new SystemPropertyInfo();
		systemPropertyInfo.ServiceInfo = new object();
		ISystemDataClassSettings val;
		ISystemListOfSimpleTypeSettings val2;
		if ((val = (ISystemDataClassSettings)(object)((systemTypeSettings is ISystemDataClassSettings) ? systemTypeSettings : null)) != null)
		{
			systemPropertyInfo.IsCollection = val.get_RelationType() != "0";
			systemPropertyInfo.ServiceInfo.set_Item("ISystemMetadataTypeReferenceStorage", (object)systemMetadataTypeReferenceStorage);
			systemPropertyInfo.ServiceInfo.set_Item("ISystemMetadataService", (object)systemMetadataService);
			systemPropertyInfo.ServiceInfo.set_Item("ISystemMetadataProxyGenerator", (object)this);
		}
		else if ((val2 = (ISystemListOfSimpleTypeSettings)(object)((systemTypeSettings is ISystemListOfSimpleTypeSettings) ? systemTypeSettings : null)) != null)
		{
			systemPropertyInfo.IsCollection = true;
			systemPropertyInfo.ServiceInfo.set_Item("SimpleTypeUid", (object)new Guid(val2.get_SimpleTypeUid()));
		}
		return systemPropertyInfo;
	}

	private static void DefineProperty(object proxy, PropertyInfoExpression expression, ISystemDescriptor descriptor, SystemPropertyInfo propertyInfo)
	{
		Script.Write("\r\n                var attributes = {\r\n                    configurable:true,\r\n                    enumerable: true,\r\n                    get: function() {\r\n                        return Bridge.unbox({4}.SystemPropertyGetter(this, {2}, {3}));\r\n                    }\r\n                };\r\n                Object.defineProperty({1}, {0}, attributes);\r\n                ", new object[5] { expression.ObjectExpression, proxy, expression, propertyInfo, descriptor });
	}
}
