// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.BaseBidirectionalMap`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Collections;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.Converters;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.InstanceCreators;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal
{
  /// <summary>Базовый маппер</summary>
  /// <typeparam name="TSource">Исходный тип</typeparam>
  internal abstract class BaseBidirectionalMap<TSource> : IInternalMapperConfiguration
  {
    private bool configured;
    private bool configuredReverse;
    private readonly IDictionary<string, PropertyMap> propertyMaps;
    private readonly IDictionary<string, PropertyMap> propertyMapsReverse;
    private readonly List<Expression<Func<TSource, object>>> ignoreExpressions;
    private readonly List<Expression<Func<TSource, object>>> ignoreExpressionsReverse;
    internal static object oQ2Ia4h0BrAvBHsLsRT5;

    private List<Action<PropertyMap>> PropertyMapActions { get; }

    private List<Action<PropertyMap>> PropertyMapActionsReverse { get; }

    /// <summary>Ctor</summary>
    /// <param name="typeRef">Ссылка на тип DTO</param>
    internal BaseBidirectionalMap(string typeRef)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.propertyMaps = (IDictionary<string, PropertyMap>) new Dictionary<string, PropertyMap>();
      this.propertyMapsReverse = (IDictionary<string, PropertyMap>) new Dictionary<string, PropertyMap>();
      this.ignoreExpressions = new List<Expression<Func<TSource, object>>>();
      this.ignoreExpressionsReverse = new List<Expression<Func<TSource, object>>>();
      this.PropertyMapActions = new List<Action<PropertyMap>>();
      this.PropertyMapActionsReverse = new List<Action<PropertyMap>>();
      // ISSUE: reference to a compiler-generated field
      this.\u003CCustomBeforeMap\u003Ek__BackingField = (Action<object, DataClass>) ((src, dest) => { });
      // ISSUE: reference to a compiler-generated field
      Action<object, DataClass> action1 = BaseBidirectionalMap<TSource>.\u003C\u003Ec.\u003C\u003E9__12_1;
      Action<object, DataClass> action2;
      if (action1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        BaseBidirectionalMap<TSource>.\u003C\u003Ec.\u003C\u003E9__12_1 = action2 = (Action<object, DataClass>) ((src, dest) => { });
      }
      else
        goto label_14;
label_2:
      // ISSUE: reference to a compiler-generated field
      this.\u003CCustomMap\u003Ek__BackingField = action2;
      // ISSUE: reference to a compiler-generated field
      Action<DataClass, object> action3 = BaseBidirectionalMap<TSource>.\u003C\u003Ec.\u003C\u003E9__12_2;
      Action<DataClass, object> action4;
      if (action3 == null)
      {
        // ISSUE: reference to a compiler-generated field
        BaseBidirectionalMap<TSource>.\u003C\u003Ec.\u003C\u003E9__12_2 = action4 = (Action<DataClass, object>) ((src, dest) => { });
      }
      else
        goto label_13;
label_4:
      // ISSUE: reference to a compiler-generated field
      this.\u003CCustomBeforeMapReverse\u003Ek__BackingField = action4;
      // ISSUE: reference to a compiler-generated field
      Action<DataClass, object> action5 = BaseBidirectionalMap<TSource>.\u003C\u003Ec.\u003C\u003E9__12_3;
      Action<DataClass, object> action6;
      if (action5 == null)
      {
        // ISSUE: reference to a compiler-generated field
        BaseBidirectionalMap<TSource>.\u003C\u003Ec.\u003C\u003E9__12_3 = action6 = (Action<DataClass, object>) ((src, dest) => { });
      }
      else
        goto label_12;
label_7:
      // ISSUE: reference to a compiler-generated field
      this.\u003CCustomMapReverse\u003Ek__BackingField = action6;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_10;
          case 1:
            this.TypeRef = typeRef;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_10:
      return;
label_5:
      return;
label_12:
      action6 = action5;
      goto label_7;
label_13:
      action4 = action3;
      goto label_4;
label_14:
      action2 = action1;
      goto label_2;
    }

    /// <inheritdoc />
    public Type SourceType => TypeOf<TSource>.Raw;

    /// <inheritdoc />
    public string TypeRef { get; }

    /// <inheritdoc />
    public object CreateSourceInstance(DataClass dataClass)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ConfigureReverse();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return BaseBidirectionalMapStatics.InstanceCreators.First<IInstanceCreator>((Func<IInstanceCreator, bool>) (a => a.CanCreateInstance(this.SourceType))).CreateInstance(dataClass, this.SourceType);
    }

    /// <inheritdoc />
    public DataClass CreateDestinationInstance()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Configure();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return new DataClass(Locator.GetServiceNotNull<DataClassDescriptor>().GetValueContainer(this.TypeRef));
    }

    /// <inheritdoc />
    public void BeforeMap(
      object source,
      DataClass destination,
      IInternalMapperService mapperService)
    {
    }

    /// <inheritdoc />
    public void Map(object source, DataClass destination, IInternalMapperService mapperService)
    {
      int num1 = 2;
      DataClass destination1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            destination1 = destination;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_5;
          case 4:
            goto label_34;
          default:
            this.Configure();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 3 : 2;
            continue;
        }
      }
label_34:
      return;
