using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 1000)]
public class BinaryFileWrapperDescriptor : ITypeWrapperDescriptor
{
	private static BinaryFileWrapperDescriptor sMDByBboMgmQn4wxqjYp;

	public Type OriginalType => typeof(BinaryFile);

	public Type WrapperType => B5q2AabodBg4kBqnIxjq(typeof(BinaryFileWrapper).TypeHandle);

	public object CreateWrapper(object obj)
	{
		return new BinaryFileWrapper((BinaryFile)obj);
	}

	public object GetObject(object wrapper)
	{
		//Discarded unreachable code: IL_0075, IL_0084
		int num = 3;
		int num2 = num;
		BinaryFileWrapper binaryFileWrapper = default(BinaryFileWrapper);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				BinaryFile obj = new BinaryFile
				{
					Id = binaryFileWrapper.Id
				};
				M8AWQAborxJL2tpoFurH(obj, fLSS1HbolMMwnU22OdUB(binaryFileWrapper));
				return obj;
			}
			default:
				return null;
			case 3:
				binaryFileWrapper = wrapper as BinaryFileWrapper;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (binaryFileWrapper == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public bool TestType(Type type)
	{
		return false;
	}

	public BinaryFileWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FkZkXCbogDc4dUmkUBaY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type B5q2AabodBg4kBqnIxjq(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool u36EnVboJKPeYkY7RBsc()
	{
		return sMDByBboMgmQn4wxqjYp == null;
	}

	internal static BinaryFileWrapperDescriptor HV944nbo984mRAjYUvI0()
	{
		return sMDByBboMgmQn4wxqjYp;
	}

	internal static object fLSS1HbolMMwnU22OdUB(object P_0)
	{
		return ((BinaryFileWrapper)P_0).SecondId;
	}

	internal static void M8AWQAborxJL2tpoFurH(object P_0, object P_1)
	{
		((BinaryFile)P_0).SecondId = (string)P_1;
	}

	internal static void FkZkXCbogDc4dUmkUBaY()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
