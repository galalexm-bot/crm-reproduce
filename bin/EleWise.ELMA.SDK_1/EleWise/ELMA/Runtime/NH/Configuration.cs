// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Configuration
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

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
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  /// <inheritdoc />
  internal class Configuration : NHibernate.Cfg.Configuration
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

    /// <summary>
    /// Создать <see cref="T:NHibernate.ISessionFactory" />, используюя свойства и маппинги текущей конфигурации
    /// </summary>
    /// <returns>Экземпляр <see cref="T:NHibernate.ISessionFactory" /></returns>
    public new ISessionFactory BuildSessionFactory()
    {
      int num1 = 8;
      ISessionFactory factory;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              Configuration.Replace<string, ISet<string>>((object) this.collectionRolesByEntityParticipant, (object) factory);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            case 2:
              Configuration.Replace<string, IEntityPersister>((object) this.entityPersisters, (object) factory);
              num2 = 3;
              continue;
            case 3:
              Configuration.Replace<string, ICollectionPersister>((object) this.collectionPersisters, (object) factory);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 3 : 4;
              continue;
            case 4:
              Configuration.Replace<string, IClassMetadata>((object) this.classMetadata, (object) factory);
              num2 = 6;
              continue;
            case 5:
              Configuration.Replace<System.Type, string>((object) this.implementorToEntityName, (object) factory);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
              continue;
            case 6:
              Configuration.Replace<string, ICollectionMetadata>((object) this.collectionMetadata, (object) factory);
              num2 = 5;
              continue;
            case 7:
              goto label_8;
            case 8:
              factory = (ISessionFactory) Configuration.fIOSaMWPdeTRWlKkeJhX((object) this);
              num2 = 7;
              continue;
            case 9:
              goto label_4;
            default:
              Configuration.Replace<string, string>((object) this.imports, (object) factory);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 9 : 7;
              continue;
          }
        }
label_8:
        Configuration.Replace<string, IIdentifierGenerator>((object) this.identifierGenerators, (object) factory);
        num1 = 2;
      }
