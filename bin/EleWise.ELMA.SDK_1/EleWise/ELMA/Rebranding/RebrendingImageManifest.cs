// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Rebranding.RebrendingImageManifest
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Rebranding
{
  [XmlRoot("images")]
  public class RebrendingImageManifest
  {
    private static RebrendingImageManifest Pb1lfpPSty8gqeEwj9H;

    /// <summary>
    /// Название изображения в формате ПространствоИмен.НазваниеИзображения
    /// </summary>
    [DataMember]
    [XmlElement("FullName")]
    public string FullName
    {
      get => this.\u003CFullName\u003Ek__BackingField;
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
              this.\u003CFullName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

    /// <summary>Название файла с изображением</summary>
    [DataMember]
    [XmlElement("FileName")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
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

    public RebrendingImageManifest()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool un2TEKPi9Bn8yM0vNU2() => RebrendingImageManifest.Pb1lfpPSty8gqeEwj9H == null;

    internal static RebrendingImageManifest quEB3HPRYfe0heNo9ns() => RebrendingImageManifest.Pb1lfpPSty8gqeEwj9H;
  }
}
