// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.SR
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Design;
using EleWise.ELMA.FeatureFlags.Components;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Rebranding;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using Gettext.Cs;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace EleWise.ELMA
{
  /// <summary>Класс для локализации строк</summary>
  public class SR
  {
    private static readonly List<ResourceManager> managers;
    private static readonly Dictionary<CultureInfo, Dictionary<string, string>> localizationStrings;
    private static readonly ReaderWriterLockSlim localizationStringsRWLock;
    internal static bool WatcherDisable;
    private static string resourcesDir;
    private static string fileFormat;
    private static FileSystemWatcher _watcher;
    private static LanguagesMap _languagesMap;
    private static ILocalizationService _localizationService;
    public static string Dir;
    private static LanguageHolder _languageHolder;
    private static object _watcherWorks;
    private static readonly object _languageHolderSinch;
    private static readonly Regex TranslationVariant;
    [ThreadStatic]
    private static bool futureTranslate;
    [ThreadStatic]
    private static bool escapeQuote;
    private static FileSystemWatcher settigsFileWatcher;
    private static Dictionary<string, string> settigsStrings;
    private static readonly ReaderWriterLockSlim settigsObjectsRWLock;
    private static readonly Dictionary<string, object> settigsObjects;
    public const string TranslateSRT = "SR.T";
    public const string FutureTranslateSRT = "SR.M";
    private static Regex formatParse;
    private static string futureTranslateSRTParse1;
    private static string futureTranslateSRTParse2;
    private static string futureTranslateSRTParse3;
    private static string futureTranslateSRTParse4;
    private static readonly string translateSRTFormat;
    private static Regex translateSRTParse;
    private static FieldInfo exceptionMessageField;
    /// <summary>Наименования для международной културы</summary>
    internal const string InternationalCultureName = "en-US";
    private static SR hhETXDEKMSWwCMFllS2;

    private static ILocalizationService LocalizationService
    {
      get
      {
        int num = 1;
        ILocalizationService localizationService;
        while (true)
        {
          switch (num)
          {
            case 1:
              localizationService = SR._localizationService;
              if (localizationService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return localizationService;
label_5:
        return SR._localizationService = Locator.GetService<ILocalizationService>();
      }
    }

    /// <summary>Локаль системы для ключей перевода</summary>
    public static CultureInfo KeyCultureInfo => new CultureInfo((string) SR.vrPDjpEk9ZyFJxtBPVT(1581325282 << 3 ^ -234306220));

    /// <summary>Ctor</summary>
    static SR()
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        string str;
        while (true)
        {
          object path1;
          switch (num2)
          {
            case 1:
              SR.futureTranslateSRTParse4 = (string) SR.zDd21wEe2Q9vWeCZ5Vq((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138011169), SR.wv2V9uEO2uKL83swaT4(SR.vrPDjpEk9ZyFJxtBPVT(-1839087379 - 334718690 ^ 2121154739), SR.vrPDjpEk9ZyFJxtBPVT(-680446928 - -370807692 ^ -309633672), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272626623)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837669873));
              num2 = 23;
              continue;
            case 2:
              SR.localizationStrings = new Dictionary<CultureInfo, Dictionary<string, string>>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 6 : 14;
              continue;
            case 3:
              goto label_37;
            case 4:
              SR.settigsObjectsRWLock = new ReaderWriterLockSlim();
              num2 = 19;
              continue;
            case 5:
              SR.ubcQihEaliD8V6sqHBC((object) SR._watcher, true);
              num2 = 20;
              continue;
            case 6:
              SR.futureTranslate = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            case 7:
              SR.Dir = string.Empty;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 21 : 0;
              continue;
            case 8:
              SR._languageHolderSinch = new object();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 11 : 22;
              continue;
            case 9:
              SR.managers = new List<ResourceManager>();
              num2 = 2;
              continue;
            case 10:
              SR.xTWNKgEn9iEi1QjfS8W();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 9 : 4;
              continue;
            case 11:
              SR.KSiFlZEtHptU6ov4xRF((object) SR.settigsFileWatcher, (object) new FileSystemEventHandler(SR.ClearSettingsCache));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 33 : 33;
              continue;
            case 12:
              SR.SUtFUrE4IP1kCbLIbN4((object) SR.settigsFileWatcher, (object) new FileSystemEventHandler(SR.ClearSettingsCache));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 8 : 15;
              continue;
            case 13:
              path1 = SR.eLcujBEHAM4OsWcWIeD(SR.jHTe4DEAXt2du1YvRsV((object) ((AppDomain) SR.amhCBBENfPr0FTQhOlV()).SetupInformation));
              break;
            case 14:
              goto label_13;
            case 15:
              SR.resourcesDir = SR.GetSetting(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108650570), (string) SR.vrPDjpEk9ZyFJxtBPVT(1012087039 ^ 1012082013));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 14 : 16;
              continue;
            case 16:
              SR.fileFormat = SR.GetSetting((string) SR.vrPDjpEk9ZyFJxtBPVT(-710283084 ^ -537863435 ^ 173619193), (string) SR.vrPDjpEk9ZyFJxtBPVT(-1598106783 - -968262081 ^ -629847872));
              num2 = 26;
              continue;
            case 17:
              SR.futureTranslateSRTParse3 = (string) SR.vrPDjpEk9ZyFJxtBPVT(92412609 - 1050237057 ^ -957817248) + (string) SR.wv2V9uEO2uKL83swaT4(SR.vrPDjpEk9ZyFJxtBPVT(1514961705 ^ 1514955153), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210728697), SR.vrPDjpEk9ZyFJxtBPVT(236071375 ^ 236073733)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874005093);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 0;
              continue;
            case 18:
              SR.translateSRTParse = new Regex((string) SR.lc8hOAE1sRHAJUqTiBu((object) SR.translateSRTFormat, SR.j5NFCIEPKZBdAXjpiy5(SR.vrPDjpEk9ZyFJxtBPVT(--1418440330 ^ 1418441688), (object) new string[2]
              {
                (string) SR.vrPDjpEk9ZyFJxtBPVT(-1876063057 ^ -1876061705),
                (string) SR.vrPDjpEk9ZyFJxtBPVT(333888594 ^ 1075625116 ^ 1408900496)
              })));
              num2 = 25;
              continue;
            case 19:
              SR.formatParse = new Regex((string) SR.vrPDjpEk9ZyFJxtBPVT(1470998129 - 231418599 ^ 1239572978));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 6 : 24;
              continue;
            case 20:
              goto label_35;
            case 21:
              goto label_3;
            case 22:
              SR.TranslationVariant = new Regex((string) SR.vrPDjpEk9ZyFJxtBPVT(272623989 ^ 272626471));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 6 : 4;
              continue;
            case 23:
              SR.translateSRTFormat = (string) SR.vrPDjpEk9ZyFJxtBPVT(1012087039 ^ 1012081671) + (string) SR.wv2V9uEO2uKL83swaT4((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654300765), SR.vrPDjpEk9ZyFJxtBPVT(-649342099 - -1150814748 ^ 501466957), SR.vrPDjpEk9ZyFJxtBPVT(1149433385 + 173655049 ^ 1323081976)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669368059);
              num2 = 18;
              continue;
            case 24:
              SR.futureTranslateSRTParse1 = (string) SR.EcubNPE2ApKSGDnHF26(SR.wv2V9uEO2uKL83swaT4(SR.vrPDjpEk9ZyFJxtBPVT(-1978478350 ^ -1978480054), SR.vrPDjpEk9ZyFJxtBPVT(-70007027 ^ -70001207), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475863501)), SR.vrPDjpEk9ZyFJxtBPVT(-649342099 - -1150814748 ^ 501466971), (object) ((string) SR.vrPDjpEk9ZyFJxtBPVT(-1088304168 ^ -1088302752)).Replace((string) SR.vrPDjpEk9ZyFJxtBPVT(372753449 ^ 372760301), (string) SR.vrPDjpEk9ZyFJxtBPVT(95909607 + 343705423 ^ 439608572)), SR.vrPDjpEk9ZyFJxtBPVT(1581325282 << 3 ^ -234306476));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 28 : 21;
              continue;
            case 25:
              SR.settigsObjects = new Dictionary<string, object>();
              num2 = 31;
              continue;
            case 26:
              if (MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.Designer)
              {
                num2 = 13;
                continue;
              }
              goto case 29;
            case 27:
              SR.SUtFUrE4IP1kCbLIbN4((object) SR._watcher, (object) new FileSystemEventHandler(SR.WatcherCreated));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 4 : 5;
              continue;
            case 28:
              goto label_10;
            case 29:
              // ISSUE: type reference
              path1 = SR.eLcujBEHAM4OsWcWIeD((object) SR.v04rSTE6JPQRN7lmO1M(__typeref (SR)).Assembly.Location);
              break;
            case 30:
              SR.t4Z1yZE7fBklY0hqG9y((object) str);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 3 : 1;
              continue;
            case 31:
              FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(((AppDomain) SR.amhCBBENfPr0FTQhOlV()).BaseDirectory);
              SR.CyKNcHE3LfoF40woUpa((object) fileSystemWatcher, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312862627));
              SR.csFyHZEpgNend1Trjy2((object) fileSystemWatcher, false);
              SR.ubcQihEaliD8V6sqHBC((object) fileSystemWatcher, true);
              SR.m9WcKWEDiq0722G1jS2((object) fileSystemWatcher, NotifyFilters.FileName | NotifyFilters.LastWrite);
              SR.settigsFileWatcher = fileSystemWatcher;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 11 : 6;
              continue;
            case 32:
              SR.KSiFlZEtHptU6ov4xRF((object) SR._watcher, (object) new FileSystemEventHandler(SR.WatcherCreated));
              num2 = 34;
              continue;
            case 33:
              SR.eNikLQEw9g5LUjIp0QO((object) SR.settigsFileWatcher, (object) new FileSystemEventHandler(SR.ClearSettingsCache));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 12 : 6;
              continue;
            case 34:
              SR.eNikLQEw9g5LUjIp0QO((object) SR._watcher, (object) new FileSystemEventHandler(SR.WatcherCreated));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 22 : 27;
              continue;
            default:
              SR.escapeQuote = true;
              num2 = 4;
              continue;
          }
          string resourcesDir = SR.resourcesDir;
          str = Path.Combine((string) path1, resourcesDir);
          num2 = 30;
        }
label_3:
        SR._watcherWorks = new object();
        num1 = 8;
        continue;
label_10:
        SR.futureTranslateSRTParse2 = (string) SR.EcubNPE2ApKSGDnHF26(SR.wv2V9uEO2uKL83swaT4(SR.vrPDjpEk9ZyFJxtBPVT(694673736 ^ -23604109 ^ -672125053), SR.vrPDjpEk9ZyFJxtBPVT(-345420348 ^ -345417984), SR.vrPDjpEk9ZyFJxtBPVT(-867826612 ^ -867819898)), SR.vrPDjpEk9ZyFJxtBPVT(1461625753 ^ 1461631307), SR.wv2V9uEO2uKL83swaT4((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978480054), SR.vrPDjpEk9ZyFJxtBPVT(-643786247 ^ -643792067), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475863501)), SR.vrPDjpEk9ZyFJxtBPVT(-1858887263 ^ -1858880973));
        num1 = 17;
        continue;
label_13:
        SR.localizationStringsRWLock = new ReaderWriterLockSlim();
        num1 = 7;
        continue;
label_37:
        FileSystemWatcher fileSystemWatcher1 = new FileSystemWatcher();
        fileSystemWatcher1.IncludeSubdirectories = true;
        SR.BkyZ2xExBSVMbjmCg0r((object) fileSystemWatcher1, (object) str);
        SR._watcher = fileSystemWatcher1;
        num1 = 32;
      }
label_35:;
    }

    /// <summary>Слежение за изменением папки</summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected static void WatcherCreated(object sender, FileSystemEventArgs e)
    {
      int num1 = 3;
      object watcherWorks;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_23;
          case 1:
            goto label_2;
          case 2:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 1;
            continue;
          case 3:
            watcherWorks = SR._watcherWorks;
            num1 = 2;
            continue;
          default:
            goto label_20;
        }
      }
label_23:
      return;
label_20:
      return;
label_2:
      try
      {
        Monitor.Enter(watcherWorks, ref lockTaken);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              SR.t4Z1yZE7fBklY0hqG9y((object) SR.Dir);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
                num3 = 0;
              switch (num3)
              {
                case 0:
                  return;
                default:
                  return;
              }
            }
            catch (Exception ex)
            {
              int num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
                num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 0:
                    goto label_10;
                  case 1:
                    SR.Rt6iupEmcpmcigB36oL((object) Logger.Log, SR.fRxTRuE0Fu7IiSgLGiJ((object) ex), (object) ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_9;
                }
              }
label_10:
              break;
label_9:
              break;
            }
        }
      }
      finally
      {
        int num5;
        if (!lockTaken)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
        else
          goto label_21;
label_19:
        switch (num5)
        {
          case 2:
            break;
          default:
        }
label_21:
        SR.uAdJh8Eyu8SUX82LTvH(watcherWorks);
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        {
          num5 = 0;
          goto label_19;
        }
        else
          goto label_19;
      }
    }

    /// <summary>Карта базовых языков</summary>
    public static LanguagesMap LanguagesMap
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (SR._languagesMap != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              SR._languagesMap = (LanguagesMap) SR.TfqWJrEJmXGOFKOZeAv(SR.sLXJnbEMYC63UfMFJ9W());
              num = 3;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return SR._languagesMap;
      }
    }

    /// <summary>Получить папку культуры</summary>
    /// <param name="info"></param>
    /// <returns></returns>
    public static string GetCultureDir(CultureInfo info) => (string) SR.qUO8HQEdMHJcMgVtYQs(SR.ER5pPiE9h18lxXF0djO((object) info));

    /// <summary>Получить папку культуры</summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static string GetCultureDir(string name) => (string) SR.ePijyxElsJnePn3Rlaf((object) SR.Dir, (object) name);

    /// <summary>Инициализация SR</summary>
    /// <param name="dir">Строка адреса директории с ресурсами локализации</param>
    public static void ReInitSR(string dir)
    {
      int num1 = 4;
      HashSet<string> resourceNames;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_97;
          case 1:
          case 7:
            resourceNames = new HashSet<string>()
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751173636)
            };
            num1 = 8;
            continue;
          case 2:
            goto label_95;
          case 3:
            if (SR.WatcherDisable)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 0;
              continue;
            }
            SR.Dir = dir;
            num1 = 6;
            continue;
          case 4:
            num1 = 3;
            continue;
          case 5:
            SR.sx0DOeEgaV9hG4Sac2k((object) dir);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
            continue;
          case 6:
            if (SR.w3XdpxEru2SQXqvBqWC((object) dir))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 7;
              continue;
            }
            goto case 5;
          case 8:
            goto label_8;
          default:
            goto label_92;
        }
      }
label_97:
      return;
label_95:
      return;
label_92:
      return;
label_8:
      try
      {
        SR.zopcDbE5esKil0UNMTM((object) SR.localizationStringsRWLock);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              SR.YWdO0cEjvdVXPX7sQek((object) SR.managers);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_13;
            default:
              SR.A4UyHMEYUuWXrXPgSA8((object) SR.localizationStrings);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 2;
              continue;
          }
        }
label_13:
        try
        {
          if (!SR.w3XdpxEru2SQXqvBqWC((object) dir))
            return;
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
            num3 = 2;
          List<CultureInfo>.Enumerator enumerator1;
          HashSet<string>.Enumerator enumerator2;
          List<CultureInfo> cultureNames;
          while (true)
          {
            switch (num3)
            {
              case 1:
label_76:
                enumerator2 = resourceNames.GetEnumerator();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
                continue;
              case 2:
                Action<FileInfo> action;
                ((IEnumerable<DirectoryInfo>) new DirectoryInfo(dir).GetDirectories()).ForEach<DirectoryInfo>((Action<DirectoryInfo>) (p =>
                {
                  int num5 = 3;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 0:
                        goto label_7;
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        object enumeration = SR.\u003C\u003Ec__DisplayClass27_0.fmfN96fHaP6fSh3FiSe8((object) p, SR.\u003C\u003Ec__DisplayClass27_0.BOxH1XfHpLhvI0dkru6E(--1418440330 ^ 1418440906));
                        Action<FileInfo> action1 = action;
                        Action<FileInfo> action2 = action1 == null ? (action = (Action<FileInfo>) (f =>
                        {
                          int num6 = 1;
                          while (true)
                          {
                            switch (num6)
                            {
                              case 1:
                                if (f != null)
                                {
                                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                                  continue;
                                }
                                goto label_6;
                              case 2:
                                goto label_2;
                              default:
                                // ISSUE: reference to a compiler-generated method
                                resourceNames.Add((string) SR.\u003C\u003Ec__DisplayClass27_0.lSQ8XKfHDRPKaFOKqH1x((object) f.Name));
                                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 0;
                                continue;
                            }
                          }
label_2:
                          return;
label_6:;
                        })) : action1;
                        ((IEnumerable<FileInfo>) enumeration).ForEach<FileInfo>(action2);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_5;
                      case 3:
                        if (p == null)
                        {
                          num5 = 2;
                          continue;
                        }
                        goto case 1;
                      default:
                        goto label_2;
                    }
                  }
label_7:
                  return;
label_5:
                  return;
label_2:;
                }));
                num3 = 3;
                continue;
              case 3:
                cultureNames = SR.GetCultureNames();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 4 : 4;
                continue;
              case 4:
                if (SR.F9tHyvELEwA31Ff1ZC4((object) cultureNames) > 0)
                {
                  num3 = 7;
                  continue;
                }
                goto label_82;
              case 5:
                goto label_86;
              case 6:
                try
                {
label_68:
                  if (enumerator1.MoveNext())
                    goto label_66;
                  else
                    goto label_69;
label_64:
                  CultureInfo current;
                  int num7;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        goto label_68;
                      case 2:
                        goto label_76;
                      case 3:
                        SR.localizationStrings[current] = new Dictionary<string, string>();
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
                        continue;
                      default:
                        goto label_66;
                    }
                  }
label_66:
                  current = enumerator1.Current;
                  num7 = 3;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
                  {
                    num7 = 3;
                    goto label_64;
                  }
                  else
                    goto label_64;
label_69:
                  num7 = 2;
                  goto label_64;
                }
                finally
                {
                  enumerator1.Dispose();
                  int num8 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
                    num8 = 0;
                  switch (num8)
                  {
                    default:
                  }
                }
              case 7:
                enumerator1 = cultureNames.GetEnumerator();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 6 : 6;
                continue;
              default:
                goto label_17;
            }
          }
label_86:
          return;
label_17:
          try
          {
label_56:
            if (enumerator2.MoveNext())
              goto label_53;
            else
              goto label_57;
label_19:
            GettextResourceManager gettextResourceManager;
            int num9;
            while (true)
            {
              switch (num9)
              {
                case 1:
                  enumerator1 = cultureNames.GetEnumerator();
                  num9 = 5;
                  continue;
                case 2:
                  goto label_56;
                case 3:
                  SR.managers.Add((ResourceManager) gettextResourceManager);
                  num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
                  continue;
                case 4:
                  goto label_74;
                case 5:
                  goto label_20;
                default:
                  goto label_53;
              }
            }
label_74:
            return;
label_20:
            try
            {
label_24:
              if (enumerator1.MoveNext())
                goto label_47;
              else
                goto label_25;
label_21:
              CultureInfo current1;
              ResourceSet resourceSet;
              IDictionaryEnumerator dictionaryEnumerator;
              int num10;
              while (true)
              {
                switch (num10)
                {
                  case 1:
                    resourceSet = gettextResourceManager.GetResourceSet(current1, true, true);
                    num10 = 2;
                    continue;
                  case 2:
                    if (resourceSet == null)
                    {
                      num10 = 7;
                      continue;
                    }
                    goto case 6;
                  case 3:
                    goto label_28;
                  case 4:
                    goto label_47;
                  case 5:
                    goto label_56;
                  case 6:
                    dictionaryEnumerator = (IDictionaryEnumerator) SR.XH6sWAEU0IVwOHVWELH((object) resourceSet);
                    num10 = 3;
                    continue;
                  default:
                    goto label_24;
                }
              }
label_28:
              try
              {
label_39:
                if (SR.D7yccqEcy1QouE1npyx((object) dictionaryEnumerator))
                  goto label_30;
                else
                  goto label_40;
label_29:
                DictionaryEntry current2;
                string key;
                string str;
                int num11;
                while (true)
                {
                  switch (num11)
                  {
                    case 1:
                      if (!SR.xhtPxdEs9nG9CKwHKbx((object) str))
                      {
                        num11 = 2;
                        continue;
                      }
                      goto label_39;
                    case 2:
                      SR.localizationStrings[current1][key] = str;
                      num11 = 3;
                      continue;
                    case 3:
                    case 7:
                      goto label_39;
                    case 4:
                      if (SR.xhtPxdEs9nG9CKwHKbx((object) key))
                      {
                        num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 7;
                        continue;
                      }
                      goto case 1;
                    case 5:
                      str = current2.Value.ToString();
                      num11 = 4;
                      continue;
                    case 6:
                      goto label_30;
                    case 8:
                      goto label_24;
                    default:
                      key = current2.Key.ToString();
                      num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 5 : 5;
                      continue;
                  }
                }
label_30:
                current2 = (DictionaryEntry) dictionaryEnumerator.Current;
                num11 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
                {
                  num11 = 0;
                  goto label_29;
                }
                else
                  goto label_29;
label_40:
                num11 = 8;
                goto label_29;
              }
              finally
              {
                IDisposable disposable = dictionaryEnumerator as IDisposable;
                int num12 = 2;
                while (true)
                {
                  switch (num12)
                  {
                    case 1:
                      goto label_46;
                    case 2:
                      if (disposable != null)
                      {
                        num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_46;
                    default:
                      SR.fNbGRaEzWbfbl76JXxQ((object) disposable);
                      num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
                      continue;
                  }
                }
label_46:;
              }
label_25:
              num10 = 5;
              goto label_21;
label_47:
              current1 = enumerator1.Current;
              num10 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
              {
                num10 = 1;
                goto label_21;
              }
              else
                goto label_21;
            }
            finally
            {
              enumerator1.Dispose();
              int num13 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
                num13 = 0;
              switch (num13)
              {
                default:
              }
            }
label_53:
            gettextResourceManager = new GettextResourceManager(enumerator2.Current, dir, SR.fileFormat);
            num9 = 3;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
            {
              num9 = 1;
              goto label_19;
            }
            else
              goto label_19;
label_57:
            num9 = 4;
            goto label_19;
          }
          finally
          {
            enumerator2.Dispose();
            int num14 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
              num14 = 0;
            switch (num14)
            {
              default:
            }
          }
label_82:;
        }
        catch (Exception ex)
        {
          int num15 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
            num15 = 0;
          while (true)
          {
            switch (num15)
            {
              case 1:
                goto label_70;
              default:
                Logger.Log.Error((object) ex.Message, ex);
                num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
                continue;
            }
          }
label_70:;
        }
      }
      finally
      {
        SR.vQFfoqfF6L9U9w0pBEm((object) SR.localizationStringsRWLock);
        int num16 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
          num16 = 0;
        switch (num16)
        {
          default:
        }
      }
    }

    /// <summary>Получить hash всех установленных культур</summary>
    /// <returns></returns>
    public static LocalizationHash[] ComputeLocalizationHash()
    {
      int num1 = 2;
      List<LocalizationHash> localizationHashList;
      List<CultureInfo>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = SR.GetCultureNames().GetEnumerator();
            num1 = 3;
            continue;
          case 2:
            localizationHashList = new List<LocalizationHash>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_4;
          default:
            goto label_2;
        }
      }
