using System;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Helpers;

public class RestrictionBuilderSelectAction<T> : RestrictionBuilderBase<T>
{
	private static object sDNsjHhcjlVO6sbZOvUo;

	public RestrictionBuilderSelectAction(RestrictionBuilderSelectType<T> baseRestrictionBuilder)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(baseRestrictionBuilder.restriction, baseRestrictionBuilder.restrictionsBuilder);
	}

	public void Ignore()
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
				restriction.RuleType = RuleType.Ignore;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Clone()
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
				restriction.RuleType = RuleType.Clone;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ByRef()
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
				restriction.RuleType = RuleType.CopyByRef;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Action(Func<object, object, CopyAction> action)
	{
		restriction.RuleType = RuleType.Action;
		restriction.Action = action;
	}

	internal static bool EqUN7jhcYvMtwyaI1ro6()
	{
		return sDNsjHhcjlVO6sbZOvUo == null;
	}

	internal static object Svw3yphcL8C2A3Gv3ZPW()
	{
		return sDNsjHhcjlVO6sbZOvUo;
	}
}
