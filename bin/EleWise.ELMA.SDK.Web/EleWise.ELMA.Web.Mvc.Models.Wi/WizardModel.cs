using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Models.Wizard;

public class WizardModel
{
	private string routeName;

	private string actionName;

	private string controllerName;

	private string url;

	public string Name { get; set; }

	public IList<WizardItem> Items { get; set; }

	public string CssClass { get; set; }

	public string ControllerName
	{
		get
		{
			return controllerName;
		}
		set
		{
			controllerName = value;
		}
	}

	public string ActionName
	{
		get
		{
			return actionName;
		}
		set
		{
			actionName = value;
		}
	}

	public string RouteName
	{
		get
		{
			return routeName;
		}
		set
		{
			routeName = value;
		}
	}

	public string Url
	{
		get
		{
			return url;
		}
		set
		{
			url = value;
		}
	}

	public string FormName { get; set; }

	public bool RenderForm { get; set; }

	public WizardModel(string name)
	{
		Name = name;
		FormName = Name;
		RenderForm = true;
	}
}
