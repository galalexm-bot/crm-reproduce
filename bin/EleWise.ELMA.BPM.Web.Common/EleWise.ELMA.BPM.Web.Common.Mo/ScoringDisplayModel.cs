using System;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.Model.Entities.EntityReferences;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class ScoringDisplayModel
{
	public bool IsGlobalScoringEnabled { get; set; }

	public string ColorCode { get; set; }

	public DuplicateStatus Status { get; set; }

	public Guid TypeGuid { get; set; }

	public long Id { get; set; }

	public ReferenceOnEntity OriginalReference { get; set; }

	public string OriginalName { get; set; }

	public DateTime? DateOfScoring { get; set; }
}
