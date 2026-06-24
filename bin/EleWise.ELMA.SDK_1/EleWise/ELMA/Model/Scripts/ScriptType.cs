// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ScriptType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>
  /// Базовая реализация для типа сценариев на основе прямого указания типа результата и параметров
  /// </summary>
  public abstract class ScriptType : ScriptTypeBase
  {
    private static ScriptType kUlsmrbiUfstdI2uv7iW;

    /// <summary>Сгенерировать определение метода</summary>
    /// <param name="name">Имя метода</param>
    /// <param name="generationParams">Дополнительные параметры генерации</param>
    /// <returns>Определение метода</returns>
    public override ScriptMethodDeclaration GenerateMethod(
      string name,
      IDictionary<string, object> generationParams = null)
    {
      ScriptMethodDeclaration method = new ScriptMethodDeclaration()
      {
        Name = name,
        ReturnType = this.ReturnType
      };
      if (this.Parameters != null)
        method.Parameters.AddRange(this.Parameters);
      return method;
    }

    /// <summary>
    /// Тип возвращаемого значения (используется при генерации исходного кода сценария)
    /// </summary>
    protected virtual string ReturnType => (string) null;

    /// <summary>
    /// Параметры - тип и имя (используется при генерации исходного кода сценария)
    /// </summary>
    protected virtual IEnumerable<ScriptMethodParameter> Parameters => (IEnumerable<ScriptMethodParameter>) null;

    protected ScriptType()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool iBLiTAbisxya0LWXXY32() => ScriptType.kUlsmrbiUfstdI2uv7iW == null;

    internal static ScriptType Orr1E8bicqsmoC3Rp4es() => ScriptType.kUlsmrbiUfstdI2uv7iW;
  }
}
