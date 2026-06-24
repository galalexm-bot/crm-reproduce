using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Calendar.Export.Models;

[Serializable]
public class ExternalCalendarItem : ICalendarItem
{
	public string Id { get; set; }

	public Guid Uid { get; set; }

	public string SourceId { get; set; }

	public Guid SourceTypeUid { get; set; }

	[DisplayName(typeof(ExternalCalendarItem_SR), "StartDate")]
	public DateTime StartDate { get; set; }

	[DisplayName(typeof(ExternalCalendarItem_SR), "EndDate")]
	public DateTime EndDate { get; set; }

	[DisplayName(typeof(ExternalCalendarItem_SR), "Status")]
	public EventStatus Status { get; set; }

	public bool Completed
	{
		get
		{
			if (Status != EventStatus.Cancelled)
			{
				return EndDate < DateTime.Now;
			}
			return false;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public bool MarkExpired => StartDate > DateTime.Now;

	public bool ToInform => false;

	[DisplayName(typeof(ExternalCalendarItem_SR), "Theme")]
	public string Theme { get; set; }

	[DisplayName(typeof(ExternalCalendarItem_SR), "Place")]
	public string Place { get; set; }

	public string To
	{
		get
		{
			return null;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public IDictionary<string, string> EventUsers
	{
		get
		{
			return new Dictionary<string, string>();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	[DisplayName(typeof(ExternalCalendarItem_SR), "Description")]
	public string Description { get; set; }

	[DisplayName(typeof(ExternalCalendarItem_SR), "IsPeriodical")]
	public bool IsPeriodical { get; set; }

	public bool HasCopy
	{
		get
		{
			return false;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public bool OnlyInfo { get; set; }

	public long CreationAuthor
	{
		get
		{
			return 0L;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public bool ReadOnly
	{
		get
		{
			return true;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public ICollection<IComment> Comments => new Collection<IComment>();

	public bool PrivateAccess => false;

	public ICalendarItem Clone()
	{
		throw new NotSupportedException();
	}
}
