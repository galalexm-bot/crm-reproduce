using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class ConstructorDeclarationSyntax : MemberSyntax
{
	private readonly ParameterDeclarationSyntax[] _parameters;

	private readonly Accessibility _accessibility;

	private readonly DeclarationModifiers _modifiers;

	private readonly string _constructorName;

	private readonly ExpressionSyntax[] _constructorArguments;

	private readonly StatementSyntax[] _statements;

	public ConstructorDeclarationSyntax(IEnumerable<ParameterDeclarationSyntax> parameters, Accessibility accessibility, DeclarationModifiers modifiers, IEnumerable<ExpressionSyntax> baseConstructorArguments, IEnumerable<ExpressionSyntax> thisConstructorArguments, IEnumerable<StatementSyntax> statements)
	{
		if (baseConstructorArguments != null && thisConstructorArguments != null)
		{
			throw new ArgumentException("Only one of baseConstructorArguments and thisConstructorArguments can be filled");
		}
		_parameters = parameters.ToArrayOrEmpty();
		_accessibility = accessibility;
		_modifiers = modifiers;
		_constructorName = ((baseConstructorArguments != null) ? "base" : ((thisConstructorArguments != null) ? "this" : null));
		_constructorArguments = (baseConstructorArguments ?? thisConstructorArguments).ToArrayOrNull();
		_statements = statements.ToArrayOrEmpty();
	}

	protected override void InternalGenerate()
	{
		GenerationContext.Current.Write(_accessibility).Write(_modifiers).Write(((InterfaceDeclarationSyntax)GenerationContext.Current.ParentNode).Name)
			.Write("(")
			.WriteComaSeparated(_parameters)
			.WriteLine(")")
			.If(_constructorArguments != null, delegate(GenerationContext ca)
			{
				ca.Indentation(delegate(GenerationContext _)
				{
					_.Write(": ").Write(_constructorName).Write("(")
						.WriteComaSeparated(_constructorArguments)
						.WriteLine(")");
				});
			})
			.WriteLine("{")
			.Indentation(_statements)
			.WriteLine("}");
	}
}