label_4:
      return factory;
    }

    /// <summary>
    /// Обновить <paramref name="factory" />, используя <paramref name="mapper" />
    /// </summary>
    /// <param name="factory"><see cref="T:NHibernate.ISessionFactory" /> для обновления</param>
    /// <param name="mapper"><see cref="T:NHibernate.Mapping.ByCode.ModelMapper" /> с изменениями</param>
    /// <param name="regions">Список для возврата регионов кэша, для которых были изменения маппинга</param>
    public void UpdateSessionFactory(
      ISessionFactory factory,
      ModelMapper mapper,
      IList<string> regions)
    {
      SessionFactoryImpl factory1 = (SessionFactoryImpl) factory;
      Configuration.logger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210591897));
      HbmMapping hbmMapping = mapper.CompileMappingForAllExplicitlyAddedEntities();
      hbmMapping.defaultaccess = typeof (EntityPropertyAccessor).AssemblyQualifiedName;
      HashSet<string> entityNames = hbmMapping.Items.OfType<IEntityMapping>().Select<IEntityMapping, string>((Func<IEntityMapping, string>) (m =>
      {
        int num = 1;
        object obj;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              obj = Configuration.\u003C\u003Ec__DisplayClass1_0.p5TEsrQ7kgxILwYHJvK3((object) m);
              if (obj == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return (string) obj;
label_5:
        // ISSUE: reference to a compiler-generated method
        return Configuration.\u003C\u003Ec__DisplayClass1_0.dMHeDxQ7nNGuBAm3mF5r((object) m, (object) hbmMapping).FullName;
      })).ToHashSet<string>();
      lock (this)
      {
        Configuration.logger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642987646));
        Dictionary<string, IEnumerable<string>> dictionary1 = (Dictionary<string, IEnumerable<string>>) null;
        foreach (string str in entityNames)
        {
          if (this.classes.Remove(str))
          {
            if (dictionary1 == null)
            {
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              dictionary1 = this.CollectionMappings.Where<NHibernate.Mapping.Collection>((Func<NHibernate.Mapping.Collection, bool>) (c => entityNames.Contains((string) Configuration.\u003C\u003Ec__DisplayClass1_0.Y5QrReQ72hV1EcvRTsks(Configuration.\u003C\u003Ec__DisplayClass1_0.UdcABYQ7ObZIHFP6nEv0((object) c))))).GroupBy<NHibernate.Mapping.Collection, string>((Func<NHibernate.Mapping.Collection, string>) (c => (string) Configuration.\u003C\u003Ec.E1OKo6Q7yBmkoFIplHV2(Configuration.\u003C\u003Ec.pHpo2UQ7m2lMDhq0gZCo((object) c)))).ToDictionary<IGrouping<string, NHibernate.Mapping.Collection>, string, IEnumerable<string>>((Func<IGrouping<string, NHibernate.Mapping.Collection>, string>) (g => g.Key), (Func<IGrouping<string, NHibernate.Mapping.Collection>, IEnumerable<string>>) (g => g.Select<NHibernate.Mapping.Collection, string>((Func<NHibernate.Mapping.Collection, string>) (c => c.Role))));
            }
            IEnumerable<string> source;
            if (dictionary1.TryGetValue(str, out source))
              source.Count<string>(new Func<string, bool>(this.collections.Remove));
            this.Imports.Remove(str);
            this.Imports.Remove(StringHelper.Unqualify(str));
          }
        }
        Configuration.logger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372623559));
        this.AddMapping(hbmMapping);
        Configuration.logger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121029379));
        this.BuildMappings();
        Configuration.logger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293816780));
        this.Validate();
        Configuration.logger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669080231));
        SchemaMetadataUpdater.QuoteTableAndColumns((NHibernate.Cfg.Configuration) this);
        Configuration.logger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870758049));
        Settings settings = factory1.Settings;
        IDictionary<string, IIdentifierGenerator> dictionary2 = (IDictionary<string, IIdentifierGenerator>) this.identifierGenerators.GetValue((object) factory1);
        HashSet<PersistentClass> classMappings = entityNames.Select<string, PersistentClass>((Func<string, PersistentClass>) (en => this.classes[en])).ToHashSet<PersistentClass>();
        // ISSUE: reference to a compiler-generated method
        HashSet<NHibernate.Mapping.Table> identityTables = classMappings.Select<PersistentClass, NHibernate.Mapping.Table>((Func<PersistentClass, NHibernate.Mapping.Table>) (cm => (NHibernate.Mapping.Table) Configuration.\u003C\u003Ec.BXYNLRQ7MCIJdd1kR71l((object) cm))).ToHashSet<NHibernate.Mapping.Table>();
        foreach (PersistentClass persistentClass in classMappings)
        {
          if (!persistentClass.IsInherited)
          {
            IIdentifierGenerator identifierGenerator = persistentClass.Identifier.CreateIdentifierGenerator(settings.Dialect, settings.DefaultCatalogName, settings.DefaultSchemaName, (RootClass) persistentClass);
            dictionary2[persistentClass.EntityName] = identifierGenerator;
          }
        }
        List<IEntityPersister> newEntityPersisters = new List<IEntityPersister>();
        List<ICollectionPersister> second = new List<ICollectionPersister>();
        IDictionary<string, IEntityPersister> dictionary3 = (IDictionary<string, IEntityPersister>) this.entityPersisters.GetValue((object) factory1);
        IDictionary<string, IClassMetadata> dictionary4 = (IDictionary<string, IClassMetadata>) this.classMetadata.GetValue((object) factory1);
        IDictionary<string, ICollectionPersister> dictionary5 = (IDictionary<string, ICollectionPersister>) this.collectionPersisters.GetValue((object) factory1);
        IDictionary<string, ICollectionMetadata> dictionary6 = (IDictionary<string, ICollectionMetadata>) this.collectionMetadata.GetValue((object) factory1);
        IDictionary<System.Type, string> dictionary7 = (IDictionary<System.Type, string>) this.implementorToEntityName.GetValue((object) factory1);
        IDictionary<string, ISet<string>> dictionary8 = (IDictionary<string, ISet<string>>) this.collectionRolesByEntityParticipant.GetValue((object) factory1);
        IDictionary<string, NHibernate.Cache.ICache> levelCacheRegions = factory1.GetAllSecondLevelCacheRegions();
        Dictionary<string, ICacheConcurrencyStrategy> dictionary9 = new Dictionary<string, ICacheConcurrencyStrategy>();
        Configuration.logger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874140629));
        foreach (PersistentClass model in classMappings)
        {
          IMapping mapping = this.BuildMapping();
          model.PrepareTemporaryTables(mapping, settings.Dialect);
          string cacheRegionName = model.RootClazz.CacheRegionName;
          ICacheConcurrencyStrategy cache;
          if (!dictionary9.TryGetValue(cacheRegionName, out cache))
          {
            cache = CacheFactory.CreateCache(model.CacheConcurrencyStrategy, cacheRegionName, model.IsMutable, settings, this.Properties);
            if (cache != null)
            {
              regions.Add(cacheRegionName);
              dictionary9.Add(cacheRegionName, cache);
              levelCacheRegions[cache.RegionName] = cache.Cache;
            }
          }
          IEntityPersister classPersister = PersisterFactory.CreateClassPersister(model, cache, (ISessionFactoryImplementor) factory1, mapping);
          newEntityPersisters.Add(classPersister);
          dictionary3[model.EntityName] = classPersister;
          dictionary4[model.EntityName] = classPersister.ClassMetadata;
          if (model.HasPocoRepresentation)
            dictionary7[model.MappedClass] = model.EntityName;
        }
        Configuration.logger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470574312));
        foreach (NHibernate.Mapping.Collection model in this.CollectionMappings.Where<NHibernate.Mapping.Collection>((Func<NHibernate.Mapping.Collection, bool>) (c =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                if (!classMappings.Contains((PersistentClass) Configuration.\u003C\u003Ec__DisplayClass1_1.iossnAQ73m1fGbkZ0L9u((object) c)))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
                  continue;
                }
                goto label_5;
              default:
                goto label_4;
            }
          }
