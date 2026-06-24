// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.Analyzers.BaseViewItemAnalyzer`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Dependencies.Analyzers
{
  /// <summary>
  /// Базовый анализатор зависимостей в элементах представления
  /// </summary>
  /// <typeparam name="T"></typeparam>
  [Component]
  internal abstract class BaseViewItemAnalyzer<T> : IViewItemAnalyzer
  {
    private static object pF4BiIhRdR3RgkRkkgTb;

    /// <inheritdoc />
    public DependencyAnalysisResult Analyse(
      ClassMetadata contextMetadata,
      IMetadata metadata,
      FormViewItem form,
      DependencyServiceOptions options)
    {
      int num = 1;
      IEnumerable<T> viewItems;
      DependencyAnalysisResult dependencyAnalysisResult;
      while (true)
      {
        switch (num)
        {
          case 1:
            viewItems = form.FindItems(false, new Func<ViewItem, bool>(this.CheckViewItem)).Cast<T>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          default:
            dependencyAnalysisResult = this.ProcessViewItems(viewItems, contextMetadata, metadata, options);
            if (dependencyAnalysisResult == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 2;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return dependencyAnalysisResult;
label_6:
      return new DependencyAnalysisResult();
    }

    /// <summary>Проверить ViewItem</summary>
    /// <param name="viewItem">Элемент представления</param>
    /// <returns><c>true</c>, если подходит</returns>
    protected virtual bool CheckViewItem(ViewItem viewItem) => viewItem is T;

    /// <summary>
    /// Обработать подходящие по условию элементы представления
    /// </summary>
    /// <param name="viewItems">Элементы представления</param>
    /// <param name="contextMetadata">контекстные метаданные</param>
    /// <param name="metadata">метаданные</param>
    /// <param name="options">Настройки для анализа зависимостей</param>
    /// <returns>Результат анализа зависимостей</returns>
    protected abstract DependencyAnalysisResult ProcessViewItems(
      IEnumerable<T> viewItems,
      ClassMetadata contextMetadata,
      IMetadata metadata,
      DependencyServiceOptions options);

    protected BaseViewItemAnalyzer()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool IOBc3ehRlgn8TiPOCW1m() => BaseViewItemAnalyzer<T>.pF4BiIhRdR3RgkRkkgTb == null;

    internal static object qYdvFlhRrOLDRR006AIa() => BaseViewItemAnalyzer<T>.pF4BiIhRdR3RgkRkkgTb;
  }
}