label_2:
      return localizationHashList.ToArray();
label_4:
      try
      {
label_9:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_10;
label_5:
        CultureInfo current;
        string str;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              goto label_2;
            case 3:
              goto label_9;
            case 4:
              if (!current.Equals(SR.wI6wbifBevfaFuGnfnY()))
              {
                num2 = 5;
                continue;
              }
              goto label_9;
            case 5:
              str = (string) SR.jNeJPafWELTvdE0VKh7((object) current);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            default:
              localizationHashList.Add((LocalizationHash) SR.gWjOp4foyfoRwtYZxrt((object) str));
              num2 = 3;
              continue;
          }
        }
label_7:
        current = enumerator.Current;
        num2 = 4;
        goto label_5;
label_10:
        num2 = 2;
        goto label_5;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Посчитать hash локали</summary>
    /// <returns></returns>
    public static LocalizationHash ComputeLocalizationHash(string targetPath)
    {
      int num1 = 3;
      string str1;
      LocalizationHash localizationHash;
      MD5 md5;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_7;
          case 2:
            localizationHash = new LocalizationHash()
            {
              Local = str1
            };
            num1 = 4;
            continue;
          case 3:
            str1 = (string) SR.XBHUIKfbQ9HLpIWj9Ln((object) targetPath);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 2;
            continue;
          case 4:
            if (!Directory.Exists(targetPath))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            }
            md5 = (MD5) SR.n5W0AVfhkrNK5UmjAYE();
            num1 = 5;
            continue;
          case 5:
            goto label_8;
          default:
            goto label_5;
        }
      }
label_5:
      return localizationHash;
label_7:
      return localizationHash;
label_8:
      try
      {
        string[] strArray = (string[]) SR.VTE36ofG6Fk1KyI6i8k((object) targetPath, SR.vrPDjpEk9ZyFJxtBPVT(1505778440 - 1981636111 ^ -475864391));
        int num2 = 16;
        while (true)
        {
          int num3;
          int index;
          string str2;
          FileStream inputStream1;
          string path;
          string str3;
          FileStream inputStream2;
          switch (num2)
          {
            case 1:
label_30:
              ++index;
              num2 = 12;
              continue;
            case 2:
              try
              {
                List<LocalizationFileHash> fileHashes = localizationHash.FileHashes;
                LocalizationFileHash localizationFileHash = new LocalizationFileHash();
                SR.SNdTRNffMDU8W0jv0wV((object) localizationFileHash, SR.XBHUIKfbQ9HLpIWj9Ln((object) str3));
                localizationFileHash.Hash = md5.ComputeHash((Stream) inputStream2);
                fileHashes.Add(localizationFileHash);
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                    goto label_30;
                }
              }
              finally
              {
                int num5;
                if (inputStream2 == null)
                  num5 = 2;
                else
                  goto label_41;
label_40:
                switch (num5)
                {
                  case 1:
                    break;
                  default:
                }
label_41:
                inputStream2.Dispose();
                num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
                {
                  num5 = 0;
                  goto label_40;
                }
                else
                  goto label_40;
              }
            case 3:
            case 17:
              if (index >= strArray.Length)
              {
                num2 = 5;
                continue;
              }
              goto case 9;
            case 4:
            case 12:
              if (index < strArray.Length)
              {
                num3 = 14;
                break;
              }
              goto default;
            case 5:
              goto label_7;
            case 6:
            case 14:
              str3 = strArray[index];
              num2 = 7;
              continue;
            case 7:
              inputStream2 = (FileStream) SR.O0KVcGfExvQOVrb4KWP((object) str3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 2 : 1;
              continue;
            case 8:
label_44:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 17 : 14;
              continue;
            case 9:
              str2 = strArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 2 : 10;
              continue;
            case 10:
              inputStream1 = (FileStream) SR.O0KVcGfExvQOVrb4KWP((object) str2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 13 : 13;
              continue;
            case 11:
              index = 0;
              num3 = 3;
              break;
            case 13:
              try
              {
                List<LocalizationFileHash> fileHashes = localizationHash.FileHashes;
                LocalizationFileHash localizationFileHash = new LocalizationFileHash();
                SR.SNdTRNffMDU8W0jv0wV((object) localizationFileHash, SR.XBHUIKfbQ9HLpIWj9Ln((object) str2));
                SR.x94ybafCYHWqkFgLZvO((object) localizationFileHash, (object) md5.ComputeHash((Stream) inputStream1));
                fileHashes.Add(localizationFileHash);
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                    goto label_44;
                }
              }
              finally
              {
                int num7;
                if (inputStream1 == null)
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                else
                  goto label_21;
label_20:
                switch (num7)
                {
                  case 2:
                    break;
                  default:
                }
label_21:
                SR.fNbGRaEzWbfbl76JXxQ((object) inputStream1);
                num7 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
                {
                  num7 = 0;
                  goto label_20;
                }
                else
                  goto label_20;
              }
            case 15:
              strArray = (string[]) SR.mUFwmafQI3l24KjKvEC((object) path);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 8 : 11;
              continue;
            case 16:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 4 : 0;
              continue;
            case 18:
              if (Directory.Exists(path))
              {
                num2 = 15;
                continue;
              }
              goto label_7;
            default:
              path = Path.Combine(targetPath, (string) SR.vrPDjpEk9ZyFJxtBPVT(-488881205 ^ -488874617));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 18;
              continue;
          }
          num2 = num3;
        }
      }
      finally
      {
        if (md5 != null)
        {
          int num8 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
            num8 = 1;
          while (true)
          {
            switch (num8)
            {
              case 1:
                SR.fNbGRaEzWbfbl76JXxQ((object) md5);
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
                continue;
              default:
                goto label_50;
            }
          }
        }
label_50:;
      }
    }

    /// <summary>Список установленых языков</summary>
    /// <returns></returns>
    public static List<CultureInfo> GetCultureNames()
    {
      if (string.IsNullOrEmpty(SR.Dir))
        return new List<CultureInfo>() { SR.KeyCultureInfo };
      List<DirectoryInfo> source = new List<DirectoryInfo>();
      if (Directory.Exists(SR.Dir))
      {
        // ISSUE: reference to a compiler-generated method
        source = ((IEnumerable<DirectoryInfo>) new DirectoryInfo(SR.Dir).GetDirectories()).Where<DirectoryInfo>((Func<DirectoryInfo, bool>) (d => !d.Name.Equals((string) SR.\u003C\u003Ec.H98icRfHHX1gVBH9UoAp(1669212571 ^ 1669297091), StringComparison.OrdinalIgnoreCase))).ToList<DirectoryInfo>();
      }
      List<CultureInfo> list = source.Select<DirectoryInfo, CultureInfo>((Func<DirectoryInfo, CultureInfo>) (c =>
      {
        CultureInfo cultureNames;
        switch (1)
        {
          case 1:
            try
            {
              cultureNames = new CultureInfo(c.Name);
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
                num = 0;
              switch (num)
              {
              }
            }
            catch (Exception ex)
            {
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
                num = 1;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    SR.\u003C\u003Ec.daCcOKfH7MtYqWY3TWYm(SR.\u003C\u003Ec.LT1eMZfHAsHcqIUb27Pr(), (object) ex.Message, (object) ex);
                    num = 2;
                    continue;
                  case 2:
                    cultureNames = (CultureInfo) null;
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_9;
                }
              }
            }
            break;
        }
label_9:
        return cultureNames;
      })).Where<CultureInfo>((Func<CultureInfo, bool>) (c => c != null)).ToList<CultureInfo>();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (!source.Any<DirectoryInfo>((Func<DirectoryInfo, bool>) (c => ((string) SR.\u003C\u003Ec.h8LqyLfHxOcgYmSYLqj7((object) c)).StartsWith(((CultureInfo) SR.\u003C\u003Ec.RY52oOfH0UXJLoE2VLpu()).Name))))
        list.Add(new CultureInfo(SR.KeyCultureInfo.Name));
      return list;
    }

    /// <summary>Получить культуру по имени из установленных</summary>
    /// <param name="cultureName"></param>
    /// <returns></returns>
    public static CultureInfo GetCultureByName(string cultureName)
    {
      int num = 2;
      string cultureName1;
      while (true)
      {
        switch (num)
        {
          case 1:
            cultureName1 = cultureName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return SR.GetCultureNames().FirstOrDefault<CultureInfo>((Func<CultureInfo, bool>) (c => SR.\u003C\u003Ec__DisplayClass31_0.RnZ6llfAWsBwacTYAwMV(SR.\u003C\u003Ec__DisplayClass31_0.om1tLXfABB8X8jZpuTI2((object) c), (object) cultureName1, StringComparison.OrdinalIgnoreCase)));
    }

    /// <summary>Загрузить сохраненную локаль</summary>
    public static void InitCulture()
    {
      switch (1)
      {
        case 1:
          try
          {
            if (SR.GBi3c8fvDVNA69Cnbs8() == null)
              break;
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_6;
                case 1:
                  SR.BmXYoTf82JiVq0fBY2r(SR.GBi3c8fvDVNA69Cnbs8());
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_1;
              }
            }
label_6:
            break;
label_1:
            break;
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_15;
                default:
                  Logger.Log.Error(SR.fRxTRuE0Fu7IiSgLGiJ((object) ex), ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 0;
                  continue;
              }
            }
label_15:
            break;
          }
      }
    }

    /// <summary>Получить локаль для текущего пользователя</summary>
    /// <returns></returns>
    public static CultureInfo GetCurrentCulture() => (CultureInfo) SR.OE4XD9fZcGLeABfJ5Cx((object) null);

    /// <summary>Получить локаль для указанного пользователя</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public static CultureInfo GetCurrentCulture(IUser user)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (Locator.Initialized)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          case 3:
            goto label_5;
          default:
            if (SR.GBi3c8fvDVNA69Cnbs8() != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 3 : 1;
              continue;
            }
            goto label_6;
        }
      }
label_2:
      return (CultureInfo) null;
label_5:
      return (CultureInfo) SR.Dm5MNlfu3ZSojur4rLc((object) SR.LocalizationService, (object) user);
label_6:
      return (CultureInfo) null;
    }

    /// <summary>Культура по умолчанию</summary>
    /// <returns></returns>
    public static CultureInfo GetDefaultCulture()
    {
      int num = 3;
      object defaultCulture;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_11;
          case 2:
            goto label_3;
          case 3:
            if (SR.LT6X7FfInVe2V4Qju61())
            {
              if (SR.GBi3c8fvDVNA69Cnbs8() != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                continue;
              }
              defaultCulture = SR.GIxm43fiaqb6NBWslFj(SR.ER5pPiE9h18lxXF0djO((object) ((Thread) SR.ilBR3WfS9bcKJDpOKiS()).CurrentCulture));
              if (defaultCulture == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            }
            else
            {
              num = 2;
              continue;
            }
          default:
            goto label_8;
        }
      }
label_3:
      return (CultureInfo) null;
label_8:
      return (CultureInfo) SR.EPsa3ifVCRMqykoxK6W(SR.GBi3c8fvDVNA69Cnbs8());
label_2:
      return (CultureInfo) defaultCulture;
label_11:
      return (CultureInfo) SR.wI6wbifBevfaFuGnfnY();
    }

    /// <summary>Запуск кода в указанной культуре</summary>
    /// <param name="culture"></param>
    /// <param name="action"></param>
    public static T RunWithCulture<T>(CultureInfo culture, Func<T> action)
    {
      T result = default (T);
      SR.RunWithCulture(culture, (System.Action) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              result = action();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      return result;
    }

    /// <summary>Запуск кода в указанной культуре</summary>
    /// <param name="culture">Культура</param>
    /// <param name="action">Действие</param>
    /// <returns>Задача</returns>
    public static async Task RunWithCultureAsync(CultureInfo culture, Func<Task> action)
    {
      int num1 = 3;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_42;
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 2:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 5;
              else
                goto label_9;
label_6:
              CultureInfo currentCulture;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_9;
                  case 2:
                    goto label_3;
                  case 3:
                  case 5:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                    continue;
                  case 4:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    currentCulture = (CultureInfo) SR.\u003CRunWithCultureAsync\u003Ed__37.LetmUkfAvDeLX5Ekkawc(SR.\u003CRunWithCultureAsync\u003Ed__37.OZrn26fACv1xKy4c5sGY());
                    num3 = 3;
                    continue;
                  default:
                    goto label_11;
                }
              }
label_11:
              CultureInfo currentUiCulture;
              try
              {
                int num4;
                if (num2 == 0)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 9;
                else
                  goto label_19;
label_14:
                TaskAwaiter taskAwaiter;
                TaskAwaiter awaiter;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 3 : 8;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      SR.\u003CRunWithCultureAsync\u003Ed__37.rjSTm4fAZQ9NA9tiv868(SR.\u003CRunWithCultureAsync\u003Ed__37.OZrn26fACv1xKy4c5sGY(), (object) CultureInfo.CreateSpecificCulture(culture.Name));
                      num4 = 3;
                      continue;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      awaiter = SR.\u003CRunWithCultureAsync\u003Ed__37.mFMN4ffAudxqj5VBOWuf((object) action());
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 4 : 1;
                      continue;
                    case 4:
                      if (!awaiter.IsCompleted)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 7 : 13;
                        continue;
                      }
                      goto case 8;
                    case 5:
                      goto label_36;
                    case 6:
                      goto label_19;
                    case 7:
                      taskAwaiter = new TaskAwaiter();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
                      continue;
                    case 8:
                      awaiter.GetResult();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 9 : 12;
                      continue;
                    case 10:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, SR.\u003CRunWithCultureAsync\u003Ed__37>(ref awaiter, this);
                      num4 = 5;
                      continue;
                    case 11:
                      taskAwaiter = awaiter;
                      num4 = 10;
                      continue;
                    case 12:
                      goto label_3;
                    case 13:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 0;
                      num4 = 11;
                      continue;
                    default:
                      awaiter = taskAwaiter;
                      num4 = 7;
                      continue;
                  }
                }
label_36:
                return;
label_19:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                SR.\u003CRunWithCultureAsync\u003Ed__37.oqQsi2fA8Xo3rSQhQHr6(SR.\u003CRunWithCultureAsync\u003Ed__37.OZrn26fACv1xKy4c5sGY(), (object) culture);
                num4 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
                {
                  num4 = 2;
                  goto label_14;
                }
                else
                  goto label_14;
              }
              finally
              {
                int num5;
                if (num2 >= 0)
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
                else
                  goto label_32;
label_30:
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                    case 3:
                      goto label_35;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      SR.\u003CRunWithCultureAsync\u003Ed__37.rjSTm4fAZQ9NA9tiv868(SR.\u003CRunWithCultureAsync\u003Ed__37.OZrn26fACv1xKy4c5sGY(), (object) currentCulture);
                      num5 = 3;
                      continue;
                    default:
                      goto label_32;
                  }
                }
label_35:
label_32:
                // ISSUE: reference to a compiler-generated method
                ((Thread) SR.\u003CRunWithCultureAsync\u003Ed__37.OZrn26fACv1xKy4c5sGY()).CurrentUICulture = currentUiCulture;
                num5 = 2;
                goto label_30;
              }
label_9:
              // ISSUE: reference to a compiler-generated method
              currentUiCulture = (CultureInfo) SR.\u003CRunWithCultureAsync\u003Ed__37.ELse2mfAQbLyBST5bRYE((object) Thread.CurrentThread);
              num3 = 4;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
              {
                num3 = 0;
                goto label_6;
              }
              else
                goto label_6;
            }
            catch (Exception ex)
            {
              int num6 = 2;
              while (true)
              {
                switch (num6)
                {
                  case 0:
                    goto label_33;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_31;
                }
              }
label_33:
              return;
label_31:
              return;
            }
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = 2;
            continue;
          case 4:
label_3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 1;
            continue;
          default:
            goto label_39;
        }
      }
label_42:
      return;
label_39:;
    }

    /// <summary>Запуск кода в указанной культуре</summary>
    /// <param name="culture"></param>
    /// <param name="action"></param>
    public static void RunWithCulture(CultureInfo culture, System.Action action)
    {
      int num1 = 2;
      CultureInfo currentUiCulture;
      CultureInfo cultureInfo;
      while (true)
      {
        switch (num1)
        {
          case 1:
            cultureInfo = (CultureInfo) SR.ENoAQ5fRxFpE3Db0aA0(SR.ilBR3WfS9bcKJDpOKiS());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          case 2:
            currentUiCulture = ((Thread) SR.ilBR3WfS9bcKJDpOKiS()).CurrentUICulture;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_13;
          default:
            goto label_4;
        }
      }
label_13:
      return;
label_4:
      try
      {
        ((Thread) SR.ilBR3WfS9bcKJDpOKiS()).CurrentUICulture = culture;
        int num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              SR.QKI0p7fqAucnfg62r6k(SR.ilBR3WfS9bcKJDpOKiS(), (object) CultureInfo.CreateSpecificCulture((string) SR.ER5pPiE9h18lxXF0djO((object) culture)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
              continue;
            default:
              SR.GhEBiQfKllxnPl0PNkW((object) action);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 1;
              continue;
          }
        }
label_9:;
      }
      finally
      {
        SR.HJSDGGfXC1aSSNCQinE(SR.ilBR3WfS9bcKJDpOKiS(), (object) currentUiCulture);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_15;
            default:
              SR.QKI0p7fqAucnfg62r6k(SR.ilBR3WfS9bcKJDpOKiS(), (object) cultureInfo);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
              continue;
          }
        }
label_15:;
      }
    }

    /// <summary>
    /// Выполнить код с установленной культурой с региональными параметрами для диспетчера ресурсов
    /// </summary>
    /// <param name="action"></param>
    public static void RunWithSpecificUICulture(System.Action action)
    {
      int num1 = 1;
      CultureInfo cultureInfo;
      while (true)
      {
        switch (num1)
        {
          case 1:
            cultureInfo = (CultureInfo) SR.VqkN2yfTkUovyT1i9kT(SR.ilBR3WfS9bcKJDpOKiS());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_14;
          default:
            goto label_3;
        }
      }
label_14:
      return;
label_3:
      try
      {
        int num2;
        if (Thread.CurrentThread.CurrentUICulture.IsNeutralCulture)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
        else
          goto label_7;
label_6:
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              goto label_7;
            default:
              ((Thread) SR.ilBR3WfS9bcKJDpOKiS()).CurrentUICulture = (CultureInfo) SR.ejgM9efkMhTI4CUxAkj(SR.ER5pPiE9h18lxXF0djO(SR.VqkN2yfTkUovyT1i9kT(SR.ilBR3WfS9bcKJDpOKiS())));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 2;
              continue;
          }
        }
label_10:
        return;
