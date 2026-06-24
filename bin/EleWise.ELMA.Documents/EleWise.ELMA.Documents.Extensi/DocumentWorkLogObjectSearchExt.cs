using System;
using System.Collections;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Tasks.ExtensionPoints;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Documents.Extensions;

[Component]
public class DocumentWorkLogObjectSearchExtension : WorkLogObjectSearchExtensionBase
{
	public override Guid Uid => new Guid("{676931CE-32CA-44B4-BDB4-AC234578835B}");

	public override Type BaseObjectType => typeof(IDocument);

	protected override void Init()
	{
		AddProperty((IDocumentWorkLogObjectSearchFilter p) => p.Documents);
		AddProperty((IDocumentWorkLogObjectSearchFilter p) => p.CreationDate);
		AddProperty((IDocumentWorkLogObjectSearchFilter p) => p.CreationAuthor);
	}

	public override void SetupCriteria(ICriteria criteria, IWorkLogObjectSearchFilter filter)
	{
		base.SetupCriteria(criteria, filter);
		if (filter is IDocumentWorkLogObjectSearchFilter documentWorkLogObjectSearchFilter && documentWorkLogObjectSearchFilter.Documents != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.In("Id", (ICollection)documentWorkLogObjectSearchFilter.Documents.Select((IDocument e) => e.Id).ToArray()));
		}
	}

	public override void SetupFilter(IEntityFilter entityFilter, IWorkLogObjectSearchFilter filter)
	{
		base.SetupFilter(entityFilter, filter);
		if (entityFilter is IDocumentFilter documentFilter)
		{
			documentFilter.CreationDate = filter.CreationDate;
			if (filter.CreationAuthor != null)
			{
				documentFilter.CreationAuthor.Add(filter.CreationAuthor);
			}
		}
	}
}
