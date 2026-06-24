using System;
using System.Dynamic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Common.Models;

public abstract class HistoryBaseModel : IHistoryBaseModel
{
	private readonly EntityActionEventArgs _originalEvent;

	private readonly dynamic _eventData = new ExpandoObject();

	public EntityActionEventArgs OriginalEvent => _originalEvent;

	public DateTime ActionDate { get; set; }

	EleWise.ELMA.Security.IUser IHistoryBaseModel.ActionAuthor { get; set; }

	public EleWise.ELMA.Security.Models.IUser ActionAuthor
	{
		get
		{
			return (EleWise.ELMA.Security.Models.IUser)((IHistoryBaseModel)this).ActionAuthor;
		}
		set
		{
			((IHistoryBaseModel)this).ActionAuthor = value;
		}
	}

	public string ActionTheme { get; set; }

	public IAuditAction AuditAction { get; set; }

	public IAuditObject AuditObject { get; set; }

	public virtual dynamic EventData => _eventData;

	protected HistoryBaseModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
	{
		if (originalEvent == null)
		{
			throw new ArgumentNullException("originalEvent");
		}
		_originalEvent = originalEvent;
		ActionTheme = actionTheme;
		AuditAction = originalEvent.Action;
		AuditObject = originalEvent.Object;
		ActionDate = originalEvent.ActionDate;
		ActionAuthor = (EleWise.ELMA.Security.Models.IUser)originalEvent.ActionAuthor;
	}
}
