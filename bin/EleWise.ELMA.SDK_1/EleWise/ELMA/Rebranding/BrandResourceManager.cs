// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Rebranding.BrandResourceManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Serialization;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Web;
using System.Xml;

namespace EleWise.ELMA.Rebranding
{
  /// <summary>Менеджер ресурсов для ребрендинга системы</summary>
  public static class BrandResourceManager
  {
    private static bool _stringsInitialized;
    private static bool _imagesInitialized;
    private static bool _brandPackageInstalled;
    private static string _reourcesDirectory;
    private static Dictionary<string, Dictionary<string, string>> _localizedRebrandingDictionary;
    private static Dictionary<string, Bitmap> _rebrandingImages;
    private static Dictionary<string, Bitmap> _defaultImages;
    private static object _lockObject;
    private static BrandResourceManager SkDtKr2lZHYkgl1fKtG;

    static BrandResourceManager()
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          object path1;
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              // ISSUE: type reference
              path1 = BrandResourceManager.P1SgFv2LuqqenwCSjki(BrandResourceManager.brTeni2Y0TMr8yGPAxO((object) BrandResourceManager.my7d6N2jwVCBXumxug7(__typeref (EleWise.ELMA.SR)).Assembly));
              break;
            case 3:
              BrandResourceManager._lockObject = new object();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            case 4:
              BrandResourceManager._localizedRebrandingDictionary = new Dictionary<string, Dictionary<string, string>>();
              num2 = 7;
              continue;
            case 5:
              goto label_6;
            case 6:
              goto label_3;
            case 7:
              BrandResourceManager._rebrandingImages = new Dictionary<string, Bitmap>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
              continue;
            default:
              if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.Designer)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 2;
                continue;
              }
              path1 = (object) Path.GetDirectoryName((string) BrandResourceManager.pj5TXC2cDHQcXhjaVx8(BrandResourceManager.Ixqq5p2shrenXn0cp4L(BrandResourceManager.WqYm9N2U0JcSt4EMOgr())));
              break;
          }
          string setting = EleWise.ELMA.SR.GetSetting((string) BrandResourceManager.ggyJMk2zqwfTfdn04wj(-710283084 ^ -537863435 ^ 173619143), (string) BrandResourceManager.ggyJMk2zqwfTfdn04wj(1461625753 ^ 1461632571));
          BrandResourceManager._reourcesDirectory = Path.Combine((string) path1, setting);
          num2 = 6;
        }
label_6:
        BrandResourceManager.w2R4yF25p9e4S6PXi0Y();
        num1 = 4;
        continue;
label_8:
        BrandResourceManager._defaultImages = new Dictionary<string, Bitmap>();
        num1 = 3;
      }
label_3:;
    }

    /// <summary>Установить бренд пакет</summary>
    /// <param name="isDesigner"></param>
    public static void InstallPackage(bool isDesigner = false)
    {
      int num1 = 12;
      string str1;
      string[] source1;
      string path;
      BrandPackageManifest brandPackageManifest;
      string str2;
      List<RebrendingImageManifest>.Enumerator enumerator1;
      string path1;
      List<RebrendingLicenseStringsManifest>.Enumerator enumerator2;
      CultureInfo cultureInfo;
      string dirName;
      List<CultureInfo> srCultures;
      Dictionary<string, RebrandingStrings> rebrandingDictionary;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_112;
          case 1:
            num1 = 2;
            continue;
          case 2:
            try
            {
              BrandResourceManager.X2pchaeSDfqlAVhbZRS((object) str1, true);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_83;
              }
            }
            catch
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  goto label_83;
              }
            }
          case 3:
            goto label_119;
          case 4:
            List<CultureInfo> source2 = srCultures;
            // ISSUE: reference to a compiler-generated field
            Func<CultureInfo, bool> func = BrandResourceManager.\u003C\u003Ec.\u003C\u003E9__1_3;
            Func<CultureInfo, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              BrandResourceManager.\u003C\u003Ec.\u003C\u003E9__1_3 = predicate = (Func<CultureInfo, bool>) (z => BrandResourceManager.\u003C\u003Ec.A1sOCPfypBQ0GDNBvr8d(BrandResourceManager.\u003C\u003Ec.ibskJ7fyNfITecqOPiff((object) z), BrandResourceManager.\u003C\u003Ec.jVRu08fy3Zfy4EPWidfi(372753449 ^ 372760173), StringComparison.InvariantCulture));
            }
            else
              goto label_75;
label_121:
            cultureInfo = source2.FirstOrDefault<CultureInfo>(predicate);
            num1 = 40;
            continue;
label_75:
            predicate = func;
            goto label_121;
          case 5:
            enumerator2 = brandPackageManifest.Strings.GetEnumerator();
            num1 = 42;
            continue;
          case 6:
            enumerator1 = brandPackageManifest.Images.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 20 : 22;
            continue;
          case 7:
            if (brandPackageManifest.Images.Count <= 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 33 : 12;
              continue;
            }
            goto case 29;
          case 8:
            path = (string) BrandResourceManager.RdBPlYeGVArPEvIIrZ4((object) str1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16765271), BrandResourceManager.ggyJMk2zqwfTfdn04wj(1149433385 + 173655049 ^ 1323092574));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 11 : 18;
            continue;
          case 9:
          case 14:
          case 15:
          case 33:
label_10:
            BrandResourceManager._brandPackageInstalled = true;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
            continue;
          case 10:
label_83:
            BrandResourceManager._stringsInitialized = true;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 3;
            continue;
          case 11:
            if (BrandResourceManager._brandPackageInstalled)
            {
              num1 = 31;
              continue;
            }
            if (BrandResourceManager.yNtA17eF8WNSCKyvwVv((object) BrandResourceManager._reourcesDirectory))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 20 : 4;
              continue;
            }
            goto case 26;
          case 12:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 2 : 11;
            continue;
          case 13:
            ((IEnumerable<DirectoryInfo>) BrandResourceManager.aVSVAdeQyFuQ7lYA1kr((object) new DirectoryInfo(BrandResourceManager._reourcesDirectory))).Where<DirectoryInfo>((Func<DirectoryInfo, bool>) (d =>
            {
              int num4 = 2;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_3;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (BrandResourceManager.\u003C\u003Ec__DisplayClass1_0.mGMaE4fySORfNfoWpo4h(BrandResourceManager.\u003C\u003Ec__DisplayClass1_0.D9nBtufyId8td4fabGk9((object) d), BrandResourceManager.\u003C\u003Ec__DisplayClass1_0.F3VkqwfyVPsqKf83t3Ho(-70007027 ^ -70083243), StringComparison.OrdinalIgnoreCase))
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
                      continue;
                    }
                    goto label_2;
                  default:
                    goto label_2;
                }
              }
label_2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return !BrandResourceManager.\u003C\u003Ec__DisplayClass1_0.mGMaE4fySORfNfoWpo4h(BrandResourceManager.\u003C\u003Ec__DisplayClass1_0.D9nBtufyId8td4fabGk9((object) d), (object) dirName, StringComparison.OrdinalIgnoreCase);
label_3:
              return false;
            })).ToList<DirectoryInfo>().ForEach((Action<DirectoryInfo>) (c =>
            {
              int num5 = 4;
              while (true)
              {
                int num6 = num5;
                CultureInfo culture;
                DirectoryInfo c1;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_12;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      culture = srCultures.FirstOrDefault<CultureInfo>((Func<CultureInfo, bool>) (z => BrandResourceManager.\u003C\u003Ec__DisplayClass1_2.s2LLuYfy2fTD8ABLWjoc((object) z.Name, (object) c1.Name, StringComparison.InvariantCulture)));
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 2 : 7;
                      continue;
                    case 3:
                      c1 = c;
                      num6 = 2;
                      continue;
                    case 4:
                      goto label_10;
                    case 5:
                      // ISSUE: reference to a compiler-generated method
                      if (rebrandingDictionary.ContainsKey((string) BrandResourceManager.\u003C\u003Ec__DisplayClass1_1.lxvPpPfyXSEYWBx4VLQI((object) culture)))
                      {
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_3;
                    case 6:
                      goto label_13;
                    case 7:
                      if (culture == null)
                      {
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 1 : 1;
                        continue;
                      }
                      goto case 5;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      BrandResourceManager.AddLocalizedReplaceDictionary((object) culture, (object) rebrandingDictionary[(string) BrandResourceManager.\u003C\u003Ec__DisplayClass1_1.lxvPpPfyXSEYWBx4VLQI((object) culture)]);
                      num6 = 6;
                      continue;
                  }
                }
label_10:
                num5 = 3;
              }
label_12:
              return;
label_13:
              return;
label_3:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 9 : 23;
            continue;
          case 16:
            rebrandingDictionary = new Dictionary<string, RebrandingStrings>();
            num1 = 5;
            continue;
          case 17:
            if (rebrandingDictionary.ContainsKey(cultureInfo.Name))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 13 : 27;
              continue;
            }
            goto case 35;
          case 18:
            if (!Directory.Exists(path))
            {
              num1 = 15;
              continue;
            }
            goto case 30;
          case 19:
          case 20:
            source1 = (string[]) BrandResourceManager.bf2SAReWpTSFwIm3h9c((object) BrandResourceManager._reourcesDirectory, BrandResourceManager.ggyJMk2zqwfTfdn04wj(2008901894 << 3 ^ -1108662324));
            num1 = 34;
            continue;
          case 21:
            BrandResourceManager.wsqHF9eVsy11gGrGMmR((object) path, (object) str2);
            num1 = 9;
            continue;
          case 22:
            try
            {
label_14:
              if (enumerator1.MoveNext())
                goto label_32;
              else
                goto label_15;
label_13:
              RebrendingImageManifest current;
              int num7;
              switch (num7)
              {
                case 1:
                  try
                  {
                    FileStream fileStream = File.Open(Path.Combine(path1, current.FileName), FileMode.Open, FileAccess.Read);
                    int num8 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
                      num8 = 0;
                    switch (num8)
                    {
                      case 1:
                        goto label_14;
                      default:
                        try
                        {
                          BrandResourceManager._rebrandingImages.Add((string) BrandResourceManager.bWSTTle8eQLG7qS11Nr((object) current), new Bitmap((Stream) fileStream));
                          int num9 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
                            num9 = 0;
                          switch (num9)
                          {
                            default:
                              goto label_14;
                          }
                        }
                        finally
                        {
                          int num10;
                          if (fileStream == null)
                            num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
                          else
                            goto label_26;
label_25:
                          switch (num10)
                          {
                            case 2:
                              break;
                            default:
                          }
label_26:
                          BrandResourceManager.m0ToGCeZIvtSRPdKeqQ((object) fileStream);
                          num10 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
                          {
                            num10 = 0;
                            goto label_25;
                          }
                          else
                            goto label_25;
                        }
                    }
                  }
                  catch
                  {
                    int num11 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
                      num11 = 0;
                    switch (num11)
                    {
                      default:
                        goto label_14;
                    }
                  }
                case 2:
                  goto label_10;
                case 3:
                  goto label_32;
                default:
                  goto label_14;
              }
label_15:
              num7 = 2;
              goto label_13;
label_32:
              current = enumerator1.Current;
              num7 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
              {
                num7 = 1;
                goto label_13;
              }
              else
                goto label_13;
            }
            finally
            {
              enumerator1.Dispose();
              int num12 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
                num12 = 0;
              switch (num12)
              {
                default:
              }
            }
          case 23:
            if (rebrandingDictionary.ContainsKey((string) BrandResourceManager.ggyJMk2zqwfTfdn04wj(1642859704 ^ 1642862332)))
            {
              num1 = 4;
              continue;
            }
            goto case 35;
          case 24:
            if (BrandResourceManager.H8pumvebVpqmYCBfPKF((object) ((IEnumerable<string>) source1).First<string>(), (object) str1))
            {
              num1 = 28;
              continue;
            }
            goto case 1;
          case 25:
            path1 = (string) BrandResourceManager.RdBPlYeGVArPEvIIrZ4((object) str1, BrandResourceManager.ggyJMk2zqwfTfdn04wj(1574260816 ^ 1574248478), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939406124));
            num1 = 7;
            continue;
          case 26:
            BrandResourceManager.a0qblEeBj7QokfcvsP9((object) BrandResourceManager._reourcesDirectory);
            num1 = 19;
            continue;
          case 27:
            BrandResourceManager.MY4mthevNoXb5FlLNyI((object) cultureInfo, (object) rebrandingDictionary[(string) BrandResourceManager.HxF7JXeCotpfEdnhlft((object) cultureInfo)]);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 20 : 36;
            continue;
          case 28:
            num1 = 38;
            continue;
          case 29:
            if (!BrandResourceManager.yNtA17eF8WNSCKyvwVv((object) path1))
            {
              num1 = 14;
              continue;
            }
            goto case 6;
          case 30:
            str2 = (string) BrandResourceManager.X6eSyReI8F7lRKNX6xk((object) ((HttpContext) BrandResourceManager.OeZl6Reu2qSPdJbPG7M()).Server, (object) "");
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 6 : 21;
            continue;
          case 31:
            goto label_110;
          case 32:
