using EleWise.ELMA.Model.Entities.EntityReferences;

namespace EleWise.ELMA.Common.Managers;

internal class LastObjectInfoDTO
{
	public long UserId { get; set; }

	public ReferenceOnEntityType ObjectType { get; set; }

	public long HowMany { get; set; }
}
