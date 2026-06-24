// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.Services.TranslateBAConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.BPMApps.Services
{
  /// <summary>
  /// Точка расширения конвертации манифеста и настроек экспорта переводов
  /// </summary>
  [Component(Order = 2600)]
  internal class TranslateBAConverter : IBPMAppItemsConverter
  {
    private static readonly Guid _exportTranslatesUid;
    internal static TranslateBAConverter XQV1Y6fePEkEsr2F2ZqI;

    /// <inheritdoc />
    public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
    {
      int num = 1;
      TranslateExportSettings translateSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.CheckArguments(bpmAppManifest, settings);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 2:
            this.SetTranslateChapter(bpmAppManifest, translateSettings);
            num = 4;
            continue;
          case 3:
            if (translateSettings != null)
            {
              num = 6;
              continue;
            }
            goto label_2;
          case 4:
            goto label_10;
          case 5:
            goto label_5;
          case 6:
            TranslateBAConverter.B3JskVfepNnClcqPYej9((object) bpmAppManifest, TranslateBAConverter._exportTranslatesUid, TranslateBAConverter.cXCV2ufe3QUW8jZvUnBp((object) translateSettings));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 1;
            continue;
          default:
            translateSettings = this.GetTranslateSettings(settings);
            num = 3;
            continue;
        }
      }
label_10:
      return;
label_5:
      return;
label_2:;
    }

    /// <inheritdoc />
    public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.SetTranlateSettings(bpmAppManifest, settings);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
            continue;
          case 2:
            this.CheckArguments(bpmAppManifest, settings);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    private void SetTranslateChapter(
      BPMAppManifest bpmAppManifest,
      TranslateExportSettings settings)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        TranslatesBAChapter translatesBaChapter1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_16;
            case 2:
              TranslateBAConverter.Y1sumNfetWbWqxl8VH7a((object) bpmAppManifest, (object) translatesBaChapter1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
              continue;
            case 3:
              if (settings.ExportTranslate)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
                continue;
              }
              goto case 8;
            case 4:
              TranslatesBAChapter translatesBaChapter2 = new TranslatesBAChapter();
              TranslateBAConverter.wKUSpHfeaDFKLHvatQom((object) translatesBaChapter2, TranslateExportConst.ExportExtensionUid);
              translatesBaChapter1 = translatesBaChapter2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 3 : 2;
              continue;
            case 5:
              goto label_15;
            case 6:
              if (TranslateBAConverter.nlfuL2feD7tZAXIQFLJw((object) translatesBaChapter1.Translates) <= 0)
              {
                num2 = 9;
                continue;
              }
              goto case 2;
            case 7:
              goto label_12;
            case 8:
              if (translatesBaChapter1.Translates == null)
              {
                num2 = 7;
                continue;
              }
              goto case 6;
            case 9:
              goto label_9;
            default:
              if (settings.Translates == null)
                goto case 8;
              else
                goto label_8;
          }
        }
label_8:
        num1 = 5;
        continue;
label_15:
        TranslatesBAChapter translatesBaChapter3 = translatesBaChapter1;
        List<CultureInfo> translates = settings.Translates;
        // ISSUE: reference to a compiler-generated field
        Func<CultureInfo, TranslateBAItem> func = TranslateBAConverter.\u003C\u003Ec.\u003C\u003E9__3_0;
        Func<CultureInfo, TranslateBAItem> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          TranslateBAConverter.\u003C\u003Ec.\u003C\u003E9__3_0 = selector = (Func<CultureInfo, TranslateBAItem>) (c =>
          {
            TranslateBAItem translateBaItem = new TranslateBAItem();
            // ISSUE: reference to a compiler-generated method
            TranslateBAConverter.\u003C\u003Ec.vjjoUuZFS4WaguJEZDdh((object) translateBaItem, (object) c.NativeName);
            // ISSUE: reference to a compiler-generated method
            TranslateBAConverter.\u003C\u003Ec.kMrQuVZFiovmbm3iWHle((object) translateBaItem, (object) c.ToString());
            return translateBaItem;
          });
        }
        else
          goto label_19;
label_18:
        List<TranslateBAItem> list = translates.Select<CultureInfo, TranslateBAItem>(selector).ToList<TranslateBAItem>();
        translatesBaChapter3.Translates = list;
        num1 = 8;
        continue;
label_19:
        selector = func;
        goto label_18;
      }
label_16:
      return;
label_12:
      return;
