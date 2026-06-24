// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.ApiServiceVersionResponse
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.API.Models
{
  [DataContract(Name = "ApiService")]
  [Serializable]
  public class ApiServiceVersionResponse
  {
    internal static ApiServiceVersionResponse yYniqAf1bDk4X8DdJBq9;

    [DataMember]
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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
    public ApiMethodResponse[] Methods
    {
      get => this.\u003CMethods\u003Ek__BackingField;
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
              this.\u003CMethods\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
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

    public ApiServiceVersionResponse()
    {
      ApiServiceVersionResponse.cDWwGLf1ElKQr181qQZU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool oHTHYSf1h8MaKOd8nCx0() => ApiServiceVersionResponse.yYniqAf1bDk4X8DdJBq9 == null;

    internal static ApiServiceVersionResponse fjNRGIf1GPmcTyqscl1d() => ApiServiceVersionResponse.yYniqAf1bDk4X8DdJBq9;

    internal static void cDWwGLf1ElKQr181qQZU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