label_11:
            srCultures = EleWise.ELMA.SR.GetCultureNames();
            num1 = 13;
            continue;
          case 34:
            if (((IEnumerable<string>) source1).Any<string>())
            {
              num1 = 41;
              continue;
            }
            goto case 37;
          case 35:
          case 36:
            if (isDesigner)
            {
              num1 = 25;
              continue;
            }
            goto case 8;
          case 37:
            BrandResourceManager._stringsInitialized = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          case 38:
            brandPackageManifest = ManifestBuilder.DeserializeByXmlFromFile<BrandPackageManifest>((string) BrandResourceManager.iohVoneo2bTO08knrla((object) str1, BrandResourceManager.ggyJMk2zqwfTfdn04wj(1178210108 ^ 1178238760)));
            num1 = 16;
            continue;
          case 39:
            str1 = (string) BrandResourceManager.iohVoneo2bTO08knrla((object) BrandResourceManager._reourcesDirectory, (object) dirName);
            num1 = 24;
            continue;
          case 40:
            if (cultureInfo == null)
            {
              num1 = 35;
              continue;
            }
            goto case 17;
          case 41:
            dirName = Guid.NewGuid().ToString((string) BrandResourceManager.ggyJMk2zqwfTfdn04wj(1304605005 ^ 1304609091));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 13 : 39;
            continue;
          case 42:
            try
            {
label_47:
              if (enumerator2.MoveNext())
                goto label_78;
              else
                goto label_48;
label_46:
              RebrandingStrings rebrandingStrings;
              int num13;
              while (true)
              {
                switch (num13)
                {
                  case 1:
                    goto label_11;
                  case 2:
                    goto label_78;
                  case 3:
                    rebrandingStrings = (RebrandingStrings) null;
                    num13 = 4;
                    continue;
                  case 4:
                    goto label_49;
                  default:
                    goto label_47;
                }
              }
label_49:
              RebrendingLicenseStringsManifest current;
              try
              {
                FileStream fileStream = new FileStream((string) BrandResourceManager.RdBPlYeGVArPEvIIrZ4((object) str1, BrandResourceManager.ggyJMk2zqwfTfdn04wj(-398663332 ^ -398683880), BrandResourceManager.QQkyPKehvv4DsEtIecx((object) current)), FileMode.Open, FileAccess.Read);
                int num14 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
                  num14 = 0;
                switch (num14)
                {
                  default:
                    try
                    {
                      XmlReader reader = (XmlReader) BrandResourceManager.ilCt3leEn2uk8ZOVPNh((object) fileStream);
                      int num15 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
                        num15 = 0;
                      switch (num15)
                      {
                        default:
                          try
                          {
                            rebrandingStrings = (RebrandingStrings) ClassSerializationHelper.DeserializeObjectByXml(TypeOf<RebrandingStrings>.Raw, reader, false);
                            int num16 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
                              num16 = 0;
                            switch (num16)
                            {
                              default:
                                goto label_47;
                            }
                          }
                          finally
                          {
                            int num17;
                            if (reader == null)
                              num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 1;
                            else
                              goto label_63;
label_62:
                            switch (num17)
                            {
                              case 1:
                              case 2:
                            }
label_63:
                            reader.Dispose();
                            num17 = 1;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
                            {
                              num17 = 2;
                              goto label_62;
                            }
                            else
                              goto label_62;
                          }
                      }
                    }
                    finally
                    {
                      int num18;
                      if (fileStream == null)
                        num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
                      else
                        goto label_69;
label_68:
                      switch (num18)
                      {
                        case 1:
                        case 2:
                      }
label_69:
                      fileStream.Dispose();
                      num18 = 2;
                      goto label_68;
                    }
                }
              }
              finally
              {
                int num19;
                if (rebrandingStrings == null)
                  num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                else
                  goto label_74;
label_73:
                switch (num19)
                {
                  case 1:
                    break;
                  default:
                }
label_74:
                rebrandingDictionary.Add((string) BrandResourceManager.VD9c6UefXTLls1I9r5f((object) current), rebrandingStrings);
                num19 = 2;
                goto label_73;
              }
label_48:
              num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 0;
              goto label_46;
label_78:
              current = enumerator2.Current;
              num13 = 3;
              goto label_46;
            }
            finally
            {
              enumerator2.Dispose();
              int num20 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
                num20 = 0;
              switch (num20)
              {
                default:
              }
            }
          default:
            goto label_107;
        }
      }
label_112:
      return;
label_119:
      return;
label_110:
      return;
label_107:;
    }

    /// <summary>Провести ребренд строки</summary>
    /// <param name="culture"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public static string R(CultureInfo culture, string t)
    {
      int num1 = 2;
      Dictionary<string, string>.Enumerator enumerator;
      while (true)
      {
        CultureInfo cultureInfo1;
        object obj;
        switch (num1)
        {
          case 1:
            obj = BrandResourceManager.Dm7t3DeiUWGxx06TnHF();
            break;
          case 2:
            CultureInfo cultureInfo2 = culture;
            if (cultureInfo2 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 1;
              continue;
            }
            obj = (object) cultureInfo2;
            break;
          case 3:
            if (BrandResourceManager._stringsInitialized)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 6 : 7;
              continue;
            }
            goto label_7;
          case 4:
            enumerator = BrandResourceManager._localizedRebrandingDictionary[(string) BrandResourceManager.HxF7JXeCotpfEdnhlft((object) cultureInfo1)].GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          case 5:
          case 6:
            goto label_7;
          case 7:
            if (!BrandResourceManager._localizedRebrandingDictionary.ContainsKey(cultureInfo1.Name))
            {
              num1 = 6;
              continue;
            }
            goto case 4;
          default:
            goto label_9;
        }
        cultureInfo1 = (CultureInfo) obj;
        num1 = 3;
      }
label_7:
      return t;
label_9:
      string str;
      try
      {
label_12:
        if (enumerator.MoveNext())
          goto label_16;
        else
          goto label_13;
label_11:
        KeyValuePair<string, string> current;
        int num2;
        while (true)
        {
          object obj;
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              obj = (object) t;
              break;
            case 3:
            case 6:
              goto label_12;
            case 4:
              if (current.Value.IsNullOrEmpty())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 2;
                continue;
              }
              goto case 8;
            case 5:
              if (!BrandResourceManager.OnOU04eR1XO8eJLy7nO((object) t, (object) current.Key))
              {
                num2 = 6;
                continue;
              }
              goto case 4;
            case 7:
              goto label_8;
            case 8:
              obj = BrandResourceManager.j5rI0aeqBwWFAbgwueQ((object) t, (object) current.Key, (object) current.Value);
              break;
            default:
              goto label_16;
          }
          str = (string) obj;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 3 : 7;
        }
label_13:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 1;
        goto label_11;
label_16:
        current = enumerator.Current;
        num2 = 5;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        {
          num2 = 5;
          goto label_11;
        }
        else
          goto label_11;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_8:
      return str;
    }

    /// <summary>
    /// Получить брендовое изображение или вернуть стандартное
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static Bitmap GetImage(string name)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        object lockObject;
        bool lockTaken;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_52;
            case 2:
