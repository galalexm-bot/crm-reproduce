using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.ScriptDesigner.Enums;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using EleWise.ELMA.ScriptDesigner.TranslateData;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ScriptDesigner.CodeItems;

[Serializable]
[DisplayName(typeof(ResourcesForeachCodeItem), "DisplayName")]
public class IterationCodeItem : CompositeCodeItem
{
	[Component(Order = 54)]
	private class ToolboxItem : CyclesCodeItemToolBoxItem<IterationCodeItem>
	{
		internal static object FTy9JIfxmgCkyq0SlbVw;

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 2:
					base.ToolTipHeader = SR.T((string)G3SVDsfxJiumDysDn2eN(-70007027 ^ -70019785));
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num = 0;
					}
					break;
				case 1:
				{
					base.ToolTipBody = (string)GJU96ofx9dxe92k75NkF(G3SVDsfxJiumDysDn2eN(-583745292 ^ -583949198));
					int num2 = 2;
					num = num2;
					break;
				}
				case 0:
					return;
				}
			}
		}

		internal static object G3SVDsfxJiumDysDn2eN(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object GJU96ofx9dxe92k75NkF(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool oVC70Efxy2ek4ufS75y5()
		{
			return FTy9JIfxmgCkyq0SlbVw == null;
		}

		internal static ToolboxItem vHStnFfxMXdvZ8O34lSl()
		{
			return (ToolboxItem)FTy9JIfxmgCkyq0SlbVw;
		}
	}

	private static IterationCodeItem MFUINhi9HHZ8On8yrVJ;

	public VariableCodeItem LocalVariableCodeItem
	{
		[CompilerGenerated]
		get
		{
			return _003CLocalVariableCodeItem_003Ek__BackingField;
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
					_003CLocalVariableCodeItem_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
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

	public CycleType CycleType
	{
		[CompilerGenerated]
		get
		{
			return _003CCycleType_003Ek__BackingField;
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
					_003CCycleType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
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

	public CodeItem CollectionVariableCodeItem
	{
		[CompilerGenerated]
		get
		{
			return _003CCollectionVariableCodeItem_003Ek__BackingField;
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
					_003CCollectionVariableCodeItem_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
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

	public VariableCodeItemToolBoxItem LocalVariableCodeItemPoint
	{
		[CompilerGenerated]
		get
		{
			return _003CLocalVariableCodeItemPoint_003Ek__BackingField;
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
					_003CLocalVariableCodeItemPoint_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
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

	public IterationCodeItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pTjrPOir8VrkZDxgnhZ();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				CycleType = CycleType.NotSelected;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override bool IsValidParent(ICodeItem compositeCodeItem)
	{
		//Discarded unreachable code: IL_00a0, IL_00af
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (compositeCodeItem is IfCodeItem)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			default:
				return compositeCodeItem is IterationCodeItem;
			case 4:
				return true;
			case 2:
				if (!(compositeCodeItem is RootCodeItem))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 3:
				if (!(compositeCodeItem is ElseCodeItem))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public override CodeStatement ToCodeStatement()
	{
		//Discarded unreachable code: IL_00f7, IL_0101, IL_017b, IL_018a, IL_01da, IL_01ed, IL_032f, IL_0339, IL_040f, IL_0422, IL_0431, IL_045a, IL_0469, IL_048e, IL_049d, IL_0582, IL_0595
		int num = 8;
		VariableCodeItem variableCodeItem2 = default(VariableCodeItem);
		VariableCodeItem variableCodeItem = default(VariableCodeItem);
		CodeIterationStatement codeIterationStatement = default(CodeIterationStatement);
		List<CodeItem>.Enumerator enumerator = default(List<CodeItem>.Enumerator);
		CodeStatement codeStatement = default(CodeStatement);
		string text = default(string);
		string randomName = default(string);
		CodeStatement codeStatement3 = default(CodeStatement);
		CodeExpressionStatement codeExpressionStatement = default(CodeExpressionStatement);
		CodeStatement codeStatement2 = default(CodeStatement);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (variableCodeItem2 != null)
					{
						num2 = 29;
						continue;
					}
					goto IL_072d;
				case 24:
					if (variableCodeItem == null)
					{
						num2 = 3;
						continue;
					}
					goto case 26;
				case 12:
					return codeIterationStatement;
				case 3:
					if (CycleType == CycleType.Foreach)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto IL_072d;
				case 21:
					try
					{
						while (true)
						{
							IL_0127:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
								{
									num3 = 0;
								}
								goto IL_0105;
							}
							goto IL_014d;
							IL_014d:
							codeStatement = (CodeStatement)j3VtiDigHLMi7xuKbFl(enumerator.Current);
							num3 = 3;
							goto IL_0105;
							IL_0105:
							while (true)
							{
								switch (num3)
								{
								case 2:
								case 4:
									goto IL_0127;
								case 5:
									goto IL_014d;
								case 3:
									if (codeStatement == null)
									{
										num3 = 4;
										continue;
									}
									goto case 1;
								case 1:
									X0jVjPij3VwiwFp4ib8(sjaAMwi5ROLFd55nPnR(codeIterationStatement), codeStatement);
									num3 = 2;
									continue;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 4;
				case 25:
					vddaGcisuMtGHY4xfiD(codeIterationStatement, new CodeExpressionStatement(new CodeSnippetExpression((string)rwTLV1icg9ToeLSFghw(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309651872), text, OLe1sRRWBrTpvJiQ8OU(variableCodeItem2)))));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 5;
					}
					continue;
				case 14:
					enumerator = base.Items.GetEnumerator();
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 11;
					}
					continue;
				case 33:
					randomName = CodeItemCodeGenerator.GetRandomName();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					iqQ7MlizDsOJ6BAe3tx(codeIterationStatement, CollectionVariableCodeItem.ToCodeExpression());
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 4;
					}
					continue;
				case 30:
					variableCodeItem2 = CollectionVariableCodeItem as VariableCodeItem;
					num2 = 5;
					continue;
				case 19:
					text = (string)yPcU5QRFvXJcMUFPqGV();
					num2 = 30;
					continue;
				case 23:
					return codeIterationStatement;
				case 11:
					return null;
				case 26:
					enumerator = base.Items.GetEnumerator();
					num2 = 32;
					continue;
				case 17:
					if (CollectionVariableCodeItem != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto IL_072b;
				case 32:
					try
					{
						while (true)
						{
							IL_0394:
							int num8;
							if (!enumerator.MoveNext())
							{
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
								{
									num8 = 1;
								}
								goto IL_033d;
							}
							goto IL_036c;
							IL_036c:
							codeStatement3 = (CodeStatement)j3VtiDigHLMi7xuKbFl(enumerator.Current);
							num8 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
							{
								num8 = 3;
							}
							goto IL_033d;
							IL_033d:
							while (true)
							{
								switch (num8)
								{
								case 4:
									if (codeStatement3 != null)
									{
										num8 = 3;
										continue;
									}
									goto IL_0394;
								case 2:
									break;
								default:
									goto IL_0394;
								case 3:
									X0jVjPij3VwiwFp4ib8(sjaAMwi5ROLFd55nPnR(codeIterationStatement), codeStatement3);
									num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
									{
										num8 = 0;
									}
									continue;
								case 1:
									goto end_IL_0394;
								}
								break;
							}
							goto IL_036c;
							continue;
							end_IL_0394:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
					goto case 27;
				case 2:
					X0jVjPij3VwiwFp4ib8(sjaAMwi5ROLFd55nPnR(codeIterationStatement), codeExpressionStatement);
					num2 = 14;
					continue;
				case 8:
					codeIterationStatement = new CodeIterationStatement();
					num = 7;
					break;
				case 28:
					try
					{
						while (true)
						{
							int num6;
							if (!enumerator.MoveNext())
							{
								int num5 = 3;
								num6 = num5;
								goto IL_04ac;
							}
							goto IL_052e;
							IL_04ac:
							while (true)
							{
								switch (num6)
								{
								case 1:
									if (codeStatement2 != null)
									{
										num6 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
										{
											num6 = 0;
										}
										continue;
									}
									break;
								case 4:
									break;
								case 2:
									X0jVjPij3VwiwFp4ib8(sjaAMwi5ROLFd55nPnR(codeIterationStatement), codeStatement2);
									num6 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
									{
										num6 = 4;
									}
									continue;
								default:
									goto IL_052e;
								case 3:
									goto end_IL_04eb;
								}
								break;
							}
							continue;
							IL_052e:
							codeStatement2 = enumerator.Current.ToCodeStatement();
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
							{
								num6 = 1;
							}
							goto IL_04ac;
							continue;
							end_IL_04eb:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 31;
				case 1:
					if (LocalVariableCodeItem != null)
					{
						num2 = 19;
						continue;
					}
					goto IL_072b;
				case 18:
					if (CollectionVariableCodeItem == null)
					{
						return null;
					}
					num2 = 20;
					continue;
				case 20:
					enumerator = base.Items.GetEnumerator();
					num2 = 28;
					continue;
				case 15:
					iqQ7MlizDsOJ6BAe3tx(codeIterationStatement, new CodeSnippetExpression(string.Format((string)cAbZ4DiYYwxX0QVO00B(-195614443 ^ -195593457), text)));
					num = 16;
					break;
				case 13:
					vddaGcisuMtGHY4xfiD(codeIterationStatement, new CodeExpressionStatement(new CodeSnippetExpression((string)FR5txLiLwEDCUVvhCvn(cAbZ4DiYYwxX0QVO00B(-29254301 ^ -29242339), randomName))));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 10;
					}
					continue;
				case 9:
					if (CollectionVariableCodeItem == null)
					{
						return null;
					}
					num2 = 33;
					continue;
				case 7:
					if (CycleType == CycleType.For)
					{
						num2 = 9;
						continue;
					}
					goto case 3;
				case 29:
					codeExpressionStatement = new CodeExpressionStatement(new CodeSnippetExpression(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477152140), GRSocfRBuR4QcuvCO9w(LocalVariableCodeItem).FullName, LocalVariableCodeItem.VariableName, text)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 2;
					}
					continue;
				case 22:
					vddaGcisuMtGHY4xfiD(codeIterationStatement, new CodeExpressionStatement(new CodeSnippetExpression()));
					num2 = 6;
					continue;
				case 31:
					codeIterationStatement.IncrementStatement = new CodeExpressionStatement(new CodeSnippetExpression());
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 13;
					}
					continue;
				case 16:
					return codeIterationStatement;
				default:
					variableCodeItem = CollectionVariableCodeItem as VariableCodeItem;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 24;
					}
					continue;
				case 4:
					Y4eG4iiUwvyj39dNJ1Q(codeIterationStatement, new CodeExpressionStatement(new CodeSnippetExpression()));
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 7;
					}
					continue;
				case 10:
					iqQ7MlizDsOJ6BAe3tx(codeIterationStatement, new CodeSnippetExpression((string)rwTLV1icg9ToeLSFghw(cAbZ4DiYYwxX0QVO00B(0x7EC153F ^ 0x7EC44A7), randomName, variableCodeItem.VariableName)));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 12;
					}
					continue;
				case 27:
					{
						Y4eG4iiUwvyj39dNJ1Q(codeIterationStatement, new CodeExpressionStatement(new CodeSnippetExpression((string)FR5txLiLwEDCUVvhCvn(cAbZ4DiYYwxX0QVO00B(0x2A7797B7 ^ 0x2A77C6C7), randomName))));
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					IL_072d:
					if (CycleType != 0)
					{
						num = 11;
						break;
					}
					goto case 18;
					IL_072b:
					return null;
				}
				break;
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
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(codeItem is IfCodeItem))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				if (!(codeItem is AssignCodeItem))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				return codeItem is IterationCodeItem;
			}
			break;
		}
		return true;
	}

	internal static void pTjrPOir8VrkZDxgnhZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool H72nRGidN6Ml4BrS2ek()
	{
		return MFUINhi9HHZ8On8yrVJ == null;
	}

	internal static IterationCodeItem AlOlcnil6ybXnw7QLhi()
	{
		return MFUINhi9HHZ8On8yrVJ;
	}

	internal static object j3VtiDigHLMi7xuKbFl(object P_0)
	{
		return ((CodeItem)P_0).ToCodeStatement();
	}

	internal static object sjaAMwi5ROLFd55nPnR(object P_0)
	{
		return ((CodeIterationStatement)P_0).Statements;
	}

	internal static int X0jVjPij3VwiwFp4ib8(object P_0, object P_1)
	{
		return ((CodeStatementCollection)P_0).Add((CodeStatement)P_1);
	}

	internal static object cAbZ4DiYYwxX0QVO00B(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object FR5txLiLwEDCUVvhCvn(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void Y4eG4iiUwvyj39dNJ1Q(object P_0, object P_1)
	{
		((CodeIterationStatement)P_0).IncrementStatement = (CodeStatement)P_1;
	}

	internal static void vddaGcisuMtGHY4xfiD(object P_0, object P_1)
	{
		((CodeIterationStatement)P_0).InitStatement = (CodeStatement)P_1;
	}

	internal static object rwTLV1icg9ToeLSFghw(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void iqQ7MlizDsOJ6BAe3tx(object P_0, object P_1)
	{
		((CodeIterationStatement)P_0).TestExpression = (CodeExpression)P_1;
	}

	internal static object yPcU5QRFvXJcMUFPqGV()
	{
		return CodeItemCodeGenerator.GetRandomName();
	}

	internal static Type GRSocfRBuR4QcuvCO9w(object P_0)
	{
		return ((VariableCodeItem)P_0).VariableType;
	}

	internal static object OLe1sRRWBrTpvJiQ8OU(object P_0)
	{
		return ((VariableCodeItem)P_0).VariableName;
	}
}
