using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class ModulesIndexViewModel
{
	public bool InstallModules { get; set; }

	public bool BrowseToGallery { get; set; }

	public IEnumerable<ModuleViewModel> Modules { get; set; }
}
