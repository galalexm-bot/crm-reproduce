using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using NHibernate;

namespace EleWise.ELMA.Documents.Managers;

public class DocumentTaskBaseExtensionManager : EntityExtensionManager<ITaskBase, IDocumentTaskBaseExtension, long, TaskBaseManager>
{
	public DocumentManager DocumentManager { get; set; }

	protected override void OnSetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.OnSetupFilter(criteria, filter);
		if (filter is IDocumentTaskBaseExtensionFilter documentTaskBaseExtensionFilter)
		{
			if (documentTaskBaseExtensionFilter.InnerDocument != null)
			{
				DocumentManager.TasksCriteria(documentTaskBaseExtensionFilter.InnerDocument, null, criteria);
			}
			if (documentTaskBaseExtensionFilter.InnerDocuments != null && ((IEnumerable<IDocument>)documentTaskBaseExtensionFilter.InnerDocuments).Any())
			{
				DocumentManager.DocumentTasksCriteria(((IEnumerable<IDocument>)documentTaskBaseExtensionFilter.InnerDocuments).ToList(), null, criteria);
			}
		}
	}
}
