using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Runtime.Versioning;
using System.Xml.Serialization;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.Extensions;
using EleWise.ELMA.Packaging.Logging;
using EleWise.ELMA.Packaging.ProjectSystem;
using NuGet;

namespace EleWise.ELMA.Packaging;

public class ElmaPackageBuilder
{
	internal class PropertyProvider : IPropertyProvider
	{
		private readonly PackageBuilder builder;

		private readonly IParsedProject project;

		private readonly string tfm;

		public PropertyProvider(PackageBuilder builder)
		{
			this.builder = builder;
		}

		public PropertyProvider(PackageBuilder builder, IParsedProject project)
		{
			this.builder = builder;
			this.project = project;
		}

		public PropertyProvider(PackageBuilder builder, IParsedProject project, string tfm)
			: this(builder, project)
		{
			this.tfm = tfm;
		}

		dynamic IPropertyProvider.GetPropertyValue(string propertyName)
		{
			return propertyName.ToLower() switch
			{
				"id" => builder.get_Id(), 
				"author" => builder.get_Authors().First(), 
				"version" => ((object)builder.get_Version()).ToString(), 
				"description" => builder.get_Description(), 
				"tfm" => tfm, 
				_ => project?.GetPropertyValue(propertyName), 
			};
		}
	}

	private static FrameworkName TargetFramework = ProjectSystemImpl.TargetFrameworkName;

	private static readonly string shortLibFolderName = VersionUtility.GetShortFrameworkName(TargetFramework);

	private static readonly string nupkgLibRootPath = Path.Combine("lib", shortLibFolderName);

	private readonly ISolutionParser solutionParser;

	public ILogger Logger { get; set; }

	public Version GlobalVersion { get; set; }

	public string OutputDirectory { get; set; }

	public string SystemPackagesDirectory { get; set; }

	public string SourceFilesFileName { get; set; }

	public string BeforeBuildToolFileName { get; set; }

	public string AdditionalTags { get; set; }

	public bool NoProjectDependencies { get; set; }

	public bool NoPackagesConfigDependencies { get; set; }

	public bool AddProjectSrc { get; set; }

	public IEnumerable<string> ProjectNames { get; set; }

	public string ActivationType { get; set; }

	public string LocalizedXmlsPath { get; set; }

	public bool SkipHelpPackages { get; set; }

	public bool UseStandardNugetFormat { get; set; }

	internal ElmaPackageBuilder(ISolutionParser solutionParser)
	{
		GlobalVersion = new Version("1.0.0");
		Logger = EleWise.ELMA.Packaging.Logging.Logger.Log;
		this.solutionParser = solutionParser;
	}

