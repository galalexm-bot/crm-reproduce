using System.Collections.Generic;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;

namespace EleWise.ELMA.Common.Services;

[DeveloperApi(DeveloperApiType.Service)]
public interface IDuplicateService
{
	ICollection<IDuplicate> GetPossibleDuplicates(ReferenceOnEntity reference);

	void ProcessEntity(IEntity entity);

	void FillDuplicates(IEntity entity, IDuplicateHandler handler);
}
