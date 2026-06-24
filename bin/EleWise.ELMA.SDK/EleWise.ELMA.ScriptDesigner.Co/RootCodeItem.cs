using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ScriptDesigner.CodeItems;

[Serializable]
public class RootCodeItem : CompositeCodeItem
{
	private static RootCodeItem J98RCaqePCkAC2bdLDw;

	public List<VariableCodeItemToolBoxItem> LocalVariables { get; set; }

	public List<VariableCodeItemToolBoxItem> IterationVariables { get; set; }

	public string SourceCode
	{
		[CompilerGenerated]
		get
		{
			return _003CSourceCode_003Ek__BackingField;
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
					_003CSourceCode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
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

	public string CompiledFileName
	{
		[CompilerGenerated]
		get
		{
			return _003CCompiledFileName_003Ek__BackingField;
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
					_003CCompiledFileName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
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

	public string ProjectName
	{
		[CompilerGenerated]
		get
		{
			return _003CProjectName_003Ek__BackingField;
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
					_003CProjectName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DateTime CreationDate
	{
		[CompilerGenerated]
		get
		{
			return _003CCreationDate_003Ek__BackingField;
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
					_003CCreationDate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DateTime ChangeTime
	{
		[CompilerGenerated]
		get
		{
			return _003CChangeTime_003Ek__BackingField;
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
					_003CChangeTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
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

	public long CreationAuthor
	{
		[CompilerGenerated]
		get
		{
			return _003CCreationAuthor_003Ek__BackingField;
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
					_003CCreationAuthor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ScriptMethodDeclaration MethodDeclaration
	{
		[CompilerGenerated]
		get
		{
			return _003CMethodDeclaration_003Ek__BackingField;
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
					_003CMethodDeclaration_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
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

	public RootCodeItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		W5L1C4qNWig7c9sjFRH();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				IterationVariables = new List<VariableCodeItemToolBoxItem>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			case 2:
				LocalVariables = new List<VariableCodeItemToolBoxItem>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override bool IsValidParent(ICodeItem compositeCodeItem)
	{
		return false;
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
			typeof(IfCodeItem),
			typeof(VariableCodeItem),
			typeof(AssignCodeItem),
			typeof(IterationCodeItem)
		};
	}

	public override bool IsValidChild(ICodeItem codeItem)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_0060, IL_006f
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return codeItem is IterationCodeItem;
			case 2:
			case 3:
				return true;
			case 4:
				if (codeItem is IfCodeItem)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 1;
			case 1:
				if (codeItem is AssignCodeItem)
				{
					num2 = 2;
					break;
				}
				goto default;
			}
		}
	}

	internal static void W5L1C4qNWig7c9sjFRH()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool uGuLtOqPZAWGeKnNnBV()
	{
		return J98RCaqePCkAC2bdLDw == null;
	}

	internal static RootCodeItem BSLqrYq1HNfmCoK9s3c()
	{
		return J98RCaqePCkAC2bdLDw;
	}
}
