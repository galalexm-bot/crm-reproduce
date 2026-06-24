using System;
using System.Collections.Generic;
using EleWise.ELMA.Content.Models;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class HomePagesModel
{
	public List<HomePageTab> VisibleTabs { get; set; }

	[Obsolete("Не используется")]
	public List<HomePageTab> HiddenTabs { get; set; }

	public IPageContentModel CurrentPageModel { get; set; }

	public bool AllowedSetupTabs { get; set; }

	public Exception Exception { get; set; }

	public long? ActivePageId { get; set; }
}