	public void BuildBySolution(string solutionFileName, string configuration, string platform, bool markModulesAsDefault)
	{
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected O, but got Unknown
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_089f: Expected O, but got Unknown
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e7: Expected O, but got Unknown
		//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Expected O, but got Unknown
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Unknown result type (might be due to invalid IL or missing references)
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Expected O, but got Unknown
		//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a78: Expected O, but got Unknown
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b54: Expected O, but got Unknown
		//IL_0c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Expected O, but got Unknown
		//IL_0ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Expected O, but got Unknown
		//IL_0d7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		if (string.IsNullOrEmpty(solutionFileName))
		{
			throw new ArgumentNullException("solutionFileName");
		}
		ElmaStoreComponentActivationType? elmaStoreComponentActivationType = null;
		if (!string.IsNullOrEmpty(ActivationType) && Enum.TryParse<ElmaStoreComponentActivationType>(ActivationType, out var result))
		{
			elmaStoreComponentActivationType = result;
		}
		if (!Path.IsPathRooted(solutionFileName))
		{
			solutionFileName = Path.GetFullPath(solutionFileName);
		}
		string directoryName = Path.GetDirectoryName(solutionFileName);
		string text = (string.IsNullOrEmpty(SystemPackagesDirectory) ? SafeCombinePaths(directoryName, "packages") : SystemPackagesDirectory);
		configuration = (string.IsNullOrEmpty(configuration) ? "Debug" : configuration);
		platform = (string.IsNullOrEmpty(platform) ? "Any CPU" : platform);
		Logger.Info(SR.T("Построение пакетов для решения '{0}')", solutionFileName));
		Logger.Debug(" " + SR.T("Конфигурация: '{0}'", configuration));
		Logger.Debug(" " + SR.T("Платформа: '{0}'", platform));
		Logger.Debug(" " + SR.T("Глобальная версия: '{0}'", GlobalVersion));
		Logger.Debug(" " + SR.T("Папка сохранения пакетов: '{0}'", OutputDirectory));
		Logger.Debug(" " + SR.T("Папка системных пакетов: '{0}'", text));
		Dictionary<string, IParsedProject> parsedProjects = solutionParser.Parse(solutionFileName).Projects.ToDictionary((IParsedProject prj) => prj.ProjectFileName.ToUpper());
		Dictionary<PackageBuilder, string> dictionary = new Dictionary<PackageBuilder, string>();
		foreach (IParsedProject value6 in parsedProjects.Values)
		{
			if (!value6.Configs.TryGetValue(configuration + "|" + platform, out var value))
			{
				Logger.Debug(SR.T("Проект '{0}' не найден", value6.AssemblyName));
				continue;
			}
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(value6.ProjectFileName);
			if ((ProjectNames == null && !value.IncludeInBuild) || (ProjectNames != null && !ProjectNames.Contains(fileNameWithoutExtension)))
			{
				Logger.Debug(SR.T("Проект '{0}' не выбран для сборки", value6.AssemblyName));
				continue;
			}
			Logger.Info(SR.T("Обработка проекта '{0}'", value6.AssemblyName));
			value6.SetGlobalProperty("Configuration", value.ConfigurationName);
			value6.SetGlobalProperty("Platform", value.PlatformName);
			value6.ReevaluateIfNecessary();
			string text2 = value6.GetPropertyValue("OutputPath");
			if (text2 != null && text2.EndsWith("\\"))
			{
				text2 = text2.Substring(0, text2.Length - 1);
			}
			string directoryName2 = Path.GetDirectoryName(value6.ProjectFileName);
			PackageBuilder val = new PackageBuilder();
			val.set_Id(value6.AssemblyName);
			val.set_Version(new SemanticVersion(GlobalVersion));
			val.get_Authors().Add("ELMA");
			val.set_Description(value6.AssemblyName);
			List<ManifestFile> list = null;
			string path = SafeCombinePaths(directoryName2, value6.AssemblyName + ".nuspec");
			if (!File.Exists(path))
			{
				path = SafeCombinePaths(directoryName2, "Properties", value6.AssemblyName + ".nuspec");
			}
			if (File.Exists(path))
			{
				string path2 = Path.ChangeExtension(path, Constants.XManifestExtension);
				using FileStream fileStream = File.OpenRead(path);
				using FileStream fileStream2 = (File.Exists(path2) ? File.OpenRead(path2) : null);
				PropertyProvider propertyProvider = new PropertyProvider(val, value6, shortLibFolderName);
				Manifest val2 = Manifest.ReadFrom((Stream)fileStream, (IPropertyProvider)(object)propertyProvider, false);
				if (!UseStandardNugetFormat)
				{
					list = val2.get_Files();
				}
				val2.set_Files(new List<ManifestFile>());
				using (MemoryStream memoryStream = new MemoryStream())
				{
					val2.Save((Stream)memoryStream);
					memoryStream.Seek(0L, SeekOrigin.Begin);
					val = new PackageBuilder((Stream)memoryStream, (Stream)fileStream2, (string)null, (IPropertyProvider)(object)propertyProvider);
				}
				if (list != null)
				{
					val.PopulateFiles(directoryName2, (IEnumerable<ManifestFile>)list);
				}
			}
			ElmaPackageMetadata elmaPackageMetadata = new ElmaPackageMetadata((val.get_Tags() != null) ? string.Join(" ", val.get_Tags()) : "");
			if (elmaStoreComponentActivationType.HasValue && val.get_Tags() != null)
			{
				string item = $"[ActivationType:{ElmaStoreComponentActivationType.Paid}]";
				if (val.get_Tags().Contains(item))
				{
					elmaPackageMetadata.ActivationType = elmaStoreComponentActivationType.Value;
					val.get_Tags().Remove(item);
					val.get_Tags().Add($"[ActivationType:{elmaStoreComponentActivationType.Value}]");
				}
				if (elmaStoreComponentActivationType.Value == ElmaStoreComponentActivationType.CE)
				{
					foreach (string item6 in (from t in val.get_Tags()
						where t.StartsWith("[Edition:")
						select t).ToList())
					{
						val.get_Tags().Remove(item6);
					}
					val.get_Tags().Add("[Edition:CE]");
					elmaPackageMetadata.Editions.Clear();
					elmaPackageMetadata.Editions.Add(ElmaEdition.CE);
				}
			}
			if (markModulesAsDefault && !elmaPackageMetadata.Default && (elmaPackageMetadata.Type == ElmaPackageType.Module || elmaPackageMetadata.Type == ElmaPackageType.Core || elmaPackageMetadata.Type == ElmaPackageType.Platform || elmaPackageMetadata.Type == ElmaPackageType.ProcessPackage || elmaPackageMetadata.Type == ElmaPackageType.MobileApplication || elmaPackageMetadata.Type == ElmaPackageType.Application))
			{
				val.get_Tags().Add("[Default]");
			}
			if (!string.IsNullOrEmpty(AdditionalTags))
			{
				string[] array = AdditionalTags.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				foreach (string item2 in array)
				{
					if (!val.get_Tags().Contains(item2))
					{
						val.get_Tags().Add(item2);
					}
				}
			}
			List<PackageDependency> list2 = new List<PackageDependency>();
			if (!NoPackagesConfigDependencies)
			{
				AddPackageReferences(value6, text, list2);
			}
			if (!NoProjectDependencies)
			{
				AddProjectReferences(value6, (string prjName) => (!parsedProjects.TryGetValue(prjName.ToUpper(), out var value5)) ? null : value5, list2);
			}
			if (list2.Count > 0)
			{
				PackageDependencySet item3 = new PackageDependencySet((FrameworkName)null, (IEnumerable<PackageDependency>)list2);
				val.get_DependencySets().Add(item3);
			}
			string propertyValue = value6.GetPropertyValue("ProjectTypeGuids");
			bool flag = false;
			if (propertyValue != null)
			{
				Guid item4 = new Guid("349c5851-65df-11da-9384-00065b846f21");
				if ((from s in propertyValue.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
					select s.Trim() into s
					where !string.IsNullOrEmpty(s)
					select new Guid(s)).ToList().Contains(item4))
				{
					flag = true;
				}
			}
			string fileName = Path.GetFileName(directoryName2);
			if (list == null || !list.Any())
			{
				if (UseStandardNugetFormat)
				{
					PackAssemblyFiles(SafeCombinePaths(directoryName2, text2), value6.AssemblyName, val);
				}
				else if (!flag)
				{
					PackAssemblyFiles(SafeCombinePaths(directoryName2, text2), value6.AssemblyName, val);
					if (AddProjectSrc)
					{
						List<ManifestFile> list3 = new List<ManifestFile>();
						ManifestFile val3 = new ManifestFile();
						val3.set_Source("**\\*.*");
						val3.set_Exclude($"bin\\**\\*.*;obj\\**\\*.*;{value6.AssemblyName}.csproj.user;Content\\Help\\**\\*.*;**\\*.snk");
						val3.set_Target($"ELMA\\Module\\{fileName}");
						list3.Add(val3);
						ManifestFile val4 = new ManifestFile();
						val4.set_Source($"{text2}\\{value6.AssemblyName}.*");
						val4.set_Exclude($"{text2}\\*.pdb");
						val4.set_Target($"ELMA\\Module\\{fileName}\\bin");
						list3.Add(val4);
						list = list3;
						val.PopulateFiles(directoryName2, (IEnumerable<ManifestFile>)list);
					}
				}
				else
				{
					List<ManifestFile> list4 = new List<ManifestFile>();
					ManifestFile val5 = new ManifestFile();
					val5.set_Source("**\\*.*");
					val5.set_Exclude(ProcessFilesAttribute($"bin\\**\\*.*;obj\\**\\*.*;{value6.AssemblyName}.csproj.user;Content\\Help\\**\\*.*;**\\*.snk;{{ActivationType==CE?**\\*.cs}}"));
					val5.set_Target($"ELMA\\WebModule\\{fileName}");
					list4.Add(val5);
					ManifestFile val6 = new ManifestFile();
					val6.set_Source($"{text2}\\{value6.AssemblyName}.*");
					val6.set_Exclude($"{text2}\\*.pdb");
					val6.set_Target($"ELMA\\WebModule\\{fileName}\\bin");
					list4.Add(val6);
					list = list4;
					val.PopulateFiles(directoryName2, (IEnumerable<ManifestFile>)list);
				}
			}
			else
			{
				foreach (ManifestFile item7 in list)
				{
					item7.set_Source(ProcessFilesAttribute(item7.get_Source()));
					item7.set_Exclude(ProcessFilesAttribute(item7.get_Exclude()));
				}
			}
			if (!string.IsNullOrEmpty(LocalizedXmlsPath) && !string.IsNullOrWhiteSpace(LocalizedXmlsPath))
			{
				string[] array = Directory.GetDirectories(LocalizedXmlsPath);
				foreach (string text3 in array)
				{
					string text4 = text3.Split('\\').Last();
					string[] files = Directory.GetFiles(text3, value6.AssemblyName + ".*");
					foreach (string text5 in files)
					{
						Collection<IPackageFile> files2 = val.get_Files();
						PhysicalPackageFile val7 = new PhysicalPackageFile();
						val7.set_SourcePath(text5);
						val7.set_TargetPath(SafeCombinePaths(nupkgLibRootPath + "\\" + text4, Path.GetFileName(text5)));
						files2.Add((IPackageFile)(object)val7);
					}
				}
			}
			if (File.Exists(path))
			{
				bool flag2 = false;
				bool flag3 = false;
				string[] array = new string[1] { ".png" };
				foreach (string text6 in array)
				{
					string text7 = Path.ChangeExtension(path, text6);
					if (File.Exists(text7))
					{
						string source = text7.Substring(directoryName2.Length + 1);
						PackageBuilder obj = val;
						ManifestFile[] array2 = new ManifestFile[1];
						ManifestFile val8 = new ManifestFile();
						val8.set_Source(source);
						val8.set_Target("");
						array2[0] = val8;
						obj.PopulateFiles(directoryName2, (IEnumerable<ManifestFile>)(object)array2);
						flag2 = true;
					}
					string text8 = Path.Combine(Path.GetDirectoryName(path), string.Format("{0}.{1}{2}", Path.GetFileNameWithoutExtension(path), "Manifest", text6));
					if (File.Exists(text8))
					{
						string destFileName = SafeCombinePaths(OutputDirectory, string.Concat(val.get_Id(), ".", val.get_Version(), text6));
						File.Copy(text8, destFileName, overwrite: true);
						flag3 = true;
					}
					if (flag2 && flag3)
					{
						break;
					}
				}
			}
			string value2 = SafeCombinePaths(OutputDirectory, string.Concat(val.get_Id(), ".", val.get_Version(), ".nupkg"));
			dictionary.Add(val, value2);
			string path3 = Path.ChangeExtension(path, ".Help.nuspec");
			string path4 = Path.ChangeExtension(path3, Constants.XManifestExtension);
			if (SkipHelpPackages || !File.Exists(path3))
			{
				continue;
			}
			PackageBuilder val9 = new PackageBuilder();
			val9.set_Id(value6.AssemblyName + ".Help");
			val9.set_Version(new SemanticVersion(GlobalVersion));
			val9.get_Authors().Add("EleWise");
			val9.set_Description(val9.get_Id());
			Manifest val10;
			XManifest val11;
			using (FileStream fileStream3 = File.OpenRead(path3))
			{
				using FileStream fileStream4 = (File.Exists(path4) ? File.OpenRead(path4) : null);
				val10 = Manifest.ReadFrom((Stream)fileStream3, (IPropertyProvider)(object)new PropertyProvider(val9), false);
				val11 = ((fileStream4 != null) ? XManifest.ReadFrom((Stream)fileStream3, (IPropertyProvider)(object)new PropertyProvider(val9)) : null);
			}
			val9.Populate(val10.get_Metadata());
			val9.Populate((val11 != null) ? val11.get_Metadata() : null);
			List<ManifestFile> list5 = val10.get_Files();
			if ((val10.get_Files() == null || !val10.get_Files().Any()) && flag)
			{
				List<ManifestFile> list6 = new List<ManifestFile>();
				ManifestFile val12 = new ManifestFile();
				val12.set_Source("Content\\Help\\**\\*.*");
				val12.set_Target($"ELMA\\WebModule\\{value6.AssemblyName}\\Content\\Help");
				list6.Add(val12);
				list5 = list6;
			}
			if (!string.IsNullOrEmpty(AdditionalTags))
			{
				string[] array = AdditionalTags.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				foreach (string item5 in array)
				{
					if (!val9.get_Tags().Contains(item5))
					{
						val9.get_Tags().Add(item5);
					}
				}
			}
			if (list5 != null && list5.Any())
			{
				val9.PopulateFiles(directoryName2, (IEnumerable<ManifestFile>)list5);
			}
			string value3 = SafeCombinePaths(OutputDirectory, string.Concat(val9.get_Id(), ".", val9.get_Version(), ".nupkg"));
			dictionary.Add(val9, value3);
		}
		if (!string.IsNullOrEmpty(SourceFilesFileName))
		{
			Logger.Info(SR.T("Сохранение информации о файлах, включаемых в пакеты..."));
			List<string> list7 = new List<string>();
			foreach (KeyValuePair<PackageBuilder, string> item8 in dictionary)
			{
				foreach (IPackageFile file in item8.Key.get_Files())
				{
					PhysicalPackageFile val13 = (PhysicalPackageFile)(object)((file is PhysicalPackageFile) ? file : null);
					if (val13 != null && File.Exists(val13.get_SourcePath()))
					{
						list7.Add(val13.get_SourcePath());
					}
				}
			}
			string directoryName3 = Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
			File.WriteAllLines(Path.IsPathRooted(SourceFilesFileName) ? SourceFilesFileName : Path.Combine(directoryName3, SourceFilesFileName), list7.ToArray());
			Logger.Debug(SR.T("Информация о файлах, включаемых в пакеты, сохранена"));
		}
		if (!string.IsNullOrEmpty(BeforeBuildToolFileName))
		{
			int num = BeforeBuildToolFileName.IndexOf('|');
			string text9 = BeforeBuildToolFileName;
			string text10 = "";
			if (num > 0)
			{
				text9 = BeforeBuildToolFileName.Substring(0, num);
				text10 = BeforeBuildToolFileName.Substring(num + 1);
			}
			string directoryName4 = Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
			text9 = (Path.IsPathRooted(text9) ? text9 : Path.Combine(directoryName4, text9));
			if (!File.Exists(text9))
			{
				throw new FileNotFoundException(SR.T("Файл не найден: {0}", text9), text9);
			}
			Logger.Info(SR.T("Запуск внешней программы '{0}' ({1})...", text9, text10));
			Process process = new Process();
			process.StartInfo.FileName = text9;
			process.StartInfo.Arguments = text10;
			process.StartInfo.UseShellExecute = false;
			process.Start();
			process.WaitForExit();
			if (process.ExitCode != 0)
			{
				throw new InvalidOperationException(SR.T("Внешняя программа '{0}' ({1}) возвратила код ошибки {2}", text9, text10, process.ExitCode));
			}
			Logger.Debug(SR.T("Внешняя программа выполнена"));
		}
		foreach (KeyValuePair<PackageBuilder, string> item9 in dictionary)
		{
			PackageBuilder key = item9.Key;
			string value4 = item9.Value;
			Logger.Info(SR.T("Построение пакета для проекта '{0}'", key.get_Id()));
			using (FileStream fileStream5 = File.Create(value4))
			{
				key.Save((Stream)fileStream5);
			}
			FilesAttributes filesAttributes = new FilesAttributes();
			foreach (IPackageFile file2 in key.get_Files())
			{
				PhysicalPackageFile val14 = (PhysicalPackageFile)(object)((file2 is PhysicalPackageFile) ? file2 : null);
				if (val14 != null && File.Exists(val14.get_SourcePath()))
				{
					FileInfo fileInfo = new FileInfo(val14.get_SourcePath());
					filesAttributes.Files.Add(new FileAttributes
					{
						Path = file2.get_Path(),
						CreationTime = fileInfo.CreationTime,
						LastWriteTime = fileInfo.LastWriteTime
					});
				}
			}
			using Package package = Package.Open(value4);
			Uri partUri = new Uri("/Files_Attributes.xml", UriKind.Relative);
			using Stream stream = package.CreatePart(partUri, "application/octet").GetStream();
			new XmlSerializer(typeof(FilesAttributes)).Serialize(stream, filesAttributes);
		}
		Logger.Info(SR.T("Пакеты для решения построены"));
	}

