using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Exceptions;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Services;

[Service]
internal class FullTextSearchCardService : IFullTextSearchCardService
{
	private static readonly ILogger IndexLog;

	private List<IModuleFullTextSearchExtension> points;

	private static FullTextSearchCardService WqyMArGSBtlPCtZLv2od;

	private List<IModuleFullTextSearchExtension> Points => points ?? (points = ComponentManager.Current.GetExtensionPoints<IModuleFullTextSearchExtension>().ToList());

	public List<IEntity> ReconstructEntities(Type cardType, FullTextSearchResultModel resultModel)
	{
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
		_003C_003Ec__DisplayClass4_.cardType = cardType;
		try
		{
			List<FullTextSearchResultItem> items = resultModel.Items;
			List<string> listReturnFields = resultModel.ListReturnFields;
			Dictionary<string, Guid> dictionary = new Dictionary<string, Guid>();
			foreach (string item in listReturnFields.Where((string f) => !_003C_003Ec.VTLis7vLqJfcceEHN6lI(f)))
			{
				string[] array = item.Split('_');
				if (array.Count() == 2 && Guid.TryParse(array[0], out var result) && !dictionary.ContainsKey(item))
				{
					dictionary.Add(item, result);
				}
			}
			List<IEntity> list = new List<IEntity>();
			foreach (FullTextSearchResultItem item2 in items)
			{
				_003C_003Ec__DisplayClass4_1 _003C_003Ec__DisplayClass4_2 = new _003C_003Ec__DisplayClass4_1();
				_003C_003Ec__DisplayClass4_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass4_;
				_003C_003Ec__DisplayClass4_2.itemF = item2;
				if (_003C_003Ec__DisplayClass4_2.itemF == null || _003C_003Ec__DisplayClass4_2.itemF.ResultData == null)
				{
					continue;
				}
				WebData resultData = _003C_003Ec__DisplayClass4_2.itemF.ResultData;
				WebDataItem webDataItem = resultData.Items.FirstOrDefault((WebDataItem i) => _003C_003Ec.RSgT0dvLTaDru4pFUORV(_003C_003Ec.a48kKqvLKRdCyJY23Dbx(i), _003C_003Ec.Ea1A0gvLXJ8cEEkpN5Wa(-629844702 ^ -629860544)));
				WebDataItem webDataItem2 = resultData.Items.FirstOrDefault((WebDataItem i) => _003C_003Ec.RSgT0dvLTaDru4pFUORV(i.Name, _003C_003Ec.Ea1A0gvLXJ8cEEkpN5Wa(0x6DC147B0 ^ 0x6DC1C6EE)));
				if (webDataItem == null || !Guid.TryParse(webDataItem.Value, out var result2) || webDataItem2 == null || !long.TryParse(webDataItem2.Value, out var result3))
				{
					continue;
				}
				Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(result2);
				EntityMetadata entityMetadata = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadata(result2) as EntityMetadata;
				if (!(typeByUid != null) || entityMetadata == null || ModelHelper.GetEntityManager(typeByUid) == null)
				{
					continue;
				}
				_003C_003Ec__DisplayClass4_2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_2();
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass4_2;
				CS_0024_003C_003E8__locals0.fakeEntity = InterfaceActivator.Create(typeByUid) as IEntity<long>;
				if (CS_0024_003C_003E8__locals0.fakeEntity == null)
				{
					continue;
				}
				CS_0024_003C_003E8__locals0.fakeEntity.Id = result3;
				WebDataItem[] items2 = resultData.Items;
				foreach (WebDataItem webDataItem3 in items2)
				{
					if (webDataItem3 == null || string.IsNullOrWhiteSpace(webDataItem3.Name))
					{
						continue;
					}
					if (dictionary.ContainsKey(webDataItem3.Name))
					{
						dictionary.Remove(webDataItem3.Name);
					}
					string[] array2 = webDataItem3.Name.Split('_');
					if (array2.Length == 0)
					{
						continue;
					}
					_003C_003Ec__DisplayClass4_3 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass4_3();
					if (!Guid.TryParse(array2[0], out CS_0024_003C_003E8__locals1.resultDataItemGuid))
					{
						continue;
					}
					PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass4_3.nLjRUivLQ0wVbPfx3yTP(_003C_003Ec__DisplayClass4_3.WCI5gnvLf7sGW88Skl9k(p), CS_0024_003C_003E8__locals1.resultDataItemGuid));
					if (propertyMetadata != null)
					{
						IFullTextSearchDescriptorService serviceNotNull = Locator.GetServiceNotNull<IFullTextSearchDescriptorService>();
						if (!serviceNotNull.IsSupportedSearchInIndex(propertyMetadata))
						{
							throw new FullTextFilterException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1766002350), propertyMetadata.TypeUid, propertyMetadata.SubTypeUid, propertyMetadata.Uid, propertyMetadata.Name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A42F4A)));
						}
						serviceNotNull.SetIndexField(CS_0024_003C_003E8__locals0.fakeEntity, webDataItem3, propertyMetadata);
					}
				}
				foreach (KeyValuePair<string, Guid> item3 in dictionary)
				{
					_003C_003Ec__DisplayClass4_4 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass4_4();
					CS_0024_003C_003E8__locals2.returnDynamicFieldF = item3;
					PropertyMetadata propertyMetadata2 = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass4_4.JccX7cvLI9JtZwNjetH2(_003C_003Ec__DisplayClass4_4.GpXOoYvLuxxZPRwSYAUf(p), CS_0024_003C_003E8__locals2.returnDynamicFieldF.Value));
					if (propertyMetadata2 != null)
					{
						IFullTextSearchDescriptorService serviceNotNull2 = Locator.GetServiceNotNull<IFullTextSearchDescriptorService>();
						if (!serviceNotNull2.IsSupportedSearchInIndex(propertyMetadata2))
						{
							throw new FullTextFilterException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70221224), propertyMetadata2.TypeUid, propertyMetadata2.SubTypeUid, propertyMetadata2.Uid, propertyMetadata2.Name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A6EF5E)));
						}
						serviceNotNull2.SetEmptyIndexField(CS_0024_003C_003E8__locals0.fakeEntity, propertyMetadata2, CS_0024_003C_003E8__locals2.returnDynamicFieldF.Key);
					}
				}
				Points.ForEach(delegate(IModuleFullTextSearchExtension p)
				{
					int num = 1;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							p.ReconstructEntity(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.cardType, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.itemF, CS_0024_003C_003E8__locals0.fakeEntity);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num2 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				list.Add(CS_0024_003C_003E8__locals0.fakeEntity);
			}
			return list;
		}
		catch (FullTextFilterException exception)
		{
			IndexLog.Warn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1D2F18), exception);
			return null;
		}
		catch (Exception message)
		{
			Logger.Log.Error(message);
			return null;
		}
	}

	public List<long> GetIdArray(List<FullTextSearchResultItem> resultItems)
	{
		try
		{
			if (resultItems == null)
			{
				return null;
			}
			List<long> list = new List<long>();
			foreach (FullTextSearchResultItem resultItem in resultItems)
			{
				if (resultItem != null && resultItem.ResultData != null)
				{
					WebDataItem webDataItem = resultItem.ResultData.Items.FirstOrDefault((WebDataItem i) => _003C_003Ec.RSgT0dvLTaDru4pFUORV(i.Name, _003C_003Ec.Ea1A0gvLXJ8cEEkpN5Wa(-787452571 ^ -787420101)));
					if (webDataItem != null && long.TryParse(webDataItem.Value, out var result))
					{
						list.Add(result);
					}
				}
			}
			return list;
		}
		catch (FullTextFilterException exception)
		{
			IndexLog.Warn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099537065), exception);
			return null;
		}
		catch (Exception message)
		{
			Logger.Log.Error(message);
			return null;
		}
	}

	public IModuleFullTextSearchExtension GetExtensionByFilter(IEntityFilter filter)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 4;
		int num2 = num;
		ClassMetadata entityMetadataByFilter = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return GetExtensionByObjectTypeUid(entityMetadataByFilter.Uid);
			case 2:
				return null;
			case 4:
				if (filter == null)
				{
					num2 = 3;
					break;
				}
				entityMetadataByFilter = MetadataLoader.GetEntityMetadataByFilter(filter.GetType());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return null;
			default:
				if (entityMetadataByFilter == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public Type GetCardTypeByFilter(IEntityFilter filter)
	{
		//Discarded unreachable code: IL_0045, IL_0054
		int num = 2;
		int num2 = num;
		ClassMetadata entityMetadataByFilter = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return GetCardTypeByObjectTypeUid(w16b87GSbv9xwPoEulhL(entityMetadataByFilter));
			case 4:
				if (entityMetadataByFilter == null)
				{
					return null;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return null;
			case 1:
				entityMetadataByFilter = MetadataLoader.GetEntityMetadataByFilter(filter.GetType());
				num2 = 4;
				break;
			case 2:
				if (filter != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public IModuleFullTextSearchExtension GetExtensionByObjectTypeUid(Guid typeUid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return Points.FirstOrDefault(_003C_003Ec__DisplayClass8_._003CGetExtensionByObjectTypeUid_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass8_.typeUid = typeUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IModuleFullTextSearchExtension GetExtensionByObjectType(Type type)
	{
		int num = 2;
		int num2 = num;
		IMetadata metadata = default(IMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				if (metadata != null)
				{
					return GetExtensionByObjectTypeUid(XWSQ84GSh9Gy0eCnBAig(metadata));
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				metadata = MetadataLoader.LoadMetadata(type);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public Type GetCardTypeByObjectTypeUid(Guid typeUid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass10_.typeUid = typeUid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return Points.Select(_003C_003Ec__DisplayClass10_._003CGetCardTypeByObjectTypeUid_003Eb__0).FirstOrDefault((Type cardType) => _003C_003Ec.qSN9ZavLkFRu3lRyWNoW(cardType, null));
			}
		}
	}

	public Type GetCardTypeByObjectType(Type type)
	{
		//Discarded unreachable code: IL_0065, IL_0074
		int num = 3;
		int num2 = num;
		IMetadata metadata = default(IMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				return GetCardTypeByObjectTypeUid(XWSQ84GSh9Gy0eCnBAig(metadata));
			case 3:
				metadata = MetadataLoader.LoadMetadata(type);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (metadata != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public IModuleFullTextSearchExtension GetExtensionByCardType(Type cardType)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return Points.FirstOrDefault(_003C_003Ec__DisplayClass12_._003CGetExtensionByCardType_003Eb__0);
			case 2:
				_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass12_.cardType = cardType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Guid? GetCardUidByCardType(Type cardType)
	{
		foreach (IModuleFullTextSearchExtension point in Points)
		{
			Guid? supportedCardType = point.GetSupportedCardType(cardType);
			if (supportedCardType.HasValue && supportedCardType != Guid.Empty)
			{
				return supportedCardType;
			}
		}
		return null;
	}

	public Type GetCardTypeByCardUid(Guid cardUid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass14_.cardUid = cardUid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return Points.Select(_003C_003Ec__DisplayClass14_._003CGetCardTypeByCardUid_003Eb__0).FirstOrDefault((Type cardType) => _003C_003Ec.qSN9ZavLkFRu3lRyWNoW(cardType, null));
			}
		}
	}

	public FullTextSearchCardService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		O5sJ71GSG89Qg0Jk8eo5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static FullTextSearchCardService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				IndexLog = (ILogger)fV8f0xGSfIVaDtglXoHH(PSbwEOGSEnEvECdLCtuj(-1767720453 ^ -1767800469));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				O5sJ71GSG89Qg0Jk8eo5();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool ek4sqNGSWcwQiMhlKh9d()
	{
		return WqyMArGSBtlPCtZLv2od == null;
	}

	internal static FullTextSearchCardService L7PcllGSop6brncRHf9r()
	{
		return WqyMArGSBtlPCtZLv2od;
	}

	internal static Guid w16b87GSbv9xwPoEulhL(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Guid XWSQ84GSh9Gy0eCnBAig(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static void O5sJ71GSG89Qg0Jk8eo5()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object PSbwEOGSEnEvECdLCtuj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object fV8f0xGSfIVaDtglXoHH(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
