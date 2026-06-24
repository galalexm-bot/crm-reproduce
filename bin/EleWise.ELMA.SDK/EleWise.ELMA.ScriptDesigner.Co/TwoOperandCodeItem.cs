using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ScriptDesigner.Enums;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ScriptDesigner.CodeItems;

[Serializable]
public abstract class TwoOperandCodeItem : CompositeCodeItem, ITwoOperandCodeItem, ICompositeCodeItem, ICodeItem
{
	internal static TwoOperandCodeItem juDfjfiQFx3qquUMjpm;

	public CodeItem OperandOne
	{
		[CompilerGenerated]
		get
		{
			return _003COperandOne_003Ek__BackingField;
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
					_003COperandOne_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
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

	public CodeItem OperandTwo
	{
		[CompilerGenerated]
		get
		{
			return _003COperandTwo_003Ek__BackingField;
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
					_003COperandTwo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Operator
	{
		[CompilerGenerated]
		get
		{
			return _003COperator_003Ek__BackingField;
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
					_003COperator_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public abstract List<Type> GetTypesByOperand(OperandDirection direction);

	public abstract CodeBinaryOperatorType GetOperatorType();

	protected TwoOperandCodeItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dw6bFBi8hqYmmjyMRgd();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool TX284biCIdQTIfHB60Q()
	{
		return juDfjfiQFx3qquUMjpm == null;
	}

	internal static TwoOperandCodeItem VmZvT5ivcyvl0I8X8gQ()
	{
		return juDfjfiQFx3qquUMjpm;
	}

	internal static void dw6bFBi8hqYmmjyMRgd()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
