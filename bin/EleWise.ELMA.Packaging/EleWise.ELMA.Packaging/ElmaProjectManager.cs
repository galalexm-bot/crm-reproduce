using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Xml.Serialization;
using EleWise.ELMA.Packaging.Components.Web;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Packaging.Logging;
using EleWise.ELMA.Packaging.ProjectSystem;
using NuGet;

namespace EleWise.ELMA.Packaging;

internal class ElmaProjectManager : ProjectManager
{
	private class InstallExecutor : IPreparedOperation
	{
		private ElmaProjectManager _owner;

		private IEnumerable<PackageOperation> _operations;

		public InstallExecutor(ElmaProjectManager owner, IEnumerable<PackageOperation> operations)
		{
			_owner = owner;
			_operations = operations;
		}

		public void Execute()
		{
			try
			{
				_owner.DoExecute(_operations);
			}
			finally
			{
				if (((ProjectManager)_owner).get_LocalRepository() != null && Directory.Exists(((ProjectManager)_owner).get_LocalRepository().get_Source()))
				{
					PackageInstaller.RemoveLocalRepositorySubDirs(((ProjectManager)_owner).get_LocalRepository().get_Source());
				}
			}
		}
	}

	private IPackageReferenceRepository _packageReferenceRepository;

	private SharedPackageRepository _sharedPackageRepository;

	private XmlSerializer _fileAttributesSerializer;

	private PackagingSettings _settings;

	public IElmaComponent ElmaComponent { get; set; }

	public ElmaStoreComponentRepository LocalStoreComponentsRepository { get; set; }

	public ElmaProjectManager(IPackageRepository sourceRepository, IPackagePathResolver pathResolver, IProjectSystem project, IPackageRepository localRepository, PackagingSettings settings, SharedPackageRepository sharedPackageRepository)
		: base(sourceRepository, pathResolver, project, localRepository)
	{
		_fileAttributesSerializer = new XmlSerializer(typeof(FilesAttributes));
		ref IPackageReferenceRepository packageReferenceRepository = ref _packageReferenceRepository;
		IPackageRepository localRepository2 = ((ProjectManager)this).get_LocalRepository();
		packageReferenceRepository = (IPackageReferenceRepository)(object)((localRepository2 is IPackageReferenceRepository) ? localRepository2 : null);
		_settings = settings;
		_sharedPackageRepository = sharedPackageRepository;
	}

	private static IEnumerable<T> GetCompatibleItemsCore<T>(IProjectSystem projectSystem, IEnumerable<T> items) where T : IFrameworkTargetable
	{
		IEnumerable<T> result = default(IEnumerable<T>);
		if (VersionUtility.TryGetCompatibleItems<T>(projectSystem.get_TargetFramework(), items, ref result))
		{
			return result;
		}
		return Enumerable.Empty<T>();
	}

