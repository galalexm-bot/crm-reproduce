using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using Mono.Cecil;
using NHibernate.Metadata;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

[Service]
internal sealed class WorkflowMetadataLoaderService : IWorkflowMetadataLoaderService
{
	private static readonly ILogger Log;

	private readonly IMetadataRuntimeService metadataRuntimeService;

	private readonly ProcessHeaderManager processHeaderManager;

	private readonly ISessionProvider sessionProvider;

	private readonly SessionFactoryHolder sessionFactoryHolder;

	private readonly ILockKeyFactory lockKeyFactory;

	private readonly IDictionary<long, Type> fullContextTypes;

	private readonly IDictionary<long, Type> fullInstanceMetricsTypes;

	private readonly IDictionary<long, Type> fullProcessMetricsTypes;

	private readonly IDictionary<Guid, long> headerIdsByMetadataUid;

	private readonly IDictionary<long, string> fullContextAssemblyNames;

	private readonly ConcurrentDictionary<long, byte> headersRegistrations;

	private static string classmapAttributeTypeName;

	internal static WorkflowMetadataLoaderService q2BTm0kW1xUfm2OigMn;

	public WorkflowMetadataLoaderService(IMetadataRuntimeService metadataRuntimeService, ProcessHeaderManager processHeaderManager, ISessionProvider sessionProvider, SessionFactoryHolder sessionFactoryHolder, ILockKeyFactory lockKeyFactory)
	{
		//Discarded unreachable code: IL_008a
		h9T9uEk6Atf7B81NtE1();
		fullContextTypes = new ConcurrentDictionary<long, Type>();
		fullInstanceMetricsTypes = new ConcurrentDictionary<long, Type>();
		fullProcessMetricsTypes = new ConcurrentDictionary<long, Type>();
		headerIdsByMetadataUid = new ConcurrentDictionary<Guid, long>();
		fullContextAssemblyNames = new ConcurrentDictionary<long, string>();
		headersRegistrations = new ConcurrentDictionary<long, byte>();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
			{
				this.sessionFactoryHolder = sessionFactoryHolder;
				int num2 = 5;
				num = num2;
				break;
			}
			default:
				this.sessionProvider = sessionProvider;
				num = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
				{
					num = 4;
				}
				break;
			case 1:
				this.metadataRuntimeService = metadataRuntimeService;
				num = 2;
				break;
			case 3:
				return;
			case 2:
				this.processHeaderManager = processHeaderManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
				{
					num = 0;
				}
				break;
			case 5:
				this.lockKeyFactory = lockKeyFactory;
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public void CheckOrLoadMetadata(IWorkflowProcess process)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				KT9phAk3pV1iktbhaZZ(process, tZvqGEkqHOLpCeLnfg1(-949717965 ^ -949722047));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				RegisterProcessHeaderMetadataInternal((IProcessHeader)DuUm1bkT6yajNfMCQTZ(process), throwOnErrors: true);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				KT9phAk3pV1iktbhaZZ(DuUm1bkT6yajNfMCQTZ(process), tZvqGEkqHOLpCeLnfg1(-684210684 ^ -684236258));
				num2 = 3;
				break;
			case 2:
				return;
			}
		}
	}

	public void RegisterProcessHeaderMetadata(IEnumerable<IProcessHeader> processHeaders)
	{
		foreach (IProcessHeader processHeader in processHeaders)
		{
			RegisterProcessHeaderMetadataInternal(processHeader, throwOnErrors: false);
		}
	}

	public Type GetFullInstanceContextType(long headerId, bool throwOnMissing)
	{
		//Discarded unreachable code: IL_006a, IL_0079
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				throw new MetadataException((string)d5ey5MkQjh9WMVhU5We(tZvqGEkqHOLpCeLnfg1(0x75BAD659 ^ 0x75BA28A3), new object[1] { headerId }));
			case 4:
				return null;
			default:
			{
				if (fullContextTypes.TryGetValue(headerId, out var value))
				{
					return value;
				}
				num2 = 3;
				break;
			}
			case 1:
				CheckOrLoadMetadata(headerId);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (!throwOnMissing)
				{
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public Type GetFullInstanceMetricValuesType(long headerId)
	{
		int num = 1;
		int num2 = num;
		Type value = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return value;
			default:
				fullInstanceMetricsTypes.TryGetValue(headerId, out value);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				CheckOrLoadMetadata(headerId);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Type GetFullProcessMetricValuesType(long headerId)
	{
		int num = 2;
		int num2 = num;
		Type value = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				fullProcessMetricsTypes.TryGetValue(headerId, out value);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return value;
			case 2:
				CheckOrLoadMetadata(headerId);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public long? GetHeaderIdByFullMetadataUid(Guid metadataUid)
	{
		if (headerIdsByMetadataUid.TryGetValue(metadataUid, out var value))
		{
			return value;
		}
		return null;
	}

	public IDictionary<IProcessHeader, Type> GetFullContextTypes()
	{
		_003C_003Ec__DisplayClass20_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_0();
		CS_0024_003C_003E8__locals0.processHeaders = processHeaderManager.FindByIdArray(fullContextTypes.Keys.ToArray());
		return fullContextTypes.ToDictionary(delegate(KeyValuePair<long, Type> k)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_1();
			CS_0024_003C_003E8__locals0.k = k;
			return CS_0024_003C_003E8__locals0.processHeaders.FirstOrDefault((IProcessHeader o) => o.Id == CS_0024_003C_003E8__locals0.k.Key);
		}, (KeyValuePair<long, Type> v) => v.Value);
	}

	public IDictionary<long, Type> GetFullInstanceContextTypes()
	{
		return fullContextTypes.ToDictionary((KeyValuePair<long, Type> k) => k.Key, (KeyValuePair<long, Type> v) => v.Value);
	}

	private void CheckOrLoadMetadata(long headerId)
	{
		//Discarded unreachable code: IL_0046, IL_0084, IL_0094, IL_00a3, IL_00db
		int num = 2;
		int num2 = num;
		IProcessHeader processHeader = default(IProcessHeader);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 8:
				obj = null;
				goto IL_00ff;
			case 1:
			case 3:
				if (processHeader != null)
				{
					num2 = 5;
					break;
				}
				goto case 8;
			default:
				processHeader = (IProcessHeader)kYdyqYkp2Rq75XlCbuD(processHeader);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			case 2:
				processHeader = processHeaderManager.LoadOrNull(headerId);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				RegisterProcessHeaderMetadataInternal(processHeader, throwOnErrors: false);
				num2 = 4;
				break;
			case 5:
				{
					obj = kYdyqYkp2Rq75XlCbuD(processHeader);
					goto IL_00ff;
				}
				IL_00ff:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			}
		}
	}

	private void PrepareRegisterHeaderTypes(IProcessHeader header, Assembly assembly, IDictionary<Type, IProcessHeader> typesToRegister, IDictionary<long, Type> contextTypes, IDictionary<long, Type> instanceMetricsTypes, IDictionary<long, Type> processMetricsTypes)
	{
		if (header.Context == null)
		{
			return;
		}
		if (fullContextAssemblyNames.TryGetValue(header.Id, out var value) && value == header.Context.AssemblyName && fullContextTypes.TryGetValue(header.Id, out var value2))
		{
			IClassMetadata classMetadata = sessionFactoryHolder.SessionFactory.GetClassMetadata(value2);
			if (((classMetadata != null) ? classMetadata.get_MappedClass() : null) == value2)
			{
				if (Log.IsTraceEnabled())
				{
					Log.Trace(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398685387), header.Name, header.Id));
				}
				return;
			}
		}
		if (Log.IsDebugEnabled())
		{
			Log.Debug(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-682910880 ^ -682976400), header.Name, header.Id));
		}
		if (header.Context.AssemblyRaw != null && header.Context.AssemblyRaw.Length != 0 && !string.IsNullOrEmpty(header.Context.AssemblyName))
		{
			if (Log.IsDebugEnabled())
			{
				Log.Debug(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF5D150), header.Name, header.Id));
			}
			string text = Path.Combine(ComponentManager.Current.WorkDirectory, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057756463), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C66B019));
			string text2 = Path.Combine(text, header.Context.AssemblyName + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -419961347));
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			using (IDisposable disposable = lockKeyFactory.Get(text2))
			{
				lock (disposable)
				{
					assembly = ComponentManager.FindLoadedAssembly(header.Context.AssemblyName, isFullName: false);
					if (assembly == null)
					{
						IOExtensions.WriteAllBytesWithAttempts(text2, header.Context.AssemblyRaw, TimeSpan.FromSeconds(1.0), 10);
						assembly = ComponentManager.LoadAssembly(CheckAssembly(header.Context.AssemblyRaw));
					}
				}
			}
			if (Log.IsDebugEnabled())
			{
				Log.Debug(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-148495695 ^ -148429829), header.Name, header.Id));
			}
		}
		if (assembly == null)
		{
			throw new FileNotFoundException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614274E3 ^ 0x61437511), header.Name, header.Id), header.Context.AssemblyName + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56A753C9 ^ 0x56A7F47D));
		}
		Type type = assembly.GetType(header.Context.FullTypeName);
		if (type == null)
		{
			throw new TypeNotFoundException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638160312), header.Name, header.Context.AssemblyName, header.Context.FullTypeName));
		}
		typesToRegister[type] = header;
		contextTypes[header.Id] = type;
		if (header.InstanceMetrics != null && !string.IsNullOrEmpty(header.InstanceMetrics.TypeName))
		{
			Type type2 = assembly.GetType(header.InstanceMetrics.TypeName);
			if (type2 == null)
			{
				Log.WarnFormat(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D7CA21), header.Name, header.Context.AssemblyName, header.InstanceMetrics.FullTypeName);
			}
			else
			{
				typesToRegister[type2] = header;
			}
			instanceMetricsTypes[header.Id] = type2;
		}
		else
		{
			instanceMetricsTypes[header.Id] = null;
		}
		if (header.ProcessMetrics != null && !string.IsNullOrEmpty(header.ProcessMetrics.TypeName))
		{
			Type type3 = assembly.GetType(header.ProcessMetrics.TypeName);
			if (type3 == null)
			{
				Log.WarnFormat(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801874475), header.Name, header.Context.AssemblyName, header.ProcessMetrics.FullTypeName);
			}
			else
			{
				typesToRegister[type3] = header;
			}
			processMetricsTypes[header.Id] = type3;
		}
		else
		{
			processMetricsTypes[header.Id] = null;
		}
		foreach (IProcessHeader item in (IEnumerable<IProcessHeader>)header.SubHeaders)
		{
			PrepareRegisterHeaderTypes(item, assembly, typesToRegister, contextTypes, instanceMetricsTypes, processMetricsTypes);
		}
		if (Log.IsDebugEnabled())
		{
			Log.Debug(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -539934319), header.Name, header.Id));
		}
	}

	private static byte[] CheckAssembly(object assemblyRawBytes)
	{
		//Discarded unreachable code: IL_00ce
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		int num = 8;
		int num2 = num;
		AssemblyDefinition val2 = default(AssemblyDefinition);
		ModuleDefinition val = default(ModuleDefinition);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 8:
			{
				MemoryStream memoryStream2 = MemoryHelper.GetMemoryStream((byte[])assemblyRawBytes, writable: false);
				NFHmoKkCKDbiwMjZUle(memoryStream2, 0L, SeekOrigin.Begin);
				ReaderParameters val3 = new ReaderParameters();
				val3.set_AssemblyResolver((IAssemblyResolver)(object)new EntityDynamicGenerator.AssemblyResolver());
				val2 = (AssemblyDefinition)vv8aw8kM5SvUV9n79Ch(memoryStream2, (object)val3);
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num2 = 7;
				}
				break;
			}
			case 7:
				val = (ModuleDefinition)deDDP6kkG5d4c8eZiIa(val2);
				num2 = 4;
				break;
			case 6:
				memoryStream = MemoryHelper.GetMemoryStream();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				lQ0bfakUa86335uk9CK(val2, memoryStream);
				num2 = 5;
				break;
			default:
				return (byte[])IxPkTFkVCP6BNHDwLSF(memoryStream);
			case 5:
				NFHmoKkCKDbiwMjZUle(memoryStream, 0L, SeekOrigin.Begin);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (((ICollection<AssemblyNameReference>)val.get_AssemblyReferences()).RemoveAll((AssemblyNameReference r) => (string)_003C_003Ec.AKUXv4Z7SyDMvqKmy7UP(r) == SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x141C968 ^ 0x1431B2E)) != 0)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 2:
				return (byte[])assemblyRawBytes;
			case 1:
				((IEnumerable<TypeDefinition>)val.get_Types()).Where((TypeDefinition t) => ((MemberReference)t).get_FullName() != "<Module>").SelectRecursive((TypeDefinition t) => (IEnumerable<TypeDefinition>)t.get_NestedTypes()).ForEach(delegate(TypeDefinition tr)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							((ICollection<CustomAttribute>)tr.get_CustomAttributes()).RemoveAll((CustomAttribute a) => _003C_003Ec.phM9BYZ7E3q1XeZfmXcR(_003C_003Ec.LyoO7GZ7h1FVvAuim2O1(_003C_003Ec.n1fq66Z71dlN9ei4sp0j(a)), classmapAttributeTypeName));
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				});
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private void RegisterProcessHeaderMetadataInternal(IProcessHeader processHeader, bool throwOnErrors)
	{
		//Discarded unreachable code: IL_012e, IL_0245, IL_0254, IL_0263, IL_02fc, IL_030f, IL_031e, IL_035a, IL_038d, IL_043c, IL_044b, IL_045a, IL_048b, IL_049a, IL_04aa, IL_04b9, IL_0565, IL_0574, IL_0585, IL_0594, IL_059f, IL_06ea, IL_06fd, IL_077e, IL_078d, IL_07fe, IL_08ea, IL_08fd, IL_0a30, IL_0a63, IL_0b03, IL_0b12, IL_0b21, IL_0b86, IL_0b99, IL_0ba8, IL_0bb7, IL_0bef, IL_0bfe, IL_0c6c
		int num = 3;
		_003C_003Ec__DisplayClass25_0 _003C_003Ec__DisplayClass25_ = default(_003C_003Ec__DisplayClass25_0);
		Dictionary<long, Type>.Enumerator enumerator = default(Dictionary<long, Type>.Enumerator);
		IMetadata metadata3 = default(IMetadata);
		KeyValuePair<long, Type> current3 = default(KeyValuePair<long, Type>);
		IProcessHeader value = default(IProcessHeader);
		Dictionary<long, Type> dictionary4 = default(Dictionary<long, Type>);
		Dictionary<long, Type> dictionary3 = default(Dictionary<long, Type>);
		Dictionary<long, Type> dictionary2 = default(Dictionary<long, Type>);
		string message = default(string);
		_003C_003Ec__DisplayClass25_1 _003C_003Ec__DisplayClass25_2 = default(_003C_003Ec__DisplayClass25_1);
		KeyValuePair<long, Type> current2 = default(KeyValuePair<long, Type>);
		IMetadata metadata2 = default(IMetadata);
		KeyValuePair<long, Type> current = default(KeyValuePair<long, Type>);
		IMetadata metadata = default(IMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
				case 10:
					uhs6TFk2V5jaBVYFjyL(50);
					num2 = 14;
					continue;
				case 14:
					if (!headersRegistrations.TryAdd(_003C_003Ec__DisplayClass25_.processHeader.Id, 0))
					{
						num2 = 7;
						continue;
					}
					goto case 1;
				case 15:
					return;
				case 9:
					if (!headersRegistrations.TryAdd(_003C_003Ec__DisplayClass25_.processHeader.Id, 0))
					{
						num2 = 5;
						continue;
					}
					goto case 6;
				case 3:
					_003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_0();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
				case 11:
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass25_.processHeader = processHeader;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num2 = 4;
					}
					continue;
				case 8:
					return;
				case 13:
					egeXASk7qQFD9JroQsP(Log, SR.T((string)tZvqGEkqHOLpCeLnfg1(-420003255 ^ -420067479), GUrQ3akG57dGqxAW1Sg(_003C_003Ec__DisplayClass25_.processHeader), _003C_003Ec__DisplayClass25_.processHeader.Id));
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
					{
						num2 = 7;
					}
					continue;
				case 12:
					Log.Debug(SR.T((string)tZvqGEkqHOLpCeLnfg1(-862330810 ^ -862394912), _003C_003Ec__DisplayClass25_.processHeader.Name, _003C_003Ec__DisplayClass25_.processHeader.Id));
					num2 = 11;
					continue;
				case 1:
					if (!O4QHb5kAfUwnKAjmBuF(Log))
					{
						num2 = 6;
						continue;
					}
					goto case 12;
				case 4:
					if (_003C_003Ec__DisplayClass25_.processHeader == null)
					{
						return;
					}
					goto end_IL_0012;
				case 5:
					if (O4QHb5kAfUwnKAjmBuF(Log))
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 7;
				}
				try
				{
					Dictionary<Type, IProcessHeader> dictionary = new Dictionary<Type, IProcessHeader>();
					int num3 = 22;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						int num9;
						switch (num3)
						{
						case 14:
							try
							{
								while (true)
								{
									IL_020e:
									int num14;
									if (!enumerator.MoveNext())
									{
										num14 = 6;
										goto IL_013c;
									}
									goto IL_01b3;
									IL_013c:
									while (true)
									{
										switch (num14)
										{
										default:
										{
											metadata3 = (IMetadata)amIhGYkIKe03FnVeD4l(current3.Value, true, true);
											int num15 = 2;
											num14 = num15;
											continue;
										}
										case 2:
											headerIdsByMetadataUid[oUiJNYkaOu6W4tmF0Og(metadata3)] = current3.Key;
											num14 = 7;
											continue;
										case 10:
											break;
										case 1:
											fullContextAssemblyNames[current3.Key] = (string)JMgj6mki3RUMyCnSWLM(XLJdmFkFQinUVCKHfKX(value));
											num14 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
											{
												num14 = 0;
											}
											continue;
										case 4:
										case 7:
											goto IL_020e;
										case 9:
											if (!(current3.Value != null))
											{
												num14 = 4;
												continue;
											}
											goto case 8;
										case 8:
											if (!dictionary.TryGetValue(current3.Value, out value))
											{
												num14 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
												{
													num14 = 3;
												}
												continue;
											}
											goto case 1;
										case 5:
											fullContextTypes[current3.Key] = current3.Value;
											num14 = 9;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
											{
												num14 = 9;
											}
											continue;
										case 6:
											goto end_IL_020e;
										}
										break;
									}
									goto IL_01b3;
									IL_01b3:
									current3 = enumerator.Current;
									num14 = 5;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
									{
										num14 = 2;
									}
									goto IL_013c;
									continue;
									end_IL_020e:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num16 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
								{
									num16 = 0;
								}
								switch (num16)
								{
								case 0:
									break;
								}
							}
							goto case 9;
						case 3:
							try
							{
								PrepareRegisterHeaderTypes(_003C_003Ec__DisplayClass25_.processHeader, null, dictionary, dictionary4, dictionary3, dictionary2);
								int num12 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
								{
									num12 = 0;
								}
								switch (num12)
								{
								case 0:
									break;
								}
							}
							catch (Exception ex2)
							{
								int num13 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
								{
									num13 = 0;
								}
								while (true)
								{
									switch (num13)
									{
									case 3:
										Log.Error(message, ex2);
										num13 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
										{
											num13 = 1;
										}
										break;
									case 1:
										if (throwOnErrors)
										{
											num13 = 2;
											break;
										}
										goto end_IL_0391;
									default:
										message = (string)d5ey5MkQjh9WMVhU5We(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17F0C5A2 ^ 0x17F1C3E2), new object[2]
										{
											GUrQ3akG57dGqxAW1Sg(_003C_003Ec__DisplayClass25_.processHeader),
											_003C_003Ec__DisplayClass25_.processHeader.Id
										});
										num13 = 3;
										break;
									case 2:
										throw new InvalidOperationException(message, ex2);
									}
									continue;
									end_IL_0391:
									break;
								}
							}
							goto case 24;
						case 23:
							return;
						case 22:
							dictionary4 = new Dictionary<long, Type>();
							num3 = 7;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
							{
								num3 = 4;
							}
							continue;
						case 1:
							return;
						default:
							_003C_003Ec__DisplayClass25_2.hasFaileds = false;
							num3 = 8;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
							{
								num3 = 8;
							}
							continue;
						case 12:
							dictionary2 = new Dictionary<long, Type>();
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
							{
								num3 = 3;
							}
							continue;
						case 21:
							if (_003C_003Ec__DisplayClass25_2.hasFaileds)
							{
								num3 = 7;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
								{
									num3 = 18;
								}
								continue;
							}
							goto case 10;
						case 4:
						case 18:
							if (!throwOnErrors)
							{
								num3 = 19;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
								{
									num3 = 23;
								}
								continue;
							}
							break;
						case 9:
							enumerator = dictionary3.GetEnumerator();
							num3 = 20;
							continue;
						case 16:
							return;
						case 20:
							try
							{
								while (true)
								{
									int num10;
									if (!enumerator.MoveNext())
									{
										num10 = 2;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
										{
											num10 = 3;
										}
										goto IL_05a3;
									}
									goto IL_069b;
									IL_069b:
									current2 = enumerator.Current;
									num10 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
									{
										num10 = 0;
									}
									goto IL_05a3;
									IL_05a3:
									while (true)
									{
										switch (num10)
										{
										case 1:
											metadata2 = (IMetadata)amIhGYkIKe03FnVeD4l(current2.Value, true, true);
											num10 = 6;
											continue;
										case 4:
											break;
										case 2:
											if (V4JGnHkrdnwbSW28l7b(current2.Value, null))
											{
												num10 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
												{
													num10 = 1;
												}
												continue;
											}
											break;
										default:
											fullInstanceMetricsTypes[current2.Key] = current2.Value;
											num10 = 2;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
											{
												num10 = 2;
											}
											continue;
										case 6:
											headerIdsByMetadataUid[oUiJNYkaOu6W4tmF0Og(metadata2)] = current2.Key;
											num10 = 4;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
											{
												num10 = 1;
											}
											continue;
										case 5:
											goto IL_069b;
										case 3:
											goto end_IL_05e3;
										}
										break;
									}
									continue;
									end_IL_05e3:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num11 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
								{
									num11 = 0;
								}
								switch (num11)
								{
								case 0:
									break;
								}
							}
							goto case 13;
						case 6:
							vcFrp6kxJxIci5IViks(Log, dXIc87kNMDMRnQucWV4(tZvqGEkqHOLpCeLnfg1(0x6871CA ^ 0x6976B8)));
							num9 = 16;
							goto IL_00b6;
						case 10:
							enumerator = dictionary4.GetEnumerator();
							num3 = 6;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
							{
								num3 = 14;
							}
							continue;
						case 7:
							dictionary3 = new Dictionary<long, Type>();
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
							{
								num3 = 12;
							}
							continue;
						case 2:
							try
							{
								while (true)
								{
									int num6;
									if (!enumerator.MoveNext())
									{
										num6 = 5;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
										{
											num6 = 6;
										}
										goto IL_079c;
									}
									goto IL_0861;
									IL_0861:
									current = enumerator.Current;
									num6 = 7;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
									{
										num6 = 5;
									}
									goto IL_079c;
									IL_079c:
									while (true)
									{
										switch (num6)
										{
										case 7:
											fullProcessMetricsTypes[current.Key] = current.Value;
											num6 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
											{
												num6 = 1;
											}
											continue;
										case 2:
										case 3:
											break;
										case 4:
											headerIdsByMetadataUid[oUiJNYkaOu6W4tmF0Og(metadata)] = current.Key;
											num6 = 2;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
											{
												num6 = 2;
											}
											continue;
										default:
											goto IL_0861;
										case 1:
											if (!(current.Value != null))
											{
												num6 = 3;
												continue;
											}
											goto case 5;
										case 5:
										{
											metadata = (IMetadata)amIhGYkIKe03FnVeD4l(current.Value, true, true);
											int num7 = 4;
											num6 = num7;
											continue;
										}
										case 6:
											goto end_IL_0808;
										}
										break;
									}
									continue;
									end_IL_0808:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num8 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
								{
									num8 = 0;
								}
								switch (num8)
								{
								case 0:
									break;
								}
							}
							goto case 11;
						case 13:
							enumerator = dictionary2.GetEnumerator();
							num9 = 2;
							goto IL_00b6;
						case 15:
							_003C_003Ec__DisplayClass25_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass25_;
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
							{
								num3 = 0;
							}
							continue;
						case 11:
							if (!JrGLM9keRZc628PSPJi(Log))
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 6;
						case 19:
							_003C_003Ec__DisplayClass25_2 = new _003C_003Ec__DisplayClass25_1();
							num9 = 15;
							goto IL_00b6;
						case 24:
							if (dictionary.Count <= 0)
							{
								num3 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
								{
									num3 = 5;
								}
								continue;
							}
							goto case 19;
						case 8:
							try
							{
								metadataRuntimeService.RegisterTypes(dictionary.Keys, dictionary.ToDictionary((KeyValuePair<Type, IProcessHeader> p) => p.Key, (KeyValuePair<Type, IProcessHeader> p) => p.Key.FullName), _003C_003Ec__DisplayClass25_2._003CRegisterProcessHeaderMetadataInternal_003Eb__2);
								int num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
							catch (Exception ex)
							{
								int num5 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									case 2:
										_003C_003Ec__DisplayClass25_2.hasFaileds = true;
										num5 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
										{
											num5 = 0;
										}
										continue;
									case 1:
										BAq5NAkotu3nHG67IM0(Log, ex, SR.T((string)tZvqGEkqHOLpCeLnfg1(-961162596 ^ -961227650)), new object[2]
										{
											GUrQ3akG57dGqxAW1Sg(_003C_003Ec__DisplayClass25_2.CS_0024_003C_003E8__locals1.processHeader),
											_003C_003Ec__DisplayClass25_2.CS_0024_003C_003E8__locals1.processHeader.Id
										});
										num5 = 2;
										continue;
									case 0:
										break;
									}
									break;
								}
							}
							goto case 21;
						case 5:
							return;
						case 17:
							break;
							IL_00b6:
							num3 = num9;
							continue;
						}
						break;
					}
					throw new InvalidOperationException((string)dXIc87kNMDMRnQucWV4(tZvqGEkqHOLpCeLnfg1(-1516552726 ^ -1516619222)));
				}
				finally
				{
					headersRegistrations.TryRemove(_003C_003Ec__DisplayClass25_.processHeader.Id, out var _);
					int num17 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
					{
						num17 = 0;
					}
					switch (num17)
					{
					case 0:
						break;
					}
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	static WorkflowMetadataLoaderService()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				h9T9uEk6Atf7B81NtE1();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				Log = (ILogger)z98NlFkSYqnZy408qjC(tZvqGEkqHOLpCeLnfg1(0x2ACCDD87 ^ 0x2ACDD5A3));
				num2 = 3;
				break;
			case 3:
				classmapAttributeTypeName = TypeOf<ClassMapAttribute>.FullName;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void h9T9uEk6Atf7B81NtE1()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool OfByMxkjMJAMcCKHGYg()
	{
		return q2BTm0kW1xUfm2OigMn == null;
	}

	internal static WorkflowMetadataLoaderService jZE3BPkRojwg5EnIfRg()
	{
		return q2BTm0kW1xUfm2OigMn;
	}

	internal static object tZvqGEkqHOLpCeLnfg1(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void KT9phAk3pV1iktbhaZZ(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object DuUm1bkT6yajNfMCQTZ(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static object d5ey5MkQjh9WMVhU5We(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object kYdyqYkp2Rq75XlCbuD(object P_0)
	{
		return ((IProcessHeader)P_0).Parent;
	}

	internal static long NFHmoKkCKDbiwMjZUle(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static object vv8aw8kM5SvUV9n79Ch(object P_0, object P_1)
	{
		return AssemblyDefinition.ReadAssembly((Stream)P_0, (ReaderParameters)P_1);
	}

	internal static object deDDP6kkG5d4c8eZiIa(object P_0)
	{
		return ((AssemblyDefinition)P_0).get_MainModule();
	}

	internal static void lQ0bfakUa86335uk9CK(object P_0, object P_1)
	{
		((AssemblyDefinition)P_0).Write((Stream)P_1);
	}

	internal static object IxPkTFkVCP6BNHDwLSF(object P_0)
	{
		return ((MemoryStream)P_0).GetBuffer();
	}

	internal static bool O4QHb5kAfUwnKAjmBuF(object P_0)
	{
		return ((ILogger)P_0).IsDebugEnabled();
	}

	internal static object GUrQ3akG57dGqxAW1Sg(object P_0)
	{
		return ((IProcessHeader)P_0).Name;
	}

	internal static void egeXASk7qQFD9JroQsP(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static void uhs6TFk2V5jaBVYFjyL(int P_0)
	{
		Thread.Sleep(P_0);
	}

	internal static void BAq5NAkotu3nHG67IM0(object P_0, object P_1, object P_2, object P_3)
	{
		((ILogger)P_0).Error((Exception)P_1, (string)P_2, (object[])P_3);
	}

	internal static object XLJdmFkFQinUVCKHfKX(object P_0)
	{
		return ((IProcessHeader)P_0).Context;
	}

	internal static object JMgj6mki3RUMyCnSWLM(object P_0)
	{
		return ((ProcessContext)P_0).AssemblyName;
	}

	internal static object amIhGYkIKe03FnVeD4l(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static Guid oUiJNYkaOu6W4tmF0Og(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static bool V4JGnHkrdnwbSW28l7b(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool JrGLM9keRZc628PSPJi(object P_0)
	{
		return ((ILogger)P_0).IsTraceEnabled();
	}

	internal static object dXIc87kNMDMRnQucWV4(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void vcFrp6kxJxIci5IViks(object P_0, object P_1)
	{
		((ILogger)P_0).Trace(P_1);
	}

	internal static object z98NlFkSYqnZy408qjC(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
