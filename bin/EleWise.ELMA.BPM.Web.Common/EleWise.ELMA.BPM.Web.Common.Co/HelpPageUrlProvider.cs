using System.Globalization;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Help;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = -1)]
public class HelpPageUrlProvider : XmlMapHelpPageUrlProvider
{
	private const string HelpIndexPath = "~/Modules/EleWise.ELMA.BPM.Web.Common/Content/Help/{0}/HelpIndex.xml";

	protected override string Icon => "";

	protected override string Index
	{
		get
		{
			CultureInfo cultureInfo = SR.GetCurrentCulture() ?? Thread.CurrentThread.CurrentCulture;
			CultureInfo baseCultureInfo = SR.LanguagesMap.GetBaseCultureInfo(cultureInfo.Name);
			return $"~/Modules/EleWise.ELMA.BPM.Web.Common/Content/Help/{baseCultureInfo.Name}/WebHelp/index.htm";
		}
	}

	protected override string Name => SR.T("Платформа");

	protected override string Description => SR.T("Документация по платформе системы: задачи, календарь, архив документов, портал.");

	public HelpPageUrlProvider()
		: base("~/Modules/EleWise.ELMA.BPM.Web.Common/Content/Help/{0}/HelpIndex.xml")
	{
	}
}
