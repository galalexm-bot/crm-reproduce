using System;
using System.Linq;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Transform;

namespace EleWise.ELMA.Documents.Managers;

public class DocumentMetadataGroupManager : EntityManager<IDocumentMetadataGroup, long>
{
	public new static DocumentMetadataGroupManager Instance => Locator.GetServiceNotNull<DocumentMetadataGroupManager>();

	public IDocumentMetadataGroup Load(Guid metadataType, Guid groupType)
	{
		InstanceOf<IDocumentMetadataGroupFilter> instanceOf = new InstanceOf<IDocumentMetadataGroupFilter>();
		instanceOf.New.GroupType = groupType;
		instanceOf.New.MetadataType = metadataType;
		IDocumentMetadataGroupFilter @new = instanceOf.New;
		return Find(@new, new FetchOptions(0, 1)).FirstOrDefault();
	}

	public bool IsChildGroup(long groupId, long testGroupId)
	{
		return base.Session.GetNamedQuery("GetSubgroupsMGroups").CleanUpCache(cleanUpCache: false).SetInt64("groupId", groupId)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(FolderTreeNode)))
			.List<FolderTreeNode>()
			.ToList()
			.Any((FolderTreeNode f) => f.Id == testGroupId);
	}
}
