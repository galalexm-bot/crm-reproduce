using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Services;

public interface IDmsObjectRelationService
{
	void Insert(IEnumerable<IDmsObject> dmsObjs);

	void Insert(IDmsObject dms);

	void Move(IDmsObject dmsObj, IFolder to, IFolder from = null);

	void Move(IEnumerable<IDmsObject> dmsObjs, IFolder to, IFolder from = null);

	void FullRemove(IEnumerable<IDmsObject> dmsObjs);

	void FullRemove(IEnumerable<long> dmsIds);
}
