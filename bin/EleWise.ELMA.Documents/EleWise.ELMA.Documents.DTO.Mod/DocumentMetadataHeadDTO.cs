using System;
using EleWise.ELMA.Model.DTO;

namespace EleWise.ELMA.Documents.DTO.Models;

[Serializable]
public class DocumentMetadataHeadDTO : EntityDTO<long>
{
	public static Guid FileUID = new Guid("7f8a792f-1123-48b9-985f-8cad74803a35");

	public long GroupId { get; set; }

	public Guid DocumentTypeUid { get; set; }

	public bool IsDeleted { get; set; }

	public Guid MetadataType { get; set; }
}
