// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.ApiVersionResponse
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.API.Models
{
  [DataContract(Name = "ApiVersion")]
  [Serializable]
  public class ApiVersionResponse
  {
    internal static ApiVersionResponse I9UUbPf1FnPHbmauOvUN;

    [DataMember]
    public string Version
    {
      get => this.\u003CVersion\u003Ek__BackingField;
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
              this.\u003CVersion\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
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
    public ApiServiceVersionResponse[] Services
    {
      get => this.\u003CServices\u003Ek__BackingField;
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
              this.\u003CServices\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
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

    public ApiVersionResponse()
    {
      ApiVersionResponse.x3vie0f1oSq5S1aOtaKJ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool aDQQn5f1BmiSJmuLFc9i() => ApiVersionResponse.I9UUbPf1FnPHbmauOvUN == null;

    internal static ApiVersionResponse Tj8p9wf1WiRLIlrR7jZy() => ApiVersionResponse.I9UUbPf1FnPHbmauOvUN;

    internal static void x3vie0f1oSq5S1aOtaKJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
