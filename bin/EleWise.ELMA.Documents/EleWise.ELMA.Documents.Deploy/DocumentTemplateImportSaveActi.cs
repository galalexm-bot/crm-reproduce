using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Deploy.Import;

public class DocumentTemplateImportSaveActions : EntityImportSaveActions
{
	private List<TestImportMessages> testMessages;

	public override bool IsSupported(Guid typeGuid)
	{
		if (!(typeGuid == InterfaceActivator.UID<IDocumentTemplate>()))
		{
			return typeGuid == InterfaceActivator.UID<IDocumentTemplate>(loadImplementation: false);
		}
		return true;
	}

	public override List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data)
	{
		testMessages = new List<TestImportMessages>();
		Dictionary<string, string> serviceData = data.ServiceData;
		IDocumentTemplate template = entity as IDocumentTemplate;
		if (template == null)
		{
			return testMessages;
		}
		Func<BinaryFile> func = delegate
		{
			if (serviceData.Count((KeyValuePair<string, string> s) => IsKeyMatch(s.Key, template.Uid)) > 0)
			{
				string[] array = serviceData.First((KeyValuePair<string, string> s) => IsKeyMatch(s.Key, template.Uid)).Key.Split('_');
				if (array.Count() == 3 && Guid.TryParse(array[1], out var result) && result != Guid.Empty)
				{
					KeyValuePair<BinaryFile, bool> keyValuePair = DownloadBinaryFile(result);
					if (keyValuePair.Key != null && keyValuePair.Key.Uid != Guid.Empty && !keyValuePair.Value)
					{
						DataAccessManager.FileManager.SaveFile(keyValuePair.Key);
					}
					return keyValuePair.Key;
				}
			}
			return null;
		};
		if (template.TemplateType == DocumentTemplateType.File && template.File != null)
		{
			BinaryFile binaryFile = func();
			if (binaryFile != null)
			{
				template.File = binaryFile;
			}
		}
		else if (template.TemplateType == DocumentTemplateType.Document)
		{
			BinaryFile binaryFile2 = func();
			if (binaryFile2 != null)
			{
				if (template.Document != null && template.Document.CurrentVersion != null && template.Document.CurrentVersion.File != null)
				{
					template.Document.CurrentVersion.File = binaryFile2;
				}
				else
				{
					template.File = binaryFile2;
					template.TemplateType = DocumentTemplateType.File;
				}
			}
		}
		return testMessages;
	}

	private KeyValuePair<BinaryFile, bool> DownloadBinaryFile(Guid uid)
	{
		if (uid != Guid.Empty)
		{
			try
			{
				BinaryFile binaryFile = DataAccessManager.FileManager.LoadFile(uid.ToString());
				_ = binaryFile.Name;
				return new KeyValuePair<BinaryFile, bool>(binaryFile, value: true);
			}
			catch (FileNotFoundException)
			{
				return new KeyValuePair<BinaryFile, bool>(Locator.GetServiceNotNull<ICacheFilesService>().GetBinaryFile(uid), value: false);
			}
		}
		return new KeyValuePair<BinaryFile, bool>(null, value: false);
	}

	public static bool IsKeyMatch(string key, Guid templateUid)
	{
		if (!string.IsNullOrEmpty(key) && key.StartsWith("FileToExport_", StringComparison.OrdinalIgnoreCase))
		{
			return key.EndsWith(string.Concat(templateUid, "_{0}"), StringComparison.OrdinalIgnoreCase);
		}
		return false;
	}
}
