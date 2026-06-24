using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using Autofac.Builder;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Publication;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Hubs;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Licensing.Impl;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Cache;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Metadata;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Managers;

internal class ModelRegistrarImpl : LicensedUnitBase, IWorkplaceLicenseInfoOwner, ILicensedUnit, IActivationTokenContainer
{
	private class EntityTypesSet
	{
		internal static object UftMuuCgN2qaGcUZy4Mn;

		public Guid Uid
		{
			[CompilerGenerated]
			get
			{
				return _003CUid_003Ek__BackingField;
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
						_003CUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Type IntfType
		{
			[CompilerGenerated]
			get
			{
				return _003CIntfType_003Ek__BackingField;
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
						_003CIntfType_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
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

		public Type ImplType
		{
			[CompilerGenerated]
			get
			{
				return _003CImplType_003Ek__BackingField;
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
						_003CImplType_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
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

		public Type ExtType
		{
			[CompilerGenerated]
			get
			{
				return _003CExtType_003Ek__BackingField;
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
						_003CExtType_003Ek__BackingField = value;
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

		public EntityTypesSet(Guid uid)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			LbgOQmCgaZAgn1Agmxcw();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				Uid = uid;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num = 1;
				}
			}
		}

		internal static void LbgOQmCgaZAgn1Agmxcw()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool qcBCxvCg37H3pA38GLEs()
		{
			return UftMuuCgN2qaGcUZy4Mn == null;
		}

		internal static EntityTypesSet enMNlRCgp9MXEgeLT7Jf()
		{
			return (EntityTypesSet)UftMuuCgN2qaGcUZy4Mn;
		}
	}

	private class PublicationEventHandler : IPublicationEventHandler, IEventHandler
	{
		private readonly TaskCompletionSource<bool> waitPublication;

		internal static object k2eFTiCgD0WY5xi47bI6;

		public void Complete(Guid publicationToken)
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
					waitPublication.TrySetResult(result: true);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public void Error(Guid publicationToken, Exception exception)
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
					waitPublication.TrySetResult(result: false);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public void Wait()
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
					YaHr02Cg48WoDYLVYhNe(waitPublication.Task);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public PublicationEventHandler()
		{
			//Discarded unreachable code: IL_003c, IL_0041
			ILYbKhCg6CgxiE2ygmL5();
			waitPublication = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool xBq2x7Cgt6BSbPjf4rfC()
		{
			return k2eFTiCgD0WY5xi47bI6 == null;
		}

		internal static PublicationEventHandler CXTO1lCgwqF9XG7rGUQj()
		{
			return (PublicationEventHandler)k2eFTiCgD0WY5xi47bI6;
		}

		internal static void YaHr02Cg48WoDYLVYhNe(object P_0)
		{
			((Task)P_0).Wait();
		}

		internal static void ILYbKhCg6CgxiE2ygmL5()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private static ILogger publishLogger;

	public const string CompiledModelBaseDir = "CompiledModel";

	private static readonly Guid securityAssemblyUid;

	private readonly IDictionary<Guid, Type> _typesByUid;

	private readonly IDictionary<Guid, Type> _removedTypes;

	private readonly IDictionary<Guid, IMetadata> _metadataList;

	private readonly IDictionary<Guid, IMetadata> _metadataParents;

	private IEnumerable<AssemblyModelsMetadata> _previousAsmModelsMetadataList;

	private readonly IDictionary<string, AssemblyModelsMetadata> _asmModelsMetadataDict;

	private readonly ISet<Guid> configUids;

	private readonly List<Assembly> _modelAssemblies;

	private readonly Dictionary<(Guid, Guid), ITypeDescriptor> _typeDescriptorsByUid;

	private readonly Dictionary<Type, ITypeDescriptor> _typeDescriptorsByType;

	private readonly ISet<Type> registeredTypes;

	[ThreadStatic]
	private ISet<Guid> resolvingTypeUids;

	private Dictionary<EntityMetadata, int> metadataIndexTree;

	private SessionFactoryHolder sessionFactoryHolder;

	private bool initialized;

	private bool licensingInitialized;

	private string lastAppliedActKey;

	private string registrationKey;

	private ConcurrentLicenseInfo licenseInfo;

	private LicenseStatus initializedStatus;

	private static ModelRegistrarImpl AooqRUhEIeI5n6Mpant1;

	uint IWorkplaceLicenseInfoOwner.UsedLicenseCount => pG9VjJhEXu7I2ZLyhrZ3((IWorkplaceLicenseInfoOwner)LBmBFrhEKAAtgIukDOCQ((ILicensedModuleAssembly)fTxXPfhEqYpAM5v2up7W(X95t0nhERmiTkRBTIGSO(Sts3SxhEijg8pQXRUhEn()), securityAssemblyUid)));

	public bool ConfigurationScriptsRecompileRequired
	{
		[CompilerGenerated]
		get
		{
			return _003CConfigurationScriptsRecompileRequired_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CConfigurationScriptsRecompileRequired_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
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

	public string ConfigurationScriptsErrors
	{
		[CompilerGenerated]
		get
		{
			return _003CConfigurationScriptsErrors_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CConfigurationScriptsErrors_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private SessionFactoryHolder SessionFactoryHolder
	{
		get
		{
			int num = 1;
			int num2 = num;
			SessionFactoryHolder sessionFactoryHolder = default(SessionFactoryHolder);
			SessionFactoryHolder obj;
			while (true)
			{
				switch (num2)
				{
				default:
					sessionFactoryHolder = (this.sessionFactoryHolder = Locator.GetServiceNotNull<SessionFactoryHolder>());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					obj = this.sessionFactoryHolder;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = sessionFactoryHolder;
					break;
				}
				break;
			}
			return obj;
		}
	}

	Guid ILicensedUnit.RegistrationKeyMethodUid => new Guid((string)DXCyuKhE2myPrbWWHu8M(-1858887263 ^ -1858874475));

	public void Register(ModelRegistrar r, NHManagerRegisterParams parameters)
	{
		//Discarded unreachable code: IL_00b2, IL_0199, IL_0390, IL_041d, IL_042c, IL_043b, IL_04a5, IL_054a, IL_0559, IL_06d9, IL_06e8, IL_0827, IL_0867, IL_0876, IL_0882, IL_097c, IL_0a28, IL_0a60, IL_0a6f, IL_0abf, IL_0b04, IL_0b99, IL_0bc1, IL_0be0, IL_0bef, IL_0c1c, IL_0c47, IL_0ca9, IL_0ce1, IL_0d14, IL_0d80, IL_0d8f, IL_0d9b, IL_0e04, IL_0e3c, IL_0e74, IL_0ee0, IL_0eef, IL_0f11, IL_0f63, IL_0f72, IL_1180, IL_1233, IL_1263, IL_1272, IL_127e, IL_128d, IL_12c2, IL_12da, IL_12e4, IL_13d5, IL_1415, IL_1424, IL_1451, IL_1489, IL_16a6, IL_16e6, IL_16f5, IL_1701, IL_17b8, IL_17f0
		int num = 9;
		LicenseStatus status = default(LicenseStatus);
		DateTime? expirationDate = default(DateTime?);
		IDisposable disposable2 = default(IDisposable);
		DateTime dateTime2 = default(DateTime);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		IDisposable disposable = default(IDisposable);
		PublicationEventHandler publicationEventHandler = default(PublicationEventHandler);
		DateTime dateTime3 = default(DateTime);
		IStartInformation startInformation = default(IStartInformation);
		IEnumerator<AssemblyModelsMetadata> enumerator2 = default(IEnumerator<AssemblyModelsMetadata>);
		AssemblyModelsMetadata current3 = default(AssemblyModelsMetadata);
		List<MemoryStream> list2 = default(List<MemoryStream>);
		Assembly assembly2 = default(Assembly);
		string text = default(string);
		int setting = default(int);
		List<Assembly> list = default(List<Assembly>);
		DbPreUpdater dbPreUpdater = default(DbPreUpdater);
		IEnumerable<AssemblyModelsMetadata> enumerable = default(IEnumerable<AssemblyModelsMetadata>);
		IEnumerator<Type> enumerator = default(IEnumerator<Type>);
		Type current2 = default(Type);
		AssemblyModelsMetadata current = default(AssemblyModelsMetadata);
		Assembly assembly = default(Assembly);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 13:
				{
					DecodeActivationKey(lastAppliedActKey, out status, out var _, out var _, out var _, out var _, out expirationDate);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 14;
					}
					continue;
				}
				case 4:
					disposable2 = (IDisposable)da0jhhhEnHZHVHZn1IHW();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					throw new LicenseExpiredException(__ModuleInfo.UID);
				case 10:
					dateTime2 = HwZMFShEk8CeWGj8sZKH();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 4;
					}
					continue;
				case 14:
					if (status != 0)
					{
						num2 = 11;
						continue;
					}
					goto IL_1830;
				case 8:
					_003C_003Ec__DisplayClass6_._003C_003E4__this = this;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 12;
					}
					continue;
				case 1:
					if (!expirationDate.HasValue)
					{
						num2 = 10;
						continue;
					}
					break;
				case 12:
					_003C_003Ec__DisplayClass6_.parameters = parameters;
					num2 = 13;
					continue;
				case 9:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
					num2 = 8;
					continue;
				case 11:
					if (status != LicenseStatus.DateExpired)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto IL_1830;
				default:
					try
					{
						MetadataServiceContext metadataServiceContext = new MetadataServiceContext(r);
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								return;
							case 1:
								try
								{
									IRuntimeApplication serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
									int num4 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
									{
										num4 = 15;
									}
									while (true)
									{
										int num10;
										bool num19;
										switch (num4)
										{
										case 4:
											disposable = (IDisposable)E5fXP0hE4wBb7JxGRnsP(Locator.GetServiceNotNull<IEventHandlerSubscribeService>(), publicationEventHandler);
											num4 = 7;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
											{
												num4 = 12;
											}
											continue;
										case 20:
											V9eqT4hEaFyxG5KTYqNU(ylU8LMhENJ3no4g00OBs(), VprG0OhEpIdm4mYL18WY(DXCyuKhE2myPrbWWHu8M(-1886646897 ^ -1886444383), (int)hB6xcphE3RLmeOMZs7uV(HwZMFShEk8CeWGj8sZKH(), dateTime3).TotalMilliseconds, DXCyuKhE2myPrbWWHu8M(-1886646897 ^ -1886553677)));
											num4 = 22;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
											{
												num4 = 35;
											}
											continue;
										case 46:
											dateTime3 = HwZMFShEk8CeWGj8sZKH();
											num4 = 43;
											continue;
										case 1:
											publicationEventHandler = new PublicationEventHandler();
											num10 = 4;
											goto IL_01d9;
										case 3:
											startInformation = (IStartInformation)uGTM6NhEP1WTivFv8sgr(13.0, hgIkSShEeHFSirvB1wg6(DXCyuKhE2myPrbWWHu8M(-1633514411 ^ -1633571869)));
											num4 = 17;
											continue;
										case 6:
											try
											{
												while (true)
												{
													int num27;
													if (!JilRh4hEcsSIxTlIWqPc(enumerator2))
													{
														num27 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
														{
															num27 = 0;
														}
														goto IL_039e;
													}
													goto IL_0660;
													IL_0660:
													current3 = enumerator2.Current;
													num27 = 23;
													goto IL_039e;
													IL_039e:
													while (true)
													{
														int num28;
														switch (num27)
														{
														case 3:
														case 19:
															break;
														case 7:
														case 14:
															if (!tVofbYhELfbcXgg38gWJ(OIrrekhEJr8xYG18WsJf(current3), DXCyuKhE2myPrbWWHu8M(-1710575414 ^ -1710589364)))
															{
																num27 = 15;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
																{
																	num27 = 16;
																}
																continue;
															}
															goto case 22;
														case 2:
															ConfigurationScriptsErrors = (string)FiqTxthEsrhBCZS0r4kR(EfHg8RhElrHjJPIViysi(current3), qGHMbhhEUpDZSh3FLHPo());
															num27 = 4;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
															{
																num27 = 1;
															}
															continue;
														case 11:
															list2.Add((MemoryStream)Wl7JVPhEgcxNIjiA2Pl0(current3));
															num27 = 13;
															continue;
														case 22:
															((ComponentManager)Sts3SxhEijg8pQXRUhEn()).RegisterAssembly(assembly2);
															num27 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
															{
																num27 = 0;
															}
															continue;
														case 12:
															if (zucfSrhEMNClQwH8Outc(text))
															{
																num27 = 8;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
																{
																	num27 = 10;
																}
																continue;
															}
															goto case 8;
														case 4:
														case 9:
														case 13:
															goto end_IL_039e;
														case 26:
															if (oHZ0mMhEjj8uA3MtknRU(current3.Name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E2B10C)))
															{
																num27 = 20;
																continue;
															}
															goto end_IL_039e;
														case 5:
															if (!oHZ0mMhEjj8uA3MtknRU(OIrrekhEJr8xYG18WsJf(current3), DXCyuKhE2myPrbWWHu8M(0xD3DEF7E ^ 0xD3DE51A)))
															{
																num27 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
																{
																	num27 = 7;
																}
																continue;
															}
															goto case 15;
														case 15:
															MVVdaLhEY32cKChTO0gG(assembly2);
															num27 = 14;
															continue;
														case 21:
															IOExtensions.WriteAllBytesWithAttempts(Path.Combine(text, (string)OIrrekhEJr8xYG18WsJf(current3) + (string)DXCyuKhE2myPrbWWHu8M(-1822890472 ^ -1822922666)), (Stream)EfHg8RhElrHjJPIViysi(current3), TimeSpan.FromSeconds(1.0), setting);
															num27 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
															{
																num27 = 19;
															}
															continue;
														case 25:
															goto IL_0660;
														case 23:
															if (RK4bCNhE0d4G5UHXWjRX(current3) != null)
															{
																num28 = 17;
																goto IL_039a;
															}
															goto case 26;
														case 17:
															text = (string)M4Bho7hEylM5d6QSLLKm(dYKhTQhEmRiOvikgv19S(Sts3SxhEijg8pQXRUhEn()), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3315336));
															num28 = 12;
															goto IL_039a;
														case 8:
															Directory.CreateDirectory(text);
															num27 = 18;
															continue;
														case 24:
														{
															object obj = EfHg8RhElrHjJPIViysi(current3);
															if (obj == null)
															{
																num27 = 6;
																continue;
															}
															if (xq8EYQhErJrawiw2AFnv(obj) > 0)
															{
																goto case 2;
															}
															goto case 6;
														}
														case 20:
															ConfigurationScriptsRecompileRequired = true;
															num27 = 24;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
															{
																num27 = 3;
															}
															continue;
														case 10:
														case 18:
															wtBPlmhEdc7QFZsF41cb(M4Bho7hEylM5d6QSLLKm(text, tcbG00hE9RUI5mfHviBO(OIrrekhEJr8xYG18WsJf(current3), DXCyuKhE2myPrbWWHu8M(-1710575414 ^ -1710492560))), RK4bCNhE0d4G5UHXWjRX(current3), TimeSpan.FromSeconds(1.0), setting);
															num27 = 27;
															continue;
														default:
															list.Add(assembly2);
															num27 = 11;
															continue;
														case 27:
															goto IL_0788;
														case 6:
															num27 = 9;
															continue;
														case 1:
															goto end_IL_0564;
															IL_039a:
															num27 = num28;
															continue;
														}
														goto IL_0446;
														IL_0788:
														object obj2 = EfHg8RhElrHjJPIViysi(current3);
														if (obj2 == null)
														{
															num27 = 3;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
															{
																num27 = 1;
															}
															continue;
														}
														if (xq8EYQhErJrawiw2AFnv(obj2) > 0)
														{
															num27 = 7;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
															{
																num27 = 21;
															}
															continue;
														}
														goto IL_0446;
														IL_0446:
														assembly2 = (Assembly)gB9hkNhE52D7axtIfSwc(current3.AssemblyRawStream, Wl7JVPhEgcxNIjiA2Pl0(current3));
														num27 = 5;
														continue;
														end_IL_039e:
														break;
													}
													continue;
													end_IL_0564:
													break;
												}
											}
											finally
											{
												int num29;
												if (enumerator2 == null)
												{
													num29 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
													{
														num29 = 1;
													}
													goto IL_082b;
												}
												goto IL_0841;
												IL_0841:
												khgNxJhE13keHsOYC8wd(enumerator2);
												num29 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
												{
													num29 = 0;
												}
												goto IL_082b;
												IL_082b:
												switch (num29)
												{
												case 1:
													goto end_IL_0806;
												case 2:
													goto end_IL_0806;
												}
												goto IL_0841;
												end_IL_0806:;
											}
											goto case 9;
										case 16:
											startInformation = (IStartInformation)uGTM6NhEP1WTivFv8sgr(99.0, SR.M((string)DXCyuKhE2myPrbWWHu8M(0x63ABA4E8 ^ 0x63A88D38)));
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
											{
												num4 = 14;
											}
											continue;
										case 8:
											V9eqT4hEaFyxG5KTYqNU(ylU8LMhENJ3no4g00OBs(), VprG0OhEpIdm4mYL18WY(DXCyuKhE2myPrbWWHu8M(0x42643203 ^ 0x42671ACF), (int)(HwZMFShEk8CeWGj8sZKH() - dateTime3).TotalMilliseconds, DXCyuKhE2myPrbWWHu8M(0x4785BC0D ^ 0x4784C831)));
											num4 = 42;
											continue;
										case 21:
											if (dbPreUpdater != null)
											{
												num4 = 7;
												continue;
											}
											goto case 23;
										case 18:
											XWlIc9hfBJ2poxTt2OPq(mwAKgLhfFsefQerrPsaa(), new Action(_003C_003Ec__DisplayClass6_._003CRegister_003Eb__0));
											num10 = 20;
											goto IL_01d9;
										case 14:
											try
											{
												BuildHubsAssembly();
												int num17 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
												{
													num17 = 1;
												}
												while (true)
												{
													switch (num17)
													{
													case 1:
														V9eqT4hEaFyxG5KTYqNU(Logger.Log, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA5A03BF) + (int)hB6xcphE3RLmeOMZs7uV(HwZMFShEk8CeWGj8sZKH(), dateTime3).TotalMilliseconds + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CA3277));
														num17 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
														{
															num17 = 0;
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
													int num18 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
													{
														num18 = 0;
													}
													while (true)
													{
														switch (num18)
														{
														default:
															khgNxJhE13keHsOYC8wd(startInformation);
															num18 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
															{
																num18 = 1;
															}
															continue;
														case 1:
															break;
														}
														break;
													}
												}
											}
											goto case 26;
										case 25:
											setting = SR.GetSetting((string)DXCyuKhE2myPrbWWHu8M(0x103FE975 ^ 0x103CC10B), 30);
											num4 = 2;
											continue;
										case 12:
											try
											{
												IActorModelRuntime serviceNotNull2 = Locator.GetServiceNotNull<IActorModelRuntime>();
												int num11 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
												{
													num11 = 0;
												}
												switch (num11)
												{
												default:
													try
													{
														TaskAwaiter<bool> awaiter = serviceNotNull2.GetActor<IPublicationActor>(Guid.Empty).PublicationStarted().GetAwaiter();
														int num12 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
														{
															num12 = 0;
														}
														while (true)
														{
															switch (num12)
															{
															case 2:
																startInformation = StartInformation.Operation(14.0, SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72442AB4)));
																num12 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
																{
																	num12 = 1;
																}
																continue;
															default:
																if (awaiter.GetResult())
																{
																	num12 = 2;
																	continue;
																}
																break;
															case 1:
																try
																{
																	z5ygoDhE6VihNm5EdJHJ(publicationEventHandler);
																	int num13 = 0;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
																	{
																		num13 = 0;
																	}
																	switch (num13)
																	{
																	case 0:
																		break;
																	}
																}
																finally
																{
																	int num14;
																	if (startInformation == null)
																	{
																		num14 = 2;
																		goto IL_0bc5;
																	}
																	goto IL_0bfa;
																	IL_0bc5:
																	switch (num14)
																	{
																	case 2:
																		goto end_IL_0bb0;
																	case 1:
																		goto end_IL_0bb0;
																	}
																	goto IL_0bfa;
																	IL_0bfa:
																	khgNxJhE13keHsOYC8wd(startInformation);
																	num14 = 0;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
																	{
																		num14 = 1;
																	}
																	goto IL_0bc5;
																	end_IL_0bb0:;
																}
																break;
															case 3:
																break;
															}
															break;
														}
													}
													catch (Exception ex)
													{
														int num15 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
														{
															num15 = 1;
														}
														while (true)
														{
															switch (num15)
															{
															case 1:
																WrFJrwhEH8iRcUc13Z7K(ylU8LMhENJ3no4g00OBs(), ex);
																num15 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
																{
																	num15 = 0;
																}
																continue;
															case 0:
																break;
															}
															break;
														}
													}
													break;
												}
											}
											finally
											{
												if (disposable != null)
												{
													int num16 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
													{
														num16 = 0;
													}
													while (true)
													{
														switch (num16)
														{
														default:
															khgNxJhE13keHsOYC8wd(disposable);
															num16 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
															{
																num16 = 0;
															}
															continue;
														case 1:
															break;
														}
														break;
													}
												}
											}
											goto case 44;
										case 13:
											try
											{
												_previousAsmModelsMetadataList = dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.Runned);
												int num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
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
												int num9;
												if (startInformation == null)
												{
													int num8 = 2;
													num9 = num8;
													goto IL_0d44;
												}
												goto IL_0d5a;
												IL_0d44:
												switch (num9)
												{
												case 2:
													goto end_IL_0d2b;
												case 1:
													goto end_IL_0d2b;
												}
												goto IL_0d5a;
												IL_0d5a:
												startInformation.Dispose();
												num9 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
												{
													num9 = 0;
												}
												goto IL_0d44;
												end_IL_0d2b:;
											}
											goto case 27;
										case 35:
											startInformation = (IStartInformation)uGTM6NhEP1WTivFv8sgr(99.0, hgIkSShEeHFSirvB1wg6(DXCyuKhE2myPrbWWHu8M(-1876063057 ^ -1875991239)));
											num10 = 38;
											goto IL_01d9;
										case 17:
											try
											{
												Init(_003C_003Ec__DisplayClass6_.parameters, null);
												int num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
												{
													num5 = 0;
												}
												switch (num5)
												{
												case 0:
													break;
												}
											}
											finally
											{
												if (startInformation != null)
												{
													int num6 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
													{
														num6 = 0;
													}
													while (true)
													{
														switch (num6)
														{
														default:
															khgNxJhE13keHsOYC8wd(startInformation);
															num6 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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
											goto case 11;
										case 22:
											NBV50xhEwZAEYM0FeJP0(dbPreUpdater);
											num4 = 32;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
											{
												num4 = 21;
											}
											continue;
										case 15:
											dbPreUpdater = (DbPreUpdater)URcIOQhEOaIf6vKOwdeg(serviceNotNull);
											num10 = 21;
											goto IL_01d9;
										case 28:
											list2 = new List<MemoryStream>();
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
											{
												num4 = 0;
											}
											continue;
										case 37:
											num19 = pwf3XNhExHw4JX2ZveYd(((MetadataItemManager)efpZtQhE7Lpy90klgyZv()).GetRestartRequiredMetadataUids()) > 0;
											goto IL_1523;
										case 40:
											oaG8mUhEtGIqnr5HeLQN(dbPreUpdater, r);
											num4 = 22;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
											{
												num4 = 14;
											}
											continue;
										case 9:
											_003C_003Ec__DisplayClass6_.parameters.Add<AssemblyModelsMetadataMap>();
											num4 = 30;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
											{
												num4 = 5;
											}
											continue;
										case 2:
											if (Bmp32thEA1hdepj1Chu9(Locator.GetServiceNotNull<IDynamicPublicationService>()))
											{
												num4 = 31;
												continue;
											}
											goto case 37;
										case 19:
											if (kEYJxVhEzDx31dO7Kgu0(list) > 0)
											{
												num4 = 46;
												continue;
											}
											goto case 42;
										case 44:
											enumerable = dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.Published);
											num4 = 39;
											continue;
										case 24:
											Locator.GetServiceNotNull<FindReferenceService>().AddMetadata(_metadataList.Values.OfType<EntityMetadata>());
											num4 = 10;
											continue;
										case 26:
											dateTime3 = HwZMFShEk8CeWGj8sZKH();
											num4 = 11;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
											{
												num4 = 24;
											}
											continue;
										case 10:
											V9eqT4hEaFyxG5KTYqNU(ylU8LMhENJ3no4g00OBs(), VprG0OhEpIdm4mYL18WY(DXCyuKhE2myPrbWWHu8M(-475857671 ^ -475933027), (int)hB6xcphE3RLmeOMZs7uV(HwZMFShEk8CeWGj8sZKH(), dateTime3).TotalMilliseconds, DXCyuKhE2myPrbWWHu8M(-576149596 ^ -576072808)));
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
											{
												num4 = 34;
											}
											continue;
										case 32:
											if (!serviceNotNull.IsFirstServerInCluster)
											{
												num4 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
												{
													num4 = 0;
												}
												continue;
											}
											goto case 44;
										case 11:
											V9eqT4hEaFyxG5KTYqNU(ylU8LMhENJ3no4g00OBs(), VprG0OhEpIdm4mYL18WY(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A4CB4A), (int)hB6xcphE3RLmeOMZs7uV(DateTime.Now, dateTime3).TotalMilliseconds, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AAD0D4)));
											num4 = 45;
											continue;
										case 23:
											throw new InvalidOperationException((string)DXCyuKhE2myPrbWWHu8M(0x4EA5403C ^ 0x4EA6672A));
										case 7:
											startInformation = (IStartInformation)uGTM6NhEP1WTivFv8sgr(1.0, hgIkSShEeHFSirvB1wg6(DXCyuKhE2myPrbWWHu8M(-345420348 ^ -345347406)));
											num4 = 13;
											continue;
										case 36:
											dateTime3 = DateTime.Now;
											num4 = 3;
											continue;
										case 43:
											Init(_003C_003Ec__DisplayClass6_.parameters, list, null, null, list2);
											num4 = 8;
											continue;
										default:
											if (enumerable != null)
											{
												num4 = 25;
												continue;
											}
											goto case 9;
										case 5:
											try
											{
												while (true)
												{
													IL_11cb:
													int num24;
													if (!JilRh4hEcsSIxTlIWqPc(enumerator))
													{
														num24 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
														{
															num24 = 0;
														}
														goto IL_118e;
													}
													goto IL_11a8;
													IL_11a8:
													current2 = enumerator.Current;
													num24 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
													{
														num24 = 0;
													}
													goto IL_118e;
													IL_118e:
													while (true)
													{
														switch (num24)
														{
														case 3:
															break;
														case 2:
															goto IL_11cb;
														default:
														{
															_003C_003Ec__DisplayClass6_.parameters.Add(current2);
															int num25 = 2;
															num24 = num25;
															continue;
														}
														case 1:
															goto end_IL_11cb;
														}
														break;
													}
													goto IL_11a8;
													continue;
													end_IL_11cb:
													break;
												}
											}
											finally
											{
												int num26;
												if (enumerator == null)
												{
													num26 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
													{
														num26 = 0;
													}
													goto IL_1237;
												}
												goto IL_124d;
												IL_124d:
												khgNxJhE13keHsOYC8wd(enumerator);
												num26 = 2;
												goto IL_1237;
												IL_1237:
												switch (num26)
												{
												default:
													goto end_IL_1212;
												case 1:
													break;
												case 0:
													goto end_IL_1212;
												case 2:
													goto end_IL_1212;
												}
												goto IL_124d;
												end_IL_1212:;
											}
											goto case 19;
										case 38:
											try
											{
												enumerator2 = dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.GlobalModule).GetEnumerator();
												int num20 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
												{
													num20 = 0;
												}
												switch (num20)
												{
												default:
													try
													{
														while (true)
														{
															IL_1373:
															int num21;
															if (!JilRh4hEcsSIxTlIWqPc(enumerator2))
															{
																num21 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
																{
																	num21 = 0;
																}
																goto IL_12e8;
															}
															goto IL_1350;
															IL_1350:
															current = enumerator2.Current;
															num21 = 3;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
															{
																num21 = 0;
															}
															goto IL_12e8;
															IL_12e8:
															while (true)
															{
																switch (num21)
																{
																case 4:
																	assembly = ComponentManager.LoadAssembly((MemoryStream)RK4bCNhE0d4G5UHXWjRX(current), (MemoryStream)Wl7JVPhEgcxNIjiA2Pl0(current));
																	num21 = 5;
																	continue;
																case 5:
																	AEtwtkhfWC0U0uEK8v85(Sts3SxhEijg8pQXRUhEn(), assembly);
																	num21 = 1;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
																	{
																		num21 = 1;
																	}
																	continue;
																case 2:
																	goto IL_1350;
																case 1:
																	goto IL_1373;
																case 3:
																	if (RK4bCNhE0d4G5UHXWjRX(current) != null)
																	{
																		num21 = 4;
																		continue;
																	}
																	goto IL_1373;
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
														int num22;
														if (enumerator2 == null)
														{
															num22 = 2;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
															{
																num22 = 0;
															}
															goto IL_13d9;
														}
														goto IL_13ef;
														IL_13ef:
														khgNxJhE13keHsOYC8wd(enumerator2);
														num22 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
														{
															num22 = 0;
														}
														goto IL_13d9;
														IL_13d9:
														switch (num22)
														{
														case 2:
															goto end_IL_13b4;
														case 1:
															goto end_IL_13b4;
														}
														goto IL_13ef;
														end_IL_13b4:;
													}
													break;
												}
											}
											finally
											{
												if (startInformation != null)
												{
													int num23 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
													{
														num23 = 0;
													}
													while (true)
													{
														switch (num23)
														{
														case 1:
															khgNxJhE13keHsOYC8wd(startInformation);
															num23 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
															{
																num23 = 0;
															}
															continue;
														case 0:
															break;
														}
														break;
													}
												}
											}
											goto case 16;
										case 45:
											if (W2VonghEDp1sNQp329ks(dbPreUpdater))
											{
												num4 = 40;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
												{
													num4 = 7;
												}
												continue;
											}
											goto case 32;
										case 27:
											dbPreUpdater.CheckMetadataList(_previousAsmModelsMetadataList);
											num4 = 36;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
											{
												num4 = 25;
											}
											continue;
										case 39:
											list = new List<Assembly>();
											num4 = 28;
											continue;
										case 42:
											dateTime3 = HwZMFShEk8CeWGj8sZKH();
											num10 = 18;
											goto IL_01d9;
										case 33:
											enumerator2 = enumerable.GetEnumerator();
											num4 = 6;
											continue;
										case 31:
											num19 = !serviceNotNull.IsFirstServerInCluster;
											goto IL_1523;
										case 29:
											enumerable = enumerable.Where(delegate(AssemblyModelsMetadata a)
											{
												int num34 = 1;
												int num35 = num34;
												while (true)
												{
													switch (num35)
													{
													case 1:
														if (!_003C_003Ec.kueh44CgljkbB8gL5kla(_003C_003Ec.WAmLM6Cg9xRNeYPmJPTH(a), _003C_003Ec.JoOdLdCgdlyxJl4cN6px(-583745292 ^ -583742832)))
														{
															return false;
														}
														num35 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
														{
															num35 = 0;
														}
														break;
													default:
														return _003C_003Ec.kueh44CgljkbB8gL5kla(_003C_003Ec.WAmLM6Cg9xRNeYPmJPTH(a), _003C_003Ec.JoOdLdCgdlyxJl4cN6px(-1765851862 ^ -1765804116));
													}
												}
											}).Concat(_previousAsmModelsMetadataList.Where(delegate(AssemblyModelsMetadata a)
											{
												int num32 = 1;
												int num33 = num32;
												while (true)
												{
													switch (num33)
													{
													default:
														return _003C_003Ec.BoYxRTCgrm7g1xF6DCUf(_003C_003Ec.WAmLM6Cg9xRNeYPmJPTH(a), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70024026));
													case 1:
														if ((string)_003C_003Ec.WAmLM6Cg9xRNeYPmJPTH(a) == (string)_003C_003Ec.JoOdLdCgdlyxJl4cN6px(0x5F3078B6 ^ 0x5F3072D2))
														{
															return true;
														}
														num33 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
														{
															num33 = 0;
														}
														break;
													}
												}
											}));
											num4 = 33;
											continue;
										case 30:
											enumerator = ((ComponentManager)Sts3SxhEijg8pQXRUhEn()).GetExtensionPoints<IEntityMappingProvider>().SelectMany((IEntityMappingProvider p) => p.GetMappingTypes()).GetEnumerator();
											num4 = 5;
											continue;
										case 34:
											_003C_003Ec__DisplayClass6_.parameters.AddNHibernateClassMappingRange(from type in _metadataList.Values.OfType<EntityMetadata>().Where(delegate(EntityMetadata metadata)
												{
													//Discarded unreachable code: IL_0039, IL_0048
													int num36 = 2;
													int num37 = num36;
													while (true)
													{
														switch (num37)
														{
														default:
															return _003C_003Ec.ogqkN3Cgggq2dPc9NYVn(metadata) == EntityMetadataType.InterfaceImplementation;
														case 1:
															return true;
														case 2:
															if (_003C_003Ec.ogqkN3Cgggq2dPc9NYVn(metadata) == EntityMetadataType.Entity)
															{
																num37 = 1;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
																{
																	num37 = 0;
																}
																break;
															}
															goto default;
														}
													}
												}).Select(_003C_003Ec__DisplayClass6_._003CRegister_003Eb__2)
												where _003C_003Ec.t1nqPgCg5pyDvm924iYi(type) == null
												select type);
											num4 = 41;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
											{
												num4 = 8;
											}
											continue;
										case 41:
											break;
											IL_01d9:
											num4 = num10;
											continue;
											IL_1523:
											if (num19)
											{
												num4 = 29;
												continue;
											}
											goto case 33;
										}
										break;
									}
								}
								finally
								{
									int num30;
									if (metadataServiceContext == null)
									{
										num30 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
										{
											num30 = 2;
										}
										goto IL_16aa;
									}
									goto IL_16c0;
									IL_16c0:
									khgNxJhE13keHsOYC8wd(metadataServiceContext);
									num30 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
									{
										num30 = 1;
									}
									goto IL_16aa;
									IL_16aa:
									switch (num30)
									{
									case 2:
										goto end_IL_1685;
									case 1:
										goto end_IL_1685;
									}
									goto IL_16c0;
									end_IL_1685:;
								}
								goto case 3;
							case 3:
								krLxZlhfo1jHd6SdRGY3();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
								{
									num3 = 0;
								}
								break;
							default:
								V9eqT4hEaFyxG5KTYqNU(Logger.Log, VprG0OhEpIdm4mYL18WY(DXCyuKhE2myPrbWWHu8M(-867826612 ^ -867881314), (int)hB6xcphE3RLmeOMZs7uV(HwZMFShEk8CeWGj8sZKH(), dateTime2).TotalMilliseconds, DXCyuKhE2myPrbWWHu8M(0x3A6135BE ^ 0x3A604182)));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
								{
									num3 = 2;
								}
								break;
							}
						}
					}
					finally
					{
						if (disposable2 != null)
						{
							int num31 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
							{
								num31 = 1;
							}
							while (true)
							{
								switch (num31)
								{
								case 1:
									khgNxJhE13keHsOYC8wd(disposable2);
									num31 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
									{
										num31 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				case 5:
				{
					DateTime date = dateTime.Date;
					dateTime = expirationDate.Value;
					if (gqLemFhETc963syN82Z2(date, dateTime.Date))
					{
						num2 = 7;
						continue;
					}
					goto case 10;
				}
				case 3:
					throw new LicenseActivationRequiredException(__ModuleInfo.UID);
				case 6:
					break;
					IL_1830:
					if (status != LicenseStatus.DateExpired)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 7;
				}
				break;
			}
			dateTime = DateTime.Now;
			num = 5;
		}
	}

	public IMetadata GetParentMetadata(Guid metadataUid)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		IMetadata value = default(IMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_metadataParents.TryGetValue(metadataUid, out value);
				num2 = 2;
				break;
			default:
				return null;
			case 1:
				return MetadataLoader.LoadMetadata(gFpNn3hfbtFM9pIpBFuP(value));
			case 2:
				if (value != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public Type GetTypeByUid(Guid uid, bool loadImplementation = true)
	{
		Type typeByUidOrNull = GetTypeByUidOrNull(uid, loadImplementation);
		if (nVCrBKhfhn5vgCsEkxNR(typeByUidOrNull, null))
		{
			throw new TypeNotFoundException(uid);
		}
		return typeByUidOrNull;
	}

	public Type GetTypeByUidOrNull(Guid uid, bool loadImplementation = true)
	{
		//Discarded unreachable code: IL_00d4, IL_00e3, IL_018e, IL_019d, IL_01a8, IL_0206, IL_0239, IL_02a1, IL_02b0, IL_032d, IL_036d, IL_037c, IL_0388, IL_041f, IL_0432, IL_0468, IL_0477, IL_04a6, IL_04b5
		int num = 5;
		int num2 = num;
		Type value = default(Type);
		IEnumerator<ITypeResolver> enumerator = default(IEnumerator<ITypeResolver>);
		ITypeResolver current = default(ITypeResolver);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (resolvingTypeUids != null)
				{
					num2 = 8;
					break;
				}
				goto case 11;
			case 11:
				resolvingTypeUids = new HashSet<Guid>();
				num2 = 2;
				break;
			case 5:
				if (i1dslmhfGaIQV5V3IBJA(uid, Guid.Empty))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 1;
					}
					break;
				}
				if (!_typesByUid.TryGetValue(uid, out value))
				{
					num2 = 7;
					break;
				}
				goto case 12;
			case 2:
			case 8:
				if (resolvingTypeUids.Add(uid))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 12;
			case 9:
				return value;
			case 1:
				return null;
			case 3:
				return value;
			default:
				if (loadImplementation)
				{
					return tqZmAZhfvGmcVTaD1kmJ(value);
				}
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num2 = 9;
				}
				break;
			case 10:
				if (_removedTypes.TryGetValue(uid, out value))
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 6:
				try
				{
					IEnumerable<ITypeResolver> extensionPoints = ((ComponentManager)Sts3SxhEijg8pQXRUhEn()).GetExtensionPoints<ITypeResolver>();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						int num4;
						switch (num3)
						{
						case 1:
							try
							{
								while (true)
								{
									IL_02e1:
									int num5;
									if (!enumerator.MoveNext())
									{
										num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
										{
											num5 = 5;
										}
										goto IL_01ac;
									}
									goto IL_01ce;
									IL_01ce:
									current = enumerator.Current;
									num5 = 3;
									goto IL_01ac;
									IL_01ac:
									while (true)
									{
										switch (num5)
										{
										case 3:
											try
											{
												value = wEt5wShfEa8qi4IyHtVr(current, uid);
												int num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
												{
													num6 = 0;
												}
												switch (num6)
												{
												case 0:
													break;
												}
											}
											catch (Exception ex)
											{
												int num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
												{
													num7 = 0;
												}
												while (true)
												{
													switch (num7)
													{
													default:
														UBkMgyhfQTI6aVNvhRiu(ylU8LMhENJ3no4g00OBs(), w8YUuXhffKXZjDWEUk3K(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C5013D9), uid, current.GetType().FullName), ex);
														num7 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
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
											goto case 2;
										case 1:
											goto end_IL_02e1;
										case 2:
											if (S1SdV4hfCSkBSyri1HPC(value, null))
											{
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
												{
													num5 = 1;
												}
												continue;
											}
											goto IL_02e1;
										case 4:
											goto IL_02e1;
										case 5:
											goto end_IL_02e1;
										}
										break;
									}
									goto IL_01ce;
									continue;
									end_IL_02e1:
									break;
								}
							}
							finally
							{
								int num8;
								if (enumerator == null)
								{
									num8 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
									{
										num8 = 2;
									}
									goto IL_0331;
								}
								goto IL_0347;
								IL_0347:
								khgNxJhE13keHsOYC8wd(enumerator);
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
								{
									num8 = 0;
								}
								goto IL_0331;
								IL_0331:
								switch (num8)
								{
								default:
									goto end_IL_030c;
								case 1:
									break;
								case 2:
									goto end_IL_030c;
								case 0:
									goto end_IL_030c;
								}
								goto IL_0347;
								end_IL_030c:;
							}
							goto case 2;
						case 2:
							_typesByUid[uid] = value;
							num4 = 5;
							goto IL_0162;
						case 3:
							value = null;
							num3 = 4;
							continue;
						default:
							if (extensionPoints != null)
							{
								num4 = 3;
								goto IL_0162;
							}
							break;
						case 4:
							enumerator = extensionPoints.GetEnumerator();
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
							{
								num3 = 0;
							}
							continue;
						case 5:
							break;
							IL_0162:
							num3 = num4;
							continue;
						}
						break;
					}
				}
				finally
				{
					resolvingTypeUids.Remove(uid);
					int num9 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num9 = 0;
					}
					switch (num9)
					{
					case 0:
						break;
					}
				}
				goto case 12;
			case 12:
				if (!nVCrBKhfhn5vgCsEkxNR(value, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 10;
			case 4:
				return null;
			}
		}
	}

	public IMetadata GetMetadata(Guid uid, bool loadImplementation = true)
	{
		return MetadataLoader.LoadMetadata(uid, inherit: true, loadImplementation);
	}

	public void RegisterTypes(IEnumerable<Type> types, IDictionary<Type, string> entityNames, Action<Type, Exception> registrationException, bool asEntity)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		if (types == null || !types.Any())
		{
			return;
		}
		IRuntimeApplication serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
		NHManagerRegisterParams nHManagerRegisterParams = new NHManagerRegisterParams
		{
			Builder = new ContainerBuilder(),
			TransformationProvider = serviceNotNull.TransformationProvider
		};
		bool flag = false;
		foreach (Type type in types)
		{
			try
			{
				LoadMetadataInternal(type);
				flag = RegisterTypeAsEntity(type, nHManagerRegisterParams, asEntity, (entityNames != null && entityNames.TryGetValue(type, out var value)) ? value : null) || flag;
			}
			catch (Exception ex)
			{
				Logger.Log.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870702159), type.FullName), ex);
				registrationException?.Invoke(type, ex);
			}
		}
		SessionFactoryHolder.UpdateConfiguration(nHManagerRegisterParams);
		if (flag)
		{
			UpdateIoC(nHManagerRegisterParams.Builder);
		}
	}

