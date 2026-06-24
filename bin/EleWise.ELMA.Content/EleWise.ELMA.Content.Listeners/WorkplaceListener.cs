using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Constants;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate;
using NHibernate.Event;

namespace EleWise.ELMA.Content.Listeners;

[Component]
internal class WorkplaceListener : EntityEventsListener
{
	public ITransformationProvider TransformationProvider { get; set; }

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IWorkPlace workPlace)
		{
			if (workPlace.StartMenu == null)
			{
				workPlace.StartMenu = AbstractNHEntityManager<IStartMenu, int>.Instance.Load(MenuManager.StartMenuUid);
			}
			if (workPlace.LeftMenu == null)
			{
				workPlace.LeftMenu = AbstractNHEntityManager<ILeftMenu, int>.Instance.Load(MenuManager.LeftMenuUid);
			}
			if (workPlace.WorkplacePages == null)
			{
				workPlace.WorkplacePages = AbstractNHEntityManager<IWorkplacePages, long>.Instance.Load(WorkPlaceManager.DefaultWorkplacePagesUid);
			}
			if (workPlace.WorkplaceColorSchemes == null)
			{
				workPlace.WorkplaceColorSchemes = AbstractNHEntityManager<IWorkplaceColorScheme, long>.Instance.Load(ColorSchemeConst.DefaultWorkplaceColorSchemeUid);
			}
		}
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IUserWorkPlace userWorkPlace && userWorkPlace.WorkPlace == null)
		{
			userWorkPlace.WorkPlace = WorkPlaceManager.Instance.Load(WorkPlaceManager.DefaultWorkPlaceUid);
			userWorkPlace.ColorScheme = ColorSchemeManager.Instance.GetUserColorScheme(userWorkPlace.WorkPlace, userWorkPlace);
		}
		return base.OnPreInsert(@event);
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		WorkPlaceManager.Instance.RefreshWorkPlaceByUserCache(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IUserWorkPlace);
		MenuManager.Instance.RefreshMenuByWorkPlaceCache(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IWorkPlace);
		WorkplacePagesManager.Instance.RefreshWorkplacePagesByWorkPlaceCache(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IWorkPlace);
		WebToolbarManager.Instance.RefreshWebToolbarByWorkPlaceCache(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IWorkPlace);
		MenuManager.Instance.RefreshMenuReadOnly(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IMenu);
		base.OnPostUpdate(@event);
	}

	public override void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
	{
		if (((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() is IWorkplaceColorScheme workplaceColorScheme && ((AbstractCollectionEvent)@event).get_Collection().GetDeletes(((AbstractCollectionEvent)(object)@event).GetCollectionPersister(), true) is IEnumerable<IColorScheme> source && source.Any())
		{
			IColorScheme colorScheme = ((IEnumerable<IColorScheme>)workplaceColorScheme.ColorSchemes).FirstOrDefault();
			ISession session = base.SessionProvider.GetSession(string.Empty);
			string text = TransformationProvider.Dialect.QuoteIfNeeded("ColorScheme");
			string text2 = string.Format("Update {0} set {1} = :{2} where {1} in (:{3})", TransformationProvider.Dialect.QuoteIfNeeded("User"), text, "defaultColorScheme", "deletesColorSchemes");
			((IQuery)session.CreateSQLQuery(text2)).SetParameter<long>("defaultColorScheme", colorScheme.Id).SetParameterList("deletesColorSchemes", (IEnumerable)source.Select((IColorScheme i) => i.Id).ToList()).ExecuteUpdate();
		}
		base.OnPreUpdateCollection(@event);
	}
}
