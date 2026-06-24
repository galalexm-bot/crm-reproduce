// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.ServiceReference.HttpAuthenticationHeader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Scripts.ServiceReference
{
  /// <summary>Represents the WWW-Authenticate HTTP response header.</summary>
  public class HttpAuthenticationHeader
  {
    private string[] authenticationSchemes;
    internal static HttpAuthenticationHeader rZN5CDBcAWCO4hKjOvQs;

    /// <summary>Ctor</summary>
    /// <param name="headers">Заголовки запроса</param>
    public HttpAuthenticationHeader(WebHeaderCollection headers)
    {
      HttpAuthenticationHeader.tRM8BiBc0DfK92JTyENJ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.authenticationSchemes = (string[]) HttpAuthenticationHeader.wJhR7lBcm8yiwAEpPcw1((object) headers, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154047459));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override string ToString()
    {
      int num1 = 7;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        int index;
        string[] authenticationSchemes;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ++index;
              num2 = 5;
              continue;
            case 2:
            case 11:
              str = authenticationSchemes[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 8 : 9;
              continue;
            case 3:
              stringBuilder.Append(str);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            case 4:
            case 5:
              if (index < authenticationSchemes.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 11 : 6;
                continue;
              }
              goto label_10;
            case 6:
              goto label_9;
            case 7:
              if (this.HasAuthenticationSchemes)
              {
                num2 = 6;
                continue;
              }
              goto label_11;
            case 8:
              authenticationSchemes = this.authenticationSchemes;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 10 : 4;
              continue;
            case 9:
              stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597110764));
              num2 = 3;
              continue;
            case 10:
              index = 0;
              num2 = 4;
              continue;
            case 12:
              goto label_10;
            default:
              HttpAuthenticationHeader.IPAOcmBcyNUYhcKxXjec((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757140480));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 1;
              continue;
          }
        }
label_9:
        stringBuilder = new StringBuilder();
        num1 = 8;
      }
label_10:
      return stringBuilder.ToString();
label_11:
      return string.Empty;
    }

    /// <summary>Gets a comma separated list of authentication types.</summary>
    public string AuthenticationType
    {
      get
      {
        int num1 = 9;
        StringBuilder stringBuilder;
        int index;
        string str;
        int num2;
        int num3;
        while (true)
        {
          switch (num1)
          {
            case 1:
              stringBuilder = new StringBuilder();
              num1 = 10;
              continue;
            case 2:
            case 11:
              if (index >= this.authenticationSchemes.Length)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 6 : 2;
                continue;
              }
              goto case 16;
            case 3:
              str = (string) HttpAuthenticationHeader.rwguf6BcJ1E1B8vkPX5V((object) str, 0, num3);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
              continue;
            case 4:
              stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345432268));
              num1 = 15;
              continue;
            case 5:
              if (num3 > 0)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 3 : 3;
                continue;
              }
              goto default;
            case 6:
              goto label_2;
            case 7:
              num2 = 0;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 0;
              continue;
            case 8:
              goto label_3;
            case 9:
              if (!this.HasAuthenticationSchemes)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 8 : 7;
                continue;
              }
              goto case 7;
            case 10:
              index = 0;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 8 : 11;
              continue;
            case 12:
              ++index;
              num1 = 2;
              continue;
            case 13:
              num3 = HttpAuthenticationHeader.Vva59oBcMqvkJqhn3K1f((object) str, ' ');
              num1 = 5;
              continue;
            case 14:
              ++num2;
              num1 = 12;
              continue;
            case 15:
              stringBuilder.Append(str);
              num1 = 14;
              continue;
            case 16:
              str = this.authenticationSchemes[index];
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 13 : 12;
              continue;
            default:
              if (num2 > 0)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 4;
                continue;
              }
              goto case 15;
          }
        }
label_2:
        return stringBuilder.ToString();
label_3:
        return string.Empty;
      }
    }

    private bool HasAuthenticationSchemes
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (this.authenticationSchemes == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return this.authenticationSchemes.Length != 0;
label_5:
        return false;
      }
    }

    internal static void tRM8BiBc0DfK92JTyENJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object wJhR7lBcm8yiwAEpPcw1([In] object obj0, [In] object obj1) => (object) ((NameValueCollection) obj0).GetValues((string) obj1);

    internal static bool QlkbnMBc7Av7lbiu3VlI() => HttpAuthenticationHeader.rZN5CDBcAWCO4hKjOvQs == null;

    internal static HttpAuthenticationHeader bamH4FBcxjnWl6rqMBSh() => HttpAuthenticationHeader.rZN5CDBcAWCO4hKjOvQs;

    internal static object IPAOcmBcyNUYhcKxXjec([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static int Vva59oBcMqvkJqhn3K1f([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);

    internal static object rwguf6BcJ1E1B8vkPX5V([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);
  }
}
