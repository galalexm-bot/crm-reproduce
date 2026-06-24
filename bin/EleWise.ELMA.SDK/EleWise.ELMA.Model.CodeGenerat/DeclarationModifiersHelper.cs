using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.Model.CodeGeneration;

public static class DeclarationModifiersHelper
{
	public static EleWise.ELMA.CodeGeneration.CSharp.Enums.DeclarationModifiers Unpack(this DeclarationModifiers modifiers)
	{
		return (EleWise.ELMA.CodeGeneration.CSharp.Enums.DeclarationModifiers)modifiers;
	}
}
