using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Scripts.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Formatting;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.Text;

namespace EleWise.ELMA.UIBuilder.Services;

[Service]
internal sealed class ScriptService : IScriptService
{
	private class DummyClass
	{
		public Type Reference => typeof(CSharpFormattingOptions);
	}

	private const string Indentation = "    ";

	private static readonly int TabSize = "    ".Length;

	public GenerateMethodCodeResponse GenerateMethodCode(GenerateMethodCodeRequest request)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		List<ClassDeclarationSyntax> source = CSharpSyntaxTree.ParseText(request.SourceCode, CSharpParseOptions.get_Default().WithLanguageVersion((LanguageVersion)7), "", (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken)).GetRoot(default(CancellationToken)).DescendantNodes((Func<SyntaxNode, bool>)null, false)
			.OfType<ClassDeclarationSyntax>()
			.ToList();
		ClassDeclarationSyntax val = source.FirstOrDefault(delegate(ClassDeclarationSyntax q)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			SyntaxToken identifier4 = ((BaseTypeDeclarationSyntax)q).get_Identifier();
			return ((object)(SyntaxToken)(ref identifier4)).ToString() == request.ClassName;
		});
		ClassDeclarationSyntax val2 = ((val != null) ? ((IEnumerable)(object)((TypeDeclarationSyntax)val).get_Members()).OfType<ClassDeclarationSyntax>().FirstOrDefault(delegate(ClassDeclarationSyntax q)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			SyntaxToken identifier3 = ((BaseTypeDeclarationSyntax)q).get_Identifier();
			return ((object)(SyntaxToken)(ref identifier3)).ToString() == "ComponentController";
		}) : null);
		if (val2 == null)
		{
			val2 = source.FirstOrDefault(delegate(ClassDeclarationSyntax q)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				SyntaxToken identifier2 = ((BaseTypeDeclarationSyntax)q).get_Identifier();
				return ((object)(SyntaxToken)(ref identifier2)).ToString() == "ComponentController";
			});
			if (val2 == null)
			{
				val2 = source.FirstOrDefault(delegate(ClassDeclarationSyntax q)
				{
					//IL_0001: Unknown result type (might be due to invalid IL or missing references)
					//IL_0006: Unknown result type (might be due to invalid IL or missing references)
					SyntaxToken identifier = ((BaseTypeDeclarationSyntax)q).get_Identifier();
					return ((object)(SyntaxToken)(ref identifier)).ToString() == "ViewModelController";
				}) ?? val;
				if (val2 == null)
				{
					return null;
				}
			}
		}
		SyntaxGenerator generator = SyntaxGenerator.GetGenerator((Workspace)new AdhocWorkspace(), "C#");
		TypeSyntax val3 = SyntaxFactory.ParseTypeName(request.ReturnType, 0, true);
		SyntaxNode[] array = (SyntaxNode[])(object)((!(request.ReturnValue != "")) ? null : new SyntaxNode[1] { generator.ReturnStatement((SyntaxNode)(object)SyntaxFactory.ParseExpression(request.ReturnValue, 0, (ParseOptions)null, true)) });
		IEnumerable<SyntaxNode> enumerable = request.Parameters.Select((ScriptMethodParameter param) => generator.ParameterDeclaration(param.Name, (SyntaxNode)(object)SyntaxFactory.ParseTypeName(param.Type, 0, true), (SyntaxNode)null, (RefKind)0));
		SyntaxNode obj = generator.MethodDeclaration(request.MethodName, enumerable, (IEnumerable<string>)null, (SyntaxNode)(object)val3, (Accessibility)6, DeclarationModifiers.get_None(), (IEnumerable<SyntaxNode>)array);
		MethodDeclarationSyntax val4 = (MethodDeclarationSyntax)(object)((obj is MethodDeclarationSyntax) ? obj : null);
		if (val4 == null)
		{
			return null;
		}
		int num = 1;
		SyntaxNode parent = ((SyntaxNode)val2).get_Parent();
		while (!(parent is CompilationUnitSyntax))
		{
			parent = parent.get_Parent();
			num++;
		}
		MemberDeclarationSyntax val5 = ((TypeDeclarationSyntax)val2).get_Members().LastOrDefault();
		string text = string.Concat(Enumerable.Repeat(' ', num * TabSize));
		string description = request.Description;
		if (!string.IsNullOrWhiteSpace(description))
		{
			SyntaxTrivia val6 = GenerateSummary(description, text);
			SyntaxTokenList val7 = SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxFactory.TriviaList((SyntaxTrivia[])(object)new SyntaxTrivia[4]
			{
				SyntaxFactory.get_LineFeed(),
				SyntaxFactory.Whitespace(text),
				val6,
				SyntaxFactory.Whitespace(text)
			}), (SyntaxKind)8343, SyntaxFactory.TriviaList(SyntaxFactory.get_Space())));
			val4 = SyntaxNodeExtensions.WithTrailingTrivia<MethodDeclarationSyntax>(SyntaxNodeExtensions.NormalizeWhitespace<MethodDeclarationSyntax>(val4, "    ", Environment.NewLine + text, false).WithModifiers(val7), (SyntaxTrivia[])(object)new SyntaxTrivia[1] { SyntaxFactory.SyntaxTrivia((SyntaxKind)8540, Environment.NewLine) });
		}
		else
		{
			val4 = SyntaxNodeExtensions.WithTrailingTrivia<MethodDeclarationSyntax>(SyntaxNodeExtensions.WithLeadingTrivia<MethodDeclarationSyntax>(SyntaxNodeExtensions.NormalizeWhitespace<MethodDeclarationSyntax>(val4, "    ", Environment.NewLine + text, false), (SyntaxTrivia[])(object)new SyntaxTrivia[1] { SyntaxFactory.SyntaxTrivia((SyntaxKind)8540, (val5 != null) ? (Environment.NewLine + text) : text) }), (SyntaxTrivia[])(object)new SyntaxTrivia[1] { SyntaxFactory.SyntaxTrivia((SyntaxKind)8540, Environment.NewLine) });
		}
		GenerateMethodCodeResponse obj2 = new GenerateMethodCodeResponse
		{
			MethodSourceCode = ((SyntaxNode)val4).ToFullString()
		};
		TextSpan fullSpan;
		int end;
		if (val5 == null)
		{
			SyntaxToken openBraceToken = ((BaseTypeDeclarationSyntax)val2).get_OpenBraceToken();
			fullSpan = ((SyntaxToken)(ref openBraceToken)).get_FullSpan();
			end = ((TextSpan)(ref fullSpan)).get_End();
		}
		else
		{
			fullSpan = ((SyntaxNode)val5).get_FullSpan();
			end = ((TextSpan)(ref fullSpan)).get_End();
		}
		obj2.InsertPosition = end;
		return obj2;
	}

	private SyntaxTrivia GenerateSummary(string description, string intendation = "    ")
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		return SyntaxFactory.Trivia((StructuredTriviaSyntax)(object)SyntaxFactory.DocumentationCommentTrivia((SyntaxKind)8544, new SyntaxList<XmlNodeSyntax>((IEnumerable<XmlNodeSyntax>)(object)new XmlNodeSyntax[3]
		{
			(XmlNodeSyntax)SyntaxFactory.XmlText().WithTextTokens(SyntaxFactory.TokenList(SyntaxFactory.XmlTextLiteral(SyntaxFactory.TriviaList(SyntaxFactory.DocumentationCommentExterior("///")), " ", " ", SyntaxFactory.TriviaList()))),
			(XmlNodeSyntax)SyntaxFactory.XmlExampleElement(SyntaxFactory.SingletonList<XmlNodeSyntax>((XmlNodeSyntax)(object)SyntaxFactory.XmlText().WithTextTokens(SyntaxFactory.TokenList((SyntaxToken[])(object)new SyntaxToken[4]
			{
				SyntaxFactory.XmlTextNewLine(SyntaxFactory.TriviaList(), "\n", "\n", SyntaxFactory.TriviaList()),
				SyntaxFactory.XmlTextLiteral(SyntaxFactory.TriviaList(SyntaxFactory.DocumentationCommentExterior(intendation + "///")), " " + description, " " + description, SyntaxFactory.TriviaList()),
				SyntaxFactory.XmlTextNewLine(SyntaxFactory.TriviaList(), "\n", "\n", SyntaxFactory.TriviaList()),
				SyntaxFactory.XmlTextLiteral(SyntaxFactory.TriviaList(SyntaxFactory.DocumentationCommentExterior(intendation + "///")), " ", " ", SyntaxFactory.TriviaList())
			})))).WithStartTag(SyntaxFactory.XmlElementStartTag(SyntaxFactory.XmlName(SyntaxFactory.Identifier("summary")))).WithEndTag(SyntaxFactory.XmlElementEndTag(SyntaxFactory.XmlName(SyntaxFactory.Identifier("summary")))),
			(XmlNodeSyntax)SyntaxFactory.XmlText().WithTextTokens(SyntaxFactory.TokenList(SyntaxFactory.XmlTextNewLine(SyntaxFactory.TriviaList(), "\n", "\n", SyntaxFactory.TriviaList())))
		})));
	}

	public IEnumerable<ScriptMethodDeclaration> ParseMethods(ParseMethodsRequest request)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		List<ScriptMethodDeclaration> list = new List<ScriptMethodDeclaration>();
		string text = request?.SourceCode;
		if (string.IsNullOrWhiteSpace(text))
		{
			return list;
		}
		SyntaxTree obj = SyntaxFactory.ParseSyntaxTree(text, (ParseOptions)null, "", Encoding.UTF8, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken));
		ClassDeclarationSyntax val = ((obj != null) ? obj.GetRoot(default(CancellationToken)).DescendantNodes((Func<SyntaxNode, bool>)null, false).OfType<ClassDeclarationSyntax>()
			.FirstOrDefault() : null);
		if (val == null)
		{
			return list;
		}
		Enumerator<MemberDeclarationSyntax> enumerator = ((TypeDeclarationSyntax)(((IEnumerable)(object)((TypeDeclarationSyntax)val).get_Members()).OfType<ClassDeclarationSyntax>().FirstOrDefault(delegate(ClassDeclarationSyntax @class)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			SyntaxToken identifier3 = ((BaseTypeDeclarationSyntax)@class).get_Identifier();
			if (!(((object)(SyntaxToken)(ref identifier3)).ToString() == "ComponentController"))
			{
				identifier3 = ((BaseTypeDeclarationSyntax)@class).get_Identifier();
				return ((object)(SyntaxToken)(ref identifier3)).ToString() == "ViewModelController";
			}
			return true;
		}) ?? val)).get_Members().GetEnumerator();
		while (enumerator.MoveNext())
		{
			MemberDeclarationSyntax current = enumerator.get_Current();
			MethodDeclarationSyntax val2 = (MethodDeclarationSyntax)(object)((current is MethodDeclarationSyntax) ? current : null);
			if (val2 != null && CSharpExtensions.Any(((MemberDeclarationSyntax)val2).get_Modifiers(), (SyntaxKind)8343))
			{
				SyntaxToken identifier = val2.get_Identifier();
				string text2 = ((SyntaxToken)(ref identifier)).get_Text();
				ScriptMethodDeclaration methodDeclaration = new ScriptMethodDeclaration
				{
					Name = text2,
					ReturnType = ((object)val2.get_ReturnType()).ToString()
				};
				string text3 = string.Join(", ", ((IEnumerable<ParameterSyntax>)(object)((BaseParameterListSyntax)((BaseMethodDeclarationSyntax)val2).get_ParameterList()).get_Parameters()).Select(delegate(ParameterSyntax param)
				{
					//IL_0001: Unknown result type (might be due to invalid IL or missing references)
					//IL_0006: Unknown result type (might be due to invalid IL or missing references)
					SyntaxToken identifier2 = param.get_Identifier();
					string text4 = ((SyntaxToken)(ref identifier2)).get_Text();
					string text5 = ((object)param.get_Type()).ToString();
					methodDeclaration.Parameters.Add(new ScriptMethodParameter(text4, text5));
					return text5 + " " + text4;
				}));
				methodDeclaration.Signature = text2 + "(" + text3 + ")";
				methodDeclaration.DisplayInfo = text2 + "(" + text3 + ")";
				list.Add(methodDeclaration);
			}
		}
		return list;
	}

	public string ChangeSourceClassName(string sourceCode, string oldName, string newName)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(sourceCode))
		{
			return sourceCode;
		}
		SyntaxNode root = CSharpSyntaxTree.ParseText(sourceCode, CSharpParseOptions.get_Default().WithLanguageVersion((LanguageVersion)7), "", (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken)).GetRoot(default(CancellationToken));
		ClassDeclarationSyntax val = null;
		SyntaxToken val3;
		foreach (SyntaxNode item in root.DescendantNodes((Func<SyntaxNode, bool>)null, false))
		{
			ClassDeclarationSyntax val2;
			if ((val2 = (ClassDeclarationSyntax)(object)((item is ClassDeclarationSyntax) ? item : null)) != null)
			{
				val3 = ((BaseTypeDeclarationSyntax)val2).get_Identifier();
				if (((object)(SyntaxToken)(ref val3)).ToString() == oldName)
				{
					val = val2;
					break;
				}
			}
		}
		if (val == null)
		{
			return sourceCode;
		}
		SyntaxToken identifier = ((BaseTypeDeclarationSyntax)val).get_Identifier();
		val3 = SyntaxFactory.Identifier(newName);
		return ((object)SyntaxNodeExtensions.ReplaceToken<SyntaxNode>(root, identifier, ((SyntaxToken)(ref val3)).WithTriviaFrom(((BaseTypeDeclarationSyntax)val).get_Identifier()))).ToString();
	}

	public AddInterfaceResult AddInterface(AddInterfaceData data)
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		AddInterfaceResult addInterfaceResult = new AddInterfaceResult();
		addInterfaceResult.SourceCode = data.SourceCode;
		if (string.IsNullOrEmpty(data.SourceCode))
		{
			return addInterfaceResult;
		}
		SyntaxNode root = CSharpSyntaxTree.ParseText(data.SourceCode, CSharpParseOptions.get_Default().WithLanguageVersion((LanguageVersion)7), "", (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken)).GetRoot(default(CancellationToken));
		List<ClassDeclarationSyntax> source = root.DescendantNodes((Func<SyntaxNode, bool>)null, false).OfType<ClassDeclarationSyntax>().ToList();
		ClassDeclarationSyntax val = source.FirstOrDefault(delegate(ClassDeclarationSyntax q)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			SyntaxToken identifier4 = ((BaseTypeDeclarationSyntax)q).get_Identifier();
			return ((object)(SyntaxToken)(ref identifier4)).ToString() == data.ClassName;
		});
		ClassDeclarationSyntax val2 = ((val != null) ? ((IEnumerable)(object)((TypeDeclarationSyntax)val).get_Members()).OfType<ClassDeclarationSyntax>().FirstOrDefault(delegate(ClassDeclarationSyntax q)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			SyntaxToken identifier3 = ((BaseTypeDeclarationSyntax)q).get_Identifier();
			return ((object)(SyntaxToken)(ref identifier3)).ToString() == "ComponentController";
		}) : null);
		if (val2 == null)
		{
			val2 = source.FirstOrDefault(delegate(ClassDeclarationSyntax q)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				SyntaxToken identifier2 = ((BaseTypeDeclarationSyntax)q).get_Identifier();
				return ((object)(SyntaxToken)(ref identifier2)).ToString() == "ComponentController";
			});
			if (val2 == null)
			{
				val2 = source.FirstOrDefault(delegate(ClassDeclarationSyntax q)
				{
					//IL_0001: Unknown result type (might be due to invalid IL or missing references)
					//IL_0006: Unknown result type (might be due to invalid IL or missing references)
					SyntaxToken identifier = ((BaseTypeDeclarationSyntax)q).get_Identifier();
					return ((object)(SyntaxToken)(ref identifier)).ToString() == "ViewModelController";
				}) ?? val;
				if (val2 == null)
				{
					return null;
				}
			}
		}
		BaseListSyntax baseList = ((BaseTypeDeclarationSyntax)val2).get_BaseList();
		if (baseList != null && baseList.get_Types().get_Count() > 0 && ((IEnumerable<BaseTypeSyntax>)(object)((BaseTypeDeclarationSyntax)val2).get_BaseList().get_Types()).Any((BaseTypeSyntax t) => ((object)t.get_Type()).ToString().Equals(data.InterfaceName)))
		{
			return addInterfaceResult;
		}
		SyntaxGenerator.GetGenerator((Workspace)new AdhocWorkspace(), "C#");
		ClassDeclarationSyntax val3 = val2.AddBaseListTypes((BaseTypeSyntax[])(object)new BaseTypeSyntax[1] { (BaseTypeSyntax)SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName(data.InterfaceName, 0, true)) });
		string text2 = (addInterfaceResult.SourceCode = ((object)SyntaxNodeExtensions.WithLeadingTrivia<SyntaxNode>(SyntaxNodeExtensions.NormalizeWhitespace<SyntaxNode>(SyntaxNodeExtensions.ReplaceNode<SyntaxNode>(root, (SyntaxNode)(object)val2, (SyntaxNode)(object)SyntaxNodeExtensions.WithTriviaFrom<ClassDeclarationSyntax>(val3, (SyntaxNode)(object)val2)), "    ", Environment.NewLine, false), (SyntaxTrivia[])(object)new SyntaxTrivia[1] { SyntaxFactory.SyntaxTrivia((SyntaxKind)8540, Environment.NewLine) })).ToString());
		return addInterfaceResult;
	}

	public bool InterfaceExists(InterfaceExistsInfo info)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(info.SourceCode))
		{
			return false;
		}
		List<ClassDeclarationSyntax> source = CSharpSyntaxTree.ParseText(info.SourceCode, CSharpParseOptions.get_Default().WithLanguageVersion((LanguageVersion)7), "", (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken)).GetRoot(default(CancellationToken)).DescendantNodes((Func<SyntaxNode, bool>)null, false)
			.OfType<ClassDeclarationSyntax>()
			.ToList();
		ClassDeclarationSyntax val = source.FirstOrDefault(delegate(ClassDeclarationSyntax q)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			SyntaxToken identifier4 = ((BaseTypeDeclarationSyntax)q).get_Identifier();
			return ((object)(SyntaxToken)(ref identifier4)).ToString() == info.ClassName;
		});
		ClassDeclarationSyntax val2 = ((val != null) ? ((IEnumerable)(object)((TypeDeclarationSyntax)val).get_Members()).OfType<ClassDeclarationSyntax>().FirstOrDefault(delegate(ClassDeclarationSyntax q)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			SyntaxToken identifier3 = ((BaseTypeDeclarationSyntax)q).get_Identifier();
			return ((object)(SyntaxToken)(ref identifier3)).ToString() == "ComponentController";
		}) : null);
		if (val2 == null)
		{
			val2 = source.FirstOrDefault(delegate(ClassDeclarationSyntax q)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				SyntaxToken identifier2 = ((BaseTypeDeclarationSyntax)q).get_Identifier();
				return ((object)(SyntaxToken)(ref identifier2)).ToString() == "ComponentController";
			});
			if (val2 == null)
			{
				val2 = source.FirstOrDefault(delegate(ClassDeclarationSyntax q)
				{
					//IL_0001: Unknown result type (might be due to invalid IL or missing references)
					//IL_0006: Unknown result type (might be due to invalid IL or missing references)
					SyntaxToken identifier = ((BaseTypeDeclarationSyntax)q).get_Identifier();
					return ((object)(SyntaxToken)(ref identifier)).ToString() == "ViewModelController";
				}) ?? val;
				if (val2 == null)
				{
					return false;
				}
			}
		}
		BaseListSyntax baseList = ((BaseTypeDeclarationSyntax)val2).get_BaseList();
		if (baseList != null && baseList.get_Types().get_Count() > 0 && ((IEnumerable<BaseTypeSyntax>)(object)((BaseTypeDeclarationSyntax)val2).get_BaseList().get_Types()).Any((BaseTypeSyntax t) => ((object)t.get_Type()).ToString().Equals(info.InterfaceName)))
		{
			return true;
		}
		return false;
	}
}
