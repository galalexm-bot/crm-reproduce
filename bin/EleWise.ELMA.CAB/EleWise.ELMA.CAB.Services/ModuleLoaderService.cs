#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using EleWise.ELMA.CAB.Configuration;
using EleWise.ELMA.CAB.Instrumentation;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Utility;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB.Services;

public class ModuleLoaderService : IModuleLoaderService
{
	private class ClassNameTraceSourceAttribute : TraceSourceAttribute
	{
		public ClassNameTraceSourceAttribute()
			: base(typeof(ModuleLoaderService).FullName)
		{
		}
	}

	private class ModuleMetadata
	{
		private readonly Assembly assembly;

		private readonly List<string> dependencies = new List<string>();

		private readonly List<IModule> moduleClasses = new List<IModule>();

		private readonly List<Type> moduleTypes = new List<Type>();

		private readonly List<string> roles = new List<string>();

		private readonly List<ServiceMetadata> services = new List<ServiceMetadata>();

		private readonly TraceSource traceSource;

		private readonly List<KeyValuePair<Type, Type>> workItemExtensions = new List<KeyValuePair<Type, Type>>();

		private readonly List<Type> workItemRootExtensions = new List<Type>();

		private bool extensionsInitialized;

		private bool loadedServices;

		private bool modulesInitialzed;

		private string name;

		private bool notified;

		public IEnumerable<string> Dependencies => dependencies;

		public string Name
		{
			get
			{
				if (name == null)
				{
					name = assembly.FullName;
				}
				return name;
			}
			set
			{
				name = value;
			}
		}

		public ModuleMetadata(Assembly assembly, TraceSource traceSource)
		{
			this.assembly = assembly;
			this.traceSource = traceSource;
			object[] customAttributes = assembly.GetCustomAttributes(typeof(ModuleAttribute), inherit: true);
			for (int i = 0; i < customAttributes.Length; i++)
			{
				ModuleAttribute moduleAttribute = (ModuleAttribute)customAttributes[i];
				name = moduleAttribute.Name;
			}
			customAttributes = assembly.GetCustomAttributes(typeof(ModuleDependencyAttribute), inherit: true);
			for (int i = 0; i < customAttributes.Length; i++)
			{
				ModuleDependencyAttribute moduleDependencyAttribute = (ModuleDependencyAttribute)customAttributes[i];
				dependencies.Add(moduleDependencyAttribute.Name);
			}
			Type[] exportedTypes = assembly.GetExportedTypes();
			foreach (Type type in exportedTypes)
			{
				customAttributes = type.GetCustomAttributes(typeof(ServiceAttribute), inherit: true);
				for (int j = 0; j < customAttributes.Length; j++)
				{
					ServiceAttribute serviceAttribute = (ServiceAttribute)customAttributes[j];
					services.Add(new ServiceMetadata(type, serviceAttribute.RegisterAs ?? type, serviceAttribute.AddOnDemand));
				}
				customAttributes = type.GetCustomAttributes(typeof(WorkItemExtensionAttribute), inherit: true);
				for (int j = 0; j < customAttributes.Length; j++)
				{
					WorkItemExtensionAttribute workItemExtensionAttribute = (WorkItemExtensionAttribute)customAttributes[j];
					workItemExtensions.Add(new KeyValuePair<Type, Type>(workItemExtensionAttribute.WorkItemType, type));
				}
				customAttributes = type.GetCustomAttributes(typeof(RootWorkItemExtensionAttribute), inherit: true);
				for (int j = 0; j < customAttributes.Length; j++)
				{
					RootWorkItemExtensionAttribute rootWorkItemExtensionAttribute = (RootWorkItemExtensionAttribute)customAttributes[j];
					workItemRootExtensions.Add(type);
				}
				if (!type.IsAbstract && typeof(IModule).IsAssignableFrom(type))
				{
					moduleTypes.Add(type);
				}
			}
		}

		public void LoadServices(WorkItem workItem)
		{
			if (loadedServices)
			{
				return;
			}
			loadedServices = true;
			EnsureModuleClassesExist(workItem);
			try
			{
				foreach (IModule moduleClass in moduleClasses)
				{
					moduleClass.AddServices();
					if (traceSource != null)
					{
						traceSource.TraceInformation(Resources.AddServicesCalled, moduleClass.GetType());
					}
				}
				foreach (ServiceMetadata service in services)
				{
					if (service.AddOnDemand)
					{
						workItem.Services.AddOnDemand(service.InstanceType, service.RegistrationType);
						if (traceSource != null)
						{
							traceSource.TraceInformation(Resources.ServiceAddedOnDemand, Name, service.InstanceType);
						}
					}
					else
					{
						workItem.Services.AddNew(service.InstanceType, service.RegistrationType);
						if (traceSource != null)
						{
							traceSource.TraceInformation(Resources.ServiceAdded, Name, service.InstanceType);
						}
					}
				}
			}
			catch (Exception innerException)
			{
				ThrowModuleLoadException(innerException);
			}
		}

