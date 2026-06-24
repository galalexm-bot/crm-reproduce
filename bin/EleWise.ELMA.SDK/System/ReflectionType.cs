using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace System;

public static class ReflectionType
{
	private static IDynamicPublicationService dynamicPublicationService;

	private static IDictionary<Assembly, IDictionary<string, MemoryStream>> manifestResources;

	private static readonly IDictionary<string, Type> DynamicTypes;

	private static readonly IDictionary<string, Type> DynamicTypesIgnoreCase;

	private static Assembly configuraionModelAssembly;

	private static Assembly dynamicModelAssembly;

	internal static ReflectionType n1v4IBosNT6s4EXUbrm;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static bool? DynamicPublicationEnable => (dynamicPublicationService ?? (dynamicPublicationService = (Locator.Initialized ? Locator.GetService<IDynamicPublicationService>() : null)))?.Enable;

	public static Type GetType(string typeName)
	{
		return GetType(typeName, throwOnError: false, ignoreCase: false);
	}

	public static Type GetType(string typeName, bool throwOnError)
	{
		return GetType(typeName, throwOnError, ignoreCase: false);
	}

	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass2_.throwOnError = throwOnError;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return GetType(typeName, _003C_003Ec__DisplayClass2_._003CGetType_003Eb__0, TypeResolver, _003C_003Ec__DisplayClass2_.throwOnError, ignoreCase);
			}
		}
	}

	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver)
	{
		return GetType(typeName, assemblyResolver, typeResolver, throwOnError: false, ignoreCase: false);
	}

	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError)
	{
		return GetType(typeName, assemblyResolver, typeResolver, throwOnError, ignoreCase: false);
	}

	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.assemblyResolver = assemblyResolver;
		CS_0024_003C_003E8__locals0.typeResolver = typeResolver;
		CS_0024_003C_003E8__locals0.assembly = null;
		Type value = Type.GetType(typeName, (AssemblyName asmName) => AssemblyResolver(asmName, CS_0024_003C_003E8__locals0.assemblyResolver), delegate(Assembly asm, string type, bool ignore)
		{
			int num2 = 1;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				default:
					return TypeResolver(asm, type, ignore, CS_0024_003C_003E8__locals0.typeResolver);
				case 1:
					CS_0024_003C_003E8__locals0.assembly = asm;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num3 = 0;
					}
					break;
				}
			}
		}, throwOnError, ignoreCase);
		if (value == null && typeName.Contains('+') && (CS_0024_003C_003E8__locals0.assembly == null || CS_0024_003C_003E8__locals0.assembly == configuraionModelAssembly || CS_0024_003C_003E8__locals0.assembly == dynamicModelAssembly))
		{
			int num = typeName.IndexOf(',');
			(ignoreCase ? DynamicTypesIgnoreCase : DynamicTypes).TryGetValue(GetTypeName((num > 0) ? typeName.Remove(typeName.IndexOf(',')).Trim() : typeName.Trim()), out value);
		}
		return value;
	}

	public static Type GetReflectionType(this Assembly assembly, string name)
	{
		return assembly.GetReflectionType(name, throwOnError: false, ignoreCase: false);
	}

	public static Type GetReflectionType(this Assembly assembly, string name, bool throwOnError)
	{
		return d8lBdobFlgoo8NrdMON(assembly, name, throwOnError, false);
	}

	public static Type GetReflectionType(this Assembly assembly, string name, bool throwOnError, bool ignoreCase)
	{
		//Discarded unreachable code: IL_0077, IL_0086
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return TypeResolver(assembly, name, ignoreCase, TypeResolver);
			case 1:
				return TypeResolver(assembly, name, ignoreCase, TypeResolverThrowOnError);
			case 2:
				if (throwOnError)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public static ManifestResourceInfo GetReflectionManifestResourceInfo(this Assembly assembly, string resourceName)
	{
		//Discarded unreachable code: IL_00d2, IL_00e1, IL_00f1, IL_0100, IL_01a3, IL_01b2
		int num = 12;
		int num2 = num;
		MemoryStream value2 = default(MemoryStream);
		string text = default(string);
		IDictionary<string, MemoryStream> value = default(IDictionary<string, MemoryStream>);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (value2 != null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 5;
					}
				}
				else
				{
					text = (string)DrdXihbWBYkwC882Tvt(HwfRXSbBl14iJYS5Gcv(assembly));
					num2 = 8;
				}
				continue;
			case 5:
				return new ManifestResourceInfo(null, null, ResourceLocation.Embedded | ResourceLocation.ContainedInManifestFile);
			case 8:
				if (!pNpUFubbxhUgPo2oaox(text, AdIcTsboJk5FvALb41m(0x3A5D5EF ^ 0x3A5DC71)))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 3;
			default:
				if (!value.TryGetValue(resourceName, out value2))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 7;
			case 6:
				if (!pNpUFubbxhUgPo2oaox(text, AdIcTsboJk5FvALb41m(-477139494 ^ -477141962)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			case 1:
			case 4:
			case 9:
			case 10:
			case 11:
				return (ManifestResourceInfo)GHAE8vbh8FWN0x3WU0G(assembly, resourceName);
			case 3:
				assembly = configuraionModelAssembly;
				num2 = 10;
				continue;
			case 12:
				if (!manifestResources.TryGetValue(assembly, out value))
				{
					num2 = 11;
					continue;
				}
				goto default;
			case 2:
				break;
			}
			assembly = dynamicModelAssembly;
			num2 = 8;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
			{
				num2 = 9;
			}
		}
	}

	public static string[] GetReflectionManifestResourceNames(this Assembly assembly)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (string[])vKUF7DbGYZNmZuYvOJF(assembly);
			case 1:
			{
				if (manifestResources.TryGetValue(assembly, out var value))
				{
					return value.Keys.ToArray();
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public static Stream GetReflectionManifestResourceStream(this Assembly assembly, Type type, string name)
	{
		return (Stream)nJbjmlbEnnUBvkiFm36(assembly, ((object)type == null || type.Namespace == null) ? name : ((name == null) ? type.Namespace : (type.Namespace + Type.Delimiter + name)));
	}

	public static Stream GetReflectionManifestResourceStream(this Assembly assembly, string name)
	{
		//Discarded unreachable code: IL_00a3, IL_00b2, IL_0129, IL_017f, IL_01af, IL_01be, IL_0278, IL_0287, IL_0296, IL_02cc
		int num = 19;
		MemoryStream value2 = default(MemoryStream);
		IDictionary<string, MemoryStream> value = default(IDictionary<string, MemoryStream>);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (Stream)Ym8q1Cbf7DnHpb49TgJ(assembly, name);
				case 16:
				case 17:
					assembly = dynamicModelAssembly;
					num2 = 11;
					continue;
				case 9:
					value2.Seek(0L, SeekOrigin.Begin);
					num = 2;
					break;
				case 6:
					if (!manifestResources.TryGetValue(FindAssembly(ref configuraionModelAssembly, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17ADC6BC)), out value))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 14;
				case 15:
					if (value2 == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 9;
				case 12:
					if (!value.TryGetValue(name, out value2))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 15;
				case 2:
					return value2;
				case 4:
					text = (string)DrdXihbWBYkwC882Tvt(HwfRXSbBl14iJYS5Gcv(assembly));
					num = 5;
					break;
				case 8:
				case 13:
					assembly = configuraionModelAssembly;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
				case 18:
					if (pNpUFubbxhUgPo2oaox(DrdXihbWBYkwC882Tvt(HwfRXSbBl14iJYS5Gcv(assembly)), AdIcTsboJk5FvALb41m(-1824388195 ^ -1824390733)))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto default;
				case 5:
					if (pNpUFubbxhUgPo2oaox(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97969720)))
					{
						num2 = 13;
						continue;
					}
					goto case 7;
				case 14:
					if (value.TryGetValue(name, out value2))
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto default;
				case 19:
					if (!manifestResources.TryGetValue(assembly, out value))
					{
						num2 = 18;
						continue;
					}
					goto case 12;
				case 7:
					if (pNpUFubbxhUgPo2oaox(text, AdIcTsboJk5FvALb41m(-1939377524 ^ -1939375264)))
					{
						num2 = 16;
						continue;
					}
					goto default;
				}
				break;
			}
		}
	}

	internal static bool IsDynamicAssembly(this Assembly asm)
	{
		//Discarded unreachable code: IL_0085, IL_0094, IL_00fa, IL_0109
		int num = 6;
		int num2 = num;
		string text = default(string);
		bool flag = default(bool);
		bool? dynamicPublicationEnable = default(bool?);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (!pNpUFubbxhUgPo2oaox(text, AdIcTsboJk5FvALb41m(0x20261A4F ^ 0x20261061)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 8;
			case 5:
				flag = true;
				num2 = 3;
				break;
			case 1:
				return pNpUFubbxhUgPo2oaox(text, AdIcTsboJk5FvALb41m(0x7E6E5A0B ^ 0x7E6E53E7));
			case 8:
				return true;
			default:
				return false;
			case 2:
				text = (string)DrdXihbWBYkwC882Tvt(HwfRXSbBl14iJYS5Gcv(asm));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 9;
				}
				break;
			case 3:
				if (dynamicPublicationEnable == flag)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 9:
				if (pNpUFubbxhUgPo2oaox(text, AdIcTsboJk5FvALb41m(0x57A5235E ^ 0x57A5293A)))
				{
					num2 = 8;
					break;
				}
				goto case 4;
			case 6:
				dynamicPublicationEnable = DynamicPublicationEnable;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (!(text == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606652286)))
				{
					num2 = 7;
					break;
				}
				goto case 8;
			}
		}
	}

	internal static void Register(IEnumerable<Type> newTypes)
	{
		newTypes.ForEach(Register);
	}

	internal static void Register(Type type)
	{
		int num = 3;
		int num2 = num;
		string key = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				DynamicTypesIgnoreCase.Add(key, type);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 3:
				key = (string)vyD4u7bQBKGCAaxya99(type.FullName);
				num2 = 2;
				break;
			case 2:
				DynamicTypes.Add(key, type);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void AddManifestResources(Assembly assembly, IEnumerable<(string name, byte[] data)> manifestResources)
	{
		string name = assembly.GetName().Name;
		IDictionary<string, MemoryStream> value;
		if (!(name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105198202)) && !(name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837664283)))
		{
			if (!(name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35992579)) && !(name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x51150BF1)))
			{
				return;
			}
			if (!ReflectionType.manifestResources.TryGetValue(FindAssembly(ref dynamicModelAssembly, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x63809FC5)), out value))
			{
				value = (ReflectionType.manifestResources[dynamicModelAssembly] = ((IEnumerable<string>)dynamicModelAssembly.GetManifestResourceNames()).ToDictionary((Func<string, string>)((string n) => n), (Func<string, MemoryStream>)((string _) => null)));
			}
		}
		else if (!ReflectionType.manifestResources.TryGetValue(FindAssembly(ref configuraionModelAssembly, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812027350)), out value))
		{
			value = (ReflectionType.manifestResources[configuraionModelAssembly] = ((IEnumerable<string>)configuraionModelAssembly.GetManifestResourceNames()).ToDictionary((Func<string, string>)((string n) => n), (Func<string, MemoryStream>)((string _) => null)));
		}
		ReflectionType.manifestResources[assembly] = value;
		foreach (var manifestResource in manifestResources)
		{
			string item = manifestResource.name;
			byte[] item2 = manifestResource.data;
			MemoryStream memoryStream = MemoryHelper.GetMemoryStream(item2.Length);
			memoryStream.Write(item2, 0, item2.Length);
			value[item] = memoryStream.AsReadOnly();
		}
	}

	private static Assembly AssemblyResolver(object asmName, bool throwOnError)
	{
		//Discarded unreachable code: IL_004f, IL_0081, IL_00cf, IL_00de
		Assembly assembly = default(Assembly);
		switch (1)
		{
		default:
			return assembly;
		case 1:
			try
			{
				assembly = (Assembly)MBNytVbvfgD9PJPRGSf(ueIK1ObCaBQV7mWwxhD(), asmName);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num = 0;
				}
				return num switch
				{
					0 => assembly, 
					_ => assembly, 
				};
			}
			catch (Exception)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return assembly;
					case 2:
						throw;
					}
					if (throwOnError)
					{
						num2 = 2;
						continue;
					}
					assembly = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 1;
					}
				}
			}
		}
	}

	private static Assembly AssemblyResolver(object asmName, Func<AssemblyName, Assembly> assemblyResolver)
	{
		string name = ((AssemblyName)asmName).Name;
		if (!(name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138159076)) && !(name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C949C2A)))
		{
			if (name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87335335) || name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C533113))
			{
				return FindAssembly(ref dynamicModelAssembly, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411198077));
			}
			return assemblyResolver((AssemblyName)asmName);
		}
		return FindAssembly(ref configuraionModelAssembly, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099749581));
	}

	private static Type TypeResolver(object assembly, object typeName, bool ignoreCase)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if ((Assembly)assembly != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return VNO7o9b81wu0uCYaqFC(typeName, false, ignoreCase);
			case 1:
				return Dm6d0RbZJB2Nsa4KLEI(assembly, typeName, false, ignoreCase);
			}
		}
	}

	private static Type TypeResolverThrowOnError(object assembly, object typeName, bool ignoreCase)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return Type.GetType((string)typeName, throwOnError: true, ignoreCase);
			case 1:
				if (NDHVAlbubDh4XKLqLlR(assembly, null))
				{
					return ((Assembly)assembly).GetType((string)typeName, throwOnError: true, ignoreCase);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static Type TypeResolver(object assembly, object typeName, bool ignoreCase, Func<Assembly, string, bool, Type> typeResolver)
	{
		string text;
		if (((Assembly)assembly == null || (Assembly)assembly == FindAssembly(ref configuraionModelAssembly, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A33F452)) || (Assembly)assembly == FindAssembly(ref dynamicModelAssembly, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812027296)) || (text = ((Assembly)assembly)?.GetName().Name) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC14E2E) || text == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307E963D)) && (ignoreCase ? DynamicTypesIgnoreCase : DynamicTypes).TryGetValue(GetTypeName(typeName), out var value))
		{
			return value;
		}
		return typeResolver((Assembly)assembly, (string)typeName, ignoreCase);
	}

	private static string GetTypeName(object typeName)
	{
		return (string)typeName;
	}

	private static Assembly FindAssembly(ref Assembly assembly, object assemblyName)
	{
		int num = 4;
		int num2 = num;
		Assembly assembly2 = default(Assembly);
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = default(_003C_003Ec__DisplayClass27_0);
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 2:
				assembly2 = (assembly = ((IEnumerable<Assembly>)vR4KLdbITVxeMtvynfI(AppDomain.CurrentDomain)).FirstOrDefault(_003C_003Ec__DisplayClass27_._003CFindAssembly_003Eb__0));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				_003C_003Ec__DisplayClass27_.assemblyName = (string)assemblyName;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				_003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
				num2 = 3;
				continue;
			case 1:
				obj = assembly;
				if (obj != null)
				{
					break;
				}
				num2 = 2;
				continue;
			default:
				obj = assembly2;
				break;
			}
			break;
		}
		return (Assembly)obj;
	}

	static ReflectionType()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				manifestResources = new Dictionary<Assembly, IDictionary<string, MemoryStream>>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				DynamicTypes = PublishCacheContext.CreateCache((IDictionary<string, Type> c) => new Dictionary<string, Type>(c));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				SingletonReader.JJCZtPuTvSt();
				num2 = 2;
				break;
			case 4:
				return;
			default:
				DynamicTypesIgnoreCase = PublishCacheContext.CreateCache((IDictionary<string, Type> c) => new Dictionary<string, Type>(c, StringComparer.OrdinalIgnoreCase));
				num2 = 4;
				break;
			}
		}
	}

	internal static bool DCwfqAocdwHl46Ubc3m()
	{
		return n1v4IBosNT6s4EXUbrm == null;
	}

	internal static ReflectionType jSxWekozCHxrub23Ege()
	{
		return n1v4IBosNT6s4EXUbrm;
	}

	internal static Type d8lBdobFlgoo8NrdMON(object P_0, object P_1, bool throwOnError, bool ignoreCase)
	{
		return ((Assembly)P_0).GetReflectionType((string)P_1, throwOnError, ignoreCase);
	}

	internal static object HwfRXSbBl14iJYS5Gcv(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object DrdXihbWBYkwC882Tvt(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static object AdIcTsboJk5FvALb41m(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool pNpUFubbxhUgPo2oaox(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object GHAE8vbh8FWN0x3WU0G(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetReflectionManifestResourceInfo((string)P_1);
	}

	internal static object vKUF7DbGYZNmZuYvOJF(object P_0)
	{
		return ((Assembly)P_0).GetManifestResourceNames();
	}

	internal static object nJbjmlbEnnUBvkiFm36(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetReflectionManifestResourceStream((string)P_1);
	}

	internal static object Ym8q1Cbf7DnHpb49TgJ(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object vyD4u7bQBKGCAaxya99(object P_0)
	{
		return GetTypeName(P_0);
	}

	internal static object ueIK1ObCaBQV7mWwxhD()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object MBNytVbvfgD9PJPRGSf(object P_0, object P_1)
	{
		return ((AppDomain)P_0).Load((AssemblyName)P_1);
	}

	internal static Type VNO7o9b81wu0uCYaqFC(object P_0, bool P_1, bool P_2)
	{
		return Type.GetType((string)P_0, P_1, P_2);
	}

	internal static Type Dm6d0RbZJB2Nsa4KLEI(object P_0, object P_1, bool P_2, bool P_3)
	{
		return ((Assembly)P_0).GetType((string)P_1, P_2, P_3);
	}

	internal static bool NDHVAlbubDh4XKLqLlR(object P_0, object P_1)
	{
		return (Assembly)P_0 != (Assembly)P_1;
	}

	internal static object vR4KLdbITVxeMtvynfI(object P_0)
	{
		return ((AppDomain)P_0).GetAssemblies();
	}
}
