// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.PoLineDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Globalization
{
  /// <summary>Описание строки перевода</summary>
  [Serializable]
  public class PoLineDescriptor
  {
    private List<string> _keyWords;
    private List<string> _valueWords;
    private string _keyHash;
    internal static PoLineDescriptor zKpcp2GG0SVTKEfGARdM;

    public string Key
    {
      get => this.\u003CKey\u003Ek__BackingField;
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
              this.\u003CKey\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
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

    public string Value
    {
      get => this.\u003CValue\u003Ek__BackingField;
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
              this.\u003CValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
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

    public bool IsFuzzy
    {
      get => this.\u003CIsFuzzy\u003Ek__BackingField;
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
              this.\u003CIsFuzzy\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
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

    public bool IsLow
    {
      get => this.\u003CIsLow\u003Ek__BackingField;
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
              this.\u003CIsLow\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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

    public List<string> Comments { get; set; }

    public bool IsJsBlock
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.Comments == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              goto label_8;
          }
        }
label_4:
        List<string> comments = this.Comments;
        Func<string, bool> func = PoLineDescriptor.\u003C\u003Ec.\u003C\u003E9__21_0;
        Func<string, bool> predicate;
        if (func == null)
          PoLineDescriptor.\u003C\u003Ec.\u003C\u003E9__21_0 = predicate = (Func<string, bool>) (c => c.Contains((string) PoLineDescriptor.\u003C\u003Ec.McwwSAvgyRsJJwLUA4EU(1597012150 ^ 1597228632)));
        else
          goto label_5;
label_7:
        return comments.Any<string>(predicate);
label_5:
        predicate = func;
        goto label_7;
label_8:
        return false;
      }
    }

    public List<string> KeyWords
    {
      get
      {
        if (this._keyWords == null && !string.IsNullOrEmpty(this.Key))
          this._keyWords = ((IEnumerable<string>) LocalizationHolder.SplitByWords(this.Key)).ToList<string>();
        return this._keyWords ?? new List<string>();
      }
    }

    public List<string> ValueWords
    {
      get
      {
        if (this._valueWords == null && !string.IsNullOrEmpty(this.Value))
          this._valueWords = ((IEnumerable<string>) LocalizationHolder.SplitByWords(this.Value)).ToList<string>();
        return this._valueWords ?? new List<string>();
      }
    }

    public string KeyHash
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
            case 3:
              goto label_5;
            case 2:
              if (!PoLineDescriptor.ayHbaKGGMnKYg4ytEX6u((object) this._keyHash))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 1;
                continue;
              }
              break;
          }
          this._keyHash = (string) PoLineDescriptor.clCuaeGGJXXiZK77kanG((object) this.Key);
          num = 3;
        }
label_5:
        return this._keyHash;
      }
    }

    public PoLineDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Comments = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public void WriteToFile(StreamWriter sw)
    {
      int num1 = 6;
      List<string>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_17;
          case 2:
          case 3:
            if (this.IsLow)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            }
            goto case 8;
          case 4:
            sw.WriteLine((string) PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(1012087039 ^ 1011910347), this.Value != null ? PoLineDescriptor.F2KCFhGGrpZUSsCfF0Qf(PoLineDescriptor.iKEo02GGlscbnaPPFS2G(PoLineDescriptor.iKEo02GGlscbnaPPFS2G(PoLineDescriptor.iKEo02GGlscbnaPPFS2G((object) ((string) PoLineDescriptor.iKEo02GGlscbnaPPFS2G(PoLineDescriptor.iKEo02GGlscbnaPPFS2G((object) this.Value, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459555201), (object) ""), PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(-1426456882 ^ 2009939514 ^ -583737470), PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(1597012150 ^ 1597007768))).Replace((string) PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(-2092274397 << 4 ^ 883256336), (string) PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(-740338220 ^ -740341118)), PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(-1638402543 ^ -1638405707), PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(2008901894 << 3 ^ -1108650138)), PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(1917256330 ^ 1917107360), PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(1505778440 - 1981636111 ^ -475864161)), PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(1232639661 >> 3 ^ 154078591), PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(964881585 - -1459193222 ^ -1870893743))) : (object) "");
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 1;
            continue;
          case 5:
            try
            {
label_10:
              if (enumerator.MoveNext())
                goto label_13;
              else
                goto label_11;
label_9:
              string current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_10;
                  case 2:
                    PoLineDescriptor.KEdXOUGG9dZMGsZjNh9q((object) sw, (object) current);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 1;
                    continue;
                  case 3:
                    goto label_13;
                  default:
                    goto label_4;
                }
              }
label_11:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
              goto label_9;
label_13:
              current = enumerator.Current;
              num2 = 2;
              goto label_9;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 6:
            enumerator = this.Comments.GetEnumerator();
            num1 = 5;
            continue;
          case 7:
