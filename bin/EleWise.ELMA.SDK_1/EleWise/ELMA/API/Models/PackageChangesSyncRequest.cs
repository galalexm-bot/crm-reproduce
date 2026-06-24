// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.PackageChangesSyncRequest
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.API.Models
{
  [DataContract(Name = "PackageSyncChanges")]
  [Serializable]
  public class PackageChangesSyncRequest
  {
    internal static PackageChangesSyncRequest HFJZ4KfNJn9OZJopapa9;

    [DataMember]
    public DateTime Now
    {
      get => this.\u003CNow\u003Ek__BackingField;
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
              this.\u003CNow\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
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

    [DataMember]
    public PackageChangesSyncData[] Data
    {
      get => this.\u003CData\u003Ek__BackingField;
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
              this.\u003CData\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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

    public PackageChangesSyncRequest()
    {
      PackageChangesSyncRequest.XlWrI5fNlI4NvhSF9Tka();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool DxXaQ1fN9OQ6eeKIg7TA() => PackageChangesSyncRequest.HFJZ4KfNJn9OZJopapa9 == null;

    internal static PackageChangesSyncRequest wJJJBDfNdiBA8F4P6If5() => PackageChangesSyncRequest.HFJZ4KfNJn9OZJopapa9;

    internal static void XlWrI5fNlI4NvhSF9Tka() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
