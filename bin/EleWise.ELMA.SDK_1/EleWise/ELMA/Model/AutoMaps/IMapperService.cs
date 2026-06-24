// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.IMapperService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.AutoMaps
{
  /// <summary>Сервис маппинга</summary>
  public interface IMapperService
  {
    /// <summary>Маппинг из одного типа в другой</summary>
    /// <typeparam name="TDestination">Тип назначение</typeparam>
    /// <param name="source">Экземпляр объекта, который необходимо смапить</param>
    /// <returns>Экземпляр нового объекта</returns>
    TDestination Map<TDestination>(object source) where TDestination : class;

    /// <summary>Маппинг из одного типа в другой</summary>
    /// <typeparam name="TSource">Тип источник</typeparam>
    /// <typeparam name="TDestination">Тип назначение</typeparam>
    /// <param name="source">Экземпляр объекта, который необходимо смапить</param>
    /// <returns>Экземпляр нового объекта</returns>
    TDestination Map<TSource, TDestination>(TSource source)
      where TSource : class
      where TDestination : class;

    /// <summary>Маппинг из одного типа в другой</summary>
    /// <typeparam name="TSource">Тип источник</typeparam>
    /// <typeparam name="TDestination">Тип назначение</typeparam>
    /// <param name="source">Экземпляр объекта, который необходимо смапить</param>
    /// <param name="destination">Экземпляр объекта, в который необходимо смапить</param>
    /// <returns>Экземпляр нового объекта</returns>
    TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
      where TSource : class
      where TDestination : class;
  }
}