	protected override void ExtractPackageFilesToProject(IPackage package)
	{
		List<IPackageAssemblyReference> list = ElmaProjectManager.GetCompatibleItemsCore<IPackageAssemblyReference>(((ProjectManager)this).get_Project(), package.get_AssemblyReferences()).ToList();
		IEnumerable<IPackageFile> files = package.GetFiles();
		IPackageFile val = files.FirstOrDefault((IPackageFile f) => f.get_Path().Equals("Files_Attributes.xml"));
		FilesAttributes filesAttributes = null;
		if (val != null)
		{
			using Stream stream2 = val.GetStream();
			filesAttributes = (FilesAttributes)_fileAttributesSerializer.Deserialize(stream2);
		}
		try
		{
			IEnumerable<IPackageFile> contentFiles = GetContentFiles(files);
			if (contentFiles != null && contentFiles.Any())
			{
				foreach (IPackageFile item in contentFiles)
				{
					string path2 = item.get_Path();
					if (!((ProjectManager)this).get_Project().IsSupportedFile(path2))
					{
						continue;
					}
					if (((IFileSystem)((ProjectManager)this).get_Project()).FileExists(path2))
					{
						((ProjectManager)this).get_Logger().Log((MessageLevel)1, SR.T("Файл \"{0}\" уже существует"), new object[1] { path2 });
						continue;
					}
					using Stream stream3 = item.GetStream();
					DateTime? creationTime = null;
					DateTime? lastWriteTime = null;
					ProjectSystemImpl projectSystemImpl = ((ProjectManager)this).get_Project() as ProjectSystemImpl;
					FileAttributes fileAttributes = ((filesAttributes != null) ? filesAttributes.Files.FirstOrDefault((FileAttributes f) => f.Path.Equals(path2)) : null);
					if (fileAttributes != null && projectSystemImpl != null)
					{
						creationTime = fileAttributes.CreationTime;
						lastWriteTime = fileAttributes.LastWriteTime;
					}
					((ProjectSystemImpl)(object)((ProjectManager)this).get_Project()).AddFile(path2, stream3, creationTime, lastWriteTime);
				}
			}
			foreach (IPackageAssemblyReference item2 in list)
			{
				((ProjectManager)this).get_Logger().Log((MessageLevel)2, SR.T("  Выбрана сборка: {0}", ((IPackageFile)item2).get_Path()), Array.Empty<object>());
				Action<string, Stream> action = delegate(string path, Stream stream)
				{
					DateTime? creationTime2 = null;
					DateTime? lastWriteTime2 = null;
					ProjectSystemImpl projectSystemImpl2 = ((ProjectManager)this).get_Project() as ProjectSystemImpl;
					FileAttributes fileAttributes2 = ((filesAttributes != null) ? filesAttributes.Files.FirstOrDefault((FileAttributes f) => f.Path.Equals(path)) : null);
					if (fileAttributes2 != null && projectSystemImpl2 != null)
					{
						creationTime2 = fileAttributes2.CreationTime;
						lastWriteTime2 = fileAttributes2.LastWriteTime;
					}
					((ProjectSystemImpl)(object)((ProjectManager)this).get_Project()).AddReference(path, stream, creationTime2, lastWriteTime2);
				};
				if (PackageExtensions.IsEmptyFolder((IPackageFile)(object)item2))
				{
					continue;
				}
				if (((ProjectManager)this).get_Project().ReferenceExists(((IPackageFile)item2).get_Path()))
				{
					((ProjectManager)this).get_Project().RemoveReference(((IPackageFile)item2).get_Path());
				}
				using (Stream arg = ((IPackageFile)item2).GetStream())
				{
					action(((IPackageFile)item2).get_Path(), arg);
				}
				List<IPackageFile> list2 = GetFiles(files, Path.GetDirectoryName(((IPackageFile)item2).get_Path())).ToList();
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(Path.GetFileName(((IPackageFile)item2).get_Path()));
				foreach (IPackageFile item3 in list2)
				{
					string fileName = Path.GetFileName(item3.get_Path());
					bool flag = item3.get_Path().Equals(((IPackageFile)item2).get_Path() + ".config", StringComparison.CurrentCultureIgnoreCase);
					string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(fileName);
					if (Path.GetExtension(fileName).Equals(".xml", StringComparison.CurrentCultureIgnoreCase))
					{
						if (item3.get_Path().Split('\\').Count() > 3)
						{
							continue;
						}
						CultureInfo cultureFromSettings = SR.GetCultureFromSettings();
						if (cultureFromSettings != null && cultureFromSettings.Name != SR.KeyCultureInfo.Name)
						{
							string culturePath = Path.Combine(item3.get_Path().Replace(item3.get_EffectivePath(), ""), cultureFromSettings.Name, item3.get_EffectivePath());
							IPackageFile val2 = list2.FirstOrDefault((IPackageFile q) => q.get_Path().Equals(culturePath, StringComparison.CurrentCultureIgnoreCase));
							if (val2 != null)
							{
								if (((ProjectManager)this).get_Project().ReferenceExists(fileName))
								{
									((ProjectManager)this).get_Project().RemoveReference(fileName);
								}
								using (Stream arg2 = val2.GetStream())
								{
									action(item3.get_Path(), arg2);
								}
								continue;
							}
						}
					}
					if (!item3.get_Path().Equals(((IPackageFile)item2).get_Path(), StringComparison.CurrentCultureIgnoreCase) && (fileNameWithoutExtension.Equals(fileNameWithoutExtension2, StringComparison.CurrentCultureIgnoreCase) || flag))
					{
						if (((ProjectManager)this).get_Project().ReferenceExists(fileName))
						{
							((ProjectManager)this).get_Project().RemoveReference(fileName);
						}
						using Stream arg3 = item3.GetStream();
						action(item3.get_Path(), arg3);
					}
				}
			}
			if (new ElmaPackageMetadata(((IPackageMetadata)package).get_Tags()).Type == ElmaPackageType.Help)
			{
				AddHelpFiles(contentFiles);
			}
		}
		finally
		{
			if (_packageReferenceRepository != null)
			{
				_packageReferenceRepository.AddPackage(((IPackageName)package).get_Id(), ((IPackageName)package).get_Version(), false, ((ProjectManager)this).get_Project().get_TargetFramework());
			}
			else
			{
				((ProjectManager)this).get_LocalRepository().AddPackage(package);
			}
			files = null;
			GC.Collect();
		}
	}