label_55:
              if (!BrandResourceManager._rebrandingImages.ContainsKey(name))
              {
                num2 = 3;
                continue;
              }
              goto label_52;
            case 3:
              if (BrandResourceManager._defaultImages.ContainsKey(name))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 5;
                continue;
              }
              goto label_50;
            case 4:
              try
              {
                Monitor.Enter(lockObject, ref lockTaken);
                int num3 = 4;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                  num3 = 6;
                Assembly assembly;
                IList<BrandResourceAttribute> attributes;
                int index;
                Assembly[] assemblyArray;
                IEnumerator<BrandResourceAttribute> enumerator;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      try
                      {
label_16:
                        if (BrandResourceManager.vBFkBde13rE4h5R2B1a((object) enumerator))
                          goto label_27;
                        else
                          goto label_17;
label_14:
                        BrandResourceAttribute current;
                        string key;
                        Bitmap bitmap;
                        Type type;
                        int num4;
                        while (true)
                        {
                          switch (num4)
                          {
                            case 1:
                              key = (string) BrandResourceManager.G7VEMZePawcArZ34mso((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70023921), BrandResourceManager.RXKdHheedu2cfGmrYxw((object) current), BrandResourceManager.HobP9seObe19NKtMnFh((object) current));
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
                              continue;
                            case 2:
                              if (bitmap != null)
                              {
                                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 11 : 0;
                                continue;
                              }
                              goto label_16;
                            case 3:
                              goto label_12;
                            case 4:
                              goto label_27;
                            case 5:
                            case 8:
                            case 9:
                              goto label_16;
                            case 6:
                              if (!BrandResourceManager.G58PO7ek3aTcdZVMij2(type, (Type) null))
                              {
                                num4 = 5;
                                continue;
                              }
                              goto case 7;
                            case 7:
                              bitmap = BrandResourceManager.YMctBNe2JBTYTivb9dX((object) (ResourceManager) BrandResourceManager.wiei8YenNY1kURKrJf8((object) type.GetProperty((string) BrandResourceManager.ggyJMk2zqwfTfdn04wj(~1767720452 ^ -1767716467), BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic), (object) null, (object) null), BrandResourceManager.HobP9seObe19NKtMnFh((object) current)) as Bitmap;
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 1;
                              continue;
                            case 10:
                              type = BrandResourceManager.oJEUMweTkMnC3yr4Dpv((object) assembly, (object) current.ResourceFullName);
                              num4 = 6;
                              continue;
                            case 11:
                              BrandResourceManager._defaultImages.Add(key, bitmap);
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 7 : 9;
                              continue;
                            default:
                              if (BrandResourceManager._defaultImages.ContainsKey(key))
                              {
                                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 8 : 7;
                                continue;
                              }
                              goto case 2;
                          }
                        }
label_17:
                        num4 = 3;
                        goto label_14;
label_27:
                        current = enumerator.Current;
                        num4 = 10;
                        goto label_14;
                      }
                      finally
                      {
                        int num5;
                        if (enumerator == null)
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
                        else
                          goto label_31;
label_30:
                        switch (num5)
                        {
                          case 2:
                            break;
                          default:
                        }
label_31:
                        BrandResourceManager.m0ToGCeZIvtSRPdKeqQ((object) enumerator);
                        num5 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
                        {
                          num5 = 1;
                          goto label_30;
                        }
                        else
                          goto label_30;
                      }
                    case 2:
                      BrandResourceManager._imagesInitialized = true;
                      num3 = 9;
                      continue;
                    case 3:
                    case 13:
                      assembly = assemblyArray[index];
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
                      continue;
                    case 4:
                      assemblyArray = (Assembly[]) BrandResourceManager.imIjhReKaMU75bt4BKk();
                      num3 = 12;
                      continue;
                    case 5:
                    case 7:
                      if (index < assemblyArray.Length)
                      {
                        num3 = 13;
                        continue;
                      }
                      goto case 2;
                    case 6:
                      if (BrandResourceManager._imagesInitialized)
                      {
                        num3 = 8;
                        continue;
                      }
                      goto case 4;
                    case 8:
                    case 9:
                      goto label_55;
                    case 10:
                      enumerator = attributes.GetEnumerator();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
                      continue;
                    case 11:
                      if (BrandResourceManager.fh1idieXy2LhyaTnaEJ((object) attributes) != 0)
                      {
                        num3 = 10;
                        continue;
                      }
                      goto case 14;
                    case 12:
                      index = 0;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 5 : 7;
                      continue;
                    case 14:
label_12:
                      ++index;
                      num3 = 5;
                      continue;
                    default:
                      attributes = AttributeHelper<BrandResourceAttribute>.GetAttributes(assembly);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 6 : 11;
                      continue;
                  }
                }
              }
              finally
              {
                int num6;
                if (!lockTaken)
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 1;
                else
                  goto label_43;
label_42:
                switch (num6)
                {
                  case 2:
                    break;
                  default:
                }
label_43:
                BrandResourceManager.GQuBgmeNddcY4BHwfI8(lockObject);
                num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
                {
                  num6 = 0;
                  goto label_42;
                }
                else
                  goto label_42;
              }
            case 5:
              goto label_49;
            case 6:
              lockObject = BrandResourceManager._lockObject;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
              continue;
            case 7:
              if (!BrandResourceManager._imagesInitialized)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 6 : 3;
                continue;
              }
              goto case 2;
            default:
              goto label_51;
          }
        }
label_51:
        lockTaken = false;
        num1 = 4;
      }
label_49:
      return BrandResourceManager._defaultImages[name];
label_50:
      return (Bitmap) null;
label_52:
      return BrandResourceManager._rebrandingImages[name];
    }

    private static void AddLocalizedReplaceDictionary(object culture, object rebrandCulture)
    {
      int num1 = 7;
      List<RebrandingStrings.RebrandingString>.Enumerator enumerator;
      Dictionary<string, string> dictionary;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_23;
          case 2:
            BrandResourceManager._localizedRebrandingDictionary.Add((string) BrandResourceManager.HxF7JXeCotpfEdnhlft(culture), dictionary);
            num1 = 3;
            continue;
          case 3:
            goto label_19;
          case 4:
label_5:
            if (BrandResourceManager.yeTG2FeDWeRbL2N9243((object) dictionary) <= 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
              continue;
            }
            goto case 2;
          case 5:
            enumerator = ((RebrandingStrings) rebrandCulture).Strings.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          case 6:
            if (BrandResourceManager.w1858ie3YcmC3lg2dNC((object) ((RebrandingStrings) rebrandCulture).Strings) > 0)
            {
              num1 = 5;
              continue;
            }
            goto case 4;
          case 7:
            dictionary = new Dictionary<string, string>();
            num1 = 6;
            continue;
          default:
            try
            {
label_11:
              if (enumerator.MoveNext())
                goto label_10;
              else
                goto label_12;
label_9:
              RebrandingStrings.RebrandingString current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_10;
                  case 2:
                    dictionary.Add(current.Key, (string) BrandResourceManager.qekRiJea6FOFNsDg7ni((object) current));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
                    continue;
                  case 4:
                    if (string.IsNullOrEmpty((string) BrandResourceManager.sxSFDFepEjahpxMlrYQ((object) current)))
                    {
                      num2 = 3;
                      continue;
                    }
                    goto case 2;
                  case 5:
                    goto label_5;
                  default:
                    goto label_11;
                }
              }
label_10:
              current = enumerator.Current;
              num2 = 4;
              goto label_9;
label_12:
              num2 = 5;
              goto label_9;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
        }
      }
label_23:
      return;
label_19:;
    }

    private static void CopyFolderContents(object sourcePath, object destinationPath)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          int index;
          string[] strArray;
          FileInfo fileInfo;
          object obj1;
          object obj2;
          switch (num2)
          {
            case 1:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 13 : 5;
              continue;
            case 2:
            case 3:
              fileInfo = new FileInfo(strArray[index]);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 4 : 1;
              continue;
            case 4:
              try
              {
                BrandResourceManager.RktfeGe6PmmR6kQ44fk((object) fileInfo, BrandResourceManager.G7VEMZePawcArZ34mso(BrandResourceManager.ggyJMk2zqwfTfdn04wj(-488881205 ^ -488885421), destinationPath, (object) fileInfo.Name), true);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_11;
                }
              }
              catch
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                    goto label_11;
                }
              }
            case 5:
              strArray = Directory.GetDirectories((string) sourcePath);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 0;
              continue;
            case 6:
              if (BrandResourceManager.yNtA17eF8WNSCKyvwVv(destinationPath))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 7 : 23;
                continue;
              }
              goto case 20;
            case 7:
              obj1 = BrandResourceManager.TSPZaTewNV478f81S3S(sourcePath, BrandResourceManager.ggyJMk2zqwfTfdn04wj(-1921202237 ^ -1921197899));
              break;
            case 8:
              if (BrandResourceManager.wSxNT9etovTH8o3eWEC(sourcePath, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470446632)))
              {
                obj1 = sourcePath;
                break;
              }
              goto label_16;
            case 9:
            case 23:
              strArray = (string[]) BrandResourceManager.K3bxJ7e4WMICEE2MoYi(sourcePath);
              num2 = 12;
              continue;
            case 10:
label_11:
              ++index;
              num2 = 15;
              continue;
            case 11:
              if (!Directory.Exists((string) sourcePath))
              {
                num2 = 22;
                continue;
              }
              goto case 6;
            case 12:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
              continue;
            case 13:
            case 24:
              if (index < strArray.Length)
              {
                num2 = 19;
                continue;
              }
              goto label_29;
            case 14:
              obj2 = BrandResourceManager.TSPZaTewNV478f81S3S(destinationPath, BrandResourceManager.ggyJMk2zqwfTfdn04wj(-1876063057 ^ -1876061223));
              goto label_38;
            case 16:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 13 : 24;
              continue;
            case 17:
              if (!((string) destinationPath).EndsWith((string) BrandResourceManager.ggyJMk2zqwfTfdn04wj(1232639661 >> 3 ^ 154078627)))
              {
                num2 = 14;
                continue;
              }
              obj2 = destinationPath;
              goto label_38;
            case 18:
              goto label_32;
            case 19:
            case 21:
              string str = strArray[index];
              DirectoryInfo directoryInfo = new DirectoryInfo(str);
              BrandResourceManager.CopyFolderContents((object) str, BrandResourceManager.TSPZaTewNV478f81S3S(destinationPath, BrandResourceManager.wUQHOPeHGHmGVNA8Mls((object) directoryInfo)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 16 : 14;
              continue;
            case 20:
              Directory.CreateDirectory((string) destinationPath);
              num2 = 9;
              continue;
            case 22:
              goto label_28;
            default:
              if (index < strArray.Length)
              {
                num2 = 3;
                continue;
              }
              goto case 5;
          }
          sourcePath = obj1;
          num2 = 17;
          continue;
label_38:
          destinationPath = obj2;
          num2 = 11;
        }
