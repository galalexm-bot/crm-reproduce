using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

[Component]
public abstract class NotificationTemplateEmbeddedDataSource : INotificationTemplateDataSource
{
	private static NotificationTemplateEmbeddedDataSource VHVncGwihYWgPQixjOX;

	protected virtual string Namespace => GetType().Namespace;

	public IEnumerable<NotificationTemplateFileInfo> GetFiles()
	{
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals0.ns = Namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824386727);
		Assembly assembly = GetType().Assembly;
		IEnumerable<string> enumerable = assembly.GetManifestResourceNames().Where(delegate(string n)
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return _003C_003Ec__DisplayClass0_0.NjoSKjfl0IliWV7CVUFM(n, _003C_003Ec__DisplayClass0_0.IbeegnflxYd26AgccSie(--1360331293 ^ 0x51158C53));
				case 1:
					return false;
				case 2:
					if (!n.StartsWith(CS_0024_003C_003E8__locals0.ns))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				}
			}
		});
		List<NotificationTemplateFileInfo> list = new List<NotificationTemplateFileInfo>();
		foreach (string item2 in enumerable)
		{
			XmlDocument xmlDocument = new XmlDocument();
			using (Stream inStream = assembly.GetManifestResourceStream(item2))
			{
				try
				{
					xmlDocument.Load(inStream);
				}
				catch (Exception exception)
				{
					Logger.Log.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A658F2), item2, assembly.FullName), exception);
					continue;
				}
			}
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(item2.Substring(CS_0024_003C_003E8__locals0.ns.Length));
			try
			{
				NotificationTemplateFileInfo item = new NotificationTemplateFileInfo(fileNameWithoutExtension, xmlDocument);
				list.Add(item);
			}
			catch (Exception exception2)
			{
				Logger.Log.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583775286), item2, assembly.FullName), exception2);
			}
		}
		return list;
	}

	protected NotificationTemplateEmbeddedDataSource()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IFDFDKwK5VvKV06PtE0();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool mHLyLiwRRUiU3IaOv7b()
	{
		return VHVncGwihYWgPQixjOX == null;
	}

	internal static NotificationTemplateEmbeddedDataSource xS01fVwqtyEQ3VB4y3I()
	{
		return VHVncGwihYWgPQixjOX;
	}

	internal static void IFDFDKwK5VvKV06PtE0()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
