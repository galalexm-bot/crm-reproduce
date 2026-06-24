using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Content;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
public class ThemeSettingsController : BPMController
{
	private readonly ColorSchemeManager colorSchemeManager;

	public ThemeSettingsModule SettingsModule { get; set; }

	public ThemeSettings Settings => SettingsModule.Settings;

	public ThemeSettingsController(ColorSchemeManager colorSchemeManager)
	{
		this.colorSchemeManager = colorSchemeManager;
	}

	[ContentItem(Name = "SR.M('Цветовые схемы')", Id = "portal-color-schemes", Image24 = "#work_place.svg")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command)
	{
		GridData<IColorScheme> gridData = colorSchemeManager.CreateGridData(command);
		gridData.IsPageable = false;
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[HttpPost]
	public JsonResult SetCurrentScheme(long schemeId)
	{
		if (colorSchemeManager.LoadOrNull(schemeId) == null)
		{
			return ((Controller)this).Json((object)new
			{
				success = false,
				error = SR.T("Не удалось найти цветовую схему с идентификатором {0}", schemeId)
			});
		}
		Settings.CurrentColorSchemeId = schemeId;
		SettingsModule.SaveSettings();
		return ((Controller)this).Json((object)new
		{
			success = true
		});
	}

	[HttpGet]
	[Obsolete("Не используется", true)]
	public ActionResult View()
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)Settings);
	}

	[HttpGet]
	[Obsolete("Не используется", true)]
	public ActionResult Edit()
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)Settings);
	}
}