	public void AddPackageReferences(IEnumerable<IPackage> packages, bool ignoreDependencies, bool allowPrereleaseVersions, bool updateDependencies)
	{
		PrepareAddPackageReferences(packages, ignoreDependencies, allowPrereleaseVersions, updateDependencies)?.Execute();
	}

	public IPreparedOperation PrepareAddPackageReferences(IEnumerable<IPackage> packages, bool ignoreDependencies, bool allowPrereleaseVersions, bool updateDependencies)
	{
		if (_settings != null)
		{
			packages = packages.Where((IPackage p) => new ElmaPackageMetadata(((IPackageMetadata)p).get_Tags()).IsCompatible(_settings.Edition)).ToArray();
		}
		List<IPackage> packagesToRemove = new List<IPackage>();
		if (ElmaComponent != null)
		{
			packagesToRemove.AddRange(packages.Where((IPackage p) => !ElmaComponent.IsCompatible(p)));
			packages = packages.Where((IPackage p) => !packagesToRemove.Contains(p)).ToArray();
			foreach (IPackage package in packages)
			{
				ElmaComponent.CheckCompatible(package);
			}
		}
		ElmaUpdateWalker walker = new ElmaUpdateWalker(_settings, ((ProjectManager)this).get_LocalRepository(), ((ProjectManager)this).get_SourceRepository(), (IDependentsResolver)(object)new ElmaDependentsWalker(_settings, ((ProjectManager)this).get_LocalRepository(), ((ProjectManager)this).get_Project().get_TargetFramework()), ((ProjectManager)this).get_ConstraintProvider(), ((ProjectManager)this).get_Project().get_TargetFramework(), ((ProjectManager)this).get_Logger(), !ignoreDependencies, allowPrereleaseVersions)
		{
			AcceptedTargets = (PackageTargets)1,
			ElmaComponent = ElmaComponent,
			UpdateDependencies = updateDependencies,
			ThrowOnConflicts = true,
			PackageFrameworkComparer = (string id) => _packageReferenceRepository.GetPackageTargetFramework(id) == ((ProjectManager)this).get_Project().get_TargetFramework()
		};
		if (ElmaComponent != null)
		{
			PackageInfo packageInfo = ElmaComponent.GetInstalledPackagesInfo().FirstOrDefault((PackageInfo p) => p.Id == "EleWise.ELMA.CRM.UA");
			if (packageInfo != null && packageInfo.Version < SemanticVersion.Parse("3.11.6"))
			{
				walker.PackagesToRemove.Add("EleWise.ELMA.CRM.UA");
				walker.PackagesToRemove.Add("EleWise.ELMA.CRM.UA.Web");
				walker.PackagesToRemove.Add("EleWise.ELMA.CRM.UA.Import.Web");
			}
		}
		if (_settings.Edition == ElmaEdition.Express)
		{
			walker.PackagesToRemove.Add("EleWise.ELMA.Extensions.MSSQL");
			walker.PackagesToRemove.Add("EleWise.ELMA.CRM.Workflow.Processes.Db.MsSql");
		}
		if (_settings.Edition != ElmaEdition.Enterprise)
		{
			walker.PackagesToRemove.Add("EleWise.ELMA.Cache.AppFabric");
			walker.PackagesToRemove.Add("EleWise.ELMA.MessageQueue");
			walker.PackagesToRemove.Add("EleWise.ELMA.MessageQueueJMS");
			walker.PackagesToRemove.Add("EleWise.ELMA.MessageQueueMSMQ");
			walker.PackagesToRemove.Add("EleWise.ELMA.MessageQueueRMQ");
			walker.PackagesToRemove.Add("EleWise.ELMA.MessageQueue.Design");
			walker.PackagesToRemove.Add("EleWise.ELMA.MessageQueueJMS.Design");
			walker.PackagesToRemove.Add("EleWise.ELMA.MessageQueueMSMQ.Design");
			walker.PackagesToRemove.Add("EleWise.ELMA.MessageQueueRMQ.Design");
			walker.PackagesToRemove.Add("EleWise.ELMA.Extensions.Oracle");
			walker.PackagesToRemove.Add("EleWise.ELMA.Diagnostics.Elastic");
		}
		if (_settings.Edition != ElmaEdition.CE)
		{
			walker.PackagesToRemove.Add("EleWise.ELMA.WebServer.Shell");
		}
		walker.PackagesToRemove.Add("EleWise.ELMA.Projects.Workflow");
		walker.PackagesToRemove.Add("EleWise.ELMA.Projects.Workflow.Design");
		walker.PackagesToRemove.Add("EleWise.ELMA.Projects.Workflow.Web");
		foreach (IPackage item in packagesToRemove)
		{
			if (!walker.PackagesToRemove.Contains(((IPackageName)item).get_Id()))
			{
				((ProjectManager)this).get_Logger().Log((MessageLevel)2, SR.T("Пакет '{0}' не будет установлен (или будет удален) как несовместимый с компонентом '{1}'", ((IPackageName)item).get_Id(), (ElmaComponent != null) ? ElmaComponent.Id : ""), Array.Empty<object>());
				walker.PackagesToRemove.Add(((IPackageName)item).get_Id());
			}
		}
		foreach (string item2 in (from d in packages.SelectMany((IPackage p) => ((IXPackageMetadata)p).get_UninstallDependencies() ?? Enumerable.Empty<PackageUninstallDependency>())
			select d.get_Id()).ToHashSet())
		{
			((ProjectManager)this).get_Logger().Log((MessageLevel)2, SR.T("Устаревший пакет '{0}' будет удален (если встретится среди пакетов компонента)", item2), Array.Empty<object>());
			walker.PackagesToRemove.Add(item2);
		}
		packages = packages.Where((IPackage p) => !walker.PackagesToRemove.Contains(((IPackageName)p).get_Id())).ToList();
		IPreparedOperation result = Execute(packages, walker);
		((ProjectManager)this).get_Logger().Log((MessageLevel)2, SR.T("Список пакетов для переустановки:"), Array.Empty<object>());
		foreach (IPackage item3 in walker.PackagesToReinstall)
		{
			((ProjectManager)this).get_Logger().Log((MessageLevel)2, SR.T("{0} {1}", ((IPackageName)item3).get_Id(), ((IPackageName)item3).get_Version()), Array.Empty<object>());
		}
		return result;
	}