label_5:
      try
      {
        DataClassMetadata[] array = destination1.GetIncludes(false).ToArray<DataClassMetadata>();
        DataClassMetadata metadata = ((IEnumerable<DataClassMetadata>) array).FirstOrDefault<DataClassMetadata>((Func<DataClassMetadata, bool>) (a => a.TypeRef == destination1.TypeRef));
        if (metadata != null)
          this.Map((ClassMetadata) metadata, source, destination1, mapperService);
        IEnumerator<DataClassMetadata> enumerator = ((IEnumerable<DataClassMetadata>) array).Except<DataClassMetadata>((IEnumerable<DataClassMetadata>) new DataClassMetadata[1]
        {
          metadata
        }).GetEnumerator();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
          num2 = 0;
        switch (num2)
        {
          case 1:
            break;
          default:
            try
            {
label_20:
              if (enumerator.MoveNext())
                goto label_15;
              else
                goto label_21;
label_13:
              DataClassMetadata current;
              int num3;
              while (true)
              {
                int num4;
                IInternalMapperConfiguration mapper;
                switch (num3)
                {
                  case 0:
                    goto label_26;
                  case 1:
                    mapper.Map((ClassMetadata) current, source, destination1, mapperService);
                    num3 = 4;
                    continue;
                  case 2:
                    this.InternalMap((ClassMetadata) current, source, destination1, mapperService);
                    num4 = 5;
                    break;
                  case 3:
                    if (mapper != null)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
                      continue;
                    }
                    goto case 2;
                  case 4:
                  case 5:
                    goto label_20;
                  case 6:
                    goto label_15;
                  case 7:
                    mapper = mapperService.GetMapper(current.Uid);
                    num4 = 3;
                    break;
                  default:
                    goto label_25;
                }
                num3 = num4;
              }
label_26:
              break;
label_25:
              break;
label_15:
              current = enumerator.Current;
              num3 = 7;
              goto label_13;
label_21:
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              goto label_13;
            }
            finally
            {
              int num5;
              if (enumerator == null)
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
              else
                goto label_27;
label_24:
              switch (num5)
              {
                case 2:
                  break;
                default:
              }
label_27:
              enumerator.Dispose();
              num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
              {
                num5 = 0;
                goto label_24;
              }
              else
                goto label_24;
            }
        }
      }
      catch (Exception ex)
      {
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
          num6 = 0;
        string message;
        while (true)
        {
          switch (num6)
          {
            case 1:
              Logger.Log.Error((object) message, ex);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 2;
              continue;
            case 2:
              goto label_37;
            default:
              message = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921039377) + this.TypeRef + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210561207) + this.SourceType.FullName;
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 0;
              continue;
          }
        }
label_37:
        throw new Exception(message, ex);
      }
    }

    /// <inheritdoc />
    public void Map(
      ClassMetadata metadata,
      object source,
      DataClass destination,
      IInternalMapperService mapperService)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            this.Configure();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          case 3:
            string name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909127081);
            // ISSUE: reference to a compiler-generated field
            Func<System.Collections.Generic.HashSet<Guid>> func = BaseBidirectionalMap<TSource>.\u003C\u003Ec.\u003C\u003E9__22_0;
            Func<System.Collections.Generic.HashSet<Guid>> val;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              BaseBidirectionalMap<TSource>.\u003C\u003Ec.\u003C\u003E9__22_0 = val = (Func<System.Collections.Generic.HashSet<Guid>>) (() => new System.Collections.Generic.HashSet<Guid>());
            }
            else
              goto label_11;
label_10:
            ContextVars.GetOrAdd<System.Collections.Generic.HashSet<Guid>>(name, val).Add(metadata.ModuleUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 2 : 0;
            continue;
label_11:
            val = func;
            goto label_10;
          case 4:
            this.InternalMap(metadata, source, destination, mapperService);
            num = 6;
            continue;
          case 5:
            this.BeforeMap(source, destination, mapperService);
            num = 4;
            continue;
          case 6:
            this.CustomMap(source, destination);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
            continue;
          default:
            this.CustomBeforeMap(source, destination);
            num = 5;
            continue;
        }
      }
label_8:;
    }

    /// <inheritdoc />
    public void BeforeMapReverse(
      DataClass source,
      object destination,
      IInternalMapperService mapperService)
    {
    }

    /// <inheritdoc />
    public void MapReverse(
      DataClass source,
      object destination,
      IInternalMapperService mapperService)
    {
      int num1 = 1;
      DataClass source1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_29;
          default:
            source1 = source;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 2;
            continue;
        }
      }
label_29:
      return;
label_3:
      try
      {
        DataClassMetadata[] array = source1.GetIncludes(true).ToArray<DataClassMetadata>();
        DataClassMetadata metadata = ((IEnumerable<DataClassMetadata>) array).FirstOrDefault<DataClassMetadata>((Func<DataClassMetadata, bool>) (a => a.TypeRef == source1.TypeRef));
        if (metadata != null)
          this.MapReverse((ClassMetadata) metadata, source1, destination, mapperService);
        IEnumerator<DataClassMetadata> enumerator = ((IEnumerable<DataClassMetadata>) array).Except<DataClassMetadata>((IEnumerable<DataClassMetadata>) new DataClassMetadata[1]
        {
          metadata
        }).GetEnumerator();
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
          num2 = 1;
        switch (num2)
        {
          case 1:
            try
            {
label_10:
              if (enumerator.MoveNext())
                goto label_12;
              else
                goto label_11;
label_9:
              DataClassMetadata current;
              int num3;
              while (true)
              {
                IInternalMapperConfiguration mapper;
                switch (num3)
                {
                  case 1:
                  case 3:
                    goto label_10;
                  case 2:
                    mapper.MapReverse((ClassMetadata) current, source1, destination, mapperService);
                    num3 = 3;
                    continue;
                  case 4:
                    goto label_21;
                  case 5:
                    goto label_12;
                  case 6:
                    if (mapper != null)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 2 : 1;
                      continue;
                    }
                    break;
                  case 7:
                    mapper = mapperService.GetMapper(current.Uid);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 6 : 5;
                    continue;
                }
                this.InternalMapReverse((ClassMetadata) current, source1, destination, mapperService);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 1 : 1;
              }
label_21:
              break;
label_11:
              num3 = 4;
              goto label_9;
label_12:
              current = enumerator.Current;
              num3 = 7;
              goto label_9;
            }
            finally
            {
              int num4;
              if (enumerator == null)
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
              else
                goto label_23;
label_20:
              switch (num4)
              {
                case 1:
                  break;
                default:
              }
label_23:
              enumerator.Dispose();
              num4 = 2;
              goto label_20;
            }
        }
      }
      catch (Exception ex)
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
          num5 = 0;
        string message;
        while (true)
        {
          switch (num5)
          {
            case 1:
              Logger.Log.Error((object) message, ex);
              num5 = 2;
              continue;
            case 2:
              goto label_32;
            default:
              message = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218734050) + this.TypeRef + z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902021873) + this.SourceType.FullName;
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 1;
              continue;
          }
        }
