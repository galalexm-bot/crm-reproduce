using System;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities.EntityReferences;

namespace EleWise.ELMA.Tasks.Extensions;

[Serializable]
public class ReplacementTaskAssignment : IXsiType
{
	public ReferenceOnEntity Entity { get; set; }

	public Guid PropertyUid { get; set; }

	public long UserId { get; set; }

	public string Value { get; set; }
}
