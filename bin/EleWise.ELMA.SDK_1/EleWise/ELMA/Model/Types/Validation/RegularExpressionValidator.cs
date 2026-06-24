// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.RegularExpressionValidator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace EleWise.ELMA.Model.Types.Validation
{
  public class RegularExpressionValidator : DataAnnotationsModelValidator<RegularExpressionAttribute>
  {
    private readonly string _pattern;
    public const string ValidationType = "regularexp";
    internal static RegularExpressionValidator Id7hlGogsgwE0QVBGJkY;

    public RegularExpressionValidator(
      ModelMetadata metadata,
      ControllerContext context,
      RegularExpressionAttribute attribute)
    {
      RegularExpressionValidator.AL0ghCo5FAekJ2SNFhM8();
      // ISSUE: explicit constructor call
      base.\u002Ector(metadata, context, attribute);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._pattern = (string) RegularExpressionValidator.PWuODfo5BCvit7TZX3fh((object) attribute);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
    {
      ModelClientValidationRule clientValidationRule = new ModelClientValidationRule()
      {
        ErrorMessage = SR.T(this.ErrorMessage),
        ValidationType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146419629)
      };
      clientValidationRule.ValidationParameters.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867915836), (object) this._pattern);
      return (IEnumerable<ModelClientValidationRule>) new ModelClientValidationRule[1]
      {
        clientValidationRule
      };
    }

    internal static void AL0ghCo5FAekJ2SNFhM8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object PWuODfo5BCvit7TZX3fh([In] object obj0) => (object) ((System.ComponentModel.DataAnnotations.RegularExpressionAttribute) obj0).Pattern;

    internal static bool BgKOi9ogcKdtJYx1oY6h() => RegularExpressionValidator.Id7hlGogsgwE0QVBGJkY == null;

    internal static RegularExpressionValidator UiBZqLogzkEmfHfe9RR5() => RegularExpressionValidator.Id7hlGogsgwE0QVBGJkY;
  }
}
