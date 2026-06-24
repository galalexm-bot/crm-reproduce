// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Signatures.ImplementationSignature
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Signatures
{
  /// <summary>Сигнатура реализации расширения</summary>
  [Serializable]
  public sealed class ImplementationSignature
  {
    internal static ImplementationSignature CoTT9IWzlvNaeySRdvJI;

    /// <summary>Идентификатор зоны расширений</summary>
    public string PointId
    {
      get => this.\u003CPointId\u003Ek__BackingField;
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
              this.\u003CPointId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
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

    /// <summary>Тип контракта</summary>
    public Guid TypeUid
    {
      get => this.\u003CTypeUid\u003Ek__BackingField;
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
              this.\u003CTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
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

    public ImplementationSignature()
    {
      ImplementationSignature.yNLSEBWz5l2mYUw8gnMP();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool dE20FfWzrRH0ASWNVG6E() => ImplementationSignature.CoTT9IWzlvNaeySRdvJI == null;

    internal static ImplementationSignature xxmawwWzgg1MRTn7N8JG() => ImplementationSignature.CoTT9IWzlvNaeySRdvJI;

    internal static void yNLSEBWz5l2mYUw8gnMP() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
