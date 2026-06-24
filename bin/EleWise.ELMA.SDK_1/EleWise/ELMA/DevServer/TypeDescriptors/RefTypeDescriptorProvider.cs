// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.DevServer.TypeDescriptors.RefTypeDescriptorProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.DevServer.TypeDescriptors
{
  /// <inheritdoc />
  internal sealed class RefTypeDescriptorProvider : ITypeDescriptorProvider
  {
    private static Type refTypeDescriptorType;
    internal static RefTypeDescriptorProvider bq4y1REObB3wmNgS8Ped;

    /// <inheritdoc />
    public IEnumerable<Type> GetTypeDescriptors() => ((IEnumerable<Type>) typeof (RefTypeDescriptorProvider).Assembly.GetTypes()).Where<Type>((Func<Type, bool>) (t =>
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!t.IsAbstract)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      return RefTypeDescriptorProvider.\u003C\u003Ec.InG8LE8XLOsGC1rZcWc3(t);
label_5:
      return false;
    }));

    private static bool IsRefTypeDescriptor(Type toCheck)
    {
      int num = 1;
      while (true)
      {
        Type type1;
        Type type2;
        switch (num)
        {
          case 1:
          case 4:
            if (!(toCheck != (Type) null))
            {
              num = 5;
              continue;
            }
            goto case 2;
          case 2:
            // ISSUE: type reference
            if (!(toCheck != RefTypeDescriptorProvider.mrkYmkEOff8P1MX7ICRl(__typeref (object))))
            {
              num = 10;
              continue;
            }
            goto default;
          case 3:
            toCheck = toCheck.BaseType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 4;
            continue;
          case 5:
          case 10:
            goto label_11;
          case 6:
            type2 = toCheck;
            break;
          case 7:
            type2 = toCheck.GetGenericTypeDefinition();
            break;
          case 8:
            if (!RefTypeDescriptorProvider.MIuTmFEOEJpL19FAissZ(RefTypeDescriptorProvider.refTypeDescriptorType, type1))
            {
              num = 3;
              continue;
            }
            goto label_2;
          case 9:
            goto label_2;
          default:
            if (toCheck.IsGenericType)
            {
              num = 7;
              continue;
            }
            goto case 6;
        }
        type1 = type2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 2 : 8;
      }
label_2:
      return true;
label_11:
      return false;
    }

    public RefTypeDescriptorProvider()
    {
      RefTypeDescriptorProvider.wv6xFjEOQ9hrquilh45i();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static RefTypeDescriptorProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: type reference
            RefTypeDescriptorProvider.refTypeDescriptorType = RefTypeDescriptorProvider.mrkYmkEOff8P1MX7ICRl(__typeref (RefTypeDescriptor<,>));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool MIuTmFEOEJpL19FAissZ([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static Type mrkYmkEOff8P1MX7ICRl([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool cFDrbeEOhDP4a36DHb7x() => RefTypeDescriptorProvider.bq4y1REObB3wmNgS8Ped == null;

    internal static RefTypeDescriptorProvider wEEf4vEOGfFAjCCSeYXU() => RefTypeDescriptorProvider.bq4y1REObB3wmNgS8Ped;

    internal static void wv6xFjEOQ9hrquilh45i() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
