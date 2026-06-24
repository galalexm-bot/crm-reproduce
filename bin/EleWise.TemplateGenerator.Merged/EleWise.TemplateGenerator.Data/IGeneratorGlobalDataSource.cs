namespace EleWise.TemplateGenerator.DataSources;

public interface IGeneratorGlobalDataSource
{
	FormatedValue GetVariableValue(string name);
}