label_4:
          // ISSUE: reference to a compiler-generated method
          return identityTables.Contains((NHibernate.Mapping.Table) Configuration.\u003C\u003Ec__DisplayClass1_1.WlkJ6UQ7p2glcMgjet9u((object) c));
label_5:
          return true;
        })))
        {
          ICacheConcurrencyStrategy cache = CacheFactory.CreateCache(model.CacheConcurrencyStrategy, model.CacheRegionName, model.IsMutable, settings, this.Properties);
          if (cache != null)
            levelCacheRegions[cache.RegionName] = cache.Cache;
          ICollectionPersister collectionPersister = PersisterFactory.CreateCollectionPersister(model, cache, (ISessionFactoryImplementor) factory1);
          second.Add(collectionPersister);
          dictionary5[model.Role] = collectionPersister;
          dictionary6[model.Role] = collectionPersister.CollectionMetadata;
          IType indexType = collectionPersister.IndexType;
          if (indexType != null && indexType.IsAssociationType && !indexType.IsAnyType)
          {
            string associatedEntityName = ((IAssociationType) indexType).GetAssociatedEntityName((ISessionFactoryImplementor) factory1);
            ISet<string> stringSet;
            if (!dictionary8.TryGetValue(associatedEntityName, out stringSet))
            {
              stringSet = (ISet<string>) new HashSet<string>();
              dictionary8[associatedEntityName] = stringSet;
            }
            stringSet.Add(collectionPersister.Role);
          }
          IType elementType = collectionPersister.ElementType;
          if (elementType.IsAssociationType && !elementType.IsAnyType)
          {
            string associatedEntityName = ((IAssociationType) elementType).GetAssociatedEntityName((ISessionFactoryImplementor) factory1);
            ISet<string> stringSet;
            if (!dictionary8.TryGetValue(associatedEntityName, out stringSet))
            {
              stringSet = (ISet<string>) new HashSet<string>();
              dictionary8[associatedEntityName] = stringSet;
            }
            stringSet.Add(collectionPersister.Role);
          }
        }
        Configuration.logger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 235938873));
        IDictionary<string, string> dictionary10 = (IDictionary<string, string>) this.imports.GetValue((object) factory1);
        foreach (string str in entityNames)
        {
          string key = StringHelper.Unqualify(str);
          dictionary10[str] = this.Imports[str];
          dictionary10[key] = this.Imports[key];
        }
        Configuration.logger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408765638));
        // ISSUE: reference to a compiler-generated method
        newEntityPersisters.ForEach((Action<IEntityPersister>) (p => Configuration.\u003C\u003Ec.fV7BgXQ7JVxb3P6ZPuHj((object) p)));
        // ISSUE: reference to a compiler-generated method
        second.ForEach((Action<ICollectionPersister>) (p => Configuration.\u003C\u003Ec.pwGlmyQ799ZL88UqIpxI((object) p)));
        // ISSUE: reference to a compiler-generated method
        dictionary5.Values.Except<ICollectionPersister>((IEnumerable<ICollectionPersister>) second).OfType<IQueryableCollection>().Where<IQueryableCollection>((Func<IQueryableCollection, bool>) (p =>
        {
          int num = 1;
          IQueryableCollection p1;
          while (true)
          {
            switch (num)
            {
              case 1:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
                continue;
              case 2:
                goto label_2;
              default:
                p1 = p;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 2;
                continue;
            }
          }
label_2:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return newEntityPersisters.Any<IEntityPersister>((Func<IEntityPersister, bool>) (ep => Configuration.\u003C\u003Ec__DisplayClass1_2.bBoiskQ7HxFhD188X7pJ(Configuration.\u003C\u003Ec__DisplayClass1_2.kXTkuTQ74PvSk9nLcmbJ((object) ep), Configuration.\u003C\u003Ec__DisplayClass1_2.kXTkuTQ74PvSk9nLcmbJ(Configuration.\u003C\u003Ec__DisplayClass1_2.fedkaXQ76qA3O4fosCBh((object) p1)))));
        })).ForEach<IQueryableCollection>((Action<IQueryableCollection>) (p => Configuration.\u003C\u003Ec.pwGlmyQ799ZL88UqIpxI((object) p)));
      }
    }

    private static void Replace<TKey, TValue>(object field, object factory)
    {
      IDictionary<TKey, TValue> dictionary1 = (IDictionary<TKey, TValue>) ((FieldInfo) field).GetValue(factory);
      IEqualityComparer<TKey> comparer = dictionary1 is Dictionary<TKey, TValue> dictionary2 ? dictionary2.Comparer : (IEqualityComparer<TKey>) null;
      IDictionary<TKey, TValue> dictionary3 = comparer != null ? PublishCacheContext.CreateCache<TKey, TValue>((Func<IDictionary<TKey, TValue>, IDictionary<TKey, TValue>>) (c => (IDictionary<TKey, TValue>) new ConcurrentDictionary<TKey, TValue>((IEnumerable<KeyValuePair<TKey, TValue>>) c, comparer))) : PublishCacheContext.CreateCache<TKey, TValue>();
      foreach (KeyValuePair<TKey, TValue> keyValuePair in (IEnumerable<KeyValuePair<TKey, TValue>>) dictionary1)
        dictionary3.Add(keyValuePair);
      ((FieldInfo) field).SetValue(factory, (object) dictionary3);
    }

    private static System.Type ClassForNameChecked(object mapping, object hbmMapping)
    {
      int num1 = 1;
      string str;
      while (true)
      {
        switch (num1)
        {
          case 1:
            str = NHibernate.Util.TypeNameParser.Parse((string) Configuration.pyHfqJWPlxuQlKndiui5(mapping), ((HbmMapping) hbmMapping).@namespace, ((HbmMapping) hbmMapping).assembly).ToString();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_11;
          default:
            goto label_3;
        }
      }
label_3:
      System.Type type;
      try
      {
        type = Configuration.BhYGNyWPrLh5YIMbL20q((object) str);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw new MappingException((string) Configuration.hTx934WPg7VbkFVlvaAH(-1886646897 ^ -1886518363) + str + (string) Configuration.hTx934WPg7VbkFVlvaAH(1470998129 - 231418599 ^ 1239447002), ex);
        }
      }
