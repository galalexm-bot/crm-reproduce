using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ScriptDesigner.CodeItems;

[Serializable]
[DisplayName(typeof(ResourcesIfConditionCodeItem), "DisplayName")]
public class IfConditionCodeItem : CompositeCodeItem
{
	internal static IfConditionCodeItem jg9oh0qhHWIH1ZBE2pF;

	public IfConditionCodeItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
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
		return compositeCodeItem is IfCodeItem;
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
				codeExpression = ToCodeExpression();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return new CodeExpressionStatement(codeExpression);
			}
			if (codeExpression != null)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			return null;
		}
	}

	public override CodeExpression ToCodeExpression()
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		CodeItem codeItem = default(CodeItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (CodeExpression)MtnqWmqf7MWIsPR0dZ9(codeItem);
				case 1:
					return null;
				case 2:
					if (codeItem == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				case 3:
					break;
				}
				break;
			}
			codeItem = base.Items.FirstOrDefault();
			num = 2;
		}
	}

	public override CodeStatement[] ToCodeStatementList()
	{
		return null;
	}

	public override List<Type> GetValidToInsert()
	{
		return new List<Type>
		{
			typeof(ConditionCodeItem),
			typeof(AndOrCodeItem)
		};
	}

	public override bool IsValidChild(ICodeItem codeItem)
	{
		return codeItem is ConditionCodeItem;
	}

	public override void InitNew(ICodeItem parent)
	{
		int num = 3;
		int num2 = num;
		ConditionCodeItem conditionCodeItem = default(ConditionCodeItem);
		while (true)
		{
			switch (num2)
			{
			case 4:
				base.Items.Add(conditionCodeItem);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 2:
				conditionCodeItem = new ConditionCodeItem();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				base.InitNew(parent);
				num2 = 2;
				break;
			default:
				xpQ9pxqQDKsmUhHhxMx(conditionCodeItem, this);
				num2 = 4;
				break;
			}
		}
	}

	internal static bool dS8M6VqGP1vF8oNarLk()
	{
		return jg9oh0qhHWIH1ZBE2pF == null;
	}

	internal static IfConditionCodeItem NwCkKmqE9Av7r2KQnUV()
	{
		return jg9oh0qhHWIH1ZBE2pF;
	}

	internal static object MtnqWmqf7MWIsPR0dZ9(object P_0)
	{
		return ((CodeItem)P_0).ToCodeExpression();
	}

	internal static void xpQ9pxqQDKsmUhHhxMx(object P_0, object P_1)
	{
		((CodeItem)P_0).InitNew((ICodeItem)P_1);
	}
}