label_32:
        throw new Exception(message, ex);
      }
    }

    /// <inheritdoc />
    public void MapReverse(
      ClassMetadata metadata,
      DataClass source,
      object destination,
      IInternalMapperService mapperService)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.CustomMapReverse(source, destination);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          case 2:
            this.CustomBeforeMapReverse(source, destination);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 5 : 5;
            continue;
          case 3:
            this.ConfigureReverse();
            num = 2;
            continue;
          case 4:
            this.InternalMapReverse(metadata, source, destination, mapperService);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
            continue;
          case 5:
            this.BeforeMapReverse(source, destination, mapperService);
            num = 4;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    private void InternalMap(
      ClassMetadata metadata,
      object source,
      DataClass destination,
      IInternalMapperService mapperService)
    {
      int num1 = 1;
      List<PropertyMetadata>.Enumerator enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator1 = metadata.Properties.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_115;
          default:
            goto label_2;
        }
      }
label_115:
      return;
label_2:
      try
      {
label_16:
        if (enumerator1.MoveNext())
          goto label_6;
        else
          goto label_17;
label_5:
        PropertyMetadata current1;
        object obj1;
        int num2;
        while (true)
        {
          int num3;
          object instance1;
          Type propertyType1;
          IList instance2;
          object obj2;
          Type propertyType2;
          Type genericArgument;
          System.Reflection.PropertyInfo property;
          Type propertyType3;
          IList list;
          PropertyMap propertyMap;
          IEnumerator enumerator2;
          Guid simpleTypeUid;
          IRuntimeTypeDescriptor typeDescriptor1;
          Type runtimeType;
          switch (num2)
          {
            case 1:
              propertyType3 = destination.GetProperty(metadata, current1).PropertyType;
              num2 = 37;
              continue;
            case 2:
              if (!property.CanRead)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 3 : 6;
                continue;
              }
              goto case 43;
            case 3:
label_15:
              obj1 = (object) instance2;
              num2 = 34;
              continue;
            case 4:
              typeDescriptor1 = (IRuntimeTypeDescriptor) MetadataServiceContext.Service.GetTypeDescriptor(simpleTypeUid, Guid.Empty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 27 : 22;
              continue;
            case 5:
            case 31:
              obj1 = instance1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 10 : 24;
              continue;
            case 7:
            case 10:
            case 11:
            case 18:
            case 20:
            case 24:
            case 34:
label_9:
              num2 = 16;
              continue;
            case 8:
              list = (IList) destination.GetObject(metadata.Uid, current1.Uid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 8 : 42;
              continue;
            case 9:
              try
              {
                TypeConverter converter = ElmaTypeDescriptorHelper.GetConverter(propertyType1);
                int num4 = 2;
                while (true)
                {
                  ITypeConverter typeConverter;
                  object obj3;
                  switch (num4)
                  {
                    case 1:
                      obj3 = typeConverter.ConvertTo(obj2, runtimeType);
                      break;
                    case 2:
                      if (!converter.CanConvertTo(runtimeType))
                      {
                        num4 = 5;
                        continue;
                      }
                      goto case 7;
                    case 3:
                    case 5:
                      typeConverter = BaseBidirectionalMapStatics.TypeConverters.Find((Predicate<ITypeConverter>) (a => a.CanConvertTo(runtimeType)));
                      num4 = 6;
                      continue;
                    case 6:
                      if (typeConverter != null)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 1;
                        continue;
                      }
                      goto case 8;
                    case 7:
                      obj1 = converter.ConvertTo(obj2, runtimeType);
                      num4 = 4;
                      continue;
                    case 8:
                      obj3 = runtimeType.DefaultValue();
                      break;
                    default:
                      goto label_9;
                  }
                  obj1 = obj3;
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
                }
              }
              catch (Exception ex)
              {
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                    throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153917381), (object) metadata.FullTypeName, (object) metadata.Uid, (object) current1.Name, (object) current1.Uid), ex);
                }
              }
            case 13:
label_79:
              obj1 = (object) list;
              num2 = 18;
              continue;
            case 14:
              propertyMap = this.FindPropertyMap(current1.Name);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 45 : 26;
              continue;
            case 15:
              if (current1.SubTypeUid != Guid.Empty)
              {
                num2 = 44;
                continue;
              }
              goto case 35;
            case 16:
              goto label_46;
            case 17:
            case 29:
              genericArgument = propertyType2.GetGenericArguments()[0];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 8 : 8;
              continue;
            case 19:
              obj1 = BaseBidirectionalMap<TSource>.MapToDataClass(obj2, current1.SubTypeUid, mapperService, (DataClass) instance1).As(propertyType2);
              num2 = 11;
              continue;
            case 21:
              if (!(obj1.GetType() != propertyType1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 10 : 0;
                continue;
              }
              goto case 33;
            case 22:
              num2 = 32;
              continue;
            case 25:
              obj1 = obj2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 4 : 15;
              continue;
            case 26:
              goto label_6;
            case 27:
              instance2 = (IList) Activator.CreateInstance(typeof (List<>).MakeGenericType(typeDescriptor1.RuntimeType));
              num2 = 49;
              continue;
            case 28:
              goto label_111;
            case 30:
              if (current1.Settings is DataClassSettings settings)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 39 : 52;
                continue;
              }
              goto case 7;
            case 32:
              Type type = typeDescriptor2.RuntimeType;
              if ((object) type == null)
                type = obj2.GetType();
              runtimeType = type;
              num3 = 38;
              break;
            case 33:
              simpleTypeUid = ((ListOfSimpleTypeSettings) current1.Settings).SimpleTypeUid;
              num2 = 4;
              continue;
            case 35:
              if (obj1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 4 : 39;
                continue;
              }
              goto case 1;
            case 36:
              if (runtimeType != propertyType1.GetNonNullableType())
              {
                num2 = 9;
                continue;
              }
              goto case 7;
            case 37:
              if (instance1 != null)
              {
                num2 = 5;
                continue;
              }
              goto case 54;
            case 38:
              if (typeDescriptor2 == null)
              {
                num3 = 7;
                break;
              }
              goto case 55;
            case 39:
              propertyType1 = property.PropertyType;
              num2 = 41;
              continue;
            case 40:
              property = propertyMap.Property;
              num2 = 2;
              continue;
            case 41:
              if (!(MetadataServiceContext.Service.GetTypeDescriptor(current1.TypeUid, current1.SubTypeUid) is IRuntimeTypeDescriptor typeDescriptor2))
              {
                num2 = 20;
                continue;
              }
              goto case 51;
            case 42:
              enumerator2 = ((IEnumerable) obj2).GetEnumerator();
              num3 = 47;
              break;
            case 43:
              instance1 = destination.GetObject(metadata.Uid, current1.Uid);
              num2 = 50;
              continue;
            case 44:
              if (obj2 == null)
              {
                num2 = 23;
                continue;
              }
              goto case 30;
            case 45:
              if (propertyMap == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                continue;
              }
              goto case 48;
            case 46:
              try
              {
label_97:
                if (enumerator2.MoveNext())
                  goto label_99;
                else
                  goto label_98;
label_96:
                object current2;
                int num6;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_99;
                    case 2:
                      goto label_97;
                    case 3:
                      instance2.Add(current2);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 2 : 1;
                      continue;
                    default:
                      goto label_15;
                  }
                }
