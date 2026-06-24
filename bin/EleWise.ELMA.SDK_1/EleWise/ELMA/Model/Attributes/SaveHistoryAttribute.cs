// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.SaveHistoryAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут, указывающий, нужно ли хранить историю изменения сущности
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
  public class SaveHistoryAttribute : Attribute
  {
    private bool saveHistory;
    internal static SaveHistoryAttribute d7TlbIouwheXsjCdcx41;

    public SaveHistoryAttribute()
    {
      SaveHistoryAttribute.JAqiWgouHj4dkqK6CFWS();
      this.saveHistory = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public SaveHistoryAttribute(bool saveHistory)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.saveHistory = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.saveHistory = saveHistory;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public bool SaveHistory => this.saveHistory;

    internal static void JAqiWgouHj4dkqK6CFWS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool vQHxROou4MeVIguCFElw() => SaveHistoryAttribute.d7TlbIouwheXsjCdcx41 == null;

    internal static SaveHistoryAttribute N2wFj2ou6XE9fAFq0B5K() => SaveHistoryAttribute.d7TlbIouwheXsjCdcx41;
  }
}
