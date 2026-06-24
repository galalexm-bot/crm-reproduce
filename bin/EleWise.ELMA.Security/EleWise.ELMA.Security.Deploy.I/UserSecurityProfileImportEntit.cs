using System;
using System.Collections.Generic;
using System.Xml;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Deploy.Import;

internal class UserSecurityProfileImportEntitySaveAction : EntityImportSaveActions
{
	public static readonly Guid UID;

	internal static UserSecurityProfileImportEntitySaveAction waJafZyqqPrveD5cZ5r;

	public override bool IsSupported(Guid typeGuid)
	{
		return typeGuid == UID;
	}

	public override bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data)
	{
		return false;
	}

	public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
		//Discarded unreachable code: IL_0128
		int num = 7;
		XmlReader xmlReader = default(XmlReader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					break;
				case 5:
					IbBrHdyDpqd8hRBOOaQ(xmlReader);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					RYI774yMDrpNqVWRTeD(xmlReader);
					num2 = 3;
					continue;
				case 3:
				case 4:
					if (N3F9hXyskwoikT9OqfA(xmlReader) == XmlNodeType.EndElement)
					{
						num2 = 10;
						continue;
					}
					goto case 5;
				case 9:
					nwYqH1yEgobUBdrq6Mx(xmlReader);
					num2 = 2;
					continue;
				case 10:
					result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, (string)UgRP0NyYkh5FFQX5Gv8(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x62C4BCE8 ^ 0x62C44646))));
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					R4NNLBy0qa0chZIpjhm(xmlReader);
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 == 0)
					{
						num2 = 6;
					}
					continue;
				case 1:
					return;
				case 2:
					R4NNLBy0qa0chZIpjhm(xmlReader);
					num2 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 != 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					nwYqH1yEgobUBdrq6Mx(xmlReader);
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			xmlReader = (XmlReader)SK2uHCyF88KuSr1E9sp(data);
			num = 6;
		}
	}

	public override void ExecSaveActions(IEntity entity, Dictionary<string, string> serviceData)
	{
	}

	public UserSecurityProfileImportEntitySaveAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static UserSecurityProfileImportEntitySaveAction()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				UID = InterfaceActivator.UID<IUserSecurityProfile>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool AOwufnyce62vDsno0GT()
	{
		return waJafZyqqPrveD5cZ5r == null;
	}

	internal static UserSecurityProfileImportEntitySaveAction nF7wD6yGO92FQVjwQ1J()
	{
		return waJafZyqqPrveD5cZ5r;
	}

	internal static object SK2uHCyF88KuSr1E9sp(object P_0)
	{
		return ((ImportTestReadData)P_0).Reader;
	}

	internal static bool R4NNLBy0qa0chZIpjhm(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static bool nwYqH1yEgobUBdrq6Mx(object P_0)
	{
		return ((XmlReader)P_0).MoveToElement();
	}

	internal static void IbBrHdyDpqd8hRBOOaQ(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static XmlNodeType RYI774yMDrpNqVWRTeD(object P_0)
	{
		return ((XmlReader)P_0).MoveToContent();
	}

	internal static XmlNodeType N3F9hXyskwoikT9OqfA(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static object UgRP0NyYkh5FFQX5Gv8(object P_0)
	{
		return SR.T((string)P_0);
	}
}
