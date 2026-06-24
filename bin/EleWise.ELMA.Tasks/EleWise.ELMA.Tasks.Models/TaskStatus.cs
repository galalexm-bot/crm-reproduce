using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("243b57bf-40cf-46a5-88f2-79593b695c05")]
[DisplayName(typeof(__Resources_TaskStatus), "DisplayName")]
[Description(typeof(__Resources_TaskStatus), "Description")]
[EnumMetadataType(EnumMetadataType.EnumExtension)]
[BaseClass("b11d6d0a-f07b-40a3-bc49-2cc5a67fbc81")]
public class TaskStatus : TaskBaseStatus
{
	protected TaskStatus(Guid value, string name)
		: base(value, name)
	{
	}
}
