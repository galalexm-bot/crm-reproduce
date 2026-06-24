// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbox.CommonViewItemToolboxGroup
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.Views.Toolbox
{
  /// <summary>Группа общих элементов представления</summary>
  [Component(Order = 10)]
  public class CommonViewItemToolboxGroup : IViewItemToolboxGroup
  {
    public static readonly Guid UID;
    internal static CommonViewItemToolboxGroup TExlphopmE3tMAbsITm0;

    public Guid GroupUid => CommonViewItemToolboxGroup.UID;

    public Guid ParentGroupUid => Guid.Empty;

    public string Name => EleWise.ELMA.SR.T((string) CommonViewItemToolboxGroup.wG6NOdopJPcplrioUKM1(1149433385 + 173655049 ^ 1323226744));

    public CommonViewItemToolboxGroup()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static CommonViewItemToolboxGroup()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            CommonViewItemToolboxGroup.WSmP6aop9o6w8gnMLjrr();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            CommonViewItemToolboxGroup.UID = new Guid((string) CommonViewItemToolboxGroup.wG6NOdopJPcplrioUKM1(1819636893 << 3 ^ 1672071350));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object wG6NOdopJPcplrioUKM1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool iyUyc9opyMR1Lbivojja() => CommonViewItemToolboxGroup.TExlphopmE3tMAbsITm0 == null;

    internal static CommonViewItemToolboxGroup I4e1u8opMlfabTwgiIEK() => CommonViewItemToolboxGroup.TExlphopmE3tMAbsITm0;

    internal static void WSmP6aop9o6w8gnMLjrr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
