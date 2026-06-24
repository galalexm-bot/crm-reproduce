using System;
using EleWise.ELMA.Calendar.Export.Models;

namespace EleWise.ELMA.Common.Mobile.API.Models;

[Serializable]
internal class ExternalCalendarItemModel
{
	public Guid TypeUid { get; set; }

	public string Id { get; set; }

	public Guid Uid { get; set; }

	public DateTime StartDate { get; set; }

	public DateTime EndDate { get; set; }

	public bool Completed { get; set; }

	public bool MarkExpired { get; set; }

	public bool ToInform { get; set; }

	public string Theme { get; set; }

	public string Place { get; set; }

	public string To { get; set; }

	public string Description { get; set; }

	public bool HasCopy { get; set; }

	public bool OnlyInfo { get; set; }

	public long CreationAuthor { get; set; }

	public bool ReadOnly { get; set; }

	public bool PrivateAccess { get; set; }

	public ExternalCalendarItemModel(ExternalCalendarItem calendarItem)
	{
		TypeUid = calendarItem.SourceTypeUid;
		Id = calendarItem.Id;
		Uid = calendarItem.Uid;
		StartDate = calendarItem.StartDate;
		EndDate = calendarItem.EndDate;
		Completed = calendarItem.Completed;
		MarkExpired = calendarItem.MarkExpired;
		ToInform = calendarItem.ToInform;
		Theme = calendarItem.Theme;
		Place = calendarItem.Place;
		To = calendarItem.To;
		Description = calendarItem.Description;
		HasCopy = calendarItem.HasCopy;
		OnlyInfo = calendarItem.OnlyInfo;
		CreationAuthor = calendarItem.CreationAuthor;
		ReadOnly = calendarItem.ReadOnly;
		PrivateAccess = calendarItem.PrivateAccess;
	}
}
