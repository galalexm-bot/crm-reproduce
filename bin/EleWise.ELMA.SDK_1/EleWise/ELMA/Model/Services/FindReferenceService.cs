// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.FindReferenceService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Metadata;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>Служба поиска зависимостей</summary>
  [Service(Type = ComponentType.Server)]
  public class FindReferenceService
  {
    private static readonly string BLOBStoreKey;
    private readonly IServerPlacementPublishService serverPlacementPublishService;
    private readonly ILazy<ITransformationProvider> transformationProvider;
    private readonly ILazy<IMetadataRuntimeService> metadataService;
    private readonly ILazy<ISessionProvider> sessionProvider;
    private readonly ConcurrentDictionary<string, ConcurrentDictionary<Guid, FindReferenceService.ReferenceMap>> references;
    private readonly ConcurrentDictionary<string, ConcurrentDictionary<Guid, FindReferenceService.ReferenceMap>> allReferences;
    private readonly IDictionary<Guid, EntityMetadata> cachedLoadedMetadata;
    internal static FindReferenceService nBDVsnb8eOYJew1IYYky;

    /// <summary>ctor</summary>
    /// <param name="serverPlacementPublishService">Сервис публикации действия на всех серверах кластера ELMA</param>
    /// <param name="transformationProvider">Провайдер преобразования БД</param>
    /// <param name="metadataService">Служб управления метаданными в режиме Runtime</param>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    public FindReferenceService(
      IServerPlacementPublishService serverPlacementPublishService,
      ILazy<ITransformationProvider> transformationProvider,
      ILazy<IMetadataRuntimeService> metadataService,
      ILazy<ISessionProvider> sessionProvider)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.references = new ConcurrentDictionary<string, ConcurrentDictionary<Guid, FindReferenceService.ReferenceMap>>();
      this.allReferences = new ConcurrentDictionary<string, ConcurrentDictionary<Guid, FindReferenceService.ReferenceMap>>();
      this.cachedLoadedMetadata = (IDictionary<Guid, EntityMetadata>) new ConcurrentDictionary<Guid, EntityMetadata>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.serverPlacementPublishService = serverPlacementPublishService;
      this.transformationProvider = transformationProvider;
      this.metadataService = metadataService;
      this.sessionProvider = sessionProvider;
    }

    /// <summary>Добавить информацию о ссылке</summary>
    /// <param name="map">Информация о ссылке</param>
    public void AddReference(FindReferenceService.ReferenceMap map)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (this.Add(this.references, map))
            {
              num = 3;
              continue;
            }
            goto label_7;
          case 2:
            this.Add(this.allReferences, map);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
            continue;
          case 3:
            this.Send((IEnumerable<FindReferenceService.ReferenceMap>) new FindReferenceService.ReferenceMap[1]
            {
              map
            }, (IEnumerable<FindReferenceService.ReferenceMap>) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:
      return;
label_7:;
    }

    /// <summary>Добавить информацию об обратной ссылке</summary>
    /// <param name="map">Информация об обратной ссылке</param>
    public void AddToAllReference(FindReferenceService.ReferenceMap map)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            this.Send((IEnumerable<FindReferenceService.ReferenceMap>) null, (IEnumerable<FindReferenceService.ReferenceMap>) new FindReferenceService.ReferenceMap[1]
            {
              map
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (!this.Add(this.allReferences, map))
            {
              num = 2;
              continue;
            }
            goto case 1;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_2:
      return;
label_7:;
    }

    /// <summary>Добавить информацию о ссылках</summary>
    /// <param name="references">Информация о ссылках</param>
    /// <param name="allReferences">Информация об обратных ссылках</param>
    public void AddReferences(
      IEnumerable<FindReferenceService.ReferenceMap> references,
      IEnumerable<FindReferenceService.ReferenceMap> allReferences)
    {
      references = (IEnumerable<FindReferenceService.ReferenceMap>) references.Where<FindReferenceService.ReferenceMap>((Func<FindReferenceService.ReferenceMap, bool>) (m =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.Add(this.allReferences, m);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return this.Add(this.references, m);
      })).ToArray<FindReferenceService.ReferenceMap>();
      allReferences = (IEnumerable<FindReferenceService.ReferenceMap>) allReferences.Where<FindReferenceService.ReferenceMap>((Func<FindReferenceService.ReferenceMap, bool>) (m => this.Add(this.allReferences, m))).ToArray<FindReferenceService.ReferenceMap>();
      if (!references.Any<FindReferenceService.ReferenceMap>() && !allReferences.Any<FindReferenceService.ReferenceMap>())
        return;
      this.Send(references, allReferences);
    }

    /// <summary>Добавить информация о ссылках</summary>
    /// <param name="metadatas">Метаданные</param>
    public void AddMetadata(IEnumerable<EntityMetadata> metadatas)
    {
      List<FindReferenceService.ReferenceMap> references = new List<FindReferenceService.ReferenceMap>();
      List<FindReferenceService.ReferenceMap> allReferences = new List<FindReferenceService.ReferenceMap>();
      // ISSUE: reference to a compiler-generated method
      Dictionary<Guid, ClassMetadata> dictionary = metadatas.Where<EntityMetadata>((Func<EntityMetadata, bool>) (m =>
      {
        int num = 4;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (FindReferenceService.\u003C\u003Ec.hqd9MbCeSoZfwCw6RidD((object) m) == EntityMetadataType.Entity)
              {
                num = 2;
                continue;
              }
              goto label_6;
            case 2:
              goto label_7;
            case 3:
              goto label_8;
            case 4:
              if (m == null)
              {
                num = 3;
                continue;
              }
              goto case 1;
            default:
              goto label_6;
          }
        }
label_6:
        // ISSUE: reference to a compiler-generated method
        return FindReferenceService.\u003C\u003Ec.hqd9MbCeSoZfwCw6RidD((object) m) == EntityMetadataType.InterfaceImplementation;
label_7:
        return true;
label_8:
        return false;
      })).ToDictionary<EntityMetadata, Guid, ClassMetadata>((Func<EntityMetadata, Guid>) (m => FindReferenceService.\u003C\u003Ec.xTF0rECeibTO6kOQrmcX((object) m)), (Func<EntityMetadata, ClassMetadata>) (m => (ClassMetadata) m));
      foreach (ClassMetadata classMetadata in dictionary.Values)
      {
        foreach (PropertyMetadata propertyMetadata in classMetadata.Properties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                if (FindReferenceService.\u003C\u003Ec.GhQXxrCeRh4R6LYawUUG((object) p) is EntitySettings)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
                  continue;
                }
                goto label_5;
              default:
                goto label_4;
            }
          }
