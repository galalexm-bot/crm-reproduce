using System;
using System.Linq.Expressions;
using AutoMapper;
using EleWise.ELMA.Documents.DTO.Models;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Documents.DTO.AutoMaps;

public class DocumentMetadataHeadMap : BidirectionalMap<IDocumentMetadataHead, DocumentMetadataHeadDTO>
{
	protected override void InitMap(IMappingExpression<IDocumentMetadataHead, DocumentMetadataHeadDTO> map)
	{
		base.InitMap(map);
		map.ForMember<long>((Expression<Func<DocumentMetadataHeadDTO, long>>)((DocumentMetadataHeadDTO m) => m.GroupId), (Action<IMemberConfigurationExpression<IDocumentMetadataHead, DocumentMetadataHeadDTO, long>>)delegate(IMemberConfigurationExpression<IDocumentMetadataHead, DocumentMetadataHeadDTO, long> a)
		{
			a.Ignore();
		});
		map.AfterMap((Action<IDocumentMetadataHead, DocumentMetadataHeadDTO>)MapPropertiesToDto);
	}

	private void MapPropertiesToDto(IDocumentMetadataHead obj, DocumentMetadataHeadDTO dto)
	{
		if (obj.Group != null)
		{
			dto.GroupId = obj.Group.Id;
		}
	}

	protected override void InitReverseMap(IMappingExpression<DocumentMetadataHeadDTO, IDocumentMetadataHead> map)
	{
		base.InitReverseMap(map);
		map.ForMember<IDocumentMetadataGroup>((Expression<Func<IDocumentMetadataHead, IDocumentMetadataGroup>>)((IDocumentMetadataHead m) => m.Group), (Action<IMemberConfigurationExpression<DocumentMetadataHeadDTO, IDocumentMetadataHead, IDocumentMetadataGroup>>)delegate(IMemberConfigurationExpression<DocumentMetadataHeadDTO, IDocumentMetadataHead, IDocumentMetadataGroup> a)
		{
			a.Ignore();
		});
		map.AfterMap((Action<DocumentMetadataHeadDTO, IDocumentMetadataHead>)MapProperties);
	}

	private void MapProperties(DocumentMetadataHeadDTO dto, IDocumentMetadataHead obj)
	{
		obj.Group = ((dto.GroupId > 0) ? AbstractNHEntityManager<IDocumentMetadataGroup, long>.Instance.LoadOrNull(dto.GroupId) : null);
	}
}
