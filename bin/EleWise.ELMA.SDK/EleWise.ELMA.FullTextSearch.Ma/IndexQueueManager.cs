using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Cache;
using EleWise.ELMA.FullTextSearch.Exceptions;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.FullTextSearch.Settings;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Manager;

public class IndexQueueManager : EntityManager<IIndexQueue, long>
{
	private static readonly ILogger IndexLog;

	public static string IndexQueueListContextKeyConst;

	private IFullTextTypeMappingServiceExt mappingService;

	private static IndexQueueManager i8L63YGQPIi9XJXjODLh;

	public ILockManager LockManager
	{
		[CompilerGenerated]
		get
		{
			return _003CLockManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CLockManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ITransformationProvider TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public new static IndexQueueManager Instance => Locator.GetServiceNotNull<IndexQueueManager>();

	private static ICacheService CacheService => Locator.GetServiceNotNull<ICacheService>();

	private IFullTextTypeMappingServiceExt MappingService
	{
		get
		{
			int num = 2;
			int num2 = num;
			IFullTextTypeMappingServiceExt fullTextTypeMappingServiceExt = default(IFullTextTypeMappingServiceExt);
			IFullTextTypeMappingServiceExt fullTextTypeMappingServiceExt2;
			while (true)
			{
				switch (num2)
				{
				case 1:
					fullTextTypeMappingServiceExt = (mappingService = Locator.GetServiceNotNull<IFullTextTypeMappingServiceExt>());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					fullTextTypeMappingServiceExt2 = mappingService;
					if (fullTextTypeMappingServiceExt2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				default:
					fullTextTypeMappingServiceExt2 = fullTextTypeMappingServiceExt;
					break;
				}
				break;
			}
			return fullTextTypeMappingServiceExt2;
		}
	}

	[Transaction]
	public override void Save(IIndexQueue obj)
	{
		//Discarded unreachable code: IL_016a, IL_0179, IL_01e1, IL_01eb
		int num = 3;
		bool? visualData = default(bool?);
		bool flag = default(bool);
		long? num4 = default(long?);
		long? num3 = default(long?);
		IUser currentUser = default(IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				long? obj2;
				switch (num2)
				{
				case 5:
					if (visualData != flag)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto end_IL_0012;
				case 12:
					obj.CreationAuthorId = num4;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 6;
					}
					continue;
				case 10:
					num3 = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					visualData = obj.VisualData;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					if (num4.HasValue)
					{
						num2 = 7;
						continue;
					}
					return;
				case 4:
					goto end_IL_0012;
				case 11:
					return;
				case 13:
					return;
				case 3:
					currentUser = ((IAuthenticationService)wA8TeVGQ3Uj6UARs3Gp7(this)).GetCurrentUser();
					num2 = 2;
					continue;
				case 2:
					if (currentUser != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 10;
				case 9:
					base.Save(obj);
					num2 = 6;
					continue;
				case 1:
					flag = true;
					num2 = 5;
					continue;
				default:
					obj2 = num3;
					break;
				case 8:
					obj2 = (long?)PjoolAGQpMVuZ8hQHCwU(currentUser);
					break;
				}
				num4 = obj2;
				num2 = 12;
				continue;
				end_IL_0012:
				break;
			}
			((ICacheService)TPo866GQarVj9TuSRtYb()).Insert((string)SohwcfGQtday0DXOMFvZ(rMfQq0GQDS3LR61R8L47(0x7C1EE318 ^ 0x7C1FA5F2), rMfQq0GQDS3LR61R8L47(-29254301 ^ -29205091), num4), num4, (string)rMfQq0GQDS3LR61R8L47(0x103FE975 ^ 0x103C298B));
			num = 13;
		}
	}

	public bool ContainIndexingVisualData()
	{
		//Discarded unreachable code: IL_003d, IL_004c, IL_005c
		int num = 1;
		int num2 = num;
		IUser user = default(IUser);
		long? num3 = default(long?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				user = (IUser)klo5B0GQwkL3UT8bQ7lx(wA8TeVGQ3Uj6UARs3Gp7(this));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (user != null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 2:
				return false;
			case 3:
				num3 = (long?)user.GetId();
				num2 = 6;
				break;
			case 4:
				return false;
			case 5:
				return oXNnmQGQ4LWj6KBY4eTF(TPo866GQarVj9TuSRtYb(), SohwcfGQtday0DXOMFvZ(rMfQq0GQDS3LR61R8L47(0x1ECE530A ^ 0x1ECF15E0), rMfQq0GQDS3LR61R8L47(0x68BBB53E ^ 0x68B875C0), num3), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675325631));
			case 6:
				if (num3.HasValue)
				{
					num2 = 5;
					break;
				}
				goto case 4;
			}
		}
	}

	public bool ContainIndexingVisualData(Guid cardType)
	{
		//Discarded unreachable code: IL_0039
		int num = 3;
		int num2 = num;
		IIndexQueueFilter indexQueueFilter = default(IIndexQueueFilter);
		while (true)
		{
			switch (num2)
			{
			default:
				indexQueueFilter.VisualData = true;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return F8hpPeGQ6VRO9BiAk8NQ(this, indexQueueFilter);
			case 3:
				if (IsIndexingOn())
				{
					num2 = 2;
					break;
				}
				goto case 4;
			case 4:
				return false;
			case 2:
				indexQueueFilter = InterfaceActivator.Create<IIndexQueueFilter>();
				num2 = 5;
				break;
			case 5:
				indexQueueFilter.CardTypeUid = cardType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ClearQueue()
	{
		int num = 2;
		int num2 = num;
		string sql = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				sql = (string)UpOcGWGQ7iPBS2tcNYKs(rMfQq0GQDS3LR61R8L47(-138018305 ^ -137984543), k4TYYXGQAiFtvrVK4rAy(UMoj6oGQHa5AGZZM7hKv(TransformationProvider), rMfQq0GQDS3LR61R8L47(-218496594 ^ -218513254)));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				TransformationProvider.ExecuteNonQuery(sql);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private List<KeyValuePair<string, object>> DirtyValuesHexToList(string valueStr)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
		string[] array = valueStr.Split('|');
		if (array.Any())
		{
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (MemoryHelper.ActionWithMemoryBuffer<byte, string, object>(text.Length >> 1, text, DirtyValuesHexToListAction) is KeyValuePair<string, object> item)
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	private object DirtyValuesHexToListAction(byte[] buffer, int offset, int length, string listGrI)
	{
		//Discarded unreachable code: IL_0051, IL_007d, IL_008c
		int num = 4;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 3:
				if (num3 < offset + length)
				{
					num2 = 5;
					break;
				}
				goto case 1;
			case 4:
				num3 = offset;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				return ClassSerializationHelper.DeserializeObject(buffer, offset, length);
			case 5:
			case 6:
				buffer[num3] = spB5MiGQ0mTMuxC9LgKY(Sy3OOEGQxV2xCVb8u1dK(listGrI, num3 << 1, 2), 16);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				num3++;
				num2 = 2;
				break;
			}
		}
	}

	public bool HasIndexAllQueue()
	{
		int num = 2;
		int num2 = num;
		Dictionary<string, object> paramValues = default(Dictionary<string, object>);
		string sql = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				paramValues = new Dictionary<string, object> { 
				{
					(string)rMfQq0GQDS3LR61R8L47(-629844702 ^ -629762832),
					0
				} };
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				sql = (string)uANvCPGQyU30dArwmDq1(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979398787), new object[4]
				{
					k4TYYXGQAiFtvrVK4rAy(UMoj6oGQHa5AGZZM7hKv(TransformationProvider), rMfQq0GQDS3LR61R8L47(-1217523399 ^ -1217540083)),
					k4TYYXGQAiFtvrVK4rAy(TransformationProvider.Dialect, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398696446)),
					((Dialect)UMoj6oGQHa5AGZZM7hKv(TransformationProvider)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16539813)),
					IpakLTGQme0cJLTV889k(TransformationProvider)
				});
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return rC4jCKGQMqoydlwsoqlh(TransformationProvider.ExecuteScalar(sql, paramValues)) > 0;
			}
		}
	}

	public bool HasIndexAllReIndexByTypeQueue()
	{
		int num = 1;
		int num2 = num;
		Dictionary<string, object> paramValues = default(Dictionary<string, object>);
		string sql = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				paramValues = new Dictionary<string, object>
				{
					{
						(string)rMfQq0GQDS3LR61R8L47(-138018305 ^ -138034345),
						0
					},
					{
						(string)rMfQq0GQDS3LR61R8L47(0x6DC147B0 ^ 0x6DC28568),
						1
					}
				};
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return rC4jCKGQMqoydlwsoqlh(TransformationProvider.ExecuteScalar(sql, paramValues)) > 0;
			case 1:
				sql = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939557506), k4TYYXGQAiFtvrVK4rAy(UMoj6oGQHa5AGZZM7hKv(TransformationProvider), rMfQq0GQDS3LR61R8L47(-2099751081 ^ -2099538333)), k4TYYXGQAiFtvrVK4rAy(UMoj6oGQHa5AGZZM7hKv(TransformationProvider), rMfQq0GQDS3LR61R8L47(-812025778 ^ -811992816)), k4TYYXGQAiFtvrVK4rAy(UMoj6oGQHa5AGZZM7hKv(TransformationProvider), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53F6D1F)), TransformationProvider.ParameterSeparator);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool HasIndexAllQueueForContinue()
	{
		//Discarded unreachable code: IL_00c4, IL_00d3, IL_012f, IL_013e
		int num = 5;
		ICollection<IIndexQueue> source = default(ICollection<IIndexQueue>);
		IIndexQueueFilter indexQueueFilter = default(IIndexQueueFilter);
		FetchOptions fetchOptions2 = default(FetchOptions);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (!source.Any())
					{
						num2 = 7;
						continue;
					}
					goto case 1;
				default:
					return false;
				case 2:
					return true;
				case 7:
					return false;
				case 1:
					if (!y2j8kpGQdoowRXi1eXCB(NOcmpmGQ9sudnlC0bSHe(source.Last())))
					{
						num2 = 2;
						continue;
					}
					goto default;
				case 4:
					indexQueueFilter.QueueType = new List<IndexQueueType> { IndexQueueType.IndexAll };
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 8;
					}
					continue;
				case 3:
					source = Find(indexQueueFilter, fetchOptions2);
					num2 = 6;
					continue;
				case 8:
				{
					FetchOptions fetchOptions = new FetchOptions();
					XJ7mA4GQJZVJMOJL8Gh6(fetchOptions, rMfQq0GQDS3LR61R8L47(-1710575414 ^ -1710607980));
					fetchOptions2 = fetchOptions;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				case 5:
					break;
				}
				break;
			}
			indexQueueFilter = InterfaceActivator.Create<IIndexQueueFilter>();
			num = 4;
		}
	}

	private bool IndexAll(IIndexQueue item)
	{
		//Discarded unreachable code: IL_0060, IL_006f
		int num = 4;
		long id = default(long);
		bool breakBecauseIsIndexAll = default(bool);
		string sql = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return true;
				case 4:
					if (QXXkE5GQlnDaLqhRGCpX(item) <= 5)
					{
						goto end_IL_0012;
					}
					goto default;
				case 5:
					return false;
				case 3:
					id = item.Id;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 7;
					}
					break;
				case 7:
					if (!((IFullTextSearchService)ykPnvsGQrFK86K9Je66g(this)).ReIndexAllEntities(item, (string)NOcmpmGQ9sudnlC0bSHe(item), out breakBecauseIsIndexAll))
					{
						return false;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 1;
					}
					break;
				default:
					base.FullTextSearchService.StopIndexing(SR.T((string)rMfQq0GQDS3LR61R8L47(-35995181 ^ -36109521)));
					num2 = 5;
					break;
				case 6:
					TransformationProvider.ExecuteNonQuery(sql, new Dictionary<string, object> { 
					{
						(string)rMfQq0GQDS3LR61R8L47(0x5F3078B6 ^ 0x5F33BCF4),
						id
					} });
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					sql = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420989752), ((Dialect)UMoj6oGQHa5AGZZM7hKv(TransformationProvider)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867051359)), k4TYYXGQAiFtvrVK4rAy(UMoj6oGQHa5AGZZM7hKv(TransformationProvider), rMfQq0GQDS3LR61R8L47(0x35C0467B ^ 0x35C0C725)), IpakLTGQme0cJLTV889k(TransformationProvider), breakBecauseIsIndexAll ? rMfQq0GQDS3LR61R8L47(0x26FFCB59 ^ 0x26FF849F) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867843978));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 3;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	private bool IndexByType(IIndexQueue item)
	{
		//Discarded unreachable code: IL_0168, IL_0177
		int num = 9;
		int num2 = num;
		Type type = default(Type);
		Guid? cardTypeUid = default(Guid?);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (trThAcGQYXb2rpC1RCDI(type, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					break;
				}
				if (!HasIndexAllQueue())
				{
					num2 = 4;
					break;
				}
				goto case 12;
			case 7:
				k6iqAQGQgtiYXt5yWG9y(IndexLog, rMfQq0GQDS3LR61R8L47(-1459557599 ^ -1459409043));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			case 12:
				k6iqAQGQgtiYXt5yWG9y(IndexLog, rMfQq0GQDS3LR61R8L47(-951514650 ^ -951399322));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 6;
				}
				break;
			case 1:
				return true;
			case 5:
			{
				object obj = Q2ni16GQ58UmKva214JP(this);
				cardTypeUid = item.CardTypeUid;
				type = SIu2N1GQj6Kc0yjN3apa(obj, cardTypeUid.Value);
				num2 = 3;
				break;
			}
			case 11:
				return false;
			case 8:
				if (cardTypeUid.HasValue)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 7;
			case 2:
				Kd5m3EGQUSotUch9Nlhr(base.FullTextSearchService, item);
				num2 = 11;
				break;
			case 10:
				return true;
			default:
			{
				ILogger indexLog = IndexLog;
				object format = rMfQq0GQDS3LR61R8L47(-2112703338 ^ -2112786310);
				object[] array = new object[1];
				cardTypeUid = item.CardTypeUid;
				array[0] = cardTypeUid.Value;
				indexLog.ErrorFormat((string)format, array);
				num2 = 10;
				break;
			}
			case 6:
				return true;
			case 4:
				WyeK25GQLaC7fjY2bHDC(base.FullTextSearchService, type);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				cardTypeUid = item.CardTypeUid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 8;
				}
				break;
			}
		}
	}

	private void ResetIndexQueueAttempt(IIndexQueue item)
	{
		int num = 1;
		int num2 = num;
		string sql = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				TransformationProvider.ExecuteNonQuery(sql, new Dictionary<string, object> { 
				{
					(string)rMfQq0GQDS3LR61R8L47(-541731959 ^ -541714485),
					item.Id
				} });
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				sql = (string)uANvCPGQyU30dArwmDq1(rMfQq0GQDS3LR61R8L47(-70007027 ^ -70254277), new object[4]
				{
					k4TYYXGQAiFtvrVK4rAy(UMoj6oGQHa5AGZZM7hKv(TransformationProvider), rMfQq0GQDS3LR61R8L47(-477139494 ^ -477319954)),
					k4TYYXGQAiFtvrVK4rAy(TransformationProvider.Dialect, rMfQq0GQDS3LR61R8L47(0x63ABA4E8 ^ 0x63AB25B6)),
					IpakLTGQme0cJLTV889k(TransformationProvider),
					k4TYYXGQAiFtvrVK4rAy(UMoj6oGQHa5AGZZM7hKv(TransformationProvider), rMfQq0GQDS3LR61R8L47(-2138958856 ^ -2138974860))
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void IncreaseIndexQueueAttempt(IIndexQueue item)
	{
		int num = 1;
		int num2 = num;
		string sql = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
			{
				long num3 = QXXkE5GQlnDaLqhRGCpX(item);
				BsumQEGQsupi7sKIrsWx(item, num3 + 1);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			case 2:
				TransformationProvider.ExecuteNonQuery(sql, new Dictionary<string, object>
				{
					{
						(string)rMfQq0GQDS3LR61R8L47(0x66F566B6 ^ 0x66F6A2F4),
						item.Id
					},
					{
						(string)rMfQq0GQDS3LR61R8L47(0x1637C429 ^ 0x16340323),
						QXXkE5GQlnDaLqhRGCpX(item)
					}
				});
				num2 = 3;
				continue;
			}
			sql = string.Format((string)rMfQq0GQDS3LR61R8L47(-1824388195 ^ -1824404221), k4TYYXGQAiFtvrVK4rAy(TransformationProvider.Dialect, rMfQq0GQDS3LR61R8L47(-606654180 ^ -606801880)), k4TYYXGQAiFtvrVK4rAy(UMoj6oGQHa5AGZZM7hKv(TransformationProvider), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29287363)), IpakLTGQme0cJLTV889k(TransformationProvider), k4TYYXGQAiFtvrVK4rAy(UMoj6oGQHa5AGZZM7hKv(TransformationProvider), rMfQq0GQDS3LR61R8L47(0x48A7E34A ^ 0x48A425C6)), IpakLTGQme0cJLTV889k(TransformationProvider));
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
			{
				num2 = 2;
			}
		}
	}

	private bool IndexObject(IIndexQueue item)
	{
		//Discarded unreachable code: IL_00b6, IL_0150, IL_015f, IL_0183
		int num = 10;
		int num2 = num;
		IndexQueueType indexQueueType = default(IndexQueueType);
		Guid? objectTypeUid = default(Guid?);
		Type cardTypeByObjectTypeUid = default(Type);
		long? objectId = default(long?);
		IndexQueueType? queueType = default(IndexQueueType?);
		while (true)
		{
			switch (num2)
			{
			case 11:
				indexQueueType = IndexQueueType.IndexObject;
				num2 = 4;
				break;
			case 2:
			{
				object obj = Q2ni16GQ58UmKva214JP(this);
				objectTypeUid = item.ObjectTypeUid;
				cardTypeByObjectTypeUid = ((IFullTextSearchCardService)obj).GetCardTypeByObjectTypeUid(objectTypeUid.Value);
				num2 = 3;
				break;
			}
			case 14:
				if (objectId.HasValue)
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto default;
			case 13:
			{
				IFullTextSearchServiceReIndexingTypeExtension fullTextSearchService = base.FullTextSearchService;
				Type cardType = cardTypeByObjectTypeUid;
				List<long> list = new List<long>();
				objectId = item.ObjectId;
				list.Add(objectId.Value);
				fullTextSearchService.IndexEntities(cardType, list);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 7;
				}
				break;
			}
			case 6:
				queueType = item.QueueType;
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				if (qfa6LCGQceYekEv9vGmy(cardTypeByObjectTypeUid, null))
				{
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			case 12:
				objectTypeUid = item.ObjectTypeUid;
				num2 = 8;
				break;
			default:
				return true;
			case 8:
				if (!objectTypeUid.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 1:
				objectId = item.ObjectId;
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 11;
				}
				break;
			case 10:
				if (item == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 1;
			case 4:
				if (queueType != indexQueueType)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	private bool ReIndexObjectPart(IIndexQueue item)
	{
		//Discarded unreachable code: IL_008f, IL_00c2, IL_00f6, IL_0105, IL_0110, IL_0221, IL_0234, IL_02a3, IL_02b2, IL_02c2, IL_02d1, IL_0317, IL_038a, IL_0399, IL_03a4, IL_0504, IL_0534, IL_0543, IL_054f, IL_055e, IL_05f6, IL_062e
		int num = 14;
		long? objectId = default(long?);
		IndexQueueType? queueType = default(IndexQueueType?);
		Guid? guid = default(Guid?);
		List<QueueToIndex>.Enumerator enumerator = default(List<QueueToIndex>.Enumerator);
		QueueToIndex current = default(QueueToIndex);
		List<KeyValuePair<string, object>> list = default(List<KeyValuePair<string, object>>);
		IndexQueueType indexQueueType = default(IndexQueueType);
		IEnumerator<IGrouping<Type, QueueToIndex>> enumerator2 = default(IEnumerator<IGrouping<Type, QueueToIndex>>);
		IEnumerator<QueueToIndex> enumerator3 = default(IEnumerator<QueueToIndex>);
		QueueToIndex current3 = default(QueueToIndex);
		List<IEnumerable<KeyValuePair<string, object>>> list3 = default(List<IEnumerable<KeyValuePair<string, object>>>);
		List<KeyValuePair<string, object>> list2 = default(List<KeyValuePair<string, object>>);
		IGrouping<Type, QueueToIndex> current2 = default(IGrouping<Type, QueueToIndex>);
		List<QueueToIndex> queueToIndex = default(List<QueueToIndex>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (!objectId.HasValue)
					{
						num2 = 11;
						continue;
					}
					goto case 6;
				case 9:
					queueType = item.QueueType;
					num2 = 17;
					continue;
				case 15:
					guid = item.CardTypeUid;
					num2 = 2;
					continue;
				case 14:
					if (item == null)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 19;
				case 16:
					try
					{
						while (true)
						{
							IL_01a2:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 4;
								goto IL_0114;
							}
							goto IL_017f;
							IL_0114:
							while (true)
							{
								switch (num3)
								{
								case 2:
									current.Properties.Add(new KeyValuePair<string, object>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A1E551), current.Id));
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
									{
										num3 = 2;
									}
									continue;
								case 3:
									goto IL_01a2;
								case 1:
									if (!current.Properties.Any((KeyValuePair<string, object> p) => object.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548B2FD4), p.Key)))
									{
										num3 = 2;
										continue;
									}
									goto IL_01a2;
								case 4:
									goto end_IL_01a2;
								}
								break;
							}
							goto IL_017f;
							IL_017f:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
							{
								num3 = 1;
							}
							goto IL_0114;
							continue;
							end_IL_01a2:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					break;
				case 2:
					if (guid.HasValue)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 1;
				case 1:
				case 8:
				case 11:
				case 12:
				case 13:
					return true;
				case 19:
					objectId = item.ObjectId;
					num2 = 5;
					continue;
				case 6:
					guid = item.ObjectTypeUid;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					list = DirtyValuesHexToList((string)NOcmpmGQ9sudnlC0bSHe(item));
					num2 = 3;
					continue;
				case 17:
					indexQueueType = IndexQueueType.ReIndexObjectPart;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 20;
					}
					continue;
				case 7:
					try
					{
						while (true)
						{
							int num5;
							if (!jnqeyoGQzGCacFmWvxVP(enumerator2))
							{
								num5 = 6;
								goto IL_0325;
							}
							goto IL_0361;
							IL_0325:
							while (true)
							{
								switch (num5)
								{
								case 3:
									break;
								case 5:
									goto IL_0361;
								default:
									try
									{
										while (true)
										{
											IL_03ca:
											int num6;
											if (!jnqeyoGQzGCacFmWvxVP(enumerator3))
											{
												num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
												{
													num6 = 0;
												}
												goto IL_03a8;
											}
											goto IL_03f0;
											IL_03f0:
											current3 = enumerator3.Current;
											num6 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
											{
												num6 = 1;
											}
											goto IL_03a8;
											IL_03a8:
											while (true)
											{
												switch (num6)
												{
												case 1:
													goto IL_03ca;
												case 3:
													goto IL_03f0;
												case 5:
													list3.Add(list2);
													num6 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
													{
														num6 = 1;
													}
													continue;
												case 4:
													list2 = current3.Properties.Select((KeyValuePair<string, object> p) => new KeyValuePair<string, object>(p.Key, p.Value)).ToList();
													num6 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
													{
														num6 = 2;
													}
													continue;
												case 2:
													list2.AddRange(current3.DynamicProperties.Select((FieldIndexListItem di) => new KeyValuePair<string, object>(di.Field, di)));
													num6 = 5;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
													{
														num6 = 1;
													}
													continue;
												case 0:
													break;
												}
												break;
											}
											break;
										}
									}
									finally
									{
										int num7;
										if (enumerator3 == null)
										{
											num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
											{
												num7 = 0;
											}
											goto IL_0508;
										}
										goto IL_051e;
										IL_051e:
										fkWwVQGCFbH6EYExRcw9(enumerator3);
										num7 = 2;
										goto IL_0508;
										IL_0508:
										switch (num7)
										{
										default:
											goto end_IL_04e3;
										case 1:
											break;
										case 0:
											goto end_IL_04e3;
										case 2:
											goto end_IL_04e3;
										}
										goto IL_051e;
										end_IL_04e3:;
									}
									goto case 2;
								case 1:
									list3 = new List<IEnumerable<KeyValuePair<string, object>>>();
									num5 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
									{
										num5 = 4;
									}
									continue;
								case 4:
									enumerator3 = current2.GetEnumerator();
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
									{
										num5 = 0;
									}
									continue;
								case 2:
								{
									((IFullTextSearchService)ykPnvsGQrFK86K9Je66g(this)).ReIndexByPropertyList(current2.Key, list3);
									int num8 = 3;
									num5 = num8;
									continue;
								}
								case 6:
									goto end_IL_034b;
								}
								break;
							}
							continue;
							IL_0361:
							current2 = enumerator2.Current;
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
							{
								num5 = 0;
							}
							goto IL_0325;
							continue;
							end_IL_034b:
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							int num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num9 = 0;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									enumerator2.Dispose();
									num9 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
									{
										num9 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 1;
				case 20:
					if (queueType != indexQueueType)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 10;
				default:
					if (guid.HasValue)
					{
						num2 = 15;
						continue;
					}
					goto case 1;
				case 21:
					goto end_IL_0012;
				case 3:
					if (!list.Any())
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto end_IL_0012;
				case 4:
					enumerator = queueToIndex.GetEnumerator();
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 14;
					}
					continue;
				case 18:
					break;
				}
				enumerator2 = (from i in queueToIndex
					group i by i.CardType).GetEnumerator();
				num2 = 7;
				continue;
				end_IL_0012:
				break;
			}
			IFullTextTypeMappingServiceExt fullTextTypeMappingServiceExt = MappingService;
			List<KeyValuePair<string, object>> item2 = list;
			objectId = item.ObjectId;
			long value = objectId.Value;
			guid = item.ObjectTypeUid;
			queueToIndex = fullTextTypeMappingServiceExt.GetQueueToIndex(item2, value, guid.Value);
			num = 4;
		}
	}

	private void MergeBlanks(List<IIndexQueue> itemsIndex, out List<IIndexQueue> itemsForIndex, out List<IIndexQueue> itemsForClear)
	{
		itemsForIndex = new List<IIndexQueue>();
		itemsForClear = new List<IIndexQueue>();
		foreach (IGrouping<Guid?, IIndexQueue> item in from i in itemsIndex
			group i by i.CardTypeUid)
		{
			_003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass34_0();
			if (!item.Key.HasValue)
			{
				continue;
			}
			IOrderedEnumerable<IIndexQueue> source = from i in item.Where(delegate(IIndexQueue i)
				{
					int num17 = 1;
					int num18 = num17;
					IndexQueueType? queueType7 = default(IndexQueueType?);
					IndexQueueType indexQueueType7 = default(IndexQueueType);
					while (true)
					{
						switch (num18)
						{
						case 1:
							queueType7 = i.QueueType;
							num18 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
							{
								num18 = 0;
							}
							break;
						default:
							indexQueueType7 = IndexQueueType.IndexByType;
							num18 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
							{
								num18 = 1;
							}
							break;
						case 2:
							return queueType7 == indexQueueType7;
						}
					}
				})
				orderby i.Id
				select i;
			CS_0024_003C_003E8__locals2.newestIndexByType = source.LastOrDefault();
			if (CS_0024_003C_003E8__locals2.newestIndexByType != null)
			{
				itemsForIndex.Add(CS_0024_003C_003E8__locals2.newestIndexByType);
			}
			foreach (IGrouping<long?, IIndexQueue> item2 in from i in (CS_0024_003C_003E8__locals2.newestIndexByType == null) ? item.Where(delegate(IIndexQueue i)
				{
					//Discarded unreachable code: IL_006c, IL_007b
					int num15 = 2;
					int num16 = num15;
					IndexQueueType indexQueueType6 = default(IndexQueueType);
					IndexQueueType? queueType6 = default(IndexQueueType?);
					while (true)
					{
						switch (num16)
						{
						case 6:
							indexQueueType6 = IndexQueueType.ReIndexObject;
							num16 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
							{
								num16 = 3;
							}
							break;
						case 4:
							queueType6 = i.QueueType;
							num16 = 6;
							break;
						case 3:
							return queueType6 == indexQueueType6;
						case 5:
							return true;
						case 2:
							queueType6 = i.QueueType;
							num16 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
							{
								num16 = 1;
							}
							break;
						default:
							if (queueType6 == indexQueueType6)
							{
								num16 = 5;
								break;
							}
							goto case 4;
						case 1:
							indexQueueType6 = IndexQueueType.IndexObject;
							num16 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
							{
								num16 = 0;
							}
							break;
						}
					}
				}) : (from i in item.Where(delegate(IIndexQueue i)
					{
						//Discarded unreachable code: IL_005f
						int num13 = 2;
						int num14 = num13;
						IndexQueueType? queueType5 = default(IndexQueueType?);
						IndexQueueType indexQueueType5 = default(IndexQueueType);
						while (true)
						{
							switch (num14)
							{
							case 6:
								queueType5 = i.QueueType;
								num14 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
								{
									num14 = 0;
								}
								break;
							default:
								indexQueueType5 = IndexQueueType.ReIndexObject;
								num14 = 5;
								break;
							case 5:
								return queueType5 == indexQueueType5;
							case 4:
								return true;
							case 1:
								indexQueueType5 = IndexQueueType.IndexObject;
								num14 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
								{
									num14 = 2;
								}
								break;
							case 2:
								queueType5 = i.QueueType;
								num14 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
								{
									num14 = 0;
								}
								break;
							case 3:
								if (queueType5 == indexQueueType5)
								{
									num14 = 4;
									break;
								}
								goto case 6;
							}
						}
					})
					where i.Id > CS_0024_003C_003E8__locals2.newestIndexByType.Id
					select i)
				group i by i.ObjectId)
			{
				IIndexQueue indexQueue = item2.OrderBy((IIndexQueue i) => i.Id).LastOrDefault();
				if (indexQueue != null)
				{
					itemsForIndex.Add(indexQueue);
				}
			}
			IEnumerable<IIndexQueue> source2 = ((CS_0024_003C_003E8__locals2.newestIndexByType == null) ? item.Where(delegate(IIndexQueue i)
			{
				int num11 = 2;
				int num12 = num11;
				IndexQueueType indexQueueType4 = default(IndexQueueType);
				IndexQueueType? queueType4 = default(IndexQueueType?);
				while (true)
				{
					switch (num12)
					{
					case 1:
						indexQueueType4 = IndexQueueType.ReIndexObjectPart;
						num12 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num12 = 0;
						}
						break;
					default:
						return queueType4 == indexQueueType4;
					case 2:
						queueType4 = i.QueueType;
						num12 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num12 = 0;
						}
						break;
					}
				}
			}) : (from i in item.Where(delegate(IIndexQueue i)
				{
					int num9 = 2;
					int num10 = num9;
					IndexQueueType? queueType3 = default(IndexQueueType?);
					IndexQueueType indexQueueType3 = default(IndexQueueType);
					while (true)
					{
						switch (num10)
						{
						case 2:
							queueType3 = i.QueueType;
							num10 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
							{
								num10 = 1;
							}
							break;
						default:
							return queueType3 == indexQueueType3;
						case 1:
							indexQueueType3 = IndexQueueType.ReIndexObjectPart;
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
							{
								num10 = 0;
							}
							break;
						}
					}
				})
				where i.Id > CS_0024_003C_003E8__locals2.newestIndexByType.Id
				select i));
			foreach (IGrouping<Guid?, IIndexQueue> item3 in from i in source2
				group i by i.ObjectTypeUid)
			{
				_003C_003Ec__DisplayClass34_1 _003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_1();
				if (item3 == null)
				{
					continue;
				}
				_003C_003Ec__DisplayClass34_.objectTypeGroupF = item3;
				foreach (IGrouping<long?, IIndexQueue> item4 in from i in source2
					group i by i.ObjectId)
				{
					_003C_003Ec__DisplayClass34_2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass34_2();
					CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass34_;
					if (item4 == null)
					{
						continue;
					}
					CS_0024_003C_003E8__locals0.objectIdGroupF = item4;
					CS_0024_003C_003E8__locals0.newestIndexObjectForTypeAndId = itemsForIndex.FirstOrDefault(delegate(IIndexQueue i)
					{
						//Discarded unreachable code: IL_0049, IL_0088, IL_0097
						int num7 = 6;
						int num8 = num7;
						long? objectId3 = default(long?);
						long? key2 = default(long?);
						Guid? objectTypeUid = default(Guid?);
						Guid? key = default(Guid?);
						while (true)
						{
							switch (num8)
							{
							default:
								if (objectId3 != key2)
								{
									num8 = 7;
									break;
								}
								goto case 8;
							case 3:
								return true;
							case 2:
								return objectTypeUid.GetValueOrDefault() == key.GetValueOrDefault();
							case 7:
								return false;
							case 4:
								key = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.objectTypeGroupF.Key;
								num8 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
								{
									num8 = 1;
								}
								break;
							case 8:
								objectTypeUid = i.ObjectTypeUid;
								num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
								{
									num8 = 4;
								}
								break;
							case 6:
								objectId3 = i.ObjectId;
								num8 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
								{
									num8 = 4;
								}
								break;
							case 5:
								key2 = CS_0024_003C_003E8__locals0.objectIdGroupF.Key;
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
								{
									num8 = 0;
								}
								break;
							case 9:
								if (objectTypeUid.HasValue != key.HasValue)
								{
									num8 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
									{
										num8 = 1;
									}
									break;
								}
								if (objectTypeUid.HasValue)
								{
									num8 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
									{
										num8 = 2;
									}
									break;
								}
								goto case 3;
							case 1:
								return false;
							}
						}
					});
					IEnumerable<IIndexQueue> enumerable = ((CS_0024_003C_003E8__locals0.newestIndexObjectForTypeAndId == null) ? item4.Where(delegate(IIndexQueue i)
					{
						int num5 = 2;
						int num6 = num5;
						IndexQueueType indexQueueType2 = default(IndexQueueType);
						IndexQueueType? queueType2 = default(IndexQueueType?);
						while (true)
						{
							switch (num6)
							{
							case 1:
								indexQueueType2 = IndexQueueType.ReIndexObjectPart;
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
								{
									num6 = 0;
								}
								break;
							default:
								return queueType2 == indexQueueType2;
							case 2:
								queueType2 = i.QueueType;
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
								{
									num6 = 0;
								}
								break;
							}
						}
					}) : (from i in item4.Where(delegate(IIndexQueue i)
						{
							int num3 = 2;
							int num4 = num3;
							IndexQueueType? queueType = default(IndexQueueType?);
							IndexQueueType indexQueueType = default(IndexQueueType);
							while (true)
							{
								switch (num4)
								{
								default:
									return queueType == indexQueueType;
								case 2:
									queueType = i.QueueType;
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
									{
										num4 = 1;
									}
									break;
								case 1:
									indexQueueType = IndexQueueType.ReIndexObjectPart;
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						})
						where i.Id > CS_0024_003C_003E8__locals0.newestIndexObjectForTypeAndId.Id
						select i));
					if (enumerable == null)
					{
						continue;
					}
					using IEnumerator<IIndexQueue> enumerator4 = enumerable.GetEnumerator();
					while (enumerator4.MoveNext())
					{
						_003C_003Ec__DisplayClass34_3 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass34_3();
						CS_0024_003C_003E8__locals1.item = enumerator4.Current;
						if (!itemsForIndex.Any(delegate(IIndexQueue a)
						{
							int num = 2;
							int num2 = num;
							long? objectId2 = default(long?);
							long? objectId = default(long?);
							while (true)
							{
								switch (num2)
								{
								case 1:
									objectId2 = CS_0024_003C_003E8__locals1.item.ObjectId;
									num2 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
									{
										num2 = 0;
									}
									break;
								case 2:
									objectId = a.ObjectId;
									num2 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
									{
										num2 = 1;
									}
									break;
								default:
									return objectId == objectId2;
								}
							}
						}) || (itemsForIndex.Any() && itemsForIndex.LastOrDefault().DirtyValues != CS_0024_003C_003E8__locals1.item.DirtyValues))
						{
							itemsForIndex.Add(CS_0024_003C_003E8__locals1.item);
						}
					}
				}
			}
		}
		foreach (IIndexQueue item5 in itemsIndex)
		{
			if (!itemsForIndex.Contains(item5))
			{
				itemsForClear.Add(item5);
			}
		}
	}

	private bool IsIndexingOn()
	{
		return rbiHaVGCBnyKaogqpbQH(ykPnvsGQrFK86K9Je66g(this)) == FullTextSearchState.On;
	}

	private bool IndexingIsWorking()
	{
		return nmmUsEGCWxjrRf1gXdUb(ykPnvsGQrFK86K9Je66g(this));
	}

	[Obsolete("Устарело. Используйте FullTextHandlerActor", true)]
	public void IndexQueueProcessing()
	{
	}

	internal void InternalIndexQueueProcessing()
	{
		//Discarded unreachable code: IL_006e, IL_0127, IL_017e, IL_01d5, IL_022c, IL_0283, IL_02bf, IL_02ce, IL_0333, IL_0342, IL_034e, IL_035d
		int num = 2;
		int num2 = num;
		IUnitOfWork unitOfWork = default(IUnitOfWork);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				if (!IndexingIsWorking())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 1;
					}
					break;
				}
				unitOfWork = ((IUnitOfWorkManager)iPal6mGCo5SosxVD3aVo(this)).Create(string.Empty, transactional: true, IsolationLevel.Unspecified);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 4:
								return;
							default:
								KWqnsqGCGjbdPZarcfHx(gTri96GCh5qHdW5A7xKA(base.SessionProvider, string.Empty));
								num3 = 2;
								continue;
							case 2:
								break;
							case 3:
								rQX5DTGCE3ukFqxsf50W(unitOfWork);
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
								{
									num3 = 3;
								}
								continue;
							case 1:
								try
								{
									base.SecurityService.RunBySystemUser(delegate
									{
										int num11 = 1;
										int num12 = num11;
										while (true)
										{
											switch (num12)
											{
											default:
												return;
											case 1:
												((ISecurityService)RHyEDpGCXsQ1IFlorLcI(this)).RunWithElevatedPrivilegies((Action)delegate
												{
													int num13 = 1;
													int num14 = num13;
													while (true)
													{
														switch (num14)
														{
														default:
															return;
														case 0:
															return;
														case 1:
															Processing();
															num14 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
															{
																num14 = 0;
															}
															break;
														}
													}
												});
												num12 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
												{
													num12 = 0;
												}
												break;
											case 0:
												return;
											}
										}
									});
									int num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
									{
										num4 = 0;
									}
									while (true)
									{
										switch (num4)
										{
										default:
											unitOfWork.Commit();
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
											{
												num4 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								catch (StopIndexingException)
								{
									int num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
									{
										num5 = 1;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											return;
										case 0:
											return;
										case 1:
											unitOfWork.Commit();
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
											{
												num5 = 0;
											}
											break;
										}
									}
								}
								catch (IndexingServerUnavailableException)
								{
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
									{
										num6 = 0;
									}
									while (true)
									{
										switch (num6)
										{
										case 1:
											return;
										}
										unitOfWork.Commit();
										num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
										{
											num6 = 1;
										}
									}
								}
								catch (MappingServiceNotAvailableException)
								{
									int num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
									{
										num7 = 0;
									}
									while (true)
									{
										switch (num7)
										{
										case 1:
											return;
										}
										unitOfWork.Commit();
										num7 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
										{
											num7 = 0;
										}
									}
								}
								catch (Exception)
								{
									int num8 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
									{
										num8 = 1;
									}
									while (true)
									{
										switch (num8)
										{
										case 1:
											vDvMVoGCbwh8tddmgffV(unitOfWork);
											num8 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
											{
												num8 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
								goto default;
							}
							if (HasIndexAllQueueForContinue())
							{
								break;
							}
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
							{
								num3 = 3;
							}
						}
					}
				}
				finally
				{
					int num10;
					if (unitOfWork == null)
					{
						int num9 = 2;
						num10 = num9;
						goto IL_02f7;
					}
					goto IL_030d;
					IL_02f7:
					switch (num10)
					{
					default:
						goto end_IL_02de;
					case 1:
						break;
					case 2:
						goto end_IL_02de;
					case 0:
						goto end_IL_02de;
					}
					goto IL_030d;
					IL_030d:
					unitOfWork.Dispose();
					num10 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num10 = 0;
					}
					goto IL_02f7;
					end_IL_02de:;
				}
			case 1:
				return;
			}
		}
	}

	private bool Processing()
	{
		//Discarded unreachable code: IL_00d2, IL_00e0, IL_0127, IL_0136, IL_0228, IL_0237, IL_0280, IL_028f, IL_02c0, IL_0300, IL_030f, IL_031b, IL_0362, IL_036c, IL_03ff, IL_049a, IL_04a9, IL_04b9, IL_059e, IL_05b1, IL_05c0, IL_05d0, IL_05df, IL_060a, IL_063a, IL_069d, IL_06ac, IL_06f3, IL_072b, IL_07aa, IL_085d, IL_086c, IL_0877, IL_09d4, IL_09e7, IL_0a43, IL_0ab2, IL_0b1b, IL_0b74, IL_0bac, IL_0bbb, IL_0d7b, IL_0d8a, IL_0d9a, IL_0da9, IL_0e55, IL_0e64
		int num = 8;
		ICollection<IIndexQueue> collection = default(ICollection<IIndexQueue>);
		List<IIndexQueue> itemsForIndex = default(List<IIndexQueue>);
		List<IIndexQueue> itemsForClear = default(List<IIndexQueue>);
		IEnumerator<IIndexQueue> enumerator2 = default(IEnumerator<IIndexQueue>);
		IIndexQueue current2 = default(IIndexQueue);
		long? creationAuthorId = default(long?);
		Dictionary<long, long> dictionary = default(Dictionary<long, long>);
		long value2 = default(long);
		IIndexQueueFilter indexQueueFilter2 = default(IIndexQueueFilter);
		ICollection<IIndexQueue> collection2 = default(ICollection<IIndexQueue>);
		FetchOptions fetchOptions4 = default(FetchOptions);
		IIndexQueue current3 = default(IIndexQueue);
		List<IIndexQueue> list = default(List<IIndexQueue>);
		IndexQueueType valueOrDefault = default(IndexQueueType);
		IIndexQueueFilter indexQueueFilter = default(IIndexQueueFilter);
		Dictionary<long, long>.Enumerator enumerator = default(Dictionary<long, long>.Enumerator);
		KeyValuePair<long, long> current = default(KeyValuePair<long, long>);
		Dictionary<long, long> dictionary2 = default(Dictionary<long, long>);
		IDataReader dataReader = default(IDataReader);
		string sql = default(string);
		Dictionary<string, object> paramValues = default(Dictionary<string, object>);
		long key = default(long);
		long value = default(long);
		IFullTextTypeMappingAvailability fullTextTypeMappingAvailability = default(IFullTextTypeMappingAvailability);
		FetchOptions fetchOptions2 = default(FetchOptions);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					if (!IsIndexingOn())
					{
						num2 = 7;
						continue;
					}
					if (IndexingIsWorking())
					{
						num2 = 9;
						continue;
					}
					goto case 1;
				case 11:
					MergeBlanks(collection.ToList(), out itemsForIndex, out itemsForClear);
					num2 = 10;
					continue;
				case 29:
					try
					{
						while (true)
						{
							int num12;
							if (!jnqeyoGQzGCacFmWvxVP(enumerator2))
							{
								num12 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
								{
									num12 = 4;
								}
								goto IL_00e4;
							}
							goto IL_01c5;
							IL_01c5:
							current2 = enumerator2.Current;
							num12 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
							{
								num12 = 12;
							}
							goto IL_00e4;
							IL_00e4:
							while (true)
							{
								switch (num12)
								{
								case 3:
								case 7:
								case 11:
									break;
								case 12:
									creationAuthorId = current2.CreationAuthorId;
									num12 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
									{
										num12 = 1;
									}
									continue;
								case 8:
									dictionary[value2]++;
									num12 = 11;
									continue;
								case 6:
								case 9:
									dictionary.Add(value2, 1L);
									num12 = 3;
									continue;
								case 2:
									goto IL_01c5;
								case 10:
									if (!dictionary.ContainsKey(value2))
									{
										num12 = 9;
										continue;
									}
									goto case 8;
								case 5:
									creationAuthorId = current2.CreationAuthorId;
									num12 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
									{
										num12 = 0;
									}
									continue;
								case 1:
									if (!creationAuthorId.HasValue)
									{
										num12 = 7;
										continue;
									}
									goto case 5;
								default:
									value2 = creationAuthorId.Value;
									num12 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
									{
										num12 = 6;
									}
									continue;
								case 4:
									goto end_IL_0141;
								}
								break;
							}
							continue;
							end_IL_0141:
							break;
						}
					}
					finally
					{
						int num13;
						if (enumerator2 == null)
						{
							num13 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
							{
								num13 = 0;
							}
							goto IL_02c4;
						}
						goto IL_02da;
						IL_02da:
						fkWwVQGCFbH6EYExRcw9(enumerator2);
						num13 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num13 = 0;
						}
						goto IL_02c4;
						IL_02c4:
						switch (num13)
						{
						default:
							goto end_IL_029f;
						case 2:
							break;
						case 0:
							goto end_IL_029f;
						case 1:
							goto end_IL_029f;
						}
						goto IL_02da;
						end_IL_029f:;
					}
					goto case 25;
				case 12:
					indexQueueFilter2.QueueType = new List<IndexQueueType> { IndexQueueType.IndexAll };
					num = 30;
					break;
				case 21:
					collection2 = Find(indexQueueFilter2, fetchOptions4);
					num2 = 13;
					continue;
				case 14:
					try
					{
						while (true)
						{
							IL_06b7:
							int num14;
							if (!jnqeyoGQzGCacFmWvxVP(enumerator2))
							{
								num14 = 4;
								goto IL_0370;
							}
							goto IL_0392;
							IL_0370:
							while (true)
							{
								switch (num14)
								{
								case 2:
									break;
								case 5:
									goto IL_03a5;
								case 3:
									throw new StopIndexingException();
								default:
									try
									{
										IndexQueueType? queueType = current3.QueueType;
										int num15 = 6;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
										{
											num15 = 3;
										}
										while (true)
										{
											switch (num15)
											{
											default:
												goto end_IL_0403;
											case 6:
												if (!queueType.HasValue)
												{
													num15 = 12;
													continue;
												}
												break;
											case 2:
												list.Add(current3);
												num15 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
												{
													num15 = 1;
												}
												continue;
											case 11:
												ReIndexObjectPart(current3);
												num15 = 2;
												continue;
											case 12:
												goto end_IL_0403;
											case 14:
												goto end_IL_0403;
											case 8:
												list.Add(current3);
												num15 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
												{
													num15 = 0;
												}
												continue;
											case 9:
												goto IL_04e6;
											case 10:
												list.Add(current3);
												num15 = 4;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
												{
													num15 = 14;
												}
												continue;
											case 3:
												goto IL_051c;
											case 5:
												switch (valueOrDefault)
												{
												case IndexQueueType.ReIndexObjectPart:
													break;
												case IndexQueueType.IndexObject:
													goto IL_04e6;
												case IndexQueueType.IndexByType:
													goto IL_051c;
												default:
													goto IL_055c;
												case IndexQueueType.ReIndexObject:
													goto end_IL_0403;
												}
												goto case 11;
											case 13:
												break;
											case 0:
												goto end_IL_0403;
											case 7:
												goto end_IL_0403;
											case 4:
												goto end_IL_0403;
											case 1:
												goto end_IL_0403;
												IL_055c:
												num15 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
												{
													num15 = 7;
												}
												continue;
												IL_051c:
												if (!IndexByType(current3))
												{
													num15 = 4;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
													{
														num15 = 1;
													}
													continue;
												}
												goto case 8;
												IL_04e6:
												IndexObject(current3);
												num15 = 10;
												continue;
											}
											valueOrDefault = queueType.GetValueOrDefault();
											num15 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
											{
												num15 = 5;
											}
											continue;
											end_IL_0403:
											break;
										}
									}
									catch (StopIndexingException)
									{
										int num16 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
										{
											num16 = 0;
										}
										switch (num16)
										{
										default:
											throw;
										}
									}
									catch (Exception ex3)
									{
										int num17 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
										{
											num17 = 1;
										}
										while (true)
										{
											switch (num17)
											{
											case 1:
												NBSFoKGCul9oJHvV8gkI(IndexLog, UpOcGWGQ7iPBS2tcNYKs(rMfQq0GQDS3LR61R8L47(0x7C1EE318 ^ 0x7C1D2438), jkY6eOGCZN3eEffwbCOa(ex3)), ex3);
												num17 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
												{
													num17 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
									goto IL_06b7;
								case 1:
									goto IL_06b7;
								case 4:
									goto end_IL_06b7;
								}
								break;
								IL_03a5:
								if (!IsIndexingOn())
								{
									num14 = 3;
									continue;
								}
								num14 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
								{
									num14 = 0;
								}
							}
							goto IL_0392;
							IL_0392:
							current3 = enumerator2.Current;
							num14 = 5;
							goto IL_0370;
							continue;
							end_IL_06b7:
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							int num18 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
							{
								num18 = 0;
							}
							while (true)
							{
								switch (num18)
								{
								default:
									fkWwVQGCFbH6EYExRcw9(enumerator2);
									num18 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
									{
										num18 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 15;
				case 25:
					list = new List<IIndexQueue>();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 11;
					}
					continue;
				case 5:
				{
					bool result = IndexAll(collection2.Last());
					z7P7cZGCvkmqLpkW9vCX(TPo866GQarVj9TuSRtYb(), rMfQq0GQDS3LR61R8L47(-1765851862 ^ -1765999148));
					return result;
				}
				case 20:
					indexQueueFilter = InterfaceActivator.Create<IIndexQueueFilter>();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 19;
					}
					continue;
				case 2:
					((ICacheService)TPo866GQarVj9TuSRtYb()).ClearRegion((string)rMfQq0GQDS3LR61R8L47(-1886646897 ^ -1886401167));
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 9;
					}
					continue;
				case 15:
					if (IndexingIsWorking())
					{
						num2 = 3;
						continue;
					}
					goto case 22;
				case 3:
					try
					{
						if (prnUOBGCI0hdi65LIbMO(dictionary) > 0)
						{
							int num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
							{
								num3 = 6;
							}
							while (true)
							{
								switch (num3)
								{
								case 4:
									try
									{
										while (true)
										{
											int num7;
											if (!enumerator.MoveNext())
											{
												num7 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
												{
													num7 = 3;
												}
												goto IL_087b;
											}
											goto IL_08e7;
											IL_08e7:
											current = enumerator.Current;
											num7 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
											{
												num7 = 1;
											}
											goto IL_087b;
											IL_087b:
											while (true)
											{
												switch (num7)
												{
												case 1:
													if (dictionary2[current.Key] == current.Value)
													{
														num7 = 5;
														continue;
													}
													break;
												case 2:
													goto IL_08e7;
												case 4:
													if (dictionary2.ContainsKey(current.Key))
													{
														num7 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
														{
															num7 = 1;
														}
														continue;
													}
													goto case 5;
												case 5:
													cZtNv0GCieBFW8xFilMN(CacheService, SohwcfGQtday0DXOMFvZ(rMfQq0GQDS3LR61R8L47(-740338220 ^ -740420802), rMfQq0GQDS3LR61R8L47(-561074844 ^ -561156710), current.Key), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575969446));
													num7 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
													{
														num7 = 0;
													}
													continue;
												case 3:
													goto end_IL_089d;
												}
												break;
											}
											continue;
											end_IL_089d:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator).Dispose();
										int num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
										{
											num8 = 0;
										}
										switch (num8)
										{
										case 0:
											break;
										}
									}
									goto end_IL_082d;
								case 3:
									dictionary2 = new Dictionary<long, long>();
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
									{
										num3 = 0;
									}
									continue;
								default:
									dataReader = TransformationProvider.ExecuteQuery(sql, paramValues);
									num3 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
									{
										num3 = 6;
									}
									continue;
								case 7:
									try
									{
										while (true)
										{
											IL_0ad8:
											int num4;
											if (!dqxoQVGCSeuTXoWMDjMN(dataReader))
											{
												num4 = 3;
												goto IL_0a51;
											}
											goto IL_0a94;
											IL_0a51:
											while (true)
											{
												switch (num4)
												{
												case 4:
													dictionary2.Add(key, value);
													num4 = 6;
													continue;
												case 8:
													break;
												default:
													if (dictionary2.ContainsKey(key))
													{
														int num5 = 7;
														num4 = num5;
														continue;
													}
													goto case 2;
												case 1:
												case 6:
												case 7:
													goto IL_0ad8;
												case 2:
													if (!dictionary.ContainsKey(key))
													{
														num4 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
														{
															num4 = 1;
														}
														continue;
													}
													goto case 4;
												case 5:
													value = rC4jCKGQMqoydlwsoqlh(jcsq2TGCVDXalNGxp2pd(dataReader, 1));
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
													{
														num4 = 0;
													}
													continue;
												case 3:
													goto end_IL_0ad8;
												}
												break;
											}
											goto IL_0a94;
											IL_0a94:
											key = Convert.ToInt64(jcsq2TGCVDXalNGxp2pd(dataReader, 0));
											num4 = 5;
											goto IL_0a51;
											continue;
											end_IL_0ad8:
											break;
										}
									}
									finally
									{
										if (dataReader != null)
										{
											int num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
											{
												num6 = 0;
											}
											while (true)
											{
												switch (num6)
												{
												default:
													fkWwVQGCFbH6EYExRcw9(dataReader);
													num6 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
													{
														num6 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									break;
								case 1:
									paramValues = new Dictionary<string, object> { 
									{
										(string)rMfQq0GQDS3LR61R8L47(-105199646 ^ -105312270),
										true
									} };
									num3 = 3;
									continue;
								case 6:
									sql = string.Format((string)rMfQq0GQDS3LR61R8L47(0x5F3078B6 ^ 0x5F33BFD4), ((Dialect)UMoj6oGQHa5AGZZM7hKv(TransformationProvider)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099538333)), k4TYYXGQAiFtvrVK4rAy(UMoj6oGQHa5AGZZM7hKv(TransformationProvider), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475890265)), TransformationProvider.Dialect.QuoteIfNeeded((string)rMfQq0GQDS3LR61R8L47(-195614443 ^ -195698697)), ((Dialect)UMoj6oGQHa5AGZZM7hKv(TransformationProvider)).QuoteIfNeeded((string)rMfQq0GQDS3LR61R8L47(-1751176224 ^ -1751323624)), TransformationProvider.ParameterSeparator);
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
									{
										num3 = 1;
									}
									continue;
								case 5:
									break;
								case 2:
									goto end_IL_082d;
								}
								enumerator = dictionary.GetEnumerator();
								int num9 = 4;
								num3 = num9;
								continue;
								end_IL_082d:
								break;
							}
						}
					}
					catch (Exception ex)
					{
						int num10 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num10 = 1;
						}
						while (true)
						{
							switch (num10)
							{
							default:
							{
								z7P7cZGCvkmqLpkW9vCX(TPo866GQarVj9TuSRtYb(), rMfQq0GQDS3LR61R8L47(0x57A5235E ^ 0x57A6E3A0));
								int num11 = 2;
								num10 = num11;
								continue;
							}
							case 1:
								k6iqAQGQgtiYXt5yWG9y(IndexLog, ex);
								num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
								{
									num10 = 0;
								}
								continue;
							case 2:
								break;
							}
							break;
						}
					}
					goto default;
				case 17:
					throw new MappingServiceNotAvailableException(fullTextTypeMappingAvailability.Errors);
				case 4:
				{
					FetchOptions fetchOptions = new FetchOptions();
					rT5KaiGC8rGEuWpIhAPl(fetchOptions, 100);
					XJ7mA4GQJZVJMOJL8Gh6(fetchOptions, rMfQq0GQDS3LR61R8L47(-210725949 ^ -210759011));
					fetchOptions2 = fetchOptions;
					num2 = 6;
					continue;
				}
				case 30:
				{
					FetchOptions fetchOptions3 = new FetchOptions();
					XJ7mA4GQJZVJMOJL8Gh6(fetchOptions3, rMfQq0GQDS3LR61R8L47(-867826612 ^ -867793646));
					fetchOptions4 = fetchOptions3;
					num2 = 21;
					continue;
				}
				default:
					if (vaZMNHGCRNR7JMiZ6Vvo(list) > 0)
					{
						num2 = 23;
						continue;
					}
					goto case 18;
				case 16:
					dictionary = new Dictionary<long, long>();
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 23;
					}
					continue;
				case 24:
					if (mFnGYHGCCfUZM3iEX2vi(collection) > 0)
					{
						num = 16;
						break;
					}
					goto case 2;
				case 1:
					throw new IndexingServerUnavailableException();
				case 9:
					fullTextTypeMappingAvailability = (IFullTextTypeMappingAvailability)AL5FMpGCfT1HlyuYH14R(MappingService);
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					collection = Find(indexQueueFilter, fetchOptions2);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 24;
					}
					continue;
				case 26:
					if (gqnGNjGCQKciI9nZLc0U(fullTextTypeMappingAvailability))
					{
						indexQueueFilter2 = InterfaceActivator.Create<IIndexQueueFilter>();
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
						{
							num2 = 4;
						}
					}
					else
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num2 = 13;
						}
					}
					continue;
				case 7:
					throw new StopIndexingException();
				case 19:
					indexQueueFilter.QueueType = new List<IndexQueueType>
					{
						IndexQueueType.IndexByType,
						IndexQueueType.IndexObject,
						IndexQueueType.ReIndexObject,
						IndexQueueType.ReIndexObjectPart
					};
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 1;
					}
					continue;
				case 22:
				case 31:
					return true;
				case 13:
					if (mFnGYHGCCfUZM3iEX2vi(collection2) <= 0)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto case 5;
				case 18:
					if (vaZMNHGCRNR7JMiZ6Vvo(itemsForClear) > 0)
					{
						num2 = 28;
						continue;
					}
					goto case 22;
				case 27:
					enumerator2 = collection.Where(delegate(IIndexQueue i)
					{
						int num19 = 1;
						int num20 = num19;
						bool flag = default(bool);
						bool? visualData = default(bool?);
						while (true)
						{
							switch (num20)
							{
							default:
								flag = true;
								num20 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
								{
									num20 = 0;
								}
								break;
							case 1:
								visualData = i.VisualData;
								num20 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
								{
									num20 = 0;
								}
								break;
							case 2:
								return visualData == flag;
							}
						}
					}).GetEnumerator();
					num2 = 29;
					continue;
				case 10:
					enumerator2 = itemsForIndex.OrderBy((IIndexQueue i) => i.Id).GetEnumerator();
					num2 = 14;
					continue;
				case 23:
					list.ForEach(delegate(IIndexQueue i)
					{
						_003C_003Ec.dZSbm8vjEhjnRFYXqyvL(i);
					});
					num2 = 18;
					continue;
				case 28:
					itemsForClear.ForEach(delegate(IIndexQueue i)
					{
						_003C_003Ec.dZSbm8vjEhjnRFYXqyvL(i);
					});
					num2 = 31;
					continue;
				}
				break;
			}
		}
	}

	public void AddReindexObjectPartItem(Type cardType, long objectId, Guid objectTypeUid, List<KeyValuePair<string, object>> listPairs, bool visualData = false)
	{
		Guid? cardUidByCardType = base.FullTextSearchCardService.GetCardUidByCardType(cardType);
		if (cardUidByCardType.HasValue)
		{
			AddReindexObjectPartItem(cardUidByCardType.Value, objectId, objectTypeUid, listPairs, visualData);
		}
	}

	public void AddReindexObjectPartItem(Guid cardUid, long objectId, Guid objectTypeUid, List<KeyValuePair<string, object>> listPairs, bool visualData = false)
	{
		if (!(cardUid == Guid.Empty))
		{
			CreateReindexObjectPartItem(cardUid, objectId, objectTypeUid, listPairs, visualData)?.Save();
		}
	}

	public IIndexQueue CreateReindexObjectPartItem(Type cardType, long objectId, Guid objectTypeUid, List<KeyValuePair<string, object>> listPairs, bool visualData = false)
	{
		Guid? cardUidByCardType = base.FullTextSearchCardService.GetCardUidByCardType(cardType);
		if (cardUidByCardType.HasValue)
		{
			return CreateReindexObjectPartItem(cardUidByCardType.Value, objectId, objectTypeUid, listPairs, visualData);
		}
		return null;
	}

	public IIndexQueue CreateReindexObjectPartItem(Guid cardUid, long objectId, Guid objectTypeUid, List<KeyValuePair<string, object>> listPairs, bool visualData = false)
	{
		if (cardUid == Guid.Empty)
		{
			return null;
		}
		List<string> list = new List<string>();
		if (listPairs != null && listPairs.Any())
		{
			foreach (KeyValuePair<string, object> listPair in listPairs)
			{
				if (!string.IsNullOrWhiteSpace(listPair.Key))
				{
					byte[] array = ClassSerializationHelper.SerializeObject(new KeyValuePair<string, object>(listPair.Key, listPair.Value));
					list.Add(BitConverter.ToString(array).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463A0150), ""));
				}
			}
			IIndexQueue indexQueue = InterfaceActivator.Create<IIndexQueue>();
			indexQueue.DirtyValues = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD54D02), list);
			indexQueue.CardTypeUid = cardUid;
			indexQueue.ObjectId = objectId;
			indexQueue.ObjectTypeUid = objectTypeUid;
			indexQueue.QueueType = IndexQueueType.ReIndexObjectPart;
			indexQueue.VisualData = visualData;
			return indexQueue;
		}
		return null;
	}

	public IndexQueueManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static IndexQueueManager()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				IndexLog = (ILogger)AJvsL1GCKC15DQdQpsIB(rMfQq0GQDS3LR61R8L47(0x2ACE37D ^ 0x2AFDBED));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				IndexQueueListContextKeyConst = (string)rMfQq0GQDS3LR61R8L47(-787452571 ^ -787241641);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				huGS4SGCqOAmPcKT4DVn();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool piUJfkGQ1lmoICVawQLS()
	{
		return i8L63YGQPIi9XJXjODLh == null;
	}

	internal static IndexQueueManager g3g1TcGQNSsePB90neuR()
	{
		return i8L63YGQPIi9XJXjODLh;
	}

	internal static object wA8TeVGQ3Uj6UARs3Gp7(object P_0)
	{
		return ((EntityManager<IIndexQueue, long>)P_0).AuthenticationService;
	}

	internal static object PjoolAGQpMVuZ8hQHCwU(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static object TPo866GQarVj9TuSRtYb()
	{
		return CacheService;
	}

	internal static object rMfQq0GQDS3LR61R8L47(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object SohwcfGQtday0DXOMFvZ(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object klo5B0GQwkL3UT8bQ7lx(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static bool oXNnmQGQ4LWj6KBY4eTF(object P_0, object P_1, object P_2)
	{
		return ((ICacheService)P_0).Contains((string)P_1, (string)P_2);
	}

	internal static bool F8hpPeGQ6VRO9BiAk8NQ(object P_0, object P_1)
	{
		return ((EntityManager<IIndexQueue, long>)P_0).Exists((IEntityFilter)P_1);
	}

	internal static object UMoj6oGQHa5AGZZM7hKv(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object k4TYYXGQAiFtvrVK4rAy(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object UpOcGWGQ7iPBS2tcNYKs(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object Sy3OOEGQxV2xCVb8u1dK(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static byte spB5MiGQ0mTMuxC9LgKY(object P_0, int P_1)
	{
		return Convert.ToByte((string)P_0, P_1);
	}

	internal static object IpakLTGQme0cJLTV889k(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static object uANvCPGQyU30dArwmDq1(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static long rC4jCKGQMqoydlwsoqlh(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static void XJ7mA4GQJZVJMOJL8Gh6(object P_0, object P_1)
	{
		((FetchOptions)P_0).SortExpression = (string)P_1;
	}

	internal static object NOcmpmGQ9sudnlC0bSHe(object P_0)
	{
		return ((IIndexQueue)P_0).DirtyValues;
	}

	internal static bool y2j8kpGQdoowRXi1eXCB(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static long QXXkE5GQlnDaLqhRGCpX(object P_0)
	{
		return ((IIndexQueue)P_0).Attempt;
	}

	internal static object ykPnvsGQrFK86K9Je66g(object P_0)
	{
		return ((EntityManager<IIndexQueue, long>)P_0).FullTextSearchService;
	}

	internal static void k6iqAQGQgtiYXt5yWG9y(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object Q2ni16GQ58UmKva214JP(object P_0)
	{
		return ((EntityManager<IIndexQueue, long>)P_0).FullTextSearchCardService;
	}

	internal static Type SIu2N1GQj6Kc0yjN3apa(object P_0, Guid cardUid)
	{
		return ((IFullTextSearchCardService)P_0).GetCardTypeByCardUid(cardUid);
	}

	internal static bool trThAcGQYXb2rpC1RCDI(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static void WyeK25GQLaC7fjY2bHDC(object P_0, Type cardType)
	{
		((IFullTextSearchService)P_0).StopIndexingType(cardType);
	}

	internal static object Kd5m3EGQUSotUch9Nlhr(object P_0, object P_1)
	{
		return ((IFullTextSearchServiceReIndexingTypeExtension)P_0).ReIndexingByType((IIndexQueue)P_1);
	}

	internal static void BsumQEGQsupi7sKIrsWx(object P_0, long value)
	{
		((IIndexQueue)P_0).Attempt = value;
	}

	internal static bool qfa6LCGQceYekEv9vGmy(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool jnqeyoGQzGCacFmWvxVP(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void fkWwVQGCFbH6EYExRcw9(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static FullTextSearchState rbiHaVGCBnyKaogqpbQH(object P_0)
	{
		return ((IFullTextSearchService)P_0).GetIndexState();
	}

	internal static bool nmmUsEGCWxjrRf1gXdUb(object P_0)
	{
		return ((IFullTextSearchService)P_0).IndexingIsWorking();
	}

	internal static object iPal6mGCo5SosxVD3aVo(object P_0)
	{
		return ((EntityManager<IIndexQueue, long>)P_0).UnitOfWorkManager;
	}

	internal static void vDvMVoGCbwh8tddmgffV(object P_0)
	{
		((IUnitOfWork)P_0).Rollback();
	}

	internal static object gTri96GCh5qHdW5A7xKA(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static void KWqnsqGCGjbdPZarcfHx(object P_0)
	{
		((ISession)P_0).Clear();
	}

	internal static void rQX5DTGCE3ukFqxsf50W(object P_0)
	{
		((IUnitOfWork)P_0).Commit();
	}

	internal static object AL5FMpGCfT1HlyuYH14R(object P_0)
	{
		return ((IFullTextTypeMappingServiceExt)P_0).CheckAvailability();
	}

	internal static bool gqnGNjGCQKciI9nZLc0U(object P_0)
	{
		return ((IFullTextTypeMappingAvailability)P_0).IsAvailable;
	}

	internal static int mFnGYHGCCfUZM3iEX2vi(object P_0)
	{
		return ((ICollection<IIndexQueue>)P_0).Count;
	}

	internal static void z7P7cZGCvkmqLpkW9vCX(object P_0, object P_1)
	{
		((ICacheService)P_0).ClearRegion((string)P_1);
	}

	internal static void rT5KaiGC8rGEuWpIhAPl(object P_0, int value)
	{
		((FetchOptions)P_0).MaxResults = value;
	}

	internal static object jkY6eOGCZN3eEffwbCOa(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void NBSFoKGCul9oJHvV8gkI(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static int prnUOBGCI0hdi65LIbMO(object P_0)
	{
		return ((Dictionary<long, long>)P_0).Count;
	}

	internal static object jcsq2TGCVDXalNGxp2pd(object P_0, int P_1)
	{
		return ((IDataRecord)P_0)[P_1];
	}

	internal static bool dqxoQVGCSeuTXoWMDjMN(object P_0)
	{
		return ((IDataReader)P_0).Read();
	}

	internal static void cZtNv0GCieBFW8xFilMN(object P_0, object P_1, object P_2)
	{
		((ICacheService)P_0).Remove((string)P_1, (string)P_2);
	}

	internal static int vaZMNHGCRNR7JMiZ6Vvo(object P_0)
	{
		return ((List<IIndexQueue>)P_0).Count;
	}

	internal static void huGS4SGCqOAmPcKT4DVn()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object AJvsL1GCKC15DQdQpsIB(object P_0)
	{
		return EleWise.ELMA.Logging.Logger.GetLogger((string)P_0);
	}

	internal static object RHyEDpGCXsQ1IFlorLcI(object P_0)
	{
		return ((EntityManager<IIndexQueue, long>)P_0).SecurityService;
	}
}
