using System.Collections.Generic;
using EleWise.TemplateGenerator.DataSources;

namespace EleWise.TemplateGenerator.Functions;

public class FunctionEvaluationContext
{
	public GenerationContext GenerationContext { get; set; }

	public IGeneratorDataSource DataSource { get; set; }

	public List<FormatedValue> Parameters { get; set; }
}
