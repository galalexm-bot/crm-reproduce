// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.PackageBAItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.ComponentModel;
using System.Xml.Serialization;

namespace EleWise.ELMA.BPMApps
{
  public class PackageBAItem : BPMAppManifestItem
  {
    private static PackageBAItem VCFQubfkgsUqiPCr6cEp;

    public PackageBAItem()
    {
      PackageBAItem.PvG8LXfkYGCIwiLa4rkl();
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
            this.PackageTitle = "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          case 2:
            this.PackageId = "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Идентификатор пакета</summary>
    [DefaultValue("")]
    [XmlElement("PackageId")]
    public string PackageId
    {
      get => this.\u003CPackageId\u003Ek__BackingField;
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
              this.\u003CPackageId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

    /// <summary>Отображаемое имя пакета</summary>
    [DefaultValue("")]
    [XmlElement("PackageTitle")]
    public string PackageTitle
    {
      get => this.\u003CPackageTitle\u003Ek__BackingField;
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
              this.\u003CPackageTitle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
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

    internal static void PvG8LXfkYGCIwiLa4rkl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool BjyboAfk5y66C3gBDRKh() => PackageBAItem.VCFQubfkgsUqiPCr6cEp == null;

    internal static PackageBAItem JhqNZyfkjiqQPuOnrynp() => PackageBAItem.VCFQubfkgsUqiPCr6cEp;
  }
}
