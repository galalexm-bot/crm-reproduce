// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.Types.FormScriptType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.UI.Scripts.Types
{
  [Component]
  public abstract class FormScriptType : ScriptTypeBase
  {
    private static FormScriptType Ddhw5xLC23UF2Ls5Edl;

    public override ScriptMethodDeclaration GenerateMethod(
      string name,
      IDictionary<string, object> generationParams = null)
    {
      ScriptMethodDeclaration declaration = new ScriptMethodDeclaration()
      {
        Name = name
      };
      FormMetadata generationParam1 = (FormMetadata) generationParams[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199928019)];
      FormContextMetadata generationParam2 = (FormContextMetadata) generationParams[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852883714)];
      FormTablePartMetadata parameterValue = this.GetParameterValue(generationParams, z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874025293)) as FormTablePartMetadata;
      this.SetMethodParameters(declaration, generationParam1, generationParam2, parameterValue, generationParams);
      return declaration;
    }

    protected abstract void SetMethodParameters(
      ScriptMethodDeclaration declaration,
      FormMetadata formMetadata,
      FormContextMetadata contextMetadata,
      FormTablePartMetadata tablePartMetadata,
      IDictionary<string, object> generationParams);

    protected FormScriptType()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool R5SaBrLveQ9p3UnQtgm() => FormScriptType.Ddhw5xLC23UF2Ls5Edl == null;

    internal static FormScriptType O6bYuHL8aVn4tSgSd8C() => FormScriptType.Ddhw5xLC23UF2Ls5Edl;

    public static class Parameters
    {
      public const string FormMetadata = "FormMetadata";
    }
  }
}