label_7:
        action();
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        {
          num2 = 1;
          goto label_6;
        }
        else
          goto label_6;
      }
      finally
      {
        SR.HJSDGGfXC1aSSNCQinE(SR.ilBR3WfS9bcKJDpOKiS(), (object) cultureInfo);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Идентификатор текущей культуры</summary>
    public static int CurrentLCID
    {
      get
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              if (SR.TbORhafn2l9tC8ugc3q() != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 3:
              if (!SR.futureTranslate)
              {
                num = 2;
                continue;
              }
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        return 0;
label_3:
        return SR.DHJVtgfOCny6u95QqrJ(SR.TbORhafn2l9tC8ugc3q());
      }
    }

    internal static void RunWithFutureTranslate(System.Action action, bool escapeQuote = true)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            SR.RunWithFutureTranslate<int>((Func<int>) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    SR.\u003C\u003Ec__DisplayClass44_0.laFvqvfARcBlvlnDq1jx((object) action);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_3:
              return 0;
            }), escapeQuote);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static T RunWithFutureTranslate<T>(Func<T> action, bool escapeQuote = true)
    {
      bool futureTranslate = SR.futureTranslate;
      bool escapeQuote1 = SR.escapeQuote;
      try
      {
        SR.futureTranslate = true;
        SR.escapeQuote = escapeQuote;
        return action();
      }
      catch (Exception ex)
      {
        SR.futureTranslate = futureTranslate;
        SR.escapeQuote = escapeQuote1;
        SR.PreparedTranslate((object) ex);
        throw;
      }
      finally
      {
        SR.futureTranslate = futureTranslate;
        SR.escapeQuote = escapeQuote1;
      }
    }

    public static string GetSetting(string setting, string defaultValue = null)
    {
      int num1 = 6;
      string setting1;
      while (true)
      {
        FileSystemWatcher settigsFileWatcher;
        bool lockTaken;
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            lockTaken = false;
            num1 = 3;
            continue;
          case 3:
            try
            {
              Monitor.Enter((object) settigsFileWatcher, ref lockTaken);
              int num2 = 3;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
                num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_17;
                  case 2:
                    SR.settigsStrings = SR.ReadSettings();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
                    continue;
                  case 3:
                    if (SR.settigsStrings == null)
                    {
                      num2 = 2;
                      continue;
                    }
                    goto label_17;
                  default:
                    ((SettingsFeatureFlagProvider.SettingsFeatureFlagContainer) SR.lMtYqjf2YyFB6MqEelK()).UpdateFlags((IDictionary<string, string>) SR.settigsStrings);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 1;
                    continue;
                }
              }
            }
            finally
            {
              int num3;
              if (!lockTaken)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 2;
              else
                goto label_14;
label_13:
              switch (num3)
              {
                case 1:
                case 2:
              }
label_14:
              Monitor.Exit((object) settigsFileWatcher);
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
              {
                num3 = 1;
                goto label_13;
              }
              else
                goto label_13;
            }
          case 4:
            goto label_2;
          case 5:
            settigsFileWatcher = SR.settigsFileWatcher;
            num1 = 2;
            continue;
          case 6:
            if (SR.settigsStrings == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 5;
              continue;
            }
            break;
        }
label_17:
        if (SR.settigsStrings.TryGetValue(setting, out setting1))
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 1;
        else
          break;
      }
label_2:
      return defaultValue;
label_3:
      return setting1;
    }

    private static Dictionary<string, string> ReadSettings()
    {
      Dictionary<string, string> dictionary = new Dictionary<string, string>();
      try
      {
        NameValueCollection appSettings = ConfigurationManager.AppSettings;
        foreach (string allKey in appSettings.AllKeys)
          dictionary[allKey] = appSettings[allKey];
      }
      catch (Exception ex)
      {
        Thread.Sleep(TimeSpan.FromSeconds(1.0));
        NameValueCollection appSettings = ConfigurationManager.AppSettings;
        foreach (string allKey in appSettings.AllKeys)
          dictionary[allKey] = appSettings[allKey];
      }
      return dictionary;
    }

    private static void ClearSettingsCache(object sender, object e)
    {
      int num1 = 7;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_22;
          case 2:
            SR.zopcDbE5esKil0UNMTM((object) SR.settigsObjectsRWLock);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 5 : 1;
            continue;
          case 3:
            SR.settigsObjectsRWLock.EnterWriteLock();
            num1 = 9;
            continue;
          case 4:
            SR.settigsStrings = SR.ReadSettings();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 2;
            continue;
          case 5:
            try
            {
              SR.AYhD3sfPCBmMhgwc0ZA((object) SR.settigsObjects);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_7;
              }
            }
            finally
            {
              SR.vQFfoqfF6L9U9w0pBEm((object) SR.settigsObjectsRWLock);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 6:
            SR.settigsStrings = SR.ReadSettings();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 3 : 3;
            continue;
          case 7:
            SR.rKpwuffeFfMsfAZuTYf((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757129564));
            num1 = 6;
            continue;
          case 8:
label_7:
            ((SettingsFeatureFlagProvider.SettingsFeatureFlagContainer) SR.lMtYqjf2YyFB6MqEelK()).UpdateFlags((IDictionary<string, string>) SR.settigsStrings);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
            continue;
          case 9:
            try
            {
              SR.AYhD3sfPCBmMhgwc0ZA((object) SR.settigsObjects);
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
                num4 = 0;
              switch (num4)
              {
              }
            }
            finally
            {
              SR.vQFfoqfF6L9U9w0pBEm((object) SR.settigsObjectsRWLock);
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
                num5 = 0;
              switch (num5)
              {
                default:
              }
            }
            break;
        }
        Thread.Sleep(TimeSpan.FromSeconds(5.0));
        num1 = 4;
      }
label_22:;
    }

    public static T GetSetting<T>(string setting, T defaultValue = null)
    {
      SR.settigsObjectsRWLock.EnterReadLock();
      object obj;
      try
      {
        if (SR.settigsObjects.TryGetValue(setting, out obj))
          return (T) (obj ?? (object) defaultValue);
      }
      finally
      {
        SR.settigsObjectsRWLock.ExitReadLock();
      }
      string setting1 = SR.GetSetting(setting);
      if (setting1 != null)
      {
        Type type = typeof (T);
        try
        {
          TypeConverter converter = TypeDescriptor.GetConverter(type);
          if (converter == null || !converter.CanConvertFrom(typeof (string)))
          {
            try
            {
              obj = Convert.ChangeType((object) setting1, type);
            }
            catch (Exception ex)
            {
              obj = (object) null;
            }
          }
          else
            obj = converter.ConvertFrom((ITypeDescriptorContext) null, CultureInfo.InvariantCulture, (object) setting1);
        }
        catch (Exception ex)
        {
          Logger.Log.Warn(ex, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413558883), (object) setting, (object) type, (object) setting1);
        }
      }
      SR.settigsObjectsRWLock.EnterWriteLock();
      try
      {
        SR.settigsObjects[setting] = obj;
      }
      finally
      {
        SR.settigsObjectsRWLock.ExitWriteLock();
      }
      return (T) (obj ?? (object) defaultValue);
    }

    private static string GetString(object s, object cultureInfo)
    {
      string str1;
      switch (1)
      {
        case 1:
          try
          {
            SR.yI3DdLf1odUpTbYq9Tw((object) SR.localizationStringsRWLock);
            int num = 3;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
              num = 5;
            while (true)
            {
              Dictionary<string, string> dictionary;
              string str2;
              object obj;
              switch (num)
              {
                case 1:
                  str2 = (string) null;
                  num = 10;
                  continue;
                case 2:
                  if (cultureInfo == null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 11;
                    continue;
                  }
                  goto case 1;
                case 3:
                  obj = (object) str2;
                  break;
                case 4:
                case 6:
                  goto label_25;
                case 5:
                  if (SR.localizationStrings.Count <= 0)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 12 : 1;
                    continue;
                  }
                  goto case 2;
                case 7:
                  if (!SR.SKaSXef3wPLiiMxWjBu((object) SR.TranslationVariant, (object) str2))
                  {
                    num = 3;
                    continue;
                  }
                  goto case 9;
                case 8:
                case 13:
                  if (str2 != null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 5 : 7;
                    continue;
                  }
                  goto case 3;
                case 9:
                  obj = SR.Fwh7LUfpeYalvIHcb2R(s, (object) str2);
                  break;
                case 10:
                  if (!SR.localizationStrings.TryGetValue((CultureInfo) cultureInfo, out dictionary))
                  {
                    num = 8;
                    continue;
                  }
                  goto default;
                case 11:
                  cultureInfo = (object) ((Thread) SR.ilBR3WfS9bcKJDpOKiS()).CurrentCulture;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
                  continue;
                case 12:
                  str1 = (string) s;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 4 : 4;
                  continue;
                default:
                  dictionary.TryGetValue((string) SR.zdvXKufN548Bomluk73(s, SR.vrPDjpEk9ZyFJxtBPVT(-680446928 - -370807692 ^ -309634748), (object) ""), out str2);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 13 : 6;
                  continue;
              }
              str1 = (string) obj;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 5 : 6;
            }
          }
          finally
          {
            SR.r03onkfa5hciDbdP5rS((object) SR.localizationStringsRWLock);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
              num = 0;
            switch (num)
            {
              default:
            }
          }
      }
label_25:
      return str1;
    }

    private static string GetCorrectTranslationVariant(object s, object res)
    {
      int num = 4;
      string[] strArray;
      int index;
      string stackTrace;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated method
            if (!((IEnumerable<string>) SR.hLGe5efwVmmtam67qDf((object) strArray[index], (object) new char[1]
            {
              ','
            }, StringSplitOptions.RemoveEmptyEntries)).Any<string>((Func<string, bool>) (placeOfUse => SR.\u003C\u003Ec__DisplayClass55_0.tAnNcqfAkmscPaKFobaF((object) stackTrace, (object) placeOfUse))))
            {
              num = 5;
              continue;
            }
            goto label_4;
          case 2:
            stackTrace = (string) SR.uMVd6GftmiLF9clEMG8();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 8 : 0;
            continue;
          case 3:
            strArray = (string[]) SR.AmJgVtfDTHtutwU5BT1((object) SR.TranslationVariant, res);
            num = 2;
            continue;
          case 4:
            num = 3;
            continue;
          case 5:
            index += 2;
            num = 7;
            continue;
          case 6:
            goto label_10;
          case 8:
            index = 1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          case 9:
            goto label_4;
          default:
            if (index >= strArray.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 2 : 6;
              continue;
            }
            goto case 1;
        }
      }
label_4:
      return strArray[index + 1];
label_10:
      return (string) s;
    }

    /// <summary>Resources directory used to retrieve files from.</summary>
    public static string ResourcesDirectory
    {
      get => SR.resourcesDir;
      set => SR.resourcesDir = value;
    }

    /// <summary>
    /// Format of the file based on culture and resource name.
    /// </summary>
    public static string FileFormat
    {
      get => SR.fileFormat;
      set => SR.fileFormat = value;
    }

    public static bool ContainsKey(string str)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!SR.nslMSgf4kNavaANKuti((object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317796248)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return SR.ContainsKey((object) str, SR.vrPDjpEk9ZyFJxtBPVT(-787452571 ^ -787451807));
label_3:
      return true;
    }

    private static bool ContainsKey(object str, object key)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (SR.xhtPxdEs9nG9CKwHKbx(str))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return SR.rMvA0kfHnXtosAHDHwa(str, SR.wjOd72f69ggE1fcKUeJ(key, SR.vrPDjpEk9ZyFJxtBPVT(516838154 ^ 516836852)), StringComparison.OrdinalIgnoreCase);
label_3:
      return false;
    }

    /// <summary>Извлечь ключ из строки</summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string ExtractKeyFromString(string str)
    {
      int num = 4;
      int length;
      while (true)
      {
        switch (num)
        {
          case 1:
            length = str.Length - 8;
            num = 2;
            continue;
          case 2:
            str = str.Substring(6, length);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 5 : 5;
            continue;
          case 3:
            goto label_7;
          case 4:
            if (SR.xhtPxdEs9nG9CKwHKbx((object) str))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 3;
              continue;
            }
            if (!SR.mtwX23fAMdqOQyDem3K((object) str))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          default:
            goto label_2;
        }
      }
label_2:
      return str.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405835443), "");
label_7:
      return str;
    }

    /// <summary>
    /// Поиск локализованной строки, используется для пометки строки как локализуемой
    /// </summary>
    public static string T(string t)
    {
      int num1 = 5;
      CultureInfo cultureInfo;
      string translateLocalization;
      while (true)
      {
        int num2 = num1;
        long int64;
        IUser user;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              goto label_35;
            case 3:
              goto label_34;
            case 4:
              if (SR.LT6X7FfInVe2V4Qju61())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 13 : 14;
                continue;
              }
              goto label_35;
            case 5:
              if (SR.JcbhQkf7EkwLGkp7urB())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 4 : 0;
                continue;
              }
              goto label_35;
            case 6:
              if (((TranslateService) SR.uEWa04fxBoxFsQt26MC()).IsTranslationModeEnabled(new long?(int64)))
              {
                num2 = 8;
                continue;
              }
              goto label_35;
            case 7:
              if (!SR.asXlO1fmyP1EGNujCPc((object) TranslateService.Instance))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 2 : 2;
                continue;
              }
              goto case 12;
            case 8:
              if (!SR.xhtPxdEs9nG9CKwHKbx((object) t))
              {
                cultureInfo = (CultureInfo) SR.OE4XD9fZcGLeABfJ5Cx((object) user);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 8 : 11;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 1;
              continue;
            case 9:
              user = (IUser) null;
              num2 = 13;
              continue;
            case 10:
              goto label_7;
            case 11:
              translateLocalization = ((TranslateService) SR.uEWa04fxBoxFsQt26MC()).GetTranslateLocalization(new long?(int64));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 3 : 2;
              continue;
            case 12:
              t = (string) SR.tLHZIffyaOOFFY10KCT((object) t);
              num2 = 9;
              continue;
            case 13:
              try
              {
                ((TranslateService) SR.uEWa04fxBoxFsQt26MC()).InLineDisabled = true;
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_21;
                    default:
                      user = (IUser) SR.VtfQ4sfMxRLjSLso1ML();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
              finally
              {
                SR.aK4YNSfJnhP1R3eYIp2(SR.uEWa04fxBoxFsQt26MC(), false);
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 14:
              if (Locator.GetService<TranslateService>() != null)
              {
                num2 = 10;
                continue;
              }
              goto label_35;
            case 15:
              goto label_12;
            case 16:
              goto label_11;
          }
label_21:
          if (user != null)
            num2 = 15;
          else
            goto label_11;
        }
label_7:
        if (!SR.I8Kgqjf0XUhfOyCJNNu(SR.uEWa04fxBoxFsQt26MC()))
        {
          num1 = 7;
          continue;
        }
        goto label_35;
label_12:
        int64 = Convert.ToInt64(SR.zuAjLGfdMObPvKu1wGJ((object) user));
        num1 = 6;
      }
label_9:
      return t;
label_11:
      return (string) SR.T3pY1vf9p5wOaHT2d3p((object) null, (object) t);
label_34:
      return ((TranslateService) SR.uEWa04fxBoxFsQt26MC()).T((string) SR.ER5pPiE9h18lxXF0djO((object) cultureInfo), translateLocalization, t, SR.pu1oHZflZBnsDtK8WKB(SR.uEWa04fxBoxFsQt26MC()));
label_35:
      return (string) SR.T3pY1vf9p5wOaHT2d3p((object) null, (object) t);
    }

    /// <summary>
    /// Поиск локализованной строки, используется для пометки строки как локализуемой
    /// </summary>
    /// <param name="ignoreTranslationMode">Игнорировать режим перевода</param>
    internal static string T(string t, bool ignoreTranslationMode)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ignoreTranslationMode)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) SR.T3pY1vf9p5wOaHT2d3p((object) null, (object) t);
label_5:
      return (string) SR.zQj0ibfrmOi0M6BSYOP((object) t);
    }

    /// <summary>
    /// Поиск локализованной строки с форматированием, используется для пометки строки как локализуемой
    /// </summary>
    /// <param name="ignoreTranslationMode">Игнорировать режим перевода</param>
    internal static string T(bool ignoreTranslationMode, string t, params object[] parameters)
    {
      int num = 7;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!SR.xhtPxdEs9nG9CKwHKbx((object) t))
            {
              num = 5;
              continue;
            }
            goto label_6;
          case 2:
            goto label_4;
          case 3:
            goto label_3;
          case 4:
            t = (string) SR.tLHZIffyaOOFFY10KCT((object) t);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 1;
            continue;
          case 5:
            if (!SR.dHmVm3fgQQ816kwVw9V())
            {
              num = 2;
              continue;
            }
            goto label_3;
          case 6:
            goto label_5;
          case 7:
            if (!ignoreTranslationMode)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 6 : 6;
              continue;
            }
            goto case 4;
          default:
            goto label_6;
        }
      }
label_3:
      return (string) SR.lc8hOAE1sRHAJUqTiBu((object) GuiLocalizationUtility.TemplateInCodeRes, (object) t);
label_4:
      return (string) SR.KcN3P6f5Q33p7saMZkQ(SR.T3pY1vf9p5wOaHT2d3p((object) null, (object) t), (object) parameters);
label_5:
      return SR.T(t, parameters);
label_6:
      return t;
    }

    public static bool Is12Hours => ((string) SR.Yu5m4rfjUyiwlEs6QHV((object) ((CultureInfo) SR.ENoAQ5fRxFpE3Db0aA0(SR.ilBR3WfS9bcKJDpOKiS())).DateTimeFormat)).Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909175911));

    private static bool ContainsNonPrintable(object source)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        char ch;
        UnicodeCategory unicodeCategory;
        int index;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (unicodeCategory != UnicodeCategory.OtherNotAssigned)
              {
                ++index;
                num2 = 16;
                continue;
              }
              num2 = 11;
              continue;
            case 2:
            case 13:
              ch = str[index];
              num2 = 6;
              continue;
            case 3:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
              continue;
            case 4:
              str = (string) source;
              num2 = 3;
              continue;
            case 5:
              if ((uint) (unicodeCategory - 12) <= 2U)
              {
                num2 = 9;
                continue;
              }
              goto case 1;
            case 6:
              if (ch > '\'')
              {
                num2 = 12;
                continue;
              }
              goto case 8;
            case 7:
              goto label_4;
            case 8:
              switch (ch)
              {
                case char.MinValue:
                case '\a':
                case '\b':
                case '\t':
                case '\n':
                case '\v':
                case '\f':
                case '\r':
                  goto label_3;
                case '\u0001':
                case '\u0002':
                case '\u0003':
                case '\u0004':
                case '\u0005':
                case '\u0006':
                  goto label_4;
                default:
                  num2 = 10;
                  continue;
              }
            case 9:
            case 11:
              goto label_5;
            case 10:
              goto label_27;
            case 12:
            case 19:
              if (ch != '<')
              {
                num2 = 14;
                continue;
              }
              goto label_3;
            case 14:
              if (ch != '>')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 17 : 17;
                continue;
              }
              goto label_3;
            case 15:
              goto label_3;
            case 17:
              if (ch == '\\')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 15;
                continue;
              }
              goto label_4;
            case 18:
              goto label_10;
            default:
              if (index < SR.GBJ0shfYcW1fDaoXcPi((object) str))
              {
                num2 = 13;
                continue;
              }
              goto label_10;
          }
        }
label_4:
        unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(ch);
        num1 = 5;
        continue;
label_27:
        if (ch != '\'')
          num1 = 7;
        else
          break;
      }
label_3:
      return true;
label_5:
      return true;
label_10:
      return false;
    }

    private static string EscapeNonPrintable(object source, char quoteChar = '\'', bool includeLetter = false)
    {
      int num1 = 2;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        UnicodeCategory unicodeCategory;
        int num3;
        char ch;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              SR.GdnoxofLlnwDOdyW7KX((object) stringBuilder, quoteChar);
              num2 = 9;
              continue;
            case 2:
              stringBuilder = new StringBuilder();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
              continue;
            case 3:
              switch (ch)
              {
                case char.MinValue:
                  goto label_50;
                case '\u0001':
                case '\u0002':
                case '\u0003':
                case '\u0004':
                case '\u0005':
                case '\u0006':
                  goto label_42;
                case '\a':
                  goto label_7;
                case '\b':
                  goto label_3;
                case '\t':
                  goto label_22;
                case '\n':
                  goto label_33;
                case '\v':
                  goto label_11;
                case '\f':
                  goto label_18;
                case '\r':
                  goto label_44;
                default:
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 10 : 5;
                  continue;
              }
            case 5:
label_3:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder, SR.vrPDjpEk9ZyFJxtBPVT(1242972401 >> 4 ^ 77691721));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 48 : 28;
              continue;
            case 7:
label_11:
              stringBuilder.Append((string) SR.vrPDjpEk9ZyFJxtBPVT(1654249598 >> 2 ^ 413559153));
              num2 = 30;
              continue;
            case 8:
              if (ch != '\\')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 26 : 50;
                continue;
              }
              goto case 28;
            case 9:
              str = (string) source;
              num2 = 12;
              continue;
            case 10:
              if (ch != '<')
              {
                num2 = 36;
                continue;
              }
              goto case 22;
            case 11:
            case 38:
              if (num3 < SR.GBJ0shfYcW1fDaoXcPi((object) str))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 16 : 13;
                continue;
              }
              goto case 19;
            case 12:
              num3 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 36 : 38;
              continue;
            case 14:
              goto label_19;
            case 15:
            case 36:
            case 50:
label_42:
              if (SR.escapeQuote)
              {
                num2 = 33;
                continue;
              }
              goto case 29;
            case 16:
            case 24:
              ch = SR.mAw3SifUOge9U7pspLw((object) str, num3);
              num2 = 23;
              continue;
            case 18:
              goto label_36;
            case 19:
              SR.GdnoxofLlnwDOdyW7KX((object) stringBuilder, quoteChar);
              num2 = 18;
              continue;
            case 20:
              switch (unicodeCategory)
              {
                case UnicodeCategory.LineSeparator:
                case UnicodeCategory.ParagraphSeparator:
                case UnicodeCategory.Control:
                  goto label_39;
                default:
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 47 : 33;
                  continue;
              }
            case 22:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder, SR.vrPDjpEk9ZyFJxtBPVT(-1204263869 ^ -1341583247 ^ 137456444));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 17 : 5;
              continue;
            case 23:
              if (ch <= '<')
              {
                num2 = 3;
                continue;
              }
              goto case 37;
            case 25:
label_33:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder, SR.vrPDjpEk9ZyFJxtBPVT(-630932142 - 1120244082 ^ -1751173962));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
              continue;
            case 27:
label_18:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539362561));
              num2 = 21;
              continue;
            case 28:
              stringBuilder.Append((string) SR.vrPDjpEk9ZyFJxtBPVT(-542721635 ^ -542726477));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 54 : 8;
              continue;
            case 29:
              unicodeCategory = SR.RX7sHTfc8uwHWHVfGa8(ch);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 9 : 20;
              continue;
            case 32:
label_50:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder, SR.vrPDjpEk9ZyFJxtBPVT(1051276242 - 990076387 ^ 61197017));
              num2 = 39;
              continue;
            case 33:
              if ((int) ch == (int) quoteChar)
              {
                num2 = 41;
                continue;
              }
              goto case 29;
            case 34:
label_39:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder, (object) ((string) SR.vrPDjpEk9ZyFJxtBPVT(381945751 ^ 1158627804 ^ 1405835575) + ((int) ch).ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137456566))));
              num2 = 13;
              continue;
            case 35:
            case 42:
              stringBuilder.Append(ch);
              num2 = 44;
              continue;
            case 37:
              if (ch != '>')
              {
                num2 = 8;
                continue;
              }
              goto label_19;
            case 41:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder, SR.wjOd72f69ggE1fcKUeJ(SR.vrPDjpEk9ZyFJxtBPVT(2045296739 + 1688595713 ^ -561073646), (object) quoteChar.ToString()));
              num2 = 40;
              continue;
            case 43:
label_7:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder, SR.vrPDjpEk9ZyFJxtBPVT(-477139494 ^ -477138204));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 6 : 6;
              continue;
            case 45:
              if (includeLetter)
              {
                num2 = 53;
                continue;
              }
              goto case 35;
            case 46:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder, (object) ((string) SR.vrPDjpEk9ZyFJxtBPVT(-97972138 ^ -97972438) + ((int) ch).ToString((string) SR.vrPDjpEk9ZyFJxtBPVT(516838154 ^ 516836494))));
              num2 = 4;
              continue;
            case 47:
              if (unicodeCategory == UnicodeCategory.OtherNotAssigned)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 16 : 34;
                continue;
              }
              goto case 45;
            case 51:
label_22:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97972432));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 49 : 20;
              continue;
            case 52:
              goto label_44;
            case 53:
              if (!SR.U39iKrfz4PTIVB4xC3n(ch))
              {
                num2 = 35;
                continue;
              }
              goto case 46;
            default:
              ++num3;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 11 : 2;
              continue;
          }
        }
label_19:
        SR.plrWIZfsunMGnoDbsC4((object) stringBuilder, SR.vrPDjpEk9ZyFJxtBPVT(993438473 ^ 993440791));
        num1 = 31;
        continue;
label_44:
        SR.plrWIZfsunMGnoDbsC4((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978478676));
        num1 = 26;
      }
label_36:
      return stringBuilder.ToString();
    }

    private static string UnEscapeNonPrintable(object source)
    {
      int num1 = 1;
      StringBuilder stringBuilder1;
      IEnumerator<char> enumerator;
      StringBuilder stringBuilder2;
      bool flag;
      while (true)
      {
        switch (num1)
        {
          case 1:
            stringBuilder1 = new StringBuilder();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_5;
          case 4:
            stringBuilder2 = (StringBuilder) null;
            num1 = 5;
            continue;
          case 5:
            enumerator = ((IEnumerable<char>) source).Skip<char>(1).Take<char>(SR.GBJ0shfYcW1fDaoXcPi(source) - 2).GetEnumerator();
            num1 = 3;
            continue;
          default:
            flag = false;
            num1 = 4;
            continue;
        }
      }
label_3:
      return stringBuilder1.ToString();
label_5:
      try
      {
label_12:
        if (SR.D7yccqEcy1QouE1npyx((object) enumerator))
          goto label_35;
        else
          goto label_13;
label_7:
        char current;
        int num2;
        while (true)
        {
          int num3;
          int num4;
          switch (num2)
          {
            case 1:
              flag = false;
              num2 = 40;
              continue;
            case 2:
              if (current <= '\'')
              {
                num2 = 28;
                continue;
              }
              goto case 38;
            case 3:
              SR.GdnoxofLlnwDOdyW7KX((object) stringBuilder1, current);
              num3 = 32;
              break;
            case 4:
label_46:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder1, SR.vrPDjpEk9ZyFJxtBPVT(-2138958856 ^ -2138960814));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 57 : 16;
              continue;
            case 5:
            case 9:
            case 13:
            case 18:
            case 22:
            case 26:
            case 27:
            case 31:
            case 32:
            case 37:
            case 42:
            case 44:
            case 45:
            case 55:
            case 57:
              goto label_12;
            case 6:
            case 19:
              if (current > 'b')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 34 : 23;
                continue;
              }
              goto case 25;
            case 7:
label_44:
              stringBuilder2 = new StringBuilder();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 2 : 26;
              continue;
            case 8:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder1, SR.vrPDjpEk9ZyFJxtBPVT(-1852837372 ^ -1852838502));
              num2 = 18;
              continue;
            case 10:
              if (current != '\'')
              {
                num3 = 29;
                break;
              }
              goto case 53;
            case 11:
              goto label_3;
            case 12:
              if (current != 'b')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 9 : 15;
                continue;
              }
              goto case 49;
            case 14:
label_22:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder1, SR.vrPDjpEk9ZyFJxtBPVT(979449278 ^ 979446286));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 4 : 5;
              continue;
            case 16:
              SR.GdnoxofLlnwDOdyW7KX((object) stringBuilder1, SR.bGbNKNQWXtGNaXiJC0b(num4));
              num2 = 27;
              continue;
            case 17:
label_30:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239573550));
              num2 = 45;
              continue;
            case 20:
            case 34:
              if (current != 'f')
              {
                num2 = 51;
                continue;
              }
              goto case 8;
            case 21:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 44 : 11;
              continue;
            case 23:
              goto label_35;
            case 25:
              if (current != 'a')
              {
                num2 = 12;
                continue;
              }
              goto case 48;
            case 28:
              if (current != '"')
              {
                num2 = 10;
                continue;
              }
              goto case 46;
            case 30:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder1, SR.vrPDjpEk9ZyFJxtBPVT(132912447 ^ 132909747));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 42 : 18;
              continue;
            case 35:
              if (current != '\\')
              {
                num2 = 24;
                continue;
              }
              goto case 56;
            case 36:
label_33:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder1, SR.vrPDjpEk9ZyFJxtBPVT(~1767720452 ^ -1767725309));
              num3 = 31;
              break;
            case 38:
              if (current != '0')
              {
                num2 = 35;
                continue;
              }
              goto case 30;
            case 39:
              stringBuilder2.Append(current);
              num2 = 43;
              continue;
            case 40:
              if (current > '\\')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 19 : 3;
                continue;
              }
              goto case 2;
            case 43:
              if (SR.lvI4olQF7albnw00yWR((object) stringBuilder2) == 4)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 50 : 31;
                continue;
              }
              goto label_12;
            case 46:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder1, SR.vrPDjpEk9ZyFJxtBPVT(572119659 - -337058038 ^ 909176377));
              num3 = 13;
              break;
            case 47:
              if (!flag)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 40 : 41;
                continue;
              }
              goto case 1;
            case 48:
              stringBuilder1.Append((string) SR.vrPDjpEk9ZyFJxtBPVT(1051802738 - -1831968059 ^ -1411201473));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 15 : 22;
              continue;
            case 49:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669215747));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 5 : 37;
              continue;
            case 50:
              num4 = SR.wgXXaUQBOF1cAnNgoe3((object) stringBuilder2.ToString(), 16);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 11 : 52;
              continue;
            case 51:
              switch (current)
              {
                case 'n':
                  goto label_30;
                case 'o':
                case 'p':
                case 'q':
                case 's':
                  goto label_47;
                case 'r':
                  goto label_33;
                case 't':
                  goto label_46;
                case 'u':
                  goto label_44;
                case 'v':
                  goto label_22;
                default:
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                  continue;
              }
            case 52:
              stringBuilder2 = (StringBuilder) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 3 : 16;
              continue;
            case 53:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder1, SR.vrPDjpEk9ZyFJxtBPVT(1113862659 ^ 1113861981));
              num2 = 9;
              continue;
            case 54:
              if (stringBuilder2 != null)
              {
                num2 = 39;
                continue;
              }
              goto case 47;
            case 56:
              SR.plrWIZfsunMGnoDbsC4((object) stringBuilder1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345419086));
              num2 = 55;
              continue;
            default:
label_47:
              if (current == '\\')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 21 : 4;
                continue;
              }
              goto case 3;
          }
          num2 = num3;
        }
label_13:
        num2 = 11;
        goto label_7;
label_35:
        current = enumerator.Current;
        num2 = 54;
        goto label_7;
      }
      finally
      {
        if (enumerator != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                SR.fNbGRaEzWbfbl76JXxQ((object) enumerator);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                continue;
              default:
                goto label_65;
            }
          }
        }
label_65:;
      }
    }

    /// <summary>
    /// Поиск локализованной строки, используется для пометки строки как локализуемой
    /// </summary>
    public static string T(CultureInfo info, string t)
    {
      int num1 = 6;
      string str;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!SR.L0PxKdQhr7FZKQO4hnp((object) t))
              {
                num2 = 9;
                continue;
              }
              goto label_25;
            case 2:
              goto label_25;
            case 3:
              goto label_3;
            case 4:
              goto label_12;
            case 5:
              t = (string) SR.tLHZIffyaOOFFY10KCT((object) t);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 8 : 5;
              continue;
            case 6:
              if (!SR.futureTranslate)
              {
                num2 = 5;
                continue;
              }
              goto case 11;
            case 7:
              if (SR.uMfBKQQbd5qoCDWUgJN(SR.RuhSxJQopS7Z6nEKkOA((object) t), (object) ""))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
                continue;
              }
              goto case 14;
            case 8:
              if (!GuiLocalizationUtility.DesignMode)
              {
                num2 = 13;
                continue;
              }
              goto label_13;
            case 10:
              if (SR.xhtPxdEs9nG9CKwHKbx((object) str))
              {
                num2 = 4;
                continue;
              }
              goto label_11;
            case 11:
              if (t != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 5 : 7;
                continue;
              }
              goto label_24;
            case 12:
              goto label_4;
            case 13:
              if (!string.IsNullOrEmpty(t))
              {
                num2 = 12;
                continue;
              }
              goto label_3;
            case 14:
              if (!SR.ContainsKey((object) t, SR.vrPDjpEk9ZyFJxtBPVT(1514961705 ^ 1514955153)))
              {
                num2 = 2;
                continue;
              }
              goto case 1;
            case 15:
              goto label_11;
            default:
              goto label_24;
          }
        }
label_4:
        str = (string) SR.tLcP3gQGa9N3dZwprrk((object) t, (object) info);
        num1 = 10;
      }
label_3:
      return t;
label_11:
      return (string) SR.kwlvTKQEEHO8sfth8N8((object) info, (object) str);
label_12:
      return BrandResourceManager.R((CultureInfo) null, t);
label_13:
      return (string) SR.lc8hOAE1sRHAJUqTiBu((object) GuiLocalizationUtility.TemplateInCodeRes, (object) t);
label_24:
      return t;
label_25:
      return (string) SR.EcubNPE2ApKSGDnHF26(SR.vrPDjpEk9ZyFJxtBPVT(-1426456882 ^ 2009939514 ^ -583738804), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757129352), (object) SR.EscapeNonPrintable(SR.tLHZIffyaOOFFY10KCT((object) t)), SR.vrPDjpEk9ZyFJxtBPVT(-281842504 ^ -281840892));
    }

    /// <summary>
    /// Поиск локализованной строки с форматированием, используется для пометки строки как локализуемой
    /// </summary>
    public static string T(string t, params object[] parameters) => SR.T((CultureInfo) null, t, parameters);

    /// <summary>
    /// Поиск локализованной строки с форматированием, используется для пометки строки как локализуемой
    /// </summary>
    public static string T(CultureInfo info, string t, params object[] parameters)
    {
      int num1 = 31;
      List<string> stringList;
      string str1;
      string str2;
      object[] array;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          long int64;
          string translateLocalization;
          IUser user;
          CultureInfo cultureInfo;
          List<int> indexes;
          switch (num2)
          {
            case 1:
              translateLocalization = ((TranslateService) SR.uEWa04fxBoxFsQt26MC()).GetTranslateLocalization(new long?(int64));
              num2 = 23;
              continue;
            case 2:
              if (!((TranslateService) SR.uEWa04fxBoxFsQt26MC()).InLineDisabled)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 28 : 28;
                continue;
              }
              goto case 10;
            case 3:
              try
              {
                SR.aK4YNSfJnhP1R3eYIp2((object) TranslateService.Instance, true);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_26;
                    default:
                      user = (IUser) SR.VtfQ4sfMxRLjSLso1ML();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
                      continue;
                  }
                }
              }
              finally
              {
                SR.aK4YNSfJnhP1R3eYIp2((object) TranslateService.Instance, false);
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 4:
              if (stringList[2] != null)
              {
                num2 = 42;
                continue;
              }
              goto case 21;
            case 5:
              goto label_43;
            case 6:
              goto label_70;
            case 7:
              goto label_28;
            case 8:
              cultureInfo = (CultureInfo) SR.OE4XD9fZcGLeABfJ5Cx((object) user);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
              continue;
            case 9:
              if (t != null)
              {
                num2 = 39;
                continue;
              }
              goto label_67;
            case 10:
            case 26:
            case 38:
              if (!GuiLocalizationUtility.DesignMode)
              {
                num2 = 24;
                continue;
              }
              goto label_43;
            case 11:
              if (!Locator.Initialized)
              {
                num2 = 10;
                continue;
              }
              goto case 15;
            case 12:
              user = (IUser) null;
              num2 = 3;
              continue;
            case 13:
            case 32:
              goto label_67;
            case 14:
              if (!TranslateService.Instance.IsTranslationModeEnabled(new long?(int64)))
              {
                num2 = 38;
                continue;
              }
              goto case 36;
            case 15:
              if (Locator.GetService<TranslateService>() != null)
              {
                num2 = 2;
                continue;
              }
              goto case 10;
            case 16:
              array = ((IEnumerable<object>) parameters).Select<object, object>((Func<object, int, object>) ((p, i) =>
              {
                int num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      if (indexes.Contains(i))
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_2;
                    case 2:
                      goto label_2;
                    default:
                      goto label_3;
                  }
                }
label_2:
                return (object) null;
label_3:
                return p;
              })).Select<object, object>((Func<object, object>) (p =>
              {
                int num6 = 2;
                object obj1;
                while (true)
                {
                  int num7 = num6;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        goto label_7;
                      case 2:
                        if (p is string)
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
                          continue;
                        }
                        goto case 3;
                      case 3:
                        obj1 = p;
                        if (obj1 == null)
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_12;
                      default:
                        goto label_9;
                    }
                  }
label_7:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (!SR.\u003C\u003Ec.jkOQR6fHJ5ElPMUA8pwL((object) (string) p, SR.\u003C\u003Ec.H98icRfHHX1gVBH9UoAp(-812025778 ^ -812031242)))
                    num6 = 3;
                  else
                    goto label_11;
                }
label_9:
                object obj2 = (object) "";
label_10:
                return (object) SR.EscapeNonPrintable((object) obj2.ToString());
label_12:
                obj2 = obj1;
                goto label_10;
label_11:
                return p;
              })).ToArray<object>();
              num2 = 6;
              continue;
            case 17:
              int64 = Convert.ToInt64(SR.zuAjLGfdMObPvKu1wGJ((object) user));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 11 : 14;
              continue;
            case 18:
              t = (string) SR.tLHZIffyaOOFFY10KCT((object) t);
              num2 = 12;
              continue;
            case 19:
              stringList[3] = SR.dHmVm3fgQQ816kwVw9V() ? (string) SR.lc8hOAE1sRHAJUqTiBu((object) GuiLocalizationUtility.TemplateInCodeRes, (object) stringList[3]) : (string) SR.KcN3P6f5Q33p7saMZkQ((object) SR.T(info, stringList[3]), (object) parameters);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 6 : 29;
              continue;
            case 20:
              str2 = stringList[2];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 27 : 6;
              continue;
            case 21:
              if (stringList[3] != null)
              {
                num2 = 19;
                continue;
              }
              goto label_61;
            case 22:
              if (SR.ContainsKey((object) t, SR.vrPDjpEk9ZyFJxtBPVT(1819636893 << 3 ^ 1672199760)))
              {
                num2 = 34;
                continue;
              }
              break;
            case 23:
              stringList = ((TranslateService) SR.uEWa04fxBoxFsQt26MC()).TA((string) SR.ER5pPiE9h18lxXF0djO((object) cultureInfo), translateLocalization, t, SR.pu1oHZflZBnsDtK8WKB((object) TranslateService.Instance));
              num2 = 41;
              continue;
            case 24:
              goto label_44;
            case 25:
              if (!SR.dHmVm3fgQQ816kwVw9V())
              {
                num2 = 37;
                continue;
              }
              goto label_64;
            case 27:
              str1 = stringList[3];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 4 : 3;
              continue;
            case 28:
              if (!SR.asXlO1fmyP1EGNujCPc((object) TranslateService.Instance))
              {
                num2 = 26;
                continue;
              }
              goto case 18;
            case 29:
              goto label_61;
            case 30:
              if (!string.IsNullOrEmpty(t))
              {
                if (SR.JcbhQkf7EkwLGkp7urB())
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 11 : 3;
                  continue;
                }
                goto case 10;
              }
              else
              {
                num2 = 7;
                continue;
              }
            case 31:
              if (!SR.futureTranslate)
              {
                num2 = 30;
                continue;
              }
              goto case 40;
            case 33:
              goto label_17;
            case 34:
              if (SR.L0PxKdQhr7FZKQO4hnp((object) t))
                break;
              goto label_22;
            case 35:
label_26:
              if (user != null)
              {
                num2 = 17;
                continue;
              }
              goto case 25;
            case 36:
              if (!SR.xhtPxdEs9nG9CKwHKbx((object) t))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 6 : 8;
                continue;
              }
              goto label_35;
            case 37:
              goto label_65;
            case 39:
              if (SR.uMfBKQQbd5qoCDWUgJN(SR.RuhSxJQopS7Z6nEKkOA((object) t), (object) ""))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 31 : 32;
                continue;
              }
              goto case 22;
            case 40:
              num2 = 9;
              continue;
            case 41:
              if (stringList.Count == 5)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 20 : 7;
                continue;
              }
              if (SR.dHmVm3fgQQ816kwVw9V())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 5 : 33;
                continue;
              }
              goto label_18;
            case 42:
              stringList[2] = SR.dHmVm3fgQQ816kwVw9V() ? (string) SR.lc8hOAE1sRHAJUqTiBu((object) GuiLocalizationUtility.TemplateInCodeRes, (object) stringList[2]) : string.Format((string) SR.T3pY1vf9p5wOaHT2d3p((object) info, (object) stringList[2]), parameters);
              num2 = 21;
              continue;
            case 43:
              goto label_35;
            default:
              goto label_64;
          }
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          indexes = ((IEnumerable) SR.qIjWcfQf5rSBCxJxJoT((object) SR.formatParse, (object) t)).Cast<Match>().Select<Match, int>((Func<Match, int>) (m => SR.\u003C\u003Ec.wLlxIhfHM39thZ0ROU6P((object) ((Capture) SR.\u003C\u003Ec.Uhc1FvfHyPI7uMWNp5IF(SR.\u003C\u003Ec.EcU2EpfHmwgk0iF3vRxV((object) m), SR.\u003C\u003Ec.H98icRfHHX1gVBH9UoAp(44884861 ^ 44903945))).Value))).ToList<int>();
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 16 : 4;
        }
label_22:
        num1 = 13;
      }
label_17:
      return (string) SR.lc8hOAE1sRHAJUqTiBu((object) GuiLocalizationUtility.TemplateInCodeRes, (object) stringList[0]);
label_18:
      return (string) SR.KcN3P6f5Q33p7saMZkQ(SR.T3pY1vf9p5wOaHT2d3p((object) info, (object) stringList[0]), (object) parameters);
label_28:
      return t;
label_35:
      return t;
label_43:
      return (string) SR.lc8hOAE1sRHAJUqTiBu((object) GuiLocalizationUtility.TemplateInCodeRes, (object) t);
label_44:
      return string.Format((string) SR.T3pY1vf9p5wOaHT2d3p((object) info, (object) t), parameters);
label_61:
      return string.Format((string) SR.vrPDjpEk9ZyFJxtBPVT(-2112703338 ^ -2112705708), (object) stringList[0], (object) stringList[1], (object) stringList[2], (object) stringList[3], (object) str2, (object) str1, (object) stringList[4]);
label_64:
      return (string) SR.lc8hOAE1sRHAJUqTiBu((object) GuiLocalizationUtility.TemplateInCodeRes, (object) t);
label_65:
      return (string) SR.KcN3P6f5Q33p7saMZkQ(SR.T3pY1vf9p5wOaHT2d3p((object) info, (object) t), (object) parameters);
label_67:
      return t;
