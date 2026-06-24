using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Extensions.Dynamic;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp.RuntimeBinder;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

public static class TypeFactoryExtensions
{
	private static readonly Type GetNullableTypeWithLengthType;

	private static TypeFactoryExtensions R140bvWmt5GCgsJY2ZhT;

	private static ConcurrentDictionary<string, IType> typeByTypeOfName => (ConcurrentDictionary<string, IType>)typeof(TypeFactory).GetField(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234163140), BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);

	private static dynamic getTypeDelegatesWithLength => ExposedObject.From(xJqebbWmHMBF7WniRtUo(typeof(TypeFactory).GetField((string)CFngsEWm66ILw16LZNsW(-1317790512 ^ -1317652608), BindingFlags.Static | BindingFlags.NonPublic), null));

	public static void ReRegisterType(IType nhibernateType, IEnumerable<string> aliases, Func<int, NullableType> ctorLength)
	{
		foreach (string item in new List<string>(aliases) { nhibernateType.get_Name() })
		{
			typeByTypeOfName[item] = nhibernateType;
			object arg = getTypeDelegatesWithLength;
			if (_003C_003Eo__1._003C_003Ep__0 == null)
			{
				_003C_003Eo__1._003C_003Ep__0 = CallSite<Action<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDC1EAA), null, typeof(TypeFactoryExtensions), new CSharpArgumentInfo[2]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			_003C_003Eo__1._003C_003Ep__0.Target(_003C_003Eo__1._003C_003Ep__0, arg, item);
			if (_003C_003Eo__1._003C_003Ep__1 == null)
			{
				_003C_003Eo__1._003C_003Ep__1 = CallSite<Action<CallSite, object, string, Delegate>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6EFE37), null, typeof(TypeFactoryExtensions), new CSharpArgumentInfo[3]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			_003C_003Eo__1._003C_003Ep__1.Target(_003C_003Eo__1._003C_003Ep__1, arg, item, DelegateExtensions.Cast(ctorLength, GetNullableTypeWithLengthType));
		}
	}

	public static void ReRegisterType(Type systemType, IType nhibernateType, IEnumerable<string> aliases, Func<int, NullableType> ctorLength)
	{
		List<string> list = new List<string>(aliases);
		list.AddRange(GetClrTypeAliases(systemType));
		ReRegisterType(nhibernateType, list, ctorLength);
	}

	public static NullableType GetType(NullableType defaultUnqualifiedType, int length, Func<int, NullableType> ctorDelegate)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		return (NullableType)typeof(TypeFactory).GetMethods(BindingFlags.Static | BindingFlags.NonPublic).First((MethodInfo m) => ((IEnumerable<ParameterInfo>)_003C_003Ec.ANIHvZQY7Nwy6YpUhdYT(m)).Count() == 3).Invoke(null, new object[3] { defaultUnqualifiedType, length, ctorDelegate });
	}

	private static IEnumerable<string> GetClrTypeAliases(Type systemType)
	{
		return (IEnumerable<string>)typeof(TypeFactory).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561215902), BindingFlags.Static | BindingFlags.NonPublic).Invoke(null, new object[1] { systemType });
	}

	static TypeFactoryExtensions()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				uoeZgEWmAgQTCTjUj97g();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				GetNullableTypeWithLengthType = XPLHIGWm7mqfyWwIyBUN(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECC7882), true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object CFngsEWm66ILw16LZNsW(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object xJqebbWmHMBF7WniRtUo(object P_0, object P_1)
	{
		return ((FieldInfo)P_0).GetValue(P_1);
	}

	internal static bool rGLTUMWmwZrE4PlmJGSa()
	{
		return R140bvWmt5GCgsJY2ZhT == null;
	}

	internal static TypeFactoryExtensions y3KqaxWm4VBH41scVxVj()
	{
		return R140bvWmt5GCgsJY2ZhT;
	}

	internal static void uoeZgEWmAgQTCTjUj97g()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type XPLHIGWm7mqfyWwIyBUN(object P_0, bool P_1)
	{
		return Type.GetType((string)P_0, P_1);
	}
}
