using System;

namespace EleWise.ELMA.Web.Mvc.Menu;

[Serializable]
public class MenuState
{
	public string Id { get; set; }

	public bool Collapsed { get; set; }

	public int Width { get; set; }
}