label_4:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return FindReferenceService.\u003C\u003Ec.TjxxAUCeKgrxlfmyjZRV(FindReferenceService.\u003C\u003Ec.wivj3QCeqvRvdd4nAqvX((object) p), Guid.Empty);
label_5:
          return false;
        })))
        {
          PropertyMetadata prop = propertyMetadata;
          ConcurrentDictionary<Guid, FindReferenceService.ReferenceMap> concurrentDictionary;
          switch (((EntitySettings) prop.Settings).RelationType)
          {
            case RelationType.OneToOne:
              ClassMetadata metadata1;
              if (!dictionary.TryGetValue(prop.SubTypeUid, out metadata1))
                metadata1 = (ClassMetadata) MetadataServiceContext.Service.GetMetadata(prop.SubTypeUid);
              if (metadata1 != null)
              {
                if (metadata1.Properties.Any<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
                {
                  int num = 1;
                  while (true)
                  {
                    switch (num)
                    {
                      case 1:
                        if (p.Settings is EntitySettings settings2)
                        {
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_7;
                      case 2:
                        goto label_6;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        if (FindReferenceService.\u003C\u003Ec__DisplayClass15_0.anKd3bCeQBWDaGfvSKJk((object) settings2) == RelationType.OneToMany)
                        {
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 0;
                          continue;
                        }
                        goto label_7;
                    }
                  }
label_6:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  return FindReferenceService.\u003C\u003Ec__DisplayClass15_0.gN0atuCe8gFEdRa6111S(FindReferenceService.\u003C\u003Ec__DisplayClass15_0.ohhWQ0CeCBdbJhGoHCKw((object) settings2), FindReferenceService.\u003C\u003Ec__DisplayClass15_0.EFvBU1Cevnbhd7RPCV5j((object) prop));
label_7:
                  return false;
                })))
                {
                  if (!this.allReferences.TryGetValue(classMetadata.FullTypeName, out concurrentDictionary) || !concurrentDictionary.ContainsKey(prop.Uid))
                  {
                    allReferences.Add(new FindReferenceService.ReferenceMap()
                    {
                      ElementEntityUid = classMetadata.Uid,
                      ElementEntityName = classMetadata.FullTypeName,
                      ElementPropertyName = prop.Name,
                      ElementPropertyUid = prop.Uid,
                      ReferenceEntityName = metadata1.FullTypeName,
                      ReferenceType = FindReferenceService.ReferenceEnum.Simple
                    });
                    continue;
                  }
                  continue;
                }
                if (!this.references.TryGetValue(classMetadata.FullTypeName, out concurrentDictionary) || !concurrentDictionary.ContainsKey(prop.Uid))
                {
                  references.Add(new FindReferenceService.ReferenceMap()
                  {
                    ElementEntityUid = classMetadata.Uid,
                    ElementEntityName = classMetadata.FullTypeName,
                    ElementPropertyName = prop.Name,
                    ElementPropertyUid = prop.Uid,
                    ReferenceEntityName = metadata1.FullTypeName,
                    ReferenceType = FindReferenceService.ReferenceEnum.Simple
                  });
                  continue;
                }
                continue;
              }
              continue;
            case RelationType.ManyToMany:
              ClassMetadata metadata2;
              if (!dictionary.TryGetValue(prop.SubTypeUid, out metadata2))
                metadata2 = (ClassMetadata) MetadataServiceContext.Service.GetMetadata(prop.SubTypeUid);
              if (metadata2 is EntityMetadata && (!this.references.TryGetValue(classMetadata.FullTypeName, out concurrentDictionary) || !concurrentDictionary.ContainsKey(prop.Uid)))
              {
                references.Add(new FindReferenceService.ReferenceMap()
                {
                  ElementEntityUid = classMetadata.Uid,
                  ElementEntityName = classMetadata.FullTypeName,
                  ElementPropertyName = prop.Name,
                  ElementPropertyUid = prop.Uid,
                  ReferenceEntityName = metadata2.FullTypeName,
                  ReferenceType = FindReferenceService.ReferenceEnum.ManyToMany
                });
                continue;
              }
              continue;
            default:
              continue;
          }
        }
      }
      this.AddReferences((IEnumerable<FindReferenceService.ReferenceMap>) references, (IEnumerable<FindReferenceService.ReferenceMap>) allReferences);
    }

    public ICollection<FindReferenceService.Reference> GetReferences(string entityName, bool all = false)
    {
      ConcurrentDictionary<Guid, FindReferenceService.ReferenceMap> concurrentDictionary;
      if (!(all ? this.allReferences : this.references).TryGetValue(entityName, out concurrentDictionary))
        return (ICollection<FindReferenceService.Reference>) Array.Empty<FindReferenceService.Reference>();
      Dictionary<Guid, EntityMetadata> loadedMetadata = new Dictionary<Guid, EntityMetadata>();
      HashSet<Guid> source = new HashSet<Guid>();
      foreach (Guid guid in concurrentDictionary.Values.Select<FindReferenceService.ReferenceMap, Guid>((Func<FindReferenceService.ReferenceMap, Guid>) (m => m.ElementEntityUid)).Distinct<Guid>())
      {
        EntityMetadata entityMetadata = (EntityMetadata) MetadataLoader.LoadMetadataOrNull(guid, false, false);
        if (entityMetadata != null)
        {
          loadedMetadata[guid] = entityMetadata;
          this.cachedLoadedMetadata.Remove(guid);
        }
        else if (this.cachedLoadedMetadata.TryGetValue(guid, out entityMetadata))
          loadedMetadata[guid] = entityMetadata;
        else
          source.Add(guid);
      }
      if (source.Count > 0)
      {
        foreach (EntityMetadata entityMetadata1 in (IEnumerable<EntityMetadata>) this.sessionProvider.Value.GetSession(string.Empty).CreateCriteria<EntityMetadata>().Add((ICriterion) Restrictions.In(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138932118), (ICollection) source.ToArray<Guid>())).List<EntityMetadata>())
        {
          EntityMetadata entityMetadata2 = ClassSerializationHelper.CloneObjectByXml<EntityMetadata>(entityMetadata1);
          entityMetadata2.Properties.AddRange((IEnumerable<PropertyMetadata>) entityMetadata2.EntityProperties);
          entityMetadata2.EntityProperties.Clear();
          entityMetadata2.TableParts.AddRange((IEnumerable<TablePartMetadata>) entityMetadata2.EntityTableParts);
          entityMetadata2.EntityTableParts.Clear();
          loadedMetadata[entityMetadata2.Uid] = entityMetadata2;
          this.cachedLoadedMetadata[entityMetadata2.Uid] = entityMetadata2;
        }
      }
      return (ICollection<FindReferenceService.Reference>) concurrentDictionary.Values.Select<FindReferenceService.ReferenceMap, FindReferenceService.Reference>((Func<FindReferenceService.ReferenceMap, FindReferenceService.Reference>) (m =>
      {
        int num1 = 2;
        EntityMetadata entityMetadata;
        PropertyMetadata propertyMetadata;
        FindReferenceService.ReferenceMap m1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              m1 = m;
              num1 = 4;
              continue;
            case 2:
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_2;
            case 4:
              // ISSUE: reference to a compiler-generated method
              entityMetadata = loadedMetadata[FindReferenceService.\u003C\u003Ec__DisplayClass16_0.zCMCXTCeOZwITRBFaWUa((object) m1)];
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
              continue;
            default:
              propertyMetadata = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
              {
                int num2 = 1;
                Guid guid;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      guid = FindReferenceService.\u003C\u003Ec__DisplayClass16_1.HwFoeICeDm8iYwPLa2qw((object) p);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_2;
                  }
                }
label_2:
                return guid.Equals(m1.ElementPropertyUid);
              }));
              num1 = 3;
              continue;
          }
        }