	internal void LoadAndRegister(MetadataAssemblyPublishResult result, IEnumerable<IRootMetadata> deltaMetadataList)
	{
		if (publishLogger.IsTraceEnabled())
		{
			publishLogger.Trace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638605393) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309826480), deltaMetadataList.Select((IRootMetadata m) => (string)_003C_003Ec.lLSCTDCgY3dCPBssMnHr(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858726817), _003C_003Ec.VAlpu6CgjNuKM8mwO2Gg(m), m))));
		}
		_asmModelsMetadataDict.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE3D7ED), out var value);
		_asmModelsMetadataDict.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521267602), out var value2);
		publishLogger.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146450217));
		string text = Path.Combine(ComponentManager.Current.WorkDirectory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837681895));
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		IOExtensions.WriteAllBytesWithAttempts(Path.Combine(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F64A9E)), result.ConfigurationAssembly.AssemblyRawStream, TimeSpan.FromSeconds(1.0), 15);
		if (result.DynamicAssembly != null)
		{
			IOExtensions.WriteAllBytesWithAttempts(Path.Combine(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876049617)), result.DynamicAssembly.AssemblyRawStream, TimeSpan.FromSeconds(1.0), 15);
		}
		IEnumerable<Guid> source;
		using (new MetadataServiceContext(new ExtendedMetadataService(MetadataServiceContext.MetadataRuntimeService, (from m in deltaMetadataList.OfType<EntityMetadata>()
			where m.Type == EntityMetadataType.Interface
			select m).Select(delegate(EntityMetadata m)
		{
			EntityMetadata entityMetadata = new EntityMetadata();
			_003C_003Ec.vXgTLhCgUmI44ZZJrSjs(entityMetadata, _003C_003Ec.w9fQ1hCgLFlF6HgG3hwv(m));
			_003C_003Ec.aZ9fLtCgs0fw9HdGMPIc(entityMetadata, EntityMetadataType.InterfaceImplementation);
			return entityMetadata;
		}).Concat(deltaMetadataList))))
		{
			source = deltaMetadataList.SelectMany(MetadataLoader.GetDependentMetadataUids).Distinct().ToArray();
		}
		Type value3;
		var list = (from uid in source
			select (!_typesByUid.TryGetValue(uid, out value3) || !(value3 != null)) ? null : new
			{
				type = value3,
				uid = uid
			} into d
			where d != null
			select d).ToList();
		list.ForEach(d =>
		{
			FilterTypeAttribute reflectionCustomAttribute = d.type.GetReflectionCustomAttribute<FilterTypeAttribute>();
			PublishCacheContext.RemoveFromCache(d.type, d.uid);
			if (reflectionCustomAttribute != null)
			{
				PublishCacheContext.RemoveFromCache(reflectionCustomAttribute.FilterType, d.uid);
			}
		});
		EntityDynamicGenerator.LoadDeltaAssembly(result.ConfigurationDeltaAssemblyRaw, out var changedTypes, out var newTypes);
		ComponentManager.UpdateAssemblyRaw(ComponentManager.FindLoadedAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53CA6C7), isFullName: false), result.ConfigurationAssembly.AssemblyRawStream);
		IEnumerable<Type> changedTypes2 = Enumerable.Empty<Type>();
		IEnumerable<Type> newTypes2 = Enumerable.Empty<Type>();
		if (result.DynamicAssembly != null)
		{
			EntityDynamicGenerator.LoadDeltaAssembly(result.DynamicDeltaAssemblyRaw, out changedTypes2, out newTypes2);
			ComponentManager.UpdateAssemblyRaw(ComponentManager.FindLoadedAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218494080), isFullName: false), result.DynamicAssembly.AssemblyRawStream);
		}
		publishLogger.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571D8FEB));
		List<Guid> list2 = new List<Guid>();
		List<Guid> list3 = new List<Guid>();
		HashSet<Guid> hashSet = (from m in deltaMetadataList.Where(delegate(IRootMetadata t)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return !(t is EntityMetadata);
					case 1:
						if (!(t is IDeltaRootMetadata))
						{
							return false;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			})
			select _003C_003Ec.VAlpu6CgjNuKM8mwO2Gg(m)).ToHashSet();
		HashSet<Type> hashSet2 = newTypes.Concat(newTypes2).ToHashSet();
		HashSet<Type> deltaTypes = changedTypes.Concat(changedTypes2).Concat(hashSet2).ToHashSet();
		foreach (EntityMetadata item in deltaMetadataList.OfType<EntityMetadata>())
		{
			if (item.Type == EntityMetadataType.Interface)
			{
				list2.Add(item.Uid);
			}
			else if (item.Type == EntityMetadataType.InterfaceExtension)
			{
				list3.Add(item.BaseClassUid);
			}
		}
		Dictionary<Guid, AbstractMetadata> dictionary = value?.RestoreMetadata()?.ToDictionary((AbstractMetadata m) => _003C_003Ec.ODkKseCgcVmUcpuVTmxC(m)) ?? new Dictionary<Guid, AbstractMetadata>();
		foreach (Type item2 in newTypes.Concat(changedTypes))
		{
			bool flag = false;
			UidAttribute attribute = AttributeHelper<UidAttribute>.GetAttribute(item2, inherited: true);
			if (attribute != null)
			{
				flag = hashSet.Contains(attribute.Uid);
				if (flag)
				{
					publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521326350), item2.AssemblyQualifiedName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1DCFD2));
				}
				if (list2.Contains(attribute.Uid))
				{
					publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710646216), item2.Assembly);
					publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD67D60), item2.AssemblyQualifiedName, attribute.Uid);
					flag = true;
				}
			}
			BaseClassAttribute attribute2 = AttributeHelper<BaseClassAttribute>.GetAttribute(item2, inherited: true);
			if (attribute2 != null && list3.Contains(attribute2.BaseClassUid))
			{
				publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398472138), item2.AssemblyQualifiedName);
				publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637D0433), item2.AssemblyQualifiedName, attribute.Uid);
				flag = true;
			}
			if (flag)
			{
				if (publishLogger.IsTraceEnabled())
				{
					publishLogger.Trace(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29183857), item2.AssemblyQualifiedName, (item2 is TypeBuilder typeBuilder) ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C5016A5), typeBuilder.IsCreated()) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70194873), item2.GetHashCode()));
				}
				if (LoadMetadataInternal(item2) is AbstractMetadata abstractMetadata)
				{
					publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2139013808), item2.AssemblyQualifiedName);
					dictionary[abstractMetadata.Uid] = abstractMetadata;
				}
			}
		}
		publishLogger.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334922527));
		AssemblyModelsMetadata assemblyModelsMetadata = new AssemblyModelsMetadata
		{
			Id = (value?.Id ?? 0),
			Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837665249),
			AssemblyRawStream = result.ConfigurationAssembly.AssemblyRawStream,
			DocumentationRawStream = result.ConfigurationAssembly.DocumentationRawStream,
			Status = AssemblyModelsMetadataStatus.Runned
		};
		assemblyModelsMetadata.SetMetadata(dictionary.Values.ToArray());
		_asmModelsMetadataDict[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638400907)] = assemblyModelsMetadata;
		configUids.Clear();
		configUids.UnionWith(dictionary.Keys);
		if (result.DynamicAssembly != null)
		{
			publishLogger.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x4639206E));
			try
			{
				dictionary = value2?.RestoreMetadata()?.ToDictionary((AbstractMetadata m) => _003C_003Ec.ODkKseCgcVmUcpuVTmxC(m)) ?? new Dictionary<Guid, AbstractMetadata>();
				foreach (Type item3 in newTypes2.Concat(changedTypes2))
				{
					if (item3.IsInterface)
					{
						continue;
					}
					ImplementationUidAttribute attribute3 = AttributeHelper<ImplementationUidAttribute>.GetAttribute(item3, inherited: true);
					if (attribute3 != null)
					{
						publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269D7060), item3.AssemblyQualifiedName, attribute3.Uid);
						if (LoadMetadataInternal(item3) is AbstractMetadata abstractMetadata2)
						{
							publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289905960), item3.AssemblyQualifiedName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234098462));
							dictionary[abstractMetadata2.Uid] = abstractMetadata2;
						}
					}
				}
				assemblyModelsMetadata = new AssemblyModelsMetadata
				{
					Id = (value2?.Id ?? 0),
					Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70005469),
					AssemblyRawStream = result.DynamicAssembly.AssemblyRawStream,
					DocumentationRawStream = result.DynamicAssembly.DocumentationRawStream,
					Status = AssemblyModelsMetadataStatus.Runned
				};
				assemblyModelsMetadata.SetMetadata(dictionary.Values.ToArray());
				_asmModelsMetadataDict[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CB4C65)] = assemblyModelsMetadata;
			}
			catch (ReflectionTypeLoadException ex)
			{
				string text2 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3271668), ex.LoaderExceptions.Select((Exception e) => e.ToString()).ToArray());
				string message = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A6205A0) + text2;
				Logger.Log.Error(message, ex);
				throw;
			}
		}
		list.Where(d => !_typesByUid.ContainsKey(d.uid)).ForEach(d =>
		{
			LoadMetadataInternal(d.type);
		});
		RegisterDeltaTypes(deltaTypes, hashSet2);
	}

	public IEnumerable<IMetadata> GetMetadataList()
	{
		return _metadataList.Values;
	}

	public IEnumerable<AssemblyModelsMetadata> GetAssemblyModelsMetadataList()
	{
		return _asmModelsMetadataDict.Values;
	}

	public IEnumerable<AssemblyModelsMetadata> GetPreviousAssemblyModelsMetadataList()
	{
		return _previousAsmModelsMetadataList;
	}

	public IEnumerable<ITypeDescriptor> GetTypeDescriptors()
	{
		return _typeDescriptorsByUid.Values;
	}

	public ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid)
	{
		//Discarded unreachable code: IL_0079, IL_0088
		int num = 1;
		int num2 = num;
		ITypeDescriptor value = default(ITypeDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_typeDescriptorsByUid.TryGetValue((typeUid, Guid.Empty), out value);
				num2 = 3;
				break;
			default:
				if (value != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			case 3:
				return value;
			case 2:
				return value;
			case 1:
				_typeDescriptorsByUid.TryGetValue((typeUid, subTypeUid), out value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ITypeDescriptor GetTypeDescriptor(Type runtimeType)
	{
		//Discarded unreachable code: IL_00a3, IL_00b2, IL_00da
		int num = 1;
		int num2 = num;
		Type key = default(Type);
		ITypeDescriptor value = default(ITypeDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 8:
				key = runtimeType.GetGenericArguments()[0];
				num2 = 7;
				break;
			default:
				if (value != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			case 1:
				_typeDescriptorsByType.TryGetValue(runtimeType, out value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (runtimeType.IsGenericType)
				{
					num2 = 6;
					break;
				}
				goto case 2;
			case 2:
			case 4:
			case 5:
				return value;
			case 6:
				if (!nVCrBKhfhn5vgCsEkxNR(runtimeType.GetGenericTypeDefinition(), HlH5dnhf8tQP4FsdRdNP(typeof(Nullable<>).TypeHandle)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 8;
			case 7:
				_typeDescriptorsByType.TryGetValue(key, out value);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public IEnumerable<ITypeDescriptor> GetIdTypeDescriptors()
	{
		return _typeDescriptorsByUid.Values.Where((ITypeDescriptor t) => _003C_003Ec.mir18ACgzCVeNNqA3dup(t));
	}

	public ITypeDescriptor GetIdTypeDescriptor(Guid typeUid)
	{
		//Discarded unreachable code: IL_0075, IL_0084
		int num = 1;
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (typeDescriptor.UseForId)
					{
						return typeDescriptor;
					}
					goto end_IL_0012;
				default:
					if (typeDescriptor == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 4;
				case 2:
				case 3:
					return null;
				case 1:
					typeDescriptor = GetTypeDescriptor(typeUid, Guid.Empty);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
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

	public void OnSoftPublished(ICollection<IRootMetadata> metadatas)
	{
		Type value;
		var list = (from uid in metadatas.SelectMany(MetadataLoader.GetDependentMetadataUids).Distinct()
			select (!_typesByUid.TryGetValue(uid, out value)) ? null : new
			{
				type = value,
				uid = uid
			} into d
			where d != null
			select d).ToList();
		list.ForEach(d =>
		{
			FilterTypeAttribute reflectionCustomAttribute = d.type.GetReflectionCustomAttribute<FilterTypeAttribute>();
			PublishCacheContext.RemoveFromCache(d.type, d.uid);
			if (reflectionCustomAttribute != null)
			{
				PublishCacheContext.RemoveFromCache(reflectionCustomAttribute.FilterType, d.uid);
			}
		});
		list.ForEach(d =>
		{
			LoadMetadataInternal(d.type);
		});
		list.ForEach(d =>
		{
			if (MetadataLoader.LoadMetadata(d.type) is ICompositeMetadata metadata)
			{
				ProcessCompositeMetadata(d.type.Assembly, metadata);
			}
		});
		_removedTypes.Where((KeyValuePair<Guid, Type> p) => !_typesByUid.ContainsKey(p.Key)).ForEach(delegate(KeyValuePair<Guid, Type> p)
		{
			LoadMetadataInternal(p.Value);
		});
		_removedTypes.Clear();
	}

	public bool IsSystem(Guid typeUid)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 1;
		int num2 = num;
		Type value = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return !configUids.Contains(typeUid);
			default:
				return false;
			case 3:
				if (S1SdV4hfCSkBSyri1HPC(value, null))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 1:
				if (!_typesByUid.TryGetValue(typeUid, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public bool IsConfig(Guid typeUid)
	{
		//Discarded unreachable code: IL_0098, IL_00a7, IL_00b7, IL_00c6
		int num = 3;
		int num2 = num;
		Type value = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return configUids.Contains(typeUid);
			case 2:
			case 4:
				return false;
			default:
				if (!S1SdV4hfCSkBSyri1HPC(value, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 1;
			case 3:
				if (!_typesByUid.TryGetValue(typeUid, out value))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			}
		}
	}

	private void Init(NHManagerRegisterParams parameters, IList<Assembly> assemblies, IEnumerable<AssemblyModelsMetadata> preparedModelsMetadata = null, IList<MemoryStream> docRaws = null, IList<MemoryStream> pdbRaws = null)
	{
		_003C_003Ec__DisplayClass45_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass45_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.assemblies = assemblies;
		CS_0024_003C_003E8__locals0.preparedModelsMetadata = preparedModelsMetadata;
		CS_0024_003C_003E8__locals0.docRaws = docRaws;
		CS_0024_003C_003E8__locals0.pdbRaws = pdbRaws;
		DateTime now = DateTime.Now;
		CS_0024_003C_003E8__locals0.assemblies = CS_0024_003C_003E8__locals0.assemblies ?? (from a in ComponentManager.GetAssemblies().ToList()
			where (string)_003C_003Ec.qGX9SoC5FunX93ScTHoA(a) != (string)_003C_003Ec.JoOdLdCgdlyxJl4cN6px(0x5F3078B6 ^ 0x5F307298)
			select a).ToList();
		RegisterTypeDescriptors(CS_0024_003C_003E8__locals0.assemblies);
		now = DateTime.Now;
		SR.RunWithCulture(SR.KeyCultureInfo, delegate
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 1:
					CS_0024_003C_003E8__locals0._003C_003E4__this.InitModelsMetadata(CS_0024_003C_003E8__locals0.assemblies, CS_0024_003C_003E8__locals0.preparedModelsMetadata, CS_0024_003C_003E8__locals0.docRaws, CS_0024_003C_003E8__locals0.pdbRaws);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num4 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
		Logger.Log.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538580852), (int)(DateTime.Now - now).TotalMilliseconds));
		now = DateTime.Now;
		RegisterEntityManagers(parameters, CS_0024_003C_003E8__locals0.assemblies);
		Logger.Log.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD66082), (int)(DateTime.Now - now).TotalMilliseconds));
		now = DateTime.Now;
		parameters.AddRange(from type in ComponentManager.Current.GetExtensionPointTypes(typeof(IEntity)).Where(delegate(Type type)
			{
				int num = 3;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						return !type.IsAbstract;
					case 3:
						if (CS_0024_003C_003E8__locals0.assemblies == null)
						{
							return true;
						}
						num2 = 2;
						break;
					case 2:
						if (CS_0024_003C_003E8__locals0.assemblies.Contains(type.Assembly))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_0036;
					default:
						{
							if (!type.ContainsGenericParameters)
							{
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
								{
									num2 = 1;
								}
								break;
							}
							goto IL_0036;
						}
						IL_0036:
						return false;
					}
				}
			})
			select GetClassMapType(type) into сlassMapType
			where _003C_003Ec.BqWU2rC5BwZGEPTtMcJK(сlassMapType, null)
			select сlassMapType);
		Logger.Log.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDF8B20), (int)(DateTime.Now - now).TotalMilliseconds));
	}

	private void InitModelsMetadata([NotNull] IList<Assembly> assemblies, IEnumerable<AssemblyModelsMetadata> preparedModelsMetadata, IList<MemoryStream> docRaws, IList<MemoryStream> pdbRaws)
	{
		Contract.ArgumentNotNull(assemblies, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317770926));
		ApplicationStartCache applicationStartCache = Locator.GetServiceNotNull<IRuntimeApplication>().ApplicationStartCache;
		foreach (Assembly assembly in assemblies)
		{
			_003C_003Ec__DisplayClass46_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass46_0();
			if (AttributeHelper<ModelAssemblyAttribute>.GetAttribute(assembly) == null)
			{
				continue;
			}
			_modelAssemblies.Add(assembly);
			CS_0024_003C_003E8__locals0.metadataCache = null;
			Action<AssemblyModelsMetadata> action = delegate(AssemblyModelsMetadata m)
			{
				//Discarded unreachable code: IL_0058, IL_0067, IL_0072, IL_010d, IL_0145, IL_0154
				int num = 2;
				int num2 = num;
				IEnumerator<IRootMetadata> enumerator2 = default(IEnumerator<IRootMetadata>);
				IRootMetadata current2 = default(IRootMetadata);
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 2:
						CS_0024_003C_003E8__locals0.metadataCache = new Dictionary<Guid, IRootMetadata>();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 1;
						}
						break;
					case 0:
						return;
					case 3:
						try
						{
							while (true)
							{
								int num3;
								if (!_003C_003Ec__DisplayClass46_0.GjC89xC5IcxDTatpRQv6(enumerator2))
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
									{
										num3 = 0;
									}
									goto IL_0076;
								}
								goto IL_00d4;
								IL_00d4:
								current2 = enumerator2.Current;
								num3 = 3;
								goto IL_0076;
								IL_0076:
								while (true)
								{
									switch (num3)
									{
									default:
										return;
									case 0:
										return;
									case 2:
										break;
									case 3:
										CS_0024_003C_003E8__locals0.metadataCache[_003C_003Ec__DisplayClass46_0.PwBCeiC5uEb7xQQaex7J(current2)] = current2;
										num3 = 2;
										continue;
									case 1:
										goto IL_00d4;
									}
									break;
								}
							}
						}
						finally
						{
							if (enumerator2 != null)
							{
								int num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num4 = 0;
								}
								while (true)
								{
									switch (num4)
									{
									case 1:
										enumerator2.Dispose();
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
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
					case 1:
						enumerator2 = ((IEnumerable)_003C_003Ec__DisplayClass46_0.Oikqd6C5Z0Fd3aCZl9vI(m)).OfType<IRootMetadata>().GetEnumerator();
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			};
			CS_0024_003C_003E8__locals0.asmName = ComponentManager.GetAssemblyShortName(assembly);
			AssemblyModelsMetadata assemblyModelsMetadata = null;
			AssemblyModelsMetadata assemblyModelsMetadata2 = _previousAsmModelsMetadataList.FirstOrDefault((AssemblyModelsMetadata a) => (string)_003C_003Ec__DisplayClass46_0.WPnMm0C5VEMvSJvAHL0C(a) == CS_0024_003C_003E8__locals0.asmName);
			AssemblyModelsMetadata assemblyModelsMetadata3 = null;
			if (!applicationStartCache.GetAssemblyInfo(assembly)._changed && assemblyModelsMetadata2 != null && assemblyModelsMetadata2.Status == AssemblyModelsMetadataStatus.Runned)
			{
				assemblyModelsMetadata = assemblyModelsMetadata2;
				if (assemblyModelsMetadata != null)
				{
					action(assemblyModelsMetadata);
				}
			}
			else
			{
				assemblyModelsMetadata3 = preparedModelsMetadata?.FirstOrDefault((AssemblyModelsMetadata a) => _003C_003Ec__DisplayClass46_0.Dr3vL9C5Sj0cUwDadWmU(a.Name, CS_0024_003C_003E8__locals0.asmName));
				if (assemblyModelsMetadata3 != null)
				{
					action(assemblyModelsMetadata3);
				}
			}
			List<AbstractMetadata> list = new List<AbstractMetadata>();
			try
			{
				Type[] types = assembly.GetTypes();
				foreach (Type type in types)
				{
					if (LoadMetadataInternal(type, CS_0024_003C_003E8__locals0.metadataCache) is AbstractMetadata item)
					{
						list.Add(item);
					}
				}
			}
			catch (ReflectionTypeLoadException ex)
			{
				string text = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767798291), ex.LoaderExceptions.Select((Exception e) => e.ToString()).ToArray());
				string message = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F657E2) + assembly.FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD5336E) + text;
				Logger.Log.Error(message, ex);
				throw;
			}
			if (assemblyModelsMetadata == null)
			{
				assemblyModelsMetadata = new AssemblyModelsMetadata
				{
					Id = (assemblyModelsMetadata2?.Id ?? 0),
					Name = CS_0024_003C_003E8__locals0.asmName
				};
				byte[] array = ComponentManager.GetLoadedAssemblyRaw(assembly);
				MemoryStream memoryStream = pdbRaws?[assemblies.IndexOf(assembly)];
				MemoryStream memoryStream2 = docRaws?[assemblies.IndexOf(assembly)];
				if (array == null && !assembly.IsDynamic && assembly.Location != null && File.Exists(assembly.Location))
				{
					array = File.ReadAllBytes(assembly.Location);
					string path = Path.ChangeExtension(assembly.Location, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859022503));
					if (memoryStream == null && File.Exists(path))
					{
						using FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
						memoryStream = MemoryHelper.GetMemoryStream((int)fileStream.Length);
						fileStream.CopyTo(memoryStream);
						memoryStream.Seek(0L, SeekOrigin.Begin);
					}
					string path2 = Path.ChangeExtension(assembly.Location, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6ED445));
					if (memoryStream2 == null && File.Exists(path2))
					{
						using FileStream fileStream2 = new FileStream(path2, FileMode.Open, FileAccess.Read);
						memoryStream2 = MemoryHelper.GetMemoryStream((int)fileStream2.Length);
						fileStream2.CopyTo(memoryStream2);
						memoryStream2.Seek(0L, SeekOrigin.Begin);
					}
				}
				if (array != null)
				{
					assemblyModelsMetadata.AssemblyRawStream = MemoryHelper.GetMemoryStream(array.Length);
					assemblyModelsMetadata.AssemblyRawStream.Write(array, 0, array.Length);
				}
				assemblyModelsMetadata.DebugRawStream = memoryStream;
				assemblyModelsMetadata.DocumentationRawStream = memoryStream2;
				if (assemblyModelsMetadata3 != null)
				{
					assemblyModelsMetadata.MetadataStream = assemblyModelsMetadata3.MetadataStream;
				}
				else
				{
					assemblyModelsMetadata.SetMetadata(list.ToArray());
				}
			}
			if (_asmModelsMetadataDict.ContainsKey(CS_0024_003C_003E8__locals0.asmName))
			{
				Logger.Log.ErrorFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998354778), CS_0024_003C_003E8__locals0.asmName);
			}
			_asmModelsMetadataDict.Add(CS_0024_003C_003E8__locals0.asmName, assemblyModelsMetadata);
			if (CS_0024_003C_003E8__locals0.asmName == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822888836))
			{
				configUids.Clear();
				configUids.UnionWith(from m in assemblyModelsMetadata.RestoreMetadata()
					select m.Uid);
			}
		}
	}

	private IMetadata LoadMetadataInternal(Type type, Dictionary<Guid, IRootMetadata> metadataCache = null)
	{
		try
		{
			if ((!type.IsInterface && type.IsAbstract) || type.ContainsGenericParameters)
			{
				return null;
			}
			MetadataTypeAttribute attribute = AttributeHelper<MetadataTypeAttribute>.GetAttribute(type, inherited: false);
			if (attribute == null || !typeof(AbstractMetadata).IsAssignableFrom(attribute.MetadataType) || attribute.MetadataType.IsDefined(typeof(PartialMetadataTypeAttribute), inherit: false) || attribute.MetadataType.GetInterface(typeof(IRootMetadata).FullName) == null)
			{
				if (AttributeHelper<FilterForAttribute>.GetAttribute(type, inherited: true) != null && type.Assembly.IsDynamicAssembly())
				{
					EntityDynamicProvider.AddType(type);
				}
				return null;
			}
			if (metadataCache != null)
			{
				UidAttribute attribute2 = AttributeHelper<UidAttribute>.GetAttribute(type, inherited: true);
				if (attribute2 != null && metadataCache.TryGetValue(attribute2.Uid, out var value))
				{
					MetadataLoader.AddMetadataToCache(type, value, inherit: false);
				}
			}
			IMetadata metadata = MetadataLoader.LoadMetadata(type, inherit: false, loadImplementation: false);
			if (_typesByUid.TryGetValue(metadata.Uid, out var value2) && value2 != null)
			{
				return null;
			}
			_typesByUid[metadata.Uid] = type;
			_metadataList[metadata.Uid] = metadata;
			if (type.Assembly.IsDynamicAssembly())
			{
				EntityDynamicProvider.AddType(type);
			}
			if (metadata is ICompositeMetadata metadata2)
			{
				ProcessCompositeMetadata(type.Assembly, metadata2);
			}
			return metadata;
		}
		catch (Exception cause)
		{
			throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76EE68C)), type.AssemblyQualifiedName), cause);
		}
	}

	private void ProcessCompositeMetadata(Assembly assembly, ICompositeMetadata metadata)
	{
		//Discarded unreachable code: IL_002f, IL_003e, IL_0104, IL_0113, IL_0225, IL_025d, IL_026c
		int num = 2;
		int num2 = num;
		IEnumerator<IMetadata> enumerator = default(IEnumerator<IMetadata>);
		Type type = default(Type);
		ICodeItemMetadata codeItemMetadata = default(ICodeItemMetadata);
		IMetadata current = default(IMetadata);
		ICompositeMetadata compositeMetadata = default(ICompositeMetadata);
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
					while (true)
					{
						IL_0160:
						int num3;
						if (!JilRh4hEcsSIxTlIWqPc(enumerator))
						{
							num3 = 4;
							goto IL_004d;
						}
						goto IL_00ac;
						IL_004d:
						while (true)
						{
							switch (num3)
							{
							case 4:
								return;
							case 8:
							{
								type = Wtt178hfZpB8Q7bU4fpj(assembly, codeItemMetadata.FullTypeName);
								int num4 = 9;
								num3 = num4;
								continue;
							}
							case 11:
								break;
							case 7:
								_metadataParents[current.Uid] = metadata;
								num3 = 10;
								continue;
							case 12:
							case 13:
								compositeMetadata = current as ICompositeMetadata;
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
								{
									num3 = 1;
								}
								continue;
							case 3:
								ProcessCompositeMetadata(assembly, compositeMetadata);
								num3 = 5;
								continue;
							case 2:
								_typesByUid[gFpNn3hfbtFM9pIpBFuP(current)] = type;
								num3 = 12;
								continue;
							default:
								if (codeItemMetadata == null)
								{
									num3 = 13;
									continue;
								}
								goto case 8;
							case 5:
								goto IL_0160;
							case 1:
								if (compositeMetadata != null)
								{
									num3 = 3;
									continue;
								}
								goto IL_0160;
							case 6:
								_metadataList[gFpNn3hfbtFM9pIpBFuP(current)] = current;
								num3 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
								{
									num3 = 3;
								}
								continue;
							case 9:
								if (S1SdV4hfCSkBSyri1HPC(type, null))
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
									{
										num3 = 2;
									}
									continue;
								}
								goto case 12;
							case 10:
								codeItemMetadata = current as ICodeItemMetadata;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						}
						goto IL_00ac;
						IL_00ac:
						current = enumerator.Current;
						num3 = 6;
						goto IL_004d;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								khgNxJhE13keHsOYC8wd(enumerator);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
								{
									num5 = 0;
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
				enumerator = metadata.GetCompositeParts().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private bool RegisterTypeAsEntity(Type type, NHManagerRegisterParams parameters, bool asEntity, string entityName = null, int? tableNumber = null, bool? dynamicInsert = null, bool? dynamicUpdate = null)
	{
		if (!typeof(IEntity).IsAssignableFrom(type))
		{
			return false;
		}
		if (asEntity)
		{
			IClassMetadata classMetadata = SessionFactoryHolder.SessionFactory.GetClassMetadata(type);
			if (((classMetadata != null) ? classMetadata.get_MappedClass() : null) != type && MetadataLoader.LoadMetadata(type, inherit: false) is EntityMetadata entityMetadata && type.IsClass)
			{
				Locator.GetServiceNotNull<FindReferenceService>().AddMetadata(new EntityMetadata[1] { entityMetadata });
				if (!RegisterTypeMapByClassMap(type, parameters))
				{
					parameters.AddNHibernateClassMapping(type, (entityName != type.FullName) ? entityName : null, tableNumber, dynamicInsert, (dynamicUpdate ?? (AttributeHelper<CompositeEntityPartAttribute>.GetAttributes(type, inherited: false).Count > 0)) ? new bool?(true) : null);
				}
			}
		}
		bool flag = registeredTypes.Add(type) && RegisterTypeDefaultManager(type, parameters.Builder);
		List<(Type, string, int?, bool?, bool?)> list = new List<(Type, string, int?, bool?, bool?)>();
		foreach (CompositeEntityPartAttribute attribute in AttributeHelper<CompositeEntityPartAttribute>.GetAttributes(type, inherited: false))
		{
			list.Add((attribute.EntityType, null, attribute.TableNumber, null, true));
		}
		foreach (TablePartAttribute attribute2 in AttributeHelper<TablePartAttribute>.GetAttributes(type, inherited: false))
		{
			string item = null;
			TablePartInfoAttribute tablePartInfoAttribute = ((entityName != null) ? AttributeHelper<TablePartInfoAttribute>.GetAttribute(attribute2.TablePartType, inherited: false) : null);
			if (tablePartInfoAttribute != null)
			{
				item = entityName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E412A1) + tablePartInfoAttribute.TablePartPropertyName;
			}
			list.Add((attribute2.TablePartType, item, null, null, null));
		}
		foreach (var item2 in list)
		{
			flag = RegisterTypeAsEntity(item2.Item1, parameters, asEntity, item2.Item2, item2.Item3, item2.Item4, item2.Item5) || flag;
		}
		return flag;
	}

	private void RegisterTypeMapByMetadata(IEnumerable<Type> types)
	{
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		_003C_003Ec__DisplayClass50_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass50_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		Dictionary<Guid, EntityMetadata> dictionary = new Dictionary<Guid, EntityMetadata>();
		foreach (Type item in types.Where((Type t) => !t.IsInterface))
		{
			UidAttribute attribute = AttributeHelper<UidAttribute>.GetAttribute(item, inherited: false);
			if (attribute != null && _metadataList.TryGetValue(attribute.Uid, out var value) && value is EntityMetadata entityMetadata)
			{
				while (entityMetadata.BaseClassUid != Guid.Empty)
				{
					entityMetadata = _metadataList[entityMetadata.BaseClassUid] as EntityMetadata;
				}
				dictionary[entityMetadata.Uid] = entityMetadata;
			}
		}
		CS_0024_003C_003E8__locals0.metadataList = new List<EntityMetadata>();
		CS_0024_003C_003E8__locals0.metadataList.AddRange(dictionary.Values);
		CS_0024_003C_003E8__locals0.allMetadataList = from md in _metadataList.Values.OfType<EntityMetadata>()
			where _003C_003Ec.ogqkN3Cgggq2dPc9NYVn(md) == EntityMetadataType.InterfaceImplementation
			select md;
		dictionary.Values.ForEach(delegate(EntityMetadata rootMetadata)
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
					CS_0024_003C_003E8__locals0.metadataList.AddRange(CS_0024_003C_003E8__locals0._003C_003E4__this.GetMetadataChilds(rootMetadata, CS_0024_003C_003E8__locals0.allMetadataList));
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num4 = 0;
					}
					break;
				}
			}
		});
		if (!CS_0024_003C_003E8__locals0.metadataList.Any())
		{
			return;
		}
		IRuntimeApplication serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
		NHManagerRegisterParams nHManagerRegisterParams = new NHManagerRegisterParams
		{
			Builder = new ContainerBuilder(),
			TransformationProvider = serviceNotNull.TransformationProvider
		};
		nHManagerRegisterParams.AddNHibernateClassMappingRange((from metadata in CS_0024_003C_003E8__locals0.metadataList.OfType<EntityMetadata>().Where(delegate(EntityMetadata metadata)
			{
				//Discarded unreachable code: IL_002d, IL_003c
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (metadata.Type == EntityMetadataType.Entity)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
							{
								num2 = 1;
							}
							break;
						}
						goto default;
					default:
						return metadata.Type == EntityMetadataType.InterfaceImplementation;
					case 1:
						return true;
					}
				}
			})
			select CS_0024_003C_003E8__locals0._003C_003E4__this._typesByUid[_003C_003Ec__DisplayClass50_0.aK6aY5C5X6iFYZ8288Uk(metadata)] into type
			where _003C_003Ec.GyBGaZC5WZ5X5CwIdcby(_003C_003Ec.t1nqPgCg5pyDvm924iYi(type), null)
			select type).SelectMany((Type type) => CS_0024_003C_003E8__locals0._003C_003E4__this.GetPartTypes(MetadataLoader.LoadMetadata(type, inherit: false) as ICompositeMetadata).Values.Prepend(type)));
		SessionFactoryHolder.UpdateConfiguration(nHManagerRegisterParams);
		Locator.GetServiceNotNull<FindReferenceService>().AddMetadata(CS_0024_003C_003E8__locals0.metadataList);
	}

	private IEnumerable<EntityMetadata> GetMetadataChilds(EntityMetadata entityMetadata, IEnumerable<EntityMetadata> metadataList)
	{
		_003C_003Ec__DisplayClass51_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass51_0();
		CS_0024_003C_003E8__locals0.entityMetadata = entityMetadata;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.metadataList = metadataList;
		CS_0024_003C_003E8__locals0.result = new List<EntityMetadata>();
		List<EntityMetadata> list = CS_0024_003C_003E8__locals0.metadataList.Where((EntityMetadata metadata) => metadata.BaseClassUid == _003C_003Ec__DisplayClass51_0.yxP7PAC5OLS1UIsqURmw(CS_0024_003C_003E8__locals0.entityMetadata)).ToList();
		CS_0024_003C_003E8__locals0.result.AddRange(list);
		list.ForEach(delegate(EntityMetadata child)
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
					CS_0024_003C_003E8__locals0.result.AddRange(CS_0024_003C_003E8__locals0._003C_003E4__this.GetMetadataChilds(child, CS_0024_003C_003E8__locals0.metadataList));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
		return CS_0024_003C_003E8__locals0.result;
	}

	private bool RegisterTypeMapByClassMap(Type type, NHManagerRegisterParams parameters)
	{
		int num = 1;
		int num2 = num;
		Type type2 = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				type2 = JlTCquhfumknDMrpTWlR(type);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return false;
			case 2:
				return true;
			}
			if (nVCrBKhfhn5vgCsEkxNR(type2, null))
			{
				num2 = 3;
				continue;
			}
			parameters.Add(type2);
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
			{
				num2 = 2;
			}
		}
	}

	private bool RegisterTypeDefaultManager(Type type, ContainerBuilder updater)
	{
		//Discarded unreachable code: IL_00b0, IL_00bf
		int num = 8;
		Type type2 = default(Type);
		IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> val = default(IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>);
		DefaultManagerAttribute attribute = default(DefaultManagerAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!S1SdV4hfCSkBSyri1HPC(type2, null))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 1;
				case 5:
					((ComponentManager)Sts3SxhEijg8pQXRUhEn()).SetupInterceptors(type2, val);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					TryRegisterAsEntityManager<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(val, type2);
					num2 = 6;
					continue;
				case 6:
					return true;
				case 4:
					return false;
				case 8:
					attribute = AttributeHelper<DefaultManagerAttribute>.GetAttribute(type, inherited: true);
					num2 = 7;
					continue;
				case 1:
					val = RegistrationExtensions.RegisterType(updater, type2);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					if (attribute != null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 4;
				case 9:
					type2 = GbMhblhfIMgpeDmufJyX(attribute, type);
					num2 = 2;
					continue;
				}
				break;
			}
			val.As(new Type[1] { type2 });
			num = 5;
		}
	}

	private void BuildHubsAssembly()
	{
		//Discarded unreachable code: IL_0083, IL_011f, IL_013b, IL_014a, IL_02c3, IL_02d2, IL_03ab, IL_03eb, IL_03fa, IL_0406, IL_0415, IL_0431, IL_051d, IL_052c
		int num = 5;
		int num2 = num;
		Assembly assembly = default(Assembly);
		byte[][] array = default(byte[][]);
		int num8 = default(int);
		Type current = default(Type);
		ConstructorInfo constructorInfo = default(ConstructorInfo);
		Type clientType = default(Type);
		Type type = default(Type);
		Func<object, IClient> wrapperFactory = default(Func<object, IClient>);
		Type[] genericArguments = default(Type[]);
		ParameterExpression parameterExpression = default(ParameterExpression);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return;
			case 2:
				assembly = ComponentManager.LoadAssembly(array[num8]);
				num2 = 6;
				continue;
			default:
				if (num8 >= array.Length)
				{
					num2 = 7;
					continue;
				}
				goto case 2;
			case 5:
				array = Locator.GetServiceNotNull<IBuildHubsAssemblyService>().BuildAssemblies();
				num2 = 4;
				continue;
			case 4:
				num8 = 0;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				break;
			case 6:
				try
				{
					IEnumerator<Type> enumerator = ((IEnumerable<Type>)UqibHohfVovHU8xcqoov(assembly)).Where(delegate(Type t)
					{
						int num9 = 1;
						int num10 = num9;
						while (true)
						{
							switch (num10)
							{
							case 1:
								if (_003C_003Ec.Q8RknJC5oRq3KxHNvY0F(typeof(IClient).TypeHandle).IsAssignableFrom(t))
								{
									num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
									{
										num10 = 0;
									}
									break;
								}
								goto IL_0063;
							case 2:
								return t.BaseType.IsConstructedGenericType;
							default:
								{
									if (_003C_003Ec.BqWU2rC5BwZGEPTtMcJK(t.BaseType, null))
									{
										num10 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
										{
											num10 = 1;
										}
										break;
									}
									goto IL_0063;
								}
								IL_0063:
								return false;
							}
						}
					}).GetEnumerator();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							while (true)
							{
								IL_035f:
								int num4;
								if (!JilRh4hEcsSIxTlIWqPc(enumerator))
								{
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
									{
										num4 = 7;
									}
									goto IL_0159;
								}
								goto IL_0277;
								IL_0277:
								current = enumerator.Current;
								num4 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
								{
									num4 = 5;
								}
								goto IL_0159;
								IL_0159:
								while (true)
								{
									switch (num4)
									{
									case 11:
										if (!Wsvw58hfSVmuBGiKAwiR(constructorInfo, null))
										{
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
											{
												num4 = 0;
											}
											continue;
										}
										goto case 3;
									case 5:
										HubClientProxyHelper.AddProxy(clientType, type, wrapperFactory);
										num4 = 9;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
										{
											num4 = 12;
										}
										continue;
									case 10:
										constructorInfo = current.GetConstructors(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault();
										num4 = 8;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
										{
											num4 = 11;
										}
										continue;
									case 4:
										type = genericArguments[1];
										num4 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
										{
											num4 = 10;
										}
										continue;
									case 8:
										wrapperFactory = Expression.Lambda<Func<object, IClient>>((Expression)YHxmNOhfK9dsQZ1rwpgm(constructorInfo, new Expression[1] { (Expression)K82ELyhfq2fpNNBNuZ3L(parameterExpression, type) }), new ParameterExpression[1] { parameterExpression }).Compile();
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
										{
											num4 = 5;
										}
										continue;
									case 1:
										break;
									case 2:
										if (genericArguments.Length == 2)
										{
											num4 = 6;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
											{
												num4 = 4;
											}
											continue;
										}
										goto IL_035f;
									case 6:
										clientType = genericArguments[0];
										num4 = 4;
										continue;
									case 3:
										throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787259589), qWghdOhfiMb8tPkhytZn(current)));
									default:
									{
										parameterExpression = (ParameterExpression)ChOnXUhfRhH8rLUrxc4F(HlH5dnhf8tQP4FsdRdNP(typeof(object).TypeHandle));
										int num5 = 8;
										num4 = num5;
										continue;
									}
									case 9:
										genericArguments = current.BaseType.GetGenericArguments();
										num4 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
										{
											num4 = 0;
										}
										continue;
									case 12:
										goto IL_035f;
									case 7:
										goto end_IL_035f;
									}
									break;
								}
								goto IL_0277;
								continue;
								end_IL_035f:
								break;
							}
						}
						finally
						{
							int num6;
							if (enumerator == null)
							{
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
								{
									num6 = 0;
								}
								goto IL_03af;
							}
							goto IL_03c5;
							IL_03c5:
							khgNxJhE13keHsOYC8wd(enumerator);
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
							{
								num6 = 2;
							}
							goto IL_03af;
							IL_03af:
							switch (num6)
							{
							default:
								goto end_IL_038a;
							case 1:
								break;
							case 0:
								goto end_IL_038a;
							case 2:
								goto end_IL_038a;
							}
							goto IL_03c5;
							end_IL_038a:;
						}
						break;
					case 1:
						break;
					}
				}
				catch (ReflectionTypeLoadException ex)
				{
					int num7 = 2;
					while (true)
					{
						switch (num7)
						{
						default:
							text2 = (string)AJ6eCihfnWjLC60sx0wi(DXCyuKhE2myPrbWWHu8M(0x12441CA4 ^ 0x12472DF0), l2kem6hfkakMvFnQHapv(assembly), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AC8043), text);
							num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num7 = 0;
							}
							break;
						case 1:
							UBkMgyhfQTI6aVNvhRiu(ylU8LMhENJ3no4g00OBs(), text2, ex);
							num7 = 3;
							break;
						case 2:
							text = (string)oyOQABhfT9E9uhgPKR45(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939586406), ((IEnumerable<Exception>)VNt3C8hfXEX8VlqqbNII(ex)).Select((Exception e) => e.ToString()).ToArray());
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
							{
								num7 = 0;
							}
							break;
						case 3:
							throw;
						}
					}
				}
				break;
			}
			num8++;
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
			{
				num2 = 3;
			}
		}
	}

	private void BuildDynamicModelAssembly(NHManagerRegisterParams parameters)
	{
		//Discarded unreachable code: IL_0295, IL_02a4, IL_02b4, IL_02e4, IL_037a, IL_03bd, IL_041c, IL_0475, IL_04ad, IL_04bc, IL_0505, IL_05e9, IL_060f, IL_06ee, IL_06fd, IL_070d, IL_071c, IL_08d0, IL_08df, IL_094c, IL_095b
		int num = 29;
		string text = default(string);
		bool flag = default(bool);
		AssemblyModelsMetadata assemblyModelsMetadata2 = default(AssemblyModelsMetadata);
		AssemblyModelsMetadata value = default(AssemblyModelsMetadata);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		ICollection<EntityMetadata> collection = default(ICollection<EntityMetadata>);
		_003C_003Ec__DisplayClass55_0 _003C_003Ec__DisplayClass55_ = default(_003C_003Ec__DisplayClass55_0);
		MemoryStream memoryStream = default(MemoryStream);
		List<AssemblyModelsMetadata> list = default(List<AssemblyModelsMetadata>);
		AssemblyModelsMetadata assemblyModelsMetadata = default(AssemblyModelsMetadata);
		MemoryStream memoryStream2 = default(MemoryStream);
		DynamicModelAssemblyBuilder dynamicModelAssemblyBuilder = default(DynamicModelAssemblyBuilder);
		Assembly assembly2 = default(Assembly);
		Assembly assembly = default(Assembly);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num7;
				switch (num2)
				{
				case 11:
					if (zucfSrhEMNClQwH8Outc(text))
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 61;
						}
						continue;
					}
					goto case 26;
				case 25:
					flag = true;
					num2 = 12;
					continue;
				case 19:
					if (assemblyModelsMetadata2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 60;
				case 34:
					if (!flag)
					{
						num2 = 42;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 1;
				case 4:
					if (!_asmModelsMetadataDict.TryGetValue((string)DXCyuKhE2myPrbWWHu8M(-97972138 ^ -97969614), out value))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 56;
				case 31:
					flag = assemblyModelsMetadata2 == null;
					num2 = 50;
					continue;
				case 57:
					metadataServiceContext = new MetadataServiceContext(new ConfigurationModelBuilderMetadataService(Locator.GetServiceNotNull<IMetadataRuntimeService>(), collection));
					num2 = 38;
					continue;
				case 5:
					_003C_003Ec__DisplayClass55_.newAssemblyModels = _asmModelsMetadataDict.Values;
					num2 = 2;
					continue;
				case 14:
				case 22:
					if (assemblyModelsMetadata2 == null)
					{
						num2 = 15;
						continue;
					}
					goto case 16;
				case 48:
					memoryStream = assemblyModelsMetadata2.DocumentationRawStream;
					num2 = 45;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 55;
					}
					continue;
				case 59:
					Locator.GetServiceNotNull<IModelAssemblyBuilderHandler>().DynamicModelAssemblyBuilt(collection);
					num2 = 51;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 13;
					}
					continue;
				case 23:
					memoryStream = (MemoryStream)EfHg8RhElrHjJPIViysi(assemblyModelsMetadata2);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 53;
					}
					continue;
				case 47:
					if (memoryStream != null)
					{
						num2 = 27;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 17;
				case 41:
					if (list.Count > 0)
					{
						num2 = 25;
						continue;
					}
					goto case 12;
				case 44:
					assemblyModelsMetadata = null;
					num2 = 37;
					continue;
				case 26:
					Directory.CreateDirectory(text);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 43;
					}
					continue;
				case 38:
					try
					{
						IStartInformation startInformation = (IStartInformation)uGTM6NhEP1WTivFv8sgr(39.0, SR.M((string)DXCyuKhE2myPrbWWHu8M(0x1DE3DD89 ^ 0x1DE0EF47)));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						default:
							try
							{
								memoryStream2 = dynamicModelAssemblyBuilder.BuildAssemblyToStream(_003C_003Ec__DisplayClass55_._003CBuildDynamicModelAssembly_003Eb__7);
								int num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
								{
									num4 = 1;
								}
								while (true)
								{
									switch (num4)
									{
									case 1:
										memoryStream = (MemoryStream)CX5PulhfDoGDrQDPxsdG(dynamicModelAssemblyBuilder);
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
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
							finally
							{
								if (startInformation != null)
								{
									int num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
									{
										num5 = 1;
									}
									while (true)
									{
										switch (num5)
										{
										case 1:
											khgNxJhE13keHsOYC8wd(startInformation);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
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
						}
					}
					finally
					{
						if (metadataServiceContext != null)
						{
							int num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									khgNxJhE13keHsOYC8wd(metadataServiceContext);
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
									{
										num6 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 59;
				case 29:
					_003C_003Ec__DisplayClass55_ = new _003C_003Ec__DisplayClass55_0();
					num2 = 28;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 20;
					}
					continue;
				case 13:
					num7 = (_modelAssemblies.Any(_003C_003Ec__DisplayClass55_._003CBuildDynamicModelAssembly_003Eb__2) ? 1 : 0);
					goto IL_09dd;
				case 16:
					memoryStream2 = (MemoryStream)RK4bCNhE0d4G5UHXWjRX(assemblyModelsMetadata2);
					num2 = 23;
					continue;
				case 33:
					_003C_003Ec__DisplayClass55_.dynamicPublicationService = Locator.GetServiceNotNull<IDynamicPublicationService>();
					num = 34;
					break;
				case 40:
					text = (string)M4Bho7hEylM5d6QSLLKm(dYKhTQhEmRiOvikgv19S(ComponentManager.Current), DXCyuKhE2myPrbWWHu8M(-35995181 ^ -36008783));
					num2 = 11;
					continue;
				case 37:
					collection = null;
					num2 = 54;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 43;
					}
					continue;
				case 50:
					_003C_003Ec__DisplayClass55_.applicationStartCache = (ApplicationStartCache)Sy81uGhfeIrcBD4lpNhc(Locator.GetServiceNotNull<IRuntimeApplication>());
					num2 = 33;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass55_.oldAssemblyModels = _previousAsmModelsMetadataList;
					num2 = 30;
					continue;
				default:
					assemblyModelsMetadata = null;
					num2 = 20;
					continue;
				case 8:
					dynamicModelAssemblyBuilder.RegisterTypes(DynamicModelAssemblyBuilder.GetAutoImplementTypes());
					num2 = 24;
					continue;
				case 46:
					if (!nXhtpehf2rXE0fovMO40(assembly2, null))
					{
						num2 = 39;
						continue;
					}
					goto case 45;
				case 58:
					if (rhfAaIhfaKlXCrPZMiP7(collection) > 0)
					{
						num2 = 57;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 27;
						}
						continue;
					}
					goto case 15;
				case 36:
					DynamicModelAssemblyBuilder.SaveDocumentation(memoryStream, text);
					num2 = 17;
					continue;
				case 27:
					if (xq8EYQhErJrawiw2AFnv(memoryStream) > 0)
					{
						num2 = 36;
						continue;
					}
					goto case 17;
				case 15:
				case 51:
				case 53:
				case 55:
					if (memoryStream2 != null)
					{
						num2 = 40;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					return;
				case 9:
					dynamicModelAssemblyBuilder = new DynamicModelAssemblyBuilder(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488879643));
					num2 = 4;
					continue;
				case 7:
				case 10:
					memoryStream2 = (MemoryStream)RK4bCNhE0d4G5UHXWjRX(assemblyModelsMetadata2);
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 48;
					}
					continue;
				case 17:
					assembly = ComponentManager.LoadAssembly(memoryStream2, null);
					num2 = 21;
					continue;
				case 21:
					AEtwtkhfWC0U0uEK8v85(Sts3SxhEijg8pQXRUhEn(), assembly);
					num2 = 32;
					continue;
				case 54:
					if (!flag)
					{
						num = 14;
						break;
					}
					goto case 9;
				case 60:
					if (!XTGhC3hfp93ohNu6VfIJ(dynamicModelAssemblyBuilder))
					{
						num = 10;
						break;
					}
					goto default;
				case 3:
				case 6:
					dynamicModelAssemblyBuilder.RegisterTypes(DynamicModelAssemblyBuilder.GetEntityInterfaceTypes());
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 5;
					}
					continue;
				case 12:
					memoryStream2 = null;
					num2 = 52;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 43;
					}
					continue;
				case 30:
				{
					List<AssemblyModelsMetadata> list2 = _003C_003Ec__DisplayClass55_.newAssemblyModels.Where(_003C_003Ec__DisplayClass55_._003CBuildDynamicModelAssembly_003Eb__3).ToList();
					list = _003C_003Ec__DisplayClass55_.oldAssemblyModels.Where(_003C_003Ec__DisplayClass55_._003CBuildDynamicModelAssembly_003Eb__4).ToList();
					if (tG1UTShfNT8wvqKuxjPr(list2) <= 0)
					{
						num2 = 41;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 25;
				}
				case 20:
					collection = dynamicModelAssemblyBuilder.GetImplementationMetadataList();
					num2 = 58;
					continue;
				case 1:
					BVq164hf129OL8G4SE5i(_003C_003Ec__DisplayClass55_.applicationStartCache, Bmp32thEA1hdepj1Chu9(_003C_003Ec__DisplayClass55_.dynamicPublicationService));
					num2 = 5;
					continue;
				case 45:
					AEtwtkhfWC0U0uEK8v85(Sts3SxhEijg8pQXRUhEn(), assembly2);
					num2 = 18;
					continue;
				case 42:
					if (e2ZmhihfP8jeVLp8mMmq(_003C_003Ec__DisplayClass55_.applicationStartCache) == _003C_003Ec__DisplayClass55_.dynamicPublicationService.Enable)
					{
						num2 = 13;
						continue;
					}
					num7 = 1;
					goto IL_09dd;
				case 49:
					return;
				case 56:
					dynamicModelAssemblyBuilder.RegisterConfigurationMetadataList((IEnumerable<IMetadata>)iJYS7ihf397WGdKkIr4t(value));
					num2 = 6;
					continue;
				case 52:
					memoryStream = null;
					num2 = 44;
					continue;
				case 18:
					Init(parameters, new Assembly[1] { assembly2 });
					num2 = 35;
					continue;
				case 43:
				case 61:
					IOExtensions.WriteAllBytesWithAttempts(Path.Combine(text, (string)DXCyuKhE2myPrbWWHu8M(-583745292 ^ -583758476)), memoryStream2, de1BAwhft2mQC7GHpLeG(1.0), SR.GetSetting(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561150694), 30));
					num = 47;
					break;
				case 28:
					assembly2 = ((IEnumerable<Assembly>)Wr7pl5hfOil7UYrISmCf()).FirstOrDefault((Assembly a) => _003C_003Ec.BoYxRTCgrm7g1xF6DCUf(ComponentManager.GetAssemblyShortName(a), _003C_003Ec.JoOdLdCgdlyxJl4cN6px(0x3C5338FF ^ 0x3C5332D1)));
					num2 = 46;
					continue;
				case 35:
					return;
				case 39:
					assemblyModelsMetadata2 = _previousAsmModelsMetadataList.FirstOrDefault((AssemblyModelsMetadata a) => _003C_003Ec.BoYxRTCgrm7g1xF6DCUf(a.Name, _003C_003Ec.JoOdLdCgdlyxJl4cN6px(0x63ABA4E8 ^ 0x63ABAEC6)));
					num = 31;
					break;
				case 24:
					dynamicModelAssemblyBuilder.PreviousAssemblyRawStream = (MemoryStream)((assemblyModelsMetadata2 != null) ? RK4bCNhE0d4G5UHXWjRX(assemblyModelsMetadata2) : null);
					num2 = 19;
					continue;
				case 32:
					{
						Init(parameters, new Assembly[1] { assembly }, (assemblyModelsMetadata == null) ? null : new AssemblyModelsMetadata[1] { assemblyModelsMetadata }, new MemoryStream[1] { memoryStream });
						num2 = 49;
						continue;
					}
					IL_09dd:
					flag = (byte)num7 != 0;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	internal void RegisterEntityManagers(NHManagerRegisterParams parameters, IList<Assembly> assemblies)
	{
		_003C_003Ec__DisplayClass56_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass56_0();
		CS_0024_003C_003E8__locals0.assemblies = assemblies;
		DateTime now = DateTime.Now;
		Type typeFromHandle = typeof(IEntityManager<>);
		IEnumerable<Type> enumerable = ComponentManager.Current.GetExtensionPointTypes(typeFromHandle).Where(delegate(Type t)
		{
			//Discarded unreachable code: IL_0041, IL_0050
			int num5 = 2;
			int num6 = num5;
			while (true)
			{
				switch (num6)
				{
				default:
					return CS_0024_003C_003E8__locals0.assemblies.Contains(t.Assembly);
				case 1:
					return true;
				case 2:
					if (CS_0024_003C_003E8__locals0.assemblies == null)
					{
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num6 = 1;
						}
						break;
					}
					goto default;
				}
			}
		});
		Dictionary<Type, Type> dictionary = new Dictionary<Type, Type>();
		foreach (Type item in enumerable)
		{
			if (item.IsGenericTypeDefinition)
			{
				continue;
			}
			Type @interface = item.GetInterface(typeFromHandle.FullName);
			if (@interface != null && @interface.IsGenericType && !@interface.IsGenericTypeDefinition && @interface.GetGenericTypeDefinition() == typeFromHandle)
			{
				Type type = @interface.GetGenericArguments()[0];
				EntityMetadataTypeAttribute attribute = AttributeHelper<EntityMetadataTypeAttribute>.GetAttribute(type, inherited: false);
				if (attribute != null && attribute.Type == EntityMetadataType.InterfaceExtension && item.GetInterface(typeof(IEntityExtensionManager<, , >).FullName) == null)
				{
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939586686)), typeof(IEntityExtensionManager<, , >).FullName));
				}
				dictionary[type] = item;
			}
		}
		foreach (Type item2 in from t in ComponentManager.Current.GetExtensionPointTypes(typeof(IEntity)).Where(delegate(Type t)
			{
				//Discarded unreachable code: IL_0066, IL_0075
				int num3 = 2;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						return CS_0024_003C_003E8__locals0.assemblies.Contains(t.Assembly);
					case 1:
						return true;
					case 2:
						if (CS_0024_003C_003E8__locals0.assemblies == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
							{
								num4 = 1;
							}
							break;
						}
						goto default;
					}
				}
			})
			where !t.ContainsGenericParameters
			select t)
		{
			CreateTypeDefaultManager(item2, dictionary);
		}
		Logger.Log.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939586796), (int)(DateTime.Now - now).TotalMilliseconds));
		now = DateTime.Now;
		RegisterEntityManagerTypesInIoc(dictionary, parameters.Builder);
		Logger.Log.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECD60EA), (int)(DateTime.Now - now).TotalMilliseconds, dictionary.Count));
		now = DateTime.Now;
		foreach (Type item3 in from t in ComponentManager.Current.GetExtensionPointTypes(typeof(IManager)).Where(delegate(Type t)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (CS_0024_003C_003E8__locals0.assemblies == null)
						{
							return true;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 0;
						}
						break;
					default:
						return CS_0024_003C_003E8__locals0.assemblies.Contains(t.Assembly);
					}
				}
			})
			where !t.ContainsGenericParameters
			select t)
		{
			IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> val = RegistrationExtensions.RegisterType(parameters.Builder, item3);
			val.As(new Type[1] { item3 });
			ComponentManager.Current.SetupInterceptors(item3, val);
			TryRegisterAsEntityManager<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(val, item3);
		}
		Logger.Log.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867880932), (int)(DateTime.Now - now).TotalMilliseconds));
	}

	private void CreateTypeDefaultManager(Type entityType, Dictionary<Type, Type> entityManagerTypesMap)
	{
		if (entityManagerTypesMap == null)
		{
			entityManagerTypesMap = new Dictionary<Type, Type>();
		}
		if (entityManagerTypesMap.ContainsKey(entityType))
		{
			return;
		}
		EntityMetadataTypeAttribute attribute = AttributeHelper<EntityMetadataTypeAttribute>.GetAttribute(entityType, inherited: false);
		ImplementationUidAttribute attribute2 = AttributeHelper<ImplementationUidAttribute>.GetAttribute(entityType, inherited: false);
		BaseClassAttribute attribute3 = AttributeHelper<BaseClassAttribute>.GetAttribute(entityType, inherited: false);
		Type typeByUid;
		if (attribute != null && attribute2 != null && attribute.Type == EntityMetadataType.InterfaceImplementation && (typeByUid = GetTypeByUid(attribute2.Uid, loadImplementation: false)) != null)
		{
			Type entityIdType = ModelHelper.GetEntityIdType(entityType);
			entityManagerTypesMap[entityType] = typeof(EntityImplManager<, , >).MakeGenericType(entityType, typeByUid, entityIdType);
			DefaultManagerAttribute attribute4 = AttributeHelper<DefaultManagerAttribute>.GetAttribute(entityType, inherited: true);
			if (attribute4 != null)
			{
				entityManagerTypesMap[entityType] = attribute4.GetManagerType(entityType);
			}
			return;
		}
		Type typeByUid2;
		if (attribute != null && attribute3 != null && attribute.Type == EntityMetadataType.InterfaceExtension && (typeByUid2 = GetTypeByUid(attribute3.BaseClassUid, loadImplementation: false)) != null)
		{
			Type entityIdType2 = ModelHelper.GetEntityIdType(entityType);
			entityManagerTypesMap[entityType] = typeof(EntityExtensionManager<, , >).MakeGenericType(typeByUid2, entityType, entityIdType2);
			return;
		}
		DefaultManagerAttribute attribute5 = AttributeHelper<DefaultManagerAttribute>.GetAttribute(entityType, inherited: true);
		if (attribute5 == null && entityType.IsInterface)
		{
			Type type = null;
			foreach (Type item in from intf in entityType.GetInterfaces()
				where AttributeHelper<DefaultManagerAttribute>.GetAttribute(intf, inherited: false) != null
				select intf)
			{
				if (type == null || type.IsAssignableFrom(item))
				{
					type = item;
				}
			}
			if (type != null)
			{
				attribute5 = AttributeHelper<DefaultManagerAttribute>.GetAttribute(type, inherited: false);
			}
		}
		if (attribute5 != null)
		{
			Type managerType = attribute5.GetManagerType(entityType);
			if (managerType != null)
			{
				entityManagerTypesMap[entityType] = managerType;
			}
		}
	}

	private static IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> TryRegisterAsEntityManager<TLimit, TActivatorData, TRegistrationStyle>(IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> registrar, Type managerType)
	{
		List<Type> list = new List<Type>();
		list.AddRange(managerType.GetInterfaces());
		if (list.Count > 0)
		{
			RegistrationExtensions.PropertiesAutowired<TLimit, TActivatorData, TRegistrationStyle>(registrar.As(list.ToArray()), (PropertyWiringOptions)1);
		}
		registrar.SetScope<TLimit, TActivatorData, TRegistrationStyle>(ServiceScope.Application);
		return registrar;
	}

	private void RegisterTypeDescriptors(IList<Assembly> assemblies)
	{
		foreach (ITypeDescriptor extensionPoint in ComponentManager.Current.GetExtensionPoints<ITypeDescriptor>())
		{
			if (assemblies == null || assemblies.Contains(extensionPoint.GetType().Assembly))
			{
				_typeDescriptorsByUid[(extensionPoint.Uid, extensionPoint.SubTypeUid)] = extensionPoint;
				if (extensionPoint is IRuntimeTypeDescriptor runtimeTypeDescriptor && runtimeTypeDescriptor.IsRuntimeType)
				{
					_typeDescriptorsByType[runtimeTypeDescriptor.RuntimeType] = extensionPoint;
				}
			}
		}
	}

	private Dictionary<Guid, Type> GetPartTypes(ICompositeMetadata metadata)
	{
		Dictionary<Guid, Type> dictionary = new Dictionary<Guid, Type>();
		if (metadata != null)
		{
			foreach (IMetadata compositePart in metadata.GetCompositeParts())
			{
				if (compositePart is ICodeItemMetadata && _typesByUid.TryGetValue(compositePart.Uid, out var value))
				{
					dictionary.Add(((ITablePartMetadata)compositePart).TablePartPropertyUid, value);
				}
				dictionary.AddRange(GetPartTypes(compositePart as ICompositeMetadata));
			}
			return dictionary;
		}
		return dictionary;
	}

	private void RegisterDeltaTypes(ISet<Type> deltaTypes, ISet<Type> newTypesToRegister)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		_003C_003Ec__DisplayClass61_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass61_0();
		CS_0024_003C_003E8__locals0.deltaTypes = deltaTypes;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		publishLogger.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571D973D));
		_removedTypes.Where((KeyValuePair<Guid, Type> p) => !CS_0024_003C_003E8__locals0.deltaTypes.Contains(p.Value)).ForEach(delegate(KeyValuePair<Guid, Type> p)
		{
			publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309396148), p.Value.AssemblyQualifiedName);
			CS_0024_003C_003E8__locals0._003C_003E4__this.LoadMetadataInternal(p.Value);
		});
		_removedTypes.Clear();
		if (CS_0024_003C_003E8__locals0.deltaTypes.Count == 0)
		{
			return;
		}
		lock (registeredTypes)
		{
			bool flag = false;
			ContainerBuilder val = new ContainerBuilder();
			publishLogger.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671940105));
			foreach (Type item in newTypesToRegister)
			{
				if (((!item.IsAbstract && item.IsClass) || item.IsInterface || (item.IsValueType && !item.IsEnum)) && !item.ContainsGenericParameters && ComponentManager.Current.IsComponentType(item))
				{
					flag = true;
					ComponentManager.Current.ProcessComponent(item, null, val, (ServiceScope? _) => false);
				}
				if (!item.IsAbstract && item.IsClass && !item.ContainsGenericParameters && ComponentManager.Current.IsServiceType(item))
				{
					flag = true;
					ComponentManager.Current.ProcessService(item, val, (ServiceScope? _) => false);
				}
			}
			foreach (Type deltaType in CS_0024_003C_003E8__locals0.deltaTypes)
			{
				if (deltaType.IsAbstract || !deltaType.IsClass || deltaType.ContainsGenericParameters)
				{
					continue;
				}
				object[] reflectionCustomAttributes = deltaType.GetReflectionCustomAttributes(typeof(ImplementAttribute), inherit: false);
				if (reflectionCustomAttributes.Length != 0)
				{
					flag = true;
					RegistrationExtensions.RegisterType(val, deltaType).As(new Type[1] { deltaType }).As((from ImplementAttribute a in reflectionCustomAttributes
						select _003C_003Ec.fTn7vIC5buHK5LjD1oRs(a)).ToArray());
					object[] array = reflectionCustomAttributes;
					for (int i = 0; i < array.Length; i++)
					{
						ImplementAttribute implementAttribute = (ImplementAttribute)array[i];
						ComponentManager.Current.AddToExtensionPointTypesMap(implementAttribute.InterfaceType, deltaType);
					}
				}
				else if (newTypesToRegister.Contains(deltaType) && deltaType.GetReflectionCustomAttributes(typeof(EntityAttribute), inherit: false).Length != 0)
				{
					flag = true;
					RegistrationExtensions.RegisterType(val, deltaType).As(new Type[1] { deltaType });
				}
			}
			publishLogger.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675304277));
			Dictionary<Type, Type> dictionary = new Dictionary<Type, Type>();
			foreach (Type item2 in newTypesToRegister.Where(delegate(Type t)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return TypeOf<IEntity>.Raw.IsAssignableFrom(t);
					case 1:
						if (t.ContainsGenericParameters)
						{
							return false;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}))
			{
				CreateTypeDefaultManager(item2, dictionary);
			}
			if (dictionary.Count > 0)
			{
				flag = true;
				RegisterEntityManagerTypesInIoc(dictionary, val);
			}
			publishLogger.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A616D4));
			RegisterTypeMapByMetadata(CS_0024_003C_003E8__locals0.deltaTypes);
			if (flag)
			{
				publishLogger.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A4D68A));
				UpdateIoC(val);
			}
		}
		publishLogger.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787261261));
	}

	private void UpdateIoC(ContainerBuilder updater)
	{
		//Discarded unreachable code: IL_0055, IL_00b3, IL_00d2, IL_00e1, IL_00fe
		int num = 2;
		int num2 = num;
		IContainer obj = default(IContainer);
		bool lockTaken = default(bool);
		IContainer serviceNotNull = default(IContainer);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 3:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						}
						QI4ba9hfwsCMmvuax3P0(updater, serviceNotNull);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num3 = 1;
						}
					}
				}
				finally
				{
					int num4;
					if (!lockTaken)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num4 = 1;
						}
						goto IL_00b7;
					}
					goto IL_00ec;
					IL_00ec:
					Monitor.Exit(obj);
					num4 = 2;
					goto IL_00b7;
					IL_00b7:
					switch (num4)
					{
					case 1:
						goto end_IL_0092;
					case 2:
						goto end_IL_0092;
					}
					goto IL_00ec;
					end_IL_0092:;
				}
			case 2:
				serviceNotNull = Locator.GetServiceNotNull<IContainer>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				obj = serviceNotNull;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				lockTaken = false;
				num2 = 3;
				break;
			}
		}
	}

	private void RegisterEntityManagerTypesInIoc(Dictionary<Type, Type> entityManagerTypesMap, ContainerBuilder updater)
	{
		foreach (KeyValuePair<Type, Type> item in entityManagerTypesMap)
		{
			IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> val = RegistrationExtensions.RegisterType(updater, item.Value);
			val.As(new Type[1] { item.Value });
			if (item.Value.GetGenericArguments().Length != 3 || item.Value.GetGenericTypeDefinition() != typeof(EntityImplManager<, , >))
			{
				ComponentManager.Current.SetupInterceptors(item.Value, val);
			}
			TryRegisterAsEntityManager<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(val, item.Value);
		}
	}

	private static Type GetClassMapType(Type type)
	{
		//Discarded unreachable code: IL_0045, IL_007d, IL_008c, IL_0135, IL_0171, IL_017d, IL_018c
		Type result = default(Type);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				ClassMapAttribute attribute = AttributeHelper<ClassMapAttribute>.GetAttribute(type, inherited: false);
				int num;
				if (attribute == null)
				{
					num = 2;
					goto IL_0049;
				}
				object obj = attribute.MapType;
				goto IL_00db;
				IL_0049:
				Type type2 = default(Type);
				while (true)
				{
					switch (num)
					{
					case 1:
						return result;
					default:
						type2 = null;
						num = 5;
						continue;
					case 4:
						if (TypeOf<IConformistHoldersProvider>.Raw.IsAssignableFrom(type2))
						{
							num = 3;
							continue;
						}
						goto default;
					case 3:
					case 5:
						result = type2;
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num = 1;
						}
						continue;
					case 2:
						break;
					}
					break;
				}
				obj = null;
				goto IL_00db;
				IL_00db:
				type2 = (Type)obj;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num = 3;
				}
				goto IL_0049;
			}
			catch (FileNotFoundException ex)
			{
				if (eOsjDphf4p3AjPuLK26i(ex.FileName, DXCyuKhE2myPrbWWHu8M(-70007027 ^ -70192867)))
				{
					int num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							return result;
						default:
							result = null;
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
							{
								num2 = 0;
							}
							continue;
						case 2:
							break;
						}
						break;
					}
				}
				throw;
			}
		}
	}

	protected override ushort GetDbLicenseCount()
	{
		return 0;
	}

	string ILicensedUnit.GetRegistrationKey()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				InitLicense();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return registrationKey;
			}
		}
	}

	void ILicensedUnit.ApplyActivationKey(string key)
	{
		//Discarded unreachable code: IL_00de, IL_00e8, IL_0111, IL_0120, IL_0145, IL_01a6, IL_02eb, IL_031e, IL_032d
		int num = 10;
		LicenseStatus status = default(LicenseStatus);
		ushort licCount = default(ushort);
		ushort privilegeLicCount = default(ushort);
		DateTime? expirationDate = default(DateTime?);
		byte licType = default(byte);
		byte licSubType = default(byte);
		DateTime? expirationDate2 = default(DateTime?);
		ushort licCount2 = default(ushort);
		byte licType2 = default(byte);
		byte licSubType2 = default(byte);
		byte b = default(byte);
		byte b2 = default(byte);
		ushort privilegeLicCount2 = default(ushort);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				int num4;
				switch (num2)
				{
				default:
					return;
				case 14:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType, licSubType);
					num2 = 18;
					continue;
				case 29:
					if (licType == 2)
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto IL_0178;
				case 24:
					num3 = licType;
					goto IL_037f;
				case 21:
					return;
				case 20:
					if (!expirationDate2.HasValue)
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 25:
					if (licCount == licCount2)
					{
						num2 = 12;
						continue;
					}
					return;
				case 16:
					num4 = licType2;
					break;
				case 26:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType, licSubType);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					return;
				case 19:
					return;
				case 17:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType, licSubType);
					num2 = 27;
					continue;
				case 7:
					return;
				case 2:
					if (licType != 2)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 24;
						}
						continue;
					}
					num3 = 1;
					goto IL_037f;
				case 22:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType, licSubType);
					num2 = 3;
					continue;
				case 13:
				case 28:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType, licSubType);
					num2 = 6;
					continue;
				case 15:
					if (expirationDate.HasValue)
					{
						num2 = 20;
						continue;
					}
					goto IL_0178;
				case 11:
					return;
				case 5:
					if (licSubType <= licSubType2)
					{
						num2 = 4;
						continue;
					}
					goto case 17;
				case 8:
					if (b >= b2)
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 26;
				case 30:
					if (licType2 != 2)
					{
						num2 = 16;
						continue;
					}
					num4 = 1;
					break;
				case 27:
					return;
				case 4:
					if (licSubType >= licSubType2)
					{
						if (licType != 1)
						{
							num2 = 29;
							continue;
						}
						goto case 15;
					}
					num2 = 7;
					continue;
				case 10:
					InitLicense();
					num2 = 9;
					continue;
				case 12:
					if (privilegeLicCount <= privilegeLicCount2)
					{
						num2 = 21;
						continue;
					}
					goto case 22;
				case 0:
					return;
				case 23:
					if (b > b2)
					{
						return;
					}
					num2 = 5;
					continue;
				case 3:
					return;
				case 9:
					if (DecodeActivationKey(key, out status, out licCount, out privilegeLicCount, out licType, out licSubType, out expirationDate))
					{
						if (lastAppliedActKey == null)
						{
							num2 = 14;
							continue;
						}
						DecodeActivationKey(lastAppliedActKey, out var _, out licCount2, out privilegeLicCount2, out licType2, out licSubType2, out expirationDate2);
						num2 = 2;
					}
					else
					{
						num2 = 19;
					}
					continue;
				case 1:
					if (gqLemFhETc963syN82Z2(expirationDate.Value, expirationDate2.Value))
					{
						num2 = 13;
						continue;
					}
					goto IL_0178;
				case 18:
					return;
					IL_0178:
					if (licCount <= licCount2)
					{
						num2 = 25;
						continue;
					}
					goto case 22;
					IL_037f:
					b = (byte)num3;
					num2 = 30;
					continue;
				}
				b2 = (byte)num4;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 8;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 28;
		}
	}

	void ILicensedUnit.CompleteLicensingInitialize()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				InitLicense();
				num2 = 2;
				break;
			case 2:
				licensingInitialized = true;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				initializedStatus = pqimPUhf6YWUW2yVLWik(licenseInfo);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	ILicenseInfo ILicensedUnit.GetLicenseInfo()
	{
		//Discarded unreachable code: IL_0097, IL_00c8, IL_011b, IL_012a
		int num = 1;
		int num2 = num;
		ushort dbLicenseCount = default(ushort);
		WorkplaceLicenseInfo workplaceLicenseInfo = default(WorkplaceLicenseInfo);
		uint? workplaceCount = default(uint?);
		while (true)
		{
			switch (num2)
			{
			case 12:
				dbLicenseCount = GetDbLicenseCount();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 8;
				}
				break;
			case 1:
				InitLicense();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				if (dbLicenseCount <= 0)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 2;
			case 6:
			case 7:
				workplaceLicenseInfo.WorkplaceCount = dbLicenseCount;
				num2 = 3;
				break;
			case 3:
			case 9:
			case 11:
				return licenseInfo;
			case 4:
			{
				ushort num3 = dbLicenseCount;
				workplaceCount = workplaceLicenseInfo.WorkplaceCount;
				if (num3 < workplaceCount.Value)
				{
					num2 = 6;
					break;
				}
				goto case 3;
			}
			case 10:
				if (!workplaceCount.HasValue)
				{
					num2 = 7;
					break;
				}
				goto case 4;
			case 2:
				workplaceCount = workplaceLicenseInfo.WorkplaceCount;
				num2 = 10;
				break;
			default:
				workplaceLicenseInfo = licenseInfo;
				num2 = 5;
				break;
			case 5:
				if (workplaceLicenseInfo == null)
				{
					num2 = 11;
					break;
				}
				goto case 12;
			}
		}
	}

	void ILicensedUnit.UpdateLicenseInfo()
	{
		int num = 3;
		int num2 = num;
		LicenseStatus status = default(LicenseStatus);
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				DecodeActivationKey(lastAppliedActKey, out status, out var _, out var _, out var _, out var _, out var _);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
				licenseInfo.Status = status;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			case 3:
				InitLicense();
				num2 = 2;
				break;
			}
		}
	}

	byte[] ILicensedUnit.GetActivationToken()
	{
		return null;
	}

	ActivationToken IActivationTokenContainer.GetActivationToken()
	{
		return null;
	}

	private void InitLicense()
	{
		//Discarded unreachable code: IL_0095, IL_00d1, IL_00e0, IL_0179, IL_01a9, IL_01b8, IL_01c4, IL_01d3
		int num = 1;
		int num2 = num;
		bool lockTaken = default(bool);
		ModelRegistrarImpl modelRegistrarImpl = default(ModelRegistrarImpl);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				lockTaken = false;
				num2 = 4;
				break;
			case 0:
				return;
			case 2:
				return;
			case 1:
				if (!initialized)
				{
					modelRegistrarImpl = this;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 4:
				try
				{
					Monitor.Enter(modelRegistrarImpl, ref lockTaken);
					int num3 = 3;
					while (true)
					{
						switch (num3)
						{
						case 2:
							return;
						case 5:
							return;
						default:
							initialized = true;
							num3 = 5;
							continue;
						case 4:
						{
							ConcurrentLicenseInfo concurrentLicenseInfo = new ConcurrentLicenseInfo(this);
							CJ5OXGhfAjPy4RoqMw7D(concurrentLicenseInfo, LicenseStatus.NotActivated);
							licenseInfo = concurrentLicenseInfo;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						case 3:
							if (initialized)
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
								{
									num3 = 2;
								}
								continue;
							}
							break;
						case 1:
							break;
						}
						registrationKey = (string)D08CImhfHyXgSSwGlqMr(1);
						num3 = 4;
					}
				}
				finally
				{
					int num4;
					if (!lockTaken)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num4 = 0;
						}
						goto IL_017d;
					}
					goto IL_0193;
					IL_0193:
					CsYqvohf7XEKwOQ02YBd(modelRegistrarImpl);
					num4 = 2;
					goto IL_017d;
					IL_017d:
					switch (num4)
					{
					case 1:
						goto end_IL_0158;
					case 2:
						goto end_IL_0158;
					}
					goto IL_0193;
					end_IL_0158:;
				}
			}
		}
	}

	private static string GenerateRegistrationKey(ushort algorithm)
	{
		//Discarded unreachable code: IL_0157, IL_0166, IL_0176, IL_0185
		int num = 4;
		int num2 = num;
		string text = default(string);
		string text2 = default(string);
		uint hnH = default(uint);
		uint hnL = default(uint);
		while (true)
		{
			switch (num2)
			{
			default:
				if (text.Length >= 10)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 1;
			case 2:
			case 9:
				if (rPsUdMhfx5xoOjZloj6i(text2) >= 10)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 5;
			case 1:
				text = (string)tcbG00hE9RUI5mfHviBO(DXCyuKhE2myPrbWWHu8M(0x1ECE530A ^ 0x1ECE4C86), text);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				LicensedUnitBase.GHN(out hnH, out hnL);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				return (string)I4tox1hf0PCbTAyAnoup(tcbG00hE9RUI5mfHviBO(text2, text));
			case 3:
				text2 = hnH.ToString();
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 6;
				}
				break;
			case 5:
				text2 = (string)tcbG00hE9RUI5mfHviBO(DXCyuKhE2myPrbWWHu8M(0x1ECE530A ^ 0x1ECE4C86), text2);
				num2 = 9;
				break;
			case 8:
				text = hnL.ToString();
				num2 = 2;
				break;
			}
		}
	}

	private static string FormatKey(object key)
	{
		//Discarded unreachable code: IL_007c, IL_00b3, IL_00eb, IL_012f, IL_013e
		int num = 5;
		StringBuilder stringBuilder = default(StringBuilder);
		int num3 = default(int);
		char[] array = default(char[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return string.Empty;
				case 7:
					return stringBuilder.ToString();
				default:
					num3 = 0;
					num2 = 11;
					break;
				case 1:
				case 2:
				case 6:
					w9gn6chfyeFQwxgLoZ2p(stringBuilder, array[num3]);
					num2 = 14;
					break;
				case 10:
				case 11:
					if (num3 < array.Length)
					{
						num2 = 9;
						break;
					}
					goto case 7;
				case 13:
					w9gn6chfyeFQwxgLoZ2p(stringBuilder, '-');
					num2 = 6;
					break;
				case 8:
					if (num3 % 5 != 0)
					{
						num2 = 2;
						break;
					}
					goto case 13;
				case 12:
					array = (char[])ylLCqThfma6DuURpdN0j(key);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					if (key != null)
					{
						stringBuilder = new StringBuilder();
						num2 = 12;
						break;
					}
					goto end_IL_0012;
				case 3:
				case 9:
					if (num3 <= 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 8;
				case 14:
					num3++;
					num2 = 10;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	private bool DecodeLastActivationKey(out LicenseStatus status, out ushort licCount, out ushort privilegeLicCount, out byte licType, out byte licSubType, out DateTime? expirationDate)
	{
		return DecodeActivationKey(lastAppliedActKey, out status, out licCount, out privilegeLicCount, out licType, out licSubType, out expirationDate);
	}

	private bool DecodeActivationKey(string key, out LicenseStatus status, out ushort licCount, out ushort privilegeLicCount, out byte licType, out byte licSubType, out DateTime? expirationDate)
	{
		//Discarded unreachable code: IL_011b, IL_01a9, IL_01b8, IL_027b, IL_02d2
		int num = 6;
		uint hnH = default(uint);
		bool result = default(bool);
		ushort num6 = default(ushort);
		uint hnL = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					licSubType = 0;
					num2 = 9;
					continue;
				case 7:
					licType = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					licCount = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					expirationDate = null;
					num2 = 12;
					continue;
				default:
					return false;
				case 9:
					break;
				case 4:
					if (rPsUdMhfx5xoOjZloj6i(key) == 20)
					{
						num2 = 10;
						continue;
					}
					goto case 8;
				case 3:
					try
					{
						uint num3 = uint.Parse((string)tylfvfhfJi5EvwAF0dQr(key, 0, 10));
						uint num4 = kfGRYohf9CMyBJoUuVbJ(tylfvfhfJi5EvwAF0dQr(key, 10, 10));
						if (num3 == ~hnH)
						{
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								case 9:
									return result;
								case 10:
									licCount = num6;
									num5 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
									{
										num5 = 3;
									}
									continue;
								case 1:
									if (num4 == ~hnL)
									{
										num5 = 5;
										continue;
									}
									goto end_IL_011f;
								case 5:
									status = LicenseStatus.Activated;
									num5 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
									{
										num5 = 4;
									}
									continue;
								default:
									num6 = RpGkAahfdtIjA4x3Y64Y(this);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
									{
										num5 = 6;
									}
									continue;
								case 8:
									licCount = 65000;
									num5 = 4;
									continue;
								case 6:
									if (num6 > 0)
									{
										num5 = 3;
										continue;
									}
									break;
								case 3:
									if (num6 < licCount)
									{
										num5 = 10;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
										{
											num5 = 5;
										}
										continue;
									}
									break;
								case 4:
									licType = byte.MaxValue;
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
									{
										num5 = 0;
									}
									continue;
								case 7:
									break;
								case 2:
									goto end_IL_011f;
								}
								result = true;
								num5 = 9;
								continue;
								end_IL_011f:
								break;
							}
						}
					}
					catch (Exception ex)
					{
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num7 = 0;
						}
						while (true)
						{
							switch (num7)
							{
							default:
								UBkMgyhfQTI6aVNvhRiu(Logger.Log, DXCyuKhE2myPrbWWHu8M(0xA592A41 ^ 0xA5A1C77), ex);
								num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
								{
									num7 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 8;
				case 1:
					key = ((string)rrfTO6hfMDvqmf4gOhAx(rrfTO6hfMDvqmf4gOhAx(rrfTO6hfMDvqmf4gOhAx(key, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A67873), ""), DXCyuKhE2myPrbWWHu8M(-1146510045 ^ -1146491903), ""), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576145394), "")).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979245879), "").Replace((string)DXCyuKhE2myPrbWWHu8M(-889460160 ^ -889457180), "");
					num2 = 4;
					continue;
				case 8:
					status = LicenseStatus.NotActivated;
					num2 = 11;
					continue;
				case 6:
					InitLicense();
					num2 = 5;
					continue;
				case 10:
					LicensedUnitBase.GHN(out hnH, out hnL);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					if (key != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 8;
				}
				break;
			}
			privilegeLicCount = 0;
			num = 2;
		}
	}

	private void SetLastAppliedKey(string key, LicenseStatus newStatus, ushort newLicCount, ushort newPrivilegeCount, DateTime? newExpirationDate, byte newLicType, byte newSubType)
	{
		lastAppliedActKey = key;
		if (licensingInitialized && newStatus == LicenseStatus.Activated && initializedStatus != 0)
		{
			licenseInfo.Status = LicenseStatus.NeedRestart;
		}
		else
		{
			licenseInfo.Status = newStatus;
		}
		licenseInfo.LicenseType = newLicType;
		licenseInfo.IsConcurrent = newSubType == 1;
		licenseInfo.WorkplaceCount = ((newLicCount >= 65000) ? null : new uint?(newLicCount));
		licenseInfo.PrivilegeCount = ((newPrivilegeCount >= 65000) ? null : new uint?(newPrivilegeCount));
		licenseInfo.TrialExpiration = newExpirationDate;
	}

	public ModelRegistrarImpl()
	{
		//Discarded unreachable code: IL_01ad, IL_01b2
		Yx3YPghfl6nsek2iUuj1();
		_typesByUid = PublishCacheContext.CreateCache(delegate(IDictionary<Guid, Type> c, Type _, Guid uid)
		{
			c.Remove(uid);
		});
		_removedTypes = PublishCacheContext.CreateCache(delegate(IDictionary<Guid, Type> c, Type type, Guid uid)
		{
			if (!TypeOf<IEntityFilter>.Raw.IsAssignableFrom(type))
			{
				c[uid] = type;
			}
		});
		_metadataList = PublishCacheContext.CreateCache(delegate(IDictionary<Guid, IMetadata> c, Type _, Guid uid)
		{
			c.Remove(uid);
		});
		_metadataParents = PublishCacheContext.CreateCache(delegate(IDictionary<Guid, IMetadata> c, Type _, Guid uid)
		{
			c.Remove(uid);
		});
		_asmModelsMetadataDict = PublishCacheContext.CreateCache<string, AssemblyModelsMetadata>(delegate
		{
		});
		configUids = PublishCacheContext.CreateCache((ISet<Guid> c) => new HashSet<Guid>(c));
		_modelAssemblies = new List<Assembly>();
		_typeDescriptorsByUid = new Dictionary<(Guid, Guid), ITypeDescriptor>();
		_typeDescriptorsByType = new Dictionary<Type, ITypeDescriptor>();
		registeredTypes = new HashSet<Type>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ModelRegistrarImpl()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				securityAssemblyUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099551987));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Yx3YPghfl6nsek2iUuj1();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				publishLogger = (ILogger)KnONIkhfrALglGWycAdB(DXCyuKhE2myPrbWWHu8M(-2106517564 ^ -2106456060));
				num2 = 3;
				break;
			}
		}
	}

	internal static object Sts3SxhEijg8pQXRUhEn()
	{
		return ComponentManager.Current;
	}

	internal static object X95t0nhERmiTkRBTIGSO(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static object fTxXPfhEqYpAM5v2up7W(object P_0, Guid uid)
	{
		return ((IModuleManager)P_0).FindUnitByUid(uid);
	}

	internal static object LBmBFrhEKAAtgIukDOCQ(object P_0)
	{
		return ((ILicensedModuleAssembly)P_0).LicenseUnit;
	}

	internal static uint pG9VjJhEXu7I2ZLyhrZ3(object P_0)
	{
		return ((IWorkplaceLicenseInfoOwner)P_0).UsedLicenseCount;
	}

	internal static bool dNRqOvhEV0WY1pLZZ3cv()
	{
		return AooqRUhEIeI5n6Mpant1 == null;
	}

	internal static ModelRegistrarImpl nIKRVmhESm4OrmMkI7mO()
	{
		return AooqRUhEIeI5n6Mpant1;
	}

	internal static bool gqLemFhETc963syN82Z2(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static DateTime HwZMFShEk8CeWGj8sZKH()
	{
		return DateTime.Now;
	}

	internal static object da0jhhhEnHZHVHZn1IHW()
	{
		return PublishCacheContext.Create();
	}

	internal static object URcIOQhEOaIf6vKOwdeg(object P_0)
	{
		return ((IRuntimeApplication)P_0).DbPreUpdater;
	}

	internal static object DXCyuKhE2myPrbWWHu8M(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object hgIkSShEeHFSirvB1wg6(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static object uGTM6NhEP1WTivFv8sgr(double completePercent, object P_1)
	{
		return StartInformation.Operation(completePercent, (string)P_1);
	}

	internal static void khgNxJhE13keHsOYC8wd(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object ylU8LMhENJ3no4g00OBs()
	{
		return Logger.Log;
	}

	internal static TimeSpan hB6xcphE3RLmeOMZs7uV(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static object VprG0OhEpIdm4mYL18WY(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static void V9eqT4hEaFyxG5KTYqNU(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static bool W2VonghEDp1sNQp329ks(object P_0)
	{
		return ((DbPreUpdater)P_0).NeedRecompileConfigurationModel;
	}

	internal static void oaG8mUhEtGIqnr5HeLQN(object P_0, object P_1)
	{
		((DbPreUpdater)P_0).RecompileConfigurationModel((IMetadataRuntimeService)P_1);
	}

	internal static void NBV50xhEwZAEYM0FeJP0(object P_0)
	{
		((DbPreUpdater)P_0).DeletePreparedModelConfiguration();
	}

	internal static object E5fXP0hE4wBb7JxGRnsP(object P_0, object P_1)
	{
		return ((IEventHandlerSubscribeService)P_0).Subscribe((IEventHandler)P_1);
	}

	internal static void z5ygoDhE6VihNm5EdJHJ(object P_0)
	{
		((PublicationEventHandler)P_0).Wait();
	}

	internal static void WrFJrwhEH8iRcUc13Z7K(object P_0, object P_1)
	{
		((ILogger)P_0).Warn(P_1);
	}

	internal static bool Bmp32thEA1hdepj1Chu9(object P_0)
	{
		return ((IDynamicPublicationService)P_0).Enable;
	}

	internal static object efpZtQhE7Lpy90klgyZv()
	{
		return MetadataItemManager.Instance;
	}

	internal static int pwf3XNhExHw4JX2ZveYd(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static object RK4bCNhE0d4G5UHXWjRX(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).AssemblyRawStream;
	}

	internal static object dYKhTQhEmRiOvikgv19S(object P_0)
	{
		return ((ComponentManager)P_0).WorkDirectory;
	}

	internal static object M4Bho7hEylM5d6QSLLKm(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool zucfSrhEMNClQwH8Outc(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object OIrrekhEJr8xYG18WsJf(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).Name;
	}

	internal static object tcbG00hE9RUI5mfHviBO(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void wtBPlmhEdc7QFZsF41cb(object P_0, object P_1, TimeSpan interval, int attemptCount)
	{
		IOExtensions.WriteAllBytesWithAttempts((string)P_0, (Stream)P_1, interval, attemptCount);
	}

	internal static object EfHg8RhElrHjJPIViysi(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).DocumentationRawStream;
	}

	internal static long xq8EYQhErJrawiw2AFnv(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object Wl7JVPhEgcxNIjiA2Pl0(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).DebugRawStream;
	}

	internal static object gB9hkNhE52D7axtIfSwc(object P_0, object P_1)
	{
		return ComponentManager.LoadAssembly((MemoryStream)P_0, (MemoryStream)P_1);
	}

	internal static bool oHZ0mMhEjj8uA3MtknRU(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void MVVdaLhEY32cKChTO0gG(object P_0)
	{
		ConfigurationModelAssemblyBuilder.InitVersion((Assembly)P_0);
	}

	internal static bool tVofbYhELfbcXgg38gWJ(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object qGHMbhhEUpDZSh3FLHPo()
	{
		return Encoding.UTF8;
	}

	internal static object FiqTxthEsrhBCZS0r4kR(object P_0, object P_1)
	{
		return ((MemoryStream)P_0).AsString((Encoding)P_1);
	}

	internal static bool JilRh4hEcsSIxTlIWqPc(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static int kEYJxVhEzDx31dO7Kgu0(object P_0)
	{
		return ((List<Assembly>)P_0).Count;
	}

	internal static object mwAKgLhfFsefQerrPsaa()
	{
		return SR.KeyCultureInfo;
	}

	internal static void XWlIc9hfBJ2poxTt2OPq(object P_0, object P_1)
	{
		SR.RunWithCulture((CultureInfo)P_0, (Action)P_1);
	}

	internal static object AEtwtkhfWC0U0uEK8v85(object P_0, object P_1)
	{
		return ((ComponentManager)P_0).RegisterAssembly((Assembly)P_1);
	}

	internal static void krLxZlhfo1jHd6SdRGY3()
	{
		PublishCacheContext.Complete();
	}

	internal static Guid gFpNn3hfbtFM9pIpBFuP(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static bool nVCrBKhfhn5vgCsEkxNR(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool i1dslmhfGaIQV5V3IBJA(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Type wEt5wShfEa8qi4IyHtVr(object P_0, Guid uid)
	{
		return ((ITypeResolver)P_0).GetTypeByUid(uid);
	}

	internal static object w8YUuXhffKXZjDWEUk3K(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void UBkMgyhfQTI6aVNvhRiu(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static bool S1SdV4hfCSkBSyri1HPC(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static Type tqZmAZhfvGmcVTaD1kmJ(Type t)
	{
		return InterfaceActivator.TypeOf(t);
	}

	internal static Type HlH5dnhf8tQP4FsdRdNP(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Type Wtt178hfZpB8Q7bU4fpj(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetReflectionType((string)P_1);
	}

	internal static Type JlTCquhfumknDMrpTWlR(Type type)
	{
		return GetClassMapType(type);
	}

	internal static Type GbMhblhfIMgpeDmufJyX(object P_0, Type objectType)
	{
		return ((DefaultManagerAttribute)P_0).GetManagerType(objectType);
	}

	internal static object UqibHohfVovHU8xcqoov(object P_0)
	{
		return ((Assembly)P_0).GetTypes();
	}

	internal static bool Wsvw58hfSVmuBGiKAwiR(object P_0, object P_1)
	{
		return (ConstructorInfo)P_0 == (ConstructorInfo)P_1;
	}

	internal static object qWghdOhfiMb8tPkhytZn(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object ChOnXUhfRhH8rLUrxc4F(Type P_0)
	{
		return Expression.Parameter(P_0);
	}

	internal static object K82ELyhfq2fpNNBNuZ3L(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static object YHxmNOhfK9dsQZ1rwpgm(object P_0, object P_1)
	{
		return Expression.New((ConstructorInfo)P_0, (Expression[])P_1);
	}

	internal static object VNt3C8hfXEX8VlqqbNII(object P_0)
	{
		return ((ReflectionTypeLoadException)P_0).LoaderExceptions;
	}

	internal static object oyOQABhfT9E9uhgPKR45(object P_0, object P_1)
	{
		return string.Join((string)P_0, (string[])P_1);
	}

	internal static object l2kem6hfkakMvFnQHapv(object P_0)
	{
		return ((Assembly)P_0).FullName;
	}

	internal static object AJ6eCihfnWjLC60sx0wi(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static object Wr7pl5hfOil7UYrISmCf()
	{
		return ComponentManager.GetAssemblies();
	}

	internal static bool nXhtpehf2rXE0fovMO40(object P_0, object P_1)
	{
		return (Assembly)P_0 != (Assembly)P_1;
	}

	internal static object Sy81uGhfeIrcBD4lpNhc(object P_0)
	{
		return ((IRuntimeApplication)P_0).ApplicationStartCache;
	}

	internal static bool e2ZmhihfP8jeVLp8mMmq(object P_0)
	{
		return ((ApplicationStartCache)P_0).DynamicPublication;
	}

	internal static void BVq164hf129OL8G4SE5i(object P_0, bool value)
	{
		((ApplicationStartCache)P_0).DynamicPublication = value;
	}

	internal static int tG1UTShfNT8wvqKuxjPr(object P_0)
	{
		return ((List<AssemblyModelsMetadata>)P_0).Count;
	}

	internal static object iJYS7ihf397WGdKkIr4t(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).RestoreMetadata();
	}

	internal static bool XTGhC3hfp93ohNu6VfIJ(object P_0)
	{
		return ((DynamicModelAssemblyBuilder)P_0).HasChanges();
	}

	internal static int rhfAaIhfaKlXCrPZMiP7(object P_0)
	{
		return ((ICollection<EntityMetadata>)P_0).Count;
	}

	internal static object CX5PulhfDoGDrQDPxsdG(object P_0)
	{
		return ((DynamicModelAssemblyBuilder)P_0).DocumentationRawStream;
	}

	internal static TimeSpan de1BAwhft2mQC7GHpLeG(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}

	internal static void QI4ba9hfwsCMmvuax3P0(object P_0, object P_1)
	{
		((ContainerBuilder)P_0).Update((IContainer)P_1);
	}

	internal static bool eOsjDphf4p3AjPuLK26i(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static LicenseStatus pqimPUhf6YWUW2yVLWik(object P_0)
	{
		return ((LicenseInfo)P_0).Status;
	}

	internal static object D08CImhfHyXgSSwGlqMr(ushort algorithm)
	{
		return GenerateRegistrationKey(algorithm);
	}

	internal static void CJ5OXGhfAjPy4RoqMw7D(object P_0, LicenseStatus value)
	{
		((LicenseInfo)P_0).Status = value;
	}

	internal static void CsYqvohf7XEKwOQ02YBd(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static int rPsUdMhfx5xoOjZloj6i(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object I4tox1hf0PCbTAyAnoup(object P_0)
	{
		return FormatKey(P_0);
	}

	internal static object ylLCqThfma6DuURpdN0j(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object w9gn6chfyeFQwxgLoZ2p(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static object rrfTO6hfMDvqmf4gOhAx(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object tylfvfhfJi5EvwAF0dQr(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static uint kfGRYohf9CMyBJoUuVbJ(object P_0)
	{
		return uint.Parse((string)P_0);
	}

	internal static ushort RpGkAahfdtIjA4x3Y64Y(object P_0)
	{
		return ((LicensedUnitBase)P_0).GetDbLicenseCount();
	}

	internal static void Yx3YPghfl6nsek2iUuj1()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object KnONIkhfrALglGWycAdB(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
