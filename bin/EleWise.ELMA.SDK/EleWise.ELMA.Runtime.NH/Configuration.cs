using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Cache;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Engine;
using NHibernate.Id;
using NHibernate.Impl;
using NHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using NHibernate.Metadata;
using NHibernate.Persister;
using NHibernate.Persister.Collection;
using NHibernate.Persister.Entity;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Type;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

internal class Configuration : Configuration
{
	private static readonly INHibernateLogger log;

	private static readonly ILogger logger;

	private readonly FieldInfo identifierGenerators;

	private readonly FieldInfo entityPersisters;

	private readonly FieldInfo collectionPersisters;

	private readonly FieldInfo classMetadata;

	private readonly FieldInfo collectionMetadata;

	private readonly FieldInfo implementorToEntityName;

	private readonly FieldInfo collectionRolesByEntityParticipant;

	private readonly FieldInfo imports;

	private readonly MethodInfo validate;

	internal static Configuration fMLKZTWPMjMqSbVZReRj;

	public ISessionFactory BuildSessionFactory()
	{
		int num = 8;
		ISessionFactory val = default(ISessionFactory);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					val = (ISessionFactory)fIOSaMWPdeTRWlKkeJhX(this);
					num2 = 7;
					continue;
				case 9:
					return val;
				case 1:
					Replace<string, ISet<string>>(collectionRolesByEntityParticipant, val);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					Replace<Type, string>(implementorToEntityName, val);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					Replace<string, ICollectionMetadata>(collectionMetadata, val);
					num2 = 5;
					continue;
				case 7:
					break;
				default:
					Replace<string, string>(imports, val);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 7;
					}
					continue;
				case 2:
					Replace<string, IEntityPersister>(entityPersisters, val);
					num2 = 3;
					continue;
				case 3:
					Replace<string, ICollectionPersister>(collectionPersisters, val);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 4;
					}
					continue;
				case 4:
					Replace<string, IClassMetadata>(classMetadata, val);
					num2 = 6;
					continue;
				}
				break;
			}
			Replace<string, IIdentifierGenerator>(identifierGenerators, val);
			num = 2;
		}
	}

	public void UpdateSessionFactory(ISessionFactory factory, ModelMapper mapper, IList<string> regions)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		SessionFactoryImpl val = (SessionFactoryImpl)factory;
		logger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210591897));
		CS_0024_003C_003E8__locals0.hbmMapping = mapper.CompileMappingForAllExplicitlyAddedEntities();
		CS_0024_003C_003E8__locals0.hbmMapping.defaultaccess = typeof(EntityPropertyAccessor).AssemblyQualifiedName;
		CS_0024_003C_003E8__locals0.entityNames = CS_0024_003C_003E8__locals0.hbmMapping.Items.OfType<IEntityMapping>().Select(delegate(IEntityMapping m)
		{
			int num5 = 1;
			int num6 = num5;
			object obj;
			while (true)
			{
				switch (num6)
				{
				case 1:
					obj = _003C_003Ec__DisplayClass1_0.p5TEsrQ7kgxILwYHJvK3(m);
					if (obj == null)
					{
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num6 = 0;
						}
						continue;
					}
					break;
				default:
					obj = _003C_003Ec__DisplayClass1_0.dMHeDxQ7nNGuBAm3mF5r(m, CS_0024_003C_003E8__locals0.hbmMapping).FullName;
					break;
				}
				break;
			}
			return (string)obj;
		}).ToHashSet();
		lock (this)
		{
			_003C_003Ec__DisplayClass1_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass1_1();
			logger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EE007E));
			Dictionary<string, IEnumerable<string>> dictionary = null;
			foreach (string entityName in CS_0024_003C_003E8__locals0.entityNames)
			{
				if (!base.classes.Remove(entityName))
				{
					continue;
				}
				if (dictionary == null)
				{
					dictionary = (from c in ((Configuration)this).get_CollectionMappings()
						where CS_0024_003C_003E8__locals0.entityNames.Contains((string)_003C_003Ec__DisplayClass1_0.Y5QrReQ72hV1EcvRTsks(_003C_003Ec__DisplayClass1_0.UdcABYQ7ObZIHFP6nEv0(c)))
						group c by (string)_003C_003Ec.E1OKo6Q7yBmkoFIplHV2(_003C_003Ec.pHpo2UQ7m2lMDhq0gZCo(c))).ToDictionary((IGrouping<string, Collection> g) => g.Key, (IGrouping<string, Collection> g) => g.Select((Collection c) => c.get_Role()));
				}
				if (dictionary.TryGetValue(entityName, out var value))
				{
					value.Count(base.collections.Remove);
				}
				((Configuration)this).get_Imports().Remove(entityName);
				((Configuration)this).get_Imports().Remove(StringHelper.Unqualify(entityName));
			}
			logger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x1635C8C7));
			((Configuration)this).AddMapping(CS_0024_003C_003E8__locals0.hbmMapping);
			logger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6C5703));
			((Configuration)this).BuildMappings();
			logger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1E13CC));
			Validate();
			logger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637C24A7));
			SchemaMetadataUpdater.QuoteTableAndColumns((Configuration)(object)this);
			logger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870758049));
			Settings settings = val.get_Settings();
			IDictionary<string, IIdentifierGenerator> dictionary2 = (IDictionary<string, IIdentifierGenerator>)identifierGenerators.GetValue(val);
			CS_0024_003C_003E8__locals1.classMappings = CS_0024_003C_003E8__locals0.entityNames.Select((string en) => ((Configuration)CS_0024_003C_003E8__locals0._003C_003E4__this).classes[en]).ToHashSet();
			CS_0024_003C_003E8__locals1.identityTables = CS_0024_003C_003E8__locals1.classMappings.Select((PersistentClass cm) => (Table)_003C_003Ec.BXYNLRQ7MCIJdd1kR71l(cm)).ToHashSet();
			foreach (PersistentClass classMapping in CS_0024_003C_003E8__locals1.classMappings)
			{
				if (!classMapping.get_IsInherited())
				{
					IIdentifierGenerator value2 = classMapping.get_Identifier().CreateIdentifierGenerator(settings.get_Dialect(), settings.get_DefaultCatalogName(), settings.get_DefaultSchemaName(), (RootClass)classMapping);
					dictionary2[classMapping.get_EntityName()] = value2;
				}
			}
			CS_0024_003C_003E8__locals1.newEntityPersisters = new List<IEntityPersister>();
			List<ICollectionPersister> list = new List<ICollectionPersister>();
			IDictionary<string, IEntityPersister> dictionary3 = (IDictionary<string, IEntityPersister>)entityPersisters.GetValue(val);
			IDictionary<string, IClassMetadata> dictionary4 = (IDictionary<string, IClassMetadata>)classMetadata.GetValue(val);
			IDictionary<string, ICollectionPersister> dictionary5 = (IDictionary<string, ICollectionPersister>)collectionPersisters.GetValue(val);
			IDictionary<string, ICollectionMetadata> dictionary6 = (IDictionary<string, ICollectionMetadata>)collectionMetadata.GetValue(val);
			IDictionary<Type, string> dictionary7 = (IDictionary<Type, string>)implementorToEntityName.GetValue(val);
			IDictionary<string, ISet<string>> dictionary8 = (IDictionary<string, ISet<string>>)collectionRolesByEntityParticipant.GetValue(val);
			IDictionary<string, ICache> allSecondLevelCacheRegions = val.GetAllSecondLevelCacheRegions();
			Dictionary<string, ICacheConcurrencyStrategy> dictionary9 = new Dictionary<string, ICacheConcurrencyStrategy>();
			logger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341A53D5));
			foreach (PersistentClass classMapping2 in CS_0024_003C_003E8__locals1.classMappings)
			{
				IMapping val2 = ((Configuration)this).BuildMapping();
				classMapping2.PrepareTemporaryTables(val2, settings.get_Dialect());
				string cacheRegionName = classMapping2.get_RootClazz().get_CacheRegionName();
				if (!dictionary9.TryGetValue(cacheRegionName, out var value3))
				{
					value3 = CacheFactory.CreateCache(classMapping2.get_CacheConcurrencyStrategy(), cacheRegionName, classMapping2.get_IsMutable(), settings, ((Configuration)this).get_Properties());
					if (value3 != null)
					{
						regions.Add(cacheRegionName);
						dictionary9.Add(cacheRegionName, value3);
						allSecondLevelCacheRegions[value3.get_RegionName()] = value3.get_Cache();
					}
				}
				IEntityPersister val3 = PersisterFactory.CreateClassPersister(classMapping2, value3, (ISessionFactoryImplementor)(object)val, val2);
				CS_0024_003C_003E8__locals1.newEntityPersisters.Add(val3);
				dictionary3[classMapping2.get_EntityName()] = val3;
				dictionary4[classMapping2.get_EntityName()] = val3.get_ClassMetadata();
				if (classMapping2.get_HasPocoRepresentation())
				{
					dictionary7[classMapping2.get_MappedClass()] = classMapping2.get_EntityName();
				}
			}
			logger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A72EE8));
			foreach (Collection item in ((Configuration)this).get_CollectionMappings().Where(delegate(Collection c)
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 1:
						if (CS_0024_003C_003E8__locals1.classMappings.Contains((PersistentClass)_003C_003Ec__DisplayClass1_1.iossnAQ73m1fGbkZ0L9u(c)))
						{
							return true;
						}
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num4 = 0;
						}
						break;
					default:
						return CS_0024_003C_003E8__locals1.identityTables.Contains((Table)_003C_003Ec__DisplayClass1_1.WlkJ6UQ7p2glcMgjet9u(c));
					}
				}
			}))
			{
				ICacheConcurrencyStrategy val4 = CacheFactory.CreateCache(item.get_CacheConcurrencyStrategy(), item.get_CacheRegionName(), item.get_IsMutable(), settings, ((Configuration)this).get_Properties());
				if (val4 != null)
				{
					allSecondLevelCacheRegions[val4.get_RegionName()] = val4.get_Cache();
				}
				ICollectionPersister val5 = PersisterFactory.CreateCollectionPersister(item, val4, (ISessionFactoryImplementor)(object)val);
				list.Add(val5);
				dictionary5[item.get_Role()] = val5;
				dictionary6[item.get_Role()] = val5.get_CollectionMetadata();
				IType indexType = val5.get_IndexType();
				if (indexType != null && indexType.get_IsAssociationType() && !indexType.get_IsAnyType())
				{
					string associatedEntityName = ((IAssociationType)indexType).GetAssociatedEntityName((ISessionFactoryImplementor)(object)val);
					if (!dictionary8.TryGetValue(associatedEntityName, out var value4))
					{
						value4 = (dictionary8[associatedEntityName] = new HashSet<string>());
					}
					value4.Add(val5.get_Role());
				}
				IType elementType = val5.get_ElementType();
				if (elementType.get_IsAssociationType() && !elementType.get_IsAnyType())
				{
					string associatedEntityName2 = ((IAssociationType)elementType).GetAssociatedEntityName((ISessionFactoryImplementor)(object)val);
					if (!dictionary8.TryGetValue(associatedEntityName2, out var value5))
					{
						value5 = (dictionary8[associatedEntityName2] = new HashSet<string>());
					}
					value5.Add(val5.get_Role());
				}
			}
			logger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE102439));
			IDictionary<string, string> dictionary10 = (IDictionary<string, string>)imports.GetValue(val);
			foreach (string entityName2 in CS_0024_003C_003E8__locals0.entityNames)
			{
				string key = StringHelper.Unqualify(entityName2);
				dictionary10[entityName2] = ((Configuration)this).get_Imports()[entityName2];
				dictionary10[key] = ((Configuration)this).get_Imports()[key];
			}
			logger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53F80EC6));
			CS_0024_003C_003E8__locals1.newEntityPersisters.ForEach(delegate(IEntityPersister p)
			{
				_003C_003Ec.fV7BgXQ7JVxb3P6ZPuHj(p);
			});
			list.ForEach(delegate(ICollectionPersister p)
			{
				_003C_003Ec.pwGlmyQ799ZL88UqIpxI(p);
			});
			dictionary5.Values.Except(list).OfType<IQueryableCollection>().Where(delegate(IQueryableCollection p)
			{
				int num = 1;
				int num2 = num;
				_003C_003Ec__DisplayClass1_2 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_2);
				while (true)
				{
					switch (num2)
					{
					case 2:
						return CS_0024_003C_003E8__locals1.newEntityPersisters.Any(_003C_003Ec__DisplayClass1_._003CUpdateSessionFactory_003Eb__13);
					default:
						_003C_003Ec__DisplayClass1_.p = p;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 2;
						}
						break;
					case 1:
						_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_2();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			})
				.ForEach(delegate(IQueryableCollection p)
				{
					_003C_003Ec.pwGlmyQ799ZL88UqIpxI(p);
				});
		}
	}

	private static void Replace<TKey, TValue>(object field, object factory)
	{
		_003C_003Ec__DisplayClass13_0<TKey, TValue> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0<TKey, TValue>();
		IDictionary<TKey, TValue> dictionary = (IDictionary<TKey, TValue>)((FieldInfo)field).GetValue(factory);
		CS_0024_003C_003E8__locals0.comparer = ((dictionary is Dictionary<TKey, TValue> dictionary2) ? dictionary2.Comparer : null);
		IDictionary<TKey, TValue> dictionary3 = ((CS_0024_003C_003E8__locals0.comparer != null) ? PublishCacheContext.CreateCache((IDictionary<TKey, TValue> c) => new ConcurrentDictionary<TKey, TValue>(c, CS_0024_003C_003E8__locals0.comparer)) : PublishCacheContext.CreateCache<TKey, TValue>());
		foreach (KeyValuePair<TKey, TValue> item in dictionary)
		{
			dictionary3.Add(item);
		}
		((FieldInfo)field).SetValue(factory, (object)dictionary3);
	}

	private static Type ClassForNameChecked(object mapping, object hbmMapping)
	{
		//Discarded unreachable code: IL_0084, IL_00b7, IL_00fe, IL_010d
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		string text = default(string);
		Type result = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = ((object)TypeNameParser.Parse((string)pyHfqJWPlxuQlKndiui5(mapping), ((HbmMapping)hbmMapping).@namespace, ((HbmMapping)hbmMapping).assembly)).ToString();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				result = BhYGNyWPrLh5YIMbL20q(text);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			catch (Exception ex)
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				default:
					throw new MappingException((string)hTx934WPg7VbkFVlvaAH(-1886646897 ^ -1886518363) + text + (string)hTx934WPg7VbkFVlvaAH(0x49E27B8A ^ 0x49E075DA), ex);
				}
			}
		}
	}

	private void Validate()
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
				aepdu7WP559ljyo2qcPW(validate, this, new object[0]);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public Configuration()
	{
		//Discarded unreachable code: IL_0197, IL_019c
		SingletonReader.JJCZtPuTvSt();
		identifierGenerators = TypeOf<SessionFactoryImpl>.Raw.GetField(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541598239), BindingFlags.Instance | BindingFlags.NonPublic);
		entityPersisters = TypeOf<SessionFactoryImpl>.Raw.GetField((string)hTx934WPg7VbkFVlvaAH(--1867379187 ^ 0x6F4FFF67), BindingFlags.Instance | BindingFlags.NonPublic);
		collectionPersisters = TypeOf<SessionFactoryImpl>.Raw.GetField((string)hTx934WPg7VbkFVlvaAH(-1334993905 ^ -1334865225), BindingFlags.Instance | BindingFlags.NonPublic);
		classMetadata = TypeOf<SessionFactoryImpl>.Raw.GetField((string)hTx934WPg7VbkFVlvaAH(0x5DD55050 ^ 0x5DD75EB4), BindingFlags.Instance | BindingFlags.NonPublic);
		collectionMetadata = TypeOf<SessionFactoryImpl>.Raw.GetField((string)hTx934WPg7VbkFVlvaAH(0x92F12D5 ^ 0x92D1DD7), BindingFlags.Instance | BindingFlags.NonPublic);
		implementorToEntityName = TypeOf<SessionFactoryImpl>.Raw.GetField((string)hTx934WPg7VbkFVlvaAH(-1638402543 ^ -1638532805), BindingFlags.Instance | BindingFlags.NonPublic);
		collectionRolesByEntityParticipant = TypeOf<SessionFactoryImpl>.Raw.GetField((string)hTx934WPg7VbkFVlvaAH(-420743386 ^ -420874118), BindingFlags.Instance | BindingFlags.NonPublic);
		imports = TypeOf<SessionFactoryImpl>.Raw.GetField((string)hTx934WPg7VbkFVlvaAH(-70037984 ^ -70172284), BindingFlags.Instance | BindingFlags.NonPublic);
		validate = TypeOf<Configuration>.Raw.GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72450FA2), BindingFlags.Instance | BindingFlags.NonPublic);
		((Configuration)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static Configuration()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				SUrEs0WPj4oHVoBpH2SH();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				logger = (ILogger)L07hb0WPU1jwtENYYeTh(e3YtnBWPL0fuBJZxHFv3(typeof(SessionFactoryHolder).TypeHandle));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				log = (INHibernateLogger)XQGGSVWPYe60vR9PHhSU(typeof(Configuration));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object fIOSaMWPdeTRWlKkeJhX(object P_0)
	{
		return ((Configuration)P_0).BuildSessionFactory();
	}

	internal static bool zf3Ph1WPJ7lTrG6UCVxU()
	{
		return fMLKZTWPMjMqSbVZReRj == null;
	}

	internal static Configuration SFDuVJWP98JJd62WD9bN()
	{
		return fMLKZTWPMjMqSbVZReRj;
	}

	internal static object pyHfqJWPlxuQlKndiui5(object P_0)
	{
		return ((IEntityMapping)P_0).get_Name();
	}

	internal static Type BhYGNyWPrLh5YIMbL20q(object P_0)
	{
		return ReflectHelper.ClassForName((string)P_0);
	}

	internal static object hTx934WPg7VbkFVlvaAH(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object aepdu7WP559ljyo2qcPW(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static void SUrEs0WPj4oHVoBpH2SH()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object XQGGSVWPYe60vR9PHhSU(Type P_0)
	{
		return NHibernateLogger.For(P_0);
	}

	internal static Type e3YtnBWPL0fuBJZxHFv3(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object L07hb0WPU1jwtENYYeTh(Type componentType)
	{
		return Logger.GetLogger(componentType);
	}
}
