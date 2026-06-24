using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Extras.DynamicProxy;
using Autofac.Features.Metadata;
using Castle.DynamicProxy;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Actions.Impl;
using EleWise.ELMA.ActorModel;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Cache.Modules;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Hubs;
using EleWise.ELMA.Hubs.Attributes;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Licensing.Impl;
using EleWise.ELMA.Licensing.Storages;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Remoting;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Cache;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Extensions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Interceptors;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Impl;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ComponentModel;

public class ComponentManager : IComponentManager, IDisposable
{
	protected internal class RegistrationData
	{
		public List<Assembly> Assemblies;

		public List<Assembly> DisabledAssemblies;

		public readonly List<object> ComponentsToRegister;

		public readonly List<Type> ComponentsTypesToIgnore;

		public readonly List<Type> ComponentsTypesToRegister;

		public readonly List<Type> ExtensionPointsToRegister;

		public readonly List<Type> ServiceTypesToRegister;

		internal static RegistrationData N4LL1D8re4aLINfWcO1S;

		public RegistrationData()
		{
			//Discarded unreachable code: IL_009a, IL_009f
			SingletonReader.JJCZtPuTvSt();
			Assemblies = new List<Assembly>();
			DisabledAssemblies = new List<Assembly>();
			ComponentsToRegister = new List<object>();
			ComponentsTypesToIgnore = new List<Type>();
			ComponentsTypesToRegister = new List<Type>();
			ExtensionPointsToRegister = new List<Type>();
			ServiceTypesToRegister = new List<Type>();
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

		internal static bool DMBKVc8rPugLrsgjIwmd()
		{
			return N4LL1D8re4aLINfWcO1S == null;
		}

		internal static RegistrationData BhT4xs8r1tZyTkbJSUcS()
		{
			return N4LL1D8re4aLINfWcO1S;
		}
	}

	public enum LifetimeStage
	{
		BeforeInit,
		Initializing,
		InitCompleting,
		Initialized,
		Disposed
	}

	private bool disposed;

	protected internal RegistrationData registrationData;

	protected readonly List<Assembly> componentAssemblies;

	protected readonly List<Assembly> processedAssemblies;

	protected readonly List<object> components;

	protected readonly List<Type> componentTypes;

	protected readonly Dictionary<Type, List<Type>> extensionPointTypesMap;

	protected readonly Dictionary<Type, List<Type>> extensionPointTypesMapShell;

	protected Dictionary<Type, List<Type>> extensionPointTypesMapToAdd;

	protected ContainerBuilder initBuilder;

	private string[] _assembliesPaths;

	private bool _assembliesLoaded;

	private static readonly List<Tuple<Type, string, Type>> attributeMethodInterceptors;

	private static readonly List<Tuple<Type, string, Type>> typeInterceptors;

	private static readonly List<Tuple<Type, string>> requiredInterceptors;

	private static readonly List<string> interceptorNames;

	private static ComponentManager _current;

	private static readonly IDictionary<string, Assembly> assembliesByName;

	private static readonly IDictionary<string, Assembly> assembliesByFullName;

	private static readonly IDictionary<Assembly, MemoryStream> assemblyRaws;

	private static readonly IDictionary<Assembly, string> assemblyShortNames;

	private static readonly IDictionary<Assembly, string> assemblyFullNames;

	private static readonly IDictionary<Assembly, string> assemblyLocations;

	private static readonly IDictionary<Assembly, byte[]> assemblyPublicKeys;

	private static readonly IDictionary<Assembly, bool> assemblyIsModelResults;

	private static (Type interfaceType, Type implementationType)[] actorTypes;

	private static (Type interfaceType, Type implementationType)[] hubTypes;

	private ContainerBuilder preInitBuilder;

	private readonly ComponentType componentType;

	private readonly IStartControl startControl;

	private IContainer currentContainer;

	private LifetimeStage stage;

	private AssemblyInfoCache assemblyInfoCache;

	private readonly List<Tuple<Type, object>> shellComponents;

	private readonly List<Type> shellServices;

	private ApplicationStartCache applicationStartCache;

	private Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>> interceptorsToRegister;

	private IRuntimeApplication runtimeApplication;

	private string workDirectory;

	private LicenseManager licenseManager;

	private IModuleManager moduleManager;

	private readonly PackageService packageService;

	private bool initializeTerminatedByLicense;

	private bool cacheEnabled;

	private readonly ConcurrentDictionary<Type, bool> cacheAvailability;

	private readonly ConcurrentDictionary<Type, object> cache;

	internal static ComponentManager QJMBdufvrLQnbvJUYYZb;

