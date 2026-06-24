// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.LogOutResponse
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.API.Models
{
  /// <summary>Результат выхода из системы.</summary>
  [Description(typeof (__LogOutResponse_SR), "Description")]
  [DataContract(Name = "Auth")]
  [Serializable]
  public class LogOutResponse
  {
    internal static LogOutResponse i6ieDmfNvhFst1jfhDKb;

    /// <summary>Успешность выхода из системы.</summary>
    [Description(typeof (__LogOutResponse_SR), "Success")]
    [DataMember]
    public bool Success
    {
      get => this.\u003CSuccess\u003Ek__BackingField;
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
              this.\u003CSuccess\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
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

    public LogOutResponse()
    {
      LogOutResponse.GESHJqfNuwxduGZcX391();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool V5OSjvfN8eX6IsCvUIm8() => LogOutResponse.i6ieDmfNvhFst1jfhDKb == null;

    internal static LogOutResponse uDh2CHfNZqwVqjHIF9Nd() => LogOutResponse.i6ieDmfNvhFst1jfhDKb;

    internal static void GESHJqfNuwxduGZcX391() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
