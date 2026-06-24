// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.DateTimeQueryResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.QueryFunctionResults
{
  [Component]
  public class DateTimeQueryResult : IQueryFunctionResult, IEQLFunction
  {
    internal static DateTimeQueryResult RaIyx9GM4wjYEOQKOAhm;

    public string FunctionName => (string) DateTimeQueryResult.rC3tdEGMAg8pf6sZFfPX(--1418440330 ^ 1418698956);

    public object GetValue(EntityMetadata metadata, string propName, object[] parameters)
    {
      int num = 17;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parameters.Length == 6)
            {
              num = 2;
              continue;
            }
            goto label_16;
          case 2:
            object[] source1 = parameters;
            // ISSUE: reference to a compiler-generated field
            Func<object, bool> func1 = DateTimeQueryResult.\u003C\u003Ec.\u003C\u003E9__2_3;
            Func<object, bool> predicate1;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              DateTimeQueryResult.\u003C\u003Ec.\u003C\u003E9__2_3 = predicate1 = (Func<object, bool>) (p => p is long);
            }
            else
              goto label_12;
label_61:
            if (((IEnumerable<object>) source1).All<object>(predicate1))
            {
              num = 11;
              continue;
            }
            goto label_16;
label_12:
            predicate1 = func1;
            goto label_61;
          case 3:
            object[] source2 = parameters;
            // ISSUE: reference to a compiler-generated field
            Func<object, bool> func2 = DateTimeQueryResult.\u003C\u003Ec.\u003C\u003E9__2_2;
            Func<object, bool> predicate2;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              DateTimeQueryResult.\u003C\u003Ec.\u003C\u003E9__2_2 = predicate2 = (Func<object, bool>) (p => p is long);
            }
            else
              goto label_65;
label_57:
            if (!((IEnumerable<object>) source2).All<object>(predicate2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 1;
              continue;
            }
            goto label_32;
label_65:
            predicate2 = func2;
            goto label_57;
          case 4:
            if (!((string) parameters[0]).Equals((string) DateTimeQueryResult.rC3tdEGMAg8pf6sZFfPX(1994213607 >> 4 ^ 124377824), StringComparison.OrdinalIgnoreCase))
            {
              num = 12;
              continue;
            }
            goto label_37;
          case 5:
            goto label_22;
          case 6:
            goto label_6;
          case 7:
          case 12:
label_38:
            if (parameters.Length == 3)
            {
              num = 22;
              continue;
            }
            goto label_23;
          case 8:
            goto label_32;
          case 9:
            goto label_37;
          case 10:
            if (!((IEnumerable<object>) parameters).All<object>((Func<object, bool>) (p => p is long)))
            {
              num = 28;
              continue;
            }
            goto label_9;
          case 11:
            goto label_15;
          case 13:
            goto label_28;
          case 14:
            if (DateTimeQueryResult.Th5qTOGM7iRvXsOo4dcx((object) (string) parameters[0], DateTimeQueryResult.rC3tdEGMAg8pf6sZFfPX(-477139494 ^ -477404288), StringComparison.OrdinalIgnoreCase))
            {
              num = 6;
              continue;
            }
            break;
          case 15:
            if (!((string) parameters[0]).Equals((string) DateTimeQueryResult.rC3tdEGMAg8pf6sZFfPX(589593376 ^ -1977315327 ^ -1459461989), StringComparison.OrdinalIgnoreCase))
            {
              num = 25;
              continue;
            }
            goto label_25;
          case 16:
          case 24:
            goto label_46;
          case 17:
            if (parameters.Length == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 16 : 15;
              continue;
            }
            goto case 23;
          case 18:
            if (((IEnumerable<object>) parameters).All<object>((Func<object, bool>) (p => p is long)))
            {
              num = 13;
              continue;
            }
            goto label_29;
          case 19:
            if (parameters[0] is string)
            {
              num = 15;
              continue;
            }
            goto case 25;
          case 20:
            if (parameters[0] is string)
            {
              num = 14;
              continue;
            }
            break;
          case 21:
            if (parameters[0] is string)
            {
              num = 29;
              continue;
            }
            goto case 27;
          case 22:
            object[] source3 = parameters;
            // ISSUE: reference to a compiler-generated field
            Func<object, bool> func3 = DateTimeQueryResult.\u003C\u003Ec.\u003C\u003E9__2_0;
            Func<object, bool> predicate3;
            if (func3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              DateTimeQueryResult.\u003C\u003Ec.\u003C\u003E9__2_0 = predicate3 = (Func<object, bool>) (p => p is long);
            }
            else
              goto label_66;
label_51:
            if (((IEnumerable<object>) source3).All<object>(predicate3))
            {
              num = 5;
              continue;
            }
            goto label_23;
label_66:
            predicate3 = func3;
            goto label_51;
          case 23:
            if (parameters.Length == 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 21 : 16;
              continue;
            }
            goto case 27;
          case 25:
            if (parameters.Length == 1)
            {
              num = 20;
              continue;
            }
            break;
          case 26:
            goto label_9;
          case 27:
            if (parameters.Length == 1)
            {
              num = 19;
              continue;
            }
            goto case 25;
          case 28:
label_10:
            if (parameters.Length == 5)
            {
              num = 3;
              continue;
            }
            goto case 1;
          case 29:
            if (!DateTimeQueryResult.Th5qTOGM7iRvXsOo4dcx((object) (string) parameters[0], DateTimeQueryResult.rC3tdEGMAg8pf6sZFfPX(-1858887263 ^ -1859048855), StringComparison.OrdinalIgnoreCase))
            {
              num = 27;
              continue;
            }
            goto label_46;
          case 30:
            goto label_25;
          default:
            if (!(parameters[0] is string))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 7 : 1;
              continue;
            }
            goto case 4;
        }
        if (parameters.Length == 1)
        {
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
          continue;
        }
        goto label_38;
