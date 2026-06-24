using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.PeriodicalEntitySettings;
using EleWise.ELMA.Extensions;
using Newtonsoft.Json;

namespace EleWise.ELMA.Common.Serialization;

internal static class PeriodicalEntitySettingsSerializer
{
	public static IPeriodicalEntitySettings Deserialize(Periodicity periodicity, string data)
	{
		if (data.IsNullOrWhiteSpace() || periodicity == Periodicity.WorkingDays || periodicity == Periodicity.Quarterly)
		{
			return null;
		}
		PeriodicalEntitySettingsCustomCreationConverter periodicalEntitySettingsCustomCreationConverter = new PeriodicalEntitySettingsCustomCreationConverter(periodicity);
		return JsonConvert.DeserializeObject<IPeriodicalEntitySettings>(data, (JsonConverter[])(object)new JsonConverter[1] { (JsonConverter)periodicalEntitySettingsCustomCreationConverter });
	}

	public static string Serialize(IPeriodicalEntitySettings periodicalEntitySettings)
	{
		if (periodicalEntitySettings == null)
		{
			return string.Empty;
		}
		return JsonConvert.SerializeObject((object)periodicalEntitySettings);
	}
}
