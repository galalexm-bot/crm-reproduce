using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Services;
using NHibernate.Criterion;

namespace EleWise.ELMA.Documents.Managers;

public class DocumentReferenceManager : ReferenceManager<IDocumentReference, long>
{
	public new static DocumentReferenceManager Instance => Locator.GetServiceNotNull<DocumentReferenceManager>();

	public IEnumerable<IDocumentReference> GetReferences(IDocument document)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Reference", (object)document)).SetCacheable(true).List<IDocumentReference>();
	}
}