label_16:
        num1 = 7;
      }
label_32:
      return;
label_28:
      return;
label_29:;
    }

    /// <summary>Расчитать массив хеш-кодов файлов</summary>
    /// <param name="entries"></param>
    /// <param name="extractContent"></param>
    /// <returns></returns>
    private static byte[] EvaluateFilesHashArray(
      IEnumerable<ZipEntry> entries,
      Func<ZipEntry, byte[]> extractContent)
    {
      // ISSUE: reference to a compiler-generated method
      List<ZipEntry> list = entries.Where<ZipEntry>((Func<ZipEntry, bool>) (e =>
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_8;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (BrandResourceManager.\u003C\u003Ec.JiuxdYfyDu9kvhHdQhfO((object) e.Name, BrandResourceManager.\u003C\u003Ec.jVRu08fy3Zfy4EPWidfi(-787452571 ^ -787473039)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 4;
                continue;
              }
              goto label_9;
            case 3:
              // ISSUE: reference to a compiler-generated method
              if (!BrandResourceManager.\u003C\u003Ec.GWJd88fyaxgfStApssme((object) e))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 2;
                continue;
              }
              goto label_9;
            case 4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (BrandResourceManager.\u003C\u003Ec.JiuxdYfyDu9kvhHdQhfO(BrandResourceManager.\u003C\u003Ec.bkBXv1fyt6nlvPqgcaug((object) e), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501459983)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            default:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (BrandResourceManager.\u003C\u003Ec.JiuxdYfyDu9kvhHdQhfO((object) e.Name, BrandResourceManager.\u003C\u003Ec.jVRu08fy3Zfy4EPWidfi(-1217523399 ^ -1217503081)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
                continue;
              }
              goto label_9;
          }
        }
label_8:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return BrandResourceManager.\u003C\u003Ec.JiuxdYfyDu9kvhHdQhfO((object) e.Name, BrandResourceManager.\u003C\u003Ec.jVRu08fy3Zfy4EPWidfi(-606654180 ^ -606650172));
label_9:
        return false;
      })).OrderBy<ZipEntry, string>((Func<ZipEntry, string>) (e => (string) BrandResourceManager.\u003C\u003Ec.bkBXv1fyt6nlvPqgcaug((object) e)), (IComparer<string>) StringComparer.Ordinal).ToList<ZipEntry>();
      using (MemoryStream memoryStream = MemoryHelper.GetMemoryStream())
      {
        foreach (ZipEntry zipEntry in list)
        {
          byte[] buffer = extractContent(zipEntry);
          byte[] hash;
          using (SHA1 shA1 = SHA1.Create())
            hash = shA1.ComputeHash(buffer);
          memoryStream.Write(hash, 0, hash.Length);
        }
        return memoryStream.ToArray();
      }
    }

    private static void WriteFileToZip(object zipStream, object filePath, object entryName)
    {
      int num1 = 1;
      FileInfo fileInfo;
      ZipEntry zipEntry1;
      byte[] numArray;
      FileStream fileStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            fileInfo = new FileInfo((string) filePath);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
            continue;
          case 2:
            fileStream = (FileStream) BrandResourceManager.S05qnJeyaNYeWbqGjCk(filePath);
            num1 = 5;
            continue;
          case 3:
            BrandResourceManager.nT0yHjem6pwF0Bbc8eK(zipStream, (object) zipEntry1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 4 : 4;
            continue;
          case 4:
            numArray = new byte[4096];
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 2 : 1;
            continue;
          case 5:
            try
            {
              BrandResourceManager.B2dKtIeMnAOe4eEVIKX((object) fileStream, zipStream, (object) numArray);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_4;
              }
            }
            finally
            {
              int num3;
              if (fileStream == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 1;
              else
                goto label_14;
label_13:
              switch (num3)
              {
                case 1:
                case 2:
              }
label_14:
              BrandResourceManager.m0ToGCeZIvtSRPdKeqQ((object) fileStream);
              num3 = 2;
              goto label_13;
            }
          case 6:
            goto label_15;
          case 7:
            ZipEntry zipEntry2 = new ZipEntry((string) entryName);
            BrandResourceManager.M5WuwhexKYk54xDLix6((object) zipEntry2, BrandResourceManager.jLF9UBe7dgympYXPjN3((object) fileInfo));
            BrandResourceManager.kSOIete0BQ5kE7mwIwy((object) zipEntry2, fileInfo.Length);
            zipEntry1 = zipEntry2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 2 : 3;
            continue;
          case 8:
label_4:
            BrandResourceManager.wwLYvBeJEyjsQpBpFBf(zipStream);
            num1 = 6;
            continue;
          default:
            entryName = BrandResourceManager.U2Hhl5eAdEmlwNlIdM4(entryName);
            num1 = 7;
            continue;
        }
      }
label_15:;
    }

    private static void WriteDirectoryToZip(object zipStream, object path, object entryRootName)
    {
      int num = 2;
      DirectoryInfo directoryInfo1;
      DirectoryInfo[] directoryInfoArray;
      int index;
      DirectoryInfo directoryInfo2;
      FileInfo[] fileInfoArray;
      string str1;
      FileInfo fileInfo;
      string str2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (directoryInfo1.Exists)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 6 : 4;
              continue;
            }
            goto label_11;
          case 2:
            directoryInfo1 = new DirectoryInfo((string) path);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 1;
            continue;
          case 3:
            BrandResourceManager.KR10NGe5JwWAIjkVSLn(zipStream, (object) directoryInfo2.FullName, (object) str1);
            num = 10;
            continue;
          case 4:
            goto label_13;
          case 5:
          case 15:
            if (index >= directoryInfoArray.Length)
            {
              num = 4;
              continue;
            }
            goto case 18;
          case 6:
            fileInfoArray = (FileInfo[]) BrandResourceManager.oe8KTre9JXwrJHJXi6E((object) directoryInfo1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012090965));
            num = 13;
            continue;
          case 7:
            str1 = (string) BrandResourceManager.G7VEMZePawcArZ34mso(BrandResourceManager.ggyJMk2zqwfTfdn04wj(-138018305 ^ -137989839), entryRootName, BrandResourceManager.wUQHOPeHGHmGVNA8Mls((object) directoryInfo1));
            num = 3;
            continue;
          case 8:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 17 : 9;
            continue;
          case 9:
            fileInfo = fileInfoArray[index];
            num = 14;
            continue;
          case 10:
            ++index;
            num = 5;
            continue;
          case 11:
            index = 0;
            num = 15;
            continue;
          case 12:
            directoryInfoArray = (DirectoryInfo[]) BrandResourceManager.BgreNmegp96X0BwLr91((object) directoryInfo1);
            num = 11;
            continue;
          case 13:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 9 : 16;
            continue;
          case 14:
            str2 = (string) BrandResourceManager.j4b13med3nD3HYZN791(BrandResourceManager.ggyJMk2zqwfTfdn04wj(-1290212282 ^ -644262414 ^ 1786890496), entryRootName, BrandResourceManager.wUQHOPeHGHmGVNA8Mls((object) directoryInfo1), BrandResourceManager.wUQHOPeHGHmGVNA8Mls((object) fileInfo));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          case 16:
          case 17:
            if (index >= fileInfoArray.Length)
            {
              num = 12;
              continue;
            }
            goto case 9;
          case 18:
            directoryInfo2 = directoryInfoArray[index];
            num = 7;
            continue;
          default:
            BrandResourceManager.wDoi0ier3xVKX3MGx2H(zipStream, BrandResourceManager.eCcAjHelpwdqRV1lF99((object) fileInfo), (object) str2);
            num = 8;
            continue;
        }
      }
label_13:
      return;
label_11:;
    }

    private static bool VerifySignature(object data, object csp, object signature)
    {
      int num1 = 1;
      SHA1Managed shA1Managed;
      while (true)
      {
        switch (num1)
        {
          case 1:
            shA1Managed = new SHA1Managed();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_3:
      bool flag;
      return flag;
label_4:
      try
      {
        byte[] hash = shA1Managed.ComputeHash((byte[]) data);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              flag = BrandResourceManager.W04kZteYap3jkwtVJPH(csp, (object) hash, BrandResourceManager.jmOVkEejQcMuDKA65ab(BrandResourceManager.ggyJMk2zqwfTfdn04wj(1021410165 ^ 1021381525)), signature);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
      }
      finally
      {
        if (shA1Managed != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                shA1Managed.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
    }

    private static void WriteCertificate(
      Action<string, byte[]> addEntry,
      object cert,
      object entryName)
    {
      byte[] bytes = Encoding.ASCII.GetBytes(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217502763) + Convert.ToBase64String(((X509Certificate) cert).Export(X509ContentType.Cert)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470452342));
      addEntry((string) entryName, bytes);
    }

    private static void WriteSignatureItem(
      Action<string, byte[]> addEntry,
      object data,
      object csp,
      object entryName)
    {
      using (SHA1Managed shA1Managed = new SHA1Managed())
      {
        byte[] hash = shA1Managed.ComputeHash((byte[]) data);
        byte[] numArray = ((RSACryptoServiceProvider) csp).SignHash(hash, CryptoConfig.MapNameToOID(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113866979)));
        addEntry((string) entryName, numArray);
      }
    }

    private static void WriteSignatures(
      Action<string, byte[]> addEntry,
      object certRef,
      object manifestBytes,
      object resourcesBytes)
    {
      RSACryptoServiceProvider privateKey = (RSACryptoServiceProvider) ((X509Certificate2) certRef).PrivateKey;
      string str = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501460201), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993450599));
      BrandResourceManager.WriteSignatureItem(addEntry, manifestBytes, (object) privateKey, (object) (str + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35999659)));
      BrandResourceManager.WriteSignatureItem(addEntry, resourcesBytes, (object) privateKey, (object) (str + z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459578225)));
      BrandResourceManager.WriteCertificate(addEntry, certRef, (object) (str + z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757136102)));
    }

    private static void WriteSignatures(
      object file,
      object certRefs,
      object manifestBytes,
      object resourcesBytes)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            ZipFile file1 = (ZipFile) file;
            BrandResourceManager.WriteSignatures((Action<string, byte[]>) ((name, data) =>
            {
              int num2 = 1;
              string str;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    str = (string) BrandResourceManager.\u003C\u003Ec__DisplayClass13_0.Mio6iKfy7DhOIhc41RBj((object) name);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_2;
                  default:
                    // ISSUE: reference to a compiler-generated method
                    BrandResourceManager.\u003C\u003Ec__DisplayClass13_0.jRRbcyfyx84XOrAbCOOF((object) file1, (object) new BrandResourceManager.MemoryStreamDataSource(data), (object) str);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 2;
                    continue;
                }
              }
label_2:;
            }), certRefs, manifestBytes, resourcesBytes);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Создать бренд пакет</summary>
    /// <param name="manifestPath"></param>
    /// <param name="certPath"></param>
    /// <param name="psw"></param>
    public static void CreateBrandPackage(string manifestPath, string certPath, string psw)
    {
      int num1 = 1;
      FileStream stream;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_4;
          case 1:
            if (!BrandResourceManager.Cxw7CbeLyS8j9phrqLu((object) manifestPath))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 2:
            goto label_21;
          case 3:
            goto label_12;
          case 4:
            if (File.Exists(certPath))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 5;
              continue;
            }
            goto label_14;
          case 5:
            stream = File.Open(certPath, FileMode.Open, FileAccess.Read);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 5 : 6;
            continue;
          case 6:
            goto label_9;
          default:
            goto label_6;
        }
      }
