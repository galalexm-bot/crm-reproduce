using System;
using EleWise.ELMA.CRM.Listeners;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Runtime.Managers;

namespace EleWise.ELMA.CRM.Managers;

[Obsolete]
public class AddressBaseManager : NHManagerBase
{
	public void SaveNewFields(IAddress address)
	{
		CRMListener.SaveNewFields(address);
	}

	public virtual Guid SaveNewItems(string name, long type, Guid? parentUid, long? code)
	{
		return AddrManager.Instance.Save(name, (int)type, parentUid, code)?.Uid ?? Guid.Empty;
	}
}
