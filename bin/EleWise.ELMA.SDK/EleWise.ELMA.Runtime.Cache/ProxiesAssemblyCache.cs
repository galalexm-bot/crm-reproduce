using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Cache;

internal class ProxiesAssemblyCache
{
	private byte[] assemblyRaw;

	private string fileName;

	private static ProxiesAssemblyCache pKBGU0WPvA838hE3c3AX;

	public string AssemblyNameHash
	{
		[CompilerGenerated]
		get
		{
			return _003CAssemblyNameHash_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CAssemblyNameHash_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string TypeSignaturesHash
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeSignaturesHash_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CTypeSignaturesHash_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public byte[] AssemblyRaw
	{
		get
		{
			//Discarded unreachable code: IL_0079, IL_00b4, IL_00c3
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (fileName == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				case 5:
					assemblyRaw = File.ReadAllBytes(fileName);
					num2 = 2;
					break;
				case 4:
					if (assemblyRaw != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 1;
				default:
					return assemblyRaw;
				}
			}
		}
		set
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
					assemblyRaw = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public ProxiesAssemblyCache()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hQiPxiWPuSp9ivWEJGu5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ProxiesAssemblyCache(string fileName)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hQiPxiWPuSp9ivWEJGu5();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
		{
			num = 0;
		}
		string[] array = default(string[]);
		while (true)
		{
			switch (num)
			{
			default:
				TypeSignaturesHash = (string)NjAcgXWPSR6qfq20Vvob(array[1]);
				num = 3;
				break;
			case 4:
				AssemblyNameHash = (string)NjAcgXWPSR6qfq20Vvob(array[0]);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			case 3:
				this.fileName = fileName;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				array = (string[])ewONRsWPVRvmwDKPYK7x(NcNO2NWPIqmOcdCEjR9Q(Path.GetFileName(fileName)), new char[1] { '-' });
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num = 4;
				}
				break;
			}
		}
	}

	public string GetCacheFileName()
	{
		return (string)NOqxBfWPq7H5PR4BU3dG(pqOjXdWPi802BdLB2Flb(AssemblyNameHash), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A5F4AB), pqOjXdWPi802BdLB2Flb(TypeSignaturesHash), tpHi8SWPRyNvoaWFT9R4(-583745292 ^ -583695282));
	}

