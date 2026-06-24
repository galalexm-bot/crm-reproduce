using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ExpressionUtil;

public static class ILGeneratorHacks
{
	public static readonly MethodInfo PostIncMethod;

	public static readonly FieldInfo LocalSignatureField;

	public static readonly FieldInfo LocalCountField;

	public static readonly MethodInfo AddArgumentMethod;

	private static readonly Func<ILGenerator, Type, int> _getNextLocalVarIndex;

	private static ILGeneratorHacks EiMmlJGrTZIQ9B1JwTss;

	public static Func<ILGenerator, Type, int> CompileGetNextLocalVarIndex()
	{
		if (LocalCountField == null || LocalSignatureField == null || AddArgumentMethod == null)
		{
			return (ILGenerator i, Type t) => _003C_003Ec.flYMrH88YX0De7m8O9c0(_003C_003Ec.Csxv1t88jhbI8u5THbjq(i, t));
		}
		DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(int), new Type[3]
		{
			typeof(ExpressionCompiler.ArrayClosure),
			typeof(ILGenerator),
			typeof(Type)
		}, typeof(ExpressionCompiler.ArrayClosure), skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.Emit(OpCodes.Ldfld, LocalSignatureField);
		iLGenerator.Emit(OpCodes.Ldarg_2);
		iLGenerator.Emit(OpCodes.Ldc_I4_0);
		iLGenerator.Emit(OpCodes.Call, AddArgumentMethod);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.Emit(OpCodes.Ldflda, LocalCountField);
		iLGenerator.Emit(OpCodes.Call, PostIncMethod);
		iLGenerator.Emit(OpCodes.Ret);
		return (Func<ILGenerator, Type, int>)dynamicMethod.CreateDelegate(typeof(Func<ILGenerator, Type, int>), ExpressionCompiler.EmptyArrayClosure);
	}

	internal static int PostInc(ref int i)
	{
		int num = 1;
		int num2 = num;
		int result = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				result = i++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return result;
			}
		}
	}

	public static int GetNextLocalVarIndex(this ILGenerator il, Type t)
	{
		return _getNextLocalVarIndex(il, t);
	}

	static ILGeneratorHacks()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				PostIncMethod = (MethodInfo)qZrGAyGr1wVqcq4WcKBq(OKkDX9Greo6A3ulKhAjx(bNjMq0Gr2Iy6UdTIoKjb(typeof(ILGeneratorHacks).TypeHandle)), bRaOIVGrPGbZFGdbso5v(-1146510045 ^ -1146243309));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				LocalSignatureField = (FieldInfo)Ll5JXdGrNTNeG5q8MBuD(OKkDX9Greo6A3ulKhAjx(bNjMq0Gr2Iy6UdTIoKjb(typeof(ILGenerator).TypeHandle)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638669229));
				num2 = 4;
				break;
			case 4:
				LocalCountField = (FieldInfo)Ll5JXdGrNTNeG5q8MBuD(OKkDX9Greo6A3ulKhAjx(typeof(ILGenerator)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234041994));
				num2 = 5;
				break;
			case 1:
				dCQDTJGrOjSV5S2ePRvv();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			case 2:
				_getNextLocalVarIndex = CompileGetNextLocalVarIndex();
				num2 = 3;
				break;
			case 5:
				AddArgumentMethod = ((TypeInfo)OKkDX9Greo6A3ulKhAjx(bNjMq0Gr2Iy6UdTIoKjb(typeof(SignatureHelper).TypeHandle))).GetDeclaredMethods((string)bRaOIVGrPGbZFGdbso5v(0x57A5235E ^ 0x57A131DC)).First((MethodInfo m) => m.GetParameters().Length == 2);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool qXYArEGrkKLSNHwL0EaV()
	{
		return EiMmlJGrTZIQ9B1JwTss == null;
	}

	internal static ILGeneratorHacks BexZIoGrn2rO7rEMNnUw()
	{
		return EiMmlJGrTZIQ9B1JwTss;
	}

	internal static void dCQDTJGrOjSV5S2ePRvv()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type bNjMq0Gr2Iy6UdTIoKjb(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object OKkDX9Greo6A3ulKhAjx(Type P_0)
	{
		return P_0.GetTypeInfo();
	}

	internal static object bRaOIVGrPGbZFGdbso5v(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object qZrGAyGr1wVqcq4WcKBq(object P_0, object P_1)
	{
		return ((TypeInfo)P_0).GetDeclaredMethod((string)P_1);
	}

	internal static object Ll5JXdGrNTNeG5q8MBuD(object P_0, object P_1)
	{
		return ((TypeInfo)P_0).GetDeclaredField((string)P_1);
	}
}
