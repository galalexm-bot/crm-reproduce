// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.DropDownItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Common
{
  /// <summary>Элемент выпадающего списка</summary>
  [TypeConverter(typeof (DropDownItemTypeConverter))]
  [Component]
  [Serializable]
  public class DropDownItem : IXsiType
  {
    private static DropDownItem GebeIrhK02YtVIhLqw9L;

    /// <summary>Создать</summary>
    public DropDownItem()
    {
      DropDownItem.s1LfInhKMKT2UnEhbqa0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Создать</summary>
    /// <param name="key">Ключ (идентификатор)</param>
    /// <param name="value">Значение (текст)</param>
    public DropDownItem(string key, string value)
    {
      DropDownItem.s1LfInhKMKT2UnEhbqa0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Value = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          case 2:
            this.Key = key;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Создать</summary>
    /// <param name="key">Ключ (идентификатор)</param>
    /// <param name="value">Значение (текст)</param>
    /// <param name="toolTipText">Текст подсказки</param>
    public DropDownItem(string key, string value, string toolTipTitle, string toolTipText)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        num1 = 0;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            this.ToolTip = toolTipText;
            num2 = 3;
            break;
          case 2:
            this.Value = value;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
            continue;
          case 3:
            this.ToolTipTitle = toolTipTitle;
            num2 = 4;
            break;
          case 4:
            goto label_4;
          default:
            this.Key = key;
            num1 = 2;
            continue;
        }
        num1 = num2;
      }
label_4:;
    }

    /// <summary>Создать из строкового представления</summary>
    /// <param name="stringValue">Строковое представление</param>
    public DropDownItem(string stringValue)
    {
      DropDownItem.s1LfInhKMKT2UnEhbqa0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 5;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_11;
          case 1:
            goto label_14;
          case 2:
            this.Value = stringValue;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_13;
          case 4:
            this.Value = "";
            num1 = 6;
            continue;
          case 5:
            this.Key = (string) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 2 : 4;
            continue;
          case 6:
            if (!DropDownItem.V2XlqfhKJVGFi0kEc4HC((object) stringValue))
            {
              num1 = 9;
              continue;
            }
            goto label_20;
          case 7:
            this.Value = stringValue;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 11 : 0;
            continue;
          case 8:
            if (num2 > 0)
            {
              this.Key = (string) DropDownItem.dUjXGVhKlj3kxeZ8Kvk2((object) stringValue, 1, num2 - 1);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 9 : 10;
              continue;
            }
            num1 = 7;
            continue;
          case 9:
            if (DropDownItem.SGSH2PhKdTpmi3LCTZ6Z((object) stringValue, DropDownItem.ijtCgjhK9K95JfLNPUTC(-244066886 - -48452443 ^ -195616023)))
            {
              num2 = stringValue.IndexOf('}');
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 8 : 1;
              continue;
            }
            num1 = 2;
            continue;
          case 10:
            this.Value = stringValue.Substring(num2 + 1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
            continue;
          case 11:
            goto label_7;
          default:
            goto label_2;
        }
      }
label_11:
      return;
label_14:
      return;
label_13:
      return;
label_7:
      return;
label_2:
      return;
label_20:;
    }

    /// <summary>Ключ (идентификатор)</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
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

    /// <summary>Значение (текст)</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
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

    /// <summary>Текст подсказки</summary>
    public string ToolTip
    {
      get => this.\u003CToolTip\u003Ek__BackingField;
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
              this.\u003CToolTip\u003Ek__BackingField = value;
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

    /// <summary>Заголовок подсказки</summary>
    public string ToolTipTitle
    {
      get => this.\u003CToolTipTitle\u003Ek__BackingField;
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
              this.\u003CToolTipTitle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
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

    /// <summary>Получить локализованное значение</summary>
    /// <returns></returns>
    public string GetLocalizedValue()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!string.IsNullOrEmpty(this.Key))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return this.Value;
label_5:
      return (string) DropDownItem.Q95Np8hKrkVpmJ8L1tWq((object) this.Value);
    }

    /// <summary>Данные</summary>
    [XmlIgnore]
    public object DataTag
    {
      get => this.\u003CDataTag\u003Ek__BackingField;
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
              this.\u003CDataTag\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
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

    /// <summary>Элемент в виде строки</summary>
    /// <returns>Строковое представление</returns>
    public override string ToString()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!DropDownItem.V2XlqfhKJVGFi0kEc4HC((object) this.Key))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      object obj = (object) string.Empty;
      goto label_6;
label_5:
      obj = DropDownItem.dWE5oRhKgr3LwDewch97(DropDownItem.ijtCgjhK9K95JfLNPUTC(~-397266137 ^ 397264676), (object) this.Key, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124639390));
label_6:
      string str1 = this.Value;
      string str2 = str1 == null ? string.Empty : str1;
      return (string) DropDownItem.n1GZ2XhK5YgfdMyLARW6(obj, (object) str2);
    }

    public override int GetHashCode() => this.ToString().GetHashCode();

    public override bool Equals(object obj)
    {
      int num = 1;
      string empty;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj != null)
            {
              empty = obj.ToString();
              if (empty == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 2 : 2;
                continue;
              }
              goto label_8;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
              continue;
            }
          case 2:
            goto label_7;
          default:
            goto label_2;
        }
      }
label_2:
      return false;
label_7:
      empty = string.Empty;
label_8:
      return DropDownItem.Df4dNAhKjn81yh1225MF((object) empty, (object) this.ToString());
    }

    internal static void s1LfInhKMKT2UnEhbqa0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool yade7vhKmSdnT58rk47T() => DropDownItem.GebeIrhK02YtVIhLqw9L == null;

    internal static DropDownItem QeT3dQhKyG3Cqlb50tcF() => DropDownItem.GebeIrhK02YtVIhLqw9L;

    internal static bool V2XlqfhKJVGFi0kEc4HC([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object ijtCgjhK9K95JfLNPUTC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool SGSH2PhKdTpmi3LCTZ6Z([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static object dUjXGVhKlj3kxeZ8Kvk2([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object Q95Np8hKrkVpmJ8L1tWq([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object dWE5oRhKgr3LwDewch97([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object n1GZ2XhK5YgfdMyLARW6([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool Df4dNAhKjn81yh1225MF([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);
  }
}
