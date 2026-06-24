using System.Collections.Generic;
using EleWise.ELMA.Model.DTO;

namespace EleWise.ELMA.Documents.DTO.Models;

internal class DmsObjectDTO : EntityDTO<long>
{
	public List<long> UserSecuritySetCacheIds { get; set; }

	public long? FolderId { get; set; }
}
