using System;
using System.Collections.Generic;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UI.Services.FindComponent;

public interface IFindComponentService
{
	RecursiveComponentModel FindComponent(Guid headerUid, FindComponentOptions options);

	RecursiveComponentModel FindComponent(ObjectFormFindComponentModel model, FindComponentOptions options);

	IEnumerable<ClientComponentModel> GetAdditionalModules();
}
