using System;
using System.CodeDom;
using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ScriptDesigner.CodeItems;

[Serializable]
[DisplayName(typeof(ResourcesElseCodeItem), "DisplayName")]
public class ElseCodeItem : CompositeCodeItem
{
	private static ElseCodeItem lL1NXHi6QI0MN26V4fA;

	public ElseCodeItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EWT8Rci7sTSAshZDaly();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
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
		throw new NotImplementedException();
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
		return new List<Type>
		{
			typeof(AssignCodeItem),
			typeof(IfCodeItem),
			typeof(IterationCodeItem)
		};
	}

	public override bool IsValidChild(ICodeItem codeItem)
	{
		//Discarded unreachable code: IL_007b, IL_008a, IL_009a, IL_00a9
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (codeItem is AssignCodeItem)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return codeItem is IterationCodeItem;
			case 1:
			case 3:
				return true;
			case 4:
				if (codeItem is IfCodeItem)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	internal static void EWT8Rci7sTSAshZDaly()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool IcUwioiHkNpvGLs9I7x()
	{
		return lL1NXHi6QI0MN26V4fA == null;
	}

	internal static ElseCodeItem tEOiUjiAXVPdDfenO30()
	{
		return lL1NXHi6QI0MN26V4fA;
	}
}
