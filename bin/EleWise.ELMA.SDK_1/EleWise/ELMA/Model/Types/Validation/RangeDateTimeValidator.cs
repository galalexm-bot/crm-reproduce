// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.RangeDateTimeValidator
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
  public class RangeDateTimeValidator : DataAnnotationsModelValidator<RangeDateTimeAttribute>
  {
    private DateTime? _min;
    private DateTime? _max;
    public const string ValidationType = "rangedatevalidator";
    internal static RangeDateTimeValidator LECO1yogiRw8qXmIQGPI;

    public RangeDateTimeValidator(
      ModelMetadata metadata,
      ControllerContext context,
      RangeDateTimeAttribute attribute)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(metadata, context, attribute);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            this._max = !RangeDateTimeValidator.ztZdmZogX69xelZK10VR(RangeDateTimeValidator.YWbJLrogkJCp7ShiOFrq((object) attribute)) ? new DateTime?(new DateTime(Convert.ToInt64((string) RangeDateTimeValidator.YWbJLrogkJCp7ShiOFrq((object) attribute)))) : new DateTime?();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 1;
            continue;
          default:
            this._min = RangeDateTimeValidator.ztZdmZogX69xelZK10VR(RangeDateTimeValidator.viaoMcogK9BNJKpfTG9G((object) attribute)) ? new DateTime?() : new DateTime?(new DateTime(RangeDateTimeValidator.uo5mq4ogTW8lolbgEAVc((object) attribute.Min)));
            num = 2;
            continue;
        }
      }
label_4:;
    }

    public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
    {
      ModelClientValidationRule clientValidationRule = new ModelClientValidationRule()
      {
        ErrorMessage = EleWise.ELMA.SR.T(this.ErrorMessage),
        ValidationType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124745626)
      };
      clientValidationRule.ValidationParameters.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317617684), this._min.HasValue ? (object) this._min.Value.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304577741)) : (object) (string) null);
      clientValidationRule.ValidationParameters.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606760358), this._max.HasValue ? (object) this._max.Value.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536743914)) : (object) (string) null);
      return (IEnumerable<ModelClientValidationRule>) new ModelClientValidationRule[1]
      {
        clientValidationRule
      };
    }

    internal static object viaoMcogK9BNJKpfTG9G([In] object obj0) => (object) ((RangeDateTimeAttribute) obj0).Min;

    internal static bool ztZdmZogX69xelZK10VR([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static long uo5mq4ogTW8lolbgEAVc([In] object obj0) => Convert.ToInt64((string) obj0);

    internal static object YWbJLrogkJCp7ShiOFrq([In] object obj0) => (object) ((RangeDateTimeAttribute) obj0).Max;

    internal static bool zrOTVVogRrMenn6mdBj8() => RangeDateTimeValidator.LECO1yogiRw8qXmIQGPI == null;

    internal static RangeDateTimeValidator MLxJVUogqoqJVrC0efQY() => RangeDateTimeValidator.LECO1yogiRw8qXmIQGPI;
  }
}