label_11:
      return type;
    }

    private void Validate()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Configuration.aepdu7WP559ljyo2qcPW((object) this.validate, (object) this, (object) new object[0]);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public Configuration()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.identifierGenerators = TypeOf<SessionFactoryImpl>.Raw.GetField(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541598239), BindingFlags.Instance | BindingFlags.NonPublic);
      this.entityPersisters = TypeOf<SessionFactoryImpl>.Raw.GetField((string) Configuration.hTx934WPg7VbkFVlvaAH(--1867379187 ^ 1867513703), BindingFlags.Instance | BindingFlags.NonPublic);
      this.collectionPersisters = TypeOf<SessionFactoryImpl>.Raw.GetField((string) Configuration.hTx934WPg7VbkFVlvaAH(-1334993905 ^ -1334865225), BindingFlags.Instance | BindingFlags.NonPublic);
      this.classMetadata = TypeOf<SessionFactoryImpl>.Raw.GetField((string) Configuration.hTx934WPg7VbkFVlvaAH(1574260816 ^ 1574395572), BindingFlags.Instance | BindingFlags.NonPublic);
      this.collectionMetadata = TypeOf<SessionFactoryImpl>.Raw.GetField((string) Configuration.hTx934WPg7VbkFVlvaAH(1232639661 >> 3 ^ 153951703), BindingFlags.Instance | BindingFlags.NonPublic);
      this.implementorToEntityName = TypeOf<SessionFactoryImpl>.Raw.GetField((string) Configuration.hTx934WPg7VbkFVlvaAH(-1638402543 ^ -1638532805), BindingFlags.Instance | BindingFlags.NonPublic);
      this.collectionRolesByEntityParticipant = TypeOf<SessionFactoryImpl>.Raw.GetField((string) Configuration.hTx934WPg7VbkFVlvaAH(-420743386 ^ -420874118), BindingFlags.Instance | BindingFlags.NonPublic);
      this.imports = TypeOf<SessionFactoryImpl>.Raw.GetField((string) Configuration.hTx934WPg7VbkFVlvaAH(1461825605 - 1531863589 ^ -70172284), BindingFlags.Instance | BindingFlags.NonPublic);
      this.validate = TypeOf<NHibernate.Cfg.Configuration>.Raw.GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917128610), BindingFlags.Instance | BindingFlags.NonPublic);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static Configuration()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: type reference
            Configuration.logger = (ILogger) Configuration.L07hb0WPU1jwtENYYeTh(Configuration.e3YtnBWPL0fuBJZxHFv3(__typeref (SessionFactoryHolder)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
            continue;
          case 2:
            Configuration.log = (INHibernateLogger) Configuration.XQGGSVWPYe60vR9PHhSU(typeof (NHibernate.Cfg.Configuration));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
            continue;
          case 3:
            Configuration.SUrEs0WPj4oHVoBpH2SH();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static object fIOSaMWPdeTRWlKkeJhX([In] object obj0) => (object) ((NHibernate.Cfg.Configuration) obj0).BuildSessionFactory();

    internal static bool zf3Ph1WPJ7lTrG6UCVxU() => Configuration.fMLKZTWPMjMqSbVZReRj == null;

    internal static Configuration SFDuVJWP98JJd62WD9bN() => Configuration.fMLKZTWPMjMqSbVZReRj;

    internal static object pyHfqJWPlxuQlKndiui5([In] object obj0) => (object) ((IEntityMapping) obj0).Name;

    internal static System.Type BhYGNyWPrLh5YIMbL20q([In] object obj0) => ReflectHelper.ClassForName((string) obj0);

    internal static object hTx934WPg7VbkFVlvaAH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object aepdu7WP559ljyo2qcPW([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

    internal static void SUrEs0WPj4oHVoBpH2SH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object XQGGSVWPYe60vR9PHhSU([In] System.Type obj0) => (object) NHibernateLogger.For(obj0);

    internal static System.Type e3YtnBWPL0fuBJZxHFv3([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object L07hb0WPU1jwtENYYeTh(System.Type componentType) => (object) Logger.GetLogger(componentType);
  }
}
