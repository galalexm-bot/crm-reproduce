using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.ScriptDesigner.Enums;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ScriptDesigner.CodeItems;

[Serializable]
[DisplayName(typeof(ResourcesExactValueCodeItem), "DisplayName")]
public class ExactValueCodeItem : CodeItem
{
	[Component(Order = 58)]
	private class ToolboxItem : MathCodeItemToolBoxItem<ExactValueCodeItem>
	{
		private static object gw2DXEfxjxRFoYniasn6;

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			meofNIfxUhEZ99w5J8Q5();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void meofNIfxUhEZ99w5J8Q5()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool HY4ouDfxYVaWUuE8ZnFR()
		{
			return gw2DXEfxjxRFoYniasn6 == null;
		}

		internal static ToolboxItem Df7DS3fxLltQ1xNH0peH()
		{
			return (ToolboxItem)gw2DXEfxjxRFoYniasn6;
		}
	}

	internal static ExactValueCodeItem PW1M7ERTIedSmjiT238;

	public object Value
	{
		[CompilerGenerated]
		get
		{
			return _003CValue_003Ek__BackingField;
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
					_003CValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public MathConstantDesignerType DesignerType
	{
		[CompilerGenerated]
		get
		{
			return _003CDesignerType_003Ek__BackingField;
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
					_003CDesignerType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
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

	[XmlIgnore]
	public Type LeftOperatorType
	{
		[CompilerGenerated]
		get
		{
			return _003CLeftOperatorType_003Ek__BackingField;
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
					_003CLeftOperatorType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string LeftOperatorTypeName
	{
		get
		{
			//Discarded unreachable code: IL_0058, IL_0067
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (OpfwO6ROq3bFx5VlRoU(LeftOperatorType, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return null;
				default:
					return LeftOperatorType.AssemblyQualifiedName;
				}
			}
		}
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
					LeftOperatorType = ((value != null) ? DvoxJcR2AA2q1JZkdNb(value) : null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ExactValueCodeItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
		{
			num = 0;
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
				Value = null;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override bool IsValidParent(ICodeItem codeItem)
	{
		//Discarded unreachable code: IL_005a, IL_0069, IL_009e
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (codeItem is AssignCodeItem)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				if (codeItem is ConditionCodeItem)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 4:
				return codeItem is MathCodeItem;
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
			case 1:
				codeExpression = (CodeExpression)VvduyXReZquaObtcMIU(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return new CodeExpressionStatement(codeExpression);
			}
			if (codeExpression != null)
			{
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
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
		//Discarded unreachable code: IL_00cc, IL_00eb, IL_01d7, IL_0207, IL_03a5, IL_03b4, IL_03f7, IL_0406, IL_0471, IL_0500
		int num = 7;
		string currencyDecimalSeparator = default(string);
		DateTime result3 = default(DateTime);
		double result2 = default(double);
		string text = default(string);
		long result4 = default(long);
		long result = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				object s2;
				object s;
				switch (num2)
				{
				case 26:
					currencyDecimalSeparator = ((NumberFormatInfo)aL2dlERa3xEL9GvpgNK(sldbqURp9ksv5vp7fmT())).CurrencyDecimalSeparator;
					num2 = 10;
					continue;
				case 20:
					if (Value != null)
					{
						num = 15;
						break;
					}
					goto case 4;
				case 24:
					obj = Value.ToString();
					goto IL_0579;
				case 14:
					if (Value == null)
					{
						num2 = 12;
						continue;
					}
					return new CodePrimitiveExpression(Value.ToString());
				case 1:
					return new CodeObjectCreateExpression(tdXdSUR1xhAPn81kToL(typeof(DateTime).TypeHandle), new CodePrimitiveExpression(result3.Year), new CodePrimitiveExpression(result3.Month), new CodePrimitiveExpression(result3.Day), new CodePrimitiveExpression(result3.Hour), new CodePrimitiveExpression(result3.Minute), new CodePrimitiveExpression(result3.Second), new CodePrimitiveExpression(result3.Millisecond));
				case 18:
					if (Value == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 24;
				default:
					return new CodePrimitiveExpression(result2);
				case 21:
					long.TryParse(text, out result4);
					num2 = 9;
					continue;
				case 10:
					double.TryParse((string)HGowrBRDVdjim1dZ0e8(HGowrBRDVdjim1dZ0e8(text, hn7SynRPgVQjv8PDSJl(0x42643203 ^ 0x426460F3), currencyDecimalSeparator), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978480074), currencyDecimalSeparator), out result2);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					return new CodePrimitiveExpression("");
				case 15:
					if (Value.ToString() == SR.T((string)hn7SynRPgVQjv8PDSJl(0x3CE17B75 ^ 0x3CE12983)))
					{
						num2 = 16;
						continue;
					}
					goto case 19;
				case 22:
					if (!UWhu2oR3gUoodEVMLr3(text, hn7SynRPgVQjv8PDSJl(0x4D1C1EE4 ^ 0x4D1C4C14)))
					{
						num2 = 3;
						continue;
					}
					goto case 26;
				case 3:
					if (!UWhu2oR3gUoodEVMLr3(text, hn7SynRPgVQjv8PDSJl(0x57A5235E ^ 0x57A5399A)))
					{
						num2 = 21;
						continue;
					}
					goto case 26;
				case 7:
					if (DesignerType != MathConstantDesignerType.DateTime)
					{
						if (DesignerType == MathConstantDesignerType.LoadOrNull)
						{
							num2 = 17;
							continue;
						}
						if (DesignerType != 0)
						{
							if (DesignerType == MathConstantDesignerType.Digit)
							{
								num2 = 18;
								continue;
							}
							if (DesignerType == MathConstantDesignerType.Bool)
							{
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
								{
									num2 = 20;
								}
								continue;
							}
							goto IL_04a7;
						}
						num = 14;
						break;
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 6;
					}
					continue;
				case 19:
					if (Pt80PwRwWVMXH69Rp0Q(Value.ToString(), LYPPjpRt9Q1aedlQkGS(hn7SynRPgVQjv8PDSJl(0x63ABA4E8 ^ 0x63AB8D6C))))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num2 = 4;
						}
						continue;
					}
					if (Pt80PwRwWVMXH69Rp0Q(Value.ToString(), LYPPjpRt9Q1aedlQkGS(hn7SynRPgVQjv8PDSJl(0x7EC153F ^ 0x7EC3C43))))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto IL_04a7;
				case 17:
					if (Value == null)
					{
						num2 = 2;
						continue;
					}
					goto case 8;
				case 9:
					return new CodePrimitiveExpression(result4);
				case 4:
				case 16:
					return new CodePrimitiveExpression(false);
				case 25:
					s2 = Value.ToString();
					goto IL_0515;
				case 6:
					if (Value == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 25;
				case 11:
					return new CodePrimitiveExpression(true);
				case 23:
					return new CodeSnippetExpression((string)dH1Ps0RN0reHEn1Bicl(hn7SynRPgVQjv8PDSJl(-541731959 ^ -541753085), LeftOperatorType.ToString(), result));
				case 8:
					s = Value.ToString();
					goto IL_0547;
				case 5:
					s2 = hn7SynRPgVQjv8PDSJl(-2107978722 ^ -2107976814);
					goto IL_0515;
				case 2:
					s = hn7SynRPgVQjv8PDSJl(0x61EC0CB8 ^ 0x61EC1334);
					goto IL_0547;
				case 13:
					{
						obj = hn7SynRPgVQjv8PDSJl(0x1ECE530A ^ 0x1ECE4C86);
						goto IL_0579;
					}
					IL_0515:
					DateTime.TryParse((string)s2, out result3);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 1;
					}
					continue;
					IL_0547:
					long.TryParse((string)s, out result);
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 15;
					}
					continue;
					IL_0579:
					text = (string)obj;
					num = 22;
					break;
					IL_04a7:
					return null;
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
		return null;
	}

	internal static bool wfcrvcRkShtvCxpKcdU()
	{
		return PW1M7ERTIedSmjiT238 == null;
	}

	internal static ExactValueCodeItem C4mVyiRnQn6n1DxK38t()
	{
		return PW1M7ERTIedSmjiT238;
	}

	internal static bool OpfwO6ROq3bFx5VlRoU(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static Type DvoxJcR2AA2q1JZkdNb(object P_0)
	{
		return Type.GetType((string)P_0);
	}

	internal static object VvduyXReZquaObtcMIU(object P_0)
	{
		return ((CodeItem)P_0).ToCodeExpression();
	}

	internal static object hn7SynRPgVQjv8PDSJl(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type tdXdSUR1xhAPn81kToL(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object dH1Ps0RN0reHEn1Bicl(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool UWhu2oR3gUoodEVMLr3(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object sldbqURp9ksv5vp7fmT()
	{
		return CultureInfo.CurrentCulture;
	}

	internal static object aL2dlERa3xEL9GvpgNK(object P_0)
	{
		return ((CultureInfo)P_0).NumberFormat;
	}

	internal static object HGowrBRDVdjim1dZ0e8(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object LYPPjpRt9Q1aedlQkGS(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool Pt80PwRwWVMXH69Rp0Q(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
