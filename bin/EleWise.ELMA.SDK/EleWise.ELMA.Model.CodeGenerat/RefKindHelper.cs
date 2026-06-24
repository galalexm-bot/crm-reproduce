using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.Model.CodeGeneration;

public static class RefKindHelper
{
	public static EleWise.ELMA.CodeGeneration.CSharp.Enums.RefKind Unpack(this RefKind refKind)
	{
		return (EleWise.ELMA.CodeGeneration.CSharp.Enums.RefKind)refKind;
	}
}
