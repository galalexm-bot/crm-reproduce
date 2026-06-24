using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
public class MyDocumentsListener : EntityEventsListener
{
	public override void OnPostInsert(PostInsertEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IUser user && user.Status != UserStatus.System)
		{
			string name = user.Uid.ToString();
			ContextVars.TryGetValue<bool>(name, out var value);
			if (!value)
			{
				bool value2 = MyDocumentFolderManager.Instance.CreateDefaultFoldersForNewUser(user);
				ContextVars.Set(name, value2);
			}
		}
	}
}
