// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Packaging.PackageDescription
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Packaging
{
  /// <summary>Описание пакета</summary>
  [Serializable]
  public class PackageDescription
  {
    private static PackageDescription g8OfyEBO1QiHnfcco0iD;

    public PackageDescription()
    {
      PackageDescription.ocdSv5BOpnLaiOKR5UZl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Идентификатор</summary>
    public string Id
    {
      get => this.\u003CId\u003Ek__BackingField;
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
              this.\u003CId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
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

    /// <summary>Название</summary>
    public string Title
    {
      get => this.\u003CTitle\u003Ek__BackingField;
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
              this.\u003CTitle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
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

    /// <summary>Краткое описание</summary>
    public string Summary
    {
      get => this.\u003CSummary\u003Ek__BackingField;
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
              this.\u003CSummary\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
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

    /// <summary>Полное описание</summary>
    public string Description
    {
      get => this.\u003CDescription\u003Ek__BackingField;
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
              this.\u003CDescription\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
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

    /// <summary>Тип пакета</summary>
    public ElmaPackageType Type
    {
      get => this.\u003CType\u003Ek__BackingField;
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
              this.\u003CType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
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

    /// <summary>Авторские права</summary>
    public string Copyright
    {
      get => this.\u003CCopyright\u003Ek__BackingField;
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
              this.\u003CCopyright\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
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

    /// <summary>Авторы</summary>
    public IEnumerable<string> Authors { get; set; }

    /// <summary>Адрес иконки пакета</summary>
    public Uri IconUrl
    {
      get => this.\u003CIconUrl\u003Ek__BackingField;
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
              this.\u003CIconUrl\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
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

    /// <summary>Адрес страницы с лицензией</summary>
    public Uri LicenseUrl
    {
      get => this.\u003CLicenseUrl\u003Ek__BackingField;
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
              this.\u003CLicenseUrl\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
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

    /// <summary>Владельцы</summary>
    public IEnumerable<string> Owners { get; set; }

    /// <summary>Идентифиаторы модулей-владельцев пакета</summary>
    public List<string> OwnerIds { get; set; }

    /// <summary>Адрес страницы с информацией о пакете</summary>
    public Uri ProjectUrl
    {
      get => this.\u003CProjectUrl\u003Ek__BackingField;
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
              this.\u003CProjectUrl\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
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

    /// <summary>Тэги</summary>
    public string Tags
    {
      get => this.\u003CTags\u003Ek__BackingField;
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
              this.\u003CTags\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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

    /// <summary>Приоритет</summary>
    public int Priority
    {
      get => this.\u003CPriority\u003Ek__BackingField;
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
              this.\u003CPriority\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
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

    /// <summary>Метаданные установленного пакета</summary>
    public ElmaPackageMetadata InstalledMetadata
    {
      get => this.\u003CInstalledMetadata\u003Ek__BackingField;
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
              this.\u003CInstalledMetadata\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
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

    /// <summary>Метаданные последнего пакета</summary>
    public ElmaPackageMetadata LastMetadata
    {
      get => this.\u003CLastMetadata\u003Ek__BackingField;
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
              this.\u003CLastMetadata\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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

    public override string ToString() => this.Id;

    /// <summary>Номер последней версии</summary>
    public SemanticVersion LastVersion
    {
      get => this.\u003CLastVersion\u003Ek__BackingField;
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
              this.\u003CLastVersion\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
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

    /// <summary>Информация об изменениях в последней версии</summary>
    public string LastReleaseNotes
    {
      get => this.\u003CLastReleaseNotes\u003Ek__BackingField;
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
              this.\u003CLastReleaseNotes\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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

    /// <summary>Строковое представление номера последней версии</summary>
    public string GetLastVersion()
    {
      int num = 1;
      SemanticVersion lastVersion;
      while (true)
      {
        switch (num)
        {
          case 1:
            lastVersion = this.LastVersion;
            if ((object) lastVersion == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) null;
label_5:
      return lastVersion.ToString();
    }

    /// <summary>Номер установленной версии</summary>
    public SemanticVersion InstalledVersion
    {
      get => this.\u003CInstalledVersion\u003Ek__BackingField;
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
              this.\u003CInstalledVersion\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
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

    /// <summary>Установлен ли пакет</summary>
    public bool IsInstalled
    {
      get => this.\u003CIsInstalled\u003Ek__BackingField;
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
              this.\u003CIsInstalled\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
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

    /// <summary>Установлена ли последняя версия</summary>
    public bool IsLatestVersionInstalled
    {
      get => this.\u003CIsLatestVersionInstalled\u003Ek__BackingField;
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
              this.\u003CIsLatestVersionInstalled\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
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

    /// <summary>Интервал версий (для зависимостей)</summary>
    public string DependencyVersion
    {
      get => this.\u003CDependencyVersion\u003Ek__BackingField;
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
              this.\u003CDependencyVersion\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
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

    public void WriteToXml(XmlWriter writer)
    {
      int num1 = 6;
      IEnumerator<string> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            PackageDescription.DDkrUABOtEV3IxCHmYde((object) writer, PackageDescription.NXHKVFBOaysDnd7PO2ub(1304605005 ^ 1304658053), (object) this.Summary);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 8 : 8;
            continue;
          case 2:
            try
            {
label_15:
              if (PackageDescription.PAIuRMBO4rcbm2dEis8N((object) enumerator))
                goto label_13;
              else
                goto label_16;
label_11:
              string current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    PackageDescription.DDkrUABOtEV3IxCHmYde((object) writer, PackageDescription.NXHKVFBOaysDnd7PO2ub(381945751 ^ 1158627804 ^ 1405776975), (object) current);
                    num2 = 2;
                    continue;
                  case 2:
                    goto label_15;
                  case 3:
                    goto label_3;
                  default:
                    goto label_13;
                }
              }
label_13:
              current = enumerator.Current;
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
              {
                num2 = 1;
                goto label_11;
              }
              else
                goto label_11;
label_16:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 3;
              goto label_11;
            }
            finally
            {
              int num3;
              if (enumerator == null)
                num3 = 2;
              else
                goto label_20;
label_19:
              switch (num3)
              {
                case 1:
                  break;
                default:
              }
label_20:
              PackageDescription.yojX1FBO6qjBVpjJwBst((object) enumerator);
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
              {
                num3 = 0;
                goto label_19;
              }
              else
                goto label_19;
            }
          case 3:
label_3:
            PackageDescription.Uu5DTxBOHBysf2MKapy5((object) writer);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 2 : 9;
            continue;
          case 4:
            goto label_28;
          case 5:
            PackageDescription.DDkrUABOtEV3IxCHmYde((object) writer, PackageDescription.NXHKVFBOaysDnd7PO2ub(-1886646897 ^ -1886614319), (object) this.Id);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 10 : 6;
            continue;
          case 6:
            PackageDescription.WLyiOsBODupolIx88GsW((object) writer, (object) string.Format((string) PackageDescription.NXHKVFBOaysDnd7PO2ub(1514961705 ^ 1515014815)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 5 : 2;
            continue;
          case 7:
            enumerator = this.Owners.GetEnumerator();
            num1 = 2;
            continue;
          case 8:
            writer.WriteElementString((string) PackageDescription.NXHKVFBOaysDnd7PO2ub(1051802738 - -1831968059 ^ -1411127177), this.Description);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 11 : 12;
            continue;
          case 9:
            PackageDescription.Uu5DTxBOHBysf2MKapy5((object) writer);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 4;
            continue;
          case 10:
            writer.WriteElementString((string) PackageDescription.NXHKVFBOaysDnd7PO2ub(-1858887263 ^ -1858920235), !PackageDescription.yOybUTBOw28PrlHllZmk((object) this.LastVersion, (object) null) ? "" : this.LastVersion.ToString());
            num1 = 11;
            continue;
          case 11:
            PackageDescription.DDkrUABOtEV3IxCHmYde((object) writer, PackageDescription.NXHKVFBOaysDnd7PO2ub(1113862659 ^ 1113852645), (object) ((int) this.Type).ToString());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          case 12:
            writer.WriteStartElement((string) PackageDescription.NXHKVFBOaysDnd7PO2ub(864270449 << 6 ^ -521196108));
            num1 = 13;
            continue;
          case 13:
            if (this.Owners != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 7;
              continue;
            }
            goto case 3;
          default:
            PackageDescription.DDkrUABOtEV3IxCHmYde((object) writer, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234332554), (object) this.Title);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
            continue;
        }
      }
label_28:;
    }

    internal PackageDescription(IPackage installedPackage, IPackage lastPackage)
    {
      PackageDescription.ocdSv5BOpnLaiOKR5UZl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 37;
      while (true)
      {
        ElmaPackageMetadata elmaPackageMetadata1;
        IPackage package1;
        ElmaPackageMetadata elmaPackageMetadata2;
        ElmaPackageMetadata elmaPackageMetadata3;
        ElmaPackageMetadata elmaPackageMetadata4;
        ElmaPackageMetadata elmaPackageMetadata5;
        IPackage package2;
        ElmaPackageMetadata elmaPackageMetadata6;
        switch (num)
        {
          case 1:
            this.Priority = PackageDescription.MMIucmBOlNMjfiDh1BZ0((object) elmaPackageMetadata1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 2 : 2;
            continue;
          case 2:
            this.OwnerIds = elmaPackageMetadata1.OwnerIds;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 3:
          case 27:
            this.LastVersion = lastPackage.Version;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 7 : 26;
            continue;
          case 4:
            if (installedPackage != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 5 : 20;
              continue;
            }
            goto case 21;
          case 5:
            if (lastPackage == null)
            {
              num = 12;
              continue;
            }
            elmaPackageMetadata5 = new ElmaPackageMetadata((string) PackageDescription.tLkirjBOAHkqc2DqbQs7((object) lastPackage));
            goto label_44;
          case 6:
            goto label_36;
          case 7:
            this.InstalledMetadata = elmaPackageMetadata2;
            num = 32;
            continue;
          case 8:
            this.Tags = (string) PackageDescription.jETKjtBOdlGhpvIgpD2C((object) elmaPackageMetadata1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
            continue;
          case 9:
            this.Owners = package1.Owners;
            num = 17;
            continue;
          case 10:
            this.LastReleaseNotes = lastPackage.ReleaseNotes;
            num = 33;
            continue;
          case 11:
            lastPackage = installedPackage;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 3;
            continue;
          case 12:
            elmaPackageMetadata5 = (ElmaPackageMetadata) null;
            goto label_44;
          case 13:
            this.Description = (string) PackageDescription.pG2FsBBOmOYPTCohlX0p((object) package1);
            num = 24;
            continue;
          case 14:
            package2 = lastPackage;
            break;
          case 15:
            this.LicenseUrl = package1.LicenseUrl;
            num = 9;
            continue;
          case 16:
            elmaPackageMetadata6 = elmaPackageMetadata3;
            goto label_49;
          case 17:
            this.ProjectUrl = (Uri) PackageDescription.Xy1Js4BO9j4Ai5Uj7TQd((object) package1);
            num = 8;
            continue;
          case 18:
            if (installedPackage == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 8 : 28;
              continue;
            }
            goto case 30;
          case 19:
            goto label_52;
          case 20:
            elmaPackageMetadata4 = new ElmaPackageMetadata((string) PackageDescription.tLkirjBOAHkqc2DqbQs7((object) installedPackage));
            goto label_42;
          case 21:
            elmaPackageMetadata4 = (ElmaPackageMetadata) null;
            goto label_42;
          case 22:
            this.IconUrl = (Uri) PackageDescription.V3JenSBOJnXKuYtcGTu2((object) package1);
            num = 15;
            continue;
          case 23:
            IPackage package3 = installedPackage;
            if (package3 == null)
            {
              num = 14;
              continue;
            }
            package2 = package3;
            break;
          case 24:
            this.Type = PackageDescription.te6T3rBOyosLvLJHNaxO((object) elmaPackageMetadata1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 29 : 36;
            continue;
          case 25:
            this.Summary = (string) PackageDescription.hdHHe0BO0OMPQ94FPq4C((object) package1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 7 : 13;
            continue;
          case 26:
            this.LastMetadata = elmaPackageMetadata3 ?? elmaPackageMetadata2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 4 : 10;
            continue;
          case 28:
            goto label_46;
          case 29:
            if (lastPackage != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 21 : 23;
              continue;
            }
            goto label_36;
          case 30:
            this.InstalledVersion = (SemanticVersion) PackageDescription.PTK5oKBOrPXfClAeireG((object) installedPackage);
            num = 7;
            continue;
          case 31:
            this.Title = (string) PackageDescription.POcNehBOx7WnoX6By9Z2((object) package1);
            num = 25;
            continue;
          case 32:
            this.IsLatestVersionInstalled = PackageDescription.IGg3J2BOggICJVx7j6ZW(PackageDescription.PTK5oKBOrPXfClAeireG((object) lastPackage), (object) null) || PackageDescription.IGg3J2BOggICJVx7j6ZW(PackageDescription.PTK5oKBOrPXfClAeireG((object) installedPackage), (object) null) || PackageDescription.CKC15yBO54yxpqsGLCaa(PackageDescription.PTK5oKBOrPXfClAeireG((object) lastPackage), (object) installedPackage.Version);
            num = 19;
            continue;
          case 33:
            this.IsInstalled = installedPackage != null;
            num = 18;
            continue;
          case 34:
            this.Authors = package1.Authors;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 2 : 22;
            continue;
          case 35:
            ElmaPackageMetadata elmaPackageMetadata7 = elmaPackageMetadata2;
            if (elmaPackageMetadata7 == null)
            {
              num = 16;
              continue;
            }
            elmaPackageMetadata6 = elmaPackageMetadata7;
            goto label_49;
          case 36:
            this.Copyright = (string) PackageDescription.Io8EE7BOMKvy520VNaAs((object) package1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 34 : 7;
            continue;
          case 37:
            if (installedPackage == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 5 : 29;
              continue;
            }
            goto case 23;
          case 38:
            this.Id = (string) PackageDescription.rLrrGFBO7j0ioisU0VCv((object) package1);
            num = 31;
            continue;
          default:
            if (lastPackage != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 17 : 27;
              continue;
            }
            goto case 11;
        }
        package1 = package2;
        num = 4;
        continue;
label_42:
        elmaPackageMetadata2 = elmaPackageMetadata4;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 5 : 1;
        continue;
label_44:
        elmaPackageMetadata3 = elmaPackageMetadata5;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 14 : 35;
        continue;
label_49:
        elmaPackageMetadata1 = elmaPackageMetadata6;
        num = 38;
      }
label_52:
      return;
label_46:
      return;
label_36:
      throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413615117));
    }

    internal static void ocdSv5BOpnLaiOKR5UZl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool HoKoXOBONcfN3PdBhISF() => PackageDescription.g8OfyEBO1QiHnfcco0iD == null;

    internal static PackageDescription mi2uLDBO36Lk69EkYiI8() => PackageDescription.g8OfyEBO1QiHnfcco0iD;

    internal static object NXHKVFBOaysDnd7PO2ub(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void WLyiOsBODupolIx88GsW([In] object obj0, [In] object obj1) => ((XmlWriter) obj0).WriteStartElement((string) obj1);

    internal static void DDkrUABOtEV3IxCHmYde([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlWriter) obj0).WriteElementString((string) obj1, (string) obj2);

    internal static bool yOybUTBOw28PrlHllZmk([In] object obj0, [In] object obj1) => (SemanticVersion) obj0 != (SemanticVersion) obj1;

    internal static bool PAIuRMBO4rcbm2dEis8N([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void yojX1FBO6qjBVpjJwBst([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void Uu5DTxBOHBysf2MKapy5([In] object obj0) => ((XmlWriter) obj0).WriteEndElement();

    internal static object tLkirjBOAHkqc2DqbQs7([In] object obj0) => (object) ((IPackageMetadata) obj0).Tags;

    internal static object rLrrGFBO7j0ioisU0VCv([In] object obj0) => (object) ((IPackageName) obj0).Id;

    internal static object POcNehBOx7WnoX6By9Z2([In] object obj0) => (object) ((IPackageMetadata) obj0).Title;

    internal static object hdHHe0BO0OMPQ94FPq4C([In] object obj0) => (object) ((IPackageMetadata) obj0).Summary;

    internal static object pG2FsBBOmOYPTCohlX0p([In] object obj0) => (object) ((IPackageMetadata) obj0).Description;

    internal static ElmaPackageType te6T3rBOyosLvLJHNaxO([In] object obj0) => ((ElmaPackageMetadata) obj0).Type;

    internal static object Io8EE7BOMKvy520VNaAs([In] object obj0) => (object) ((IPackageMetadata) obj0).Copyright;

    internal static object V3JenSBOJnXKuYtcGTu2([In] object obj0) => (object) ((IPackageMetadata) obj0).IconUrl;

    internal static object Xy1Js4BO9j4Ai5Uj7TQd([In] object obj0) => (object) ((IPackageMetadata) obj0).ProjectUrl;

    internal static object jETKjtBOdlGhpvIgpD2C([In] object obj0) => (object) ((ElmaPackageMetadata) obj0).Tags;

    internal static int MMIucmBOlNMjfiDh1BZ0([In] object obj0) => ((ElmaPackageMetadata) obj0).Priority;

    internal static object PTK5oKBOrPXfClAeireG([In] object obj0) => (object) ((IPackageName) obj0).Version;

    internal static bool IGg3J2BOggICJVx7j6ZW([In] object obj0, [In] object obj1) => (SemanticVersion) obj0 == (SemanticVersion) obj1;

    internal static bool CKC15yBO54yxpqsGLCaa([In] object obj0, [In] object obj1) => ((SemanticVersion) obj0).Equals((SemanticVersion) obj1);
  }
}
