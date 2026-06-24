using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Workflow.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Documents.Components;

[Component(Order = 200)]
public class DocumentChangePermissions : IDocumentChangePermissions
{
	internal static DocumentChangePermissions I2bHTq4PX9i2ICV42L;

	public List<IDocument> GetAllDocuments(IDocument document, bool applyToRelated)
	{
		List<IDocument> list = new List<IDocument>();
		list.Add(document);
		if (applyToRelated)
		{
			foreach (IDocumentLink alLink in DocumentLinkManager.Instance.GetAlLinks(document.Id))
			{
				list.Add(alLink.LinkedDocument);
			}
			return list;
		}
		return list;
	}

	public DocumentChangePermissions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ny0qirOO5jOLxMmqcBp();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void ny0qirOO5jOLxMmqcBp()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool FW8RmRzsI6GvZjZfHN()
	{
		return I2bHTq4PX9i2ICV42L == null;
	}

	internal static DocumentChangePermissions mlwZvbOKwWkRtvRXdye()
	{
		return I2bHTq4PX9i2ICV42L;
	}
}
