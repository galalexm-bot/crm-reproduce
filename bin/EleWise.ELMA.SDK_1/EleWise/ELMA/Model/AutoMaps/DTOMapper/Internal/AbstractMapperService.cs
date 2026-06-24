// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.AbstractMapperService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal
{
  /// <summary>Абстрактный класс маппера</summary>
  /// <inheritdoc cref="T:EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.IInternalMapperService" />
  internal abstract class AbstractMapperService : IMapperService, IInternalMapperService
  {
    /// <summary>Список мапперов</summary>
    protected ICollection<IInternalMapperConfiguration> mappers;
    /// <summary>Кеш мапперов по уникальному идентификатору метаданных</summary>
    internal readonly ConcurrentDictionary<Guid, IInternalMapperConfiguration> mappersByUidCache;
    /// <summary>
    /// Кеш мапперов по типу и уникальному идентификатору метаданных
    /// </summary>
    internal readonly ConcurrentDictionary<(Type, Guid), ISet<IInternalMapperConfiguration>> mappersByTypeAndUidCache;
    /// <summary>Кеш мапперов по typreref</summary>
    internal readonly ConcurrentDictionary<string, ISet<IInternalMapperConfiguration>> mappersByTypeRef;
    /// <summary>Кеш опубликованных модулей</summary>
    internal readonly ConcurrentDictionary<Guid, ModuleVersion[]> PublishedModules;
    private static readonly Type defaultMapperType;
    private static DataClassDescriptor dataClassDescriptor;
    private readonly IModuleMetadataLoader moduleMetadataLoader;
    private static AbstractMapperService biDP2XhxejTRU9NWL0vI;

    /// <summary>Инициализировать</summary>
    protected abstract void Init();

    /// <inheritdoc />
    public TDestination Map<TDestination>(object source) where TDestination : class => this.Map(typeof (TDestination), source).As<TDestination>();

    /// <inheritdoc />
    public TDestination Map<TSource, TDestination>(TSource source)
      where TSource : class
      where TDestination : class
    {
      return this.Map<TDestination>((object) source);
    }

    /// <inheritdoc />
    public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
      where TSource : class
      where TDestination : class
    {
      return this.Map(TypeOf<TDestination>.Raw, (object) source, (object) destination).As<TDestination>();
    }

    private object Map(Type destinationType, object source, object destination = null)
    {
      int num = 8;
      while (true)
      {
        IInternalMapperConfiguration mapper1;
        object obj1;
        Guid metadataUid;
        IInternalMapperConfiguration mapper2;
        object obj2;
        object obj3;
        Guid guid;
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (destination == null)
            {
              num = 14;
              continue;
            }
            obj2 = AbstractMapperService.hETGUHhxpkYkETPOWCDy(destination);
            break;
          case 3:
            mapper2 = this.GetMapper(obj1.GetType(), metadataUid);
            num = 5;
            continue;
          case 4:
            obj3 = (object) mapper2.CreateDestinationInstance();
            goto label_28;
          case 5:
            object obj4 = destination;
            if (obj4 == null)
            {
              num = 4;
              continue;
            }
            obj3 = obj4;
            goto label_28;
          case 6:
            guid = Guid.Empty;
            goto label_26;
          case 7:
            goto label_11;
          case 8:
            if (source == null)
            {
              num = 7;
              continue;
            }
            AbstractMapperService.J8jeRKhxNLhTT5ALmUmY((object) this);
            num = 12;
            continue;
          case 9:
            obj1 = AbstractMapperService.hETGUHhxpkYkETPOWCDy(source);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 3;
            continue;
          case 10:
            mapper1 = this.GetMapper(dataClass, destinationType);
            num = 2;
            continue;
          case 11:
            UidAttribute attribute = AttributeHelper<UidAttribute>.GetAttribute(destinationType, true);
            if (attribute == null)
            {
              num = 6;
              continue;
            }
            guid = attribute.Uid;
            goto label_26;
          case 12:
            if (!(source is DataClass dataClass))
            {
              num = 11;
              continue;
            }
            goto case 10;
          case 13:
            AbstractMapperService.oOfoyYhxDJI6DxKudEdq((object) mapper2, obj1, (object) (DataClass) destination, (object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 1;
            continue;
          case 14:
            obj2 = AbstractMapperService.qd0R9Fhx36hR7CctRgAq((object) mapper1, (object) dataClass);
            break;
          case 15:
            AbstractMapperService.G1uQErhxaVWb807gtRvt((object) mapper1, (object) dataClass, destination, (object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
            continue;
          default:
            goto label_16;
        }
        destination = obj2;
        num = 15;
        continue;
label_26:
        metadataUid = guid;
        num = 9;
        continue;
label_28:
        destination = obj3;
        num = 13;
      }
label_3:
      return destination;
label_11:
      return (object) null;
label_16:
      return destination;
    }

    private static DataClassDescriptor DataClassDescriptor
    {
      get
      {
        int num = 1;
        DataClassDescriptor dataClassDescriptor;
        while (true)
        {
          switch (num)
          {
            case 1:
              dataClassDescriptor = AbstractMapperService.dataClassDescriptor;
              if (dataClassDescriptor == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return dataClassDescriptor;
label_5:
        return AbstractMapperService.dataClassDescriptor = Locator.GetServiceNotNull<DataClassDescriptor>();
      }
    }

    protected AbstractMapperService(IModuleMetadataLoader moduleMetadataLoader)
    {
      AbstractMapperService.mnGol7hxtxcupJqLb71D();
      this.mappers = (ICollection<IInternalMapperConfiguration>) new MappersCollection();
      this.mappersByUidCache = new ConcurrentDictionary<Guid, IInternalMapperConfiguration>();
      this.mappersByTypeAndUidCache = new ConcurrentDictionary<(Type, Guid), ISet<IInternalMapperConfiguration>>();
      this.mappersByTypeRef = new ConcurrentDictionary<string, ISet<IInternalMapperConfiguration>>();
      this.PublishedModules = new ConcurrentDictionary<Guid, ModuleVersion[]>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.moduleMetadataLoader = moduleMetadataLoader;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public IInternalMapperConfiguration GetMapper(Type declaredSourceType, Guid metadataUid)
    {
      int num = 1;
      IInternalMapperConfiguration mapperInternal;
      while (true)
      {
        switch (num)
        {
          case 1:
            ISet<IInternalMapperConfiguration> orAdd = this.mappersByTypeAndUidCache.GetOrAdd((declaredSourceType, metadataUid), (Func<(Type, Guid), ISet<IInternalMapperConfiguration>>) (tuple => (ISet<IInternalMapperConfiguration>) new ConcurrentHashSet<IInternalMapperConfiguration>()));
            mapperInternal = this.GetMapperInternal(declaredSourceType, metadataUid);
            IInternalMapperConfiguration mapperConfiguration = mapperInternal;
            orAdd.Add(mapperConfiguration);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return mapperInternal;
    }

    /// <inheritdoc />
    public IInternalMapperConfiguration GetMapper(Guid metadataUid) => this.mappersByUidCache.GetOrAdd(metadataUid, (Func<Guid, IInternalMapperConfiguration>) (mdUid =>
    {
      int num = 3;
      DataClassMetadata metadataByUid;
      string typeRef;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            metadataByUid = ((DataClassDescriptor) AbstractMapperService.eam8wohxx4RWqR79Duye()).GetMetadataByUid(mdUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          case 3:
            num = 2;
            continue;
          default:
            typeRef = (string) AbstractMapperService.comIxuhx03u2gGKPBgkm((object) metadataByUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
            continue;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.mappers.FirstOrDefault<IInternalMapperConfiguration>((Func<IInternalMapperConfiguration, bool>) (a => AbstractMapperService.\u003C\u003Ec__DisplayClass17_0.HdDGG1v4oK2UHXuoWJIe(AbstractMapperService.\u003C\u003Ec__DisplayClass17_0.bKlmPGv4WxP34kcpiK3W((object) a), (object) typeRef)));
    }));

    /// <inheritdoc />
    public IInternalMapperConfiguration GetMapper(DataClass dataClass, Type declaredSourceType)
    {
      int num = 1;
      string dataClassTypeRef;
      while (true)
      {
        switch (num)
        {
          case 1:
            dataClassTypeRef = (string) AbstractMapperService.OuHKVmhxwUui1DoYb2My((object) dataClass);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.GetMapper(dataClassTypeRef, declaredSourceType);
    }

    private IInternalMapperConfiguration GetMapperInternal(Type declaredType, Guid mdUid)
    {
      int num1 = 10;
      IInternalMapperConfiguration mapperInternal;
      while (true)
      {
        int num2 = num1;
        string str;
        Type declaredType1;
        Type baseType;
        Type type;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 6:
              if (!AbstractMapperService.jNWCmjhx7FCNqKMEJwOx(baseType, TypeOf<object>.Raw))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 14 : 7;
                continue;
              }
              goto case 28;
            case 2:
            case 20:
              if (AbstractMapperService.adVWpqhxAOrNIjpuDQfh(baseType, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
                continue;
              }
              goto case 28;
            case 3:
              this.mappers.Add(mapperInternal);
              num2 = 15;
              continue;
            case 4:
              type = ((IMetadataRuntimeService) AbstractMapperService.yG658Hhx4tTuDuHVOCji()).GetTypeByUidOrNull(AbstractMapperService.AJlipJhx6wbklACOF3nl((object) entityMetadata) == EntityMetadataType.InterfaceImplementation ? entityMetadata.ImplementationUid : AbstractMapperService.hoWhVwhxHTZtyXRPadZD((object) entityMetadata), false);
              num2 = 27;
              continue;
            case 5:
              goto label_36;
            case 7:
              if (mapperInternal != null)
              {
                num2 = 11;
                continue;
              }
              goto label_16;
            case 8:
              if (!TypeOf<IEntity>.Raw.IsAssignableFrom(declaredType1))
              {
                num2 = 12;
                continue;
              }
              goto case 22;
            case 9:
              declaredType1 = declaredType;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 23 : 24;
              continue;
            case 10:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 9 : 0;
              continue;
            case 11:
              goto label_15;
            case 12:
            case 25:
              mapperInternal = this.TryFindMapperByType(declaredType1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 7 : 6;
              continue;
            case 13:
              goto label_20;
            case 14:
              // ISSUE: reference to a compiler-generated method
              mapperInternal = this.mappers.FirstOrDefault<IInternalMapperConfiguration>((Func<IInternalMapperConfiguration, bool>) (a => AbstractMapperService.\u003C\u003Ec__DisplayClass19_0.Oy6Bniv4QDD95HkCQxvO((object) a) == baseType));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 17 : 16;
              continue;
            case 15:
              goto label_41;
            case 16:
              if (mapperInternal == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 8;
                continue;
              }
              goto label_12;
            case 17:
              if (mapperInternal != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
                continue;
              }
              mapperInternal = this.TryFindMapperByType(baseType);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 18 : 3;
              continue;
            case 18:
              if (mapperInternal != null)
              {
                num2 = 13;
                continue;
              }
              baseType = baseType.BaseType;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 1;
              continue;
            case 19:
              goto label_27;
            case 21:
              if (mapperInternal != null)
              {
                num2 = 19;
                continue;
              }
              goto case 12;
            case 22:
              if (!(MetadataLoader.LoadMetadata(declaredType1) is EntityMetadata entityMetadata))
              {
                num2 = 25;
                continue;
              }
              goto case 26;
            case 23:
              goto label_12;
            case 24:
              // ISSUE: reference to a compiler-generated method
              mapperInternal = this.mappers.FirstOrDefault<IInternalMapperConfiguration>((Func<IInternalMapperConfiguration, bool>) (a => AbstractMapperService.\u003C\u003Ec__DisplayClass19_0.pDahmvv4fiyAxG82PWF6(a.SourceType, declaredType1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 16 : 16;
              continue;
            case 26:
              num2 = 4;
              continue;
            case 27:
              if (AbstractMapperService.adVWpqhxAOrNIjpuDQfh(type, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 29 : 21;
                continue;
              }
              goto case 12;
            case 28:
              str = (string) AbstractMapperService.comIxuhx03u2gGKPBgkm((object) ((DataClassDescriptor) AbstractMapperService.eam8wohxx4RWqR79Duye()).GetMetadataByUid(mdUid));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 5;
              continue;
            case 29:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              mapperInternal = this.mappers.FirstOrDefault<IInternalMapperConfiguration>((Func<IInternalMapperConfiguration, bool>) (a => AbstractMapperService.\u003C\u003Ec__DisplayClass19_1.JJWDUPv4I4H9USWJVvKa(AbstractMapperService.\u003C\u003Ec__DisplayClass19_1.im3Xvsv4ulWKUEkyAKU8((object) a), type)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 21 : 2;
              continue;
            default:
              goto label_33;
          }
        }
label_16:
        baseType = declaredType1.BaseType;
        num1 = 20;
        continue;
label_36:
        mapperInternal = (IInternalMapperConfiguration) AbstractMapperService.mY3BVuhxm59bIlexahex(declaredType1, (object) str);
        num1 = 3;
      }
label_12:
      return mapperInternal;
label_15:
      return mapperInternal;
label_20:
      return mapperInternal;
label_27:
      return mapperInternal;
label_33:
      return mapperInternal;
label_41:
      return mapperInternal;
    }

    private IInternalMapperConfiguration TryFindMapperByType(Type sourceType)
    {
      int num1 = 8;
      int index;
      ModuleVersion[] orAdd;
      string str;
      IInternalMapperConfiguration mapperByType;
      string fullName;
      DataClassMetadata dataClassMetadata;
      Type sourceType1;
      AbstractMapperService abstractMapperService;
      string typeToMap;
      while (true)
      {
        switch (num1)
        {
          case 1:
          case 4:
            dataClassMetadata = ((ModuleInfoMetadata) AbstractMapperService.xXNGXAhx92oTMsi7KlUf((object) orAdd[index])).DataClasses.FirstOrDefault<DataClassMetadata>((Func<DataClassMetadata, bool>) (dto =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (AbstractMapperService.\u003C\u003Ec__DisplayClass20_0.w97Mpbv4KdtNoXwwaLiU((object) dto) != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_3;
                  default:
                    goto label_2;
                }
              }
label_2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return AbstractMapperService.\u003C\u003Ec__DisplayClass20_0.h387u6v4T63mNdckdDA8(AbstractMapperService.\u003C\u003Ec__DisplayClass20_0.bc38Lnv4XWRGncKy0MJe(AbstractMapperService.\u003C\u003Ec__DisplayClass20_0.w97Mpbv4KdtNoXwwaLiU((object) dto)), (object) typeToMap);
label_3:
              return false;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 2 : 12;
            continue;
          case 2:
            goto label_15;
          case 3:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (this.mappers.FirstOrDefault<IInternalMapperConfiguration>((Func<IInternalMapperConfiguration, bool>) (m => AbstractMapperService.\u003C\u003Ec__DisplayClass20_0.uf1tkIv4q2cPPNPqAP0S(AbstractMapperService.\u003C\u003Ec__DisplayClass20_0.B88h1Qv4Rydm6IFHNPxg((object) m), sourceType1))) == null)
            {
              str = (string) AbstractMapperService.sZ1L81hxMfRiGxrFK0vq(AbstractMapperService.LdUA2MhxyBJleThyfpsH((object) sourceType1.Assembly));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 10 : 9;
              continue;
            }
            num1 = 11;
            continue;
          case 5:
          case 16:
            if (index < orAdd.Length)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
              continue;
            }
            goto label_15;
          case 6:
            goto label_11;
          case 7:
            sourceType1 = sourceType;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 8 : 13;
            continue;
          case 8:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 7 : 1;
            continue;
          case 9:
            orAdd = this.PublishedModules.GetOrAdd(Guid.Empty, (Func<Guid, ModuleVersion[]>) (g => abstractMapperService.moduleMetadataLoader.GetAllDefaultVersions((IEnumerable<Guid>) ModuleMetadataItemHeaderManager.DesignerModules).ToArray<ModuleVersion>()));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 9 : 15;
            continue;
          case 10:
            fullName = sourceType1.FullName;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 11:
            goto label_5;
          case 12:
            if (dataClassMetadata == null)
            {
              ++index;
              num1 = 5;
              continue;
            }
            num1 = 14;
            continue;
          case 13:
            abstractMapperService = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 3;
            continue;
          case 14:
            mapperByType = (IInternalMapperConfiguration) AbstractMapperService.mY3BVuhxm59bIlexahex(sourceType1, AbstractMapperService.comIxuhx03u2gGKPBgkm((object) dataClassMetadata));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 17 : 0;
            continue;
          case 15:
            index = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 16 : 16;
            continue;
          case 17:
            this.mappers.Add(mapperByType);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 6 : 5;
            continue;
          default:
            typeToMap = (string) AbstractMapperService.Nda9dahxJaPy5t0xDPI8((object) fullName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487385500), (object) str);
            num1 = 9;
            continue;
        }
      }
label_5:
      return (IInternalMapperConfiguration) null;
label_11:
      return mapperByType;
label_15:
      return (IInternalMapperConfiguration) null;
    }

    private IInternalMapperConfiguration GetMapper(string dataClassTypeRef, Type declaredSourceType)
    {
      int num = 1;
      IInternalMapperConfiguration internalMapper;
      while (true)
      {
        switch (num)
        {
          case 1:
            ConcurrentDictionary<string, ISet<IInternalMapperConfiguration>> mappersByTypeRef = this.mappersByTypeRef;
            string key = dataClassTypeRef;
            // ISSUE: reference to a compiler-generated field
            Func<string, ISet<IInternalMapperConfiguration>> func = AbstractMapperService.\u003C\u003Ec.\u003C\u003E9__21_0;
            Func<string, ISet<IInternalMapperConfiguration>> valueFactory;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              AbstractMapperService.\u003C\u003Ec.\u003C\u003E9__21_0 = valueFactory = (Func<string, ISet<IInternalMapperConfiguration>>) (typeRef => (ISet<IInternalMapperConfiguration>) new ConcurrentHashSet<IInternalMapperConfiguration>());
            }
            else
              goto label_6;
label_5:
            ISet<IInternalMapperConfiguration> orAdd = mappersByTypeRef.GetOrAdd(key, valueFactory);
            internalMapper = this.GetInternalMapper(dataClassTypeRef, declaredSourceType);
            IInternalMapperConfiguration mapperConfiguration = internalMapper;
            orAdd.Add(mapperConfiguration);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
label_6:
            valueFactory = func;
            goto label_5;
          default:
            goto label_2;
        }
      }
label_2:
      return internalMapper;
    }

    private IInternalMapperConfiguration GetInternalMapper(string typeRef, Type declaredSourceType)
    {
      int num1 = 22;
      IInternalMapperConfiguration internalMapper1;
      IInternalMapperConfiguration internalMapper2;
      IInternalMapperConfiguration internalMapper3;
      IInternalMapperConfiguration defaultMapper;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          Type type1;
          int index;
          IInternalMapperConfiguration[] mapperConfigurationArray;
          IInternalMapperConfiguration[] array;
          ModuleVersion[] orAdd;
          List<IInternalMapperConfiguration> source;
          IEnumerator<DataClassMetadata> enumerator;
          string typeRef1;
          AbstractMapperService abstractMapperService;
          Type declaredSourceType1;
          switch (num2)
          {
            case 1:
              if (AbstractMapperService.gfJcn8hxYPuBu20epjs9((object) source) <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 12 : 33;
                continue;
              }
              goto case 8;
            case 2:
              source = new List<IInternalMapperConfiguration>();
              num2 = 38;
              continue;
            case 3:
              type1 = ((IMetadataRuntimeService) AbstractMapperService.yG658Hhx4tTuDuHVOCji()).GetTypeByUidOrNull(AbstractMapperService.AJlipJhx6wbklACOF3nl((object) entityMetadata) == EntityMetadataType.InterfaceImplementation ? entityMetadata.ImplementationUid : AbstractMapperService.hoWhVwhxHTZtyXRPadZD((object) entityMetadata), false);
              num2 = 15;
              continue;
            case 4:
              goto label_41;
            case 5:
              goto label_19;
            case 6:
              // ISSUE: reference to a compiler-generated method
              array = this.mappers.Where<IInternalMapperConfiguration>((Func<IInternalMapperConfiguration, bool>) (a => AbstractMapperService.\u003C\u003Ec__DisplayClass22_0.O1mhBjv4e2MseOnUSjjT((object) a.TypeRef, (object) typeRef1))).ToArray<IInternalMapperConfiguration>();
              num2 = 12;
              continue;
            case 7:
              this.mappers.Add(internalMapper3);
              num2 = 25;
              continue;
            case 8:
              array = source.Where<IInternalMapperConfiguration>((Func<IInternalMapperConfiguration, bool>) (a => a.TypeRef == typeRef1)).ToArray<IInternalMapperConfiguration>();
              num2 = 26;
              continue;
            case 9:
              index = 0;
              num2 = 18;
              continue;
            case 10:
              if (TypeOf<IEntity>.Raw.IsAssignableFrom(declaredSourceType1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
                continue;
              }
              goto case 15;
            case 11:
              // ISSUE: reference to a compiler-generated method
              internalMapper2 = ((IEnumerable<IInternalMapperConfiguration>) array).FirstOrDefault<IInternalMapperConfiguration>((Func<IInternalMapperConfiguration, bool>) (a => declaredSourceType1.IsAssignableFrom(AbstractMapperService.\u003C\u003Ec__DisplayClass22_0.XejwTWv4PABBeaueC0t4((object) a))));
              num2 = 30;
              continue;
            case 12:
              if (array.Length == 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 2;
                continue;
              }
              break;
            case 13:
              goto label_24;
            case 14:
              goto label_9;
            case 15:
              mapperConfigurationArray = array;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 9 : 7;
              continue;
            case 16:
            case 40:
              // ISSUE: reference to a compiler-generated method
              enumerator = ((ModuleInfoMetadata) AbstractMapperService.xXNGXAhx92oTMsi7KlUf((object) orAdd[index])).DataClasses.Where<DataClassMetadata>((Func<DataClassMetadata, bool>) (dto => AbstractMapperService.\u003C\u003Ec.QgHc80vwcZi9XpC4lLA9((object) dto) != null)).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 34 : 26;
              continue;
            case 17:
              internalMapper2 = AbstractMapperService.CreateDefaultMapper(declaredSourceType1, (object) typeRef1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 13 : 13;
              continue;
            case 18:
            case 41:
              if (index >= mapperConfigurationArray.Length)
              {
                num2 = 11;
                continue;
              }
              goto case 24;
            case 19:
            case 29:
              if (index < orAdd.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 15 : 16;
                continue;
              }
              goto case 1;
            case 20:
              goto label_16;
            case 21:
              typeRef1 = typeRef;
              num2 = 36;
              continue;
            case 22:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 21 : 12;
              continue;
            case 23:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 2 : 19;
              continue;
            case 24:
              internalMapper1 = mapperConfigurationArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 18 : 35;
              continue;
            case 25:
              goto label_11;
            case 26:
              if (array.Length == 0)
              {
                num2 = 42;
                continue;
              }
              break;
            case 27:
              declaredSourceType1 = declaredSourceType;
              num2 = 6;
              continue;
            case 28:
              if (AbstractMapperService.jNWCmjhx7FCNqKMEJwOx(AbstractMapperService.Pxe4GthxLO1YNd2kjYVZ((object) internalMapper1), type1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 31 : 25;
                continue;
              }
              goto label_28;
            case 30:
              if (internalMapper2 == null)
              {
                num2 = 17;
                continue;
              }
              goto label_16;
            case 31:
              goto label_27;
            case 32:
label_23:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 22 : 29;
              continue;
            case 33:
              internalMapper3 = (IInternalMapperConfiguration) AbstractMapperService.mY3BVuhxm59bIlexahex(declaredSourceType1, (object) typeRef1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 7;
              continue;
            case 34:
              try
              {
label_64:
                if (AbstractMapperService.wCDAQMhx56jEdhMyTirh((object) enumerator))
                  goto label_58;
                else
                  goto label_65;
label_52:
                DataClassMetadata current;
                string str;
                Type type2;
                IInternalMapperConfiguration mapperConfiguration;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_23;
                    case 2:
                      mapperConfiguration = (IInternalMapperConfiguration) AbstractMapperService.mY3BVuhxm59bIlexahex(type2, AbstractMapperService.comIxuhx03u2gGKPBgkm((object) current));
                      num3 = 9;
                      continue;
                    case 3:
                    case 8:
                      goto label_64;
                    case 4:
                      if (declaredSourceType1.IsAssignableFrom(type2))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 2 : 2;
                        continue;
                      }
                      goto label_64;
                    case 5:
                      if (AbstractMapperService.XqLEo5hxrDgA4msHKhkL((object) str))
                      {
                        num3 = 8;
                        continue;
                      }
                      goto case 7;
                    case 6:
                      goto label_58;
                    case 7:
                      type2 = AbstractMapperService.k4lAakhxgW51YGgJy3WI((object) str);
                      num3 = 11;
                      continue;
                    case 9:
                      this.mappers.Add(mapperConfiguration);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 8 : 10;
                      continue;
                    case 10:
                      source.Add(mapperConfiguration);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 3 : 2;
                      continue;
                    case 11:
                      if (!AbstractMapperService.jNWCmjhx7FCNqKMEJwOx(type2, (Type) null))
                      {
                        num3 = 4;
                        continue;
                      }
                      goto label_64;
                    default:
                      str = (string) AbstractMapperService.MUuYZshxlTBD5h3AND2U(AbstractMapperService.orD7n0hxdSRtHLefH5rr((object) current));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 3 : 5;
                      continue;
                  }
                }
label_58:
                current = enumerator.Current;
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
                {
                  num3 = 0;
                  goto label_52;
                }
                else
                  goto label_52;
label_65:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 1;
                goto label_52;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_73;
                      default:
                        AbstractMapperService.nhHuqVhxjo3sKT8b41Qp((object) enumerator);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_73:;
              }
            case 35:
              if (!AbstractMapperService.jNWCmjhx7FCNqKMEJwOx(internalMapper1.SourceType, declaredSourceType1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 39 : 31;
                continue;
              }
              goto label_41;
            case 36:
              abstractMapperService = this;
              num2 = 27;
              continue;
            case 37:
              this.mappers.Add(defaultMapper);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 5 : 3;
              continue;
            case 38:
              orAdd = this.PublishedModules.GetOrAdd(Guid.Empty, (Func<Guid, ModuleVersion[]>) (g => abstractMapperService.moduleMetadataLoader.GetAllDefaultVersions((IEnumerable<Guid>) ModuleMetadataItemHeaderManager.DesignerModules).ToArray<ModuleVersion>()));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 23 : 5;
              continue;
            case 39:
              if (AbstractMapperService.adVWpqhxAOrNIjpuDQfh(type1, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 28;
                continue;
              }
              goto label_28;
            case 42:
              defaultMapper = AbstractMapperService.CreateDefaultMapper(declaredSourceType1, (object) typeRef1);
              num2 = 37;
              continue;
            default:
              if (MetadataLoader.LoadMetadata(declaredSourceType1) is EntityMetadata entityMetadata)
              {
                num2 = 3;
                continue;
              }
              goto case 15;
          }
          type1 = (Type) null;
          num2 = 10;
          continue;
label_28:
          ++index;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 8 : 41;
        }
label_24:
        this.mappers.Add(internalMapper2);
        num1 = 14;
      }
label_9:
      return internalMapper2;
label_11:
      return internalMapper3;
label_16:
      return internalMapper2;
label_19:
      return defaultMapper;
label_27:
      return internalMapper1;
label_41:
      return internalMapper1;
    }

    private static IInternalMapperConfiguration CreateDefaultMapper(
      Type declaredSourceType,
      object typeRef)
    {
      return (IInternalMapperConfiguration) AbstractMapperService.eQFOWNhxUa08VOEJsnAS(AbstractMapperService.defaultMapperType.MakeGenericType(declaredSourceType), (object) new object[1]
      {
        typeRef
      });
    }

    static AbstractMapperService()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            // ISSUE: type reference
            AbstractMapperService.defaultMapperType = AbstractMapperService.VCPJLdhxsFlKI1xJlNoK(__typeref (DefaultDataClassBidirectionalMap<>));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static void J8jeRKhxNLhTT5ALmUmY([In] object obj0) => ((AbstractMapperService) obj0).Init();

    internal static object qd0R9Fhx36hR7CctRgAq([In] object obj0, [In] object obj1) => ((IInternalMapperConfiguration) obj0).CreateSourceInstance((DataClass) obj1);

    internal static object hETGUHhxpkYkETPOWCDy([In] object obj0) => obj0.CastAsRealType();

    internal static void G1uQErhxaVWb807gtRvt([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((IInternalMapperConfiguration) obj0).MapReverse((DataClass) obj1, obj2, (IInternalMapperService) obj3);

    internal static void oOfoyYhxDJI6DxKudEdq([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((IInternalMapperConfiguration) obj0).Map(obj1, (DataClass) obj2, (IInternalMapperService) obj3);

    internal static bool LNNLcDhxPxsqx5xYK7cH() => AbstractMapperService.biDP2XhxejTRU9NWL0vI == null;

    internal static AbstractMapperService rS6fZ3hx1QEpDCNJSA9g() => AbstractMapperService.biDP2XhxejTRU9NWL0vI;

    internal static void mnGol7hxtxcupJqLb71D() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object OuHKVmhxwUui1DoYb2My([In] object obj0) => (object) ((DataClass) obj0).TypeRef;

    internal static object yG658Hhx4tTuDuHVOCji() => (object) MetadataServiceContext.MetadataRuntimeService;

    internal static EntityMetadataType AJlipJhx6wbklACOF3nl([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static Guid hoWhVwhxHTZtyXRPadZD([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool adVWpqhxAOrNIjpuDQfh([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool jNWCmjhx7FCNqKMEJwOx([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object eam8wohxx4RWqR79Duye() => (object) AbstractMapperService.DataClassDescriptor;

    internal static object comIxuhx03u2gGKPBgkm([In] object obj0) => (object) ((DataClassMetadata) obj0).TypeRef;

    internal static object mY3BVuhxm59bIlexahex(Type declaredSourceType, [In] object obj1) => (object) AbstractMapperService.CreateDefaultMapper(declaredSourceType, obj1);

    internal static object LdUA2MhxyBJleThyfpsH([In] object obj0) => (object) ((Assembly) obj0).GetName();

    internal static object sZ1L81hxMfRiGxrFK0vq([In] object obj0) => (object) ((AssemblyName) obj0).Name;

    internal static object Nda9dahxJaPy5t0xDPI8([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object xXNGXAhx92oTMsi7KlUf([In] object obj0) => (object) ((ModuleVersion) obj0).Metadata;

    internal static object orD7n0hxdSRtHLefH5rr([In] object obj0) => (object) ((DataClassMetadata) obj0).TypeToMap;

    internal static object MUuYZshxlTBD5h3AND2U([In] object obj0) => (object) ((TypeToMap) obj0).FullTypeName;

    internal static bool XqLEo5hxrDgA4msHKhkL([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static Type k4lAakhxgW51YGgJy3WI([In] object obj0) => Type.GetType((string) obj0);

    internal static bool wCDAQMhx56jEdhMyTirh([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void nhHuqVhxjo3sKT8b41Qp([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static int gfJcn8hxYPuBu20epjs9([In] object obj0) => ((List<IInternalMapperConfiguration>) obj0).Count;

    internal static Type Pxe4GthxLO1YNd2kjYVZ([In] object obj0) => ((IInternalMapperConfiguration) obj0).SourceType;

    internal static object eQFOWNhxUa08VOEJsnAS([In] Type obj0, [In] object obj1) => Activator.CreateInstance(obj0, (object[]) obj1);

    internal static Type VCPJLdhxsFlKI1xJlNoK([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
