using System;

namespace EleWise.ELMA.History.Models;

public sealed class InverseRelatedEntityModel
{
	public long Id { get; set; }

	public Guid TypeUid { get; set; }

	public InverseRelatedEntityModel(long id, Guid typeUid)
	{
		Id = id;
		TypeUid = typeUid;
	}
}
