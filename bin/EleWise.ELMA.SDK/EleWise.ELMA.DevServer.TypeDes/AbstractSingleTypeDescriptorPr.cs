using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.DevServer.TypeDescriptors;

public abstract class AbstractSingleTypeDescriptorProvider<TTd> : ITypeDescriptorProvider where TTd : ITypeDescriptor
{
	internal static object HAUJdgEny1tZpWnOignt;

	public virtual IEnumerable<Type> GetTypeDescriptors()
	{
		return new Type[1] { TypeOf<TTd>.Raw };
	}

	protected AbstractSingleTypeDescriptorProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool N76VqDEnMNwlS1ioWKbb()
	{
		return HAUJdgEny1tZpWnOignt == null;
	}

	internal static object kWGivwEnJy5Lix7P7Fbh()
	{
		return HAUJdgEny1tZpWnOignt;
	}
}
