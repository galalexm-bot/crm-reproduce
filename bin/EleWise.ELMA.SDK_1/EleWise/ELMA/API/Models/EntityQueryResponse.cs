// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.EntityQueryResponse
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Services.Public;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace EleWise.ELMA.API.Models
{
  [DataContract]
  [Description("Ответ на запрос объектов")]
  [Serializable]
  public class EntityQueryResponse
  {
    internal static EntityQueryResponse vvDJI6f1mP0A3lW7KjCD;

    [DataMember]
    [Description("Количество объектов в результате")]
    public long Count
    {
      get => this.\u003CCount\u003Ek__BackingField;
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
              this.\u003CCount\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
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
    [Description("Объекты")]
    public IEnumerable<WebData> Data { get; set; }

    [Description("Ошибка запроса")]
    [DataMember]
    public PublicServiceException Exception
    {
      get => this.\u003CException\u003Ek__BackingField;
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
              this.\u003CException\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
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

    public EntityQueryResponse()
    {
      EntityQueryResponse.dwFTKIf1JRvxN9bDauZw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool FWWJCjf1yyaNyeZq053W() => EntityQueryResponse.vvDJI6f1mP0A3lW7KjCD == null;

    internal static EntityQueryResponse tbW44Sf1MORCR5Y2nK3m() => EntityQueryResponse.vvDJI6f1mP0A3lW7KjCD;

    internal static void dwFTKIf1JRvxN9bDauZw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
