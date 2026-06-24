// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Rebranding.RebrendingLicenseStringsManifest
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Rebranding
{
  /// <summary>Манифест строк подвергаемых ребрендингу</summary>
  [XmlRoot("strings")]
  public class RebrendingLicenseStringsManifest
  {
    private static RebrendingLicenseStringsManifest JQXLcyPqGZsuH48rdoV;

    /// <summary>Локаль строк для ребренда</summary>
    [XmlElement("Locale")]
    [DataMember]
    public string Locale
    {
      get => this.\u003CLocale\u003Ek__BackingField;
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
              this.\u003CLocale\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
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

    /// <summary>Файл со строками указанной локали</summary>
    [XmlElement("FileName")]
    [DataMember]
    public string FileName
    {
      get => this.\u003CFileName\u003Ek__BackingField;
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
              this.\u003CFileName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
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

    public RebrendingLicenseStringsManifest()
    {
      RebrendingLicenseStringsManifest.ESpEgpPTqToYvSkMUQX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool lwgcOHPKJIRFoBASlhc() => RebrendingLicenseStringsManifest.JQXLcyPqGZsuH48rdoV == null;

    internal static RebrendingLicenseStringsManifest zGcZiYPXKZucVVMtM3T() => RebrendingLicenseStringsManifest.JQXLcyPqGZsuH48rdoV;

    internal static void ESpEgpPTqToYvSkMUQX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