label_98:
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
                goto label_96;
label_99:
                current2 = enumerator2.Current;
                num6 = 3;
                goto label_96;
              }
              finally
              {
                IDisposable disposable = enumerator2 as IDisposable;
                int num7 = 2;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      disposable.Dispose();
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
                      continue;
                    case 2:
                      if (disposable != null)
                      {
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 1;
                        continue;
                      }
                      goto label_106;
                    default:
                      goto label_106;
                  }
                }
label_106:;
              }
            case 47:
              try
              {
label_83:
                if (enumerator2.MoveNext())
                  goto label_85;
                else
                  goto label_84;
label_82:
                object current3;
                int num8;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      goto label_85;
                    case 2:
                      goto label_83;
                    case 3:
                      list.Add(current3 != null ? BaseBidirectionalMap<TSource>.MapToDataClass(current3, current1.SubTypeUid, mapperService).As(genericArgument) : (object) null);
                      num8 = 2;
                      continue;
                    default:
                      goto label_79;
                  }
                }
label_84:
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                goto label_82;
label_85:
                current3 = enumerator2.Current;
                num8 = 3;
                goto label_82;
              }
              finally
              {
                IDisposable disposable = enumerator2 as IDisposable;
                int num9 = 2;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      disposable.Dispose();
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      if (disposable != null)
                      {
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 1;
                        continue;
                      }
                      goto label_92;
                    default:
                      goto label_92;
                  }
                }
label_92:;
              }
            case 48:
              if (!propertyMap.Ignored)
              {
                num2 = 40;
                continue;
              }
              goto label_16;
            case 49:
              enumerator2 = ((IEnumerable) obj1).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 16 : 46;
              continue;
            case 50:
              obj2 = property.GetValue(source);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 6 : 25;
              continue;
            case 51:
              if (typeDescriptor2 is ListOfSimpleTypeDescriptor)
              {
                num3 = 21;
                break;
              }
              goto case 22;
            case 52:
              propertyType2 = destination.GetProperty(metadata, current1).PropertyType;
              num2 = 53;
              continue;
            case 53:
              if (settings.RelationType != RelationType.OneToOne)
              {
                num2 = 17;
                continue;
              }
              goto case 19;
            case 54:
              if (propertyType3.IsAssignableFromNull())
              {
                num3 = 31;
                break;
              }
              goto label_16;
            case 55:
              if (runtimeType != (Type) null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 36 : 36;
                continue;
              }
              goto case 7;
            default:
              goto label_16;
          }
          num2 = num3;
        }
label_111:
        return;
label_46:
        try
        {
          destination.SetObject(metadata.Uid, current1.Uid, obj1);
          int num10 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
            num10 = 0;
          switch (num10)
          {
            default:
              goto label_16;
          }
        }
        catch (Exception ex)
        {
          int num11 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
            num11 = 0;
          switch (num11)
          {
            default:
              throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408861508), (object) metadata.FullTypeName, (object) metadata.Uid, (object) current1.Name, (object) current1.Uid), ex);
          }
        }
label_6:
        current1 = enumerator1.Current;
        num2 = 14;
        goto label_5;
label_17:
        num2 = 28;
        goto label_5;
      }
      finally
      {
        enumerator1.Dispose();
        int num12 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
          num12 = 0;
        switch (num12)
        {
          default:
        }
      }
    }

    private void InternalMapReverse(
      ClassMetadata metadata,
      DataClass source,
      object destination,
      IInternalMapperService mapperService)
    {
      int num1 = 1;
      List<PropertyMetadata>.Enumerator enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator1 = metadata.Properties.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_187;
          default:
            goto label_2;
        }
      }
label_187:
      return;
label_2:
      try
      {
label_173:
        if (enumerator1.MoveNext())
          goto label_38;
        else
          goto label_174;
label_4:
        int num2;
        int num3 = num2;
label_5:
        System.Reflection.PropertyInfo property;
        Type propertyType;
        PropertyMetadata current1;
        object obj1;
        List<object> objectList;
        Type elementType;
        Array instance1;
        TypeConverter converter;
        while (true)
        {
          Type type1;
          IList list;
          object obj2;
          IEnumerator enumerator2;
          UntypedISetProxy untypedIsetProxy1;
          Array instance2;
          int index1;
          int length;
          PropertyMap propertyMapReverse;
          List<object>.Enumerator enumerator3;
          int index2;
          object[] array;
          object instance3;
          IList instance4;
          Type itemSimpleType;
          int index3;
          Type type2;
          UntypedISetProxy untypedIsetProxy2;
          switch (num3)
          {
            case 1:
              if (current1.SubTypeUid != Guid.Empty)
              {
                num3 = 57;
                continue;
              }
              goto case 76;
            case 2:
            case 64:
              goto label_173;
            case 3:
              array = ((IEnumerable) obj1).Cast<object>().ToArray<object>();
              num3 = 98;
              continue;
            case 4:
            case 79:
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 60 : 15;
              continue;
            case 5:
              enumerator3 = objectList.GetEnumerator();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 22 : 18;
              continue;
            case 6:
              if (!propertyType.IsArray)
              {
                num3 = 17;
                continue;
              }
              goto case 97;
            case 7:
              num3 = 26;
              continue;
            case 8:
              goto label_154;
            case 9:
            case 65:
            case 69:
              instance4 = (IList) Activator.CreateInstance(propertyType);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 20 : 84;
              continue;
            case 10:
              goto label_47;
            case 11:
              list = (IList) new List<object>();
              num3 = 94;
              continue;
            case 12:
            case 46:
              if (index3 >= objectList.Count)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 21 : 51;
                continue;
              }
              goto case 15;
            case 13:
            case 63:
              if (index1 >= length)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 54 : 9;
                continue;
              }
              goto case 92;
            case 14:
              if (settings.RelationType == RelationType.OneToOne)
              {
                num3 = 25;
                continue;
              }
              goto case 19;
            case 15:
              ((IList) instance1)[index3] = objectList[index3];
              num3 = 35;
              continue;
            case 17:
            case 48:
              if (propertyType == TypeOf<object>.Raw)
                goto case 95;
              else
                goto label_163;
            case 18:
            case 40:
              obj1 = (object) list;
              num3 = 42;
              continue;
            case 19:
              elementType = EleWise.ELMA.Extensions.EnumerableExtensions.GetElementType(propertyType);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 51 : 56;
              continue;
            case 20:
              if (obj2 != null)
              {
                num3 = 14;
                continue;
              }
              goto label_173;
            case 21:
              obj1 = property.GetValue(destination);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 32 : 49;
              continue;
            case 22:
              try
              {
label_140:
                if (enumerator3.MoveNext())
                  goto label_139;
                else
                  goto label_141;
label_137:
                object current2;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_170;
                    case 2:
                      goto label_140;
                    case 3:
                      untypedIsetProxy1.Add(current2);
                      num4 = 2;
                      continue;
                    default:
                      goto label_139;
                  }
                }
