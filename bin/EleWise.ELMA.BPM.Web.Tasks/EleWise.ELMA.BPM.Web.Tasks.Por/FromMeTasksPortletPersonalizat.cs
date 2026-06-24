using System;
using System.Web.Mvc;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Tasks.Portlets;

[Serializable]
public class FromMeTasksPortletPersonalization : PortletPersonalization
{
	private int daysAgo = 1;

	private int daysAhead = 1;

	private bool showCompleted = true;

	[Personalization(PersonalizationScope.User)]
	[Required(true)]
	[HiddenInput(DisplayValue = false)]
	public int DaysAgo
	{
		get
		{
			return daysAgo;
		}
		set
		{
			daysAgo = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[Required(true)]
	[HiddenInput(DisplayValue = false)]
	public int DaysAhead
	{
		get
		{
			return daysAhead;
		}
		set
		{
			daysAhead = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public bool ShowCompleted
	{
		get
		{
			return showCompleted;
		}
		set
		{
			showCompleted = value;
		}
	}
}
