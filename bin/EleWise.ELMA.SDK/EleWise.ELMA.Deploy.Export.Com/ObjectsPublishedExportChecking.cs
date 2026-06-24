using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.Enums;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.Export.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export.Components;

[Component]
public class ObjectsPublishedExportCheckingRule : IExportCheckingRule
{
	private MetadataItemHeaderManager metadataItemHeaderManager;

	internal static ObjectsPublishedExportCheckingRule TFtZmuEsEYyyRauJukNK;

	public ObjectsPublishedExportCheckingRule(MetadataItemHeaderManager metadataItemHeaderManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Af8cDbEsC9P9A1yCns4t();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.metadataItemHeaderManager = metadataItemHeaderManager;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
			{
				num = 0;
			}
		}
	}

	public virtual IExportCheckingResult Check(IExportCheckingContext context)
	{
		//Discarded unreachable code: IL_0075, IL_00c7
		int num = 1;
		int num2 = num;
		object value = default(object);
		ObjectsExportSetting objectsExportSetting = default(ObjectsExportSetting);
		BaseExportCheckingResult result = default(BaseExportCheckingResult);
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(context, (string)GrcF5yEsv4NSsnalqLuD(-1638402543 ^ -1638419961));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				if (!((ConfigExportSettings)K67Y8tEs8LXR28FYZAEQ(context)).CustomSettings.TryGetValue(ObjectsExportConsts.ExportExtensionUid, out value))
				{
					num2 = 3;
					continue;
				}
				goto case 5;
			case 6:
				if (objectsExportSetting.Catalogs == null)
				{
					num2 = 8;
					continue;
				}
				break;
			case 2:
			case 3:
			case 8:
				return result;
			case 5:
				if ((objectsExportSetting = value as ObjectsExportSetting) != null)
				{
					num2 = 6;
					continue;
				}
				goto case 2;
			default:
				result = new BaseExportCheckingResult();
				num2 = 4;
				continue;
			case 7:
				break;
			}
			Check(objectsExportSetting.Catalogs.Select((KeyValuePair<Guid, bool> catalog) => catalog.Key), result);
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
			{
				num2 = 2;
			}
		}
	}

	protected virtual string PublishedMissed(string displayName)
	{
		return SR.T((string)GrcF5yEsv4NSsnalqLuD(0x12A5FAC7 ^ 0x12A0F28F), displayName);
	}

	protected void Check(IEnumerable<Guid> uids, BaseExportCheckingResult result)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.result = result;
		uids.ForEach(delegate(Guid uid)
		{
			//Discarded unreachable code: IL_0076, IL_0085, IL_00bc
			int num = 6;
			int num2 = num;
			IMetadataItemHeader metadataItemHeader = default(IMetadataItemHeader);
			while (true)
			{
				switch (num2)
				{
				case 4:
					_003C_003Ec__DisplayClass4_0.v1Zbra8mkRIs0cJHU9dD(CS_0024_003C_003E8__locals0.result, ExportCheckingMessageType.Error, _003C_003Ec__DisplayClass4_0.zpeNIY8mTHhQppeBIUYr(CS_0024_003C_003E8__locals0._003C_003E4__this, _003C_003Ec__DisplayClass4_0.GS85I58mXFICv57O5Nsc(metadataItemHeader)), uid);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return;
				case 5:
					if (metadataItemHeader == null)
					{
						num2 = 3;
						break;
					}
					goto default;
				default:
					if (metadataItemHeader.Published != null)
					{
						num2 = 2;
						break;
					}
					goto case 4;
				case 2:
					return;
				case 1:
					return;
				case 6:
					metadataItemHeader = CS_0024_003C_003E8__locals0._003C_003E4__this.metadataItemHeaderManager.LoadOrNull(uid);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 5;
					}
					break;
				}
			}
		});
	}

	internal static void Af8cDbEsC9P9A1yCns4t()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool eJswADEsf4NSWSo0YQ9B()
	{
		return TFtZmuEsEYyyRauJukNK == null;
	}

	internal static ObjectsPublishedExportCheckingRule v4X43qEsQIyY4XwCye1a()
	{
		return TFtZmuEsEYyyRauJukNK;
	}

	internal static object GrcF5yEsv4NSsnalqLuD(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object K67Y8tEs8LXR28FYZAEQ(object P_0)
	{
		return ((IExportCheckingContext)P_0).Settings;
	}
}
