using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using Autofac.Builder;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ComponentModel.Components;

public abstract class AbstractMetadataEditorComponent : IInitHandler, IMetadataEditorService, IMetadataService
{
	private Dictionary<Type, IMetadataTypeInfo> metadataTypeInfos;

	protected DateTime lastMetadataUpdate;

	private string currentProjectName;

	private ISet<string> processedAssemblyNames;

	private IDictionary<string, ISet<string>> projectReferences;

	private IDictionary<string, IDictionary<Guid, IMetadata>> metadataByProjects;

	private Dictionary<KeyValuePair<Guid, Guid>, ITypeDescriptor> _typeDescriptorsByUid;

	private readonly Dictionary<Type, ITypeDescriptor> _typeDescriptorsByType;

	internal static AbstractMetadataEditorComponent GGmLhxfIXZPxMDyk1G02;

	public abstract string ProjectName { get; }

	public virtual string CurrentProjectName
	{
		get
		{
			return currentProjectName;
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
					currentProjectName = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
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

	public IEnumerable<string> ProjectNames => projectReferences.Keys;

	void IInitHandler.Init()
	{
		cBSlISfIn169p0eSnQLa(this);
	}

	void IInitHandler.InitComplete()
	{
		TBjAHJfIOLMfaywRR7cl(this);
	}

	public IMetadata GetMetadata(Guid metadataUid, bool loadImplementation = true)
	{
		//Discarded unreachable code: IL_0079, IL_0088, IL_0097
		int num = 6;
		IMetadata metadata = default(IMetadata);
		string currentProject = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					if (metadataByProjects.ContainsKey((string)J8l8YHfIesBlDmt2hcCJ(-561074844 ^ -561076480)))
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 5:
					metadata = (IMetadata)gkSw6ffI2CTeP9V02INX(this, currentProject, metadataUid);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 1;
					}
					break;
				case 6:
					currentProject = GetCurrentProject();
					num2 = 5;
					break;
				case 4:
					metadata = (IMetadata)gkSw6ffI2CTeP9V02INX(this, J8l8YHfIesBlDmt2hcCJ(-643786247 ^ -643787875), metadataUid);
					num2 = 2;
					break;
				case 1:
					if (metadata != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto default;
				case 2:
				case 3:
				case 7:
					return metadata;
				default:
					if (!iwGRixfIPO6XxlVQeRpd(currentProject, J8l8YHfIesBlDmt2hcCJ(-97972138 ^ -97969614)))
					{
						num2 = 7;
						break;
					}
					goto case 8;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public virtual IMetadata GetMetadata(string projectName, Guid metadataUid)
	{
		return GetMetadata(projectName, metadataUid, failIfNotExists: true);
	}

	public IEnumerable<ITypeDescriptor> GetTypeDescriptors()
	{
		return _typeDescriptorsByUid.Values;
	}

	public ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid)
	{
		//Discarded unreachable code: IL_006c, IL_007e
		int num = 1;
		int num2 = num;
		ITypeDescriptor value = default(ITypeDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_typeDescriptorsByUid.TryGetValue(new KeyValuePair<Guid, Guid>(typeUid, Guid.Empty), out value);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 2;
				}
				break;
			default:
				return value;
			case 4:
				if (!KKbUJXfI16c7q0SJChIl(subTypeUid, Guid.Empty))
				{
					num2 = 5;
					break;
				}
				goto case 3;
			case 1:
				if (_typeDescriptorsByUid.TryGetValue(new KeyValuePair<Guid, Guid>(typeUid, subTypeUid), out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public IEnumerable<ITypeDescriptor> GetIdTypeDescriptors()
	{
		return _typeDescriptorsByUid.Values.Where((ITypeDescriptor t) => _003C_003Ec.ptoFSu85HDAUwZJVPFjI(t));
	}

	public ITypeDescriptor GetIdTypeDescriptor(Guid typeUid)
	{
		//Discarded unreachable code: IL_0054
		int num = 2;
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return null;
				case 4:
					if (NJaUx7fIN20UqbclyXD9(typeDescriptor))
					{
						return typeDescriptor;
					}
					goto end_IL_0012;
				case 1:
					if (typeDescriptor == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				case 2:
					typeDescriptor = GetTypeDescriptor(typeUid, Guid.Empty);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public IEnumerable<IMetadata> GetMetadataList()
	{
		return GetMetadataList(inherited: true);
	}

	public IEnumerable<IMetadata> GetMetadataList(bool inherited)
	{
		return GetMetadataList(GetCurrentProject(), inherited);
	}

	public virtual IEnumerable<IMetadata> GetMetadataList(string projectName, bool inherited)
	{
		if (!inherited)
		{
			if (!metadataByProjects.TryGetValue(projectName, out var value))
			{
				throw ProjectNotFound(projectName);
			}
			return value.Values;
		}
		return AllReferences(projectName, new HashSet<string>()).SelectMany((string p) => GetMetadataList(p, inherited: false)).ToArray();
		IEnumerable<string> AllReferences(string prjName, ISet<string> processedProjects)
		{
			_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.processedProjects = processedProjects;
			if (CS_0024_003C_003E8__locals0.processedProjects.Add(prjName) && projectReferences.TryGetValue(prjName, out var value2))
			{
				return value2.SelectMany((string r) => AllReferences(r, CS_0024_003C_003E8__locals0.processedProjects)).Prepend(prjName);
			}
			return Enumerable.Empty<string>();
		}
	}

	public AssemblyInfoMetadata GetAssemblyInfoMetadata(string projectName)
	{
		return GetMetadataList(projectName, inherited: false).OfType<AssemblyInfoMetadata>().FirstOrDefault();
	}

	public void SaveMetadata(IMetadata metadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SaveMetadata(new IMetadata[1] { metadata });
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				lastMetadataUpdate = jDaBuXfI3juKoxn0jicw();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public abstract void SaveMetadata(IEnumerable<IMetadata> metadataList);

	public void PublishMetadata(IMetadata metadata, string comment)
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
				PublishMetadata(new IMetadata[1] { metadata }, comment);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public abstract void PublishMetadata(IEnumerable<IMetadata> metadataList, string comment);

	public abstract void RemoveMetadata(IMetadata metadata);

	public virtual ICodeGenerator CreateCodeGenerator(IMetadata metadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				zlQdvVfIp7ibX2GwtyJ4(metadata, J8l8YHfIesBlDmt2hcCJ(-289714582 ^ -289732780));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				ICodeGenerator obj = (ICodeGenerator)r1nf9MfIaRj0o0ChTNVX((GetMetadataTypeInfo(metadata.GetType()) ?? throw new CodeGeneratorCreateException()).GeneratorType);
				jshARyfIDrblKtm4Z11d(obj, metadata);
				return obj;
			}
			}
		}
	}

	public ITypeDescriptor GetTypeDescriptor(Type runtimeType)
	{
		//Discarded unreachable code: IL_0049, IL_00e7, IL_011b, IL_012a
		int num = 2;
		int num2 = num;
		Type key = default(Type);
		ITypeDescriptor value = default(ITypeDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 9:
				_typeDescriptorsByType.TryGetValue(key, out value);
				num2 = 5;
				break;
			case 6:
				key = runtimeType.GetGenericArguments()[0];
				num2 = 9;
				break;
			case 2:
				_typeDescriptorsByType.TryGetValue(runtimeType, out value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (value != null)
				{
					num2 = 8;
					break;
				}
				goto case 7;
			case 4:
				if (!IwHVTxfIw7PjXaFKuwNj(runtimeType.GetGenericTypeDefinition(), cGUtZUfIt1cNiinZpVZY(typeof(Nullable<>).TypeHandle)))
				{
					num2 = 3;
					break;
				}
				goto case 6;
			default:
				return value;
			case 7:
				if (!runtimeType.IsGenericType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public abstract void BuildDocumentation();

	public abstract MetadataItemDTO GetMetadataItemDTO(IMetadata metadata);

	public abstract IEnumerable<MetadataItemDTO> GetMetadataItemDTOList();

	public virtual bool IsSystem(Guid typeUid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = default(_003C_003Ec__DisplayClass27_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass27_.typeUid = typeUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return metadataByProjects.Where((KeyValuePair<string, IDictionary<Guid, IMetadata>> p) => p.Key != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138015845) && p.Key != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822888906)).Any(_003C_003Ec__DisplayClass27_._003CIsSystem_003Eb__1);
			}
		}
	}

	public virtual bool IsConfig(Guid typeUid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = default(_003C_003Ec__DisplayClass28_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return GetMetadataList(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867824088), inherited: false).Any(_003C_003Ec__DisplayClass28_._003CIsConfig_003Eb__0);
			case 2:
				_003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass28_.typeUid = typeUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void OnInit()
	{
		//Discarded unreachable code: IL_005d, IL_010a, IL_0142, IL_0151
		int num = 1;
		int num2 = num;
		IEnumerator<IMetadataTypeInfo> enumerator = default(IEnumerator<IMetadataTypeInfo>);
		IMetadataTypeInfo current = default(IMetadataTypeInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = ((ComponentManager)lYULLCfI4qH4aZu2Gko4()).GetExtensionPoints<IMetadataTypeInfo>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				try
				{
					while (true)
					{
						IL_0085:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
							{
								num3 = 0;
							}
							goto IL_006b;
						}
						goto IL_00ab;
						IL_00ab:
						current = enumerator.Current;
						int num4 = 2;
						num3 = num4;
						goto IL_006b;
						IL_006b:
						while (true)
						{
							switch (num3)
							{
							case 1:
								goto IL_0085;
							case 3:
								goto IL_00ab;
							case 2:
								ProcessMetadataType(current);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
								{
									num3 = 1;
								}
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
					if (enumerator != null)
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								enumerator.Dispose();
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
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
				}
				break;
			case 2:
				break;
			case 3:
				return;
			}
			RegisterComponent(RegistrationExtensions.RegisterInstance<AbstractMetadataEditorComponent>(ComponentManager.Builder, this).SingleInstance());
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
			{
				num2 = 3;
			}
		}
	}

	protected virtual void OnInitComplete()
	{
		InitTypeDescriptors();
	}

	protected virtual void RegisterComponent(IRegistrationBuilder<AbstractMetadataEditorComponent, SimpleActivatorData, SingleRegistrationStyle> registrar)
	{
		registrar.As<IMetadataEditorService>();
	}

	protected virtual void Reset()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				lastMetadataUpdate = DateTime.Now;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 3;
				}
				break;
			default:
				metadataByProjects.Clear();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				qega7ifI6Yw7adLwqR8b(projectReferences);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual bool IsAssemblyProcessed(string assemblyName)
	{
		return processedAssemblyNames.Contains(assemblyName);
	}

	protected virtual void ProcessAssembly(Assembly assembly, bool hasSources = false)
	{
		//Discarded unreachable code: IL_009f, IL_00f2, IL_0125, IL_0182, IL_0191, IL_01be, IL_028f, IL_02c5, IL_035f, IL_0392, IL_047e, IL_048d, IL_049d, IL_04ac, IL_0510
		int num = 19;
		int num2 = num;
		string assemblyShortName = default(string);
		IDictionary<Guid, IMetadata> dictionary = default(IDictionary<Guid, IMetadata>);
		IMetadata metadata = default(IMetadata);
		Type type = default(Type);
		Type[] array = default(Type[]);
		int num7 = default(int);
		Type[] types = default(Type[]);
		ReflectionTypeLoadException ex2 = default(ReflectionTypeLoadException);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 18:
				return;
			case 9:
				swe4MOfIM636DklPk2D7(this, assemblyShortName);
				num2 = 13;
				continue;
			case 21:
				if (dictionary == null)
				{
					num2 = 9;
					continue;
				}
				goto case 5;
			case 14:
				try
				{
					metadata = MetadataLoader.LoadMetadata(type, inherit: false);
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex3)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							h7TnDxfIyHjfFG2k1eGB(TfNsSJfIxpah9yJXNSsu(), RsDDUXfImBFwXlMoIEgj(J8l8YHfIesBlDmt2hcCJ(0x103FE975 ^ 0x103AA937), type.FullName), ex3);
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num6 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
					break;
				}
				goto case 4;
			case 23:
				assemblyShortName = ComponentManager.GetAssemblyShortName(assembly);
				num2 = 24;
				continue;
			case 12:
				return;
			case 17:
				num2 = 3;
				continue;
			case 24:
				dictionary = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				if (AttributeHelper<MetadataTypeAttribute>.GetAttribute(type, inherited: false) != null)
				{
					num2 = 14;
					continue;
				}
				break;
			case 8:
				fymFs5fI9wd3vlp1pjXp(this, assemblyShortName, metadata);
				num2 = 20;
				continue;
			case 22:
				return;
			case 11:
			case 25:
				type = array[num7];
				num2 = 2;
				continue;
			case 4:
				if (metadata == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 10;
					}
					continue;
				}
				goto case 21;
			case 6:
				lastMetadataUpdate = DateTime.Now;
				num2 = 22;
				continue;
			default:
				if (num7 < array.Length)
				{
					num2 = 25;
					continue;
				}
				goto case 6;
			case 7:
				num7 = 0;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				array = types;
				num2 = 7;
				continue;
			case 13:
				dictionary = metadataByProjects[assemblyShortName];
				num2 = 5;
				continue;
			case 19:
				if (processedAssemblyNames.Add((string)pvbh22fIH7k3Gmw3VQ5w(assembly)))
				{
					if (AttributeHelper<ModelAssemblyAttribute>.GetAttribute(assembly) == null)
					{
						return;
					}
					num2 = 17;
				}
				else
				{
					num2 = 18;
				}
				continue;
			case 5:
				if (dictionary.ContainsKey(Je6HHRfIJMfh59XuamB5(metadata)))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 15;
					}
					continue;
				}
				goto case 8;
			case 10:
			case 15:
			case 20:
				break;
			case 3:
				try
				{
					types = assembly.GetTypes();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
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
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 3:
							return;
						case 6:
							return;
						case 1:
						case 2:
							h7TnDxfIyHjfFG2k1eGB(TfNsSJfIxpah9yJXNSsu(), RsDDUXfImBFwXlMoIEgj(J8l8YHfIesBlDmt2hcCJ(-1487388570 ^ -1487044728), assembly.FullName), ex);
							num4 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
							{
								num4 = 2;
							}
							continue;
						default:
							if ((ex2 = ex as ReflectionTypeLoadException) == null)
							{
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
								{
									num4 = 1;
								}
								continue;
							}
							break;
						case 4:
							((ILogger)TfNsSJfIxpah9yJXNSsu()).Error(string.Format((string)J8l8YHfIesBlDmt2hcCJ(0x12A5FAC7 ^ 0x12A0C529), (string)XhYmMWfI0jnRmHBuw1i5(assembly) + Environment.NewLine + text), ex);
							num4 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
							{
								num4 = 6;
							}
							continue;
						case 5:
							break;
						}
						text = (string)SVEoIPfI7XxMxaYvHN1c(J8l8YHfIesBlDmt2hcCJ(0x34185E55 ^ 0x341B6E43), ((IEnumerable<Exception>)c1YO8UfIADAxFM4naM02(ex2)).Select((Exception e) => e.ToString()).ToArray());
						num4 = 4;
					}
				}
				goto case 23;
			}
			num7++;
			num2 = 14;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
			{
				num2 = 16;
			}
		}
	}

	protected virtual void AddOrReplaceMetadata(string projectName, IMetadata metadata)
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
			{
				if (!metadataByProjects.TryGetValue(projectName, out var value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					value[Je6HHRfIJMfh59XuamB5(metadata)] = metadata;
					num2 = 3;
				}
				break;
			}
			case 3:
				lastMetadataUpdate = DateTime.Now;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				throw ProjectNotFound(projectName);
			case 0:
				return;
			}
		}
	}

	protected virtual void RemoveMetadata(string projectName, IMetadata metadata)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				throw ProjectNotFound(projectName);
			case 3:
				lastMetadataUpdate = DateTime.Now;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
			{
				if (metadataByProjects.TryGetValue(projectName, out var value))
				{
					value.Remove(Je6HHRfIJMfh59XuamB5(metadata));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 1;
					}
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	protected virtual void AddProject(string projectName)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (ProjectExists(projectName))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 1;
					}
					break;
				}
				projectReferences.Add(projectName, new HashSet<string>());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				metadataByProjects.Add(projectName, new Dictionary<Guid, IMetadata>());
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				return;
			case 3:
				return;
			}
		}
	}

	protected virtual void AddProjectReference(string projectName, string assemblyName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
			{
				if (!projectReferences.TryGetValue(projectName, out var value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				}
				value.Add(assemblyName);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 2;
				}
				break;
			}
			default:
				throw ProjectNotFound(projectName);
			}
		}
	}

	protected virtual void RemoveProjectReference(string projectName, string assemblyName)
	{
		//Discarded unreachable code: IL_005f, IL_006e
		int num = 2;
		int num2 = num;
		ISet<string> value = default(ISet<string>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (projectReferences.TryGetValue(projectName, out value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 0:
				return;
			case 3:
				throw ProjectNotFound(projectName);
			case 1:
				value.Remove(assemblyName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void RemoveProject(string projectName)
	{
		//Discarded unreachable code: IL_0032, IL_0041
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				if (projectReferences.Remove(projectName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				throw ProjectNotFound(projectName);
			default:
				metadataByProjects.Remove(projectName);
				num2 = 3;
				break;
			}
		}
	}

	protected virtual bool ProjectExists(string projectName)
	{
		return projectReferences.ContainsKey(projectName);
	}

	protected virtual void RenameProject(string oldName, string newName)
	{
		//Discarded unreachable code: IL_00bc, IL_00cb
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (JXG5fBfIdoBl6OAo31Ak(this, oldName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 1;
			case 1:
				throw ProjectNotFound(oldName);
			case 4:
				metadataByProjects[newName] = metadataByProjects[oldName];
				num2 = 3;
				break;
			case 2:
				return;
			case 3:
				projectReferences[newName] = projectReferences[oldName];
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				d2FDqufIlXIqwB0ylg62(this, oldName);
				num2 = 2;
				break;
			}
		}
	}

	private void InitTypeDescriptors()
	{
		//Discarded unreachable code: IL_002e, IL_003d, IL_0048, IL_007f, IL_019a, IL_01b9, IL_01c8, IL_01f5, IL_0204
		int num = 1;
		int num2 = num;
		IEnumerator<ITypeDescriptor> enumerator = default(IEnumerator<ITypeDescriptor>);
		IRuntimeTypeDescriptor runtimeTypeDescriptor = default(IRuntimeTypeDescriptor);
		ITypeDescriptor current = default(ITypeDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				enumerator = ComponentManager.Current.GetExtensionPoints<ITypeDescriptor>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!TtGXCtfIjnyl7X6GOPGT(enumerator))
					{
						num3 = 8;
						goto IL_004c;
					}
					goto IL_0161;
					IL_004c:
					while (true)
					{
						switch (num3)
						{
						case 7:
							if (runtimeTypeDescriptor != null)
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
								{
									num3 = 2;
								}
								continue;
							}
							break;
						case 2:
							if (!HWyRNCfIgGPf7wiRfSQQ(runtimeTypeDescriptor))
							{
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 3;
						case 1:
							_typeDescriptorsByUid[new KeyValuePair<Guid, Guid>(current.Uid, V1eTRcfIrjB2cEg6tX3T(current))] = current;
							num3 = 5;
							continue;
						case 5:
							runtimeTypeDescriptor = current as IRuntimeTypeDescriptor;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
							{
								num3 = 7;
							}
							continue;
						case 3:
							_typeDescriptorsByType[Pf8Sh1fI5BP0p1jcSQ36(runtimeTypeDescriptor)] = current;
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
							{
								num3 = 6;
							}
							continue;
						case 4:
						case 6:
							break;
						default:
							goto IL_0161;
						case 8:
							return;
						}
						break;
					}
					continue;
					IL_0161:
					current = enumerator.Current;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num3 = 1;
					}
					goto IL_004c;
				}
			}
			finally
			{
				int num4;
				if (enumerator == null)
				{
					num4 = 2;
					goto IL_019e;
				}
				goto IL_01d3;
				IL_019e:
				switch (num4)
				{
				case 2:
					goto end_IL_0189;
				case 1:
					goto end_IL_0189;
				}
				goto IL_01d3;
				IL_01d3:
				jiT7HPfIYnjd6EPZFtlO(enumerator);
				num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num4 = 1;
				}
				goto IL_019e;
				end_IL_0189:;
			}
		}
	}

	private void ProcessMetadataType(IMetadataTypeInfo metadataTypeInfo)
	{
		//Discarded unreachable code: IL_0087
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!metadataTypeInfos.ContainsKey(IEArn5fILsDqHjI7jKyd(metadataTypeInfo)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 4:
					return;
				case 3:
					return;
				case 2:
					zlQdvVfIp7ibX2GwtyJ4(metadataTypeInfo, J8l8YHfIesBlDmt2hcCJ(-138018305 ^ -138198667));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			metadataTypeInfos.Add(IEArn5fILsDqHjI7jKyd(metadataTypeInfo), metadataTypeInfo);
			num = 4;
		}
	}

	private IMetadataTypeInfo GetMetadataTypeInfo(Type metadataType)
	{
		int num = 2;
		int num2 = num;
		IMetadataTypeInfo value = default(IMetadataTypeInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				metadataTypeInfos.TryGetValue(metadataType, out value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return value;
			case 2:
				zlQdvVfIp7ibX2GwtyJ4(metadataType, J8l8YHfIesBlDmt2hcCJ(0x7247028A ^ 0x72424224));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private Exception ProjectNotFound(string projectName)
	{
		return new Exception(SR.T((string)J8l8YHfIesBlDmt2hcCJ(--1360331293 ^ 0x511042D7), projectName));
	}

	private IMetadata GetMetadata(string projectName, Guid metadataUid, bool failIfNotExists)
	{
		//Discarded unreachable code: IL_00d2, IL_00e1, IL_00ec, IL_0158, IL_0167, IL_0185, IL_0194, IL_01dc, IL_021c, IL_022b, IL_0237, IL_024f, IL_025e
		int num = 1;
		IMetadata value = default(IMetadata);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current = default(string);
		IMetadata result = default(IMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					if (!metadataByProjects.TryGetValue(projectName, out var value2))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num2 = 0;
						}
						continue;
					}
					if (!value2.TryGetValue(metadataUid, out value))
					{
						num2 = 4;
						continue;
					}
					goto case 6;
				}
				case 6:
					return value;
				case 4:
					goto end_IL_0012;
				default:
					if (failIfNotExists)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					return null;
				case 2:
					throw ProjectNotFound(projectName);
				case 3:
					try
					{
						while (true)
						{
							IL_012d:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
								{
									num3 = 0;
								}
								goto IL_00f0;
							}
							goto IL_011a;
							IL_011a:
							current = enumerator.Current;
							num3 = 6;
							goto IL_00f0;
							IL_00f0:
							while (true)
							{
								switch (num3)
								{
								case 3:
									break;
								case 1:
								case 5:
									goto IL_012d;
								default:
									result = value;
									num3 = 7;
									continue;
								case 4:
									if (value == null)
									{
										num3 = 5;
										continue;
									}
									goto default;
								case 6:
									value = GetMetadata(current, metadataUid, failIfNotExists: false);
									num3 = 4;
									continue;
								case 2:
									goto end_IL_012d;
								case 7:
									return result;
								}
								break;
							}
							goto IL_011a;
							continue;
							end_IL_012d:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 2;
							goto IL_01e0;
						}
						goto IL_01f6;
						IL_01e0:
						switch (num4)
						{
						default:
							goto end_IL_01cb;
						case 1:
							break;
						case 2:
							goto end_IL_01cb;
						case 0:
							goto end_IL_01cb;
						}
						goto IL_01f6;
						IL_01f6:
						jiT7HPfIYnjd6EPZFtlO(enumerator);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num4 = 0;
						}
						goto IL_01e0;
						end_IL_01cb:;
					}
					break;
				case 5:
					break;
				}
				return null;
				continue;
				end_IL_0012:
				break;
			}
			enumerator = projectReferences[projectName].GetEnumerator();
			num = 3;
		}
	}

	private string GetCurrentProject()
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (string.IsNullOrEmpty(CurrentProjectName))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return (string)hCovyYfIU237VY8sOQDN(this);
			case 1:
				throw new Exception((string)GhngnRfIs7MM2nkBLkod(J8l8YHfIesBlDmt2hcCJ(-978351861 ^ -978662927)));
			}
		}
	}

	protected AbstractMetadataEditorComponent()
	{
		//Discarded unreachable code: IL_009a, IL_009f
		FFZOBafIcLXR7LWYvlPf();
		metadataTypeInfos = new Dictionary<Type, IMetadataTypeInfo>();
		lastMetadataUpdate = jDaBuXfI3juKoxn0jicw();
		processedAssemblyNames = new HashSet<string>();
		projectReferences = new Dictionary<string, ISet<string>>();
		metadataByProjects = new Dictionary<string, IDictionary<Guid, IMetadata>>();
		_typeDescriptorsByUid = new Dictionary<KeyValuePair<Guid, Guid>, ITypeDescriptor>();
		_typeDescriptorsByType = new Dictionary<Type, ITypeDescriptor>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void cBSlISfIn169p0eSnQLa(object P_0)
	{
		((AbstractMetadataEditorComponent)P_0).OnInit();
	}

	internal static void TBjAHJfIOLMfaywRR7cl(object P_0)
	{
		((AbstractMetadataEditorComponent)P_0).OnInitComplete();
	}

	internal static object gkSw6ffI2CTeP9V02INX(object P_0, object P_1, Guid metadataUid)
	{
		return ((AbstractMetadataEditorComponent)P_0).GetMetadata((string)P_1, metadataUid);
	}

	internal static object J8l8YHfIesBlDmt2hcCJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool iwGRixfIPO6XxlVQeRpd(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static bool v400lUfITMkYH4fHgtWX()
	{
		return GGmLhxfIXZPxMDyk1G02 == null;
	}

	internal static AbstractMetadataEditorComponent aQyTjufIkvd8T2eAgq2T()
	{
		return GGmLhxfIXZPxMDyk1G02;
	}

	internal static bool KKbUJXfI16c7q0SJChIl(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool NJaUx7fIN20UqbclyXD9(object P_0)
	{
		return ((ITypeDescriptor)P_0).UseForId;
	}

	internal static DateTime jDaBuXfI3juKoxn0jicw()
	{
		return DateTime.Now;
	}

	internal static void zlQdvVfIp7ibX2GwtyJ4(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object r1nf9MfIaRj0o0ChTNVX(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void jshARyfIDrblKtm4Z11d(object P_0, object P_1)
	{
		((ICodeGenerator)P_0).Metadata = (IMetadata)P_1;
	}

	internal static Type cGUtZUfIt1cNiinZpVZY(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool IwHVTxfIw7PjXaFKuwNj(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object lYULLCfI4qH4aZu2Gko4()
	{
		return ComponentManager.Current;
	}

	internal static void qega7ifI6Yw7adLwqR8b(object P_0)
	{
		((ICollection<KeyValuePair<string, ISet<string>>>)P_0).Clear();
	}

	internal static object pvbh22fIH7k3Gmw3VQ5w(object P_0)
	{
		return ComponentManager.GetAssemblyShortName((Assembly)P_0);
	}

	internal static object c1YO8UfIADAxFM4naM02(object P_0)
	{
		return ((ReflectionTypeLoadException)P_0).LoaderExceptions;
	}

	internal static object SVEoIPfI7XxMxaYvHN1c(object P_0, object P_1)
	{
		return string.Join((string)P_0, (string[])P_1);
	}

	internal static object TfNsSJfIxpah9yJXNSsu()
	{
		return Logger.Log;
	}

	internal static object XhYmMWfI0jnRmHBuw1i5(object P_0)
	{
		return ((Assembly)P_0).FullName;
	}

	internal static object RsDDUXfImBFwXlMoIEgj(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void h7TnDxfIyHjfFG2k1eGB(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void swe4MOfIM636DklPk2D7(object P_0, object P_1)
	{
		((AbstractMetadataEditorComponent)P_0).AddProject((string)P_1);
	}

	internal static Guid Je6HHRfIJMfh59XuamB5(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static void fymFs5fI9wd3vlp1pjXp(object P_0, object P_1, object P_2)
	{
		((AbstractMetadataEditorComponent)P_0).AddOrReplaceMetadata((string)P_1, (IMetadata)P_2);
	}

	internal static bool JXG5fBfIdoBl6OAo31Ak(object P_0, object P_1)
	{
		return ((AbstractMetadataEditorComponent)P_0).ProjectExists((string)P_1);
	}

	internal static void d2FDqufIlXIqwB0ylg62(object P_0, object P_1)
	{
		((AbstractMetadataEditorComponent)P_0).RemoveProject((string)P_1);
	}

	internal static Guid V1eTRcfIrjB2cEg6tX3T(object P_0)
	{
		return ((ITypeDescriptor)P_0).SubTypeUid;
	}

	internal static bool HWyRNCfIgGPf7wiRfSQQ(object P_0)
	{
		return ((IRuntimeTypeDescriptor)P_0).IsRuntimeType;
	}

	internal static Type Pf8Sh1fI5BP0p1jcSQ36(object P_0)
	{
		return ((IRuntimeTypeDescriptor)P_0).RuntimeType;
	}

	internal static bool TtGXCtfIjnyl7X6GOPGT(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void jiT7HPfIYnjd6EPZFtlO(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Type IEArn5fILsDqHjI7jKyd(object P_0)
	{
		return ((IMetadataTypeInfo)P_0).MetadataType;
	}

	internal static object hCovyYfIU237VY8sOQDN(object P_0)
	{
		return ((AbstractMetadataEditorComponent)P_0).CurrentProjectName;
	}

	internal static object GhngnRfIs7MM2nkBLkod(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void FFZOBafIcLXR7LWYvlPf()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
