using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using EleWise.ELMA.Packaging.Extensions;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Packaging.Helper;
using EleWise.ELMA.Packaging.Logging;
using EleWise.ELMA.Packaging.Properties;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public class ElmaStoreComponentsBuilder
{
	private class MemoryStreamDataSource : IStaticDataSource
	{
		private byte[] _bytes;

		public MemoryStreamDataSource(byte[] bytes)
		{
			_bytes = bytes;
		}

		public Stream GetSource()
		{
			return new MemoryStream(_bytes);
		}
	}

	private class UnpackInfo
	{
		public ComponentLicenseInfo licInfo;

		public IEnumerable<StoreComponentVerifiedSignature> signatures;

		public byte[] iconBytes;

		public string iconEntryName;

		public byte[] manifestBytes;

		public byte[] componentBinBytes;

		public ElmaStoreComponentManifest manifest;
	}

	public static void Create(string manifestPath)
	{
		Create(manifestPath, null, null, null);
	}

	public static void Create(string manifestPath, ElmaStoreComponentBuildSettings settings)
	{
		Create(manifestPath, null, null, settings);
	}

	public static void Create(string manifestPath, string componentPath)
	{
		Create(manifestPath, componentPath, null, null);
	}

	public static void Create(string manifestPath, string componentPath, string nupkgsPath)
	{
		Create(manifestPath, componentPath, nupkgsPath, null);
	}

	public static void Create(string manifestPath, string componentPath, string nupkgsPath, ElmaStoreComponentBuildSettings settings)
	{
		Create(manifestPath, componentPath, nupkgsPath, settings, null);
	}

	public static void Create(string manifestPath, string componentPath, string nupkgsPath, ElmaStoreComponentBuildSettings settings, Dictionary<string, ElmaStoreComponentManifest> files, byte[] iconData)
	{
		Create(manifestPath, componentPath, nupkgsPath, settings, files, iconData, null);
	}

	public static void Create(string manifestPath, string componentPath, string nupkgsPath, ElmaStoreComponentBuildSettings settings, Dictionary<string, ElmaStoreComponentManifest> files, byte[] iconData, string componentFilesDirectory)
	{
		Create(manifestPath, componentPath, nupkgsPath, settings, files, iconData, componentFilesDirectory, null);
	}

	public static void Create(string manifestPath, string componentPath, string nupkgsPath, ElmaStoreComponentBuildSettings settings, Dictionary<string, ElmaStoreComponentManifest> files, byte[] iconData, string componentFilesDirectory, string configurationFile)
	{
		ElmaStoreComponentManifest manifest = ManifestBuilder.DeserializeByXmlFromFile<ElmaStoreComponentManifest>(manifestPath);
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(manifestPath);
		string text = nupkgsPath ?? Path.GetDirectoryName(manifestPath);
		string[] packagesFile = Directory.GetFiles(text, "*.nupkg");
		if (string.IsNullOrEmpty(componentPath))
		{
			componentPath = Path.Combine(text, fileNameWithoutExtension + ".elma4");
		}
		bool num = settings != null && settings.SignatureCertificates != null && settings.SignatureCertificates.Count > 0;
		string originalFileName = componentPath;
		if (num)
		{
			componentPath += ".tmp";
		}
		FS.CreateFile(componentPath, delegate
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			ZipOutputStream val = new ZipOutputStream((Stream)File.Create(componentPath));
			try
			{
				WriteFileToZip(val, manifestPath, "manifest.elma4manifest");
				foreach (PackageManifest package in manifest.Packages)
				{
					PackageManifest manifest2 = package;
					string text2 = packagesFile.FirstOrDefault((string p) => Path.GetFileName(p).Equals($"{manifest2.Id}.{manifest2.SemanticVersion}.nupkg", StringComparison.OrdinalIgnoreCase));
					if (text2 != null)
					{
						WriteFileToZip(val, text2, "Packages/" + Path.GetFileName(text2));
					}
				}
				if (files != null)
				{
					foreach (KeyValuePair<string, ElmaStoreComponentManifest> file in files)
					{
						string text3 = string.Format(string.Format("{0}{1}", Guid.NewGuid(), ".elma4"));
						WriteFileToZip(val, file.Key, "BpmAppComponents/" + text3);
					}
				}
				if (!string.IsNullOrWhiteSpace(configurationFile) && File.Exists(configurationFile))
				{
					WriteFileToZip(val, configurationFile, "Data/config.xml");
					string text4 = WriteHash(configurationFile);
					if (!string.IsNullOrWhiteSpace(text4))
					{
						byte[] bytes = Encoding.UTF8.GetBytes(text4);
						WriteBytesToZip(val, bytes, "Data/config.sha");
					}
				}
				if (iconData != null)
				{
					WriteBytesToZip(val, iconData, "icon.png");
				}
				if (!string.IsNullOrWhiteSpace(componentFilesDirectory) && Directory.Exists(componentFilesDirectory))
				{
					WriteDirectoryToZip(val, "ComponentFiles/", componentFilesDirectory);
				}
			}
			finally
			{
				((DeflaterOutputStream)val).set_IsStreamOwner(true);
				((Stream)(object)val).Close();
			}
		});
		if (num)
		{
			Sign(componentPath, originalFileName, settings.SignatureCertificates);
		}
	}

	public static void Create(string manifestPath, string componentPath, string nupkgsPath, ElmaStoreComponentBuildSettings settings, Dictionary<string, ElmaStoreComponentManifest> files)
	{
		Create(manifestPath, componentPath, nupkgsPath, settings, files, null);
	}

	public static void Sign(string componentFileName, IEnumerable<SignatureCertificateReference> certificates)
	{
		if (string.IsNullOrEmpty(componentFileName))
		{
			throw new ArgumentNullException("componentFileName");
		}
		if (!File.Exists(componentFileName))
		{
			throw new FileNotFoundException(SR.T("Не найден файл компонента"), componentFileName);
		}
		string text = componentFileName + ".tmp";
		if (File.Exists(text))
		{
			File.Delete(text);
		}
		File.Move(componentFileName, text);
		Sign(componentFileName, text, certificates);
	}

	public static void Sign(string componentFileName, string originalFileName, IEnumerable<SignatureCertificateReference> certificates)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		if (string.IsNullOrEmpty(componentFileName))
		{
			throw new ArgumentNullException("componentFileName");
		}
		if (string.IsNullOrEmpty(originalFileName))
		{
			throw new ArgumentNullException("originalFileName");
		}
		if (!File.Exists(originalFileName))
		{
			throw new FileNotFoundException(SR.T("Не найден временный файл компонента"), originalFileName);
		}
		bool flag = true;
		try
		{
			byte[] array = null;
			string entryName = null;
			byte[] array2;
			ElmaStoreComponentManifest elmaStoreComponentManifest;
			using (FileStream fileStream = File.Open(originalFileName, FileMode.Open, FileAccess.Read))
			{
				ZipFile zf = new ZipFile(fileStream);
				try
				{
					ZipEntry val = (from name in new string[1] { "manifest.elma4manifest" }.Union(ElmaStoreComponentFile.SupportedManifestFileNames)
						select zf.GetEntry(name)).FirstOrDefault((ZipEntry entry) => entry != null);
					if (val == null)
					{
						throw new InvalidOperationException(SR.T("Не найден манифест в конечном файле"));
					}
					array2 = zf.GetInputStream(val).ReadAllBytes();
					elmaStoreComponentManifest = ManifestBuilder.DeserializeByXml<ElmaStoreComponentManifest>(Encoding.UTF8.GetString(array2));
					flag = elmaStoreComponentManifest.ActivationType == ElmaStoreComponentActivationType.Paid;
					ZipEntry val2 = FindIconEntry(zf);
					if (val2 != null)
					{
						array = zf.GetInputStream(val2).ReadAllBytes();
						entryName = val2.get_Name();
					}
					if (flag)
					{
						zf.BeginUpdate();
						zf.Delete(val);
						if (val2 != null)
						{
							zf.Delete(val2);
						}
						zf.CommitUpdate();
					}
					else
					{
						IEnumerable<ZipEntry> enumerable = ((IEnumerable)zf).OfType<ZipEntry>();
						byte[] componentBin = EvaluateFilesHashArray(enumerable, (ZipEntry e) => zf.GetInputStream(e).ReadAllBytes());
						zf.BeginUpdate();
						ZipEntry[] array3 = enumerable.ToArray();
						foreach (ZipEntry val3 in array3)
						{
							if (val3.get_Name().StartsWith("signatures/") || val3.get_Name().Equals("signatures"))
							{
								zf.Delete(val3);
							}
						}
						WriteSignatures(zf, certificates, array2, componentBin);
						zf.CommitUpdate();
					}
				}
				finally
				{
					if (zf != null)
					{
						((IDisposable)zf).Dispose();
					}
				}
			}
			if (!flag)
			{
				return;
			}
			using FileStream fileStream2 = File.Create(componentFileName);
			ZipOutputStream val4 = new ZipOutputStream((Stream)fileStream2);
			try
			{
				((DeflaterOutputStream)val4).set_IsStreamOwner(false);
				WriteBytesToZip(val4, array2, "manifest.elma4manifest");
				if (array != null)
				{
					WriteBytesToZip(val4, array, entryName);
				}
				byte[] array4 = Crypt(File.ReadAllBytes(originalFileName), elmaStoreComponentManifest.Id.ToLower().Trim());
				WriteBytesToZip(val4, array4, "component.bin");
				WriteSignatures(val4, certificates, array2, array4);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
		}
		finally
		{
			if (flag)
			{
				try
				{
					FS.DeleteFile(originalFileName);
				}
				catch (Exception exception)
				{
					Logger.Log.Warn("Cannot delete original component file", exception);
				}
			}
			else
			{
				if (File.Exists(componentFileName))
				{
					FS.DeleteFile(componentFileName);
				}
				FS.MoveFile(originalFileName, componentFileName);
			}
		}
	}

	public static SignatureCertificateReference[] GetAvailableCertificateReferences()
	{
		X509Store x509Store = new X509Store(StoreLocation.CurrentUser);
		x509Store.Open(OpenFlags.OpenExistingOnly);
		List<X509Certificate2> caCertificates = new List<X509Certificate2>();
		Action<StoreName> obj = delegate(StoreName sn)
		{
			try
			{
				X509Store x509Store2 = new X509Store(sn);
				x509Store2.Open(OpenFlags.OpenExistingOnly);
				caCertificates.AddRange(x509Store2.Certificates.Cast<X509Certificate2>());
			}
			catch (Exception exception)
			{
				Logger.Log.Error($"Cannot get certificates from store '{sn.ToString()}'", exception);
			}
		};
		obj(StoreName.AuthRoot);
		obj(StoreName.CertificateAuthority);
		obj(StoreName.Root);
		obj(StoreName.TrustedPublisher);
		return (from cr in x509Store.Certificates.Cast<X509Certificate2>().Select(delegate(X509Certificate2 userCert)
			{
				List<X509Certificate2> list = caCertificates.Where((X509Certificate2 c) => c.Subject == userCert.Issuer).ToList();
				if (list.Count == 0)
				{
					Logger.Log.Debug($"Cannot find store certificate for '{userCert.Subject}'");
					return null;
				}
				X509Certificate2 x509Certificate = list.FirstOrDefault((X509Certificate2 c) => ValidateChain(userCert, c));
				return (x509Certificate == null) ? null : new SignatureCertificateReference
				{
					ComponentCertificate = userCert,
					StoreCertificate = x509Certificate
				};
			})
			where cr != null
			select cr).ToArray();
	}

	public static ElmaStoreComponentManifest Read(string elma3Path, bool needPackages, string packagesPath, bool needIcon, out List<string> packages, out Image icon)
	{
		List<string> bpmAppFiles;
		return Read(elma3Path, null, null, needPackages, packagesPath, needIcon, out packages, out icon, needBpmApps: false, null, out bpmAppFiles, null);
	}

	public static ElmaStoreComponentManifest Read(string elma3Path, IEnumerable<string> activationKeys, Func<DateTime?> getMainUnitExpiration, bool needPackages, string packagesPath, bool needIcon, out List<string> packages, out Image icon)
	{
		List<string> bpmAppFiles;
		return Read(elma3Path, activationKeys, getMainUnitExpiration, needPackages, packagesPath, needIcon, out packages, out icon, needBpmApps: false, null, out bpmAppFiles, null);
	}

	private static ElmaStoreComponentManifest Read(string elma3Path, IEnumerable<string> activationKeys, Func<DateTime?> getMainUnitExpiration, bool needPackages, string packagesPath, bool needIcon, out List<string> packages, out Image icon, bool needBpmApps, string bpmAppPath, out List<string> bpmAppFiles, Func<string, string> getTempUniqueFolder)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		icon = null;
		packages = new List<string>();
		bpmAppFiles = new List<string>();
		getTempUniqueFolder = CheckGetTempUniqueFolderDelegate(getTempUniqueFolder);
		UnpackInfo unpackInfo;
		try
		{
			if (Unpack(elma3Path, activationKeys, getMainUnitExpiration, out unpackInfo).HasValue || (unpackInfo?.licInfo != null && unpackInfo.licInfo.Status != 0))
			{
				unpackInfo = null;
			}
		}
		catch (Exception exception)
		{
			Logger.Log.Error("Cannot get ELMA Store component signatures", exception);
			throw new InvalidOperationException(SR.T("Не удалось получить электронные подписи компонента. Подробности смотрите в журнале ошибок системы."));
		}
		using (FileStream fileStream = File.OpenRead(elma3Path))
		{
			ZipFile zf = new ZipFile(fileStream);
			try
			{
				int? num = new string[1] { "manifest.elma4manifest" }.Union(ElmaStoreComponentFile.SupportedManifestFileNames).Select(delegate(string name)
				{
					int num2 = zf.FindEntry(name, true);
					return (num2 >= 0) ? new int?(num2) : null;
				}).FirstOrDefault((int? index) => index.HasValue);
				if (!num.HasValue)
				{
					return null;
				}
				string @string;
				using (Stream stream = zf.GetInputStream((long)num.Value))
				{
					@string = Encoding.UTF8.GetString(stream.ReadAllBytes());
				}
				ElmaStoreComponentManifest elmaStoreComponentManifest = ManifestBuilder.DeserializeByXml<ElmaStoreComponentManifest>(@string);
				if (needBpmApps && elmaStoreComponentManifest != null && elmaStoreComponentManifest.BpmApps != null && elmaStoreComponentManifest.BpmApps.Any())
				{
					if (string.IsNullOrEmpty(bpmAppPath))
					{
						bpmAppPath = getTempUniqueFolder("BpmAppComponents");
					}
					if (!Directory.Exists(bpmAppPath))
					{
						FS.CreateDirectory(bpmAppPath);
					}
					if (unpackInfo != null)
					{
						using MemoryStream memoryStream = new MemoryStream(Decrypt(unpackInfo.componentBinBytes, unpackInfo.manifest.Id.ToLower().Trim()));
						ZipFile val = new ZipFile((Stream)memoryStream);
						try
						{
							bpmAppFiles.AddRange(ExtractFiles(val, bpmAppPath, "BpmAppComponents/"));
						}
						finally
						{
							((IDisposable)val)?.Dispose();
						}
					}
					else
					{
						bpmAppFiles.AddRange(ExtractFiles(zf, bpmAppPath, "BpmAppComponents/"));
					}
				}
				if (needPackages)
				{
					if (string.IsNullOrEmpty(packagesPath))
					{
						packagesPath = getTempUniqueFolder("Packages");
					}
					if (!Directory.Exists(packagesPath))
					{
						FS.CreateDirectory(packagesPath);
					}
					if (unpackInfo != null)
					{
						using MemoryStream memoryStream2 = new MemoryStream(Decrypt(unpackInfo.componentBinBytes, unpackInfo.manifest.Id.ToLower().Trim()));
						ZipFile val2 = new ZipFile((Stream)memoryStream2);
						try
						{
							packages.AddRange(ExtractFiles(val2, packagesPath, "Packages/"));
						}
						finally
						{
							((IDisposable)val2)?.Dispose();
						}
					}
					else
					{
						packages.AddRange(ExtractFiles(zf, packagesPath, "Packages/"));
					}
				}
				if (needIcon)
				{
					icon = FindIcon(zf);
				}
				return elmaStoreComponentManifest;
			}
			finally
			{
				if (zf != null)
				{
					((IDisposable)zf).Dispose();
				}
			}
		}
		string fileName;
		byte[] buffer;
		static IEnumerable<string> ExtractFiles(ZipFile zip, string path, string extractFolder)
		{
			foreach (ZipEntry item in zip)
			{
				ZipEntry val3 = item;
				if (val3.get_IsFile() && (val3.get_Name() == null || val3.get_Name().StartsWith(extractFolder)))
				{
					Stream packageStream = zip.GetInputStream(val3);
					try
					{
						fileName = Path.Combine(path, Path.GetFileName(val3.get_Name()));
						buffer = new byte[4096];
						FS.CreateFile(fileName, delegate
						{
							using FileStream fileStream2 = File.Create(fileName);
							StreamUtils.Copy(packageStream, (Stream)fileStream2, buffer);
						});
						yield return fileName;
					}
					finally
					{
						if (packageStream != null)
						{
							((IDisposable)packageStream).Dispose();
						}
					}
				}
			}
		}
	}

	private static Func<string, string> CheckGetTempUniqueFolderDelegate(Func<string, string> getTempUniqueFolder)
	{
		if (getTempUniqueFolder != null)
		{
			return getTempUniqueFolder;
		}
		return (string prefix) => ExportImportTempFolderHelper.GetTempUniqueFolder(prefix);
	}

	public static ElmaStoreComponentManifest Read(string elma3Path, bool needPackages, string packagesPath, out List<string> packages)
	{
		Image icon;
		return Read(elma3Path, needPackages, packagesPath, needIcon: false, out packages, out icon);
	}

	public static ElmaStoreComponentManifest Read(string elma3Path)
	{
		List<string> packages;
		return Read(elma3Path, needPackages: false, null, out packages);
	}

	public static ElmaStoreComponentManifest Read(string elma3Path, out Image icon)
	{
		List<string> packages;
		return Read(elma3Path, needPackages: false, null, needIcon: true, out packages, out icon);
	}

	public static StoreComponentUnpackStatus UnpackIfSigned(string elma3Path, string serverFolderName, IEnumerable<string> activationKeys, Func<DateTime?> getMainUnitExpiration, out IEnumerable<StoreComponentVerifiedSignature> signatures)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrWhiteSpace(elma3Path))
		{
			throw new ArgumentException("elma3Path is Empty");
		}
		if (string.IsNullOrWhiteSpace(serverFolderName))
		{
			throw new ArgumentException("serverFolderName is Empty");
		}
		UnpackInfo unpackInfo;
		StoreComponentUnpackStatus? storeComponentUnpackStatus = Unpack(elma3Path, activationKeys, getMainUnitExpiration, out unpackInfo);
		signatures = unpackInfo.signatures;
		if (storeComponentUnpackStatus.HasValue)
		{
			return storeComponentUnpackStatus.Value;
		}
		if (unpackInfo.licInfo != null && unpackInfo.licInfo.Status != 0)
		{
			return StoreComponentUnpackStatus.ActivationError;
		}
		if (!Directory.Exists(serverFolderName))
		{
			Directory.CreateDirectory(serverFolderName);
		}
		using (MemoryStream memoryStream = new MemoryStream(Decrypt(unpackInfo.componentBinBytes, unpackInfo.manifest.Id.ToLower().Trim())))
		{
			new FastZip().ExtractZip((Stream)memoryStream, serverFolderName, (Overwrite)2, (ConfirmOverwriteDelegate)null, (string)null, (string)null, true, false, false);
		}
		File.WriteAllBytes(Path.Combine(serverFolderName, "manifest.elma4manifest"), unpackInfo.manifestBytes);
		if (!string.IsNullOrEmpty(unpackInfo.iconEntryName) && unpackInfo.iconBytes != null)
		{
			File.WriteAllBytes(Path.Combine(serverFolderName, unpackInfo.iconEntryName), unpackInfo.manifestBytes);
		}
		if (unpackInfo.signatures != null && unpackInfo.signatures.Any())
		{
			File.WriteAllBytes(Path.Combine(serverFolderName, "signatures.zip"), StoreComponentSignatureInfo.Compress(unpackInfo.signatures));
		}
		return StoreComponentUnpackStatus.Success;
	}

	public static ComponentLicenseInfo GetLicenseInfo(ElmaStoreComponentManifest manifest, IEnumerable<StoreComponentSignatureInfo> signatures, IEnumerable<string> activationKeys, Func<DateTime?> getMainUnitExpiration)
	{
		if (manifest == null)
		{
			throw new ArgumentNullException("manifest");
		}
		if (manifest.ActivationType != ElmaStoreComponentActivationType.Paid || signatures == null || !signatures.Any())
		{
			return null;
		}
		foreach (StoreComponentSignatureInfo signature in signatures)
		{
			if (!ValidateChain(signature.ComponentCertificate, signature.StoreCertificate))
			{
				throw new InvalidOperationException(SR.T("Неверный набор сертификатов у компонента '{0}'", manifest.GetNonEmptyTitle()));
			}
		}
		RSALicense rSALicense = new RSALicense(manifest.GetUid(), manifest.Id, manifest.Version, signatures.Select((StoreComponentSignatureInfo s) => s.ComponentCertificate).ToArray(), getMainUnitExpiration);
		if (activationKeys != null)
		{
			foreach (string activationKey in activationKeys)
			{
				rSALicense.ApplyActivationKey(activationKey);
			}
		}
		rSALicense.CompleteLicensingInitialize();
		return rSALicense.GetLicenseInfo();
	}

	public static ComponentLicenseInfo GetLicenseInfo(string elma3Path, IEnumerable<string> activationKeys, Func<DateTime?> getMainUnitExpiration)
	{
		Unpack(elma3Path, activationKeys, getMainUnitExpiration, out var unpackInfo);
		return unpackInfo.licInfo;
	}

	public static IEnumerable<StoreComponentSignatureInfo> GetSignatures(string elma3Path)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		if (string.IsNullOrWhiteSpace(elma3Path))
		{
			throw new ArgumentException("elma3Path is Empty");
		}
		using FileStream fileStream = File.Open(elma3Path, FileMode.Open, FileAccess.Read);
		ZipFile val = new ZipFile(fileStream);
		try
		{
			byte[] manifestBytes;
			byte[] componentBinBytes;
			ElmaStoreComponentManifest manifest;
			return GetSignatures(val, out manifestBytes, out componentBinBytes, out manifest);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static Image ReadIcon(string elma3Path)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		ZipFile val = null;
		try
		{
			val = new ZipFile(File.OpenRead(elma3Path));
			return FindIcon(val);
		}
		finally
		{
			if (val != null)
			{
				val.set_IsStreamOwner(true);
				val.Close();
			}
		}
	}

	public static bool ValidateOnComponent(string fileName, out ElmaStoreComponentManifest manifest)
	{
		manifest = null;
		if (!File.Exists(fileName))
		{
			return false;
		}
		try
		{
			manifest = Read(fileName);
			return manifest != null;
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex.Message, ex);
			return false;
		}
	}

	public static bool ValidateOnComponent(string fileName)
	{
		ElmaStoreComponentManifest manifest;
		return ValidateOnComponent(fileName, out manifest);
	}

	public static List<ValidateTreeItem> ExtractAndValidateOnComponent(List<string> fileNames)
	{
		return ExtractAndValidateOnComponent(fileNames, null, null, null);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static List<ValidateTreeItem> ExtractAndValidateOnComponent(List<string> fileNames, Func<string, string> getTempUniqueFolder)
	{
		return ExtractAndValidateOnComponent(fileNames, getTempUniqueFolder, null, null);
	}

	public static List<ValidateTreeItem> ExtractAndValidateOnComponent(List<string> fileNames, Func<string, string> getTempUniqueFolder, IEnumerable<string> activationKeys, Func<DateTime?> getMainUnitExpiration)
	{
		List<ValidateTreeItem> list = new List<ValidateTreeItem>();
		ExtractAndValidateOnComponent(fileNames.Select((string fn) => new ValidateTreeItem(fn, fn)).ToList(), list, 0, getTempUniqueFolder, activationKeys, getMainUnitExpiration);
		return list;
	}

	private static void ExtractAndValidateOnComponent(List<ValidateTreeItem> fileNames, List<ValidateTreeItem> resultList, int level, Func<string, string> getTempUniqueFolder, IEnumerable<string> activationKeys, Func<DateTime?> getMainUnitExpiration)
	{
		level++;
		if (level > 100)
		{
			throw new NestingLevelException();
		}
		fileNames.ForEach(delegate(ValidateTreeItem item)
		{
			if (resultList.All((ValidateTreeItem i) => i.File != item.File))
			{
				resultList.Add(item);
				if (File.Exists(item.File))
				{
					try
					{
						List<string> packages;
						Image icon;
						List<string> bpmAppFiles;
						ElmaStoreComponentManifest elmaStoreComponentManifest = Read(item.File, activationKeys, getMainUnitExpiration, needPackages: false, null, needIcon: false, out packages, out icon, needBpmApps: true, null, out bpmAppFiles, getTempUniqueFolder);
						if (elmaStoreComponentManifest != null)
						{
							item.Manifest = elmaStoreComponentManifest;
							if (bpmAppFiles.Any())
							{
								ExtractAndValidateOnComponent(bpmAppFiles.Select((string fn) => new ValidateTreeItem(item.File, fn)).ToList(), item.Items, level, getTempUniqueFolder, activationKeys, getMainUnitExpiration);
							}
						}
						else
						{
							item.Messages.Add(new ValidateMessage(ValidateMessageCode.Error, SR.T("Файл не является компонентом BPM App")));
						}
						return;
					}
					catch (Exception ex)
					{
						item.Messages.Add(new ValidateMessage(ValidateMessageCode.Error, ex.Message));
						return;
					}
				}
				item.Messages.Add(new ValidateMessage(ValidateMessageCode.Error, SR.T("Файл {0} не найден", item.File)));
			}
		});
	}

	private static string WriteHash(string configFile)
	{
		try
		{
			if (File.Exists(configFile))
			{
				using (FileStream inputStream = File.OpenRead(configFile))
				{
					using SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
					return BitConverter.ToString(sHA1CryptoServiceProvider.ComputeHash(inputStream)).Replace("-", string.Empty);
				}
			}
		}
		catch (Exception)
		{
			return null;
		}
		return null;
	}

	private static void WriteDirectoryToZip(ZipOutputStream zipStream, string parentPath, string path)
	{
		foreach (string item in Directory.EnumerateFiles(path))
		{
			WriteFileToZip(zipStream, item, parentPath + Path.GetFileName(item));
		}
		string[] directories = Directory.GetDirectories(path);
		foreach (string path2 in directories)
		{
			WriteDirectoryToZip(zipStream, parentPath + Path.GetDirectoryName(path2) + "/", path2);
		}
	}

	private static void WriteFileToZip(ZipOutputStream zipStream, string filePath, string entryName)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		FileInfo fileInfo = new FileInfo(filePath);
		entryName = ZipEntry.CleanName(entryName);
		ZipEntry val = new ZipEntry(entryName);
		val.set_DateTime(fileInfo.LastWriteTime);
		val.set_Size(fileInfo.Length);
		val.set_IsUnicodeText(true);
		ZipEntry val2 = val;
		zipStream.PutNextEntry(val2);
		byte[] array = new byte[4096];
		using (FileStream fileStream = File.OpenRead(filePath))
		{
			StreamUtils.Copy((Stream)fileStream, (Stream)(object)zipStream, array);
		}
		zipStream.CloseEntry();
	}

	private static void WriteBytesToZip(ZipOutputStream zipStream, byte[] bytes, string entryName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		entryName = ZipEntry.CleanName(entryName);
		ZipEntry val = new ZipEntry(entryName);
		val.set_Size((long)bytes.Length);
		ZipEntry val2 = val;
		zipStream.PutNextEntry(val2);
		((Stream)(object)zipStream).Write(bytes, 0, bytes.Length);
		zipStream.CloseEntry();
	}

	private static Image FindIcon(ZipFile zf)
	{
		ZipEntry val = FindIconEntry(zf);
		if (val != null)
		{
			try
			{
				return Image.FromStream(zf.GetInputStream(val));
			}
			catch (Exception exception)
			{
				Logger.Log.Error("Cannot read component icon", exception);
				return null;
			}
		}
		return null;
	}

	private static ZipEntry FindIconEntry(ZipFile zf)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		foreach (ZipEntry item in zf)
		{
			ZipEntry val = item;
			if (val.get_Name() != null && val.get_Name().ToUpper().Contains("ICON."))
			{
				return val;
			}
		}
		return null;
	}

	private static AesManaged CreateAes(string psw)
	{
		int iterations = 100;
		int keySize = 128;
		byte[] array = new byte[16];
		new Random().NextBytes(array);
		AesManaged obj = new AesManaged
		{
			Padding = PaddingMode.PKCS7,
			KeySize = keySize
		};
		int cb = obj.KeySize / 8;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(psw, array, iterations);
		obj.Key = rfc2898DeriveBytes.GetBytes(cb);
		obj.IV = rfc2898DeriveBytes.GetBytes(cb);
		return obj;
	}

	private static byte[] Crypt(byte[] data, string psw)
	{
		using MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(psw));
		return new TripleDESCryptoServiceProvider
		{
			Key = key,
			Mode = CipherMode.ECB,
			Padding = PaddingMode.PKCS7
		}.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
	}

	private static byte[] Decrypt(byte[] data, string psw)
	{
		using MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(psw));
		return new TripleDESCryptoServiceProvider
		{
			Key = key,
			Mode = CipherMode.ECB,
			Padding = PaddingMode.PKCS7
		}.CreateDecryptor().TransformFinalBlock(data, 0, data.Length);
	}

	private static void WriteCertificate(Action<string, byte[]> addEntry, X509Certificate2 cert, string entryName)
	{
		byte[] bytes = Encoding.ASCII.GetBytes("-----BEGIN CERTIFICATE-----\n" + Convert.ToBase64String(cert.Export(X509ContentType.Cert)) + "\n-----END CERTIFICATE-----");
		addEntry(entryName, bytes);
	}

	private static void WriteSignatureItem(Action<string, byte[]> addEntry, byte[] data, RSACryptoServiceProvider csp, string entryName)
	{
		using SHA1Managed sHA1Managed = new SHA1Managed();
		new UnicodeEncoding();
		byte[] rgbHash = sHA1Managed.ComputeHash(data);
		byte[] arg = csp.SignHash(rgbHash, CryptoConfig.MapNameToOID("SHA1"));
		addEntry(entryName, arg);
	}

	private static bool VerifySignature(byte[] data, RSACryptoServiceProvider csp, byte[] signature)
	{
		using SHA1Managed sHA1Managed = new SHA1Managed();
		new UnicodeEncoding();
		byte[] rgbHash = sHA1Managed.ComputeHash(data);
		return csp.VerifyHash(rgbHash, CryptoConfig.MapNameToOID("SHA1"), signature);
	}

	private static void WriteSignatures(ZipFile file, IEnumerable<SignatureCertificateReference> certRefs, byte[] manifestBytes, byte[] componentBin)
	{
		WriteSignatures((Action<string, byte[]>)delegate(string entryName, byte[] entryData)
		{
			string text = ZipEntry.CleanName(entryName);
			file.Add((IStaticDataSource)(object)new MemoryStreamDataSource(entryData), text);
		}, certRefs, manifestBytes, componentBin);
	}

	private static void WriteSignatures(ZipOutputStream stream, IEnumerable<SignatureCertificateReference> certRefs, byte[] manifestBytes, byte[] componentBin)
	{
		WriteSignatures((Action<string, byte[]>)delegate(string entryName, byte[] entryData)
		{
			WriteBytesToZip(stream, entryData, entryName);
		}, certRefs, manifestBytes, componentBin);
	}

	private static void WriteSignatures(Action<string, byte[]> addEntry, IEnumerable<SignatureCertificateReference> certRefs, byte[] manifestBytes, byte[] componentBin)
	{
		int num = 0;
		foreach (SignatureCertificateReference certRef in certRefs)
		{
			num++;
			WriteSignature(addEntry, certRef, manifestBytes, componentBin, num);
		}
	}

	private static void WriteSignature(Action<string, byte[]> addEntry, SignatureCertificateReference certRef, byte[] manifestBytes, byte[] componentBin, int signatureIndex)
	{
		RSACryptoServiceProvider csp = (RSACryptoServiceProvider)certRef.ComponentCertificate.PrivateKey;
		string text = "signatures/s" + signatureIndex;
		WriteSignatureItem(addEntry, manifestBytes, csp, text + ".manifest.signature");
		WriteSignatureItem(addEntry, componentBin, csp, text + ".component.signature");
		WriteCertificate(addEntry, certRef.ComponentCertificate, text + ".component.cer");
		WriteCertificate(addEntry, certRef.StoreCertificate, text + ".store.cer");
	}

	public static bool ValidateChain(X509Certificate2 componentCertificate, X509Certificate2 storeCertificate)
	{
		X509Chain x509Chain = X509Chain.Create();
		X509Certificate2 x509Certificate = new X509Certificate2(Resources.elma_root);
		x509Chain.ChainPolicy.ExtraStore.Add(x509Certificate);
		x509Chain.ChainPolicy.ExtraStore.Add(storeCertificate);
		x509Chain.ChainPolicy.RevocationFlag = X509RevocationFlag.ExcludeRoot;
		x509Chain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
		x509Chain.ChainPolicy.VerificationFlags = X509VerificationFlags.AllowUnknownCertificateAuthority;
		if (!x509Chain.Build(componentCertificate))
		{
			string text = string.Join("\r\n", x509Chain.ChainStatus.Select((X509ChainStatus s) => s.StatusInformation).ToList());
			Logger.Log.Debug($"Wrong certificate chain: '{componentCertificate.Subject}', '{storeCertificate.Subject}'" + ":\r\n" + text);
			return false;
		}
		if (x509Chain.ChainElements[x509Chain.ChainElements.Count - 1].Certificate.Thumbprint != x509Certificate.Thumbprint)
		{
			Logger.Log.Debug($"Wrong ROOT for certificate chain: '{componentCertificate.Subject}', '{storeCertificate.Subject}'");
			return false;
		}
		return true;
	}

	private static IEnumerable<StoreComponentVerifiedSignature> GetSignatures(ZipFile zf, out byte[] manifestBytes, out byte[] componentBinBytes, out ElmaStoreComponentManifest manifest)
	{
		manifestBytes = null;
		manifest = null;
		componentBinBytes = null;
		List<StoreComponentVerifiedSignature> list = new List<StoreComponentVerifiedSignature>();
		ZipEntry val = (from name in new string[1] { "manifest.elma4manifest" }.Union(ElmaStoreComponentFile.SupportedManifestFileNames)
			select zf.GetEntry(name)).FirstOrDefault((ZipEntry entry) => entry != null);
		if (val == null)
		{
			return list;
		}
		manifestBytes = zf.GetInputStream(val).ReadAllBytes();
		string @string = Encoding.UTF8.GetString(manifestBytes);
		manifest = ManifestBuilder.DeserializeByXml<ElmaStoreComponentManifest>(@string);
		byte[] data;
		if (manifest.ActivationType == ElmaStoreComponentActivationType.Paid)
		{
			ZipEntry entry2 = zf.GetEntry("component.bin");
			if (entry2 == null)
			{
				return list;
			}
			componentBinBytes = zf.GetInputStream(entry2).ReadAllBytes();
			data = componentBinBytes;
		}
		else
		{
			data = EvaluateFilesHashArray(((IEnumerable)zf).OfType<ZipEntry>().ToArray(), (ZipEntry e) => zf.GetInputStream(e).ReadAllBytes());
		}
		int num = 0;
		while (true)
		{
			num++;
			string text = "signatures/s" + num;
			ZipEntry entry3 = zf.GetEntry(text + ".manifest.signature");
			ZipEntry entry4 = zf.GetEntry(text + ".component.signature");
			ZipEntry entry5 = zf.GetEntry(text + ".component.cer");
			ZipEntry entry6 = zf.GetEntry(text + ".store.cer");
			if (entry3 == null || entry4 == null || entry5 == null || entry6 == null)
			{
				break;
			}
			X509Certificate2 x509Certificate;
			try
			{
				x509Certificate = new X509Certificate2(zf.GetInputStream(entry5).ReadAllBytes());
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException("Wrong component certificate", innerException);
			}
			X509Certificate2 storeCertificate;
			try
			{
				storeCertificate = new X509Certificate2(zf.GetInputStream(entry6).ReadAllBytes());
			}
			catch (Exception innerException2)
			{
				throw new InvalidOperationException("Wront store certificate", innerException2);
			}
			byte[] array;
			try
			{
				array = zf.GetInputStream(entry3).ReadAllBytes();
			}
			catch (Exception innerException3)
			{
				throw new InvalidOperationException("Cannot read manifest signature file", innerException3);
			}
			byte[] array2;
			try
			{
				array2 = zf.GetInputStream(entry4).ReadAllBytes();
			}
			catch (Exception innerException4)
			{
				throw new InvalidOperationException("Cannot read component content signature file", innerException4);
			}
			StoreComponentSignatureStatus status = StoreComponentSignatureStatus.Success;
			if (!ValidateChain(x509Certificate, storeCertificate))
			{
				status = StoreComponentSignatureStatus.WrongCertificates;
			}
			else
			{
				RSACryptoServiceProvider csp = (RSACryptoServiceProvider)x509Certificate.PublicKey.Key;
				if (!VerifySignature(manifestBytes, csp, array))
				{
					status = StoreComponentSignatureStatus.WrongManifestSignature;
				}
				else if (!VerifySignature(data, csp, array2))
				{
					status = StoreComponentSignatureStatus.WrongContentSignature;
				}
			}
			StoreComponentVerifiedSignature item = new StoreComponentVerifiedSignature(x509Certificate, storeCertificate, array2, array, status, num);
			list.Add(item);
		}
		return list;
	}

	private static StoreComponentUnpackStatus? Unpack(string elma3Path, IEnumerable<string> activationKeys, Func<DateTime?> getMainUnitExpiration, out UnpackInfo unpackInfo)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		if (string.IsNullOrWhiteSpace(elma3Path))
		{
			throw new ArgumentException("elma3Path is Empty");
		}
		unpackInfo = new UnpackInfo();
		using (FileStream fileStream = File.Open(elma3Path, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			ZipFile val = new ZipFile(fileStream);
			try
			{
				unpackInfo.signatures = GetSignatures(val, out var manifestBytes, out var componentBinBytes, out var manifest);
				unpackInfo.manifestBytes = manifestBytes;
				unpackInfo.componentBinBytes = componentBinBytes;
				if (!unpackInfo.signatures.Any())
				{
					return StoreComponentUnpackStatus.Unsigned;
				}
				if (unpackInfo.signatures.Any((StoreComponentVerifiedSignature s) => s.Status != StoreComponentSignatureStatus.Success))
				{
					return StoreComponentUnpackStatus.WrongSignatures;
				}
				if (manifest.ActivationType != ElmaStoreComponentActivationType.Paid)
				{
					return StoreComponentUnpackStatus.FreeSigned;
				}
				ZipEntry val2 = FindIconEntry(val);
				if (val2 != null)
				{
					unpackInfo.iconBytes = val.GetInputStream(val2).ReadAllBytes();
					unpackInfo.iconEntryName = val2.get_Name();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		if (unpackInfo.manifestBytes == null)
		{
			throw new NullReferenceException("manifestBytes == null");
		}
		if (unpackInfo.componentBinBytes == null)
		{
			throw new NullReferenceException("componentBinBytes == null");
		}
		string @string = Encoding.UTF8.GetString(unpackInfo.manifestBytes);
		unpackInfo.manifest = ManifestBuilder.DeserializeByXml<ElmaStoreComponentManifest>(@string);
		if (unpackInfo.manifest.ActivationType == ElmaStoreComponentActivationType.Paid)
		{
			foreach (StoreComponentVerifiedSignature signature in unpackInfo.signatures)
			{
				if (!ValidateChain(signature.ComponentCertificate, signature.StoreCertificate))
				{
					throw new InvalidOperationException(SR.T("Неверный набор сертификатов у компонента '{0}'", unpackInfo.manifest.GetNonEmptyTitle()));
				}
			}
			RSALicense rSALicense = new RSALicense(unpackInfo.manifest.GetUid(), unpackInfo.manifest.Id, unpackInfo.manifest.Version, unpackInfo.signatures.Select((StoreComponentVerifiedSignature s) => s.ComponentCertificate).ToArray(), getMainUnitExpiration);
			if (activationKeys != null)
			{
				foreach (string activationKey in activationKeys)
				{
					rSALicense.ApplyActivationKey(activationKey);
				}
			}
			rSALicense.CompleteLicensingInitialize();
			unpackInfo.licInfo = rSALicense.GetLicenseInfo();
		}
		return null;
	}

	private static byte[] EvaluateFilesHashArray(IEnumerable<ZipEntry> entries, Func<ZipEntry, byte[]> extractContent)
	{
		if (entries == null)
		{
			throw new ArgumentNullException("entries");
		}
		if (extractContent == null)
		{
			throw new ArgumentNullException("extractContent");
		}
		List<ZipEntry> list = (from e in entries
			where !e.get_IsDirectory()
			where !e.get_Name().StartsWith("signatures/")
			select e).OrderBy((ZipEntry e) => e.get_Name(), StringComparer.Ordinal).ToList();
		using MemoryStream memoryStream = new MemoryStream();
		foreach (ZipEntry item in list)
		{
			byte[] buffer = extractContent(item);
			byte[] array;
			using (SHA1 sHA = SHA1.Create())
			{
				array = sHA.ComputeHash(buffer);
			}
			memoryStream.Write(array, 0, array.Length);
		}
		return memoryStream.ToArray();
	}
}
