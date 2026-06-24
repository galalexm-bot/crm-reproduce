using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class MethodDeclarationSyntax : InterfaceMemberSyntax
{
	private ParameterDeclarationSyntax[] _parameters;

	private string[] _typeParameters;

	private StatementSyntax[] _statements;

	public MethodDeclarationSyntax(string name, IEnumerable<ParameterDeclarationSyntax> parameters, IEnumerable<string> typeParameters, TypeSyntax returnType, Accessibility accessibility, DeclarationModifiers modifiers, IEnumerable<StatementSyntax> statements)
		: base(name, returnType, accessibility, modifiers)
	{
		_parameters = parameters.ToArrayOrEmpty();
		_typeParameters = typeParameters.ToArrayOrNull();
		_statements = statements.ToArrayOrEmpty();
	}

	protected override void InternalGenerate()
	{
		bool flag = GenerationContext.Current.ParentNode is ClassDeclarationSyntax;
		GenerationContext.Current.Call(delegate
		{
			base.InternalGenerate();
		}).If(_typeParameters != null, delegate(GenerationContext _)
		{
			_.Write("<").WriteComaSeparated(_typeParameters).Write(">");
		}).Write("(")
			.WriteComaSeparated(_parameters)
			.Write(")")
			.Call(delegate
			{
				GenerateTypeConstraints();
			})
			.If(flag && !_modifiers.HasFlag(DeclarationModifiers.Abstract), delegate(GenerationContext _)
			{
				_.WriteLine().WriteLine("{").Indentation(_statements)
					.WriteLine("}");
			})
			.If(!flag || _modifiers.HasFlag(DeclarationModifiers.Abstract), delegate(GenerationContext _)
			{
				_.WriteLine(";");
			});
	}
}
