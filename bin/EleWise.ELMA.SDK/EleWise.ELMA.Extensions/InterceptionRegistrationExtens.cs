using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Extras.DynamicProxy;
using Autofac.Features.Scanning;
using Castle.Core.Logging;
using Castle.DynamicProxy;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Internal;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Cache;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

internal static class InterceptionRegistrationExtensions
{
	private class CustomClassProxyGenerator : ClassProxyGenerator
	{
		internal static object DrgF508hXDwUNvn3Hdxt;

		public CustomClassProxyGenerator(ModuleScope scope, Type targetType)
		{
			//Discarded unreachable code: IL_002c, IL_0031
			t3c3QW8hnIrA9GqILM7Z();
			((ClassProxyGenerator)this)._002Ector(scope, targetType);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		protected override ClassEmitter BuildClassEmitter(string typeName, Type parentType, IEnumerable<Type> interfaces)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			((BaseProxyGenerator)this).CheckNotGenericTypeDefinition(parentType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561285698));
			((BaseProxyGenerator)this).CheckNotGenericTypeDefinitions(interfaces, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x3137B9F4));
			return new ClassEmitter(((BaseProxyGenerator)this).get_Scope(), typeName, parentType, interfaces, TypeAttributes.Public | TypeAttributes.Serializable, false);
		}

		internal static void t3c3QW8hnIrA9GqILM7Z()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool tdqZHK8hTBNrS9N9cNHd()
		{
			return DrgF508hXDwUNvn3Hdxt == null;
		}

		internal static CustomClassProxyGenerator fK3l2C8hkKhBDk6OFn6C()
		{
			return (CustomClassProxyGenerator)DrgF508hXDwUNvn3Hdxt;
		}
	}

	private class CustomProxyBuilder : IProxyBuilder
	{
		private readonly object scope;

		private object logger;

		internal static object LtYdMt8hO61XK7yrWnYV;

		public ILogger Logger
		{
			get
			{
				return (ILogger)logger;
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
					case 0:
						return;
					case 1:
						logger = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ModuleScope ModuleScope => (ModuleScope)scope;

		public CustomProxyBuilder(ModuleScope scope)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			nYfF2W8hPyrhDoQVJf0G();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					logger = NullLogger.Instance;
					num = 2;
					continue;
				case 2:
					return;
				}
				this.scope = scope;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num = 1;
				}
			}
		}

		public Type CreateClassProxyType(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					AssertValidType(classToProxy);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
				{
					CustomClassProxyGenerator customClassProxyGenerator = new CustomClassProxyGenerator((ModuleScope)scope, classToProxy);
					d4dOP98h1TVcblHAjX1E(customClassProxyGenerator, logger);
					return T3qx3s8hNYcmFW0B0L4E(customClassProxyGenerator, additionalInterfacesToProxy, options);
				}
				default:
					AssertValidTypes(additionalInterfacesToProxy);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		private void AssertValidType(Type target)
		{
			//Discarded unreachable code: IL_0080, IL_008a, IL_0099, IL_00c9, IL_00d8, IL_0108, IL_0112, IL_0121, IL_016d, IL_0177, IL_0186, IL_0196, IL_01ae, IL_01be
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0240: Unknown result type (might be due to invalid IL or missing references)
			int num = 16;
			bool isNested = default(bool);
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num6;
					int num4;
					int num5;
					int num3;
					switch (num2)
					{
					case 2:
						if (target.IsNestedAssembly)
						{
							num2 = 8;
							continue;
						}
						goto case 6;
					case 6:
						num6 = (target.IsNestedFamORAssem ? 1 : 0);
						goto IL_0248;
					case 15:
						if (isNested)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
							{
								num2 = 2;
							}
							continue;
						}
						num6 = 0;
						goto IL_0248;
					case 10:
						if (target.IsPublic)
						{
							num2 = 5;
							continue;
						}
						goto case 14;
					case 3:
						num4 = (AqVs5u8h3bxG81QJb4Cc(target.Assembly) ? 1 : 0);
						goto IL_0288;
					case 16:
						break;
					case 1:
						if (target.IsVisible)
						{
							num2 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
							{
								num2 = 12;
							}
							continue;
						}
						goto case 11;
					case 8:
						num6 = 1;
						goto IL_0248;
					case 13:
						return;
					case 11:
						num5 = ((!isNested) ? 1 : 0);
						goto IL_0265;
					case 14:
						num3 = (target.IsNestedPublic ? 1 : 0);
						goto IL_02a5;
					case 4:
						throw new GeneratorException((string)KiNFBn8haY5SoH3PQ7TL(KPyCnp8hpERcJRFCKBuu(0x31326106 ^ 0x3137B80C), target.FullName, KPyCnp8hpERcJRFCKBuu(0x26FFCB59 ^ 0x26FA1241)));
					case 7:
						if (!target.IsGenericTypeDefinition)
						{
							num2 = 13;
							continue;
						}
						goto case 9;
					case 9:
						throw new GeneratorException((string)KiNFBn8haY5SoH3PQ7TL(KPyCnp8hpERcJRFCKBuu(0x10E41EDB ^ 0x10E1C7D1), target.FullName, KPyCnp8hpERcJRFCKBuu(0x12A5FAC7 ^ 0x12A0236F)));
					case 12:
						num5 = 0;
						goto IL_0265;
					default:
						num4 = 0;
						goto IL_0288;
					case 5:
						{
							num3 = 1;
							goto IL_02a5;
						}
						IL_02a5:
						if (((uint)num3 | (flag ? 1u : 0u)) != 0)
						{
							num2 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
							{
								num2 = 6;
							}
							continue;
						}
						goto case 4;
						IL_0265:
						if (((uint)num5 | (flag2 ? 1u : 0u)) == 0)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 3;
						IL_0248:
						flag2 = (byte)num6 != 0;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 1;
						}
						continue;
						IL_0288:
						flag = (byte)num4 != 0;
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 6;
						}
						continue;
					}
					break;
				}
				isNested = target.IsNested;
				num = 15;
			}
		}

		private void AssertValidTypes(IEnumerable<Type> targetTypes)
		{
			if (targetTypes == null)
			{
				return;
			}
			foreach (Type targetType in targetTypes)
			{
				AssertValidType(targetType);
			}
		}

		public Type CreateClassProxyTypeWithTarget(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
		{
			throw new NotImplementedException();
		}

		public Type CreateInterfaceProxyTypeWithTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, Type targetType, ProxyGenerationOptions options)
		{
			throw new NotImplementedException();
		}

		public Type CreateInterfaceProxyTypeWithTargetInterface(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
		{
			throw new NotImplementedException();
		}

		public Type CreateInterfaceProxyTypeWithoutTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
		{
			throw new NotImplementedException();
		}

		internal static void nYfF2W8hPyrhDoQVJf0G()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool YpSiY78h2u5kpHvR5L96()
		{
			return LtYdMt8hO61XK7yrWnYV == null;
		}

		internal static CustomProxyBuilder I89ifk8heEebw9sEphda()
		{
			return (CustomProxyBuilder)LtYdMt8hO61XK7yrWnYV;
		}

		internal static void d4dOP98h1TVcblHAjX1E(object P_0, object P_1)
		{
			((BaseProxyGenerator)P_0).set_Logger((ILogger)P_1);
		}

		internal static Type T3qx3s8hNYcmFW0B0L4E(object P_0, object P_1, object P_2)
		{
			return ((ClassProxyGenerator)P_0).GenerateCode((Type[])P_1, (ProxyGenerationOptions)P_2);
		}

		internal static bool AqVs5u8h3bxG81QJb4Cc(object P_0)
		{
			return InternalsUtil.IsInternalToDynamicProxy((Assembly)P_0);
		}

		internal static object KPyCnp8hpERcJRFCKBuu(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object KiNFBn8haY5SoH3PQ7TL(object P_0, object P_1, object P_2)
		{
			return (string)P_0 + (string)P_1 + (string)P_2;
		}
	}

	private static readonly Dictionary<string, IProxyBuilder> ProxyBuilders;

	private static readonly Dictionary<string, IProxyBuilder> CacheProxyBuilders;

	private static readonly List<Type> CacheableTypes;

	private static readonly Dictionary<string, ProxiesAssemblyCache> AsmCaches;

	private static readonly IEnumerable<Service> EmptyServices;

	private static readonly string CachePathName;

	private static readonly List<Assembly> CacheProxyAssemblies;

	internal static InterceptionRegistrationExtensions eQTEqOG6VXXEExeYk5LR;

	public static void LoadCache(IEnumerable<Type> cacheableTypes, IEnumerable<ProxiesAssemblyCache> asmCaches)
	{
		CacheableTypes.Clear();
		AsmCaches.Clear();
		if (cacheableTypes == null)
		{
			return;
		}
		Type[] array = cacheableTypes.ToArray();
		CacheableTypes.AddRange(array);
		Dictionary<string, List<Type>> dictionary = new Dictionary<string, List<Type>>();
		Type[] array2 = array;
		foreach (Type type in array2)
		{
			string sHA1Base64Hash = GetProxyAssemblyName(type).AssemblyName.GetSHA1Base64Hash();
			if (!dictionary.TryGetValue(sHA1Base64Hash, out var value))
			{
				value = (dictionary[sHA1Base64Hash] = new List<Type>());
			}
			value.Add(type);
		}
		ProxiesAssemblyCache[] source = ((asmCaches != null) ? asmCaches.ToArray() : new ProxiesAssemblyCache[0]);
		using Dictionary<string, List<Type>>.Enumerator enumerator = dictionary.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
			CS_0024_003C_003E8__locals0.pair = enumerator.Current;
			ProxiesAssemblyCache proxiesAssemblyCache = source.FirstOrDefault((ProxiesAssemblyCache a) => _003C_003Ec__DisplayClass0_0.PmYrUQ8h6SRsPgYjyt35(_003C_003Ec__DisplayClass0_0.YpNt678h4okohPmmJLDK(a), CS_0024_003C_003E8__locals0.pair.Key));
			string text = ProxiesAssemblyCache.EvaluateTypesSignatureHash(CS_0024_003C_003E8__locals0.pair.Value);
			if (proxiesAssemblyCache != null && proxiesAssemblyCache.TypeSignaturesHash != text)
			{
				proxiesAssemblyCache = null;
			}
			if (proxiesAssemblyCache == null)
			{
				proxiesAssemblyCache = new ProxiesAssemblyCache
				{
					AssemblyNameHash = CS_0024_003C_003E8__locals0.pair.Key,
					TypeSignaturesHash = text
				};
			}
			AsmCaches.Add(proxiesAssemblyCache.AssemblyNameHash, proxiesAssemblyCache);
		}
	}

	public static IEnumerable<ProxiesAssemblyCache> SaveCache()
	{
		lock (ProxyBuilders)
		{
			List<ProxiesAssemblyCache> list = new List<ProxiesAssemblyCache>();
			try
			{
				foreach (KeyValuePair<string, IProxyBuilder> cacheProxyBuilder in CacheProxyBuilders)
				{
					string key = cacheProxyBuilder.Key;
					if (!AsmCaches.TryGetValue(key.GetSHA1Base64Hash(), out var value) || value == null)
					{
						continue;
					}
					ModuleScope moduleScope = cacheProxyBuilder.Value.get_ModuleScope();
					if (value.AssemblyRaw == null && (moduleScope.get_WeakNamedModule() != null || moduleScope.get_StrongNamedModule() != null))
					{
						if (!Directory.Exists(CachePathName))
						{
							Directory.CreateDirectory(CachePathName);
						}
						bool flag = moduleScope.get_WeakNamedModule() == null && moduleScope.get_StrongNamedModule() != null;
						moduleScope.SaveAssembly(flag);
						string path = Path.Combine(CachePathName, key + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16704931));
						if (File.Exists(path))
						{
							value.AssemblyRaw = File.ReadAllBytes(path);
						}
					}
					list.Add(value);
				}
				ProxyBuilders.Clear();
				CacheProxyBuilders.Clear();
				CacheableTypes.Clear();
				AsmCaches.Clear();
			}
			finally
			{
				if (Directory.Exists(CachePathName))
				{
					try
					{
						Directory.Delete(CachePathName, recursive: true);
					}
					catch (Exception exception)
					{
						Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F49F0DF), exception);
					}
				}
			}
			return list.ToArray();
		}
	}

	public static IRegistrationBuilder<TLimit, ScanningActivatorData, TRegistrationStyle> EnableClassInterceptorsCacheable<TLimit, TRegistrationStyle>(this IRegistrationBuilder<TLimit, ScanningActivatorData, TRegistrationStyle> registration)
	{
		if (registration == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146248111));
		}
		registration.get_ActivatorData().get_ConfigurationActions().Add(delegate(Type t, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> rb)
		{
			rb.EnableClassInterceptorsCacheable<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>();
		});
		return registration;
	}

	public static IRegistrationBuilder<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle> EnableClassInterceptorsCacheable<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle>(this IRegistrationBuilder<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle> registration) where TConcreteReflectionActivatorData : ConcreteReflectionActivatorData
	{
		_003C_003Ec__DisplayClass3_0<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle>();
		CS_0024_003C_003E8__locals0.registration = registration;
		((ReflectionActivatorData)(object)CS_0024_003C_003E8__locals0.registration.get_ActivatorData()).set_ImplementationType(GetBuilder(((ReflectionActivatorData)(object)CS_0024_003C_003E8__locals0.registration.get_ActivatorData()).get_ImplementationType()).CreateClassProxyType(((ReflectionActivatorData)(object)CS_0024_003C_003E8__locals0.registration.get_ActivatorData()).get_ImplementationType(), new Type[0], ProxyGenerationOptions.Default));
		CS_0024_003C_003E8__locals0.registration.OnPreparing((Action<PreparingEventArgs>)delegate(PreparingEventArgs e)
		{
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			int num = 2;
			int num2 = num;
			_003C_003Ec__DisplayClass3_1<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle> _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_1<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle>);
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_1<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle>();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return;
				default:
					_003C_003Ec__DisplayClass3_.e.set_Parameters((IEnumerable<Parameter>)((IEnumerable<Parameter>)(object)new Parameter[1] { (Parameter)new PositionalParameter(0, (object)GetInterceptorServices(_003C_003Ec__DisplayClass3_.e.get_Component(), ((ReflectionActivatorData)(object)CS_0024_003C_003E8__locals0.registration.get_ActivatorData()).get_ImplementationType()).Select(_003C_003Ec__DisplayClass3_._003CEnableClassInterceptorsCacheable_003Eb__1).Cast<IInterceptor>().ToArray()) }).Concat(_003C_003Ec__DisplayClass3_.e.get_Parameters()).ToArray());
					num2 = 3;
					break;
				case 1:
					_003C_003Ec__DisplayClass3_.e = e;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		return CS_0024_003C_003E8__locals0.registration;
	}

	static InterceptionRegistrationExtensions()
	{
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
				CacheProxyAssemblies = new List<Assembly>();
				num2 = 3;
				break;
			case 2:
				CacheProxyBuilders = new Dictionary<string, IProxyBuilder>();
				num2 = 8;
				break;
			case 7:
				AsmCaches = new Dictionary<string, ProxiesAssemblyCache>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				SingletonReader.JJCZtPuTvSt();
				num2 = 4;
				break;
			case 8:
				CacheableTypes = new List<Type>();
				num2 = 7;
				break;
			case 1:
				EmptyServices = (IEnumerable<Service>)(object)new Service[0];
				num2 = 6;
				break;
			case 0:
				return;
			case 4:
				ProxyBuilders = new Dictionary<string, IProxyBuilder>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				CachePathName = (string)vySCqBG6qCkn3eRKSWDc(v1kSFhG6RBtCuxSVneb1(-1638402543 ^ -1638664289));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static (string AssemblyName, bool StrongNamed) GetProxyAssemblyName(Type type, bool needStrongName = false)
	{
		IEnumerable<Type> source;
		if (!type.IsGenericType || type.IsGenericTypeDefinition)
		{
			IEnumerable<Type> enumerable = new Type[1] { type };
			source = enumerable;
		}
		else
		{
			source = type.GetGenericArguments().Prepend(type.GetGenericTypeDefinition());
		}
		SortedSet<Assembly> source2 = new SortedSet<Assembly>(source.Select((Type t) => t.Assembly), FunctorComparer<Assembly>.Create((Assembly a, Assembly b) => _003C_003Ec.FHBVdy8hjASQwSctX5yU(_003C_003Ec.owBbAp8hglkE5W919x32(), _003C_003Ec.jV1KXw8h5C1atcOgJZmc(a), b.FullName)));
		string item = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979250613), source2.Select(ComponentManager.GetAssemblyShortName)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123638598) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87467927);
		if (needStrongName)
		{
			return (item, source2.All(delegate(Assembly a)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
					{
						object obj = _003C_003Ec.aJlBrw8hLpvYoZBRlXBh(_003C_003Ec.LyHplJ8hYufwUIxPxO3B(a));
						if (obj != null)
						{
							return ((Array)obj).Length != 0;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 0;
						}
						break;
					}
					default:
						return false;
					}
				}
			}));
		}
		return (item, false);
	}

	internal static bool IsProxyAssembly(Assembly asm)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_0099
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return true;
			case 3:
				return false;
			default:
				return true;
			case 1:
				if (!CacheProxyAssemblies.Contains(asm))
				{
					num2 = 3;
					break;
				}
				goto case 4;
			case 2:
				if (!asm.IsDynamic)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	private static IEnumerable<Service> GetInterceptorServices(object registration, Type implType)
	{
		if (registration == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571AA2EB));
		}
		if (implType == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538781262));
		}
		IEnumerable<Service> enumerable = EmptyServices;
		if (((IComponentRegistration)registration).get_Metadata().TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7E81487), out var value))
		{
			enumerable = enumerable.Concat((IEnumerable<Service>)value);
		}
		if (implType.IsClass)
		{
			enumerable = enumerable.Concat(from InterceptAttribute att in implType.GetCustomAttributes(typeof(InterceptAttribute), inherit: true)
				select (Service)_003C_003Ec.w5FIWE8hUjhRx8rrpqoJ(att));
			enumerable = enumerable.Concat(from InterceptAttribute att in implType.GetInterfaces().SelectMany((Type i) => i.GetCustomAttributes(typeof(InterceptAttribute), inherit: true))
				select (Service)_003C_003Ec.w5FIWE8hUjhRx8rrpqoJ(att));
		}
		return enumerable.ToArray();
	}

	private static IProxyBuilder GetBuilder(Type type)
	{
		//Discarded unreachable code: IL_0054, IL_011c, IL_0126, IL_0135, IL_0145, IL_0154, IL_0216, IL_0225, IL_0235, IL_0244, IL_035e, IL_0396, IL_03a5
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		int num = 3;
		int num2 = num;
		IProxyBuilder result = default(IProxyBuilder);
		Dictionary<string, IProxyBuilder> proxyBuilders = default(Dictionary<string, IProxyBuilder>);
		bool lockTaken = default(bool);
		IProxyBuilder value = default(IProxyBuilder);
		(string, bool) proxyAssemblyName = default((string, bool));
		string item = default(string);
		string text = default(string);
		bool flag = default(bool);
		Dictionary<string, IProxyBuilder> dictionary = default(Dictionary<string, IProxyBuilder>);
		Assembly assembly = default(Assembly);
		ProxiesAssemblyCache value2 = default(ProxiesAssemblyCache);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 3:
				proxyBuilders = ProxyBuilders;
				num2 = 2;
				break;
			case 1:
				try
				{
					Monitor.Enter(proxyBuilders, ref lockTaken);
					int num3 = 5;
					while (true)
					{
						Dictionary<string, IProxyBuilder> dictionary2;
						switch (num3)
						{
						case 18:
							return result;
						case 9:
							value = (IProxyBuilder)(object)new CustomProxyBuilder(new ModuleScope(true, !proxyAssemblyName.Item2, item, text, item, text));
							num3 = 17;
							continue;
						case 15:
							text = (string)UwVhSAG6X3fY8WLuYto5(CachePathName, MYDRKFG6KqBmKlkPmcNe(item, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870842227)));
							num3 = 9;
							continue;
						case 4:
							dictionary2 = ProxyBuilders;
							break;
						case 3:
							if (!flag)
							{
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
								{
									num3 = 2;
								}
								continue;
							}
							dictionary2 = CacheProxyBuilders;
							break;
						case 17:
							if (!flag)
							{
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
								{
									num3 = 12;
								}
								continue;
							}
							goto case 20;
						default:
							dictionary.Add(item, value);
							num3 = 16;
							continue;
						case 13:
							item = proxyAssemblyName.Item1;
							num3 = 8;
							continue;
						case 5:
							proxyAssemblyName = GetProxyAssemblyName(type, needStrongName: true);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							flag = CacheableTypes.Contains(type);
							num3 = 3;
							continue;
						case 2:
						case 16:
							result = value;
							num3 = 18;
							continue;
						case 7:
							CacheProxyAssemblies.Add(assembly);
							num3 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
							{
								num3 = 11;
							}
							continue;
						case 8:
							if (dictionary.TryGetValue(item, out value))
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
								{
									num3 = 2;
								}
								continue;
							}
							goto case 15;
						case 14:
							assembly = (Assembly)poeerbG6nQIAZjfWbkD7(M8GkSyG6ktNiT81E598Z(value2));
							num3 = 7;
							continue;
						case 11:
							M0Q3OMG62Eu544korKVk(xQHclWG6OjbkP0WnMV57(value), assembly);
							num3 = 6;
							continue;
						case 20:
							if (!AsmCaches.TryGetValue((string)ERrWP0G6T7nYLVm0EqIb(item), out value2))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 19;
						case 19:
							if (value2.AssemblyRaw == null)
							{
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
								{
									num3 = 10;
								}
								continue;
							}
							goto case 14;
						}
						dictionary = dictionary2;
						num3 = 13;
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								Monitor.Exit(proxyBuilders);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
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
				}
			case 2:
				lockTaken = false;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object v1kSFhG6RBtCuxSVneb1(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object vySCqBG6qCkn3eRKSWDc(object P_0)
	{
		return IOExtensions.GetTempPath((string)P_0);
	}

	internal static bool MiJmLBG6SBQq7fIdY2rn()
	{
		return eQTEqOG6VXXEExeYk5LR == null;
	}

	internal static InterceptionRegistrationExtensions ma76JtG6iFsBZEJ2tgkQ()
	{
		return eQTEqOG6VXXEExeYk5LR;
	}

	internal static object MYDRKFG6KqBmKlkPmcNe(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object UwVhSAG6X3fY8WLuYto5(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object ERrWP0G6T7nYLVm0EqIb(object P_0)
	{
		return ((string)P_0).GetSHA1Base64Hash();
	}

	internal static object M8GkSyG6ktNiT81E598Z(object P_0)
	{
		return ((ProxiesAssemblyCache)P_0).AssemblyRaw;
	}

	internal static object poeerbG6nQIAZjfWbkD7(object P_0)
	{
		return ComponentManager.LoadAssembly((byte[])P_0);
	}

	internal static object xQHclWG6OjbkP0WnMV57(object P_0)
	{
		return ((IProxyBuilder)P_0).get_ModuleScope();
	}

	internal static void M0Q3OMG62Eu544korKVk(object P_0, object P_1)
	{
		((ModuleScope)P_0).LoadAssemblyIntoCache((Assembly)P_1);
	}
}