label_4:
      return;
label_21:
      return;
label_12:
      return;
label_6:
      return;
label_14:
      return;
label_9:
      try
      {
        X509Certificate2 x509Certificate2 = new X509Certificate2(stream.ReadAllBytes(), psw);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_18;
            default:
              BrandResourceManager.FjVMtUeUXMCf279R0AE((object) manifestPath, (object) x509Certificate2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 0;
              continue;
          }
        }
label_18:;
      }
      finally
      {
        int num3;
        if (stream == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
        else
          goto label_19;
label_17:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_19:
        stream.Dispose();
        num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        {
          num3 = 1;
          goto label_17;
        }
        else
          goto label_17;
      }
    }

    private static void VerifyFileResources(
      object manifestPath,
      object resSubFolder,
      IList<RebrendingLicenseStringsManifest> fileResources)
    {
      string manifestPath1 = (string) manifestPath;
      string resSubFolder1 = (string) resSubFolder;
      if (fileResources.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (RebrendingLicenseStringsManifest licenseStringsManifest in fileResources.Where<RebrendingLicenseStringsManifest>((Func<RebrendingLicenseStringsManifest, bool>) (res => !BrandResourceManager.\u003C\u003Ec__DisplayClass15_0.UZTpwAfydsad2TNmx1ly(BrandResourceManager.\u003C\u003Ec__DisplayClass15_0.Y5axpbfy91AIPiFuDHMw((object) Path.GetDirectoryName(manifestPath1), (object) resSubFolder1, BrandResourceManager.\u003C\u003Ec__DisplayClass15_0.w1rKQufyJ5KpF344UMcW((object) res))))).ToList<RebrendingLicenseStringsManifest>())
        fileResources.Remove(licenseStringsManifest);
    }

    /// <summary>Создать бренд пакет</summary>
    /// <param name="manifestPath"></param>
    /// <param name="cert"></param>
    public static void CreateBrandPackage(string manifestPath, X509Certificate2 cert)
    {
      int num1 = 6;
      FileStream file;
      while (true)
      {
        int num2 = num1;
        List<RebrendingImageManifest> rebrendingImageManifestList;
        List<RebrendingImageManifest>.Enumerator enumerator1;
        string brandPackagePath;
        string manifestPath1;
        BrandPackageManifest manifest;
        string brandPackageDir;
        while (true)
        {
          switch (num2)
          {
            case 1:
              file = (FileStream) BrandResourceManager.SwijiqPWguAjlEuYKAP((object) brandPackagePath, FileMode.Open, FileAccess.ReadWrite);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 12 : 1;
              continue;
            case 2:
              brandPackageDir = (string) BrandResourceManager.P1SgFv2LuqqenwCSjki((object) manifestPath1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 4 : 7;
              continue;
            case 3:
              if (BrandResourceManager.Apoe6lesYY7Cortmf4v((object) manifest.Images) > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                continue;
              }
              goto label_50;
            case 4:
              BrandResourceManager.VerifyFileResources((object) manifestPath1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309643702), (IList<RebrendingLicenseStringsManifest>) manifest.LicenseFiles);
              num2 = 3;
              continue;
            case 5:
              manifestPath1 = manifestPath;
              num2 = 9;
              continue;
            case 6:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 5 : 4;
              continue;
            case 7:
              brandPackagePath = (string) BrandResourceManager.iohVoneo2bTO08knrla((object) brandPackageDir, (object) string.Format((string) BrandResourceManager.ggyJMk2zqwfTfdn04wj(1142330761 ^ 1541959139 ^ 536775264), (object) manifest.Title, BrandResourceManager.N54b1TPFRZj2lTNDiv1((object) manifest)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 15 : 12;
              continue;
            case 8:
              goto label_39;
            case 9:
              manifest = ManifestBuilder.DeserializeByXmlFromFile<BrandPackageManifest>(manifestPath1);
              num2 = 17;
              continue;
            case 10:
              try
              {
label_54:
                if (enumerator1.MoveNext())
                  goto label_56;
                else
                  goto label_55;
label_53:
                RebrendingImageManifest current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                    case 5:
                      goto label_54;
                    case 2:
                      goto label_9;
                    case 3:
                      if (BrandResourceManager.Cxw7CbeLyS8j9phrqLu(BrandResourceManager.kcClQ2ezpeZ3Tw5mlfM(BrandResourceManager.P1SgFv2LuqqenwCSjki((object) manifestPath1), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345424502), BrandResourceManager.ggyJMk2zqwfTfdn04wj(-345420348 ^ -345424484), BrandResourceManager.a2DCwmecnr2rWdnIER4((object) current))))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 3 : 5;
                        continue;
                      }
                      break;
                    case 4:
                      goto label_56;
                  }
                  rebrendingImageManifestList.Add(current);
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 1;
                }
label_55:
                num3 = 2;
                goto label_53;
label_56:
                current = enumerator1.Current;
                num3 = 3;
                goto label_53;
              }
              finally
              {
                enumerator1.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 11:
              BrandResourceManager.VerifyFileResources((object) manifestPath1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70011063), (IList<RebrendingLicenseStringsManifest>) manifest.Strings);
              num2 = 4;
              continue;
            case 12:
              goto label_13;
            case 13:
              goto label_64;
            case 14:
label_9:
              enumerator1 = rebrendingImageManifestList.GetEnumerator();
              num2 = 8;
              continue;
            case 15:
              BrandResourceManager.rsJK2HPBsS46gKoBuf9((object) brandPackagePath, (object) (System.Action) (() =>
              {
                int num5 = 1;
                ZipOutputStream zipStream;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      zipStream = new ZipOutputStream((Stream) File.Create(brandPackagePath));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_60;
                    default:
                      goto label_3;
                  }
                }
label_60:
                return;
label_3:
                try
                {
                  // ISSUE: reference to a compiler-generated method
                  BrandResourceManager.WriteFileToZip((object) zipStream, (object) manifestPath1, BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.k041Kxfy54kUWwnDdVmD(-1380439818 << 3 ^ 1841379236));
                  int num6 = 2;
                  while (true)
                  {
                    int num7 = num6;
                    List<RebrendingLicenseStringsManifest>.Enumerator enumerator2;
                    string str1;
                    string[] strArray;
                    int index;
                    string str2;
                    List<RebrendingImageManifest>.Enumerator enumerator3;
                    while (true)
                    {
                      switch (num7)
                      {
                        case 0:
                          goto label_56;
                        case 1:
                          str2 = strArray[index];
                          num7 = 6;
                          continue;
                        case 2:
                          enumerator2 = manifest.Strings.GetEnumerator();
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 14 : 15;
                          continue;
                        case 3:
                          goto label_47;
                        case 4:
                        case 8:
                          if (index >= strArray.Length)
                          {
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
                            continue;
                          }
                          goto case 1;
                        case 5:
                          index = 0;
                          num7 = 8;
                          continue;
                        case 6:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.cteXpMfMF6b8fxF7XZMA((object) zipStream, (object) str2, BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.k041Kxfy54kUWwnDdVmD(381945751 ^ 1158627804 ^ 1406017863));
                          num7 = 12;
                          continue;
                        case 7:
                          goto label_52;
                        case 9:
label_51:
                          enumerator3 = manifest.Images.GetEnumerator();
                          num7 = 16;
                          continue;
                        case 10:
                          // ISSUE: reference to a compiler-generated method
                          if (!BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.eNwxgGfycZ7iFoXNdZML((object) str1))
                          {
                            num7 = 3;
                            continue;
                          }
                          goto case 14;
                        case 11:
                          try
                          {
label_24:
                            if (enumerator2.MoveNext())
                              goto label_27;
                            else
                              goto label_25;
label_22:
                            RebrendingLicenseStringsManifest current;
                            string str3;
                            int num8;
                            while (true)
                            {
                              switch (num8)
                              {
                                case 1:
                                  // ISSUE: reference to a compiler-generated method
                                  // ISSUE: reference to a compiler-generated method
                                  // ISSUE: reference to a compiler-generated method
                                  // ISSUE: reference to a compiler-generated method
                                  BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.qxJ46NfyUTTcllEmZBrB((object) zipStream, (object) str3, BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.jyG9CufyLl9X5sxT8Vwj(BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.k041Kxfy54kUWwnDdVmD(-1998538950 ^ -1998204426), BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.gUEMZhfyj2ZsNmoIkAUn((object) current)));
                                  num8 = 3;
                                  continue;
                                case 2:
                                  // ISSUE: reference to a compiler-generated method
                                  // ISSUE: reference to a compiler-generated method
                                  // ISSUE: reference to a compiler-generated method
                                  str3 = (string) BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.S8dknMfyYCiFiTtBXGah((object) brandPackageDir, BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.k041Kxfy54kUWwnDdVmD(1021410165 ^ 1021381251), BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.gUEMZhfyj2ZsNmoIkAUn((object) current));
                                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
                                  continue;
                                case 3:
                                  goto label_24;
                                case 4:
                                  goto label_27;
                                default:
                                  goto label_51;
                              }
                            }
label_25:
                            num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
                            goto label_22;
label_27:
                            current = enumerator2.Current;
                            num8 = 2;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
                            {
                              num8 = 2;
                              goto label_22;
                            }
                            else
                              goto label_22;
                          }
                          finally
                          {
                            enumerator2.Dispose();
                            int num9 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
                              num9 = 0;
                            switch (num9)
                            {
                              default:
                            }
                          }
                        case 12:
                          ++index;
                          num7 = 4;
                          continue;
                        case 13:
label_7:
                          enumerator2 = manifest.LicenseFiles.GetEnumerator();
                          num7 = 11;
                          continue;
                        case 14:
                          // ISSUE: reference to a compiler-generated method
                          strArray = (string[]) BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.oslgpHfyzk8jJvPagxXH((object) str1);
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 5;
                          continue;
                        case 15:
                          try
                          {
label_38:
                            if (enumerator2.MoveNext())
                              goto label_42;
                            else
                              goto label_39;
label_37:
                            string str4;
                            RebrendingLicenseStringsManifest current;
                            int num10;
                            while (true)
                            {
                              switch (num10)
                              {
                                case 1:
                                  goto label_7;
                                case 2:
                                  goto label_42;
                                case 3:
                                  // ISSUE: reference to a compiler-generated method
                                  // ISSUE: reference to a compiler-generated method
                                  // ISSUE: reference to a compiler-generated method
                                  str4 = (string) BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.S8dknMfyYCiFiTtBXGah((object) brandPackageDir, BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.k041Kxfy54kUWwnDdVmD(-1858887263 ^ -1858874907), BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.gUEMZhfyj2ZsNmoIkAUn((object) current));
                                  num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
                                  continue;
                                case 4:
                                  goto label_38;
                                default:
                                  // ISSUE: reference to a compiler-generated method
                                  // ISSUE: reference to a compiler-generated method
                                  // ISSUE: reference to a compiler-generated method
                                  BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.qxJ46NfyUTTcllEmZBrB((object) zipStream, (object) str4, BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.jyG9CufyLl9X5sxT8Vwj((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413339813), BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.gUEMZhfyj2ZsNmoIkAUn((object) current)));
                                  num10 = 4;
                                  continue;
                              }
                            }
label_39:
                            num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
                            goto label_37;
label_42:
                            current = enumerator2.Current;
                            num10 = 3;
                            goto label_37;
                          }
                          finally
                          {
                            enumerator2.Dispose();
                            int num11 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
                              num11 = 0;
                            switch (num11)
                            {
                              default:
                            }
                          }
                        case 16:
                          goto label_10;
                        default:
                          goto label_43;
                      }
                    }
label_10:
                    try
                    {
label_13:
                      if (enumerator3.MoveNext())
                        goto label_15;
                      else
                        goto label_14;
label_11:
                      RebrendingImageManifest current;
                      string str5;
                      int num12;
                      while (true)
                      {
                        switch (num12)
                        {
                          case 1:
                            goto label_15;
                          case 2:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.qxJ46NfyUTTcllEmZBrB((object) zipStream, (object) str5, BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.jyG9CufyLl9X5sxT8Vwj(BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.k041Kxfy54kUWwnDdVmD(-643786247 ^ -643432687), (object) current.FileName));
                            num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 3 : 3;
                            continue;
                          case 3:
                            goto label_13;
                          case 4:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            str5 = Path.Combine(brandPackageDir, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710571388), (string) BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.k041Kxfy54kUWwnDdVmD(322893104 - -1992822529 ^ -1979222935), (string) BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.oe7ZVSfys2gDbOwxhikH((object) current));
                            num12 = 2;
                            continue;
                          default:
                            goto label_52;
                        }
                      }
label_14:
                      num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
                      goto label_11;
label_15:
                      current = enumerator3.Current;
                      num12 = 4;
                      goto label_11;
                    }
                    finally
                    {
                      enumerator3.Dispose();
                      int num13 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
                        num13 = 0;
                      switch (num13)
                      {
                        default:
                      }
                    }
label_52:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    str1 = Path.Combine(brandPackageDir, (string) BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.k041Kxfy54kUWwnDdVmD(-1088304168 ^ -1088308330), (string) BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.k041Kxfy54kUWwnDdVmD(-420743386 ^ -420772022));
                    num6 = 10;
                  }
label_56:
                  return;
label_47:
                  return;
label_43:;
                }
                finally
                {
                  zipStream.IsStreamOwner = true;
                  int num14 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
                    num14 = 0;
                  while (true)
                  {
                    switch (num14)
                    {
                      case 1:
                        goto label_62;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        BrandResourceManager.\u003C\u003Ec__DisplayClass16_0.cGreZUfMB0gukp43QB93((object) zipStream);
                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
                        continue;
                    }
                  }
label_62:;
                }
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
              continue;
            case 16:
              goto label_50;
            case 17:
              rebrendingImageManifestList = new List<RebrendingImageManifest>();
              num2 = 11;
              continue;
            default:
              enumerator1 = manifest.Images.GetEnumerator();
              num2 = 10;
              continue;
          }
        }
label_39:
        try
        {
label_41:
          if (enumerator1.MoveNext())
            goto label_44;
          else
            goto label_42;
label_40:
          RebrendingImageManifest current;
          int num15;
          while (true)
          {
            switch (num15)
            {
              case 1:
                goto label_44;
              case 2:
                goto label_41;
              case 3:
                goto label_50;
              default:
                manifest.Images.Remove(current);
                num15 = 2;
                continue;
            }
          }
label_42:
          num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 3 : 3;
          goto label_40;
label_44:
          current = enumerator1.Current;
          num15 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
          {
            num15 = 0;
            goto label_40;
          }
          else
            goto label_40;
        }
        finally
        {
          enumerator1.Dispose();
          int num16 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
            num16 = 0;
          switch (num16)
          {
            default:
          }
        }
label_50:
        ManifestBuilder.SerializeByXmlToFile<BrandPackageManifest>((object) manifest, manifestPath1);
        num1 = 2;
      }
