using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration.PublicApi;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Cache;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Mono.Cecil;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class DynamicModelAssemblyBuilder
{
	private class MetadataInfo
	{
		internal static object M1cShAvixQQruoS77xoJ;

		public EntityMetadata Metadata
		{
			[CompilerGenerated]
			get
			{
				return _003CMetadata_003Ek__BackingField;
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
						_003CMetadata_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Type Type
		{
			[CompilerGenerated]
			get
			{
				return _003CType_003Ek__BackingField;
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
						_003CType_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public MetadataInfo()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool Ql6xCUvi0eXre4eOkbtc()
		{
			return M1cShAvixQQruoS77xoJ == null;
		}

		internal static MetadataInfo o6Tm0HvimMMPJOjFAdRZ()
		{
			return (MetadataInfo)M1cShAvixQQruoS77xoJ;
		}
	}

	private static ILogger publishLogger;

	private string assemblyName;

	private readonly IEnumerable<IPublicApiNodeProvider> publicApiNodeProviders;

	private List<Assembly> requiredAssemblies;

	private Dictionary<string, string> sourceAssemblyHashes;

	private Dictionary<Guid, AbstractMetadata> metadataDict;

	private IEnumerable<IMetadata> configurationMetadataList;

	private List<EntityMetadata> intfMetadataList;

	private Dictionary<Guid, List<EntityMetadata>> intfExtMetadataByBaseUid;

	private List<Type> autoImplementAllTypes;

	private List<Type> autoImplementInterfaces;

	private Dictionary<Type, List<Type>> autoImplementExtensions;

	private List<EntityMetadata> metadataList;

	private byte[] documentationRaw;

	private MemoryStream documentationRawStream;

	private bool initialized;

	private bool metadataBuilt;

	private byte[] previousAssemblyRaw;

	private MemoryStream previousAssemblyRawStream;

	private bool buildDeltaAssembly;

	private Dictionary<string, string> previousHashCodes;

	private static readonly ContextVars.Local<ISet<Guid>> configurationModelUids;

	internal static DynamicModelAssemblyBuilder egNBONhaE4FMnt2XTXQI;

	internal static ISet<Guid> ConfigurationModelUids => configurationModelUids.Value;

	public byte[] DocumentationRaw
	{
		get
		{
			int num = 2;
			int num2 = num;
			byte[] array2;
			byte[] array = default(byte[]);
			while (true)
			{
				switch (num2)
				{
				case 2:
					array2 = documentationRaw;
					if (array2 == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					array = (documentationRaw = documentationRawStream?.ToArray());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					array2 = array;
					break;
				}
				break;
			}
			return array2;
		}
	}

	public MemoryStream DocumentationRawStream
	{
		get
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
				{
					MemoryStream memoryStream = documentationRawStream;
					if (memoryStream == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 1;
						}
						break;
					}
					s0oFVHhaI4AlnDLMiMwS(memoryStream, 0L, SeekOrigin.Begin);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					break;
				}
				default:
					return documentationRawStream;
				}
			}
		}
	}

	public byte[] PreviousAssemblyRaw
	{
		get
		{
			int num = 2;
			int num2 = num;
			byte[] array2;
			byte[] array = default(byte[]);
			while (true)
			{
				switch (num2)
				{
				case 2:
					array2 = previousAssemblyRaw;
					if (array2 == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
				{
					MemoryStream memoryStream = previousAssemblyRawStream;
					array = (previousAssemblyRaw = (byte[])((memoryStream != null) ? MRQ3tIha3evmYqDcLxFf(memoryStream) : null));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					continue;
				}
				default:
					array2 = array;
					break;
				}
				break;
			}
			return array2;
		}
		set
		{
			//Discarded unreachable code: IL_0091, IL_00a0
			int num = 5;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 6:
					case 8:
						if (value == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 3;
					case 2:
						return;
					default:
						yjdNNShaDeNs8F17g3hn(previousAssemblyRawStream, value, 0, value.Length);
						num2 = 7;
						continue;
					case 5:
						previousAssemblyRaw = value;
						num2 = 4;
						continue;
					case 7:
						return;
					case 1:
						previousAssemblyRawStream = null;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 2;
						}
						continue;
					case 3:
						previousAssemblyRawStream = (MemoryStream)xr9tZuhaaEkNTA4r1x00(value.Length);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num2 = 0;
						}
						continue;
					case 4:
					{
						MemoryStream memoryStream = previousAssemblyRawStream;
						if (memoryStream == null)
						{
							num2 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
							{
								num2 = 0;
							}
							continue;
						}
						wMvFPghapbPn7FVsP1L0(memoryStream);
						num = 8;
						break;
					}
					}
					break;
				}
			}
		}
	}

	public MemoryStream PreviousAssemblyRawStream
	{
		get
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return previousAssemblyRawStream;
				case 2:
				{
					MemoryStream memoryStream = previousAssemblyRawStream;
					if (memoryStream == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 1;
						}
						break;
					}
					memoryStream.Seek(0L, SeekOrigin.Begin);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
				}
			}
		}
		set
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					previousAssemblyRawStream = value;
					num2 = 4;
					break;
				case 4:
					return;
				case 3:
					previousAssemblyRaw = null;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
				{
					MemoryStream memoryStream = previousAssemblyRawStream;
					if (memoryStream == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 0;
						}
						break;
					}
					wMvFPghapbPn7FVsP1L0(memoryStream);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 1;
					}
					break;
				}
				}
			}
		}
	}

	public static IEnumerable<Type> GetEntityInterfaceTypes()
	{
		return ComponentManager.Current.GetExtensionPointTypes(TypeOf<IEntity>.Raw).Where(delegate(Type t)
		{
			//Discarded unreachable code: IL_003d, IL_00c3, IL_00d2
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return !_003C_003Ec.t4rHjuvirxr85RhlQnJI(_003C_003Ec.Y6PPjAvilqlfEMV7QsEC(AttributeHelper<MetadataTypeAttribute>.GetAttribute(t, inherited: false)), TypeOf<PartialMetadataTypeAttribute>.Raw, false);
				case 3:
				case 5:
					return false;
				case 2:
					if (t.IsInterface)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 1:
					if (_003C_003Ec.DaTV0nvidKYIN8PJq68i(t, TypeOf<IEntity>.Raw))
					{
						num2 = 4;
						break;
					}
					goto case 3;
				case 6:
					if (!t.IsDefined(TypeOf<MetadataTypeAttribute>.Raw, inherit: false))
					{
						num2 = 5;
						break;
					}
					goto default;
				case 4:
					if (t.ContainsGenericParameters)
					{
						num2 = 3;
						break;
					}
					goto case 6;
				}
			}
		});
	}

	public static IEnumerable<Type> GetAutoImplementTypes()
	{
		return ComponentManager.Current.GetExtensionPointTypes(TypeOf<IAutoImplement>.Raw).Where(delegate(Type t)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return !t.ContainsGenericParameters;
				default:
					if (_003C_003Ec.DaTV0nvidKYIN8PJq68i(t, TypeOf<IAutoImplement>.Raw))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto IL_0032;
				case 1:
					{
						if (t.IsInterface)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_0032;
					}
					IL_0032:
					return false;
				}
			}
		});
	}

	internal static MemoryStream GetDocumentation(MemoryStream documentationTemplateRaw)
	{
		//Discarded unreachable code: IL_00da, IL_0112, IL_014a, IL_0159
		int num = 2;
		int num2 = num;
		string text = default(string);
		StreamWriter streamWriter = default(StreamWriter);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 2:
				text = SR.PreparedTranslate((string)vE9FRkhavkKPH7kdCuwi(documentationTemplateRaw, q3IiYOhaCAIAMKgUtNvQ()));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				streamWriter = new StreamWriter((Stream)gQretDha8nfaTB4cSgVU(memoryStream), (Encoding)q3IiYOhaCAIAMKgUtNvQ());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				s0oFVHhaI4AlnDLMiMwS(memoryStream, 0L, SeekOrigin.Begin);
				num2 = 3;
				break;
			case 1:
				memoryStream = MemoryHelper.GetMemoryStream();
				num2 = 5;
				break;
			case 3:
				return memoryStream;
			default:
				try
				{
					Cofr9ThaZLXMnPpmEowT(streamWriter, text);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				finally
				{
					if (streamWriter != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								LgX8AJhaurSqYuJhBjZf(streamWriter);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
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
				goto case 4;
			}
		}
	}

	internal static void SaveDocumentation(MemoryStream documentationTemplateRaw, string baseDirectoryName)
	{
		//Discarded unreachable code: IL_0070, IL_007f, IL_0252, IL_0265
		int num = 1;
		int num2 = num;
		string text = default(string);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		List<CultureInfo>.Enumerator enumerator = default(List<CultureInfo>.Enumerator);
		string text3 = default(string);
		CultureInfo current = default(CultureInfo);
		string text2 = default(string);
		int setting = default(int);
		string item = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				text = (string)LfsVCShaV3V4nLuhwhHM(SR.KeyCultureInfo);
				num2 = 4;
				break;
			case 4:
				_003C_003Ec__DisplayClass3_.documentationTemplate = (string)vE9FRkhavkKPH7kdCuwi(documentationTemplateRaw, q3IiYOhaCAIAMKgUtNvQ());
				num2 = 6;
				break;
			case 2:
				try
				{
					while (true)
					{
						IL_011e:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_008e;
						}
						goto IL_00c4;
						IL_008e:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							case 9:
								if (!IkhYyVhaRudvT5HiQkbE(text3))
								{
									int num4 = 2;
									num3 = num4;
									continue;
								}
								goto case 10;
							default:
								if (ACxYYZhaiS3DGZRSOTud(LfsVCShaV3V4nLuhwhHM(current), text))
								{
									num3 = 8;
									continue;
								}
								goto case 10;
							case 4:
								goto IL_011e;
							case 7:
								text3 = baseDirectoryName;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
								{
									num3 = 0;
								}
								continue;
							case 6:
								MemoryHelper.ActionWithMemoryBuffer<byte, (string, int, string)>(wi1pXEhaKDNWChfV8qyu(q3IiYOhaCAIAMKgUtNvQ(), text2), (text2, setting, item), SaveDocumentationAction);
								num3 = 4;
								continue;
							case 2:
								Directory.CreateDirectory(text3);
								num3 = 10;
								continue;
							case 8:
								text3 = Path.Combine(baseDirectoryName, (string)LfsVCShaV3V4nLuhwhHM(current));
								num3 = 9;
								continue;
							case 10:
								item = (string)arIUWLhaqnbnn5fnrUIm(text3, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6C6EE9));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								text2 = SR.RunWithCulture(current, (Func<string>)_003C_003Ec__DisplayClass3_._003CSaveDocumentation_003Eb__0);
								num3 = 6;
								continue;
							case 3:
								return;
							}
							break;
						}
						goto IL_00c4;
						IL_00c4:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num3 = 7;
						}
						goto IL_008e;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			case 5:
				return;
			case 1:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				enumerator = SR.GetCultureNames().GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				setting = SR.GetSetting((string)l4D9FhhaS8J19aT9wPkH(-281842504 ^ -282049338), 30);
				num2 = 3;
				break;
			}
		}
	}

	public DynamicModelAssemblyBuilder(string assemblyName)
	{
		//Discarded unreachable code: IL_0035, IL_003a
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(assemblyName, ((ComponentManager)XNSp4ahaXprqPnEwCUlu()).GetExtensionPoints<IPublicApiNodeProvider>());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public DynamicModelAssemblyBuilder(string assemblyName, IEnumerable<IPublicApiNodeProvider> publicApiNodeProviders)
	{
		SingletonReader.JJCZtPuTvSt();
		requiredAssemblies = new List<Assembly>();
		sourceAssemblyHashes = new Dictionary<string, string>();
		metadataDict = new Dictionary<Guid, AbstractMetadata>();
		autoImplementAllTypes = new List<Type>();
		metadataList = new List<EntityMetadata>();
		base._002Ector();
		Contract.ArgumentNotNullOrEmpty(assemblyName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583555768));
		Contract.ArgumentNotNull(publicApiNodeProviders, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA5A469D));
		this.assemblyName = assemblyName;
		this.publicApiNodeProviders = publicApiNodeProviders;
	}

	public void RegisterType(Type type)
	{
		//Discarded unreachable code: IL_00e2, IL_00f1, IL_0144, IL_02a9, IL_02b8, IL_0300, IL_030f, IL_031e, IL_032e
		int num = 4;
		AbstractMetadata abstractMetadata = default(AbstractMetadata);
		string value = default(string);
		Assembly assembly2 = default(Assembly);
		EntityMetadata entityMetadata = default(EntityMetadata);
		string value2 = default(string);
		Assembly assembly = default(Assembly);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 20:
					if (autoImplementAllTypes.Contains(type))
					{
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 2;
						}
					}
					else
					{
						autoImplementAllTypes.Add(type);
						num2 = 13;
					}
					continue;
				case 10:
				case 11:
				case 18:
					metadataDict[abstractMetadata.Uid] = abstractMetadata;
					num2 = 17;
					continue;
				case 15:
					value = (string)mJj07yhaOXgr1nA6qOUx(assembly2);
					num2 = 19;
					continue;
				case 4:
					CheckNotInitialized((string)l4D9FhhaS8J19aT9wPkH(0x5A4C7B29 ^ 0x5A4F1625));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 3;
					}
					continue;
				case 28:
					if (odC5JVhakUdJCuNO7489(entityMetadata) != Guid.Empty)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 14;
				case 8:
					value2 = AssemblyInfoCache.EvaluateHashCode(assembly);
					num2 = 7;
					continue;
				case 16:
					return;
				case 23:
					if (abstractMetadata is EnumMetadata)
					{
						num2 = 11;
						continue;
					}
					goto case 21;
				case 2:
					return;
				case 9:
					if (TypeOf<IAutoImplement>.Raw.IsAssignableFrom(type))
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 20;
						}
						continue;
					}
					abstractMetadata = MetadataLoader.LoadMetadata(type, inherit: false, loadImplementation: false) as AbstractMetadata;
					num = 26;
					break;
				case 22:
					return;
				case 25:
					return;
				case 29:
					return;
				case 6:
					requiredAssemblies.Add(assembly2);
					num2 = 15;
					continue;
				case 12:
					requiredAssemblies.Add(assembly);
					num2 = 8;
					continue;
				case 7:
					sourceAssemblyHashes.Add(ComponentManager.GetAssemblyShortName(assembly), value2);
					num2 = 5;
					continue;
				case 5:
					return;
				case 14:
					if (iHYrKBhan5LfQDiJL97X(entityMetadata) != EntityMetadataType.Interface)
					{
						return;
					}
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					continue;
				case 21:
					if ((entityMetadata = abstractMetadata as EntityMetadata) == null)
					{
						num2 = 22;
						continue;
					}
					goto case 1;
				case 3:
					if (SuRoGJhaTZfggrnIdNDk(type, null))
					{
						return;
					}
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 7;
					}
					continue;
				case 19:
					sourceAssemblyHashes.Add((string)CVd0kOha2himyiiqiqGE(assembly2), value);
					num = 29;
					break;
				case 13:
					assembly = type.Assembly;
					num = 27;
					break;
				case 24:
					return;
				default:
					if (requiredAssemblies.Contains(assembly2))
					{
						num2 = 25;
						continue;
					}
					goto case 6;
				case 26:
					if (abstractMetadata == null)
					{
						return;
					}
					num2 = 23;
					continue;
				case 17:
					assembly2 = type.Assembly;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					continue;
				case 27:
					if (requiredAssemblies.Contains(assembly))
					{
						return;
					}
					num2 = 12;
					continue;
				case 1:
					if (entityMetadata.Type == EntityMetadataType.InterfaceExtension)
					{
						num2 = 28;
						continue;
					}
					goto case 14;
				}
				break;
			}
		}
	}

	public void RegisterTypes(IEnumerable<Type> types)
	{
		CheckNotInitialized(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108055242));
		if (types == null)
		{
			return;
		}
		foreach (Type type in types)
		{
			RegisterType(type);
		}
	}

	public void RegisterMetadata(IMetadata metadata)
	{
		//Discarded unreachable code: IL_00ee, IL_00fd
		int num = 2;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (!keBv8nhae82wXipOxyuL(odC5JVhakUdJCuNO7489(entityMetadata), Guid.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 7:
				if (iHYrKBhan5LfQDiJL97X(entityMetadata) == EntityMetadataType.InterfaceExtension)
				{
					num2 = 4;
					break;
				}
				goto default;
			case 1:
				if (metadata is EnumMetadata)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 5;
			default:
				if (iHYrKBhan5LfQDiJL97X(entityMetadata) == EntityMetadataType.Interface)
				{
					num2 = 3;
					break;
				}
				return;
			case 6:
				return;
			case 9:
				return;
			case 3:
			case 8:
				metadataDict[ShNQRehaPIGFxkbFBMbg(metadata)] = (AbstractMetadata)metadata;
				num2 = 9;
				break;
			case 2:
				CheckNotInitialized((string)l4D9FhhaS8J19aT9wPkH(--1333735954 ^ 0x4F7C5F54));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if ((entityMetadata = metadata as EntityMetadata) == null)
				{
					num2 = 6;
					break;
				}
				goto case 7;
			}
		}
	}

	public void RegisterMetadataList(IEnumerable<IMetadata> metadataList)
	{
		CheckNotInitialized(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234114438));
		if (metadataList == null)
		{
			return;
		}
		foreach (IMetadata metadata in metadataList)
		{
			RegisterMetadata(metadata);
		}
	}

	public void RegisterConfigurationMetadataList(IEnumerable<IMetadata> metadataList)
	{
		configurationMetadataList = metadataList;
	}

	public void RegisterDependentAssembly(string assemblyName, byte[] asmRaw)
	{
		//Discarded unreachable code: IL_004d, IL_0085, IL_00bd, IL_00cc
		int num = 2;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					RegisterDependentAssembly(assemblyName, memoryStream);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
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
					if (memoryStream != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								LgX8AJhaurSqYuJhBjZf(memoryStream);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
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
				memoryStream = (MemoryStream)Hb4OCIha1RJm3y1XHHaM(asmRaw, false);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void RegisterDependentAssembly(string assemblyName, MemoryStream asmRaw)
	{
		int num = 2;
		int num2 = num;
		string value = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 4:
				sourceAssemblyHashes[assemblyName] = value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				CheckNotInitialized((string)l4D9FhhaS8J19aT9wPkH(-281842504 ^ -282066642));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (assemblyName == null)
				{
					return;
				}
				num2 = 3;
				break;
			case 3:
				value = (string)sGl6QMhaN7bEblXDM0sj(asmRaw);
				num2 = 4;
				break;
			}
		}
	}

	public ICollection<EntityMetadata> GetImplementationMetadataList()
	{
		BuildMetadata();
		return metadataList;
	}

	public byte[] BuildAssembly(Action<ModelAssemblyBuilder> builderActions)
	{
		return BuildAssemblyToStream(builderActions)?.ToArray();
	}

	public MemoryStream BuildAssemblyToStream(Action<ModelAssemblyBuilder> builderActions)
	{
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
		_003C_003Ec__DisplayClass17_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass17_.builderActions = builderActions;
		_003C_003Ec__DisplayClass17_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_1();
		CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass17_;
		CS_0024_003C_003E8__locals0.builder = new ModelAssemblyBuilder(assemblyName);
		try
		{
			if (buildDeltaAssembly)
			{
				publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105272786));
			}
			else
			{
				publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53FC2A5));
			}
			BuildMetadata();
			documentationRaw = null;
			documentationRawStream = null;
			SR.RunWithFutureTranslate(delegate
			{
				//Discarded unreachable code: IL_00b8, IL_00e7, IL_0148, IL_0157, IL_0162, IL_020d, IL_0220, IL_022f, IL_027b, IL_0331, IL_0340, IL_035a, IL_0449, IL_0481, IL_0494, IL_04a3
				switch (1)
				{
				case 1:
					try
					{
						configurationModelUids.Value = (from m in (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.configurationMetadataList ?? Enumerable.Empty<IMetadata>()).SelectRecursive((IMetadata m) => (!(m is ICompositeMetadata compositeMetadata)) ? Enumerable.Empty<IMetadata>() : compositeMetadata.GetCompositeParts())
							select _003C_003Ec.O6DM5SvigvhrihpJ4YQP(m)).ToHashSet();
						int num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num = 0;
						}
						List<EntityMetadata>.Enumerator enumerator2 = default(List<EntityMetadata>.Enumerator);
						EntityMetadata current2 = default(EntityMetadata);
						List<Type>.Enumerator enumerator = default(List<Type>.Enumerator);
						Type current = default(Type);
						List<Type> value = default(List<Type>);
						string text = default(string);
						ClassGeneratorAttribute attribute = default(ClassGeneratorAttribute);
						while (true)
						{
							switch (num)
							{
							case 5:
								CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.builderActions(CS_0024_003C_003E8__locals0.builder);
								num = 2;
								break;
							case 2:
							case 4:
								enumerator2 = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.metadataList.GetEnumerator();
								num = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
								{
									num = 0;
								}
								break;
							default:
								try
								{
									while (true)
									{
										IL_0193:
										int num5;
										if (!enumerator2.MoveNext())
										{
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
											{
												num5 = 0;
											}
											goto IL_0166;
										}
										goto IL_0180;
										IL_0180:
										current2 = enumerator2.Current;
										num5 = 3;
										goto IL_0166;
										IL_0166:
										while (true)
										{
											switch (num5)
											{
											case 2:
												goto IL_0180;
											case 1:
												goto IL_0193;
											case 3:
												CS_0024_003C_003E8__locals0.builder.AddMetadata(current2);
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
												{
													num5 = 1;
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
									((IDisposable)enumerator2).Dispose();
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
									{
										num6 = 0;
									}
									switch (num6)
									{
									case 0:
										break;
									}
								}
								goto case 3;
							case 1:
								if (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.builderActions == null)
								{
									num = 4;
									break;
								}
								goto case 5;
							case 3:
								enumerator = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.autoImplementInterfaces.GetEnumerator();
								num = 6;
								break;
							case 6:
								try
								{
									while (true)
									{
										int num2;
										if (!enumerator.MoveNext())
										{
											num2 = 4;
											goto IL_0285;
										}
										goto IL_0387;
										IL_035f:
										CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.autoImplementExtensions.TryGetValue(current, out value);
										num2 = 7;
										goto IL_0285;
										IL_0387:
										current = enumerator.Current;
										int num3 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
										{
											num3 = 1;
										}
										goto IL_0289;
										IL_0285:
										num3 = num2;
										goto IL_0289;
										IL_0289:
										while (true)
										{
											Type type;
											switch (num3)
											{
											case 9:
												_003C_003Ec__DisplayClass17_1.e709GpvRZnoQktftBOo4(CS_0024_003C_003E8__locals0.builder, text);
												num3 = 3;
												continue;
											case 6:
												if (!_003C_003Ec__DisplayClass17_1.abJSS9vRQ76vhoO6QucL(_003C_003Ec__DisplayClass17_1.XIXAvovRfk3t7KrKE8Xc(attribute), null))
												{
													num3 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
													{
														num3 = 0;
													}
													continue;
												}
												type = _003C_003Ec__DisplayClass17_1.XIXAvovRfk3t7KrKE8Xc(attribute);
												goto IL_03d2;
											case 7:
												attribute = AttributeHelper<ClassGeneratorAttribute>.GetAttribute(current, inherited: false);
												num3 = 5;
												continue;
											case 3:
												break;
											default:
												type = _003C_003Ec__DisplayClass17_1.ttZ6v4vRCHBkFT3aZevp(typeof(AutoClassGenerator).TypeHandle);
												goto IL_03d2;
											case 1:
												goto IL_035f;
											case 2:
												goto IL_0387;
											case 5:
												if (attribute == null)
												{
													num3 = 8;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
													{
														num3 = 8;
													}
													continue;
												}
												goto case 6;
											case 4:
												return;
												IL_03d2:
												text = ((IAutoClassGenerator)_003C_003Ec__DisplayClass17_1.PTEkJYvRvWadCRp0q52o(type)).GenerateCode(current, (Type[])((value != null) ? _003C_003Ec__DisplayClass17_1.Rjxbh7vR8qHidcMVvJpp(value) : new Type[0]));
												num3 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
												{
													num3 = 9;
												}
												continue;
											}
											break;
										}
									}
								}
								finally
								{
									((IDisposable)enumerator).Dispose();
									int num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
									{
										num4 = 0;
									}
									switch (num4)
									{
									case 0:
										break;
									}
								}
							}
						}
					}
					finally
					{
						configurationModelUids.Value = null;
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
				case 0:
					break;
				}
			});
			BuildPublicApi(CS_0024_003C_003E8__locals0.builder);
			CS_0024_003C_003E8__locals0.builder.AddSourceCode(sourceAssemblyHashes.If(!ReflectionType.DynamicPublicationEnable.Value, (IEnumerable<KeyValuePair<string, string>> _) => _.Append(new KeyValuePair<string, string>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD63F40), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740339762)))).Select(delegate(KeyValuePair<string, string> pair)
			{
				ISyntaxNode syntaxNode = TypeOf<DynamicAssemblySourceAttribute>.Raw.CreateAttribute(pair.Key.CreateSyntaxNode(), pair.Value.CreateSyntaxNode());
				syntaxNode.Unpack<AttributeSyntax>().AssemblySpecifier = true;
				return syntaxNode;
			}).GenerateCSCodeString());
			if (buildDeltaAssembly)
			{
				publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1766042850));
			}
			else
			{
				publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A30905E));
			}
			MemoryStream memoryStream = CS_0024_003C_003E8__locals0.builder.BuildToStream(pdb: false);
			if (memoryStream != null)
			{
				documentationRawStream = CS_0024_003C_003E8__locals0.builder.DocumentationRawStream;
			}
			if (buildDeltaAssembly)
			{
				publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561134604));
			}
			else
			{
				publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710629348));
			}
			return memoryStream;
		}
		finally
		{
			if (CS_0024_003C_003E8__locals0.builder != null)
			{
				((IDisposable)CS_0024_003C_003E8__locals0.builder).Dispose();
			}
		}
	}

	private void BuildPublicApi(ModelAssemblyBuilder builder)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				return;
			case 0:
				return;
			case 1:
				_003C_003Ec__DisplayClass18_._003C_003E4__this = this;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 5;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
				num2 = 2;
				break;
			case 5:
				if (publicApiNodeProviders.Any())
				{
					SR.RunWithFutureTranslate(_003C_003Ec__DisplayClass18_._003CBuildPublicApi_003Eb__0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 4;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass18_.builder = builder;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public bool HasChanges()
	{
		//Discarded unreachable code: IL_0051, IL_017d, IL_0187, IL_01c2, IL_0208, IL_0217, IL_024d, IL_02ed, IL_0300, IL_030f, IL_033c, IL_034b
		int num = 3;
		string value2 = default(string);
		Dictionary<string, string>.Enumerator enumerator = default(Dictionary<string, string>.Enumerator);
		KeyValuePair<string, string> current = default(KeyValuePair<string, string>);
		bool result = default(bool);
		string value = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					if (previousHashCodes == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 7;
				case 4:
				case 8:
					return true;
				case 3:
					Init();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					previousHashCodes.TryGetValue((string)l4D9FhhaS8J19aT9wPkH(--1333735954 ^ 0x4F7C5D02), out value2);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return ACxYYZhaiS3DGZRSOTud(value2, l4D9FhhaS8J19aT9wPkH(-289714582 ^ -289713040)) == ReflectionType.DynamicPublicationEnable.Value;
				case 5:
					if (PreviousAssemblyRaw.Length != 0)
					{
						LoadPreviousHashCodes();
						num2 = 10;
						break;
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 4;
					}
					break;
				case 2:
					if (PreviousAssemblyRaw == null)
					{
						num2 = 8;
						break;
					}
					goto case 5;
				case 7:
					if (previousHashCodes.Count == LmYERChatWF1tS31Anhn(sourceAssemblyHashes))
					{
						goto end_IL_0012;
					}
					num2 = 9;
					break;
				case 11:
					try
					{
						while (true)
						{
							IL_0222:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
								{
									num3 = 0;
								}
								goto IL_018b;
							}
							goto IL_029e;
							IL_029e:
							current = enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
							{
								num3 = 1;
							}
							goto IL_018b;
							IL_018b:
							while (true)
							{
								switch (num3)
								{
								case 7:
									return result;
								case 9:
									return result;
								case 1:
									if (previousHashCodes.TryGetValue(current.Key, out value))
									{
										num3 = 8;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
										{
											num3 = 8;
										}
										continue;
									}
									goto case 3;
								case 2:
									goto IL_0222;
								case 5:
									result = true;
									num3 = 9;
									continue;
								case 6:
								case 8:
									if (value != current.Value)
									{
										num3 = 5;
										continue;
									}
									goto IL_0222;
								case 3:
									result = true;
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
									{
										num3 = 7;
									}
									continue;
								case 4:
									goto IL_029e;
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
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 6;
				default:
					return true;
				}
				continue;
				end_IL_0012:
				break;
			}
			enumerator = sourceAssemblyHashes.GetEnumerator();
			num = 11;
		}
	}

	internal void BuildDeltaAssembly()
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
				buildDeltaAssembly = true;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void CheckNotInitialized(string method)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (initialized)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				throw new InvalidOperationException(string.Format((string)l4D9FhhaS8J19aT9wPkH(0x3CE17B75 ^ 0x3CE21433), method));
			}
		}
	}

	private void Init()
	{
		//Discarded unreachable code: IL_004e, IL_00a7, IL_0148, IL_0157, IL_0232, IL_0262, IL_0271, IL_027d, IL_034a, IL_0354, IL_0413, IL_04a6, IL_0533, IL_0546, IL_0555
		int num = 9;
		int num2 = num;
		IEnumerator<EntityMetadata> enumerator2 = default(IEnumerator<EntityMetadata>);
		EntityMetadata rootMetadata = default(EntityMetadata);
		List<EntityMetadata> value2 = default(List<EntityMetadata>);
		EntityMetadata current2 = default(EntityMetadata);
		List<Type>.Enumerator enumerator = default(List<Type>.Enumerator);
		Type current = default(Type);
		Type key = default(Type);
		List<Type> value = default(List<Type>);
		InterfaceExtensionAttribute attribute = default(InterfaceExtensionAttribute);
		while (true)
		{
			switch (num2)
			{
			case 6:
				try
				{
					while (true)
					{
						int num5;
						if (!prLwSbha4RMTXuZQR00F(enumerator2))
						{
							num5 = 2;
							goto IL_0060;
						}
						goto IL_0130;
						IL_0060:
						while (true)
						{
							switch (num5)
							{
							case 4:
								if (!intfExtMetadataByBaseUid.TryGetValue(rootMetadata.Uid, out value2))
								{
									num5 = 8;
									continue;
								}
								goto case 7;
							case 3:
							{
								intfExtMetadataByBaseUid.Add(v668wMhawoSEvLmmVSgU(rootMetadata), value2);
								int num6 = 7;
								num5 = num6;
								continue;
							}
							case 6:
								rootMetadata = GetRootMetadata(current2);
								num5 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
								{
									num5 = 0;
								}
								continue;
							case 5:
								goto IL_0130;
							case 11:
								if (iHYrKBhan5LfQDiJL97X(current2) == EntityMetadataType.Interface)
								{
									num5 = 12;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
									{
										num5 = 0;
									}
									continue;
								}
								break;
							case 10:
								if (rootMetadata == null)
								{
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
									{
										num5 = 1;
									}
									continue;
								}
								goto case 4;
							case 12:
								intfMetadataList.Add(current2);
								num5 = 13;
								continue;
							case 9:
								if (current2.Type == EntityMetadataType.InterfaceExtension)
								{
									num5 = 6;
									continue;
								}
								goto case 11;
							case 7:
								value2.Add(current2);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num5 = 0;
								}
								continue;
							case 8:
								value2 = new List<EntityMetadata>();
								num5 = 3;
								continue;
							case 2:
								goto end_IL_00b1;
							}
							break;
						}
						continue;
						IL_0130:
						current2 = enumerator2.Current;
						num5 = 9;
						goto IL_0060;
						continue;
						end_IL_00b1:
						break;
					}
				}
				finally
				{
					int num7;
					if (enumerator2 == null)
					{
						num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num7 = 1;
						}
						goto IL_0236;
					}
					goto IL_024c;
					IL_024c:
					LgX8AJhaurSqYuJhBjZf(enumerator2);
					num7 = 2;
					goto IL_0236;
					IL_0236:
					switch (num7)
					{
					case 1:
						goto end_IL_0211;
					case 2:
						goto end_IL_0211;
					}
					goto IL_024c;
					end_IL_0211:;
				}
				goto case 5;
			case 4:
				intfExtMetadataByBaseUid = new Dictionary<Guid, List<EntityMetadata>>();
				num2 = 3;
				continue;
			case 1:
				enumerator = autoImplementAllTypes.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				autoImplementInterfaces = new List<Type>();
				num2 = 7;
				continue;
			case 3:
				enumerator2 = metadataDict.Values.OfType<EntityMetadata>().GetEnumerator();
				num2 = 6;
				continue;
			case 9:
				if (initialized)
				{
					num2 = 8;
					continue;
				}
				intfMetadataList = new List<EntityMetadata>();
				num2 = 4;
				continue;
			case 7:
				autoImplementExtensions = new Dictionary<Type, List<Type>>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				break;
			default:
				try
				{
					while (true)
					{
						IL_043e:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
							{
								num3 = 8;
							}
							goto IL_0358;
						}
						goto IL_0396;
						IL_0396:
						current = enumerator.Current;
						num3 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num3 = 12;
						}
						goto IL_0358;
						IL_0358:
						while (true)
						{
							switch (num3)
							{
							case 4:
								break;
							case 6:
								autoImplementInterfaces.Add(current);
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
								{
									num3 = 0;
								}
								continue;
							case 9:
								if (autoImplementExtensions.TryGetValue(key, out value))
								{
									num3 = 9;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
									{
										num3 = 10;
									}
									continue;
								}
								goto case 3;
							case 3:
								value = new List<Type>();
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
								{
									num3 = 0;
								}
								continue;
							case 5:
							case 7:
								goto IL_043e;
							case 1:
								autoImplementExtensions.Add(key, value);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
								{
									num3 = 0;
								}
								continue;
							case 12:
								attribute = AttributeHelper<InterfaceExtensionAttribute>.GetAttribute(current, inherited: false);
								num3 = 11;
								continue;
							default:
								value.Add(current);
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
								{
									num3 = 7;
								}
								continue;
							case 2:
								key = AoSXarha6On05NFyMisn(attribute);
								num3 = 9;
								continue;
							case 11:
								if (attribute != null)
								{
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 6;
							case 8:
								goto end_IL_043e;
							}
							break;
						}
						goto IL_0396;
						continue;
						end_IL_043e:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				break;
			case 10:
				return;
			case 8:
				return;
			}
			initialized = true;
			num2 = 10;
		}
	}

	private void BuildMetadata()
	{
		//Discarded unreachable code: IL_005a, IL_0068, IL_015e, IL_0171, IL_0180, IL_0190, IL_019f
		int num = 3;
		int num2 = num;
		List<EntityMetadata>.Enumerator enumerator = default(List<EntityMetadata>.Enumerator);
		EntityMetadata current = default(EntityMetadata);
		List<EntityMetadata> value = default(List<EntityMetadata>);
		EntityMetadata item = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				return;
			case 7:
				enumerator = intfMetadataList.GetEnumerator();
				num2 = 4;
				continue;
			case 4:
				try
				{
					while (true)
					{
						IL_011c:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;
							goto IL_006c;
						}
						goto IL_0109;
						IL_006c:
						while (true)
						{
							switch (num3)
							{
							case 5:
								intfExtMetadataByBaseUid.TryGetValue(v668wMhawoSEvLmmVSgU(current), out value);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								item = current.CreateInterfaceImplementationMetadata(value);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
								{
									num3 = 2;
								}
								continue;
							case 2:
								metadataList.Add(item);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								break;
							default:
								goto IL_011c;
							case 4:
								goto end_IL_011c;
							}
							break;
						}
						goto IL_0109;
						IL_0109:
						current = enumerator.Current;
						num3 = 5;
						goto IL_006c;
						continue;
						end_IL_011c:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				break;
			case 3:
				if (!metadataBuilt)
				{
					num2 = 2;
					continue;
				}
				return;
			case 0:
				return;
			case 2:
				Init();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 6;
				}
				continue;
			case 6:
				HqfnTZhaHwTZMdld7p1W(metadataList);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 3;
				}
				continue;
			case 1:
				break;
			}
			metadataBuilt = true;
			num2 = 5;
		}
	}

	private EntityMetadata GetRootMetadata(EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_0064, IL_0073, IL_00ef, IL_00f9
		int num = 1;
		int num2 = num;
		AbstractMetadata value = default(AbstractMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 8:
				if (odC5JVhakUdJCuNO7489(metadata) == Guid.Empty)
				{
					num2 = 6;
					continue;
				}
				if (metadataDict.TryGetValue(odC5JVhakUdJCuNO7489(metadata), out value))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 3;
			default:
				return metadata;
			case 1:
				if (metadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 8;
			case 7:
				if (entityMetadata.Type == EntityMetadataType.Interface)
				{
					num2 = 4;
					continue;
				}
				goto IL_0117;
			case 3:
				obj = null;
				break;
			case 5:
				if (entityMetadata != null)
				{
					num2 = 7;
					continue;
				}
				goto IL_0117;
			case 4:
				return entityMetadata;
			case 2:
				{
					obj = value as EntityMetadata;
					break;
				}
				IL_0117:
				return GetRootMetadata(entityMetadata);
			}
			entityMetadata = (EntityMetadata)obj;
			num2 = 5;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
			{
				num2 = 4;
			}
		}
	}

	private void LoadPreviousHashCodes()
	{
		//Discarded unreachable code: IL_0085
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				return;
			case 1:
				if (PreviousAssemblyRawStream == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 4:
				break;
			case 0:
				return;
			case 2:
				return;
			}
			if (cbdYp3haATSAp2Vc3syw(PreviousAssemblyRawStream) == 0L)
			{
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 2;
				}
				continue;
			}
			previousHashCodes = ((IEnumerable<CustomAttribute>)((AssemblyDefinition)TP5cThha71gB6VayLtS4(PreviousAssemblyRawStream)).get_CustomAttributes()).Where((CustomAttribute a) => (string)_003C_003Ec.wy28UavijnddwxbePcDd(((MemberReference)_003C_003Ec.a8qWUVvi52VvhQkjmyDK(a)).get_DeclaringType()) == (string)_003C_003Ec.pNW1rDviY7FUbmjCZN8P()).ToDictionary(delegate(CustomAttribute a)
			{
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_003d: Unknown result type (might be due to invalid IL or missing references)
				int num5 = 1;
				int num6 = num5;
				CustomAttributeArgument val2 = default(CustomAttributeArgument);
				while (true)
				{
					switch (num6)
					{
					default:
						return (string)((CustomAttributeArgument)(ref val2)).get_Value();
					case 1:
						val2 = a.get_ConstructorArguments().get_Item(0);
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num6 = 0;
						}
						break;
					}
				}
			}, delegate(CustomAttribute a)
			{
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_003d: Unknown result type (might be due to invalid IL or missing references)
				int num3 = 1;
				int num4 = num3;
				CustomAttributeArgument val = default(CustomAttributeArgument);
				while (true)
				{
					switch (num4)
					{
					default:
						return (string)((CustomAttributeArgument)(ref val)).get_Value();
					case 1:
						val = a.get_ConstructorArguments().get_Item(1);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num4 = 0;
						}
						break;
					}
				}
			});
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
			{
				num2 = 2;
			}
		}
	}

	private static void SaveDocumentationAction(object buffer, int offset, int length, (string, int, string) param)
	{
		var (text, attemptCount, fileName) = param;
		Encoding.UTF8.GetBytes(text, 0, text.Length, (byte[])buffer, offset);
		IOExtensions.WriteAllBytesWithAttempts(fileName, (byte[])buffer, offset, length, TimeSpan.FromSeconds(1.0), attemptCount);
	}

	static DynamicModelAssemblyBuilder()
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
				aNQ4YghaxGw05BHxuLTg();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				configurationModelUids = new ContextVars.Local<ISet<Guid>>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 2;
				}
				break;
			default:
				publishLogger = Logger.GetLogger((string)l4D9FhhaS8J19aT9wPkH(0x68BBB53E ^ 0x68B8AAFE));
				num2 = 3;
				break;
			}
		}
	}

	internal static object q3IiYOhaCAIAMKgUtNvQ()
	{
		return Encoding.UTF8;
	}

	internal static object vE9FRkhavkKPH7kdCuwi(object P_0, object P_1)
	{
		return ((MemoryStream)P_0).AsString((Encoding)P_1);
	}

	internal static object gQretDha8nfaTB4cSgVU(object P_0)
	{
		return ((MemoryStream)P_0).AsNoClose();
	}

	internal static void Cofr9ThaZLXMnPpmEowT(object P_0, object P_1)
	{
		((TextWriter)P_0).Write((string)P_1);
	}

	internal static void LgX8AJhaurSqYuJhBjZf(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static long s0oFVHhaI4AlnDLMiMwS(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static bool MICNNvhafv7YPgmKE2C8()
	{
		return egNBONhaE4FMnt2XTXQI == null;
	}

	internal static DynamicModelAssemblyBuilder vm4JkVhaQECl2UUWB6Pk()
	{
		return egNBONhaE4FMnt2XTXQI;
	}

	internal static object LfsVCShaV3V4nLuhwhHM(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static object l4D9FhhaS8J19aT9wPkH(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool ACxYYZhaiS3DGZRSOTud(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static bool IkhYyVhaRudvT5HiQkbE(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object arIUWLhaqnbnn5fnrUIm(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static int wi1pXEhaKDNWChfV8qyu(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetByteCount((string)P_1);
	}

	internal static object XNSp4ahaXprqPnEwCUlu()
	{
		return ComponentManager.Current;
	}

	internal static bool SuRoGJhaTZfggrnIdNDk(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid odC5JVhakUdJCuNO7489(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static EntityMetadataType iHYrKBhan5LfQDiJL97X(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static object mJj07yhaOXgr1nA6qOUx(object P_0)
	{
		return AssemblyInfoCache.EvaluateHashCode((Assembly)P_0);
	}

	internal static object CVd0kOha2himyiiqiqGE(object P_0)
	{
		return ComponentManager.GetAssemblyShortName((Assembly)P_0);
	}

	internal static bool keBv8nhae82wXipOxyuL(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid ShNQRehaPIGFxkbFBMbg(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static object Hb4OCIha1RJm3y1XHHaM(object P_0, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, writable);
	}

	internal static object sGl6QMhaN7bEblXDM0sj(object P_0)
	{
		return AssemblyInfoCache.EvaluateHashCode((Stream)P_0);
	}

	internal static object MRQ3tIha3evmYqDcLxFf(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void wMvFPghapbPn7FVsP1L0(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	internal static object xr9tZuhaaEkNTA4r1x00(int requiredSize)
	{
		return MemoryHelper.GetMemoryStream(requiredSize);
	}

	internal static void yjdNNShaDeNs8F17g3hn(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static int LmYERChatWF1tS31Anhn(object P_0)
	{
		return ((Dictionary<string, string>)P_0).Count;
	}

	internal static Guid v668wMhawoSEvLmmVSgU(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool prLwSbha4RMTXuZQR00F(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static Type AoSXarha6On05NFyMisn(object P_0)
	{
		return ((InterfaceExtensionAttribute)P_0).ExtendedInterfaceType;
	}

	internal static void HqfnTZhaHwTZMdld7p1W(object P_0)
	{
		((List<EntityMetadata>)P_0).Clear();
	}

	internal static long cbdYp3haATSAp2Vc3syw(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object TP5cThha71gB6VayLtS4(object P_0)
	{
		return AssemblyDefinition.ReadAssembly((Stream)P_0);
	}

	internal static void aNQ4YghaxGw05BHxuLTg()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
