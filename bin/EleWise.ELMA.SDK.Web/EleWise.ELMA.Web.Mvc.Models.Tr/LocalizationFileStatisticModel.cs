using EleWise.ELMA.Globalization;

namespace EleWise.ELMA.Web.Mvc.Models.Translate;

public class LocalizationFileStatisticModel
{
	public string FileName { get; set; }

	public long Total { get; set; }

	public int Progress { get; set; }

	public long Fuzzy { get; set; }

	public long Translated { get; set; }

	public long HighPriority { get; set; }

	public PoLineFilter Filter { get; set; }

	public void RecalcByFilter(LocalizationHolder target)
	{
		if (Filter != null)
		{
			LocalizationStatistic statistic = LocalizationHolder.GetStatistic(target, Filter);
			Total = statistic.TotalStrings;
			Progress = statistic.TotalProgress;
			Fuzzy = statistic.TotalFuzzy;
			Translated = statistic.Translated;
			HighPriority = statistic.TotalHighStrings;
		}
	}
}
