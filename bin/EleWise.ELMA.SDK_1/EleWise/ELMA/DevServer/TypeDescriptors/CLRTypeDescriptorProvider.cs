// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.DevServer.TypeDescriptors.CLRTypeDescriptorProvider
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
  internal sealed class CLRTypeDescriptorProvider : ITypeDescriptorProvider
  {
    private static Type clrTypeDescriptorType;
    internal static CLRTypeDescriptorProvider AjWFuwEnsHsSETcjO1Cy;

    /// <inheritdoc />
    public IEnumerable<Type> GetTypeDescriptors() => ((IEnumerable<Type>) typeof (CLRTypeDescriptorProvider).Assembly.GetTypes()).Where<Type>((Func<Type, bool>) (t =>
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (t.IsAbstract)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      // ISSUE: reference to a compiler-generated method
      return CLRTypeDescriptorProvider.\u003C\u003Ec.ktg73u8XrA0JeR1h7elj(t);
label_3:
      return false;
    }));

    private static bool IsCLRTypeDescriptor(Type toCheck)
    {
      int num = 10;
      while (true)
      {
        Type type1;
        Type type2;
        switch (num)
        {
          case 1:
            if (!CLRTypeDescriptorProvider.PQDG0TEOFMaM4lrCqv3G(CLRTypeDescriptorProvider.clrTypeDescriptorType, type1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 4;
              continue;
            }
            goto label_6;
          case 2:
            type2 = toCheck.GetGenericTypeDefinition();
            break;
          case 3:
          case 8:
            goto label_8;
          case 4:
            toCheck = toCheck.BaseType;
            num = 7;
            continue;
          case 5:
            type2 = toCheck;
            break;
          case 6:
            // ISSUE: type reference
            if (toCheck != CLRTypeDescriptorProvider.QOnltfEOW3NPUilEfQe6(__typeref (object)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 4 : 11;
              continue;
            }
            goto label_8;
          case 7:
          case 10:
            if (!CLRTypeDescriptorProvider.I8h44AEOBb2f1BlHbPB4(toCheck, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 3 : 1;
              continue;
            }
            goto case 6;
          case 9:
          case 11:
            if (toCheck.IsGenericType)
            {
              num = 2;
              continue;
            }
            goto case 5;
          default:
            goto label_6;
        }
        type1 = type2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
      }
label_6:
      return true;
label_8:
      return false;
    }

    public CLRTypeDescriptorProvider()
    {
      CLRTypeDescriptorProvider.hxlth1EOooJE3hwJ4hPG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static CLRTypeDescriptorProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CLRTypeDescriptorProvider.clrTypeDescriptorType = typeof (CLRTypeDescriptor<>);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
            continue;
          case 2:
            CLRTypeDescriptorProvider.hxlth1EOooJE3hwJ4hPG();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool PQDG0TEOFMaM4lrCqv3G([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool I8h44AEOBb2f1BlHbPB4([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static Type QOnltfEOW3NPUilEfQe6([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool b6L0AlEnci8XKA2g36iL() => CLRTypeDescriptorProvider.AjWFuwEnsHsSETcjO1Cy == null;

    internal static CLRTypeDescriptorProvider MYnZbCEnzgbAp0vFHZC6() => CLRTypeDescriptorProvider.AjWFuwEnsHsSETcjO1Cy;

    internal static void hxlth1EOooJE3hwJ4hPG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
