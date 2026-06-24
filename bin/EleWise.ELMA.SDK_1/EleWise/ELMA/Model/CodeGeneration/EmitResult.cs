// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.EmitResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Результат компиляции</summary>
  [Serializable]
  public class EmitResult
  {
    internal static EmitResult u3mPMChe252KDogZk1i5;

    private EmitResult()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static EmitResult SuccessResult(IEnumerable<Diagnostic> diagnostics = null) => new EmitResult()
    {
      Success = true,
      Diagnostics = diagnostics ?? Enumerable.Empty<Diagnostic>()
    };

    internal static EmitResult ErrorResult(IEnumerable<Diagnostic> diagnostics) => new EmitResult()
    {
      Success = false,
      Diagnostics = diagnostics
    };

    /// <summary>true, если сборка удачная, иначе false</summary>
    public bool Success
    {
      get => this.\u003CSuccess\u003Ek__BackingField;
      private set
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
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

    /// <summary>Сообщения ошибок и предупреждений компиляции</summary>
    public IEnumerable<Diagnostic> Diagnostics { get; private set; }

    internal static bool alNPO7heexMwdeRMVbnu() => EmitResult.u3mPMChe252KDogZk1i5 == null;

    internal static EmitResult JfuHpjhePWWbYT61iOHe() => EmitResult.u3mPMChe252KDogZk1i5;
  }
}
