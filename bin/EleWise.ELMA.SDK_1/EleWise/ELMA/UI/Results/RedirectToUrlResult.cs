// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Results.RedirectToUrlResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;
using System.Web.Routing;

namespace EleWise.ELMA.UI.Results
{
  /// <summary>Результат с перенаправлением на другой адрес</summary>
  public class RedirectToUrlResult : FormResult
  {
    private static RedirectToUrlResult CIBo3OyjLTTbrVkIV31;

    public RedirectToUrlResult(string url)
    {
      RedirectToUrlResult.PqM0CwyU4nxY20v55dA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Values = new RouteValueDictionary();
            num = 3;
            continue;
          case 2:
            this.Url = url;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            RedirectToUrlResult.xM6IMbyclwA6DHh31C8((object) url, RedirectToUrlResult.XfQKV4ysqwiN7l6ICkP(-2107978722 ^ -2108004784));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 0;
            continue;
        }
      }
label_3:;
    }

    public RedirectToUrlResult(string url, RouteValueDictionary values)
    {
      RedirectToUrlResult.PqM0CwyU4nxY20v55dA();
      // ISSUE: explicit constructor call
      this.\u002Ector(url);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Values = values;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Идентификатор страницы</summary>
    public string Url
    {
      get => this.\u003CUrl\u003Ek__BackingField;
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
              this.\u003CUrl\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
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

    /// <summary>Значения параметров страницы</summary>
    public RouteValueDictionary Values
    {
      get => this.\u003CValues\u003Ek__BackingField;
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
              this.\u003CValues\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
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

    internal static void PqM0CwyU4nxY20v55dA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object XfQKV4ysqwiN7l6ICkP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void xM6IMbyclwA6DHh31C8([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static bool JxNh2KyYPgBUutSCi7u() => RedirectToUrlResult.CIBo3OyjLTTbrVkIV31 == null;

    internal static RedirectToUrlResult Fft2bGyL1I5U4j8LYfF() => RedirectToUrlResult.CIBo3OyjLTTbrVkIV31;
  }
}