label_64:
      return;
label_13:
      try
      {
        int num17 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
          num17 = 0;
        ZipFile zf;
        while (true)
        {
          switch (num17)
          {
            case 1:
              goto label_17;
            default:
              zf = new ZipFile(file);
              num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 1;
              continue;
          }
        }
label_17:
        try
        {
          byte[] filesHashArray = BrandResourceManager.EvaluateFilesHashArray(zf.OfType<ZipEntry>(), (Func<ZipEntry, byte[]>) (e => zf.GetInputStream(e).ReadAllBytes()));
          int num18 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
            num18 = 1;
          byte[] numArray;
          while (true)
          {
            switch (num18)
            {
              case 1:
                numArray = (byte[]) BrandResourceManager.Dp5PivPhko43bbKknSQ(BrandResourceManager.QKVomOPbSIHWiWgPmmW((object) zf, BrandResourceManager.LRYm93PornK2fSNONEV((object) zf, BrandResourceManager.ggyJMk2zqwfTfdn04wj(-53329496 >> 4 ^ -3320818))));
                num18 = 3;
                continue;
              case 2:
                goto label_60;
              case 3:
                BrandResourceManager.t4Wu86PGiQ3AjFvRJoo((object) zf);
                num18 = 4;
                continue;
              case 4:
                BrandResourceManager.t4FemEPEhWyxNctO937((object) zf, (object) cert, (object) numArray, (object) filesHashArray);
                num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                continue;
              default:
                zf.CommitUpdate();
                num18 = 2;
                continue;
            }
          }
label_60:;
        }
        finally
        {
          if (zf != null)
          {
            int num19 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
              num19 = 1;
            while (true)
            {
              switch (num19)
              {
                case 1:
                  ((IDisposable) zf).Dispose();
                  num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_29;
              }
            }
          }
label_29:;
        }
      }
      finally
      {
        int num20;
        if (file == null)
          num20 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 1;
        else
          goto label_33;
label_32:
        switch (num20)
        {
          case 1:
          case 2:
        }
label_33:
        BrandResourceManager.m0ToGCeZIvtSRPdKeqQ((object) file);
        num20 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
        {
          num20 = 2;
          goto label_32;
        }
        else
          goto label_32;
      }
    }

    /// <summary>Распаковать бренд пакет в указанную папку</summary>
    /// <param name="packagePath"></param>
    /// <param name="pathToUnpack"></param>
    /// <returns></returns>
    public static bool UnpackBrandPackage(string packagePath, string pathToUnpack)
    {
      int num1 = 3;
      FileStream file;
      bool flag;
      FileStream fileStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_69:
            fileStream = File.Open(packagePath, FileMode.Open, FileAccess.Read);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            if (!File.Exists(packagePath))
            {
              num1 = 2;
              continue;
            }
            file = (FileStream) BrandResourceManager.SwijiqPWguAjlEuYKAP((object) packagePath, FileMode.Open, FileAccess.Read);
            num1 = 5;
            continue;
          case 4:
            goto label_6;
          case 5:
            try
            {
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
                num2 = 0;
              ZipFile zf;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_26;
                  default:
                    zf = new ZipFile(file);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 1;
                    continue;
                }
              }
