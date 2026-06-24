using EleWise.ELMA.Model.Entities.EntityReferences;

namespace EleWise.ELMA.Runtime.Managers;

public interface IReferenceOnEntityManager
{
	string SaveRef(ReferenceOnEntity @ref);

	ReferenceOnEntity LoadRef(string id);
}
