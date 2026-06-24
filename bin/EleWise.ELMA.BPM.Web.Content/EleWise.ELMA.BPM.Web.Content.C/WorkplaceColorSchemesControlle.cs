using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.Content.Constants;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
public class WorkplaceColorSchemesController : BPMController
{
	private const string PortalActiveMenuItem = "portal-workplace";

	private readonly ColorSchemeManager colorSchemeManager;

	private readonly WorkPlaceManager workPlaceManager;

	private readonly EntityManager<IWorkplaceColorScheme, long> workplaceColorSchemeeManager;

	public WorkplaceColorSchemesController(ColorSchemeManager colorSchemeManager, WorkPlaceManager workPlaceManager, EntityManager<IWorkplaceColorScheme, long> workplaceColorSchemeeManager)
	{
		this.colorSchemeManager = colorSchemeManager;
		this.workPlaceManager = workPlaceManager;
		this.workplaceColorSchemeeManager = workplaceColorSchemeeManager;
	}

	public ActionResult Create(long id)
	{
		base.ActiveMenuItem = "portal-workplace";
		IWorkplaceColorScheme workplaceColorScheme = InterfaceActivator.Create<IWorkplaceColorScheme>();
		IColorScheme colorScheme = colorSchemeManager.Load(ColorSchemeConst.DefaultColorSchemeUid);
		workplaceColorScheme.ColorSchemes.Add(colorScheme);
		IWorkPlace workPlace = workPlaceManager.Load(id);
		workPlace.WorkplaceColorSchemes = workplaceColorScheme;
		WorkplaceColorSchemesModel workplaceColorSchemesModel = new WorkplaceColorSchemesModel
		{
			Entity = workplaceColorScheme,
			ReturnUrl = ((Controller)this).get_Url().Action("Display", "WorkPlace", (object)new { id }),
			Workplaces = new List<IWorkPlace>(),
			ReadOnly = false
		};
		workplaceColorSchemesModel.Workplaces.Add(workPlace);
		return (ActionResult)(object)((Controller)this).View("Edit", (object)workplaceColorSchemesModel);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Create(WorkplaceColorSchemesModel model)
	{
		return Edit(model);
	}

	public ActionResult Edit(long id, string ReturnUrl, bool enableEdit = false)
	{
		base.ActiveMenuItem = "portal-workplace";
		IWorkplaceColorScheme workplaceColorScheme = workplaceColorSchemeeManager.Load(id);
		WorkPlaceManager obj = workPlaceManager;
		InstanceOf<IWorkPlaceFilter> instanceOf = new InstanceOf<IWorkPlaceFilter>();
		instanceOf.New.WorkplaceColorSchemes = workplaceColorScheme;
		List<IWorkPlace> list = obj.Find(instanceOf.New, null).ToList();
		bool readOnly = list.Count > 1 && !enableEdit;
		WorkplaceColorSchemesModel workplaceColorSchemesModel = new WorkplaceColorSchemesModel
		{
			Entity = workplaceColorScheme,
			ReturnUrl = ReturnUrl,
			Workplaces = list,
			ReadOnly = readOnly
		};
		return (ActionResult)(object)((Controller)this).View((object)workplaceColorSchemesModel);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Edit(WorkplaceColorSchemesModel model)
	{
		try
		{
			if (((Controller)this).get_ModelState().get_IsValid() && ((ICollection<IColorScheme>)model.Entity.ColorSchemes).Count > 0)
			{
				bool num = model.Entity.IsNew();
				model.Entity.Save();
				if (num)
				{
					foreach (IWorkPlace workplace in model.Workplaces)
					{
						workplace.WorkplaceColorSchemes = model.Entity;
						workplace.Save();
					}
				}
			}
			else
			{
				base.Notifier.Error(SR.T("Заполните обязательные поля"));
			}
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
		}
		string text = ((Controller)this).get_Url().ReturnUrl() ?? ((Controller)this).get_Url().Action("Index", "WorkPlace");
		return (ActionResult)(object)((Controller)this).Redirect(text);
	}
}
