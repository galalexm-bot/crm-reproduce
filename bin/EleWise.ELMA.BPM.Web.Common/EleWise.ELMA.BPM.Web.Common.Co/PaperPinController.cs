using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

public class PaperPinController : BPMController<IPaperPin, long>
{
	[HttpGet]
	public ActionResult Info(Guid entityTypeUid, string entityId, string paperPinPanel, string addPaperPinScript, string removePaperPinScript)
	{
		object id = ModelHelper.TryConvertEntityId(entityTypeUid, entityId);
		IPaperPinProvider paperPinProvider = ComponentManager.Current.GetExtensionPoints<IPaperPinProvider>().FirstOrDefault((IPaperPinProvider p) => p.IsAvailable(entityTypeUid, id));
		PaperPinModel paperPinModel = new PaperPinModel
		{
			EntityTypeUid = entityTypeUid,
			EntityId = id,
			PaperPinPanel = paperPinPanel,
			PaperPins = PaperPinManager.Instance.GetAllPaperPinsByUser(base.AuthenticationService.GetCurrentUser<IUser>(), paperPinProvider?.AvailableTypes()),
			ConfirmText = ((paperPinProvider != null) ? paperPinProvider.ConfirmText(entityTypeUid, id) : ""),
			TooltipDescription = ((paperPinProvider != null) ? paperPinProvider.TooltipText(entityTypeUid, id) : ""),
			TooltipDescriptionPin = ((paperPinProvider != null) ? paperPinProvider.TooltipTextPin(entityTypeUid, id) : ""),
			AddPaperPinScript = addPaperPinScript,
			RemovePaperPinScript = removePaperPinScript
		};
		return (ActionResult)(object)((Controller)this).PartialView("PaperPin/IconInfo", (object)paperPinModel);
	}

	[HttpPost]
	public ActionResult SetPaperPin(Guid entityTypeUid, string entityId)
	{
		object id = ModelHelper.TryConvertEntityId(entityTypeUid, entityId);
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		if (PaperPinManager.Instance.GetPaperPinByUser(entityTypeUid, currentUser, id).Count == 0)
		{
			PaperPinManager instance = PaperPinManager.Instance;
			IPaperPinProvider paperPinProvider = ComponentManager.Current.GetExtensionPoints<IPaperPinProvider>().FirstOrDefault((IPaperPinProvider p) => p.IsAvailable(entityTypeUid, id));
			if (paperPinProvider != null && paperPinProvider.OnlyOneInstance())
			{
				instance.GetAllPaperPinsByUser(currentUser, paperPinProvider.AvailableTypes()).ToList().ForEach(delegate(IPaperPin w)
				{
					w.Delete();
				});
			}
			instance.CreatePaperPinByUser(entityTypeUid, id, currentUser);
		}
		return SuccessJson();
	}

	[HttpPost]
	public ActionResult RemovePaperPin(Guid entityTypeUid, string entityId)
	{
		object entityId2 = ModelHelper.TryConvertEntityId(entityTypeUid, entityId);
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		PaperPinManager.Instance.GetPaperPinByUser(entityTypeUid, currentUser, entityId2).ForEach(delegate(IPaperPin w)
		{
			w.Delete();
		});
		return SuccessJson();
	}
}
