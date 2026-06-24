// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Results.RedirectToPageResult
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
  /// <summary>
  /// Результат с перенаправлением на другую страницу конфигурации
  /// </summary>
  public class RedirectToPageResult : FormResult
  {
    private static RedirectToPageResult ryLxRwyzcQLrhHCwtC6;

    public RedirectToPageResult(string pageId)
    {
      RedirectToPageResult.JQxPcIMWDNtWB1J4Fot();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.PageId = pageId;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          case 3:
            RedirectToPageResult.EDGF7mMolDX3qhBQueU((object) pageId, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420782722));
            num = 2;
            continue;
          default:
            this.Values = new RouteValueDictionary();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    public RedirectToPageResult(string pageId, RouteValueDictionary values)
    {
      RedirectToPageResult.JQxPcIMWDNtWB1J4Fot();
      // ISSUE: explicit constructor call
      this.\u002Ector(pageId);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Values = values;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Идентификатор страницы</summary>
    public string PageId
    {
      get => this.\u003CPageId\u003Ek__BackingField;
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
              this.\u003CPageId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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

    internal static void JQxPcIMWDNtWB1J4Fot() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void EDGF7mMolDX3qhBQueU([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static bool DpP1PGMFiOGP8G8TXW1() => RedirectToPageResult.ryLxRwyzcQLrhHCwtC6 == null;

    internal static RedirectToPageResult CFHnqfMBLM85IbUdLxj() => RedirectToPageResult.ryLxRwyzcQLrhHCwtC6;
  }
}