label_139:
                current2 = enumerator3.Current;
                num4 = 3;
                goto label_137;
label_141:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
                goto label_137;
              }
              finally
              {
                enumerator3.Dispose();
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                }
              }
            case 23:
              propertyType = property.PropertyType;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 24 : 15;
              continue;
            case 24:
              obj2 = source.GetObject(metadata.Uid, current1.Uid);
              num3 = 83;
              continue;
            case 25:
              obj1 = BaseBidirectionalMap<TSource>.MapToClass((DataClass) obj2, property.PropertyType, mapperService, instance3);
              num3 = 80;
              continue;
            case 26:
              try
              {
                int num6;
                if (converter.CanConvertFrom(obj1.GetType()))
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 2;
                else
                  goto label_102;
label_101:
                object obj3;
                switch (num6)
                {
                  case 1:
                    break;
                  case 2:
                    obj3 = converter.ConvertFrom((ITypeDescriptorContext) null, CultureInfo.InvariantCulture, obj1);
                    goto label_104;
                  default:
                    goto label_170;
                }
label_102:
                obj3 = propertyType.DefaultValue();
label_104:
                obj1 = obj3;
                num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
                {
                  num6 = 0;
                  goto label_101;
                }
                else
                  goto label_101;
              }
              catch (Exception ex)
              {
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
                  num7 = 0;
                switch (num7)
                {
                  default:
                    throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405666139), (object) metadata.FullTypeName, (object) metadata.Uid, (object) current1.Name, (object) current1.Uid), ex);
                }
              }
            case 27:
              if (instance3 != null)
              {
                num3 = 100;
                continue;
              }
              goto label_57;
            case 28:
              if (property.DeclaringType.IsInterface)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 10 : 0;
                continue;
              }
              goto label_173;
            case 29:
              goto label_91;
            case 30:
              goto label_42;
            case 31:
              enumerator2 = ((IEnumerable) obj2).GetEnumerator();
              num3 = 93;
              continue;
            case 32:
              if (!(type1 != (Type) null))
              {
                num3 = 69;
                continue;
              }
              goto case 99;
            case 33:
              if (!(itemSimpleType == (Type) null))
              {
                num3 = 74;
                continue;
              }
              goto case 11;
            case 34:
label_148:
              if (!propertyType.IsGenericType)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 50 : 2;
                continue;
              }
              type2 = propertyType.GetGenericTypeDefinition();
              break;
            case 35:
              ++index3;
              num3 = 12;
              continue;
            case 36:
              index3 = 0;
              num3 = 46;
              continue;
            case 37:
              untypedIsetProxy2 = (UntypedISetProxy) null;
              goto label_180;
            case 38:
            case 66:
            case 94:
label_176:
              index2 = 0;
              num3 = 90;
              continue;
            case 39:
              property = propertyMapReverse.Property;
              num3 = 67;
              continue;
            case 41:
            case 100:
              obj1 = instance3;
              num3 = 81;
              continue;
            case 42:
            case 86:
              if (!propertyType.IsInstanceOfType(obj1))
              {
                num3 = 102;
                continue;
              }
              goto case 44;
            case 43:
              if (propertyType.IsArray)
              {
                num3 = 75;
                continue;
              }
              goto case 32;
            case 44:
            case 61:
            case 80:
            case 81:
label_170:
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 8 : 4;
              continue;
            case 45:
              if (untypedIsetProxy1 == null)
                goto case 44;
              else
                goto label_20;
            case 47:
              if (typeDescriptor is ListOfSimpleTypeDescriptor simpleTypeDescriptor)
              {
                num3 = 91;
                continue;
              }
              goto case 42;
            case 49:
              if (obj1 != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 33 : 103;
                continue;
              }
              goto case 37;
            case 50:
              type2 = (Type) null;
              break;
            case 51:
              obj1 = (object) instance1;
              num3 = 44;
              continue;
            case 52:
              index1 = 0;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 13 : 4;
              continue;
            case 53:
              goto label_57;
            case 54:
              list = (IList) instance2;
              num3 = 18;
              continue;
            case 55:
              ++index2;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 59 : 24;
              continue;
            case 56:
              objectList = new List<object>();
              num3 = 31;
              continue;
            case 57:
              if (current1.Settings is DataClassSettings settings)
              {
                num3 = 20;
                continue;
              }
              goto case 44;
            case 58:
              if (!(MetadataServiceContext.Service.GetTypeDescriptor(current1.TypeUid, current1.SubTypeUid) is IRuntimeTypeDescriptor typeDescriptor))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 6 : 86;
                continue;
              }
              goto case 47;
            case 59:
            case 90:
              if (index2 >= length)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 40 : 23;
                continue;
              }
              goto case 68;
            case 60:
              try
              {
                list = (IList) Activator.CreateInstance(propertyType);
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
                  num8 = 0;
                switch (num8)
                {
                  default:
                    goto label_176;
                }
              }
              catch (Exception ex)
              {
                int num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
                  num9 = 0;
                switch (num9)
                {
                  default:
                    throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1756901570), (object) metadata.FullTypeName, (object) metadata.Uid, (object) current1.Name, (object) current1.Uid), ex);
                }
              }
            case 62:
              ++index1;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 63 : 61;
              continue;
            case 67:
              if (!property.CanWrite)
              {
                num3 = 28;
                continue;
              }
              goto case 78;
            case 68:
              list.Add(array[index2]);
              num3 = 55;
              continue;
            case 70:
              if (property.CanWrite)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 78 : 30;
                continue;
              }
              goto label_173;
            case 71:
              try
              {
label_120:
                if (enumerator3.MoveNext())
                  goto label_123;
                else
                  goto label_121;
label_119:
                object current3;
                int num10;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                      instance4.Add(current3);
                      num10 = 3;
                      continue;
                    case 2:
                      goto label_123;
                    case 3:
                      goto label_120;
                    default:
                      goto label_48;
                  }
                }
