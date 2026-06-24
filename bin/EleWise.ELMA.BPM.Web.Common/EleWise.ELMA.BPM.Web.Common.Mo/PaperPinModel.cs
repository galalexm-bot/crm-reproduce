using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class PaperPinModel
{
	public Guid EntityTypeUid { get; set; }

	public object EntityId { get; set; }

	public string PaperPinPanel { get; set; }

	public string ConfirmText { get; set; }

	public string TooltipDescription { get; set; }

	public string TooltipDescriptionPin { get; set; }

	public List<IPaperPin> PaperPins { get; set; }

	public string AddPaperPinScript { get; set; }

	public string RemovePaperPinScript { get; set; }

	public PaperPinModel()
	{
		PaperPinPanel = "IconInfoPaperPin";
	}

	public bool IsCurrentIsPaperPin(Guid typeUid, object objectId)
	{
		if (PaperPins == null)
		{
			return false;
		}
		IAuthenticationService service = Locator.GetService<IAuthenticationService>();
		IUser currentUser = service.GetCurrentUser<IUser>();
		string sObjectId = Convert.ToString(objectId);
		return PaperPins.Any((IPaperPin w) => w.User.Id == currentUser.Id && ((objectId != null && sObjectId == w.EntityId) || (objectId == null && string.IsNullOrEmpty(w.EntityId))));
	}
}
