using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ScriptDesigner.CodeItems;

public class BaseCodeItem : CodeItem
{
	internal static BaseCodeItem qaExJ4q31XEkfNLCOr4;

	public string VariableName
	{
		[CompilerGenerated]
		get
		{
			return _003CVariableName_003Ek__BackingField;
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
					_003CVariableName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
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

	public Type VariableType
	{
		[CompilerGenerated]
		get
		{
			return _003CVariableType_003Ek__BackingField;
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
					_003CVariableType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
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

	public BaseCodeItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WTbrfAqDxBosfDbtRtB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override bool IsValidParent(ICodeItem compositeCodeItem)
	{
		//Discarded unreachable code: IL_007e, IL_00a6, IL_00b5, IL_0114, IL_0138, IL_015c, IL_016b
		int num = 8;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!(compositeCodeItem is ConditionCodeItem))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 2;
				case 8:
					if (compositeCodeItem is RootCodeItem)
					{
						goto end_IL_0012;
					}
					goto case 3;
				case 13:
					if (!(compositeCodeItem is MathCodeItem))
					{
						num2 = 4;
						break;
					}
					goto case 2;
				case 9:
					if (compositeCodeItem is ElseCodeItem)
					{
						num2 = 2;
						break;
					}
					goto case 13;
				case 3:
					if (compositeCodeItem is IfCodeItem)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 10;
						}
						break;
					}
					goto case 1;
				case 6:
					if (compositeCodeItem is IfConditionCodeItem)
					{
						num2 = 11;
						break;
					}
					goto case 12;
				case 1:
					if (compositeCodeItem is AssignCodeItem)
					{
						num2 = 5;
						break;
					}
					goto default;
				case 12:
					return compositeCodeItem is IterationCodeItem;
				case 2:
				case 5:
				case 7:
				case 10:
				case 11:
					return true;
				case 4:
					if (!(compositeCodeItem is AndOrCodeItem))
					{
						num2 = 6;
						break;
					}
					goto case 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	public override CodeStatement ToCodeStatement()
	{
		return null;
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
		throw new NotImplementedException();
	}

	internal static void WTbrfAqDxBosfDbtRtB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool fKHmoFqp87LVQisvTpd()
	{
		return qaExJ4q31XEkfNLCOr4 == null;
	}

	internal static BaseCodeItem Hup8ptqa9C5EKsQnsik()
	{
		return qaExJ4q31XEkfNLCOr4;
	}
}
