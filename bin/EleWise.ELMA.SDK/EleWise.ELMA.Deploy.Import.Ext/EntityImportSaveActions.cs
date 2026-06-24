using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[Component]
public abstract class EntityImportSaveActions : IEntityImportSaveActions
{
	private static EntityImportSaveActions HXMQymErzuHkTkvXvGPZ;

	public abstract bool IsSupported(Guid typeGuid);

	public virtual bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data)
	{
		return true;
	}

	public virtual List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data)
	{
		return new List<TestImportMessages>();
	}

	public virtual void ExecSaveActions(IEntity entity, Dictionary<string, string> serviceData)
	{
		ISession session = Locator.GetServiceNotNull<ISessionProvider>().GetSession("");
		session.Save((object)entity);
		session.Flush();
	}

	public virtual void ExecPostSaveActions(IEntity entity, Type type, Dictionary<string, object> values, Dictionary<string, string> serviceData, LinksDictionary links)
	{
	}

	public virtual void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
	}

	public virtual IEnumerable<ILinksDictionaryItem> RecoveryLinks(IEntity entity, Guid entityUid, LinksDictionary linksDictionary)
	{
		return Enumerable.Empty<ILinksDictionaryItem>();
	}

	protected EntityImportSaveActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool HEMDs7EgFXN9dd84WUwT()
	{
		return HXMQymErzuHkTkvXvGPZ == null;
	}

	internal static EntityImportSaveActions MJhvAEEgBk71xMKR7iek()
	{
		return HXMQymErzuHkTkvXvGPZ;
	}
}
