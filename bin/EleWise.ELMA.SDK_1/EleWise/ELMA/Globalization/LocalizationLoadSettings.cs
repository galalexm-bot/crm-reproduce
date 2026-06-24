// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.LocalizationLoadSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Globalization
{
  [Serializable]
  public class LocalizationLoadSettings
  {
    public SerializableDictionary<Guid, object> CustomSettings;
    private static LocalizationLoadSettings b6CUdVGbERqgInDxCBYA;

    /// <summary>Ctor</summary>
    public LocalizationLoadSettings()
    {
      LocalizationLoadSettings.SnKMaaGbChrOjQEeX3HC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.PrepareCustomSettings();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Папка для выгрузки</summary>
    public string Folder
    {
      get => this.\u003CFolder\u003Ek__BackingField;
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
              this.\u003CFolder\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
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

    private void PrepareCustomSettings()
    {
      int num1 = 3;
      IEnumerator<ILocalizationLoadCustomSettings> enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_28;
          case 2:
            enumerator1 = ((ComponentManager) LocalizationLoadSettings.I1GeEvGbvki2RNqKE25t()).GetExtensionPoints<ILocalizationLoadCustomSettings>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
            continue;
          case 3:
            this.CustomSettings = new SerializableDictionary<Guid, object>();
            num1 = 2;
            continue;
          default:
            goto label_4;
        }
      }
label_28:
      return;
label_4:
      try
      {
label_8:
        if (LocalizationLoadSettings.lGyfPZGb8CJn3JJpvHL4((object) enumerator1))
          goto label_7;
        else
          goto label_9;
label_6:
        Dictionary<Guid, object>.Enumerator enumerator2;
        int num2;
        switch (num2)
        {
          case 0:
            return;
          case 1:
            break;
          case 2:
            goto label_8;
          case 3:
            try
            {
label_16:
              if (enumerator2.MoveNext())
                goto label_14;
              else
                goto label_17;
label_11:
              KeyValuePair<Guid, object> current;
              int num3;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                  case 3:
                    goto label_16;
                  case 2:
                    goto label_8;
                  case 4:
                    this.CustomSettings.Add(current.Key, current.Value);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 2 : 3;
                    continue;
                  case 5:
                    if (this.CustomSettings.ContainsKey(current.Key))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 1;
                      continue;
                    }
                    goto case 4;
                  default:
                    goto label_14;
                }
              }
label_14:
              current = enumerator2.Current;
              num3 = 5;
              goto label_11;
label_17:
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 2;
              goto label_11;
            }
            finally
            {
              enumerator2.Dispose();
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
                num4 = 0;
              switch (num4)
              {
                default:
              }
            }
          default:
            return;
        }
label_7:
        enumerator2 = enumerator1.Current.GetNewSettingObj().GetEnumerator();
        num2 = 3;
        goto label_6;
label_9:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
        goto label_6;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_30;
              default:
                enumerator1.Dispose();
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_30:;
      }
    }

    internal static void SnKMaaGbChrOjQEeX3HC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool U5DIKKGbfYJfh6wsv0Ff() => LocalizationLoadSettings.b6CUdVGbERqgInDxCBYA == null;

    internal static LocalizationLoadSettings aFVmw0GbQwHMe7odlK7t() => LocalizationLoadSettings.b6CUdVGbERqgInDxCBYA;

    internal static object I1GeEvGbvki2RNqKE25t() => (object) ComponentManager.Current;

    internal static bool lGyfPZGb8CJn3JJpvHL4([In] object obj0) => ((IEnumerator) obj0).MoveNext();
  }
}
