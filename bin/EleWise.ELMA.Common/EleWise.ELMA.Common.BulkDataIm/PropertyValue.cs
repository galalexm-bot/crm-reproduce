using System.Collections.Generic;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class PropertyValue
{
	public IDictionary<string, object> Columns { get; private set; }

	public MapPropertyInfo PropertyInfo { get; private set; }

	public PropertyValue(MapPropertyInfo propertyInfo)
	{
		PropertyInfo = propertyInfo;
		Columns = new Dictionary<string, object>();
		foreach (string column in propertyInfo.Columns)
		{
			if (!string.IsNullOrEmpty(column))
			{
				Columns.Add(column, null);
			}
		}
	}

	public override string ToString()
	{
		return $"{PropertyInfo.TableName}: {PropertyInfo.Name}";
	}
}
