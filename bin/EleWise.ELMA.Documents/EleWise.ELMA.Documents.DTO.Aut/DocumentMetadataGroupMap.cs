using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using EleWise.ELMA.Documents.DTO.Models;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Managers;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents.DTO.AutoMaps;

public class DocumentMetadataGroupMap : BidirectionalMap<IDocumentMetadataGroup, DocumentMetadataGroupDTO>
{
	protected override void InitMap(IMappingExpression<IDocumentMetadataGroup, DocumentMetadataGroupDTO> map)
	{
		base.InitMap(map);
		map.ForMember<List<DocumentMetadataHeadDTO>>((Expression<Func<DocumentMetadataGroupDTO, List<DocumentMetadataHeadDTO>>>)((DocumentMetadataGroupDTO m) => m.DocumentTypes), (Action<IMemberConfigurationExpression<IDocumentMetadataGroup, DocumentMetadataGroupDTO, List<DocumentMetadataHeadDTO>>>)delegate(IMemberConfigurationExpression<IDocumentMetadataGroup, DocumentMetadataGroupDTO, List<DocumentMetadataHeadDTO>> a)
		{
			a.Ignore();
		});
		map.ForMember<List<DocumentMetadataGroupDTO>>((Expression<Func<DocumentMetadataGroupDTO, List<DocumentMetadataGroupDTO>>>)((DocumentMetadataGroupDTO m) => m.Groups), (Action<IMemberConfigurationExpression<IDocumentMetadataGroup, DocumentMetadataGroupDTO, List<DocumentMetadataGroupDTO>>>)delegate(IMemberConfigurationExpression<IDocumentMetadataGroup, DocumentMetadataGroupDTO, List<DocumentMetadataGroupDTO>> a)
		{
			a.Ignore();
		});
		map.ForMember<DateTime>((Expression<Func<DocumentMetadataGroupDTO, DateTime>>)((DocumentMetadataGroupDTO m) => m.CreationDate), (Action<IMemberConfigurationExpression<IDocumentMetadataGroup, DocumentMetadataGroupDTO, DateTime>>)delegate(IMemberConfigurationExpression<IDocumentMetadataGroup, DocumentMetadataGroupDTO, DateTime> a)
		{
			a.Ignore();
		});
		map.ForMember<DateTime>((Expression<Func<DocumentMetadataGroupDTO, DateTime>>)((DocumentMetadataGroupDTO m) => m.ChangeDate), (Action<IMemberConfigurationExpression<IDocumentMetadataGroup, DocumentMetadataGroupDTO, DateTime>>)delegate(IMemberConfigurationExpression<IDocumentMetadataGroup, DocumentMetadataGroupDTO, DateTime> a)
		{
			a.Ignore();
		});
		map.AfterMap((Action<IDocumentMetadataGroup, DocumentMetadataGroupDTO>)MapDocumentTypesToDto);
	}

	private void MapDocumentTypesToDto(IDocumentMetadataGroup group, DocumentMetadataGroupDTO dto)
	{
		if (dto == null || group == null)
		{
			return;
		}
		if (group.ParentGroup != null)
		{
			dto.ParentGroupId = group.ParentGroup.Id;
		}
		dto.DocumentTypes.Clear();
		foreach (IDocumentMetadataHead item in (IEnumerable<IDocumentMetadataHead>)group.DocumentTypes)
		{
			dto.DocumentTypes.Add(Mapper.Map<IDocumentMetadataHead, DocumentMetadataHeadDTO>(item, new DocumentMetadataHeadDTO()));
		}
		dto.Groups.Clear();
		foreach (IDocumentMetadataGroup item2 in (IEnumerable<IDocumentMetadataGroup>)group.Groups)
		{
			dto.Groups.Add(Mapper.Map<IDocumentMetadataGroup, DocumentMetadataGroupDTO>(item2, new DocumentMetadataGroupDTO()));
		}
		dto.CreationDate = (group.CreationDate.HasValue ? group.CreationDate.Value : DateTime.MinValue);
		dto.ChangeDate = (group.ChangeDate.HasValue ? group.ChangeDate.Value : DateTime.MinValue);
	}