	private void PackAssemblyFiles(string targetDir, string assemblyName, PackageBuilder builder)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		string[] files = Directory.GetFiles(targetDir, assemblyName + ".*");
		foreach (string text in files)
		{
			if (Path.GetFileName(text).Equals(assemblyName + ".exe.config", StringComparison.CurrentCultureIgnoreCase) || (Path.GetFileNameWithoutExtension(text).Equals(assemblyName, StringComparison.CurrentCultureIgnoreCase) && !Path.GetExtension(text).Equals(".pdb", StringComparison.CurrentCultureIgnoreCase)))
			{
				Collection<IPackageFile> files2 = builder.get_Files();
				PhysicalPackageFile val = new PhysicalPackageFile();
				val.set_SourcePath(text);
				val.set_TargetPath(SafeCombinePaths(nupkgLibRootPath, Path.GetFileName(text)));
				files2.Add((IPackageFile)(object)val);
			}
		}
	}

	private void AddPackageReferences(IParsedProject prj, string systemPackagesPath, List<PackageDependency> dependencies)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		string directoryName = Path.GetDirectoryName(prj.ProjectFileName);
		string text = SafeCombinePaths(directoryName, Constants.PackageReferenceFile);
		if (!File.Exists(text))
		{
			return;
		}
		foreach (PackageReference packageReference in new PackageReferenceFile(text).GetPackageReferences())
		{
			Version version = new Version(packageReference.get_Version().get_Version().Major, packageReference.get_Version().get_Version().Minor, packageReference.get_Version().get_Version().Build);
			Version version2 = new Version(packageReference.get_Version().get_Version().Major, packageReference.get_Version().get_Version().Minor, packageReference.get_Version().get_Version().Build + 1);
			string id = packageReference.get_Id();
			VersionSpec val = new VersionSpec();
			val.set_MinVersion(new SemanticVersion(version));
			val.set_IsMinInclusive(true);
			val.set_MaxVersion(new SemanticVersion(version2));
			val.set_IsMaxInclusive(false);
			dependencies.Add(new PackageDependency(id, (IVersionSpec)val));
			string text2 = packageReference.get_Id() + "." + packageReference.get_Version();
			string text3 = SafeCombinePaths(OutputDirectory, text2 + ".nupkg");
			if (!File.Exists(text3))
			{
				string text4 = SafeCombinePaths(systemPackagesPath, text2, text2 + ".nupkg");
				if (!File.Exists(text4))
				{
					Logger.Warn(" " + SR.T("Не найден системный пакет '{0}'", text4));
					continue;
				}
				File.Copy(text4, text3);
			}
			string text5 = packageReference.get_Id() + ".Help." + packageReference.get_Version();
			string text6 = SafeCombinePaths(OutputDirectory, text5 + ".nupkg");
			if (!File.Exists(text6))
			{
				string text7 = SafeCombinePaths(systemPackagesPath, text5, text5 + ".nupkg");
				if (File.Exists(text7))
				{
					File.Copy(text7, text6);
				}
			}
		}
	}

	private void AddProjectReferences(IParsedProject prj, Func<string, IParsedProject> resolveProjectFunc, List<PackageDependency> dependencies)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		string directoryName = Path.GetDirectoryName(prj.ProjectFileName);
		foreach (string item in from i in prj.GetItems(ParsedProjectItemType.ProjectReference)
			select i.EvaluatedInclude)
		{
			string path = SafeCombinePaths(directoryName, item);
			DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(path));
			path = SafeCombinePaths(directoryInfo.FullName, Path.GetFileName(path));
			IParsedProject parsedProject = resolveProjectFunc(path);
			if (parsedProject != null)
			{
				Version version = new Version(GlobalVersion.Major, GlobalVersion.Minor);
				Version version2 = new Version(GlobalVersion.Major, GlobalVersion.Minor + 1);
				string assemblyName = parsedProject.AssemblyName;
				VersionSpec val = new VersionSpec();
				val.set_MinVersion(new SemanticVersion(version));
				val.set_IsMinInclusive(true);
				val.set_MaxVersion(new SemanticVersion(version2));
				val.set_IsMaxInclusive(false);
				dependencies.Add(new PackageDependency(assemblyName, (IVersionSpec)val));
			}
		}
	}

	private string SafeCombinePaths(params string[] paths)
	{
		if (paths == null || paths.Length == 0)
		{
			throw new ArgumentException("paths is null or empty");
		}
		string text = paths[0];
		for (int i = 1; i < paths.Length; i++)
		{
			string text2 = paths[i];
			while (text.EndsWith("\\"))
			{
				text = text.Substring(0, text.Length - 1);
			}
			if (text2.StartsWith("\\"))
			{
				text2 = text2.Substring(1);
			}
			while (text2.StartsWith("..\\"))
			{
				int num = text.LastIndexOf('\\');
				if (num <= 0)
				{
					throw new InvalidOperationException("Cannot combine paths: " + string.Join(",", paths));
				}
				text = text.Substring(0, num);
				text2 = ((text2.Length > 3) ? text2.Substring(3) : "");
			}
			if (!string.IsNullOrEmpty(text2))
			{
				text = text + "\\" + text2;
			}
		}
		return text;
	}

	private string ProcessFilesAttribute(string value)
	{
		if (string.IsNullOrEmpty(value) || !value.Contains("{"))
		{
			return value;
		}
		string[] array = value.Split(';');
		List<string> list = new List<string>();
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (text.StartsWith("{") && text.EndsWith("}") && text.Contains("?"))
			{
				string text2 = text.Substring(1, text.Length - 2);
				int num = text2.IndexOf('?');
				string text3 = text2.Substring(0, num);
				string item = text2.Substring(num + 1);
				int num2 = text3.IndexOf("!=");
				bool flag;
				if (num2 > 0)
				{
					flag = false;
				}
				else
				{
					flag = true;
					num2 = text3.IndexOf("==");
					if (num2 <= 0)
					{
						list.Add(text);
						continue;
					}
				}
				string text4 = text3.Substring(0, num2);
				string value2 = text3.Substring(num2 + 2);
				string text5 = null;
				if (text4 == "ActivationType")
				{
					text5 = ActivationType;
				}
				if (text5 == null)
				{
					text5 = "";
				}
				bool flag2 = text5.Equals(value2);
				if ((flag && flag2) || (!flag && !flag2))
				{
					list.Add(item);
				}
			}
			else
			{
				list.Add(text);
			}
		}
		return string.Join(";", list);
	}
}
