using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;

namespace Nemerle.Compiler;

public class NemerleCodeGenerator : CodeGenerator, ISupportRelocation
{
	protected enum BracingType
	{
		C,
		Block,
		Indent
	}

	private sealed class _N_closureOf_GetTypeOutput_50358
	{
		internal Function<CodeTypeReference, string> _N_expandGenerics_50363;

		internal _N_closureOf_GetTypeOutput_50358()
		{
		}
	}

	private sealed class _N_expandGenerics__50391 : Function<CodeTypeReference, string>
	{
		[SpecialName]
		private _N_closureOf_GetTypeOutput_50358 _N_GetTypeOutput_closure_50395;

		public _N_expandGenerics__50391(_N_closureOf_GetTypeOutput_50358 _N_GetTypeOutput_closure_50395)
		{
			this._N_GetTypeOutput_closure_50395 = _N_GetTypeOutput_closure_50395;
		}

		[SpecialName]
		public sealed override string apply(CodeTypeReference r)
		{
			string text = r.BaseType.Trim();
			int num = text.IndexOf("`");
			text = ((num == -1) ? text : text.Substring(0, num));
			string result;
			if (r.TypeArguments.Count == 0)
			{
				result = text;
			}
			else
			{
				CodeTypeReference[] array = new CodeTypeReference[r.TypeArguments.Count];
				r.TypeArguments.CopyTo(array, 0);
				result = Convert.ToString(text) + ".[" + string.Join(", ", array.MapToArray(_N_GetTypeOutput_closure_50395._N_expandGenerics_50363)) + "]";
			}
			return result;
		}
	}

	private bool dont_write_semicolon = false;

	private int id = 0;

	private CodeGeneratorOptions options = null;

	private IndentedTextWriter output = null;

	protected bool inNestedBinary = false;

	private static Hashtable typesTable;

	private static readonly string[] types;

	private static Hashtable keywordsTable;

	private static readonly string[] keywords;

	protected new CodeGeneratorOptions Options
	{
		get
		{
			return (options == null) ? base.Options : options;
		}
		set
		{
			options = value;
		}
	}

	protected BracingType BracingStyle => Options.BracingStyle switch
	{
		"Block" => BracingType.Block, 
		"Indent" => BracingType.Indent, 
		_ => BracingType.C, 
	};

	protected new TextWriter Output
	{
		get
		{
			return (output == null) ? base.Output : output;
		}
		set
		{
			if (Options == null)
			{
				options = new CodeGeneratorOptions();
			}
			output = new IndentedTextWriter(value, Options.IndentString);
		}
	}

	protected new int Indent
	{
		get
		{
			return (output == null) ? base.Indent : output.Indent;
		}
		set
		{
			if (output != null)
			{
				output.Indent = value;
			}
			else
			{
				base.Indent = value;
			}
		}
	}

	protected override string NullToken => "null";

	static NemerleCodeGenerator()
	{
		types = new string[16]
		{
			"object", "bool", "byte", "float", "uint", "char", "ulong", "ushort", "decimal", "int",
			"sbyte", "short", "double", "long", "string", "void"
		};
		keywords = new string[61]
		{
			"abstract", "and", "array", "as", "base", "catch", "class", "def", "delegate", "do",
			"else", "enum", "event", "extends", "extern", "false", "finally", "for", "foreach", "fun",
			"if", "implements", "in", "interface", "internal", "lock", "macro", "match", "module", "mutable",
			"namespace", "new", "null", "out", "override", "params", "private", "protected", "public", "ref",
			"sealed", "static", "struct", "syntax", "this", "throw", "true", "try", "type", "typeof",
			"unless", "using", "variant", "virtual", "void", "when", "where", "while", "assert", "abort",
			"ignore"
		};
	}

	private string new_name()
	{
		checked
		{
			id++;
			return string.Concat("_N" + id, "_");
		}
	}

	protected override void GenerateArrayCreateExpression(CodeArrayCreateExpression expression)
	{
		CodeTypeReference codeTypeReference = null;
		CodeTypeReference codeTypeReference2 = null;
		TextWriter textWriter = Output;
		textWriter.Write("array");
		CodeExpressionCollection initializers = expression.Initializers;
		codeTypeReference = expression.CreateType;
		checked
		{
			if (initializers.Count > 0)
			{
				textWriter.WriteLine("[");
				Indent++;
				OutputExpressionList(initializers, newlineBetweenItems: true);
				Indent--;
				textWriter.Write("]");
			}
			else
			{
				for (codeTypeReference2 = codeTypeReference.ArrayElementType; codeTypeReference2 != null; codeTypeReference2 = codeTypeReference2.ArrayElementType)
				{
					codeTypeReference = codeTypeReference2;
				}
				textWriter.Write('(');
				CodeExpression sizeExpression = expression.SizeExpression;
				if (sizeExpression != null)
				{
					GenerateExpression(sizeExpression);
				}
				else
				{
					textWriter.Write(expression.Size);
				}
				textWriter.Write(')');
			}
			if (codeTypeReference.BaseType == "System.Object" || codeTypeReference.BaseType == "object")
			{
				textWriter.Write(" :> array[object]");
			}
		}
	}

	protected override void GenerateBaseReferenceExpression(CodeBaseReferenceExpression _N_wildcard_3320)
	{
		Output.Write("base");
	}

	protected override void GenerateBinaryOperatorExpression(CodeBinaryOperatorExpression e)
	{
		bool flag = false;
		TextWriter textWriter = Output;
		flag = false;
		textWriter.Write("(");
		GenerateExpression(e.Left);
		textWriter.Write(" ");
		CodeExpression left = e.Left;
		if (!(left is CodeBinaryOperatorExpression) && 0 == 0)
		{
			left = e.Right;
			if (!(left is CodeBinaryOperatorExpression))
			{
				goto IL_00a9;
			}
		}
		checked
		{
			if (!inNestedBinary)
			{
				flag = true;
				inNestedBinary = true;
				Indent += 3;
			}
			ContinueOnNewLine("");
			goto IL_00a9;
		}
		IL_00a9:
		OutputOperator(e.Operator);
		textWriter.Write(" ");
		GenerateExpression(e.Right);
		textWriter.Write(")");
		checked
		{
			if (flag)
			{
				Indent -= 3;
				inNestedBinary = false;
			}
		}
	}

