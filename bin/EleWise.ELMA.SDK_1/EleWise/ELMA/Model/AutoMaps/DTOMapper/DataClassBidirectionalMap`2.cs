// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.DataClassBidirectionalMap`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System.Reflection;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper
{
  /// <summary>Маппер типа в структуру обмена данными</summary>
  /// <typeparam name="TSource">Тип объекта</typeparam>
  /// <typeparam name="TDestination">Тип структуры обмена данными</typeparam>
  public class DataClassBidirectionalMap<TSource, TDestination> : 
    BaseDataClassBidirectionalMap<TSource>,
    IMapperConfiguration
    where TSource : class
    where TDestination : DataClass, new()
  {
    private static object wrlbekh7L01XZ84dkGfL;

    public DataClassBidirectionalMap()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(DataClassBidirectionalMap<TSource, TDestination>.GetTypeRef());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Инициализация конфигуратора</summary>
    protected virtual void InitMap()
    {
    }

    /// <summary>Инициализация конфигуратора</summary>
    protected virtual void InitMapReverse()
    {
    }

    /// <summary>Функция перед маппингом в структуру обмена данными</summary>
    /// <param name="source">Экземпляр исходного типа</param>
    /// <param name="destination">Экземпляр структуры обмена данными</param>
    protected virtual void BeforeMap(TSource source, TDestination destination)
    {
    }

    /// <summary>
    /// Функция дополнительного маппинга в структуру обмена данными
    /// </summary>
    /// <param name="source">Экземпляр исходного типа</param>
    /// <param name="destination">Экземпляр структуры обмена данными</param>
    protected virtual void Map(TSource source, TDestination destination)
    {
    }

    /// <summary>
    /// Функция перед маппингом из структуры обмена данными в исходный тип
    /// </summary>
    /// <param name="source">Экземпляр исходного типа</param>
    /// <param name="destination">Экземпляр структуры обмена данными</param>
    protected virtual void BeforeMapReverse(TDestination source, TSource destination)
    {
    }

    /// <summary>
    /// Функция маппинга из структуры обмена данными в исходный тип
    /// </summary>
    /// <param name="source">Экземпляр структуры обмена данными</param>
    /// <param name="destination">Экземпляр исходного типа</param>
    protected virtual void MapReverse(TDestination source, TSource destination)
    {
    }

    /// <inheritdoc />
    internal override void BeforeMap(TSource source, DataClass destination) => this.BeforeMap(source, destination.As<TDestination>());

    /// <inheritdoc />
    internal override void Map(TSource source, DataClass destination) => this.Map(source, destination.As<TDestination>());

    /// <inheritdoc />
    internal override void BeforeMapReverse(DataClass source, TSource destination) => this.BeforeMapReverse(source.As<TDestination>(), destination);

    /// <inheritdoc />
    internal override void MapReverse(DataClass source, TSource destination) => this.MapReverse(source.As<TDestination>(), destination);

    /// <inheritdoc />
    void IMapperConfiguration.InitMap() => this.InitMap();

    /// <inheritdoc />
    void IMapperConfiguration.InitMapReverse() => this.InitMapReverse();

    private static string GetTypeRef() => DataClassMetadata.GetTypeRef(TypeOf<TDestination>.Raw);

    internal static bool SBBQaPh7UbLB7pHjjUj5() => DataClassBidirectionalMap<TSource, TDestination>.wrlbekh7L01XZ84dkGfL == null;

    internal static object elLPr8h7s6HhaOjWYifh() => DataClassBidirectionalMap<TSource, TDestination>.wrlbekh7L01XZ84dkGfL;
  }
}