label_9:;
    }

    private TranslateExportSettings GetTranslateSettings(ConfigExportSettings settings)
    {
      int num = 2;
      TranslateExportSettings translateSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            object obj;
            if (!settings.CustomSettings.TryGetValue(TranslateExportConst.ExportExtensionUid, out obj))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 1;
              continue;
            }
            translateSettings = obj as TranslateExportSettings;
            num = 4;
            continue;
          case 3:
            goto label_3;
          case 4:
            if (translateSettings != null)
            {
              num = 3;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (TranslateExportSettings) null;
label_3:
      return translateSettings;
label_8:
      return (TranslateExportSettings) null;
    }

    private void SetTranlateSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
    {
      int num = 1;
      TranslateExportSettings tranlateSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            tranlateSettings = this.GetTranlateSettings(bpmAppManifest);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            settings.CustomSettings[TranslateExportConst.ExportExtensionUid] = (object) tranlateSettings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    private TranslateExportSettings GetTranlateSettings(BPMAppManifest bpmAppManifest)
    {
      int num = 6;
      TranslateExportSettings tranlateSettings;
      while (true)
      {
        TranslatesBAChapter translatesBaChapter;
        switch (num)
        {
          case 1:
          case 4:
          case 8:
          case 11:
            goto label_9;
          case 2:
            if (translatesBaChapter.Translates == null)
            {
              num = 8;
              continue;
            }
            goto case 7;
          case 3:
            translatesBaChapter = TranslateBAConverter.fWXJE7fe6nRVHCDhkeIs((object) bpmAppManifest, TranslateExportConst.ExportExtensionUid) as TranslatesBAChapter;
            num = 10;
            continue;
          case 5:
            TranslateBAConverter.VImIj1fe4eY62gbeGRLX((object) tranlateSettings, TranslateBAConverter.jkDeBsfew6I8Hmh1b267((object) bpmAppManifest, TranslateBAConverter._exportTranslatesUid, TranslateBAConverter.cXCV2ufe3QUW8jZvUnBp((object) tranlateSettings)));
            num = 3;
            continue;
          case 6:
            tranlateSettings = new TranslateExportSettings();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 5 : 2;
            continue;
          case 7:
            if (translatesBaChapter.Translates.Count <= 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
              continue;
            }
            break;
          case 9:
            TranslateExportSettings translateExportSettings = tranlateSettings;
            List<TranslateBAItem> translates = translatesBaChapter.Translates;
            // ISSUE: reference to a compiler-generated field
            Func<TranslateBAItem, CultureInfo> func = TranslateBAConverter.\u003C\u003Ec.\u003C\u003E9__6_0;
            Func<TranslateBAItem, CultureInfo> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              TranslateBAConverter.\u003C\u003Ec.\u003C\u003E9__6_0 = selector = (Func<TranslateBAItem, CultureInfo>) (p => new CultureInfo((string) TranslateBAConverter.\u003C\u003Ec.PHSs81ZFR3QWNv11aAb7((object) p)));
            }
            else
              goto label_16;
label_15:
            List<CultureInfo> list = translates.Select<TranslateBAItem, CultureInfo>(selector).ToList<CultureInfo>();
            translateExportSettings.Translates = list;
            num = 4;
            continue;
label_16:
            selector = func;
            goto label_15;
          case 10:
            if (translatesBaChapter == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 4 : 11;
              continue;
            }
            goto case 2;
        }
        tranlateSettings.Translates = new List<CultureInfo>();
        num = 9;
      }
label_9:
      return tranlateSettings;
    }

    private void CheckArguments(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TranslateBAConverter.gnHVLGfeAgySIAkSl6LH((object) bpmAppManifest, TranslateBAConverter.XCGMWPfeHN7F2VNoVSnw(813604817 ^ 813422403));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            TranslateBAConverter.gnHVLGfeAgySIAkSl6LH((object) settings, TranslateBAConverter.XCGMWPfeHN7F2VNoVSnw(-1317790512 ^ -1317734818));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    public TranslateBAConverter()
    {
      TranslateBAConverter.OPT53mfe7B7xYq8uQkif();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static TranslateBAConverter()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TranslateBAConverter._exportTranslatesUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1406012633));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool cXCV2ufe3QUW8jZvUnBp([In] object obj0) => ((TranslateExportSettings) obj0).ExportTranslate;

    internal static void B3JskVfepNnClcqPYej9([In] object obj0, Guid uid, bool value) => ((BPMAppManifest) obj0).SetFlag(uid, value);

    internal static bool A3Ym20fe1cbbQYdT77YP() => TranslateBAConverter.XQV1Y6fePEkEsr2F2ZqI == null;

    internal static TranslateBAConverter yYaxgqfeNwxu8giLQeCK() => TranslateBAConverter.XQV1Y6fePEkEsr2F2ZqI;

    internal static void wKUSpHfeaDFKLHvatQom([In] object obj0, Guid value) => ((BPMAppManifestChapter) obj0).Uid = value;

    internal static int nlfuL2feD7tZAXIQFLJw([In] object obj0) => ((List<TranslateBAItem>) obj0).Count;

    internal static void Y1sumNfetWbWqxl8VH7a([In] object obj0, [In] object obj1) => ((BPMAppManifest) obj0).SetChapter((BPMAppManifestChapter) obj1);

    internal static bool jkDeBsfew6I8Hmh1b267([In] object obj0, Guid uid, bool defaultValue) => ((BPMAppManifest) obj0).GetFlag(uid, defaultValue);

    internal static void VImIj1fe4eY62gbeGRLX([In] object obj0, bool value) => ((TranslateExportSettings) obj0).ExportTranslate = value;

    internal static object fWXJE7fe6nRVHCDhkeIs([In] object obj0, Guid uid) => (object) ((BPMAppManifest) obj0).GetChapter(uid);

    internal static object XCGMWPfeHN7F2VNoVSnw(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void gnHVLGfeAgySIAkSl6LH([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void OPT53mfe7B7xYq8uQkif() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
