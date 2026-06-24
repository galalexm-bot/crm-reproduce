using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Web.DTO.Managers;

public interface IWorkPlaceTypeService
{
	IDictionary<Guid, string> WorkPlaceTypes();

	string GetVirtualPath(Guid workPlaceTypeUid, string partialViewName);
}
