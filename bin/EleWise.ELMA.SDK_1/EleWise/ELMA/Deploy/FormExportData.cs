// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.FormExportData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy
{
  public class FormExportData
  {
    internal static FormExportData c1gGNuEe8V0FqrjvKTMP;

    public string EntityName
    {
      get => this.\u003CEntityName\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CEntityName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public ICollection<FormViewItem> FormViewItems { get; set; }

    public ICollection<Pair<FormViewItemTransformation, FormViewItem>> FormViewItemTransformations { get; set; }

    public ICollection<FormView> FormViews { get; set; }

    public string ViewNamePrefix
    {
      get => this.\u003CViewNamePrefix\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CViewNamePrefix\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public FormExportData()
    {
      FormExportData.xa7qPFEeItHola1Qqmfr();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Y4ZXQSEeZZLHl1vB3Okg() => FormExportData.c1gGNuEe8V0FqrjvKTMP == null;

    internal static FormExportData G2NP36Eeuc6kZtyg7NDu() => FormExportData.c1gGNuEe8V0FqrjvKTMP;

    internal static void xa7qPFEeItHola1Qqmfr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
