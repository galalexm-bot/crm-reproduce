using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ScriptDesigner.CodeItems;

[Serializable]
[DisplayName(typeof(ResourcesIfCodeItem), "DisplayName")]
public class IfCodeItem : CompositeCodeItem
{
	[Component(Order = 53)]
	private class ToolboxItem : LogicalCodeItemToolBoxItem<IfCodeItem>
	{
		internal static object u4mPOtfxshuZk8a5aZVQ;

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_001a, IL_001f
			BK9DgWf0FJFgV9s7pdgy();
			base._002Ector();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					base.ToolTipBody = (string)B3lMlHf0WCVUE05PPKrD(GIG9ahf0B4UfF0UKl0aj(-1710575414 ^ -1710238256));
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num = 0;
					}
					break;
				default:
					base.ToolTipHeader = (string)B3lMlHf0WCVUE05PPKrD(GIG9ahf0B4UfF0UKl0aj(0x63ABA4E8 ^ 0x63ABF7C0));
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num = 0;
					}
					break;
				case 1:
					return;
				}
			}
		}

		internal static void BK9DgWf0FJFgV9s7pdgy()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object GIG9ahf0B4UfF0UKl0aj(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object B3lMlHf0WCVUE05PPKrD(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool PYgJAdfxcasiVleYHSom()
		{
			return u4mPOtfxshuZk8a5aZVQ == null;
		}

		internal static ToolboxItem zPuLP8fxzMiSYBOPdq29()
		{
			return (ToolboxItem)u4mPOtfxshuZk8a5aZVQ;
		}
	}

	internal static IfCodeItem r0gQWeRd2e3frMJmxD3;

	public ElseCodeItem Else
	{
		[CompilerGenerated]
		get
		{
			return _003CElse_003Ek__BackingField;
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
					_003CElse_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IfCodeItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		glLpZuRgTvGtE26ndtt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
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
		//Discarded unreachable code: IL_007f, IL_008e
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!(compositeCodeItem is RootCodeItem))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 1:
				if (!(compositeCodeItem is IfCodeItem))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				if (compositeCodeItem is ElseCodeItem)
				{
					num2 = 4;
					continue;
				}
				goto case 3;
			case 3:
				return compositeCodeItem is IterationCodeItem;
			case 4:
				break;
			}
			break;
		}
		return true;
	}

	public override CodeStatement ToCodeStatement()
	{
		//Discarded unreachable code: IL_0072, IL_0081, IL_008c, IL_0169, IL_017c, IL_018b, IL_01b7, IL_01c6, IL_01d1, IL_02b3, IL_02eb, IL_02fa, IL_031f, IL_0332, IL_0432
		int num = 18;
		int num2 = num;
		List<CodeItem>.Enumerator enumerator = default(List<CodeItem>.Enumerator);
		CodeStatement[] array = default(CodeStatement[]);
		List<CodeStatement> list2 = default(List<CodeStatement>);
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		IEnumerator<CodeItem> enumerator2 = default(IEnumerator<CodeItem>);
		List<CodeStatement> list = default(List<CodeStatement>);
		CodeStatement[] array2 = default(CodeStatement[]);
		while (true)
		{
			switch (num2)
			{
			case 11:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;
							goto IL_0090;
						}
						goto IL_00f8;
						IL_0090:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								if (array != null)
								{
									num3 = 3;
									continue;
								}
								break;
							case 3:
								list2.AddRange(array);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
								{
									num3 = 1;
								}
								continue;
							case 2:
								goto IL_00f8;
							case 4:
								goto end_IL_00ae;
							}
							break;
						}
						continue;
						IL_00f8:
						CodeItem current = enumerator.Current;
						CodeStatement codeStatement = (CodeStatement)PGiHZhRjqEeuMDCmKf7(current);
						if (codeStatement != null)
						{
							list2.Add(codeStatement);
						}
						array = (CodeStatement[])W5ArfIRYHe3lTZgGgjT(current);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num3 = 0;
						}
						goto IL_0090;
						continue;
						end_IL_00ae:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 12;
			case 13:
				if (jA4G0xR5NRR80D9yNtx(_003C_003Ec__DisplayClass7_.conditionItem) == null)
				{
					num2 = 15;
					continue;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						int num5;
						if (!YBHw2QRL2aJ8UV3HaB6(enumerator2))
						{
							num5 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
							{
								num5 = 0;
							}
							goto IL_01d5;
						}
						goto IL_024d;
						IL_024d:
						CodeItem current2 = enumerator2.Current;
						CodeStatement codeStatement2 = (CodeStatement)PGiHZhRjqEeuMDCmKf7(current2);
						if (codeStatement2 != null)
						{
							list.Add(codeStatement2);
						}
						array2 = (CodeStatement[])W5ArfIRYHe3lTZgGgjT(current2);
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num5 = 4;
						}
						goto IL_01d5;
						IL_01d5:
						while (true)
						{
							switch (num5)
							{
							case 4:
								if (array2 != null)
								{
									num5 = 3;
									continue;
								}
								break;
							case 1:
								break;
							case 3:
								list.AddRange(array2);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
								{
									num5 = 1;
								}
								continue;
							default:
								goto IL_024d;
							case 2:
								goto end_IL_0204;
							}
							break;
						}
						continue;
						end_IL_0204:
						break;
					}
				}
				finally
				{
					if (enumerator2 != null)
					{
						int num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								RcNHkDRU9Sd70mJsfyq(enumerator2);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
								{
									num6 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto default;
			case 4:
				if (Else == null)
				{
					num2 = 7;
					continue;
				}
				goto case 2;
			case 12:
			case 19:
				if (JClpVmRsLMyRCR3yKPp(list) == 0)
				{
					num2 = 3;
					continue;
				}
				goto case 4;
			case 8:
				if (Else.Items.Any())
				{
					num2 = 9;
					continue;
				}
				goto case 12;
			case 2:
				if (JClpVmRsLMyRCR3yKPp(list2) == 0)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 6;
			case 18:
				_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
				num2 = 17;
				continue;
			case 16:
				list2 = new List<CodeStatement>();
				num2 = 13;
				continue;
			default:
				if (Else == null)
				{
					num2 = 12;
					continue;
				}
				goto case 8;
			case 14:
				list = new List<CodeStatement>();
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 16;
				}
				continue;
			case 6:
			case 7:
				return new CodeConditionStatement(_003C_003Ec__DisplayClass7_.conditionItem.ToCodeExpression(), (CodeStatement[])ojSnUCRcjZdGKgq89Pr(list), (CodeStatement[])ojSnUCRcjZdGKgq89Pr(list2));
			case 15:
				return null;
			case 9:
				enumerator = Else.Items.GetEnumerator();
				num2 = 11;
				continue;
			case 3:
				list.Add(new CodeSnippetStatement(""));
				num2 = 4;
				continue;
			case 5:
				list2.Add(new CodeSnippetStatement(""));
				num2 = 6;
				continue;
			case 17:
				_003C_003Ec__DisplayClass7_.conditionItem = base.Items.FirstOrDefault((CodeItem a) => a is IfConditionCodeItem);
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 0;
				}
				continue;
			case 10:
				break;
			}
			enumerator2 = base.Items.Where(_003C_003Ec__DisplayClass7_._003CToCodeStatement_003Eb__1).GetEnumerator();
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
			{
				num2 = 0;
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
			typeof(AssignCodeItem),
			typeof(IfCodeItem),
			typeof(IterationCodeItem)
		};
	}

	public override bool IsValidChild(ICodeItem codeItem)
	{
		//Discarded unreachable code: IL_005a, IL_0069, IL_0085, IL_0094
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (codeItem is AssignCodeItem)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				return codeItem is IterationCodeItem;
			default:
				return true;
			case 3:
				if (codeItem is IfCodeItem)
				{
					num2 = 2;
					break;
				}
				goto case 4;
			}
		}
	}

	public override void InitNew(ICodeItem parent)
	{
		int num = 1;
		int num2 = num;
		IfConditionCodeItem ifConditionCodeItem = default(IfConditionCodeItem);
		while (true)
		{
			switch (num2)
			{
			case 2:
				base.Items.Add(ifConditionCodeItem);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 4;
				}
				continue;
			case 4:
				return;
			case 1:
				base.InitNew(parent);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				ifConditionCodeItem = new IfConditionCodeItem();
				num2 = 5;
				continue;
			case 5:
				yx9pPDRz4KEv9wUwpLO(ifConditionCodeItem, this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 2;
				}
				continue;
			}
			if (base.Items.Any((CodeItem a) => a is IfConditionCodeItem))
			{
				return;
			}
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
			{
				num2 = 3;
			}
		}
	}

	internal static void glLpZuRgTvGtE26ndtt()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Dus3CLRlcD95HPbJxub()
	{
		return r0gQWeRd2e3frMJmxD3 == null;
	}

	internal static IfCodeItem NvhlerRriHWBmBlfL9i()
	{
		return r0gQWeRd2e3frMJmxD3;
	}

	internal static object jA4G0xR5NRR80D9yNtx(object P_0)
	{
		return ((CodeItem)P_0).ToCodeExpression();
	}

	internal static object PGiHZhRjqEeuMDCmKf7(object P_0)
	{
		return ((CodeItem)P_0).ToCodeStatement();
	}

	internal static object W5ArfIRYHe3lTZgGgjT(object P_0)
	{
		return ((CodeItem)P_0).ToCodeStatementList();
	}

	internal static bool YBHw2QRL2aJ8UV3HaB6(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void RcNHkDRU9Sd70mJsfyq(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int JClpVmRsLMyRCR3yKPp(object P_0)
	{
		return ((List<CodeStatement>)P_0).Count;
	}

	internal static object ojSnUCRcjZdGKgq89Pr(object P_0)
	{
		return ((List<CodeStatement>)P_0).ToArray();
	}

	internal static void yx9pPDRz4KEv9wUwpLO(object P_0, object P_1)
	{
		((CodeItem)P_0).InitNew((ICodeItem)P_1);
	}
}
