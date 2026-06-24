using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.CRM.Components.WorkLog;

[Component(Order = int.MaxValue)]
public class ContactWorkLogExtension : WorkLogExtensionBase<IContact>
{
	public static readonly Guid uid = new Guid("{A6F209B5-CE04-4FFC-9BB0-3BB4EED9DCA3}");

	public override Guid Uid => uid;

	protected override IUser GetDefaultHarmonizator(IEntity entity)
	{
		IUser user = DefaultHarmonizator();
		if (user != null)
		{
			return user;
		}
		if (!(entity is IContact contact))
		{
			return null;
		}
		return contact.CreationAuthor;
	}
}
