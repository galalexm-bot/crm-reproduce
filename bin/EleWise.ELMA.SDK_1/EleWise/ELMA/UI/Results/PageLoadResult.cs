// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Results.PageLoadResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Results
{
  /// <summary>Загрузка текущей страницы</summary>
  public class PageLoadResult : FormResult
  {
    internal static PageLoadResult xa71HUym2dWBU3XIjlB;

    public PageLoadResult(IPageLoadViewModel viewModel)
    {
      PageLoadResult.NhrgfCyJ5pbMEuJkcHI();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ViewModel = viewModel;
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            PageLoadResult.j2qT5yydvHD6nsqxDeE((object) viewModel, PageLoadResult.sNhXRTy95OdO8CkBNu5(1304605005 ^ 1304566645));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Модель страницы</summary>
    public IPageLoadViewModel ViewModel
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
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

    internal static void NhrgfCyJ5pbMEuJkcHI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object sNhXRTy95OdO8CkBNu5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void j2qT5yydvHD6nsqxDeE([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool leyfhKyyM2GGJhWbCWF() => PageLoadResult.xa71HUym2dWBU3XIjlB == null;

    internal static PageLoadResult VGAy4lyMWOUEKp9dIaq() => PageLoadResult.xa71HUym2dWBU3XIjlB;
  }
}