label_2:
        FindReferenceService.Reference references = new FindReferenceService.Reference();
        // ISSUE: reference to a compiler-generated method
        FindReferenceService.\u003C\u003Ec__DisplayClass16_0.uviOHUCe2sfDkBi20wnN((object) references, (object) entityMetadata);
        // ISSUE: reference to a compiler-generated method
        FindReferenceService.\u003C\u003Ec__DisplayClass16_0.uiaX5tCeejRcdMZFSYr9((object) references, (object) propertyMetadata);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        FindReferenceService.\u003C\u003Ec__DisplayClass16_0.wlc0nBCe1xcHBWMypDE2((object) references, FindReferenceService.\u003C\u003Ec__DisplayClass16_0.ltaqGqCePrKcPeBwLkck((object) m1));
        return references;
      })).ToArray<FindReferenceService.Reference>();
    }

    public void DeleteEntityReferences(IEntity entity)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.DeleteEntityReferences(entity, (string) null, (ISession) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void DeleteEntityReferences(IEntity entity, string entityName, ISession session)
    {
      int num1 = 2;
      IEnumerator<FindReferenceService.Reference> enumerator;
      while (true)
      {
        int num2 = num1;
        List<string> source;
        Type type1;
        while (true)
        {
          IClassMetadata classMetadata;
          Type type2;
          switch (num2)
          {
            case 1:
              if (session == null)
              {
                num2 = 5;
                continue;
              }
              goto case 18;
            case 2:
              if (entity != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
                continue;
              }
              goto label_72;
            case 3:
              if (FindReferenceService.i0ga54b8N9CS22JYWgBA((object) entityName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 7 : 17;
                continue;
              }
              goto case 11;
            case 4:
            case 7:
            case 9:
              if (!FindReferenceService.AmESMwb8tv8VKoJBE9lO(type1, (Type) null))
              {
                num2 = 8;
                continue;
              }
              goto label_80;
            case 5:
              session = this.sessionProvider.Value.GetSession("");
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 16 : 18;
              continue;
            case 6:
              goto label_17;
            case 8:
              goto label_9;
            case 10:
              goto label_77;
            case 11:
              classMetadata = (IClassMetadata) FindReferenceService.iiA9Obb8aUGU0yRySGFX(FindReferenceService.AER7KAb8pKDOMmHF49lO((object) session), (object) entityName);
              num2 = 12;
              continue;
            case 12:
              if (classMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 15 : 4;
                continue;
              }
              goto default;
            case 13:
              goto label_12;
            case 14:
              goto label_80;
            case 15:
              type2 = FindReferenceService.SMh3Erb8DdY8YmR3Nw94((object) classMetadata);
              break;
            case 16:
              type1 = type1.BaseType;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 4 : 2;
              continue;
            case 17:
              type1 = FindReferenceService.wI9QDwb83ZNJKOkMPP0G((object) entity);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 7;
              continue;
            case 18:
              source = new List<string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 2 : 3;
              continue;
            default:
              type2 = (Type) null;
              break;
          }
          type1 = type2;
          num2 = 9;
        }
label_9:
        enumerator = source.SelectMany<string, FindReferenceService.Reference>((Func<string, IEnumerable<FindReferenceService.Reference>>) (en => (IEnumerable<FindReferenceService.Reference>) this.GetReferences(en))).GetEnumerator();
        num1 = 6;
        continue;
label_80:
        source.Add(type1.FullName);
        num1 = 16;
      }
label_77:
      return;
label_12:
      return;
label_72:
      return;
label_17:
      try
      {
label_21:
        if (FindReferenceService.W9JKYAb8gnL3IE32BQrt((object) enumerator))
          goto label_27;
        else
          goto label_22;
label_18:
        FindReferenceService.Reference current;
        Type typeByUid;
        string str1;
        int num3;
        while (true)
        {
          EntitySettings entitySettings1;
          EntityPropertyMetadata propertyMetadata;
          object obj1;
          string str2;
          string str3;
          object id;
          Guid typeUid;
          string queryString;
          Guid guid;
          EntitySettings entitySettings2;
          object obj2;
          switch (num3)
          {
            case 1:
              propertyMetadata = current.PropertyMetadata as EntityPropertyMetadata;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 15 : 24;
              continue;
            case 2:
              if (propertyMetadata != null)
              {
                num3 = 11;
                continue;
              }
              goto case 26;
            case 3:
              ((IQuery) FindReferenceService.aBdahYb8xuK2dphXa4ka(FindReferenceService.bxJnSyb87qfSUBXa8E2l((object) session, (object) str3), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121068521), id)).ExecuteUpdate(false);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 2;
              continue;
            case 4:
              FindReferenceService.dRsabQb8lhw39ZAbmH5j(FindReferenceService.aBdahYb8xuK2dphXa4ka((object) session.CreateSQLQuery(queryString), FindReferenceService.wxE3pBb86726BAQS1KJr(-1120607109 - 305487170 ^ -1426246949), obj1), false);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 10 : 19;
              continue;
            case 5:
            case 28:
              if (entitySettings1 == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 8;
                continue;
              }
              goto case 13;
            case 6:
              entitySettings2 = ((PropertyMetadata) FindReferenceService.S3piZmb8wWMddlGyuUi9((object) current)).Settings as EntitySettings;
              break;
            case 7:
            case 8:
              goto label_21;
            case 9:
              goto label_37;
            case 10:
              goto label_71;
            case 11:
              guid = FindReferenceService.LltYN8b80cJnNjdve7Dd((object) propertyMetadata);
              goto label_67;
            case 12:
              queryString = (string) FindReferenceService.lcNyIob89rB2jQ37tTZq(FindReferenceService.wxE3pBb86726BAQS1KJr(-2107978722 ^ -2108130840), FindReferenceService.p3u35ib8AHCO9yKusU8M(FindReferenceService.BVjrtRb8HIQk6mlXfbXU((object) this.transformationProvider.Value), FindReferenceService.T41KqOb8M8MOqnCdlVPr((object) entitySettings1)), FindReferenceService.p3u35ib8AHCO9yKusU8M(FindReferenceService.BVjrtRb8HIQk6mlXfbXU((object) this.transformationProvider.Value), FindReferenceService.JTAN0Pb8JFLK5lkMGHpn((object) entitySettings1)));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
              continue;
            case 13:
              if (entitySettings1.RelationType == RelationType.ManyToMany)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 6 : 12;
                continue;
              }
              goto label_21;
            case 14:
              goto label_56;
            case 15:
              typeByUid = this.metadataService.Value.GetTypeByUid(FindReferenceService.qEVDH3b8yd4ejvt6NHLB(FindReferenceService.ywArutb8m4nUfxonf5lJ((object) current)));
              num3 = 9;
              continue;
            case 16:
              if (entitySettings1 != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 22 : 22;
                continue;
              }
              goto case 5;
            case 17:
              if (current.PropertyMetadata != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 6 : 2;
                continue;
              }
              goto case 27;
            case 18:
              goto label_27;
            case 19:
              str1 = this.metadataService.Value.GetTypeByUid(current.EntityMetadata.Uid).FullName + (string) FindReferenceService.wxE3pBb86726BAQS1KJr(-882126494 ^ -882127962) + (string) FindReferenceService.iATTWUb8rxy9X2B9tnvM(FindReferenceService.S3piZmb8wWMddlGyuUi9((object) current));
              num3 = 14;
              continue;
            case 20:
              obj2 = FindReferenceService.jWk4sgb845FF5re5ZiXx((object) current.EntityMetadata);
              goto label_65;
            case 21:
              session.CleanUpCache(ModelHelper.GetEntityType(typeUid));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 15 : 0;
              continue;
            case 22:
              if (entitySettings1.RelationType != RelationType.OneToOne)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 5 : 5;
                continue;
              }
              goto case 1;
            case 23:
              id = entity.GetId();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 3 : 1;
              continue;
            case 24:
              if (propertyMetadata == null)
              {
                num3 = 20;
                continue;
              }
              obj2 = (object) propertyMetadata.GetTableName(current.EntityMetadata);
              goto label_65;
            case 25:
              str3 = string.Format((string) FindReferenceService.wxE3pBb86726BAQS1KJr(-1217523399 ^ -1217616711), FindReferenceService.p3u35ib8AHCO9yKusU8M(FindReferenceService.BVjrtRb8HIQk6mlXfbXU((object) this.transformationProvider.Value), (object) str2), FindReferenceService.p3u35ib8AHCO9yKusU8M(FindReferenceService.BVjrtRb8HIQk6mlXfbXU((object) this.transformationProvider.Value), (object) entitySettings1.FieldName));
              num3 = 23;
              continue;
            case 26:
              guid = current.EntityMetadata.Uid;
              goto label_67;
            case 27:
              entitySettings2 = (EntitySettings) null;
              break;
            default:
              obj1 = FindReferenceService.xe9dE1b8d8Usi4hby8Kp((object) entity);
              num3 = 4;
              continue;
          }
          entitySettings1 = entitySettings2;
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 3 : 16;
          continue;
label_65:
          str2 = (string) obj2;
          num3 = 25;
          continue;
label_67:
          typeUid = guid;
          num3 = 21;
        }
label_71:
        return;
label_37:
        try
        {
          session.CleanUpCache(typeByUid);
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
            num4 = 0;
          switch (num4)
          {
            default:
              goto label_21;
          }
        }
        catch (MappingException ex)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
            num5 = 0;
          switch (num5)
          {
            default:
              goto label_21;
          }
        }
