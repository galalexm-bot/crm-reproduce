using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 50)]
public class DocumentLastObjectsResolver : IEntityLastObjectsResolver
{
	public bool CheckType(Guid typeUid)
	{
		List<Guid> list = (from documentMetadata in MetadataServiceContext.Service.GetMetadataList().OfType<DocumentMetadata>()
			select documentMetadata.Uid).ToList();
		list.Add(InterfaceActivator.UID<IDocument>());
		return list.Contains(typeUid);
	}

	public IEnumerable<IEntity> GetObjects(Guid typeUid, string text)
	{
		FetchOptions fetchOptions = new FetchOptions(0, 3, ListSortDirection.Descending, "ChangeDate");
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeUid);
		List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(classMetadata);
		childClasses.Add(classMetadata);
		List<Guid> objectType = childClasses.Select((ClassMetadata c) => c.Uid).ToList();
		IEnumerable<IDocument> source = from o in (from o in LastObjectInfoManager.Instance.GetObjects(fetchOptions, objectType, isRealObjectType: true).ToList()
				select o.Object.Object).OfType<IDocument>()
			where !o.IsDeleted && (!o.IsArchived.HasValue || !o.IsArchived.Value)
			select o;
		if (!string.IsNullOrEmpty(text))
		{
			source = source.Where((IDocument o) => !string.IsNullOrEmpty(o.ToString()) && o.ToString().IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0);
		}
		return source.ToList();
	}
}
