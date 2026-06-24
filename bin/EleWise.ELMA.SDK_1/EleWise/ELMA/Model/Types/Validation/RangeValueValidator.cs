// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.RangeValueValidator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace EleWise.ELMA.Model.Types.Validation
{
  public class RangeValueValidator : DataAnnotationsModelValidator<RangeValueAttribute>
  {
    private readonly object _min;
    private readonly object _max;
    private readonly Type _operandType;
    public const string ValidationType = "rangevalidator";
    private static RangeValueValidator rLxZsfog6I5bKgHq6jbT;

    public RangeValueValidator(
      ModelMetadata metadata,
      ControllerContext context,
      RangeValueAttribute attribute)
    {
      RangeValueValidator.L0TrL3og75r0tkhTnOIN();
      // ISSUE: explicit constructor call
      base.\u002Ector(metadata, context, attribute);
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 5:
            this._operandType = RangeValueValidator.JT8CWeogmbE9VPcSKkCV((object) attribute);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 3 : 3;
            continue;
          case 2:
            this._min = attribute.Minimum;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
            continue;
          case 3:
            goto label_8;
          case 4:
            if (RangeValueValidator.WqfdfHogxnXKpm0c9OJV((object) attribute) != null)
            {
              num = 2;
              continue;
            }
            goto default;
          case 6:
            this._max = attribute.Maximum;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
            continue;
          default:
            if (RangeValueValidator.npmyqrog0ObhMcW3pVYg((object) attribute) == null)
            {
              num = 5;
              continue;
            }
            goto case 6;
        }
      }
label_8:;
    }

    public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
    {
      ModelClientValidationRule clientValidationRule = new ModelClientValidationRule()
      {
        ErrorMessage = EleWise.ELMA.SR.T(this.ErrorMessage),
        ValidationType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345248108)
      };
      clientValidationRule.ValidationParameters.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712324235), this._min);
      clientValidationRule.ValidationParameters.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1114018117), this._max);
      return (IEnumerable<ModelClientValidationRule>) new ModelClientValidationRule[1]
      {
        clientValidationRule
      };
    }

    internal static void L0TrL3og75r0tkhTnOIN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object WqfdfHogxnXKpm0c9OJV([In] object obj0) => ((RangeAttribute) obj0).Minimum;

    internal static object npmyqrog0ObhMcW3pVYg([In] object obj0) => ((RangeAttribute) obj0).Maximum;

    internal static Type JT8CWeogmbE9VPcSKkCV([In] object obj0) => ((RangeAttribute) obj0).OperandType;

    internal static bool UaTwnxogHlAxUQ8cdvkI() => RangeValueValidator.rLxZsfog6I5bKgHq6jbT == null;

    internal static RangeValueValidator s3rVt5ogANDDmptOSR1R() => RangeValueValidator.rLxZsfog6I5bKgHq6jbT;
  }
}
