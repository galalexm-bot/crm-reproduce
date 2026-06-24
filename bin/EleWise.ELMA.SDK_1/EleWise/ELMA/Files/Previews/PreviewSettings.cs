// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.PreviewSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Настройка формирования превью</summary>
  public class PreviewSettings : GlobalSettingsBase
  {
    private List<CreatorInfo> _infos;
    private static PreviewSettings JFU79TGNGVNxNDpJ6iph;

    public PreviewSettings()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._infos = new List<CreatorInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    [HiddenInput(DisplayValue = false)]
    public List<CreatorInfo> Infos
    {
      get => this._infos;
      set => this._infos = value;
    }

    public string SerializedInfos
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this._infos == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return string.Empty;
label_5:
        return string.Join((string) PreviewSettings.DdYZY9GNQmNtIBN71idG(-1290212282 ^ -644262414 ^ 1786899816), this._infos.Select<CreatorInfo, string>((Func<CreatorInfo, string>) (v => ClassSerializationHelper.SerializeObjectByXml((object) v))));
      }
      set
      {
        int num = 1;
        string[] strArray;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (PreviewSettings.EkMQ8sGNCu7S9uSYGqrK((object) value))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
                continue;
              }
              strArray = (string[]) PreviewSettings.a4yXkCGNvT0BB9Raswf4((object) value, (object) new string[1]
              {
                (string) PreviewSettings.DdYZY9GNQmNtIBN71idG(-2138160520 ^ -2138171740)
              }, StringSplitOptions.RemoveEmptyEntries);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 4 : 0;
              continue;
            case 2:
              goto label_4;
            case 3:
              goto label_8;
            case 4:
              string[] source = strArray;
              Func<string, CreatorInfo> func = PreviewSettings.\u003C\u003Ec.\u003C\u003E9__6_0;
              Func<string, CreatorInfo> selector;
              if (func == null)
                PreviewSettings.\u003C\u003Ec.\u003C\u003E9__6_0 = selector = (Func<string, CreatorInfo>) (v => ClassSerializationHelper.DeserializeObjectByXml<CreatorInfo>(v));
              else
                goto label_11;
label_10:
              this._infos = ((IEnumerable<string>) source).Select<string, CreatorInfo>(selector).ToList<CreatorInfo>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 3;
              continue;
label_11:
              selector = func;
              goto label_10;
            default:
              this._infos = new List<CreatorInfo>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 2;
              continue;
          }
        }
label_4:
        return;
label_8:;
      }
    }

    public void InitInfos()
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        PreviewSettings previewSettings;
        List<IFilePreviewCreator> creators;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              this.Infos.RemoveAll((Predicate<CreatorInfo>) (i =>
              {
                int num3 = 2;
                CreatorInfo i1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      i1 = i;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 1;
                      continue;
                    default:
                      goto label_3;
                  }
                }
label_3:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return creators.All<IFilePreviewCreator>((Func<IFilePreviewCreator, bool>) (c => PreviewSettings.\u003C\u003Ec__DisplayClass7_2.VnFVdZ8FGL7g8J2Quiuw(PreviewSettings.\u003C\u003Ec__DisplayClass7_2.ac29ZC8FhauqRIWPo78y((object) c), i1.Uid)));
              }));
              num2 = 5;
              continue;
            case 4:
              creators = ((ComponentManager) PreviewSettings.NO2RtPGN8Us7UhJwGobs()).GetExtensionPoints<IFilePreviewCreator>().ToList<IFilePreviewCreator>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 2 : 2;
              continue;
            case 5:
              goto label_3;
            default:
              previewSettings = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 4 : 1;
              continue;
          }
        }
label_6:
        creators.ForEach((Action<IFilePreviewCreator>) (c =>
        {
          int num4 = 5;
          CreatorInfo creatorInfo1;
          IFilePreviewCreator c1;
          while (true)
          {
            switch (num4)
            {
              case 0:
                goto label_2;
              case 1:
                CreatorInfo creatorInfo2 = new CreatorInfo();
                creatorInfo2.Uid = c1.Uid;
                // ISSUE: reference to a compiler-generated method
                PreviewSettings.\u003C\u003Ec__DisplayClass7_0.qIOn2jvzYHuWTVJMsKFh((object) creatorInfo2, false);
                creatorInfo1 = creatorInfo2;
                num4 = 3;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (previewSettings.Infos.All<CreatorInfo>((Func<CreatorInfo, bool>) (i => PreviewSettings.\u003C\u003Ec__DisplayClass7_1.jj6FK88FFerPcLqggdxR(PreviewSettings.\u003C\u003Ec__DisplayClass7_1.aAqQa0vzzo3wWL30spjE((object) i), c1.Uid))))
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 1;
                  continue;
                }
                goto label_9;
              case 3:
                previewSettings.Infos.Add(creatorInfo1);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
                continue;
              case 4:
                c1 = c;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 2 : 1;
                continue;
              case 5:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 4 : 3;
                continue;
              default:
                goto label_10;
            }
          }
label_2:
          return;
label_10:
          return;
label_9:;
        }));
        num1 = 3;
      }
label_3:;
    }

    internal static bool PUP4ZhGNEyK6tZ1wWRw8() => PreviewSettings.JFU79TGNGVNxNDpJ6iph == null;

    internal static PreviewSettings T1VymdGNfCeNvouIuIbl() => PreviewSettings.JFU79TGNGVNxNDpJ6iph;

    internal static object DdYZY9GNQmNtIBN71idG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool EkMQ8sGNCu7S9uSYGqrK([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object a4yXkCGNvT0BB9Raswf4([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static object NO2RtPGN8Us7UhJwGobs() => (object) ComponentManager.Current;
  }
}