		private void EnsureModuleClassesExist(WorkItem workItem)
		{
			if (moduleClasses.Count == moduleTypes.Count)
			{
				return;
			}
			try
			{
				foreach (Type moduleType in moduleTypes)
				{
					IModule item = (IModule)workItem.Items.AddNew(moduleType);
					moduleClasses.Add(item);
					if (traceSource != null)
					{
						traceSource.TraceInformation(Resources.LogModuleAdded, moduleType);
					}
				}
			}
			catch (FileNotFoundException innerException)
			{
				ThrowModuleReferenceException(innerException);
			}
			catch (Exception innerException2)
			{
				ThrowModuleLoadException(innerException2);
			}
		}

		public void InitializeModuleClasses(WorkItem workItem)
		{
			if (modulesInitialzed)
			{
				return;
			}
			modulesInitialzed = true;
			EnsureModuleClassesExist(workItem);
			try
			{
				foreach (IModule moduleClass in moduleClasses)
				{
					moduleClass.Load();
					if (traceSource != null)
					{
						traceSource.TraceInformation(Resources.ModuleStartCalled, moduleClass.GetType());
					}
				}
			}
			catch (FileNotFoundException innerException)
			{
				ThrowModuleReferenceException(innerException);
			}
			catch (Exception innerException2)
			{
				ThrowModuleLoadException(innerException2);
			}
		}

		public void InitializeWorkItemExtensions(WorkItem workItem)
		{
			if (extensionsInitialized)
			{
				return;
			}
			extensionsInitialized = true;
			IWorkItemExtensionService workItemExtensionService = workItem.Services.Get<IWorkItemExtensionService>();
			if (workItemExtensionService == null)
			{
				return;
			}
			foreach (KeyValuePair<Type, Type> workItemExtension in workItemExtensions)
			{
				workItemExtensionService.RegisterExtension(workItemExtension.Key, workItemExtension.Value);
			}
			foreach (Type workItemRootExtension in workItemRootExtensions)
			{
				workItemExtensionService.RegisterRootExtension(workItemRootExtension);
			}
		}

		public void NotifyOfLoadedModule(Action<LoadedModuleInfo> action)
		{
			if (!notified)
			{
				notified = true;
				action(ToLoadedModuleInfo());
			}
		}

		public LoadedModuleInfo ToLoadedModuleInfo()
		{
			return new LoadedModuleInfo(assembly, Name, roles, dependencies);
		}

		private void ThrowModuleLoadException(Exception innerException)
		{
			throw new ModuleLoadException(Name, string.Format(CultureInfo.CurrentCulture, Resources.FailedToLoadModule, new object[2] { assembly.FullName, innerException.Message }), innerException);
		}

		private void ThrowModuleReferenceException(Exception innerException)
		{
			throw new ModuleLoadException(Name, Resources.ReferencedAssemblyNotFound, innerException);
		}
	}

	private class ServiceMetadata
	{
		public readonly bool AddOnDemand;

		public readonly Type InstanceType;

		public readonly Type RegistrationType;

		public ServiceMetadata(Type instanceType, Type registrationType, bool addOnDemand)
		{
			InstanceType = instanceType;
			RegistrationType = registrationType;
			AddOnDemand = addOnDemand;
		}
	}

	private readonly Dictionary<Assembly, ModuleMetadata> loadedModules = new Dictionary<Assembly, ModuleMetadata>();

	private readonly TraceSource traceSource;

	public IList<LoadedModuleInfo> LoadedModules
	{
		get
		{
			List<LoadedModuleInfo> list = new List<LoadedModuleInfo>();
			foreach (ModuleMetadata value in loadedModules.Values)
			{
				list.Add(value.ToLoadedModuleInfo());
			}
			return list.AsReadOnly();
		}
	}

	public event EventHandler<DataEventArgs<LoadedModuleInfo>> ModuleLoaded;

	[InjectionConstructor]
	public ModuleLoaderService([ClassNameTraceSource] TraceSource traceSource)
	{
		this.traceSource = traceSource;
	}

	public void Load(WorkItem workItem, params IModuleInfo[] modules)
	{
		Guard.ArgumentNotNull(workItem, "workItem");
		Guard.ArgumentNotNull(modules, "modules");
		InnerLoad(workItem, modules);
	}

