using System;
using System.Web.Mvc;
using EleWise.ELMA.Actions;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.Content.Constants;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
public class ColorSchemeController : BPMController<IColorScheme, long>
{
	private readonly ColorSchemeManager colorSchemeManager;

	public ColorSchemeController(ColorSchemeManager colorSchemeManager)
	{
		this.colorSchemeManager = colorSchemeManager;
	}

	public ActionResult Create()
	{
		ColorSchemeModel colorSchemeModel = new ColorSchemeModel
		{
			ColorSchemeSettings = ColorSchemeConst.DefaultColorSchemeSettings
		};
		return (ActionResult)(object)((Controller)this).PartialView("EditPopup", (object)colorSchemeModel);
	}

	public ActionResult Edit(long schemeId)
	{
		IColorScheme colorScheme = colorSchemeManager.LoadOrNull(schemeId);
		Contract.CheckWithMessage<ArgumentException>(colorScheme != null, SR.T("Не удалось найти цветовую схему с идентификатором {0}", schemeId));
		Contract.CheckWithMessage<ArgumentException>(colorSchemeManager.CanEdit(colorScheme), SR.T("Цветовая схема с идентификатором {0} недоступна для редактирования", schemeId));
		ColorSchemeModel colorSchemeModel = new ColorSchemeModel(colorScheme);
		return (ActionResult)(object)((Controller)this).PartialView("EditPopup", (object)colorSchemeModel);
	}

	public ActionResult Copy(long schemeId)
	{
		IColorScheme colorScheme = colorSchemeManager.LoadOrNull(schemeId);
		Contract.CheckWithMessage<ArgumentException>(colorScheme != null, SR.T("Не удалось найти цветовую схему с идентификатором {0}", schemeId));
		ColorSchemeModel colorSchemeModel = new ColorSchemeModel
		{
			ColorSchemeSettings = ColorSchemeSettingsModel.FromColorScheme(colorScheme)
		};
		return (ActionResult)(object)((Controller)this).PartialView("EditPopup", (object)colorSchemeModel);
	}

	public JsonResult Delete(long schemeId)
	{
		IColorScheme colorScheme = colorSchemeManager.LoadOrNull(schemeId);
		if (colorScheme == null)
		{
			return ((Controller)this).Json((object)new
			{
				success = false,
				error = SR.T("Не удалось найти цветовую схему с идентификатором {0}", schemeId)
			});
		}
		ActionCheckResult actionCheckResult = colorSchemeManager.CanDelete(colorScheme);
		if (!actionCheckResult.Result)
		{
			return ((Controller)this).Json((object)new
			{
				success = false,
				error = actionCheckResult.ErrorMessage
			});
		}
		colorSchemeManager.Delete(colorScheme);
		return ((Controller)this).Json((object)new
		{
			success = true
		});
	}

	public JsonResult Save(ColorSchemeModel colorSchemeModel)
	{
		if (colorSchemeModel.Entity.Name.IsNullOrWhiteSpace())
		{
			return ((Controller)this).Json((object)new
			{
				success = false,
				error = SR.T("Имя цветовой схемы не может быть пустым")
			});
		}
		if (!colorSchemeModel.Entity.IsNew() && !colorSchemeManager.CanEdit(colorSchemeModel.Entity))
		{
			return ((Controller)this).Json((object)new
			{
				success = false,
				error = SR.T("Не удалось сохранить цветовую схему с идентификатором {0}", colorSchemeModel.Entity.Id)
			});
		}
		ActionCheckResult actionCheckResult = colorSchemeManager.CanSave(colorSchemeModel.Entity);
		if (!actionCheckResult.Result)
		{
			return ((Controller)this).Json((object)new
			{
				success = false,
				error = actionCheckResult.ErrorMessage
			});
		}
		colorSchemeManager.SetColorSchemeSettings(colorSchemeModel.Entity, colorSchemeModel.ColorSchemeSettings);
		return ((Controller)this).Json((object)new
		{
			success = true
		});
	}
}
