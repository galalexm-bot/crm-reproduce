using System;

namespace EleWise.ELMA.Model.CodeGeneration;

public interface IAutoClassGenerator
{
	string GenerateCode(Type interfaceType, params Type[] extensionTypes);
}