	public void Load(WorkItem workItem, params Assembly[] assemblies)
	{
		Guard.ArgumentNotNull(workItem, "workItem");
		Guard.ArgumentNotNull(assemblies, "assemblies");
		List<IModuleInfo> list = new List<IModuleInfo>();
		foreach (Assembly assembly in assemblies)
		{
			list.Add(new ModuleInfo(assembly));
		}
		InnerLoad(workItem, list.ToArray());
	}

	protected virtual void OnModuleLoaded(LoadedModuleInfo module)
	{
		if (this.ModuleLoaded != null)
		{
			this.ModuleLoaded(this, new DataEventArgs<LoadedModuleInfo>(module));
		}
	}

	private void InnerLoad(WorkItem workItem, IModuleInfo[] modules)
	{
		if (modules.Length == 0)
		{
			return;
		}
		LoadAssemblies(modules);
		List<ModuleMetadata> loadOrder = GetLoadOrder();
		foreach (ModuleMetadata item in loadOrder)
		{
			item.LoadServices(workItem);
		}
		foreach (ModuleMetadata item2 in loadOrder)
		{
			item2.InitializeModuleClasses(workItem);
		}
		foreach (ModuleMetadata item3 in loadOrder)
		{
			item3.InitializeWorkItemExtensions(workItem);
		}
		foreach (ModuleMetadata item4 in loadOrder)
		{
			item4.NotifyOfLoadedModule(OnModuleLoaded);
		}
	}

	private List<ModuleMetadata> GetLoadOrder()
	{
		Dictionary<string, ModuleMetadata> dictionary = new Dictionary<string, ModuleMetadata>();
		ModuleDependencySolver moduleDependencySolver = new ModuleDependencySolver();
		List<ModuleMetadata> list = new List<ModuleMetadata>();
		foreach (ModuleMetadata value in loadedModules.Values)
		{
			if (dictionary.ContainsKey(value.Name))
			{
				throw new ModuleLoadException(string.Format(CultureInfo.CurrentCulture, Resources.DuplicatedModule, new object[1] { value.Name }));
			}
			dictionary.Add(value.Name, value);
			moduleDependencySolver.AddModule(value.Name);
			foreach (string dependency in value.Dependencies)
			{
				moduleDependencySolver.AddDependency(value.Name, dependency);
			}
		}
		if (moduleDependencySolver.ModuleCount > 0)
		{
			string[] array = moduleDependencySolver.Solve();
			for (int i = 0; i < array.Length; i++)
			{
				list.Add(dictionary[array[i]]);
			}
		}
		return list;
	}

	private void LoadAssemblies(IModuleInfo[] modules)
	{
		foreach (IModuleInfo moduleInfo in modules)
		{
			GuardLegalAssemblyFile(moduleInfo);
			Assembly assembly = LoadAssembly(moduleInfo.AssemblyFile);
			if (!loadedModules.ContainsKey(assembly))
			{
				loadedModules.Add(assembly, new ModuleMetadata(assembly, traceSource));
			}
		}
	}

	private Assembly LoadAssembly(string assemblyFile)
	{
		Guard.ArgumentNotNullOrEmptyString(assemblyFile, "assemblyFile");
		assemblyFile = GetModulePath(assemblyFile);
		FileInfo fileInfo = new FileInfo(assemblyFile);
		Assembly assembly = null;
		try
		{
			assembly = Assembly.LoadFrom(fileInfo.FullName);
		}
		catch (Exception ex)
		{
			throw new ModuleLoadException(assemblyFile, ex.Message, ex);
		}
		if (traceSource != null)
		{
			traceSource.TraceInformation(Resources.LogModuleAssemblyLoaded, fileInfo.FullName);
		}
		return assembly;
	}

	private string GetModulePath(string assemblyFile)
	{
		if (!Path.IsPathRooted(assemblyFile))
		{
			assemblyFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, assemblyFile);
		}
		return assemblyFile;
	}

	private void GuardLegalAssemblyFile(IModuleInfo modInfo)
	{
		Guard.ArgumentNotNull(modInfo, "modInfo");
		Guard.ArgumentNotNull(modInfo.AssemblyFile, "modInfo.AssemblyFile");
		string modulePath = GetModulePath(modInfo.AssemblyFile);
		if (!File.Exists(modulePath))
		{
			throw new ModuleLoadException(string.Format(CultureInfo.CurrentCulture, Resources.ModuleNotFound, new object[1] { modulePath }));
		}
	}
}
