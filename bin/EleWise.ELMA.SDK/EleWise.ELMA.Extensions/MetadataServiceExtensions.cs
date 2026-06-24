using System;
using System.Linq;
using Antlr.Runtime.Misc;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Extensions;

public static class MetadataServiceExtensions
{
	internal static MetadataServiceExtensions Hx2VstG36skfuSFjqOyY;

	public static string GetDisplayName(this IMetadataService service, ICodeItemMetadata metadata)
	{
		int num = 1;
		int num2 = num;
		string text;
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = service.GetConfigurationMetadataExtensionPropertyValue<string, ICodeItemMetadata>(metadata, (ICodeItemMetadata e) => (string)_003C_003Ec.wlPiyK8FOlZPqiRJWe7i(e));
				if (text == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				text = string.Empty;
				break;
			}
			break;
		}
		return text;
	}

	private static T1 GetConfigurationMetadataExtensionPropertyValue<T1, T2>(this object service, T2 metadata, Func<T2, T1> func) where T2 : class, IMetadata
	{
		if (!(service.GetConfigurationMetadataExtension(metadata) is T2 val))
		{
			return default(T1);
		}
		return func.Invoke(val);
	}

	private static IMetadata GetConfigurationMetadataExtension(this object service, object metadata)
	{
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return MetadataLoader.LoadMetadata(lZb3wiG37T09uNdTH0jy(_003C_003Ec__DisplayClass2_.metadata));
			case 3:
				return _003C_003Ec__DisplayClass2_.metadata;
			default:
				if (!(_003C_003Ec__DisplayClass2_.service is IMetadataRuntimeService))
				{
					if ((entityMetadata = _003C_003Ec__DisplayClass2_.metadata as EntityMetadata) != null)
					{
						num2 = 2;
						break;
					}
					goto case 3;
				}
				num2 = 7;
				break;
			case 2:
				if (gswyoIG3xrGaQj8WXwye(entityMetadata) == EntityMetadataType.Interface)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 6:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 5;
				break;
			case 5:
				_003C_003Ec__DisplayClass2_.metadata = (IMetadata)metadata;
				num2 = 4;
				break;
			case 4:
				_003C_003Ec__DisplayClass2_.service = (IMetadataService)service;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			{
				_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_2 = _003C_003Ec__DisplayClass2_;
				IMetadata metadata2 = _003C_003Ec__DisplayClass2_.service.GetMetadataList().OfType<EntityMetadata>().FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetConfigurationMetadataExtension_003Eb__0);
				_003C_003Ec__DisplayClass2_2.metadata = metadata2 ?? _003C_003Ec__DisplayClass2_.metadata;
				num2 = 3;
				break;
			}
			}
		}
	}

	internal static bool cK66G3G3HMWVHoxxSfPE()
	{
		return Hx2VstG36skfuSFjqOyY == null;
	}

	internal static MetadataServiceExtensions cmmjN5G3AkOtWTAD1r1t()
	{
		return Hx2VstG36skfuSFjqOyY;
	}

	internal static Guid lZb3wiG37T09uNdTH0jy(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static EntityMetadataType gswyoIG3xrGaQj8WXwye(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}
}