	public static ComponentManager Current
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					throw new NotInitializedException((string)oB6VAWfvjUcykXtDN2xn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F043FC)));
				case 1:
					if (_current != null)
					{
						return _current;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public static bool Initialized => _current != null;

	public static ContainerBuilder Builder
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (UHpgitf8qjb4qfO8dayD() == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 0;
						}
						break;
					}
					return ((ComponentManager)UHpgitf8qjb4qfO8dayD()).initBuilder;
				default:
					return null;
				}
			}
		}
	}

	public static IEnumerable<(Type interfaceType, Type implementationType)> ActorTypes
	{
		get
		{
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Expected O, but got Unknown
			_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals0;
			if (actorTypes == null)
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_0();
				CS_0024_003C_003E8__locals0.additionalAssemblyWithActors = new string[9]
				{
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87133725),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978141424),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103ACF53),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542652755),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088098932),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A0DC45),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538524150),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -881920090),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -542050959)
				};
				actorTypes = (from t in AppDomain.CurrentDomain.GetAssemblies().Where(ShouldGenerateCodeForAssembly).SelectMany(delegate(Assembly a)
					{
						try
						{
							return a.GetTypes();
						}
						catch (ReflectionTypeLoadException ex)
						{
							string text = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218549832), ex.LoaderExceptions.Select((Exception e) => e.ToString()).ToArray());
							string message = z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x54889FDE) + a.FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138169018) + text;
							Logger.Log.Error(message, ex);
							throw;
						}
					})
						.Where(delegate(Type t)
						{
							//Discarded unreachable code: IL_0068, IL_0077
							int num3 = 2;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return !t.IsAbstract;
								case 1:
									return false;
								case 2:
									if (!_003C_003Ec.p0to0q8r4vDsnxUQjfRL(typeof(Actor).TypeHandle).IsAssignableFrom(t))
									{
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
										{
											num4 = 1;
										}
										break;
									}
									goto default;
								}
							}
						})
					select (t.GetInterfaces().Where(ActorInterfaceUtils.IsActorInterface).FirstOrDefault(), t) into p
					where p.interfaceType != null
					select p).ToArray();
				if (Locator.Initialized)
				{
					ContainerBuilder val = new ContainerBuilder();
					(Type, Type)[] array = actorTypes;
					for (int i = 0; i < array.Length; i++)
					{
						(Type, Type) tuple = array[i];
						RegistrationExtensions.PropertiesAutowired<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.AsSelf<object, ConcreteReflectionActivatorData>(RegistrationExtensions.RegisterType(val, tuple.Item2)).As(new Type[1] { tuple.Item1 }), (PropertyWiringOptions)1);
					}
					val.Update(Locator.GetServiceNotNull<IContainer>());
				}
			}
			return actorTypes;
			bool ShouldGenerateCodeForAssembly(Assembly assembly)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (!_003C_003Ec__DisplayClass20_0.mxdRbS8rrO4tAdxlVwEe(assembly))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					default:
						if (assembly.GetCustomAttribute<GeneratedCodeAttribute>() == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
							{
								num2 = 2;
							}
							continue;
						}
						break;
					case 2:
						return CS_0024_003C_003E8__locals0.additionalAssemblyWithActors.Contains(((AssemblyName)_003C_003Ec__DisplayClass20_0.POVukQ8rgQH2jTn5jkk4(assembly)).Name);
					}
					break;
				}
				return false;
			}
		}
	}

	internal static IEnumerable<(Type interfaceType, Type implementationType)> HubTypes
	{
		get
		{
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			if (hubTypes == null)
			{
				hubTypes = (from type in AppDomain.CurrentDomain.GetAssemblies().Where(ShouldGenerateCodeForAssembly).SelectMany(delegate(Assembly assembly)
					{
						try
						{
							return assembly.GetTypes();
						}
						catch (ReflectionTypeLoadException ex)
						{
							string text = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECD631C), ex.LoaderExceptions.Select((Exception e) => e.ToString()).ToArray());
							string message = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C97A4E0) + assembly.FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217498617) + text;
							Logger.Log.Error(message, ex);
							throw;
						}
					})
						.Where(delegate(Type type)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return _003C_003Ec.Ljqoco8rHEY45IxNiSyn(type, typeof(HubBase<>));
								case 1:
									if (type.IsAbstract)
									{
										return false;
									}
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						})
					select (type.GetInterfaces().Where(HubInterfaceUtils.IsHubInterface).FirstOrDefault(), type) into information
					where information.interfaceType != null
					select information).ToArray();
				if (Locator.Initialized)
				{
					ContainerBuilder val = new ContainerBuilder();
					(Type, Type)[] array = hubTypes;
					for (int i = 0; i < array.Length; i++)
					{
						(Type, Type) tuple = array[i];
						RegistrationExtensions.PropertiesAutowired<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.AsSelf<object, ConcreteReflectionActivatorData>(RegistrationExtensions.RegisterType(val, tuple.Item2)).As(tuple.Item2.GetInterfaces()), (PropertyWiringOptions)1);
					}
					val.Update(Locator.GetServiceNotNull<IContainer>());
				}
			}
			return hubTypes;
			static bool ShouldGenerateCodeForAssembly(Assembly assembly)
			{
				//Discarded unreachable code: IL_0035, IL_0044, IL_0090
				int num = 4;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 2:
							return assembly.GetCustomAttribute<GeneratedCodeAttribute>() == null;
						default:
							return false;
						case 1:
							if (!_003C_003Ec.OXsyoJ8r6369VvmJ2EfQ(assembly, _003C_003Ec.p0to0q8r4vDsnxUQjfRL(typeof(ComponentAssemblyAttribute).TypeHandle), false))
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
								{
									num2 = 0;
								}
								continue;
							}
							goto case 2;
						case 4:
							if (assembly.IsDynamic)
							{
								break;
							}
							goto case 1;
						}
						break;
					}
					num = 3;
				}
			}
		}
	}

	public LifetimeStage Stage => stage;

	public string WorkDirectory => workDirectory;

	public ILicenseManager LicenseManager => licenseManager;

	public IModuleManager ModuleManager => moduleManager;

	public PackageService PackageService => packageService;

	public ComponentType ComponentType => componentType;

	public IEnumerable<IActivationKeyStorage> ActivationKeyStorages { get; set; }

	public string[] AssemblyPaths => _assembliesPaths;

	protected static ILogger log => Logger.Log;

	public static Assembly LoadAssembly(byte[] assemblyRaw)
	{
		return (Assembly)ajNSXxfvLetrW0lfpyqb(rmS4nRfvYnQowt8RKw6Y(assemblyRaw, false), null);
	}

	public static Assembly LoadAssembly(string assemblyPath)
	{
		//Discarded unreachable code: IL_005a, IL_00e2, IL_0122, IL_012d, IL_013c, IL_0171, IL_01f9, IL_0218, IL_0227, IL_0244
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		FileStream fileStream = default(FileStream);
		MemoryStream memoryStream2 = default(MemoryStream);
		FileStream fileStream2 = default(FileStream);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 6:
				try
				{
					memoryStream = MemoryHelper.GetMemoryStream((int)nqrMNBfvsYqLRb8dCEKG(fileStream));
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						default:
							sLdQBBfvzH8cyZvmUkMb(memoryStream, 0L, SeekOrigin.Begin);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							SK5GEgfvc1bJ2EjpDtgL(fileStream, memoryStream);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				finally
				{
					int num4;
					if (fileStream == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num4 = 0;
						}
						goto IL_00e6;
					}
					goto IL_00fc;
					IL_00fc:
					GZq6Oaf8FISSCf4iMf0C(fileStream);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num4 = 1;
					}
					goto IL_00e6;
					IL_00e6:
					switch (num4)
					{
					default:
						goto end_IL_00c1;
					case 2:
						break;
					case 0:
						goto end_IL_00c1;
					case 1:
						goto end_IL_00c1;
					}
					goto IL_00fc;
					end_IL_00c1:;
				}
				break;
			case 7:
				try
				{
					memoryStream2 = (MemoryStream)FoVNpRf8oMBqyZSXryE6((int)nqrMNBfvsYqLRb8dCEKG(fileStream2));
					int num5 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num5 = 2;
					}
					while (true)
					{
						switch (num5)
						{
						case 2:
							SK5GEgfvc1bJ2EjpDtgL(fileStream2, memoryStream2);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
							{
								num5 = 1;
							}
							continue;
						case 1:
							sLdQBBfvzH8cyZvmUkMb(memoryStream2, 0L, SeekOrigin.Begin);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
							{
								num5 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					int num6;
					if (fileStream2 == null)
					{
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num6 = 1;
						}
						goto IL_01fd;
					}
					goto IL_0232;
					IL_0232:
					GZq6Oaf8FISSCf4iMf0C(fileStream2);
					num6 = 2;
					goto IL_01fd;
					IL_01fd:
					switch (num6)
					{
					case 1:
						goto end_IL_01d8;
					case 2:
						goto end_IL_01d8;
					}
					goto IL_0232;
					end_IL_01d8:;
				}
				goto case 8;
			case 5:
				fileStream2 = new FileStream(text, FileMode.Open, FileAccess.Read);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 7;
				}
				continue;
			default:
				fileStream = new FileStream(assemblyPath, FileMode.Open, FileAccess.Read);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 1;
				}
				continue;
			case 8:
				return (Assembly)ajNSXxfvLetrW0lfpyqb(memoryStream, memoryStream2);
			case 3:
				if (fCv9KKfvUqj26fb31diw(text))
				{
					num2 = 5;
					continue;
				}
				goto case 8;
			case 4:
				memoryStream2 = null;
				num2 = 3;
				continue;
			case 1:
				if (!fCv9KKfvUqj26fb31diw(assemblyPath))
				{
					return null;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				break;
			}
			text = (string)xFOOAUf8WGtTJQHqHNVa(assemblyPath, wCv31Xf8BDT6klkASJPg(-1411196499 ^ -1411323563));
			num2 = 4;
		}
	}

	internal static Assembly LoadAssemblyWithLock(ILockService lockService, string assemblyName, bool isFullName, byte[] assemblyRaw, byte[] debugRaw)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_010b, IL_0159, IL_01a2, IL_01c1, IL_01ed, IL_01fc, IL_020c, IL_021b
		int num = 5;
		int num2 = num;
		ILock @lock = default(ILock);
		Assembly result = default(Assembly);
		Assembly assembly = default(Assembly);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (!(assembly != null))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			default:
				return assembly;
			case 3:
				if (isFullName)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			case 7:
				return (Assembly)PMS0jff8hmwqAq23WOsK(assemblyRaw, debugRaw);
			case 1:
				@lock = lockService.AcquireLock(assemblyName);
				num2 = 2;
				break;
			case 5:
				assembly = (Assembly)dGstXOf8bmTXQR0gWfP3(assemblyName, isFullName);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				return result;
			case 2:
				try
				{
					assembly = (Assembly)dGstXOf8bmTXQR0gWfP3(assemblyName, true);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						Assembly assembly2;
						switch (num3)
						{
						default:
							return result;
						case 0:
							return result;
						case 1:
							if (!RFH3yXf8G144TwqweIOi(assembly, null))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
								{
									num3 = 2;
								}
								continue;
							}
							assembly2 = assembly;
							break;
						case 2:
							assembly2 = LoadAssembly(assemblyRaw, debugRaw);
							break;
						}
						result = assembly2;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num3 = 0;
						}
					}
				}
				finally
				{
					int num4;
					if (@lock == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num4 = 0;
						}
						goto IL_01a6;
					}
					goto IL_01cb;
					IL_01cb:
					@lock.Dispose();
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num4 = 0;
					}
					goto IL_01a6;
					IL_01a6:
					switch (num4)
					{
					default:
						goto end_IL_0181;
					case 0:
						goto end_IL_0181;
					case 2:
						break;
					case 1:
						goto end_IL_0181;
					}
					goto IL_01cb;
					end_IL_0181:;
				}
			}
		}
	}

	public static Assembly LoadAssembly(byte[] assemblyRaw, byte[] debugRaw)
	{
		//Discarded unreachable code: IL_004a
		int num = 1;
		int num2 = num;
		object assemblyRaw2;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (assemblyRaw == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				assemblyRaw2 = rmS4nRfvYnQowt8RKw6Y(assemblyRaw, false);
				break;
			default:
				assemblyRaw2 = null;
				break;
			}
			break;
		}
		MemoryStream debugRaw2 = ((debugRaw != null) ? MemoryHelper.GetMemoryStream(debugRaw, writable: false) : null);
		return LoadAssembly((MemoryStream)assemblyRaw2, debugRaw2);
	}

	public static Assembly LoadAssembly(MemoryStream assemblyRaw, MemoryStream debugRaw)
	{
		//Discarded unreachable code: IL_007b, IL_00b7
		int num = 3;
		Assembly assembly = default(Assembly);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 5:
					assembliesByFullName[(string)x64lvJf8v6CF4oxdDeL5(assembly)] = assembly;
					num2 = 6;
					continue;
				case 6:
					assembliesByName[(string)n9g3yIf88CaM0X95aYoX(assembly)] = assembly;
					num2 = 4;
					continue;
				case 4:
					return assembly;
				case 3:
					if (assemblyRaw != null)
					{
						goto end_IL_0012;
					}
					goto case 7;
				default:
					obj = RkCv57f8QQLg0Cwd5X11(jWxwSbf8fSObbiwFJuE8(OLJy54f8ET3bhgMLXCAm(assemblyRaw)), jWxwSbf8fSObbiwFJuE8(debugRaw));
					break;
				case 1:
					assemblyRaws[assembly] = (MemoryStream)kaxDhff8CmFtTDwlJshq(assemblyRaw);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					return null;
				case 2:
					if (debugRaw != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = Assembly.Load((byte[])jWxwSbf8fSObbiwFJuE8(OLJy54f8ET3bhgMLXCAm(assemblyRaw)));
					break;
				}
				assembly = (Assembly)obj;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	internal static void UpdateAssemblyRaw(Assembly assembly, MemoryStream assemblyRaw)
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
				assemblyRaws[assembly] = assemblyRaw.AsReadOnly();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static byte[] GetLoadedAssemblyRaw(Assembly assembly)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				object obj = nPjKSNf8ZLZ15ThUoVfp(assembly);
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (byte[])jWxwSbf8fSObbiwFJuE8(obj);
			}
			default:
				return null;
			}
		}
	}

	public static MemoryStream GetLoadedAssemblyRawAsStream(Assembly assembly)
	{
		int num = 1;
		int num2 = num;
		MemoryStream value = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (MLUjBmf8uveewmtmyNK1(assembly, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				assemblyRaws.TryGetValue(assembly, out value);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return null;
			case 2:
				return value;
			}
		}
	}

	public static Assembly[] GetAssemblies()
	{
		return (Assembly[])v5Q9sxf8V01q5Iw9Niyo(T4L9EQf8IXdhwhUHsXDu());
	}

	public static Assembly[] GetAssemblies(AppDomain domain)
	{
		//Discarded unreachable code: IL_005d, IL_006c
		int num = 4;
		int num2 = num;
		while (true)
		{
			AppDomain appDomain;
			switch (num2)
			{
			case 2:
				if (_current != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 1:
				if (_current.moduleManager != null)
				{
					num2 = 5;
					break;
				}
				goto default;
			case 4:
				appDomain = domain;
				if (appDomain == null)
				{
					num2 = 3;
					break;
				}
				goto IL_00a7;
			case 3:
				appDomain = AppDomain.CurrentDomain;
				goto IL_00a7;
			default:
				return (Assembly[])zdh7Gvf8SStPvj8tRfiU(domain);
			case 5:
				{
					return (from a in domain.GetAssemblies()
						where _current.moduleManager.IsAssemblyAvailable(a)
						select a).ToArray();
				}
				IL_00a7:
				domain = appDomain;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public static bool IsModelAssembly(Assembly assembly)
	{
		//Discarded unreachable code: IL_00e8
		int num = 2;
		int num2 = num;
		bool value = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 4:
				value = QW7fFif8RUT9OOfShLAn(assembly, fq0cNOf8iuVHvsiP5PGY(typeof(ModelAssemblyAttribute).TypeHandle), false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				throw new ArgumentNullException((string)wCv31Xf8BDT6klkASJPg(-1217523399 ^ -1217502121));
			default:
				assemblyIsModelResults[assembly] = value;
				num2 = 3;
				break;
			case 3:
			case 5:
				return value;
			case 2:
				if (!MLUjBmf8uveewmtmyNK1(assembly, null))
				{
					if (assemblyIsModelResults.TryGetValue(assembly, out value))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 4;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public ComponentManager(ComponentType componentType, ContainerBuilder containerBuilder = null)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		q9Em1cf8KGVrygmCgNB8();
		this._002Ector(componentType, null, containerBuilder);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ComponentManager(ComponentType componentType, IStartControl startControl, ContainerBuilder containerBuilder = null)
	{
		//Discarded unreachable code: IL_00ce
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		q9Em1cf8KGVrygmCgNB8();
		registrationData = new RegistrationData();
		componentAssemblies = new List<Assembly>();
		processedAssemblies = new List<Assembly>();
		components = new List<object>();
		componentTypes = new List<Type>();
		extensionPointTypesMap = new Dictionary<Type, List<Type>>();
		extensionPointTypesMapShell = new Dictionary<Type, List<Type>>();
		shellComponents = new List<Tuple<Type, object>>();
		shellServices = new List<Type>();
		cacheAvailability = new ConcurrentDictionary<Type, bool>();
		cache = new ConcurrentDictionary<Type, object>();
		base._002Ector();
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				MDhNfRf8XTOyqDV7LOcj(T4L9EQf8IXdhwhUHsXDu(), new ResolveEventHandler(CurrentDomainAssemblyResolve));
				num2 = 2;
				break;
			case 3:
				packageService = new PackageService();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				this.componentType = componentType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 2:
				zNG16vf8TI2LJqYeDHPf(T4L9EQf8IXdhwhUHsXDu(), new ResolveEventHandler(CurrentDomainReflectionOnlyAssemblyResolve));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				extensionPointTypesMapToAdd = extensionPointTypesMap;
				num2 = 3;
				break;
			default:
				this.startControl = startControl ?? new DoNothingStartControl();
				num2 = 4;
				break;
			case 4:
				preInitBuilder = (ContainerBuilder)(((object)containerBuilder) ?? ((object)new ContainerBuilder()));
				num2 = 7;
				break;
			}
		}
	}

	public IEnumerable<T> GetComponentsForRegister<T>()
	{
		if (stage != 0)
		{
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867388763), stage));
		}
		return registrationData.ComponentsToRegister.OfType<T>().ToList();
	}

	public void InitLicensing(string[] assembliesPaths, [NotNull] string workingDirectory)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				InitLicensing(assembliesPaths, workingDirectory, onlyLoadedAssemblies: false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void InitLicensing(string[] assembliesPaths, [NotNull] string workingDirectory, bool onlyLoadedAssemblies)
	{
		//Discarded unreachable code: IL_0055, IL_0064, IL_00cc, IL_021a, IL_0229, IL_028e, IL_029d, IL_02a9, IL_03bf, IL_03ce
		int num = 4;
		RemoteServiceProvider remoteServiceProvider = default(RemoteServiceProvider);
		IRuntimeApplication runtimeApplication = default(IRuntimeApplication);
		IStartInformation startInformation = default(IStartInformation);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					try
					{
						int num3;
						if (licenseManager != null)
						{
							num3 = 12;
							goto IL_0089;
						}
						goto IL_01a8;
						IL_0089:
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 4:
								if (GLLOL4f8PFRD0nvCwcOm(Ywh3E7f8esDbbESNlstN(packageService)))
								{
									num4 = 5;
									goto IL_0085;
								}
								goto case 7;
							case 5:
							case 9:
								moduleManager = new ModuleManager(registrationData.Assemblies, packageService, remoteServiceProvider, runtimeApplication);
								num3 = 8;
								continue;
							case 7:
								HBYsiLf81Ud8SNSZpPdy(packageService);
								num3 = 9;
								continue;
							case 2:
							case 12:
								CheckLicensing();
								num3 = 10;
								continue;
							default:
								startInformation.Message = (string)zCdDexf8Ov8Ow1CLnVht(wCv31Xf8BDT6klkASJPg(0x103FE975 ^ 0x103AC18B));
								num3 = 3;
								continue;
							case 8:
								zaKxIrf8NQ2IJrNHDgOr(licenseManager);
								num4 = 2;
								goto IL_0085;
							case 1:
								runtimeApplication = registrationData.ComponentsToRegister.OfType<IRuntimeApplication>().FirstOrDefault();
								num3 = 4;
								continue;
							case 6:
								break;
							case 3:
								remoteServiceProvider = registrationData.ComponentsToRegister.OfType<RemoteServiceProvider>().FirstOrDefault();
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
								{
									num3 = 1;
								}
								continue;
							case 11:
								licenseManager = new LicenseManager(ActivationKeyStorages);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
								{
									num3 = 0;
								}
								continue;
							case 10:
								return;
								IL_0085:
								num3 = num4;
								continue;
							}
							break;
						}
						goto IL_01a8;
						IL_01a8:
						LoadAssemblies(onlyLoadedAssemblies);
						num3 = 11;
						goto IL_0089;
					}
					finally
					{
						int num5;
						if (startInformation == null)
						{
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
							{
								num5 = 0;
							}
							goto IL_025e;
						}
						goto IL_0274;
						IL_0274:
						GZq6Oaf8FISSCf4iMf0C(startInformation);
						int num6 = 2;
						num5 = num6;
						goto IL_025e;
						IL_025e:
						switch (num5)
						{
						default:
							goto end_IL_0239;
						case 1:
							break;
						case 0:
							goto end_IL_0239;
						case 2:
							goto end_IL_0239;
						}
						goto IL_0274;
						end_IL_0239:;
					}
				case 5:
					return;
				case 3:
					Tv4ncrf8kNlRhOhmeKEG(workingDirectory, wCv31Xf8BDT6klkASJPg(-1852837372 ^ -1853171180));
					num2 = 9;
					continue;
				case 11:
					throw new InvalidOperationException(SR.T((string)wCv31Xf8BDT6klkASJPg(-16752921 ^ -16419117), stage));
				case 12:
					_assembliesPaths = (string[])pg5KxNf8n9c69kdxEpZb(assembliesPaths);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (Directory.Exists(workingDirectory))
					{
						num2 = 2;
						continue;
					}
					goto case 10;
				case 7:
					startInformation = (IStartInformation)OB3ZKXf82AiHB1c8go0f(7.0, zCdDexf8Ov8Ow1CLnVht(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8345CEE)));
					num2 = 6;
					continue;
				case 1:
				case 2:
					_current = this;
					num2 = 7;
					continue;
				case 10:
					Directory.CreateDirectory(workingDirectory);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					Tv4ncrf8kNlRhOhmeKEG(assembliesPaths, wCv31Xf8BDT6klkASJPg(0x53CACA3 ^ 0x5398B4D));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					if (stage == LifetimeStage.BeforeInit)
					{
						num2 = 12;
						continue;
					}
					goto case 11;
				}
				break;
			}
			workDirectory = workingDirectory;
			num = 8;
		}
	}

	public void LoadAssemblies(string[] assembliesPaths)
	{
		//Discarded unreachable code: IL_003a
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 3:
				Tv4ncrf8kNlRhOhmeKEG(assembliesPaths, wCv31Xf8BDT6klkASJPg(0x307E9FD1 ^ 0x307BB83F));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (stage == LifetimeStage.BeforeInit)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 1:
				LoadAssemblies(onlyLoadedAssemblies: false);
				num2 = 4;
				break;
			case 5:
				throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583931468), stage));
			default:
				_assembliesPaths = GetAssembliesPathsWithArchitecture(assembliesPaths);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Init(string[] assembliesPaths, [NotNull] string workingDirectory)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				Init(assembliesPaths, workingDirectory, null, null, null);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				Tv4ncrf8kNlRhOhmeKEG(workingDirectory, wCv31Xf8BDT6klkASJPg(0x31326106 ^ 0x31374916));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Init(string[] assembliesPaths, [NotNull] string workingDirectory, Type[] componentTypesToRegister, Type[] extensionPointsToRegister, Type[] servicesToRegister)
	{
		//Discarded unreachable code: IL_011c
		int num = 11;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 7:
				case 9:
					InitLicensing(assembliesPaths, workingDirectory);
					num2 = 4;
					break;
				default:
					if (extensionPointsToRegister != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 6;
				case 11:
					Tv4ncrf8kNlRhOhmeKEG(workingDirectory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979569119));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 9;
					}
					break;
				case 6:
					if (servicesToRegister == null)
					{
						goto end_IL_0012;
					}
					goto case 8;
				case 4:
					gU1fdof83wfgD06oHiei(this);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					break;
				case 8:
					registrationData.ServiceTypesToRegister.AddRange(servicesToRegister);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 9;
					}
					break;
				case 10:
					if (stage != 0)
					{
						num2 = 5;
						break;
					}
					if (componentTypesToRegister != null)
					{
						num2 = 3;
						break;
					}
					goto default;
				case 3:
					registrationData.ComponentsTypesToRegister.AddRange(componentTypesToRegister);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					registrationData.ExtensionPointsToRegister.AddRange(extensionPointsToRegister);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 6;
					}
					break;
				case 5:
					throw new InvalidOperationException(SR.T((string)wCv31Xf8BDT6klkASJPg(0xE1229CF ^ 0xE170025), stage));
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	public void ResumeInit()
	{
		//Discarded unreachable code: IL_0039, IL_0048
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					Init();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					CheckLicensing();
					num2 = 2;
					break;
				case 0:
					return;
				case 5:
					if (initializeTerminatedByLicense)
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 1:
					throw new InvalidOperationException((string)oB6VAWfvjUcykXtDN2xn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426412103)));
				case 4:
					initializeTerminatedByLicense = false;
					num2 = 3;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public ComponentManager RegisterComponent(object component)
	{
		//Discarded unreachable code: IL_0037
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return this;
			case 1:
				if (stage == LifetimeStage.BeforeInit)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 4;
			case 4:
				if (stage != LifetimeStage.Initializing)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 2:
				throw new InvalidOperationException(SR.T((string)wCv31Xf8BDT6klkASJPg(0xA592A41 ^ 0xA5C0113), stage));
			}
			registrationData.ComponentsToRegister.Add(component);
			num2 = 3;
		}
	}

	public ComponentManager IgnoreComponentType(Type ignoreComponentType)
	{
		//Discarded unreachable code: IL_005c, IL_006b
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return this;
			case 1:
				if (stage == LifetimeStage.BeforeInit)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 3:
				throw new InvalidOperationException(SR.T((string)wCv31Xf8BDT6klkASJPg(-606654180 ^ -606986946), stage));
			default:
				registrationData.ComponentsTypesToIgnore.Add(ignoreComponentType);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				if (stage != LifetimeStage.Initializing)
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	public ComponentManager RegisterAssembly(Assembly assembly)
	{
		//Discarded unreachable code: IL_00e4, IL_0119, IL_0128, IL_0138
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 8:
				if (stage != LifetimeStage.Initializing)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 4;
			case 1:
			case 3:
				ProcessAssembly(assembly, checkComponentAttribute: false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				throw new InvalidOperationException(SR.T((string)wCv31Xf8BDT6klkASJPg(0x3CE17B75 ^ 0x3CE45783), stage));
			case 4:
				if (stage != 0)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			case 5:
				if (stage == LifetimeStage.BeforeInit)
				{
					num2 = 4;
					continue;
				}
				goto case 8;
			case 7:
				break;
			}
			AddAssembly(assembly);
			num2 = 6;
		}
	}

	public void UpdateContainer()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				preInitBuilder = initBuilder;
				num2 = 3;
				break;
			case 4:
				initBuilder = new ContainerBuilder();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FAE69D), stage));
			case 2:
				if (stage == LifetimeStage.Initializing)
				{
					r87KH2f8pPCgu5NM7KpL(initBuilder, currentContainer);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 1;
					}
				}
				break;
			case 3:
				return;
			}
		}
	}

	public T GetExtensionPointByType<T>()
	{
		object extensionPointByType = GetExtensionPointByType(typeof(T));
		if (!(extensionPointByType is T))
		{
			return default(T);
		}
		return (T)extensionPointByType;
	}

	public object GetExtensionPointByType(Type type)
	{
		int num = 1;
		int num2 = num;
		object result = default(object);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 3:
				throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281656628), stage));
			case 4:
				if (stage != LifetimeStage.Initialized)
				{
					num2 = 3;
					break;
				}
				goto IL_0063;
			case 1:
				if (stage != LifetimeStage.Initializing)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0063;
			default:
				{
					if (stage != LifetimeStage.InitCompleting)
					{
						num2 = 4;
						break;
					}
					goto IL_0063;
				}
				IL_0063:
				ResolutionExtensions.TryResolve((IComponentContext)(object)CurrentScope(), type, ref result);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public IEnumerable<T> GetExtensionPoints<T>()
	{
		return GetExtensionPointsInternal<T>();
	}

	public IEnumerable<T> GetExtensionPoints<T>(bool useCache)
	{
		if (useCache)
		{
			return GetExtensionPointsInternal<T>();
		}
		return GetExtensionPointsNonCached<T>();
	}

	public IEnumerable<Type> GetExtensionPointTypes(Type type)
	{
		if (!extensionPointTypesMap.TryGetValue(type, out var value) && !extensionPointTypesMapShell.TryGetValue(type, out value))
		{
			return EleWise.ELMA.Helpers.EmptyArray<Type>.Instance;
		}
		return value;
	}

	public IEnumerable<Type> GetExtensionPointTypes<T>()
	{
		return GetExtensionPointTypes(typeof(T));
	}

	public Type[] GetExtensionPointTypesArray(Type type)
	{
		return GetExtensionPointTypes(type).ToArray();
	}

	public Type[] GetXsiTypes()
	{
		return GetExtensionPointTypesArray(typeof(IXsiType));
	}

	public Type[] GetXsiRoots()
	{
		return GetExtensionPointTypesArray(fq0cNOf8iuVHvsiP5PGY(typeof(IXsiRoot).TypeHandle));
	}

	public void StartCache()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				cacheEnabled = true;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void ResetCache()
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
				gy6LMvf8aAA8sK6LetIh(cache);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Dispose()
	{
		//Discarded unreachable code: IL_0073, IL_0082
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				cUPMLcf8t8o2OHJEXnGT(this, true);
				num2 = 4;
				break;
			case 6:
				O8pAoYf8D1FNnpmN6Lde(T4L9EQf8IXdhwhUHsXDu(), new ResolveEventHandler(CurrentDomainAssemblyResolve));
				num2 = 7;
				break;
			case 5:
				return;
			case 3:
				return;
			case 1:
				disposed = true;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				if (disposed)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				GC.SuppressFinalize(this);
				num2 = 5;
				break;
			case 7:
				AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve -= CurrentDomainReflectionOnlyAssemblyResolve;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void Init()
	{
		//Discarded unreachable code: IL_0062, IL_00e5, IL_0104, IL_0130, IL_013f, IL_022c, IL_023b, IL_02c5, IL_02cf, IL_03a3, IL_03b6, IL_03c5, IL_04bc, IL_04f4, IL_0520, IL_0548, IL_0588, IL_0597, IL_05a3, IL_05c7, IL_0620, IL_062f, IL_0660, IL_0698
		int num = 2;
		IStartInformation startInformation2 = default(IStartInformation);
		IStartInformation startInformation = default(IStartInformation);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					try
					{
						stage = LifetimeStage.InitCompleting;
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								InvokeInitHandlers(delegate(IInitHandler h)
								{
									_003C_003Ec.AmkM3l8rAvvtRtS2jjNr(h);
								});
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
								{
									num3 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						int num4;
						if (startInformation2 == null)
						{
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
							{
								num4 = 0;
							}
							goto IL_00e9;
						}
						goto IL_010e;
						IL_010e:
						GZq6Oaf8FISSCf4iMf0C(startInformation2);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num4 = 0;
						}
						goto IL_00e9;
						IL_00e9:
						switch (num4)
						{
						default:
							goto end_IL_00c4;
						case 1:
							goto end_IL_00c4;
						case 2:
							break;
						case 0:
							goto end_IL_00c4;
						}
						goto IL_010e;
						end_IL_00c4:;
					}
					goto end_IL_0012;
				default:
					goto end_IL_0012;
				case 4:
					startInformation2 = StartInformation.Operation(99.0, SR.M((string)wCv31Xf8BDT6klkASJPg(0x53CACA3 ^ 0x5399C97)));
					num2 = 3;
					continue;
				case 1:
					try
					{
						QuZb1gf8wZgJPPqATKGy(startInformation, zCdDexf8Ov8Ow1CLnVht(wCv31Xf8BDT6klkASJPg(0x7E6E5A0B ^ 0x7E6B7579)));
						int num9 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num9 = 0;
						}
						while (true)
						{
							switch (num9)
							{
							case 1:
							{
								runtimeApplication = registrationData.ComponentsToRegister.OfType<IRuntimeApplication>().FirstOrDefault();
								int num10 = 3;
								num9 = num10;
								continue;
							}
							case 6:
								applicationStartCache = (ApplicationStartCache)iCXEMjf86FkZ4CMmCrMa(runtimeApplication);
								num9 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
								{
									num9 = 10;
								}
								continue;
							case 3:
								if (runtimeApplication == null)
								{
									num9 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
									{
										num9 = 9;
									}
									continue;
								}
								goto case 11;
							case 7:
								try
								{
									while (true)
									{
										IL_0335:
										int num11;
										if (!enumerator.MoveNext())
										{
											num11 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
											{
												num11 = 1;
											}
											goto IL_02d3;
										}
										goto IL_0312;
										IL_0312:
										current = enumerator.Current;
										num11 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
										{
											num11 = 0;
										}
										goto IL_02d3;
										IL_02d3:
										while (true)
										{
											switch (num11)
											{
											default:
												if (!applicationStartCache.InterceptorNames.Contains(current))
												{
													num11 = 4;
													continue;
												}
												goto IL_0335;
											case 3:
												break;
											case 2:
												goto IL_0335;
											case 4:
												applicationStartCache.InterceptorNames.Add(current);
												num11 = 2;
												continue;
											case 1:
												goto end_IL_0335;
											}
											break;
										}
										goto IL_0312;
										continue;
										end_IL_0335:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator).Dispose();
									int num12 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
									{
										num12 = 0;
									}
									switch (num12)
									{
									case 0:
										break;
									}
								}
								goto case 5;
							case 4:
								obs47Ef8HCmXygAAEXBM(this);
								num9 = 2;
								continue;
							case 10:
								if (applicationStartCache != null)
								{
									num9 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
									{
										num9 = 8;
									}
									continue;
								}
								goto case 5;
							case 5:
							case 9:
								QuZb1gf8wZgJPPqATKGy(startInformation, SR.M((string)wCv31Xf8BDT6klkASJPg(0x307E9FD1 ^ 0x307BB067)));
								num9 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
								{
									num9 = 4;
								}
								continue;
							case 11:
								xbaUumf84xps0wdtJv35(runtimeApplication);
								num9 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
								{
									num9 = 6;
								}
								continue;
							case 8:
								enumerator = interceptorNames.GetEnumerator();
								num9 = 7;
								continue;
							case 2:
								vHp45Ff8AxB2Ll7CoFDt(this);
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
								{
									num9 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						if (startInformation != null)
						{
							int num13 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
							{
								num13 = 1;
							}
							while (true)
							{
								switch (num13)
								{
								case 1:
									GZq6Oaf8FISSCf4iMf0C(startInformation);
									num13 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
									{
										num13 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					break;
				case 5:
					return;
				case 7:
					try
					{
						RegisterComponents();
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					finally
					{
						int num8;
						if (startInformation2 == null)
						{
							num8 = 2;
							goto IL_054c;
						}
						goto IL_0562;
						IL_054c:
						switch (num8)
						{
						default:
							goto end_IL_0537;
						case 1:
							break;
						case 2:
							goto end_IL_0537;
						case 0:
							goto end_IL_0537;
						}
						goto IL_0562;
						IL_0562:
						GZq6Oaf8FISSCf4iMf0C(startInformation2);
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num8 = 0;
						}
						goto IL_054c;
						end_IL_0537:;
					}
					goto case 4;
				case 8:
					try
					{
						int num5;
						if (applicationStartCache == null)
						{
							num5 = 2;
							goto IL_05cb;
						}
						goto IL_05f6;
						IL_05cb:
						while (true)
						{
							switch (num5)
							{
							case 3:
								return;
							case 1:
							case 2:
								goto IL_05e5;
							}
							break;
							IL_05e5:
							stage = LifetimeStage.Initialized;
							num5 = 3;
						}
						goto IL_05f6;
						IL_05f6:
						applicationStartCache.Save();
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num5 = 1;
						}
						goto IL_05cb;
					}
					finally
					{
						if (startInformation2 != null)
						{
							int num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									GZq6Oaf8FISSCf4iMf0C(startInformation2);
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
									{
										num6 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				case 2:
					startInformation = (IStartInformation)OB3ZKXf82AiHB1c8go0f(7.0, zCdDexf8Ov8Ow1CLnVht(wCv31Xf8BDT6klkASJPg(0x53CB464B ^ 0x53CE6E97)));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					break;
				}
				startInformation2 = StartInformation.Operation(91.0, (string)zCdDexf8Ov8Ow1CLnVht(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A36CE34)));
				num2 = 7;
				continue;
				end_IL_0012:
				break;
			}
			startInformation2 = StartInformation.Operation(99.0, (string)zCdDexf8Ov8Ow1CLnVht(wCv31Xf8BDT6klkASJPg(-1710575414 ^ -1710260150)));
			num = 8;
		}
	}

	protected virtual void RegisterComponents()
	{
		//Discarded unreachable code: IL_015d, IL_02b8, IL_02c7, IL_035d, IL_039d, IL_03ac, IL_03b8, IL_03c7, IL_046e, IL_047d, IL_0489, IL_0498, IL_04f8, IL_0507, IL_057f, IL_059e, IL_05ad, IL_05ca, IL_06e0, IL_06fc, IL_078b, IL_07f4, IL_0834, IL_0843, IL_0870, IL_08a8, IL_08b7, IL_0953, IL_098b, IL_09c3, IL_09d2, IL_0a39, IL_0a71, IL_0a80
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected O, but got Unknown
		int num = 10;
		int num2 = num;
		IStartInformation startInformation = default(IStartInformation);
		ILifetimeScope val = default(ILifetimeScope);
		ProxiesAssemblyActivator proxiesAssemblyActivator = default(ProxiesAssemblyActivator);
		while (true)
		{
			switch (num2)
			{
			case 10:
				startInformation = (IStartInformation)OB3ZKXf82AiHB1c8go0f(2.0, LZ008Nf8xmu585fmbT9g(AvZseCf87nQFXfGZQCuK()));
				num2 = 9;
				break;
			case 4:
				val = ((ILifetimeScope)currentContainer).BeginLifetimeScope(wCv31Xf8BDT6klkASJPg(0x26FFCB59 ^ 0x26FAFA47));
				num2 = 2;
				break;
			case 8:
				dKon21f89ADKk47U06VN(new LifetimeScopeAccessorLocatorImpl(currentContainer, ResolutionExtensions.Resolve<ILifetimeScopeAccessor>((IComponentContext)(object)currentContainer)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			default:
				preInitBuilder = null;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				registrationData = new RegistrationData();
				num2 = 4;
				break;
			case 3:
				stage = LifetimeStage.Initializing;
				num2 = 6;
				break;
			case 9:
				try
				{
					interceptorsToRegister = new Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>>();
					int num15 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num15 = 1;
					}
					while (true)
					{
						object dbPreUpdater2;
						switch (num15)
						{
						case 2:
							dbPreUpdater2 = null;
							break;
						default:
							interceptorsToRegister = null;
							num15 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
							{
								num15 = 4;
							}
							continue;
						case 1:
							if (runtimeApplication == null)
							{
								int num19 = 2;
								num15 = num19;
								continue;
							}
							dbPreUpdater2 = i5KsxUf80NLvuC9y1TJH(runtimeApplication);
							break;
						case 3:
							try
							{
								BTftcJf8mQJ0fJiLolaw(this, registrationData);
								int num16 = 6;
								while (true)
								{
									switch (num16)
									{
									case 7:
										S2Tp5lf8yImDLkmk4tjl(AvZseCf87nQFXfGZQCuK(), 95.0);
										num16 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
										{
											num16 = 2;
										}
										continue;
									case 5:
									case 8:
										RegistrationExtensions.RegisterInstance<LifetimeScopeAccessor>(preInitBuilder, new LifetimeScopeAccessor(() => (ILifetimeScope)(object)currentContainer)).As<ILifetimeScopeAccessor>().SingleInstance();
										num16 = 7;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
										{
											num16 = 7;
										}
										continue;
									case 4:
										if (packageService != null)
										{
											num16 = 3;
											continue;
										}
										goto default;
									default:
										if (moduleManager == null)
										{
											num16 = 8;
											continue;
										}
										break;
									case 3:
										RegistrationExtensions.RegisterInstance<PackageService>(preInitBuilder, packageService).As<PackageService>().SingleInstance();
										num16 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
										{
											num16 = 0;
										}
										continue;
									case 6:
										RegistrationExtensions.RegisterInstance<ComponentManager>(preInitBuilder, this).As<IComponentManager>().As<ComponentManager>()
											.SingleInstance();
										num16 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
										{
											num16 = 4;
										}
										continue;
									case 1:
										break;
									case 2:
										goto end_IL_01b7;
									}
									RegistrationExtensions.RegisterInstance<IModuleManager>(preInitBuilder, moduleManager).As<IModuleManager>().As<ModuleManager>()
										.SingleInstance();
									int num17 = 5;
									num16 = num17;
									continue;
									end_IL_01b7:
									break;
								}
							}
							finally
							{
								int num18;
								if (proxiesAssemblyActivator == null)
								{
									num18 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
									{
										num18 = 1;
									}
									goto IL_0361;
								}
								goto IL_0377;
								IL_0377:
								((IDisposable)proxiesAssemblyActivator).Dispose();
								num18 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
								{
									num18 = 0;
								}
								goto IL_0361;
								IL_0361:
								switch (num18)
								{
								default:
									goto end_IL_033c;
								case 1:
									break;
								case 2:
									goto end_IL_033c;
								case 0:
									goto end_IL_033c;
								}
								goto IL_0377;
								end_IL_033c:;
							}
							goto default;
						case 4:
							goto end_IL_0139;
						}
						proxiesAssemblyActivator = new ProxiesAssemblyActivator((DbPreUpdater)dbPreUpdater2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A2D382), interceptorsToRegister);
						num15 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num15 = 3;
						}
						continue;
						end_IL_0139:
						break;
					}
				}
				finally
				{
					int num20;
					if (startInformation == null)
					{
						num20 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num20 = 0;
						}
						goto IL_043e;
					}
					goto IL_0454;
					IL_0454:
					startInformation.Dispose();
					int num21 = 2;
					num20 = num21;
					goto IL_043e;
					IL_043e:
					switch (num20)
					{
					default:
						goto end_IL_0419;
					case 1:
						break;
					case 0:
						goto end_IL_0419;
					case 2:
						goto end_IL_0419;
					}
					goto IL_0454;
					end_IL_0419:;
				}
				goto case 1;
			case 7:
				try
				{
					int num13;
					if (ak7x64f8MUeCSWUyQlu7())
					{
						int num12 = 3;
						num13 = num12;
						goto IL_04c0;
					}
					goto IL_052d;
					IL_04c0:
					while (true)
					{
						switch (num13)
						{
						default:
							goto end_IL_04c0;
						case 3:
							currentContainer = Locator.GetServiceNotNull<IContainer>();
							num13 = 4;
							continue;
						case 2:
							goto end_IL_04c0;
						case 4:
							preInitBuilder.Update(currentContainer);
							num13 = 2;
							continue;
						case 1:
							break;
						case 0:
							goto end_IL_04c0;
						}
						goto IL_052d;
						continue;
						end_IL_04c0:
						break;
					}
					goto end_IL_04a4;
					IL_052d:
					currentContainer = (IContainer)zZxacwf8JxHmadkXTyJS(preInitBuilder, (ContainerBuildOptions)0);
					num13 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num13 = 0;
					}
					goto IL_04c0;
					end_IL_04a4:;
				}
				finally
				{
					int num14;
					if (startInformation == null)
					{
						num14 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num14 = 1;
						}
						goto IL_0583;
					}
					goto IL_05b8;
					IL_05b8:
					GZq6Oaf8FISSCf4iMf0C(startInformation);
					num14 = 2;
					goto IL_0583;
					IL_0583:
					switch (num14)
					{
					case 1:
						goto end_IL_055e;
					case 2:
						goto end_IL_055e;
					}
					goto IL_05b8;
					end_IL_055e:;
				}
				goto case 8;
			case 1:
				startInformation = StartInformation.Operation(3.0, (string)zCdDexf8Ov8Ow1CLnVht(wCv31Xf8BDT6klkASJPg(0x4D1C1EE4 ^ 0x4D192E30)));
				num2 = 7;
				break;
			case 2:
				try
				{
					initBuilder = new ContainerBuilder();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							startInformation = (IStartInformation)OB3ZKXf82AiHB1c8go0f(99.0, zCdDexf8Ov8Ow1CLnVht(wCv31Xf8BDT6klkASJPg(-1822890472 ^ -1822566556)));
							num3 = 5;
							continue;
						case 4:
							preInitBuilder = null;
							num3 = 7;
							continue;
						default:
							interceptorsToRegister = new Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>>();
							num3 = 9;
							continue;
						case 6:
							try
							{
								int num6;
								if (runtimeApplication == null)
								{
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
									{
										num6 = 0;
									}
									goto IL_06e4;
								}
								object dbPreUpdater = i5KsxUf80NLvuC9y1TJH(runtimeApplication);
								goto IL_070c;
								IL_070c:
								proxiesAssemblyActivator = new ProxiesAssemblyActivator((DbPreUpdater)dbPreUpdater, (string)wCv31Xf8BDT6klkASJPg(-1146510045 ^ -1146317757), interceptorsToRegister);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
								{
									num6 = 0;
								}
								goto IL_06e4;
								IL_06e4:
								switch (num6)
								{
								case 1:
									dbPreUpdater = null;
									break;
								default:
									try
									{
										InvokeInitHandlers(delegate(IInitHandler h)
										{
											h.Init();
										});
										int num7 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
										{
											num7 = 0;
										}
										while (true)
										{
											switch (num7)
											{
											case 1:
												S2Tp5lf8yImDLkmk4tjl(StartInformation.Current, 95.0);
												num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
												{
													num7 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
									finally
									{
										int num8;
										if (proxiesAssemblyActivator == null)
										{
											num8 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
											{
												num8 = 1;
											}
											goto IL_07f8;
										}
										goto IL_080e;
										IL_080e:
										GZq6Oaf8FISSCf4iMf0C(proxiesAssemblyActivator);
										num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
										{
											num8 = 0;
										}
										goto IL_07f8;
										IL_07f8:
										switch (num8)
										{
										default:
											goto end_IL_07d3;
										case 2:
											break;
										case 1:
											goto end_IL_07d3;
										case 0:
											goto end_IL_07d3;
										}
										goto IL_080e;
										end_IL_07d3:;
									}
									goto end_IL_06bb;
								}
								goto IL_070c;
								end_IL_06bb:;
							}
							finally
							{
								if (startInformation != null)
								{
									int num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
									{
										num9 = 0;
									}
									while (true)
									{
										switch (num9)
										{
										default:
											GZq6Oaf8FISSCf4iMf0C(startInformation);
											num9 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
											{
												num9 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
							goto case 8;
						case 9:
							startInformation = (IStartInformation)OB3ZKXf82AiHB1c8go0f(98.0, zCdDexf8Ov8Ow1CLnVht(wCv31Xf8BDT6klkASJPg(0x3C5338FF ^ 0x3C5609D5)));
							num3 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							preInitBuilder = initBuilder;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
							{
								num3 = 0;
							}
							continue;
						case 5:
							try
							{
								r87KH2f8pPCgu5NM7KpL(initBuilder, currentContainer);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
							finally
							{
								if (startInformation != null)
								{
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											startInformation.Dispose();
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
											{
												num5 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
							break;
						case 8:
						{
							interceptorsToRegister = null;
							int num10 = 2;
							num3 = num10;
							continue;
						}
						case 3:
							break;
						case 7:
							return;
						}
						initBuilder = null;
						num3 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
						{
							num3 = 2;
						}
					}
				}
				finally
				{
					if (val != null)
					{
						int num11 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num11 = 0;
						}
						while (true)
						{
							switch (num11)
							{
							default:
								GZq6Oaf8FISSCf4iMf0C(val);
								num11 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
								{
									num11 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 5:
				return;
			}
		}
	}

	protected virtual void RegisterData(RegistrationData regData)
	{
		//Discarded unreachable code: IL_0055, IL_0064, IL_006f, IL_0104, IL_0117, IL_0126, IL_0137, IL_0141, IL_01e8, IL_01fb, IL_020b, IL_021a, IL_0225, IL_02bc, IL_02cf, IL_02de
		int num = 6;
		int num2 = num;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		object current3 = default(object);
		List<Assembly>.Enumerator enumerator = default(List<Assembly>.Enumerator);
		Assembly current2 = default(Assembly);
		Assembly current = default(Assembly);
		while (true)
		{
			switch (num2)
			{
			case 6:
				enumerator2 = regData.ComponentsToRegister.GetEnumerator();
				num2 = 5;
				continue;
			case 5:
				try
				{
					while (true)
					{
						IL_00c2:
						int num7;
						if (!enumerator2.MoveNext())
						{
							num7 = 3;
							goto IL_0073;
						}
						goto IL_008d;
						IL_0073:
						while (true)
						{
							switch (num7)
							{
							case 1:
								m7QHUtf8dZ9i8Ndx3bXb(this, current3);
								num7 = 2;
								continue;
							case 2:
								goto IL_00c2;
							case 3:
								goto end_IL_00c2;
							}
							break;
						}
						goto IL_008d;
						IL_008d:
						current3 = enumerator2.Current;
						num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num7 = 1;
						}
						goto IL_0073;
						continue;
						end_IL_00c2:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num8 = 0;
					}
					switch (num8)
					{
					case 0:
						break;
					}
				}
				break;
			case 2:
				try
				{
					while (true)
					{
						IL_0196:
						int num5;
						if (!enumerator.MoveNext())
						{
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
							{
								num5 = 0;
							}
							goto IL_0145;
						}
						goto IL_015f;
						IL_015f:
						current2 = enumerator.Current;
						num5 = 2;
						goto IL_0145;
						IL_0145:
						while (true)
						{
							switch (num5)
							{
							default:
								return;
							case 3:
								break;
							case 2:
								ProcessAssembly(current2, checkComponentAttribute: true, disabled: true);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
								{
									num5 = 1;
								}
								continue;
							case 1:
								goto IL_0196;
							case 0:
								return;
							}
							break;
						}
						goto IL_015f;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
			default:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_0229;
						}
						goto IL_026d;
						IL_0229:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 1:
								ProcessAssembly(current);
								num3 = 3;
								continue;
							default:
								goto IL_026d;
							case 2:
								goto end_IL_0243;
							}
							break;
						}
						continue;
						IL_026d:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num3 = 1;
						}
						goto IL_0229;
						continue;
						end_IL_0243:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 3;
			case 3:
				enumerator = regData.DisabledAssemblies.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 2;
				}
				continue;
			case 4:
				return;
			case 1:
				break;
			}
			enumerator = regData.Assemblies.GetEnumerator();
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
			{
				num2 = 0;
			}
		}
	}

	protected virtual void RegisterAutofacInterceptors()
	{
		//Discarded unreachable code: IL_003e, IL_004d, IL_0058, IL_0104, IL_0117, IL_018d, IL_019c, IL_0257, IL_026a, IL_027b, IL_0285, IL_0351, IL_0364
		int num = 2;
		List<Tuple<Type, string>>.Enumerator enumerator2 = default(List<Tuple<Type, string>>.Enumerator);
		Tuple<Type, string> current3 = default(Tuple<Type, string>);
		List<Tuple<Type, string, Type>>.Enumerator enumerator = default(List<Tuple<Type, string, Type>>.Enumerator);
		Tuple<Type, string, Type> current2 = default(Tuple<Type, string, Type>);
		Tuple<Type, string, Type> current = default(Tuple<Type, string, Type>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					try
					{
						while (true)
						{
							int num8;
							if (!enumerator2.MoveNext())
							{
								num8 = 3;
								goto IL_005c;
							}
							goto IL_00b5;
							IL_005c:
							while (true)
							{
								switch (num8)
								{
								default:
									RegistrationExtensions.RegisterType(preInitBuilder, current3.Item1).Named<IInterceptor>(current3.Item2);
									num8 = 2;
									continue;
								case 2:
									break;
								case 1:
									goto IL_00b5;
								case 3:
									return;
								}
								break;
							}
							continue;
							IL_00b5:
							current3 = enumerator2.Current;
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num8 = 0;
							}
							goto IL_005c;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
				case 3:
					enumerator2 = requiredInterceptors.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					break;
				case 2:
					enumerator = attributeMethodInterceptors.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					try
					{
						while (true)
						{
							IL_0211:
							int num6;
							if (!enumerator.MoveNext())
							{
								int num5 = 3;
								num6 = num5;
								goto IL_01ab;
							}
							goto IL_01fe;
							IL_01ab:
							while (true)
							{
								switch (num6)
								{
								case 2:
									RegistrationExtensions.RegisterType(preInitBuilder, current2.Item1).Named<IInterceptor>(current2.Item2);
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
									{
										num6 = 0;
									}
									continue;
								case 1:
									break;
								default:
									goto IL_0211;
								case 3:
									goto end_IL_0211;
								}
								break;
							}
							goto IL_01fe;
							IL_01fe:
							current2 = enumerator.Current;
							num6 = 2;
							goto IL_01ab;
							continue;
							end_IL_0211:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					break;
				case 5:
					return;
				case 6:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
								{
									num3 = 1;
								}
								goto IL_0289;
							}
							goto IL_02c9;
							IL_02c9:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
							{
								num3 = 0;
							}
							goto IL_0289;
							IL_0289:
							while (true)
							{
								switch (num3)
								{
								case 3:
									break;
								case 2:
									goto IL_02c9;
								default:
									RegistrationExtensions.RegisterType(preInitBuilder, current.Item1).Named<IInterceptor>(current.Item2);
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
									{
										num3 = 1;
									}
									continue;
								case 1:
									goto end_IL_02a3;
								}
								break;
							}
							continue;
							end_IL_02a3:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 3;
				}
				break;
			}
			enumerator = typeInterceptors.GetEnumerator();
			num = 6;
		}
	}

	protected virtual void RegisterAutofacModules()
	{
		//Discarded unreachable code: IL_01bf, IL_01c9, IL_02ef, IL_0302
		int num = 12;
		_003C_003Ec__DisplayClass88_0 _003C_003Ec__DisplayClass88_ = default(_003C_003Ec__DisplayClass88_0);
		List<Tuple<Type, string, Type>>.Enumerator enumerator = default(List<Tuple<Type, string, Type>>.Enumerator);
		Tuple<Type, string, Type> current = default(Tuple<Type, string, Type>);
		_003C_003Ec__DisplayClass88_1 _003C_003Ec__DisplayClass88_2 = default(_003C_003Ec__DisplayClass88_1);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					_003C_003Ec__DisplayClass88_.attType = fq0cNOf8iuVHvsiP5PGY(typeof(HubMethodNameAttribute).TypeHandle);
					num2 = 5;
					continue;
				case 12:
					_003C_003Ec__DisplayClass88_ = new _003C_003Ec__DisplayClass88_0();
					num2 = 11;
					continue;
				case 14:
					if (componentType != ComponentType.Test)
					{
						num = 2;
						break;
					}
					goto default;
				case 10:
					P7ty2Tf8ljIjsQ73A092(preInitBuilder, new RequiredVirtualMethodModule(_003C_003Ec__DisplayClass88_._003CRegisterAutofacModules_003Eb__0, _003C_003Ec__DisplayClass88_._003CRegisterAutofacModules_003Eb__1, applicationStartCache));
					num2 = 15;
					continue;
				case 2:
					ModuleRegistrationExtensions.RegisterModule(preInitBuilder, (IModule)(object)new LoggingModule());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					enumerator = attributeMethodInterceptors.GetEnumerator();
					num2 = 4;
					continue;
				case 5:
					P7ty2Tf8ljIjsQ73A092(preInitBuilder, new RequiredVirtualMethodModule(_003C_003Ec__DisplayClass88_._003CRegisterAutofacModules_003Eb__2, _003C_003Ec__DisplayClass88_._003CRegisterAutofacModules_003Eb__3, applicationStartCache));
					num2 = 14;
					continue;
				default:
					P7ty2Tf8ljIjsQ73A092(preInitBuilder, new LazyResolverModule());
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					_003C_003Ec__DisplayClass88_.messageTemplate = (string)oB6VAWfvjUcykXtDN2xn(wCv31Xf8BDT6klkASJPg(0x49E27B8A ^ 0x49E74A4E));
					num = 8;
					break;
				case 7:
					return;
				case 4:
					try
					{
						while (true)
						{
							IL_028c:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
								{
									num3 = 0;
								}
								goto IL_01cd;
							}
							goto IL_0279;
							IL_0279:
							current = enumerator.Current;
							num3 = 3;
							goto IL_01cd;
							IL_01cd:
							while (true)
							{
								switch (num3)
								{
								case 1:
									_003C_003Ec__DisplayClass88_2.attributeType = current.Item3;
									num3 = 2;
									continue;
								case 2:
									P7ty2Tf8ljIjsQ73A092(preInitBuilder, new RequiredVirtualMethodModule(_003C_003Ec__DisplayClass88_2._003CRegisterAutofacModules_003Eb__4, _003C_003Ec__DisplayClass88_2._003CRegisterAutofacModules_003Eb__5, applicationStartCache));
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
									{
										num3 = 4;
									}
									continue;
								case 6:
									_003C_003Ec__DisplayClass88_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass88_;
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
									{
										num3 = 1;
									}
									continue;
								case 5:
									goto IL_0279;
								case 4:
									goto IL_028c;
								case 3:
									_003C_003Ec__DisplayClass88_2 = new _003C_003Ec__DisplayClass88_1();
									num3 = 6;
									continue;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 3;
				case 9:
					P7ty2Tf8ljIjsQ73A092(preInitBuilder, new EntityActivationModule());
					num2 = 13;
					continue;
				case 3:
					_003C_003Ec__DisplayClass88_.cfgServiceMessageTemplate = SR.T((string)wCv31Xf8BDT6klkASJPg(-2112703338 ^ -2112387482));
					num2 = 10;
					continue;
				case 1:
					ModuleRegistrationExtensions.RegisterModule(preInitBuilder, (IModule)(object)new EntityManagerActionsCollectModule());
					num2 = 9;
					continue;
				case 11:
					_003C_003Ec__DisplayClass88_._003C_003E4__this = this;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
					P7ty2Tf8ljIjsQ73A092(preInitBuilder, new ExtensionPointsActivationModule());
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	protected virtual void LoadAssemblies(bool onlyLoadedAssemblies)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				LoadAssemblies(onlyLoadedAssemblies, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected virtual void LoadAssemblies(bool onlyLoadedAssemblies, AppDomain domain)
	{
		//Discarded unreachable code: IL_00c5, IL_0165, IL_0174, IL_01a7, IL_01b1, IL_02bb, IL_02ca, IL_02d9, IL_034d, IL_03c4, IL_041b, IL_0473, IL_04ab
		int num = 11;
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string text = default(string);
		int num9 = default(int);
		string[] assembliesPaths = default(string[]);
		_003C_003Ec__DisplayClass90_0 _003C_003Ec__DisplayClass90_ = default(_003C_003Ec__DisplayClass90_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 5:
					return;
				case 4:
					enumerator = ((IEnumerable<string>)RpN0Cif8rMl36lDkbCPb(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138876098))).Union(Directory.GetFiles(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459386561))).GetEnumerator();
					num2 = 6;
					continue;
				case 11:
					if (_assembliesLoaded)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 10;
						}
						continue;
					}
					if (_assembliesPaths == null)
					{
						num = 5;
						break;
					}
					goto case 12;
				case 8:
					num9++;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					num9 = 0;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 8;
					}
					continue;
				case 10:
					return;
				case 7:
					_assembliesLoaded = true;
					num = 2;
					break;
				case 1:
				case 9:
					if (num9 >= assembliesPaths.Length)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 3;
				case 12:
					assembliesPaths = _assembliesPaths;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					try
					{
						while (true)
						{
							int num3;
							if (!pMYTqhf8UFUy6jrJ5ODO(enumerator))
							{
								num3 = 4;
								goto IL_01b5;
							}
							goto IL_01e9;
							IL_01b5:
							while (true)
							{
								switch (num3)
								{
								case 3:
									break;
								case 2:
									goto IL_01e9;
								default:
									try
									{
										Assembly assembly = ((IEnumerable<Assembly>)v5Q9sxf8V01q5Iw9Niyo(domain)).FirstOrDefault(_003C_003Ec__DisplayClass90_._003CLoadAssemblies_003Eb__0);
										int num4 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
										{
											num4 = 5;
										}
										while (true)
										{
											switch (num4)
											{
											case 5:
												if (RFH3yXf8G144TwqweIOi(assembly, null))
												{
													num4 = 2;
													continue;
												}
												goto case 4;
											case 4:
												if (onlyLoadedAssemblies)
												{
													num4 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
													{
														num4 = 1;
													}
													continue;
												}
												break;
											case 2:
											{
												AddAssembly(assembly);
												int num5 = 6;
												num4 = num5;
												continue;
											}
											case 6:
												goto end_IL_0243;
											case 1:
												goto end_IL_0243;
											case 3:
												goto end_IL_0243;
											}
											AddAssembly((Assembly)((domain != null) ? BBH6ZXf8jMvCBLNJBUG0(domain, qZRn8xf85fbF35GLkVx7(_003C_003Ec__DisplayClass90_.file)) : xhDBvwf8giCa1LwM4d84(_003C_003Ec__DisplayClass90_.file)));
											num4 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
											{
												num4 = 1;
											}
											continue;
											end_IL_0243:
											break;
										}
									}
									catch (BadImageFormatException)
									{
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
										{
											num6 = 0;
										}
										while (true)
										{
											switch (num6)
											{
											default:
												yVWEs6f8L7ZQtBtryb75(wYY10Qf8YZfu2qyo2lEJ(), string.Format((string)wCv31Xf8BDT6klkASJPg(-1487388570 ^ -1487047736), _003C_003Ec__DisplayClass90_.file));
												num6 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
												{
													num6 = 1;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
									catch (Exception exception)
									{
										int num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
										{
											num7 = 0;
										}
										while (true)
										{
											switch (num7)
											{
											default:
												((ILogger)wYY10Qf8YZfu2qyo2lEJ()).Warn(wCv31Xf8BDT6klkASJPg(-3333094 ^ -3663896), exception);
												num7 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
												{
													num7 = 1;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
									break;
								case 1:
									_003C_003Ec__DisplayClass90_.file = enumerator.Current;
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
									{
										num3 = 0;
									}
									continue;
								case 4:
									goto end_IL_01d3;
								}
								break;
							}
							continue;
							IL_01e9:
							_003C_003Ec__DisplayClass90_ = new _003C_003Ec__DisplayClass90_0();
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
							{
								num3 = 0;
							}
							goto IL_01b5;
							continue;
							end_IL_01d3:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
							{
								num8 = 1;
							}
							while (true)
							{
								switch (num8)
								{
								case 1:
									enumerator.Dispose();
									num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
									{
										num8 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 8;
				case 3:
					text = assembliesPaths[num9];
					num = 4;
					break;
				}
				break;
			}
		}
	}

	protected virtual void InvokeInitHandlers(Action<IInitHandler> action)
	{
		foreach (IInitHandler extensionPoint in GetExtensionPoints<IInitHandler>())
		{
			action(extensionPoint);
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		//Discarded unreachable code: IL_0103, IL_0136, IL_018d
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
				if (_current == this)
				{
					num2 = 3;
					break;
				}
				return;
			case 4:
				((ILogger)K3ITMvf8s05BklVvjDli()).Warn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CE7269));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (currentContainer != null)
				{
					num2 = 2;
					break;
				}
				goto case 6;
			case 3:
				_current = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				stage = LifetimeStage.Disposed;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				try
				{
					GZq6Oaf8FISSCf4iMf0C(currentContainer);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							LB0mCcf8cq99ok71aam0(K3ITMvf8s05BklVvjDli(), wCv31Xf8BDT6klkASJPg(-475857671 ^ -475543391), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				goto case 6;
			case 0:
				return;
			}
		}
	}

	protected virtual void ProcessAssembly(Assembly assembly, bool checkComponentAttribute = true, bool disabled = false)
	{
		//Discarded unreachable code: IL_00f9, IL_0108, IL_01ab, IL_01e3, IL_01f6, IL_0205, IL_0256, IL_0265, IL_0274, IL_0283
		int num = 2;
		bool flag = default(bool);
		bool? isComponentAssembly = default(bool?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (assemblyInfoCache == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 20;
				case 5:
					flag = true;
					num2 = 16;
					continue;
				case 17:
					if (!checkComponentAttribute)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 21;
				case 19:
					return;
				case 1:
					processedAssemblies.Add(assembly);
					num2 = 4;
					continue;
				case 10:
				case 12:
					flag = ccwPrsfZFfxGqf7KjX5X(this, assembly);
					num = 14;
					break;
				case 14:
					if (assemblyInfoCache == null)
					{
						num = 18;
						break;
					}
					goto default;
				case 4:
					assemblyInfoCache = null;
					num2 = 17;
					continue;
				case 9:
					flag = isComponentAssembly.Value;
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 15;
					}
					continue;
				case 8:
				case 15:
				case 16:
				case 18:
					if (flag)
					{
						num2 = 3;
						continue;
					}
					return;
				case 20:
					isComponentAssembly = assemblyInfoCache.IsComponentAssembly;
					num2 = 7;
					continue;
				case 3:
					try
					{
						ProcessComponentAssembly(assembly, disabled);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					finally
					{
						assemblyInfoCache = null;
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				case 2:
					if (processedAssemblies.Contains(assembly))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 1;
					}
					continue;
				case 11:
					isComponentAssembly = assemblyInfoCache.IsComponentAssembly;
					num2 = 9;
					continue;
				case 13:
					return;
				default:
					assemblyInfoCache.IsComponentAssembly = flag;
					num = 8;
					break;
				case 7:
					if (isComponentAssembly.HasValue)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 10;
				case 21:
					assemblyInfoCache = (AssemblyInfoCache)((applicationStartCache != null) ? fwAmGgf8zofGfRgrkkHS(applicationStartCache, assembly) : null);
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	protected virtual void ProcessComponentAssembly(Assembly assembly, bool disabled = false)
	{
		//Discarded unreachable code: IL_00bc, IL_0171, IL_01bb, IL_01ca, IL_0309, IL_03b1, IL_03c0, IL_03d0, IL_03df
		int num = 1;
		int num2 = num;
		int num4 = default(int);
		Type type = default(Type);
		string message = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 5:
				componentAssemblies.Add(assembly);
				num2 = 3;
				break;
			default:
				throw new ArgumentNullException((string)wCv31Xf8BDT6klkASJPg(-521266112 ^ -521246418));
			case 4:
				return;
			case 1:
				if (!MLUjBmf8uveewmtmyNK1(assembly, null))
				{
					if (componentAssemblies.Contains(assembly))
					{
						return;
					}
					num2 = 5;
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 0;
					}
				}
				break;
			case 3:
				try
				{
					Type[] types = assembly.GetTypes();
					int num3 = 4;
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						default:
							if (num4 >= types.Length)
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
								{
									num3 = 1;
								}
								break;
							}
							goto case 6;
						case 6:
							type = types[num4];
							num3 = 5;
							break;
						case 3:
							num4++;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
							{
								num3 = 0;
							}
							break;
						case 4:
							num4 = 0;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
							{
								num3 = 2;
							}
							break;
						case 5:
							ProcessType(type, disabled);
							num3 = 3;
							break;
						}
					}
				}
				catch (ReflectionTypeLoadException ex)
				{
					int num5 = 2;
					while (true)
					{
						switch (num5)
						{
						case 3:
							return;
						default:
							((ILogger)wYY10Qf8YZfu2qyo2lEJ()).Error(message, ex);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num5 = 1;
							}
							continue;
						case 4:
							message = (string)jMRKQmfZb6NgS6ZwZvMi(wCv31Xf8BDT6klkASJPg(-643786247 ^ -643585875), s1RFq1fZopCWVkoKLgAB(assembly), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487396008), text);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num5 = 0;
							}
							continue;
						case 1:
							if (!mex9u6fZhL1d3Aq3MgS0(x64lvJf8v6CF4oxdDeL5(assembly), wCv31Xf8BDT6klkASJPg(-978351861 ^ -978335613)))
							{
								num5 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
								{
									num5 = 0;
								}
								continue;
							}
							break;
						case 2:
						{
							text = (string)E1nOPTfZWFcbapix9WGp(wCv31Xf8BDT6klkASJPg(-345420348 ^ -345342510), ((IEnumerable<Exception>)VSD4gpfZBv3GyDn7IbhH(ex)).Select((Exception e) => e.ToString()).ToArray());
							int num6 = 4;
							num5 = num6;
							continue;
						}
						case 5:
							break;
						}
						break;
					}
					throw new InvalidOperationException(message, ex);
				}
				catch (Exception exception)
				{
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						default:
							((ILogger)wYY10Qf8YZfu2qyo2lEJ()).Error(ah0QgIfZG8YS1QTM2hsV(wCv31Xf8BDT6klkASJPg(0x3630F361 ^ 0x3635C7F3), x64lvJf8v6CF4oxdDeL5(assembly)), exception);
							num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
							{
								num7 = 1;
							}
							break;
						case 1:
							if (!mex9u6fZhL1d3Aq3MgS0(x64lvJf8v6CF4oxdDeL5(assembly), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521249336)))
							{
								return;
							}
							num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
							{
								num7 = 2;
							}
							break;
						case 2:
							throw;
						}
					}
				}
			}
		}
	}

	protected virtual bool IsComponentAssembly(Assembly assembly)
	{
		//Discarded unreachable code: IL_0053, IL_0062
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!MLUjBmf8uveewmtmyNK1(assembly, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411207997));
			case 1:
				return assembly.IsDefined(typeof(ComponentAssemblyAttribute), inherit: false);
			}
		}
	}

	protected virtual void ProcessType(Type type, bool assemblyDisabled = false)
	{
		//Discarded unreachable code: IL_0163, IL_0172, IL_0200, IL_025c, IL_02c0, IL_02cf, IL_02df, IL_02ee, IL_0313, IL_0322, IL_03f8, IL_043d, IL_0482, IL_0491, IL_04ce, IL_04dd
		int num = 12;
		int num3 = default(int);
		object[] array = default(object[]);
		object[] array2 = default(object[]);
		ImplementAttribute implementAttribute = default(ImplementAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 25:
					if (!type.IsEnum)
					{
						num2 = 38;
						continue;
					}
					goto case 8;
				case 22:
					if (!type.IsInterface)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 17;
				case 24:
					num3++;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 2;
					}
					continue;
				case 18:
					if (array.Length == 0)
					{
						num2 = 7;
						continue;
					}
					break;
				case 9:
					if (type.ContainsGenericParameters)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 21;
				case 4:
					if (!type.IsClass)
					{
						num2 = 28;
						continue;
					}
					goto case 9;
				case 32:
					ProcessComponentType(type, assemblyDisabled);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 36;
					}
					continue;
				case 0:
					return;
				case 7:
					if (((Array)caqunGfZCSCVAp24EyF5(type, fq0cNOf8iuVHvsiP5PGY(typeof(EntityAttribute).TypeHandle), false)).Length == 0)
					{
						num2 = 20;
						continue;
					}
					goto case 37;
				case 10:
				case 13:
					if (num3 >= array2.Length)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 17:
				case 31:
					if (type.ContainsGenericParameters)
					{
						num2 = 16;
						continue;
					}
					goto case 33;
				case 27:
					if (ErSpsGfZfEQpWCmqJs9J(type, fq0cNOf8iuVHvsiP5PGY(typeof(decimal).TypeHandle)))
					{
						num2 = 31;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 8;
				case 3:
					array2 = array;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 23;
					}
					continue;
				case 5:
					return;
				case 15:
					return;
				case 20:
					return;
				case 26:
					return;
				case 28:
					return;
				case 12:
					if (Q1IZdBfZEF00fCvibT7o(type, null))
					{
						num2 = 11;
						continue;
					}
					if (!type.IsAbstract)
					{
						num2 = 34;
						continue;
					}
					goto case 22;
				case 38:
					if (type.IsPrimitive)
					{
						num2 = 8;
						continue;
					}
					goto case 27;
				case 35:
					if (type.IsAbstract)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					if (type.IsValueType)
					{
						num2 = 25;
						continue;
					}
					goto case 8;
				case 11:
					throw new ArgumentNullException((string)wCv31Xf8BDT6klkASJPg(-1317790512 ^ -1317793550));
				case 33:
					if (TieWjafZQfkqmZD9ZTHY(this, type))
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 32;
						}
						continue;
					}
					goto case 8;
				case 34:
					if (type.IsClass)
					{
						num2 = 17;
						continue;
					}
					goto case 22;
				case 23:
					num3 = 0;
					num2 = 13;
					continue;
				case 21:
					if (!IsServiceType(type))
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto end_IL_0012;
				case 1:
					goto end_IL_0012;
				case 19:
					AddToExtensionPointTypesMap(NAKZrlfZvugthLE49hhX(implementAttribute), type);
					num2 = 24;
					continue;
				case 37:
					RegistrationExtensions.RegisterType(preInitBuilder, type).As(new Type[1] { type });
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 4;
					}
					continue;
				case 8:
				case 16:
				case 36:
					if (assemblyDisabled)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 35;
				case 6:
					implementAttribute = (ImplementAttribute)array2[num3];
					num2 = 19;
					continue;
				case 29:
				case 30:
					array = (object[])caqunGfZCSCVAp24EyF5(type, fq0cNOf8iuVHvsiP5PGY(typeof(ImplementAttribute).TypeHandle), false);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 18;
					}
					continue;
				case 14:
					break;
				}
				RegistrationExtensions.RegisterType(preInitBuilder, type).As(new Type[1] { type }).As((from ImplementAttribute a in array
					select _003C_003Ec.Ooa6om8r7uLJufod7v7M(a)).ToArray());
				num2 = 3;
				continue;
				end_IL_0012:
				break;
			}
			ProcessService(type);
			num = 30;
		}
	}

	public bool IsServiceType(Type type)
	{
		//Discarded unreachable code: IL_0084, IL_00cd, IL_00dc, IL_00fe, IL_012e, IL_013d, IL_0163, IL_0172
		int num = 13;
		bool? isServiceType = default(bool?);
		TypeInfoCache typeInfoCache = default(TypeInfoCache);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 3:
					isServiceType = typeInfoCache.IsServiceType;
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 8;
					}
					continue;
				case 6:
					if (typeInfoCache == null)
					{
						num2 = 15;
						continue;
					}
					goto case 5;
				default:
					return isServiceType.Value;
				case 2:
				case 9:
					goto end_IL_0012;
				case 8:
					if (typeInfoCache == null)
					{
						num2 = 9;
						continue;
					}
					goto case 3;
				case 10:
					obj = null;
					break;
				case 13:
					if (Q1IZdBfZEF00fCvibT7o(type, null))
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					if (!registrationData.ServiceTypesToRegister.Contains(type))
					{
						if (applicationStartCache != null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
							{
								num2 = 4;
							}
							continue;
						}
						goto case 10;
					}
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 7;
					}
					continue;
				case 14:
					if (!isServiceType.HasValue)
					{
						num2 = 2;
						continue;
					}
					goto case 11;
				case 11:
					isServiceType = typeInfoCache.IsServiceType;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
				case 15:
					return flag;
				case 7:
					return true;
				case 12:
					throw new ArgumentNullException((string)wCv31Xf8BDT6klkASJPg(-3333094 ^ -3332040));
				case 5:
					typeInfoCache.IsServiceType = flag;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					obj = ((AssemblyInfoCache)fwAmGgf8zofGfRgrkkHS(applicationStartCache, type.Assembly)).GetTypeInfo(type);
					break;
				}
				typeInfoCache = (TypeInfoCache)obj;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			flag = QoPPLJfZ8RCjmLbtMORD(type, fq0cNOf8iuVHvsiP5PGY(typeof(ServiceAttribute).TypeHandle), true);
			num = 6;
		}
	}

	private void ProcessService(Type serviceType)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass98_0 _003C_003Ec__DisplayClass98_ = default(_003C_003Ec__DisplayClass98_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				ProcessService(_003C_003Ec__DisplayClass98_.serviceType, preInitBuilder, _003C_003Ec__DisplayClass98_._003CProcessService_003Eb__0);
				num2 = 3;
				break;
			case 3:
				return;
			default:
				_003C_003Ec__DisplayClass98_.serviceType = serviceType;
				num2 = 4;
				break;
			case 1:
				_003C_003Ec__DisplayClass98_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass98_ = new _003C_003Ec__DisplayClass98_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void ProcessShellService(Type serviceType, ContainerBuilder containerBuilder, params ServiceScope[] serviceScope)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass99_0 _003C_003Ec__DisplayClass99_ = default(_003C_003Ec__DisplayClass99_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			default:
				_003C_003Ec__DisplayClass99_._003C_003E4__this = this;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass99_.serviceType = serviceType;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass99_.containerBuilder = containerBuilder;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass99_.serviceScope = serviceScope;
				num2 = 3;
				break;
			case 1:
				_003C_003Ec__DisplayClass99_ = new _003C_003Ec__DisplayClass99_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				RunWithShellExtensionPointTypesMap(_003C_003Ec__DisplayClass99_._003CProcessShellService_003Eb__0);
				num2 = 4;
				break;
			}
		}
	}

	public virtual void ProcessService(Type serviceType, ContainerBuilder containerBuilder, Func<ServiceScope?, bool> skipCondition)
	{
		if (log.IsVerboseEnabled())
		{
			log.Verbose(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x426106E7) + serviceType);
		}
		ServiceAttribute attribute = AttributeHelper<ServiceAttribute>.GetAttribute(serviceType, inherited: true);
		if (attribute == null || ((attribute.Type & componentType) == 0 && !registrationData.ServiceTypesToRegister.Contains(serviceType)))
		{
			return;
		}
		if (skipCondition(attribute.Scope))
		{
			shellServices.Add(serviceType);
			return;
		}
		IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> val = RegistrationExtensions.RegisterType(containerBuilder, serviceType);
		if (attribute.InjectProperties)
		{
			RegistrationExtensions.PropertiesAutowired<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(val, (PropertyWiringOptions)1);
		}
		List<Type> list = (from itf in serviceType.GetInterfaces()
			where !TypeOf<IEventHandler>.Raw.IsAssignableFrom(itf)
			select itf).ToList();
		if (TypeOf<IEventHandler>.Raw.IsAssignableFrom(serviceType))
		{
			list.Add(TypeOf<IEventHandler>.Raw);
		}
		if (list.Count > 0)
		{
			val.As(list.ToArray());
		}
		val.As(new Type[1] { serviceType });
		val.SetScope<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(attribute.Scope);
		ComponentOrderAttribute attribute2 = AttributeHelper<ComponentOrderAttribute>.GetAttribute(serviceType, inherited: true);
		if (attribute2 != null)
		{
			val.WithMetadata(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -69829846), (object)attribute2.Order);
		}
		if (attribute.EnableInterceptors)
		{
			SetupInterceptors(serviceType, val);
		}
	}

	public void SetupInterceptors(Type type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> registrar)
	{
		TypeInfoCache typeInfoCache = ((applicationStartCache != null) ? applicationStartCache.GetAssemblyInfo(type.Assembly).GetTypeInfo(type) : null);
		Dictionary<string, bool?> dictionary = new Dictionary<string, bool?>();
		bool flag = false;
		foreach (string interceptorName in interceptorNames)
		{
			if (!(dictionary[interceptorName] = typeInfoCache?.IsInterceptorEnabled(interceptorName)).HasValue)
			{
				flag = true;
			}
		}
		if (flag)
		{
			MethodInfo[] methods = ((ReflectionActivatorData)registrar.get_ActivatorData()).get_ImplementationType().GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (Tuple<Type, string, Type> attributeMethodInterceptor in attributeMethodInterceptors)
			{
				if (!dictionary[attributeMethodInterceptor.Item2].HasValue)
				{
					_003C_003Ec__DisplayClass101_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass101_0();
					CS_0024_003C_003E8__locals0.interceptor = attributeMethodInterceptor;
					bool flag3 = methods.Any((MethodInfo m) => ((Array)_003C_003Ec__DisplayClass101_0.zw7XS78gXZ9tFvQXyZHp(m, CS_0024_003C_003E8__locals0.interceptor.Item3, true)).Length != 0);
					dictionary[attributeMethodInterceptor.Item2] = flag3;
					typeInfoCache?.SetInterceptorEnabled(attributeMethodInterceptor.Item2, flag3);
				}
			}
			foreach (Tuple<Type, string, Type> typeInterceptor in typeInterceptors)
			{
				if (!dictionary[typeInterceptor.Item2].HasValue)
				{
					bool flag4 = typeInterceptor.Item3.IsAssignableFrom(type);
					dictionary[typeInterceptor.Item2] = flag4;
					typeInfoCache?.SetInterceptorEnabled(typeInterceptor.Item2, flag4);
				}
			}
		}
		bool flag5 = false;
		foreach (KeyValuePair<string, bool?> item in dictionary.Where((KeyValuePair<string, bool?> p) => p.Value.HasValue && p.Value.Value))
		{
			RegistrationExtensions.InterceptedBy<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(registrar, new string[1] { item.Key });
			flag5 = true;
		}
		if (!flag5)
		{
			return;
		}
		if (flag)
		{
			foreach (Tuple<Type, string> requiredInterceptor in requiredInterceptors)
			{
				if (!dictionary[requiredInterceptor.Item2].HasValue)
				{
					bool flag6 = type.IsPublic && type.IsClass && !type.IsAbstract;
					dictionary[requiredInterceptor.Item2] = flag6;
					typeInfoCache?.SetInterceptorEnabled(requiredInterceptor.Item2, flag6);
					RegistrationExtensions.InterceptedBy<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(registrar, new string[1] { requiredInterceptor.Item2 });
				}
			}
		}
		if (interceptorsToRegister != null)
		{
			interceptorsToRegister.Add(type, registrar);
		}
		else
		{
			registrar.EnableClassInterceptorsCacheable<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>();
		}
	}

	public virtual bool IsComponentType(Type type)
	{
		//Discarded unreachable code: IL_007d, IL_0102, IL_0111, IL_0121, IL_0130, IL_0179, IL_0188, IL_021e, IL_0228, IL_0237, IL_0264, IL_0273, IL_0294
		int num = 22;
		bool? isComponentType = default(bool?);
		TypeInfoCache typeInfoCache = default(TypeInfoCache);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 17:
					isComponentType = typeInfoCache.IsComponentType;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
					throw new ArgumentNullException((string)wCv31Xf8BDT6klkASJPg(0x4785BC0D ^ 0x4785B02F));
				case 21:
					if (!registrationData.ComponentsTypesToRegister.Contains(type))
					{
						num = 11;
						break;
					}
					goto case 6;
				case 14:
					return flag;
				case 3:
					if (isComponentType.HasValue)
					{
						num2 = 10;
						continue;
					}
					goto IL_019b;
				case 22:
					if (!Q1IZdBfZEF00fCvibT7o(type, null))
					{
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 15;
				case 10:
					isComponentType = typeInfoCache.IsComponentType;
					num2 = 12;
					continue;
				case 12:
					return isComponentType.Value;
				case 2:
					if (typeInfoCache != null)
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto IL_019b;
				default:
					if (type.IsInterface)
					{
						num2 = 4;
						continue;
					}
					goto case 1;
				case 6:
					return true;
				case 11:
					if (applicationStartCache != null)
					{
						num2 = 8;
						continue;
					}
					goto case 18;
				case 18:
					obj = null;
					goto IL_02ea;
				case 5:
					flag = true;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 16;
					}
					continue;
				case 9:
				case 16:
				case 19:
					if (typeInfoCache != null)
					{
						num2 = 13;
						continue;
					}
					goto case 14;
				case 13:
					typeInfoCache.IsComponentType = flag;
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 9;
					}
					continue;
				case 1:
					flag = false;
					num2 = 19;
					continue;
				case 8:
					obj = applicationStartCache.GetAssemblyInfo(type.Assembly).GetTypeInfo(type);
					goto IL_02ea;
				case 4:
				case 7:
					{
						flag = ErSpsGfZfEQpWCmqJs9J(type.GetInterfaces().FirstOrDefault((Type intf) => _003C_003Ec.W1JlcZ8rxR1nQA81XnP8(intf, _003C_003Ec.p0to0q8r4vDsnxUQjfRL(typeof(ComponentAttribute).TypeHandle), true)), null);
						num2 = 9;
						continue;
					}
					IL_019b:
					if (!QoPPLJfZ8RCjmLbtMORD(type, fq0cNOf8iuVHvsiP5PGY(typeof(ComponentAttribute).TypeHandle), true))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
					IL_02ea:
					typeInfoCache = (TypeInfoCache)obj;
					num = 2;
					break;
				}
				break;
			}
		}
	}

	protected virtual object CreateComponent(Type type)
	{
		//Discarded unreachable code: IL_0048, IL_007b, IL_00e3, IL_00f2
		object obj = default(object);
		switch (1)
		{
		case 1:
			try
			{
				obj = uquioYfZZPrSnh2AyBLt(type, true);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num = 0;
				}
				return num switch
				{
					0 => obj, 
					_ => obj, 
				};
			}
			catch (Exception ex)
			{
				int num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 2:
						obj = null;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						LB0mCcf8cq99ok71aam0(K3ITMvf8s05BklVvjDli(), ah0QgIfZG8YS1QTM2hsV(wCv31Xf8BDT6klkASJPg(0x35C0467B ^ 0x35C57363), type), ex);
						num2 = 2;
						break;
					default:
						return obj;
					case 0:
						return obj;
					}
				}
			}
		default:
			return obj;
		}
	}

	protected virtual void ProcessComponentType(Type type, bool assemblyDisabled = false)
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
				ProcessComponent(type, null, assemblyDisabled);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void ProcessComponent(object component)
	{
		int num = 2;
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
				throw new ArgumentNullException((string)wCv31Xf8BDT6klkASJPg(-488881205 ^ -488740317));
			case 2:
				if (component != null)
				{
					ProcessComponent(component.GetType(), component);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	protected virtual void ProcessComponent(Type type, object instance, bool assemblyDisabled = false)
	{
		//Discarded unreachable code: IL_0077, IL_0086
		int num = 2;
		_003C_003Ec__DisplayClass106_0 _003C_003Ec__DisplayClass106_ = default(_003C_003Ec__DisplayClass106_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					ProcessComponent(_003C_003Ec__DisplayClass106_.type, _003C_003Ec__DisplayClass106_.instance, preInitBuilder, _003C_003Ec__DisplayClass106_._003CProcessComponent_003Eb__0, assemblyDisabled);
					num2 = 8;
					break;
				case 7:
					_003C_003Ec__DisplayClass106_.type = type;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 4;
					}
					break;
				case 2:
					_003C_003Ec__DisplayClass106_ = new _003C_003Ec__DisplayClass106_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					_003C_003Ec__DisplayClass106_.instance = instance;
					num2 = 5;
					break;
				case 5:
					if (componentTypes.Contains(_003C_003Ec__DisplayClass106_.type))
					{
						return;
					}
					goto end_IL_0012;
				case 1:
					_003C_003Ec__DisplayClass106_._003C_003E4__this = this;
					num2 = 7;
					break;
				case 3:
					return;
				case 6:
					componentTypes.Add(_003C_003Ec__DisplayClass106_.type);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					break;
				case 8:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	public virtual bool IsProcessedType(Type type)
	{
		return componentTypes.Contains(type);
	}

	private void RunWithShellExtensionPointTypesMap(Action action)
	{
		int num = 1;
		Dictionary<Type, List<Type>> dictionary = default(Dictionary<Type, List<Type>>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					lLPXDTfZulS9hZZw80iO(action);
					num2 = 3;
					continue;
				case 3:
					extensionPointTypesMapToAdd = dictionary;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					dictionary = extensionPointTypesMapToAdd;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				}
				break;
			}
			extensionPointTypesMapToAdd = extensionPointTypesMapShell;
			num = 4;
		}
	}

	public virtual void AddShellComponents(ContainerBuilder containterBuilder)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass109_0 _003C_003Ec__DisplayClass109_ = default(_003C_003Ec__DisplayClass109_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				_003C_003Ec__DisplayClass109_._003C_003E4__this = this;
				num2 = 3;
				break;
			case 0:
				return;
			case 2:
				_003C_003Ec__DisplayClass109_ = new _003C_003Ec__DisplayClass109_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				JFluwafZICIrmHSYkAej(extensionPointTypesMapShell);
				num2 = 4;
				break;
			case 4:
				RunWithShellExtensionPointTypesMap(_003C_003Ec__DisplayClass109_._003CAddShellComponents_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass109_.containterBuilder = containterBuilder;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void ProcessShellComponent(Type type, object instance, ContainerBuilder containerBuilder, params ServiceScope[] serviceScopes)
	{
		int num = 7;
		int num2 = num;
		_003C_003Ec__DisplayClass110_0 _003C_003Ec__DisplayClass110_ = default(_003C_003Ec__DisplayClass110_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				_003C_003Ec__DisplayClass110_.instance = instance;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass110_.type = type;
				num2 = 4;
				break;
			case 1:
				_003C_003Ec__DisplayClass110_.serviceScopes = serviceScopes;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass110_.containerBuilder = containerBuilder;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass110_._003C_003E4__this = this;
				num2 = 2;
				break;
			case 0:
				return;
			case 5:
				RunWithShellExtensionPointTypesMap(_003C_003Ec__DisplayClass110_._003CProcessShellComponent_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				_003C_003Ec__DisplayClass110_ = new _003C_003Ec__DisplayClass110_0();
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private Func<ServiceScope?, bool> SkipByScopes(Type type, ServiceScope[] serviceScopes)
	{
		_003C_003Ec__DisplayClass111_0 _003C_003Ec__DisplayClass111_ = new _003C_003Ec__DisplayClass111_0();
		_003C_003Ec__DisplayClass111_.serviceScopes = serviceScopes;
		_003C_003Ec__DisplayClass111_.type = type;
		return delegate(ServiceScope? scope)
		{
			if (!scope.HasValue)
			{
				return false;
			}
			if (!_003C_003Ec__DisplayClass111_.serviceScopes.Contains(scope.Value))
			{
				if (log.IsVerboseEnabled())
				{
					log.Verbose(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x20201185), _003C_003Ec__DisplayClass111_.type, scope));
				}
				return true;
			}
			return false;
		};
	}

	protected internal virtual void ProcessComponent(Type type, object instance, ContainerBuilder containerBuilder, Func<ServiceScope?, bool> skipCondition, bool assemblyDisabled = false)
	{
		_003C_003Ec__DisplayClass112_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass112_0();
		CS_0024_003C_003E8__locals0.type = type;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.assemblyDisabled = assemblyDisabled;
		if (CS_0024_003C_003E8__locals0.type == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633517449));
		}
		if (registrationData.ComponentsTypesToIgnore.Any((Type t) => t.IsAssignableFrom(CS_0024_003C_003E8__locals0.type)))
		{
			if (log.IsDebugEnabled())
			{
				log.DebugFormat(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x724237EC)), CS_0024_003C_003E8__locals0.type.FullName);
			}
			return;
		}
		if (log.IsVerboseEnabled())
		{
			log.Verbose(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7E9208B)) + CS_0024_003C_003E8__locals0.type);
		}
		ComponentAttribute attribute = AttributeHelper<ComponentAttribute>.GetAttribute(CS_0024_003C_003E8__locals0.type, inherited: true);
		CS_0024_003C_003E8__locals0.itemComponentType = attribute?.Type ?? ComponentType.All;
		Type[] interfaces = CS_0024_003C_003E8__locals0.type.GetInterfaces();
		List<Type> list = new List<Type>();
		list.AddRange(interfaces);
		list.AddRange(from @interface in interfaces.Where(delegate(Type @interface)
			{
				//Discarded unreachable code: IL_006c, IL_007b
				int num4 = 1;
				int num5 = num4;
				while (true)
				{
					switch (num5)
					{
					default:
						if (!@interface.IsGenericType)
						{
							num5 = 3;
							continue;
						}
						goto case 2;
					case 1:
						if (_003C_003Ec.wFbQvx8r0O8IbDdYCK68(@interface, null))
						{
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
							{
								num5 = 0;
							}
							continue;
						}
						break;
					case 2:
						return !@interface.IsGenericTypeDefinition;
					case 3:
						break;
					}
					break;
				}
				return false;
			})
			select @interface.GetGenericTypeDefinition());
		var list2 = list.Select((Type ifc) => new
		{
			ifc = ifc,
			attr = AttributeHelper<ExtensionPointAttribute>.GetAttribute(ifc, inherited: true)
		}).Where(v =>
		{
			if (v.ifc == TypeOf<IEventHandler>.Raw || (v.attr != null && ((v.attr.Type & CS_0024_003C_003E8__locals0._003C_003E4__this.componentType) != 0 || CS_0024_003C_003E8__locals0._003C_003E4__this.registrationData.ComponentsTypesToRegister.Contains(CS_0024_003C_003E8__locals0.type) || CS_0024_003C_003E8__locals0._003C_003E4__this.registrationData.ExtensionPointsToRegister.Contains(v.ifc))))
			{
				if (CS_0024_003C_003E8__locals0.assemblyDisabled)
				{
					ExtensionPointAttribute attr2 = v.attr;
					if (attr2 == null || !attr2.ForceRegister)
					{
						goto IL_00cc;
					}
				}
				if ((CS_0024_003C_003E8__locals0.itemComponentType & CS_0024_003C_003E8__locals0._003C_003E4__this.componentType) == 0)
				{
					return CS_0024_003C_003E8__locals0._003C_003E4__this.componentType == (ComponentType)0;
				}
				return true;
			}
			goto IL_00cc;
			IL_00cc:
			return false;
		}).ToList();
		List<ServiceScope> list3 = (from v in list2
			where v.attr != null
			select v.attr.ServiceScope).Distinct().ToList();
		if (list3.Count > 1)
		{
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3665424), CS_0024_003C_003E8__locals0.type));
		}
		ServiceScope serviceScope = ((list3.Count == 0) ? ServiceScope.Application : list3[0]);
		if (skipCondition(serviceScope))
		{
			if (log.IsDebugEnabled())
			{
				log.DebugFormat(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -489065051)), CS_0024_003C_003E8__locals0.type.FullName, list3);
			}
			return;
		}
		List<Type> list4 = (from v in list2.Where(v =>
			{
				ExtensionPointAttribute attr = v.attr;
				return attr != null && !attr.CreateInstance;
			})
			select v.ifc).ToList();
		if (list4.Count > 0)
		{
			list4.ForEach(delegate(Type ifc)
			{
				int num2 = 1;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						CS_0024_003C_003E8__locals0._003C_003E4__this.AddToExtensionPointTypesMap(ifc, CS_0024_003C_003E8__locals0.type);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num3 = 0;
						}
						break;
					}
				}
			});
			if (CS_0024_003C_003E8__locals0.type.IsInterface && list4.Count == list2.Count)
			{
				return;
			}
		}
		if (CS_0024_003C_003E8__locals0.type.IsInterface || list2.Count == 0)
		{
			return;
		}
		Type[] array = (from v in list2
			where v.ifc == TypeOf<IEventHandler>.Raw || (v.attr.CreateInstance && !TypeOf<IEventHandler>.Raw.IsAssignableFrom(v.ifc))
			select v.ifc).ToArray();
		if (instance == null && CS_0024_003C_003E8__locals0.type.GetConstructors(BindingFlags.Instance | BindingFlags.Public).Length == 0)
		{
			if (log.IsVerboseEnabled())
			{
				log.Verbose(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787129419)) + CS_0024_003C_003E8__locals0.type);
			}
			instance = CreateComponent(CS_0024_003C_003E8__locals0.type);
		}
		IRegistrationBuilder<object, IConcreteActivatorData, SingleRegistrationStyle> val = (IRegistrationBuilder<object, IConcreteActivatorData, SingleRegistrationStyle>)((instance == null) ? ((object)RegistrationExtensions.RegisterType(containerBuilder, CS_0024_003C_003E8__locals0.type).As(new Type[1] { CS_0024_003C_003E8__locals0.type })) : ((object)RegistrationExtensions.RegisterInstance<object>(containerBuilder, instance).As(new Type[1] { CS_0024_003C_003E8__locals0.type })));
		if (array.Length > 1 && log.IsWarnEnabled())
		{
			log.Warn(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1410863425), CS_0024_003C_003E8__locals0.type, string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629843680), array.AsEnumerable())));
		}
		else if (log.IsVerboseEnabled())
		{
			log.Verbose(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643453351), CS_0024_003C_003E8__locals0.type, string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8317830), array.AsEnumerable())));
		}
		if (array.Length != 0)
		{
			val.As(array);
			val.SetScope<object, IConcreteActivatorData, SingleRegistrationStyle>(serviceScope);
		}
		int num = AttributeHelper<ComponentOrderAttribute>.GetAttribute(CS_0024_003C_003E8__locals0.type, inherited: true)?.Order ?? attribute?.Order ?? 0;
		val.WithMetadata(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218155868), (object)num);
		if (attribute != null)
		{
			if (attribute.InjectProerties)
			{
				RegistrationExtensions.PropertiesAutowired<object, IConcreteActivatorData, SingleRegistrationStyle>(val, (PropertyWiringOptions)1);
			}
			if (attribute.EnableInterceptors)
			{
				SetupInterceptors(CS_0024_003C_003E8__locals0.type, (IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>)(object)val);
			}
		}
	}

	public void AddToExtensionPointTypesMap(Type @interface, Type type)
	{
		//Discarded unreachable code: IL_0139
		int num = 8;
		int num2 = num;
		List<Type> list = default(List<Type>);
		List<Type> value = default(List<Type>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				list = new List<Type>();
				num2 = 5;
				break;
			default:
				if (value.Contains(type))
				{
					return;
				}
				num2 = 9;
				break;
			case 7:
				((ILogger)K3ITMvf8s05BklVvjDli()).DebugFormat((string)oB6VAWfvjUcykXtDN2xn(wCv31Xf8BDT6klkASJPg(0x3CE17B75 ^ 0x3CE44365)), type.FullName, @interface.FullName);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 6;
				}
				break;
			case 8:
				if (((ILogger)K3ITMvf8s05BklVvjDli()).IsDebugEnabled())
				{
					num2 = 7;
					break;
				}
				goto case 6;
			case 6:
				if (extensionPointTypesMapToAdd.TryGetValue(@interface, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 1:
				value = list;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 4;
				}
				break;
			case 9:
				value.Add(type);
				num2 = 2;
				break;
			case 5:
				extensionPointTypesMapToAdd.Add(@interface, list);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static Assembly FindLoadedAssembly(string name, bool isFullName)
	{
		//Discarded unreachable code: IL_006d, IL_00c9, IL_018d, IL_01b7, IL_01c6, IL_01d5
		int num = 10;
		Assembly value = default(Assembly);
		_003C_003Ec__DisplayClass114_0 _003C_003Ec__DisplayClass114_ = default(_003C_003Ec__DisplayClass114_0);
		IDictionary<string, Assembly> dictionary2 = default(IDictionary<string, Assembly>);
		byte[] array = default(byte[]);
		IRemotingAssemblyResolverService service = default(IRemotingAssemblyResolverService);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IDictionary<string, Assembly> dictionary;
				switch (num2)
				{
				case 3:
					if (!MLUjBmf8uveewmtmyNK1(value, null))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 1;
				case 8:
					value = ((IEnumerable<Assembly>)LkeEIWfZVP7QvxWcvsKs()).FirstOrDefault(_003C_003Ec__DisplayClass114_._003CFindLoadedAssembly_003Eb__0);
					num2 = 3;
					continue;
				case 2:
				case 5:
				case 11:
				case 13:
					return value;
				case 1:
					if (!ak7x64f8MUeCSWUyQlu7())
					{
						num2 = 11;
						continue;
					}
					goto case 4;
				case 7:
					dictionary2[_003C_003Ec__DisplayClass114_.name] = value;
					num = 13;
					break;
				default:
					array = (byte[])mEg1infZS0RErI5OokjW(service, _003C_003Ec__DisplayClass114_.name, isFullName);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 13;
					}
					continue;
				case 6:
					value = (Assembly)h2sQuRfZivgEJgC38bj4(array);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 7;
					}
					continue;
				case 15:
					if (array != null)
					{
						num2 = 6;
						continue;
					}
					goto case 7;
				case 17:
					if (dictionary2.TryGetValue(_003C_003Ec__DisplayClass114_.name, out value))
					{
						num2 = 5;
						continue;
					}
					goto case 8;
				case 18:
					dictionary = assembliesByName;
					goto IL_024e;
				case 14:
					if (isFullName)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 18;
				case 9:
					_003C_003Ec__DisplayClass114_.name = name;
					num2 = 14;
					continue;
				case 16:
					if (service != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 4:
					service = Locator.GetService<IRemotingAssemblyResolverService>();
					num = 16;
					break;
				case 10:
					_003C_003Ec__DisplayClass114_ = new _003C_003Ec__DisplayClass114_0();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					{
						dictionary = assembliesByFullName;
						goto IL_024e;
					}
					IL_024e:
					dictionary2 = dictionary;
					num2 = 17;
					continue;
				}
				break;
			}
		}
	}

	public static string GetAssemblyShortName(Assembly assembly)
	{
		//Discarded unreachable code: IL_0046, IL_0071, IL_0080, IL_0090, IL_009f
		int num = 2;
		int num2 = num;
		AssemblyName assemblyName = default(AssemblyName);
		string value = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 7:
				obj = string.Empty;
				break;
			default:
				if (assemblyName != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 7;
			case 5:
				assemblyShortNames[assembly] = value;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 4;
				}
				continue;
			case 1:
			case 4:
				return value;
			case 6:
				assemblyName = (AssemblyName)ki2Ea2fZRqwm5SDipU0F(assembly);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (assemblyShortNames.TryGetValue(assembly, out value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 6;
			case 3:
				obj = T72yEwfZqbUN6aBPknoJ(assemblyName);
				break;
			}
			value = (string)obj;
			num2 = 5;
		}
	}

	public static string GetAssemblyFullName(Assembly assembly)
	{
		int num = 1;
		int num2 = num;
		string value = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!assemblyFullNames.TryGetValue(assembly, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				assemblyFullNames[assembly] = value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 2;
				}
				continue;
			default:
				value = (string)s1RFq1fZopCWVkoKLgAB(assembly);
				num2 = 3;
				continue;
			case 2:
				break;
			}
			break;
		}
		return value;
	}

	public static string GetAssemblyLocation(Assembly assembly)
	{
		//Discarded unreachable code: IL_0089, IL_00c1, IL_0112
		int num = 1;
		int num2 = num;
		string value = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				assemblyLocations[assembly] = value;
				num2 = 4;
				continue;
			case 1:
				if (assemblyLocations.TryGetValue(assembly, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 8;
			case 7:
				obj = null;
				break;
			case 6:
				if (j71FQEfZTAOhcfmky4SR(value, string.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 3;
			default:
				return value;
			case 8:
				if (!a3KxhFfZKhxKuAZ4h4ue(assembly))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 7;
			case 2:
				value = null;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 2;
				}
				continue;
			case 5:
				obj = WSLVaGfZXhjki7qCxyVW(assembly);
				break;
			}
			value = (string)obj;
			num2 = 6;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
			{
				num2 = 0;
			}
		}
	}

	public static byte[] GetAssemblyPublicKey(Assembly assembly)
	{
		//Discarded unreachable code: IL_0083, IL_0092
		int num = 3;
		int num2 = num;
		byte[] value = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				assemblyPublicKeys[assembly] = value;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				value = (byte[])UdSXs0fZkr84fpcCDhpr(ki2Ea2fZRqwm5SDipU0F(assembly));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
			case 4:
				return value;
			case 3:
				if (assemblyPublicKeys.TryGetValue(assembly, out value))
				{
					num2 = 2;
					break;
				}
				goto default;
			}
		}
	}

	protected void AddAssembly(Assembly assembly)
	{
		//Discarded unreachable code: IL_0069, IL_0078
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 5:
				return;
			case 3:
				return;
			case 2:
				if (registrationData.Assemblies.Contains(assembly))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 4:
				assembliesByName[GetAssemblyShortName(assembly)] = assembly;
				num2 = 3;
				continue;
			case 6:
				assembliesByFullName[GetAssemblyFullName(assembly)] = assembly;
				num2 = 4;
				continue;
			}
			if (!processedAssemblies.Contains(assembly))
			{
				registrationData.Assemblies.Add(assembly);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 2;
				}
			}
			else
			{
				num2 = 5;
			}
		}
	}

	~ComponentManager()
	{
		//Discarded unreachable code: IL_0046, IL_007d, IL_0090, IL_009f
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				Dispose();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			finally
			{
				base.Finalize();
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		}
	}

	private static Assembly CurrentDomainAssemblyResolve(object sender, object args)
	{
		//Discarded unreachable code: IL_005c, IL_006b, IL_007a
		int num = 3;
		int num2 = num;
		AssemblyName assemblyName = default(AssemblyName);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return FindLoadedAssembly((string)cwFwi1fZne8Cb0Erc622(args), isFullName: true);
			case 6:
				return (Assembly)dGstXOf8bmTXQR0gWfP3(T72yEwfZqbUN6aBPknoJ(assemblyName), false);
			case 5:
				if (!((string)T72yEwfZqbUN6aBPknoJ(assemblyName) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138159018)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 6;
			case 3:
				if (args != null)
				{
					num2 = 2;
					break;
				}
				goto default;
			default:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1410866893));
			case 2:
				assemblyName = new AssemblyName((string)cwFwi1fZne8Cb0Erc622(args));
				num2 = 7;
				break;
			case 7:
				if (!(assemblyName.Name == (string)wCv31Xf8BDT6klkASJPg(-1146510045 ^ -1146507449)))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 6;
			case 4:
				if (j71FQEfZTAOhcfmky4SR(T72yEwfZqbUN6aBPknoJ(assemblyName), wCv31Xf8BDT6klkASJPg(-345420348 ^ -345405630)))
				{
					num2 = 6;
					break;
				}
				goto case 5;
			}
		}
	}

	private static Assembly CurrentDomainReflectionOnlyAssemblyResolve(object sender, object args)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_0063, IL_009a
		int num = 7;
		int num2 = num;
		Assembly assembly = default(Assembly);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (RFH3yXf8G144TwqweIOi(assembly, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 7:
				if (args != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 1;
			case 5:
			case 8:
				return null;
			case 2:
				return (Assembly)KT3enQfZOlQIWilQmmgb(assembly.Location);
			default:
				if (a3KxhFfZKhxKuAZ4h4ue(assembly))
				{
					num2 = 5;
					break;
				}
				goto case 4;
			case 4:
				if (!GLLOL4f8PFRD0nvCwcOm(WSLVaGfZXhjki7qCxyVW(assembly)))
				{
					num2 = 2;
					break;
				}
				goto case 5;
			case 1:
				throw new ArgumentNullException((string)wCv31Xf8BDT6klkASJPg(0x7EC153F ^ 0x7E92DA1));
			case 6:
				assembly = (Assembly)dGstXOf8bmTXQR0gWfP3(cwFwi1fZne8Cb0Erc622(args), true);
				num2 = 3;
				break;
			}
		}
	}

	private static string[] GetAssembliesPathsWithArchitecture(object assembliesPaths)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass154_0 _003C_003Ec__DisplayClass154_ = default(_003C_003Ec__DisplayClass154_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass154_ = new _003C_003Ec__DisplayClass154_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return ((IEnumerable<string>)assembliesPaths).Union(((IEnumerable<string>)assembliesPaths).Select(_003C_003Ec__DisplayClass154_._003CGetAssembliesPathsWithArchitecture_003Eb__0).Where(Directory.Exists)).ToArray();
			default:
				_003C_003Ec__DisplayClass154_.architecturePath = (string)(Environment.Is64BitProcess ? wCv31Xf8BDT6klkASJPg(-70037984 ^ -70156594) : wCv31Xf8BDT6klkASJPg(0x31326106 ^ 0x3136E198));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private IEnumerable<T> GetExtensionPointsInternal<T>()
	{
		Type typeFromHandle = typeof(T);
		if (!cacheEnabled)
		{
			return GetExtensionPointsNonCached<T>();
		}
		if (!cacheAvailability.TryGetValue(typeFromHandle, out var value))
		{
			ExtensionPointAttribute attribute = AttributeHelper<ExtensionPointAttribute>.GetAttribute(typeFromHandle, inherited: true);
			value = attribute != null && (attribute.ServiceScope == ServiceScope.Application || attribute.ServiceScope == ServiceScope.Shell);
			cacheAvailability[typeFromHandle] = value;
		}
		if (value && cache.TryGetValue(typeFromHandle, out var value2))
		{
			return (IEnumerable<T>)value2;
		}
		IEnumerable<T> extensionPointsNonCached = GetExtensionPointsNonCached<T>();
		if (value)
		{
			cache[typeFromHandle] = extensionPointsNonCached;
		}
		return extensionPointsNonCached;
	}

	private IEnumerable<T> GetExtensionPointsNonCached<T>()
	{
		if (stage != LifetimeStage.Initializing && stage != LifetimeStage.InitCompleting && stage != LifetimeStage.Initialized)
		{
			throw new InvalidOperationException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x768EC24)), stage));
		}
		if (!ResolutionExtensions.IsRegistered<T>((IComponentContext)(object)CurrentScope()))
		{
			return Enumerable.Empty<T>();
		}
		return (from v in ResolutionExtensions.Resolve<IEnumerable<Meta<T>>>((IComponentContext)(object)CurrentScope()).Select(delegate(Meta<T> m)
			{
				m.get_Metadata().TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6B6F01), out var value);
				return new
				{
					value = m.get_Value(),
					order = ((value != null) ? ((int)value) : 0)
				};
			})
			orderby v.order
			select v.value).ToList();
	}

	private IEnumerable<MethodInfo> GetIConfigurationServiceMethods(Type type)
	{
		List<Type> list = type.GetInterfaces().Where(delegate(Type intf)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!_003C_003Ec.wFbQvx8r0O8IbDdYCK68(intf, _003C_003Ec.p0to0q8r4vDsnxUQjfRL(typeof(IConfigurationService).TypeHandle)))
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return _003C_003Ec.p0to0q8r4vDsnxUQjfRL(typeof(IConfigurationService).TypeHandle).IsAssignableFrom(intf);
				}
			}
		}).ToList();
		if (!list.Any())
		{
			return null;
		}
		List<MethodInfo> list2 = new List<MethodInfo>();
		foreach (Type item in list)
		{
			MethodInfo[] methods = item.GetMethods();
			foreach (MethodInfo methodInfo in methods)
			{
				MethodInfo method = type.GetMethod(methodInfo.Name, (from p in methodInfo.GetParameters()
					select _003C_003Ec.iyQSkH8rm64EyWdRfKw1(p)).ToArray());
				if (method == null)
				{
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548E9714), methodInfo.Name, type.FullName, item.Name));
				}
				list2.Add(method);
			}
		}
		return list2;
	}

	private Type GetMethodDeclaringType([NotNull] MethodInfo method)
	{
		//Discarded unreachable code: IL_0097, IL_00a6, IL_00b6, IL_00c5, IL_00eb
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
			case 5:
				return s7kgZTfZed9q3PbxsTJO(method);
			case 1:
				return s7kgZTfZed9q3PbxsTJO(method).GetGenericTypeDefinition();
			case 6:
				throw new ArgumentNullException((string)wCv31Xf8BDT6klkASJPg(-561074844 ^ -561008526));
			case 2:
				if (!(method.DeclaringType != null))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto default;
			case 3:
				if (!EaXGAhfZ27BO3moDsl0f(method, null))
				{
					num2 = 2;
					break;
				}
				goto case 6;
			default:
				if (s7kgZTfZed9q3PbxsTJO(method).IsGenericType)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	private ILifetimeScope CurrentScope()
	{
		return (ILifetimeScope)o9fGesfZPJTsI4FiJANW(ResolutionExtensions.Resolve<ILifetimeScopeAccessor>((IComponentContext)(object)currentContainer));
	}

	private void CheckLicensing()
	{
		//Discarded unreachable code: IL_019f, IL_01ae, IL_0262, IL_0271, IL_02f1
		int num = 12;
		List<string> list = default(List<string>);
		List<string> list2 = default(List<string>);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 21:
					return;
				case 9:
				case 19:
					if (initializeTerminatedByLicense)
					{
						num2 = 5;
						continue;
					}
					goto default;
				case 10:
					break;
				case 8:
					if (!list.Any())
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					break;
				default:
					list = ((ModuleManager)moduleManager).GetDisableRequiredModules().ToList();
					num2 = 8;
					continue;
				case 12:
					list2 = ((ModuleManager)moduleManager).GetMissedRequiredModules().ToList();
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 11;
					}
					continue;
				case 20:
					OaDK0CfZ3xZxJHMK3TBT(startControl, StartStatus.NotActivated);
					num2 = 9;
					continue;
				case 2:
					text2 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECE5F08), list);
					num2 = 18;
					continue;
				case 13:
					registrationData.DisabledAssemblies = registrationData.Assemblies.Where((Assembly a) => !xjaheBfZarOXcEacQwjN(moduleManager, a)).ToList();
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 17;
					}
					continue;
				case 11:
					if (!list2.Any())
					{
						num2 = 16;
						continue;
					}
					goto case 4;
				case 7:
					text = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105198624), list2);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 14;
					}
					continue;
				case 4:
					initializeTerminatedByLicense = true;
					num2 = 7;
					continue;
				case 17:
					registrationData.Assemblies = registrationData.Assemblies.Where((Assembly a) => !registrationData.DisabledAssemblies.Contains(a)).ToList();
					num2 = 21;
					continue;
				case 3:
					if (!initializeTerminatedByLicense)
					{
						num2 = 19;
						continue;
					}
					goto case 20;
				case 6:
				case 16:
					if (moduleManager.MainApplication != null)
					{
						num2 = 15;
						continue;
					}
					goto default;
				case 18:
					pxQDF6fZNj7Cl6QyVQ9c(Logger.Log, (string)wCv31Xf8BDT6klkASJPg(-1765851862 ^ -1766193164) + text2);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
				case 22:
					bfD9WwfZp20hURxVIo4X(licenseManager);
					num2 = 13;
					continue;
				case 14:
					pxQDF6fZNj7Cl6QyVQ9c(wYY10Qf8YZfu2qyo2lEJ(), Eei7MCfZ1JFfAnMoJy8e(wCv31Xf8BDT6klkASJPg(0x66F566B6 ^ 0x66F05C0C), text));
					num2 = 6;
					continue;
				case 5:
				case 15:
					initializeTerminatedByLicense = (from module in moduleManager.MainApplication.SystemModules.OfType<ILicensedUnit>()
						select (ILicenseInfo)_003C_003Ec.wlPwbp8ryUFqlLqywFAA(module)).Any(delegate(ILicenseInfo info)
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 1:
								if (info == null)
								{
									return false;
								}
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
								{
									num4 = 0;
								}
								break;
							default:
								return _003C_003Ec.y3HbLV8rMMR5hx5U5egv(info) != LicenseStatus.Activated;
							}
						}
					});
					num2 = 3;
					continue;
				}
				break;
			}
			initializeTerminatedByLicense = true;
			num = 2;
		}
	}

	static ComponentManager()
	{
		int num = 12;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					assembliesByFullName = new ConcurrentDictionary<string, Assembly>();
					num2 = 3;
					continue;
				case 1:
					assembliesByName = new ConcurrentDictionary<string, Assembly>();
					num2 = 8;
					continue;
				case 6:
					return;
				case 12:
					SingletonReader.JJCZtPuTvSt();
					num2 = 11;
					continue;
				case 13:
					assemblyPublicKeys = new ConcurrentDictionary<Assembly, byte[]>();
					num2 = 2;
					continue;
				case 2:
					break;
				case 3:
					assemblyRaws = PublishCacheContext.CreateCache<Assembly, MemoryStream>();
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 5;
					}
					continue;
				case 4:
					assemblyLocations = new ConcurrentDictionary<Assembly, string>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 13;
					}
					continue;
				case 5:
					assemblyShortNames = new ConcurrentDictionary<Assembly, string>();
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 8;
					}
					continue;
				case 11:
					attributeMethodInterceptors = new List<Tuple<Type, string, Type>>
					{
						Tuple.Create(fq0cNOf8iuVHvsiP5PGY(typeof(TransactionInterceptor).TypeHandle), (string)wCv31Xf8BDT6klkASJPg(-1867198571 ^ -1867385667), typeof(TransactionAttribute)),
						Tuple.Create(fq0cNOf8iuVHvsiP5PGY(typeof(ManagerActionsInterceptor).TypeHandle), (string)wCv31Xf8BDT6klkASJPg(0x92F12D5 ^ 0x92A298D), typeof(ActionImplAttribute)),
						Tuple.Create(fq0cNOf8iuVHvsiP5PGY(typeof(AuditInterceptor).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E74004), typeof(AuditableAttribute)),
						Tuple.Create(typeof(ContextCacheInterceptor), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69796673), typeof(ContextCacheAttribute)),
						Tuple.Create(fq0cNOf8iuVHvsiP5PGY(typeof(CacheInterceptor).TypeHandle), (string)wCv31Xf8BDT6klkASJPg(-1765851862 ^ -1766193458), fq0cNOf8iuVHvsiP5PGY(typeof(CacheAttribute).TypeHandle)),
						Tuple.Create(fq0cNOf8iuVHvsiP5PGY(typeof(ComplexCacheInterceptor).TypeHandle), (string)wCv31Xf8BDT6klkASJPg(0x20261A4F ^ 0x20232647), fq0cNOf8iuVHvsiP5PGY(typeof(ComplexCacheAttribute).TypeHandle))
					};
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 7;
					}
					continue;
				case 7:
					typeInterceptors = new List<Tuple<Type, string, Type>> { Tuple.Create(typeof(CallSessionInterceptor), (string)wCv31Xf8BDT6klkASJPg(0x1C9495B4 ^ 0x1C91A98E), fq0cNOf8iuVHvsiP5PGY(typeof(IConfigurationService).TypeHandle)) };
					num2 = 9;
					continue;
				default:
					interceptorNames = attributeMethodInterceptors.Select((Tuple<Type, string, Type> t) => t.Item2).Union(typeInterceptors.Select((Tuple<Type, string, Type> t) => t.Item2)).Union(requiredInterceptors.Select((Tuple<Type, string> t) => t.Item2))
						.ToList();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					assemblyFullNames = new ConcurrentDictionary<Assembly, string>();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 4;
					}
					continue;
				case 9:
					requiredInterceptors = new List<Tuple<Type, string>> { Tuple.Create(fq0cNOf8iuVHvsiP5PGY(typeof(DiagnosticsInterceptor).TypeHandle), (string)wCv31Xf8BDT6klkASJPg(-420743386 ^ -420558004)) };
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			assemblyIsModelResults = new ConcurrentDictionary<Assembly, bool>();
			num = 6;
		}
	}

	internal static object oB6VAWfvjUcykXtDN2xn(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool DfU7MqfvgnrTvlixFv2l()
	{
		return QJMBdufvrLQnbvJUYYZb == null;
	}

	internal static ComponentManager OrtUyJfv5EsrNuDXPo3c()
	{
		return QJMBdufvrLQnbvJUYYZb;
	}

	internal static object rmS4nRfvYnQowt8RKw6Y(object P_0, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, writable);
	}

	internal static object ajNSXxfvLetrW0lfpyqb(object P_0, object P_1)
	{
		return LoadAssembly((MemoryStream)P_0, (MemoryStream)P_1);
	}

	internal static bool fCv9KKfvUqj26fb31diw(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static long nqrMNBfvsYqLRb8dCEKG(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static void SK5GEgfvc1bJ2EjpDtgL(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static long sLdQBBfvzH8cyZvmUkMb(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static void GZq6Oaf8FISSCf4iMf0C(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object wCv31Xf8BDT6klkASJPg(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object xFOOAUf8WGtTJQHqHNVa(object P_0, object P_1)
	{
		return Path.ChangeExtension((string)P_0, (string)P_1);
	}

	internal static object FoVNpRf8oMBqyZSXryE6(int requiredSize)
	{
		return MemoryHelper.GetMemoryStream(requiredSize);
	}

	internal static object dGstXOf8bmTXQR0gWfP3(object P_0, bool isFullName)
	{
		return FindLoadedAssembly((string)P_0, isFullName);
	}

	internal static object PMS0jff8hmwqAq23WOsK(object P_0, object P_1)
	{
		return LoadAssembly((byte[])P_0, (byte[])P_1);
	}

	internal static bool RFH3yXf8G144TwqweIOi(object P_0, object P_1)
	{
		return (Assembly)P_0 != (Assembly)P_1;
	}

	internal static object OLJy54f8ET3bhgMLXCAm(object P_0)
	{
		return EntityDynamicGenerator.CheckAssembly((MemoryStream)P_0);
	}

	internal static object jWxwSbf8fSObbiwFJuE8(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static object RkCv57f8QQLg0Cwd5X11(object P_0, object P_1)
	{
		return Assembly.Load((byte[])P_0, (byte[])P_1);
	}

	internal static object kaxDhff8CmFtTDwlJshq(object P_0)
	{
		return ((MemoryStream)P_0).AsReadOnly();
	}

	internal static object x64lvJf8v6CF4oxdDeL5(object P_0)
	{
		return GetAssemblyFullName((Assembly)P_0);
	}

	internal static object n9g3yIf88CaM0X95aYoX(object P_0)
	{
		return GetAssemblyShortName((Assembly)P_0);
	}

	internal static object nPjKSNf8ZLZ15ThUoVfp(object P_0)
	{
		return GetLoadedAssemblyRawAsStream((Assembly)P_0);
	}

	internal static bool MLUjBmf8uveewmtmyNK1(object P_0, object P_1)
	{
		return (Assembly)P_0 == (Assembly)P_1;
	}

	internal static object T4L9EQf8IXdhwhUHsXDu()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object v5Q9sxf8V01q5Iw9Niyo(object P_0)
	{
		return GetAssemblies((AppDomain)P_0);
	}

	internal static object zdh7Gvf8SStPvj8tRfiU(object P_0)
	{
		return ((AppDomain)P_0).GetAssemblies();
	}

	internal static Type fq0cNOf8iuVHvsiP5PGY(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool QW7fFif8RUT9OOfShLAn(object P_0, Type P_1, bool P_2)
	{
		return ((Assembly)P_0).IsDefined(P_1, P_2);
	}

	internal static object UHpgitf8qjb4qfO8dayD()
	{
		return Current;
	}

	internal static void q9Em1cf8KGVrygmCgNB8()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void MDhNfRf8XTOyqDV7LOcj(object P_0, object P_1)
	{
		((AppDomain)P_0).AssemblyResolve += (ResolveEventHandler)P_1;
	}

	internal static void zNG16vf8TI2LJqYeDHPf(object P_0, object P_1)
	{
		((AppDomain)P_0).ReflectionOnlyAssemblyResolve += (ResolveEventHandler)P_1;
	}

	internal static void Tv4ncrf8kNlRhOhmeKEG(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object pg5KxNf8n9c69kdxEpZb(object P_0)
	{
		return GetAssembliesPathsWithArchitecture(P_0);
	}

	internal static object zCdDexf8Ov8Ow1CLnVht(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static object OB3ZKXf82AiHB1c8go0f(double completePercent, object P_1)
	{
		return StartInformation.Operation(completePercent, (string)P_1);
	}

	internal static object Ywh3E7f8esDbbESNlstN(object P_0)
	{
		return ((PackageService)P_0).ComponentName;
	}

	internal static bool GLLOL4f8PFRD0nvCwcOm(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void HBYsiLf81Ud8SNSZpPdy(object P_0)
	{
		((PackageService)P_0).Initialize();
	}

	internal static void zaKxIrf8NQ2IJrNHDgOr(object P_0)
	{
		((LicenseManager)P_0).ApplyAllActivationKeys();
	}

	internal static void gU1fdof83wfgD06oHiei(object P_0)
	{
		((ComponentManager)P_0).Init();
	}

	internal static void r87KH2f8pPCgu5NM7KpL(object P_0, object P_1)
	{
		((ContainerBuilder)P_0).Update((IContainer)P_1);
	}

	internal static void gy6LMvf8aAA8sK6LetIh(object P_0)
	{
		((ConcurrentDictionary<Type, object>)P_0).Clear();
	}

	internal static void O8pAoYf8D1FNnpmN6Lde(object P_0, object P_1)
	{
		((AppDomain)P_0).AssemblyResolve -= (ResolveEventHandler)P_1;
	}

	internal static void cUPMLcf8t8o2OHJEXnGT(object P_0, bool disposing)
	{
		((ComponentManager)P_0).Dispose(disposing);
	}

	internal static void QuZb1gf8wZgJPPqATKGy(object P_0, object P_1)
	{
		((IStartInformation)P_0).SetInfo((string)P_1);
	}

	internal static void xbaUumf84xps0wdtJv35(object P_0)
	{
		((IRuntimeApplication)P_0).OnApplicationStarting();
	}

	internal static object iCXEMjf86FkZ4CMmCrMa(object P_0)
	{
		return ((IRuntimeApplication)P_0).ApplicationStartCache;
	}

	internal static void obs47Ef8HCmXygAAEXBM(object P_0)
	{
		((ComponentManager)P_0).RegisterAutofacInterceptors();
	}

	internal static void vHp45Ff8AxB2Ll7CoFDt(object P_0)
	{
		((ComponentManager)P_0).RegisterAutofacModules();
	}

	internal static object AvZseCf87nQFXfGZQCuK()
	{
		return StartInformation.Current;
	}

	internal static object LZ008Nf8xmu585fmbT9g(object P_0)
	{
		return ((IStartInformation)P_0).Message;
	}

	internal static object i5KsxUf80NLvuC9y1TJH(object P_0)
	{
		return ((IRuntimeApplication)P_0).DbPreUpdater;
	}

	internal static void BTftcJf8mQJ0fJiLolaw(object P_0, object P_1)
	{
		((ComponentManager)P_0).RegisterData((RegistrationData)P_1);
	}

	internal static void S2Tp5lf8yImDLkmk4tjl(object P_0, double value)
	{
		((IStartInformation)P_0).Percent = value;
	}

	internal static bool ak7x64f8MUeCSWUyQlu7()
	{
		return Locator.Initialized;
	}

	internal static object zZxacwf8JxHmadkXTyJS(object P_0, ContainerBuildOptions P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ContainerBuilder)P_0).Build(P_1);
	}

	internal static void dKon21f89ADKk47U06VN(object P_0)
	{
		Locator.SetImpl((ILocatorImpl)P_0);
	}

	internal static void m7QHUtf8dZ9i8Ndx3bXb(object P_0, object P_1)
	{
		((ComponentManager)P_0).ProcessComponent(P_1);
	}

	internal static object P7ty2Tf8ljIjsQ73A092(object P_0, object P_1)
	{
		return ModuleRegistrationExtensions.RegisterModule((ContainerBuilder)P_0, (IModule)P_1);
	}

	internal static object RpN0Cif8rMl36lDkbCPb(object P_0, object P_1)
	{
		return Directory.GetFiles((string)P_0, (string)P_1);
	}

	internal static object xhDBvwf8giCa1LwM4d84(object P_0)
	{
		return Assembly.LoadFrom((string)P_0);
	}

	internal static object qZRn8xf85fbF35GLkVx7(object P_0)
	{
		return File.ReadAllBytes((string)P_0);
	}

	internal static object BBH6ZXf8jMvCBLNJBUG0(object P_0, object P_1)
	{
		return ((AppDomain)P_0).Load((byte[])P_1);
	}

	internal static object wYY10Qf8YZfu2qyo2lEJ()
	{
		return Logger.Log;
	}

	internal static void yVWEs6f8L7ZQtBtryb75(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static bool pMYTqhf8UFUy6jrJ5ODO(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object K3ITMvf8s05BklVvjDli()
	{
		return log;
	}

	internal static void LB0mCcf8cq99ok71aam0(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object fwAmGgf8zofGfRgrkkHS(object P_0, object P_1)
	{
		return ((ApplicationStartCache)P_0).GetAssemblyInfo((Assembly)P_1);
	}

	internal static bool ccwPrsfZFfxGqf7KjX5X(object P_0, object P_1)
	{
		return ((ComponentManager)P_0).IsComponentAssembly((Assembly)P_1);
	}

	internal static object VSD4gpfZBv3GyDn7IbhH(object P_0)
	{
		return ((ReflectionTypeLoadException)P_0).LoaderExceptions;
	}

	internal static object E1nOPTfZWFcbapix9WGp(object P_0, object P_1)
	{
		return string.Join((string)P_0, (string[])P_1);
	}

	internal static object s1RFq1fZopCWVkoKLgAB(object P_0)
	{
		return ((Assembly)P_0).FullName;
	}

	internal static object jMRKQmfZb6NgS6ZwZvMi(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static bool mex9u6fZhL1d3Aq3MgS0(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static object ah0QgIfZG8YS1QTM2hsV(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static bool Q1IZdBfZEF00fCvibT7o(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool ErSpsGfZfEQpWCmqJs9J(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool TieWjafZQfkqmZD9ZTHY(object P_0, Type type)
	{
		return ((ComponentManager)P_0).IsComponentType(type);
	}

	internal static object caqunGfZCSCVAp24EyF5(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
	}

	internal static Type NAKZrlfZvugthLE49hhX(object P_0)
	{
		return ((ImplementAttribute)P_0).InterfaceType;
	}

	internal static bool QoPPLJfZ8RCjmLbtMORD(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).IsDefined(P_1, P_2);
	}

	internal static object uquioYfZZPrSnh2AyBLt(Type P_0, bool P_1)
	{
		return Activator.CreateInstance(P_0, P_1);
	}

	internal static void lLPXDTfZulS9hZZw80iO(object P_0)
	{
		P_0();
	}

	internal static void JFluwafZICIrmHSYkAej(object P_0)
	{
		((Dictionary<Type, List<Type>>)P_0).Clear();
	}

	internal static object LkeEIWfZVP7QvxWcvsKs()
	{
		return GetAssemblies();
	}

	internal static object mEg1infZS0RErI5OokjW(object P_0, object P_1, bool isFullName)
	{
		return ((IRemotingAssemblyResolverService)P_0).ResolveAssembly((string)P_1, isFullName);
	}

	internal static object h2sQuRfZivgEJgC38bj4(object P_0)
	{
		return LoadAssembly((byte[])P_0);
	}

	internal static object ki2Ea2fZRqwm5SDipU0F(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object T72yEwfZqbUN6aBPknoJ(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static bool a3KxhFfZKhxKuAZ4h4ue(object P_0)
	{
		return ((Assembly)P_0).IsDynamic;
	}

	internal static object WSLVaGfZXhjki7qCxyVW(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static bool j71FQEfZTAOhcfmky4SR(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object UdSXs0fZkr84fpcCDhpr(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKey();
	}

	internal static object cwFwi1fZne8Cb0Erc622(object P_0)
	{
		return ((ResolveEventArgs)P_0).Name;
	}

	internal static object KT3enQfZOlQIWilQmmgb(object P_0)
	{
		return Assembly.ReflectionOnlyLoadFrom((string)P_0);
	}

	internal static bool EaXGAhfZ27BO3moDsl0f(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static Type s7kgZTfZed9q3PbxsTJO(object P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}

	internal static object o9fGesfZPJTsI4FiJANW(object P_0)
	{
		return ((ILifetimeScopeAccessor)P_0).Current;
	}

	internal static object Eei7MCfZ1JFfAnMoJy8e(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void pxQDF6fZNj7Cl6QyVQ9c(object P_0, object P_1)
	{
		((ILogger)P_0).Warn(P_1);
	}

	internal static void OaDK0CfZ3xZxJHMK3TBT(object P_0, StartStatus suspendReason)
	{
		((IStartControl)P_0).Suspend(suspendReason);
	}

	internal static void bfD9WwfZp20hURxVIo4X(object P_0)
	{
		((LicenseManager)P_0).CompleteLicensingInitialize();
	}

	internal static bool xjaheBfZarOXcEacQwjN(object P_0, object P_1)
	{
		return ((IModuleManager)P_0).IsAssemblyAvailable((Assembly)P_1);
	}
}
