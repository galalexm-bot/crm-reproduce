// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.ScriptValidator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.Model.Types.Validation
{
  public class ScriptValidator : DataAnnotationsModelValidator<ScriptValidationAttribute>
  {
    public const string ValidationType = "scriptvalidator";
    internal static ScriptValidator eLBcBHorjdoy8HVBVr3Q;

    public ScriptValidator(
      ModelMetadata metadata,
      ControllerContext context,
      ScriptValidationAttribute attribute)
    {
      ScriptValidator.qJPdxEorUFQCnPRK5hYI();
      // ISSUE: explicit constructor call
      base.\u002Ector(metadata, context, attribute);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public override IEnumerable<ModelClientValidationRule> GetClientValidationRules() => (IEnumerable<ModelClientValidationRule>) new ModelClientValidationRule[1]
    {
      new ModelClientValidationRule()
      {
        ErrorMessage = this.ErrorMessage,
        ValidationType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669106537)
      }
    };

    internal static void qJPdxEorUFQCnPRK5hYI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Usv01CorYYIHuKi0G4c8() => ScriptValidator.eLBcBHorjdoy8HVBVr3Q == null;

    internal static ScriptValidator pYGey1orLQJm4oDRIrBo() => ScriptValidator.eLBcBHorjdoy8HVBVr3Q;
  }
}
