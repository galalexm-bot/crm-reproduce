using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class LiteralExpressionSyntax : ExpressionSyntax
{
	private readonly object _value;

	private readonly bool _escapeNonPrintable;

	public LiteralExpressionSyntax(object value, bool escapeNonPrintable = true)
		: base(ExpressionSyntaxPriority.Identifier)
	{
		_value = value;
		_escapeNonPrintable = escapeNonPrintable;
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write(ObjectDisplay.FormatPrimitive(_value, _escapeNonPrintable ? (ObjectDisplayOptions.IncludeTypeSuffix | ObjectDisplayOptions.UseQuotes | ObjectDisplayOptions.EscapeNonPrintableCharacters) : (ObjectDisplayOptions.IncludeTypeSuffix | ObjectDisplayOptions.UseQuotes)));
	}
}
