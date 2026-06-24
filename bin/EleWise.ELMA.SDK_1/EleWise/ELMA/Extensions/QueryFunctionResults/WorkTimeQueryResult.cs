// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.WorkTimeQueryResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Extensions.QueryFunctionResults
{
  [Component]
  public class WorkTimeQueryResult : IQueryFunctionResult, IEQLFunction
  {
    private static WorkTimeQueryResult lMxcJrGMvk4hkkiGDBDG;

    public string FunctionName => (string) WorkTimeQueryResult.DBUEJgGMuENJ1DVGCq0d(~541731958 ^ -541991417);

    public object GetValue(EntityMetadata metadata, string propName, object[] parameters)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            object[] source1 = parameters;
            // ISSUE: reference to a compiler-generated field
            Func<object, bool> func1 = WorkTimeQueryResult.\u003C\u003Ec.\u003C\u003E9__2_0;
            Func<object, bool> predicate1;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              WorkTimeQueryResult.\u003C\u003Ec.\u003C\u003E9__2_0 = predicate1 = (Func<object, bool>) (p => p is long);
            }
            else
              goto label_18;
label_12:
            if (((IEnumerable<object>) source1).All<object>(predicate1))
            {
              num = 4;
              continue;
            }
            break;
label_18:
            predicate1 = func1;
            goto label_12;
          case 2:
            if (parameters.Length == 2)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
              continue;
            }
            break;
          case 3:
            goto label_8;
          case 4:
            goto label_5;
          case 5:
            goto label_9;
          default:
            object[] source2 = parameters;
            // ISSUE: reference to a compiler-generated field
            Func<object, bool> func2 = WorkTimeQueryResult.\u003C\u003Ec.\u003C\u003E9__2_1;
            Func<object, bool> predicate2;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              WorkTimeQueryResult.\u003C\u003Ec.\u003C\u003E9__2_1 = predicate2 = (Func<object, bool>) (p => p is long);
            }
            else
              goto label_4;
label_16:
            if (!((IEnumerable<object>) source2).All<object>(predicate2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 5 : 2;
              continue;
            }
            goto label_8;
label_4:
            predicate2 = func2;
            goto label_16;
        }
        if (parameters.Length == 3)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
        else
          goto label_9;
      }
label_5:
      return (object) new WorkTime((long) parameters[0], (long) parameters[1]);
label_8:
      return (object) new WorkTime((long) parameters[0], (long) parameters[1], (long) parameters[2]);
label_9:
      throw new ArgumentException();
    }

    public IEnumerable<EQLFunction> GetEqlFunctions() => (IEnumerable<EQLFunction>) new EQLFunction[1]
    {
      new EQLFunction()
      {
        DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -28995391), (object) this.FunctionName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459296543)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461366359))),
        Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672029520)),
        Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1406094313), (object) this.FunctionName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886912433)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199681987))),
        Types = new Guid[1]{ WorkTimeDescriptor.UID }
      }
    };

    public WorkTimeQueryResult()
    {
      WorkTimeQueryResult.vFGTgUGMIEWJhIolEm6Q();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object DBUEJgGMuENJ1DVGCq0d(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool Dh2vK5GM8Hp3DG0RWpjO() => WorkTimeQueryResult.lMxcJrGMvk4hkkiGDBDG == null;

    internal static WorkTimeQueryResult ENhMT6GMZwATHkdKtHI7() => WorkTimeQueryResult.lMxcJrGMvk4hkkiGDBDG;

    internal static void vFGTgUGMIEWJhIolEm6Q() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
