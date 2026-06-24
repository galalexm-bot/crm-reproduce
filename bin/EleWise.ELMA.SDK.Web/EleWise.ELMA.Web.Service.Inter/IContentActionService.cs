using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Web.Service.Internal.Model;

namespace EleWise.ELMA.Web.Service.Internal;

public interface IContentActionService
{
	IEnumerable<ContentAction> LoadAll();

	FormBindingModel LoadFormBindingModel(ContentActionId id);

	ContentActionId LoadActionId(FormBindingModel formBindingModel, Guid buttonUid);
}
