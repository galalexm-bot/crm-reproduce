// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.BPMAppManifestItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.BPMApps
{
  /// <summary>Элемент из манифеста BPM App</summary>
  public abstract class BPMAppManifestItem
  {
    internal static BPMAppManifestItem S3YOmNfkSTBbmaMOBXLe;

    /// <summary>Уникальный идентификатор элемента</summary>
    [XmlElement("Uid")]
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
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

    protected BPMAppManifestItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool MgrRJdfkiRxwvuTOEfKS() => BPMAppManifestItem.S3YOmNfkSTBbmaMOBXLe == null;

    internal static BPMAppManifestItem KqTrvrfkR9vOxaKJSf9N() => BPMAppManifestItem.S3YOmNfkSTBbmaMOBXLe;
  }
}
