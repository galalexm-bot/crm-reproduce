using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.Model.CodeGeneration;

public static class SpecialTypeConstraintKindHelper
{
	public static EleWise.ELMA.CodeGeneration.CSharp.Enums.SpecialTypeConstraintKind Unpack(this SpecialTypeConstraintKind refKind)
	{
		return (EleWise.ELMA.CodeGeneration.CSharp.Enums.SpecialTypeConstraintKind)refKind;
	}
}
