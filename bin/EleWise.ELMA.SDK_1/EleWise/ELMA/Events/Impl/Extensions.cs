// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Impl.Extensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Events.Impl
{
  public static class Extensions
  {
    private static Extensions vp7Ql8GLE0Rc0VnY1R0I;

    public static MethodInfo GetGenericMethod(
      this Type t,
      string name,
      Type[] genericArgTypes,
      Type[] argTypes,
      Type returnType)
    {
      int num1 = 5;
      string name1;
      Type[] genericArgTypes1;
      Type[] argTypes1;
      Type returnType1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              argTypes1 = argTypes;
              num2 = 2;
              continue;
            case 2:
              returnType1 = returnType;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            case 3:
              genericArgTypes1 = genericArgTypes;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 1;
              continue;
            case 4:
              goto label_3;
            case 5:
              num2 = 4;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        name1 = name;
        num1 = 3;
      }
label_5:
      return (MethodInfo) Extensions.S5feUoGLCVLx2VmTrnhc((object) ((IEnumerable<MethodInfo>) t.GetMethods(BindingFlags.Static | BindingFlags.Public)).Where<MethodInfo>((Func<MethodInfo, bool>) (m =>
      {
        int num3 = 5;
        while (true)
        {
          switch (num3)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (Extensions.\u003C\u003Ec__DisplayClass0_0.CicbWM8uaAc8BgcoEDtF((object) m).IsGenericType)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 2;
                continue;
              }
              goto label_2;
            case 2:
              // ISSUE: reference to a compiler-generated method
              if (Extensions.\u003C\u003Ec__DisplayClass0_0.CicbWM8uaAc8BgcoEDtF((object) m).IsGenericTypeDefinition)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                continue;
              }
              goto label_15;
            case 3:
              ParameterInfo[] parameters = m.GetParameters();
              // ISSUE: reference to a compiler-generated field
              Func<ParameterInfo, Type> func = Extensions.\u003C\u003Ec.\u003C\u003E9__0_1;
              Func<ParameterInfo, Type> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                Extensions.\u003C\u003Ec.\u003C\u003E9__0_1 = selector = (Func<ParameterInfo, Type>) (pi => Extensions.\u003C\u003Ec.o3q2Lr8uHhnvdno5cNXc((object) pi));
              }
              else
                goto label_18;
label_13:
              if (((IEnumerable<ParameterInfo>) parameters).Select<ParameterInfo, Type>(selector).SequenceEqual<Type>((IEnumerable<Type>) argTypes1))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
                continue;
              }
              goto label_17;
label_18:
              selector = func;
              goto label_13;
            case 4:
              // ISSUE: reference to a compiler-generated method
              if (Extensions.\u003C\u003Ec__DisplayClass0_0.wJVbcF8upJteboieb5Kv((object) m).Length == genericArgTypes1.Length)
              {
                num3 = 3;
                continue;
              }
              goto label_17;
            case 5:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (Extensions.\u003C\u003Ec__DisplayClass0_0.s4AQU38u3aLIEINeiqEZ(Extensions.\u003C\u003Ec__DisplayClass0_0.PjrJuN8uNMkWnfesJq4w((object) m), (object) name1))
              {
                num3 = 4;
                continue;
              }
              goto label_17;
            default:
              goto label_2;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        Type type1 = Extensions.\u003C\u003Ec__DisplayClass0_0.CicbWM8uaAc8BgcoEDtF((object) m);
        goto label_16;
label_15:
        type1 = returnType1.GetGenericTypeDefinition();
label_16:
        Type type2 = returnType1;
        // ISSUE: reference to a compiler-generated method
        return Extensions.\u003C\u003Ec__DisplayClass0_0.Jmss8T8uDeiQSUtY9g6B(type1, type2);
label_17:
        return false;
      })).Single<MethodInfo>(), (object) genericArgTypes1);
    }

    internal static object S5feUoGLCVLx2VmTrnhc([In] object obj0, [In] object obj1) => (object) ((MethodInfo) obj0).MakeGenericMethod((Type[]) obj1);

    internal static bool Q8ojR6GLf5juZVp9hrml() => Extensions.vp7Ql8GLE0Rc0VnY1R0I == null;

    internal static Extensions H2inaXGLQbx7yVI6hp4r() => Extensions.vp7Ql8GLE0Rc0VnY1R0I;
  }
}
