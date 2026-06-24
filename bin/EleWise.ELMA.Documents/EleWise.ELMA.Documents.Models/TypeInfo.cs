using System;

namespace EleWise.ELMA.Documents.Models.ConvertType;

public class TypeInfo
{
	public string Name { get; set; }

	public string DisplayName { get; set; }

	public Guid Uid { get; set; }

	public Guid ImplementationUid { get; set; }
}
