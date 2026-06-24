using System;
using EleWise.ELMA.API;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

public class TypeArgument
{
	private class InterfaceTypeArgument : TypeArgument
	{
		private static object OrUcIRvw2u26mTTuLHDP;

		public InterfaceTypeArgument(TypeArgument typeArgument)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			dA8gI9vw1yjr1acjVZZv();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					metadata = typeArgument.metadata;
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num = 1;
					}
					break;
				default:
					type = typeArgument.type;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num = 1;
					}
					break;
				case 2:
					return;
				}
			}
		}

		internal override ISyntaxNode CreateTypeSyntax()
		{
			//Discarded unreachable code: IL_005c, IL_0066, IL_0075
			int num = 3;
			int num2 = num;
			object typeName;
			while (true)
			{
				switch (num2)
				{
				default:
					typeName = (string)bcb2P3vwNUM1iPvNLq0K(metadata) + (string)mg4Go6vw3hrUyRBGeS6K(0x31326106 ^ 0x3137AD34) + metadata.Name;
					break;
				case 2:
					return base.CreateTypeSyntax();
				case 3:
					if (metadata != null)
					{
						if (string.IsNullOrEmpty((string)bcb2P3vwNUM1iPvNLq0K(metadata)))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto default;
					}
					num2 = 2;
					continue;
				case 1:
					typeName = jGqxmovwa4B06XCscllk(mg4Go6vw3hrUyRBGeS6K(0x4D1C1EE4 ^ 0x4D1EE022), cm5oWCvwprPWJUmXCnuP(metadata));
					break;
				}
				break;
			}
			return ((string)typeName).CreateTypeSyntax();
		}

		internal static void dA8gI9vw1yjr1acjVZZv()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool MWBA5xvwek367S6I6qM3()
		{
			return OrUcIRvw2u26mTTuLHDP == null;
		}

		internal static InterfaceTypeArgument mi8lZ3vwPA0ImaQV0c6W()
		{
			return (InterfaceTypeArgument)OrUcIRvw2u26mTTuLHDP;
		}

		internal static object bcb2P3vwNUM1iPvNLq0K(object P_0)
		{
			return ((ClassMetadata)P_0).Namespace;
		}

		internal static object mg4Go6vw3hrUyRBGeS6K(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object cm5oWCvwprPWJUmXCnuP(object P_0)
		{
			return ((NamedMetadata)P_0).Name;
		}

		internal static object jGqxmovwa4B06XCscllk(object P_0, object P_1)
		{
			return (string)P_0 + (string)P_1;
		}
	}

	protected Type type;

	protected EntityMetadata metadata;

	internal static TypeArgument H8HLPSh7VFRhmuXbJRAi;

	internal TypeArgument UseInterface => new InterfaceTypeArgument(this);

	private TypeArgument()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qApy9xh7RnZx250OXJf4();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public string ParameterPath()
	{
		//Discarded unreachable code: IL_0070, IL_007f
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)SXcGu2h7KUKP5A8nuWbR(metadata);
			case 1:
				return (string)fVRVbQh7Xu4v96XIACh1(type);
			case 2:
				if (PhBV99h7qOcxOFxoE844(type, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public static implicit operator TypeArgument(Type type)
	{
		return new TypeArgument
		{
			type = type
		};
	}

	public static implicit operator TypeArgument(EntityMetadata metadata)
	{
		return new TypeArgument
		{
			metadata = metadata
		};
	}

	internal virtual ISyntaxNode CreateTypeSyntax()
	{
		//Discarded unreachable code: IL_0058, IL_0067
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (PhBV99h7qOcxOFxoE844(type, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return (ISyntaxNode)HhbVquh7kVOCKMDXXLPu(ojKa70h7TtoqFvPYoVt5(metadata));
			case 1:
				return (ISyntaxNode)swXYNnh7nC1prJOCLU62(type);
			}
		}
	}

	internal static void qApy9xh7RnZx250OXJf4()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool xOlAHDh7SO8ce5CJYQ9e()
	{
		return H8HLPSh7VFRhmuXbJRAi == null;
	}

	internal static TypeArgument YXjcDxh7immCW8PxbsrH()
	{
		return H8HLPSh7VFRhmuXbJRAi;
	}

	internal static bool PhBV99h7qOcxOFxoE844(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object SXcGu2h7KUKP5A8nuWbR(object P_0)
	{
		return ((EntityMetadata)P_0).ParameterPath();
	}

	internal static object fVRVbQh7Xu4v96XIACh1(Type type)
	{
		return type.ParameterPath();
	}

	internal static object ojKa70h7TtoqFvPYoVt5(object P_0)
	{
		return PublicApiPropertyClassNode.GetTypeName((EntityMetadata)P_0);
	}

	internal static object HhbVquh7kVOCKMDXXLPu(object P_0)
	{
		return ((string)P_0).CreateTypeSyntax();
	}

	internal static object swXYNnh7nC1prJOCLU62(Type type)
	{
		return type.CreateTypeSyntax();
	}
}
