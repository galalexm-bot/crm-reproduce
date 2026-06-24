using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.CodeGeneration.CSharp.Extensions;

internal static class AccessibilityExtensions
{
	public static void Generate(this Accessibility accessibility)
	{
		switch (accessibility)
		{
		case Accessibility.Private:
			GenerationContext.Current.Write("private ");
			break;
		case Accessibility.Protected:
			GenerationContext.Current.Write("protected ");
			break;
		case Accessibility.Internal:
			GenerationContext.Current.Write("internal ");
			break;
		case Accessibility.ProtectedAndInternal:
		case Accessibility.ProtectedOrInternal:
			GenerationContext.Current.Write("protected internal ");
			break;
		case Accessibility.Public:
			GenerationContext.Current.Write("public ");
			break;
		}
	}
}
