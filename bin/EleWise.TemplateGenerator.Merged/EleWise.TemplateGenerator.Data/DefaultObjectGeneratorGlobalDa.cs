using System.Collections.Generic;

namespace EleWise.TemplateGenerator.DataSources;

public class DefaultObjectGeneratorGlobalDataSource : IGeneratorGlobalDataSource
{
	private object dataSourceObject;

	private Dictionary<string, BlockInfo> blockInfos = new Dictionary<string, BlockInfo>();

	public DefaultObjectGeneratorGlobalDataSource(object dataSourceObject)
	{
		this.dataSourceObject = dataSourceObject;
	}

	public FormatedValue GetVariableValue(string name)
	{
		if (dataSourceObject == null || string.IsNullOrEmpty(name))
		{
			return null;
		}
		string[] propertyNames = GetPropertyNames(name);
		return GetValue(propertyNames);
	}

	private string[] GetPropertyNames(string name)
	{
		string[] array = name.Split(".".ToCharArray());
		int num = 0;
		string[] array2 = array;
		foreach (string text in array2)
		{
			array[num++] = text.Trim();
		}
		return array;
	}

	protected virtual FormatedValue GetValue(string[] propertyNames)
	{
		return new FormatedValue
		{
			Value = ""
		};
	}
}
