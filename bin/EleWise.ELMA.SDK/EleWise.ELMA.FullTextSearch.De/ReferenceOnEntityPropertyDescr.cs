using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Descriptors;

public class ReferenceOnEntityPropertyDescriptor : FullTextPropertyDescriptor
{
	private Func<IPropertyMetadata, string> indexFieldName;

	internal static ReferenceOnEntityPropertyDescriptor F07XTLGuFNBZHJoDUtgE;

	public ReferenceOnEntityPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_0058, IL_005d
		GGt2Y0GuoasfnYppRwxj();
		indexFieldName = (IPropertyMetadata propMd) => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541813907), _003C_003Ec.BdC12pvYIlpeGFTn6Rsi(_003C_003Ec.bK0GEbvYuxK92webjGxq(propMd).ToString()), _003C_003Ec.mvY6h4vYVXKxeGMrtSPZ(0x3CE17B75 ^ 0x3CE0B601));
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!reindex)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return GetReIndexField(obj, propMd);
			default:
				return GetIndexField(obj, propMd);
			}
		}
	}

	public override FieldIndexList GetMappingField(IPropertyMetadata propMd)
	{
		return new FieldIndexList
		{
			new FieldIndexListItem(ValueFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem(indexFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Value)
		};
	}

	private FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_00ec, IL_0168
		int num = 5;
		int num2 = num;
		ReferenceOnEntity referenceOnEntity = default(ReferenceOnEntity);
		while (true)
		{
			switch (num2)
			{
			default:
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), if6UgRGubgERKwqeaSvD(referenceOnEntity).ToString(), FullTextFieldType.String),
					new FieldIndexListItem(indexFieldName(propMd), ocWljDGuGPQ2XL04fJYD(PFhd1HGuhbgm6DEEkL5f(referenceOnEntity).ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876068633)), referenceOnEntity.ObjectId), FullTextFieldType.String)
				};
			case 1:
				return null;
			case 3:
				if (obj == null)
				{
					num2 = 2;
					break;
				}
				referenceOnEntity = obj as ReferenceOnEntity;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				if (if6UgRGubgERKwqeaSvD(referenceOnEntity) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 2:
			case 4:
				return new FieldIndexList();
			case 7:
				if (referenceOnEntity == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 6;
			case 5:
				if (propMd == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	private FieldIndexList GetReIndexField(object obj, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_00c4
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (propMd == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			case 1:
				return GetIndexField(obj, propMd);
			default:
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), string.Empty, FullTextFieldType.String),
					new FieldIndexListItem(indexFieldName(propMd), string.Empty, FullTextFieldType.String)
				};
			case 3:
				return new FieldIndexList();
			case 2:
				if (!(obj is ReferenceOnEntity))
				{
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_003d, IL_004c, IL_00e5, IL_00f4
		int num = 5;
		int num2 = num;
		ReferenceOnEntity referenceOnEntity = default(ReferenceOnEntity);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return new FilterListItem(indexFieldName(propMd), new List<object> { ocWljDGuGPQ2XL04fJYD(referenceOnEntity.ObjectTypeUId.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC24B05)), XYV6yPGuEiHUV2UU0ckQ(referenceOnEntity)) }, FilterListItemType.Must, FullTextFieldType.String);
			default:
				return null;
			case 3:
				if (if6UgRGubgERKwqeaSvD(referenceOnEntity) == null)
				{
					num2 = 6;
					break;
				}
				goto case 2;
			case 1:
				if (referenceOnEntity == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 4:
				return null;
			case 5:
				if (value != null)
				{
					referenceOnEntity = value as ReferenceOnEntity;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	public override List<string> GetReturnField(IPropertyMetadata propMd)
	{
		return new List<string> { indexFieldName(propMd) };
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0065, IL_0074, IL_00a5, IL_0101, IL_0152, IL_0161, IL_0210, IL_028b
		int num = 1;
		int num2 = num;
		long result = default(long);
		Guid result2 = default(Guid);
		PropertyInfo propertyCached = default(PropertyInfo);
		WebDataItem webDataItem = default(WebDataItem);
		string input = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 7:
				return;
			case 11:
				try
				{
					ReferenceOnEntity value2 = new ReferenceOnEntity(result, result2);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 1:
							propertyCached.SetValue(obj, value2, null);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
							{
								num3 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
				catch (Exception exception)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							Logger.Log.Warn(s9Krv0GuI6eiU67t9QEU(-1852837372 ^ -1853081364), exception);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
			case 15:
				if (long.TryParse(((string)nMoXnvGu8OyqlCC4P0UD(webDataItem)).Substring(32), out result))
				{
					num2 = 5;
					break;
				}
				return;
			case 0:
				return;
			case 12:
				return;
			case 14:
				if (webDataItem != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 3;
					}
					break;
				}
				return;
			case 4:
				return;
			case 8:
				if (!tFb5pNGuvcRVL9Gcnyca(webDataItem.Value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 2;
					}
					break;
				}
				return;
			case 13:
				input = (string)nDV4ihGuuYOhnJtjHW0t(nMoXnvGu8OyqlCC4P0UD(webDataItem), 0, 32);
				num2 = 15;
				break;
			case 2:
				if (LXRl5sGuZeAC09r8kxlc(nMoXnvGu8OyqlCC4P0UD(webDataItem)) <= 32)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 13;
			case 1:
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 5:
				if (Guid.TryParse(input, out result2))
				{
					num2 = 11;
					break;
				}
				return;
			case 9:
				return;
			case 3:
				if ((string)CSQuHmGuCbB3JdchPrxp(webDataItem) != indexFieldName(propMd))
				{
					return;
				}
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 0;
				}
				break;
			case 16:
				if (verwxKGuQy3KWNwQcrKJ(propertyCached, null))
				{
					return;
				}
				num2 = 14;
				break;
			case 6:
				if (propMd != null)
				{
					propertyCached = obj.GetType().GetPropertyCached((string)uRuB36Gufo7Q36G9cdhI(propMd));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 10;
					}
				}
				else
				{
					num2 = 12;
				}
				break;
			case 10:
				webDataItem = value as WebDataItem;
				num2 = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	internal static void GGt2Y0GuoasfnYppRwxj()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool qFpT4OGuBXPMh2lQyhf7()
	{
		return F07XTLGuFNBZHJoDUtgE == null;
	}

	internal static ReferenceOnEntityPropertyDescriptor TRKc7DGuWeeINPbXrdJo()
	{
		return F07XTLGuFNBZHJoDUtgE;
	}

	internal static object if6UgRGubgERKwqeaSvD(object P_0)
	{
		return ((ReferenceOnEntity)P_0).Object;
	}

	internal static Guid PFhd1HGuhbgm6DEEkL5f(object P_0)
	{
		return ((ReferenceOnEntity)P_0).ObjectTypeUId;
	}

	internal static object ocWljDGuGPQ2XL04fJYD(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static long XYV6yPGuEiHUV2UU0ckQ(object P_0)
	{
		return ((ReferenceOnEntity)P_0).ObjectId;
	}

	internal static object uRuB36Gufo7Q36G9cdhI(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static bool verwxKGuQy3KWNwQcrKJ(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object CSQuHmGuCbB3JdchPrxp(object P_0)
	{
		return ((WebDataItem)P_0).Name;
	}

	internal static bool tFb5pNGuvcRVL9Gcnyca(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object nMoXnvGu8OyqlCC4P0UD(object P_0)
	{
		return ((WebDataItem)P_0).Value;
	}

	internal static int LXRl5sGuZeAC09r8kxlc(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object nDV4ihGuuYOhnJtjHW0t(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object s9Krv0GuI6eiU67t9QEU(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
