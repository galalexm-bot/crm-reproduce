using System;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.ConvertType;

namespace EleWise.ELMA.Documents.Services;

public class ConflictFindingParameters
{
	public Guid ConflictFindingProcessUid;

	public IDocument[] Docs;

	public DocTypeMappingInfo[] mappings;

	public Guid targetTypeUid;
}
