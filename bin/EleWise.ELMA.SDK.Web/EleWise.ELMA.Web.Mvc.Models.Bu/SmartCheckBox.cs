using System;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;

namespace EleWise.ELMA.Web.Mvc.Models.Buttons;

public class SmartCheckBox
{
	public string Id { get; set; }

	public string Name { get; set; }

	public ActionMenu Menu { get; set; }

	public string MenuScript { get; set; }

	public string DefaultScript { get; set; }

	public bool Checked { get; set; }

	public SmartCheckBox()
	{
		Id = Guid.NewGuid().ToString().Replace("-", "");
	}
}