	protected override void InitReverseMap(IMappingExpression<DocumentMetadataGroupDTO, IDocumentMetadataGroup> map)
	{
		base.InitReverseMap(map);
		map.ForMember<ISet<IDocumentMetadataHead>>((Expression<Func<IDocumentMetadataGroup, ISet<IDocumentMetadataHead>>>)((IDocumentMetadataGroup m) => m.DocumentTypes), (Action<IMemberConfigurationExpression<DocumentMetadataGroupDTO, IDocumentMetadataGroup, ISet<IDocumentMetadataHead>>>)delegate(IMemberConfigurationExpression<DocumentMetadataGroupDTO, IDocumentMetadataGroup, ISet<IDocumentMetadataHead>> a)
		{
			a.Ignore();
		});
		map.ForMember<ISet<IDocumentMetadataGroup>>((Expression<Func<IDocumentMetadataGroup, ISet<IDocumentMetadataGroup>>>)((IDocumentMetadataGroup m) => m.Groups), (Action<IMemberConfigurationExpression<DocumentMetadataGroupDTO, IDocumentMetadataGroup, ISet<IDocumentMetadataGroup>>>)delegate(IMemberConfigurationExpression<DocumentMetadataGroupDTO, IDocumentMetadataGroup, ISet<IDocumentMetadataGroup>> a)
		{
			a.Ignore();
		});
		map.ForMember<DateTime?>((Expression<Func<IDocumentMetadataGroup, DateTime?>>)((IDocumentMetadataGroup m) => m.CreationDate), (Action<IMemberConfigurationExpression<DocumentMetadataGroupDTO, IDocumentMetadataGroup, DateTime?>>)delegate(IMemberConfigurationExpression<DocumentMetadataGroupDTO, IDocumentMetadataGroup, DateTime?> a)
		{
			a.Ignore();
		});
		map.ForMember<DateTime?>((Expression<Func<IDocumentMetadataGroup, DateTime?>>)((IDocumentMetadataGroup m) => m.ChangeDate), (Action<IMemberConfigurationExpression<DocumentMetadataGroupDTO, IDocumentMetadataGroup, DateTime?>>)delegate(IMemberConfigurationExpression<DocumentMetadataGroupDTO, IDocumentMetadataGroup, DateTime?> a)
		{
			a.Ignore();
		});
		map.AfterMap((Action<DocumentMetadataGroupDTO, IDocumentMetadataGroup>)MapDocumentTypes);
	}

	private void MapDocumentTypes(DocumentMetadataGroupDTO dto, IDocumentMetadataGroup group)
	{
		if (dto.ParentGroupId > 0)
		{
			group.ParentGroup = AbstractNHEntityManager<IDocumentMetadataGroup, long>.Instance.Load(dto.ParentGroupId);
		}
		List<IDocumentMetadataHead> list = dto.DocumentTypes.Select((DocumentMetadataHeadDTO s) => Mapper.Map<DocumentMetadataHeadDTO, IDocumentMetadataHead>(s, (s.Id > 0) ? AbstractNHEntityManager<IDocumentMetadataHead, long>.Instance.Load(s.Id) : AbstractNHEntityManager<IDocumentMetadataHead, long>.Instance.Create())).ToList();
		((ICollection<IDocumentMetadataHead>)group.DocumentTypes).Clear();
		group.DocumentTypes.AddAll((ICollection<IDocumentMetadataHead>)list);
		List<IDocumentMetadataGroup> list2 = dto.Groups.Select((DocumentMetadataGroupDTO s) => Mapper.Map<DocumentMetadataGroupDTO, IDocumentMetadataGroup>(s, (s.Id > 0) ? AbstractNHEntityManager<IDocumentMetadataGroup, long>.Instance.Load(s.Id) : AbstractNHEntityManager<IDocumentMetadataGroup, long>.Instance.Create())).ToList();
		((ICollection<IDocumentMetadataGroup>)group.Groups).Clear();
		group.Groups.AddAll((ICollection<IDocumentMetadataGroup>)list2);
		if (dto.CreationDate > DateTime.MinValue)
		{
			group.ChangeDate = dto.CreationDate;
		}
		if (dto.ChangeDate > DateTime.MinValue)
		{
			group.ChangeDate = dto.ChangeDate;
		}
	}
}