label_121:
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
                goto label_119;
label_123:
                current3 = enumerator3.Current;
                num10 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
                {
                  num10 = 1;
                  goto label_119;
                }
                else
                  goto label_119;
              }
              finally
              {
                enumerator3.Dispose();
                int num11 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
                  num11 = 0;
                switch (num11)
                {
                  default:
                }
              }
            case 72:
label_48:
              obj1 = (object) instance4;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 17 : 61;
              continue;
            case 73:
              propertyMapReverse = this.FindPropertyMapReverse(current1.Name);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 104;
              continue;
            case 74:
            case 101:
              list = (IList) Activator.CreateInstance(typeof (List<>).MakeGenericType(itemSimpleType));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 19 : 66;
              continue;
            case 75:
            case 85:
              if (!(type1 == typeof (Iesi.Collections.Generic.ISet<>)))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                continue;
              }
              goto case 21;
            case 76:
              if (obj1 != null)
              {
                num3 = 58;
                continue;
              }
              goto case 27;
            case 77:
              goto label_38;
            case 78:
              instance3 = property.GetValue(destination);
              num3 = 23;
              continue;
            case 82:
              untypedIsetProxy1.Clear();
              num3 = 5;
              continue;
            case 83:
              obj1 = obj2;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
              continue;
            case 84:
              enumerator3 = objectList.GetEnumerator();
              num3 = 71;
              continue;
            case 87:
              goto label_183;
            case 88:
              if (!converter.CanConvertFrom(obj1.GetType()))
              {
                num3 = 30;
                continue;
              }
              goto case 7;
            case 89:
              if (!(property == (System.Reflection.PropertyInfo) null))
              {
                num3 = 70;
                continue;
              }
              goto label_173;
            case 91:
              if (obj1.GetType() != propertyType)
              {
                num3 = 3;
                continue;
              }
              goto case 42;
            case 92:
              instance2.SetValue(array[index1], index1);
              num3 = 62;
              continue;
            case 93:
              try
              {
label_70:
                if (enumerator2.MoveNext())
                  goto label_72;
                else
                  goto label_71;
label_69:
                object current4;
                int num12;
                while (true)
                {
                  switch (num12)
                  {
                    case 1:
                      goto label_70;
                    case 2:
                      goto label_148;
                    case 3:
                      goto label_72;
                    default:
                      objectList.Add(current4 != null ? BaseBidirectionalMap<TSource>.MapToClass((DataClass) current4, elementType, mapperService) : (object) null);
                      num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 1;
                      continue;
                  }
                }
label_71:
                num12 = 2;
                goto label_69;
label_72:
                current4 = enumerator2.Current;
                num12 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
                {
                  num12 = 0;
                  goto label_69;
                }
                else
                  goto label_69;
              }
              finally
              {
                IDisposable disposable = enumerator2 as IDisposable;
                int num13 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
                  num13 = 1;
                while (true)
                {
                  switch (num13)
                  {
                    case 1:
                      if (disposable == null)
                      {
                        num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
                        continue;
                      }
                      goto case 2;
                    case 2:
                      disposable.Dispose();
                      num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 3 : 0;
                      continue;
                    default:
                      goto label_81;
                  }
                }
label_81:;
              }
            case 95:
              itemSimpleType = simpleTypeDescriptor.GetItemSimpleType((IPropertyMetadata) current1);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 28 : 33;
              continue;
            case 96:
              if (!propertyMapReverse.Ignored)
              {
                num3 = 39;
                continue;
              }
              goto label_173;
            case 97:
              instance2 = Array.CreateInstance(propertyType.GetElementType(), length);
              num3 = 52;
              continue;
            case 98:
              length = array.Length;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 2 : 6;
              continue;
            case 99:
              if (!type1.IsInterface)
              {
                num3 = 9;
                continue;
              }
              goto case 75;
            case 102:
              goto label_147;
            case 103:
              untypedIsetProxy2 = obj1.AsUntypedISet();
              goto label_180;
            case 104:
              if (propertyMapReverse == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 2 : 0;
                continue;
              }
              goto case 96;
            default:
              goto label_94;
          }
          type1 = type2;
          num3 = 43;
          continue;
label_180:
          untypedIsetProxy1 = untypedIsetProxy2;
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 33 : 45;
        }
label_183:
        return;
label_20:
        num2 = 82;
        goto label_4;
label_42:
        string str;
        if (!(obj1 is IFormattable formattable))
        {
          num2 = 29;
          goto label_4;
        }
        else
        {
          str = formattable.ToString((string) null, (IFormatProvider) CultureInfo.InvariantCulture);
          goto label_182;
        }
label_47:
        property = destination.GetType().GetProperty(current1.Name);
        num2 = 89;
        goto label_4;
label_57:
        if (propertyType.IsAssignableFromNull())
        {
          num2 = 41;
          goto label_4;
        }
        else
          goto label_173;
label_91:
        str = obj1.ToString();
        goto label_182;
label_94:
        instance1 = Array.CreateInstance(elementType, objectList.Count);
        num2 = 36;
        goto label_4;
