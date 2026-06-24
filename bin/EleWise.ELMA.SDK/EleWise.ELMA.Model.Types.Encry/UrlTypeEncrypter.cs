using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component]
public class UrlTypeEncrypter : BaseTypeEncrypter
{
	internal static UrlTypeEncrypter DpSaJ3oLYas3WG1qEvvH;

	public override bool CheckType(object obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0088, IL_0097
		int num = 2;
		int num2 = num;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return py8BSKoLssp2EArs4DmN(propertyMetadata2) == UrlDescriptor.UID;
			case 3:
				return false;
			case 1:
				if (propertyMetadata2 == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto default;
			case 2:
				propertyMetadata2 = propertyMetadata as PropertyMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_003d, IL_006d, IL_007c, IL_00ca, IL_0102, IL_0111
		object result = default(object);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				int num;
				if (qxLmLwoLcq8Yq0OKQuaA(obj))
				{
					num = 3;
					goto IL_0041;
				}
				goto IL_0087;
				IL_0041:
				while (true)
				{
					switch (num)
					{
					default:
						return result;
					case 0:
						return result;
					case 2:
						return result;
					case 3:
						goto IL_005b;
					case 1:
						break;
					}
					break;
					IL_005b:
					result = null;
					num = 2;
				}
				goto IL_0087;
				IL_0087:
				result = new Uri(obj, UriKind.RelativeOrAbsolute);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num = 0;
				}
				goto IL_0041;
			}
			catch (Exception)
			{
				int num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					default:
						return result;
					case 0:
						return result;
					case 1:
						result = null;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}
	}

	public UrlTypeEncrypter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ahecMwoLzdIbo5Rcahvu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid py8BSKoLssp2EArs4DmN(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool cpQSQSoLLOwCiOHwADcK()
	{
		return DpSaJ3oLYas3WG1qEvvH == null;
	}

	internal static UrlTypeEncrypter O8TwXroLU78DTysSeaPt()
	{
		return DpSaJ3oLYas3WG1qEvvH;
	}

	internal static bool qxLmLwoLcq8Yq0OKQuaA(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void ahecMwoLzdIbo5Rcahvu()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
