// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.DTO.LocalizationLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Globalization.DTO
{
  /// <summary>Загрузка локализации</summary>
  public class LocalizationLoader : DTOManager, ILocalizationLoader, IConfigurationService
  {
    private static LocalizationLoader kHDkskGfHvtB6v0KbgLg;

    public virtual byte[] Execute(LocalizationLoadSettings settings)
    {
      int num1 = 10;
      string str;
      while (true)
      {
        IEnumerator<ILocalizationFileResolver> enumerator1;
        Dictionary<string, List<PoLineDescriptor>> dictionary;
        Dictionary<string, List<PoLineDescriptor>>.Enumerator enumerator2;
        string dir;
        switch (num1)
        {
          case 1:
            LocalizationLoader.fwhQeFGf5dIG97clsx1V((object) Locator.GetServiceNotNull<IZipService>(), (object) str, (object) dir);
            num1 = 4;
            continue;
          case 2:
            try
            {
label_7:
              if (enumerator2.MoveNext())
                goto label_6;
              else
                goto label_8;
label_5:
              KeyValuePair<string, List<PoLineDescriptor>> current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_7;
                  case 2:
                    LocalizationFile localizationFile = new LocalizationFile();
                    LocalizationLoader.NMRUQ8Gflj24CGEBxQl2((object) localizationFile, LocalizationLoader.vpPeQYGfduXIORcngn8W(~1767720452 ^ -1767644253));
                    LocalizationLoader.sCcUIrGfrJ5n8boDRYxX((object) localizationFile, (object) current.Key);
                    localizationFile.Resources = new ConcurrentBag<PoLineDescriptor>((IEnumerable<PoLineDescriptor>) current.Value);
                    localizationFile.SaveToFile(dir);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
                    continue;
                  case 3:
                    goto label_14;
                  default:
                    goto label_6;
                }
              }
label_6:
              current = enumerator2.Current;
              num2 = 2;
              goto label_5;
label_8:
              num2 = 3;
              goto label_5;
            }
            finally
            {
              enumerator2.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 3:
            LocalizationLoader.tXbGFgGf9DUea4W1msaR((object) dir);
            num1 = 7;
            continue;
          case 4:
            goto label_18;
          case 5:
label_14:
            str = (string) LocalizationLoader.q6SKvWGfgygwlnrXZmj3((object) dir, LocalizationLoader.vpPeQYGfduXIORcngn8W(1642859704 ^ 1642950616));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
            continue;
          case 6:
            try
            {
label_29:
              if (LocalizationLoader.d8nTEQGfmSV8g7JTGf1V((object) enumerator1))
                goto label_32;
              else
                goto label_30;
label_23:
              ILocalizationFileResolver current;
              int num4;
              while (true)
              {
                List<PoLineDescriptor> poLineDescriptorList1;
                IEnumerable<PoLineDescriptor> collection;
                List<PoLineDescriptor> poLineDescriptorList2;
                switch (num4)
                {
                  case 1:
                  case 11:
                    poLineDescriptorList1.AddRange(collection);
                    num4 = 4;
                    continue;
                  case 2:
                    collection = current.CollectResources(settings);
                    num4 = 9;
                    continue;
                  case 3:
                    goto label_29;
                  case 4:
                    dictionary[(string) LocalizationLoader.GZRjwbGf0lvdCtHoRum2((object) current)] = poLineDescriptorList1;
                    num4 = 3;
                    continue;
                  case 5:
                  case 8:
                    poLineDescriptorList1 = new List<PoLineDescriptor>();
                    num4 = 10;
                    continue;
                  case 6:
                    poLineDescriptorList2 = dictionary[current.FileName];
                    if (poLineDescriptorList2 == null)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 6 : 7;
                      continue;
                    }
                    break;
                  case 7:
                    poLineDescriptorList2 = new List<PoLineDescriptor>();
                    break;
                  case 9:
                    if (!dictionary.ContainsKey((string) LocalizationLoader.GZRjwbGf0lvdCtHoRum2((object) current)))
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 5 : 2;
                      continue;
                    }
                    goto case 6;
                  case 10:
                    dictionary.Add((string) LocalizationLoader.GZRjwbGf0lvdCtHoRum2((object) current), poLineDescriptorList1);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 1;
                    continue;
                  case 12:
                    goto label_32;
                  default:
                    goto label_15;
                }
                poLineDescriptorList1 = poLineDescriptorList2;
                num4 = 11;
              }
label_30:
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
              goto label_23;
label_32:
              current = enumerator1.Current;
              num4 = 2;
              goto label_23;
            }
            finally
            {
              int num5;
              if (enumerator1 == null)
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 2 : 2;
              else
                goto label_41;
label_40:
              switch (num5)
              {
                case 1:
                case 2:
              }
label_41:
              LocalizationLoader.o1FhqqGfy0GTFeuyiTXN((object) enumerator1);
              num5 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
              {
                num5 = 1;
                goto label_40;
              }
              else
                goto label_40;
            }
          case 7:
            enumerator2 = dictionary.GetEnumerator();
            num1 = 2;
            continue;
          case 8:
            if (!LocalizationLoader.igj7QfGfJO1ndaBYnSHh((object) dir))
            {
              num1 = 3;
              continue;
            }
            goto case 7;
          case 9:
            enumerator1 = ((ComponentManager) LocalizationLoader.iGmbS9Gfx8RkWtVO66rc()).GetExtensionPoints<ILocalizationFileResolver>().GetEnumerator();
            num1 = 6;
            continue;
          case 10:
            dictionary = new Dictionary<string, List<PoLineDescriptor>>();
            num1 = 9;
            continue;
        }
label_15:
        dir = (string) LocalizationLoader.FHW2wxGfM8iIxQkUPd4o();
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 8 : 1;
      }
label_18:
      return (byte[]) LocalizationLoader.VWydQkGfj0Njp0SyF0lP((object) str);
    }

    public LocalizationLoader()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object iGmbS9Gfx8RkWtVO66rc() => (object) ComponentManager.Current;

    internal static object GZRjwbGf0lvdCtHoRum2([In] object obj0) => (object) ((ILocalizationFileResolver) obj0).FileName;

    internal static bool d8nTEQGfmSV8g7JTGf1V([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void o1FhqqGfy0GTFeuyiTXN([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object FHW2wxGfM8iIxQkUPd4o() => (object) IOExtensions.GetTempFileNameWithoutExtension();

    internal static bool igj7QfGfJO1ndaBYnSHh([In] object obj0) => Directory.Exists((string) obj0);

    internal static object tXbGFgGf9DUea4W1msaR([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object vpPeQYGfduXIORcngn8W(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void NMRUQ8Gflj24CGEBxQl2([In] object obj0, [In] object obj1) => ((LocalizationFile) obj0).LocalizationName = (string) obj1;

    internal static void sCcUIrGfrJ5n8boDRYxX([In] object obj0, [In] object obj1) => ((LocalizationFile) obj0).Name = (string) obj1;

    internal static object q6SKvWGfgygwlnrXZmj3([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object fwhQeFGf5dIG97clsx1V([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IZipService) obj0).CreateZipFolder((string) obj1, (string) obj2);

    internal static object VWydQkGfj0Njp0SyF0lP([In] object obj0) => (object) File.ReadAllBytes((string) obj0);

    internal static bool Sf1VSxGfAac4JH3VNNNx() => LocalizationLoader.kHDkskGfHvtB6v0KbgLg == null;

    internal static LocalizationLoader TyhSM9Gf7QWT4VkhhS3A() => LocalizationLoader.kHDkskGfHvtB6v0KbgLg;
  }
}
