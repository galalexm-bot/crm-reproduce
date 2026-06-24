// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbox.AdditionalViewItemToolboxGroup
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views.Toolbox
{
  /// <summary>Группа общих элементов представления</summary>
  [Component(Order = 20)]
  public class AdditionalViewItemToolboxGroup : IViewItemToolboxGroup
  {
    public static readonly Guid UID;
    internal static AdditionalViewItemToolboxGroup F0IhekoptWZo8PD0eNoc;

    public Guid GroupUid => AdditionalViewItemToolboxGroup.UID;

    public Guid ParentGroupUid => Guid.Empty;

    public string Name => (string) AdditionalViewItemToolboxGroup.TVFQtHop6C5UH2hiS4G5((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173752731));

    public AdditionalViewItemToolboxGroup()
    {
      AdditionalViewItemToolboxGroup.Bunw9JopHqrhE1ebx2SZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static AdditionalViewItemToolboxGroup()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            AdditionalViewItemToolboxGroup.UID = new Guid((string) AdditionalViewItemToolboxGroup.NfupVTopAH6AXyv41l5P(-1638402543 ^ -1638556181));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
            continue;
          case 2:
            AdditionalViewItemToolboxGroup.Bunw9JopHqrhE1ebx2SZ();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object TVFQtHop6C5UH2hiS4G5([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool nClHQEopwrDE4Gcvdpoe() => AdditionalViewItemToolboxGroup.F0IhekoptWZo8PD0eNoc == null;

    internal static AdditionalViewItemToolboxGroup Q1pHkWop42YFu5yhZO0p() => AdditionalViewItemToolboxGroup.F0IhekoptWZo8PD0eNoc;

    internal static void Bunw9JopHqrhE1ebx2SZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object NfupVTopAH6AXyv41l5P(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