label_16:
        if (parameters.Length == 7)
        {
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 18;
          continue;
        }
        goto label_29;
label_23:
        if (parameters.Length == 4)
          num = 10;
        else
          goto label_10;
      }
label_6:
      return (object) DateTimeQueryResult.WF6aBKGMy9InPgjcV3t7(DateTimeQueryResult.CemoOgGMmaNv0Swlq1lI((object) Locator.GetServiceNotNull<ITransformationProvider>()));
label_9:
      return (object) new DateTime(DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[0]), DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[1]), DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[2]), DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[3]), 0, 0);
label_15:
      return (object) new DateTime(DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[0]), DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[1]), Convert.ToInt32(parameters[2]), Convert.ToInt32(parameters[3]), DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[4]), DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[5]));
label_22:
      return (object) new DateTime(DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[0]), Convert.ToInt32(parameters[1]), DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[2]));
label_25:
      return (object) DateTimeQueryResult.ivNR5CGM0r0msQA4B1O9();
label_28:
      return (object) new DateTime(DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[0]), DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[1]), DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[2]), DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[3]), DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[4]), DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[5]), DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[6]));
label_29:
      throw new ArgumentException();
label_32:
      return (object) new DateTime(DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[0]), DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[1]), DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[2]), DateTimeQueryResult.wkxRE6GMMQvHoD1lZHJf(parameters[3]), Convert.ToInt32(parameters[4]), 0);
label_37:
      return (object) ((Dialect) DateTimeQueryResult.CemoOgGMmaNv0Swlq1lI((object) Locator.GetServiceNotNull<ITransformationProvider>())).MaxDateTime;
label_46:
      return (object) DateTimeQueryResult.LTCOxBGMxfpbJlVQu4Dc();
    }

    public IEnumerable<EQLFunction> GetEqlFunctions()
    {
      Guid[] guidArray = new Guid[1]
      {
        DateTimeDescriptor.UID
      };
      return (IEnumerable<EQLFunction>) new EQLFunction[6]
      {
        new EQLFunction()
        {
          DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138419974), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289455992)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858621619)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867464337)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813338839)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909442161)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541991767)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751440174)), (object) this.FunctionName),
          Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813438325)),
          Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979712828), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902056089)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672456708)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1406093489)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998276548)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939636836)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886911825)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69744577)), (object) this.FunctionName),
          Types = guidArray
        },
        new EQLFunction()
        {
          DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647647364), (object) this.FunctionName),
          Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909442109)),
          Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124378048), (object) this.FunctionName),
          Types = guidArray
        },
        new EQLFunction()
        {
          DisplayName = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951253318)),
          Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -489141097)),
          Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459297203), (object) this.FunctionName),
          Types = guidArray
        },
        new EQLFunction()
        {
          DisplayName = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883353356)),
          Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825381946)),
          Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106255296), (object) this.FunctionName),
          Types = guidArray
        },
        new EQLFunction()
        {
          DisplayName = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178216114)),
          Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413556625)),
          Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710309526), (object) this.FunctionName),
          Types = guidArray
        },
        new EQLFunction()
        {
          DisplayName = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867372617)),
          Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479509518)),
          Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -28994911), (object) this.FunctionName),
          Types = guidArray
        }
      };
    }

    public DateTimeQueryResult()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object rC3tdEGMAg8pf6sZFfPX(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool oC05GHGM6S6oZtIjbvl3() => DateTimeQueryResult.RaIyx9GM4wjYEOQKOAhm == null;

    internal static DateTimeQueryResult CBh0jBGMHTw3IDormExh() => DateTimeQueryResult.RaIyx9GM4wjYEOQKOAhm;

    internal static bool Th5qTOGM7iRvXsOo4dcx([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static DateTime LTCOxBGMxfpbJlVQu4Dc() => DateTime.Now;

    internal static DateTime ivNR5CGM0r0msQA4B1O9() => DateTime.Today;

    internal static object CemoOgGMmaNv0Swlq1lI([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static DateTime WF6aBKGMy9InPgjcV3t7([In] object obj0) => ((Dialect) obj0).MinDateTime;

    internal static int wkxRE6GMMQvHoD1lZHJf([In] object obj0) => Convert.ToInt32(obj0);
  }
}
