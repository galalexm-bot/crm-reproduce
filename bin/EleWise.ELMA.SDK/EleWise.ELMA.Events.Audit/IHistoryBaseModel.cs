using System;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Events.Audit;

public interface IHistoryBaseModel
{
	DateTime ActionDate { get; set; }

	IUser ActionAuthor { get; set; }

	string ActionTheme { get; set; }

	IAuditAction AuditAction { get; set; }

	IAuditObject AuditObject { get; set; }

	EntityActionEventArgs OriginalEvent { get; }

	dynamic EventData { get; }
}
