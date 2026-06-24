using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Services;
using NHibernate.Criterion;

namespace EleWise.ELMA.Documents.Managers;

public class FolderReferenceManager : ReferenceManager<IFolderReference, long>
{
	public new static FolderReferenceManager Instance => Locator.GetServiceNotNull<FolderReferenceManager>();

	public IEnumerable<IFolderReference> GetReferences(IFolder folder)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Reference", (object)folder)).SetCacheable(true).List<IFolderReference>();
	}
}
