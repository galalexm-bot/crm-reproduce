using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.CodeGeneration.CSharp.Extensions;

internal static class DeclarationModifiersExtensions
{
	public static void Generate(this DeclarationModifiers modifiers)
	{
		if ((modifiers & DeclarationModifiers.Abstract) > DeclarationModifiers.None)
		{
			GenerationContext.Current.Write("abstract ");
		}
		if ((modifiers & DeclarationModifiers.New) > DeclarationModifiers.None)
		{
			GenerationContext.Current.Write("new ");
		}
		if ((modifiers & DeclarationModifiers.Sealed) > DeclarationModifiers.None)
		{
			GenerationContext.Current.Write("sealed ");
		}
		if ((modifiers & DeclarationModifiers.Override) > DeclarationModifiers.None)
		{
			GenerationContext.Current.Write("override ");
		}
		if ((modifiers & DeclarationModifiers.Virtual) > DeclarationModifiers.None)
		{
			GenerationContext.Current.Write("virtual ");
		}
		if ((modifiers & DeclarationModifiers.Static) > DeclarationModifiers.None)
		{
			GenerationContext.Current.Write("static ");
		}
		if ((modifiers & DeclarationModifiers.Async) > DeclarationModifiers.None)
		{
			GenerationContext.Current.Write("async ");
		}
		if ((modifiers & DeclarationModifiers.Const) > DeclarationModifiers.None)
		{
			GenerationContext.Current.Write("const ");
		}
		if ((modifiers & DeclarationModifiers.ReadOnly) > DeclarationModifiers.None)
		{
			GenerationContext.Current.Write("readonly ");
		}
		if ((modifiers & DeclarationModifiers.Unsafe) > DeclarationModifiers.None)
		{
			GenerationContext.Current.Write("unsafe ");
		}
		if ((modifiers & DeclarationModifiers.Partial) > DeclarationModifiers.None)
		{
			GenerationContext.Current.Write("partial ");
		}
	}
}