label_70:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (string) SR.PmLX0FQQHgEiCT6txmq((object) new string[5]
      {
        (string) SR.vrPDjpEk9ZyFJxtBPVT(964881585 - -1459193222 ^ -1870894961),
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3327060),
        SR.EscapeNonPrintable(SR.tLHZIffyaOOFFY10KCT((object) t)),
        string.Concat(((IEnumerable<object>) array).Select<object, string>((Func<object, string>) (v => (string) SR.\u003C\u003Ec.jdjjCPfH9SSvAYh9xJbg(SR.\u003C\u003Ec.H98icRfHHX1gVBH9UoAp(-1852837372 ^ -1852834298), v)))),
        (string) SR.vrPDjpEk9ZyFJxtBPVT(-1921202237 ^ -1921197953)
      });
    }

    public static string PreparedTranslate(string resource)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        bool needRepeat;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              goto label_8;
            case 3:
              if (needRepeat)
              {
                num2 = 4;
                continue;
              }
              goto case 5;
            case 4:
            case 9:
              needRepeat = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 1;
              continue;
            case 5:
              string str = resource;
              string translateSrtParse3 = SR.futureTranslateSRTParse3;
              // ISSUE: reference to a compiler-generated field
              MatchEvaluator matchEvaluator1 = SR.\u003C\u003Ec.\u003C\u003E9__84_2;
              MatchEvaluator matchEvaluator2;
              if (matchEvaluator1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                SR.\u003C\u003Ec.\u003C\u003E9__84_2 = matchEvaluator2 = (MatchEvaluator) (m =>
                {
                  int num3 = 1;
                  Match m1;
                  Group tGroup;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_8;
                      case 3:
                        goto label_7;
                      case 4:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        tGroup = (Group) SR.\u003C\u003Ec.Uhc1FvfHyPI7uMWNp5IF((object) m1.Groups, SR.\u003C\u003Ec.H98icRfHHX1gVBH9UoAp(654297945 ^ 654223803));
                        num3 = 5;
                        continue;
                      case 5:
                        if (tGroup.Success)
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 2 : 2;
                          continue;
                        }
                        goto label_7;
                      default:
                        m1 = m;
                        num3 = 4;
                        continue;
                    }
                  }
label_7:
                  return m1.Value;
label_8:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: object of a compiler-generated type is created
                  IEnumerable<\u003C\u003Ef__AnonymousType24<int, int, string>> source = ((Group) SR.\u003C\u003Ec.Uhc1FvfHyPI7uMWNp5IF(SR.\u003C\u003Ec.EcU2EpfHmwgk0iF3vRxV((object) m1), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272272195))).Captures.Cast<Capture>().Select((c, i) => new \u003C\u003Ef__AnonymousType24<int, int, string>(c.Index - m1.Index, c.Length, tGroup.Captures[i].Value));
                  // ISSUE: reference to a compiler-generated field
                  Func<\u003C\u003Ef__AnonymousType24<int, int, string>, int> func = SR.\u003C\u003Ec.\u003C\u003E9__84_14;
                  Func<\u003C\u003Ef__AnonymousType24<int, int, string>, int> keySelector;
                  if (func == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    SR.\u003C\u003Ec.\u003C\u003E9__84_14 = keySelector = c => c.Index;
                  }
                  else
                    goto label_11;
label_10:
                  return source.OrderByDescending(keySelector).Aggregate(m1.Value, (text, c) => text.Remove(c.Index, c.Length).Insert(c.Index, SR.T(SR.UnEscapeNonPrintable((object) c.t))));
label_11:
                  keySelector = func;
                  goto label_10;
                });
              }
              else
                goto label_19;
label_18:
              resource = (string) SR.XgpVseQCOibmASoYadl((object) str, (object) translateSrtParse3, (object) matchEvaluator2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 6 : 6;
              continue;
label_19:
              matchEvaluator2 = matchEvaluator1;
              goto label_18;
            case 6:
              needRepeat = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 10 : 2;
              continue;
            case 7:
              string input = resource;
              string translateSrtParse1 = SR.futureTranslateSRTParse1;
              // ISSUE: reference to a compiler-generated field
              MatchEvaluator matchEvaluator3 = SR.\u003C\u003Ec.\u003C\u003E9__84_0;
              MatchEvaluator evaluator;
              if (matchEvaluator3 == null)
              {
                // ISSUE: reference to a compiler-generated field
                SR.\u003C\u003Ec.\u003C\u003E9__84_0 = evaluator = (MatchEvaluator) (m =>
                {
                  int num4 = 5;
                  Match m2;
                  Group tGroup;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        if (SR.\u003C\u003Ec.F4VOYjfHdDDEl5FmKjfW((object) tGroup))
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 1;
                          continue;
                        }
                        goto label_8;
                      case 2:
                        goto label_9;
                      case 3:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        tGroup = (Group) SR.\u003C\u003Ec.Uhc1FvfHyPI7uMWNp5IF(SR.\u003C\u003Ec.EcU2EpfHmwgk0iF3vRxV((object) m2), SR.\u003C\u003Ec.H98icRfHHX1gVBH9UoAp(-244066886 - -48452443 ^ -195671049));
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
                        continue;
                      case 4:
                        m2 = m;
                        num4 = 3;
                        continue;
                      case 5:
                        num4 = 4;
                        continue;
                      default:
                        goto label_8;
                    }
                  }
label_8:
                  return m2.Value;
label_9:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: object of a compiler-generated type is created
                  IEnumerable<\u003C\u003Ef__AnonymousType24<int, int, string>> source1 = ((IEnumerable) SR.\u003C\u003Ec.NKRL02fHl60i3m3e5WZh(SR.\u003C\u003Ec.Uhc1FvfHyPI7uMWNp5IF(SR.\u003C\u003Ec.EcU2EpfHmwgk0iF3vRxV((object) m2), SR.\u003C\u003Ec.H98icRfHHX1gVBH9UoAp(1505778440 - 1981636111 ^ -475554097)))).Cast<Capture>().Select((c, i) => new \u003C\u003Ef__AnonymousType24<int, int, string>(c.Index - m2.Index, c.Length, tGroup.Captures[i].Value));
                  // ISSUE: reference to a compiler-generated field
                  Func<\u003C\u003Ef__AnonymousType24<int, int, string>, int> func1 = SR.\u003C\u003Ec.\u003C\u003E9__84_5;
                  Func<\u003C\u003Ef__AnonymousType24<int, int, string>, int> keySelector;
                  if (func1 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    SR.\u003C\u003Ec.\u003C\u003E9__84_5 = keySelector = c => c.Index;
                  }
                  else
                    goto label_14;
label_11:
                  IOrderedEnumerable<\u003C\u003Ef__AnonymousType24<int, int, string>> source2 = source1.OrderByDescending(keySelector);
                  // ISSUE: reference to a compiler-generated method
                  object seed = SR.\u003C\u003Ec.Ilo3EgfHrf1dqpNGvgpn((object) m2);
                  // ISSUE: reference to a compiler-generated field
                  Func<string, \u003C\u003Ef__AnonymousType24<int, int, string>, string> func2 = SR.\u003C\u003Ec.\u003C\u003E9__84_6;
                  Func<string, \u003C\u003Ef__AnonymousType24<int, int, string>, string> func3;
                  if (func2 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    SR.\u003C\u003Ec.\u003C\u003E9__84_6 = func3 = (text, c) => text.Remove(c.Index, c.Length).Insert(c.Index, SR.EscapeNonPrintable((object) SR.T(SR.UnEscapeNonPrintable((object) c.t))));
                  }
                  else
                    goto label_2;
label_13:
                  return source2.Aggregate((string) seed, func3);
label_2:
                  func3 = func2;
                  goto label_13;
label_14:
                  keySelector = func1;
                  goto label_11;
                });
              }
              else
                goto label_20;
label_15:
              resource = Regex.Replace(input, translateSrtParse1, evaluator);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 9 : 9;
              continue;
label_20:
              evaluator = matchEvaluator3;
              goto label_15;
            case 8:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 7 : 6;
              continue;
            case 10:
              resource = (string) SR.XgpVseQCOibmASoYadl((object) resource, (object) SR.futureTranslateSRTParse4, (object) (MatchEvaluator) (m =>
              {
                int num5 = 2;
                Match m3;
                Group tGroup;
                \u003C\u003Ef__AnonymousType25<int, int, string>[] pCaptures;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      m3 = m;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
                      continue;
                    case 2:
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 1;
                      continue;
                    case 3:
                      goto label_12;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      if (SR.\u003C\u003Ec__DisplayClass84_0.q0m899fADgq7VP7c6v0v((object) tGroup))
                      {
                        needRepeat = true;
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 6;
                        continue;
                      }
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 2 : 5;
                      continue;
                    case 5:
                      goto label_4;
                    case 6:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      IEnumerable<Capture> source3 = ((Group) SR.\u003C\u003Ec__DisplayClass84_0.X9Lox4fAwON7vq3Hx94l((object) m3.Groups, SR.\u003C\u003Ec__DisplayClass84_0.jVFbV2fAaTi9PsedZ7QT(1033719030 - 2012070891 ^ -978369581))).Captures.Cast<Capture>();
                      // ISSUE: reference to a compiler-generated field
                      Func<Capture, \u003C\u003Ef__AnonymousType25<int, int, string>> func4 = SR.\u003C\u003Ec.\u003C\u003E9__84_16;
                      Func<Capture, \u003C\u003Ef__AnonymousType25<int, int, string>> selector;
                      if (func4 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: object of a compiler-generated type is created
                        SR.\u003C\u003Ec.\u003C\u003E9__84_16 = selector = c => new \u003C\u003Ef__AnonymousType25<int, int, string>(c.Index, c.Index + c.Length - 1, c.Value);
                      }
                      else
                        goto label_19;
label_11:
                      pCaptures = source3.Select(selector).ToArray();
                      num5 = 3;
                      continue;
label_19:
                      selector = func4;
                      goto label_11;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      tGroup = ((GroupCollection) SR.\u003C\u003Ec__DisplayClass84_0.VE27ulfApErGBDpyFO8Z((object) m3))[z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222072220)];
                      num5 = 4;
                      continue;
                  }
                }
label_4:
                // ISSUE: reference to a compiler-generated method
                return (string) SR.\u003C\u003Ec__DisplayClass84_0.nsBVpqfAtPgOpJNGSs03((object) m3);
label_12:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: object of a compiler-generated type is created
                IEnumerable<\u003C\u003Ef__AnonymousType26<int, int, string, IEnumerable<string>>> source4 = ((IEnumerable) SR.\u003C\u003Ec__DisplayClass84_0.t2RXwqfA4r1Oh1Qfq9LD(SR.\u003C\u003Ec__DisplayClass84_0.X9Lox4fAwON7vq3Hx94l(SR.\u003C\u003Ec__DisplayClass84_0.VE27ulfApErGBDpyFO8Z((object) m3), SR.\u003C\u003Ec__DisplayClass84_0.jVFbV2fAaTi9PsedZ7QT(-542721635 ^ -542909525)))).Cast<Capture>().Select((c, i) => new \u003C\u003Ef__AnonymousType26<int, int, string, IEnumerable<string>>(c.Index - m3.Index, c.Length, tGroup.Captures[i].Value, pCaptures.Where(p => p.StartIndex >= c.Index && p.StopIndex < c.Index + c.Length).Select(p => p.Value)));
                // ISSUE: reference to a compiler-generated field
                Func<\u003C\u003Ef__AnonymousType26<int, int, string, IEnumerable<string>>, int> func5 = SR.\u003C\u003Ec.\u003C\u003E9__84_18;
                Func<\u003C\u003Ef__AnonymousType26<int, int, string, IEnumerable<string>>, int> keySelector;
                if (func5 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  SR.\u003C\u003Ec.\u003C\u003E9__84_18 = keySelector = c => c.Index;
                }
                else
                  goto label_18;
label_14:
                IOrderedEnumerable<\u003C\u003Ef__AnonymousType26<int, int, string, IEnumerable<string>>> source5 = source4.OrderByDescending(keySelector);
                // ISSUE: reference to a compiler-generated method
                object seed = SR.\u003C\u003Ec__DisplayClass84_0.nsBVpqfAtPgOpJNGSs03((object) m3);
                // ISSUE: reference to a compiler-generated field
                Func<string, \u003C\u003Ef__AnonymousType26<int, int, string, IEnumerable<string>>, string> func6 = SR.\u003C\u003Ec.\u003C\u003E9__84_19;
                Func<string, \u003C\u003Ef__AnonymousType26<int, int, string, IEnumerable<string>>, string> func7;
                if (func6 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  SR.\u003C\u003Ec.\u003C\u003E9__84_19 = func7 = (text, c) => text.Remove(c.Index, c.Length).Insert(c.Index, SR.T(SR.UnEscapeNonPrintable((object) c.t), (object[]) c.p.Select<string, string>(new Func<string, string>(SR.UnEscapeNonPrintable)).ToArray<string>()));
                }
                else
                  goto label_17;
label_16:
                return source5.Aggregate((string) seed, func7);
label_17:
                func7 = func6;
                goto label_16;
label_18:
                keySelector = func5;
                goto label_14;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            default:
              if (!needRepeat)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 2;
                continue;
              }
              goto case 6;
          }
        }
label_9:
        resource = Regex.Replace(resource, SR.futureTranslateSRTParse2, (MatchEvaluator) (m =>
        {
          int num6 = 3;
          Match m4;
          Group tGroup;
          \u003C\u003Ef__AnonymousType25<int, int, string>[] pCaptures;
          while (true)
          {
            int num7 = num6;
            while (true)
            {
              switch (num7)
              {
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: object of a compiler-generated type is created
                  pCaptures = ((IEnumerable) SR.\u003C\u003Ec__DisplayClass84_0.t2RXwqfA4r1Oh1Qfq9LD(SR.\u003C\u003Ec__DisplayClass84_0.X9Lox4fAwON7vq3Hx94l(SR.\u003C\u003Ec__DisplayClass84_0.VE27ulfApErGBDpyFO8Z((object) m4), SR.\u003C\u003Ec__DisplayClass84_0.jVFbV2fAaTi9PsedZ7QT(1012087039 ^ 1012134439)))).Cast<Capture>().Select(c => new \u003C\u003Ef__AnonymousType25<int, int, string>(c.Index, c.Index + c.Length - 1, c.Value)).ToArray();
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 5;
                  continue;
                case 2:
                  m4 = m;
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                  continue;
                case 3:
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 1;
                  continue;
                case 4:
                  // ISSUE: reference to a compiler-generated method
                  if (SR.\u003C\u003Ec__DisplayClass84_0.q0m899fADgq7VP7c6v0v((object) tGroup))
                  {
                    needRepeat = true;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
                    continue;
                  }
                  goto label_7;
                case 5:
                  goto label_11;
                case 6:
                  goto label_8;
                default:
                  goto label_3;
              }
            }
label_3:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            tGroup = ((GroupCollection) SR.\u003C\u003Ec__DisplayClass84_0.VE27ulfApErGBDpyFO8Z((object) m4))[(string) SR.\u003C\u003Ec__DisplayClass84_0.jVFbV2fAaTi9PsedZ7QT(-1290212282 ^ -644262414 ^ 1786829654)];
            num6 = 4;
            continue;
label_7:
            num6 = 6;
          }
label_8:
          // ISSUE: reference to a compiler-generated method
          return (string) SR.\u003C\u003Ec__DisplayClass84_0.nsBVpqfAtPgOpJNGSs03((object) m4);
label_11:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: reference to a compiler-generated method
          return ((Group) SR.\u003C\u003Ec__DisplayClass84_0.X9Lox4fAwON7vq3Hx94l(SR.\u003C\u003Ec__DisplayClass84_0.VE27ulfApErGBDpyFO8Z((object) m4), SR.\u003C\u003Ec__DisplayClass84_0.jVFbV2fAaTi9PsedZ7QT(825385222 ^ 825688880))).Captures.Cast<Capture>().Select((c, i) => new \u003C\u003Ef__AnonymousType26<int, int, string, IEnumerable<string>>(c.Index - m4.Index, c.Length, tGroup.Captures[i].Value, pCaptures.Where(p => p.StartIndex >= c.Index && p.StopIndex < c.Index + c.Length).Select(p => p.Value))).OrderByDescending(c => c.Index).Aggregate((string) SR.\u003C\u003Ec__DisplayClass84_0.nsBVpqfAtPgOpJNGSs03((object) m4), (text, c) => text.Remove(c.Index, c.Length).Insert(c.Index, SR.EscapeNonPrintable((object) SR.T(SR.UnEscapeNonPrintable((object) c.t), (object[]) c.p.Select<string, string>(new Func<string, string>(SR.UnEscapeNonPrintable)).ToArray<string>()))));
        }));
        num1 = 3;
      }
label_8:
      return resource;
    }

    /// <summary>Перевод строки как ресурс</summary>
    /// <remarks>
    /// Передать некую строку, содержащую SR.T("Чтото") для замены Чтото на перевод
    /// </remarks>
    /// <param name="resource">Ресурс</param>
    /// <returns>Переведенная строка</returns>
    internal static string TranslateStringResource(string resource) => (string) SR.HSJBx8Qv5rufVERi4AT((object) SR.translateSRTParse, (object) resource, (object) (MatchEvaluator) (match =>
    {
      int num1 = 6;
      string source1;
      string str;
      string source2;
      bool escapeQuote;
      while (true)
      {
        switch (num1)
        {
          case 1:
          case 8:
            escapeQuote = SR.escapeQuote;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 3 : 3;
            continue;
          case 3:
            SR.escapeQuote = true;
            num1 = 7;
            continue;
          case 4:
            goto label_15;
          case 5:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            str = (string) SR.\u003C\u003Ec.Ilo3EgfHrf1dqpNGvgpn(SR.\u003C\u003Ec.BdfET7fHg7i7Xy8e03dy(SR.\u003C\u003Ec.EcU2EpfHmwgk0iF3vRxV((object) match), 1));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 9 : 10;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated method
            source2 = (string) SR.\u003C\u003Ec.Ilo3EgfHrf1dqpNGvgpn((object) match);
            num1 = 5;
            continue;
          case 7:
            goto label_7;
          case 9:
            // ISSUE: reference to a compiler-generated method
            if (!source1.Contains<char>(SR.\u003C\u003Ec.OlFcevfHUM6WaLRLUp74((object) str, 0)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 10:
            int num2 = SR.ContainsNonPrintable((object) source2) ? 1 : 0;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            source2 = num2 == 0 ? (string) SR.\u003C\u003Ec.FhrFiVfHYfCYGimL7r3p((object) source2, 1, SR.\u003C\u003Ec.V2JJNYfHjGfnDbfHf9re((object) source2) - 2) : (string) SR.\u003C\u003Ec.Rf6EO8fH54C0ELUtSh8O((object) source2);
            // ISSUE: reference to a compiler-generated method
            source1 = (string) SR.\u003C\u003Ec.FrjWq5fHLuK57Au86qMo((object) source2);
            if (num2 != 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
              continue;
            }
            goto case 9;
          default:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            source1 = (string) SR.\u003C\u003Ec.NSbTjLfHsoP8v75EnjYQ(SR.\u003C\u003Ec.H98icRfHHX1gVBH9UoAp(-1598106783 - -968262081 ^ -629680492), (object) str[0], (object) source1, (object) str[0]);
            num1 = 4;
            continue;
        }
      }
label_7:
      try
      {
        // ISSUE: reference to a compiler-generated method
        source1 = SR.EscapeNonPrintable((object) source1, SR.\u003C\u003Ec.OlFcevfHUM6WaLRLUp74((object) str, 0), true);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      finally
      {
        SR.escapeQuote = escapeQuote;
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
label_15:
      return source1;
    }));

    private static void PreparedTranslate(object exception)
    {
      int num = 3;
      while (true)
      {
        string str;
        FieldInfo fieldInfo;
        switch (num)
        {
          case 1:
            SR.PreparedTranslate((object) ((Exception) exception).InnerException);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 3 : 6;
            continue;
          case 2:
            FieldInfo exceptionMessageField = SR.exceptionMessageField;
            if ((object) exceptionMessageField == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            }
            fieldInfo = exceptionMessageField;
            break;
          case 3:
            if (exception != null)
            {
              num = 2;
              continue;
            }
            goto label_2;
          case 4:
            goto label_9;
          case 5:
            SR.BCJNJSQuVJnwmtjuKwk((object) SR.exceptionMessageField, exception, SR.PV5rvhQZjGRk8gVdlhI((object) str));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 1;
            continue;
          case 6:
            goto label_3;
          case 7:
            if (str != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 4 : 5;
              continue;
            }
            goto case 1;
          default:
            // ISSUE: type reference
            SR.exceptionMessageField = fieldInfo = SR.v04rSTE6JPQRN7lmO1M(__typeref (Exception)).GetField((string) SR.vrPDjpEk9ZyFJxtBPVT(-345420348 ^ -345412132), BindingFlags.Instance | BindingFlags.NonPublic);
            break;
        }
        str = (string) SR.aAVbr7Q8yPGLFqGkHyw((object) fieldInfo, exception);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 7 : 5;
      }
label_9:
      return;
label_3:
      return;
label_2:;
    }

    /// <summary>
    /// Используется для пометки строки как локализуемой, не переводит ее
    /// </summary>
    public static string M(string t) => BrandResourceManager.R((CultureInfo) SR.VqkN2yfTkUovyT1i9kT(SR.ilBR3WfS9bcKJDpOKiS()), t);

    /// <summary>
    /// Используется для пометки строки как локализуемой, не переводит ее
    /// </summary>
    /// <param name="t"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public static string M(string t, params object[] parameters) => BrandResourceManager.R(Thread.CurrentThread.CurrentUICulture, (string) SR.KcN3P6f5Q33p7saMZkQ((object) t, (object) parameters));

    /// <summary>Получить набор ресурсов для выбранной культуры</summary>
    public static IEnumerable<ResourceSet> GetResourceSet(CultureInfo culture)
    {
      try
      {
        SR.localizationStringsRWLock.EnterReadLock();
        // ISSUE: reference to a compiler-generated method
        return SR.managers.Select<ResourceManager, ResourceSet>((Func<ResourceManager, ResourceSet>) (m => (ResourceSet) SR.\u003C\u003Ec__DisplayClass93_0.Obuie3f7BPg7HJxuQTci((object) m, (object) culture, true, true))).Where<ResourceSet>((Func<ResourceSet, bool>) (r => r != null));
      }
      finally
      {
        SR.localizationStringsRWLock.ExitReadLock();
      }
    }

    /// <summary>Попытаться получить культру из настроек приложения</summary>
    /// <returns></returns>
    public static CultureInfo GetCultureFromSettings()
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              SR.hikBXFQIx4YxJJ4veN2();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
              continue;
            case 3:
              if (SR._languageHolder != null)
              {
                num2 = 2;
                continue;
              }
              goto case 1;
            case 4:
              goto label_6;
            default:
              goto label_8;
          }
        }
label_8:
        if (SR._languageHolder != null)
          num1 = 4;
        else
          goto label_7;
      }
label_6:
      return (CultureInfo) SR.GIxm43fiaqb6NBWslFj((object) SR._languageHolder.Name);
label_7:
      return (CultureInfo) null;
    }

    /// <summary>Загрузить информацию о языке из файла</summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public static LanguageHolder ReadFromFile(string filePath)
    {
      int num1 = 5;
      bool lockTaken;
      object languageHolderSinch;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_8;
          case 2:
          case 4:
            goto label_5;
          case 3:
            languageHolderSinch = SR._languageHolderSinch;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          case 5:
            if (!File.Exists(filePath))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 4 : 0;
              continue;
            }
            goto case 3;
          default:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 1;
            continue;
        }
      }
