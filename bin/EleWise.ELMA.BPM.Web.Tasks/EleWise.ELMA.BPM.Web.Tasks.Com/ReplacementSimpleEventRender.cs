using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Audit;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = int.MaxValue)]
public class ReplacementSimpleEventRender : IAuditEventRender
{
	public ReplacementTaskManager ReplacementTaskManager { get; set; }

	public UserManager UserManager { get; set; }

	public bool CanRender(EntityActionEventArgs @event)
	{
		if (@event != null && @event.Action != null && @event.Object != null)
		{
			return @event.Action.Uid == ReplacementTaskActions.ReplacementGuid;
		}
		return false;
	}

	public MvcHtmlString Render(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (@event == null)
		{
			throw new ArgumentNullException("event");
		}
		if (@event.Object == null)
		{
			throw new ArgumentException("event.Object");
		}
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		ReplacementTaskHistoryModel replacementEvent = new ReplacementTaskHistoryModel(@event);
		ReplacementTaskActionEventArgs replacementTaskEvent = @event as ReplacementTaskActionEventArgs;
		if (replacementTaskEvent != null)
		{
			replacementEvent.OldEntity = replacementTaskEvent.Old;
			replacementEvent.NewEntity = replacementTaskEvent.New;
			List<PropertyMetadata> list = (from p in ReplacementTaskFilter.GetProperties(MetadataServiceContext.MetadataRuntimeService.GetMetadata(@event.Object.Uid) as EntityMetadata)
				select p.Key).ToList();
			replacementEvent.Exceptions = list.Select((PropertyMetadata p) => ((EntityUserSettings)p.Settings).ReplacedUserPropertyUid).ToList();
			if (replacementTaskEvent.ChangedProperties != null && replacementTaskEvent.ChangedProperties.Count > 0)
			{
				replacementEvent.ChangedProperties = replacementTaskEvent.ChangedProperties.Where(list.Contains).ToList();
			}
			Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
			{
				replacementEvent.ReplacementTask = ReplacementTaskManager.LoadOrNull(replacementTaskEvent.ReplacementTaskId);
				replacementEvent.Executor = UserManager.LoadOrNull(replacementTaskEvent.TaskExecutorId);
				replacementEvent.ExecutorReplaced = UserManager.LoadOrNull(replacementTaskEvent.TaskExecutorReplacedId);
			});
			if (replacementEvent.ReplacementTask != null)
			{
				if (replacementEvent.ReplacementTask.Comments != null)
				{
					IComment comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
						select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)replacementEvent.ReplacementTask.Comments).Contains(c));
					replacementEvent.Comment = comment;
				}
				if (replacementEvent.ReplacementTask.Attachments != null)
				{
					List<IAttachment> attachments = (from IAttachment a in from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IAttachment>(), DefaultEntityActions.CreateGuid)
							select e.New
						where ((ICollection<IAttachment>)replacementEvent.ReplacementTask.Attachments).Contains(a)
						select a).ToList();
					replacementEvent.Attachments = attachments;
				}
			}
		}
		Locator.GetServiceNotNull<IEnumerable<IHistoryModelEvaluator>>().ForEach(delegate(IHistoryModelEvaluator e)
		{
			e.Evaluate(replacementEvent);
		});
		return html.HistoryItem(replacementEvent, new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper h, IHistoryBaseModel m) => PartialExtensions.Partial(h, "AuditView/Task.Replacement", (object)m)
		});
	}
}
