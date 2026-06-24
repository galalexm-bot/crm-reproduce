using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using EleWise.ELMA.Packaging.Extensions;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Packaging.Logging;
using EleWise.ELMA.Packaging.ProjectSystem;
using NuGet;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public class ManifestGeneratorHelper
{
	private const string PackagingFolderName = "ElmaPackaging";

	private static readonly FrameworkName TargetFrameworkName;

	private static readonly string[] ExcludeFolders;

	private static readonly string[] IncludeExtensions;

	public static string CreateBaseDirForRemoteDomain()
	{
		string text = Path.Combine(GetRootDir(), Guid.NewGuid().ToString("n"));
		if (!Directory.Exists(text))
		{
			FS.CreateDirectory(text);
		}
		return text;
	}

	internal static void PurgeTempFoldersOlderThan(DateTime thresholdTime)
	{
		string rootDir = GetRootDir();
		if (!Directory.Exists(rootDir))
		{
			return;
		}
		foreach (string item in from d in Directory.EnumerateDirectories(rootDir)
			where Directory.GetCreationTime(d) < thresholdTime
			select d)
		{
			Directory.Delete(item, recursive: true);
		}
	}

	private static string GetRootDir()
	{
		return Path.Combine(Path.GetTempPath(), "ElmaPackaging");
	}

	public static RemoteDomain CreatNewDomain(string name, List<string> sourcePaths, List<IPackage> packages, out AppDomain domain)
	{
		string text = Path.Combine(GetRootDir(), Guid.NewGuid().ToString("n"));
		if (!Directory.Exists(text))
		{
			FS.CreateDirectory(text);
		}
		AppDomainSetup info = new AppDomainSetup
		{
			ApplicationBase = text,
			PrivateBinPath = text,
			ConfigurationFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile
		};
		domain = AppDomain.CreateDomain(name, AppDomain.CurrentDomain.Evidence, info);
		foreach (string sourcePath in sourcePaths)
		{
			foreach (string item in Directory.GetFiles(sourcePath, "*.dll").Union(Directory.GetFiles(sourcePath, "*.exe")))
			{
				string fileName = Path.GetFileName(item);
				string targetFileName = Path.Combine(text, fileName);
				FS.CopyFile(item, targetFileName, overwrite: true);
			}
		}
		foreach (IPackage package in packages)
		{
			foreach (IPackageFile file2 in package.GetFiles())
			{
				string extension = Path.GetExtension(file2.get_Path());
				if (extension != null && (extension.Equals(".dll") || extension.Equals(".exe")))
				{
					string tmpFilePath = Path.Combine(text, Path.GetFileName(file2.get_Path()));
					IPackageFile file = file2;
					FS.CreateFile(tmpFilePath, delegate
					{
						File.WriteAllBytes(tmpFilePath, file.GetStream().ReadAllBytes());
					});
				}
			}
		}
		return (RemoteDomain)domain.CreateInstanceAndUnwrap(typeof(RemoteDomain).Assembly.FullName, typeof(RemoteDomain).FullName);
	}

	public static List<Assembly> GetPackageAssemblies(string tmpPath, IPackageBuilder package)
	{
		return GetPackageAssemblies(tmpPath, package.get_Files().ToList());
	}

	public static List<Assembly> GetPackageAssemblies(string tmpPath, IPackage package)
	{
		IEnumerable<IPackageFile> enumerable;
		if (!new ElmaPackageMetadata(((IPackageMetadata)package).get_Tags()).ELMA)
		{
			IEnumerable<IPackageFile> compatibleByFrameworkVersionAssemblies = (IEnumerable<IPackageFile>)GetCompatibleByFrameworkVersionAssemblies(package, TargetFrameworkName);
			enumerable = compatibleByFrameworkVersionAssemblies;
		}
		else
		{
			enumerable = package.GetFiles().Where(IsValidAssembly);
		}
		IEnumerable<IPackageFile> source = enumerable;
		return GetPackageAssemblies(tmpPath, source.ToList());
	}

	private static bool IsValidAssembly(IPackageFile packageFile)
	{
		string extension = Path.GetExtension(packageFile.get_Path());
		string directoryName = Path.GetDirectoryName(packageFile.get_Path());
		if (IncludeExtensions.Any(extension.Equals))
		{
			return !ExcludeFolders.Any(directoryName.Contains);
		}
		return false;
	}

	private static IEnumerable<IPackageAssemblyReference> GetCompatibleByFrameworkVersionAssemblies(IPackage package, FrameworkName targetFramework)
	{
		IEnumerable<IPackageAssemblyReference> source = default(IEnumerable<IPackageAssemblyReference>);
		if (VersionUtility.TryGetCompatibleItems<IPackageAssemblyReference>(targetFramework, package.get_AssemblyReferences(), ref source))
		{
			return source.Where((IPackageAssemblyReference p) => p != null);
		}
		return Enumerable.Empty<IPackageAssemblyReference>();
	}

	public static List<Assembly> GetPackageAssemblies(string tmpPath, List<IPackageFile> files)
	{
		List<Assembly> list = new List<Assembly>();
		List<string> list2 = new List<string>();
		foreach (IPackageFile packageFile in files)
		{
			byte[] array;
			using (Stream stream = packageFile.GetStream())
			{
				array = stream.ReadAllBytes();
			}
			string assemblyHashString = GetAssemblyHash(array);
			string fileName = Path.GetFileName(packageFile.get_Path());
			fileName = Path.GetFileNameWithoutExtension(fileName) + "_" + assemblyHashString + Path.GetExtension(fileName);
			string tmpFilePath = Path.Combine(tmpPath, fileName);
			if (list2.Any((string a) => a.Equals(tmpFilePath, StringComparison.OrdinalIgnoreCase)))
			{
				continue;
			}
			if (!File.Exists(tmpFilePath))
			{
				File.WriteAllBytes(tmpFilePath, array);
			}
			AssemblyName asmName;
			try
			{
				asmName = AssemblyName.GetAssemblyName(tmpFilePath);
			}
			catch (BadImageFormatException)
			{
				continue;
			}
			Assembly assembly = AppDomain.CurrentDomain.ReflectionOnlyGetAssemblies().FirstOrDefault(delegate(Assembly a)
			{
				try
				{
					if (!a.ReflectionOnly || a.IsDynamic || string.IsNullOrEmpty(a.Location))
					{
						return false;
					}
				}
				catch
				{
					return false;
				}
				return a.FullName.Equals(asmName.FullName);
			});
			if (assembly == null)
			{
				try
				{
					assembly = Assembly.ReflectionOnlyLoadFrom(tmpFilePath);
				}
				catch (Exception ex2)
				{
					Logger.Log.Error("Cannot load assembly " + tmpFilePath, ex2);
					assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(delegate(Assembly a)
					{
						try
						{
							if (a.ReflectionOnly || a.IsDynamic || string.IsNullOrEmpty(a.Location))
							{
								return false;
							}
						}
						catch
						{
							return false;
						}
						return Path.GetFileName(a.Location).Equals(Path.GetFileName(packageFile.get_Path())) && GetAssemblyHash(File.ReadAllBytes(a.Location)).Equals(assemblyHashString);
					});
					if (assembly == null)
					{
						throw new InvalidOperationException(SR.T("Не удалось загрузить сборку \"{0}\". Подробности смотрите в журнале ошибок системы.", Path.GetFileName(packageFile.get_Path())), ex2);
					}
				}
			}
			list.Add(assembly);
			list2.Add(tmpFilePath);
		}
		return list;
	}

	private static string GetAssemblyHash(byte[] asmBytes)
	{
		using SHA1Managed sHA1Managed = new SHA1Managed();
		return Convert.ToBase64String(sHA1Managed.ComputeHash(asmBytes)).Replace('/', '#').Replace('=', '@');
	}

	public static Type[] GetTypesLoaded(Assembly assembly)
	{
		try
		{
			return assembly.GetTypes();
		}
		catch (ReflectionTypeLoadException ex)
		{
			return ex.Types.Where((Type t) => t != null).ToArray();
		}
	}

	protected static bool CheckCustomAttributesData(CustomAttributeData d, string typeName)
	{
		if (d.Constructor == null)
		{
			return false;
		}
		if (d.Constructor.DeclaringType == null)
		{
			return false;
		}
		return d.Constructor.DeclaringType.FullName == typeName;
	}

	public static List<EntityManifest> GetEntitiesFromAssemblies(List<Assembly> assemblies)
	{
		List<EntityManifest> list = new List<EntityManifest>();
		TypeFilter entityInterfaceFilter = (Type t, object c) => (t.ToString() == c.ToString()) ? true : false;
		foreach (Assembly assembly in assemblies)
		{
			foreach (Type item in (from type in GetTypesLoaded(assembly)
				where type.FindInterfaces(entityInterfaceFilter, "EleWise.ELMA.Model.Entities.IEntity").Length != 0
				select type).ToList())
			{
				try
				{
					CustomAttributeData customAttributeData = item.GetCustomAttributesData().FirstOrDefault((CustomAttributeData d) => CheckCustomAttributesData(d, "EleWise.ELMA.Model.Attributes.UidAttribute"));
					Guid guid = ((!string.IsNullOrWhiteSpace(item.FullName)) ? GetDeterministicGuid(item.FullName) : Guid.Empty);
					if (customAttributeData != null && customAttributeData.ConstructorArguments.Any())
					{
						guid = new Guid(customAttributeData.ConstructorArguments.First().Value.ToString());
					}
					CustomAttributeData customAttributeData2 = item.GetCustomAttributesData().FirstOrDefault((CustomAttributeData d) => CheckCustomAttributesData(d, "EleWise.ELMA.Model.Attributes.EntityAttribute"));
					string text = string.Empty;
					if (customAttributeData2 != null && customAttributeData2.ConstructorArguments.Any())
					{
						text = (string)customAttributeData2.ConstructorArguments.First().Value;
					}
					CustomAttributeData customAttributeData3 = item.GetCustomAttributesData().FirstOrDefault((CustomAttributeData d) => CheckCustomAttributesData(d, "EleWise.ELMA.Model.Attributes.EntityMetadataTypeAttribute"));
					int entityMetadataType = 1;
					if (customAttributeData3 != null && customAttributeData3.ConstructorArguments.Any())
					{
						entityMetadataType = Convert.ToInt32(customAttributeData3.ConstructorArguments.First().Value);
					}
					if (guid != Guid.Empty && !string.IsNullOrEmpty(text))
					{
						list.Add(new EntityManifest
						{
							Name = item.Name,
							Namespace = item.Namespace,
							Uid = guid,
							TableName = text,
							EntityMetadataType = entityMetadataType
						});
					}
				}
				catch (Exception innerException)
				{
					Logger.Log.Error("Cannot create EntityManifest for type " + item.FullName);
					throw new InvalidOperationException(SR.T("Не удалось получить описание манифеста сущности для типа \"{0}\". Подробности смотрите в журнале ошибок системы.", item.FullName), innerException);
				}
			}
		}
		return list;
	}

	public static List<EnumManifest> GetEnumsFromAssemblies(List<Assembly> assemblies)
	{
		List<EnumManifest> list = new List<EnumManifest>();
		foreach (Assembly assembly in assemblies)
		{
			foreach (Type item in (from type in GetTypesLoaded(assembly)
				where type.IsEnum
				select type).ToList())
			{
				try
				{
					if (item.GetCustomAttributesData().FirstOrDefault((CustomAttributeData d) => CheckCustomAttributesData(d, "EleWise.ELMA.Model.Attributes.MetadataTypeAttribute")) != null)
					{
						CustomAttributeData customAttributeData = item.GetCustomAttributesData().FirstOrDefault((CustomAttributeData d) => CheckCustomAttributesData(d, "EleWise.ELMA.Model.Attributes.UidAttribute"));
						Guid guid = ((!string.IsNullOrWhiteSpace(item.FullName)) ? GetDeterministicGuid(item.FullName) : Guid.Empty);
						if (customAttributeData != null && customAttributeData.ConstructorArguments.Any())
						{
							guid = new Guid(customAttributeData.ConstructorArguments.First().Value.ToString());
						}
						if (guid != Guid.Empty)
						{
							list.Add(new EnumManifest
							{
								Name = item.Name,
								Namespace = item.Namespace,
								Uid = guid
							});
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}
		return list;
	}

	public static List<PackageDependencyManifest> GetDepedenciesFromPackage(IEnumerable<PackageDependencySet> dependencySets)
	{
		List<PackageDependencyManifest> list = new List<PackageDependencyManifest>();
		foreach (PackageDependencySet dependencySet in dependencySets)
		{
			foreach (PackageDependency dependency in dependencySet.get_Dependencies())
			{
				list.Add(new PackageDependencyManifest
				{
					Id = dependency.get_Id(),
					Version = ((dependency.get_VersionSpec() != null) ? ((object)dependency.get_VersionSpec()).ToString() : null)
				});
			}
		}
		return list;
	}

	public static List<PackageDependencyManifest> GetDepedenciesFromPackage(IPackage package)
	{
		return GetDepedenciesFromPackage(((IPackageMetadata)package).get_DependencySets());
	}

	public static List<PackageDependencyManifest> GetDepedenciesFromPackage(IPackageBuilder builder)
	{
		return GetDepedenciesFromPackage(((IPackageMetadata)builder).get_DependencySets());
	}

	public static List<StoredProcedureManifest> GetStoredProceduresFromAssemblies(List<Assembly> assemblies)
	{
		List<StoredProcedureManifest> list = new List<StoredProcedureManifest>();
		TypeFilter dbStructureExtensionTypeFilter = (Type t, object c) => (t.ToString() == c.ToString()) ? true : false;
		foreach (Assembly assembly in assemblies)
		{
			List<Type> list2 = (from type in GetTypesLoaded(assembly)
				where type.FindInterfaces(dbStructureExtensionTypeFilter, "EleWise.ELMA.ExtensionPoints.IDbStructureExtension").Length != 0
				select type).ToList();
			if (list2.Count == 0)
			{
				continue;
			}
			foreach (Type item in list2)
			{
				try
				{
					string text = item.FullName + ".xml";
					List<string> list3 = new List<string>();
					string text2 = string.Empty;
					using (Stream stream = assembly.GetManifestResourceStream(text))
					{
						if (stream == null)
						{
							continue;
						}
						using (StreamReader streamReader = new StreamReader(stream))
						{
							string xml = streamReader.ReadToEnd();
							XmlDocument xmlDocument = new XmlDocument();
							xmlDocument.LoadXml(xml);
							XmlNode xmlNode = xmlDocument.FirstChild;
							while (xmlNode != null && xmlNode.Name != "root")
							{
								xmlNode = xmlNode.NextSibling;
							}
							if (xmlNode == null)
							{
								throw new Exception(SR.T("Неверный файл структуры (Корневой элемент должен быть с именем \"root\""));
							}
							if (xmlNode.Attributes["provider"] != null)
							{
								text2 = xmlNode.Attributes["provider"].Value;
							}
							for (XmlNode xmlNode2 = xmlNode.FirstChild; xmlNode2 != null; xmlNode2 = xmlNode2.NextSibling)
							{
								if (xmlNode2.Name.ToUpper() == "PROCEDURES")
								{
									for (XmlNode xmlNode3 = xmlNode2.FirstChild; xmlNode3 != null; xmlNode3 = xmlNode3.NextSibling)
									{
										if (xmlNode3.Name.ToUpper() == "PROCEDURE")
										{
											for (XmlNode xmlNode4 = xmlNode3.FirstChild; xmlNode4 != null; xmlNode4 = xmlNode4.NextSibling)
											{
												if (xmlNode4.Name == "text")
												{
													list3.Add(xmlNode4.InnerText);
												}
											}
										}
									}
								}
							}
						}
						goto IL_0211;
					}
					IL_0211:
					foreach (string item2 in list3)
					{
						string text3 = UniversalProcedureNameFromText(item2);
						if (!string.IsNullOrEmpty(text3))
						{
							if (string.IsNullOrEmpty(text2))
							{
								throw new Exception(SR.T("Не задана СУБД в атрибуте provider {0}-{1}", assembly.FullName, text));
							}
							list.Add(new StoredProcedureManifest
							{
								Name = text3,
								Database = text2
							});
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}
		return list;
	}

	public static List<ExtensionPointManifest> GetExtensionPointsFromAssemblies(List<Assembly> assemblies, out List<string> extPoints)
	{
		List<ExtensionPointManifest> list = new List<ExtensionPointManifest>();
		extPoints = new List<string>();
		foreach (Assembly assembly in assemblies)
		{
			foreach (Type item2 in GetTypesLoaded(assembly).Where(delegate(Type t)
			{
				try
				{
					return t.GetCustomAttributesData().FirstOrDefault((CustomAttributeData d) => CheckCustomAttributesData(d, "EleWise.ELMA.ComponentModel.ExtensionPointAttribute")) != null;
				}
				catch (Exception)
				{
					return false;
				}
			}).ToList())
			{
				try
				{
					extPoints.Add(item2.FullName);
					ExtensionPointManifest item = new ExtensionPointManifest
					{
						Name = item2.FullName,
						Properties = GetPropertiesFromType(item2),
						Methods = GetMethodsFromType(item2)
					};
					list.Add(item);
				}
				catch (Exception)
				{
				}
			}
		}
		return list;
	}

	public static List<ComponentManifest> GetComponentsFromAssemblies(List<Assembly> assemblies, List<string> extPoints)
	{
		List<ComponentManifest> list = new List<ComponentManifest>();
		foreach (Assembly assembly in assemblies)
		{
			foreach (Type item2 in GetTypesLoaded(assembly).Where(delegate(Type t)
			{
				try
				{
					return t.GetCustomAttributesData().FirstOrDefault((CustomAttributeData d) => CheckCustomAttributesData(d, "EleWise.ELMA.ComponentModel.ComponentAttribute")) != null;
				}
				catch (Exception)
				{
					return false;
				}
			}).ToList())
			{
				List<Type> source = item2.GetInterfaces().Where(delegate(Type t)
				{
					try
					{
						return t.GetCustomAttributesData().FirstOrDefault((CustomAttributeData d) => CheckCustomAttributesData(d, "EleWise.ELMA.ComponentModel.ExtensionPointAttribute")) != null;
					}
					catch (Exception)
					{
						return false;
					}
				}).ToList();
				source = source.Where((Type i) => extPoints.All((string p) => p != i.FullName)).ToList();
				try
				{
					foreach (Type item3 in source)
					{
						List<PropertyCodeManifest> interfaceProps = GetPropertiesFromType(item3);
						List<MethodCodeManifest> interfaceMethods = GetMethodsFromType(item3);
						ComponentManifest item = new ComponentManifest
						{
							Name = item2.FullName,
							Properties = (from p in GetPropertiesFromType(item2)
								where interfaceProps.Contains(p)
								select p).ToList(),
							Methods = (from m in GetMethodsFromType(item2)
								where interfaceMethods.Contains(m)
								select m).ToList(),
							ExtensionPoint = item3.FullName
						};
						list.Add(item);
					}
				}
				catch (Exception)
				{
				}
			}
		}
		return list;
	}

	public static List<PropertyCodeManifest> GetPropertiesFromType(Type type)
	{
		List<PropertyCodeManifest> list = new List<PropertyCodeManifest>();
		PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (PropertyInfo propertyInfo in properties)
		{
			PropertyCodeManifest item = new PropertyCodeManifest
			{
				Name = propertyInfo.Name,
				Type = propertyInfo.PropertyType.FullName
			};
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public static List<MethodCodeManifest> GetMethodsFromType(Type type)
	{
		List<MethodCodeManifest> list = new List<MethodCodeManifest>();
		MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			MethodCodeManifest methodCodeManifest = new MethodCodeManifest
			{
				Name = methodInfo.Name,
				ReturnType = methodInfo.ReturnType.FullName
			};
			ParameterInfo[] parameters = methodInfo.GetParameters();
			foreach (ParameterInfo parameterInfo in parameters)
			{
				methodCodeManifest.Parametres.Add(new ParameterCodeManifest
				{
					Type = parameterInfo.ParameterType.FullName,
					Direction = (parameterInfo.IsOut ? "Out" : "")
				});
			}
			if (!list.Contains(methodCodeManifest))
			{
				list.Add(methodCodeManifest);
			}
		}
		return list;
	}

	public static Guid GetDeterministicGuid(string input, Encoding encoding)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = encoding.GetBytes(input);
		byte[] b = mD5CryptoServiceProvider.ComputeHash(bytes);
		return new Guid(b);
	}

	public static Guid GetDeterministicGuid(string input)
	{
		return GetDeterministicGuid(input, Encoding.UTF8);
	}

	public static string UniversalProcedureNameFromText(string procedureText)
	{
		if (string.IsNullOrEmpty(procedureText))
		{
			return string.Empty;
		}
		Match match = Regex.Match(procedureText.ToLower(), "(?<=procedure)(.*?)(?=\\()");
		if (match.Success)
		{
			string text = match.Value.Trim();
			if (text.Contains("."))
			{
				text = text.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
			}
			if (!string.IsNullOrEmpty(text))
			{
				text = text.Replace("[", "").Replace("]", "").Replace("\"", "");
			}
			return text;
		}
		match = Regex.Match(procedureText.ToLower(), "(?<=function)(.*?)(?=\\()");
		if (match.Success)
		{
			string text2 = match.Value.Trim();
			if (text2.Contains("."))
			{
				text2 = text2.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
			}
			if (!string.IsNullOrEmpty(text2))
			{
				text2 = text2.Replace("[", "").Replace("]", "").Replace("\"", "");
			}
			return text2;
		}
		return string.Empty;
	}

	static ManifestGeneratorHelper()
	{
		TargetFrameworkName = ProjectSystemImpl.TargetFrameworkName;
		ExcludeFolders = new string[5] { "\\App_Data\\", "\\obj\\", "\\Sandcastle\\", "\\SharpDevelop\\", "\\OmniSharp.Roslyn" };
		IncludeExtensions = new string[2] { ".exe", ".dll" };
		AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += CurrentDomain_ReflectionOnlyAssemblyResolve;
	}

	private static Assembly CurrentDomain_ReflectionOnlyAssemblyResolve(object sender, ResolveEventArgs args)
	{
		if (args == null)
		{
			throw new ArgumentNullException("args");
		}
		Assembly assembly = FindLoadedAssembly(args.Name);
		if (assembly != null && !assembly.IsDynamic && !string.IsNullOrEmpty(assembly.Location))
		{
			return Assembly.ReflectionOnlyLoadFrom(assembly.Location);
		}
		return null;
	}

	private static Assembly FindLoadedAssembly(string name)
	{
		return AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault((Assembly a) => a.FullName == name);
	}
}
