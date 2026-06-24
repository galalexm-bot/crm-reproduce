// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.Block
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Globalization
{
  internal class Block
  {
    private int _msgidhash;
    private string _msgid;
    private static Block I02X3bGEOIxoti3YSvpk;

    public Block()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.MsgStr = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
            continue;
          case 3:
            this.MsgId = new List<string>();
            num = 2;
            continue;
          default:
            this.Comments = new List<string>();
            num = 3;
            continue;
        }
      }
label_3:;
    }

    public List<string> Comments { get; set; }

    public List<string> MsgId { get; set; }

    public List<string> MsgStr { get; set; }

    public int MsgIdHash => this._msgidhash;

    public bool IsJsBlock
    {
      get => this.\u003CIsJsBlock\u003Ek__BackingField;
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
              this.\u003CIsJsBlock\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
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

    public void MsgIdHashRecalc(string s)
    {
      int num1 = 3;
      int num2;
      int num3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this._msgidhash = this._msgid.GetHashCode();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 2 : 6;
            continue;
          case 2:
            num3 = s.LastIndexOf('"');
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          case 3:
            num2 = Block.tDRSxdGEPhfjlPk91ecd((object) s, '"');
            num1 = 2;
            continue;
          case 4:
            this._msgid += (string) Block.PRtolBGE1stu5TTOBhj9((object) s, num2 + 1, num3 - num2 - 1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 1;
            continue;
          case 5:
            num3 = s.Length - 1;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 4 : 4;
            continue;
          case 6:
            goto label_2;
          default:
            if (num2 == num3)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 3 : 5;
              continue;
            }
            goto case 4;
        }
      }
label_2:;
    }

    internal static bool vO7BcnGE2M2dlx7tnqV2() => Block.I02X3bGEOIxoti3YSvpk == null;

    internal static Block RUUTuTGEemnSiIpIgPAg() => Block.I02X3bGEOIxoti3YSvpk;

    internal static int tDRSxdGEPhfjlPk91ecd([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);

    internal static object PRtolBGE1stu5TTOBhj9([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);
  }
}
