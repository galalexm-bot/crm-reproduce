// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.ExtensionPoints.FullTextSearchObjectHandlerExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Model;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints
{
  /// <summary>
  /// Точка расширения обработчика объекта полнотекстового поиска (общий абстрактный класс)
  /// </summary>
  public abstract class FullTextSearchObjectHandlerExtension : IFullTextSearchObjectHandlerExtension
  {
    private static FullTextSearchObjectHandlerExtension PM4pfCGqnWYcdcbZ9OmS;

    /// <summary>Uid обработчика объекта</summary>
    public abstract Guid Uid { get; }

    /// <summary>Базовый тип карточки, поддерживаемой расширением</summary>
    public abstract Type SupportedCard { get; }

    /// <summary>
    /// Список uid'ов базовых сущностей поддерживаемых реализацией точки расширения
    /// </summary>
    public abstract List<Guid> SupportedUids { get; }

    /// <summary>
    /// Получение списка названий полей влияющих на статические поля индексированных данные
    /// </summary>
    public abstract List<string> GetImportantProperties { get; }

    public virtual List<string> GetVisualDataProperties => new List<string>();

    /// <summary>
    /// Получение данных, готовых к индексированию, из очереди полуфабрикатов
    /// </summary>
    public abstract List<QueueToIndex> ProcessingMergedIndexQueue(
      List<KeyValuePair<string, object>> mergedIndexQueueItem,
      long id,
      Guid typeUid);

    /// <summary>Обработка объекта при создании</summary>
    public virtual void OnInsertProcessing(Guid typeUid, object obj)
    {
    }

    /// <summary>Обработка объекта при удалении</summary>
    public virtual void OnDeleteProcessing(Guid typeUid, object obj)
    {
    }

    protected FullTextSearchObjectHandlerExtension()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool qo2mT8GqOJqnNkFpSABY() => FullTextSearchObjectHandlerExtension.PM4pfCGqnWYcdcbZ9OmS == null;

    internal static FullTextSearchObjectHandlerExtension doKPo4Gq2tqvGlBpw9Wx() => FullTextSearchObjectHandlerExtension.PM4pfCGqnWYcdcbZ9OmS;
  }
}
