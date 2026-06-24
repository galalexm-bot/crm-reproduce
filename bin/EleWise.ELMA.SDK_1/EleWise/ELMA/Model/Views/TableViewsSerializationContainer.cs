// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.TableViewsSerializationContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Контейнер для сериализации списка настроек таблиц</summary>
  [Component]
  [Serializable]
  public class TableViewsSerializationContainer : IXsiRoot
  {
    private static TableViewsSerializationContainer JwOdH2o1K1OJSXKwMGjN;

    public TableViewsSerializationContainer()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.TableViews = new List<TableView>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public List<TableView> TableViews { get; set; }

    internal static bool zEf4Foo1XY68ldjDNLjf() => TableViewsSerializationContainer.JwOdH2o1K1OJSXKwMGjN == null;

    internal static TableViewsSerializationContainer XMCoOGo1ThxWuO3UEolk() => TableViewsSerializationContainer.JwOdH2o1K1OJSXKwMGjN;
  }
}
