using System.Collections.Generic;
using System.Linq;
using Orchard.Commands;
using Orchard.Localization.Services;

namespace Orchard.Localization.Commands;

public class CultureCommands : DefaultOrchardCommandHandler
{
	private readonly ICultureManager _cultureManager;

	private readonly IOrchardServices _orchardServices;

	public CultureCommands(ICultureManager cultureManager, IOrchardServices orchardServices)
	{
		_cultureManager = cultureManager;
		_orchardServices = orchardServices;
	}

	[CommandHelp("cultures list \r\n\tList site cultures")]
	[CommandName("cultures list")]
	public void ListCultures()
	{
		base.Context.Output.WriteLine(base.T("Listing Cultures:"));
		string value = string.Join(" ", _cultureManager.ListCultures());
		base.Context.Output.WriteLine(value);
	}

	[CommandHelp("cultures get site culture \r\n\tGet culture for the site")]
	[CommandName("cultures get site culture")]
	public void GetSiteCulture()
	{
		base.Context.Output.WriteLine(base.T("Site Culture is {0}", _orchardServices.WorkContext.CurrentSite.SiteCulture));
	}

	[CommandHelp("cultures set site culture <culture-name> \r\n\tSet culture for the site")]
	[CommandName("cultures set site culture")]
	public void SetSiteCulture(string cultureName)
	{
		base.Context.Output.WriteLine(base.T("Setting site culture to {0}", cultureName));
		if (!_cultureManager.IsValidCulture(cultureName))
		{
			base.Context.Output.WriteLine(base.T("Supplied culture name {0} is not valid.", cultureName));
			return;
		}
		_cultureManager.AddCulture(cultureName);
		_orchardServices.WorkContext.CurrentSite.SiteCulture = cultureName;
		base.Context.Output.WriteLine(base.T("Site culture set to {0} successfully", cultureName));
	}

	[CommandHelp("cultures add <culture-name-1> ... <culture-name-n>\r\n\tAdd one or more cultures to the site")]
	[CommandName("cultures add")]
	public void AddCultures(params string[] cultureNames)
	{
		IEnumerable<string> siteCultures = _cultureManager.ListCultures();
		base.Context.Output.WriteLine(base.T("Adding site cultures {0}", string.Join(",", cultureNames)));
		foreach (string item in from s in cultureNames.Distinct()
			where !siteCultures.Contains(s)
			select s)
		{
			if (_cultureManager.IsValidCulture(item))
			{
				_cultureManager.AddCulture(item);
				continue;
			}
			base.Context.Output.WriteLine(base.T("Supplied culture name {0} is not valid.", item));
		}
	}
}
