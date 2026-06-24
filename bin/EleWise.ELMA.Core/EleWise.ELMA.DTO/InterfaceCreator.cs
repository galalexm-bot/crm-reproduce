using System;
using Bridge;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.DTO;

public static class InterfaceCreator
{
	private static bool inited;

	private static ISystemProxyMetadataReferencesStorage proxyMetadataReferencesStorage;

	private static IProxyGeneratorServiceInternal proxyGeneratorServiceInternal;

	public static T Create<T>() where T : class
	{
		return ObjectExtensions.As<T>(Create(typeof(T)));
	}

	public static T Create<T>(object obj) where T : class
	{
		if (obj == null)
		{
			return null;
		}
		string hash = ObjectExtensions.As<string>(obj.get_Item("$t"));
		ReactiveProxy reactiveProxy = proxyGeneratorServiceInternal.GenerateProxy(hash);
		object obj2 = ConvertHelper.Serialize(obj, new SerializationSettings
		{
			WriteReferences = true
		});
		ConvertHelper.Reconcile(reactiveProxy, obj2);
		return ObjectExtensions.As<T>((object)reactiveProxy);
	}

	public static object Create(System.Type type)
	{
		if (type.get_IsClass() && Script.Write<bool>("type.$$name === \"EleWise.ELMA.DTO.ProxyType\"", new object[0]))
		{
			ProxyType proxyType = ObjectExtensions.As<ProxyType>((object)type);
			return proxyGeneratorServiceInternal.GenerateProxyByStringUid(proxyType.TypeString);
		}
		string fullName = type.get_FullName();
		string metadataUid = proxyMetadataReferencesStorage.GetMetadataUid(fullName);
		return proxyGeneratorServiceInternal.GenerateProxyByStringUid(metadataUid);
	}

	internal static void SetServices(ISystemProxyMetadataReferencesStorage storage, IProxyGeneratorServiceInternal proxyGeneratorService)
	{
		if (!inited)
		{
			inited = true;
			proxyMetadataReferencesStorage = storage;
			proxyGeneratorServiceInternal = proxyGeneratorService;
		}
	}
}
