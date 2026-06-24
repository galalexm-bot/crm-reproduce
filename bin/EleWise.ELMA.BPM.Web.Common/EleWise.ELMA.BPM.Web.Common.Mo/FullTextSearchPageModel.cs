using System.Collections.Generic;
using EleWise.ELMA.FullTextSearch;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Settings;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class FullTextSearchPageModel
{
	public bool StateOnOff => State switch
	{
		FullTextSearchState.Off => false, 
		FullTextSearchState.Ready => true, 
		FullTextSearchState.On => true, 
		_ => false, 
	};

	public FullTextSearchState State { get; set; }

	public FullTextSearchSettings Settings => Locator.GetServiceNotNull<FullTextSearchSettingsModule>().Settings;

	public IFullTextSearchProviderSettings ProviderSettings { get; set; }

	public List<IFullTextSearchModuleSettings> ModuleSettings { get; set; }

	public FullTextSearchPageModel()
	{
		ModuleSettings = new List<IFullTextSearchModuleSettings>();
	}

	public FullTextSearchPageModel(List<IFullTextSearchModuleSettings> moduleSettings)
	{
		ModuleSettings = moduleSettings;
	}
}
