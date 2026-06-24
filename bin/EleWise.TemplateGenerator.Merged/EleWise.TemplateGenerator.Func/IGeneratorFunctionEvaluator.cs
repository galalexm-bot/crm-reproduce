using System.Collections.Generic;

namespace EleWise.TemplateGenerator.Functions;

public interface IGeneratorFunctionEvaluator
{
	FormatedValue Evaluate(string name, List<FormatedValue> parameters);
}
