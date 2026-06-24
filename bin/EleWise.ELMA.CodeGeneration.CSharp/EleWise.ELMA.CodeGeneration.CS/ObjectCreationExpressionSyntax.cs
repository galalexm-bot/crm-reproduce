using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class ObjectCreationExpressionSyntax : ExpressionSyntax
{
	private readonly TypeSyntax type;

	private readonly ExpressionSyntax[] arguments;

	private readonly ExpressionSyntax[] parameters;

	public ObjectCreationExpressionSyntax(TypeSyntax type, IEnumerable<ExpressionSyntax> arguments, IEnumerable<ExpressionSyntax> parameters)
		: base(ExpressionSyntaxPriority.ObjectCreation)
	{
		this.type = type;
		this.arguments = arguments.ToArrayOrEmpty();
		this.parameters = parameters.ToArrayOrEmpty();
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write("new ").Write(type).If(arguments.Length != 0 || parameters.Length == 0, delegate(GenerationContext _)
		{
			_.Write("(").WriteComaSeparated(arguments).Write(")");
		})
			.If(parameters.Length != 0, delegate(GenerationContext _)
			{
				_.WriteLine().WriteLine("{").Indentation(delegate(GenerationContext __)
				{
					__.WriteNewLineComaSeparated(parameters);
				})
					.WriteLine()
					.Write("}");
			});
	}
}
