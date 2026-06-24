using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Templates.TemplateGenerator;

public class MetadataBasedValue : FormatedValue
{
	private ClassMetadata containerMetadata;

	private bool containerMetadataEvaluated;

	internal static MetadataBasedValue TASxRHBaKuUhp0RGD6xt;

	public ClassMetadata ContainerMetadata
	{
		get
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					containerMetadataEvaluated = true;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					if (!containerMetadataEvaluated)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					containerMetadata = GetContainerMetadata();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			return containerMetadata;
		}
	}

	public object Container
	{
		[CompilerGenerated]
		get
		{
			return _003CContainer_003Ek__BackingField;
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
					_003CContainer_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string PropertyName
	{
		[CompilerGenerated]
		get
		{
			return _003CPropertyName_003Ek__BackingField;
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
					_003CPropertyName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
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

	private ClassMetadata GetContainerMetadata()
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_0058, IL_0067
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				xM8eHZBaOf8maaa2wot4(this, GUQbRyBanrFL6IUwaHKW(bhR78vBak1VFH6djF6RN(this)));
				num2 = 2;
				break;
			case 2:
				if (bhR78vBak1VFH6djF6RN(this) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				if (bhR78vBak1VFH6djF6RN(this).GetType().IsClass)
				{
					num2 = 5;
					break;
				}
				goto case 1;
			case 1:
			case 4:
				return null;
			case 5:
				return MetadataLoader.LoadMetadata(bhR78vBak1VFH6djF6RN(this).GetType()) as ClassMetadata;
			}
		}
	}

	public MetadataBasedValue()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RNXOUEBa2FJnsubZMgK7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool OZK1hFBaXkHeX52MjWJC()
	{
		return TASxRHBaKuUhp0RGD6xt == null;
	}

	internal static MetadataBasedValue l3PRxxBaTiY2ERsvBnfq()
	{
		return TASxRHBaKuUhp0RGD6xt;
	}

	internal static object bhR78vBak1VFH6djF6RN(object P_0)
	{
		return ((FormatedValue)P_0).Value;
	}

	internal static object GUQbRyBanrFL6IUwaHKW(object P_0)
	{
		return P_0.CastAsRealType();
	}

	internal static void xM8eHZBaOf8maaa2wot4(object P_0, object P_1)
	{
		((FormatedValue)P_0).Value = P_1;
	}

	internal static void RNXOUEBa2FJnsubZMgK7()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
