using System;
using System.Linq;
using EleWise.ELMA.Globalization;

namespace EleWise.ELMA.Web.Mvc.Models.Translate;

public class PoEditorModel
{
	public string TargetLocal { get; set; }

	public string CurrentLocal { get; set; }

	public LocalizationHolder Current { get; set; }

	public LocalizationHolder Target { get; set; }

	public LocalizationFile SelectedFile { get; set; }

	public LocalizationStatistic TotalStatistic { get; set; }

	public bool Block { get; set; }

	public bool NeedMerge { get; set; }

	public void Init()
	{
		foreach (LocalizationFile file in Current.Files)
		{
			if (Target.Files.FirstOrDefault((LocalizationFile f) => f.Name.Equals(file.Name, StringComparison.OrdinalIgnoreCase)) == null)
			{
				Target.Files.Add(new LocalizationFile
				{
					LocalizationName = TargetLocal,
					Name = file.Name
				});
			}
		}
	}
}
