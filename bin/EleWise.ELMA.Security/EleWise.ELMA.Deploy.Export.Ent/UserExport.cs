using System;
using System.Collections.Generic;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export.Entities;

[Component(Order = 500)]
internal class UserExport : IExportDataExtension
{
	private static readonly ILogger ExportLog;

	private static readonly IList<Guid> Uids;

	private static UserExport OH69llQSBejA3ln3XD;

	public virtual bool CheckMetadata(IMetadata metadata)
	{
		//Discarded unreachable code: IL_009c, IL_00ab
		int num = 3;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
				entityMetadata = metadata as EntityMetadata;
				num2 = 2;
				continue;
			case 1:
				if (!Uids.Contains(gUEKrdgWoBHbIagfPD(entityMetadata)))
				{
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto default;
			case 2:
				if (entityMetadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				return true;
			case 4:
				break;
			}
			break;
		}
		return false;
	}

	public List<ClassMetadata> ExportObjects(XmlWriter writer, ClassMetadata metadata, List<DeployLogMessage> messages, List<ClassMetadata> wasExported, List<string> fileUids)
	{
		if (wasExported == null)
		{
			wasExported = new List<ClassMetadata>();
		}
		string text = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2104667969 ^ -2104667725));
		messages.Add(new DeployLogMessage(DeployLogMessageType.Warn, text));
		ExportLog.Error(text);
		wasExported.Add(metadata);
		return wasExported;
	}

	public UserExport()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		E9ZPXh8DNSA7XwCj5l();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static UserExport()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				E9ZPXh8DNSA7XwCj5l();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				ExportLog = (ILogger)QvTc5O32oV5m9XPFn5(hQDZDNrEKfC4U4Qy0d(-1943394692 ^ -1943395242));
				num2 = 3;
				break;
			case 2:
				return;
			case 3:
				Uids = new List<Guid>
				{
					InterfaceActivator.UID<IUser>(),
					InterfaceActivator.UID<IUserSecurityProfile>()
				};
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static Guid gUEKrdgWoBHbIagfPD(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static bool MJuYTjdNHSjh7IXQ82()
	{
		return OH69llQSBejA3ln3XD == null;
	}

	internal static UserExport opyQm0TdvlKvjop5J1()
	{
		return OH69llQSBejA3ln3XD;
	}

	internal static void E9ZPXh8DNSA7XwCj5l()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object hQDZDNrEKfC4U4Qy0d(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object QvTc5O32oV5m9XPFn5(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
