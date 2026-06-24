using System;

namespace EleWise.ELMA.Common.Models.Filters;

[Serializable]
public class SearchFieldsData
{
	public Guid PropertyUid { get; set; }

	public string PropertyName { get; set; }

	public SearchFieldsData()
	{
	}

	public SearchFieldsData(string stringValue)
	{
		int num = stringValue.IndexOf('|');
		PropertyUid = Guid.Parse(stringValue.Remove(num));
		PropertyName = stringValue.Substring(num + 1);
	}

	public override string ToString()
	{
		return string.Concat(PropertyUid, "|", PropertyName);
	}
}
