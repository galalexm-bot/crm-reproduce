// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ExecuteFunctionResponse`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata
{
  /// <inheritdoc />
  public class ExecuteFunctionResponse<T> : IExecuteFunctionResponse
  {
    private static object gGKv2ibpu6fKORFTqfb4;

    /// <inheritdoc />
    object IExecuteFunctionResponse.Result
    {
      get => (object) this.Result;
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
              this.Result = (T) value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
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

    /// <summary>Результат</summary>
    public T Result { get; set; }

    public ExecuteFunctionResponse()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool llSY88bpIGORwCvs8cqy() => ExecuteFunctionResponse<T>.gGKv2ibpu6fKORFTqfb4 == null;

    internal static object YRk5bLbpVcneq0EAlRUR() => ExecuteFunctionResponse<T>.gGKv2ibpu6fKORFTqfb4;
  }
}
