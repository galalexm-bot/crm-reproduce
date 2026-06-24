using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.UI.Helpers;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Services;

namespace EleWise.ELMA.UIBuilder.Services;

[Service]
internal sealed class ModulePublishDataProvider : IModulePublishDataProvider
{
	private readonly string newLine = Environment.NewLine;

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	private readonly IDependencyService dependencyService;

	private readonly ICheckComponentService checkComponentService;

	private readonly ICheckDataClassService checkDataClassService;

	public ModulePublishDataProvider(IModuleMetadataLoader moduleMetadataLoader, IDependencyService dependencyService, ICheckComponentService checkComponentService, ICheckDataClassService checkDataClassService)
	{
		this.moduleMetadataLoader = moduleMetadataLoader;
		this.dependencyService = dependencyService;
		this.checkComponentService = checkComponentService;
		this.checkDataClassService = checkDataClassService;
	}

	public IReadOnlyCollection<ModuleVersion> PrepareData(ModuleInfoMetadata module, IEnumerable<ModuleVersion> extendedModuleContext = null)
	{
		Contract.NotNull(module, "module");
		foreach (ComponentMetadata component in module.Components)
		{
			ComponentMetadataItemHeaderManager.UpdateCalculateScriptDynamicProperties(component);
		}
		IReadOnlyCollection<ModuleVersion> readOnlyCollection;
		if (module.Dependency != null)
		{
			CheckDependencyConsistency(module);
			readOnlyCollection = CheckDependencies(module, extendedModuleContext ?? Enumerable.Empty<ModuleVersion>());
		}
		else
		{
			readOnlyCollection = FillDependencies(module, extendedModuleContext ?? Enumerable.Empty<ModuleVersion>());
			CheckDependencyConsistency(module);
		}
		Validate(module, readOnlyCollection);
		return readOnlyCollection;
	}

	private IReadOnlyCollection<ModuleVersion> FillDependencies(ModuleInfoMetadata module, IEnumerable<ModuleVersion> extendedModuleContext)
	{
		ModuleVersion[] publishedDependModules = GetPublishedDependModules(module, extendedModuleContext.ToDictionary((ModuleVersion v) => v.Metadata.Uid));
		IEnumerable<Guid> ignoredMetadata = module.Components.SelectMany((ComponentMetadata c) => from md in c.GetMetadataToRegister()
			select md.Uid);
		using (CreateContext(module, publishedDependModules))
		{
			module.Dependency = dependencyService.CalculateDependencies(module, ignoredMetadata);
			return (IReadOnlyCollection<ModuleVersion>)(object)publishedDependModules;
		}
	}

	private ModuleVersion[] GetPublishedDependModules(ModuleInfoMetadata module, IReadOnlyDictionary<Guid, ModuleVersion> extendedModuleContext)
	{
		List<LinkToModule> dependencyModules = module.DependencyModules;
		if (dependencyModules.Count == 0)
		{
			return Array.Empty<ModuleVersion>();
		}
		return dependencyModules.Select((LinkToModule l) => GetContextVersion(l.ModuleUid) ?? moduleMetadataLoader.GetDefaultModuleVersion(l.ModuleUid)).ToArray();
		ModuleVersion GetContextVersion(Guid moduleUid)
		{
			if (!extendedModuleContext.TryGetValue(moduleUid, out var value))
			{
				return null;
			}
			return value;
		}
	}

	private void CheckDependencyConsistency(ModuleInfoMetadata module)
	{
		ModuleDependency dependency = module.Dependency;
		HashSet<Guid> hashSet = (from uid in dependency.Components.Select((ComponentDependency c) => c.ModuleUid).Concat(dependency.DataClasses.Select((DataClassDependency d) => d.ModuleUid)).Concat(dependency.Functions.Select((FunctionDependency f) => f.ModuleUid))
			where uid != module.Uid && uid != Guid.Empty
			select uid).ToHashSet();
		HashSet<Guid> hashSet2 = module.DependencyModules.Select((LinkToModule d) => d.ModuleUid).ToHashSet();
		if (!hashSet.IsSubsetOf(hashSet2))
		{
			string text = SR.T("Не задекларированы зависимости:{0}", newLine + string.Join(newLine, hashSet.Except(hashSet2)));
			throw new Exception(SR.T("Вычисленная модель зависимости {0}({1}) модуля не соответствует декларируемой:{2}", module.DisplayName, module.Uid, newLine + text));
		}
	}

