using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.Model.CodeGeneration;

public static class AccessibilityHelper
{
	public static EleWise.ELMA.CodeGeneration.CSharp.Enums.Accessibility Unpack(this Accessibility accessibility)
	{
		return (EleWise.ELMA.CodeGeneration.CSharp.Enums.Accessibility)accessibility;
	}
}
