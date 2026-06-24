// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryInFunctions.RelativeDateTimeFunction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.QueryInFunctions
{
  [Component]
  public class RelativeDateTimeFunction : IQueryInFunction, IEQLFunction
  {
    internal static RelativeDateTimeFunction Cp2P3gG0Q6jXtxe0Us4C;

    public string FunctionName => (string) RelativeDateTimeFunction.Wv0onyG08kHCgH9t5mtS(1925118608 << 2 ^ -889199090);

    public ICriterion GetCriterion(
      string alias,
      EntityMetadata metadata,
      string propName,
      object[] parameters)
    {
      int num = 6;
      EntityPropertyMetadata propertyMetadata;
      string propName1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parameters.Length == 2)
            {
              num = 8;
              continue;
            }
            goto label_12;
          case 2:
            goto label_16;
          case 3:
            goto label_12;
          case 4:
            if (parameters[0] is string)
            {
              num = 9;
              continue;
            }
            goto label_12;
          case 5:
            propName1 = propName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 0;
            continue;
          case 6:
            num = 5;
            continue;
          case 7:
            if (!(parameters[1] is string))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 3 : 1;
              continue;
            }
            break;
          case 8:
            if (parameters[0] == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          default:
            if (parameters[1] != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 7 : 7;
              continue;
            }
            break;
        }
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        propertyMetadata = (EntityPropertyMetadata) metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => RelativeDateTimeFunction.\u003C\u003Ec__DisplayClass2_0.yMtPXh8CIIFSvPtXC1Ri(RelativeDateTimeFunction.\u003C\u003Ec__DisplayClass2_0.qP2uCQ8Cun586MGyxy93((object) p), (object) propName1)));
        num = 2;
      }
label_12:
      throw new ArgumentException();
label_16:
      return DateTimeRangeDescriptor.GetCriterion(RelativeDateTimeFunction.VKAOGWG0Z8P9WAb29auS((object) (string) parameters[0], (object) (string) parameters[1]), propertyMetadata == null || RelativeDateTimeFunction.IfM5OEG0IyFecqUOv4bv((object) (DateTimeSettings) RelativeDateTimeFunction.AwmbYNG0upqQiS4sfOTi((object) propertyMetadata)), alias, propName1);
    }

    public IEnumerable<EQLFunction> GetEqlFunctions() => (IEnumerable<EQLFunction>) new EQLFunction[1]
    {
      new EQLFunction()
      {
        DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536540184), (object) this.FunctionName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3594110)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867119955))),
        Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740441636)),
        Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -630105718), (object) this.FunctionName),
        Types = new Guid[1]{ DateTimeDescriptor.UID }
      }
    };

    public RelativeDateTimeFunction()
    {
      RelativeDateTimeFunction.YUuHJOG0VJGyEUmQi0R2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object Wv0onyG08kHCgH9t5mtS(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool ABvUHEG0CbYwS27JS1KV() => RelativeDateTimeFunction.Cp2P3gG0Q6jXtxe0Us4C == null;

    internal static RelativeDateTimeFunction sVm2rOG0vudgwRWqlEHE() => RelativeDateTimeFunction.Cp2P3gG0Q6jXtxe0Us4C;

    internal static DateTimeRange VKAOGWG0Z8P9WAb29auS([In] object obj0, [In] object obj1) => RelativeDateTimeDescriptor.GetDateTimeRange((string) obj0, (string) obj1);

    internal static object AwmbYNG0upqQiS4sfOTi([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static bool IfM5OEG0IyFecqUOv4bv([In] object obj0) => ((DateTimeSettings) obj0).ShowTime;

    internal static void YUuHJOG0VJGyEUmQi0R2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
