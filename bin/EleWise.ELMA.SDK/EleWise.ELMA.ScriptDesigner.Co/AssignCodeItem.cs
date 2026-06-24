using System;
using System.CodeDom;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.ScriptDesigner.Enums;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ScriptDesigner.CodeItems;

[Serializable]
[DisplayName(typeof(ResourcesAssignVariableCodeItem), "DisplayName")]
public class AssignCodeItem : TwoOperandCodeItem
{
	[Component(Order = 52)]
	private class ToolboxItem : AssignCodeItemToolBoxItem<AssignCodeItem>
	{
		internal static object AyUmfcfxRgPMsNkyrCZs;

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					base.ToolTipHeader = (string)OMGYq0fxTiGlZyoVfFGk(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882147036));
					num = 2;
					continue;
				case 2:
					return;
				}
				base.ToolTipBody = (string)OMGYq0fxTiGlZyoVfFGk(eyJygnfxXSn0f8cw6ach(0x4DC2B14D ^ 0x4DC7D293));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num = 0;
				}
			}
		}

		internal static object eyJygnfxXSn0f8cw6ach(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object OMGYq0fxTiGlZyoVfFGk(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool AbWdZjfxqBXy0sTZDL8H()
		{
			return AyUmfcfxRgPMsNkyrCZs == null;
		}

		internal static ToolboxItem mHRhRIfxKp5hARi29NOB()
		{
			return (ToolboxItem)AyUmfcfxRgPMsNkyrCZs;
		}
	}

	private static AssignCodeItem o1Wdd7SMENUpaXPigM0;

	public AssignCodeItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		php3VCSdccSLoS3Gt2O();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override List<Type> GetTypesByOperand(OperandDirection direction)
	{
		if (direction == OperandDirection.Left)
		{
			return new List<Type> { typeof(VariableCodeItem) };
		}
		return new List<Type>
		{
			typeof(VariableCodeItem),
			typeof(MathCodeItem),
			typeof(ExactValueCodeItem)
		};
	}

	public override CodeBinaryOperatorType GetOperatorType()
	{
		throw new NotImplementedException();
	}

	public override bool IsValidParent(ICodeItem compositeCodeItem)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!(compositeCodeItem is IfCodeItem))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0070;
			case 3:
				if (!(compositeCodeItem is RootCodeItem))
				{
					num2 = 2;
					break;
				}
				goto IL_0070;
			case 1:
				return compositeCodeItem is IterationCodeItem;
			default:
				{
					if (!(compositeCodeItem is ElseCodeItem))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto IL_0070;
				}
				IL_0070:
				return true;
			}
		}
	}

	public override CodeStatement ToCodeStatement()
	{
		//Discarded unreachable code: IL_0066, IL_00f3, IL_0102
		int num = 4;
		int num2 = num;
		CodeExpression codeExpression = default(CodeExpression);
		CodeExpression codeExpression2 = default(CodeExpression);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (codeExpression != null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 3;
			case 4:
				if (base.OperandOne == null)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 6:
				if (codeExpression2 == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 2;
			case 8:
				codeExpression2 = (CodeExpression)qu7MJ1SloebnYPxh3Qr(base.OperandOne);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				return new CodeAssignStatement(codeExpression2, codeExpression);
			case 3:
			case 5:
				return null;
			default:
				if (base.OperandTwo != null)
				{
					num2 = 8;
					break;
				}
				goto case 3;
			case 1:
				codeExpression = (CodeExpression)qu7MJ1SloebnYPxh3Qr(base.OperandTwo);
				num2 = 6;
				break;
			}
		}
	}

	public override CodeExpression ToCodeExpression()
	{
		return null;
	}

	public override CodeStatement[] ToCodeStatementList()
	{
		return null;
	}

	public override List<Type> GetValidToInsert()
	{
		return new List<Type>
		{
			typeof(VariableCodeItem),
			typeof(MathCodeItem),
			typeof(ExactValueCodeItem)
		};
	}

	public override bool IsValidChild(ICodeItem codeItem)
	{
		return codeItem is VariableCodeItem;
	}

	internal static void php3VCSdccSLoS3Gt2O()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool DYlv0BSJNNkdKVlScoF()
	{
		return o1Wdd7SMENUpaXPigM0 == null;
	}

	internal static AssignCodeItem Jf1A0DS9b5kwJDT1ngt()
	{
		return o1Wdd7SMENUpaXPigM0;
	}

	internal static object qu7MJ1SloebnYPxh3Qr(object P_0)
	{
		return ((CodeItem)P_0).ToCodeExpression();
	}
}
