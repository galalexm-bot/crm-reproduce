using System;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
internal class FilterDocumentFolderListener : EntityEventsListener
{
	private readonly string nameOfUseDefaultSettingsDate = LinqUtils.NameOf((Expression<Func<IFilterDocumentFolder, object>>)((IFilterDocumentFolder f) => f.UseDefaultSettingsDate));

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IFilterDocumentFolder filterDocumentFolder)
		{
			int num = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), nameOfUseDefaultSettingsDate);
			object[] state = @event.get_State();
			DateTime? dateTime2 = (filterDocumentFolder.UseDefaultSettingsDate = DateTime.Now);
			state[num] = dateTime2;
		}
		return false;
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IFilterDocumentFolder filterDocumentFolder)
		{
			int num = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), nameOfUseDefaultSettingsDate);
			DateTime? dateTime = (DateTime?)@event.get_State()[num];
			DateTime? dateTime2 = (DateTime?)@event.get_OldState()[num];
			if (!dateTime2.HasValue || (dateTime.HasValue && dateTime.Value != dateTime2.Value))
			{
				object[] state = @event.get_State();
				DateTime? dateTime4 = (filterDocumentFolder.UseDefaultSettingsDate = DateTime.Now);
				state[num] = dateTime4;
			}
		}
		return false;
	}
}
