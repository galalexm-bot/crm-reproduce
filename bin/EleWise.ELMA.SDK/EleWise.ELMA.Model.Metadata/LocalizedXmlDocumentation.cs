using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
public class LocalizedXmlDocumentation
{
	private static LocalizedXmlDocumentation dXJ8Zubx5tGAfaQ6JPUe;

	public virtual byte[] DocumentationRaw
	{
		[CompilerGenerated]
		get
		{
			return _003CDocumentationRaw_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CDocumentationRaw_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual string Locale
	{
		[CompilerGenerated]
		get
		{
			return _003CLocale_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CLocale_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public LocalizedXmlDocumentation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Y8MRyHbxjf2A243DhvbM()
	{
		return dXJ8Zubx5tGAfaQ6JPUe == null;
	}

	internal static LocalizedXmlDocumentation G0fMxcbxYRluVBaQcSRH()
	{
		return dXJ8Zubx5tGAfaQ6JPUe;
	}
}
