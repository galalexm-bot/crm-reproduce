// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.ResourceString
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Globalization
{
  /// <summary>Строка из ресурсов</summary>
  [Serializable]
  public class ResourceString
  {
    private static ResourceString uqxawoGfKusVX92BrJwH;

    /// <summary>Имя сборки</summary>
    public string AssemblyName
    {
      get => this.\u003CAssemblyName\u003Ek__BackingField;
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
              this.\u003CAssemblyName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
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

    /// <summary>Namespace класса ресурсной строки</summary>
    public string Namespace
    {
      get => this.\u003CNamespace\u003Ek__BackingField;
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
              this.\u003CNamespace\u003Ek__BackingField = value;
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

    /// <summary>Имя класса</summary>
    public string ClassName
    {
      get => this.\u003CClassName\u003Ek__BackingField;
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
              this.\u003CClassName\u003Ek__BackingField = value;
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

    /// <summary>Имя ресурса</summary>
    public string ResourceName
    {
      get => this.\u003CResourceName\u003Ek__BackingField;
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
              this.\u003CResourceName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
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

    public ResourceString()
    {
      ResourceString.lbGhdLGfkfvQCtKAnHya();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Парсим входную строку и строим описание ресурсной строки
    /// </summary>
    /// <param name="val"></param>
    public void Parse(string val)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        string[] strArray1;
        string[] strArray2;
        List<string> values;
        string[] collection;
        bool flag;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_23;
            case 2:
              if (strArray2.Length <= 1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 24 : 5;
                continue;
              }
              goto case 16;
            case 3:
            case 8:
              this.ResourceName = val;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 4;
              continue;
            case 4:
              flag = false;
              num2 = 25;
              continue;
            case 5:
              if (!ResourceString.LHsbylGf2wM909MALXGt((object) val, ResourceString.bG8rReGfOGxnKGSwV1KH(1925118608 << 2 ^ -889472848)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 22 : 10;
                continue;
              }
              goto case 12;
            case 6:
              if (!ResourceString.xiDiNUGfniIj00fmaXIi((object) val))
              {
                num2 = 5;
                continue;
              }
              goto label_17;
            case 7:
              val = strArray1[0];
              num2 = 27;
              continue;
            case 9:
              goto label_28;
            case 10:
              goto label_10;
            case 11:
              if (collection.Length != 0)
              {
                num2 = 28;
                continue;
              }
              goto label_21;
            case 12:
              strArray2 = (string[]) ResourceString.TRcIMMGfe5cG9P0OlcNs((object) val, (object) new string[1]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710562758)
              }, StringSplitOptions.RemoveEmptyEntries);
              num2 = 2;
              continue;
            case 13:
              values = new List<string>((IEnumerable<string>) collection);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
              continue;
            case 14:
              val = strArray2[1];
              num2 = 18;
              continue;
            case 15:
              strArray1 = (string[]) ResourceString.TRcIMMGfe5cG9P0OlcNs((object) val, (object) new string[1]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837748423)
              }, StringSplitOptions.RemoveEmptyEntries);
              num2 = 19;
              continue;
            case 16:
              this.AssemblyName = strArray2[0];
              num2 = 14;
              continue;
            case 17:
              this.ClassName = val;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 9 : 7;
              continue;
            case 18:
            case 22:
            case 24:
              goto label_15;
            case 19:
              if (strArray1.Length > 1)
              {
                num2 = 7;
                continue;
              }
              goto case 21;
            case 20:
              collection = val.Split(new string[1]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852839744)
              }, StringSplitOptions.RemoveEmptyEntries);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 11 : 11;
              continue;
            case 21:
            case 25:
              if (val.Contains((string) ResourceString.bG8rReGfOGxnKGSwV1KH(-630932142 - 1120244082 ^ -1751174876)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 20 : 16;
                continue;
              }
              if (flag)
              {
                num2 = 17;
                continue;
              }
              goto label_26;
            case 23:
              if (!ResourceString.LHsbylGf2wM909MALXGt((object) val, ResourceString.bG8rReGfOGxnKGSwV1KH(-1380439818 << 3 ^ 1841305330)))
              {
                num2 = 8;
                continue;
              }
              goto case 15;
            case 26:
              this.Namespace = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138961604), (IEnumerable<string>) values);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
              continue;
            case 27:
              this.ResourceName = strArray1[1];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 12 : 21;
              continue;
            case 28:
              this.ClassName = collection[collection.Length - 1];
              num2 = 13;
              continue;
            default:
              ResourceString.EcDCa6GfPnouCM3lqmZ7((object) values, collection.Length - 1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 10 : 26;
              continue;
          }
        }
label_15:
        flag = true;
        num1 = 23;
      }
label_23:
      return;
label_28:
      return;
label_10:
      return;
label_26:
      return;
label_17:
      return;
label_21:;
    }

    /// <summary>Полное имя класса</summary>
    public string FullClassName => (string) ResourceString.U5d9MyGf1MNoL5GmZV9i(ResourceString.bG8rReGfOGxnKGSwV1KH(~-122002947 ^ 122101172), (object) this.Namespace, !ResourceString.xiDiNUGfniIj00fmaXIi((object) this.Namespace) ? ResourceString.bG8rReGfOGxnKGSwV1KH(-740338220 ^ -740339952) : (object) "", (object) this.ClassName);

    /// <summary>Значение по ресурсной строке</summary>
    public string Value
    {
      get
      {
        string str;
        switch (1)
        {
          case 1:
            try
            {
              PropertyInfo property = ResourceString.VDZ65iGf3LsywQJnDJAj((object) Assembly.Load((string) ResourceString.HiQDo7GfNKAZfia8bJB2((object) this.AssemblyName)), ResourceString.HiQDo7GfNKAZfia8bJB2((object) this.FullClassName)).GetProperty(this.ResourceName.Trim());
              int num = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
                num = 3;
              while (true)
              {
                switch (num)
                {
                  case 1:
                  case 2:
                    goto label_1;
                  case 3:
                    if (property != (PropertyInfo) null)
                    {
                      num = 4;
                      continue;
                    }
                    break;
                  case 4:
                    str = (string) ResourceString.OnLSkrGfpCJXlTrhR9KV((object) property, (object) null, (object) null);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 1;
                    continue;
                }
                str = "";
                num = 2;
              }
            }
            catch
            {
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
                num = 0;
              switch (num)
              {
                default:
                  throw;
              }
            }
        }
label_1:
        return str;
      }
    }

    internal static bool gimmCUGfXTfmAkTx6bRh() => ResourceString.uqxawoGfKusVX92BrJwH == null;

    internal static ResourceString qX4srSGfTWC9J9K4eYJN() => ResourceString.uqxawoGfKusVX92BrJwH;

    internal static void lbGhdLGfkfvQCtKAnHya() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xiDiNUGfniIj00fmaXIi([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object bG8rReGfOGxnKGSwV1KH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool LHsbylGf2wM909MALXGt([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static object TRcIMMGfe5cG9P0OlcNs([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static void EcDCa6GfPnouCM3lqmZ7([In] object obj0, [In] int obj1) => ((List<string>) obj0).RemoveAt(obj1);

    internal static object U5d9MyGf1MNoL5GmZV9i(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static object HiQDo7GfNKAZfia8bJB2([In] object obj0) => (object) ((string) obj0).Trim();

    internal static Type VDZ65iGf3LsywQJnDJAj([In] object obj0, [In] object obj1) => ((Assembly) obj0).GetReflectionType((string) obj1);

    internal static object OnLSkrGfpCJXlTrhR9KV([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);
  }
}
