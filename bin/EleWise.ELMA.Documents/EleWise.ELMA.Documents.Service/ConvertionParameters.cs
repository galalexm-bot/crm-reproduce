using System;
using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.ConvertType;

namespace EleWise.ELMA.Documents.Services;

public class ConvertionParameters
{
	public Guid ConvertionUid { get; set; }

	public IDocument[] Docs { get; set; }

	public DocTypeMappingInfo[] Mappings { get; set; }

	public Guid TargetTypeUid { get; set; }

	public long CurrentUserId { get; set; }

	public IDictionary<string, object> ExtendedData { get; set; }
}
