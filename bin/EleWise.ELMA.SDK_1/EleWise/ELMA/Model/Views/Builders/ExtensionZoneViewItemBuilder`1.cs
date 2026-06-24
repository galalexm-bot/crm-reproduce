// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.ExtensionZoneViewItemBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders
{
  public class ExtensionZoneViewItemBuilder<TM> : 
    ViewItemBuilder<TM, ExtensionZoneViewItem, ExtensionZoneViewItemBuilder<TM>>
    where TM : IEntity
  {
    internal static object fsJSTEoD2D9bNVREbEZd;

    public ExtensionZoneViewItemBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal ExtensionZoneViewItemBuilder(string zoneId, ViewItemBuilder parentViewItemBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentViewItemBuilder);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ViewItem.ZoneId = zoneId;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public ExtensionZoneViewItemBuilder<TM> UseOriginalModel(bool useOriginalModel = true)
    {
      this.ViewItem.UseOriginalModel = useOriginalModel;
      return this;
    }

    internal static bool ioqKG4oDeBbrXhpAilv5() => ExtensionZoneViewItemBuilder<TM>.fsJSTEoD2D9bNVREbEZd == null;

    internal static object eLLFjPoDPc7cWZNhbRZr() => ExtensionZoneViewItemBuilder<TM>.fsJSTEoD2D9bNVREbEZd;
  }
}
