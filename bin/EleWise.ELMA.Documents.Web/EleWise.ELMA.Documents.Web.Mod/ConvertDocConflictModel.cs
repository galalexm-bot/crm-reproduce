using System.Collections.Generic;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.Models;

public class ConvertDocConflictModel
{
	public List<ConflictConvertReferencesObject> DocReferences;

	public ConvertDocConflictModel(List<ConflictConvertReferencesObject> references)
	{
		DocReferences = references;
		DocReferences.ForEach(delegate(ConflictConvertReferencesObject a)
		{
			IEntityManager entityManager = EntityHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(a.RefToDocument.TypeUid));
			a.RefToDocument = (IDocument)entityManager.Load(a.RefToDocument.Uid);
		});
	}
}
