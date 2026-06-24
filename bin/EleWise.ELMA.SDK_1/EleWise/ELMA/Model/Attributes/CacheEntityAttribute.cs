// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.CacheEntityAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут указывает, что сущность будет кешироваться при чтении и записи в базу данных
  /// </summary>
  public class CacheEntityAttribute : Attribute
  {
    private readonly bool enabled;
    internal static CacheEntityAttribute g8p5RqovdpoMsCMYtmWZ;

    /// <summary>Кешироване включено</summary>
    public CacheEntityAttribute()
    {
      CacheEntityAttribute.Sc95Nfovg5m0AsbidsGL();
      this.enabled = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="enabled">Включено ли кешироване</param>
    public CacheEntityAttribute(bool enabled)
    {
      CacheEntityAttribute.Sc95Nfovg5m0AsbidsGL();
      this.enabled = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.enabled = enabled;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Включено ли кешироване</summary>
    public bool Enabled => this.enabled;

    internal static void Sc95Nfovg5m0AsbidsGL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool tpeFpPovlg0RfG6fZRdV() => CacheEntityAttribute.g8p5RqovdpoMsCMYtmWZ == null;

    internal static CacheEntityAttribute aDBFfEovrGugNkGruLnb() => CacheEntityAttribute.g8p5RqovdpoMsCMYtmWZ;
  }
}
