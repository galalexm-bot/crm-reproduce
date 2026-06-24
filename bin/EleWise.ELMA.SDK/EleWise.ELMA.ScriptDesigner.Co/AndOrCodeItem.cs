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
[DisplayName(typeof(ResourcesOrCodeItem), "DisplayName")]
public class AndOrCodeItem : TwoOperandCodeItem
{
	[Component(Order = 56)]
	private class ToolboxItem : LogicalCodeItemToolBoxItem<AndOrCodeItem>
	{
		private static object VcJMxXf0vta1tVbdXlAs;

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			brnbOef0uO8rG17IYrpu();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
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
					base.ToolTipBody = (string)RLJZy6f0VZ2yR4vni2jN(YgOl4Wf0If9Ojt1oeUIR(0x3C5338FF ^ 0x3C565DAD));
					num = 2;
					continue;
				}
				base.ToolTipHeader = (string)RLJZy6f0VZ2yR4vni2jN(YgOl4Wf0If9Ojt1oeUIR(-1870892489 ^ -1871112329));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num = 0;
				}
			}
		}

		internal static void brnbOef0uO8rG17IYrpu()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object YgOl4Wf0If9Ojt1oeUIR(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object RLJZy6f0VZ2yR4vni2jN(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool q7myxOf08jJPObXqieJa()
		{
			return VcJMxXf0vta1tVbdXlAs == null;
		}

		internal static ToolboxItem tM3T0Zf0ZDH1rQFKNbIe()
		{
			return (ToolboxItem)VcJMxXf0vta1tVbdXlAs;
		}
	}

	private static AndOrCodeItem FELYc2qugi2Gmv0N91h;

	public AndOrCodeItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HI5dfiqSBieKNPj2B54();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override bool IsValidParent(ICodeItem codeItem)
	{
		//Discarded unreachable code: IL_006b, IL_007a
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (codeItem is AndOrCodeItem)
				{
					num2 = 3;
					continue;
				}
				goto case 2;
			case 1:
				if (!(codeItem is IfConditionCodeItem))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				return codeItem is ConditionCodeItem;
			case 3:
				break;
			}
			break;
		}
		return true;
	}

	public override CodeStatement ToCodeStatement()
	{
		return null;
	}

	public override CodeBinaryOperatorType GetOperatorType()
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_00da
		int num = 2;
		int num2 = num;
		CodeBinaryOperatorType result = default(CodeBinaryOperatorType);
		string @operator = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 3:
				result = CodeBinaryOperatorType.BooleanAnd;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				result = CodeBinaryOperatorType.Add;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				if (!NYiOoZqRQBTEVIb87pM(@operator, XCm2Teqiax634IUTKBj(-138018305 ^ -137998687)))
				{
					num2 = 7;
					break;
				}
				goto case 3;
			case 1:
				@operator = base.Operator;
				num2 = 4;
				break;
			case 6:
				result = CodeBinaryOperatorType.BooleanOr;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 8;
				}
				break;
			case 4:
				if (!(@operator == (string)XCm2Teqiax634IUTKBj(-1824388195 ^ -1824373511)))
				{
					num2 = 5;
					break;
				}
				goto case 6;
			}
		}
	}

	public override CodeExpression ToCodeExpression()
	{
		//Discarded unreachable code: IL_00c1, IL_00d0
		int num = 6;
		int num2 = num;
		CodeExpression codeExpression2 = default(CodeExpression);
		CodeExpression codeExpression = default(CodeExpression);
		while (true)
		{
			switch (num2)
			{
			case 7:
				codeExpression2 = (CodeExpression)mmCYs6qq53hgbTcbTRX(base.OperandTwo);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				if (base.OperandOne == null)
				{
					num2 = 5;
					break;
				}
				goto case 1;
			case 2:
				if (codeExpression != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			default:
				if (codeExpression2 != null)
				{
					num2 = 4;
					break;
				}
				goto case 5;
			case 4:
				return new CodeBinaryOperatorExpression(codeExpression, oNly2OqKpQfKr3JfD22(this), codeExpression2);
			case 5:
				return null;
			case 1:
				if (base.OperandTwo != null)
				{
					num2 = 3;
					break;
				}
				goto case 5;
			case 3:
				codeExpression = (CodeExpression)mmCYs6qq53hgbTcbTRX(base.OperandOne);
				num2 = 7;
				break;
			}
		}
	}

	public override CodeStatement[] ToCodeStatementList()
	{
		return null;
	}

	public override List<Type> GetValidToInsert()
	{
		throw new NotImplementedException();
	}

	public override bool IsValidChild(ICodeItem codeItem)
	{
		throw new NotImplementedException();
	}

	public override List<Type> GetTypesByOperand(OperandDirection direction)
	{
		return new List<Type>
		{
			typeof(ConditionCodeItem),
			typeof(AndOrCodeItem)
		};
	}

	internal static void HI5dfiqSBieKNPj2B54()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool hkFiYWqIXPnuiOvkblW()
	{
		return FELYc2qugi2Gmv0N91h == null;
	}

	internal static AndOrCodeItem bQQ6qdqV3Axp5DV5WHS()
	{
		return FELYc2qugi2Gmv0N91h;
	}

	internal static object XCm2Teqiax634IUTKBj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool NYiOoZqRQBTEVIb87pM(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object mmCYs6qq53hgbTcbTRX(object P_0)
	{
		return ((CodeItem)P_0).ToCodeExpression();
	}

	internal static CodeBinaryOperatorType oNly2OqKpQfKr3JfD22(object P_0)
	{
		return ((TwoOperandCodeItem)P_0).GetOperatorType();
	}
}
