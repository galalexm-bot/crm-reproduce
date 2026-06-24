// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.Dynamic.ExposedObjectHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp.RuntimeBinder;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.Dynamic
{
  /// <summary>http://exposedobject.codeplex.com</summary>
  internal class ExposedObjectHelper
  {
    private static Type s_csharpInvokePropertyType;
    private static ExposedObjectHelper c9EBrCGxdkCn7qIQRsOT;

    internal static bool InvokeBestMethod(
      object[] args,
      object target,
      List<MethodInfo> instanceMethods,
      out object result)
    {
      if (instanceMethods.Count == 1)
      {
        if (ExposedObjectHelper.TryInvoke(instanceMethods[0], target, args, out result))
          return true;
      }
      else if (instanceMethods.Count > 1)
      {
        MethodInfo methodInfo1 = (MethodInfo) null;
        Type[] typeArray = (Type[]) null;
        Type[] array1 = ((IEnumerable<object>) args).Select<object, Type>((Func<object, Type>) (p =>
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_5;
              case 2:
                if (p == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 1;
                  continue;
                }
                goto label_4;
              default:
                goto label_4;
            }
          }
label_4:
          return p.GetType();
label_5:
          // ISSUE: type reference
          // ISSUE: reference to a compiler-generated method
          return ExposedObjectHelper.\u003C\u003Ec.FUnRLA8QUrUPIgqxjSVD(__typeref (object));
        })).ToArray<Type>();
        Func<Type[], Type[], bool> func = (Func<Type[], Type[], bool>) ((a, b) =>
        {
          int num = 5;
          int index;
          while (true)
          {
            switch (num)
            {
              case 1:
              case 4:
                if (index < a.Length)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 2 : 2;
                  continue;
                }
                goto label_5;
              case 2:
              case 3:
                if (!a[index].IsAssignableFrom(b[index]))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 4 : 6;
                  continue;
                }
                ++index;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 1;
                continue;
              case 5:
                index = 0;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 2 : 4;
                continue;
              case 6:
                goto label_8;
              default:
                goto label_5;
            }
          }
label_5:
          return true;
label_8:
          return false;
        });
        // ISSUE: reference to a compiler-generated method
        foreach (MethodInfo methodInfo2 in instanceMethods.Where<MethodInfo>((Func<MethodInfo, bool>) (m => ExposedObjectHelper.\u003C\u003Ec__DisplayClass1_0.dyZQWc8Qg5xa4nIU47Oa((object) m).Length == args.Length)))
        {
          // ISSUE: reference to a compiler-generated method
          Type[] array2 = ((IEnumerable<ParameterInfo>) methodInfo2.GetParameters()).Select<ParameterInfo, Type>((Func<ParameterInfo, Type>) (x => ExposedObjectHelper.\u003C\u003Ec.fIAIRG8QsEmKuSeKMItb((object) x))).ToArray<Type>();
          if (func(array2, array1) && (methodInfo1 == (MethodInfo) null || func(typeArray, array2)))
          {
            methodInfo1 = methodInfo2;
            typeArray = array2;
          }
        }
        if (methodInfo1 != (MethodInfo) null && ExposedObjectHelper.TryInvoke(methodInfo1, target, args, out result))
          return true;
      }
      result = (object) null;
      return false;
    }

    internal static bool TryInvoke(
      MethodInfo methodInfo,
      object target,
      object[] args,
      out object result)
    {
      int num1 = 1;
      bool flag;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
              result = ExposedObjectHelper.Xtuy0QGxgG0fpZDheft1((object) methodInfo, target, (object) args);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
                num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    flag = true;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_13;
                }
              }
            }
            catch (TargetInvocationException ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
                num3 = 0;
              switch (num3)
              {
              }
            }
            catch (TargetParameterCountException ex)
            {
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
                num4 = 0;
              switch (num4)
              {
              }
            }
            break;
          case 2:
            goto label_12;
        }
        result = (object) null;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 2;
      }
label_12:
      return false;
label_13:
      return flag;
    }

    internal static Type[] GetTypeArgs(InvokeMemberBinder binder)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ExposedObjectHelper.s_csharpInvokePropertyType.IsInstanceOfType((object) binder))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return ((IEnumerable<Type>) ExposedObjectHelper.ftGabDGx5LKpnyKmNoHb((object) ExposedObjectHelper.s_csharpInvokePropertyType.GetProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710310464)), (object) binder, (object) null)).ToArray<Type>();
label_5:
      return (Type[]) null;
    }

    public ExposedObjectHelper()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ExposedObjectHelper()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ExposedObjectHelper.s_csharpInvokePropertyType = ExposedObjectHelper.jZs5fIGxY1gGCmPmejGD((object) typeof (RuntimeBinderException).Assembly, ExposedObjectHelper.uAtuo7GxjF6YlnHG6AAZ(1142330761 ^ 1541959139 ^ 536539970));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object Xtuy0QGxgG0fpZDheft1([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

    internal static bool evwSt2GxlhGARGAtUkOg() => ExposedObjectHelper.c9EBrCGxdkCn7qIQRsOT == null;

    internal static ExposedObjectHelper lgQ6WVGxrhZmtqThjN8q() => ExposedObjectHelper.c9EBrCGxdkCn7qIQRsOT;

    internal static object ftGabDGx5LKpnyKmNoHb([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static object uAtuo7GxjF6YlnHG6AAZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type jZs5fIGxY1gGCmPmejGD([In] object obj0, [In] object obj1) => ((Assembly) obj0).GetType((string) obj1);
  }
}
