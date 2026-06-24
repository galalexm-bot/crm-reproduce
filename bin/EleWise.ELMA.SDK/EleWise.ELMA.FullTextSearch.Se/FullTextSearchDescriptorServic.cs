using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FullTextSearch.Services;

[Service]
internal class FullTextSearchDescriptorService : IFullTextSearchDescriptorMappingService, IFullTextSearchDescriptorService
{
	private readonly IDictionary<(Guid TypeUid, Guid SubTypeUid), IFullTextPropertyDescriptor> descriptorList;

	private readonly IFullTextPropertyMappingDescriptor defaultPropertyDescriptor;

	internal static FullTextSearchDescriptorService sUJB34GSQSck3JBRdbGV;

	private IFullTextPropertyDescriptor GetDescriptor(IPropertyMetadata propertyMd)
	{
		//Discarded unreachable code: IL_0041, IL_00bc, IL_00cb
		int num = 2;
		IFullTextTypeDescriptor fullTextTypeDescriptor = default(IFullTextTypeDescriptor);
		(Guid, Guid) key = default((Guid, Guid));
		IFullTextPropertyDescriptor value = default(IFullTextPropertyDescriptor);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					fullTextTypeDescriptor = Yv3o45GSuRurQWVoH5Km(MetadataServiceContext.Service, propertyMd.TypeUid, AYgFxUGSZshLKCvcxME5(propertyMd)) as IFullTextTypeDescriptor;
					num2 = 7;
					break;
				case 2:
					if (propertyMd != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 6;
				case 4:
					if (descriptorList.TryGetValue(key, out value))
					{
						goto end_IL_0012;
					}
					goto case 3;
				default:
					return value;
				case 6:
					return null;
				case 1:
					key = (qvjlsrGS8UQydnyUcF03(propertyMd), AYgFxUGSZshLKCvcxME5(propertyMd));
					num2 = 4;
					break;
				case 7:
					value = (descriptorList[key] = (IFullTextPropertyDescriptor)((fullTextTypeDescriptor != null) ? b6q3tVGSIyN25rg84Cn0(fullTextTypeDescriptor) : null));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public bool IsSupportedIndexing(IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 1;
		int num2 = num;
		IFullTextPropertyDescriptor descriptor = default(IFullTextPropertyDescriptor);
		while (true)
		{
			switch (num2)
			{
			default:
				if (descriptor == null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 1:
				descriptor = GetDescriptor(propMd);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return descriptor.IsSupportedIndexing;
			case 3:
				return false;
			}
		}
	}

	public bool IsSupportedSearchInIndex(IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_003d
		int num = 5;
		IFullTextPropertyDescriptor descriptor = default(IFullTextPropertyDescriptor);
		EntitySettings entitySettings = default(EntitySettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return qRn8ajGSS2cRHEZk5x3U(descriptor);
				case 3:
					return false;
				default:
					if (descriptor == null)
					{
						goto end_IL_0012;
					}
					goto case 6;
				case 1:
					if (IvXegCGSV3rHpqHKS3rY(entitySettings) == RelationType.OneToMany)
					{
						num2 = 2;
						continue;
					}
					break;
				case 5:
					entitySettings = propMd.Settings as EntitySettings;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 4;
					}
					continue;
				case 4:
					if (entitySettings != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 2:
					return false;
				}
				descriptor = GetDescriptor(propMd);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public bool IsSupportedFullTextSearchInIndex(IPropertyMetadata propMd)
	{
		int num = 2;
		int num2 = num;
		IFullTextPropertyDescriptor descriptor = default(IFullTextPropertyDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (descriptor != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			case 2:
				descriptor = GetDescriptor(propMd);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return tC6sF5GSivjrtOtvGZlA(descriptor);
			}
		}
	}

	public FieldIndexList GetIndexField(object value, IPropertyMetadata propMd, bool reindex)
	{
		int num = 2;
		int num2 = num;
		IFullTextPropertyDescriptor descriptor = default(IFullTextPropertyDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 2:
				descriptor = GetDescriptor(propMd);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return descriptor.GetIndexField(value, propMd, reindex);
			case 1:
				if (descriptor == null)
				{
					return (FieldIndexList)bsH8UKGSRDxWYf0pWxDO(defaultPropertyDescriptor, value, propMd, reindex);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public FieldListItem GetSearchField(object value, IPropertyMetadata propMd)
	{
		int num = 2;
		int num2 = num;
		IFullTextPropertyDescriptor descriptor = default(IFullTextPropertyDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 2:
				descriptor = GetDescriptor(propMd);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (descriptor != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return (FieldListItem)ti4vnuGSqNSnA0I2IwAn(defaultPropertyDescriptor, value, propMd);
			default:
				return (FieldListItem)ti4vnuGSqNSnA0I2IwAn(descriptor, value, propMd);
			}
		}
	}

	public FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_004b, IL_005a
		int num = 3;
		int num2 = num;
		IFullTextPropertyDescriptor descriptor = default(IFullTextPropertyDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return (FilterListItem)BunUlfGSKjo8mwfgkKCw(descriptor, value, propMd, filter);
			default:
				return (FilterListItem)BunUlfGSKjo8mwfgkKCw(defaultPropertyDescriptor, value, propMd, filter);
			case 2:
				if (descriptor == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				descriptor = GetDescriptor(propMd);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public List<string> GetReturnField(IPropertyMetadata propMd)
	{
		IFullTextPropertyDescriptor descriptor = GetDescriptor(propMd);
		if (descriptor != null)
		{
			return descriptor.GetReturnField(propMd);
		}
		return defaultPropertyDescriptor.GetReturnField(propMd);
	}

	public SortListItem GetSortField(IPropertyMetadata propMd)
	{
		int num = 2;
		int num2 = num;
		IFullTextPropertyDescriptor descriptor = default(IFullTextPropertyDescriptor);
		while (true)
		{
			switch (num2)
			{
			default:
				return descriptor.GetSortField(propMd);
			case 1:
				if (descriptor == null)
				{
					return (SortListItem)THAKD3GSXRRHfExhwhjN(defaultPropertyDescriptor, propMd);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				descriptor = GetDescriptor(propMd);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0039
		int num = 1;
		int num2 = num;
		IFullTextPropertyDescriptor descriptor = default(IFullTextPropertyDescriptor);
		while (true)
		{
			switch (num2)
			{
			default:
				if (descriptor != null)
				{
					num2 = 5;
					break;
				}
				goto case 3;
			case 3:
				defaultPropertyDescriptor.SetIndexField(obj, value, propMd);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				descriptor = GetDescriptor(propMd);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 5:
				bNB6QhGSTtk9ElGwyfYc(descriptor, obj, value, propMd);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				return;
			}
		}
	}

	public void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
		int num = 2;
		int num2 = num;
		IFullTextPropertyDescriptor descriptor = default(IFullTextPropertyDescriptor);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				N8L2lLGSkfjvhNEmyrFr(defaultPropertyDescriptor, obj, propMd, fieldName);
				num2 = 4;
				break;
			case 2:
				descriptor = GetDescriptor(propMd);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (descriptor == null)
				{
					num2 = 3;
					break;
				}
				descriptor.SetEmptyIndexField(obj, propMd, fieldName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			}
		}
	}

	public FieldIndexList GetMappingField(IPropertyMetadata propMd)
	{
		int num = 1;
		int num2 = num;
		IFullTextPropertyMappingDescriptor fullTextPropertyMappingDescriptor = default(IFullTextPropertyMappingDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 1:
				fullTextPropertyMappingDescriptor = GetDescriptor(propMd) as IFullTextPropertyMappingDescriptor;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return fullTextPropertyMappingDescriptor.GetMappingField(propMd);
			}
			if (fullTextPropertyMappingDescriptor == null)
			{
				return (FieldIndexList)wnhMHNGSneMGrs3j2gVB(defaultPropertyDescriptor, propMd);
			}
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
			{
				num2 = 2;
			}
		}
	}

	public FullTextSearchDescriptorService()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		SingletonReader.JJCZtPuTvSt();
		descriptorList = new Dictionary<(Guid, Guid), IFullTextPropertyDescriptor>();
		defaultPropertyDescriptor = new NoFullTextPropertyDescriptor();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid qvjlsrGS8UQydnyUcF03(object P_0)
	{
		return ((IPropertyMetadata)P_0).TypeUid;
	}

	internal static Guid AYgFxUGSZshLKCvcxME5(object P_0)
	{
		return ((IPropertyMetadata)P_0).SubTypeUid;
	}

	internal static object Yv3o45GSuRurQWVoH5Km(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static object b6q3tVGSIyN25rg84Cn0(object P_0)
	{
		return ((IFullTextTypeDescriptor)P_0).FullTextPropertyDescriptor;
	}

	internal static bool e0OpiTGSCZwbvyMSiUPQ()
	{
		return sUJB34GSQSck3JBRdbGV == null;
	}

	internal static FullTextSearchDescriptorService QIwFstGSvVfurhXbcno0()
	{
		return sUJB34GSQSck3JBRdbGV;
	}

	internal static RelationType IvXegCGSV3rHpqHKS3rY(object P_0)
	{
		return ((EntitySettings)P_0).RelationType;
	}

	internal static bool qRn8ajGSS2cRHEZk5x3U(object P_0)
	{
		return ((IFullTextPropertyDescriptor)P_0).IsSupportedSearchInIndex;
	}

	internal static bool tC6sF5GSivjrtOtvGZlA(object P_0)
	{
		return ((IFullTextPropertyDescriptor)P_0).IsSupportedFullTextSearchInIndex;
	}

	internal static object bsH8UKGSRDxWYf0pWxDO(object P_0, object P_1, object P_2, bool reindex)
	{
		return ((IFullTextPropertyDescriptor)P_0).GetIndexField(P_1, (IPropertyMetadata)P_2, reindex);
	}

	internal static object ti4vnuGSqNSnA0I2IwAn(object P_0, object P_1, object P_2)
	{
		return ((IFullTextPropertyDescriptor)P_0).GetSearchField(P_1, (IPropertyMetadata)P_2);
	}

	internal static object BunUlfGSKjo8mwfgkKCw(object P_0, object P_1, object P_2, object P_3)
	{
		return ((IFullTextPropertyDescriptor)P_0).GetFilterField(P_1, (IPropertyMetadata)P_2, (IEntityFilter)P_3);
	}

	internal static object THAKD3GSXRRHfExhwhjN(object P_0, object P_1)
	{
		return ((IFullTextPropertyDescriptor)P_0).GetSortField((IPropertyMetadata)P_1);
	}

	internal static void bNB6QhGSTtk9ElGwyfYc(object P_0, object P_1, object P_2, object P_3)
	{
		((IFullTextPropertyDescriptor)P_0).SetIndexField(P_1, P_2, (IPropertyMetadata)P_3);
	}

	internal static void N8L2lLGSkfjvhNEmyrFr(object P_0, object P_1, object P_2, object P_3)
	{
		((IFullTextPropertyDescriptor)P_0).SetEmptyIndexField(P_1, (IPropertyMetadata)P_2, (string)P_3);
	}

	internal static object wnhMHNGSneMGrs3j2gVB(object P_0, object P_1)
	{
		return ((IFullTextPropertyMappingDescriptor)P_0).GetMappingField((IPropertyMetadata)P_1);
	}
}
