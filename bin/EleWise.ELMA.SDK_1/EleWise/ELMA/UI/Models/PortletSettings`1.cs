// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.PortletSettings`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models
{
  public abstract class PortletSettings<TId> : Entity<TId>, IPortletSettings, IEntity, IIdentified
  {
    private static object CLGiE0Bbkd4QYc1cE9as;

    protected PortletSettings()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool vsw0KCBbnTP66P9oDNP1() => PortletSettings<TId>.CLGiE0Bbkd4QYc1cE9as == null;

    internal static object yru8qiBbOvXIax4NYvwP() => PortletSettings<TId>.CLGiE0Bbkd4QYc1cE9as;
  }
}