label_147:
        converter = System.ComponentModel.TypeDescriptor.GetConverter(propertyType);
        num2 = 88;
        goto label_4;
label_154:
        try
        {
          property.SetValue(destination, obj1);
          int num14 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
            num14 = 0;
          switch (num14)
          {
            default:
              goto label_173;
          }
        }
        catch (Exception ex)
        {
          int num15 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
            num15 = 0;
          switch (num15)
          {
            default:
              throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539336645), (object) metadata.FullTypeName, (object) metadata.Uid, (object) current1.Name, (object) current1.Uid), ex);
          }
        }
label_163:
        num2 = 79;
        goto label_4;
label_182:
        obj1 = (object) str;
        num2 = 7;
        goto label_4;
label_38:
        current1 = enumerator1.Current;
        num3 = 73;
        goto label_5;
label_174:
        num2 = 87;
        goto label_4;
      }
      finally
      {
        enumerator1.Dispose();
        int num16 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
          num16 = 0;
        switch (num16)
        {
          default:
        }
      }
    }

    /// <summary>Функция дополнительного маппинга в DTO</summary>
    internal Action<object, DataClass> CustomBeforeMap { get; set; }

    /// <summary>Функция дополнительного маппинга в DTO</summary>
    internal Action<object, DataClass> CustomMap { get; set; }

    /// <summary>Функция дополнительного маппинга в DTO</summary>
    internal Action<DataClass, object> CustomBeforeMapReverse { get; set; }

    /// <summary>Функция дополнительного маппинга в исходный тип</summary>
    internal Action<DataClass, object> CustomMapReverse { get; set; }

    /// <summary>Функции игнорирования свойств</summary>
    /// <param name="ignoreExpression">Выражение игнорирования свойства</param>
    internal void Ignore(Expression<Func<TSource, object>> ignoreExpression) => BaseBidirectionalMap<TSource>.Ignore((ICollection<Action<PropertyMap>>) this.PropertyMapActions, (ICollection<Expression<Func<TSource, object>>>) this.ignoreExpressions, ignoreExpression);

    /// <summary>Функции игнорирования свойств</summary>
    /// <param name="ignoreExpression">Выражение игнорирования свойства</param>
    internal void IgnoreReverse(Expression<Func<TSource, object>> ignoreExpression) => BaseBidirectionalMap<TSource>.Ignore((ICollection<Action<PropertyMap>>) this.PropertyMapActionsReverse, (ICollection<Expression<Func<TSource, object>>>) this.ignoreExpressionsReverse, ignoreExpression);

    private static void Ignore(
      ICollection<Action<PropertyMap>> actions,
      ICollection<Expression<Func<TSource, object>>> expressions,
      Expression<Func<TSource, object>> ignoreExpression)
    {
      actions.Add((Action<PropertyMap>) (pm =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              pm.Ignored = true;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      expressions.Add(ignoreExpression);
    }

    private void Configure()
    {
      int num1 = 5;
      BaseBidirectionalMap<TSource> bidirectionalMap;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_33;
          case 2:
            goto label_2;
          case 3:
            goto label_6;
          case 4:
            bidirectionalMap = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 5:
            if (!this.configured)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 4;
              continue;
            }
            goto label_21;
          default:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 2 : 3;
            continue;
        }
      }
label_33:
      return;
label_2:
      return;
label_21:
      return;
label_6:
      try
      {
        Monitor.Enter((object) bidirectionalMap, ref lockTaken);
        int num2 = 4;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_29;
            case 2:
label_22:
              this.configured = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 0;
              continue;
            case 3:
            case 5:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            case 4:
              if (!this.configured)
              {
                num2 = 3;
                continue;
              }
              goto label_24;
            case 6:
              goto label_23;
            default:
              try
              {
                BaseBidirectionalMap<TSource>.Config(this.propertyMaps, (IEnumerable<Expression<Func<TSource, object>>>) this.ignoreExpressions, new Func<string, PropertyMap>(this.FindPropertyMap), (ICollection<Action<PropertyMap>>) this.PropertyMapActions);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_22;
                }
              }
              catch (Exception ex)
              {
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
                  num4 = 0;
                string message;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      message = z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 88025639);
                      num4 = 2;
                      continue;
                    case 2:
                      Logger.Log.Error((object) message, ex);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_17;
                  }
                }
label_17:
                throw new Exception(message, ex);
              }
          }
        }
label_29:
        return;
label_23:
        return;
label_24:;
      }
      finally
      {
        if (lockTaken)
        {
          int num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                Monitor.Exit((object) bidirectionalMap);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                continue;
              default:
                goto label_31;
            }
          }
        }
label_31:;
      }
    }

    private void ConfigureReverse()
    {
      int num1 = 2;
      bool lockTaken;
      BaseBidirectionalMap<TSource> bidirectionalMap;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_32;
          case 1:
            bidirectionalMap = this;
            num1 = 4;
            continue;
          case 2:
            if (!this.configuredReverse)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
              continue;
            }
            goto label_30;
          case 3:
            goto label_7;
          case 4:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 3 : 3;
            continue;
          case 5:
            goto label_3;
          default:
            goto label_26;
        }
      }
label_32:
      return;
label_3:
      return;
label_26:
      return;
label_30:
      return;
label_7:
      try
      {
        Monitor.Enter((object) bidirectionalMap, ref lockTaken);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this.configuredReverse)
              {
                num2 = 4;
                continue;
              }
              goto case 2;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_22;
            case 4:
              goto label_18;
            case 5:
label_12:
              this.configuredReverse = true;
              num2 = 3;
              continue;
            default:
              try
              {
                BaseBidirectionalMap<TSource>.Config(this.propertyMapsReverse, (IEnumerable<Expression<Func<TSource, object>>>) this.ignoreExpressionsReverse, new Func<string, PropertyMap>(this.FindPropertyMapReverse), (ICollection<Action<PropertyMap>>) this.PropertyMapActionsReverse);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_12;
                }
              }
              catch (Exception ex)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
                  num4 = 0;
                string message;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      Logger.Log.Error((object) message, ex);
                      num4 = 2;
                      continue;
                    case 2:
                      goto label_25;
                    default:
                      message = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811925878);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
                      continue;
                  }
                }
label_25:
                throw new Exception(message, ex);
              }
          }
        }
label_22:
        return;
