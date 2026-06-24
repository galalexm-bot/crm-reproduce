using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Modules.Attributes;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class BrandResourceAttribute : Attribute
{
	private string resourceFullName;

	private string _resourceName;

	private static BrandResourceAttribute yYIRMnp5EGVwWCtGeh1;

	public string ResourceFullName => resourceFullName;

	public string ResourceName => _resourceName;

	public BrandResourceAttribute(string resourceFullName, string resourceName)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UtSmQ3pLjWPs3ZVlnSE();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.resourceFullName = resourceFullName;
				num = 2;
				break;
			case 0:
				return;
			case 2:
				_resourceName = resourceName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void UtSmQ3pLjWPs3ZVlnSE()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool SqY8TapjQCZFITgNW87()
	{
		return yYIRMnp5EGVwWCtGeh1 == null;
	}

	internal static BrandResourceAttribute si1vJJpYEaZu9OWZ1SV()
	{
		return yYIRMnp5EGVwWCtGeh1;
	}
}
