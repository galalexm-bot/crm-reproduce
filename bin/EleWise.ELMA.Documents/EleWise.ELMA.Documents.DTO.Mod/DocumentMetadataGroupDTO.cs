using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.DTO;

namespace EleWise.ELMA.Documents.DTO.Models;

[Serializable]
public class DocumentMetadataGroupDTO : EntityDTO<long>
{
	public Guid Uid { get; set; }

	public string Name { get; set; }

	public DateTime CreationDate { get; set; }

	public DateTime ChangeDate { get; set; }

	public List<DocumentMetadataHeadDTO> DocumentTypes { get; set; }

	public List<DocumentMetadataGroupDTO> Groups { get; set; }

	public long ParentGroupId { get; set; }

	public Guid MetadataType { get; set; }

	public Guid GroupType { get; set; }

	public DocumentMetadataGroupDTO()
	{
		DocumentTypes = new List<DocumentMetadataHeadDTO>();
		Groups = new List<DocumentMetadataGroupDTO>();
	}
}
