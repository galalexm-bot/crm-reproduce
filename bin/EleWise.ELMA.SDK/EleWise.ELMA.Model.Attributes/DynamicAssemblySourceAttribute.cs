using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class DynamicAssemblySourceAttribute : Attribute
{
	private string assemblyName;

	private string hashCode;

	internal static DynamicAssemblySourceAttribute gpTaGmo8hb31yVZF5yOk;

	public string AssemblyName => assemblyName;

	public string HashCode => hashCode;

	public DynamicAssemblySourceAttribute(string assemblyName, string hashCode)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				this.hashCode = hashCode;
				num = 2;
				continue;
			}
			this.assemblyName = assemblyName;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
			{
				num = 1;
			}
		}
	}

	internal static bool wT8owjo8Gevi09wdSH9P()
	{
		return gpTaGmo8hb31yVZF5yOk == null;
	}

	internal static DynamicAssemblySourceAttribute SaLWTUo8EER9Uq2ZwQsI()
	{
		return gpTaGmo8hb31yVZF5yOk;
	}
}
