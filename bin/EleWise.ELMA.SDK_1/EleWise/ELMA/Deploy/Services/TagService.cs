// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.TagService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>Сервис работы с ограничениями bpmApp</summary>
  [Service]
  public class TagService : ITagService
  {
    private List<string> tagLanguage;
    private List<string> tagDataBase;
    private List<string> tagEdition;
    private static TagService Y76wxSEAQZhuvFqf2ErR;

    public List<string> TagLanguage
    {
      get
      {
        if (this.tagLanguage == null)
        {
          this.tagLanguage = new List<string>();
          CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
          this.tagLanguage.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099460355));
          this.tagLanguage.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3557982));
          foreach (string str in (IEnumerable<string>) ((IEnumerable<CultureInfo>) cultures).Select<CultureInfo, string>((Func<CultureInfo, string>) (c => ((string) TagService.\u003C\u003Ec.lsxK4M8aSIe7nLXa3Dt1((object) c)).ToLower().ToString())).OrderBy<string, string>((Func<string, string>) (c => c)))
          {
            if (!this.tagLanguage.Contains(str))
              this.tagLanguage.Add(str);
          }
        }
        return this.tagLanguage;
      }
    }

    public List<string> TagDataBase
    {
      get
      {
        List<string> tagDataBase1 = this.tagDataBase;
        if (tagDataBase1 != null)
          return tagDataBase1;
        List<string> stringList = new List<string>();
        stringList.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426385153));
        stringList.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345121776));
        stringList.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874303409));
        List<string> tagDataBase2 = stringList;
        this.tagDataBase = stringList;
        return tagDataBase2;
      }
    }

    public List<string> TagEdition
    {
      get
      {
        if (this.tagEdition == null)
          this.tagEdition = Enum.GetValues(typeof (ElmaEdition)).Cast<ElmaEdition>().Select<ElmaEdition, string>((Func<ElmaEdition, string>) (e => (string) TagService.\u003C\u003Ec.xqOBQK8aiXJIoWAyRHhK((object) e.ToString()))).ToList<string>();
        return this.tagEdition;
      }
    }

    public bool ValidateTags(ElmaStoreComponentManifest manifest) => this.ValidateTags(manifest, out List<TestImportMessages> _);

    public bool ValidateTags(
      ElmaStoreComponentManifest manifest,
      out List<TestImportMessages> messages)
    {
      int num1 = 27;
      bool flag;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          CultureInfo cultureInfo1;
          ElmaEdition? editionType;
          string str;
          CultureInfo cultureInfo2;
          CultureInfo cultureInfo3;
          string currentEditionStr;
          string currentDataBaseStr;
          string currentBaseLangyageStr;
          string currentSystemLanguageStr;
          switch (num2)
          {
            case 1:
              if (manifest.TagDataBaseList.All<string>((Func<string, bool>) (t => t != currentDataBaseStr)))
              {
                num2 = 43;
                continue;
              }
              goto case 41;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 18 : 9;
              continue;
            case 3:
              if (manifest.TagDataBaseList.Any<string>())
              {
                num2 = 24;
                continue;
              }
              goto case 41;
            case 4:
              cultureInfo1 = (CultureInfo) TagService.saxTKxEAqPIDsIA9BYY3();
              num2 = 11;
              continue;
            case 5:
            case 14:
              List<TestImportMessages> testImportMessagesList1 = messages;
              object t1 = TagService.GDxqhrEAZZakScFwUvO8(1461625753 ^ 1461334405);
              object[] objArray1 = new object[2]
              {
                (object) manifest.Id,
                null
              };
              object obj1 = TagService.jsh3UEEASrgLgHnvhDDl((object) manifest);
              objArray1[1] = obj1 == null ? (object) string.Empty : obj1;
              TestImportMessages testImportMessages1 = new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) t1, objArray1));
              testImportMessagesList1.Add(testImportMessages1);
              num2 = 38;
              continue;
            case 6:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 6 : 15;
              continue;
            case 7:
              cultureInfo3 = ((LanguagesMap) TagService.z1BM49EAKTWd0ROxHfdx()).GetBaseCultureInfo((string) TagService.EGpFgHEAXfWhalugbC5g((object) cultureInfo1));
              break;
            case 8:
            case 16:
              messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) TagService.GDxqhrEAZZakScFwUvO8(1051276242 - 990076387 ^ 60901189), (object) manifest.Id, (object) (manifest.TagEdition ?? string.Empty))));
              num2 = 12;
              continue;
            case 9:
              goto label_41;
            case 11:
              if (cultureInfo1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 7 : 0;
                continue;
              }
              cultureInfo3 = (CultureInfo) null;
              break;
            case 12:
              flag = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 35 : 11;
              continue;
            case 13:
            case 20:
            case 34:
            case 35:
              if (manifest.TagLanguageList == null)
              {
                num2 = 10;
                continue;
              }
              goto case 37;
            case 15:
              currentDataBaseStr = (string) TagService.zWV09EEAVI3NPbSyu1qy(TagService.gAuA9dEAI9mx1hHAW6DZ((object) str));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
              continue;
            case 17:
              if (!editionType.HasValue)
              {
                num2 = 16;
                continue;
              }
              goto case 2;
            case 18:
              currentEditionStr = editionType.ToString().ToLower();
              num2 = 33;
              continue;
            case 19:
              flag = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
              continue;
            case 21:
              str = (string) TagService.GDxqhrEAZZakScFwUvO8(--1360331293 ^ 1360106489);
              num2 = 32;
              continue;
            case 22:
              messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886871861), TagService.dbAN93EAi7PE87rGNThl((object) manifest), TagService.MT8sgAEATSgdbHExsZpT((object) manifest) ?? (object) string.Empty)));
              num2 = 19;
              continue;
            case 23:
              // ISSUE: reference to a compiler-generated method
              if (!manifest.TagLanguageList.All<string>((Func<string, bool>) (t => TagService.\u003C\u003Ec__DisplayClass10_2.t0UIIf8aNKULmgjx33gP((object) t, (object) currentSystemLanguageStr))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 36 : 14;
                continue;
              }
              goto case 22;
            case 24:
              str = string.Empty;
              num2 = 40;
              continue;
            case 25:
              currentBaseLangyageStr = cultureInfo2 == null ? string.Empty : ((string) TagService.gAuA9dEAI9mx1hHAW6DZ((object) cultureInfo2.ToString())).ToLower();
              num2 = 31;
              continue;
            case 26:
              if (manifest != null)
              {
                flag = true;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 44 : 26;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 9 : 8;
              continue;
            case 27:
              messages = new List<TestImportMessages>();
              num2 = 26;
              continue;
            case 28:
              if (manifest.TagEditionList.Any<string>())
                goto case 45;
              else
                goto label_36;
            case 29:
              currentSystemLanguageStr = cultureInfo1 != null ? (string) TagService.zWV09EEAVI3NPbSyu1qy(TagService.gAuA9dEAI9mx1hHAW6DZ((object) cultureInfo1.ToString())) : string.Empty;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 25 : 6;
              continue;
            case 30:
              goto label_47;
            case 31:
              // ISSUE: reference to a compiler-generated method
              if (manifest.TagLanguageList.All<string>((Func<string, bool>) (t => TagService.\u003C\u003Ec__DisplayClass10_2.t0UIIf8aNKULmgjx33gP((object) t, (object) currentBaseLangyageStr))))
              {
                num2 = 23;
                continue;
              }
              goto label_46;
            case 32:
              if (string.IsNullOrWhiteSpace(str))
              {
                num2 = 5;
                continue;
              }
              goto case 6;
            case 33:
              if (!manifest.TagEditionList.All<string>((Func<string, bool>) (t => t != currentEditionStr)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 5 : 13;
                continue;
              }
              goto case 46;
            case 37:
              if (manifest.TagLanguageList.Any<string>())
              {
                num2 = 30;
                continue;
              }
              goto label_46;
            case 38:
              flag = false;
              num2 = 41;
              continue;
            case 39:
              flag = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 47 : 26;
              continue;
            case 40:
              object obj2 = TagService.qOJHWwEA8Sfj8qfbvhlG((object) Locator.GetServiceNotNull<IServerInfoManager>());
              if (TagService.krVrvFEAuH2uceDO3G15(obj2, TagService.GDxqhrEAZZakScFwUvO8(1199946765 ^ 1199951521)))
                str = (string) TagService.GDxqhrEAZZakScFwUvO8(1925118608 << 2 ^ -889226362);
              if (TagService.krVrvFEAuH2uceDO3G15(obj2, TagService.GDxqhrEAZZakScFwUvO8(~-397266137 ^ 396975396)))
                str = (string) TagService.GDxqhrEAZZakScFwUvO8(1574260816 ^ 1574027652);
              if (TagService.krVrvFEAuH2uceDO3G15(obj2, TagService.GDxqhrEAZZakScFwUvO8(1319452732 ^ 1319449272)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 21 : 5;
                continue;
              }
              goto case 32;
            case 41:
            case 47:
              if (manifest.TagEditionList != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 3 : 28;
                continue;
              }
              goto case 13;
            case 42:
              flag = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 18 : 34;
              continue;
            case 43:
              List<TestImportMessages> testImportMessagesList2 = messages;
              string t2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16462597);
              object[] objArray2 = new object[2]
              {
                (object) manifest.Id,
                null
              };
              string tagDataBase = manifest.TagDataBase;
              objArray2[1] = (object) (tagDataBase == null ? string.Empty : tagDataBase);
              TestImportMessages testImportMessages2 = new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(t2, objArray2));
              testImportMessagesList2.Add(testImportMessages2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 39 : 12;
              continue;
            case 44:
              if (manifest.TagDataBaseList != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 3 : 1;
                continue;
              }
              goto case 41;
            case 45:
              editionType = VersionInfo.GetEditionType();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 17 : 16;
              continue;
            case 46:
              messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) TagService.GDxqhrEAZZakScFwUvO8(572119659 - -337058038 ^ 909402571), TagService.dbAN93EAi7PE87rGNThl((object) manifest), TagService.HjSl9SEARf6n6KPBN0s2((object) manifest) ?? (object) string.Empty)));
              num2 = 42;
              continue;
            default:
              goto label_46;
          }
          cultureInfo2 = cultureInfo3;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 25 : 29;
        }
