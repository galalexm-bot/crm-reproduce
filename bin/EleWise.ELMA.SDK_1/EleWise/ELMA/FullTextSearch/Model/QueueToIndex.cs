// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.QueueToIndex
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <summary>
  /// Класс для передачи данных, подготавливаемых для индексирования
  /// </summary>
  public class QueueToIndex
  {
    /// <summary>Тип карточки</summary>
    public Type CardType;
    public long Id;
    public List<KeyValuePair<string, object>> Properties;
    public FieldIndexList DynamicProperties;
    private static QueueToIndex Qqc0DoGRcyB7o45YgwPX;

    public QueueToIndex()
    {
      QueueToIndex.zn9v8RGqB7Z376qV3wl2();
      this.Properties = new List<KeyValuePair<string, object>>();
      this.DynamicProperties = new FieldIndexList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void zn9v8RGqB7Z376qV3wl2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Tc24pDGRzi7oxwYUCbON() => QueueToIndex.Qqc0DoGRcyB7o45YgwPX == null;

    internal static QueueToIndex Ysf3w3GqFTh04QPNlPwd() => QueueToIndex.Qqc0DoGRcyB7o45YgwPX;
  }
}