	private IReadOnlyCollection<ModuleVersion> CheckDependencies(ModuleInfoMetadata metadata, IEnumerable<ModuleVersion> extendedModuleContext)
	{
		List<ModuleVersion> list = new List<ModuleVersion>();
		foreach (LinkToModule depModule in metadata.DependencyModules)
		{
			CompatibilityResult compatibilityResult = null;
			ModuleVersionHeader currentVersion = null;
			List<string> list2 = new List<string>();
			foreach (ModuleVersionHeader item in (from mv in extendedModuleContext
				select mv.Header into h
				where h.HeaderUid == depModule.ModuleUid
				select h).Concat(GetSignatures(depModule.ModuleUid)))
			{
				compatibilityResult = CheckModuleHelper.CheckSignatures(metadata.Dependency, item.Signature, depModule.ModuleUid);
				if (!compatibilityResult.IsValid)
				{
					list2.Add(SR.T("Версия модуля {0} несовместима по причине: {1}", item.Version, string.Join(newLine, compatibilityResult.Errors)));
					continue;
				}
				if (currentVersion == null)
				{
					currentVersion = item;
				}
				if (item.Status != ModuleStatus.Enabled)
				{
					continue;
				}
				currentVersion = item;
				break;
			}
			if (compatibilityResult == null)
			{
				throw new ModuleNotFoundException(depModule.ModuleUid, SR.T("Не найдено ни одной версии {0}({1})) с вычисленной сигнатурой", depModule.DisplayName, depModule.ModuleUid));
			}
			if (currentVersion == null)
			{
				throw new ModuleNotFoundException(depModule.ModuleUid, SR.T("Для модуля {0}({1}) не найдено совместимой версии {2}({3}):{4}", metadata.DisplayName, metadata.Uid, depModule.DisplayName, depModule.ModuleUid, string.Join(newLine, list2)));
			}
			if (currentVersion.Status != ModuleStatus.Enabled)
			{
				throw new ModuleNotFoundException(depModule.ModuleUid, ModuleDisabledReason.Activation);
			}
			list.Add(extendedModuleContext.FirstOrDefault((ModuleVersion m) => m.Header.HeaderUid == depModule.ModuleUid && m.Header.VersionUid == currentVersion.VersionUid) ?? moduleMetadataLoader.GetSpecificModuleVersion(depModule.ModuleUid, currentVersion.VersionUid));
		}
		return list;
	}

	private IEnumerable<ModuleVersionHeader> GetSignatures(Guid moduleUid)
	{
		return from v in moduleMetadataLoader.GetModuleVersionHeaders(moduleUid, published: false)
			orderby v.Version descending
			select v;
	}

	private void Validate(ModuleInfoMetadata module, IEnumerable<ModuleVersion> dependencies)
	{
		Contract.ArgumentNotNull(module, "module");
		List<string> list = new List<string>();
		using (CreateContext(module, dependencies))
		{
			foreach (DataClassMetadata dataClass in module.DataClasses)
			{
				ValidationResult validationResult = checkDataClassService.Validate(dataClass);
				if (!validationResult.IsValid)
				{
					string item = SR.T("Ошибка при публикации датакласса \"{0}\" {1}{2}", dataClass.DisplayName, newLine, string.Join(newLine, validationResult.Errors.Select((ValidationError error) => error.Message)));
					list.Add(item);
				}
			}
			foreach (ComponentMetadata component in module.Components)
			{
				using (MetadataServiceContext.Extend(component.DataClasses))
				{
					ValidationResult validationResult2 = checkComponentService.Validate(component);
					if (!validationResult2.IsValid)
					{
						string item2 = SR.T("Ошибка при публикации компонента \"{0}\" {1}{2}", component.DisplayName, newLine, ValidationErrorHelper.GetMessage(validationResult2.Errors));
						list.Add(item2);
					}
				}
			}
		}
		if (list.Count > 0)
		{
			throw new Exception(SR.T("Некорректные метаданные модуля:{0}", newLine + string.Join(newLine, list)));
		}
	}

	private IDisposable CreateContext(ModuleInfoMetadata module, IEnumerable<ModuleVersion> dependencies)
	{
		return MetadataServiceContext.Extend(module.DataClasses.Concat<IMetadata>(module.Functions).Concat(module.Components).Concat(dependencies.SelectMany((ModuleVersion m) => m.Metadata.DataClasses))
			.Concat(dependencies.SelectMany((ModuleVersion m) => m.Metadata.Functions))
			.Concat(dependencies.SelectMany((ModuleVersion m) => m.Metadata.Components)));
	}
}
