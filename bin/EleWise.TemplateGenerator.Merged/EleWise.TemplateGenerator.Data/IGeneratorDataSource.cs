namespace EleWise.TemplateGenerator.DataSources;

public interface IGeneratorDataSource
{
	FormatedValue GetVariableValue(string name);

	BlockInfo EnterBlock(string identifier, FormatedValue value);

	void SetBlockIndex(string identifier, int index);

	void LeaveBlock(string identifier);

	BlockInfo GetBlockInfo(string identifier);
}
