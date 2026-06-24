using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Settings.Managers;

public class TypeSettingsInstanceStoreManager : EntityManager<ITypeSettingsInstanceStore, long>
{
	internal static TypeSettingsInstanceStoreManager IjYu36bWz9fvF7MNaQun;

	public new static TypeSettingsInstanceStoreManager Instance => Locator.GetServiceNotNull<TypeSettingsInstanceStoreManager>();

	public ITypeSettingsInstanceStore Load(IEntity entity, bool createIfNotExists, bool loadIfNotLoaded)
	{
		//Discarded unreachable code: IL_01a4, IL_0269, IL_0278
		int num = 10;
		int num2 = num;
		string text = default(string);
		ITypeSettingsInstanceStore value = default(ITypeSettingsInstanceStore);
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
				((IMemoryCacheService)rm2G5tboWAlyAFjMi445(this)).TryGetValue(text, out value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				value = LoadOrNull(z0B6PVbooLAEdnspr3A6(classMetadata), KjjP62bobOZcm2htrZV5(entity));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				if (!IsNewEntity(entity))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto default;
			case 1:
				ContextVars.Set(text, value);
				num2 = 13;
				break;
			case 4:
				if (!ContextVars.TryGetValue<ITypeSettingsInstanceStore>(text, out value))
				{
					num2 = 14;
					break;
				}
				goto default;
			case 14:
				if (!(loadIfNotLoaded || createIfNotExists))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			case 16:
				value = null;
				num2 = 17;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 18;
				}
				break;
			case 5:
				return value;
			case 17:
				qmasB5boh499Uex2UihR(value, classMetadata.Uid);
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 8;
				}
				break;
			case 11:
				ContextVars.Set(text, value);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 5;
				}
				break;
			case 15:
				fS3ecSboEIkZaTSxI5oY(value, new TypeSettingsInstanceData());
				num2 = 11;
				break;
			case 12:
				CghYEIboGeXXqaD1SqRG(value, KjjP62bobOZcm2htrZV5(entity).ToString());
				num2 = 15;
				break;
			default:
				if (value == null && createIfNotExists)
				{
					num2 = 2;
					break;
				}
				goto case 5;
			case 18:
				if (IsNewEntity(entity))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 4;
			case 2:
				value = InterfaceActivator.Create<ITypeSettingsInstanceStore>();
				num2 = 17;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 17;
				}
				break;
			case 9:
				text = TypeSettingsInstanceStoreCacheKey(entity);
				num2 = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 16;
				}
				break;
			case 10:
				classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entity.GetType());
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	public virtual void Save(IEntity entity, ITypeSettingsInstanceStore settingsStore)
	{
		//Discarded unreachable code: IL_009e
		int num = 6;
		string key = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 5:
					if (!IsNewEntity(settingsStore))
					{
						num = 4;
						break;
					}
					goto IL_00dd;
				case 2:
				case 7:
					AddToPending(entity, settingsStore);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					((IMemoryCacheService)rm2G5tboWAlyAFjMi445(this)).Insert(key, settingsStore);
					num = 7;
					break;
				case 0:
					return;
				case 4:
					Save(settingsStore);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					key = TypeSettingsInstanceStoreCacheKey(entity);
					num2 = 3;
					continue;
				case 1:
					return;
				case 6:
					{
						if (!IsNewEntity(entity))
						{
							num2 = 5;
							continue;
						}
						goto IL_00dd;
					}
					IL_00dd:
					if (!IsNewEntity(entity))
					{
						num2 = 2;
						continue;
					}
					goto case 8;
				}
				break;
			}
		}
	}

	internal void SavePending()
	{
		//Discarded unreachable code: IL_0053, IL_0062, IL_0120, IL_0133, IL_0229, IL_0277, IL_028a
		int num = 1;
		int num2 = num;
		List<Tuple<IEntity, ITypeSettingsInstanceStore>>.Enumerator enumerator = default(List<Tuple<IEntity, ITypeSettingsInstanceStore>>.Enumerator);
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		Tuple<IEntity, ITypeSettingsInstanceStore> current = default(Tuple<IEntity, ITypeSettingsInstanceStore>);
		IEnumerable<IEntity> containedEntities = default(IEnumerable<IEntity>);
		List<object> revertEntities = default(List<object>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				Locator.GetServiceNotNull<IUnitOfWorkManager>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				try
				{
					while (true)
					{
						IL_01aa:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_0071;
						}
						goto IL_00bb;
						IL_0071:
						while (true)
						{
							switch (num3)
							{
							case 3:
								return;
							case 7:
								break;
							case 8:
								_003C_003Ec__DisplayClass4_.allItemEntities = new List<IEntity>();
								num3 = 12;
								continue;
							case 15:
								CghYEIboGeXXqaD1SqRG(current.Item2, KjjP62bobOZcm2htrZV5(current.Item1).ToString());
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								Save(current.Item2);
								num3 = 4;
								continue;
							default:
								containedEntities = current.Item1.GetContainedEntities();
								num3 = 9;
								continue;
							case 12:
								_003C_003Ec__DisplayClass4_.allItemEntities.Add(current.Item1);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
								{
									num3 = 0;
								}
								continue;
							case 9:
								if (containedEntities == null)
								{
									num3 = 6;
									continue;
								}
								goto case 10;
							case 2:
							case 4:
							case 11:
								goto IL_01aa;
							case 5:
							case 6:
								if (IsNewEntity(current.Item1))
								{
									num3 = 11;
									continue;
								}
								goto case 13;
							case 13:
								if (revertEntities.Any(_003C_003Ec__DisplayClass4_._003CSavePending_003Eb__0))
								{
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 15;
							case 14:
							{
								_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
								int num4 = 8;
								num3 = num4;
								continue;
							}
							case 10:
								_003C_003Ec__DisplayClass4_.allItemEntities.AddRange(containedEntities);
								num3 = 5;
								continue;
							}
							break;
						}
						goto IL_00bb;
						IL_00bb:
						current = enumerator.Current;
						num3 = 14;
						goto IL_0071;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			default:
			{
				List<Tuple<IEntity, ITypeSettingsInstanceStore>> pending = GetPending();
				revertEntities = NHUnitOfWorkManager.GetRevertEntities("");
				enumerator = pending.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 2;
				}
				break;
			}
			}
		}
	}

	private string TypeSettingsInstanceStoreCacheKey(IEntity entity)
	{
		//Discarded unreachable code: IL_0055, IL_0091, IL_00a0, IL_0165, IL_01cf
		int num = 9;
		int num2 = num;
		PropertyInfo propertyInfo = default(PropertyInfo);
		string text = default(string);
		Guid guid = default(Guid);
		ClassMetadata classMetadata = default(ClassMetadata);
		int hashCode = default(int);
		while (true)
		{
			Guid obj;
			switch (num2)
			{
			case 8:
				propertyInfo = (PropertyInfo)ADYrupboQx6cUw34e9B4(entity.GetType(), txRRY1bofdxkEbIF0G9V(-1979251663 ^ -1979225181));
				num2 = 7;
				continue;
			default:
				text = guid.ToString();
				num2 = 12;
				continue;
			case 9:
				classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entity.GetType());
				num2 = 8;
				continue;
			case 7:
				if (!rfbj7ZboCSreJHh1SiVy(propertyInfo, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 11;
			case 3:
			case 12:
				return string.Concat(txRRY1bofdxkEbIF0G9V(0x4A1640F ^ 0x4A3D43D), z0B6PVbooLAEdnspr3A6(classMetadata), txRRY1bofdxkEbIF0G9V(0x1C9495B4 ^ 0x1C94DA6A), text);
			case 1:
			case 4:
				obj = Guid.Empty;
				break;
			case 5:
				if (guid != Guid.Empty)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 10;
			case 11:
				if (yirrGTboZb3y58eUJvRj(bGG6Yqbovv8mwCZ18F3v(propertyInfo), HynNLEbo8yDPPeCvTP9W(typeof(Guid).TypeHandle)))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 1;
			case 10:
				hashCode = entity.GetHashCode();
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 2;
				}
				continue;
			case 6:
				text = hashCode.ToString();
				num2 = 3;
				continue;
			case 2:
				obj = (Guid)propertyInfo.GetValue(entity, null);
				break;
			}
			guid = obj;
			num2 = 5;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
			{
				num2 = 0;
			}
		}
	}

	private ITypeSettingsInstanceStore LoadOrNull(Guid objectTypeUid, object objectId)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				throw new ArgumentNullException((string)txRRY1bofdxkEbIF0G9V(-234299632 ^ -234197094));
			default:
				return ((ICriteria)s4f4VBboIAhvLOWioyIE(s4f4VBboIAhvLOWioyIE(CreateCriteria(), KVNMaXbouBqu8O94Y67i(txRRY1bofdxkEbIF0G9V(0x1637C429 ^ 0x163574B7), objectTypeUid)), KVNMaXbouBqu8O94Y67i(txRRY1bofdxkEbIF0G9V(-477139494 ^ -477242010), objectId.ToString()))).List<ITypeSettingsInstanceStore>().FirstOrDefault();
			case 1:
				if (objectId != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	private List<Tuple<IEntity, ITypeSettingsInstanceStore>> GetPending()
	{
		return ContextVars.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889628016), () => new List<Tuple<IEntity, ITypeSettingsInstanceStore>>());
	}

	private void AddToPending(IEntity entity, ITypeSettingsInstanceStore settingsStore)
	{
		int num = 2;
		int num2 = num;
		List<Tuple<IEntity, ITypeSettingsInstanceStore>> pending = default(List<Tuple<IEntity, ITypeSettingsInstanceStore>>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				ContextVars.Set((string)txRRY1bofdxkEbIF0G9V(0x3CE17B75 ^ 0x3CE3CBA5), pending);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				pending.Add(new Tuple<IEntity, ITypeSettingsInstanceStore>(entity, settingsStore));
				num2 = 3;
				break;
			case 2:
				pending = GetPending();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private bool IsNewEntity(IEntity entity)
	{
		int num = 2;
		int num2 = num;
		IEntityManager entityManagerOrNull = default(IEntityManager);
		while (true)
		{
			switch (num2)
			{
			default:
				return true;
			case 2:
				entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(entity.GetType());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (entityManagerOrNull != null)
				{
					return sYuNVMboVjeTOY1aSCUQ(entityManagerOrNull, entity);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public TypeSettingsInstanceStoreManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ffEcauboSiyw0tMlcD3a();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object rm2G5tboWAlyAFjMi445(object P_0)
	{
		return ((EntityManager<ITypeSettingsInstanceStore, long>)P_0).MemoryCacheService;
	}

	internal static Guid z0B6PVbooLAEdnspr3A6(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object KjjP62bobOZcm2htrZV5(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void qmasB5boh499Uex2UihR(object P_0, Guid value)
	{
		((ITypeSettingsInstanceStore)P_0).ObjectTypeUid = value;
	}

	internal static void CghYEIboGeXXqaD1SqRG(object P_0, object P_1)
	{
		((ITypeSettingsInstanceStore)P_0).ObjectId = (string)P_1;
	}

	internal static void fS3ecSboEIkZaTSxI5oY(object P_0, object P_1)
	{
		((ITypeSettingsInstanceStore)P_0).Settings = (TypeSettingsInstanceData)P_1;
	}

	internal static bool A6MVRCboFfhk8rTxgugT()
	{
		return IjYu36bWz9fvF7MNaQun == null;
	}

	internal static TypeSettingsInstanceStoreManager rxvvOmboBjWUt9Qw324j()
	{
		return IjYu36bWz9fvF7MNaQun;
	}

	internal static object txRRY1bofdxkEbIF0G9V(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ADYrupboQx6cUw34e9B4(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool rfbj7ZboCSreJHh1SiVy(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static Type bGG6Yqbovv8mwCZ18F3v(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static Type HynNLEbo8yDPPeCvTP9W(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool yirrGTboZb3y58eUJvRj(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object KVNMaXbouBqu8O94Y67i(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object s4f4VBboIAhvLOWioyIE(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static bool sYuNVMboVjeTOY1aSCUQ(object P_0, object P_1)
	{
		return ((IEntityManager)P_0).IsNew(P_1);
	}

	internal static void ffEcauboSiyw0tMlcD3a()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
