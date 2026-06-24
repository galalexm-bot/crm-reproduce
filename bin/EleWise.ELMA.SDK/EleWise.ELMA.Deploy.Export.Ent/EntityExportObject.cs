using System;
using System.Collections.Generic;
using System.Xml;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Deploy.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export.Entities;

public class EntityExportObject : IExportObject
{
	private IEntity entity;

	private EntityMetadata md;

	private ExportRuleList exportRules;

	private static readonly ILogger ExportLog;

	public Guid? CustomUid;

	public List<string> FileUids;

	internal static EntityExportObject lP3SE3EY5iyFpqokA155;

	public IEntity Entity => entity;

	public EntityExportObject(IEntity e)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		PRxpR6EYLMVqNR6tLblU();
		FileUids = new List<string>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				md = (EntityMetadata)MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType());
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num = 1;
				}
				break;
			default:
				entity = e;
				num = 2;
				break;
			}
		}
	}

	public EntityExportObject(IEntity e, ExportRuleList rules)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PRxpR6EYLMVqNR6tLblU();
		FileUids = new List<string>();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				md = (EntityMetadata)MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType());
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				entity = e;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				exportRules = rules;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public IExportObject Read()
	{
		return this;
	}

	public DeployLogMessage Write(XmlWriter writer)
	{
		return Write(writer, null);
	}

	public DeployLogMessage Write(XmlWriter writer, IMetadata metadataTrunc)
	{
		//Discarded unreachable code: IL_022d, IL_023c
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (!CustomUid.HasValue)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 9;
				case 1:
					lmvYgMELFLtSs4L7hftq(writer, tdZuCYEYzNasRWvMmUMQ(0x7E6E5A0B ^ 0x7E6A0407));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					writer.WriteAttributeString((string)tdZuCYEYzNasRWvMmUMQ(-97972138 ^ -97774790), CustomUid.ToString());
					num2 = 3;
					continue;
				case 2:
					ExportLog.Info(AQ0YOAEYcpKmM6jjnwgv(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA5C2957), YAVEiFEYUeWZFUK6lIsH(md), KKP69bEYsjKPVnpjUbo8(entity)));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
				case 6:
					FileUids.AddRange(new EntityXmlSerializer().Serialize(entity, writer, null, exportRules, metadataTrunc));
					num2 = 5;
					continue;
				case 4:
					return new DeployLogMessage(DeployLogMessageType.Info, SR.T((string)tdZuCYEYzNasRWvMmUMQ(0x2ACE37D ^ 0x2A9E0A9), md.DisplayName, KKP69bEYsjKPVnpjUbo8(entity)), endProcess: false);
				case 8:
					UtfMxJELbxyaWd9VlRc0(ExportLog, AQ0YOAEYcpKmM6jjnwgv(tdZuCYEYzNasRWvMmUMQ(0x638095EB ^ 0x63859669), YAVEiFEYUeWZFUK6lIsH(md), entity.GetId()));
					num = 4;
					break;
				default:
					PimhmPELWRBTOyb6YJWh(writer, tdZuCYEYzNasRWvMmUMQ(0x26FFCB59 ^ 0x26FF893B), xuNBpLELBT1nkUxDDKML(md).ToString());
					num2 = 7;
					continue;
				case 5:
					mh0l5AELoGLhh2kJje7m(writer);
					num = 8;
					break;
				}
				break;
			}
		}
	}

	static EntityExportObject()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				PRxpR6EYLMVqNR6tLblU();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				ExportLog = (ILogger)iKQKsdELhyiLjkN7Wqfo(tdZuCYEYzNasRWvMmUMQ(0x1DE3DD89 ^ 0x1DE7BDD5));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void PRxpR6EYLMVqNR6tLblU()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool OCoZcZEYjtXZHcGwE6Xb()
	{
		return lP3SE3EY5iyFpqokA155 == null;
	}

	internal static EntityExportObject RK7fHxEYYcCSyfUA8ZFT()
	{
		return lP3SE3EY5iyFpqokA155;
	}

	internal static object YAVEiFEYUeWZFUK6lIsH(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object KKP69bEYsjKPVnpjUbo8(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static object AQ0YOAEYcpKmM6jjnwgv(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object tdZuCYEYzNasRWvMmUMQ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void lmvYgMELFLtSs4L7hftq(object P_0, object P_1)
	{
		((XmlWriter)P_0).WriteStartElement((string)P_1);
	}

	internal static Guid xuNBpLELBT1nkUxDDKML(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void PimhmPELWRBTOyb6YJWh(object P_0, object P_1, object P_2)
	{
		((XmlWriter)P_0).WriteAttributeString((string)P_1, (string)P_2);
	}

	internal static void mh0l5AELoGLhh2kJje7m(object P_0)
	{
		((XmlWriter)P_0).WriteEndElement();
	}

	internal static void UtfMxJELbxyaWd9VlRc0(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static object iKQKsdELhyiLjkN7Wqfo(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