label_18:;
      }
      finally
      {
        int num5;
        if (!lockTaken)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 1;
        else
          goto label_31;
label_29:
        switch (num5)
        {
          case 1:
          case 2:
        }
label_31:
        Monitor.Exit((object) bidirectionalMap);
        num5 = 2;
        goto label_29;
      }
    }

    private static void Config(
      IDictionary<string, PropertyMap> propertyMaps,
      IEnumerable<Expression<Func<TSource, object>>> expressions,
      Func<string, PropertyMap> propertyMapFunc,
      ICollection<Action<PropertyMap>> actions)
    {
      foreach (System.Reflection.PropertyInfo reflectionProperty in InterfaceActivator.TypeOf<TSource>().GetReflectionProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
      {
        PropertyMap propertyMap = new PropertyMap(reflectionProperty);
        propertyMaps[reflectionProperty.Name] = propertyMap;
      }
      foreach (Expression<Func<TSource, object>> expression in expressions)
      {
        ReadOnlyCollection<ParameterExpression> parameters = expression.Parameters;
        if (parameters.Count == 1)
        {
          Expression body = expression.Body;
          if (!(body is MemberExpression memberExpression) && body is UnaryExpression unaryExpression && unaryExpression.NodeType == ExpressionType.Convert)
            memberExpression = unaryExpression.Operand as MemberExpression;
          if (memberExpression != null)
          {
            System.Reflection.PropertyInfo member = memberExpression.Member as System.Reflection.PropertyInfo;
            if (!(member == (System.Reflection.PropertyInfo) null) && !(member.DeclaringType == (Type) null))
            {
              if (!member.DeclaringType.IsAssignableFrom(parameters[0].Type))
                throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909341811), (object) member.Name, (object) parameters[0].Type, (object) member.DeclaringType));
              PropertyMap propertyMap = propertyMapFunc(member.Name);
              if (propertyMap != null)
                BaseBidirectionalMap<TSource>.Apply(propertyMap, (IEnumerable<Action<PropertyMap>>) actions);
            }
          }
        }
      }
    }

    private PropertyMap FindPropertyMap(string propertyName)
    {
      int num = 1;
      PropertyMap propertyMap;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.propertyMaps.TryGetValue(propertyName, out propertyMap);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return propertyMap;
    }

    private PropertyMap FindPropertyMapReverse(string propertyName)
    {
      int num = 1;
      PropertyMap propertyMapReverse;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.propertyMapsReverse.TryGetValue(propertyName, out propertyMapReverse);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return propertyMapReverse;
    }

    private static void Apply(PropertyMap propertyMap, IEnumerable<Action<PropertyMap>> actions)
    {
      foreach (Action<PropertyMap> action in actions)
        action(propertyMap);
    }

    /// <summary>Маппинг в DTO</summary>
    /// <param name="value">Значение</param>
    /// <param name="metadataUid">Уникальный идентификатор ожидаемых метаданных DTO</param>
    /// <param name="mapperService">Сервис маппинга</param>
    /// <param name="instance">Текущий экземпляр</param>
    /// <returns>DTO</returns>
    internal static DataClass MapToDataClass(
      object value,
      Guid metadataUid,
      IInternalMapperService mapperService,
      DataClass instance = null)
    {
      int num = 5;
      while (true)
      {
        object source;
        IInternalMapperConfiguration mapper;
        DataClass dataClass;
        switch (num)
        {
          case 1:
            mapper.Map(source, instance, mapperService);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 6 : 6;
            continue;
          case 2:
            dataClass = mapper.CreateDestinationInstance();
            break;
          case 3:
            mapper.BeforeMap(source, instance, mapperService);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
            continue;
          case 4:
            mapper = mapperService.GetMapper(source.GetType(), metadataUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
            continue;
          case 5:
            source = value.CastAsRealType();
            num = 4;
            continue;
          case 6:
            goto label_2;
          default:
            dataClass = instance;
            if ((object) dataClass == null)
            {
              num = 2;
              continue;
            }
            break;
        }
        instance = dataClass;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 3 : 3;
      }
label_2:
      return instance;
    }

    /// <summary>Маппинг в класс</summary>
    /// <param name="value">Значение</param>
    /// <param name="declaredSourceType">Объявленный тип свойства</param>
    /// <param name="mapperService">Сервис маппинга</param>
    /// <param name="instance">Текущий экземпляр</param>
    /// <returns>Значение</returns>
    internal static object MapToClass(
      DataClass value,
      Type declaredSourceType,
      IInternalMapperService mapperService,
      object instance = null)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        IInternalMapperConfiguration mapper;
        while (true)
        {
          switch (num2)
          {
            case 1:
              instance = instance.CastAsRealType();
              num2 = 2;
              continue;
            case 2:
            case 5:
              mapper.BeforeMapReverse(value, instance, mapperService);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 3 : 1;
              continue;
            case 3:
              mapper.MapReverse(value, instance, mapperService);
              num2 = 4;
              continue;
            case 4:
              goto label_8;
            case 7:
              if (instance == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 6 : 2;
                continue;
              }
              goto case 1;
            case 8:
              mapper = mapperService.GetMapper(value, declaredSourceType);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 7 : 6;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        instance = mapper.CreateSourceInstance(value);
        num1 = 5;
      }
label_8:
      return instance;
    }

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj is IInternalMapperConfiguration mapperConfiguration)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 2:
            goto label_6;
          case 3:
            goto label_7;
          default:
            if (!(mapperConfiguration.SourceType == this.SourceType))
            {
              num = 3;
              continue;
            }
            goto label_6;
        }
      }
label_6:
      return mapperConfiguration.TypeRef == this.TypeRef;
label_7:
      return false;
label_8:
      return base.Equals(obj);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
      int num = 1;
      (Type, string) valueTuple;
      while (true)
      {
        switch (num)
        {
          case 1:
            valueTuple = (this.SourceType, this.TypeRef);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return valueTuple.GetHashCode();
    }

    internal static bool nda5gph0WdDPQCSCMMtq() => BaseBidirectionalMap<TSource>.oQ2Ia4h0BrAvBHsLsRT5 == null;

    internal static object DuPLI5h0orHZDCaaYR0T() => BaseBidirectionalMap<TSource>.oQ2Ia4h0BrAvBHsLsRT5;
  }
}
