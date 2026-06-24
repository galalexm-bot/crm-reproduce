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

internal class UserImportEntitySaveAction : EntityImportSaveActions
{
	public static readonly Guid UID;

	private static UserImportEntitySaveAction ycwhG9yww79rZYCRyTM;

	public override bool IsSupported(Guid typeGuid)
	{
		return MsHIlIyvXdrEby5vCRb(typeGuid, UID);
	}

	public override bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data)
	{
		return false;
	}

	public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
		//Discarded unreachable code: IL_012f
		int num = 10;
		XmlReader xmlReader = default(XmlReader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					iwWnGuyUmlVrdhKwXQs(xmlReader);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c != 0)
					{
						num2 = 5;
					}
					continue;
				case 10:
					xmlReader = (XmlReader)COpEVEyCpU9AKNd4pCS(data);
					num2 = 9;
					continue;
				case 7:
					WhE6LWyKufmTuXuQLhW(xmlReader);
					num2 = 6;
					continue;
				case 5:
					F6IEX1yoCul78UiQH4n(xmlReader);
					num2 = 3;
					continue;
				case 2:
					F6IEX1yoCul78UiQH4n(xmlReader);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
				case 6:
					if (XSmMjKytYjTnc6DHsxV(xmlReader) == XmlNodeType.EndElement)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)BjdQaxyhUS7UbhsAGrt(-1278809262 ^ -1278864900))));
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c != 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					goto end_IL_0012;
				case 8:
					break;
				case 4:
					return;
				}
				zCBnmlyJct0cvNhEwjF(xmlReader);
				num2 = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
				{
					num2 = 3;
				}
				continue;
				end_IL_0012:
				break;
			}
			iwWnGuyUmlVrdhKwXQs(xmlReader);
			num = 2;
		}
	}

	public override void ExecSaveActions(IEntity entity, Dictionary<string, string> serviceData)
	{
	}

	public UserImportEntitySaveAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static UserImportEntitySaveAction()
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
				XX7ydNyODYqDmTAyQAw();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool MsHIlIyvXdrEby5vCRb(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool c29Ccmy2xhgQHbl6qkw()
	{
		return ycwhG9yww79rZYCRyTM == null;
	}

	internal static UserImportEntitySaveAction QL9EVOyPls8NQ9aXMmV()
	{
		return ycwhG9yww79rZYCRyTM;
	}

	internal static object COpEVEyCpU9AKNd4pCS(object P_0)
	{
		return ((ImportTestReadData)P_0).Reader;
	}

	internal static bool iwWnGuyUmlVrdhKwXQs(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static bool F6IEX1yoCul78UiQH4n(object P_0)
	{
		return ((XmlReader)P_0).MoveToElement();
	}

	internal static void zCBnmlyJct0cvNhEwjF(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static XmlNodeType WhE6LWyKufmTuXuQLhW(object P_0)
	{
		return ((XmlReader)P_0).MoveToContent();
	}

	internal static XmlNodeType XSmMjKytYjTnc6DHsxV(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static object BjdQaxyhUS7UbhsAGrt(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void XX7ydNyODYqDmTAyQAw()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
