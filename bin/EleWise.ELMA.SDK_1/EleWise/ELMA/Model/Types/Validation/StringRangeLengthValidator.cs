// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.StringRangeLengthValidator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace EleWise.ELMA.Model.Types.Validation
{
  public class StringRangeLengthValidator : DataAnnotationsModelValidator<StringRangeLengthAttribute>
  {
    private int _minValue;
    private int? _maxValue;
    public const string ValidationType = "stringrangelength";
    private static StringRangeLengthValidator sDZXI1o5pUCZS2BhkCxR;

    public StringRangeLengthValidator(
      ModelMetadata metadata,
      ControllerContext context,
      StringRangeLengthAttribute attribute)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(metadata, context, attribute);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._maxValue = !StringRangeLengthValidator.Lq9myRo5tOQ6kKJiiu3V((object) attribute.MaxValue) ? new int?(StringRangeLengthValidator.r4w915o54RL7yabV0H5W(StringRangeLengthValidator.xuSEIxo5w6Jql4wmfdmm((object) attribute))) : new int?();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 2;
            continue;
          case 2:
            goto label_3;
          default:
            this._minValue = attribute.MinValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
    {
      ModelClientValidationRule clientValidationRule = new ModelClientValidationRule()
      {
        ErrorMessage = EleWise.ELMA.SR.T(this.ErrorMessage),
        ValidationType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859058387)
      };
      clientValidationRule.ValidationParameters.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272452169), (object) this._minValue);
      clientValidationRule.ValidationParameters.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515116655), this._maxValue.HasValue ? (object) this._maxValue.Value : (object) null);
      return (IEnumerable<ModelClientValidationRule>) new ModelClientValidationRule[1]
      {
        clientValidationRule
      };
    }

    internal static bool Lq9myRo5tOQ6kKJiiu3V([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object xuSEIxo5w6Jql4wmfdmm([In] object obj0) => (object) ((StringRangeLengthAttribute) obj0).MaxValue;

    internal static int r4w915o54RL7yabV0H5W([In] object obj0) => Convert.ToInt32((string) obj0);

    internal static bool nGjuwTo5acOaoZDBkiVa() => StringRangeLengthValidator.sDZXI1o5pUCZS2BhkCxR == null;

    internal static StringRangeLengthValidator sGgUBto5DMQQ6Ys5AAGr() => StringRangeLengthValidator.sDZXI1o5pUCZS2BhkCxR;
  }
}
