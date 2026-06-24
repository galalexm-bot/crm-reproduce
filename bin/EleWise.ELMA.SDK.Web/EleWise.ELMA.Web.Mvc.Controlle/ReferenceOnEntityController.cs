using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public class ReferenceOnEntityController : BaseController
{
	public ActionResult GetAllTypes(string text)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		var data = (from m in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().OfType<EntityMetadata>()
			where (m.Type == EntityMetadataType.Interface || m.Type == EntityMetadataType.Entity) && m.ImplementationUid != Guid.Empty && (string.IsNullOrEmpty(text) || m.DisplayName.ToUpper().Contains(text.ToUpper()))
			select new
			{
				DropDownText = m.DisplayName,
				Value = m.ImplementationUid,
				ViewText = m.DisplayName,
				Text = m.DisplayName
			}).ToList();
		JsonResult val = new JsonResult();
		val.set_Data((object)data);
		val.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return (ActionResult)val;
	}
}
