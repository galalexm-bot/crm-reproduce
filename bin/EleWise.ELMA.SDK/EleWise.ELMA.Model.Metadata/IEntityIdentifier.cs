using System;

namespace EleWise.ELMA.Model.Metadata;

public interface IEntityIdentifier
{
	Guid IdTypeUid { get; set; }
}
