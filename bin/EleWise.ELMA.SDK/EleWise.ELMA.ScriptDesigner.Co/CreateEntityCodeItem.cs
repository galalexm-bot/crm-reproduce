using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using EleWise.ELMA.ScriptDesigner.TranslateData;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ScriptDesigner.CodeItems;

[Serializable]
[DisplayName(typeof(ResourcesActionCodeItem), "DisplayName")]
public class CreateEntityCodeItem : CompositeCodeItem
{
	internal class ResourcesCreateEntityCodeItem
	{
		internal static ResourcesCreateEntityCodeItem ovMxLafxkihdkyu38qxo;

		public static string DisplayName => (string)lWBUcmfxeEN9bb0Ccg0j(vXFThGfx27RBbCoYBZym(0x6DC147B0 ^ 0x6DC423A2));

		public ResourcesCreateEntityCodeItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			b6Sg2CfxPKMl048APY6u();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object vXFThGfx27RBbCoYBZym(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object lWBUcmfxeEN9bb0Ccg0j(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool vOeNElfxnvqxFx50hLUk()
		{
			return ovMxLafxkihdkyu38qxo == null;
		}

		internal static ResourcesCreateEntityCodeItem s6CusFfxOEHnRhqWGCBN()
		{
			return ovMxLafxkihdkyu38qxo;
		}

		internal static void b6Sg2CfxPKMl048APY6u()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	internal static CreateEntityCodeItem op6QvWSYx6QFOSOqhmJ;

	public string DisplayName
	{
		[CompilerGenerated]
		get
		{
			return _003CDisplayName_003Ek__BackingField;
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
					_003CDisplayName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
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

	public List<DesignerParameterInfo> Parameters { get; set; }

	public NewCodeItemToolBoxItem VariableCodeItemToolBoxItem
	{
		[CompilerGenerated]
		get
		{
			return _003CVariableCodeItemToolBoxItem_003Ek__BackingField;
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
					_003CVariableCodeItemToolBoxItem_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CreateEntityCodeItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YDLe35Ss468pbj54hB1();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
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
				Parameters = new List<DesignerParameterInfo>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override bool IsValidParent(ICodeItem codeItem)
	{
		//Discarded unreachable code: IL_008b, IL_009a
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(codeItem is ElseCodeItem))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			default:
				if (!(codeItem is IfCodeItem))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 2:
				return codeItem is IterationCodeItem;
			case 3:
				return true;
			case 4:
				if (codeItem is RootCodeItem)
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	public override CodeStatement ToCodeStatement()
	{
		return null;
	}

	public CodeStatement[] GetPropertiesStatements(string variableName)
	{
		//Discarded unreachable code: IL_007e, IL_0088, IL_00b7, IL_00c6, IL_01c8, IL_01db
		int num = 5;
		int num2 = num;
		List<DesignerParameterInfo>.Enumerator enumerator = default(List<DesignerParameterInfo>.Enumerator);
		List<CodeStatement> list = default(List<CodeStatement>);
		DesignerParameterInfo current = default(DesignerParameterInfo);
		CodeAssignStatement item = default(CodeAssignStatement);
		CodeCommentStatement item2 = default(CodeCommentStatement);
		while (true)
		{
			switch (num2)
			{
			case 2:
				enumerator = Parameters.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return (CodeStatement[])Qbn079iofF2QlHBvT5P(list);
			case 5:
				list = new List<CodeStatement>();
				num2 = 4;
				break;
			case 1:
				try
				{
					while (true)
					{
						IL_0173:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 5;
							goto IL_008c;
						}
						goto IL_00d1;
						IL_008c:
						while (true)
						{
							switch (num3)
							{
							case 4:
								break;
							default:
							{
								CodeSnippetExpression left = new CodeSnippetExpression((string)El8njXiBwWXW9EExWTV(v44IBiScQ0PBqFpaTBZ(-787452571 ^ -787468441), variableName, kwqoAQiFQOA09HwTXGb(current)));
								CodeSnippetExpression right = new CodeSnippetExpression((string)RSZogLiW2v8UrcPbaG3(v44IBiScQ0PBqFpaTBZ(-1998538950 ^ -1998523216), current.SelectedValueName));
								item = new CodeAssignStatement(left, right);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
								{
									num3 = 2;
								}
								continue;
							}
							case 1:
								if (!RnIVInSzQhlWWHtshdS(current))
								{
									num3 = 6;
									continue;
								}
								goto default;
							case 3:
							case 6:
								goto IL_0173;
							case 2:
								list.Add(item);
								num3 = 3;
								continue;
							case 5:
								goto end_IL_0173;
							}
							break;
						}
						goto IL_00d1;
						IL_00d1:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num3 = 1;
						}
						goto IL_008c;
						continue;
						end_IL_0173:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 3;
			default:
				item2 = new CodeCommentStatement(SR.T((string)v44IBiScQ0PBqFpaTBZ(-812025778 ^ -812046304), VariableCodeItemToolBoxItem.DisplayName));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				list.Add(item2);
				num2 = 2;
				break;
			case 4:
				if (Parameters.Any((DesignerParameterInfo a) => _003C_003Ec.LxbOMqfxaeLr7tshAAhW(a)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public override CodeExpression ToCodeExpression()
	{
		return null;
	}

	public override CodeStatement[] ToCodeStatementList()
	{
		//Discarded unreachable code: IL_01e3, IL_01f2, IL_02a9
		int num = 20;
		List<CodeStatement> list = default(List<CodeStatement>);
		CodeCommentStatement item = default(CodeCommentStatement);
		string text = default(string);
		CodeExpression initExpression = default(CodeExpression);
		CodeMethodInvokeExpression expression = default(CodeMethodInvokeExpression);
		string variableName = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					list.Add(item);
					num2 = 5;
					continue;
				case 16:
					break;
				case 21:
					list.Add(new CodeSnippetStatement());
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 10;
					}
					continue;
				case 13:
					list.Add(new CodeCommentStatement(SR.T((string)v44IBiScQ0PBqFpaTBZ(-1921202237 ^ -1921214703), text)));
					num2 = 12;
					continue;
				case 12:
					list.Add(new CodeVariableDeclarationStatement(new CodeTypeReference((string)v44IBiScQ0PBqFpaTBZ(-882126494 ^ -882141898)), text, initExpression));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
					list.Add(new CodeExpressionStatement(expression));
					num2 = 21;
					continue;
				case 14:
					text = (string)RSZogLiW2v8UrcPbaG3(v44IBiScQ0PBqFpaTBZ(-1822890472 ^ -1822902614), Ae9LhkiG5U55ppSw3AD(ver0mGihWaYNOiAvN4i(qRN7VpibJIsJnFpdo6T(VariableCodeItemToolBoxItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA597AFF), "")));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					list.Add(new CodeExpressionStatement(new CodeMethodInvokeExpression(new CodeVariableReferenceExpression(text), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA596897))));
					num2 = 18;
					continue;
				case 5:
					expression = new CodeMethodInvokeExpression(new CodeVariableReferenceExpression(variableName), (string)v44IBiScQ0PBqFpaTBZ(-2107978722 ^ -2107994424));
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 8;
					}
					continue;
				case 4:
					initExpression = (CodeExpression)LvcmkViEIoDo4jreHLU(VariableCodeItemToolBoxItem);
					num2 = 9;
					continue;
				case 8:
					list.Add(new CodeSnippetStatement());
					num2 = 22;
					continue;
				case 9:
					list.Add(new CodeSnippetStatement());
					num2 = 13;
					continue;
				case 7:
				case 10:
					return (CodeStatement[])Qbn079iofF2QlHBvT5P(list);
				case 22:
					list.AddRange(GetPropertiesStatements(variableName));
					num2 = 16;
					continue;
				case 18:
					list.Add(new CodeAssignStatement(new CodeVariableReferenceExpression(VariableCodeItemToolBoxItem.VariableName), new CodeVariableReferenceExpression(text)));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
				case 11:
					variableName = (string)qRN7VpibJIsJnFpdo6T(VariableCodeItemToolBoxItem);
					num2 = 8;
					continue;
				case 6:
					list.Add(new CodeSnippetStatement());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 7;
					}
					continue;
				case 15:
					list.Add(new CodeCommentStatement(SR.T((string)v44IBiScQ0PBqFpaTBZ(-420743386 ^ -420764102), VariableCodeItemToolBoxItem.DisplayName)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 19:
					if (!(VariableCodeItemToolBoxItem is ContextVariableCodeItemToolBoxItem))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 14;
				case 1:
					list.AddRange(GetPropertiesStatements(text));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 13;
					}
					continue;
				case 20:
					list = new List<CodeStatement>();
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 14;
					}
					continue;
				}
				break;
			}
			item = new CodeCommentStatement(SR.T((string)v44IBiScQ0PBqFpaTBZ(-289714582 ^ -289726602), rsNjeNifI66GvmRLs8H(VariableCodeItemToolBoxItem)));
			num = 2;
		}
	}

	public override List<Type> GetValidToInsert()
	{
		return new List<Type>
		{
			typeof(VariableCodeItem),
			typeof(MathCodeItem),
			typeof(ExactValueCodeItem)
		};
	}

	public override bool IsValidChild(ICodeItem codeItem)
	{
		return codeItem is VariableCodeItem;
	}

	internal static void YDLe35Ss468pbj54hB1()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool cohd6oSLbEnm6AVcMeJ()
	{
		return op6QvWSYx6QFOSOqhmJ == null;
	}

	internal static CreateEntityCodeItem wQJ4NQSUiWMeXx8g3yI()
	{
		return op6QvWSYx6QFOSOqhmJ;
	}

	internal static object v44IBiScQ0PBqFpaTBZ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool RnIVInSzQhlWWHtshdS(object P_0)
	{
		return ((DesignerParameterInfo)P_0).IsSelected;
	}

	internal static object kwqoAQiFQOA09HwTXGb(object P_0)
	{
		return ((DesignerParameterInfo)P_0).ParameterName;
	}

	internal static object El8njXiBwWXW9EExWTV(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object RSZogLiW2v8UrcPbaG3(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object Qbn079iofF2QlHBvT5P(object P_0)
	{
		return ((List<CodeStatement>)P_0).ToArray();
	}

	internal static object qRN7VpibJIsJnFpdo6T(object P_0)
	{
		return ((NewCodeItemToolBoxItem)P_0).VariableName;
	}

	internal static object ver0mGihWaYNOiAvN4i(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object Ae9LhkiG5U55ppSw3AD(object P_0)
	{
		return ((string)P_0).ToLowerFirstChar();
	}

	internal static object LvcmkViEIoDo4jreHLU(object P_0)
	{
		return CodeItemCodeGenerator.GetInitExpressionByType((NewCodeItemToolBoxItem)P_0);
	}

	internal static object rsNjeNifI66GvmRLs8H(object P_0)
	{
		return ((NewCodeItemToolBoxItem)P_0).DisplayName;
	}
}
