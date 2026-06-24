using System;

namespace EleWise.ELMA.Messages.DTO;

public class EntityHeaderDTO
{
	public Guid TypeUid { get; set; }

	public long Id { get; set; }

	public Guid? Uid { get; set; }

	public string Name { get; set; }
}
