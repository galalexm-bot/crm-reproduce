// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Results.PortletContentLoadResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Results
{
  /// <summary>Загрузка содержимого текущего портлета</summary>
  public class PortletContentLoadResult : FormResult
  {
    internal static PortletContentLoadResult XkeNt9ylmukVf60ZSX7;

    public PortletContentLoadResult(IPortletContentLoadViewModel viewModel)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ViewModel = viewModel;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 2;
            continue;
          case 2:
            goto label_3;
          default:
            Contract.ArgumentNotNull((object) viewModel, (string) PortletContentLoadResult.IhHqL6y5yiceVS5PcSe(1242972401 >> 4 ^ 77712951));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Модель содержимого портлета</summary>
    public IPortletContentLoadViewModel ViewModel
    {
      get => this.\u003CViewModel\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CViewModel\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
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

    internal static object IhHqL6y5yiceVS5PcSe(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool fZrGgnyrvxm1W9mC1I6() => PortletContentLoadResult.XkeNt9ylmukVf60ZSX7 == null;

    internal static PortletContentLoadResult T3vpyoygy4N1A39J18h() => PortletContentLoadResult.XkeNt9ylmukVf60ZSX7;
  }
}
