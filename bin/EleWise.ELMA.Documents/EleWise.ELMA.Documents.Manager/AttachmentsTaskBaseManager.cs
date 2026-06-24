using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.Documents.Managers;

public class AttachmentsTaskBaseManager : EntityExtensionManager<ITaskBase, IAttachmentsTaskBase, long, TaskBaseManager>
{
	private const string DocumentAttachmentsSpecifiedAlias = "das";

	private const string DocumentAttachmentsAlias = "da";

	public static AttachmentsTaskBaseManager Instance => Locator.GetServiceNotNull<AttachmentsTaskBaseManager>();

	public IEnumerable<IAttachmentsTaskBase> GetTasksByDocument(long id)
	{
		return GetTasksByDocumentCriteria(id).List<IAttachmentsTaskBase>();
	}

	internal ICriteria GetTasksByDocumentCriteria(long id)
	{
		DetachedCriteria val = CreateDetachedCriteria(FetchOptions.All, base.ImplementationType, "subTsk").CreateAlias("DocumentAttachments", "dach", (JoinType)0).CreateAlias("dach.Document", "dct").Add((ICriterion)(object)Restrictions.Eq("dct.Id", (object)id))
			.SetProjection(Projections.Distinct((IProjection)(object)Projections.Property("Id")));
		DetachedCriteria val2 = CreateDetachedCriteria(FetchOptions.All, base.ImplementationType, "subTskSpec").CreateAlias("DocumentAttachmentsSpecified", "daspec", (JoinType)0).CreateAlias("daspec.Document", "dctspec").Add((ICriterion)(object)Restrictions.Eq("dctspec.Id", (object)id))
			.SetProjection(Projections.Distinct((IProjection)(object)Projections.Property("Id")));
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Subqueries.PropertyIn("Id", val), (ICriterion)(object)Subqueries.PropertyIn("Id", val2)));
	}

	public IEnumerable<IDocument> GetDocumentsFromTask(IAttachmentsTaskBase task)
	{
		if (task == null)
		{
			return Enumerable.Empty<IDocument>();
		}
		return CreateCriteria().CreateAlias("DocumentAttachmentsSpecified", "das").Add((ICriterion)(object)Restrictions.IdEq((object)task.Id)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("das.Document") })
			.List<IDocument>()
			.Union(CreateCriteria().CreateAlias("DocumentAttachments", "da").Add((ICriterion)(object)Restrictions.IdEq((object)task.Id)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("da.Document") })
				.List<IDocument>());
	}
}
