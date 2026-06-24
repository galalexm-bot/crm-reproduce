using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface IOpenFormProvider
{
	bool CheckType(Guid typeUid);

	EntityFormInfo GetFormInfo(Guid typeUid, IEntity entity, FormBindingModel formBindingModel, string viewItemId);
}
