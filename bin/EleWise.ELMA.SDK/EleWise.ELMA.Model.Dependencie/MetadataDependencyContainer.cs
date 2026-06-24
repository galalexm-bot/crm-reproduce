using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies;

public sealed class MetadataDependencyContainer : IDependencyContainer
{
	internal static MetadataDependencyContainer w0bx82hijinm6fwvmaO5;

	public List<FormViewItemDependencyContainer> FormDependencies { get; }

	public List<FunctionDependency> FunctionDependencies { get; }

	public List<DataClassDependency> DataClassDependencies { get; }

	public List<EntityDependency> EntityDependencies { get; }

	public List<EnumDependency> EnumDependencies { get; }

	public MetadataDependencyContainer()
	{
		//Discarded unreachable code: IL_002a
		CIj2LGhiUfMllWUAQfy6();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				DataClassDependencies = new List<DataClassDependency>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num = 5;
				}
				break;
			case 3:
			{
				FunctionDependencies = new List<FunctionDependency>();
				int num2 = 4;
				num = num2;
				break;
			}
			case 2:
				return;
			default:
				EnumDependencies = new List<EnumDependency>();
				num = 2;
				break;
			case 5:
				EntityDependencies = new List<EntityDependency>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				FormDependencies = new List<FormViewItemDependencyContainer>();
				num = 3;
				break;
			}
		}
	}

	internal static void CIj2LGhiUfMllWUAQfy6()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool kUohS3hiYIkmeKEMBASy()
	{
		return w0bx82hijinm6fwvmaO5 == null;
	}

	internal static MetadataDependencyContainer WZQ6H7hiLxE3k9ulSyyK()
	{
		return w0bx82hijinm6fwvmaO5;
	}
}