label_26:
              try
              {
                ZipEntry zipEntry1 = (ZipEntry) BrandResourceManager.LRYm93PornK2fSNONEV((object) zf, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309643352));
                int num3 = 6;
                ZipEntry entry;
                string str;
                ZipEntry zipEntry2;
                ZipEntry zipEntry3;
                byte[] data;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      zipEntry2 = (ZipEntry) BrandResourceManager.LRYm93PornK2fSNONEV((object) zf, BrandResourceManager.TSPZaTewNV478f81S3S((object) str, BrandResourceManager.ggyJMk2zqwfTfdn04wj(~538519529 ^ -538531400)));
                      num3 = 18;
                      continue;
                    case 2:
                      if (zipEntry3 != null)
                      {
                        num3 = 7;
                        continue;
                      }
                      goto case 9;
                    case 3:
                      str = (string) BrandResourceManager.Nn2VMIPf5JjmWsD7Cmd(BrandResourceManager.ggyJMk2zqwfTfdn04wj(516838154 ^ 516825378), BrandResourceManager.ggyJMk2zqwfTfdn04wj(-2112703338 ^ -2112698888));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 11 : 2;
                      continue;
                    case 4:
                      flag = false;
                      num3 = 15;
                      continue;
                    case 5:
                      if (entry == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 5 : 10;
                        continue;
                      }
                      goto case 14;
                    case 6:
                      if (zipEntry1 != null)
                      {
                        num3 = 16;
                        continue;
                      }
                      goto case 4;
                    case 7:
                    case 13:
                      num3 = 12;
                      continue;
                    case 8:
                    case 16:
                      data = (byte[]) BrandResourceManager.Dp5PivPhko43bbKknSQ(BrandResourceManager.QKVomOPbSIHWiWgPmmW((object) zf, (object) zipEntry1));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 3;
                      continue;
                    case 9:
                    case 10:
                    case 17:
                      flag = false;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
                      continue;
                    case 11:
                      entry = zf.GetEntry(str + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021381363));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
                      continue;
                    case 12:
                      goto label_44;
                    case 14:
                      if (zipEntry2 == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 3 : 17;
                        continue;
                      }
                      goto case 2;
                    case 18:
                      zipEntry3 = (ZipEntry) BrandResourceManager.LRYm93PornK2fSNONEV((object) zf, BrandResourceManager.TSPZaTewNV478f81S3S((object) str, BrandResourceManager.ggyJMk2zqwfTfdn04wj(647913418 ^ 647900690)));
                      num3 = 5;
                      continue;
                    default:
                      goto label_6;
                  }
                }
label_44:
                try
                {
                  X509Certificate2 x509Certificate2 = new X509Certificate2((byte[]) BrandResourceManager.Dp5PivPhko43bbKknSQ(BrandResourceManager.QKVomOPbSIHWiWgPmmW((object) zf, (object) zipEntry3)));
                  byte[] signature = (byte[]) BrandResourceManager.Dp5PivPhko43bbKknSQ((object) zf.GetInputStream(entry));
                  byte[] numArray = (byte[]) BrandResourceManager.Dp5PivPhko43bbKknSQ(BrandResourceManager.QKVomOPbSIHWiWgPmmW((object) zf, (object) zipEntry2));
                  IEnumerable<ZipEntry> source = zf.OfType<ZipEntry>();
                  // ISSUE: reference to a compiler-generated field
                  Func<ZipEntry, bool> func = BrandResourceManager.\u003C\u003Ec.\u003C\u003E9__17_0;
                  Func<ZipEntry, bool> predicate;
                  if (func == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    BrandResourceManager.\u003C\u003Ec.\u003C\u003E9__17_0 = predicate = (Func<ZipEntry, bool>) (e =>
                    {
                      int num4 = 1;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            if (BrandResourceManager.\u003C\u003Ec.WekipFfywHN6nlXEORaU(BrandResourceManager.\u003C\u003Ec.bkBXv1fyt6nlvPqgcaug((object) e), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333740412)))
                            {
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
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
                      // ISSUE: reference to a compiler-generated method
                      return !BrandResourceManager.\u003C\u003Ec.GWJd88fyaxgfStApssme((object) e);
label_5:
                      return false;
                    });
                  }
                  else
                    goto label_70;
label_46:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  byte[] filesHashArray = BrandResourceManager.EvaluateFilesHashArray((IEnumerable<ZipEntry>) source.Where<ZipEntry>(predicate).ToArray<ZipEntry>(), (Func<ZipEntry, byte[]>) (e => (byte[]) BrandResourceManager.\u003C\u003Ec__DisplayClass17_0.UlQfrrfMv39v4rJVDviM(BrandResourceManager.\u003C\u003Ec__DisplayClass17_0.TA4vyZfMC5CGFwbNcqpf((object) zf, (object) e))));
                  RSACryptoServiceProvider csp = (RSACryptoServiceProvider) BrandResourceManager.jRCuhdPCc7XXpUJfhOq(BrandResourceManager.bTObFRPQNGxekniv5oC((object) x509Certificate2));
                  int num5 = 5;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                      case 4:
                        flag = false;
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
                        continue;
                      case 2:
                      case 6:
                        goto label_69;
                      case 3:
                        if (BrandResourceManager.gkk1yAPvYXMMcFYiqlT((object) filesHashArray, (object) csp, (object) numArray))
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 1;
                          continue;
                        }
                        goto case 1;
                      case 5:
                        if (!BrandResourceManager.VerifySignature((object) data, (object) csp, (object) signature))
                        {
                          num5 = 4;
                          continue;
                        }
                        goto case 3;
                      default:
                        goto label_6;
                    }
                  }
label_70:
                  predicate = func;
                  goto label_46;
                }
                catch
                {
                  int num6 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
                    num6 = 0;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        flag = false;
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_6;
                    }
                  }
                }
              }
              finally
              {
                int num7;
                if (zf == null)
                  num7 = 2;
                else
                  goto label_60;
label_59:
                switch (num7)
                {
                  case 1:
                  case 2:
                }
label_60:
                BrandResourceManager.m0ToGCeZIvtSRPdKeqQ((object) zf);
                num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
                {
                  num7 = 1;
                  goto label_59;
                }
                else
                  goto label_59;
              }
            }
            finally
            {
              if (file != null)
              {
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
                  num8 = 1;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      BrandResourceManager.m0ToGCeZIvtSRPdKeqQ((object) file);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_68;
                  }
                }
              }
label_68:;
            }
          default:
            goto label_7;
        }
      }
label_4:
      return false;
label_6:
      return flag;
