using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class SetPropertyInfo
{
	private readonly ImportSettings importSettings;

	public SetPropertyInfo(ImportSettings importSettings)
	{
		this.importSettings = importSettings;
	}

	public MapObject FindObject(Type objectType, Dictionary<string, object> keyValues)
	{
		return importSettings.FindObject(objectType, keyValues);
	}
}
