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
[DisplayName(typeof(ResourcesConditionCodeItem), "DisplayName")]
public class ConditionCodeItem : TwoOperandCodeItem
{
	[Component(Order = 54)]
	private class ToolboxItem : LogicalCodeItemToolBoxItem<ConditionCodeItem>
	{
		internal static object Fd9krZfx64AG9R093ek3;

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			aYajWhfx7Klkk6BYNEYS();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					base.ToolTipHeader = SR.T((string)VMtvs3fxxudQ3VlnicSp(0x92F12D5 ^ 0x92F4385));
					num = 2;
					break;
				case 2:
					base.ToolTipBody = (string)LKVPmyfx0hKYCSyNfgW7(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217694453));
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num = 1;
					}
					break;
				case 1:
					return;
				}
			}
		}

		internal static void aYajWhfx7Klkk6BYNEYS()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object VMtvs3fxxudQ3VlnicSp(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object LKVPmyfx0hKYCSyNfgW7(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool ATMxrFfxHNBVr54HI3t6()
		{
			return Fd9krZfx64AG9R093ek3 == null;
		}

		internal static ToolboxItem OjJ8t9fxAId5lvNUSeYR()
		{
			return (ToolboxItem)Fd9krZfx64AG9R093ek3;
		}
	}

	internal static ConditionCodeItem cOpBL4ini2bi1x4P53x;

	public ConditionCodeItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nC8oYEieUrwi8WhaTve();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				base.Operator = (string)P4rMCxiPNQ2ejpm3S68(0x4DC2B14D ^ 0x4DC2BD47);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override bool IsValidParent(ICodeItem compositeCodeItem)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!(compositeCodeItem is IfConditionCodeItem))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				if (!(compositeCodeItem is ConditionCodeItem))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				return compositeCodeItem is AndOrCodeItem;
			}
			break;
		}
		return true;
	}

	public override CodeStatement ToCodeStatement()
	{
		return null;
	}

	public override CodeExpression ToCodeExpression()
	{
		//Discarded unreachable code: IL_0045, IL_00c5
		int num = 4;
		int num2 = num;
		CodeExpression codeExpression2 = default(CodeExpression);
		CodeExpression codeExpression = default(CodeExpression);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (base.OperandOne == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 8;
			case 6:
				return new CodeBinaryOperatorExpression(codeExpression2, EJWt7YiNeNDxPmMwunA(this), codeExpression);
			case 1:
				return null;
			case 3:
				return null;
			case 5:
				if (codeExpression != null)
				{
					num2 = 6;
					break;
				}
				goto case 1;
			case 7:
				codeExpression2 = (CodeExpression)oDRMfPi1VAqvKxUXk0N(base.OperandOne);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (codeExpression2 == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 8:
				if (base.OperandTwo != null)
				{
					num2 = 7;
					break;
				}
				goto case 3;
			default:
				codeExpression = (CodeExpression)oDRMfPi1VAqvKxUXk0N(base.OperandTwo);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 2;
				}
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

	public override CodeBinaryOperatorType GetOperatorType()
	{
		//Discarded unreachable code: IL_0101, IL_0126, IL_0161, IL_0186, IL_0195, IL_01a4, IL_01b4, IL_01c3, IL_029d, IL_037d, IL_038c, IL_039b, IL_03aa, IL_0416, IL_0425, IL_0435, IL_0444, IL_0454, IL_048d, IL_04c0, IL_04cf, IL_04e2, IL_04f1, IL_0571, IL_0580, IL_0590, IL_05b5, IL_05eb, IL_061a, IL_0629, IL_0660, IL_066f, IL_06be
		int num = 44;
		uint num3 = default(uint);
		string @operator = default(string);
		CodeBinaryOperatorType result = default(CodeBinaryOperatorType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 37:
					if (num3 != 2715107524u)
					{
						num2 = 39;
						continue;
					}
					goto case 42;
				case 2:
					if (num3 > 3762399456u)
					{
						num2 = 22;
						continue;
					}
					goto case 37;
				case 22:
				case 48:
					if (num3 != 3779177075u)
					{
						num2 = 47;
						continue;
					}
					goto case 49;
				case 47:
					if (num3 != 3846287551u)
					{
						num2 = 33;
						continue;
					}
					goto case 26;
				case 5:
					if (V1Wilvip3SZbOcrMH6D(@operator, P4rMCxiPNQ2ejpm3S68(0x63ABA4E8 ^ 0x63ABEB28)))
					{
						num2 = 18;
						continue;
					}
					goto case 1;
				case 19:
					if (!V1Wilvip3SZbOcrMH6D(@operator, P4rMCxiPNQ2ejpm3S68(-978351861 ^ -978336051)))
					{
						num2 = 35;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 20;
				case 11:
					if (num3 != 486946535)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 26:
					if (!V1Wilvip3SZbOcrMH6D(@operator, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123616858)))
					{
						num2 = 34;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 29;
				case 14:
					if (num3 <= 990687777)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 17:
				case 55:
					result = CodeBinaryOperatorType.GreaterThanOrEqual;
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 10;
					}
					continue;
				case 29:
					result = CodeBinaryOperatorType.IdentityInequality;
					num2 = 23;
					continue;
				case 49:
					if (!V1Wilvip3SZbOcrMH6D(@operator, P4rMCxiPNQ2ejpm3S68(-2099751081 ^ -2099767163)))
					{
						goto case 1;
					}
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 4;
					}
					continue;
				case 6:
					if (!V1Wilvip3SZbOcrMH6D(@operator, P4rMCxiPNQ2ejpm3S68(0x7459E02 ^ 0x745D15C)))
					{
						num2 = 52;
						continue;
					}
					goto case 3;
				case 50:
					num3 = jVFmWPi3NNhh7SpEcqY(@operator);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 14;
					}
					continue;
				case 51:
					if (!(@operator == (string)P4rMCxiPNQ2ejpm3S68(-672123589 ^ -672105737)))
					{
						goto case 1;
					}
					num2 = 55;
					continue;
				case 42:
					if (!V1Wilvip3SZbOcrMH6D(@operator, P4rMCxiPNQ2ejpm3S68(-978351861 ^ -978336145)))
					{
						num = 32;
						break;
					}
					goto case 54;
				default:
					if (num3 != 940354920)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 41;
						}
						continue;
					}
					goto case 46;
				case 39:
					if (num3 != 3762399456u)
					{
						num2 = 31;
						continue;
					}
					goto case 51;
				case 54:
					result = CodeBinaryOperatorType.BooleanOr;
					num2 = 40;
					continue;
				case 4:
				case 53:
					result = CodeBinaryOperatorType.LessThanOrEqual;
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 17;
					}
					continue;
				case 13:
				case 18:
					result = CodeBinaryOperatorType.GreaterThan;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					result = CodeBinaryOperatorType.BooleanAnd;
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 9;
					}
					continue;
				case 27:
				case 36:
					if (num3 != 957132539)
					{
						num2 = 21;
						continue;
					}
					goto case 19;
				case 7:
					if (num3 > 940354920)
					{
						num2 = 27;
						continue;
					}
					goto case 11;
				case 21:
					if (num3 != 990687777)
					{
						num2 = 30;
						continue;
					}
					goto case 5;
				case 12:
				case 28:
					result = CodeBinaryOperatorType.ValueEquality;
					num = 9;
					break;
				case 44:
					result = CodeBinaryOperatorType.Add;
					num2 = 43;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
				case 8:
				case 9:
				case 10:
				case 15:
				case 16:
				case 23:
				case 24:
				case 25:
				case 30:
				case 31:
				case 32:
				case 33:
				case 34:
				case 35:
				case 38:
				case 40:
				case 41:
				case 45:
				case 52:
					return result;
				case 46:
					if (!(@operator == (string)P4rMCxiPNQ2ejpm3S68(-16752921 ^ -16755987)))
					{
						goto case 1;
					}
					num2 = 28;
					continue;
				case 43:
					@operator = base.Operator;
					num2 = 42;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 50;
					}
					continue;
				case 20:
					result = CodeBinaryOperatorType.LessThan;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			}
		}
	}

	public override bool IsValidChild(ICodeItem codeItem)
	{
		//Discarded unreachable code: IL_005e, IL_006d
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (codeItem is VariableCodeItem)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return codeItem is ConditionCodeItem;
			default:
				return true;
			}
		}
	}

	public override List<Type> GetTypesByOperand(OperandDirection direction)
	{
		return new List<Type>
		{
			typeof(VariableCodeItem),
			typeof(MathCodeItem),
			typeof(ExactValueCodeItem),
			typeof(ConditionCodeItem)
		};
	}

	internal static void nC8oYEieUrwi8WhaTve()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object P4rMCxiPNQ2ejpm3S68(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool kbKAYGiOAyikLvQd8KF()
	{
		return cOpBL4ini2bi1x4P53x == null;
	}

	internal static ConditionCodeItem jyewQVi2Z4k8se9BgyR()
	{
		return cOpBL4ini2bi1x4P53x;
	}

	internal static object oDRMfPi1VAqvKxUXk0N(object P_0)
	{
		return ((CodeItem)P_0).ToCodeExpression();
	}

	internal static CodeBinaryOperatorType EJWt7YiNeNDxPmMwunA(object P_0)
	{
		return ((TwoOperandCodeItem)P_0).GetOperatorType();
	}

	internal static uint jVFmWPi3NNhh7SpEcqY(object P_0)
	{
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	internal static bool V1Wilvip3SZbOcrMH6D(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
