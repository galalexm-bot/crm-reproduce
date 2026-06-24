using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.Extensions;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.BPM.Web.Security.Code;
using EleWise.ELMA.Content;
using EleWise.ELMA.Content.Constants;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Boxes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Iesi.Collections.Generic;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class WorkPlaceController : BPMController<IWorkPlace, long>
{
	public ColorSchemeManager ColorSchemeManager { get; set; }

	public UserManager UserManager { get; set; }

	public IMembershipService _membershipService { get; set; }

	public IAuthenticationService _authenticationService { get; set; }

	public ITrustedDeviceService _trustedDeviceService { get; set; }

	[ContentItem(Name = "SR.M('Интерфейсы')", Id = "portal-workplace", Image24 = "#work_place.svg")]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	[CustomGridAction]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult Grid(GridCommand command)
	{
		GridData<IWorkPlace> gridData = new GridData<IWorkPlace>
		{
			Command = command
		};
		gridData.SetCount((GridData<IWorkPlace> d, FetchOptions f) => base.Manager.Find((IWorkPlace item) => item.Type != MobileWorkPlaceTypeConst.Uid, f).Count());
		gridData.SetDataSource((GridData<IWorkPlace> d, FetchOptions f) => (d.Count <= 0) ? new List<IWorkPlace>() : base.Manager.Find((IWorkPlace item) => item.Type != MobileWorkPlaceTypeConst.Uid, f));
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[HttpGet]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult Display(IWorkPlace workPlace)
	{
		CheckUId(workPlace);
		return (ActionResult)(object)((Controller)this).View((object)new WorkPlaceModel
		{
			Entity = workPlace
		});
	}

	[HttpPost]
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult Save(WorkPlaceModel model)
	{
		CheckUId(model.Entity);
		model.Entity.Save();
		if (((Controller)this).get_Request().UrlReferrer != null)
		{
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Request().UrlReferrer.ToString());
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Display", (object)new { model.Entity.Id });
	}

	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult Delete(IWorkPlace workPlace)
	{
		CheckUId(workPlace);
		workPlace.Delete();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult SetStartMenu(IWorkPlace workPlace, int menuId)
	{
		CheckUId(workPlace);
		workPlace.StartMenu = AbstractNHEntityManager<IStartMenu, int>.Instance.Load(menuId);
		workPlace.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Display", (object)new { workPlace.Id });
	}

	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult SetLeftMenu(IWorkPlace workPlace, int menuId)
	{
		CheckUId(workPlace);
		workPlace.LeftMenu = AbstractNHEntityManager<ILeftMenu, int>.Instance.Load(menuId);
		workPlace.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Display", (object)new { workPlace.Id });
	}

	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult SetPages(IWorkPlace workPlace, long pagesId)
	{
		CheckUId(workPlace);
		workPlace.WorkplacePages = AbstractNHEntityManager<IWorkplacePages, long>.Instance.Load(pagesId);
		workPlace.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Display", (object)new { workPlace.Id });
	}

	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult SetWorkplaceColorSchemes(IWorkPlace workPlace, long colorSchemeId)
	{
		CheckUId(workPlace);
		workPlace.WorkplaceColorSchemes = AbstractNHEntityManager<IWorkplaceColorScheme, long>.Instance.Load(colorSchemeId);
		workPlace.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Display", (object)new { workPlace.Id });
	}

	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult SetToolbar(IWorkPlace workPlace, long? toolbarId)
	{
		CheckUId(workPlace);
		workPlace.Toolbar = (toolbarId.HasValue ? WebToolbarManager.Instance.Load(toolbarId.Value) : null);
		workPlace.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Display", (object)new { workPlace.Id });
	}

	[TransactionAction]
	public ActionResult CreateToolbarCopy(IWorkPlace workPlace)
	{
		CheckUId(workPlace);
		if (workPlace.Toolbar != null)
		{
			workPlace.Toolbar = CloneHelperBuilder.Create(workPlace.Toolbar).Clone();
			workPlace.Toolbar.Name = SR.T("Toolbar ({0})", workPlace.Name);
			workPlace.Save();
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Display", (object)new { workPlace.Id });
	}

	[HttpGet]
	public JsonResult GetColorSchemes(IWorkPlace workPlace, long userId)
	{
		if (workPlace.WorkplaceColorSchemes != null)
		{
			ISet<IColorScheme> colorSchemes = workPlace.WorkplaceColorSchemes.ColorSchemes;
			if (colorSchemes == null || ((ICollection<IColorScheme>)colorSchemes).Count != 0)
			{
				IUserWorkPlace user = UserManager.LoadOrNull(userId) as IUserWorkPlace;
				return ((Controller)this).Json((object)new
				{
					selectedItem = ColorSchemeManager.GetUserColorScheme(workPlace, user)?.Id,
					items = ((IEnumerable<IColorScheme>)workPlace.WorkplaceColorSchemes.ColorSchemes).Select((IColorScheme a) => new AutocompleteItem
					{
						Value = a.Id.ToString(),
						Text = a.Name,
						ViewText = a.Name,
						DropDownText = a.Name
					})
				}, (JsonRequestBehavior)0);
			}
		}
		return ((Controller)this).Json((object)null);
	}

	public ActionResult Customizer()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		if (!WorkPlaceExtensions.CustomizerEnabled)
		{
			return (ActionResult)new EmptyResult();
		}
		EleWise.ELMA.Security.Models.IUser user = (WorkPlaceExtensions.CustomizatorId.HasValue ? UserManager.Instance.LoadOrNull(WorkPlaceExtensions.CustomizatorId.Value) : null);
		if (user == null || !base.SecurityService.HasPermission(user, EleWise.ELMA.Content.PermissionProvider.ContentAdminPermission))
		{
			return (ActionResult)new EmptyResult();
		}
		CustomizerModel customizerModel = new CustomizerModel
		{
			User = UserManager.Instance.Load(user.Id),
			WorkPlace = WorkPlaceExtensions.GetCurrentWorkPlace(loadDefaultWorkPlace: true),
			TranslationEnabled = TranslateService.Instance.IsTranslationModeEnabled(user.Id)
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)customizerModel);
	}

	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult ChangeCustomizerWorkPlace(long id)
	{
		WorkPlaceExtensions.ChangeCustomizerWorkPlace(id);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		});
	}

	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult ChangeUserCustomizer(string login, string password)
	{
		object data = WorkPlaceExtensions.Data;
		EleWise.ELMA.Security.IUser user = _membershipService.ValidateUser(login, password);
		if (user == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = SR.NoTrueLogin
			});
		}
		string contextDeviceToken = TrustedDeviceTokenHelper.GetContextDeviceToken(((Controller)this).get_HttpContext(), login);
		string contextDeviceInfo = TrustedDeviceTokenHelper.GetContextDeviceInfo(((Controller)this).get_HttpContext());
		if (!_trustedDeviceService.CheckDevice(contextDeviceToken, contextDeviceInfo, user))
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = SR.T("Авторизация возможна только с доверенного устройства")
			});
		}
		try
		{
			((Controller)this).get_Session().Clear();
			_authenticationService.SignIn(user);
			WorkPlaceExtensions.EnableCustomizer(data);
			WorkPlaceExtensions.ChangeCustomizerWorkPlace(WorkPlaceManager.Instance.GetWorkPlaceByUser((long)user.GetId(), loadDefaultWorkPlace: true).Id);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true,
				error = ""
			});
		}
		catch (LicenseActivationRequiredException)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = SR.T("Требуется активация сервера")
			});
		}
		catch (LicenseWorkplaceExceededException)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = SR.T("Превышено количество пользовательских лицензий")
			});
		}
		catch (LicenseExpiredException)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = SR.T("Истек срок действия лицензии")
			});
		}
		catch (LicenseException ex4)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = ex4.Message
			});
		}
		catch (Exception)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = SR.T("Неизвестная ошибка авторизации")
			});
		}
	}

	private void CheckUId(IWorkPlace workPlace)
	{
		if (WorkPlaceManager.MobileWorkPlaceUid == workPlace.Uid)
		{
			throw new ObjectNotFoundException(InterfaceActivator.TypeOf<IWorkPlace>().FullName, workPlace.Id);
		}
	}
}
