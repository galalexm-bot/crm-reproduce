using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Helpers;

public static class SettingsHelper
{
	public static int GetRelationTypeInt(this TypeSettings settings)
	{
		RelationType? relationTypeOrNull = settings.GetRelationTypeOrNull();
		if (relationTypeOrNull.get_HasValue())
		{
			return (int)relationTypeOrNull.get_Value();
		}
		return 0;
	}

	public static RelationType? GetRelationTypeOrNull(this TypeSettings settings)
	{
		if (settings == null)
		{
			return null;
		}
		if (settings != null)
		{
			EntitySettings val;
			if ((val = (EntitySettings)(object)((settings is EntitySettings) ? settings : null)) != null)
			{
				return (RelationType)val.get_RelationType();
			}
			DataClassSettings val2;
			if ((val2 = (DataClassSettings)(object)((settings is DataClassSettings) ? settings : null)) != null)
			{
				return (RelationType)val2.get_RelationType();
			}
		}
		return null;
	}
}
