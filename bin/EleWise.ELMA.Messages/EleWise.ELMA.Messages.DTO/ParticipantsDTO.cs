using System.Collections.Generic;

namespace EleWise.ELMA.Messages.DTO;

public sealed class ParticipantsDTO
{
	public ICollection<UserDTO> Users { get; set; }

	public ICollection<EntityHeaderDTO> UserGroups { get; set; }

	public ICollection<EntityHeaderDTO> OrganizationItems { get; set; }

	public long ParticipantsCount { get; set; }
}
