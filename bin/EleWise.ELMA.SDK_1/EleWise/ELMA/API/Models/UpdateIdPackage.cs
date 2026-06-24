// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.UpdateIdPackage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.API.Models
{
  [DataContract(Name = "UpdateIdPackage")]
  [Serializable]
  public class UpdateIdPackage : PackageBase
  {
    internal static UpdateIdPackage zEDe1Sf3Cohn3gD9NiL4;

    /// <summary>
    /// Этот конструктор предназначен только для десериализации.
    /// </summary>
    [Obsolete("Этот конструктор предназначен только для десериализации.", true)]
    public UpdateIdPackage()
    {
      UpdateIdPackage.jZw4a1f3ZocA4NxgeL0m();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public UpdateIdPackage(Guid serviceUid, Guid typeUid)
    {
      UpdateIdPackage.jZw4a1f3ZocA4NxgeL0m();
      // ISSUE: explicit constructor call
      base.\u002Ector(serviceUid, typeUid);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public UpdateIdPackage(Guid serviceUid, Guid typeUid, long updated)
    {
      UpdateIdPackage.jZw4a1f3ZocA4NxgeL0m();
      // ISSUE: explicit constructor call
      this.\u002Ector(serviceUid, typeUid);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Updated = updated;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    [DataMember]
    public long Updated
    {
      get => this.\u003CUpdated\u003Ek__BackingField;
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
              this.\u003CUpdated\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
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

    internal static void jZw4a1f3ZocA4NxgeL0m() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool zWyS4Tf3vxaABd05hbyn() => UpdateIdPackage.zEDe1Sf3Cohn3gD9NiL4 == null;

    internal static UpdateIdPackage wafNK5f386qIxZydhD8W() => UpdateIdPackage.zEDe1Sf3Cohn3gD9NiL4;
  }
}
