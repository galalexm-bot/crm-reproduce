using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps;

internal static class BPMAppManifestSerializationHelper
{
	public static List<TestImportMessages> ValidateChaptersXsiTypes(string manifestXml)
	{
		List<TestImportMessages> list = new List<TestImportMessages>();
		if (string.IsNullOrWhiteSpace(manifestXml))
		{
			return list;
		}
		try
		{
			using XmlReader xmlReader = XmlReader.Create(new StringReader(manifestXml));
			xmlReader.Read();
			xmlReader.MoveToElement();
			xmlReader.Read();
			xmlReader.MoveToContent();
			xmlReader.Read();
			xmlReader.MoveToContent();
			List<Type> source = ComponentManager.Current.GetXsiTypes().ToList();
			while (xmlReader.NodeType != XmlNodeType.EndElement)
			{
				if (xmlReader.NodeType != 0)
				{
					if (xmlReader.IsStartElement() && xmlReader.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E15883) && !xmlReader.IsEmptyElement)
					{
						xmlReader.Read();
						xmlReader.MoveToContent();
						while (xmlReader.NodeType != XmlNodeType.EndElement)
						{
							if (xmlReader.IsStartElement() && xmlReader.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE176FA3) && !xmlReader.IsEmptyElement)
							{
								_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
								CS_0024_003C_003E8__locals0.elementType = xmlReader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710734724));
								if (source.Where((Type t) => (string)_003C_003Ec__DisplayClass0_0.UaWv8T8zW8KeEkmMhgB8(t) == CS_0024_003C_003E8__locals0.elementType).ToList().Count == 0)
								{
									list.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978165656), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218150974), CS_0024_003C_003E8__locals0.elementType)));
								}
							}
							xmlReader.Skip();
							xmlReader.MoveToContent();
						}
					}
					xmlReader.Skip();
					xmlReader.MoveToContent();
					continue;
				}
				return list;
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}
}
