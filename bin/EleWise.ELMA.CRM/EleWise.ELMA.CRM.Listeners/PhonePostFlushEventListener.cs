using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using NHibernate.Event;

namespace EleWise.ELMA.CRM.Listeners;

[Component]
public class PhonePostFlushEventListener : PostFlushEventListener
{
	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		UserInsertOrUpdateProcess(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IUser);
		CheckForPhoneSoftDelete(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
	}

	public override void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
	{
		ContractorInsertOrUpdateProcess(((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() as IContractor);
		ContactInsertOrUpdateProcess(((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() as IContact);
		LeadInsertOrUpdateProcess(((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() as ILead);
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		base.OnPostInsert(@event);
		UserInsertOrUpdateProcess(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IUser);
		ContractorInsertOrUpdateProcess(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IContractor);
		ContactInsertOrUpdateProcess(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IContact);
		LeadInsertOrUpdateProcess(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as ILead);
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		base.OnPostDelete(@event);
		UserDeleteProcess(@event);
	}

	private void UserInsertOrUpdateProcess(IUser user)
	{
		if (user != null)
		{
			PhoneHelper.UserPhonesInsertOrUpdate(user);
		}
	}

	private void UserDeleteProcess(PostDeleteEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IUser user)
		{
			PhoneHelper.DeleteUserPhones(user);
		}
	}

	private void ContractorInsertOrUpdateProcess(IContractor contractor)
	{
		if (contractor != null && contractor.Phone != null && ((ICollection<IPhone>)contractor.Phone).Count != 0)
		{
			ContractorPhonesUpdate(contractor);
		}
	}

	private void ContractorPhonesUpdate(IContractor contractor)
	{
		((IEnumerable<IPhone>)contractor.Phone).ToList().ForEach(delegate(IPhone c)
		{
			c.DisplayName = contractor.Name;
			c.ReferenceOnEntity = new ReferenceOnEntity
			{
				Object = contractor
			};
		});
	}

	private void ContactInsertOrUpdateProcess(IContact contact)
	{
		if (contact != null && contact.Phone != null && ((ICollection<IPhone>)contact.Phone).Count != 0)
		{
			ContactPhonesUpdate(contact);
		}
	}

	private void ContactPhonesUpdate(IContact contact)
	{
		((IEnumerable<IPhone>)contact.Phone).ToList().ForEach(delegate(IPhone c)
		{
			c.DisplayName = contact.Name;
			c.ReferenceOnEntity = new ReferenceOnEntity
			{
				Object = contact
			};
		});
	}

	private void LeadInsertOrUpdateProcess(ILead lead)
	{
		if (lead != null && lead.Phone != null && ((ICollection<IPhone>)lead.Phone).Count != 0)
		{
			LeadPhonesUpdate(lead);
		}
	}

	private void LeadPhonesUpdate(ILead lead)
	{
		((IEnumerable<IPhone>)lead.Phone).ToList().ForEach(delegate(IPhone c)
		{
			c.DisplayName = lead.Name;
			c.ReferenceOnEntity = new ReferenceOnEntity
			{
				Object = lead
			};
		});
	}

	private void CheckForPhoneSoftDelete(object entity)
	{
		if (entity is IContractor contractor && contractor.IsDeleted)
		{
			((IEnumerable<IPhone>)contractor.Phone).ForEach(delegate(IPhone p)
			{
				p.Delete();
			});
		}
		if (entity is ILead lead && lead.IsDeleted)
		{
			((IEnumerable<IPhone>)lead.Phone).ForEach(delegate(IPhone p)
			{
				p.Delete();
			});
		}
		if (entity is IContact contact && contact.IsDeleted)
		{
			((IEnumerable<IPhone>)contact.Phone).ForEach(delegate(IPhone p)
			{
				p.Delete();
			});
		}
	}
}
