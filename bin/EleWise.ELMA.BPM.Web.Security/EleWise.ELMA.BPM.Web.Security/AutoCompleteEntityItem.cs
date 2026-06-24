using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Web.Mvc.Models.Boxes;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public abstract class AutoCompleteEntityItem : AutocompleteItem
{
	public abstract string ObjectValuePrefix { get; }

	public virtual long ObjectId
	{
		get
		{
			if (!string.IsNullOrEmpty(base.Value))
			{
				if (base.Value.Contains(ObjectValuePrefix))
				{
					return GetObjectIdFromPrefixedValue(base.Value);
				}
				if (long.TryParse(base.Value, out var result))
				{
					return result;
				}
			}
			return 0L;
		}
	}

	public abstract string SelectedItemTemplateJs { get; }

	public virtual string IconUrl { get; set; }

	public virtual long GetObjectIdFromPrefixedValue(string value)
	{
		return BaseEntityUserTypeSelector.GetObjectId(ObjectValuePrefix, value);
	}
}