label_56:
        try
        {
          session.CleanUpCollectionsCache(str1);
          int num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
            num6 = 0;
          switch (num6)
          {
            default:
              goto label_21;
          }
        }
        catch (MappingException ex)
        {
          int num7 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
            num7 = 0;
          switch (num7)
          {
            default:
              goto label_21;
          }
        }
label_22:
        num3 = 10;
        goto label_18;
label_27:
        current = enumerator.Current;
        num3 = 17;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        {
          num3 = 16;
          goto label_18;
        }
        else
          goto label_18;
      }
      finally
      {
        int num8;
        if (enumerator == null)
          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
        else
          goto label_73;
label_70:
        switch (num8)
        {
          case 2:
            break;
          default:
        }
label_73:
        enumerator.Dispose();
        num8 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
        {
          num8 = 1;
          goto label_70;
        }
        else
          goto label_70;
      }
    }

    private bool Add(
      ConcurrentDictionary<string, ConcurrentDictionary<Guid, FindReferenceService.ReferenceMap>> references,
      FindReferenceService.ReferenceMap map)
    {
      if (!references.GetOrAdd(map.ReferenceEntityName, (Func<string, ConcurrentDictionary<Guid, FindReferenceService.ReferenceMap>>) (_ => new ConcurrentDictionary<Guid, FindReferenceService.ReferenceMap>())).TryAdd(map.ElementPropertyUid, map))
        return false;
      this.cachedLoadedMetadata.Remove(map.ElementEntityUid);
      return true;
    }

    private void Send(
      IEnumerable<FindReferenceService.ReferenceMap> references,
      IEnumerable<FindReferenceService.ReferenceMap> allReferences)
    {
      this.serverPlacementPublishService.For<FindReferenceService.IInstanceActor>().Publish((Func<FindReferenceService.IInstanceActor, Task>) (a => a.AddReferences(references, allReferences)));
    }

    static FindReferenceService()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            FindReferenceService.BLOBStoreKey = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740433008);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool P1qUMcb8Pj6hGB81u1Lp() => FindReferenceService.nBDVsnb8eOYJew1IYYky == null;

    internal static FindReferenceService NgaXXtb81y4U3ZRGgWMw() => FindReferenceService.nBDVsnb8eOYJew1IYYky;

    internal static bool i0ga54b8N9CS22JYWgBA([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static Type wI9QDwb83ZNJKOkMPP0G([In] object obj0) => NHibernateProxyHelper.GuessClass(obj0);

    internal static object AER7KAb8pKDOMmHF49lO([In] object obj0) => (object) ((ISession) obj0).SessionFactory;

    internal static object iiA9Obb8aUGU0yRySGFX([In] object obj0, [In] object obj1) => (object) ((ISessionFactory) obj0).GetClassMetadata((string) obj1);

    internal static Type SMh3Erb8DdY8YmR3Nw94([In] object obj0) => ((IClassMetadata) obj0).MappedClass;

    internal static bool AmESMwb8tv8VKoJBE9lO([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object S3piZmb8wWMddlGyuUi9([In] object obj0) => (object) ((FindReferenceService.Reference) obj0).PropertyMetadata;

    internal static object jWk4sgb845FF5re5ZiXx([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;

    internal static object wxE3pBb86726BAQS1KJr(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object BVjrtRb8HIQk6mlXfbXU([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object p3u35ib8AHCO9yKusU8M([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object bxJnSyb87qfSUBXa8E2l([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLQuery((string) obj1);

    internal static object aBdahYb8xuK2dphXa4ka([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IQuery) obj0).SetParameter((string) obj1, obj2);

    internal static Guid LltYN8b80cJnNjdve7Dd([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object ywArutb8m4nUfxonf5lJ([In] object obj0) => (object) ((FindReferenceService.Reference) obj0).EntityMetadata;

    internal static Guid qEVDH3b8yd4ejvt6NHLB([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object T41KqOb8M8MOqnCdlVPr([In] object obj0) => (object) ((EntitySettings) obj0).RelationTableName;

    internal static object JTAN0Pb8JFLK5lkMGHpn([In] object obj0) => (object) ((EntitySettings) obj0).ChildColumnName;

    internal static object lcNyIob89rB2jQ37tTZq([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object xe9dE1b8d8Usi4hby8Kp([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static int dRsabQb8lhw39ZAbmH5j([In] object obj0, bool cleanUpCache) => ((IQuery) obj0).ExecuteUpdate(cleanUpCache);

    internal static object iATTWUb8rxy9X2B9tnvM([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static bool W9JKYAb8gnL3IE32BQrt([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    /// <summary>Модель ссылки</summary>
    [Serializable]
    public class ReferenceMap
    {
      internal static FindReferenceService.ReferenceMap knydgFC2d7MbN9Wb6ye5;

      /// <summary>Название сущности</summary>
      public string ReferenceEntityName
      {
        get => this.\u003CReferenceEntityName\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CReferenceEntityName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <summary>Уникальный идентификатор типа сущности</summary>
      public Guid ElementEntityUid
      {
        get => this.\u003CElementEntityUid\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CElementEntityUid\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <summary>Название свойства-сущности</summary>
      public string ElementEntityName
      {
        get => this.\u003CElementEntityName\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CElementEntityName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <summary>Название свойства</summary>
      public string ElementPropertyName
      {
        get => this.\u003CElementPropertyName\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CElementPropertyName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <summary>Уникальный идентификатор свойства</summary>
      public Guid ElementPropertyUid
      {
        get => this.\u003CElementPropertyUid\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CElementPropertyUid\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <summary>Тип связи</summary>
      public FindReferenceService.ReferenceEnum ReferenceType
      {
        get => this.\u003CReferenceType\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CReferenceType\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      public ReferenceMap()
      {
        FindReferenceService.ReferenceMap.qtf3BkC2gBainpwcCwCs();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool vpNeveC2lMkreoV63u92() => FindReferenceService.ReferenceMap.knydgFC2d7MbN9Wb6ye5 == null;

      internal static FindReferenceService.ReferenceMap G9GAAyC2r82attabMnPT() => FindReferenceService.ReferenceMap.knydgFC2d7MbN9Wb6ye5;

      internal static void qtf3BkC2gBainpwcCwCs() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    public class Reference
    {
      private static FindReferenceService.Reference ECRGALC2543wJWORPcP5;

      public EntityMetadata EntityMetadata
      {
        get => this.\u003CEntityMetadata\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CEntityMetadata\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      public PropertyMetadata PropertyMetadata
      {
        get => this.\u003CPropertyMetadata\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CPropertyMetadata\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      public FindReferenceService.ReferenceEnum ReferenceType
      {
        get => this.\u003CReferenceType\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CReferenceType\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      public Reference()
      {
        FindReferenceService.Reference.AMsOZ2C2L30lr1IPe4ms();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool dGcbuWC2je4TxQFMa1cR() => FindReferenceService.Reference.ECRGALC2543wJWORPcP5 == null;

      internal static FindReferenceService.Reference PSTVlGC2YifT0FS9IrMm() => FindReferenceService.Reference.ECRGALC2543wJWORPcP5;

      internal static void AMsOZ2C2L30lr1IPe4ms() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    public enum ReferenceEnum
    {
      Simple,
      ManyToMany,
    }

    /// <summary>Актор для синхронизации информации о ссылках</summary>
    internal interface IInstanceActor : IServerPlacementActor, IActorWithGuidKey, IActor
    {
      /// <summary>Добавить ссылки</summary>
      /// <param name="references">Информация о ссылках</param>
      /// <param name="allReferences">Информация об обратных ссылках</param>
      Task AddReferences(
        IEnumerable<FindReferenceService.ReferenceMap> references,
        IEnumerable<FindReferenceService.ReferenceMap> allReferences);
    }

    /// <inheritdoc />
    internal class InstanceActor : 
      Actor,
      FindReferenceService.IInstanceActor,
      IServerPlacementActor,
      IActorWithGuidKey,
      IActor
    {
      private readonly ILazy<FindReferenceService> findReferenceService;
      private static FindReferenceService.InstanceActor pvOc1aCeWQatqEw2dkAY;

      /// <summary>ctor</summary>
      /// <param name="findReferenceService">Служба поиска зависимостей</param>
      public InstanceActor(ILazy<FindReferenceService> findReferenceService)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.findReferenceService = findReferenceService;
      }

      /// <inheritdoc />
      public Task AddReferences(
        IEnumerable<FindReferenceService.ReferenceMap> references,
        IEnumerable<FindReferenceService.ReferenceMap> allReferences)
      {
        if (this.findReferenceService.IsRegistered)
        {
          if (references != null)
            references.ForEach<FindReferenceService.ReferenceMap>((Action<FindReferenceService.ReferenceMap>) (m =>
            {
              int num = 2;
              while (true)
              {
                switch (num)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    this.findReferenceService.Value.Add(this.findReferenceService.Value.allReferences, m);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                    continue;
                  case 2:
                    this.findReferenceService.Value.Add(this.findReferenceService.Value.references, m);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_2:
              return;
label_5:;
            }));
          if (allReferences != null)
            allReferences.ForEach<FindReferenceService.ReferenceMap>((Action<FindReferenceService.ReferenceMap>) (m =>
            {
              int num = 1;
              while (true)
              {
                switch (num)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    this.findReferenceService.Value.Add(this.findReferenceService.Value.allReferences, m);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
        }
        return Task.CompletedTask;
      }

      internal static bool Xh7IowCeo39xxD2KCOeP() => FindReferenceService.InstanceActor.pvOc1aCeWQatqEw2dkAY == null;

      internal static FindReferenceService.InstanceActor P6SJveCeb9u1CKaexLhS() => FindReferenceService.InstanceActor.pvOc1aCeWQatqEw2dkAY;
    }
  }
}
