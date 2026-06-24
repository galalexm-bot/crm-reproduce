using System.Collections.Generic;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Providers;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class MapPropertyInfo
{
	public bool IsRelations { get; set; }

	public IMapTypeExtension TypeExtension { get; set; }

	public PropertyMetadata PropertyMetadata { get; private set; }

	public string Name { get; private set; }

	public bool ImportKey { get; private set; }

	public string TableName { get; private set; }

	public IMapPropertyExtension PropertyExtension { get; private set; }

	public IList<string> Columns { get; private set; }

	public MapPropertyInfo(PropertyMetadata propertyMetadata, List<string> columns, bool isImportKey, string tableName, IMapPropertyExtension propertyExtension)
		: this(propertyMetadata.Name, columns, isImportKey, tableName, propertyExtension)
	{
		PropertyMetadata = propertyMetadata;
	}

	public MapPropertyInfo(string propertyName, List<string> columns, bool isImportKey, string tableName, IMapPropertyExtension propertyExtension)
	{
		Name = propertyName;
		ImportKey = isImportKey;
		TableName = tableName;
		PropertyExtension = propertyExtension;
		Columns = new List<string>();
		foreach (string column in columns)
		{
			Columns.Add(column);
		}
	}

	public override string ToString()
	{
		return string.Format("{0}, {1}{2}", TableName, Name, ImportKey ? " [KEY]" : "");
	}
}