	protected override void GenerateCastExpression(CodeCastExpression expression)
	{
		TextWriter textWriter = Output;
		textWriter.Write("(");
		GenerateExpression(expression.Expression);
		textWriter.Write(" :> ");
		OutputType(expression.TargetType);
		textWriter.Write(")");
	}

	protected override void GenerateCompileUnitStart(CodeCompileUnit _compileUnit)
	{
		GenerateComment(new CodeComment("------------------------------------------------------------------------------"));
		GenerateComment(new CodeComment(" <autogenerated>"));
		GenerateComment(new CodeComment("     This code was generated by a tool."));
		GenerateComment(new CodeComment("     Runtime Version: " + Environment.Version.ToString()));
		GenerateComment(new CodeComment(""));
		GenerateComment(new CodeComment("     Changes to this file may cause incorrect behavior and will be lost if "));
		GenerateComment(new CodeComment("     the code is regenerated."));
		GenerateComment(new CodeComment(" </autogenerated>"));
		GenerateComment(new CodeComment("------------------------------------------------------------------------------"));
		if (Options.BracingStyle == "Indent")
		{
			Output.WriteLine("#pragma indent");
		}
		Output.WriteLine();
	}

	protected override void GenerateDelegateCreateExpression(CodeDelegateCreateExpression expression)
	{
		TextWriter textWriter = Output;
		OutputType(expression.DelegateType);
		textWriter.Write('(');
		CodeExpression targetObject = expression.TargetObject;
		if (targetObject != null)
		{
			GenerateExpression(targetObject);
			Output.Write('.');
		}
		textWriter.Write(GetSafeName(expression.MethodName));
		textWriter.Write(')');
	}