label_5:
      return (LanguageHolder) null;
label_8:
      LanguageHolder languageHolder;
      try
      {
        Monitor.Enter(languageHolderSinch, ref lockTaken);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
          num2 = 0;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_12:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 2;
              continue;
            case 2:
              try
              {
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                    try
                    {
                      XmlReader reader = (XmlReader) SR.MSJMhNQVQ0jCTmjUlQm((object) fileStream);
                      int num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
                        num5 = 0;
                      switch (num5)
                      {
                        default:
                          try
                          {
                            languageHolder = (LanguageHolder) ClassSerializationHelper.DeserializeObjectByXml(TypeOf<LanguageHolder>.Raw, reader, false);
                            int num6 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
                              num6 = 0;
                            switch (num6)
                            {
                              default:
                                goto label_6;
                            }
                          }
                          finally
                          {
                            int num7;
                            if (reader == null)
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 2;
                            else
                              goto label_27;
label_26:
                            switch (num7)
                            {
                              case 1:
                              case 2:
                            }
label_27:
                            SR.fNbGRaEzWbfbl76JXxQ((object) reader);
                            num7 = 1;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
                            {
                              num7 = 1;
                              goto label_26;
                            }
                            else
                              goto label_26;
                          }
                      }
                    }
                    finally
                    {
                      if (fileStream != null)
                      {
                        int num8 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
                          num8 = 1;
                        while (true)
                        {
                          switch (num8)
                          {
                            case 1:
                              fileStream.Dispose();
                              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_35;
                          }
                        }
                      }
label_35:;
                    }
                }
              }
              catch (Exception ex)
              {
                int num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
                  num9 = 0;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      if (num3 > 20)
                      {
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 6;
                        continue;
                      }
                      goto label_12;
                    case 2:
                      SR.Rt6iupEmcpmcigB36oL((object) Logger.Log, SR.fRxTRuE0Fu7IiSgLGiJ((object) ex), (object) ex);
                      num9 = 3;
                      continue;
                    case 3:
                      SR.ndPOVnQSZmBuJtC5DSa(1000);
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 1;
                      continue;
                    case 4:
                      goto label_6;
                    case 5:
                      goto label_12;
                    case 6:
                      languageHolder = (LanguageHolder) null;
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 4 : 3;
                      continue;
                    default:
                      ++num3;
                      num9 = 2;
                      continue;
                  }
                }
              }
            default:
              num3 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 1;
              continue;
          }
        }
      }
      finally
      {
        int num10;
        if (!lockTaken)
          num10 = 2;
        else
          goto label_48;
label_47:
        switch (num10)
        {
          case 1:
          case 2:
        }
label_48:
        Monitor.Exit(languageHolderSinch);
        num10 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
        {
          num10 = 0;
          goto label_47;
        }
        else
          goto label_47;
      }
label_6:
      return languageHolder;
    }

    /// <summary>Инициализация</summary>
    private static void InitLanguageHolder()
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = Path.Combine((string) SR.eLcujBEHAM4OsWcWIeD(SR.jHTe4DEAXt2du1YvRsV(SR.tlWStpQi3Hf2bBM08Jh(SR.amhCBBENfPr0FTQhOlV()))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            SR._languageHolder = (LanguageHolder) SR.SaunRnQRAw1qhtHyIsX(SR.ePijyxElsJnePn3Rlaf((object) str, SR.vrPDjpEk9ZyFJxtBPVT(-97972138 ^ -97963910)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 2;
            continue;
          default:
            if (SR.w3XdpxEru2SQXqvBqWC((object) str))
            {
              num = 3;
              continue;
            }
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    /// <summary>Сохранить настройки в Language.xml</summary>
    /// <param name="culture"></param>
    public static bool SaveCultureToSettings(string culture)
    {
      int num1 = 7;
      bool settings;
      object languageHolderSinch;
      bool lockTaken;
      string path1;
      while (true)
      {
        int num2 = num1;
        string path2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
            case 14:
              goto label_3;
            case 2:
              goto label_40;
            case 4:
            case 8:
              settings = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 8 : 17;
              continue;
            case 5:
              SR._languageHolder = new LanguageHolder();
              num2 = 18;
              continue;
            case 6:
              if (SR._languageHolder == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 3 : 11;
                continue;
              }
              goto default;
            case 7:
              settings = false;
              num2 = 6;
              continue;
            case 9:
              path1 = (string) SR.ePijyxElsJnePn3Rlaf((object) path2, SR.vrPDjpEk9ZyFJxtBPVT(92412609 - 1050237057 ^ -957816212));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 15 : 10;
              continue;
            case 10:
              if (!Directory.Exists(path2))
              {
                num2 = 14;
                continue;
              }
              goto case 9;
            case 11:
              SR.hikBXFQIx4YxJJ4veN2();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            case 12:
              if (SR.gp0RC3QKMejxIhjubBd(SR.R0VTSvQqu4QmJxdRWAS((object) SR._languageHolder), (object) culture, StringComparison.OrdinalIgnoreCase))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
                continue;
              }
              goto case 4;
            case 13:
              goto label_4;
            case 15:
              languageHolderSinch = SR._languageHolderSinch;
              num2 = 2;
              continue;
            case 16:
              path2 = (string) SR.JR8aUOQTGoA3cwNfGJr((object) new string[1]
              {
                (string) SR.eLcujBEHAM4OsWcWIeD(SR.jHTe4DEAXt2du1YvRsV(SR.tlWStpQi3Hf2bBM08Jh((object) AppDomain.CurrentDomain)))
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 10 : 10;
              continue;
            case 17:
              goto label_47;
            case 18:
              if (SR.R0VTSvQqu4QmJxdRWAS((object) SR._languageHolder) == null)
              {
                num2 = 4;
                continue;
              }
              goto case 12;
            default:
              if (SR._languageHolder == null)
              {
                num2 = 5;
                continue;
              }
              goto case 18;
          }
        }
label_40:
        lockTaken = false;
        num1 = 13;
        continue;
label_47:
        SR.JCNRMHQXDekHR5975gn((object) SR._languageHolder, (object) culture);
        num1 = 16;
      }
label_3:
      return settings;
label_4:
      try
      {
        Monitor.Enter(languageHolderSinch, ref lockTaken);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            try
            {
              FileStream fileStream = new FileStream(path1, FileMode.Create);
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
                num4 = 0;
              switch (num4)
              {
                case 1:
                  goto label_3;
                default:
                  try
                  {
                    MemoryStream memoryStream = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream((object) SR._languageHolder, false);
                    int num5 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
                      num5 = 0;
                    switch (num5)
                    {
                      case 1:
                        try
                        {
                          SR.nLP3HYQkc1tcQAbhyTF((object) memoryStream, (object) fileStream);
                          int num6 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
                            num6 = 0;
                          switch (num6)
                          {
                            default:
                              goto label_3;
                          }
                        }
                        finally
                        {
                          if (memoryStream != null)
                          {
                            int num7 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
                              num7 = 0;
                            while (true)
                            {
                              switch (num7)
                              {
                                case 1:
                                  goto label_23;
                                default:
                                  SR.fNbGRaEzWbfbl76JXxQ((object) memoryStream);
                                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 1;
                                  continue;
                              }
                            }
                          }
label_23:;
                        }
                      default:
                        goto label_3;
                    }
                  }
                  finally
                  {
                    int num8;
                    if (fileStream == null)
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 1;
                    else
                      goto label_27;
label_26:
                    switch (num8)
                    {
                      case 1:
                      case 2:
                    }
label_27:
                    SR.fNbGRaEzWbfbl76JXxQ((object) fileStream);
                    num8 = 2;
                    goto label_26;
                  }
              }
            }
            catch (Exception ex)
            {
              int num9 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
                num9 = 1;
              while (true)
              {
                switch (num9)
                {
                  case 1:
                    Logger.Log.Error(SR.fRxTRuE0Fu7IiSgLGiJ((object) ex), ex);
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_3;
                }
              }
            }
        }
      }
      finally
      {
        if (lockTaken)
        {
          int num10 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
            num10 = 1;
          while (true)
          {
            switch (num10)
            {
              case 1:
                Monitor.Exit(languageHolderSinch);
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
                continue;
              default:
                goto label_38;
            }
          }
        }
label_38:;
      }
    }

    /// <summary>
    /// Попытаться получить культру из настроек приложения и установить в текущий поток
    /// </summary>
    public static void SetDefaultCultureFromAppSettings()
    {
      int num1 = 3;
      CultureInfo cultureInfo;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_18;
            case 2:
              if (cultureInfo != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
                continue;
              }
              goto label_16;
            case 3:
              goto label_3;
            default:
              goto label_6;
          }
        }
label_3:
        cultureInfo = (CultureInfo) SR.UogLjCQnaJP4c3IDq0m();
        num1 = 2;
      }
label_18:
      return;
label_16:
      return;
label_6:
      try
      {
        SR.HJSDGGfXC1aSSNCQinE(SR.ilBR3WfS9bcKJDpOKiS(), (object) cultureInfo);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_12;
            default:
              SR.QKI0p7fqAucnfg62r6k(SR.ilBR3WfS9bcKJDpOKiS(), SR.ejgM9efkMhTI4CUxAkj((object) cultureInfo.Name));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 1;
              continue;
          }
        }
label_12:;
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_10;
            default:
              SR.Rt6iupEmcpmcigB36oL(SR.tvtXdeQOayhO5fojfJm(), (object) SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-1886646897 ^ -1886638649)), (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
              continue;
          }
        }
label_10:;
      }
    }

    /// <summary>
    /// Использовать ТОЛЬКО в дизайнере ELMA. Поиск пути файла с сохраненным языком
    /// </summary>
    /// <param name="forSave"></param>
    /// <returns></returns>
    public static string GetSettingsFile(bool forSave = false, string fileName = "Language.xml")
    {
      int num1 = 5;
      string settingsFile;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string path1_1;
          object path1_2;
          switch (num2)
          {
            case 1:
              path1_1 = Path.Combine((string) SR.eLcujBEHAM4OsWcWIeD(SR.jHTe4DEAXt2du1YvRsV((object) ((AppDomain) SR.amhCBBENfPr0FTQhOlV()).SetupInformation)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            case 2:
              SR.sx0DOeEgaV9hG4Sac2k((object) path1_1);
              num2 = 7;
              continue;
            case 3:
            case 9:
            case 10:
              goto label_17;
            case 4:
              path1_2 = SR.U0cNrTQPdDVLsUegSRW((object) ComponentManager.Current);
              break;
            case 5:
              if (SR.Hm3kMFQ2UCLVdsMRlJF())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 2 : 4;
                continue;
              }
              goto case 8;
            case 6:
              settingsFile = Path.Combine(path1_1, fileName);
              num2 = 9;
              continue;
            case 7:
              settingsFile = (string) SR.ePijyxElsJnePn3Rlaf((object) path1_1, (object) fileName);
              num2 = 12;
              continue;
            case 8:
              path1_2 = SR.uhipgoQeMFLh789jssT();
              break;
            case 11:
              if (SR.w3XdpxEru2SQXqvBqWC((object) path1_1))
                goto case 7;
              else
                goto label_5;
            case 12:
              if (!forSave)
                goto case 13;
              else
                goto label_7;
            case 13:
              if (SR.PjZmdRQ1nLQM3oPLgur((object) settingsFile))
              {
                num2 = 3;
                continue;
              }
              goto case 1;
            default:
              if (SR.w3XdpxEru2SQXqvBqWC((object) path1_1))
              {
                num2 = 6;
                continue;
              }
              goto label_17;
          }
          object path2 = SR.vrPDjpEk9ZyFJxtBPVT(-1822890472 ^ -1822898546);
          path1_1 = Path.Combine((string) path1_2, (string) path2);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 11 : 3;
        }
label_5:
        num1 = 2;
        continue;
label_7:
        num1 = 10;
      }
label_17:
      return settingsFile;
    }

    public static string Login => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(1917998801 >> 2 ^ 479507742));

    public static string Password => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(1669371371 ^ 1669379365));

    public static string CurrentPassword => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(1051802738 - -1831968059 ^ -1411188365));

    public static string NewPassword => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-542721635 ^ -542729885));

    public static string ConfirmPassword => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(333888594 ^ 1075625116 ^ 1408901588));

    public static string Version => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675497735));

    public static string SystemEdition => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(825385222 ^ 825376848));

    public static string FillRequiredField => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(~-397266137 ^ 397274530));

    public static string WrongInputField => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(1654249598 >> 2 ^ 413554603));

    public static string CascadeMode_None => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-812025778 ^ -812033626));

    public static string CascadeMode_All => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-1978478350 ^ -1978470132));

    public static string CascadeMode_SaveUpdate => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642868472));

    public static string AddPortlet => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(87862435 ^ 87854799));

    public static string Loading => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767728277));

    public static string NoPortlet => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(~210725948 ^ -210718359));

    public static string PleaseWaitText => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(1051802738 - -1831968059 ^ -1411187867));

    public static string Search => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-2107978722 ^ -2107969824));

    public static string Searching => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(1052221104 - 768835541 ^ 283393495));

    public static string Show => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-2138160520 ^ -2138152616));

    public static string CatalogPortlet => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-1939377524 ^ -1939385928));

    public static string Description => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-1088304168 ^ -1088296832));

    public static string TypeID => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751185268));

    public static string DisplayName => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(712480695 ^ 712487971));

    public static string DatabaseTable => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-138018305 ^ -138010041));

    public static string Name => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-218496594 ^ -218488248));

    /// <summary>Без названия</summary>
    public static string Untitled => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-1146510045 ^ -1146517799));

    public static string PropertyName => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882117256));

    public static string DatabaseTableColumn => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(132912447 ^ 132919679));

    public static string DataType => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(1232639661 >> 3 ^ 154089149));

    public static string Settings => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-1290212282 ^ -644262414 ^ 1786879284));

    public static string Required => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(864270449 << 6 ^ -521258794));

    public static string InputIntNumber => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(993438473 ^ 993431495));

    public static string InputNumber => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138949888));

    public static string InputNumberLtGt => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121170717));

    public static string InputNumberLt => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199937919));

    public static string InputNumberGt => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-1255365154 ^ 596875508 ^ -1765861220));

    public static string InputNotConstraint => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459564837));

    public static string InputDateTimeLtGt => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(372753449 ^ 372761137));

    public static string InputDateLt => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(~210725948 ^ -210717251));

    public static string InputDateGt => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(1470440286 ^ 1470432658));

    public static string InputStringTimeLtGt => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-345420348 ^ -345412898));

    public static string InputStringLt => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(1199946765 ^ 1199938441));

    public static string InputStringGt => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-1487388570 ^ -1487378512));

    public static string DeleteQuestion => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(1994213607 >> 4 ^ 124648614));

    public static string Question => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29248161));

    public static string Add => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-70007027 ^ -69996735));

    public static string Edit => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411190323));

    public static string Delete => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(1925118608 << 2 ^ -889470402));

    public static string Hide => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-2138958856 ^ -2138948760));

    public static string MoveUp => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-70007027 ^ -69996627));

    public static string MoveDown => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-1710575414 ^ -1710581658));

    public static string Copy => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-1978478350 ^ -1978468278));

    public static string Paste => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-867826612 ^ -867816292));

    public static string Create => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(~-397266137 ^ 397272124));

    public static string Save => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-1921202237 ^ -1921192139));

    public static string Cancel => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(272623989 ^ 272613497));

    /// <summary>Закрыть</summary>
    public static string Close => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-105199646 ^ -105189694));

    public static string Select => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(~210725948 ^ -210715919));

    public static string Back => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-1998538950 ^ -1998545282));

    public static string Next => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712490725));

    public static string Ok => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(1654249598 >> 2 ^ 413556607));

    /// <summary>Включить</summary>
    public static string Enable => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-1822890472 ^ -1822896272));

    public static string Yes => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146516385));

    public static string No => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(712480695 ^ 712490547));

    public static string MinValue => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538513000));

    public static string MaxValue => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-542721635 ^ -542732249));

    public static string ElmaDesigner => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(516838154 ^ 516848354));

    public static string ControlIsNotInitialized => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(874012245 ^ 874017885));

    public static string ValidationError => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(1642859704 ^ 1642866414));

    public static string EntityNameValidateMessage => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-1710575414 ^ -1710581182));

    public static string PropertyNameValidateMessage => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-2092274397 << 4 ^ 883358076));

    public static string EnumNameValidateMessage => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420750538));

    public static string Feedback => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(~-306453669 ^ 306458700));

    public static string Authorization => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(1654249598 >> 2 ^ 413555479));

    public static string NoTrueLogin => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-1088304168 ^ -1088297222));

    public static string SelectUser => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583733884));

    public static string RequiredLogin => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1514952375));

    public static string RequiredLoginTooltip => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(1021410165 ^ 1021400743));

    public static string Remember => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-488881205 ^ -488870439));

    public static string Enter => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(1113862659 ^ 1113857115));

    public static string LoggedOut => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-2107978722 ^ -2107973020));

    public static string RowCount => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(825385222 ^ 825380750));

    public static string Records => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(1178210108 ^ 1178214820));

    public static string Pages => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77679285));

    public static string HomePage => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812034432));

    public static string Administration => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(2008901894 << 3 ^ -1108646206));

    public static string Users => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(236071375 ^ 236062423));

    public static string RecordsNotFound => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672130545));

    public static string CreateUser => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(1052221104 - 768835541 ^ 283390343));

    public static string PersonalInfo => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(874012245 ^ 874017245));

    public static string RequireChangePassword => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-688192331 - 435440695 ^ -1123641372));

    public static string ChangePassword => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-70007027 ^ -69998393));

    public static string SaveUserTooltip => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(1597012150 ^ 1597003612));

    [Obsolete("Use WeekMonthDay")]
    public static string WeekMonthDayPattern => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-2107978722 ^ -2107966460));

    public static string WeekMonthDay(DateTime date) => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(272623989 ^ 272619843), (object) date);

    [Obsolete("Use MonthDayWeek")]
    public static string MonthDayWeekPattern => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(993438473 ^ 993434451));

    public static string MonthDayWeek(DateTime date) => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-1317790512 ^ -1317786458), (object) date);

    [Obsolete("Use YearMonthDay")]
    public static string YearMonthDayPattern => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-1334993905 ^ -1334989675));

    public static string YearMonthDay(DateTime date) => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470436320), (object) date);

    [Obsolete("Use YearMonthDayWeek")]
    public static string YearMonthDayWeekPattern => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(1142330761 ^ 1541959139 ^ 536791180));

    public static string YearMonthDayWeek(DateTime date) => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(87862435 ^ 87858609), (object) date);

    [Obsolete("Use YearMonthDayShortWeek")]
    public static string YearMonthDayShortWeekPattern => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112715304));

    public static string YearMonthDayShortWeek(DateTime date) => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(~289714581 ^ -289702116), (object) date);

    [Obsolete("Use WeekYearMonthDay")]
    public static string WeekYearMonthDayPattern => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757119632));

    public static string WeekYearMonthDay(DateTime date) => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-1120607109 - 305487170 ^ -1426082077), (object) date);

    [Obsolete("Use WeekYearMonthDay2")]
    public static string WeekYearMonthDayPattern2 => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-1872275253 >> 6 ^ -29249683));

    public static string WeekYearMonthDay2(DateTime date) => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(825385222 ^ 825381692), (object) date);

    [Obsolete("Use YearMonth")]
    public static string YearMonthPattern => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154083515));

    public static string YearMonth(DateTime date) => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(1581325282 << 3 ^ -234295906), (object) date);

    /// <summary>Строковое представление года</summary>
    /// <param name="date">Дата</param>
    /// <returns></returns>
    public static string Year(DateTime date) => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(1461825605 - 1531863589 ^ -70026094), (object) date);

    [Obsolete("Use CalendarDDMY")]
    public static string CalendarDDMYPattern => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(1819636893 << 3 ^ 1672189476));

    public static string CalendarDDMY(DateTime date1, DateTime date2) => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(1597012150 ^ 1597000634), (object) date1, (object) date2);

    [Obsolete("Use CalendarDMDMY")]
    public static string CalendarDMDMYPattern => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-477139494 ^ -477143394));

    public static string CalendarDMDMY(DateTime date1, DateTime date2) => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-1088304168 ^ -1088292782), (object) date1, (object) date2);

    [Obsolete("Use CalendarDMYDMY")]
    public static string CalendarDMYDMYPattern => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786874488));

    public static string CalendarDMYDMY(DateTime date1, DateTime date2) => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-2112703338 ^ -2112716624), (object) date1, (object) date2);

    [Obsolete("Use ShortMonthDayWeek")]
    public static string ShortMonthDayWeekPattern => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765865134));

    public static string ShortMonthDayWeek(DateTime date) => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-342626196 - 1290888215 ^ -1633503033), (object) date);

    public static string Language => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-882126494 ^ -882121258));

    [Obsolete("Use ToString(\"M\")")]
    public static string DayAndFullMonthPattern => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222157758));

    [Obsolete("Use DateFullMonth")]
    public static string DateFullMonthPattern => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-2138958856 ^ -2138953942));

    public static string DateFullMonth(DateTime date) => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(-1886646897 ^ -1886635679), (object) date);

    /// <summary>
    /// Названия дней недели
    /// Первый день всегда понедельник
    /// </summary>
    public static string[] WeekDayNames
    {
      get
      {
        int num = 7;
        int index;
        string[] weekDayNames;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
            case 4:
              weekDayNames[(index + 7 - 1) % 7] = (string) SR.dhmrhyQ3ucja3nk5MgP(SR.TekMapQNQCNsN9fVuBE(SR.TbORhafn2l9tC8ugc3q()))[index];
              num = 5;
              continue;
            case 5:
              ++index;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
              continue;
            case 6:
              index = 0;
              num = 3;
              continue;
            case 7:
              weekDayNames = new string[7];
              num = 6;
              continue;
            default:
              if (index <= 6)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 2 : 2;
                continue;
              }
              goto label_5;
          }
        }
