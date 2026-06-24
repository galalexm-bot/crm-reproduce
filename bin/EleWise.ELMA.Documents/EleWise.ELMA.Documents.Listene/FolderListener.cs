using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
public class FolderListener : PostFlushEventListener
{
	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		if (!(((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IFolder folder))
		{
			return;
		}
		foreach (IFolderReference reference in FolderReferenceManager.Instance.GetReferences(folder))
		{
			bool flag = false;
			if (!folder.CreationDate.HasValue || !reference.CreationDate.HasValue || reference.CreationDate.Value != folder.CreationDate.Value)
			{
				reference.CreationDate = folder.CreationDate;
				flag = true;
			}
			if (!folder.ChangeDate.HasValue || !reference.ChangeDate.HasValue || reference.ChangeDate.Value != folder.ChangeDate.Value)
			{
				reference.ChangeDate = folder.ChangeDate;
				flag = true;
			}
			if (reference.CreationAuthor != folder.CreationAuthor)
			{
				reference.CreationAuthor = folder.CreationAuthor;
				flag = true;
			}
			if (reference.ChangeAuthor != folder.ChangeAuthor)
			{
				reference.ChangeAuthor = folder.ChangeAuthor;
				flag = true;
			}
			if (reference.UseSourceName && reference.Name != folder.Name)
			{
				reference.Name = folder.Name;
				flag = true;
			}
			if (flag)
			{
				reference.Save();
			}
		}
	}
}
