using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Managers;

internal class DeployManager : DTOManager, IDeployManager, IConfigurationService
{
	private readonly ConcurrentDictionary<Guid, int> logMessages;

	private readonly ConcurrentDictionary<Guid, int> systemMessages;

	private readonly IExportImportService exportImportService;

	internal static DeployManager qvEG6rEtZC94e41l49O8;

	public DeployManager(IExportImportService exportImportService)
	{
		//Discarded unreachable code: IL_004a, IL_004f
		nlsBOUEtVgHGWICfgK8J();
		logMessages = new ConcurrentDictionary<Guid, int>();
		systemMessages = new ConcurrentDictionary<Guid, int>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.exportImportService = exportImportService;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
			{
				num = 1;
			}
		}
	}

	public virtual Guid ExportConfiguration(ConfigExportSettings settings)
	{
		int num = 3;
		int num2 = num;
		Guid result = default(Guid);
		TaskAwaiter<Guid> awaiter = default(TaskAwaiter<Guid>);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 2:
				result = awaiter.GetResult();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				awaiter = exportImportService.Export(settings).GetAwaiter();
				num2 = 2;
				break;
			case 1:
				logMessages[result] = 0;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual Guid TestConfiguration(IConfigImportSettings settings, string activateKey = null)
	{
		int num = 2;
		Guid result = default(Guid);
		TaskAwaiter<Guid> awaiter = default(TaskAwaiter<Guid>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					result = awaiter.GetResult();
					num2 = 3;
					continue;
				case 2:
					awaiter = exportImportService.Test(settings, activateKey).GetAwaiter();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					logMessages[result] = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return result;
				}
				break;
			}
			systemMessages[result] = 0;
			num = 4;
		}
	}

	public virtual bool AddActivationKey(string activateKey, List<ElmaStoreComponentManifest> componentsToInstall, out List<ElmaStoreComponentManifest> notActivatedComponents)
	{
		notActivatedComponents = new List<ElmaStoreComponentManifest>();
		if (!string.IsNullOrEmpty(activateKey))
		{
			ComponentManager.Current.LicenseManager.AddActivationKey(activateKey, out var newActivatedComponents);
			List<IStoreComponentInfo> source = newActivatedComponents.ToList();
			foreach (ElmaStoreComponentManifest item in componentsToInstall.Where((ElmaStoreComponentManifest c) => c.ProductType != ManifestComponentType.Platform).ToList())
			{
				_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
				CS_0024_003C_003E8__locals0.manifest = item;
				if (source.All((IStoreComponentInfo nc) => (string)_003C_003Ec__DisplayClass6_0.zwQ3qJ8ehalR445yVjG2(nc) != (string)_003C_003Ec__DisplayClass6_0.rOn6ee8eG866FMJVHIc0(CS_0024_003C_003E8__locals0.manifest)))
				{
					notActivatedComponents.Add(item);
				}
			}
		}
		return notActivatedComponents.Count == 0;
	}

	public virtual Guid ImportConfiguration(IConfigImportSettings settings)
	{
		int num = 2;
		int num2 = num;
		TaskAwaiter<Guid> awaiter = default(TaskAwaiter<Guid>);
		Guid result = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 2:
				awaiter = exportImportService.Import(settings).GetAwaiter();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				systemMessages[result] = 0;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return result;
			case 1:
				result = awaiter.GetResult();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				logMessages[result] = 0;
				num2 = 3;
				break;
			}
		}
	}

	public virtual void ExecutePackagesOperations(PackageInstallInfo installInfo)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
			{
				PackageService serviceNotNull = Locator.GetServiceNotNull<PackageService>();
				List<PackageOperationInfo> operations = installInfo.Operations.Select(delegate(PackageInstallOperationInfo o)
				{
					//IL_003e: Unknown result type (might be due to invalid IL or missing references)
					//IL_0048: Expected O, but got Unknown
					PackageOperationInfo packageOperationInfo = new PackageOperationInfo();
					_003C_003Ec.YlwJrm8e8Tj5oQJWjwyT(packageOperationInfo, _003C_003Ec.JcctWk8evfMYSUygix6k(o));
					packageOperationInfo.Package = ((_003C_003Ec.S07Yb48eZr6ME0pB7Jv3(o) != null) ? new PackageInfo((string)_003C_003Ec.o6veDF8euOsSo5SucBM6(o), new SemanticVersion((string)_003C_003Ec.S07Yb48eZr6ME0pB7Jv3(o))) : new PackageInfo((string)_003C_003Ec.o6veDF8euOsSo5SucBM6(o)));
					return packageOperationInfo;
				}).ToList();
				serviceNotNull.ExecuteOperations(operations, new PackageOperationOptions
				{
					UpdatingUid = EINUHZEtSHLkEnK48rhe(installInfo),
					StartAfterUpdate = true
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public virtual PackageOperationStatus GetUpdatePackagesOperationsStatus(Guid uid)
	{
		return (PackageOperationStatus)glvfHuEtiwhm9EKSPTKv(Locator.GetServiceNotNull<PackageService>(), uid);
	}

	public virtual List<DeploySystemMessage> GetImportSystemMessages(Guid importUid)
	{
		return GetLog(importUid, systemMessages, exportImportService.GetImportSystemMessages);
	}

	public virtual List<DeploySystemMessage> GetTestSystemMessages(Guid testUid)
	{
		return GetLog(testUid, systemMessages, exportImportService.GetTestSystemMessages);
	}

	public virtual List<TestImportMessages> GetTestLog(Guid testUid)
	{
		return GetLog(testUid, logMessages, exportImportService.GetTestLog);
	}

	public virtual List<DeployLogMessage> GetImportLog(Guid importUid)
	{
		return GetLog(importUid, logMessages, exportImportService.GetImportLog);
	}

	public virtual List<DeployLogMessage> GetExportLog(Guid exportUid)
	{
		return GetLog(exportUid, logMessages, exportImportService.GetExportLog);
	}

	private List<T> GetLog<T>(Guid sessionId, ConcurrentDictionary<Guid, int> messageCountDictionary, Func<Guid, int, int, Task<IEnumerable<T>>> getLogsFunc)
	{
		if (!messageCountDictionary.TryGetValue(sessionId, out var value))
		{
			return null;
		}
		List<T> list = getLogsFunc(sessionId, value, 0).GetAwaiter().GetResult().ToList();
		messageCountDictionary[sessionId] += list.Count;
		return list;
	}

	public virtual List<PackageDescription> FindAllPackages()
	{
		return Locator.GetServiceNotNull<PackageService>().FindAll().ToList();
	}

	public virtual List<PackageDescription> FindPackageDependencies(PackageDescription description)
	{
		List<PackageDescription> list = new List<PackageDescription>();
		PackageService serviceNotNull = Locator.GetServiceNotNull<PackageService>();
		IPackage package = serviceNotNull.GetPackage(description.Id, ((object)(description.InstalledVersion ?? description.LastVersion)).ToString());
		PackageFilter filter = new PackageFilter
		{
			Level = PackageLevel.All,
			Status = PackageStatus.Any
		};
		List<PackageDescription> source = serviceNotNull.Find(filter).ToList();
		if (package != null)
		{
			foreach (PackageDependencySet dependencySet in ((IPackageMetadata)package).get_DependencySets())
			{
				using IEnumerator<PackageDependency> enumerator2 = dependencySet.get_Dependencies().GetEnumerator();
				while (enumerator2.MoveNext())
				{
					_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_0();
					CS_0024_003C_003E8__locals0.dependency = enumerator2.Current;
					PackageDescription packageDescription = source.FirstOrDefault((PackageDescription p) => _003C_003Ec__DisplayClass17_0.XroWNc8eKEKVif9RnpIR(_003C_003Ec__DisplayClass17_0.WJEuEM8eREHo3Pk3wWdh(p), _003C_003Ec__DisplayClass17_0.VZpxVr8eqrMGDkvahrLA(CS_0024_003C_003E8__locals0.dependency)));
					if (packageDescription != null)
					{
						PackageDescription packageDescription2 = ClassSerializationHelper.CloneObject(packageDescription);
						packageDescription2.DependencyVersion = ((object)CS_0024_003C_003E8__locals0.dependency.get_VersionSpec()).ToString();
						list.Add(packageDescription2);
					}
				}
			}
			return list;
		}
		return list;
	}

	public virtual List<PackageDescription> FindPackages(PackageFilter filter)
	{
		return Locator.GetServiceNotNull<PackageService>().Find(filter).ToList();
	}

	public virtual ImportLicenseInfo GetServerLicenseInfo()
	{
		ImportLicenseInfo importLicenseInfo = new ImportLicenseInfo();
		KyiHDcEtRFhXWtmNWoQR(importLicenseInfo);
		return importLicenseInfo;
	}

	public virtual byte[] GetComponentFileContent(string componentId, string version, string relativeFileName)
	{
		//Discarded unreachable code: IL_026e, IL_027d
		int num = 12;
		int num2 = num;
		string text = default(string);
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = default(_003C_003Ec__DisplayClass20_0);
		while (true)
		{
			switch (num2)
			{
			case 8:
				throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561370600)));
			case 9:
				throw new FileNotFoundException((string)DnGCrMEtXH1NjAtlDq2w(QkU5wREtqRhCg3cFfHR1(-210725949 ^ -210654381)), text);
			case 1:
				throw new ArgumentException(SR.T((string)QkU5wREtqRhCg3cFfHR1(0x4EDCBA32 ^ 0x4ED83D7C)));
			case 7:
				if (!relativeFileName.Contains((string)QkU5wREtqRhCg3cFfHR1(-210725949 ^ -210456179)))
				{
					text = (string)BeA82NEteic1dZ9cBIwP(w1m3yWEtPe2PKXkXwhWH(BeA82NEteic1dZ9cBIwP(VBb6bqEt2ALjeEXGewji(hJMbnfEtOfr7cl6Zj7YS(B1hu90EtnAgX14sEyfVH(h51oOfEtkXIdWcw5aRPY(Locator.GetServiceNotNull<IRuntimeApplication>())))), QkU5wREtqRhCg3cFfHR1(-1317790512 ^ -1318020236)), _003C_003Ec__DisplayClass20_.componentId, _003C_003Ec__DisplayClass20_.version), relativeFileName);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 10;
					}
				}
				else
				{
					num2 = 8;
				}
				break;
			case 11:
				_003C_003Ec__DisplayClass20_.componentId = componentId;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				Contract.ArgumentNotNullOrEmpty(_003C_003Ec__DisplayClass20_.version, (string)QkU5wREtqRhCg3cFfHR1(0x7C1EE318 ^ 0x7C1E6F6C));
				num2 = 2;
				break;
			case 5:
				if (Path.GetInvalidFileNameChars().Any(_003C_003Ec__DisplayClass20_._003CGetComponentFileContent_003Eb__0))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (!((IEnumerable<char>)uDAo4SEtTILjuxaiuZmi()).Any(_003C_003Ec__DisplayClass20_._003CGetComponentFileContent_003Eb__1))
				{
					num2 = 7;
					break;
				}
				goto case 1;
			case 12:
				_003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
				num2 = 11;
				break;
			case 4:
				_003C_003Ec__DisplayClass20_.version = version;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				throw new ArgumentException((string)DnGCrMEtXH1NjAtlDq2w(QkU5wREtqRhCg3cFfHR1(-477139494 ^ -477369646)));
			case 2:
				MFxKZLEtKFcJXe6CSJfj(relativeFileName, QkU5wREtqRhCg3cFfHR1(0x4DC2B14D ^ 0x4DC637A9));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 5;
				}
				break;
			case 10:
				if (File.Exists(text))
				{
					return File.ReadAllBytes(text);
				}
				num2 = 9;
				break;
			default:
				MFxKZLEtKFcJXe6CSJfj(_003C_003Ec__DisplayClass20_.componentId, QkU5wREtqRhCg3cFfHR1(-1108654032 ^ -1108357382));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	public virtual bool IsImportAlreadyRun()
	{
		return GetCurrentImportId() != Guid.Empty;
	}

	private Guid GetCurrentImportId()
	{
		int num = 1;
		int num2 = num;
		TaskAwaiter<Guid> awaiter = default(TaskAwaiter<Guid>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				awaiter = exportImportService.GetCurrentImportId().GetAwaiter();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return awaiter.GetResult();
			}
		}
	}

	public virtual IImportSettings GetImportSettings(Guid testUid)
	{
		int num = 1;
		int num2 = num;
		TaskAwaiter<IEnumerable<IImportSettings>> awaiter = default(TaskAwaiter<IEnumerable<IImportSettings>>);
		while (true)
		{
			switch (num2)
			{
			default:
				return awaiter.GetResult().FirstOrDefault();
			case 1:
				awaiter = exportImportService.GetImportSettings(testUid).GetAwaiter();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void nlsBOUEtVgHGWICfgK8J()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool evSWRUEtuRnCaV0Xjbib()
	{
		return qvEG6rEtZC94e41l49O8 == null;
	}

	internal static DeployManager EK0HE1EtI2qXp4VcP6kI()
	{
		return qvEG6rEtZC94e41l49O8;
	}

	internal static Guid EINUHZEtSHLkEnK48rhe(object P_0)
	{
		return ((PackageInstallInfo)P_0).UpdatingUid;
	}

	internal static object glvfHuEtiwhm9EKSPTKv(object P_0, Guid updatingUid)
	{
		return ((PackageService)P_0).GetOperationStatus(updatingUid);
	}

	internal static void KyiHDcEtRFhXWtmNWoQR(object P_0)
	{
		ConfigurationImportExecutor.InitImportLicenseInfo((ImportLicenseInfo)P_0);
	}

	internal static object QkU5wREtqRhCg3cFfHR1(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void MFxKZLEtKFcJXe6CSJfj(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static object DnGCrMEtXH1NjAtlDq2w(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object uDAo4SEtTILjuxaiuZmi()
	{
		return Path.GetInvalidFileNameChars();
	}

	internal static object h51oOfEtkXIdWcw5aRPY(object P_0)
	{
		return ((IRuntimeApplication)P_0).Configuration;
	}

	internal static object B1hu90EtnAgX14sEyfVH(object P_0)
	{
		return ((RuntimeConfiguration)P_0).Config;
	}

	internal static object hJMbnfEtOfr7cl6Zj7YS(object P_0)
	{
		return ((System.Configuration.Configuration)P_0).FilePath;
	}

	internal static object VBb6bqEt2ALjeEXGewji(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object BeA82NEteic1dZ9cBIwP(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object w1m3yWEtPe2PKXkXwhWH(object P_0, object P_1, object P_2)
	{
		return Path.Combine((string)P_0, (string)P_1, (string)P_2);
	}
}
