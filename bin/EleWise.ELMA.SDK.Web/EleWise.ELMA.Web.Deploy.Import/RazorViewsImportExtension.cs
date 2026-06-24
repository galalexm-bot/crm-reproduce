using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.BPMApps.Enum;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.DTO.Managers;
using ICSharpCode.SharpZipLib.Zip;

namespace EleWise.ELMA.Web.Deploy.Import;

[Component(Order = 390)]
public class RazorViewsImportExtension : ConfigImportExtension
{
	public override void OnPostCompleteImport(PostCompleteImportParameters parameters)
	{
		string importWebApplicationFolder = ((!string.IsNullOrEmpty(parameters.ServerFolderName)) ? Path.Combine(parameters.ServerFolderName, "WebApplication") : null);
		string configurationPath = WebApplicationDTOManager.GetConfigurationPath(null);
		if (string.IsNullOrEmpty(importWebApplicationFolder) || !Directory.Exists(importWebApplicationFolder) || string.IsNullOrEmpty(configurationPath))
		{
			return;
		}
		IEnumerable<string> enumerable = FileUtils.CopyDirectory(importWebApplicationFolder, configurationPath, overwrite: false);
		if (Directory.Exists(importWebApplicationFolder))
		{
			new DirectoryInfo(importWebApplicationFolder).EnumerateFiles("*.cshtml", SearchOption.AllDirectories).ToList().ForEach(delegate(FileInfo vf)
			{
				string fullName = vf.FullName;
				fullName = fullName.Remove(fullName.IndexOf(importWebApplicationFolder), importWebApplicationFolder.Length);
				parameters.Messages.Add(new DeployLogMessage(BPMAppItemImportStatus.Complete, fullName, parameters.TreeUid));
				parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, SR.T("Копируется файл \"{0}\"", fullName), endProcess: false));
			});
		}
		string unpackedFolder = null;
		Action action = delegate
		{
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			if (unpackedFolder == null)
			{
				if (parameters.Manifest == null)
				{
					unpackedFolder = "";
				}
				else
				{
					ManifestStoreComponentInfo manifestStoreComponentInfo = Locator.GetServiceNotNull<PackageService>().GetStoreComponentsInfo(forRuntime: true).OfType<ManifestStoreComponentInfo>()
						.FirstOrDefault((ManifestStoreComponentInfo i) => i.InstalledManifest != null && i.InstalledManifest.Id == parameters.Manifest.Id);
					if (manifestStoreComponentInfo == null)
					{
						unpackedFolder = "";
					}
					else
					{
						string[] activationKeys = (from p in ComponentManager.Current.LicenseManager.GetActivationKeys()
							select p.Value).ToArray();
						string text4 = IOExtensions.GetTempFileNameWithoutExtension();
						string text5 = Path.ChangeExtension(text4, ".elma4");
						manifestStoreComponentInfo.InstalledFile.SaveTo(text5);
						try
						{
							IEnumerable<StoreComponentVerifiedSignature> signatures;
							switch (ElmaStoreComponentsBuilder.UnpackIfSigned(text5, text4, activationKeys, ComponentManager.Current.ModuleManager.GetMainLicensedUnitExpiration, out signatures))
							{
							case StoreComponentUnpackStatus.Unsigned:
							case StoreComponentUnpackStatus.FreeSigned:
								new FastZip().ExtractZip(text5, text4, (Overwrite)2, (ConfirmOverwriteDelegate)null, (string)null, (string)null, true, false);
								break;
							default:
								try
								{
									Directory.Delete(text4, recursive: true);
								}
								catch (Exception exception2)
								{
									Logger.Log.Error(SR.T("Ошибка удаления временной папки"), exception2);
								}
								text4 = "";
								break;
							case StoreComponentUnpackStatus.Success:
								break;
							}
						}
						catch
						{
							text4 = "";
						}
						finally
						{
							try
							{
								File.Delete(text5);
							}
							catch (Exception exception3)
							{
								Logger.Log.Error(SR.T("Ошибка удаления временного файла"), exception3);
							}
						}
						unpackedFolder = text4;
					}
				}
			}
		};
		Action<string, List<DeployLogMessage>> action2 = delegate(string fileName, List<DeployLogMessage> messages)
		{
			int num = 0;
			string text3;
			do
			{
				text3 = fileName + ((num > 0) ? (".bak" + num) : ".bak");
				num++;
			}
			while (File.Exists(text3));
			File.Copy(fileName, text3, overwrite: false);
			parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Warn, SR.T("При импорте файл \"{0}\" заменен на новый. Старый файл сохранен под именем \"{1}\"", fileName, text3), endProcess: false));
		};
		try
		{
			foreach (string item in enumerable)
			{
				string text = Path.Combine(importWebApplicationFolder, item);
				string text2 = Path.Combine(configurationPath, item);
				byte[] array = File.ReadAllBytes(text);
				byte[] other = File.ReadAllBytes(text2);
				if (((IStructuralEquatable)array).Equals((object)other, (IEqualityComparer)EqualityComparer<byte>.Default))
				{
					continue;
				}
				action();
				if (!string.IsNullOrWhiteSpace(unpackedFolder))
				{
					byte[] array2 = File.ReadAllBytes(Path.Combine(Path.Combine(unpackedFolder, "WebApplication"), item));
					if (!((IStructuralEquatable)array2).Equals((object)array, (IEqualityComparer)EqualityComparer<byte>.Default))
					{
						if (((IStructuralEquatable)array2).Equals((object)other, (IEqualityComparer)EqualityComparer<byte>.Default))
						{
							File.Copy(text, text2, overwrite: true);
							continue;
						}
						action2(text2, parameters.Messages);
						File.Copy(text, text2, overwrite: true);
					}
				}
				else
				{
					action2(text2, parameters.Messages);
					File.Copy(text, text2, overwrite: true);
				}
			}
		}
		finally
		{
			try
			{
				if (!string.IsNullOrWhiteSpace(unpackedFolder))
				{
					Directory.Delete(unpackedFolder, recursive: true);
				}
			}
			catch (Exception exception)
			{
				Logger.Log.Error(SR.T("Ошибка удаления временной папки"), exception);
			}
		}
		parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Empty, ""));
	}

	public override void OnPostCompleteTest(PostCompleteTestImportParameters parameters)
	{
		if (!(parameters?.ImportSettings is ConfigImportSettings configImportSettings) || configImportSettings.FakeManifest == null)
		{
			return;
		}
		string text = ((!string.IsNullOrEmpty(parameters.ServerFolderName)) ? Path.Combine(parameters.ServerFolderName, "WebApplication") : null);
		if (string.IsNullOrWhiteSpace(text) || !Directory.Exists(text))
		{
			return;
		}
		foreach (FileInfo item in new DirectoryInfo(text).EnumerateFiles("*.cshtml", SearchOption.AllDirectories).ToList())
		{
			string fullName = item.FullName;
			List<string> list = (from p in fullName.Remove(fullName.IndexOf(text), text.Length).Split('\\').ToList()
				where !string.IsNullOrWhiteSpace(p)
				select p).ToList();
			BPMAppManifestFakeChapter orCreateChapterByUid = configImportSettings.FakeManifest.GetOrCreateChapterByUid(RazorViewsExportConsts.ExportExtensionUid);
			BPMAppManifestFakeItem bPMAppManifestFakeItem = null;
			string text2 = "";
			foreach (string item2 in list)
			{
				text2 = text2 + "\\" + item2;
				BPMAppManifestFakeItem bPMAppManifestFakeItem2 = ((bPMAppManifestFakeItem == null) ? orCreateChapterByUid.GetOrCreateItemByUidProxy(text2, item2) : bPMAppManifestFakeItem.GetOrCreateItemByUidProxy(text2, item2));
				if (bPMAppManifestFakeItem2 != null)
				{
					bPMAppManifestFakeItem = bPMAppManifestFakeItem2;
				}
			}
		}
	}
}
