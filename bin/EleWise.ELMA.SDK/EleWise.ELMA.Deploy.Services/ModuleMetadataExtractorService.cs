using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Packaging.Helper;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Impl;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Services;

[Service]
internal sealed class ModuleMetadataExtractorService : IModuleMetadataExtractorService
{
	private class MetadataExtractorProxy : MarshalByRefObject
	{
		private static object hnKXsV8exmwHWO2OsRRQ;

		public ModuleInfoMetadata ExtractFrom(string filePath)
		{
			//Discarded unreachable code: IL_00ae, IL_0102, IL_013a, IL_0149
			int num = 1;
			int num2 = num;
			ModuleInfoMetadata moduleInfoMetadata = default(ModuleInfoMetadata);
			ModuleInfoMetadata result = default(ModuleInfoMetadata);
			Assembly assembly = default(Assembly);
			while (true)
			{
				switch (num2)
				{
				case 1:
					moduleInfoMetadata = new ModuleInfoMetadata();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return result;
				case 4:
					PbsCRd8eM2tS5DBfEvR1(new SimpleBoundVariableService());
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 1;
					}
					break;
				default:
					assembly = (Assembly)EFTV378eyxaiWxuG0e5U(filePath);
					num2 = 4;
					break;
				case 2:
					try
					{
						BymPVS8eJiXeKKb2i34B(moduleInfoMetadata, assembly);
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								return result;
							case 0:
								return result;
							case 1:
								result = moduleInfoMetadata;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}
					catch (InvalidOperationException)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								return result;
							case 0:
								return result;
							case 1:
								result = null;
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					}
				}
			}
		}

		public MetadataExtractorProxy()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			hsrv6p8e9oB1gRxbukxJ();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object EFTV378eyxaiWxuG0e5U(object P_0)
		{
			return Assembly.LoadFrom((string)P_0);
		}

		internal static void PbsCRd8eM2tS5DBfEvR1(object P_0)
		{
			ContextVars.SetImpl((IContextBoundVariableService)P_0);
		}

		internal static void BymPVS8eJiXeKKb2i34B(object P_0, object P_1)
		{
			((ModuleInfoMetadata)P_0).LoadFromAssembly((Assembly)P_1);
		}

		internal static bool maUclA8e0qXFcScIVdli()
		{
			return hnKXsV8exmwHWO2OsRRQ == null;
		}

		internal static MetadataExtractorProxy Q90Dnb8emsEEUMnQ2G04()
		{
			return (MetadataExtractorProxy)hnKXsV8exmwHWO2OsRRQ;
		}

		internal static void hsrv6p8e9oB1gRxbukxJ()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private static readonly TimeSpan RetryTime;

	private readonly IExportImportFileManager exportImportFileManager;

	internal static ModuleMetadataExtractorService A9AurwE4Ay7EfKD7XUDW;

	public ModuleMetadataExtractorService(IExportImportFileManager exportImportFileManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ItRBSxE400eTBDP5LgPH();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.exportImportFileManager = exportImportFileManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public IEnumerable<ModuleVersion> ExtractModules(IConfigImportSettings importSettings)
	{
		string filePath = exportImportFileManager.CreateZipFileName(importSettings.FileName);
		return ExtractModules(filePath);
	}

	public IEnumerable<ModuleVersion> ExtractModules(string filePath)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		List<ModuleVersion> list = new List<ModuleVersion>();
		ComponentManager current = ComponentManager.Current;
		IEnumerable<string> activationKeys = null;
		Func<DateTime?> getMainUnitExpiration = null;
		if (current != null)
		{
			activationKeys = (from a in current.LicenseManager.GetActivationKeys()
				select a.Value).ToList();
			getMainUnitExpiration = current.ModuleManager.GetMainLicensedUnitExpiration;
		}
		ElmaStoreComponentsBuilder.Read(filePath, activationKeys, getMainUnitExpiration, needPackages: true, "", needIcon: false, out var packages, out var _);
		foreach (string item2 in packages)
		{
			string tempUniqueFolder = ExportImportTempFolderHelper.GetTempUniqueFolder("");
			FSHelper.CreateDirectory(tempUniqueFolder, RetryTime);
			try
			{
				ZipPackage val = new ZipPackage(item2);
				foreach (IPackageFile libFile in PackageExtensions.GetLibFiles((IPackage)(object)val))
				{
					if (!(Path.GetFileNameWithoutExtension(libFile.get_Path()).ToUpperInvariant() == ((LocalPackage)val).get_Id().ToUpperInvariant()) || !(Path.GetExtension(libFile.get_Path()) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867745546)))
					{
						continue;
					}
					string text = Path.Combine(tempUniqueFolder, Guid.NewGuid().ToString());
					using (Stream stream = libFile.GetStream())
					{
						using FileStream destination = File.Create(text);
						stream.CopyTo(destination);
					}
					ModuleInfoMetadata moduleInfoMetadata = ExtractFrom(text);
					if (moduleInfoMetadata != null)
					{
						Guid versionUid = ModuleVersionHeader.DefaultVersionUid(moduleInfoMetadata.Uid, ((LocalPackage)val).get_Version().get_Version());
						ModuleVersion item = new ModuleVersion(moduleInfoMetadata, new ModuleVersionHeader(moduleInfoMetadata.GetSignature(), versionUid, moduleInfoMetadata.Uid, ((LocalPackage)val).get_Version().get_Version(), ModuleStatus.Enabled));
						list.Add(item);
					}
				}
			}
			finally
			{
				FSHelper.DeleteDirectory(tempUniqueFolder, recursive: true, RetryTime);
			}
		}
		return list;
	}

	private ModuleInfoMetadata ExtractFrom(string filePath)
	{
		//Discarded unreachable code: IL_00d1, IL_0109, IL_011c, IL_012b
		int num = 2;
		int num2 = num;
		AppDomain appDomain = default(AppDomain);
		ModuleInfoMetadata moduleInfoMetadata = default(ModuleInfoMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				appDomain = (AppDomain)NpqoJeE4dgqaV9u5c2Hn(zL8ApTE4yNKOpw5r1e0W(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x63841C09), gVBn6aE4mKdWnc9XkF9h()), JrVn86E4JoV66DrWYYIk(zAAkHrE4MbeQfWsHPUKY()), UBFQ2RE49hAHby0jZSkR(AppDomain.CurrentDomain));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return moduleInfoMetadata;
			case 1:
				try
				{
					moduleInfoMetadata = (ModuleInfoMetadata)wMU3d6E45xj0tceMxSCc((MetadataExtractorProxy)i6yH4EE4g47AvXlZZ1ir(appDomain, uAFkjFE4rXX9ZFthA91p(H19FiPE4lIXmQKjF7exe(typeof(MetadataExtractorProxy).TypeHandle).Assembly), typeof(MetadataExtractorProxy).FullName), filePath);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => moduleInfoMetadata, 
						_ => moduleInfoMetadata, 
					};
				}
				finally
				{
					mlpjmoE4jCPdPwJYmhEY(appDomain);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			}
		}
	}

	static ModuleMetadataExtractorService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				RetryTime = C1MmYVE4YJ6Ufm1COm7Y(1.0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				ItRBSxE400eTBDP5LgPH();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void ItRBSxE400eTBDP5LgPH()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool T5EoyAE47FRoUFSFmOKo()
	{
		return A9AurwE4Ay7EfKD7XUDW == null;
	}

	internal static ModuleMetadataExtractorService HKXBy3E4xfxWQB0R0Qhl()
	{
		return A9AurwE4Ay7EfKD7XUDW;
	}

	internal static Guid gVBn6aE4mKdWnc9XkF9h()
	{
		return Guid.NewGuid();
	}

	internal static object zL8ApTE4yNKOpw5r1e0W(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object zAAkHrE4MbeQfWsHPUKY()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object JrVn86E4JoV66DrWYYIk(object P_0)
	{
		return ((AppDomain)P_0).Evidence;
	}

	internal static object UBFQ2RE49hAHby0jZSkR(object P_0)
	{
		return ((AppDomain)P_0).SetupInformation;
	}

	internal static object NpqoJeE4dgqaV9u5c2Hn(object P_0, object P_1, object P_2)
	{
		return AppDomain.CreateDomain((string)P_0, (Evidence)P_1, (AppDomainSetup)P_2);
	}

	internal static Type H19FiPE4lIXmQKjF7exe(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object uAFkjFE4rXX9ZFthA91p(object P_0)
	{
		return ((Assembly)P_0).FullName;
	}

	internal static object i6yH4EE4g47AvXlZZ1ir(object P_0, object P_1, object P_2)
	{
		return ((AppDomain)P_0).CreateInstanceAndUnwrap((string)P_1, (string)P_2);
	}

	internal static object wMU3d6E45xj0tceMxSCc(object P_0, object P_1)
	{
		return ((MetadataExtractorProxy)P_0).ExtractFrom((string)P_1);
	}

	internal static void mlpjmoE4jCPdPwJYmhEY(object P_0)
	{
		AppDomain.Unload((AppDomain)P_0);
	}

	internal static TimeSpan C1MmYVE4YJ6Ufm1COm7Y(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}
}