label_5:
        return weekDayNames;
      }
    }

    public static string Weekend => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538514172));

    public static string Calendar => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-542721635 ^ -542733125));

    public static string Today => SR.T((string) SR.vrPDjpEk9ZyFJxtBPVT(1033719030 - 2012070891 ^ -978338761));

    public static string Partisipants => (string) SR.zQj0ibfrmOi0M6BSYOP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765865372));

    public static string ToInfrom => (string) SR.zQj0ibfrmOi0M6BSYOP(SR.vrPDjpEk9ZyFJxtBPVT(-70007027 ^ -69995927));

    public SR()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool p8WyqUEXtTP7TvhOF8W() => SR.hhETXDEKMSWwCMFllS2 == null;

    internal static SR W7ZFGKETtxxkqHKQ9KG() => SR.hhETXDEKMSWwCMFllS2;

    internal static object vrPDjpEk9ZyFJxtBPVT(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void xTWNKgEn9iEi1QjfS8W() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object wv2V9uEO2uKL83swaT4([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object EcubNPE2ApKSGDnHF26([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);

    internal static object zDd21wEe2Q9vWeCZ5Vq([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object j5NFCIEPKZBdAXjpiy5([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (string[]) obj1);

    internal static object lc8hOAE1sRHAJUqTiBu([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object amhCBBENfPr0FTQhOlV() => (object) AppDomain.CurrentDomain;

    internal static void CyKNcHE3LfoF40woUpa([In] object obj0, [In] object obj1) => ((FileSystemWatcher) obj0).Filter = (string) obj1;

    internal static void csFyHZEpgNend1Trjy2([In] object obj0, [In] bool obj1) => ((FileSystemWatcher) obj0).IncludeSubdirectories = obj1;

    internal static void ubcQihEaliD8V6sqHBC([In] object obj0, [In] bool obj1) => ((FileSystemWatcher) obj0).EnableRaisingEvents = obj1;

    internal static void m9WcKWEDiq0722G1jS2([In] object obj0, [In] NotifyFilters obj1) => ((FileSystemWatcher) obj0).NotifyFilter = obj1;

    internal static void KSiFlZEtHptU6ov4xRF([In] object obj0, [In] object obj1) => ((FileSystemWatcher) obj0).Created += (FileSystemEventHandler) obj1;

    internal static void eNikLQEw9g5LUjIp0QO([In] object obj0, [In] object obj1) => ((FileSystemWatcher) obj0).Changed += (FileSystemEventHandler) obj1;

    internal static void SUtFUrE4IP1kCbLIbN4([In] object obj0, [In] object obj1) => ((FileSystemWatcher) obj0).Deleted += (FileSystemEventHandler) obj1;

    internal static Type v04rSTE6JPQRN7lmO1M([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object eLcujBEHAM4OsWcWIeD([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object jHTe4DEAXt2du1YvRsV([In] object obj0) => (object) ((AppDomainSetup) obj0).ConfigurationFile;

    internal static void t4Z1yZE7fBklY0hqG9y([In] object obj0) => SR.ReInitSR((string) obj0);

    internal static void BkyZ2xExBSVMbjmCg0r([In] object obj0, [In] object obj1) => ((FileSystemWatcher) obj0).Path = (string) obj1;

    internal static object fRxTRuE0Fu7IiSgLGiJ([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void Rt6iupEmcpmcigB36oL([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void uAdJh8Eyu8SUX82LTvH([In] object obj0) => Monitor.Exit(obj0);

    internal static object sLXJnbEMYC63UfMFJ9W() => (object) EleWise.ELMA.Properties.Resources.LangMap;

    internal static object TfqWJrEJmXGOFKOZeAv([In] object obj0) => (object) LanguagesMap.Load((string) obj0);

    internal static object ER5pPiE9h18lxXF0djO([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static object qUO8HQEdMHJcMgVtYQs([In] object obj0) => (object) SR.GetCultureDir((string) obj0);

    internal static object ePijyxElsJnePn3Rlaf([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool w3XdpxEru2SQXqvBqWC([In] object obj0) => Directory.Exists((string) obj0);

    internal static object sx0DOeEgaV9hG4Sac2k([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static void zopcDbE5esKil0UNMTM([In] object obj0) => ((ReaderWriterLockSlim) obj0).EnterWriteLock();

    internal static void YWdO0cEjvdVXPX7sQek([In] object obj0) => ((List<ResourceManager>) obj0).Clear();

    internal static void A4UyHMEYUuWXrXPgSA8([In] object obj0) => ((Dictionary<CultureInfo, Dictionary<string, string>>) obj0).Clear();

    internal static int F9tHyvELEwA31Ff1ZC4([In] object obj0) => ((List<CultureInfo>) obj0).Count;

    internal static object XH6sWAEU0IVwOHVWELH([In] object obj0) => (object) ((ResourceSet) obj0).GetEnumerator();

    internal static bool xhtPxdEs9nG9CKwHKbx([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool D7yccqEcy1QouE1npyx([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void fNbGRaEzWbfbl76JXxQ([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void vQFfoqfF6L9U9w0pBEm([In] object obj0) => ((ReaderWriterLockSlim) obj0).ExitWriteLock();

    internal static object wI6wbifBevfaFuGnfnY() => (object) SR.KeyCultureInfo;

    internal static object jNeJPafWELTvdE0VKh7([In] object obj0) => (object) SR.GetCultureDir((CultureInfo) obj0);

    internal static object gWjOp4foyfoRwtYZxrt([In] object obj0) => (object) SR.ComputeLocalizationHash((string) obj0);

    internal static object XBHUIKfbQ9HLpIWj9Ln([In] object obj0) => (object) Path.GetFileName((string) obj0);

    internal static object n5W0AVfhkrNK5UmjAYE() => (object) MD5.Create();

    internal static object VTE36ofG6Fk1KyI6i8k([In] object obj0, [In] object obj1) => (object) Directory.GetFiles((string) obj0, (string) obj1);

    internal static object O0KVcGfExvQOVrb4KWP([In] object obj0) => (object) File.OpenRead((string) obj0);

    internal static void SNdTRNffMDU8W0jv0wV([In] object obj0, [In] object obj1) => ((LocalizationFileHash) obj0).FileName = (string) obj1;

    internal static object mUFwmafQI3l24KjKvEC([In] object obj0) => (object) Directory.GetFiles((string) obj0);

    internal static void x94ybafCYHWqkFgLZvO([In] object obj0, [In] object obj1) => ((LocalizationFileHash) obj0).Hash = (byte[]) obj1;

    internal static object GBi3c8fvDVNA69Cnbs8() => (object) SR.LocalizationService;

    internal static void BmXYoTf82JiVq0fBY2r([In] object obj0) => ((ILocalizationService) obj0).InitCulture();

    internal static object OE4XD9fZcGLeABfJ5Cx([In] object obj0) => (object) SR.GetCurrentCulture((IUser) obj0);

    internal static object Dm5MNlfu3ZSojur4rLc([In] object obj0, [In] object obj1) => (object) ((ILocalizationService) obj0).Load((IUser) obj1);

    internal static bool LT6X7FfInVe2V4Qju61() => Locator.Initialized;

    internal static object EPsa3ifVCRMqykoxK6W([In] object obj0) => (object) ((ILocalizationService) obj0).DefaultCulture;

    internal static object ilBR3WfS9bcKJDpOKiS() => (object) Thread.CurrentThread;

    internal static object GIxm43fiaqb6NBWslFj([In] object obj0) => (object) SR.GetCultureByName((string) obj0);

    internal static object ENoAQ5fRxFpE3Db0aA0([In] object obj0) => (object) ((Thread) obj0).CurrentCulture;

    internal static void QKI0p7fqAucnfg62r6k([In] object obj0, [In] object obj1) => ((Thread) obj0).CurrentCulture = (CultureInfo) obj1;

    internal static void GhEBiQfKllxnPl0PNkW([In] object obj0) => ((System.Action) obj0)();

    internal static void HJSDGGfXC1aSSNCQinE([In] object obj0, [In] object obj1) => ((Thread) obj0).CurrentUICulture = (CultureInfo) obj1;

    internal static object VqkN2yfTkUovyT1i9kT([In] object obj0) => (object) ((Thread) obj0).CurrentUICulture;

    internal static object ejgM9efkMhTI4CUxAkj([In] object obj0) => (object) CultureInfo.CreateSpecificCulture((string) obj0);

    internal static object TbORhafn2l9tC8ugc3q() => (object) CultureInfo.CurrentCulture;

    internal static int DHJVtgfOCny6u95QqrJ([In] object obj0) => ((CultureInfo) obj0).LCID;

    internal static object lMtYqjf2YyFB6MqEelK() => (object) SettingsFeatureFlagProvider.Container;

    internal static void rKpwuffeFfMsfAZuTYf([In] object obj0) => ConfigurationManager.RefreshSection((string) obj0);

    internal static void AYhD3sfPCBmMhgwc0ZA([In] object obj0) => ((Dictionary<string, object>) obj0).Clear();

    internal static void yI3DdLf1odUpTbYq9Tw([In] object obj0) => ((ReaderWriterLockSlim) obj0).EnterReadLock();

    internal static object zdvXKufN548Bomluk73([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static bool SKaSXef3wPLiiMxWjBu([In] object obj0, [In] object obj1) => ((Regex) obj0).IsMatch((string) obj1);

    internal static object Fwh7LUfpeYalvIHcb2R([In] object obj0, [In] object obj1) => (object) SR.GetCorrectTranslationVariant(obj0, obj1);

    internal static void r03onkfa5hciDbdP5rS([In] object obj0) => ((ReaderWriterLockSlim) obj0).ExitReadLock();

    internal static object AmJgVtfDTHtutwU5BT1([In] object obj0, [In] object obj1) => (object) ((Regex) obj0).Split((string) obj1);

    internal static object uMVd6GftmiLF9clEMG8() => (object) Environment.StackTrace;

    internal static object hLGe5efwVmmtam67qDf([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((char[]) obj1, obj2);

    internal static bool nslMSgf4kNavaANKuti([In] object obj0, [In] object obj1) => SR.ContainsKey(obj0, obj1);

    internal static object wjOd72f69ggE1fcKUeJ([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool rMvA0kfHnXtosAHDHwa([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).StartsWith((string) obj1, obj2);

    internal static bool mtwX23fAMdqOQyDem3K([In] object obj0) => SR.ContainsKey((string) obj0);

    internal static bool JcbhQkf7EkwLGkp7urB() => ELMAContext.Initialized;

    internal static object uEWa04fxBoxFsQt26MC() => (object) TranslateService.Instance;

    internal static bool I8Kgqjf0XUhfOyCJNNu([In] object obj0) => ((TranslateService) obj0).InLineDisabled;

    internal static bool asXlO1fmyP1EGNujCPc([In] object obj0) => ((TranslateService) obj0).Initialized;

    internal static object tLHZIffyaOOFFY10KCT([In] object obj0) => (object) SR.ExtractKeyFromString((string) obj0);

    internal static object VtfQ4sfMxRLjSLso1ML() => (object) AuthenticationService.GetCurrentUser();

    internal static void aK4YNSfJnhP1R3eYIp2([In] object obj0, bool value) => ((TranslateService) obj0).InLineDisabled = value;

    internal static object T3pY1vf9p5wOaHT2d3p([In] object obj0, [In] object obj1) => (object) SR.T((CultureInfo) obj0, (string) obj1);

    internal static object zuAjLGfdMObPvKu1wGJ([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static bool pu1oHZflZBnsDtK8WKB([In] object obj0) => ((TranslateService) obj0).InLineTurned;

    internal static object zQj0ibfrmOi0M6BSYOP([In] object obj0) => (object) SR.T((string) obj0);

    internal static bool dHmVm3fgQQ816kwVw9V() => GuiLocalizationUtility.DesignMode;

    internal static object KcN3P6f5Q33p7saMZkQ([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object Yu5m4rfjUyiwlEs6QHV([In] object obj0) => (object) ((DateTimeFormatInfo) obj0).ShortTimePattern;

    internal static int GBJ0shfYcW1fDaoXcPi([In] object obj0) => ((string) obj0).Length;

    internal static object GdnoxofLlnwDOdyW7KX([In] object obj0, [In] char obj1) => (object) ((StringBuilder) obj0).Append(obj1);

    internal static char mAw3SifUOge9U7pspLw([In] object obj0, [In] int obj1) => ((string) obj0)[obj1];

    internal static object plrWIZfsunMGnoDbsC4([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static UnicodeCategory RX7sHTfc8uwHWHVfGa8([In] char obj0) => CharUnicodeInfo.GetUnicodeCategory(obj0);

    internal static bool U39iKrfz4PTIVB4xC3n([In] char obj0) => char.IsLetter(obj0);

    internal static int lvI4olQF7albnw00yWR([In] object obj0) => ((StringBuilder) obj0).Length;

    internal static int wgXXaUQBOF1cAnNgoe3([In] object obj0, [In] int obj1) => Convert.ToInt32((string) obj0, obj1);

    internal static char bGbNKNQWXtGNaXiJC0b([In] int obj0) => Convert.ToChar(obj0);

    internal static object RuhSxJQopS7Z6nEKkOA([In] object obj0) => (object) ((string) obj0).Trim();

    internal static bool uMfBKQQbd5qoCDWUgJN([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool L0PxKdQhr7FZKQO4hnp([In] object obj0) => SR.ContainsNonPrintable(obj0);

    internal static object tLcP3gQGa9N3dZwprrk([In] object obj0, [In] object obj1) => (object) SR.GetString(obj0, obj1);

    internal static object kwlvTKQEEHO8sfth8N8([In] object obj0, [In] object obj1) => (object) BrandResourceManager.R((CultureInfo) obj0, (string) obj1);

    internal static object qIjWcfQf5rSBCxJxJoT([In] object obj0, [In] object obj1) => (object) ((Regex) obj0).Matches((string) obj1);

    internal static object PmLX0FQQHgEiCT6txmq([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static object XgpVseQCOibmASoYadl([In] object obj0, [In] object obj1, [In] object obj2) => (object) Regex.Replace((string) obj0, (string) obj1, (MatchEvaluator) obj2);

    internal static object HSJBx8Qv5rufVERi4AT([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((Regex) obj0).Replace((string) obj1, (MatchEvaluator) obj2);

    internal static object aAVbr7Q8yPGLFqGkHyw([In] object obj0, [In] object obj1) => ((FieldInfo) obj0).GetValue(obj1);

    internal static object PV5rvhQZjGRk8gVdlhI([In] object obj0) => (object) SR.PreparedTranslate((string) obj0);

    internal static void BCJNJSQuVJnwmtjuKwk([In] object obj0, [In] object obj1, [In] object obj2) => ((FieldInfo) obj0).SetValue(obj1, obj2);

    internal static void hikBXFQIx4YxJJ4veN2() => SR.InitLanguageHolder();

    internal static object MSJMhNQVQ0jCTmjUlQm([In] object obj0) => (object) XmlReader.Create((Stream) obj0);

    internal static void ndPOVnQSZmBuJtC5DSa([In] int obj0) => Thread.Sleep(obj0);

    internal static object tlWStpQi3Hf2bBM08Jh([In] object obj0) => (object) ((AppDomain) obj0).SetupInformation;

    internal static object SaunRnQRAw1qhtHyIsX([In] object obj0) => (object) SR.ReadFromFile((string) obj0);

    internal static object R0VTSvQqu4QmJxdRWAS([In] object obj0) => (object) ((LanguageHolder) obj0).Name;

    internal static bool gp0RC3QKMejxIhjubBd([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static void JCNRMHQXDekHR5975gn([In] object obj0, [In] object obj1) => ((LanguageHolder) obj0).Name = (string) obj1;

    internal static object JR8aUOQTGoA3cwNfGJr([In] object obj0) => (object) Path.Combine((string[]) obj0);

    internal static void nLP3HYQkc1tcQAbhyTF([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    internal static object UogLjCQnaJP4c3IDq0m() => (object) SR.GetCultureFromSettings();

    internal static object tvtXdeQOayhO5fojfJm() => (object) Logger.Log;

    internal static bool Hm3kMFQ2UCLVdsMRlJF() => ComponentManager.Initialized;

    internal static object uhipgoQeMFLh789jssT() => (object) DesignEnvironment.WorkDir;

    internal static object U0cNrTQPdDVLsUegSRW([In] object obj0) => (object) ((ComponentManager) obj0).WorkDirectory;

    internal static bool PjZmdRQ1nLQM3oPLgur([In] object obj0) => File.Exists((string) obj0);

    internal static object TekMapQNQCNsN9fVuBE([In] object obj0) => (object) ((CultureInfo) obj0).DateTimeFormat;

    internal static object dhmrhyQ3ucja3nk5MgP([In] object obj0) => (object) ((DateTimeFormatInfo) obj0).DayNames;

    /// <summary>Локализатор строки</summary>
    internal interface ILocalizer
    {
      /// <summary>Локализовать</summary>
      /// <returns>Локализованная строка</returns>
      string Localize();
    }

    /// <summary>Локализуемая строка</summary>
    [Serializable]
    internal abstract class LocalizableString
    {
      private static ContextVars.Local<bool> runWithSRLocalizer;
      private static SR.LocalizableString TCqMkNfHTg6OacbYr3bl;

      /// <summary>
      /// Локализуемая строка, всегда возращающая <see langword="null" />
      /// </summary>
      public static SR.LocalizableString Null { get; }

      /// <summary>
      /// Локализуемая строка, всегда возращающая <see cref="F:System.String.Empty" />
      /// </summary>
      public static SR.LocalizableString Empty { get; }

      /// <summary>Создать локализованную строку</summary>
      /// <param name="localizer">Локализатор строки</param>
      /// <returns>Локализуемая строка</returns>
      internal static SR.LocalizableString Create(SR.ILocalizer localizer) => (SR.LocalizableString) new SR.LocalizableString.LocalizerLocalizableString(localizer);

      /// <summary>При (де)сериализации использовать SR-локализацию</summary>
      /// <param name="action">Действие</param>
      internal static void RunWithSRLocalizer(System.Action action)
      {
        int num1 = 3;
        bool flag;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_12;
            case 1:
              goto label_4;
            case 2:
              SR.LocalizableString.runWithSRLocalizer.Value = true;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
              continue;
            case 3:
              flag = SR.LocalizableString.runWithSRLocalizer.Value;
              num1 = 2;
              continue;
            default:
              goto label_8;
          }
        }
label_12:
        return;
label_8:
        return;
label_4:
        try
        {
          SR.RunWithCulture((CultureInfo) SR.LocalizableString.XeJVFAfHO6UHlUqnsEwO(), action);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
            num2 = 0;
          switch (num2)
          {
          }
        }
        finally
        {
          SR.LocalizableString.runWithSRLocalizer.Value = flag;
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
            num3 = 0;
          switch (num3)
          {
            default:
          }
        }
      }

      /// <summary>Локализуемая строка</summary>
      /// <param name="string">Строка</param>
      public static implicit operator SR.LocalizableString(string @string)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (SR.LocalizableString.runWithSRLocalizer.Value)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return (SR.LocalizableString) new SR.LocalizableString.LocalizerLocalizableString((SR.ILocalizer) new SR.LocalizableString.SRTLocalizer(@string));
label_3:
        return (SR.LocalizableString) new SR.LocalizableString.NonLocalizableString(@string);
      }

      /// <summary>Локализованная строка</summary>
      /// <param name="str">Локализуемая строка</param>
      public static implicit operator string(SR.LocalizableString str) => (string) SR.LocalizableString.V3ZGE3fH2xaOEq6MDE1U((object) str);

      /// <summary>Локализовать строку</summary>
      /// <returns>Локализованная строка</returns>
      internal abstract string GetLocalized();

      protected LocalizableString()
      {
        SR.LocalizableString.cN3EVWfHe2rwo9gLU55M();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      static LocalizableString()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              SR.LocalizableString.cN3EVWfHe2rwo9gLU55M();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            case 2:
              SR.LocalizableString.Empty = (SR.LocalizableString) new SR.LocalizableString.EmptyLocalizableString();
              num = 4;
              continue;
            case 3:
              goto label_2;
            case 4:
              SR.LocalizableString.runWithSRLocalizer = new ContextVars.Local<bool>();
              num = 3;
              continue;
            default:
              SR.LocalizableString.Null = (SR.LocalizableString) new SR.LocalizableString.NullLocalizableString();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 2;
              continue;
          }
        }
label_2:;
      }

      internal static object XeJVFAfHO6UHlUqnsEwO() => (object) SR.KeyCultureInfo;

      internal static bool R7nRUGfHkguICMrR8g1j() => SR.LocalizableString.TCqMkNfHTg6OacbYr3bl == null;

      internal static SR.LocalizableString euPYMJfHnWgx2KZSFsUu() => SR.LocalizableString.TCqMkNfHTg6OacbYr3bl;

      internal static object V3ZGE3fH2xaOEq6MDE1U([In] object obj0) => (object) ((SR.LocalizableString) obj0).GetLocalized();

      internal static void cN3EVWfHe2rwo9gLU55M() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      /// <summary>
      /// Локализатор строки через <see cref="M:EleWise.ELMA.SR.T(System.String)" />
      /// </summary>
      internal class SRTLocalizer : SR.ILocalizer
      {
        private readonly string baseString;
        private static SR.LocalizableString.SRTLocalizer oSp1GWZQ7pFfBBve5UBD;

        /// <summary>ctor</summary>
        /// <param name="baseString">Строка в ключевой локали</param>
        public SRTLocalizer(string baseString)
        {
          SR.LocalizableString.SRTLocalizer.zxagU8ZQmHl6lGnTTqNK();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
            num = 0;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_3;
              case 1:
                this.baseString = baseString;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
                continue;
              default:
                goto label_5;
            }
          }
label_3:
          return;
label_5:;
        }

        /// <inheritdoc />
        public string Localize() => (string) SR.LocalizableString.SRTLocalizer.dXOFFqZQyoT599r0uJsr((object) this.baseString);

        internal static void zxagU8ZQmHl6lGnTTqNK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static bool BhZcJsZQximHAFE3B9hq() => SR.LocalizableString.SRTLocalizer.oSp1GWZQ7pFfBBve5UBD == null;

        internal static SR.LocalizableString.SRTLocalizer w74KBbZQ0b0Zk2VeM1TP() => SR.LocalizableString.SRTLocalizer.oSp1GWZQ7pFfBBve5UBD;

        internal static object dXOFFqZQyoT599r0uJsr([In] object obj0) => (object) SR.T((string) obj0);
      }

      /// <summary>
      /// Локализуемая строка, всегда возращающая <see langword="null" />
      /// </summary>
      [DebuggerDisplay("null")]
      [Serializable]
      private class NullLocalizableString : SR.LocalizableString
      {
        internal static object O87qLRZQMVTHHrGnpR0E;

        internal override string GetLocalized() => (string) null;

        public NullLocalizableString()
        {
          SR.LocalizableString.NullLocalizableString.HjIUSoZQds9jhWq5oZSl();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static void HjIUSoZQds9jhWq5oZSl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static bool unWOuaZQJ2GVeE5iGCDA() => SR.LocalizableString.NullLocalizableString.O87qLRZQMVTHHrGnpR0E == null;

        internal static SR.LocalizableString.NullLocalizableString wZLFD7ZQ94hWu6xjvRYK() => (SR.LocalizableString.NullLocalizableString) SR.LocalizableString.NullLocalizableString.O87qLRZQMVTHHrGnpR0E;
      }

      /// <summary>
      /// Локализуемая строка, всегда возращающая <see cref="F:System.String.Empty" />
      /// </summary>
      [DebuggerDisplay("\"\"")]
      [Serializable]
      private class EmptyLocalizableString : SR.LocalizableString
      {
        internal static object z3ZaxDZQl5Ph3SGMBgD6;

        internal override string GetLocalized() => "";

        public EmptyLocalizableString()
        {
          SR.LocalizableString.EmptyLocalizableString.ikUNt8ZQ5sptBVKPRqeR();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static void ikUNt8ZQ5sptBVKPRqeR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static bool ne5w3OZQr9HA0NvoH2s6() => SR.LocalizableString.EmptyLocalizableString.z3ZaxDZQl5Ph3SGMBgD6 == null;

        internal static SR.LocalizableString.EmptyLocalizableString DVvyGJZQglt27fOonKn1() => (SR.LocalizableString.EmptyLocalizableString) SR.LocalizableString.EmptyLocalizableString.z3ZaxDZQl5Ph3SGMBgD6;
      }

      /// <summary>Не локализуемая строка</summary>
      [DebuggerDisplay("{@string}")]
      [Serializable]
      private class NonLocalizableString : SR.LocalizableString
      {
        private readonly object @string;
        internal static object RsJZjUZQjg3VlyIOv3RO;

        public NonLocalizableString(string @string)
        {
          SR.LocalizableString.NonLocalizableString.nGPSibZQUVXSaC4WlCgR();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
            num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_3;
              case 1:
                this.@string = (object) @string;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                continue;
              default:
                goto label_5;
            }
          }
label_3:
          return;
label_5:;
        }

        internal override string GetLocalized() => (string) this.@string;

        internal static void nGPSibZQUVXSaC4WlCgR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static bool RdNiTvZQYorIpdyrCJ5a() => SR.LocalizableString.NonLocalizableString.RsJZjUZQjg3VlyIOv3RO == null;

        internal static SR.LocalizableString.NonLocalizableString M0OwCnZQL2vuRcAdx0XY() => (SR.LocalizableString.NonLocalizableString) SR.LocalizableString.NonLocalizableString.RsJZjUZQjg3VlyIOv3RO;
      }

      /// <summary>Локализуемая строка</summary>
      [DebuggerDisplay("{GetLocalized()}")]
      [Serializable]
      private class LocalizerLocalizableString : SR.LocalizableString, ISerializable
      {
        private static readonly IDictionary<string[], object> LocalizedStringsAll;
        private static readonly IDictionary<int, int> LCIDIndexes;
        private static bool resetLocalizationCache;
        [ThreadStatic]
        private static int lcidThread;
        [ThreadStatic]
        private static int lcidIndex;
        private readonly object localizer;
        private object localizedStrings;
        private static object eVOUArZQsEvXsG3NKOrU;

        public LocalizerLocalizableString(SR.ILocalizer localizer)
        {
          SR.LocalizableString.LocalizerLocalizableString.EhbRVDZCFUdPSRpe6yCS();
          this.localizedStrings = (object) new string[2];
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
            num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_3;
              case 2:
                this.localizer = (object) localizer;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                continue;
              default:
                SR.LocalizableString.LocalizerLocalizableString.LocalizedStringsAll.Add((string[]) this.localizedStrings, (object) null);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 1;
                continue;
            }
          }
label_3:;
        }

        public LocalizerLocalizableString(SerializationInfo info, StreamingContext context)
        {
          SR.LocalizableString.LocalizerLocalizableString.EhbRVDZCFUdPSRpe6yCS();
          this.localizedStrings = (object) new string[2];
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
            num = 0;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_3;
              default:
                this.localizer = (object) (SR.ILocalizer) SR.LocalizableString.LocalizerLocalizableString.jgRWoRZCW4Bs1vD3YxYV((object) info, SR.LocalizableString.LocalizerLocalizableString.cuVi0YZCB6ivq0ENcULo(-675505729 ^ -675627525), typeof (SR.ILocalizer));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
                continue;
            }
          }
label_3:;
        }

        ~LocalizerLocalizableString()
        {
          switch (1)
          {
            case 1:
              try
              {
                SR.LocalizableString.LocalizerLocalizableString.LocalizedStringsAll.Remove((string[]) this.localizedStrings);
                int num = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
                  num = 0;
                switch (num)
                {
                  case 0:
                    return;
                  default:
                    return;
                }
              }
              finally
              {
                SR.LocalizableString.LocalizerLocalizableString.dRY0ODZCoXLxjsHeJ8vo((object) this);
                int num = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
                  num = 0;
                switch (num)
                {
                  default:
                }
              }
          }
        }

        internal override string GetLocalized()
        {
          int num1 = 7;
          SR.LocalizableString.LocalizerLocalizableString localizableString;
          int index;
          string localized;
          bool lockTaken;
          while (true)
          {
            switch (num1)
            {
              case 1:
              case 4:
                goto label_11;
              case 2:
                goto label_5;
              case 3:
                lockTaken = false;
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
                continue;
              case 5:
label_7:
                localized = (string) this.localizedStrings[index];
                num1 = 10;
                continue;
              case 6:
                index = SR.LocalizableString.LocalizerLocalizableString.AuXbfcZCh5ZADxOQl9Yu();
                num1 = 8;
                continue;
              case 7:
                if (!SR.futureTranslate)
                {
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 3 : 6;
                  continue;
                }
                goto label_5;
              case 8:
                if (this.localizedStrings.Length <= index)
                {
                  num1 = 9;
                  continue;
                }
                goto case 5;
              case 9:
                localizableString = this;
                num1 = 3;
                continue;
              case 10:
                if (localized != null)
                {
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 0;
                  continue;
                }
                goto case 11;
              case 11:
                this.localizedStrings[index] = (object) (localized = ((SR.ILocalizer) this.localizer).Localize());
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 4;
                continue;
              default:
                try
                {
                  Monitor.Enter((object) localizableString, ref lockTaken);
                  int num2 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
                    num2 = 1;
                  string[] key;
                  while (true)
                  {
                    switch (num2)
                    {
                      case 1:
                        if (this.localizedStrings.Length <= index)
                        {
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 4;
                          continue;
                        }
                        goto label_7;
                      case 2:
                        if (!SR.LocalizableString.LocalizerLocalizableString.resetLocalizationCache)
                        {
                          num2 = 7;
                          continue;
                        }
                        goto case 5;
                      case 3:
                        SR.LocalizableString.LocalizerLocalizableString.LocalizedStringsAll.Remove((string[]) this.localizedStrings);
                        num2 = 2;
                        continue;
                      case 4:
                        key = new string[index + 1];
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
                        continue;
                      case 5:
                        this.localizedStrings = (object) key;
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 6 : 6;
                        continue;
                      case 6:
                        goto label_7;
                      case 7:
                        SR.LocalizableString.LocalizerLocalizableString.RSwoKSZCGbbjcoNnjBbs(this.localizedStrings, (object) key, 0);
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 5 : 2;
                        continue;
                      default:
                        SR.LocalizableString.LocalizerLocalizableString.LocalizedStringsAll.Add(key, (object) null);
                        num2 = 3;
                        continue;
                    }
                  }
                }
                finally
                {
                  if (lockTaken)
                  {
                    int num3 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
                      num3 = 1;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                          SR.LocalizableString.LocalizerLocalizableString.nQR8jiZCEL6ZWpx82p8T((object) localizableString);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_30;
                      }
                    }
                  }
label_30:;
                }
            }
          }
label_5:
          return (string) SR.LocalizableString.LocalizerLocalizableString.WRjkddZCbBAW2dFpMVNJ(this.localizer);
label_11:
          return localized;
        }

        private static int GetLCIDIndex()
        {
          int num1 = 1;
          while (true)
          {
            int num2 = num1;
            IDictionary<int, int> lcidIndexes;
            bool lockTaken;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  if (SR.LocalizableString.LocalizerLocalizableString.lcidThread != SR.LocalizableString.LocalizerLocalizableString.CV7TvvZCfY9mTIx1qh8B())
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                    continue;
                  }
                  goto label_16;
                case 2:
                  lockTaken = false;
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 6 : 5;
                  continue;
                case 3:
                  goto label_16;
                case 4:
label_15:
                  SR.LocalizableString.LocalizerLocalizableString.lcidThread = SR.LocalizableString.LocalizerLocalizableString.CV7TvvZCfY9mTIx1qh8B();
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 3 : 3;
                  continue;
                case 5:
                  lcidIndexes = SR.LocalizableString.LocalizerLocalizableString.LCIDIndexes;
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 2;
                  continue;
                case 6:
                  try
                  {
                    Monitor.Enter((object) lcidIndexes, ref lockTaken);
                    int num3 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
                      num3 = 0;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                          goto label_15;
                        case 2:
                          SR.LocalizableString.LocalizerLocalizableString.LCIDIndexes[SR.CurrentLCID] = SR.LocalizableString.LocalizerLocalizableString.lcidIndex = SR.LocalizableString.LocalizerLocalizableString.AEH7eGZCQR22cyNIBnrn((object) SR.LocalizableString.LocalizerLocalizableString.LCIDIndexes);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
                          continue;
                        default:
                          if (!SR.LocalizableString.LocalizerLocalizableString.LCIDIndexes.TryGetValue(SR.LocalizableString.LocalizerLocalizableString.CV7TvvZCfY9mTIx1qh8B(), out SR.LocalizableString.LocalizerLocalizableString.lcidIndex))
                          {
                            num3 = 2;
                            continue;
                          }
                          goto label_15;
                      }
                    }
                  }
                  finally
                  {
                    if (lockTaken)
                    {
                      int num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
                        num4 = 0;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            goto label_14;
                          default:
                            SR.LocalizableString.LocalizerLocalizableString.nQR8jiZCEL6ZWpx82p8T((object) lcidIndexes);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
                            continue;
                        }
                      }
                    }
label_14:;
                  }
                default:
                  if (SR.LocalizableString.LocalizerLocalizableString.LCIDIndexes.TryGetValue(SR.CurrentLCID, out SR.LocalizableString.LocalizerLocalizableString.lcidIndex))
                    goto case 4;
                  else
                    goto label_22;
              }
            }
label_22:
            num1 = 5;
          }
label_16:
          return SR.LocalizableString.LocalizerLocalizableString.lcidIndex;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                SerializationInfo serializationInfo = info;
                object obj = SR.LocalizableString.LocalizerLocalizableString.cuVi0YZCB6ivq0ENcULo(-649342099 - -1150814748 ^ 501610957);
                if (!(this.localizer is SR.LocalizableString.LocalizerLocalizableString.EmptyLocalizer emptyLocalizer))
                  emptyLocalizer = new SR.LocalizableString.LocalizerLocalizableString.EmptyLocalizer((SR.ILocalizer) this.localizer);
                SR.LocalizableString.LocalizerLocalizableString.DBs6X4ZCCqFmTMV83drr((object) serializationInfo, obj, (object) emptyLocalizer);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
                continue;
              default:
                goto label_6;
            }
          }
label_2:
          return;
label_6:;
        }

        static LocalizerLocalizableString()
        {
          int num = 3;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_2;
              case 2:
                SR.LocalizableString.LocalizerLocalizableString.LocalizedStringsAll = (IDictionary<string[], object>) new ConcurrentDictionary<string[], object>();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 4 : 4;
                continue;
              case 3:
                SR.LocalizableString.LocalizerLocalizableString.EhbRVDZCFUdPSRpe6yCS();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 2 : 2;
                continue;
              case 4:
                SR.LocalizableString.LocalizerLocalizableString.LCIDIndexes = (IDictionary<int, int>) new Dictionary<int, int>();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                continue;
              default:
                SR.LocalizableString.LocalizerLocalizableString.resetLocalizationCache = false;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 0;
                continue;
            }
          }
label_2:;
        }

        internal static void EhbRVDZCFUdPSRpe6yCS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static bool LEsphqZQcaau6U9eFS2R() => SR.LocalizableString.LocalizerLocalizableString.eVOUArZQsEvXsG3NKOrU == null;

        internal static SR.LocalizableString.LocalizerLocalizableString aCso0FZQzmXn3bpwV2RL() => (SR.LocalizableString.LocalizerLocalizableString) SR.LocalizableString.LocalizerLocalizableString.eVOUArZQsEvXsG3NKOrU;

        internal static object cuVi0YZCB6ivq0ENcULo(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static object jgRWoRZCW4Bs1vD3YxYV([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);

        internal static void dRY0ODZCoXLxjsHeJ8vo([In] object obj0) => __nonvirtual (obj0.Finalize());

        internal static object WRjkddZCbBAW2dFpMVNJ([In] object obj0) => (object) ((SR.ILocalizer) obj0).Localize();

        internal static int AuXbfcZCh5ZADxOQl9Yu() => SR.LocalizableString.LocalizerLocalizableString.GetLCIDIndex();

        internal static void RSwoKSZCGbbjcoNnjBbs([In] object obj0, [In] object obj1, [In] int obj2) => ((Array) obj0).CopyTo((Array) obj1, obj2);

        internal static void nQR8jiZCEL6ZWpx82p8T([In] object obj0) => Monitor.Exit(obj0);

        internal static int CV7TvvZCfY9mTIx1qh8B() => SR.CurrentLCID;

        internal static int AEH7eGZCQR22cyNIBnrn([In] object obj0) => ((ICollection<KeyValuePair<int, int>>) obj0).Count;

        internal static void DBs6X4ZCCqFmTMV83drr([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

        [Serializable]
        private class EmptyLocalizer : SR.ILocalizer
        {
          private readonly object baseString;
          internal static object MnNivwZpCOlstr49uIHN;

          public EmptyLocalizer(SR.ILocalizer localizer)
          {
            SR.LocalizableString.LocalizerLocalizableString.EmptyLocalizer.tDpdSxZpZGmWOF55nlsc();
            // ISSUE: explicit constructor call
            base.\u002Ector();
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_3;
                case 1:
                  this.baseString = SR.LocalizableString.LocalizerLocalizableString.EmptyLocalizer.EktifHZpuvCS7nWguXtC((object) localizer);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_5;
              }
            }
label_3:
            return;
label_5:;
          }

          public string Localize() => (string) this.baseString;

          internal static void tDpdSxZpZGmWOF55nlsc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

          internal static object EktifHZpuvCS7nWguXtC([In] object obj0) => (object) ((SR.ILocalizer) obj0).Localize();

          internal static bool d3KquBZpv7k1EJFKxgaH() => SR.LocalizableString.LocalizerLocalizableString.EmptyLocalizer.MnNivwZpCOlstr49uIHN == null;

          internal static SR.LocalizableString.LocalizerLocalizableString.EmptyLocalizer MvrbdBZp8tWZvYGfrrYt() => (SR.LocalizableString.LocalizerLocalizableString.EmptyLocalizer) SR.LocalizableString.LocalizerLocalizableString.EmptyLocalizer.MnNivwZpCOlstr49uIHN;
        }

        [Component(Order = 1)]
        private class ResetLocalizationCache : ITranslateChangeHandler
        {
          internal static object H7Hsp6ZpIbFsio4JRtnV;

          public void Execute()
          {
            int num1 = 1;
            IEnumerator<KeyValuePair<string[], object>> enumerator;
            while (true)
            {
              switch (num1)
              {
                case 1:
                  SR.LocalizableString.LocalizerLocalizableString.resetLocalizationCache = true;
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
                  continue;
                case 2:
label_21:
                  SR.LocalizableString.LocalizerLocalizableString.resetLocalizationCache = false;
                  num1 = 3;
                  continue;
                case 3:
                  goto label_17;
                case 4:
                  try
                  {
label_4:
                    if (SR.LocalizableString.LocalizerLocalizableString.ResetLocalizationCache.poqytWZpiqib6uYeJ0lZ((object) enumerator))
                      goto label_7;
                    else
                      goto label_5;
label_3:
                    int index;
                    KeyValuePair<string[], object> current;
                    int num2;
                    while (true)
                    {
                      switch (num2)
                      {
                        case 1:
                        case 3:
                          if (index >= current.Key.Length)
                          {
                            num2 = 5;
                            continue;
                          }
                          goto case 2;
                        case 2:
                          current.Key[index] = (string) null;
                          num2 = 6;
                          continue;
                        case 4:
                          goto label_7;
                        case 5:
                          goto label_4;
                        case 6:
                          ++index;
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 1;
                          continue;
                        case 7:
                          index = 0;
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 3;
                          continue;
                        default:
                          goto label_21;
                      }
                    }
label_5:
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                    goto label_3;
label_7:
                    current = enumerator.Current;
                    num2 = 7;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
                    {
                      num2 = 2;
                      goto label_3;
                    }
                    else
                      goto label_3;
                  }
                  finally
                  {
                    if (enumerator != null)
                    {
                      int num3 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
                        num3 = 0;
                      while (true)
                      {
                        switch (num3)
                        {
                          case 1:
                            goto label_19;
                          default:
                            SR.LocalizableString.LocalizerLocalizableString.ResetLocalizationCache.fEdfZqZpRccDMW5GJ5hx((object) enumerator);
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 1;
                            continue;
                        }
                      }
                    }
label_19:;
                  }
                default:
                  enumerator = SR.LocalizableString.LocalizerLocalizableString.LocalizedStringsAll.GetEnumerator();
                  num1 = 4;
                  continue;
              }
            }
label_17:;
          }

          public ResetLocalizationCache()
          {
            SR.LocalizableString.LocalizerLocalizableString.ResetLocalizationCache.nuQwB5ZpqIoxB65d7J2G();
            // ISSUE: explicit constructor call
            base.\u002Ector();
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
              num = 0;
            switch (num)
            {
            }
          }

          internal static bool poqytWZpiqib6uYeJ0lZ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

          internal static void fEdfZqZpRccDMW5GJ5hx([In] object obj0) => ((IDisposable) obj0).Dispose();

          internal static bool sDvbxBZpV9dtX3Mhg9wC() => SR.LocalizableString.LocalizerLocalizableString.ResetLocalizationCache.H7Hsp6ZpIbFsio4JRtnV == null;

          internal static SR.LocalizableString.LocalizerLocalizableString.ResetLocalizationCache VaE8QKZpSes4TlwLjoYo() => (SR.LocalizableString.LocalizerLocalizableString.ResetLocalizationCache) SR.LocalizableString.LocalizerLocalizableString.ResetLocalizationCache.H7Hsp6ZpIbFsio4JRtnV;

          internal static void nuQwB5ZpqIoxB65d7J2G() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        }
      }
    }
  }
}