	protected override void GenerateDirectives(CodeDirectiveCollection directives)
	{
		if (directives.Count <= 0)
		{
			return;
		}
		TextWriter textWriter = Output;
		textWriter.WriteLine("");
		IEnumerator enumerator = directives.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				if (current is CodeRegionDirective)
				{
					CodeRegionDirective codeRegionDirective = (CodeRegionDirective)current;
					switch (codeRegionDirective.RegionMode)
					{
					case CodeRegionMode.None:
						break;
					case CodeRegionMode.Start:
						textWriter.WriteLine("#region " + Convert.ToString(codeRegionDirective.RegionText));
						break;
					case CodeRegionMode.End:
						textWriter.WriteLine("#endregion ");
						break;
					default:
						throw new MatchFailureException();
					}
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				IDisposable disposable = (IDisposable)enumerator;
				disposable.Dispose();
			}
		}
		textWriter.WriteLine("");
	}

	protected override void GenerateSingleFloatValue(float f)
	{
		Output.Write(f.ToString("R", CultureInfo.InvariantCulture));
		Output.Write('f');
	}

	protected override void GenerateDoubleValue(double d)
	{
		Output.Write(d.ToString("R", CultureInfo.InvariantCulture));
	}

	protected override void GenerateFieldReferenceExpression(CodeFieldReferenceExpression expression)
	{
		CodeExpression targetObject = expression.TargetObject;
		if (targetObject != null)
		{
			GenerateExpression(targetObject);
			Output.Write('.');
		}
		Output.Write(GetSafeName(expression.FieldName));
	}

	protected override void GenerateArgumentReferenceExpression(CodeArgumentReferenceExpression expression)
	{
		Output.Write(GetSafeName(expression.ParameterName));
	}

	protected override void GenerateVariableReferenceExpression(CodeVariableReferenceExpression expression)
	{
		Output.Write(GetSafeName(expression.VariableName));
	}

	protected override void GenerateIndexerExpression(CodeIndexerExpression expression)
	{
		TextWriter textWriter = Output;
		GenerateExpression(expression.TargetObject);
		textWriter.Write('[');
		OutputExpressionList(expression.Indices);
		textWriter.Write(']');
	}

	protected override void GenerateArrayIndexerExpression(CodeArrayIndexerExpression expression)
	{
		TextWriter textWriter = Output;
		GenerateExpression(expression.TargetObject);
		textWriter.Write('[');
		OutputExpressionList(expression.Indices);
		textWriter.Write(']');
	}

	protected override void GenerateSnippetExpression(CodeSnippetExpression expression)
	{
		Output.Write(expression.Value);
	}

	protected override void GenerateMethodInvokeExpression(CodeMethodInvokeExpression expression)
	{
		TextWriter textWriter = Output;
		GenerateMethodReferenceExpression(expression.Method);
		textWriter.Write('(');
		OutputExpressionList(expression.Parameters);
		textWriter.Write(')');
	}

	protected override void GenerateMethodReferenceExpression(CodeMethodReferenceExpression expression)
	{
		if (expression.TargetObject != null)
		{
			GenerateExpression(expression.TargetObject);
			Output.Write('.');
		}
		Output.Write(GetSafeName(expression.MethodName));
	}

	protected override void GenerateEventReferenceExpression(CodeEventReferenceExpression expression)
	{
		GenerateExpression(expression.TargetObject);
		Output.Write('.');
		Output.Write(GetSafeName(expression.EventName));
	}

	protected override void GenerateDelegateInvokeExpression(CodeDelegateInvokeExpression expression)
	{
		GenerateExpression(expression.TargetObject);
		Output.Write('(');
		OutputExpressionList(expression.Parameters);
		Output.Write(')');
	}

	protected override void GenerateObjectCreateExpression(CodeObjectCreateExpression expression)
	{
		OutputType(expression.CreateType);
		Output.Write('(');
		OutputExpressionList(expression.Parameters);
		Output.Write(')');
	}

	protected override void GeneratePropertyReferenceExpression(CodePropertyReferenceExpression expression)
	{
		CodeExpression targetObject = expression.TargetObject;
		if (targetObject != null)
		{
			GenerateExpression(targetObject);
			Output.Write('.');
		}
		Output.Write(GetSafeName(expression.PropertyName));
	}

	protected override void GeneratePropertySetValueReferenceExpression(CodePropertySetValueReferenceExpression _N_wildcard_3321)
	{
		Output.Write("value");
	}

	protected override void GenerateThisReferenceExpression(CodeThisReferenceExpression _N_wildcard_3322)
	{
		Output.Write("this");
	}

	protected override void GenerateExpressionStatement(CodeExpressionStatement statement)
	{
		GenerateExpression(statement.Expression);
		if (!dont_write_semicolon)
		{
			Output.WriteLine(';');
		}
	}

	protected override void GenerateIterationStatement(CodeIterationStatement statement)
	{
		TextWriter textWriter = Output;
		textWriter.Write("for (");
		dont_write_semicolon = true;
		GenerateStatement(statement.InitStatement);
		textWriter.Write("; ");
		GenerateExpression(statement.TestExpression);
		textWriter.Write("; ");
		GenerateStatement(statement.IncrementStatement);
		textWriter.Write(") ");
		dont_write_semicolon = false;
		GenerateBlock(statement.Statements);
	}

	protected new void GenerateStatements(CodeStatementCollection c)
	{
		IEnumerator enumerator = c.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				if (current is CodeStatement)
				{
					CodeStatement e = (CodeStatement)current;
					GenerateStatement(e);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				IDisposable disposable = (IDisposable)enumerator;
				disposable.Dispose();
			}
		}
		if (c.Count > 0)
		{
			CodeStatement codeStatement = c[checked(c.Count - 1)];
			if (!(codeStatement is CodeVariableDeclarationStatement))
			{
				return;
			}
		}
		else if (0 == 0)
		{
			return;
		}
		switch (BracingStyle)
		{
		case BracingType.C:
		case BracingType.Block:
			Output.WriteLine("();");
			break;
		case BracingType.Indent:
			Output.WriteLine("()");
			break;
		default:
			throw new MatchFailureException();
		}
	}

	protected override void GenerateThrowExceptionStatement(CodeThrowExceptionStatement statement)
	{
		Output.Write("throw");
		if (statement.ToThrow != null)
		{
			Output.Write(' ');
			GenerateExpression(statement.ToThrow);
		}
		if (!dont_write_semicolon)
		{
			Output.WriteLine(";");
		}
	}

	protected override void GenerateComment(CodeComment comment)
	{
		int num = 0;
		bool flag = false;
		TextWriter textWriter = Output;
		string[] array = comment.Text.Split('\n');
		flag = true;
		foreach (string value in array)
		{
			if (comment.DocComment)
			{
				textWriter.Write("///");
			}
			else
			{
				textWriter.Write("//");
			}
			if (flag)
			{
				textWriter.Write(' ');
				flag = false;
			}
			textWriter.WriteLine(value);
		}
	}

	protected override void GenerateMethodReturnStatement(CodeMethodReturnStatement statement)
	{
		TextWriter textWriter = Output;
		if (statement.Expression != null)
		{
			GenerateExpression(statement.Expression);
		}
		if (!dont_write_semicolon)
		{
			textWriter.WriteLine(";");
		}
	}

	protected override void GenerateConditionStatement(CodeConditionStatement statement)
	{
		TextWriter textWriter = Output;
		CodeStatementCollection falseStatements = statement.FalseStatements;
		if (falseStatements.Count > 0)
		{
			textWriter.Write("if (");
		}
		else
		{
			textWriter.Write("when (");
		}
		GenerateExpression(statement.Condition);
		textWriter.Write(") ");
		GenerateBlock(statement.TrueStatements, endLastLine: false);
		if (falseStatements.Count > 0)
		{
			if (Options.ElseOnClosing)
			{
				textWriter.Write(' ');
			}
			else
			{
				textWriter.WriteLine();
			}
			textWriter.Write("else ");
			GenerateBlock(falseStatements);
		}
		else
		{
			textWriter.WriteLine();
		}
	}

	protected override void GenerateTryCatchFinallyStatement(CodeTryCatchFinallyStatement statement)
	{
		TextWriter textWriter = Output;
		CodeGeneratorOptions codeGeneratorOptions = Options;
		textWriter.Write("try");
		GenerateBlock(statement.TryStatements);
		checked
		{
			if (statement.CatchClauses.Count > 0)
			{
				textWriter.WriteLine("catch");
				BracingType bracingStyle = BracingStyle;
				OutputBlockStart(bracingStyle);
				Indent++;
				IEnumerator enumerator = statement.CatchClauses.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object current = enumerator.Current;
						if (current is CodeCatchClause)
						{
							CodeCatchClause codeCatchClause = (CodeCatchClause)current;
							textWriter.Write("| ");
							OutputTypeNamePair(codeCatchClause.CatchExceptionType, GetSafeName(codeCatchClause.LocalName));
							textWriter.WriteLine(" =>");
							Indent++;
							GenerateStatements(codeCatchClause.Statements);
							Indent--;
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						IDisposable disposable = (IDisposable)enumerator;
						disposable.Dispose();
					}
				}
				Indent--;
				OutputBlockEnd(bracingStyle, endLastLine: false);
			}
			CodeStatementCollection finallyStatements = statement.FinallyStatements;
			if (finallyStatements.Count > 0)
			{
				if (codeGeneratorOptions.ElseOnClosing)
				{
					textWriter.Write(' ');
				}
				else
				{
					textWriter.WriteLine();
				}
				textWriter.Write("finally ");
				GenerateBlock(finallyStatements);
			}
			else
			{
				textWriter.WriteLine();
			}
		}
	}

	protected override void GenerateAssignStatement(CodeAssignStatement statement)
	{
		TextWriter textWriter = Output;
		GenerateExpression(statement.Left);
		textWriter.Write(" = ");
		GenerateExpression(statement.Right);
		if (!dont_write_semicolon)
		{
			textWriter.WriteLine(';');
		}
	}

	protected override void GenerateAttachEventStatement(CodeAttachEventStatement statement)
	{
		TextWriter textWriter = Output;
		GenerateEventReferenceExpression(statement.Event);
		textWriter.Write(" += ");
		GenerateExpression(statement.Listener);
		if (!dont_write_semicolon)
		{
			textWriter.WriteLine(';');
		}
	}

	protected override void GenerateRemoveEventStatement(CodeRemoveEventStatement statement)
	{
		TextWriter textWriter = Output;
		GenerateEventReferenceExpression(statement.Event);
		Output.Write(" -= ");
		GenerateExpression(statement.Listener);
		if (!dont_write_semicolon)
		{
			textWriter.WriteLine(';');
		}
	}

	protected override void GenerateGotoStatement(CodeGotoStatement _N_wildcard_3323)
	{
		//Discarded unreachable code: IL_000b
		throw new NotSupportedException("Goto statement is not supported in Nemerle language.");
	}

	protected override void GenerateLabeledStatement(CodeLabeledStatement _N_wildcard_3324)
	{
		//Discarded unreachable code: IL_000b
		throw new NotSupportedException("Labeled statement is not supported in Nemerle language.");
	}

	protected override void GenerateSnippetCompileUnit(CodeSnippetCompileUnit e)
	{
		GenerateDirectives(e.StartDirectives);
		if (e.LinePragma != null)
		{
			GenerateLinePragmaStart(e.LinePragma);
		}
		Output.WriteLine(e.Value);
		if (e.LinePragma != null)
		{
			GenerateLinePragmaEnd(e.LinePragma);
		}
		GenerateDirectives(e.EndDirectives);
	}

	protected override void GenerateVariableDeclarationStatement(CodeVariableDeclarationStatement statement)
	{
		TextWriter textWriter = Output;
		textWriter.Write("mutable ");
		textWriter.Write(GetSafeName(statement.Name));
		CodeExpression initExpression = statement.InitExpression;
		if (initExpression != null)
		{
			textWriter.Write(" = ");
			GenerateExpression(initExpression);
			if (initExpression is CodePrimitiveExpression && ((CodePrimitiveExpression)initExpression).Value == null)
			{
				Output.Write(" : ");
				OutputType(statement.Type);
			}
		}
		else if (statement.Type.ArrayElementType != null)
		{
			textWriter.Write(" = ");
			textWriter.Write(NullToken);
			textWriter.Write(" : ");
			OutputType(statement.Type);
		}
		if (!dont_write_semicolon)
		{
			textWriter.WriteLine(';');
		}
	}

	protected override void GenerateLinePragmaStart(CodeLinePragma linePragma)
	{
		Output.WriteLine();
		Output.Write("#line ");
		Output.Write(linePragma.LineNumber);
		Output.Write(" \"");
		Output.Write(linePragma.FileName);
		Output.Write("\"");
		Output.WriteLine();
	}

	protected override void GenerateLinePragmaEnd(CodeLinePragma _N_wildcard_3325)
	{
		Output.WriteLine();
		Output.WriteLine("#line default");
	}

	protected override void GenerateEvent(CodeMemberEvent eventRef, CodeTypeDeclaration _declaration)
	{
		if (eventRef.CustomAttributes.Count > 0)
		{
			OutputAttributeDeclarations(eventRef.CustomAttributes);
		}
		OutputMemberAccessModifier(eventRef.Attributes);
		OutputMemberScopeModifier(eventRef.Attributes | MemberAttributes.Final);
		Output.Write("event ");
		OutputTypeNamePair(eventRef.Type, GetSafeName(eventRef.Name));
		Output.WriteLine(';');
	}

	protected override void GenerateField(CodeMemberField field)
	{
		TextWriter textWriter = Output;
		if (field.CustomAttributes.Count > 0)
		{
			OutputAttributeDeclarations(field.CustomAttributes);
		}
		if (IsCurrentEnum)
		{
			textWriter.Write("| ");
			Output.Write(field.Name);
		}
		else
		{
			MemberAttributes attributes = field.Attributes;
			OutputMemberAccessModifier(attributes);
			OutputFieldScopeModifier(attributes);
			OutputTypeNamePair(field.Type, GetSafeName(field.Name));
		}
		CodeExpression initExpression = field.InitExpression;
		if (initExpression != null)
		{
			textWriter.Write(" = ");
			GenerateExpression(initExpression);
		}
		if (!IsCurrentEnum)
		{
			textWriter.WriteLine(';');
		}
		else
		{
			textWriter.WriteLine("");
		}
	}

	protected override void OutputFieldScopeModifier(MemberAttributes attributes)
	{
		if ((attributes & MemberAttributes.VTableMask) == MemberAttributes.New)
		{
			Output.Write("new ");
		}
		switch (attributes & MemberAttributes.ScopeMask)
		{
		case MemberAttributes.Static:
			Output.Write("static mutable ");
			break;
		case MemberAttributes.Const:
			Output.Write("static ");
			break;
		default:
			Output.Write("mutable ");
			break;
		}
	}

	protected void OutputTypeAttributes(CodeTypeDeclaration declaration)
	{
		TextWriter textWriter = Output;
		TypeAttributes typeAttributes = declaration.TypeAttributes;
		switch (typeAttributes & TypeAttributes.VisibilityMask)
		{
		case TypeAttributes.Public:
		case TypeAttributes.NestedPublic:
			textWriter.Write("public ");
			break;
		case TypeAttributes.NestedPrivate:
			textWriter.Write("private ");
			break;
		case TypeAttributes.NestedFamily:
			textWriter.Write("protected ");
			break;
		case TypeAttributes.NotPublic:
		case TypeAttributes.NestedAssembly:
		case TypeAttributes.NestedFamANDAssem:
			textWriter.Write("internal ");
			break;
		case TypeAttributes.VisibilityMask:
			textWriter.Write("protected internal ");
			break;
		}
		if (declaration.IsStruct)
		{
			if (declaration.IsPartial)
			{
				textWriter.Write("partial ");
			}
			textWriter.Write("struct ");
			return;
		}
		if (declaration.IsEnum)
		{
			textWriter.Write("enum ");
			return;
		}
		if ((typeAttributes & TypeAttributes.ClassSemanticsMask) != 0)
		{
			if (declaration.IsPartial)
			{
				textWriter.Write("partial ");
			}
			textWriter.Write("interface ");
			return;
		}
		if ((typeAttributes & TypeAttributes.Sealed) != 0)
		{
			textWriter.Write("sealed ");
		}
		if ((typeAttributes & TypeAttributes.Abstract) != 0)
		{
			textWriter.Write("abstract ");
		}
		if (declaration.IsPartial)
		{
			textWriter.Write("partial ");
		}
		textWriter.Write("class ");
	}

	protected override void GenerateSnippetMember(CodeSnippetTypeMember member)
	{
		Output.Write(member.Text);
	}

	protected override void GenerateSnippetStatement(CodeSnippetStatement e)
	{
		Output.Write(e.Value);
	}

	protected override void GenerateEntryPointMethod(CodeEntryPointMethod method, CodeTypeDeclaration declaration)
	{
		method.Name = "Main";
		GenerateMethod(method, declaration);
	}

	protected override void GenerateMethod(CodeMemberMethod method, CodeTypeDeclaration declaration)
	{
		TextWriter textWriter = Output;
		if (method.CustomAttributes.Count > 0)
		{
			OutputAttributeDeclarations(method.CustomAttributes);
		}
		if (method.ReturnTypeCustomAttributes.Count > 0)
		{
			OutputAttributeDeclarations(method.ReturnTypeCustomAttributes);
		}
		MemberAttributes attributes = method.Attributes;
		if (method.PrivateImplementationType == null && !declaration.IsInterface)
		{
			OutputMemberAccessModifier(attributes);
		}
		if (!declaration.IsInterface)
		{
			OutputMemberScopeModifier(attributes);
		}
		CodeTypeReference privateImplementationType = method.PrivateImplementationType;
		if (privateImplementationType != null)
		{
			textWriter.Write(new_name());
			textWriter.Write(GetSafeName(method.Name));
		}
		else
		{
			textWriter.Write(GetSafeName(method.Name));
		}
		textWriter.Write(' ');
		textWriter.Write('(');
		OutputParameters(method.Parameters);
		textWriter.Write(')');
		textWriter.Write(" : ");
		OutputType(method.ReturnType);
		if ((attributes & MemberAttributes.ScopeMask) == MemberAttributes.Abstract || declaration.IsInterface)
		{
			textWriter.WriteLine(';');
			return;
		}
		if (privateImplementationType != null)
		{
			textWriter.Write(" implements ");
			OutputType(privateImplementationType);
			textWriter.Write(".");
			textWriter.Write(GetSafeName(method.Name));
		}
		GenerateBlock(method.Statements);
	}

	protected override void GenerateProperty(CodeMemberProperty property, CodeTypeDeclaration declaration)
	{
		TextWriter textWriter = Output;
		if (property.CustomAttributes.Count > 0)
		{
			OutputAttributeDeclarations(property.CustomAttributes);
		}
		MemberAttributes attributes = property.Attributes;
		OutputMemberAccessModifier(attributes);
		OutputMemberScopeModifier(attributes);
		if (property.Name == "Item")
		{
			textWriter.Write(GetSafeName(property.Name));
			textWriter.Write(' ');
			textWriter.Write("[");
			OutputParameters(property.Parameters);
			textWriter.Write("]");
			textWriter.Write(" : ");
			OutputType(property.Type);
		}
		else
		{
			OutputTypeNamePair(property.Type, GetSafeName(property.Name));
		}
		BracingType bracingStyle = BracingStyle;
		OutputBlockStart(bracingStyle);
		checked
		{
			Indent++;
			if (declaration.IsInterface)
			{
				if (property.HasGet)
				{
					textWriter.WriteLine("get;");
				}
				if (property.HasSet)
				{
					textWriter.WriteLine("set;");
				}
			}
			else
			{
				if (property.HasGet)
				{
					textWriter.Write("get");
					GenerateBlock(property.GetStatements);
				}
				if (property.HasSet)
				{
					textWriter.Write("set");
					GenerateBlock(property.SetStatements);
				}
			}
			Indent--;
			OutputBlockEnd(bracingStyle);
		}
	}

	protected override void GenerateConstructor(CodeConstructor constructor, CodeTypeDeclaration _declaration)
	{
		if (constructor.CustomAttributes.Count > 0)
		{
			OutputAttributeDeclarations(constructor.CustomAttributes);
		}
		OutputMemberAccessModifier(constructor.Attributes);
		Output.Write("this (");
		OutputParameters(constructor.Parameters);
		Output.Write(')');
		BracingType bracingStyle = BracingStyle;
		OutputBlockStart(bracingStyle);
		checked
		{
			Indent++;
			if (constructor.ChainedConstructorArgs.Count > 0)
			{
				Output.Write("this (");
				bool flag = true;
				IEnumerator enumerator = constructor.ChainedConstructorArgs.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object current = enumerator.Current;
						if (current is CodeExpression)
						{
							CodeExpression e = (CodeExpression)current;
							if (!flag)
							{
								Output.Write(",  ");
							}
							flag = false;
							GenerateExpression(e);
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						IDisposable disposable = (IDisposable)enumerator;
						disposable.Dispose();
					}
				}
				Output.Write(");");
			}
			if (constructor.BaseConstructorArgs.Count > 0)
			{
				Output.Write("base (");
				bool flag2 = true;
				IEnumerator enumerator2 = constructor.BaseConstructorArgs.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object current2 = enumerator2.Current;
						if (current2 is CodeExpression)
						{
							CodeExpression e2 = (CodeExpression)current2;
							if (!flag2)
							{
								Output.Write(",  ");
							}
							flag2 = false;
							GenerateExpression(e2);
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						IDisposable disposable2 = (IDisposable)enumerator2;
						disposable2.Dispose();
					}
				}
				Output.WriteLine(");");
			}
			GenerateStatements(constructor.Statements);
			Indent--;
			OutputBlockEnd(bracingStyle);
		}
	}

	protected override void GenerateTypeConstructor(CodeTypeConstructor constructor)
	{
		Output.Write("static this ()");
		GenerateBlock(constructor.Statements);
	}

	protected new void GenerateTypes(CodeNamespace e)
	{
		TextWriter textWriter = Output;
		CodeGeneratorOptions codeGeneratorOptions = Options;
		IEnumerator enumerator = e.Types.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				if (current is CodeTypeDeclaration)
				{
					CodeTypeDeclaration e2 = (CodeTypeDeclaration)current;
					if (codeGeneratorOptions.BlankLinesBetweenMembers)
					{
						textWriter.WriteLine();
					}
					((ICodeGenerator)this).GenerateCodeFromType(e2, ((IndentedTextWriter)textWriter).InnerWriter, codeGeneratorOptions);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				IDisposable disposable = (IDisposable)enumerator;
				disposable.Dispose();
			}
		}
	}

	protected override void GenerateTypeStart(CodeTypeDeclaration declaration)
	{
		CodeTypeReference codeTypeReference = null;
		TextWriter textWriter = Output;
		if (declaration.CustomAttributes.Count > 0)
		{
			OutputAttributeDeclarations(declaration.CustomAttributes);
		}
		OutputTypeAttributes(declaration);
		textWriter.Write(GetSafeName(declaration.Name));
		textWriter.Write(' ');
		IEnumerator enumerator = declaration.BaseTypes.GetEnumerator();
		if (enumerator.MoveNext())
		{
			codeTypeReference = (CodeTypeReference)enumerator.Current;
			textWriter.Write(": ");
			OutputType(codeTypeReference);
			while (enumerator.MoveNext())
			{
				codeTypeReference = (CodeTypeReference)enumerator.Current;
				textWriter.Write(",  ");
				OutputType(codeTypeReference);
			}
			textWriter.Write(' ');
		}
		if (declaration is CodeTypeDelegate)
		{
			textWriter.Write("(");
		}
		else
		{
			OutputBlockStart(BracingStyle);
		}
		checked
		{
			Indent++;
		}
	}

	protected override void GenerateTypeEnd(CodeTypeDeclaration declaration)
	{
		checked
		{
			Indent--;
			if (declaration is CodeTypeDelegate)
			{
				Output.Write(") : ");
				CodeTypeReference returnType = ((CodeTypeDelegate)declaration).ReturnType;
				if (returnType != null)
				{
					OutputType(returnType);
				}
				else
				{
					Output.Write("void");
				}
				Output.WriteLine(";");
			}
			else
			{
				OutputBlockEnd(BracingStyle);
			}
		}
	}

	protected override void GenerateNamespace(CodeNamespace ns)
	{
		GenerateCommentStatements(ns.Comments);
		GenerateNamespaceStart(ns);
		GenerateNamespaceImports(ns);
		Output.WriteLine("");
		GenerateTypes(ns);
		GenerateNamespaceEnd(ns);
	}

	protected override void GenerateNamespaceStart(CodeNamespace ns)
	{
		TextWriter textWriter = Output;
		string name = ns.Name;
		checked
		{
			if (name != null && name != "")
			{
				textWriter.Write("namespace ");
				textWriter.Write(GetSafeName(name));
				OutputBlockStart(BracingStyle);
				Indent++;
			}
		}
	}

	protected override void GenerateNamespaceEnd(CodeNamespace ns)
	{
		string name = ns.Name;
		checked
		{
			if (name != null && name != "")
			{
				Indent--;
				OutputBlockEnd(BracingStyle);
			}
		}
	}

	protected override void GenerateNamespaceImport(CodeNamespaceImport import)
	{
		TextWriter textWriter = Output;
		textWriter.Write("using ");
		textWriter.Write(GetSafeName(import.Namespace));
		textWriter.WriteLine(';');
	}

	protected override void GenerateAttributeDeclarationsStart(CodeAttributeDeclarationCollection attributes)
	{
		Output.Write('[');
		CodeTypeMember codeTypeMember = CurrentMember;
		if (codeTypeMember is CodeMemberMethod && ((CodeMemberMethod)codeTypeMember).ReturnTypeCustomAttributes == attributes)
		{
			Output.Write("return: ");
			IEnumerator enumerator = attributes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				CodeAttributeDeclaration codeAttributeDeclaration = (CodeAttributeDeclaration)enumerator.Current;
				codeAttributeDeclaration.Name = codeAttributeDeclaration.Name.Replace('+', '.');
			}
		}
	}

	protected override void GenerateAttributeDeclarationsEnd(CodeAttributeDeclarationCollection _N_wildcard_3326)
	{
		Output.WriteLine(']');
	}

	protected override void OutputType(CodeTypeReference ty)
	{
		Output.Write(GetTypeOutput(ty));
	}

	protected override void OutputTypeNamePair(CodeTypeReference ty, string name)
	{
		Output.Write(GetSafeName(name));
		Output.Write(" : ");
		Output.Write(GetTypeOutput(ty));
	}

	protected override void OutputAttributeArgument(CodeAttributeArgument arg)
	{
		TextWriter textWriter = Output;
		if (arg.Name != null && arg.Name.Length > 0)
		{
			OutputIdentifier(arg.Name);
			textWriter.Write("=");
		}
		((ICodeGenerator)this).GenerateCodeFromExpression(arg.Value, ((IndentedTextWriter)textWriter).InnerWriter, Options);
	}

	protected override void OutputAttributeDeclarations(CodeAttributeDeclarationCollection attributes)
	{
		if (attributes.Count == 0)
		{
			return;
		}
		TextWriter textWriter = Output;
		GenerateAttributeDeclarationsStart(attributes);
		bool flag = true;
		IEnumerator enumerator = attributes.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				if (!(current is CodeAttributeDeclaration))
				{
					continue;
				}
				CodeAttributeDeclaration codeAttributeDeclaration = (CodeAttributeDeclaration)current;
				if (flag)
				{
					flag = false;
				}
				else
				{
					textWriter.Write(",  ");
				}
				textWriter.Write(codeAttributeDeclaration.Name);
				if (codeAttributeDeclaration.Arguments.Count == 0)
				{
					continue;
				}
				textWriter.Write("(");
				bool flag2 = true;
				IEnumerator enumerator2 = codeAttributeDeclaration.Arguments.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object current2 = enumerator2.Current;
						if (current2 is CodeAttributeArgument)
						{
							CodeAttributeArgument arg = (CodeAttributeArgument)current2;
							if (flag2)
							{
								flag2 = false;
							}
							else
							{
								textWriter.Write(",  ");
							}
							OutputAttributeArgument(arg);
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						IDisposable disposable = (IDisposable)enumerator2;
						disposable.Dispose();
					}
				}
				textWriter.Write(")");
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				IDisposable disposable2 = (IDisposable)enumerator;
				disposable2.Dispose();
			}
		}
		GenerateAttributeDeclarationsEnd(attributes);
	}

	protected override void OutputMemberAccessModifier(MemberAttributes attributes)
	{
		TextWriter textWriter = Output;
		MemberAttributes memberAttributes = attributes & MemberAttributes.AccessMask;
		switch (memberAttributes)
		{
		case MemberAttributes.Assembly:
		case MemberAttributes.FamilyAndAssembly:
			textWriter.Write("internal ");
			return;
		case MemberAttributes.Family:
			textWriter.Write("protected ");
			return;
		case MemberAttributes.FamilyOrAssembly:
			textWriter.Write("protected internal ");
			return;
		case MemberAttributes.Private:
			textWriter.Write("private ");
			return;
		case MemberAttributes.Public:
			textWriter.Write("public ");
			return;
		}
		if (memberAttributes != 0)
		{
			throw new NotSupportedException("Unsupported access attribute");
		}
	}

	protected override void OutputMemberScopeModifier(MemberAttributes attributes)
	{
		TextWriter textWriter = Output;
		if ((attributes & MemberAttributes.New) != 0)
		{
			textWriter.Write("new ");
		}
		switch (attributes & MemberAttributes.ScopeMask)
		{
		case MemberAttributes.Abstract:
			textWriter.Write("abstract ");
			return;
		case MemberAttributes.Final:
			return;
		case MemberAttributes.Static:
			textWriter.Write("static ");
			return;
		case MemberAttributes.Override:
			textWriter.Write("override ");
			return;
		}
		if ((attributes & MemberAttributes.AccessMask) != MemberAttributes.Private)
		{
			textWriter.Write("virtual ");
		}
	}

	protected override void OutputIdentifier(string ident)
	{
		Output.Write(ident);
	}

	protected override void OutputParameters(CodeParameterDeclarationExpressionCollection parameters)
	{
		bool flag = true;
		bool flag2 = parameters.Count > 15;
		checked
		{
			if (flag2)
			{
				Indent += 3;
			}
			IEnumerator enumerator = parameters.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object current = enumerator.Current;
					if (current is CodeParameterDeclarationExpression)
					{
						CodeParameterDeclarationExpression e = (CodeParameterDeclarationExpression)current;
						if (flag)
						{
							flag = false;
						}
						else
						{
							Output.Write(",  ");
						}
						if (flag2)
						{
							ContinueOnNewLine("");
						}
						GenerateExpression(e);
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					IDisposable disposable = (IDisposable)enumerator;
					disposable.Dispose();
				}
			}
			if (flag2)
			{
				Indent -= 3;
			}
		}
	}

	protected override string QuoteSnippetString(string value)
	{
		string text = null;
		text = value.Replace("\\", "\\\\");
		text = text.Replace("\"", "\\\"");
		text = text.Replace("\t", "\\t");
		text = text.Replace("\r", "\\r");
		text = text.Replace("\n", "\\n");
		return string.Concat("\"" + text, "\"");
	}

	protected override void GenerateParameterDeclarationExpression(CodeParameterDeclarationExpression e)
	{
		if (e.CustomAttributes != null && e.CustomAttributes.Count > 0)
		{
			OutputAttributeDeclarations(e.CustomAttributes);
		}
		Output.Write(GetSafeName(e.Name));
		Output.Write(" : ");
		OutputDirection(e.Direction);
		OutputType(e.Type);
	}

	protected override void GeneratePrimitiveExpression(CodePrimitiveExpression e)
	{
		object value = e.Value;
		if (value == null)
		{
			Output.Write(NullToken);
			return;
		}
		if (value is string)
		{
			Output.Write(QuoteSnippetString((string)value));
			return;
		}
		if (value is char)
		{
			Output.Write(string.Concat("'" + (char)value, "'"));
			return;
		}
		if (value is byte)
		{
			Output.Write(((byte)value).ToString(CultureInfo.InvariantCulture));
			return;
		}
		if (value is short)
		{
			Output.Write(((short)value).ToString(CultureInfo.InvariantCulture));
			return;
		}
		if (value is int)
		{
			Output.Write(((int)value).ToString(CultureInfo.InvariantCulture));
			return;
		}
		if (value is long)
		{
			Output.Write(((long)value).ToString(CultureInfo.InvariantCulture));
			return;
		}
		if (value is float)
		{
			GenerateSingleFloatValue((float)value);
			return;
		}
		if (value is double)
		{
			GenerateDoubleValue((double)value);
			return;
		}
		if (value is decimal)
		{
			GenerateDecimalValue((decimal)value);
			return;
		}
		if (value is bool)
		{
			Output.Write((!(bool)value) ? "false" : "true");
			return;
		}
		throw new ArgumentException("InvalidPrimitiveType: " + Convert.ToString(value.GetType().ToString()));
	}

	protected override void GenerateTypeOfExpression(CodeTypeOfExpression e)
	{
		Output.Write("typeof(");
		OutputType(e.Type);
		Output.Write(")");
	}

	protected void GenerateBlock(CodeStatementCollection statements, bool endLastLine = true)
	{
		BracingType bracingStyle = BracingStyle;
		OutputBlockStart(bracingStyle);
		checked
		{
			Indent++;
			GenerateStatements(statements);
			Indent--;
			OutputBlockEnd(bracingStyle, endLastLine);
		}
	}

	protected void OutputBlockStart(BracingType bs)
	{
		switch (bs)
		{
		case BracingType.C:
			Output.WriteLine(" {");
			break;
		case BracingType.Block:
			Output.WriteLine();
			Output.WriteLine('{');
			break;
		case BracingType.Indent:
			break;
		default:
			throw new MatchFailureException();
		}
	}

	protected void OutputBlockEnd(BracingType bs, bool endLastLine = true)
	{
		switch (bs)
		{
		case BracingType.C:
			if (endLastLine)
			{
				Output.WriteLine('}');
			}
			else
			{
				Output.Write('}');
			}
			break;
		case BracingType.Block:
			Output.WriteLine('}');
			break;
		case BracingType.Indent:
			break;
		default:
			throw new MatchFailureException();
		}
	}

	protected override void OutputOperator(CodeBinaryOperatorType op)
	{
		switch (op)
		{
		default:
			throw new MatchFailureException();
		case CodeBinaryOperatorType.Add:
			Output.Write("+");
			break;
		case CodeBinaryOperatorType.Subtract:
			Output.Write("-");
			break;
		case CodeBinaryOperatorType.Multiply:
			Output.Write("*");
			break;
		case CodeBinaryOperatorType.Divide:
			Output.Write("/");
			break;
		case CodeBinaryOperatorType.Modulus:
			Output.Write("%");
			break;
		case CodeBinaryOperatorType.Assign:
			Output.Write("=");
			break;
		case CodeBinaryOperatorType.IdentityInequality:
			Output.Write("!=");
			break;
		case CodeBinaryOperatorType.IdentityEquality:
			Output.Write("==");
			break;
		case CodeBinaryOperatorType.ValueEquality:
			Output.Write("==");
			break;
		case CodeBinaryOperatorType.BitwiseOr:
			Output.Write("|");
			break;
		case CodeBinaryOperatorType.BitwiseAnd:
			Output.Write("&");
			break;
		case CodeBinaryOperatorType.BooleanOr:
			Output.Write("||");
			break;
		case CodeBinaryOperatorType.BooleanAnd:
			Output.Write("&&");
			break;
		case CodeBinaryOperatorType.LessThan:
			Output.Write("<");
			break;
		case CodeBinaryOperatorType.LessThanOrEqual:
			Output.Write("<=");
			break;
		case CodeBinaryOperatorType.GreaterThan:
			Output.Write(">");
			break;
		case CodeBinaryOperatorType.GreaterThanOrEqual:
			Output.Write(">=");
			break;
		}
	}

	protected override void OutputExpressionList(CodeExpressionCollection expressions, bool newlineBetweenItems)
	{
		TextWriter textWriter = Output;
		CodeGeneratorOptions o = Options;
		bool flag = true;
		checked
		{
			Indent++;
			IEnumerator enumerator = expressions.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object current = enumerator.Current;
					if (current is CodeExpression)
					{
						CodeExpression e = (CodeExpression)current;
						if (flag)
						{
							flag = false;
						}
						else if (newlineBetweenItems)
						{
							ContinueOnNewLine(", ");
						}
						else
						{
							textWriter.Write(",  ");
						}
						((ICodeGenerator)this).GenerateCodeFromExpression(e, ((IndentedTextWriter)textWriter).InnerWriter, o);
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					IDisposable disposable = (IDisposable)enumerator;
					disposable.Dispose();
				}
			}
			Indent--;
		}
	}

	protected override void OutputDirection(FieldDirection dir)
	{
		switch (dir)
		{
		case FieldDirection.In:
			break;
		case FieldDirection.Out:
			Output.Write("out ");
			break;
		case FieldDirection.Ref:
			Output.Write("ref ");
			break;
		default:
			throw new MatchFailureException();
		}
	}

	protected override void ContinueOnNewLine(string st)
	{
		Output.WriteLine(st);
	}

	protected override string CreateEscapedIdentifier(string value)
	{
		if (value == null)
		{
			throw new NullReferenceException("Argument identifier is null.");
		}
		return GetSafeName(value);
	}

	protected override string CreateValidIdentifier(string value)
	{
		if (value == null)
		{
			throw new NullReferenceException();
		}
		if (keywordsTable == null)
		{
			FillKeywordTable();
		}
		return (!keywordsTable.Contains(value) && !typesTable.Contains(value)) ? value : ("_" + value);
	}

	protected override string GetTypeOutput(CodeTypeReference ty)
	{
		_N_closureOf_GetTypeOutput_50358 n_closureOf_GetTypeOutput_ = new _N_closureOf_GetTypeOutput_50358();
		CodeTypeReference arrayElementType = ty.ArrayElementType;
		object obj;
		if (arrayElementType != null)
		{
			obj = string.Concat(string.Concat("array[" + ((ty.ArrayRank <= 1) ? "" : (ty.ArrayRank + ",  ")), GetTypeOutput(arrayElementType)), "]");
		}
		else
		{
			switch (ty.BaseType.ToLower(CultureInfo.InvariantCulture))
			{
			case "system.decimal":
				obj = "decimal";
				break;
			case "system.double":
				obj = "double";
				break;
			case "system.single":
				obj = "float";
				break;
			case "system.byte":
				obj = "byte";
				break;
			case "system.sbyte":
				obj = "sbyte";
				break;
			case "system.int32":
				obj = "int";
				break;
			case "system.uint32":
				obj = "uint";
				break;
			case "system.int64":
				obj = "long";
				break;
			case "system.uint64":
				obj = "ulong";
				break;
			case "system.int16":
				obj = "short";
				break;
			case "system.uint16":
				obj = "ushort";
				break;
			case "system.boolean":
				obj = "bool";
				break;
			case "system.char":
				obj = "char";
				break;
			case "system.string":
				obj = "string";
				break;
			case "system.object":
				obj = "object";
				break;
			case "system.void":
				obj = "void";
				break;
			default:
				n_closureOf_GetTypeOutput_._N_expandGenerics_50363 = new _N_expandGenerics__50391(n_closureOf_GetTypeOutput_);
				obj = GetSafeTypeName(n_closureOf_GetTypeOutput_._N_expandGenerics_50363.apply(ty));
				break;
			}
		}
		string text = (string)obj;
		return text.Replace("+", ".");
	}

	protected override bool IsValidIdentifier(string identifier)
	{
		if (keywordsTable == null)
		{
			FillKeywordTable();
		}
		return !keywordsTable.Contains(identifier) && !typesTable.Contains(identifier);
	}

	protected override bool Supports(GeneratorSupport supports)
	{
		return supports switch
		{
			GeneratorSupport.Win32Resources => false, 
			GeneratorSupport.GotoStatements => false, 
			_ => true, 
		};
	}

	private static string GetSafeName(string id)
	{
		if (keywordsTable == null)
		{
			FillKeywordTable();
		}
		return (!keywordsTable.Contains(id) && !typesTable.Contains(id)) ? id : ("@" + id);
	}

	private static string GetSafeTypeName(string id)
	{
		if (keywordsTable == null)
		{
			FillKeywordTable();
		}
		return (!keywordsTable.Contains(id)) ? id : ("@" + id);
	}

	private static void FillKeywordTable()
	{
		int num = 0;
		keywordsTable = new Hashtable();
		string[] array = keywords;
		checked
		{
			for (num = 0; num < array.Length; num++)
			{
				string text = array[num];
				text = text;
				keywordsTable.Add(text, text);
			}
			typesTable = new Hashtable();
			array = types;
			for (num = 0; num < array.Length; num++)
			{
				string text = array[num];
				text = text;
				typesTable.Add(text, text);
			}
		}
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
