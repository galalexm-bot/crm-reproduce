using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Managers;

internal class DocumentInstanceManager
{
	public static DocumentInstanceManager Instance => Locator.GetServiceNotNull<DocumentInstanceManager>();

	public IEnumerable<IDocument> GetInstancesByEntity(IEntity<long> entity, FetchOptions fetchOptions = null)
	{
		BuildInstancesByEntityQueryList(entity);
		return null;
	}

	public List<string> BuildInstancesByEntityQueryList(IEntity<long> entity)
	{
		return null;
	}
}