	public static string EvaluateTypesSignatureHash(IEnumerable<Type> types)
	{
		return (types.Count() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70040998) + EvaluateTypesSignature(types)).GetSHA1Base64Hash();
	}

	public static string EvaluateTypesSignature(IEnumerable<Type> types)
	{
		if (types == null)
		{
			return string.Empty;
		}
		List<Type> processedTypes = new List<Type>();
		StringBuilder stringBuilder = new StringBuilder();
		foreach (Type item in types.OrderBy((Type t) => t.FullName))
		{
			EvaluateTypeSignature(item, processedTypes, stringBuilder);
		}
		return stringBuilder.ToString();
	}

	private static void EvaluateTypeSignature(Type type, List<Type> processedTypes, object signature)
	{
		if (processedTypes.Contains(type))
		{
			return;
		}
		processedTypes.Add(type);
		((StringBuilder)signature).AppendLine(type.FullName);
		Type[] array = ((type.IsGenericType && !type.IsGenericTypeDefinition) ? type.GetGenericArguments() : null);
		if (array != null && array.Length != 0)
		{
			((StringBuilder)signature).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A83B5B4));
			for (int i = 0; i < array.Length; i++)
			{
				if (i > 0)
				{
					((StringBuilder)signature).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629864494));
				}
				((StringBuilder)signature).Append((object)array[i]);
			}
			((StringBuilder)signature).AppendLine(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E28D62));
			EvaluateTypeSignature(type.GetGenericTypeDefinition(), processedTypes, signature);
			return;
		}
		foreach (MethodInfo item in from m in type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
			orderby m.ToString()
			select m)
		{
			((StringBuilder)signature).Append(item.Name);
			if (item.IsVirtual)
			{
				((StringBuilder)signature).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFCF460));
			}
			string text = ((item.ReturnType != null) ? (item.ReturnType.AssemblyQualifiedName ?? item.ReturnType.Name) : null);
			if (text != null)
			{
				((StringBuilder)signature).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4C7635));
				((StringBuilder)signature).Append(text);
			}
			((StringBuilder)signature).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE3C23F));
			ParameterInfo[] parameters = item.GetParameters();
			for (int j = 0; j < parameters.Length; j++)
			{
				if (j > 0)
				{
					((StringBuilder)signature).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269E0D3A));
				}
				ParameterInfo parameterInfo = parameters[j];
				string value = parameterInfo.ParameterType.AssemblyQualifiedName ?? parameterInfo.ParameterType.Name;
				((StringBuilder)signature).Append(value);
			}
			((StringBuilder)signature).AppendLine(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8316B8E));
		}
		if (type.BaseType != null)
		{
			EvaluateTypeSignature(type.BaseType, processedTypes, signature);
		}
	}

	public static IEnumerable<ProxiesAssemblyCache> GetProxiesAssemblyCaches(string cacheName)
	{
		string cacheFolder = GetCacheFolder(cacheName);
		if (!Directory.Exists(cacheFolder))
		{
			return new ProxiesAssemblyCache[0];
		}
		return (from fileName in Directory.GetFiles(cacheFolder)
			select new ProxiesAssemblyCache(fileName)).ToArray();
	}

	public static void SaveProxiesAssemblyCaches(IEnumerable<ProxiesAssemblyCache> caches, string cacheName)
	{
		string cacheFolder = GetCacheFolder(cacheName);
		if (!Directory.Exists(cacheFolder))
		{
			Directory.CreateDirectory(cacheFolder);
		}
		List<string> list = (from f in Directory.GetFiles(cacheFolder)
			select (string)_003C_003Ec.hkXBsOQArAyQZxsvLxp2(f)).ToList();
		foreach (ProxiesAssemblyCache cache in caches)
		{
			string cacheFileName = cache.GetCacheFileName();
			if (list.Contains(cacheFileName))
			{
				list.Remove(cacheFileName);
			}
			else if (cache.AssemblyRaw != null)
			{
				File.WriteAllBytes(Path.Combine(cacheFolder, cacheFileName), cache.AssemblyRaw);
			}
		}
		foreach (string item in list)
		{
			File.Delete(Path.Combine(cacheFolder, item));
		}
	}

	private static string GetCacheFolder(object cacheName)
	{
		//Discarded unreachable code: IL_0061, IL_0070
		int num = 3;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return (string)F7bhUdWPXxWLlAeJFvNd(text, cacheName);
			default:
				return (string)cacheName;
			case 2:
				if (i9WLggWPTMiyT8lenHhN(cacheName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				text = (string)F7bhUdWPXxWLlAeJFvNd(((ComponentManager)A1GjNCWPKUhgtn2sCwBB()).WorkDirectory, tpHi8SWPRyNvoaWFT9R4(-889460160 ^ -889592226));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void hQiPxiWPuSp9ivWEJGu5()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool WZ1d2DWP8hl3LwUWk0Da()
	{
		return pKBGU0WPvA838hE3c3AX == null;
	}

	internal static ProxiesAssemblyCache oG1UDiWPZ21DEtsTfRTu()
	{
		return pKBGU0WPvA838hE3c3AX;
	}

	internal static object NcNO2NWPIqmOcdCEjR9Q(object P_0)
	{
		return Path.GetFileNameWithoutExtension((string)P_0);
	}

	internal static object ewONRsWPVRvmwDKPYK7x(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static object NjAcgXWPSR6qfq20Vvob(object P_0)
	{
		return ((string)P_0).Base64StringFromValidFileName();
	}

	internal static object pqOjXdWPi802BdLB2Flb(object P_0)
	{
		return ((string)P_0).Base64StringToValidFileName();
	}

	internal static object tpHi8SWPRyNvoaWFT9R4(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object NOqxBfWPq7H5PR4BU3dG(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static object A1GjNCWPKUhgtn2sCwBB()
	{
		return ComponentManager.Current;
	}

	internal static object F7bhUdWPXxWLlAeJFvNd(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool i9WLggWPTMiyT8lenHhN(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
