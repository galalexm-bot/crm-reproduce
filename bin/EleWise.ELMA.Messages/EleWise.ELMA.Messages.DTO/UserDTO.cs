using System;

namespace EleWise.ELMA.Messages.DTO;

public sealed class UserDTO
{
	public long Id { get; set; }

	public Guid Uid { get; set; }

	public string DisplayName { get; set; }

	public string UserName { get; set; }

	public Guid? Avatar { get; set; }
}
