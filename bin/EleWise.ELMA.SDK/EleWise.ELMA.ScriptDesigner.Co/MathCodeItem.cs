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
[DisplayName(typeof(ResourcesMathCodeItem), "DisplayName")]
public class MathCodeItem : TwoOperandCodeItem
{
	[Component(Order = 56)]
	private class ToolboxItem : MathCodeItemToolBoxItem<MathCodeItem>
	{
		internal static object k1HSfwfxdsYcfJJIZWo8;

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_001a, IL_001f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					base.ToolTipBody = SR.T((string)xlvJTCfxgY07b5oyp9xK(0x53CB464B ^ 0x53CE22F7));
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num = 0;
					}
					break;
				case 2:
					base.ToolTipHeader = (string)iMmX4Cfx5hd9eFqXb5DW(xlvJTCfxgY07b5oyp9xK(0x7247028A ^ 0x724750DC));
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static object xlvJTCfxgY07b5oyp9xK(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object iMmX4Cfx5hd9eFqXb5DW(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool DtIUWHfxl2Rh3LHqI9LW()
		{
			return k1HSfwfxdsYcfJJIZWo8 == null;
		}

		internal static ToolboxItem yeAWrPfxrl9UuSLR7Vmr()
		{
			return (ToolboxItem)k1HSfwfxdsYcfJJIZWo8;
		}
	}

	internal static MathCodeItem XSu0ZGRvDa6QIBnHOYB;

	public MathCodeItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WwF1mfRu9LrSbiAa61D();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				base.OperandTwo = null;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num = 1;
				}
				break;
			default:
				base.OperandOne = null;
				num = 2;
				break;
			}
		}
	}

	public override List<Type> GetTypesByOperand(OperandDirection direction)
	{
		return new List<Type>
		{
			typeof(VariableCodeItem),
			typeof(MathCodeItem),
			typeof(ExactValueCodeItem)
		};
	}

	public override bool IsValidParent(ICodeItem compositeCodeItem)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (compositeCodeItem is AssignCodeItem)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return compositeCodeItem is MathCodeItem;
			default:
				return true;
			}
		}
	}

	public override CodeStatement ToCodeStatement()
	{
		int num = 1;
		int num2 = num;
		CodeExpression codeExpression = default(CodeExpression);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return new CodeExpressionStatement(codeExpression);
			case 1:
				codeExpression = (CodeExpression)JZAw5SRI4AmsktqpXjJ(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (codeExpression != null)
			{
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 2;
				}
				continue;
			}
			return null;
		}
	}

	public override CodeExpression ToCodeExpression()
	{
		//Discarded unreachable code: IL_005c, IL_006b, IL_010e, IL_011d
		int num = 3;
		int num2 = num;
		CodeExpression codeExpression = default(CodeExpression);
		CodeExpression codeExpression2 = default(CodeExpression);
		while (true)
		{
			switch (num2)
			{
			case 6:
				codeExpression = base.OperandOne.ToCodeExpression();
				num2 = 8;
				continue;
			case 4:
				if (codeExpression2 == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 7;
			case 8:
				codeExpression2 = (CodeExpression)JZAw5SRI4AmsktqpXjJ(base.OperandTwo);
				num2 = 5;
				continue;
			case 3:
				if (base.OperandOne != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 5:
				if (codeExpression != null)
				{
					num2 = 4;
					continue;
				}
				break;
			case 2:
				if (base.OperandTwo == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 6;
			case 7:
				return new CodeBinaryOperatorExpression(codeExpression, C33byYRVjBePAbpLYK3(this), codeExpression2);
			}
			break;
		}
		return null;
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
		return codeItem is VariableCodeItem;
	}

	public override CodeBinaryOperatorType GetOperatorType()
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_007c, IL_0126, IL_01b9
		int num = 14;
		string @operator = default(string);
		CodeBinaryOperatorType result = default(CodeBinaryOperatorType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (!gQWCW5RinZRtyOHWZim(@operator, YcpAiMRSUWS1mVDl3aO(-889460160 ^ -889477730)))
					{
						num2 = 7;
						continue;
					}
					goto case 5;
				default:
					return result;
				case 14:
					result = CodeBinaryOperatorType.Add;
					num2 = 13;
					continue;
				case 13:
					break;
				case 7:
					if (!gQWCW5RinZRtyOHWZim(@operator, YcpAiMRSUWS1mVDl3aO(-1979251663 ^ -1979230623)))
					{
						num2 = 11;
						continue;
					}
					goto case 8;
				case 8:
					result = CodeBinaryOperatorType.Multiply;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					result = CodeBinaryOperatorType.Divide;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 6;
					}
					continue;
				case 5:
					result = CodeBinaryOperatorType.Add;
					num2 = 2;
					continue;
				case 11:
					if (!gQWCW5RinZRtyOHWZim(@operator, YcpAiMRSUWS1mVDl3aO(-1939377524 ^ -1939374880)))
					{
						num2 = 4;
						continue;
					}
					goto case 1;
				case 1:
					result = CodeBinaryOperatorType.Subtract;
					num2 = 12;
					continue;
				case 4:
					if (!gQWCW5RinZRtyOHWZim(@operator, YcpAiMRSUWS1mVDl3aO(0x7459E02 ^ 0x745D1E6)))
					{
						num2 = 3;
						continue;
					}
					goto case 10;
				}
				break;
			}
			@operator = base.Operator;
			num = 9;
		}
	}

	internal static void WwF1mfRu9LrSbiAa61D()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ErFWm1R8uj2gH6rOGYx()
	{
		return XSu0ZGRvDa6QIBnHOYB == null;
	}

	internal static MathCodeItem fEOHBtRZtVsWRYBWCbJ()
	{
		return XSu0ZGRvDa6QIBnHOYB;
	}

	internal static object JZAw5SRI4AmsktqpXjJ(object P_0)
	{
		return ((CodeItem)P_0).ToCodeExpression();
	}

	internal static CodeBinaryOperatorType C33byYRVjBePAbpLYK3(object P_0)
	{
		return ((TwoOperandCodeItem)P_0).GetOperatorType();
	}

	internal static object YcpAiMRSUWS1mVDl3aO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool gQWCW5RinZRtyOHWZim(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