label_4:
            if (!this.IsFuzzy)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 3;
              continue;
            }
            goto case 9;
          case 8:
            PoLineDescriptor.Q9LhLFGGgVrKuuVE2cjL((object) sw, PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(-105199646 ^ -105285148), PoLineDescriptor.F2KCFhGGrpZUSsCfF0Qf(PoLineDescriptor.iKEo02GGlscbnaPPFS2G((object) ((string) PoLineDescriptor.iKEo02GGlscbnaPPFS2G(PoLineDescriptor.iKEo02GGlscbnaPPFS2G(PoLineDescriptor.iKEo02GGlscbnaPPFS2G((object) this.Key.Replace((string) PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(-787452571 ^ -787451333), ""), PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(-218496594 ^ -218489128), PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(1051276242 - 990076387 ^ 61196993)), PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(1917998801 >> 2 ^ 479669140), PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(-1426456882 ^ 2009939514 ^ -583737438)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921197977), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218968604))).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909331787), (string) PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(964881585 - -1459193222 ^ -1870893743)), PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(-342626196 - 1290888215 ^ -1633512449), PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(1113862659 ^ 1113861477))));
            num1 = 4;
            continue;
          case 9:
            PoLineDescriptor.KEdXOUGG9dZMGsZjNh9q((object) sw, PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(-630932142 - 1120244082 ^ -1751345662));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 2;
            continue;
          default:
            sw.WriteLine((string) PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(1033719030 - 2012070891 ^ -978569987));
            num1 = 8;
            continue;
        }
      }
label_17:;
    }

    private static string EscapeQuotes(object s)
    {
      int num1 = 8;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          int index;
          switch (num2)
          {
            case 1:
              if (PoLineDescriptor.pO1ZC0GGjxwt635RHDa1(s, index - 1) != '\\')
              {
                num2 = 9;
                continue;
              }
              goto case 6;
            case 2:
              goto label_4;
            case 3:
              index = 1;
              num2 = 12;
              continue;
            case 4:
            case 12:
              if (index < PoLineDescriptor.kxSIhqGG5J9SWAu8CdYL(s))
              {
                num2 = 14;
                continue;
              }
              goto label_4;
            case 5:
            case 14:
              if (PoLineDescriptor.pO1ZC0GGjxwt635RHDa1(s, index) == '"')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
                continue;
              }
              goto case 6;
            case 6:
              PoLineDescriptor.sepRErGGYY0gndfCbLkV((object) stringBuilder, ((string) s)[index]);
              num2 = 13;
              continue;
            case 7:
              goto label_13;
            case 8:
              if (PoLineDescriptor.kxSIhqGG5J9SWAu8CdYL(s) >= 1)
              {
                stringBuilder = new StringBuilder();
                num2 = 10;
                continue;
              }
              goto label_12;
            case 9:
              stringBuilder.Append((string) PoLineDescriptor.Nr3Z0tGGdlelTnH1pXUf(-1380439818 << 3 ^ 1841387718));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 6 : 6;
              continue;
            case 10:
              if (PoLineDescriptor.pO1ZC0GGjxwt635RHDa1(s, 0) == '"')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 7 : 11;
                continue;
              }
              break;
            case 11:
              stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583737470));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            case 13:
              ++index;
              num2 = 4;
              continue;
          }
          PoLineDescriptor.sepRErGGYY0gndfCbLkV((object) stringBuilder, PoLineDescriptor.pO1ZC0GGjxwt635RHDa1(s, 0));
          num2 = 3;
        }
label_12:
        num1 = 7;
      }
label_4:
      return stringBuilder.ToString();
label_13:
      return (string) s;
    }

    public override string ToString()
    {
      int num = 1;
      string key;
      while (true)
      {
        switch (num)
        {
          case 1:
            key = this.Key;
            if (key == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return key;
label_5:
      return base.ToString();
    }

    internal static bool vZXuIyGGmZNUTSeXOVFL() => PoLineDescriptor.zKpcp2GG0SVTKEfGARdM == null;

    internal static PoLineDescriptor CyDXt1GGyG1vPyYyaEdr() => PoLineDescriptor.zKpcp2GG0SVTKEfGARdM;

    internal static bool ayHbaKGGMnKYg4ytEX6u([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object clCuaeGGJXXiZK77kanG([In] object obj0) => (object) EncryptionHelper.GetMd5Hash((string) obj0);

    internal static void KEdXOUGG9dZMGsZjNh9q([In] object obj0, [In] object obj1) => ((TextWriter) obj0).WriteLine((string) obj1);

    internal static object Nr3Z0tGGdlelTnH1pXUf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object iKEo02GGlscbnaPPFS2G([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object F2KCFhGGrpZUSsCfF0Qf([In] object obj0) => (object) PoLineDescriptor.EscapeQuotes(obj0);

    internal static void Q9LhLFGGgVrKuuVE2cjL([In] object obj0, [In] object obj1, [In] object obj2) => ((TextWriter) obj0).WriteLine((string) obj1, obj2);

    internal static int kxSIhqGG5J9SWAu8CdYL([In] object obj0) => ((string) obj0).Length;

    internal static char pO1ZC0GGjxwt635RHDa1([In] object obj0, [In] int obj1) => ((string) obj0)[obj1];

    internal static object sepRErGGYY0gndfCbLkV([In] object obj0, [In] char obj1) => (object) ((StringBuilder) obj0).Append(obj1);
  }
}
