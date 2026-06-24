using System;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 1000)]
public class UriWrapperDescriptor : ITypeWrapperDescriptor
{
	internal static UriWrapperDescriptor CM9qRjbbEgEKwnCTJkrR;

	public Type OriginalType => hdRNxvbbC1j5CixULPCj(typeof(Uri).TypeHandle);

	public Type WrapperType => hdRNxvbbC1j5CixULPCj(typeof(UriWrapper).TypeHandle);

	public Type[] GenericArgumentsTypes => null;

	public object CreateWrapper(object obj)
	{
		return new UriWrapper((Uri)obj);
	}

	public object GetObject(object wrapper)
	{
		return ((UriWrapper)wrapper).Value;
	}

	public bool TestType(Type type)
	{
		return false;
	}

	public UriWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VT1a2RbbvlhS3ubvNNjR();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type hdRNxvbbC1j5CixULPCj(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool LR5OtIbbfYLt0nRu0DhT()
	{
		return CM9qRjbbEgEKwnCTJkrR == null;
	}

	internal static UriWrapperDescriptor CEqUypbbQL4Ll5w2llBK()
	{
		return CM9qRjbbEgEKwnCTJkrR;
	}

	internal static void VT1a2RbbvlhS3ubvNNjR()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
