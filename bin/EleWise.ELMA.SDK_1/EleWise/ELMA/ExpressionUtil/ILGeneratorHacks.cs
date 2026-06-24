// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExpressionUtil.ILGeneratorHacks
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ExpressionUtil
{
  /// Hey
  public static class ILGeneratorHacks
  {
    public static readonly MethodInfo PostIncMethod;
    /// Get via reflection
    public static readonly FieldInfo LocalSignatureField;
    /// Get via reflection
    public static readonly FieldInfo LocalCountField;
    /// Get via reflection
    public static readonly MethodInfo AddArgumentMethod;
    private static readonly Func<ILGenerator, Type, int> _getNextLocalVarIndex;
    private static ILGeneratorHacks EiMmlJGrTZIQ9B1JwTss;

    /// Not allocating the LocalBuilder class
    ///             emitting this:
    ///             il.m_localSignature.AddArgument(type);
    ///             return PostInc(ref il.LocalCount);
    public static Func<ILGenerator, Type, int> CompileGetNextLocalVarIndex()
    {
      if (ILGeneratorHacks.LocalCountField == (FieldInfo) null || ILGeneratorHacks.LocalSignatureField == (FieldInfo) null || ILGeneratorHacks.AddArgumentMethod == (MethodInfo) null)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return (Func<ILGenerator, Type, int>) ((i, t) => ILGeneratorHacks.\u003C\u003Ec.flYMrH88YX0De7m8O9c0(ILGeneratorHacks.\u003C\u003Ec.Csxv1t88jhbI8u5THbjq((object) i, t)));
      }
      DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof (int), new Type[3]
      {
        typeof (ExpressionCompiler.ArrayClosure),
        typeof (ILGenerator),
        typeof (Type)
      }, typeof (ExpressionCompiler.ArrayClosure), true);
      ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldfld, ILGeneratorHacks.LocalSignatureField);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Ldc_I4_0);
      ilGenerator.Emit(OpCodes.Call, ILGeneratorHacks.AddArgumentMethod);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldflda, ILGeneratorHacks.LocalCountField);
      ilGenerator.Emit(OpCodes.Call, ILGeneratorHacks.PostIncMethod);
      ilGenerator.Emit(OpCodes.Ret);
      return (Func<ILGenerator, Type, int>) dynamicMethod.CreateDelegate(typeof (Func<ILGenerator, Type, int>), (object) ExpressionCompiler.EmptyArrayClosure);
    }

    internal static int PostInc(ref int i)
    {
      int num1 = 1;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num2 = i++;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return num2;
    }

    /// Does the job
    public static int GetNextLocalVarIndex(this ILGenerator il, Type t) => ILGeneratorHacks._getNextLocalVarIndex(il, t);

    static ILGeneratorHacks()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ILGeneratorHacks.dCQDTJGrOjSV5S2ePRvv();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          case 2:
            ILGeneratorHacks._getNextLocalVarIndex = ILGeneratorHacks.CompileGetNextLocalVarIndex();
            num = 3;
            continue;
          case 3:
            goto label_2;
          case 4:
            ILGeneratorHacks.LocalCountField = (FieldInfo) ILGeneratorHacks.Ll5JXdGrNTNeG5q8MBuD(ILGeneratorHacks.OKkDX9Greo6A3ulKhAjx(typeof (ILGenerator)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234041994));
            num = 5;
            continue;
          case 5:
            // ISSUE: type reference
            ILGeneratorHacks.AddArgumentMethod = ((TypeInfo) ILGeneratorHacks.OKkDX9Greo6A3ulKhAjx(ILGeneratorHacks.bNjMq0Gr2Iy6UdTIoKjb(__typeref (SignatureHelper)))).GetDeclaredMethods((string) ILGeneratorHacks.bRaOIVGrPGbZFGdbso5v(1470440286 ^ 1470181852)).First<MethodInfo>((Func<MethodInfo, bool>) (m => m.GetParameters().Length == 2));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 2;
            continue;
          case 6:
            // ISSUE: type reference
            ILGeneratorHacks.LocalSignatureField = (FieldInfo) ILGeneratorHacks.Ll5JXdGrNTNeG5q8MBuD(ILGeneratorHacks.OKkDX9Greo6A3ulKhAjx(ILGeneratorHacks.bNjMq0Gr2Iy6UdTIoKjb(__typeref (ILGenerator))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638669229));
            num = 4;
            continue;
          default:
            // ISSUE: type reference
            ILGeneratorHacks.PostIncMethod = (MethodInfo) ILGeneratorHacks.qZrGAyGr1wVqcq4WcKBq(ILGeneratorHacks.OKkDX9Greo6A3ulKhAjx(ILGeneratorHacks.bNjMq0Gr2Iy6UdTIoKjb(__typeref (ILGeneratorHacks))), ILGeneratorHacks.bRaOIVGrPGbZFGdbso5v(-1146510045 ^ -1146243309));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 6 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static bool qXYArEGrkKLSNHwL0EaV() => ILGeneratorHacks.EiMmlJGrTZIQ9B1JwTss == null;

    internal static ILGeneratorHacks BexZIoGrn2rO7rEMNnUw() => ILGeneratorHacks.EiMmlJGrTZIQ9B1JwTss;

    internal static void dCQDTJGrOjSV5S2ePRvv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type bNjMq0Gr2Iy6UdTIoKjb([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object OKkDX9Greo6A3ulKhAjx([In] Type obj0) => (object) IntrospectionExtensions.GetTypeInfo(obj0);

    internal static object bRaOIVGrPGbZFGdbso5v(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object qZrGAyGr1wVqcq4WcKBq([In] object obj0, [In] object obj1) => (object) ((TypeInfo) obj0).GetDeclaredMethod((string) obj1);

    internal static object Ll5JXdGrNTNeG5q8MBuD([In] object obj0, [In] object obj1) => (object) ((TypeInfo) obj0).GetDeclaredField((string) obj1);
  }
}
