// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.BaseDataClassBidirectionalMap`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper
{
  /// <summary>Базовый конфигуратор маппера</summary>
  /// <typeparam name="TSource">Исходный тип</typeparam>
  public abstract class BaseDataClassBidirectionalMap<TSource> : IInternalMapperConfiguration
  {
    private readonly DefaultDataClassBidirectionalMap<TSource> mapper;
    internal static object QvfJRHh75d5e6ubvwfG4;

    /// <summary>Ctor</summary>
    protected BaseDataClassBidirectionalMap(string typeRef)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num1 = 2;
      string message;
      while (true)
      {
        switch (num1)
        {
          case 1:
            DefaultDataClassBidirectionalMap<TSource> bidirectionalMap = new DefaultDataClassBidirectionalMap<TSource>(typeRef);
            bidirectionalMap.CustomBeforeMap = (Action<object, DataClass>) ((src, dest) =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    this.BeforeMap((TSource) src, dest);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            });
            bidirectionalMap.CustomMap = (Action<object, DataClass>) ((src, dest) =>
            {
              int num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    this.Map((TSource) src, dest);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            });
            bidirectionalMap.CustomBeforeMapReverse = (Action<DataClass, object>) ((src, dest) =>
            {
              int num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    this.BeforeMapReverse(src, (TSource) dest);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            });
            bidirectionalMap.CustomMapReverse = (Action<DataClass, object>) ((src, dest) =>
            {
              int num5 = 1;
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    this.MapReverse(src, (TSource) dest);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            });
            this.mapper = bidirectionalMap;
            num1 = 5;
            continue;
          case 2:
            if (!string.IsNullOrWhiteSpace(typeRef))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
              continue;
            }
            goto case 4;
          case 3:
            goto label_5;
          case 4:
            message = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1766015236) + TypeOf<TSource>.FullName;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_4;
          default:
            Logger.Log.Error((object) message);
            num1 = 3;
            continue;
        }
      }
label_4:
      return;
label_5:
      throw new Exception(message);
    }

    /// <summary>Функция игнорирования свойств экземпляра</summary>
    /// <param name="ignoreExpression">Функция игнорирования свойств экземпляра</param>
    protected void Ignore(Expression<Func<TSource, object>> ignoreExpression) => this.mapper.Ignore(ignoreExpression);

    /// <summary>
    /// Функция игнорирования свойств экземпляра при маппинге обратно
    /// </summary>
    /// <param name="ignoreExpression">Функция игнорирования свойств экземпляра</param>
    protected void IgnoreReverse(Expression<Func<TSource, object>> ignoreExpression) => this.mapper.IgnoreReverse(ignoreExpression);

    /// <summary>Функция перед маппингом в структуру обмена данными</summary>
    /// <param name="source">Экземпляр исходного типа</param>
    /// <param name="destination">Экземпляр структуры обмена данными</param>
    internal abstract void BeforeMap(TSource source, DataClass destination);

    /// <summary>
    /// Функция дополнительного маппинга в структуру обмена данными
    /// </summary>
    /// <param name="source">Экземпляр исходного типа</param>
    /// <param name="destination">Экземпляр структуры обмена данными</param>
    internal abstract void Map(TSource source, DataClass destination);

    /// <summary>
    /// Функция перед маппингом из структуры обмена данными в исходный тип
    /// </summary>
    /// <param name="source">Экземпляр структуры обмена данными</param>
    /// <param name="destination">Экземпляр исходного типа</param>
    internal abstract void BeforeMapReverse(DataClass source, TSource destination);

    /// <summary>
    /// Функция маппинга из структуры обмена данными в исходный тип
    /// </summary>
    /// <param name="source">Экземпляр структуры обмена данными</param>
    /// <param name="destination">Экземпляр исходного типа</param>
    internal abstract void MapReverse(DataClass source, TSource destination);

    /// <inheritdoc />
    Type IInternalMapperConfiguration.SourceType => this.mapper.SourceType;

    /// <inheritdoc />
    string IInternalMapperConfiguration.TypeRef => this.mapper.TypeRef;

    /// <inheritdoc />
    object IInternalMapperConfiguration.CreateSourceInstance(DataClass dataClass) => this.mapper.CreateSourceInstance(dataClass);

    /// <inheritdoc />
    DataClass IInternalMapperConfiguration.CreateDestinationInstance() => this.mapper.CreateDestinationInstance();

    /// <inheritdoc />
    void IInternalMapperConfiguration.BeforeMap(
      object source,
      DataClass destination,
      IInternalMapperService mapperService)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.mapper.BeforeMap(source, destination, mapperService);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    void IInternalMapperConfiguration.Map(
      object source,
      DataClass destination,
      IInternalMapperService mapperService)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.mapper.Map(source, destination, mapperService);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    void IInternalMapperConfiguration.Map(
      ClassMetadata metadata,
      object source,
      DataClass destination,
      IInternalMapperService mapperService)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.mapper.Map(metadata, source, destination, mapperService);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    void IInternalMapperConfiguration.BeforeMapReverse(
      DataClass source,
      object destination,
      IInternalMapperService mapperService)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.mapper.BeforeMapReverse(source, destination, mapperService);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    void IInternalMapperConfiguration.MapReverse(
      DataClass source,
      object destination,
      IInternalMapperService mapperService)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.mapper.MapReverse(source, destination, mapperService);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    void IInternalMapperConfiguration.MapReverse(
      ClassMetadata metadata,
      DataClass source,
      object destination,
      IInternalMapperService mapperService)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.mapper.MapReverse(metadata, source, destination, mapperService);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static bool U2ZbE6h7jYF4UH2XJaYc() => BaseDataClassBidirectionalMap<TSource>.QvfJRHh75d5e6ubvwfG4 == null;

    internal static object fHJm8ih7Y81mEFcm1rvS() => BaseDataClassBidirectionalMap<TSource>.QvfJRHh75d5e6ubvwfG4;
  }
}
