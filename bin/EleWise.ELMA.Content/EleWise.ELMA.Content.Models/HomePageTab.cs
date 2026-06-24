using System;
using System.ComponentModel;

namespace EleWise.ELMA.Content.Models;

[Serializable]
public class HomePageTab
{
	public string Name { get; set; }

	public bool Default { get; set; }

	public long Id { get; set; }

	public long Order { get; set; }

	[Obsolete("Not used", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool Visible { get; set; } = true;


	public string Parameters { get; set; }

	public HomePageTab()
	{
	}

	public HomePageTab(IPortalObject page)
	{
		Id = page.Id;
		Name = page.Name;
	}
}