label_7:
      try
      {
        BrandResourceManager.bMXVRgP8PZSMUACLpay((object) new FastZip(), (object) fileStream, (object) pathToUnpack, FastZip.Overwrite.Always, (object) null, (object) null, (object) null, true, false, false);
        int num9 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
          num9 = 0;
        while (true)
        {
          switch (num9)
          {
            case 1:
              flag = true;
              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
      }
      catch
      {
        int num10 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
          num10 = 0;
        while (true)
        {
          switch (num10)
          {
            case 1:
              flag = false;
              num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
      }
      finally
      {
        int num11;
        if (fileStream == null)
          num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 1;
        else
          goto label_19;
label_18:
        switch (num11)
        {
          case 2:
            break;
          default:
        }
label_19:
        BrandResourceManager.m0ToGCeZIvtSRPdKeqQ((object) fileStream);
        num11 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
        {
          num11 = 0;
          goto label_18;
        }
        else
          goto label_18;
      }
    }

    public static Stream GetBrandPackage()
    {
      int num = 3;
      string[] source;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (!((IEnumerable<string>) source).Any<string>())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
              continue;
            }
            goto label_5;
          case 3:
            source = (string[]) BrandResourceManager.bf2SAReWpTSFwIm3h9c((object) BrandResourceManager._reourcesDirectory, BrandResourceManager.ggyJMk2zqwfTfdn04wj(654297945 ^ 654288037));
            num = 2;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return (Stream) new FileStream(((IEnumerable<string>) source).First<string>(), FileMode.Open, FileAccess.Read);
label_6:
      return (Stream) null;
    }

    internal static void w2R4yF25p9e4S6PXi0Y() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type my7d6N2jwVCBXumxug7([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object brTeni2Y0TMr8yGPAxO([In] object obj0) => (object) ((Assembly) obj0).Location;

    internal static object P1SgFv2LuqqenwCSjki([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object WqYm9N2U0JcSt4EMOgr() => (object) AppDomain.CurrentDomain;

    internal static object Ixqq5p2shrenXn0cp4L([In] object obj0) => (object) ((AppDomain) obj0).SetupInformation;

    internal static object pj5TXC2cDHQcXhjaVx8([In] object obj0) => (object) ((AppDomainSetup) obj0).ConfigurationFile;

    internal static object ggyJMk2zqwfTfdn04wj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool i6ESWb2rulBAGqKEYQQ() => BrandResourceManager.SkDtKr2lZHYkgl1fKtG == null;

    internal static BrandResourceManager UtUkLl2gX9vN8BNK2fq() => BrandResourceManager.SkDtKr2lZHYkgl1fKtG;

    internal static bool yNtA17eF8WNSCKyvwVv([In] object obj0) => Directory.Exists((string) obj0);

    internal static object a0qblEeBj7QokfcvsP9([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object bf2SAReWpTSFwIm3h9c([In] object obj0, [In] object obj1) => (object) Directory.GetFiles((string) obj0, (string) obj1);

    internal static object iohVoneo2bTO08knrla([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool H8pumvebVpqmYCBfPKF([In] object obj0, [In] object obj1) => BrandResourceManager.UnpackBrandPackage((string) obj0, (string) obj1);

    internal static object QQkyPKehvv4DsEtIecx([In] object obj0) => (object) ((RebrendingLicenseStringsManifest) obj0).FileName;

    internal static object RdBPlYeGVArPEvIIrZ4([In] object obj0, [In] object obj1, [In] object obj2) => (object) Path.Combine((string) obj0, (string) obj1, (string) obj2);

    internal static object ilCt3leEn2uk8ZOVPNh([In] object obj0) => (object) XmlReader.Create((Stream) obj0);

    internal static object VD9c6UefXTLls1I9r5f([In] object obj0) => (object) ((RebrendingLicenseStringsManifest) obj0).Locale;

    internal static object aVSVAdeQyFuQ7lYA1kr([In] object obj0) => (object) ((DirectoryInfo) obj0).GetDirectories();

    internal static object HxF7JXeCotpfEdnhlft([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static void MY4mthevNoXb5FlLNyI([In] object obj0, [In] object obj1) => BrandResourceManager.AddLocalizedReplaceDictionary(obj0, obj1);

    internal static object bWSTTle8eQLG7qS11Nr([In] object obj0) => (object) ((RebrendingImageManifest) obj0).FullName;

    internal static void m0ToGCeZIvtSRPdKeqQ([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object OeZl6Reu2qSPdJbPG7M() => (object) HttpContext.Current;

    internal static object X6eSyReI8F7lRKNX6xk([In] object obj0, [In] object obj1) => (object) ((HttpServerUtility) obj0).MapPath((string) obj1);

    internal static void wsqHF9eVsy11gGrGMmR([In] object obj0, [In] object obj1) => BrandResourceManager.CopyFolderContents(obj0, obj1);

    internal static void X2pchaeSDfqlAVhbZRS([In] object obj0, [In] bool obj1) => Directory.Delete((string) obj0, obj1);

    internal static object Dm7t3DeiUWGxx06TnHF() => (object) EleWise.ELMA.SR.KeyCultureInfo;

    internal static bool OnOU04eR1XO8eJLy7nO([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static object j5rI0aeqBwWFAbgwueQ([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object imIjhReKaMU75bt4BKk() => (object) ComponentManager.GetAssemblies();

    internal static int fh1idieXy2LhyaTnaEJ([In] object obj0) => ((ICollection<BrandResourceAttribute>) obj0).Count;

    internal static Type oJEUMweTkMnC3yr4Dpv([In] object obj0, [In] object obj1) => ((Assembly) obj0).GetType((string) obj1);

    internal static bool G58PO7ek3aTcdZVMij2([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object wiei8YenNY1kURKrJf8([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static object HobP9seObe19NKtMnFh([In] object obj0) => (object) ((BrandResourceAttribute) obj0).ResourceName;

    internal static object YMctBNe2JBTYTivb9dX([In] object obj0, [In] object obj1) => ((ResourceManager) obj0).GetObject((string) obj1);

    internal static object RXKdHheedu2cfGmrYxw([In] object obj0) => (object) ((BrandResourceAttribute) obj0).ResourceFullName;

    internal static object G7VEMZePawcArZ34mso([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static bool vBFkBde13rE4h5R2B1a([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void GQuBgmeNddcY4BHwfI8([In] object obj0) => Monitor.Exit(obj0);

    internal static int w1858ie3YcmC3lg2dNC([In] object obj0) => ((List<RebrandingStrings.RebrandingString>) obj0).Count;

    internal static object sxSFDFepEjahpxMlrYQ([In] object obj0) => (object) ((RebrandingStrings.RebrandingString) obj0).Key;

    internal static object qekRiJea6FOFNsDg7ni([In] object obj0) => (object) ((RebrandingStrings.RebrandingString) obj0).Value;

    internal static int yeTG2FeDWeRbL2N9243([In] object obj0) => ((Dictionary<string, string>) obj0).Count;

    internal static bool wSxNT9etovTH8o3eWEC([In] object obj0, [In] object obj1) => ((string) obj0).EndsWith((string) obj1);

    internal static object TSPZaTewNV478f81S3S([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object K3bxJ7e4WMICEE2MoYi([In] object obj0) => (object) Directory.GetFiles((string) obj0);

    internal static object RktfeGe6PmmR6kQ44fk([In] object obj0, [In] object obj1, [In] bool obj2) => (object) ((FileInfo) obj0).CopyTo((string) obj1, obj2);

    internal static object wUQHOPeHGHmGVNA8Mls([In] object obj0) => (object) ((FileSystemInfo) obj0).Name;

    internal static object U2Hhl5eAdEmlwNlIdM4([In] object obj0) => (object) ZipEntry.CleanName((string) obj0);

    internal static DateTime jLF9UBe7dgympYXPjN3([In] object obj0) => ((FileSystemInfo) obj0).LastWriteTime;

    internal static void M5WuwhexKYk54xDLix6([In] object obj0, [In] DateTime obj1) => ((ZipEntry) obj0).DateTime = obj1;

    internal static void kSOIete0BQ5kE7mwIwy([In] object obj0, [In] long obj1) => ((ZipEntry) obj0).Size = obj1;

    internal static void nT0yHjem6pwF0Bbc8eK([In] object obj0, [In] object obj1) => ((ZipOutputStream) obj0).PutNextEntry((ZipEntry) obj1);

    internal static object S05qnJeyaNYeWbqGjCk([In] object obj0) => (object) File.OpenRead((string) obj0);

    internal static void B2dKtIeMnAOe4eEVIKX([In] object obj0, [In] object obj1, [In] object obj2) => StreamUtils.Copy((Stream) obj0, (Stream) obj1, (byte[]) obj2);

    internal static void wwLYvBeJEyjsQpBpFBf([In] object obj0) => ((ZipOutputStream) obj0).CloseEntry();

    internal static object oe8KTre9JXwrJHJXi6E([In] object obj0, [In] object obj1) => (object) ((DirectoryInfo) obj0).GetFiles((string) obj1);

    internal static object j4b13med3nD3HYZN791([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) string.Format((string) obj0, obj1, obj2, obj3);

    internal static object eCcAjHelpwdqRV1lF99([In] object obj0) => (object) ((FileSystemInfo) obj0).FullName;

    internal static void wDoi0ier3xVKX3MGx2H([In] object obj0, [In] object obj1, [In] object obj2) => BrandResourceManager.WriteFileToZip(obj0, obj1, obj2);

    internal static object BgreNmegp96X0BwLr91([In] object obj0) => (object) ((DirectoryInfo) obj0).GetDirectories();

    internal static void KR10NGe5JwWAIjkVSLn([In] object obj0, [In] object obj1, [In] object obj2) => BrandResourceManager.WriteDirectoryToZip(obj0, obj1, obj2);

    internal static object jmOVkEejQcMuDKA65ab([In] object obj0) => (object) CryptoConfig.MapNameToOID((string) obj0);

    internal static bool W04kZteYap3jkwtVJPH([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((RSACryptoServiceProvider) obj0).VerifyHash((byte[]) obj1, (string) obj2, (byte[]) obj3);

    internal static bool Cxw7CbeLyS8j9phrqLu([In] object obj0) => File.Exists((string) obj0);

    internal static void FjVMtUeUXMCf279R0AE([In] object obj0, [In] object obj1) => BrandResourceManager.CreateBrandPackage((string) obj0, (X509Certificate2) obj1);

    internal static int Apoe6lesYY7Cortmf4v([In] object obj0) => ((List<RebrendingImageManifest>) obj0).Count;

    internal static object a2DCwmecnr2rWdnIER4([In] object obj0) => (object) ((RebrendingImageManifest) obj0).FileName;

    internal static object kcClQ2ezpeZ3Tw5mlfM([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) Path.Combine((string) obj0, (string) obj1, (string) obj2, (string) obj3);

    internal static object N54b1TPFRZj2lTNDiv1([In] object obj0) => (object) ((BrandPackageManifest) obj0).Version;

    internal static void rsJK2HPBsS46gKoBuf9([In] object obj0, [In] object obj1) => FS.CreateFile((string) obj0, (System.Action) obj1);

    internal static object SwijiqPWguAjlEuYKAP([In] object obj0, [In] FileMode obj1, [In] FileAccess obj2) => (object) File.Open((string) obj0, obj1, obj2);

    internal static object LRYm93PornK2fSNONEV([In] object obj0, [In] object obj1) => (object) ((ZipFile) obj0).GetEntry((string) obj1);

    internal static object QKVomOPbSIHWiWgPmmW([In] object obj0, [In] object obj1) => (object) ((ZipFile) obj0).GetInputStream((ZipEntry) obj1);

    internal static object Dp5PivPhko43bbKknSQ([In] object obj0) => (object) ((Stream) obj0).ReadAllBytes();

    internal static void t4Wu86PGiQ3AjFvRJoo([In] object obj0) => ((ZipFile) obj0).BeginUpdate();

    internal static void t4FemEPEhWyxNctO937([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => BrandResourceManager.WriteSignatures(obj0, obj1, obj2, obj3);

    internal static object Nn2VMIPf5JjmWsD7Cmd([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object bTObFRPQNGxekniv5oC([In] object obj0) => (object) ((X509Certificate2) obj0).PublicKey;

    internal static object jRCuhdPCc7XXpUJfhOq([In] object obj0) => (object) ((PublicKey) obj0).Key;

    internal static bool gkk1yAPvYXMMcFYiqlT([In] object obj0, [In] object obj1, [In] object obj2) => BrandResourceManager.VerifySignature(obj0, obj1, obj2);

    internal static void bMXVRgP8PZSMUACLpay(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] FastZip.Overwrite obj3,
      [In] object obj4,
      [In] object obj5,
      [In] object obj6,
      [In] bool obj7,
      [In] bool obj8,
      [In] bool obj9)
    {
      ((FastZip) obj0).ExtractZip((Stream) obj1, (string) obj2, obj3, (FastZip.ConfirmOverwriteDelegate) obj4, (string) obj5, (string) obj6, obj7, obj8, obj9);
    }

    private class MemoryStreamDataSource : IStaticDataSource
    {
      private readonly object bytes;
      internal static object oC6oMDfyG8HSbmJWQe2E;

      public MemoryStreamDataSource(byte[] bytes)
      {
        BrandResourceManager.MemoryStreamDataSource.SPpyoIfyQo5QEWXHQQBt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.bytes = (object) bytes;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      public Stream GetSource() => (Stream) BrandResourceManager.MemoryStreamDataSource.HhHm6cfyCjk6kVcxjunW(this.bytes, false);

      internal static void SPpyoIfyQo5QEWXHQQBt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool mU1pS3fyE3lIKkZyexRd() => BrandResourceManager.MemoryStreamDataSource.oC6oMDfyG8HSbmJWQe2E == null;

      internal static BrandResourceManager.MemoryStreamDataSource fYsJJdfyfGElLN93SUYL() => (BrandResourceManager.MemoryStreamDataSource) BrandResourceManager.MemoryStreamDataSource.oC6oMDfyG8HSbmJWQe2E;

      internal static object HhHm6cfyCjk6kVcxjunW([In] object obj0, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, writable);
    }
  }
}