	public override void AddPackageReference(IPackage package, bool ignoreDependencies, bool allowPrereleaseVersions)
	{
		AddPackageReferences((IEnumerable<IPackage>)(object)new IPackage[1] { package }, ignoreDependencies, allowPrereleaseVersions, updateDependencies: true);
	}

	public void RemovePackageReferences(IEnumerable<IPackage> packages, bool forceRemove, bool removeDependencies)
	{
		PrepareRemovePackageReferences(packages, forceRemove, removeDependencies)?.Execute();
	}

	public IPreparedOperation PrepareRemovePackageReferences(IEnumerable<IPackage> packages, bool forceRemove, bool removeDependencies)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		ElmaUninstallWalker resolver = new ElmaUninstallWalker(_settings, ((ProjectManager)this).get_LocalRepository(), (IDependentsResolver)new DependentsWalker(((ProjectManager)this).get_LocalRepository(), ((ProjectManager)this).get_Project().get_TargetFramework()), ((ProjectManager)this).get_Project().get_TargetFramework(), ((ProjectManager)this).get_Logger(), removeDependencies, forceRemove)
		{
			ThrowOnConflicts = forceRemove
		};
		return Execute(packages, resolver);
	}

	public override void RemovePackageReference(IPackage package, bool forceRemove, bool removeDependencies)
	{
		RemovePackageReferences((IEnumerable<IPackage>)(object)new IPackage[1] { package }, forceRemove, removeDependencies);
	}

	protected void Execute(PackageOperation operation)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		bool flag = PackageRepositoryExtensions.Exists(((ProjectManager)this).get_LocalRepository(), (IPackageName)(object)operation.get_Package());
		if ((int)operation.get_Action() == 0)
		{
			bool flag2 = GetPackageTargetFramework(((IPackageName)operation.get_Package()).get_Id()) == ((ProjectManager)this).get_Project().get_TargetFramework();
			if (flag && flag2)
			{
				((ProjectManager)this).get_Logger().Log((MessageLevel)2, SR.T("Проект '{0}' уже содержит пакет '{1}'.", ((ProjectManager)this).get_Project().get_ProjectName(), PackageExtensions.GetFullName((IPackageName)(object)operation.get_Package())), Array.Empty<object>());
			}
			else if (flag)
			{
				((ProjectManager)this).get_Logger().Log((MessageLevel)2, SR.T("Переустанавливаем пакет '{1}' в проекте '{0}'.", ((ProjectManager)this).get_Project().get_ProjectName(), PackageExtensions.GetFullName((IPackageName)(object)operation.get_Package())), Array.Empty<object>());
				RemovePackageReferenceFromProject(operation.get_Package());
				AddPackageReferenceToProject(operation.get_Package());
			}
			else
			{
				AddPackageReferenceToProject(operation.get_Package());
			}
		}
		else if (flag)
		{
			RemovePackageReferenceFromProject(operation.get_Package());
		}
	}

	private IPreparedOperation Execute(IEnumerable<IPackage> packages, IElmaPackageOperationResolver resolver)
	{
		IEnumerable<PackageOperation> enumerable = resolver.ResolveOperations(packages);
		if (enumerable.Any())
		{
			return new InstallExecutor(this, enumerable);
		}
		return null;
	}

	private void DoExecute(IEnumerable<PackageOperation> operations)
	{
		if (ElmaComponent != null)
		{
			ElmaComponent.BeforeUpdate();
		}
		bool success = false;
		try
		{
			foreach (PackageOperation operation in operations)
			{
				Execute(operation);
			}
			success = true;
		}
		finally
		{
			if (ElmaComponent != null)
			{
				ElmaComponent.AfterUpdate(success);
			}
		}
	}

	private FrameworkName GetPackageTargetFramework(string packageId)
	{
		if (_packageReferenceRepository != null)
		{
			return _packageReferenceRepository.GetPackageTargetFramework(packageId) ?? ((ProjectManager)this).get_Project().get_TargetFramework();
		}
		return ((ProjectManager)this).get_Project().get_TargetFramework();
	}

	protected void AddPackageReferenceToProject(IPackage package)
	{
		((ProjectManager)this).get_Logger().Log((MessageLevel)0, SR.T("Установка пакета '{0}' в компонент '{1}'...", PackageExtensions.GetFullName((IPackageName)(object)package), ((ProjectManager)this).get_Project().get_ProjectName()), Array.Empty<object>());
		((ProjectManager)this).ExtractPackageFilesToProject(package);
		((ProjectManager)this).get_Logger().Log((MessageLevel)2, SR.T("Пакет '{0}' установлен в компонент '{1}'.", PackageExtensions.GetFullName((IPackageName)(object)package), ((ProjectManager)this).get_Project().get_ProjectName()), Array.Empty<object>());
	}

	private void RemovePackageReferenceFromProject(IPackage package)
	{
		((ProjectManager)this).get_Logger().Log((MessageLevel)0, SR.T("Удаление пакета '{0}' из компонента '{1}'...", PackageExtensions.GetFullName((IPackageName)(object)package), ((ProjectManager)this).get_Project().get_ProjectName()), Array.Empty<object>());
		List<IPackageAssemblyReference> list = ElmaProjectManager.GetCompatibleItemsCore<IPackageAssemblyReference>(((ProjectManager)this).get_Project(), package.get_AssemblyReferences()).ToList();
		IEnumerable<IPackageFile> files = package.GetFiles();
		IEnumerable<IPackageFile> contentFiles = GetContentFiles(files);
		if (contentFiles != null && contentFiles.Any())
		{
			foreach (IPackageFile item in contentFiles)
			{
				string path = item.get_Path();
				if (((ProjectManager)this).get_Project().IsSupportedFile(path) && ((IFileSystem)((ProjectManager)this).get_Project()).FileExists(path))
				{
					((IFileSystem)((ProjectManager)this).get_Project()).DeleteFile(path);
				}
			}
		}
		foreach (IPackageAssemblyReference item2 in list)
		{
			if (PackageExtensions.IsEmptyFolder((IPackageFile)(object)item2))
			{
				continue;
			}
			if (((ProjectManager)this).get_Project().ReferenceExists(((IPackageFile)item2).get_Path()))
			{
				((ProjectManager)this).get_Project().RemoveReference(((IPackageFile)item2).get_Path());
			}
			IEnumerable<IPackageFile> files2 = GetFiles(files, Path.GetDirectoryName(((IPackageFile)item2).get_Path()));
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(Path.GetFileName(((IPackageFile)item2).get_Path()));
			foreach (IPackageFile item3 in files2)
			{
				string fileName = Path.GetFileName(item3.get_Path());
				bool flag = item3.get_Path().Equals(((IPackageFile)item2).get_Path() + ".config", StringComparison.CurrentCultureIgnoreCase);
				string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(fileName);
				if (!item3.get_Path().Equals(((IPackageFile)item2).get_Path(), StringComparison.CurrentCultureIgnoreCase) && (fileNameWithoutExtension.Equals(fileNameWithoutExtension2, StringComparison.CurrentCultureIgnoreCase) || flag) && ((ProjectManager)this).get_Project().ReferenceExists(fileName))
				{
					((ProjectManager)this).get_Project().RemoveReference(fileName);
				}
			}
		}
		RemovePackageAdditionalFiles(package, files);
		((ProjectManager)this).get_LocalRepository().RemovePackage(package);
		((ProjectManager)this).get_Logger().Log((MessageLevel)2, SR.T("Пакет '{0}' удален из компонента '{1}'.", PackageExtensions.GetFullName((IPackageName)(object)package), ((ProjectManager)this).get_Project().get_ProjectName()), Array.Empty<object>());
	}

	private IEnumerable<T> GetCompatibleItemsForPackage<T>(string packageId, IEnumerable<T> items) where T : IFrameworkTargetable
	{
		FrameworkName packageTargetFramework = GetPackageTargetFramework(packageId);
		if (packageTargetFramework == null)
		{
			return items;
		}
		IEnumerable<T> result = default(IEnumerable<T>);
		if (VersionUtility.TryGetCompatibleItems<T>(packageTargetFramework, items, ref result))
		{
			return result;
		}
		return Enumerable.Empty<T>();
	}

	private IEnumerable<IPackageFile> GetContentFiles(IEnumerable<IPackageFile> packageFiles)
	{
		return GetFiles(packageFiles, "ELMA").Union(GetFiles(packageFiles, "Content"));
	}

	private void RemovePackageAdditionalFiles(IPackage package, IEnumerable<IPackageFile> packageFiles)
	{
		if (ElmaComponent == null || !(ElmaComponent.GetType() == typeof(WebComponent)))
		{
			return;
		}
		new ElmaPackageMetadata(((IPackageMetadata)package).get_Tags());
		foreach (string item in (from m in (from f in GetContentFiles(packageFiles)
				where f.get_Path().StartsWith("ELMA\\WebModule\\", StringComparison.CurrentCultureIgnoreCase)
				select f).Select(delegate(IPackageFile f)
			{
				string text2 = f.get_Path().Substring("ELMA\\WebModule".Length + 1);
				int num = text2.IndexOf('\\');
				return (num <= 0) ? null : text2.Substring(0, num);
			})
			where !string.IsNullOrEmpty(m)
			select m).Distinct(StringComparer.CurrentCultureIgnoreCase))
		{
			string path = Path.Combine(ElmaComponent.ComponentRoot, "Modules", item);
			string[] temporaryPaths = WebModuleFolder.TemporaryPaths;
			foreach (string path2 in temporaryPaths)
			{
				string text = Path.Combine(path, path2);
				if (Directory.Exists(text))
				{
					try
					{
						Directory.Delete(text, recursive: true);
					}
					catch (Exception exception)
					{
						Logger.Log.Warn(SR.T("Не удалось удалить папку '{0}'", text), exception);
					}
				}
			}
		}
	}

	private void AddHelpFiles(IEnumerable<IPackageFile> contentFiles)
	{
		if (_settings == null)
		{
			return;
		}
		foreach (IPackageFile item in contentFiles.Where((IPackageFile f) => f.get_Path().StartsWith("ELMA\\HelpChm\\")))
		{
			string path = Path.Combine(_settings.Root, "Help");
			string path2 = item.get_Path().Substring("ELMA\\HelpChm".Length + 1);
			string fileName = Path.Combine(path, path2);
			using Stream stream = item.GetStream();
			FS.CreateFile(fileName, stream);
		}
	}

	private static IEnumerable<IPackageFile> GetFiles(IEnumerable<IPackageFile> files, string directory)
	{
		string folderPrefix = directory + Path.DirectorySeparatorChar;
		return files.Where((IPackageFile file) => file.get_Path().StartsWith(folderPrefix, StringComparison.OrdinalIgnoreCase));
	}
}
