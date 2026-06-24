using System;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.vCard.Vcard;
using EleWise.ELMA.vCard.Web.Components;
using EleWise.ELMA.Web.Mvc.Controllers;

namespace EleWise.ELMA.vCard.Web.Controllers;

public class VcardController : BaseController<IUser, long>
{
	public VCardResult GetForUser(Guid id)
	{
		IUser user = base.Manager.LoadOrNull(id);
		if (user == null)
		{
			return null;
		}
		string fullName = user.FullName;
		return new VCardResult(new EleWise.ELMA.vCard.Vcard.Vcard(user), fullName);
	}
}
