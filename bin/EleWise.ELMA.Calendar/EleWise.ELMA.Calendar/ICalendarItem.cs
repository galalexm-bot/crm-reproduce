using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Calendar;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface ICalendarItem
{
	string Id { get; }

	Guid Uid { get; }

	string SourceId { get; }

	Guid SourceTypeUid { get; }

	DateTime StartDate { get; set; }

	DateTime EndDate { get; set; }

	bool Completed { get; set; }

	bool MarkExpired { get; }

	bool ToInform { get; }

	string Theme { get; set; }

	string Place { get; set; }

	string To { get; set; }

	IDictionary<string, string> EventUsers { get; set; }

	string Description { get; set; }

	bool HasCopy { get; set; }

	bool OnlyInfo { get; set; }

	long CreationAuthor { get; set; }

	bool ReadOnly { get; set; }

	ICollection<IComment> Comments { get; }

	bool PrivateAccess { get; }

	ICalendarItem Clone();
}
