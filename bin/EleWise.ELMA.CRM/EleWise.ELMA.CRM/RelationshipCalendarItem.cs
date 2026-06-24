using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM;

[Serializable]
public class RelationshipCalendarItem : ICalendarItem
{
	[ScriptIgnore]
	public readonly IRelationship Relationship;

	public string Id => Relationship.Id.ToString();

	public Guid Uid => Relationship.Uid;

	public string SourceId => Relationship.Id.ToString();

	public Guid SourceTypeUid => Relationship.TypeUid;

	public DateTime StartDate { get; set; }

	public DateTime EndDate { get; set; }

	public DateTime? LimitStartDate { get; set; }

	public DateTime? LimitEndDate { get; set; }

	public CalendarEventPeriod Period { get; set; }

	public bool Completed { get; set; }

	public bool MarkExpired => true;

	public bool ToInform { get; set; }

	public string Theme { get; set; }

	public string Place { get; set; }

	public string To { get; set; }

	public IDictionary<string, string> EventUsers { get; set; }

	public string Description { get; set; }

	public bool Periodical => true;

	public ICalendarItem Template { get; set; }

	public bool HasCopy { get; set; }

	public bool OnlyInfo { get; set; }

	public long CreationAuthor { get; set; }

	public bool ReadOnly { get; set; }

	public ICollection<IComment> Comments => (ICollection<IComment>)Relationship.Comments;

	public bool PrivateAccess => false;

	public RelationshipCalendarItem(IRelationship relationship, IEnumerable<IUser> owners = null)
	{
		if (relationship == null)
		{
			throw new ArgumentNullException("relationship");
		}
		Relationship = relationship.CastAsRealType();
		StartDate = Relationship.StartDate;
		EndDate = Relationship.EndDate;
		Completed = Relationship.Completed ?? false;
		Theme = Relationship.Theme;
		CreationAuthor = Relationship.CreationAuthor.Id;
		IRelationshipMeeting relationshipMeeting = Relationship as IRelationshipMeeting;
		To = ((Relationship.Contractor != null) ? Relationship.Contractor.Name : ((Relationship.Contact != null) ? Relationship.Contact.Name : ((Relationship.Lead != null) ? Relationship.Lead.Name : ((Relationship.Sale != null) ? Relationship.Sale.Name : ""))));
		Place = ((relationshipMeeting != null) ? relationshipMeeting.Place : "");
		List<IUser> list = new List<IUser>();
		if (((IEnumerable<IRelationshipUser>)Relationship.RelationshipUsers).Any())
		{
			list.AddRange(((IEnumerable<IRelationshipUser>)Relationship.RelationshipUsers).Select((IRelationshipUser r) => r.User));
		}
		EventUsers = list.Distinct((IUser a, IUser b) => a.Id == b.Id, (IUser c) => c.Id.GetHashCode()).ToDictionary((IUser u) => u.Id.ToString(), (IUser u) => u.GetShortName());
		Description = Relationship.Description;
		HasCopy = true;
		ReadOnly = false;
		ToInform = owners != null && owners.Any() && !((IEnumerable<IRelationshipUser>)Relationship.RelationshipUsers).Any((IRelationshipUser u) => owners.Any((IUser o) => o == u.User) && u.Status == RelationshipUserStatus.Participant);
	}

	public ICalendarItem Clone()
	{
		return new RelationshipCalendarItem(Relationship);
	}
}