label_36:
        num1 = 20;
        continue;
label_47:
        num1 = 4;
      }
label_41:
      return true;
label_46:
      return flag;
    }

    public TagService()
    {
      TagService.srd8KSEAkN3da1lVP0RW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool r0W9J0EAClxV2bo8Js5h() => TagService.Y76wxSEAQZhuvFqf2ErR == null;

    internal static TagService eDt3gvEAv9JRre625AYW() => TagService.Y76wxSEAQZhuvFqf2ErR;

    internal static object qOJHWwEA8Sfj8qfbvhlG([In] object obj0) => (object) ((IServerInfoManager) obj0).GetMainProviderType();

    internal static object GDxqhrEAZZakScFwUvO8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool krVrvFEAuH2uceDO3G15([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object gAuA9dEAI9mx1hHAW6DZ([In] object obj0) => (object) ((string) obj0).Trim();

    internal static object zWV09EEAVI3NPbSyu1qy([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object jsh3UEEASrgLgHnvhDDl([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).TagDataBase;

    internal static object dbAN93EAi7PE87rGNThl([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Id;

    internal static object HjSl9SEARf6n6KPBN0s2([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).TagEdition;

    internal static object saxTKxEAqPIDsIA9BYY3() => (object) EleWise.ELMA.SR.GetDefaultCulture();

    internal static object z1BM49EAKTWd0ROxHfdx() => (object) EleWise.ELMA.SR.LanguagesMap;

    internal static object EGpFgHEAXfWhalugbC5g([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static object MT8sgAEATSgdbHExsZpT([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).TagLanguage;

    internal static void srd8KSEAkN3da1lVP0RW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
