using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export.Entities;

[Component(Order = 1000)]
public class EntitiesExport : IExportDataExtension
{
	private static EntitiesExport HOPUJmELGwY0Fq5dOi0E;

	private int Portion => SR.GetSetting((string)uXbADOELQ6q4rB5vUqbl(-2107978722 ^ -2107652044), 100);

	public virtual bool CheckMetadata(IMetadata metadata)
	{
		return metadata is ClassMetadata;
	}

	public List<ClassMetadata> ExportObjects(XmlWriter writer, ClassMetadata metadata, List<DeployLogMessage> messages, List<ClassMetadata> wasExported, List<string> fileUids)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		if (wasExported == null)
		{
			wasExported = new List<ClassMetadata>();
		}
		CS_0024_003C_003E8__locals0.mdRtServise = Locator.GetServiceNotNull<IMetadataRuntimeService>();
		IEntityManager entityManager = ModelHelper.GetEntityManager(CS_0024_003C_003E8__locals0.mdRtServise.GetTypeByUid(metadata.Uid, loadImplementation: false));
		long num = entityManager.Count();
		int num2 = 0;
		int num3 = 0;
		IEntityFilter filter = GetFilter();
		int portion = Portion;
		while (num > 0 && num3 < num)
		{
			int maxResults = portion;
			if (num3 + portion > num)
			{
				maxResults = Convert.ToInt32(num - num3);
			}
			foreach (object item in entityManager.Find(filter, new FetchOptions(num3, maxResults, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105232708))
			{
				DisableDefaultGroupSorting = true
			}))
			{
				EntityExportObject entityExportObject = (EntityExportObject)new EntityExportObject((IEntity)item).Read();
				Type type = entityExportObject.Entity.GetType();
				if (wasExported.Select((ClassMetadata mdC) => CS_0024_003C_003E8__locals0.mdRtServise.GetTypeByUid(mdC.Uid)).Contains(type))
				{
					continue;
				}
				writer.WriteStartElement(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671847593));
				messages.Add(entityExportObject.Write(writer, metadata));
				IEnumerable<IAddEntityToData> extensionPoints = ComponentManager.Current.GetExtensionPoints<IAddEntityToData>();
				if (extensionPoints != null)
				{
					List<IEntity> list = new List<IEntity>();
					foreach (IAddEntityToData item2 in extensionPoints)
					{
						list.AddRange(item2.AddEntities(metadata, item as IEntity));
					}
					foreach (IEntity item3 in list)
					{
						EntityExportObject entityExportObject2 = (EntityExportObject)new EntityExportObject(item3).Read();
						messages.Add(entityExportObject2.Write(writer));
						fileUids.AddRange(entityExportObject2.FileUids);
					}
				}
				writer.WriteEndElement();
				fileUids.AddRange(entityExportObject.FileUids);
			}
			num2++;
			num3 = num2 * portion;
		}
		wasExported.Add(metadata);
		return wasExported;
	}

	protected virtual IEntityFilter GetFilter()
	{
		return null;
	}

	public EntitiesExport()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lqswL4ELC6HFrIBMEJX0();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object uXbADOELQ6q4rB5vUqbl(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool l7qMUxELEisp9FRqmwdl()
	{
		return HOPUJmELGwY0Fq5dOi0E == null;
	}

	internal static EntitiesExport icJHOdELfoksvNEDo988()
	{
		return HOPUJmELGwY0Fq5dOi0E;
	}

	internal static void lqswL4ELC6HFrIBMEJX0()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
