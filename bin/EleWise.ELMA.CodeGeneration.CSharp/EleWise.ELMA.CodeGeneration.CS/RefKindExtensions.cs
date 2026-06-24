using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.CodeGeneration.CSharp.Extensions;

internal static class RefKindExtensions
{
	public static void Generate(this RefKind refKind)
	{
		switch (refKind)
		{
		case RefKind.Ref:
			GenerationContext.Current.Write("ref ");
			break;
		case RefKind.Out:
			GenerationContext.Current.Write("out ");
			break;
		}
	}
}
