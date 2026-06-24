using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Components;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Components.Dependency;
using EleWise.ELMA.UI.Components.Dependency.Models;
using EleWise.ELMA.UI.Helpers;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Services.FindComponent.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Services.FindComponent;

[Service]
internal sealed class FindComponentService : ICleanUIObjectsService, IFindComponentServiceInternal, IFindComponentService
{
	internal class CandidateDependModule
	{
		private static CandidateDependModule dCtnEafsLUWIW00YptIV;

		public HashSet<Guid> Owners { get; set; }

		public bool Valid
		{
			[CompilerGenerated]
			get
			{
				return _003CValid_003Ek__BackingField;
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
						_003CValid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Guid ModuleItemUid
		{
			[CompilerGenerated]
			get
			{
				return _003CModuleItemUid_003Ek__BackingField;
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
						_003CModuleItemUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
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

		public Guid HeaderUid
		{
			[CompilerGenerated]
			get
			{
				return _003CHeaderUid_003Ek__BackingField;
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
						_003CHeaderUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
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

		public Version Version
		{
			[CompilerGenerated]
			get
			{
				return _003CVersion_003Ek__BackingField;
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
						_003CVersion_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public CandidateDependModule()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			P0aZxJfscVXeEaaIdxnI();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					Owners = new HashSet<Guid>();
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public override int GetHashCode()
		{
			int num = 1;
			int num2 = num;
			Guid headerUid = default(Guid);
			while (true)
			{
				switch (num2)
				{
				case 1:
					headerUid = HeaderUid;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return headerUid.GetHashCode() ^ ModuleItemUid.GetHashCode() ^ Valid.GetHashCode() ^ (DntiP5fszCkSoAav3MLD(Version, null) ? Version.GetHashCode() : 0);
				}
			}
		}

		public override bool Equals(object obj)
		{
			//Discarded unreachable code: IL_0062, IL_0071, IL_0113, IL_0122
			int num = 3;
			int num2 = num;
			CandidateDependModule candidateDependModule = default(CandidateDependModule);
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (candidateDependModule != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 7:
					if (!CCD3WCfcFMGks0KjFaY4(ModuleItemUid, TVHfmbfcBrGlpqmgjfBu(candidateDependModule)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				case 6:
					if (Valid == ymRLfpfcWHk3q9DsT5kt(candidateDependModule))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 3:
					candidateDependModule = obj as CandidateDependModule;
					num2 = 2;
					continue;
				case 5:
					return false;
				case 4:
					if (CCD3WCfcFMGks0KjFaY4(HeaderUid, candidateDependModule.HeaderUid))
					{
						num2 = 7;
						continue;
					}
					break;
				default:
					return uXF2Glfcb96v7pt2jMry(Version, DjKdkwfco2RL9WIQZ4s8(candidateDependModule));
				case 1:
					break;
				}
				break;
			}
			return false;
		}

		internal static void P0aZxJfscVXeEaaIdxnI()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool yVwAvPfsUUFDEkrtgQ1Q()
		{
			return dCtnEafsLUWIW00YptIV == null;
		}

		internal static CandidateDependModule lHWVx5fssBBnSuqcpdhV()
		{
			return dCtnEafsLUWIW00YptIV;
		}

		internal static bool DntiP5fszCkSoAav3MLD(object P_0, object P_1)
		{
			return (Version)P_0 != (Version)P_1;
		}

		internal static bool CCD3WCfcFMGks0KjFaY4(Guid P_0, Guid P_1)
		{
			return P_0 == P_1;
		}

		internal static Guid TVHfmbfcBrGlpqmgjfBu(object P_0)
		{
			return ((CandidateDependModule)P_0).ModuleItemUid;
		}

		internal static bool ymRLfpfcWHk3q9DsT5kt(object P_0)
		{
			return ((CandidateDependModule)P_0).Valid;
		}

		internal static object DjKdkwfco2RL9WIQZ4s8(object P_0)
		{
			return ((CandidateDependModule)P_0).Version;
		}

		internal static bool uXF2Glfcb96v7pt2jMry(object P_0, object P_1)
		{
			return (Version)P_0 == (Version)P_1;
		}
	}

	internal sealed class SearchContext
	{
		private readonly FindComponentOptions originalOptions;

		private FindComponentOptions options;

		internal static SearchContext D883qefchvEpHKEWr1hH;

		internal FindComponentOptions Options
		{
			get
			{
				int num = 2;
				int num2 = num;
				FindComponentOptions findComponentOptions = default(FindComponentOptions);
				FindComponentOptions findComponentOptions2;
				while (true)
				{
					switch (num2)
					{
					case 1:
						findComponentOptions = (options = (FindComponentOptions)XWTKZbfcfJnlClqdPC0u(originalOptions));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						findComponentOptions2 = options;
						if (findComponentOptions2 == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					default:
						findComponentOptions2 = findComponentOptions;
						break;
					}
					break;
				}
				return findComponentOptions2;
			}
		}

		internal ComponentGraph ComponentGraph { get; }

		internal Dictionary<Guid, ClientComponentModel> Components { get; }

		internal Dictionary<Guid, ClientDataClassModel> DataClasses { get; }

		internal Dictionary<Guid, ClientFunctionModel> Functions { get; }

		internal Dictionary<Guid, IEnumerable<ModuleVersionHeader>> ModuleVersions { get; }

		internal Dictionary<Guid, IEnumerable<ComponentMetadataItemWrapper>> ComponentVersions { get; }

		internal Dictionary<Guid, ModuleMetadataItemHeader> LoadedModuleHeaders { get; }

		internal Dictionary<Guid, List<CandidateDependModule>> CandidateModules { get; }

		internal Dictionary<Guid, ClientComponentModel> ChosenComponentModules { get; }

		internal Dictionary<Guid, HashSet<Guid>> CandidateDependencies { get; }

		internal HashSet<Guid> IncompatibleModuleItems { get; }

		internal HashSet<Guid> ChosenModules { get; }

		internal HashSet<Guid> AllModules { get; }

		internal List<string> Errors { get; }

		internal List<ClientExtensionPointModel> ExtensionPoints { get; set; }

		internal List<CustomTypeModel> CustomTypes { get; set; }

		internal List<ComponentMetadataItemWrapper> CacheLastPublishedComponents { get; set; }

		internal List<ComponentMetadataItemWrapper> CacheTypeLastPublishedComponents { get; set; }

		internal List<DataClassMetadataItem> CacheLastPublishedDataClasses { get; set; }

		internal List<ModuleVersion> CacheRuntimeModules { get; set; }

		internal List<ModuleVersion> CacheImplementationModules { get; set; }

		internal List<ModuleVersion> CacheTypeModules { get; set; }

		internal Dictionary<Guid, Dictionary<Guid, ClientDataClassModel>> CacheIncludeDataClasses { get; set; }

		internal SearchContext(FindComponentOptions options)
		{
			//Discarded unreachable code: IL_002a, IL_037d, IL_038c
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
			{
				num = 3;
			}
			while (true)
			{
				int num2;
				switch (num)
				{
				case 14:
					DataClasses = new Dictionary<Guid, ClientDataClassModel>();
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num = 1;
					}
					break;
				case 8:
					CustomTypes = new List<CustomTypeModel>();
					num = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num = 5;
					}
					break;
				case 28:
					ExtensionPoints = new List<ClientExtensionPointModel>();
					num = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num = 24;
					}
					break;
				case 13:
					this.options = (FindComponentOptions)XWTKZbfcfJnlClqdPC0u(options);
					num = 23;
					break;
				case 9:
					LoadedModuleHeaders = new Dictionary<Guid, ModuleMetadataItemHeader>();
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num = 0;
					}
					break;
				case 5:
					Errors = new List<string>();
					num2 = 16;
					goto IL_002f;
				case 10:
					CandidateDependencies = new Dictionary<Guid, HashSet<Guid>>();
					num = 8;
					break;
				case 17:
					ChosenComponentModules = new Dictionary<Guid, ClientComponentModel>();
					num = 20;
					break;
				case 4:
					options = new FindComponentOptions();
					num = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num = 18;
					}
					break;
				case 23:
					ComponentGraph = new ComponentGraph();
					num2 = 11;
					goto IL_002f;
				case 20:
					IncompatibleModuleItems = new HashSet<Guid>();
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num = 10;
					}
					break;
				case 12:
					CacheTypeLastPublishedComponents = new List<ComponentMetadataItemWrapper>();
					num = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num = 18;
					}
					break;
				case 7:
					AllModules = new HashSet<Guid>();
					num2 = 17;
					goto IL_002f;
				case 16:
					return;
				default:
					CandidateModules = new Dictionary<Guid, List<CandidateDependModule>>();
					num = 15;
					break;
				case 3:
					if (options != null)
					{
						num = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num = 23;
						}
						break;
					}
					goto case 4;
				case 21:
					CacheRuntimeModules = new List<ModuleVersion>();
					num = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num = 25;
					}
					break;
				case 19:
				case 24:
					originalOptions = options;
					num = 13;
					break;
				case 27:
					CacheLastPublishedComponents = new List<ComponentMetadataItemWrapper>();
					num = 6;
					break;
				case 18:
					CacheTypeModules = new List<ModuleVersion>();
					num = 28;
					break;
				case 2:
					CacheIncludeDataClasses = new Dictionary<Guid, Dictionary<Guid, ClientDataClassModel>>();
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num = 5;
					}
					break;
				case 25:
					CacheImplementationModules = new List<ModuleVersion>();
					num = 2;
					break;
				case 22:
					ModuleVersions = new Dictionary<Guid, IEnumerable<ModuleVersionHeader>>();
					num2 = 26;
					goto IL_002f;
				case 15:
					ChosenModules = new HashSet<Guid>();
					num = 7;
					break;
				case 11:
					Components = new Dictionary<Guid, ClientComponentModel>();
					num = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num = 14;
					}
					break;
				case 26:
					ComponentVersions = new Dictionary<Guid, IEnumerable<ComponentMetadataItemWrapper>>();
					num = 9;
					break;
				case 1:
					Functions = new Dictionary<Guid, ClientFunctionModel>();
					num = 22;
					break;
				case 6:
					{
						CacheLastPublishedDataClasses = new List<DataClassMetadataItem>();
						num = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num = 14;
						}
						break;
					}
					IL_002f:
					num = num2;
					break;
				}
			}
		}

		internal void Clear()
		{
			int num = 3;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 12:
						NJA5y4fcuHBgZGtslGZa(ChosenModules);
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 1;
						}
						continue;
					case 15:
						SrQc7OfcvVREl9mhPrNL(Functions);
						num2 = 17;
						continue;
					case 11:
						return;
					case 2:
						VwmvhWfcQHlc0DCI9dos(Components);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num2 = 0;
						}
						continue;
					case 4:
						VwmvhWfcQHlc0DCI9dos(ChosenComponentModules);
						num2 = 12;
						continue;
					case 7:
						break;
					case 9:
						iFAiIBfciPn774WH2Zu5(CacheLastPublishedComponents);
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 4;
						}
						continue;
					case 5:
						KJ9shBfcIn0OWdR0toBr(CandidateDependencies);
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num2 = 7;
						}
						continue;
					case 13:
						TcMEfpfcZsTPbDt8W2Be(CandidateModules);
						num2 = 4;
						continue;
					case 14:
						CacheTypeLastPublishedComponents.Clear();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num2 = 1;
						}
						continue;
					case 17:
						lIhlHJfc8Y9PeGuT5uuK(ComponentGraph);
						num2 = 13;
						continue;
					default:
						D2AuxvfcCOp9yWLJ9Ct7(DataClasses);
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 5;
						}
						continue;
					case 6:
						Errors.Clear();
						num2 = 11;
						continue;
					case 16:
						u6W2tlfcSCNDq2Xu57J3(CacheRuntimeModules);
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 6;
						}
						continue;
					case 1:
						u6W2tlfcSCNDq2Xu57J3(CacheTypeModules);
						num2 = 9;
						continue;
					case 18:
						s6c4oTfcVPWU44CP3s78(CustomTypes);
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num2 = 8;
						}
						continue;
					case 3:
						options = null;
						num2 = 2;
						continue;
					case 10:
						CacheLastPublishedDataClasses.Clear();
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 2;
						}
						continue;
					case 8:
						CacheIncludeDataClasses.Clear();
						num2 = 6;
						continue;
					}
					break;
				}
				CacheImplementationModules.Clear();
				num = 8;
			}
		}

		internal static object XWTKZbfcfJnlClqdPC0u(object P_0)
		{
			return ((FindComponentOptions)P_0).Clone();
		}

		internal static bool nSVduOfcGiSkENNnmBfT()
		{
			return D883qefchvEpHKEWr1hH == null;
		}

		internal static SearchContext esu4YpfcE2kedXEtDZ88()
		{
			return D883qefchvEpHKEWr1hH;
		}

		internal static void VwmvhWfcQHlc0DCI9dos(object P_0)
		{
			((Dictionary<Guid, ClientComponentModel>)P_0).Clear();
		}

		internal static void D2AuxvfcCOp9yWLJ9Ct7(object P_0)
		{
			((Dictionary<Guid, ClientDataClassModel>)P_0).Clear();
		}

		internal static void SrQc7OfcvVREl9mhPrNL(object P_0)
		{
			((Dictionary<Guid, ClientFunctionModel>)P_0).Clear();
		}

		internal static void lIhlHJfc8Y9PeGuT5uuK(object P_0)
		{
			((ComponentGraph)P_0).Clear();
		}

		internal static void TcMEfpfcZsTPbDt8W2Be(object P_0)
		{
			((Dictionary<Guid, List<CandidateDependModule>>)P_0).Clear();
		}

		internal static void NJA5y4fcuHBgZGtslGZa(object P_0)
		{
			((HashSet<Guid>)P_0).Clear();
		}

		internal static void KJ9shBfcIn0OWdR0toBr(object P_0)
		{
			((Dictionary<Guid, HashSet<Guid>>)P_0).Clear();
		}

		internal static void s6c4oTfcVPWU44CP3s78(object P_0)
		{
			((List<CustomTypeModel>)P_0).Clear();
		}

		internal static void u6W2tlfcSCNDq2Xu57J3(object P_0)
		{
			((List<ModuleVersion>)P_0).Clear();
		}

		internal static void iFAiIBfciPn774WH2Zu5(object P_0)
		{
			((List<ComponentMetadataItemWrapper>)P_0).Clear();
		}
	}

	private readonly IEnumerable<IDependencyFinder> dependencyFinders;

	private readonly ITransformationProvider transformationProvider;

	private readonly ISessionProvider sessionProvider;

	private readonly IModuleReferenceManager moduleReferenceManager;

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	private readonly IDependencyService dependencyService;

	private readonly ModuleMetadataCompatibilityChecker moduleMetadataCompatibilityChecker;

	private readonly Dictionary<Guid, ComponentMetadataItem> loadedComponents;

	private readonly Dictionary<Guid, FunctionMetadataItem> loadedFunctions;

	private readonly ConcurrentDictionary<Guid, RecursiveComponentModel> moduleApplicationCacheResult;

	internal static FindComponentService P0XQefzXow7msOjblcG;

	private ISession Session => (ISession)GxSR99zx3ss5c8h2MMw(sessionProvider, "");

	public IFunctionMetadataItemManager FunctionMetadataItemManager
	{
		[CompilerGenerated]
		get
		{
			return _003CFunctionMetadataItemManager_003Ek__BackingField;
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
					_003CFunctionMetadataItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IComponentMetadataItemManager ComponentMetadataItemManager
	{
		[CompilerGenerated]
		get
		{
			return _003CComponentMetadataItemManager_003Ek__BackingField;
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
					_003CComponentMetadataItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
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

	public IComponentMetadataItemHeaderManager ComponentMetadataItemHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CComponentMetadataItemHeaderManager_003Ek__BackingField;
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
					_003CComponentMetadataItemHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IDataClassMetadataItemManager DataClassMetadataItemManager
	{
		[CompilerGenerated]
		get
		{
			return _003CDataClassMetadataItemManager_003Ek__BackingField;
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
					_003CDataClassMetadataItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IDataClassMetadataItemHeaderManager DataClassMetadataItemHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CDataClassMetadataItemHeaderManager_003Ek__BackingField;
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
					_003CDataClassMetadataItemHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
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

	private void CleanModules(Guid[] modules)
	{
		int num = 4;
		int num2 = num;
		Dictionary<Guid, List<ModuleVersionHeader>> modulesDictionary = default(Dictionary<Guid, List<ModuleVersionHeader>>);
		ModuleVersionHeader[] array = default(ModuleVersionHeader[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
			{
				IEnumerable<ModuleVersionHeader> first = FirstStepCleanCompatibleVersions(modules, modulesDictionary);
				IEnumerable<ModuleVersionHeader> second = SecondStepCleanCompatibleVersions(modules, modulesDictionary);
				array = first.Concat(second).ToArray();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			case 4:
				modulesDictionary = new Dictionary<Guid, List<ModuleVersionHeader>>();
				num2 = 3;
				continue;
			case 1:
				DeleteVersions(array);
				num2 = 2;
				continue;
			}
			if (array.Length != 0)
			{
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				continue;
			}
			return;
		}
	}

	private void DeleteVersions(ModuleVersionHeader[] versionsToDelete)
	{
		//Discarded unreachable code: IL_0058, IL_0062, IL_0152, IL_018a, IL_019d, IL_01ac
		int num = 2;
		int num2 = num;
		IEnumerator<IEnumerable<Guid>> enumerator = default(IEnumerator<IEnumerable<Guid>>);
		HashSet<Guid> hashSet = default(HashSet<Guid>);
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 5:
				enumerator = hashSet.Chunk(1000).GetEnumerator();
				num2 = 4;
				break;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!Xtuo5mz2tWrRwGmUMM2(enumerator))
						{
							num3 = 4;
							goto IL_0066;
						}
						goto IL_00f3;
						IL_0066:
						while (true)
						{
							switch (num3)
							{
							case 5:
								a1VJ1AzO2HAIBOnZwkj(Session, 0, new Action(_003C_003Ec__DisplayClass1_._003CDeleteVersions_003Eb__1));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								_003C_003Ec__DisplayClass1_._003C_003E4__this = this;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
								{
									num3 = 1;
								}
								continue;
							case 3:
								goto IL_00f3;
							case 1:
								_003C_003Ec__DisplayClass1_.chunk = enumerator.Current;
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
								{
									num3 = 0;
								}
								continue;
							case 4:
								return;
							}
							break;
						}
						continue;
						IL_00f3:
						_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
						num3 = 2;
						goto IL_0066;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								OvaV7SzejkY4BOybd2x(enumerator);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
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
				if (ehvH7RznYpL4PA3dcfB(hashSet) == 0)
				{
					return;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 5;
				}
				break;
			case 3:
				return;
			case 2:
				hashSet = versionsToDelete.Select((ModuleVersionHeader v) => _003C_003Ec.mpWVMEfcaVevVJr0RSIV(v)).ToHashSet();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private IEnumerable<ModuleVersionHeader> FirstStepCleanCompatibleVersions(IEnumerable<Guid> modules, Dictionary<Guid, List<ModuleVersionHeader>> modulesDictionary)
	{
		List<ModuleVersionHeader> list = new List<ModuleVersionHeader>();
		foreach (Guid module in modules)
		{
			List<ModuleVersionHeader> list3 = (modulesDictionary[module] = moduleMetadataLoader.GetModuleVersionHeaders(module).ToList());
			List<ModuleVersionHeader> list4 = new List<ModuleVersionHeader>();
			CheckModuleCompatibilityAndDeleteCompatibleVersions(list3, list4);
			list.AddRange(list4);
			foreach (ModuleVersionHeader item in list4)
			{
				list3.Remove(item);
			}
		}
		return list;
	}

	private IEnumerable<ModuleVersionHeader> SecondStepCleanCompatibleVersions(IEnumerable<Guid> modules, Dictionary<Guid, List<ModuleVersionHeader>> modulesDictionary)
	{
		List<DependencyRequest> list = new List<DependencyRequest>();
		foreach (Guid module in modules)
		{
			if (modulesDictionary.TryGetValue(module, out var value) && value.Count != 0 && value.Count != 1)
			{
				DependencyRequest item = new DependencyRequest
				{
					ModuleUid = module
				};
				list.Add(item);
			}
		}
		List<ModuleVersionHeader> list2 = new List<ModuleVersionHeader>();
		if (list.Count == 0)
		{
			return list2;
		}
		List<Dependency> list3 = new List<Dependency>();
		foreach (IDependencyFinder dependencyFinder in dependencyFinders)
		{
			IEnumerable<Dependency> dependencies = dependencyFinder.GetDependencies(list);
			list3.AddRange(dependencies);
		}
		List<Dependency> list4 = new List<Dependency>(list3);
		Dictionary<Guid, List<ModuleVersionHeader>> dictionary = new Dictionary<Guid, List<ModuleVersionHeader>>();
		foreach (Dependency item2 in list3)
		{
			Guid moduleUid = item2.ModuleUid;
			if (!modulesDictionary.TryGetValue(moduleUid, out var value2))
			{
				continue;
			}
			if (!dictionary.TryGetValue(moduleUid, out var value3))
			{
				List<ModuleVersionHeader> list6 = (dictionary[moduleUid] = new List<ModuleVersionHeader>());
				value3 = list6;
			}
			foreach (ModuleVersionHeader item3 in value2)
			{
				ModuleSignature signature = item3.Signature;
				if (signature == null)
				{
					continue;
				}
				if (item2 is FunctionDependency functionDependency)
				{
					_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
					CS_0024_003C_003E8__locals0.functionDependencyHeaderUid = functionDependency.HeaderUid;
					FunctionDependency functionDependency2 = signature.Functions.FirstOrDefault((FunctionDependency a) => _003C_003Ec__DisplayClass3_0.yGZLwFfcl44janhxqkip(a.HeaderUid, CS_0024_003C_003E8__locals0.functionDependencyHeaderUid));
					if (functionDependency2 == null)
					{
						continue;
					}
					if (dependencyService.CheckFunctionCompatibility(functionDependency, functionDependency2).IsValid)
					{
						list4.Remove(item2);
						value3.Add(item3);
						break;
					}
				}
				if (item2 is DataClassDependency dataClassDependency)
				{
					_003C_003Ec__DisplayClass3_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass3_1();
					CS_0024_003C_003E8__locals1.dataclassDependencyHeaderUid = dataClassDependency.HeaderUid;
					DataClassDependency dataClassDependency2 = signature.DataClasses.FirstOrDefault((DataClassDependency a) => _003C_003Ec__DisplayClass3_1.K1myH1fcYqbGtkFklqnd(a.HeaderUid, CS_0024_003C_003E8__locals1.dataclassDependencyHeaderUid));
					if (dataClassDependency2 == null)
					{
						continue;
					}
					if (dependencyService.CheckDataClassCompatibility(dataClassDependency, dataClassDependency2).IsValid)
					{
						list4.Remove(item2);
						value3.Add(item3);
						break;
					}
				}
				if (item2 is ComponentDependency componentDependency)
				{
					_003C_003Ec__DisplayClass3_2 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass3_2();
					CS_0024_003C_003E8__locals2.componentDependencyHeaderUid = componentDependency.HeaderUid;
					ComponentSignature componentSignature = signature.Components.FirstOrDefault((ComponentSignature a) => _003C_003Ec__DisplayClass3_2.OacXmVfzFg45TNt1FtVh(_003C_003Ec__DisplayClass3_2.Ovpl5XfczFwcjfGJXJY6(a), CS_0024_003C_003E8__locals2.componentDependencyHeaderUid));
					if (componentSignature != null && CheckComponentHelper.CheckSignature(componentDependency, componentSignature).IsValid)
					{
						list4.Remove(item2);
						value3.Add(item3);
						break;
					}
				}
			}
		}
		if (list4.Count > 0)
		{
			Logger.Log.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92FCC8F)));
		}
		foreach (KeyValuePair<Guid, List<ModuleVersionHeader>> item4 in dictionary)
		{
			List<ModuleVersionHeader> list7 = new List<ModuleVersionHeader>(modulesDictionary[item4.Key]);
			foreach (ModuleVersionHeader item5 in item4.Value)
			{
				list7.Remove(item5);
			}
			list2.AddRange(list7);
		}
		return list2;
	}

	private void CheckModuleCompatibilityAndDeleteCompatibleVersions(List<ModuleVersionHeader> moduleVersions, List<ModuleVersionHeader> versionsToDelete)
	{
		if (moduleVersions.Count > 1)
		{
			ModuleVersionHeader moduleVersionHeader = moduleVersions[0];
			List<ModuleVersionHeader> list = moduleVersions.Except(new ModuleVersionHeader[1] { moduleVersionHeader }).ToList();
			ModuleVersionHeader[] array = Check(list, moduleVersionHeader).ToArray();
			foreach (ModuleVersionHeader item in array)
			{
				versionsToDelete.Add(item);
				list.Remove(item);
			}
			CheckModuleCompatibilityAndDeleteCompatibleVersions(list, versionsToDelete);
		}
	}

	[IteratorStateMachine(typeof(_003CCheck_003Ed__5))]
	private IEnumerable<ModuleVersionHeader> Check(IEnumerable<ModuleVersionHeader> oldVersions, ModuleVersionHeader newVersion)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CCheck_003Ed__5(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__oldVersions = oldVersions,
			_003C_003E3__newVersion = newVersion
		};
	}

	private bool FindCustomTypes(SearchContext searchContext)
	{
		//Discarded unreachable code: IL_003a, IL_008d, IL_0194, IL_01a7, IL_01de, IL_01ed, IL_01f8, IL_0220, IL_022a, IL_037c, IL_038f, IL_0457, IL_046a
		int num = 1;
		int num2 = num;
		List<ComponentMetadataItemWrapper>.Enumerator enumerator = default(List<ComponentMetadataItemWrapper>.Enumerator);
		CustomTypeImplementationModel customType = default(CustomTypeImplementationModel);
		ComponentMetadataItemWrapper current3 = default(ComponentMetadataItemWrapper);
		List<ModuleVersion>.Enumerator enumerator2 = default(List<ModuleVersion>.Enumerator);
		ModuleVersion current = default(ModuleVersion);
		List<ComponentMetadata>.Enumerator enumerator3 = default(List<ComponentMetadata>.Enumerator);
		CustomTypeImplementationModel customTypeImplementationModel = default(CustomTypeImplementationModel);
		ComponentMetadata current2 = default(ComponentMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					while (true)
					{
						int num7;
						if (!enumerator.MoveNext())
						{
							num7 = 3;
							goto IL_0048;
						}
						goto IL_00d9;
						IL_0048:
						while (true)
						{
							switch (num7)
							{
							case 5:
							{
								customType = ((ComponentSignature)bJZRQIzPaXpi6pREbbm(current3)).CustomType;
								int num8 = 6;
								num7 = num8;
								continue;
							}
							case 4:
								bwoDqGz1JjsA7K0CQeq(customType);
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
								{
									num7 = 1;
								}
								continue;
							case 2:
								goto IL_00d9;
							case 6:
								if (customType == null)
								{
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
									{
										num7 = 0;
									}
									continue;
								}
								goto case 4;
							case 1:
							{
								List<CustomTypeModel> customTypes2 = searchContext.CustomTypes;
								CustomTypeModel customTypeModel2 = new CustomTypeModel();
								SEdqeFzN2Wids1PlI5K(customTypeModel2, customType.TypeUid);
								customTypeModel2.SubTypeUid = customType.SubTypeUid;
								kmWlLozpIDaOhPsyqEK(customTypeModel2, Tpq3Slz3nJ8ch1Jm4Y6(customType));
								customTypeModel2.HeaderUid = current3.HeaderUid;
								vFLZn2zDunAfWQQI5BK(customTypeModel2, A3K5WQza9pDvO3NWvq1(current3));
								customTypes2.Add(customTypeModel2);
								num7 = 7;
								continue;
							}
							case 3:
								goto end_IL_0072;
							}
							break;
						}
						continue;
						IL_00d9:
						current3 = enumerator.Current;
						num7 = 5;
						goto IL_0048;
						continue;
						end_IL_0072:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num9 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num9 = 0;
					}
					switch (num9)
					{
					case 0:
						break;
					}
				}
				goto case 5;
			case 5:
				enumerator2 = searchContext.CacheTypeModules.GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				try
				{
					while (true)
					{
						IL_03bc:
						int num3;
						if (!enumerator2.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
							{
								num3 = 2;
							}
							goto IL_01fc;
						}
						goto IL_0399;
						IL_0399:
						current = enumerator2.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num3 = 0;
						}
						goto IL_01fc;
						IL_01fc:
						while (true)
						{
							switch (num3)
							{
							case 3:
								try
								{
									while (true)
									{
										IL_0329:
										int num4;
										if (!enumerator3.MoveNext())
										{
											num4 = 6;
											goto IL_022e;
										}
										goto IL_0267;
										IL_022e:
										while (true)
										{
											switch (num4)
											{
											default:
												customTypeImplementationModel = (CustomTypeImplementationModel)CvRW6lzwwq0EQ5KXDKY(current2);
												num4 = 2;
												continue;
											case 4:
												break;
											case 1:
											{
												List<CustomTypeModel> customTypes = searchContext.CustomTypes;
												CustomTypeModel customTypeModel = new CustomTypeModel();
												SEdqeFzN2Wids1PlI5K(customTypeModel, bwoDqGz1JjsA7K0CQeq(customTypeImplementationModel));
												BJfHPkz4usOYVkh496y(customTypeModel, customTypeImplementationModel.SubTypeUid);
												kmWlLozpIDaOhPsyqEK(customTypeModel, Tpq3Slz3nJ8ch1Jm4Y6(customTypeImplementationModel));
												UCkqCpz6l2NnPWwCrjt(customTypeModel, current2.Uid);
												hHaIsgzHbTKOkWBZkvL(customTypeModel, current2.ModuleUid);
												customTypeModel.ModuleItemUid = zhf61FzAs08ZdStq71m(current.Header);
												customTypes.Add(customTypeModel);
												num4 = 5;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
												{
													num4 = 1;
												}
												continue;
											}
											case 3:
												bwoDqGz1JjsA7K0CQeq(customTypeImplementationModel);
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
												{
													num4 = 1;
												}
												continue;
											case 5:
												goto IL_0329;
											case 2:
												if (customTypeImplementationModel != null)
												{
													num4 = 3;
													continue;
												}
												goto IL_0329;
											case 6:
												goto end_IL_0329;
											}
											break;
										}
										goto IL_0267;
										IL_0267:
										current2 = enumerator3.Current;
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
										{
											num4 = 0;
										}
										goto IL_022e;
										continue;
										end_IL_0329:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator3).Dispose();
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								goto IL_03bc;
							case 1:
								break;
							case 4:
								goto IL_03bc;
							default:
								enumerator3 = ((ModuleInfoMetadata)iMlyy1ztkAWCr8rEdWj(current)).Components.Where((ComponentMetadata c) => c.CustomTypeImplementation != null).ToList().GetEnumerator();
								num3 = 3;
								continue;
							case 2:
								goto end_IL_03bc;
							}
							break;
						}
						goto IL_0399;
						continue;
						end_IL_03bc:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto case 4;
			case 1:
				LoadData(searchContext);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return true;
			default:
				enumerator = searchContext.CacheTypeLastPublishedComponents.GetEnumerator();
				num2 = 3;
				break;
			}
		}
	}

	private void LoadData(SearchContext searchContext)
	{
		//Discarded unreachable code: IL_0072, IL_0081, IL_00d5, IL_00e4
		int num = 7;
		int num2 = num;
		IEnumerable<ModuleMetadataItemWrapper> source = default(IEnumerable<ModuleMetadataItemWrapper>);
		IEnumerable<Guid> notLoaded = default(IEnumerable<Guid>);
		while (true)
		{
			switch (num2)
			{
			case 5:
				searchContext.CacheTypeModules.AddRange(source.Select((ModuleMetadataItemWrapper w) => (ModuleVersion)vHy53qzduNL4la1OiPP(moduleMetadataLoader, w.HeaderUid, w.Uid)).ToArray());
				num2 = 2;
				break;
			case 8:
				return;
			case 4:
			case 6:
				if (searchContext.CacheTypeModules.Count != 0)
				{
					num2 = 8;
					break;
				}
				goto default;
			case 7:
				if (n3qm1lz7Myf3kxLsn3P(searchContext.CacheTypeLastPublishedComponents) != 0)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 1;
			case 2:
				return;
			case 1:
				searchContext.CacheTypeLastPublishedComponents.AddRange(GetLastPublishedComponents().Where(delegate(ComponentMetadataItemWrapper i)
				{
					//Discarded unreachable code: IL_00a6, IL_00b5, IL_00c9
					int num3 = 2;
					int num4 = num3;
					ComponentSignature componentSignature = default(ComponentSignature);
					while (true)
					{
						switch (num4)
						{
						default:
							if (!_003C_003Ec.PK0Gr7fc40TskNZCDro3(_003C_003Ec.xPJcJDfcwONi9yCYs4cF(componentSignature.CustomType), Guid.Empty))
							{
								num4 = 4;
								break;
							}
							goto case 3;
						case 2:
							componentSignature = (ComponentSignature)_003C_003Ec.ArdWkkfcDyYnjCXt3mlt(i);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
							{
								num4 = 1;
							}
							break;
						case 1:
							if (_003C_003Ec.nmdQlXfct7SNDYNys4iu(componentSignature) == null)
							{
								num4 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
								{
									num4 = 1;
								}
								break;
							}
							goto default;
						case 3:
						case 5:
							return false;
						case 4:
							return true;
						}
					}
				}));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 4;
				}
				break;
			default:
				notLoaded = from m in (from w in GetAdditionalModules()
						select (ModuleVersion)vHy53qzduNL4la1OiPP(moduleMetadataLoader, MJd4j0BFSxyqrmO88VXq(w), w.ModuleItemUid)).ToArray()
					select _003C_003Ec.c5ynBufcHHweeI3ve4iw(_003C_003Ec.u1os3Xfc6rAqw6yX12Cg(m));
				num2 = 3;
				break;
			case 3:
				source = from i in moduleMetadataLoader.GetLastPublishedHeaders(notLoaded)
					where _003C_003Ec.cYdRK7fcAsqhorX8Xkjs(i.Signature.CustomTypes) > 0
					select i;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	public void Clean(ICleanUIObjectsModel model)
	{
		//Discarded unreachable code: IL_0036, IL_0045
		int num = 4;
		int num2 = num;
		Guid[] array = default(Guid[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				return;
			case 2:
				CleanModules(array);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (array.Length == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 4:
				array = (Guid[])MTyav2z0mMKCuXrTiIo(model);
				num2 = 3;
				break;
			}
		}
	}

	public IEnumerable<ClientComponentModel> GetAdditionalModules()
	{
		UIRuntimeModel orDefault = ContextVars.GetOrDefault<UIRuntimeModel>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289698926));
		if (orDefault == null)
		{
			return Enumerable.Empty<ClientComponentModel>();
		}
		HashSet<Guid> orDefault2 = ContextVars.GetOrDefault<HashSet<Guid>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x5115DCD5));
		if (orDefault2 != null && orDefault2.Count > 0)
		{
			List<Guid> list = new List<Guid>();
			List<ItemRuntimeModel> runtimeModules = orDefault.RuntimeModules;
			using (HashSet<Guid>.Enumerator enumerator = orDefault2.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass11_0();
					CS_0024_003C_003E8__locals1.additionalModule = enumerator.Current;
					if (!(CS_0024_003C_003E8__locals1.additionalModule == Guid.Empty) && runtimeModules.Find((ItemRuntimeModel a) => _003C_003Ec__DisplayClass11_0.Rt87cXfzZLriNIHoWFA6(_003C_003Ec__DisplayClass11_0.Pl4LDhfz8YPlOaHbq0tt(a), CS_0024_003C_003E8__locals1.additionalModule)) == null)
					{
						list.Add(CS_0024_003C_003E8__locals1.additionalModule);
					}
				}
			}
			UIRuntimeModel orAdd = ContextVars.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633529003), () => new UIRuntimeModel());
			List<ClientComponentModel> list2 = new List<ClientComponentModel>();
			foreach (ItemRuntimeModel runtimeModule in orAdd.RuntimeModules)
			{
				_003C_003Ec__DisplayClass11_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_1();
				CS_0024_003C_003E8__locals0.header = runtimeModule.HeaderUid;
				Guid itemUid = runtimeModule.ItemUid;
				if (!(CS_0024_003C_003E8__locals0.header == Guid.Empty) && !(runtimeModule.ItemUid == Guid.Empty))
				{
					if (list.Find((Guid a) => a == CS_0024_003C_003E8__locals0.header) != Guid.Empty)
					{
						list.Remove(CS_0024_003C_003E8__locals0.header);
					}
					list2.Add(new ClientComponentModel
					{
						ModuleUid = CS_0024_003C_003E8__locals0.header,
						ModuleItemUid = itemUid
					});
				}
			}
			if (list.Count <= 0)
			{
				return list2;
			}
			FindComponentOptions findComponentOptions = new FindComponentOptions
			{
				NeededModules = list
			};
			findComponentOptions.LoadedModules.AddRange(runtimeModules);
			findComponentOptions.LoadedModules.AddRange(orAdd.RuntimeModules);
			return FindModules(findComponentOptions).Concat(list2);
		}
		return Enumerable.Empty<ClientComponentModel>();
	}

	private ClientComponentModel[] FindModules(FindComponentOptions options)
	{
		//Discarded unreachable code: IL_00d4, IL_00e3, IL_015b, IL_016a, IL_018e, IL_019d, IL_01a8, IL_0254, IL_0267
		int num = 16;
		SearchContext searchContext = default(SearchContext);
		int num4 = default(int);
		List<ItemRuntimeModel> loadedModules = default(List<ItemRuntimeModel>);
		Guid key = default(Guid);
		int num3 = default(int);
		Guid value = default(Guid);
		ItemRuntimeModel itemRuntimeModel = default(ItemRuntimeModel);
		List<Guid>.Enumerator enumerator = default(List<Guid>.Enumerator);
		Guid current = default(Guid);
		Guid[] array2 = default(Guid[]);
		List<Guid> neededModules = default(List<Guid>);
		ClientComponentModel[] array = default(ClientComponentModel[]);
		ModuleVersion version = default(ModuleVersion);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return searchContext.ChosenComponentModules.Values.ToArray();
				case 14:
				case 22:
					if (num4 >= loadedModules.Count)
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto case 21;
				case 18:
					searchContext.ChosenComponentModules.Remove(key);
					num2 = 9;
					continue;
				case 15:
					loadedModules = ((FindComponentOptions)lTCXFgzmDwbANeh2YWG(searchContext)).LoadedModules;
					num2 = 10;
					continue;
				case 13:
					num3 = 0;
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 23;
					}
					continue;
				case 16:
					break;
				case 4:
					num4 = 0;
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 14;
					}
					continue;
				case 1:
					value = OLpPL4zMhFxCvpk9kMd(itemRuntimeModel);
					num2 = 17;
					continue;
				case 12:
					try
					{
						while (true)
						{
							IL_01d9:
							int num6;
							if (!enumerator.MoveNext())
							{
								num6 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
								{
									num6 = 3;
								}
								goto IL_01ac;
							}
							goto IL_01c6;
							IL_01c6:
							current = enumerator.Current;
							num6 = 2;
							goto IL_01ac;
							IL_01ac:
							while (true)
							{
								switch (num6)
								{
								case 1:
									break;
								default:
									goto IL_01d9;
								case 2:
									searchContext.AllModules.Add(current);
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
									{
										num6 = 0;
									}
									continue;
								case 3:
									goto end_IL_01d9;
								}
								break;
							}
							goto IL_01c6;
							continue;
							end_IL_01d9:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 19;
				case 2:
					array2 = searchContext.ChosenComponentModules.Keys.Except(neededModules).ToArray();
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 5;
					}
					continue;
				case 17:
				{
					ClientComponentModel[] array3 = array;
					int num5 = num4;
					ClientComponentModel obj = new ClientComponentModel
					{
						ModuleUid = itemRuntimeModel.HeaderUid
					};
					M82BL7zJJj9ytsx4xAS(obj, value);
					array3[num5] = obj;
					num2 = 8;
					continue;
				}
				case 20:
					neededModules = ((FindComponentOptions)lTCXFgzmDwbANeh2YWG(searchContext)).NeededModules;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 5;
					}
					continue;
				case 8:
					version = (ModuleVersion)vHy53qzduNL4la1OiPP(moduleMetadataLoader, NBVX77z9qIdCwXt3ICf(itemRuntimeModel), OLpPL4zMhFxCvpk9kMd(itemRuntimeModel));
					num2 = 11;
					continue;
				case 6:
					key = array2[num3];
					num2 = 18;
					continue;
				case 5:
					enumerator = neededModules.GetEnumerator();
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 7;
					}
					continue;
				case 7:
					num4++;
					num2 = 22;
					continue;
				case 3:
				case 23:
					if (num3 >= array2.Length)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 10:
					array = new ClientComponentModel[Er7FNezy60ZGrjl8Cre(loadedModules)];
					num2 = 4;
					continue;
				case 19:
					FindModule(array, searchContext);
					num2 = 2;
					continue;
				case 9:
					num3++;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 3;
					}
					continue;
				case 21:
					itemRuntimeModel = loadedModules[num4];
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					FillСompatibilityTable(version, searchContext);
					num2 = 7;
					continue;
				}
				break;
			}
			searchContext = new SearchContext(options);
			num = 15;
		}
	}

	private Guid FindComponentRecursive(Guid headerUid, SearchContext searchContext)
	{
		//Discarded unreachable code: IL_008f, IL_009e
		int num = 6;
		int num2 = num;
		Guid guid2 = default(Guid);
		while (true)
		{
			Guid guid;
			switch (num2)
			{
			case 2:
			case 3:
				return guid2;
			case 6:
			{
				ModuleReference moduleReference = moduleReferenceManager.LoadOrNull(headerUid);
				if (moduleReference == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				guid = x23RTCzl072F9mR0SP8(moduleReference);
				break;
			}
			case 4:
				GetComponentFromConfiguration(headerUid, searchContext);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				GetComponentFromModule(guid2, headerUid, searchContext);
				num2 = 3;
				continue;
			case 1:
				if (guid2 == Guid.Empty)
				{
					num2 = 4;
					continue;
				}
				goto default;
			case 5:
				guid = Guid.Empty;
				break;
			}
			guid2 = guid;
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
			{
				num2 = 0;
			}
		}
	}

	private void GetComponentFromConfiguration(Guid headerUid, SearchContext searchContext)
	{
		//Discarded unreachable code: IL_0149, IL_019a, IL_01a9, IL_038e, IL_0406, IL_04c0, IL_0526, IL_057d, IL_058c, IL_059c, IL_05ab, IL_05bc, IL_05cb, IL_05d6, IL_0681, IL_06a0, IL_06af, IL_06cc, IL_077a, IL_0789, IL_0794, IL_083f, IL_085e, IL_086d, IL_088a, IL_0899, IL_08af
		int num = 22;
		ComponentMetadataItem componentMetadataItem = default(ComponentMetadataItem);
		ComponentMetadataItemHeader componentMetadataItemHeader = default(ComponentMetadataItemHeader);
		InterfaceBuilderViewMode interfaceBuilderViewMode = default(InterfaceBuilderViewMode);
		IEnumerator<ClientFunctionModel> enumerator = default(IEnumerator<ClientFunctionModel>);
		IEnumerable<ClientFunctionModel> item2 = default(IEnumerable<ClientFunctionModel>);
		Guid parent = default(Guid);
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		IEnumerable<ClientDataClassModel> item = default(IEnumerable<ClientDataClassModel>);
		ComponentGraph.Vertex vertex = default(ComponentGraph.Vertex);
		IEnumerator<ClientDataClassModel> enumerator2 = default(IEnumerator<ClientDataClassModel>);
		ClientDataClassModel current2 = default(ClientDataClassModel);
		ClientFunctionModel current = default(ClientFunctionModel);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Guid guid;
				object obj;
				switch (num2)
				{
				default:
					return;
				case 14:
					searchContext.Errors.Add(SR.T((string)PC0R82zrUHU2qMy6Gg0(-1411196499 ^ -1411250453), headerUid));
					num2 = 16;
					continue;
				case 44:
					if (searchContext.Errors.Count <= 0)
					{
						num2 = 19;
						continue;
					}
					goto case 10;
				case 39:
					uir9COBFbdBxBXhvM3Cg(lTCXFgzmDwbANeh2YWG(searchContext), InterfaceBuilderViewMode.Runtime);
					num2 = 43;
					continue;
				case 4:
					return;
				case 6:
					loadedComponents[sjUd4ZzLHZM6ksBmvHP(componentMetadataItem)] = componentMetadataItem;
					num2 = 9;
					continue;
				case 20:
					componentMetadataItem = (ComponentMetadataItem)z3Gya3zjOeKvblRLCEF(componentMetadataItemHeader);
					num2 = 29;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 13;
					}
					continue;
				case 25:
					if (RQgC0czgFSWQ4XvqAxr(lTCXFgzmDwbANeh2YWG(searchContext)) != InterfaceBuilderViewMode.Design)
					{
						num2 = 2;
						continue;
					}
					guid = Guid.Empty;
					goto IL_09bc;
				case 16:
					return;
				case 42:
					switch (interfaceBuilderViewMode)
					{
					case InterfaceBuilderViewMode.Runtime:
						break;
					default:
						goto IL_01fa;
					case InterfaceBuilderViewMode.Emulation:
						goto IL_02e7;
					case InterfaceBuilderViewMode.Design:
						goto IL_03b3;
					}
					goto case 20;
				case 23:
					enumerator = item2.GetEnumerator();
					num2 = 26;
					continue;
				case 28:
					return;
				case 5:
					if (FindConfigurationImpl(parent, sjUd4ZzLHZM6ksBmvHP(componentMetadataItem), sjUd4ZzLHZM6ksBmvHP(componentMetadataItem), componentMetadata.Uid, componentMetadataItem, searchContext))
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 31;
				case 9:
					item2 = GetFunctions((string)BcBEmvzUHSE6Hf3AR79(componentMetadata), componentMetadata.FunctionDependencies, searchContext, throwException: true).functionModels;
					num2 = 44;
					continue;
				case 1:
					if (componentMetadataItemHeader != null)
					{
						interfaceBuilderViewMode = RQgC0czgFSWQ4XvqAxr(searchContext.Options);
						num2 = 42;
						continue;
					}
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 2;
					}
					continue;
				case 17:
					return;
				case 19:
					item = GetDataClasses((string)BcBEmvzUHSE6Hf3AR79(componentMetadata), componentMetadata.DataClassDependencies, searchContext, throwException: true).dataClassModels;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 12;
					}
					continue;
				case 7:
					goto IL_02e7;
				case 43:
					if (FindComponent(parent, sjUd4ZzLHZM6ksBmvHP(componentMetadataItem), sjUd4ZzLHZM6ksBmvHP(componentMetadataItem), cMLTumBFhHIoYiMbgbG3(componentMetadata), componentMetadata.ComponentDependencies, searchContext))
					{
						num2 = 5;
						continue;
					}
					goto case 30;
				case 38:
				case 41:
					componentMetadataItem = null;
					num2 = 32;
					continue;
				case 35:
				{
					Dictionary<Guid, ClientComponentModel> components = searchContext.Components;
					Guid key = EKWac9zzFvThoYiiFo5(vertex);
					ClientComponentModel clientComponentModel = new ClientComponentModel();
					gHf6qOBFF83pESH2yeSb(clientComponentModel, EKWac9zzFvThoYiiFo5(vertex));
					aJiRH2BFWqD71eFO0MDW(clientComponentModel, q4h85NBFBxYqKkIqQqF1(vertex));
					clientComponentModel.RenderUidList = vertex.ViewItemUidList;
					components.Add(key, clientComponentModel);
					num2 = 23;
					continue;
				}
				case 0:
					return;
				case 3:
					return;
				case 18:
					if (FindCustomTypes(searchContext))
					{
						return;
					}
					num2 = 36;
					continue;
				case 45:
					goto IL_03b3;
				case 12:
					if (vKChURzsrUf3vkTTcIY(searchContext.Errors) > 0)
					{
						num2 = 28;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num2 = 33;
						}
						continue;
					}
					vertex = ((ComponentGraph)cKHlxVzcgw9q1aIwTx5(searchContext)).AddHeadVertex(headerUid, sjUd4ZzLHZM6ksBmvHP(componentMetadataItem), Guid.Empty, async: false);
					num2 = 35;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 32;
					}
					continue;
				case 11:
					return;
				case 27:
					if ((componentMetadata = DFASlozYEBdlcbhTFVo(componentMetadataItem) as ComponentMetadata) != null)
					{
						num2 = 6;
						continue;
					}
					goto case 8;
				case 33:
					searchContext.Errors.Add(SR.T((string)PC0R82zrUHU2qMy6Gg0(0x7EC153F ^ 0x7ECF437), BcBEmvzUHSE6Hf3AR79(componentMetadata)));
					num = 24;
					break;
				case 10:
					searchContext.Errors.Add(SR.T((string)PC0R82zrUHU2qMy6Gg0(-420743386 ^ -420800592), BcBEmvzUHSE6Hf3AR79(componentMetadata)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 17;
					}
					continue;
				case 24:
					return;
				case 15:
				case 29:
				case 32:
				case 40:
					if (componentMetadataItem != null)
					{
						num2 = 27;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 13;
				case 8:
					searchContext.Errors.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDC5A1A), typeof(ComponentMetadata).FullName));
					num2 = 4;
					continue;
				case 37:
					try
					{
						while (true)
						{
							int num5;
							if (!Xtuo5mz2tWrRwGmUMM2(enumerator2))
							{
								num5 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
								{
									num5 = 1;
								}
								goto IL_05da;
							}
							goto IL_0648;
							IL_0648:
							current2 = enumerator2.Current;
							num5 = 3;
							goto IL_05da;
							IL_05da:
							while (true)
							{
								switch (num5)
								{
								case 1:
									break;
								case 3:
									searchContext.DataClasses[current2.HeaderUid] = current2;
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
									{
										num5 = 0;
									}
									continue;
								default:
									goto IL_0648;
								case 2:
									goto end_IL_05f4;
								}
								break;
							}
							continue;
							end_IL_05f4:
							break;
						}
					}
					finally
					{
						int num6;
						if (enumerator2 == null)
						{
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
							{
								num6 = 0;
							}
							goto IL_0685;
						}
						goto IL_06ba;
						IL_06ba:
						OvaV7SzejkY4BOybd2x(enumerator2);
						num6 = 2;
						goto IL_0685;
						IL_0685:
						switch (num6)
						{
						default:
							goto end_IL_0660;
						case 0:
							goto end_IL_0660;
						case 1:
							break;
						case 2:
							goto end_IL_0660;
						}
						goto IL_06ba;
						end_IL_0660:;
					}
					goto case 25;
				case 22:
				{
					IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager = ComponentMetadataItemHeaderManager;
					if (componentMetadataItemHeaderManager == null)
					{
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 19;
						}
						continue;
					}
					obj = componentMetadataItemHeaderManager.LoadOrNull(headerUid);
					goto IL_099b;
				}
				case 30:
					searchContext.Errors.Add(SR.T((string)PC0R82zrUHU2qMy6Gg0(-70037984 ^ -70012998), BcBEmvzUHSE6Hf3AR79(componentMetadata)));
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 28;
					}
					continue;
				case 34:
					enumerator2 = item.GetEnumerator();
					num2 = 37;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 4;
					}
					continue;
				case 26:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								goto IL_0798;
							}
							goto IL_07f6;
							IL_0798:
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									searchContext.Functions[JjPtnYBFoMWBXtGgW9M3(current)] = current;
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
									{
										num3 = 1;
									}
									continue;
								case 3:
									goto IL_07f6;
								case 2:
									goto end_IL_07b2;
								}
								break;
							}
							continue;
							IL_07f6:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
							{
								num3 = 0;
							}
							goto IL_0798;
							continue;
							end_IL_07b2:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
							{
								num4 = 0;
							}
							goto IL_0843;
						}
						goto IL_0878;
						IL_0878:
						OvaV7SzejkY4BOybd2x(enumerator);
						num4 = 2;
						goto IL_0843;
						IL_0843:
						switch (num4)
						{
						default:
							goto end_IL_081e;
						case 0:
							goto end_IL_081e;
						case 1:
							break;
						case 2:
							goto end_IL_081e;
						}
						goto IL_0878;
						end_IL_081e:;
					}
					goto case 34;
				case 2:
					guid = sjUd4ZzLHZM6ksBmvHP(componentMetadataItem);
					goto IL_09bc;
				case 31:
					searchContext.Errors.Add(SR.T((string)PC0R82zrUHU2qMy6Gg0(-1921202237 ^ -1921243559), componentMetadata.DisplayName));
					num = 3;
					break;
				case 36:
					searchContext.Errors.Add(SR.T((string)PC0R82zrUHU2qMy6Gg0(-87337865 ^ -87312915), BcBEmvzUHSE6Hf3AR79(componentMetadata)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					searchContext.Errors.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867771424), RQgC0czgFSWQ4XvqAxr(lTCXFgzmDwbANeh2YWG(searchContext))));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 5;
					}
					continue;
				case 21:
					{
						obj = null;
						goto IL_099b;
					}
					IL_09bc:
					parent = guid;
					num2 = 39;
					continue;
					IL_099b:
					componentMetadataItemHeader = (ComponentMetadataItemHeader)obj;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 1;
					}
					continue;
					IL_03b3:
					componentMetadataItem = componentMetadataItemHeader.Draft;
					num2 = 40;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 26;
					}
					continue;
					IL_02e7:
					componentMetadataItem = (ComponentMetadataItem)QOMAZEz50QRLoH9oiWM(componentMetadataItemHeader);
					num = 15;
					break;
					IL_01fa:
					num2 = 38;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 22;
					}
					continue;
				}
				break;
			}
		}
	}

	private bool FindComponent(Guid parent, Guid itemUid, Guid owner, Guid parentComponentUid, IEnumerable<ComponentDependency> componentDependencies, SearchContext searchContext)
	{
		foreach (ComponentDependency componentDependency in componentDependencies)
		{
			Guid moduleUid = componentDependency.ModuleUid;
			if (moduleUid == Guid.Empty)
			{
				if (!FindConfigurationComponent(parent, itemUid, owner, componentDependency, searchContext))
				{
					return false;
				}
			}
			else if (!FindModuleComponent(itemUid, owner, moduleUid, parentComponentUid, componentDependency, searchContext))
			{
				return false;
			}
		}
		return true;
	}

	private bool FindConfigurationComponent(Guid parent, Guid parentItemUid, Guid owner, ComponentDependency dependency, SearchContext searchContext)
	{
		//Discarded unreachable code: IL_00af, IL_019d, IL_01ac, IL_022b, IL_023a, IL_024a, IL_025d, IL_0271, IL_0280, IL_0340, IL_035f, IL_036e, IL_039b, IL_03aa, IL_045c, IL_04b0, IL_04ba, IL_057b, IL_05b3, IL_05c2, IL_0605, IL_060f, IL_06cb, IL_06de, IL_0751, IL_07d0, IL_07df, IL_07ea, IL_0880, IL_08b8, IL_08c7, IL_0a91, IL_0ac9, IL_0ad8
		int num = 2;
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
		ComponentMetadataItemWrapper[] array = default(ComponentMetadataItemWrapper[]);
		IEnumerator<ComponentGraph.Vertex> enumerator = default(IEnumerator<ComponentGraph.Vertex>);
		bool item4 = default(bool);
		Guid guid2 = default(Guid);
		ClientComponentModel value2 = default(ClientComponentModel);
		bool result = default(bool);
		_003C_003Ec__DisplayClass17_1 _003C_003Ec__DisplayClass17_2 = default(_003C_003Ec__DisplayClass17_1);
		ComponentMetadataItem componentMetadataItem2 = default(ComponentMetadataItem);
		IEnumerator<ClientDataClassModel> enumerator3 = default(IEnumerator<ClientDataClassModel>);
		ClientDataClassModel current4 = default(ClientDataClassModel);
		ComponentMetadataItem value3 = default(ComponentMetadataItem);
		HashSet<string>.Enumerator enumerator5 = default(HashSet<string>.Enumerator);
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		bool item3 = default(bool);
		IEnumerable<ClientFunctionModel> item2 = default(IEnumerable<ClientFunctionModel>);
		IEnumerator<ClientFunctionModel> enumerator2 = default(IEnumerator<ClientFunctionModel>);
		ClientFunctionModel current = default(ClientFunctionModel);
		string current3 = default(string);
		IEnumerator<Guid> enumerator4 = default(IEnumerator<Guid>);
		Guid current2 = default(Guid);
		IEnumerable<ClientDataClassModel> item = default(IEnumerable<ClientDataClassModel>);
		Guid guid = default(Guid);
		IEnumerable<ComponentMetadataItemWrapper> value = default(IEnumerable<ComponentMetadataItemWrapper>);
		IEnumerable<ComponentMetadataItemWrapper> enumerable = default(IEnumerable<ComponentMetadataItemWrapper>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass17_.parent = parent;
					num2 = 13;
					break;
				case 7:
					_003C_003Ec__DisplayClass17_.owner = owner;
					num2 = 3;
					break;
				case 15:
					if (array.Length != 0)
					{
						enumerator = array.Select(_003C_003Ec__DisplayClass17_._003CFindConfigurationComponent_003Eb__1).GetEnumerator();
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 8;
						}
						break;
					}
					goto end_IL_0012;
				case 14:
					_003C_003Ec__DisplayClass17_.dependency = dependency;
					num2 = 4;
					break;
				case 8:
					try
					{
						while (true)
						{
							int num3;
							if (!Xtuo5mz2tWrRwGmUMM2(enumerator))
							{
								num3 = 13;
								goto IL_00bd;
							}
							goto IL_05de;
							IL_00bd:
							while (true)
							{
								int num8;
								switch (num3)
								{
								case 20:
									if (!item4)
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
										{
											num3 = 7;
										}
										continue;
									}
									goto case 4;
								case 4:
									if (_003C_003Ec__DisplayClass17_.searchContext.Components.TryGetValue(guid2, out value2))
									{
										num3 = 29;
										continue;
									}
									goto case 26;
								case 8:
									result = true;
									num8 = 27;
									goto IL_00b9;
								case 15:
									_003C_003Ec__DisplayClass17_2.vertex = enumerator.Current;
									num3 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
									{
										num3 = 6;
									}
									continue;
								case 22:
									componentMetadataItem2 = (loadedComponents[guid2] = ComponentMetadataItemManager.Load(guid2));
									num3 = 17;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
									{
										num3 = 13;
									}
									continue;
								case 12:
									try
									{
										while (true)
										{
											int num11;
											if (!enumerator3.MoveNext())
											{
												num11 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
												{
													num11 = 1;
												}
												goto IL_028f;
											}
											goto IL_02cf;
											IL_02cf:
											current4 = enumerator3.Current;
											int num12 = 3;
											num11 = num12;
											goto IL_028f;
											IL_028f:
											while (true)
											{
												switch (num11)
												{
												case 2:
													goto IL_02cf;
												case 3:
													_003C_003Ec__DisplayClass17_.searchContext.DataClasses[KQ588fBFfP6HcAVOGSkp(current4)] = current4;
													num11 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
													{
														num11 = 0;
													}
													continue;
												case 1:
													goto end_IL_02a9;
												}
												break;
											}
											continue;
											end_IL_02a9:
											break;
										}
									}
									finally
									{
										int num13;
										if (enumerator3 == null)
										{
											num13 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
											{
												num13 = 1;
											}
											goto IL_0344;
										}
										goto IL_0379;
										IL_0379:
										enumerator3.Dispose();
										num13 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
										{
											num13 = 2;
										}
										goto IL_0344;
										IL_0344:
										switch (num13)
										{
										case 1:
											goto end_IL_031f;
										case 2:
											goto end_IL_031f;
										}
										goto IL_0379;
										end_IL_031f:;
									}
									goto case 8;
								case 17:
									value3 = componentMetadataItem2;
									num3 = 31;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
									{
										num3 = 6;
									}
									continue;
								case 1:
									enumerator5 = _003C_003Ec__DisplayClass17_2.vertex.ViewItemUidList.GetEnumerator();
									num3 = 28;
									continue;
								case 11:
									guid2 = EKWac9zzFvThoYiiFo5(_003C_003Ec__DisplayClass17_2.vertex);
									num3 = 34;
									continue;
								case 16:
								{
									(bool result, IEnumerable<ClientFunctionModel> functionModels) functions = GetFunctions((string)BcBEmvzUHSE6Hf3AR79(componentMetadata), componentMetadata.FunctionDependencies, _003C_003Ec__DisplayClass17_.searchContext);
									item3 = functions.result;
									item2 = functions.functionModels;
									num8 = 3;
									goto IL_00b9;
								}
								case 29:
								case 32:
									if (SODVc5BFE1jGqDmIIqZJ(value2) != q4h85NBFBxYqKkIqQqF1(_003C_003Ec__DisplayClass17_2.vertex))
									{
										num3 = 25;
										continue;
									}
									goto case 1;
								case 25:
									aJiRH2BFWqD71eFO0MDW(value2, false);
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
									{
										num3 = 1;
									}
									continue;
								case 23:
									try
									{
										while (true)
										{
											IL_04fb:
											int num4;
											if (!Xtuo5mz2tWrRwGmUMM2(enumerator2))
											{
												num4 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
												{
													num4 = 1;
												}
												goto IL_04be;
											}
											goto IL_04d8;
											IL_04d8:
											current = enumerator2.Current;
											num4 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
											{
												num4 = 3;
											}
											goto IL_04be;
											IL_04be:
											while (true)
											{
												switch (num4)
												{
												case 2:
													break;
												default:
													goto IL_04fb;
												case 3:
													_003C_003Ec__DisplayClass17_.searchContext.Functions[current.HeaderUid] = current;
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
													{
														num4 = 0;
													}
													continue;
												case 1:
													goto end_IL_04fb;
												}
												break;
											}
											goto IL_04d8;
											continue;
											end_IL_04fb:
											break;
										}
									}
									finally
									{
										if (enumerator2 != null)
										{
											int num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
											{
												num5 = 1;
											}
											while (true)
											{
												switch (num5)
												{
												case 1:
													OvaV7SzejkY4BOybd2x(enumerator2);
													num5 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
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
									goto case 14;
								case 3:
									if (!item3)
									{
										num3 = 19;
										continue;
									}
									goto case 30;
								case 18:
									goto IL_05de;
								case 28:
									try
									{
										while (true)
										{
											int num9;
											if (!enumerator5.MoveNext())
											{
												num9 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
												{
													num9 = 1;
												}
												goto IL_0613;
											}
											goto IL_0653;
											IL_0653:
											current3 = enumerator5.Current;
											num9 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
											{
												num9 = 0;
											}
											goto IL_0613;
											IL_0613:
											while (true)
											{
												switch (num9)
												{
												case 2:
													break;
												case 3:
													goto IL_0653;
												default:
													value2.RenderUidList.Add(current3);
													num9 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
													{
														num9 = 2;
													}
													continue;
												case 1:
													goto end_IL_062d;
												}
												break;
											}
											continue;
											end_IL_062d:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator5).Dispose();
										int num10 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
										{
											num10 = 0;
										}
										switch (num10)
										{
										case 0:
											break;
										}
									}
									goto case 24;
								case 26:
								{
									Dictionary<Guid, ClientComponentModel> components = _003C_003Ec__DisplayClass17_.searchContext.Components;
									Guid key = guid2;
									ClientComponentModel obj = new ClientComponentModel
									{
										ItemUid = guid2
									};
									aJiRH2BFWqD71eFO0MDW(obj, q4h85NBFBxYqKkIqQqF1(_003C_003Ec__DisplayClass17_2.vertex));
									obj.RenderUidList = _003C_003Ec__DisplayClass17_2.vertex.ViewItemUidList;
									obj.Owners = _003C_003Ec__DisplayClass17_2.vertex.Owners;
									components[key] = obj;
									num3 = 2;
									continue;
								}
								case 31:
									componentMetadata = (ComponentMetadata)DFASlozYEBdlcbhTFVo(value3);
									num3 = 21;
									continue;
								case 10:
									if (ComponentMetadataItemManager == null)
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 11;
								case 34:
									if (!loadedComponents.TryGetValue(guid2, out value3))
									{
										num3 = 22;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
										{
											num3 = 8;
										}
										continue;
									}
									goto case 31;
								case 33:
									try
									{
										while (true)
										{
											int num6;
											if (!enumerator4.MoveNext())
											{
												num6 = 2;
												goto IL_07ee;
											}
											goto IL_081e;
											IL_07ee:
											while (true)
											{
												switch (num6)
												{
												case 3:
													break;
												default:
													goto IL_081e;
												case 1:
													value2.Owners.Add(current2);
													num6 = 3;
													continue;
												case 2:
													goto end_IL_0808;
												}
												break;
											}
											continue;
											IL_081e:
											current2 = enumerator4.Current;
											num6 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
											{
												num6 = 1;
											}
											goto IL_07ee;
											continue;
											end_IL_0808:
											break;
										}
									}
									finally
									{
										if (enumerator4 != null)
										{
											int num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
											{
												num7 = 0;
											}
											while (true)
											{
												switch (num7)
												{
												default:
													OvaV7SzejkY4BOybd2x(enumerator4);
													num7 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
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
									}
									goto case 2;
								case 30:
								{
									(bool result, IEnumerable<ClientDataClassModel> dataClassModels) dataClasses = GetDataClasses((string)BcBEmvzUHSE6Hf3AR79(componentMetadata), componentMetadata.DataClassDependencies, _003C_003Ec__DisplayClass17_.searchContext);
									item4 = dataClasses.result;
									item = dataClasses.dataClassModels;
									num3 = 20;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
									{
										num3 = 10;
									}
									continue;
								}
								case 21:
									if (!FindComponent(guid2, guid2, q4h85NBFBxYqKkIqQqF1(_003C_003Ec__DisplayClass17_2.vertex) ? guid2 : _003C_003Ec__DisplayClass17_.owner, guid, componentMetadata.ComponentDependencies, _003C_003Ec__DisplayClass17_.searchContext))
									{
										num3 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
										{
											num3 = 6;
										}
										continue;
									}
									goto case 16;
								case 24:
									enumerator4 = _003C_003Ec__DisplayClass17_2.vertex.Owners.Where(_003C_003Ec__DisplayClass17_2._003CFindConfigurationComponent_003Eb__2).GetEnumerator();
									num3 = 33;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
									{
										num3 = 1;
									}
									continue;
								case 2:
								case 9:
									enumerator2 = item2.Where(_003C_003Ec__DisplayClass17_._003CFindConfigurationComponent_003Eb__3).GetEnumerator();
									num3 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
									{
										num3 = 23;
									}
									continue;
								case 14:
									enumerator3 = item.Where(_003C_003Ec__DisplayClass17_._003CFindConfigurationComponent_003Eb__4).GetEnumerator();
									num3 = 12;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
									{
										num3 = 10;
									}
									continue;
								case 13:
									goto end_IL_03b5;
								case 27:
									{
										return result;
									}
									IL_00b9:
									num3 = num8;
									continue;
								}
								break;
							}
							continue;
							IL_05de:
							_003C_003Ec__DisplayClass17_2 = new _003C_003Ec__DisplayClass17_1();
							num3 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num3 = 15;
							}
							goto IL_00bd;
							continue;
							end_IL_03b5:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num14 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
							{
								num14 = 0;
							}
							while (true)
							{
								switch (num14)
								{
								default:
									OvaV7SzejkY4BOybd2x(enumerator);
									num14 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
									{
										num14 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 6;
				case 12:
					array = value.Where(_003C_003Ec__DisplayClass17_._003CFindConfigurationComponent_003Eb__0).ToArray();
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					value = enumerable;
					num2 = 12;
					break;
				case 10:
					enumerable = (_003C_003Ec__DisplayClass17_.searchContext.ComponentVersions[guid] = GetConfigurationComponentCandidates(guid));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					return false;
				case 11:
					if (!_003C_003Ec__DisplayClass17_.searchContext.ComponentVersions.TryGetValue(guid, out value))
					{
						num2 = 10;
						break;
					}
					goto case 12;
				case 5:
					_003C_003Ec__DisplayClass17_.searchContext.Errors.Add(SR.T((string)PC0R82zrUHU2qMy6Gg0(0x4DC2B14D ^ 0x4DC250D7), _003C_003Ec__DisplayClass17_.dependency.DisplayName));
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 1;
					}
					break;
				case 13:
					_003C_003Ec__DisplayClass17_.searchContext = searchContext;
					num2 = 14;
					break;
				case 3:
					guid = S8hxbYBFGlZbv2GJuYvK(_003C_003Ec__DisplayClass17_.dependency);
					num2 = 11;
					break;
				case 9:
					return false;
				case 2:
					_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					_003C_003Ec__DisplayClass17_.parentItemUid = parentItemUid;
					num2 = 7;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	private IEnumerable<ComponentMetadataItemWrapper> GetConfigurationComponentCandidates(Guid dependencyUid)
	{
		return ComponentMetadataItemManager?.GetCandidates(dependencyUid) ?? Enumerable.Empty<ComponentMetadataItemWrapper>();
	}

	public FindComponentService(IModuleReferenceManager moduleReferenceManager, IModuleMetadataLoader moduleMetadataLoader, IDependencyService dependencyService, ModuleMetadataCompatibilityChecker moduleMetadataCompatibilityChecker = null, IEnumerable<IDependencyFinder> dependencyFinders = null, ITransformationProvider transformationProvider = null, ISessionProvider sessionProvider = null)
	{
		SingletonReader.JJCZtPuTvSt();
		loadedComponents = new Dictionary<Guid, ComponentMetadataItem>();
		loadedFunctions = new Dictionary<Guid, FunctionMetadataItem>();
		moduleApplicationCacheResult = new ConcurrentDictionary<Guid, RecursiveComponentModel>();
		base._002Ector();
		this.moduleReferenceManager = moduleReferenceManager;
		this.moduleMetadataLoader = moduleMetadataLoader;
		this.dependencyService = dependencyService;
		this.moduleMetadataCompatibilityChecker = moduleMetadataCompatibilityChecker;
		this.dependencyFinders = dependencyFinders;
		this.transformationProvider = transformationProvider;
		this.sessionProvider = sessionProvider;
	}

	public RecursiveComponentModel FindComponent(Guid headerUid, FindComponentOptions options)
	{
		//Discarded unreachable code: IL_0039, IL_009f
		int num = 1;
		int num2 = num;
		SearchContext searchContext = default(SearchContext);
		RecursiveComponentModel value = default(RecursiveComponentModel);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return FindComponentInternal(headerUid, searchContext);
			case 1:
				if (RQgC0czgFSWQ4XvqAxr(options) != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 4:
				return value;
			default:
				searchContext = new SearchContext(options);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				if (!moduleApplicationCacheResult.TryGetValue(headerUid, out value))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	void IFindComponentServiceInternal.ClearCache()
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
				moduleApplicationCacheResult.Clear();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private RecursiveComponentModel FindComponentInternal(Guid headerUid, SearchContext searchContext)
	{
		//Discarded unreachable code: IL_0113, IL_011d, IL_01c2, IL_01fa, IL_0209, IL_021a, IL_0229, IL_02e1, IL_02f4, IL_0303, IL_035d, IL_036c, IL_03f0, IL_03ff, IL_04b5, IL_0594, IL_05a3, IL_05ae, IL_0677, IL_0686, IL_0692, IL_06a1, IL_0743, IL_0752, IL_075d, IL_0806, IL_0819, IL_08a2, IL_08b1, IL_08bc, IL_098a, IL_099d, IL_09b0
		int num = 36;
		_003C_003Ec__DisplayClass52_0 _003C_003Ec__DisplayClass52_ = default(_003C_003Ec__DisplayClass52_0);
		IEnumerator<ClientFunctionModel> enumerator = default(IEnumerator<ClientFunctionModel>);
		ClientFunctionModel current = default(ClientFunctionModel);
		ClientComponentModel value = default(ClientComponentModel);
		List<string>.Enumerator enumerator3 = default(List<string>.Enumerator);
		string current5 = default(string);
		KeyValuePair<Guid, ClientComponentModel> keyValuePair = default(KeyValuePair<Guid, ClientComponentModel>);
		RecursiveComponentModel recursiveComponentModel = default(RecursiveComponentModel);
		Guid guid = default(Guid);
		Dictionary<Guid, ClientComponentModel>.Enumerator enumerator4 = default(Dictionary<Guid, ClientComponentModel>.Enumerator);
		IEnumerator<ClientDataClassModel> enumerator2 = default(IEnumerator<ClientDataClassModel>);
		ClientDataClassModel current4 = default(ClientDataClassModel);
		ClientComponentModel[] array = default(ClientComponentModel[]);
		string current3 = default(string);
		ClientComponentModel value2 = default(ClientComponentModel);
		KeyValuePair<Guid, ClientComponentModel> current2 = default(KeyValuePair<Guid, ClientComponentModel>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass52_.searchContext.Clear();
					num2 = 37;
					continue;
				case 33:
					if (sDdEm3BFQbJHm5tfqV9U(_003C_003Ec__DisplayClass52_.searchContext.Components) > 0)
					{
						num2 = 32;
						continue;
					}
					goto case 28;
				case 35:
					_003C_003Ec__DisplayClass52_.searchContext = searchContext;
					num2 = 40;
					continue;
				case 5:
					try
					{
						while (true)
						{
							IL_0176:
							int num3;
							if (!Xtuo5mz2tWrRwGmUMM2(enumerator))
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
								{
									num3 = 0;
								}
								goto IL_0121;
							}
							goto IL_0153;
							IL_0153:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
							{
								num3 = 0;
							}
							goto IL_0121;
							IL_0121:
							while (true)
							{
								switch (num3)
								{
								default:
									value.Functions.Add(current);
									num3 = 3;
									continue;
								case 2:
									break;
								case 3:
									goto IL_0176;
								case 1:
									goto end_IL_0176;
								}
								break;
							}
							goto IL_0153;
							continue;
							end_IL_0176:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									OvaV7SzejkY4BOybd2x(enumerator);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 1;
				case 41:
					try
					{
						while (true)
						{
							IL_0269:
							int num12;
							if (!enumerator3.MoveNext())
							{
								num12 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num12 = 0;
								}
								goto IL_0238;
							}
							goto IL_0252;
							IL_0252:
							current5 = enumerator3.Current;
							int num13 = 3;
							num12 = num13;
							goto IL_0238;
							IL_0238:
							while (true)
							{
								switch (num12)
								{
								case 1:
									goto IL_0252;
								case 2:
									goto IL_0269;
								case 3:
									qAo95vBF8H25WWCSTQYN(Logger.Log, current5);
									num12 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
									{
										num12 = 2;
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
						((IDisposable)enumerator3).Dispose();
						int num14 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num14 = 0;
						}
						switch (num14)
						{
						case 0:
							break;
						}
					}
					goto case 21;
				case 16:
					_003C_003Ec__DisplayClass52_.searchContext.AllModules.AddRange(_003C_003Ec__DisplayClass52_.searchContext.ChosenModules);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 6;
					}
					continue;
				case 22:
					value = keyValuePair.Value;
					num2 = 3;
					continue;
				default:
					moduleApplicationCacheResult[headerUid] = recursiveComponentModel;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 5;
					}
					continue;
				case 38:
					_003C_003Ec__DisplayClass52_.searchContext.Clear();
					num = 4;
					break;
				case 27:
					recursiveComponentModel.CustomTypes.AddRange(_003C_003Ec__DisplayClass52_.searchContext.CustomTypes);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 8;
					}
					continue;
				case 34:
					guid = FindComponentRecursive(headerUid, _003C_003Ec__DisplayClass52_.searchContext);
					num2 = 33;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 19;
					}
					continue;
				case 37:
					return FindComponentInternal(headerUid, _003C_003Ec__DisplayClass52_.searchContext);
				case 17:
					enumerator4 = _003C_003Ec__DisplayClass52_.searchContext.ChosenComponentModules.GetEnumerator();
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 2;
					}
					continue;
				case 28:
					_003C_003Ec__DisplayClass52_.searchContext.Errors.Add(SR.T((string)PC0R82zrUHU2qMy6Gg0(-289714582 ^ -289689698), headerUid));
					num2 = 29;
					continue;
				case 21:
					FillEntityDependencies(recursiveComponentModel);
					num2 = 39;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 31;
					}
					continue;
				case 11:
				case 18:
					_003C_003Ec__DisplayClass52_.searchContext.Errors.Reverse();
					num2 = 7;
					continue;
				case 8:
					if (!SHwxCpBFI8kUKZhtBG8g(guid, Guid.Empty))
					{
						num2 = 18;
						continue;
					}
					goto default;
				case 26:
					In1G9QBFu5mGyHOPsJhK(recursiveComponentModel, value);
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 31;
					}
					continue;
				case 13:
					recursiveComponentModel.ExtensionPoints.AddRange(_003C_003Ec__DisplayClass52_.searchContext.ExtensionPoints);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 27;
					}
					continue;
				case 9:
					recursiveComponentModel.Errors.AddRange(_003C_003Ec__DisplayClass52_.searchContext.Errors);
					num2 = 23;
					continue;
				case 14:
					try
					{
						while (true)
						{
							int num9;
							if (!Xtuo5mz2tWrRwGmUMM2(enumerator2))
							{
								num9 = 2;
								goto IL_05b2;
							}
							goto IL_05fa;
							IL_05b2:
							while (true)
							{
								switch (num9)
								{
								case 3:
									break;
								default:
									value.DataClasses.Add(current4);
									num9 = 3;
									continue;
								case 1:
									goto IL_05fa;
								case 2:
									goto end_IL_05cc;
								}
								break;
							}
							continue;
							IL_05fa:
							current4 = enumerator2.Current;
							num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
							{
								num9 = 0;
							}
							goto IL_05b2;
							continue;
							end_IL_05cc:
							break;
						}
					}
					finally
					{
						int num11;
						if (enumerator2 == null)
						{
							int num10 = 2;
							num11 = num10;
							goto IL_063b;
						}
						goto IL_0651;
						IL_063b:
						switch (num11)
						{
						default:
							goto end_IL_0622;
						case 1:
							break;
						case 2:
							goto end_IL_0622;
						case 0:
							goto end_IL_0622;
						}
						goto IL_0651;
						IL_0651:
						OvaV7SzejkY4BOybd2x(enumerator2);
						num11 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num11 = 0;
						}
						goto IL_063b;
						end_IL_0622:;
					}
					goto case 10;
				case 23:
					enumerator3 = _003C_003Ec__DisplayClass52_.searchContext.Errors.GetEnumerator();
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
					return FindComponentInternal(headerUid, _003C_003Ec__DisplayClass52_.searchContext);
				case 20:
					if (FindModule(array, _003C_003Ec__DisplayClass52_.searchContext))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 2;
				case 25:
					recursiveComponentModel = new RecursiveComponentModel();
					num = 34;
					break;
				case 40:
					_003C_003Ec__DisplayClass52_._003C_003E4__this = this;
					num2 = 25;
					continue;
				case 19:
					try
					{
						while (true)
						{
							int num7;
							if (!enumerator3.MoveNext())
							{
								num7 = 2;
								goto IL_0761;
							}
							goto IL_07b7;
							IL_0761:
							while (true)
							{
								switch (num7)
								{
								case 1:
									qAo95vBF8H25WWCSTQYN(OnTNHEBFvIM8M49ecnRy(), current3);
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
									{
										num7 = 0;
									}
									continue;
								case 3:
									goto IL_07b7;
								case 2:
									return recursiveComponentModel;
								}
								break;
							}
							continue;
							IL_07b7:
							current3 = enumerator3.Current;
							num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
							{
								num7 = 1;
							}
							goto IL_0761;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
				case 29:
					GhjFjEBFCndCXlt42s75(_003C_003Ec__DisplayClass52_.searchContext.Errors);
					num2 = 9;
					continue;
				case 7:
					recursiveComponentModel.Errors.AddRange(_003C_003Ec__DisplayClass52_.searchContext.Errors);
					num = 24;
					break;
				case 36:
					_003C_003Ec__DisplayClass52_ = new _003C_003Ec__DisplayClass52_0();
					num = 35;
					break;
				case 12:
					return recursiveComponentModel;
				case 32:
					keyValuePair = _003C_003Ec__DisplayClass52_.searchContext.Components.First();
					num2 = 22;
					continue;
				case 39:
					return recursiveComponentModel;
				case 15:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator4.MoveNext())
							{
								num5 = 3;
								goto IL_08c0;
							}
							goto IL_094b;
							IL_08c0:
							while (true)
							{
								switch (num5)
								{
								case 2:
									break;
								case 4:
									value2 = current2.Value;
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
									{
										num5 = 0;
									}
									continue;
								default:
									_003C_003Ec__DisplayClass52_.searchContext.Components.Add(MeY255BFZT4ltNIPAYVj(value2), value2);
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
									{
										num5 = 2;
									}
									continue;
								case 1:
									goto IL_094b;
								case 3:
									goto end_IL_08de;
								}
								break;
							}
							continue;
							IL_094b:
							current2 = enumerator4.Current;
							num5 = 4;
							goto IL_08c0;
							continue;
							end_IL_08de:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 26;
				case 10:
					_003C_003Ec__DisplayClass52_.searchContext.AllModules.Clear();
					num2 = 16;
					continue;
				case 30:
					if (array.All(_003C_003Ec__DisplayClass52_._003CFindComponentInternal_003Eb__1))
					{
						num = 20;
						break;
					}
					goto case 38;
				case 24:
					enumerator3 = _003C_003Ec__DisplayClass52_.searchContext.Errors.GetEnumerator();
					num2 = 29;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 41;
					}
					continue;
				case 3:
					enumerator = _003C_003Ec__DisplayClass52_.searchContext.Functions.Values.Where(_003C_003Ec__DisplayClass52_._003CFindComponentInternal_003Eb__3).GetEnumerator();
					num2 = 5;
					continue;
				case 1:
					enumerator2 = _003C_003Ec__DisplayClass52_.searchContext.DataClasses.Values.Where(_003C_003Ec__DisplayClass52_._003CFindComponentInternal_003Eb__4).GetEnumerator();
					num2 = 14;
					continue;
				case 6:
					array = _003C_003Ec__DisplayClass52_.searchContext.Components.Values.Where((ClientComponentModel component) => _003C_003Ec.pgSCdFfcxyg867jk9orx(_003C_003Ec.ShhqEQfc7H6IQMgWUjuY(component), Guid.Empty)).ToArray();
					num2 = 30;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 26;
					}
					continue;
				case 31:
					recursiveComponentModel.ComponentCache = (from a in _003C_003Ec__DisplayClass52_.searchContext.Components.Except(new KeyValuePair<Guid, ClientComponentModel>[1] { keyValuePair })
						select a.Value).ToList();
					num2 = 13;
					continue;
				}
				break;
			}
		}
	}

	private void FillEntityDependencies(RecursiveComponentModel recursiveModel)
	{
		//Discarded unreachable code: IL_009a, IL_00a9, IL_00b4, IL_0122, IL_0132, IL_0292, IL_02a5, IL_03d6, IL_03f5, IL_0404, IL_0431, IL_0441, IL_0450, IL_045b, IL_049e, IL_04ad, IL_0532, IL_056c, IL_0606, IL_0619, IL_0628, IL_0639, IL_0643, IL_06ba, IL_06c9, IL_07a9, IL_07e3, IL_07f2, IL_0854, IL_0867, IL_089d, IL_08b0
		int num = 3;
		int num2 = num;
		FindComponentService findComponentService;
		IEnumerator<ClientComponentModel> enumerator = default(IEnumerator<ClientComponentModel>);
		RecursiveComponentModel recursiveModel2 = default(RecursiveComponentModel);
		ClientComponentModel header = default(ClientComponentModel);
		ClientComponentModel current3 = default(ClientComponentModel);
		Guid guid6 = default(Guid);
		List<ClientFunctionModel>.Enumerator enumerator5 = default(List<ClientFunctionModel>.Enumerator);
		ClientFunctionModel current4 = default(ClientFunctionModel);
		Guid guid5 = default(Guid);
		Guid itemUid2 = default(Guid);
		Guid guid4 = default(Guid);
		List<CustomTypeModel>.Enumerator enumerator4 = default(List<CustomTypeModel>.Enumerator);
		CustomTypeModel current2 = default(CustomTypeModel);
		Guid guid3 = default(Guid);
		Guid moduleItemUid2 = default(Guid);
		List<ClientExtensionPointModel>.Enumerator enumerator2 = default(List<ClientExtensionPointModel>.Enumerator);
		List<ClientImplementationModel>.Enumerator enumerator3 = default(List<ClientImplementationModel>.Enumerator);
		Guid guid = default(Guid);
		ClientImplementationModel current = default(ClientImplementationModel);
		Guid guid2 = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 3:
				findComponentService = this;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				continue;
			case 9:
				return;
			case 5:
				enumerator = recursiveModel2.ComponentCache.Concat(new ClientComponentModel[1] { header }).GetEnumerator();
				num2 = 4;
				continue;
			case 4:
				try
				{
					while (true)
					{
						int num10;
						if (!Xtuo5mz2tWrRwGmUMM2(enumerator))
						{
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
							{
								num10 = 11;
							}
							goto IL_00b8;
						}
						goto IL_039d;
						IL_039d:
						current3 = enumerator.Current;
						num10 = 3;
						goto IL_00b8;
						IL_00b8:
						while (true)
						{
							switch (num10)
							{
							case 9:
								LoadModule(MJd4j0BFSxyqrmO88VXq(current3), guid6);
								num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
								{
									num10 = 0;
								}
								continue;
							case 6:
								try
								{
									while (true)
									{
										int num11;
										if (!enumerator5.MoveNext())
										{
											num11 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
											{
												num11 = 5;
											}
											goto IL_0140;
										}
										goto IL_01ea;
										IL_01ea:
										current4 = enumerator5.Current;
										num11 = 6;
										goto IL_0140;
										IL_0140:
										while (true)
										{
											switch (num11)
											{
											case 4:
											{
												guid5 = DrepmcBFiXaxOYhG0UYT(current4);
												int num12 = 3;
												num11 = num12;
												continue;
											}
											case 7:
												if (SHwxCpBFI8kUKZhtBG8g(itemUid2, Guid.Empty))
												{
													num11 = 8;
													continue;
												}
												goto case 4;
											case 8:
												LoadFunctionConfiguration(itemUid2);
												num11 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
												{
													num11 = 4;
												}
												continue;
											case 2:
												goto IL_01ea;
											case 1:
												LoadModule(current4.ModuleUid, guid5);
												num11 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
												{
													num11 = 0;
												}
												continue;
											case 6:
												itemUid2 = current4.ItemUid;
												num11 = 7;
												continue;
											case 3:
												if (SHwxCpBFI8kUKZhtBG8g(guid5, Guid.Empty))
												{
													num11 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
													{
														num11 = 1;
													}
													continue;
												}
												break;
											case 5:
												goto end_IL_01a0;
											}
											break;
										}
										continue;
										end_IL_01a0:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator5).Dispose();
									int num13 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
									{
										num13 = 0;
									}
									switch (num13)
									{
									case 0:
										break;
									}
								}
								break;
							case 1:
								LoadComponentConfiguration(guid4);
								num10 = 5;
								continue;
							case 3:
								guid4 = E9tAxZBFV0HgOdgjNQ3I(current3);
								num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
								{
									num10 = 7;
								}
								continue;
							case 2:
								if (!(guid6 != Guid.Empty))
								{
									num10 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
									{
										num10 = 1;
									}
									continue;
								}
								goto case 9;
							default:
								enumerator5 = current3.Functions.GetEnumerator();
								num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
								{
									num10 = 6;
								}
								continue;
							case 10:
								break;
							case 7:
								if (SHwxCpBFI8kUKZhtBG8g(guid4, Guid.Empty))
								{
									num10 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
									{
										num10 = 1;
									}
									continue;
								}
								goto case 5;
							case 5:
								guid6 = MeY255BFZT4ltNIPAYVj(current3);
								num10 = 2;
								continue;
							case 8:
								goto IL_039d;
							case 11:
								goto end_IL_0339;
							}
							break;
						}
						continue;
						end_IL_0339:
						break;
					}
				}
				finally
				{
					int num14;
					if (enumerator == null)
					{
						num14 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num14 = 0;
						}
						goto IL_03da;
					}
					goto IL_040f;
					IL_040f:
					OvaV7SzejkY4BOybd2x(enumerator);
					num14 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num14 = 2;
					}
					goto IL_03da;
					IL_03da:
					switch (num14)
					{
					default:
						goto end_IL_03b5;
					case 0:
						goto end_IL_03b5;
					case 1:
						break;
					case 2:
						goto end_IL_03b5;
					}
					goto IL_040f;
					end_IL_03b5:;
				}
				break;
			default:
				try
				{
					while (true)
					{
						IL_05a1:
						int num8;
						if (!enumerator4.MoveNext())
						{
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
							{
								num8 = 0;
							}
							goto IL_045f;
						}
						goto IL_05c7;
						IL_05c7:
						current2 = enumerator4.Current;
						num8 = 7;
						goto IL_045f;
						IL_045f:
						while (true)
						{
							switch (num8)
							{
							case 7:
								guid3 = RoQqCaBFRmwxZQEEr95e(current2);
								num8 = 9;
								continue;
							case 1:
							case 4:
								moduleItemUid2 = current2.ModuleItemUid;
								num8 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
								{
									num8 = 3;
								}
								continue;
							case 5:
								LoadComponentConfiguration(guid3);
								num8 = 11;
								continue;
							case 3:
								if (!SHwxCpBFI8kUKZhtBG8g(moduleItemUid2, Guid.Empty))
								{
									num8 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
									{
										num8 = 0;
									}
									continue;
								}
								goto case 8;
							case 9:
								if (!SHwxCpBFI8kUKZhtBG8g(guid3, Guid.Empty))
								{
									num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
									{
										num8 = 1;
									}
									continue;
								}
								goto case 5;
							case 8:
								LoadModule(current2.ModuleUid, moduleItemUid2);
								num8 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
								{
									num8 = 10;
								}
								continue;
							case 6:
							case 10:
							case 11:
								goto IL_05a1;
							case 2:
								goto IL_05c7;
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
					((IDisposable)enumerator4).Dispose();
					int num9 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num9 = 0;
					}
					switch (num9)
					{
					case 0:
						break;
					}
				}
				goto case 6;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator2.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
							{
								num3 = 1;
							}
							goto IL_0647;
						}
						goto IL_0687;
						IL_0687:
						enumerator3 = enumerator2.Current.Implementations.GetEnumerator();
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num3 = 0;
						}
						goto IL_0647;
						IL_0647:
						switch (num3)
						{
						case 1:
							return;
						case 3:
							continue;
						case 2:
							goto IL_0687;
						}
						try
						{
							while (true)
							{
								IL_0773:
								int num4;
								if (!enumerator3.MoveNext())
								{
									num4 = 10;
									goto IL_06d8;
								}
								goto IL_070e;
								IL_06d8:
								while (true)
								{
									int num5;
									switch (num4)
									{
									case 1:
										guid = anstrnBFq6qDS1uSunmG(current);
										num5 = 8;
										goto IL_06d4;
									case 5:
										LoadComponentConfiguration(guid);
										num5 = 7;
										goto IL_06d4;
									case 3:
									case 9:
										guid2 = u9VTAiBFKr2hcEsUT9CQ(current);
										num4 = 4;
										continue;
									case 6:
									case 7:
										goto IL_0773;
									case 2:
										LoadModule(zZ5tqXBFXc8CW3jfJJC3(current), guid2);
										num4 = 6;
										continue;
									case 4:
										if (SHwxCpBFI8kUKZhtBG8g(guid2, Guid.Empty))
										{
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
											{
												num4 = 2;
											}
											continue;
										}
										goto IL_0773;
									case 8:
										if (!SHwxCpBFI8kUKZhtBG8g(guid, Guid.Empty))
										{
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
											{
												num4 = 9;
											}
											continue;
										}
										goto case 5;
									case 10:
										goto end_IL_0773;
										IL_06d4:
										num4 = num5;
										continue;
									}
									break;
								}
								goto IL_070e;
								IL_070e:
								current = enumerator3.Current;
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
								{
									num4 = 0;
								}
								goto IL_06d8;
								continue;
								end_IL_0773:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator3).Dispose();
							int num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
							{
								num6 = 0;
							}
							switch (num6)
							{
							case 0:
								break;
							}
						}
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
			case 6:
				enumerator2 = recursiveModel2.ExtensionPoints.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				continue;
			case 8:
				header = recursiveModel2.Header;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 5;
				}
				continue;
			case 2:
				recursiveModel2 = recursiveModel;
				num2 = 8;
				continue;
			case 7:
				break;
			}
			enumerator4 = recursiveModel2.CustomTypes.GetEnumerator();
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
			{
				num2 = 0;
			}
		}
	}

	private static IEnumerable<Guid> GetEntityMetadataGuids(IEnumerable<EntityDependency> entityDependencies)
	{
		List<EntityMetadata> list = new List<EntityMetadata>();
		foreach (EntityDependency entityDependency in entityDependencies)
		{
			try
			{
				if (MetadataServiceContext.Service.GetMetadata(entityDependency.HeaderUid) is EntityMetadata item)
				{
					list.Add(item);
				}
			}
			catch
			{
			}
		}
		HashSet<EntityMetadata> hashSet = new HashSet<EntityMetadata>();
		foreach (EntityMetadata item2 in list)
		{
			hashSet.Add(item2);
			foreach (ClassMetadata childClass in MetadataLoader.GetChildClasses(item2))
			{
				try
				{
					hashSet.Add((EntityMetadata)MetadataServiceContext.Service.GetMetadata(childClass.Uid));
				}
				catch
				{
				}
			}
			foreach (ClassMetadata baseClass in MetadataLoader.GetBaseClasses(item2))
			{
				try
				{
					hashSet.Add((EntityMetadata)MetadataServiceContext.Service.GetMetadata(baseClass.Uid));
				}
				catch
				{
				}
			}
		}
		return hashSet.Select((EntityMetadata a) => _003C_003Ec.XRNhnPfcmoy5wWgdQfjw(a));
	}

	private (bool result, IEnumerable<ClientDataClassModel> dataClassModels) GetDataClasses(string componentName, IReadOnlyCollection<DataClassDependency> dataClassDependencies, SearchContext searchContext, bool throwException = false)
	{
		if (dataClassDependencies.Count == 0)
		{
			return (true, Enumerable.Empty<ClientDataClassModel>());
		}
		var (flag, item) = GetRuntimeDataClasses(dataClassDependencies, searchContext);
		if (flag)
		{
			return (true, item);
		}
		if (throwException)
		{
			searchContext.Errors.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137960567), componentName));
			return (false, Enumerable.Empty<ClientDataClassModel>());
		}
		return (false, Enumerable.Empty<ClientDataClassModel>());
	}

	private (bool result, IEnumerable<ClientDataClassModel> dataClassModels) GetRuntimeDataClasses(IEnumerable<DataClassDependency> dataClassDependencies, SearchContext searchContext)
	{
		Dictionary<Guid, ClientDataClassModel> dictionary = new Dictionary<Guid, ClientDataClassModel>();
		foreach (DataClassDependency dataClassDependency in dataClassDependencies)
		{
			if (dataClassDependency.ModuleUid == Guid.Empty)
			{
				if (!GetDataClassFromConfiguration(dataClassDependency, searchContext, dictionary))
				{
					return (false, Enumerable.Empty<ClientDataClassModel>());
				}
			}
			else if (!GetDataClassFromModule(dataClassDependency, searchContext, dictionary))
			{
				return (false, Enumerable.Empty<ClientDataClassModel>());
			}
		}
		return (true, dictionary.Values);
	}

	private bool GetDataClassFromConfiguration(Dependency dependency, SearchContext searchContext, IDictionary<Guid, ClientDataClassModel> result)
	{
		Guid headerUid = dependency.HeaderUid;
		if (result.ContainsKey(headerUid))
		{
			return true;
		}
		DataClassMetadataItemHeader dataClassMetadataItemHeader = DataClassMetadataItemHeaderManager?.LoadOrNull(headerUid);
		if (dataClassMetadataItemHeader == null)
		{
			searchContext.Errors.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A5C054), dependency.DisplayName, headerUid));
			return false;
		}
		DataClassMetadataItem published = dataClassMetadataItemHeader.Published;
		if (published == null)
		{
			searchContext.Errors.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978518646), dependency.DisplayName, headerUid));
			return false;
		}
		result[headerUid] = new ClientDataClassModel
		{
			HeaderUid = headerUid,
			ItemUid = published.Uid
		};
		return true;
	}

	private bool FindConfigurationImpl(Guid parent, Guid itemUid, Guid owner, Guid parentComponentUid, ComponentMetadataItem item, SearchContext searchContext)
	{
		int num = 1;
		int num2 = num;
		ComponentSignature componentSignature = default(ComponentSignature);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if ((componentSignature = nlTaJcBFT5Ie2t4OOk9o(item) as ComponentSignature) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			default:
				return FindImplInternal(parent, itemUid, owner, parentComponentUid, componentSignature.ExtensionPoints, searchContext);
			}
		}
	}

	private bool FindModuleImpl(Guid parent, Guid itemUid, Guid owner, Guid parentComponentUid, ModuleVersion moduleVersion, SearchContext searchContext)
	{
		int num = 2;
		_003C_003Ec__DisplayClass59_0 _003C_003Ec__DisplayClass59_ = default(_003C_003Ec__DisplayClass59_0);
		List<ImplementationSignature> extensionPoints = default(List<ImplementationSignature>);
		IEnumerable<ImplementationSignature> second = default(IEnumerable<ImplementationSignature>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass59_ = new _003C_003Ec__DisplayClass59_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					return FindImplInternal(parent, itemUid, owner, parentComponentUid, extensionPoints.Concat(second).ToList(), _003C_003Ec__DisplayClass59_.searchContext);
				case 1:
					_003C_003Ec__DisplayClass59_.searchContext = searchContext;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					second = (from m in ((ModuleInfoMetadata)iMlyy1ztkAWCr8rEdWj(moduleVersion)).DependencyModules.Select(_003C_003Ec__DisplayClass59_._003CFindModuleImpl_003Eb__0)
						where m != null
						select m).SelectMany((ModuleVersion m) => m.Header.Signature.ExtensionPoints);
					num2 = 3;
					continue;
				}
				break;
			}
			extensionPoints = ((ModuleSignature)Myq9P5BFkln6ljxvfiBh(moduleVersion.Header)).ExtensionPoints;
			num = 4;
		}
	}

	private bool FindImplInternal(Guid parent, Guid itemUid, Guid owner, Guid parentComponentUid, List<ImplementationSignature> extensionPoints, SearchContext searchContext)
	{
		_003C_003Ec__DisplayClass60_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass60_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.searchContext = searchContext;
		if (parent == Guid.Empty)
		{
			return true;
		}
		if (extensionPoints.Count == 0)
		{
			return true;
		}
		if (CS_0024_003C_003E8__locals0.searchContext.CacheLastPublishedComponents.Count == 0)
		{
			CS_0024_003C_003E8__locals0.searchContext.CacheLastPublishedComponents.AddRange(GetLastPublishedComponents().Where(delegate(ComponentMetadataItemWrapper item)
			{
				//Discarded unreachable code: IL_0068, IL_0077
				int num13 = 1;
				ComponentSignature componentSignature = default(ComponentSignature);
				while (true)
				{
					int num14 = num13;
					while (true)
					{
						switch (num14)
						{
						default:
							if (componentSignature != null)
							{
								goto end_IL_0012;
							}
							goto case 2;
						case 1:
							componentSignature = (ComponentSignature)_003C_003Ec.ArdWkkfcDyYnjCXt3mlt(item);
							num14 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
							{
								num14 = 0;
							}
							break;
						case 2:
							return false;
						case 3:
							return componentSignature.Implementations.Any();
						}
						continue;
						end_IL_0012:
						break;
					}
					num13 = 3;
				}
			}));
		}
		if (CS_0024_003C_003E8__locals0.searchContext.CacheRuntimeModules.Count == 0)
		{
			ModuleVersion[] array = (from w in GetAdditionalModules()
				select CS_0024_003C_003E8__locals0._003C_003E4__this.moduleMetadataLoader.GetSpecificModuleVersion(_003C_003Ec__DisplayClass60_0.Y0THF0QFBrUKJEyb0kPI(w), _003C_003Ec__DisplayClass60_0.XAiSAoQFWhvZqkNagebV(w))).ToArray();
			IEnumerable<Guid> excluded = array.Select((ModuleVersion m) => _003C_003Ec.c5ynBufcHHweeI3ve4iw(m.Header));
			CS_0024_003C_003E8__locals0.searchContext.CacheRuntimeModules.AddRange(array.Concat(moduleMetadataLoader.GetAllDefaultVersions(excluded)));
		}
		if (CS_0024_003C_003E8__locals0.searchContext.CacheImplementationModules.Count == 0 && CS_0024_003C_003E8__locals0.searchContext.CacheRuntimeModules.Count > 0)
		{
			CS_0024_003C_003E8__locals0.searchContext.CacheImplementationModules.AddRange(CS_0024_003C_003E8__locals0.searchContext.CacheRuntimeModules.Where((ModuleVersion item) => _003C_003Ec.pZScyGfcygmr2jmD5OD7(((ModuleVersionHeader)_003C_003Ec.u1os3Xfc6rAqw6yX12Cg(item)).Signature.Implementations) > 0));
		}
		if (CS_0024_003C_003E8__locals0.searchContext.CacheLastPublishedDataClasses.Count == 0)
		{
			CS_0024_003C_003E8__locals0.searchContext.CacheLastPublishedDataClasses.AddRange(GetLastPublishedDataClasses());
		}
		using (List<ImplementationSignature>.Enumerator enumerator = extensionPoints.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass60_3 _003C_003Ec__DisplayClass60_ = new _003C_003Ec__DisplayClass60_3();
				_003C_003Ec__DisplayClass60_.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
				_003C_003Ec__DisplayClass60_.extensionPoint = enumerator.Current;
				_003C_003Ec__DisplayClass60_4 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass60_4();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass60_;
				if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.extensionPoint.TypeUid == Guid.Empty)
				{
					continue;
				}
				CS_0024_003C_003E8__locals1.types = new Dictionary<Guid, ClientDataClassModel>();
				GetIncludes(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.extensionPoint.TypeUid, Guid.Empty, Guid.Empty, CS_0024_003C_003E8__locals1.types, onlyModules: false);
				ClientExtensionPointModel clientExtensionPointModel = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.searchContext.ExtensionPoints.FirstOrDefault(delegate(ClientExtensionPointModel i)
				{
					//Discarded unreachable code: IL_002d, IL_003c
					int num11 = 2;
					int num12 = num11;
					while (true)
					{
						switch (num12)
						{
						default:
							return _003C_003Ec__DisplayClass60_3.hN5qmTQFnU5ij5U0EgQQ(_003C_003Ec__DisplayClass60_3.FUdjcnQFkVuqOnEJAgyw(i), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.extensionPoint.TypeUid);
						case 1:
							return false;
						case 2:
							if (!_003C_003Ec__DisplayClass60_3.UNBInUQFTJjJb4LPmIjw(_003C_003Ec__DisplayClass60_3.tyd6FhQFKRvJpqykqEG3(i), _003C_003Ec__DisplayClass60_3.vlFNfjQFX76W7qRpV5RR(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.extensionPoint)))
							{
								num12 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
								{
									num12 = 0;
								}
								break;
							}
							goto default;
						}
					}
				});
				if (clientExtensionPointModel != null)
				{
					continue;
				}
				clientExtensionPointModel = new ClientExtensionPointModel
				{
					PointId = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.extensionPoint.PointId,
					TypeUid = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.extensionPoint.TypeUid
				};
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.searchContext.ExtensionPoints.Add(clientExtensionPointModel);
				foreach (ComponentMetadataItemWrapper cacheLastPublishedComponent in CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.searchContext.CacheLastPublishedComponents)
				{
					if (cacheLastPublishedComponent.Signature.Implementations.Any(delegate(ImplementationSignature i)
					{
						//Discarded unreachable code: IL_0045, IL_00fa, IL_0109, IL_011a, IL_0129, IL_0134, IL_01e3, IL_0213, IL_0222, IL_022e, IL_023d
						int num7 = 8;
						_003C_003Ec__DisplayClass60_5 _003C_003Ec__DisplayClass60_4 = default(_003C_003Ec__DisplayClass60_5);
						IEnumerator<KeyValuePair<Guid, ClientDataClassModel>> enumerator9 = default(IEnumerator<KeyValuePair<Guid, ClientDataClassModel>>);
						KeyValuePair<Guid, ClientDataClassModel> current6 = default(KeyValuePair<Guid, ClientDataClassModel>);
						while (true)
						{
							int num8 = num7;
							while (true)
							{
								switch (num8)
								{
								case 6:
									if (!_003C_003Ec__DisplayClass60_4.vBPSFbQFpXfuCD2VpBxc(_003C_003Ec__DisplayClass60_4.Fa1XD6QF3rV69VaMtxpo(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.extensionPoint)))
									{
										num8 = 3;
										break;
									}
									goto case 2;
								case 1:
									if (!CS_0024_003C_003E8__locals1.types.All(_003C_003Ec__DisplayClass60_4._003CFindImplInternal_003Eb__15))
									{
										goto end_IL_0012;
									}
									goto case 4;
								case 8:
									_003C_003Ec__DisplayClass60_4 = new _003C_003Ec__DisplayClass60_5();
									num8 = 7;
									break;
								case 7:
									_003C_003Ec__DisplayClass60_4.i = i;
									num8 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
									{
										num8 = 0;
									}
									break;
								case 2:
									return true;
								case 3:
									return (string)_003C_003Ec__DisplayClass60_4.Fa1XD6QF3rV69VaMtxpo(_003C_003Ec__DisplayClass60_4.i) == (string)_003C_003Ec__DisplayClass60_4.Fa1XD6QF3rV69VaMtxpo(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.extensionPoint);
								default:
									try
									{
										while (true)
										{
											int num9;
											if (!_003C_003Ec__DisplayClass60_4.xAHTQoQF1WRbMqE1bfrj(enumerator9))
											{
												num9 = 2;
												goto IL_0138;
											}
											goto IL_019a;
											IL_0138:
											while (true)
											{
												switch (num9)
												{
												case 1:
													CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.searchContext.DataClasses[current6.Key] = current6.Value;
													num9 = 3;
													continue;
												case 3:
													break;
												default:
													goto IL_019a;
												case 2:
													goto end_IL_0184;
												}
												break;
											}
											continue;
											IL_019a:
											current6 = enumerator9.Current;
											num9 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
											{
												num9 = 0;
											}
											goto IL_0138;
											continue;
											end_IL_0184:
											break;
										}
									}
									finally
									{
										int num10;
										if (enumerator9 == null)
										{
											num10 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
											{
												num10 = 1;
											}
											goto IL_01e7;
										}
										goto IL_01fd;
										IL_01fd:
										_003C_003Ec__DisplayClass60_4.IPi6m7QFNCnaRfLtDk70(enumerator9);
										num10 = 2;
										goto IL_01e7;
										IL_01e7:
										switch (num10)
										{
										case 1:
											goto end_IL_01c2;
										case 2:
											goto end_IL_01c2;
										}
										goto IL_01fd;
										end_IL_01c2:;
									}
									goto case 6;
								case 4:
									return false;
								case 5:
									enumerator9 = CS_0024_003C_003E8__locals1.types.Where((KeyValuePair<Guid, ClientDataClassModel> dataClass) => !CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.searchContext.DataClasses.ContainsKey(dataClass.Key)).GetEnumerator();
									num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
									{
										num8 = 0;
									}
									break;
								}
								continue;
								end_IL_0012:
								break;
							}
							num7 = 5;
						}
					}) && FindImplConfigurationComponent(parent, itemUid, owner, cacheLastPublishedComponent, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.searchContext))
					{
						clientExtensionPointModel.Implementations.Add(new ClientImplementationModel
						{
							HeaderUid = cacheLastPublishedComponent.HeaderUid,
							ItemUid = cacheLastPublishedComponent.Uid
						});
					}
				}
				foreach (ModuleVersion cacheImplementationModule in CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.searchContext.CacheImplementationModules)
				{
					if (!cacheImplementationModule.Header.Signature.Implementations.Any(delegate(ImplementationSignature i)
					{
						//Discarded unreachable code: IL_00dd, IL_00ec
						int num5 = 3;
						int num6 = num5;
						_003C_003Ec__DisplayClass60_6 _003C_003Ec__DisplayClass60_3 = default(_003C_003Ec__DisplayClass60_6);
						while (true)
						{
							switch (num6)
							{
							default:
								if (!CS_0024_003C_003E8__locals1.types.All(_003C_003Ec__DisplayClass60_3._003CFindImplInternal_003Eb__19))
								{
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
									{
										num6 = 1;
									}
									break;
								}
								goto case 4;
							case 4:
								return false;
							case 1:
								if (!string.IsNullOrWhiteSpace((string)_003C_003Ec__DisplayClass60_4.Fa1XD6QF3rV69VaMtxpo(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.extensionPoint)))
								{
									num6 = 6;
									break;
								}
								goto case 5;
							case 2:
								_003C_003Ec__DisplayClass60_3.i = i;
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
								{
									num6 = 0;
								}
								break;
							case 3:
								_003C_003Ec__DisplayClass60_3 = new _003C_003Ec__DisplayClass60_6();
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
								{
									num6 = 2;
								}
								break;
							case 5:
								return true;
							case 6:
								return _003C_003Ec__DisplayClass60_4.OhShT3QFaOKRRtQKMxhV(_003C_003Ec__DisplayClass60_4.Fa1XD6QF3rV69VaMtxpo(_003C_003Ec__DisplayClass60_3.i), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.extensionPoint.PointId);
							}
						}
					}))
					{
						continue;
					}
					foreach (ComponentMetadata item in cacheImplementationModule.Metadata.Components.Where((ComponentMetadata c) => c.Implementations.Any(delegate(Implementation i)
					{
						int num3 = 1;
						_003C_003Ec__DisplayClass60_7 _003C_003Ec__DisplayClass60_2 = default(_003C_003Ec__DisplayClass60_7);
						while (true)
						{
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								case 1:
									_003C_003Ec__DisplayClass60_2 = new _003C_003Ec__DisplayClass60_7();
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
									{
										num4 = 0;
									}
									break;
								default:
									_003C_003Ec__DisplayClass60_2.i = i;
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
									{
										num4 = 2;
									}
									break;
								case 3:
									return false;
								case 2:
									if (!CS_0024_003C_003E8__locals1.types.All(_003C_003Ec__DisplayClass60_2._003CFindImplInternal_003Eb__21))
									{
										if (!_003C_003Ec__DisplayClass60_4.vBPSFbQFpXfuCD2VpBxc(_003C_003Ec__DisplayClass60_4.Fa1XD6QF3rV69VaMtxpo(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.extensionPoint)))
										{
											return _003C_003Ec__DisplayClass60_4.OhShT3QFaOKRRtQKMxhV(_003C_003Ec__DisplayClass60_4.jyjImoQFDE2wqa7M96a7(_003C_003Ec__DisplayClass60_2.i), _003C_003Ec__DisplayClass60_4.Fa1XD6QF3rV69VaMtxpo(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.extensionPoint));
										}
										goto end_IL_0012;
									}
									num4 = 3;
									break;
								case 4:
									return true;
								}
								continue;
								end_IL_0012:
								break;
							}
							num3 = 4;
						}
					})))
					{
						if (FindImplModuleComponent(parent, itemUid, owner, parentComponentUid, item, cacheImplementationModule, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.searchContext))
						{
							clientExtensionPointModel.Implementations.Add(new ClientImplementationModel
							{
								HeaderUid = item.Uid,
								ModuleItemUid = cacheImplementationModule.Header.VersionUid,
								ModuleUid = cacheImplementationModule.Header.HeaderUid
							});
						}
					}
				}
			}
		}
		return true;
		void GetIncludes(Guid uid, Guid iUid, Guid mUid, Dictionary<Guid, ClientDataClassModel> list, bool onlyModules)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass60_1();
			CS_0024_003C_003E8__locals0.uid = uid;
			if (CS_0024_003C_003E8__locals0.searchContext.CacheIncludeDataClasses.ContainsKey(CS_0024_003C_003E8__locals0.uid))
			{
				foreach (KeyValuePair<Guid, ClientDataClassModel> item2 in CS_0024_003C_003E8__locals0.searchContext.CacheIncludeDataClasses[CS_0024_003C_003E8__locals0.uid])
				{
					list.Add(item2.Key, item2.Value);
				}
				return;
			}
			if (iUid == Guid.Empty && mUid == Guid.Empty)
			{
				DataClassMetadataItem dataClassMetadataItem = CS_0024_003C_003E8__locals0.searchContext.CacheLastPublishedDataClasses.Find((DataClassMetadataItem i) => _003C_003Ec__DisplayClass60_1.fs0Ot7QFfvu8T8CJmu35(_003C_003Ec__DisplayClass60_1.wNc7UvQFEVbr39OrU0L6(_003C_003Ec__DisplayClass60_1.rsNGrNQFGIalq2guD1oO(i)), CS_0024_003C_003E8__locals0.uid));
				if (dataClassMetadataItem != null)
				{
					iUid = dataClassMetadataItem.Uid;
				}
				else
				{
					mUid = CS_0024_003C_003E8__locals0.searchContext.CacheRuntimeModules.Find((ModuleVersion m) => ((ModuleInfoMetadata)_003C_003Ec__DisplayClass60_1.ERwujfQFQcSBo1URodsC(m)).DataClasses.Any((DataClassMetadata d) => _003C_003Ec__DisplayClass60_1.fs0Ot7QFfvu8T8CJmu35(_003C_003Ec__DisplayClass60_1.iQWivMQFCJOqfwHQrxNS(d), CS_0024_003C_003E8__locals0.uid))).Header.VersionUid;
				}
			}
			list.Add(CS_0024_003C_003E8__locals0.uid, new ClientDataClassModel
			{
				HeaderUid = CS_0024_003C_003E8__locals0.uid,
				ItemUid = iUid,
				ModuleItemUid = mUid
			});
			if (!onlyModules)
			{
				foreach (DataClassMetadataItem item3 in CS_0024_003C_003E8__locals0.searchContext.CacheLastPublishedDataClasses.Where(delegate(DataClassMetadataItem item)
				{
					//Discarded unreachable code: IL_0031, IL_0040
					int num = 1;
					int num2 = num;
					DataClassMetadata dataClassMetadata = default(DataClassMetadata);
					while (true)
					{
						switch (num2)
						{
						case 1:
							dataClassMetadata = _003C_003Ec__DisplayClass60_1.P19j3MQFvSGNVUJUOUJM(item) as DataClassMetadata;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
							{
								num2 = 0;
							}
							break;
						default:
							if (dataClassMetadata != null)
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
								{
									num2 = 3;
								}
								break;
							}
							goto case 2;
						case 2:
							return false;
						case 3:
							return dataClassMetadata.IncludeList.Any((DataClassDependency i) => _003C_003Ec__DisplayClass60_1.UviXkcQF8rK4vv3b6rgy(i) == CS_0024_003C_003E8__locals0.uid);
						}
					}
				}))
				{
					GetIncludes(item3.Header.Uid, item3.Uid, Guid.Empty, list, onlyModules: false);
				}
			}
			List<DataClassMetadata> list2 = new List<DataClassMetadata>();
			foreach (ModuleVersion cacheRuntimeModule in CS_0024_003C_003E8__locals0.searchContext.CacheRuntimeModules)
			{
				ModuleInfoMetadata metadata = cacheRuntimeModule.Metadata;
				list2.AddRange(metadata.DataClasses.Where((DataClassMetadata d) => d.IncludeList.Any((DataClassDependency i) => _003C_003Ec__DisplayClass60_1.UviXkcQF8rK4vv3b6rgy(i) == CS_0024_003C_003E8__locals0.uid)));
			}
			using (List<DataClassMetadata>.Enumerator enumerator8 = list2.GetEnumerator())
			{
				while (enumerator8.MoveNext())
				{
					_003C_003Ec__DisplayClass60_2 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass60_2();
					CS_0024_003C_003E8__locals1.moduleDtoType = enumerator8.Current;
					Guid versionUid = CS_0024_003C_003E8__locals0.searchContext.CacheRuntimeModules.Find((ModuleVersion m) => _003C_003Ec__DisplayClass60_2.slbmWDQFVaepnMpHPgDy(m.Header.HeaderUid, CS_0024_003C_003E8__locals1.moduleDtoType.ModuleUid)).Header.VersionUid;
					GetIncludes(CS_0024_003C_003E8__locals1.moduleDtoType.Uid, Guid.Empty, versionUid, list, onlyModules: true);
				}
			}
			CS_0024_003C_003E8__locals0.searchContext.CacheIncludeDataClasses.Add(CS_0024_003C_003E8__locals0.uid, list);
		}
	}

	private IEnumerable<DataClassMetadataItem> GetLastPublishedDataClasses()
	{
		return DataClassMetadataItemManager?.GetLastPublished() ?? Enumerable.Empty<DataClassMetadataItem>();
	}

	private IEnumerable<ComponentMetadataItemWrapper> GetLastPublishedComponents()
	{
		return ComponentMetadataItemManager?.GetLastPublished() ?? Enumerable.Empty<ComponentMetadataItemWrapper>();
	}

	private bool FindImplConfigurationComponent(Guid parent, Guid parentItemUid, Guid owner, ComponentMetadataItemWrapper componentMetadataWrapper, SearchContext searchContext)
	{
		//Discarded unreachable code: IL_010e, IL_011d, IL_0128, IL_01ce, IL_0206, IL_0216, IL_0220, IL_02dc, IL_02ef, IL_02fe, IL_037c, IL_038b, IL_039c, IL_03ab, IL_03b6, IL_0457, IL_0497, IL_04a6, IL_04b2, IL_056e, IL_057d, IL_0588, IL_0649, IL_0668, IL_0677, IL_06a4, IL_0744, IL_0753
		int num = 4;
		_003C_003Ec__DisplayClass63_0 _003C_003Ec__DisplayClass63_ = default(_003C_003Ec__DisplayClass63_0);
		Guid itemUid = default(Guid);
		IEnumerator<Guid> enumerator = default(IEnumerator<Guid>);
		Guid current = default(Guid);
		ClientComponentModel value2 = default(ClientComponentModel);
		HashSet<string>.Enumerator enumerator4 = default(HashSet<string>.Enumerator);
		string current4 = default(string);
		ComponentMetadataItem componentMetadataItem = default(ComponentMetadataItem);
		bool item2 = default(bool);
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		bool item3 = default(bool);
		IEnumerable<ClientDataClassModel> item4 = default(IEnumerable<ClientDataClassModel>);
		IEnumerator<ClientDataClassModel> enumerator3 = default(IEnumerator<ClientDataClassModel>);
		ClientDataClassModel current2 = default(ClientDataClassModel);
		Guid parentComponentUid = default(Guid);
		ComponentMetadataItem value = default(ComponentMetadataItem);
		IEnumerator<ClientFunctionModel> enumerator2 = default(IEnumerator<ClientFunctionModel>);
		ClientFunctionModel current3 = default(ClientFunctionModel);
		IEnumerable<ClientFunctionModel> item = default(IEnumerable<ClientFunctionModel>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 23:
				{
					Dictionary<Guid, ClientComponentModel> components = _003C_003Ec__DisplayClass63_.searchContext.Components;
					Guid key = itemUid;
					ClientComponentModel clientComponentModel = new ClientComponentModel();
					gHf6qOBFF83pESH2yeSb(clientComponentModel, itemUid);
					clientComponentModel.Async = q4h85NBFBxYqKkIqQqF1(_003C_003Ec__DisplayClass63_.vertex);
					clientComponentModel.RenderUidList = _003C_003Ec__DisplayClass63_.vertex.ViewItemUidList;
					clientComponentModel.Owners = _003C_003Ec__DisplayClass63_.vertex.Owners;
					components[key] = clientComponentModel;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 11;
					}
					continue;
				}
				default:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
								{
									num3 = 1;
								}
								goto IL_012c;
							}
							goto IL_0195;
							IL_0195:
							current = enumerator.Current;
							num3 = 3;
							goto IL_012c;
							IL_012c:
							while (true)
							{
								switch (num3)
								{
								case 2:
									break;
								case 3:
									value2.Owners.Add(current);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
									{
										num3 = 2;
									}
									continue;
								default:
									goto IL_0195;
								case 1:
									goto end_IL_0146;
								}
								break;
							}
							continue;
							end_IL_0146:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									enumerator.Dispose();
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
									{
										num4 = 1;
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
				case 21:
					try
					{
						while (true)
						{
							IL_028a:
							int num9;
							if (!enumerator4.MoveNext())
							{
								num9 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
								{
									num9 = 1;
								}
								goto IL_0224;
							}
							goto IL_0267;
							IL_0267:
							current4 = enumerator4.Current;
							num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
							{
								num9 = 0;
							}
							goto IL_0224;
							IL_0224:
							while (true)
							{
								switch (num9)
								{
								default:
									value2.RenderUidList.Add(current4);
									num9 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
									{
										num9 = 2;
									}
									continue;
								case 3:
									break;
								case 2:
									goto IL_028a;
								case 1:
									goto end_IL_028a;
								}
								break;
							}
							goto IL_0267;
							continue;
							end_IL_028a:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
						int num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num10 = 0;
						}
						switch (num10)
						{
						case 0:
							break;
						}
					}
					goto case 18;
				case 5:
					enumerator4 = _003C_003Ec__DisplayClass63_.vertex.ViewItemUidList.GetEnumerator();
					num = 21;
					break;
				case 30:
					componentMetadataItem = (loadedComponents[itemUid] = ComponentMetadataItemManager.Load(itemUid));
					num2 = 12;
					continue;
				case 28:
				{
					if (!item2)
					{
						num2 = 26;
						continue;
					}
					(bool result, IEnumerable<ClientDataClassModel> dataClassModels) dataClasses = GetDataClasses((string)BcBEmvzUHSE6Hf3AR79(componentMetadata), componentMetadata.DataClassDependencies, _003C_003Ec__DisplayClass63_.searchContext);
					item3 = dataClasses.result;
					item4 = dataClasses.dataClassModels;
					num2 = 10;
					continue;
				}
				case 10:
					if (!item3)
					{
						num = 14;
						break;
					}
					if (!_003C_003Ec__DisplayClass63_.searchContext.Components.TryGetValue(itemUid, out value2))
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 9;
				case 24:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator3.MoveNext())
							{
								num5 = 3;
								goto IL_03ba;
							}
							goto IL_03ea;
							IL_03ba:
							while (true)
							{
								switch (num5)
								{
								case 1:
									break;
								case 2:
									goto IL_03ea;
								default:
									_003C_003Ec__DisplayClass63_.searchContext.DataClasses[KQ588fBFfP6HcAVOGSkp(current2)] = current2;
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
									{
										num5 = 1;
									}
									continue;
								case 3:
									goto end_IL_03d4;
								}
								break;
							}
							continue;
							IL_03ea:
							current2 = enumerator3.Current;
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
							{
								num5 = 0;
							}
							goto IL_03ba;
							continue;
							end_IL_03d4:
							break;
						}
					}
					finally
					{
						int num6;
						if (enumerator3 == null)
						{
							num6 = 2;
							goto IL_045b;
						}
						goto IL_0471;
						IL_045b:
						switch (num6)
						{
						default:
							goto end_IL_0446;
						case 1:
							break;
						case 2:
							goto end_IL_0446;
						case 0:
							goto end_IL_0446;
						}
						goto IL_0471;
						IL_0471:
						OvaV7SzejkY4BOybd2x(enumerator3);
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num6 = 0;
						}
						goto IL_045b;
						end_IL_0446:;
					}
					goto case 25;
				case 17:
					aJiRH2BFWqD71eFO0MDW(value2, false);
					num2 = 5;
					continue;
				case 26:
					return false;
				case 3:
					_003C_003Ec__DisplayClass63_.searchContext = searchContext;
					num2 = 29;
					continue;
				case 29:
					if (ComponentMetadataItemManager == null)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num2 = 22;
						}
						continue;
					}
					parentComponentUid = YxYSFPBFnmNjPCHUXxcv(componentMetadataWrapper);
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 9;
					}
					continue;
				case 4:
					_003C_003Ec__DisplayClass63_ = new _003C_003Ec__DisplayClass63_0();
					num2 = 3;
					continue;
				case 6:
					componentMetadata = (ComponentMetadata)value.Metadata;
					num2 = 16;
					continue;
				case 25:
					return true;
				case 7:
					try
					{
						while (true)
						{
							int num7;
							if (!Xtuo5mz2tWrRwGmUMM2(enumerator2))
							{
								num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
								{
									num7 = 1;
								}
								goto IL_058c;
							}
							goto IL_0600;
							IL_0600:
							current3 = enumerator2.Current;
							num7 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
							{
								num7 = 0;
							}
							goto IL_058c;
							IL_058c:
							while (true)
							{
								switch (num7)
								{
								case 2:
									_003C_003Ec__DisplayClass63_.searchContext.Functions[JjPtnYBFoMWBXtGgW9M3(current3)] = current3;
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
									{
										num7 = 0;
									}
									continue;
								case 3:
									goto IL_0600;
								case 1:
									goto end_IL_05a6;
								}
								break;
							}
							continue;
							end_IL_05a6:
							break;
						}
					}
					finally
					{
						int num8;
						if (enumerator2 == null)
						{
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
							{
								num8 = 0;
							}
							goto IL_064d;
						}
						goto IL_0682;
						IL_0682:
						OvaV7SzejkY4BOybd2x(enumerator2);
						num8 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num8 = 0;
						}
						goto IL_064d;
						IL_064d:
						switch (num8)
						{
						default:
							goto end_IL_0628;
						case 0:
							goto end_IL_0628;
						case 2:
							break;
						case 1:
							goto end_IL_0628;
						}
						goto IL_0682;
						end_IL_0628:;
					}
					goto case 8;
				case 15:
					return false;
				case 2:
				{
					(bool result, IEnumerable<ClientFunctionModel> functionModels) functions = GetFunctions((string)BcBEmvzUHSE6Hf3AR79(componentMetadata), componentMetadata.FunctionDependencies, _003C_003Ec__DisplayClass63_.searchContext);
					item2 = functions.result;
					item = functions.functionModels;
					num2 = 28;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 10;
					}
					continue;
				}
				case 20:
					if (!loadedComponents.TryGetValue(itemUid, out value))
					{
						num2 = 30;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 6;
				case 13:
					itemUid = _003C_003Ec__DisplayClass63_.vertex.ItemUid;
					num2 = 20;
					continue;
				case 12:
					value = componentMetadataItem;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 5;
					}
					continue;
				case 9:
					if (SODVc5BFE1jGqDmIIqZJ(value2) != q4h85NBFBxYqKkIqQqF1(_003C_003Ec__DisplayClass63_.vertex))
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 5;
				case 14:
					return false;
				case 22:
					return false;
				case 27:
					_003C_003Ec__DisplayClass63_.vertex = ((ComponentGraph)cKHlxVzcgw9q1aIwTx5(_003C_003Ec__DisplayClass63_.searchContext)).AddVertex(componentMetadataWrapper.HeaderUid, A3K5WQza9pDvO3NWvq1(componentMetadataWrapper), Guid.Empty, parentItemUid, string.Empty, owner, async: true);
					num2 = 13;
					continue;
				case 16:
					if (!FindComponent(itemUid, itemUid, q4h85NBFBxYqKkIqQqF1(_003C_003Ec__DisplayClass63_.vertex) ? itemUid : owner, parentComponentUid, componentMetadata.ComponentDependencies, _003C_003Ec__DisplayClass63_.searchContext))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					if (FindConfigurationImpl(itemUid, itemUid, q4h85NBFBxYqKkIqQqF1(_003C_003Ec__DisplayClass63_.vertex) ? itemUid : owner, parentComponentUid, value, _003C_003Ec__DisplayClass63_.searchContext))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 15;
				case 1:
					return false;
				case 18:
					enumerator = _003C_003Ec__DisplayClass63_.vertex.Owners.Where(_003C_003Ec__DisplayClass63_._003CFindImplConfigurationComponent_003Eb__0).GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
				case 19:
					enumerator2 = item.Where(_003C_003Ec__DisplayClass63_._003CFindImplConfigurationComponent_003Eb__1).GetEnumerator();
					num2 = 7;
					continue;
				case 8:
					enumerator3 = item4.Where(_003C_003Ec__DisplayClass63_._003CFindImplConfigurationComponent_003Eb__2).GetEnumerator();
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 24;
					}
					continue;
				}
				break;
			}
		}
	}

	private bool FindImplModuleComponent(Guid parent, Guid owner, Guid moduleUid, Guid parentComponentUid, ComponentMetadata componentMetadata, ModuleVersion moduleVersion, SearchContext searchContext)
	{
		//Discarded unreachable code: IL_013e, IL_0148, IL_0232, IL_0241, IL_024d, IL_02b2, IL_02c2, IL_02d1, IL_02dc, IL_0378, IL_038b, IL_039a, IL_03e3, IL_03f2
		int num = 1;
		_003C_003Ec__DisplayClass64_0 _003C_003Ec__DisplayClass64_ = default(_003C_003Ec__DisplayClass64_0);
		Guid guid = default(Guid);
		IEnumerator<Guid> enumerator = default(IEnumerator<Guid>);
		Guid current2 = default(Guid);
		ClientComponentModel value = default(ClientComponentModel);
		HashSet<string>.Enumerator enumerator2 = default(HashSet<string>.Enumerator);
		string current = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					_003C_003Ec__DisplayClass64_.vertex = (ComponentGraph.Vertex)ar2MpGBF2WR9Iqk4CT2u(cKHlxVzcgw9q1aIwTx5(searchContext), cMLTumBFhHIoYiMbgbG3(componentMetadata), zhf61FzAs08ZdStq71m(wyDj5JBFOvUp3aNhic5o(moduleVersion)), ((ModuleVersionHeader)wyDj5JBFOvUp3aNhic5o(moduleVersion)).HeaderUid, parent, string.Empty, owner, true);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 8;
					}
					continue;
				case 14:
				{
					Dictionary<Guid, ClientComponentModel> components = searchContext.Components;
					Guid key = guid;
					ClientComponentModel clientComponentModel = new ClientComponentModel();
					n8FEILBFPLdNFpd5yqyN(clientComponentModel, o91ZZ6BFe7tmdgKxfgXN(_003C_003Ec__DisplayClass64_.vertex));
					M82BL7zJJj9ytsx4xAS(clientComponentModel, guid);
					clientComponentModel.RenderUidList = _003C_003Ec__DisplayClass64_.vertex.ViewItemUidList;
					clientComponentModel.Owners = _003C_003Ec__DisplayClass64_.vertex.Owners;
					components[key] = clientComponentModel;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 1:
					_003C_003Ec__DisplayClass64_ = new _003C_003Ec__DisplayClass64_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					try
					{
						while (true)
						{
							int num5;
							if (!Xtuo5mz2tWrRwGmUMM2(enumerator))
							{
								num5 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
								{
									num5 = 1;
								}
								goto IL_014c;
							}
							goto IL_01b5;
							IL_01b5:
							current2 = enumerator.Current;
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
							{
								num5 = 0;
							}
							goto IL_014c;
							IL_014c:
							while (true)
							{
								switch (num5)
								{
								case 1:
									break;
								default:
									value.Owners.Add(current2);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
									{
										num5 = 1;
									}
									continue;
								case 3:
									goto IL_01b5;
								case 2:
									goto end_IL_0166;
								}
								break;
							}
							continue;
							end_IL_0166:
							break;
						}
					}
					finally
					{
						int num7;
						if (enumerator == null)
						{
							int num6 = 2;
							num7 = num6;
							goto IL_01f6;
						}
						goto IL_020c;
						IL_01f6:
						switch (num7)
						{
						case 2:
							goto end_IL_01dd;
						case 1:
							goto end_IL_01dd;
						}
						goto IL_020c;
						IL_020c:
						enumerator.Dispose();
						num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num7 = 0;
						}
						goto IL_01f6;
						end_IL_01dd:;
					}
					goto case 2;
				case 2:
				case 10:
					searchContext.ChosenModules.Add(o91ZZ6BFe7tmdgKxfgXN(_003C_003Ec__DisplayClass64_.vertex));
					num = 6;
					break;
				case 3:
					enumerator2 = _003C_003Ec__DisplayClass64_.vertex.ViewItemUidList.GetEnumerator();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 9;
					}
					continue;
				case 6:
					return true;
				case 9:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator2.MoveNext())
							{
								num3 = 2;
								goto IL_02e0;
							}
							goto IL_0329;
							IL_02e0:
							while (true)
							{
								switch (num3)
								{
								case 1:
									value.RenderUidList.Add(current);
									num3 = 3;
									continue;
								case 3:
									break;
								default:
									goto IL_0329;
								case 2:
									goto end_IL_0313;
								}
								break;
							}
							continue;
							IL_0329:
							current = enumerator2.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
							{
								num3 = 1;
							}
							goto IL_02e0;
							continue;
							end_IL_0313:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 4;
				case 5:
					return false;
				case 12:
					if (!searchContext.Components.TryGetValue(guid, out value))
					{
						num2 = 14;
						continue;
					}
					goto case 3;
				case 8:
					guid = EKWac9zzFvThoYiiFo5(_003C_003Ec__DisplayClass64_.vertex);
					num2 = 11;
					continue;
				case 11:
					FindComponent(guid, guid, _003C_003Ec__DisplayClass64_.vertex.Async ? guid : owner, cMLTumBFhHIoYiMbgbG3(componentMetadata), componentMetadata.ComponentDependencies, searchContext);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 13;
					}
					continue;
				case 13:
					if (FindModuleImpl(guid, guid, q4h85NBFBxYqKkIqQqF1(_003C_003Ec__DisplayClass64_.vertex) ? guid : owner, cMLTumBFhHIoYiMbgbG3(componentMetadata), moduleVersion, searchContext))
					{
						num = 12;
						break;
					}
					goto case 5;
				case 4:
					enumerator = _003C_003Ec__DisplayClass64_.vertex.Owners.Where(_003C_003Ec__DisplayClass64_._003CFindImplModuleComponent_003Eb__0).GetEnumerator();
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	private (bool result, IEnumerable<ClientFunctionModel> functionModels) GetFunctions(string componentName, IReadOnlyCollection<FunctionDependency> functionDependencies, SearchContext searchContext, bool throwException = false)
	{
		if (functionDependencies.Count == 0)
		{
			return (true, Enumerable.Empty<ClientFunctionModel>());
		}
		var (flag, item) = GetRuntimeFunctions(functionDependencies, searchContext);
		if (flag)
		{
			return (true, item);
		}
		if (throwException)
		{
			searchContext.Errors.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AC077D), componentName));
			return (false, Enumerable.Empty<ClientFunctionModel>());
		}
		return (false, Enumerable.Empty<ClientFunctionModel>());
	}

	private (bool result, IEnumerable<ClientFunctionModel> functionModels) GetRuntimeFunctions(IEnumerable<FunctionDependency> functionDependencies, SearchContext searchContext)
	{
		Dictionary<Guid, ClientFunctionModel> dictionary = new Dictionary<Guid, ClientFunctionModel>();
		foreach (FunctionDependency functionDependency in functionDependencies)
		{
			if (functionDependency.ModuleUid == Guid.Empty)
			{
				if (!GetFunctionFromConfiguration(functionDependency, dictionary))
				{
					return (false, Enumerable.Empty<ClientFunctionModel>());
				}
			}
			else if (!GetFunctionFromModule(functionDependency, searchContext, dictionary))
			{
				return (false, Enumerable.Empty<ClientFunctionModel>());
			}
		}
		return (true, dictionary.Values);
	}

	private bool GetFunctionFromConfiguration(FunctionDependency dependency, IDictionary<Guid, ClientFunctionModel> result)
	{
		if (result.ContainsKey(dependency.HeaderUid))
		{
			return true;
		}
		Guid? guid = null;
		foreach (FunctionMetadataItem configurationFunctionCandidate in GetConfigurationFunctionCandidates(dependency))
		{
			if (configurationFunctionCandidate.Metadata is FunctionMetadata metadata && dependencyService.CheckFunctionCompatibility(dependency, metadata.GetSignature()).IsValid)
			{
				guid = configurationFunctionCandidate.Uid;
				loadedFunctions[configurationFunctionCandidate.Uid] = configurationFunctionCandidate;
				break;
			}
		}
		if (!guid.HasValue)
		{
			return false;
		}
		result[dependency.HeaderUid] = new ClientFunctionModel
		{
			HeaderUid = dependency.HeaderUid,
			ItemUid = guid.Value,
			ModuleUid = dependency.ModuleUid
		};
		return true;
	}

	private IEnumerable<FunctionMetadataItem> GetConfigurationFunctionCandidates(FunctionDependency dependency)
	{
		return FunctionMetadataItemManager?.GetCandidates(dependency.HeaderUid) ?? Enumerable.Empty<FunctionMetadataItem>();
	}

	private bool FillСompatibilityTable(ModuleVersion version, SearchContext searchContext)
	{
		//Discarded unreachable code: IL_00be, IL_01ab, IL_01ba, IL_02ad, IL_02e5, IL_02f4, IL_044a, IL_0459, IL_046a, IL_0479, IL_0484, IL_0522, IL_0535, IL_0544, IL_05b8, IL_061c, IL_062f, IL_0642, IL_0777, IL_07e7, IL_080d, IL_081c, IL_08c5, IL_08d8
		int num = 8;
		int num2 = num;
		_003C_003Ec__DisplayClass69_0 _003C_003Ec__DisplayClass69_ = default(_003C_003Ec__DisplayClass69_0);
		List<LinkToModule>.Enumerator enumerator = default(List<LinkToModule>.Enumerator);
		ModuleInfoMetadata metadata = default(ModuleInfoMetadata);
		LinkToModule current = default(LinkToModule);
		bool result = default(bool);
		_003C_003Ec__DisplayClass69_1 _003C_003Ec__DisplayClass69_2 = default(_003C_003Ec__DisplayClass69_1);
		List<CandidateDependModule> list = default(List<CandidateDependModule>);
		List<CandidateDependModule>.Enumerator enumerator2 = default(List<CandidateDependModule>.Enumerator);
		CandidateDependModule current2 = default(CandidateDependModule);
		ModuleVersion moduleVersion = default(ModuleVersion);
		bool flag = default(bool);
		List<CandidateDependModule>.Enumerator enumerator3 = default(List<CandidateDependModule>.Enumerator);
		IEnumerable<ModuleVersionHeader> enumerable = default(IEnumerable<ModuleVersionHeader>);
		IEnumerable<ModuleVersionHeader> value = default(IEnumerable<ModuleVersionHeader>);
		while (true)
		{
			switch (num2)
			{
			case 5:
				_003C_003Ec__DisplayClass69_.searchContext = searchContext;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				_003C_003Ec__DisplayClass69_ = new _003C_003Ec__DisplayClass69_0();
				num2 = 7;
				break;
			case 2:
				return true;
			case 3:
				enumerator = metadata.DependencyModules.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass69_.moduleDependencies = metadata.Dependency;
				num2 = 3;
				break;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 6;
							goto IL_00cc;
						}
						goto IL_075b;
						IL_029a:
						int num4 = 28;
						goto IL_00c8;
						IL_075b:
						current = enumerator.Current;
						num4 = 3;
						goto IL_00c8;
						IL_00c8:
						num3 = num4;
						goto IL_00cc;
						IL_00cc:
						while (true)
						{
							switch (num3)
							{
							case 13:
								return result;
							case 29:
								return result;
							case 30:
								result = false;
								num3 = 13;
								continue;
							case 9:
								_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.searchContext.IncompatibleModuleItems.Add(zhf61FzAs08ZdStq71m(wyDj5JBFOvUp3aNhic5o(_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.version)));
								num3 = 18;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
								{
									num3 = 21;
								}
								continue;
							case 27:
								if (list.Count != 0)
								{
									num3 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
									{
										num3 = 6;
									}
									continue;
								}
								goto case 9;
							case 14:
								if (PjqLdUBFN5nTFGxfWBq3(moduleMetadataLoader, _003C_003Ec__DisplayClass69_2.dependencyModuleUid))
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 24;
							case 15:
								_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.searchContext.IncompatibleModuleItems.Add(((ModuleVersionHeader)wyDj5JBFOvUp3aNhic5o(_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.version)).VersionUid);
								num3 = 30;
								continue;
							case 8:
							case 22:
								if (!_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.searchContext.CandidateModules.ContainsKey(((ModuleVersionHeader)wyDj5JBFOvUp3aNhic5o(_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.version)).VersionUid))
								{
									goto IL_029a;
								}
								goto case 19;
							case 24:
								_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.searchContext.AllModules.Add(_003C_003Ec__DisplayClass69_2.dependencyModuleUid);
								num3 = 16;
								continue;
							case 18:
								try
								{
									while (true)
									{
										IL_041f:
										int num5;
										if (!enumerator2.MoveNext())
										{
											num5 = 10;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
											{
												num5 = 11;
											}
											goto IL_0303;
										}
										goto IL_040c;
										IL_040c:
										current2 = enumerator2.Current;
										num5 = 7;
										goto IL_0303;
										IL_0303:
										while (true)
										{
											switch (num5)
											{
											case 10:
												if (_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.searchContext.CandidateModules.ContainsKey(TRRkqPBF3DeBYb8ZFdtB(current2)))
												{
													num5 = 12;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
													{
														num5 = 3;
													}
													continue;
												}
												goto case 13;
											case 8:
											{
												lCITBgBFaM1sJH8Ic0xa(current2, ((ModuleVersionHeader)wyDj5JBFOvUp3aNhic5o(moduleVersion)).Version);
												int num8 = 2;
												num5 = num8;
												continue;
											}
											case 7:
												if (current2.Valid)
												{
													num5 = 10;
													continue;
												}
												goto IL_041f;
											case 2:
												if (!FillСompatibilityTable(moduleVersion, _003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.searchContext))
												{
													num5 = 3;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
													{
														num5 = 0;
													}
													continue;
												}
												goto case 6;
											case 14:
												flag = true;
												num5 = 8;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
												{
													num5 = 9;
												}
												continue;
											case 1:
											case 5:
											case 9:
												goto IL_041f;
											case 4:
												try
												{
													while (true)
													{
														int num6;
														if (!enumerator3.MoveNext())
														{
															num6 = 2;
															goto IL_0488;
														}
														goto IL_049e;
														IL_0488:
														switch (num6)
														{
														case 1:
															break;
														default:
															continue;
														case 2:
															goto end_IL_04e0;
														}
														goto IL_049e;
														IL_049e:
														enumerator3.Current.Owners.Add(zhf61FzAs08ZdStq71m(wyDj5JBFOvUp3aNhic5o(_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.version)));
														num6 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
														{
															num6 = 0;
														}
														goto IL_0488;
														continue;
														end_IL_04e0:
														break;
													}
												}
												finally
												{
													((IDisposable)enumerator3).Dispose();
													int num7 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
													{
														num7 = 0;
													}
													switch (num7)
													{
													case 0:
														break;
													}
												}
												goto case 14;
											case 3:
												MjCaSABFDI60LPKqXDpH(current2, false);
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
												{
													num5 = 1;
												}
												continue;
											case 13:
												moduleVersion = (ModuleVersion)vHy53qzduNL4la1OiPP(moduleMetadataLoader, eHcW1YBFpwFvr1R4vjtR(current2), TRRkqPBF3DeBYb8ZFdtB(current2));
												num5 = 3;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
												{
													num5 = 8;
												}
												continue;
											case 6:
												flag = true;
												num5 = 5;
												continue;
											case 12:
												enumerator3 = _003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.searchContext.CandidateModules[current2.ModuleItemUid].GetEnumerator();
												num5 = 4;
												continue;
											case 11:
												goto end_IL_041f;
											}
											break;
										}
										goto IL_040c;
										continue;
										end_IL_041f:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
									{
										num9 = 0;
									}
									switch (num9)
									{
									case 0:
										break;
									}
								}
								goto case 20;
							case 4:
								_003C_003Ec__DisplayClass69_2.dependencyModuleUid = OMUDSfBF1aZmZMxuFVxw(current);
								num3 = 14;
								continue;
							case 5:
								enumerable = (_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.searchContext.ModuleVersions[_003C_003Ec__DisplayClass69_2.dependencyModuleUid] = moduleMetadataLoader.GetModuleVersionHeaders(_003C_003Ec__DisplayClass69_2.dependencyModuleUid));
								num3 = 26;
								continue;
							case 28:
								_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.searchContext.CandidateModules[((ModuleVersionHeader)wyDj5JBFOvUp3aNhic5o(_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.version)).VersionUid] = list;
								num3 = 25;
								continue;
							case 12:
								enumerator2 = list.GetEnumerator();
								num3 = 18;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
								{
									num3 = 9;
								}
								continue;
							case 19:
								_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.searchContext.CandidateModules[zhf61FzAs08ZdStq71m(wyDj5JBFOvUp3aNhic5o(_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.version))].AddRange(list);
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
								{
									num3 = 2;
								}
								continue;
							case 26:
								goto IL_0749;
							case 2:
								goto IL_075b;
							case 21:
								result = false;
								num3 = 29;
								continue;
							case 20:
								if (!flag)
								{
									goto case 15;
								}
								goto IL_0795;
							case 10:
							case 25:
								flag = false;
								num3 = 12;
								continue;
							case 17:
								if (!_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.searchContext.ModuleVersions.TryGetValue(_003C_003Ec__DisplayClass69_2.dependencyModuleUid, out value))
								{
									goto IL_07d4;
								}
								goto case 23;
							case 7:
								goto IL_07f1;
							case 3:
								_003C_003Ec__DisplayClass69_2 = new _003C_003Ec__DisplayClass69_1();
								num3 = 7;
								continue;
							case 16:
								if (!_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1.searchContext.ChosenModules.Contains(_003C_003Ec__DisplayClass69_2.dependencyModuleUid))
								{
									num3 = 17;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
									{
										num3 = 3;
									}
									continue;
								}
								break;
							case 23:
								list = value.Select(_003C_003Ec__DisplayClass69_2._003CFillСompatibilityTable_003Eb__0).ToList();
								num3 = 27;
								continue;
							case 6:
								goto end_IL_021c;
							}
							break;
						}
						continue;
						IL_07f1:
						_003C_003Ec__DisplayClass69_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass69_;
						num4 = 4;
						goto IL_00c8;
						IL_07d4:
						num4 = 5;
						goto IL_00c8;
						IL_0749:
						value = enumerable;
						num4 = 23;
						goto IL_00c8;
						IL_0795:
						num4 = 11;
						goto IL_00c8;
						continue;
						end_IL_021c:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num10 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num10 = 0;
					}
					switch (num10)
					{
					case 0:
						break;
					}
				}
				goto case 2;
			default:
				if (_003C_003Ec__DisplayClass69_.searchContext.CandidateModules.ContainsKey(zhf61FzAs08ZdStq71m(wyDj5JBFOvUp3aNhic5o(_003C_003Ec__DisplayClass69_.version))))
				{
					num2 = 6;
					break;
				}
				metadata = _003C_003Ec__DisplayClass69_.version.Metadata;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				_003C_003Ec__DisplayClass69_.version = version;
				num2 = 5;
				break;
			case 6:
				return true;
			}
		}
	}

	private bool FindModule(ClientComponentModel[] componentsWithModule, SearchContext searchContext)
	{
		//Discarded unreachable code: IL_00a0, IL_00aa, IL_0131, IL_01ac, IL_01bb, IL_0268, IL_0276, IL_02cb, IL_02fe, IL_030d, IL_0318, IL_03bf, IL_03d2, IL_0428, IL_04b3, IL_05d4, IL_05e7, IL_068a, IL_069d, IL_06ac, IL_0701, IL_0710, IL_075a, IL_0769, IL_0774, IL_0888, IL_089b, IL_08aa, IL_0924, IL_0937, IL_0a0d, IL_0a1c, IL_0a27, IL_0b3a, IL_0b44, IL_0be6, IL_0bfe, IL_0c0d, IL_0cbf, IL_0cce, IL_0da1, IL_0db4, IL_0e39, IL_0e71, IL_0e81, IL_0e90, IL_0e9b, IL_0f3c, IL_0f74, IL_0f88, IL_0f97, IL_0fa2, IL_101a, IL_1028, IL_10c9, IL_10f9, IL_1108, IL_1114, IL_1199, IL_11ac, IL_11bb, IL_11cb, IL_11da, IL_12a2, IL_12da, IL_1384, IL_13ab, IL_1461, IL_1470, IL_14d1, IL_14e0, IL_15ce, IL_15ff, IL_160e, IL_1621, IL_1711, IL_1720, IL_174d, IL_175c, IL_1813, IL_1867, IL_18ea, IL_193a, IL_194d, IL_1969, IL_1a4b, IL_1a5e, IL_1a7f, IL_1a8e, IL_1a9f, IL_1aad, IL_1bb3, IL_1beb, IL_1bfa, IL_1c0a, IL_1c19, IL_1c2a, IL_1c39, IL_1d34, IL_1d43, IL_1d6e, IL_1d7d, IL_1e97, IL_1ee1, IL_1f97, IL_1faa, IL_2039, IL_2048, IL_2058, IL_206b, IL_20a9, IL_20b8, IL_20e5, IL_2260, IL_2273, IL_2282
		int num = 6;
		int num2 = num;
		ClientComponentModel[] array = default(ClientComponentModel[]);
		int num3 = default(int);
		IEnumerator<Guid> enumerator6 = default(IEnumerator<Guid>);
		_003C_003Ec__DisplayClass70_1 _003C_003Ec__DisplayClass70_3 = default(_003C_003Ec__DisplayClass70_1);
		Dictionary<Guid, HashSet<CandidateDependModule>>.Enumerator enumerator = default(Dictionary<Guid, HashSet<CandidateDependModule>>.Enumerator);
		Dictionary<Guid, HashSet<CandidateDependModule>> dictionary3 = default(Dictionary<Guid, HashSet<CandidateDependModule>>);
		IEnumerable<ModuleVersionHeader> enumerable = default(IEnumerable<ModuleVersionHeader>);
		HashSet<CandidateDependModule> value6 = default(HashSet<CandidateDependModule>);
		IEnumerable<ModuleVersionHeader> value10 = default(IEnumerable<ModuleVersionHeader>);
		HashSet<CandidateDependModule>.Enumerator enumerator8 = default(HashSet<CandidateDependModule>.Enumerator);
		HashSet<CandidateDependModule> value11 = default(HashSet<CandidateDependModule>);
		HashSet<CandidateDependModule> hashSet8 = default(HashSet<CandidateDependModule>);
		CandidateDependModule current12 = default(CandidateDependModule);
		KeyValuePair<Guid, HashSet<CandidateDependModule>> current11 = default(KeyValuePair<Guid, HashSet<CandidateDependModule>>);
		_003C_003Ec__DisplayClass70_3 _003C_003Ec__DisplayClass70_5 = default(_003C_003Ec__DisplayClass70_3);
		HashSet<CandidateDependModule>[] array7 = default(HashSet<CandidateDependModule>[]);
		CandidateDependModule candidateDependModule11 = default(CandidateDependModule);
		HashSet<CandidateDependModule>[] array6 = default(HashSet<CandidateDependModule>[]);
		IEnumerator<ModuleVersionHeader> enumerator7 = default(IEnumerator<ModuleVersionHeader>);
		HashSet<Guid> hashSet3 = default(HashSet<Guid>);
		HashSet<Guid>.Enumerator enumerator4 = default(HashSet<Guid>.Enumerator);
		KeyValuePair<Guid, HashSet<CandidateDependModule>> current10 = default(KeyValuePair<Guid, HashSet<CandidateDependModule>>);
		CandidateDependModule candidateDependModule10 = default(CandidateDependModule);
		_003C_003Ec__DisplayClass70_2 _003C_003Ec__DisplayClass70_4 = default(_003C_003Ec__DisplayClass70_2);
		Dictionary<Guid, ClientComponentModel>.ValueCollection.Enumerator enumerator2 = default(Dictionary<Guid, ClientComponentModel>.ValueCollection.Enumerator);
		HashSet<CandidateDependModule> hashSet = default(HashSet<CandidateDependModule>);
		Dictionary<Guid, HashSet<CandidateDependModule>> dictionary2 = default(Dictionary<Guid, HashSet<CandidateDependModule>>);
		Dictionary<Guid, ClientComponentModel>.ValueCollection values = default(Dictionary<Guid, ClientComponentModel>.ValueCollection);
		HashSet<CandidateDependModule> value9 = default(HashSet<CandidateDependModule>);
		ModuleVersionHeader current9 = default(ModuleVersionHeader);
		ModuleVersion moduleVersion = default(ModuleVersion);
		HashSet<CandidateDependModule> value8 = default(HashSet<CandidateDependModule>);
		Guid key5 = default(Guid);
		ClientComponentModel current8 = default(ClientComponentModel);
		IEnumerator<CandidateDependModule> enumerator3 = default(IEnumerator<CandidateDependModule>);
		CandidateDependModule current7 = default(CandidateDependModule);
		ClientComponentModel current6 = default(ClientComponentModel);
		List<CandidateDependModule> value7 = default(List<CandidateDependModule>);
		CandidateDependModule current5 = default(CandidateDependModule);
		ClientComponentModel clientComponentModel = default(ClientComponentModel);
		List<CandidateDependModule> value5 = default(List<CandidateDependModule>);
		Guid current4 = default(Guid);
		ClientComponentModel clientComponentModel3 = default(ClientComponentModel);
		ClientComponentModel[] array4 = default(ClientComponentModel[]);
		int num14 = default(int);
		CandidateDependModule candidateDependModule4 = default(CandidateDependModule);
		ClientComponentModel[] array5 = default(ClientComponentModel[]);
		CandidateDependModule candidateDependModule7 = default(CandidateDependModule);
		Dictionary<Guid, List<CandidateDependModule>> dictionary = default(Dictionary<Guid, List<CandidateDependModule>>);
		List<CandidateDependModule> value3 = default(List<CandidateDependModule>);
		List<CandidateDependModule> list2 = default(List<CandidateDependModule>);
		CandidateDependModule candidateDependModule5 = default(CandidateDependModule);
		List<CandidateDependModule> value4 = default(List<CandidateDependModule>);
		List<CandidateDependModule>.Enumerator enumerator5 = default(List<CandidateDependModule>.Enumerator);
		_003C_003Ec__DisplayClass70_0 _003C_003Ec__DisplayClass70_2 = default(_003C_003Ec__DisplayClass70_0);
		CandidateDependModule candidateDependModule6 = default(CandidateDependModule);
		bool result = default(bool);
		CandidateDependModule current3 = default(CandidateDependModule);
		List<CandidateDependModule> value2 = default(List<CandidateDependModule>);
		CandidateDependModule candidateDependModule3 = default(CandidateDependModule);
		CandidateDependModule[] array2 = default(CandidateDependModule[]);
		List<CandidateDependModule> list = default(List<CandidateDependModule>);
		ClientComponentModel current2 = default(ClientComponentModel);
		CandidateDependModule candidateDependModule = default(CandidateDependModule);
		List<CandidateDependModule> value = default(List<CandidateDependModule>);
		_003C_003Ec__DisplayClass70_4 _003C_003Ec__DisplayClass70_ = default(_003C_003Ec__DisplayClass70_4);
		CandidateDependModule candidateDependModule2 = default(CandidateDependModule);
		CandidateDependModule[] array3 = default(CandidateDependModule[]);
		KeyValuePair<Guid, HashSet<CandidateDependModule>> current = default(KeyValuePair<Guid, HashSet<CandidateDependModule>>);
		while (true)
		{
			switch (num2)
			{
			case 6:
				array = componentsWithModule;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 5;
				}
				continue;
			case 3:
			case 9:
				if (num3 < array.Length)
				{
					num2 = 14;
					continue;
				}
				goto case 10;
			case 11:
				try
				{
					while (true)
					{
						IL_09c0:
						int num19;
						if (!enumerator6.MoveNext())
						{
							num19 = 4;
							goto IL_00ae;
						}
						goto IL_0972;
						IL_00ae:
						while (true)
						{
							switch (num19)
							{
							case 28:
								if (!searchContext.ChosenModules.Contains(_003C_003Ec__DisplayClass70_3.remainingModule))
								{
									num19 = 20;
									continue;
								}
								goto IL_09c0;
							case 24:
								_003C_003Ec__DisplayClass70_3.remainingModule = enumerator6.Current;
								num19 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
								{
									num19 = 11;
								}
								continue;
							case 18:
								enumerator = dictionary3.GetEnumerator();
								num19 = 25;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
								{
									num19 = 13;
								}
								continue;
							case 27:
								enumerable = (searchContext.ModuleVersions[_003C_003Ec__DisplayClass70_3.remainingModule] = moduleMetadataLoader.GetModuleVersionHeaders(_003C_003Ec__DisplayClass70_3.remainingModule));
								num19 = 12;
								continue;
							case 8:
							case 15:
								dictionary3 = new Dictionary<Guid, HashSet<CandidateDependModule>>();
								num19 = 10;
								continue;
							case 16:
								if (ctifHNBFwwoa6iudFPtk(value6) != 0)
								{
									num19 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
									{
										num19 = 6;
									}
									continue;
								}
								goto case 13;
							case 13:
								if (searchContext.ModuleVersions.TryGetValue(_003C_003Ec__DisplayClass70_3.remainingModule, out value10))
								{
									num19 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
									{
										num19 = 0;
									}
									continue;
								}
								goto case 27;
							case 25:
								try
								{
									while (true)
									{
										int num35;
										if (!enumerator.MoveNext())
										{
											num35 = 5;
											goto IL_027a;
										}
										goto IL_05f1;
										IL_027a:
										while (true)
										{
											switch (num35)
											{
											case 4:
												break;
											case 7:
												enumerator8 = value11.GetEnumerator();
												num35 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
												{
													num35 = 1;
												}
												continue;
											case 2:
												try
												{
													while (true)
													{
														int num39;
														if (!enumerator8.MoveNext())
														{
															num39 = 3;
															goto IL_031c;
														}
														goto IL_0370;
														IL_031c:
														while (true)
														{
															switch (num39)
															{
															case 2:
																hashSet8.Add(current12);
																num39 = 1;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
																{
																	num39 = 1;
																}
																continue;
															case 1:
																break;
															default:
																goto IL_0370;
															case 3:
																goto end_IL_035a;
															}
															break;
														}
														continue;
														IL_0370:
														current12 = enumerator8.Current;
														num39 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
														{
															num39 = 2;
														}
														goto IL_031c;
														continue;
														end_IL_035a:
														break;
													}
												}
												finally
												{
													((IDisposable)enumerator8).Dispose();
													int num40 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
													{
														num40 = 0;
													}
													switch (num40)
													{
													case 0:
														break;
													}
												}
												break;
											case 6:
											case 10:
												enumerator8 = value11.GetEnumerator();
												num35 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
												{
													num35 = 2;
												}
												continue;
											case 9:
												value11 = current11.Value;
												num35 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
												{
													num35 = 0;
												}
												continue;
											case 1:
												try
												{
													while (true)
													{
														int num36;
														if (!enumerator8.MoveNext())
														{
															num36 = 3;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
															{
																num36 = 1;
															}
															goto IL_0436;
														}
														goto IL_04da;
														IL_0436:
														while (true)
														{
															switch (num36)
															{
															case 2:
																_003C_003Ec__DisplayClass70_5.dependModule = enumerator8.Current;
																num36 = 8;
																continue;
															case 7:
																break;
															case 10:
																num3 = 0;
																num36 = 5;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
																{
																	num36 = 5;
																}
																continue;
															case 9:
																goto IL_04da;
															default:
																if (num3 >= array7.Length)
																{
																	goto IL_04fa;
																}
																goto case 11;
															case 1:
																hashSet8.Add(candidateDependModule11);
																num36 = 6;
																continue;
															case 8:
																array7 = array6;
																num36 = 10;
																continue;
															case 4:
																if (candidateDependModule11 != null)
																{
																	num36 = 1;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
																	{
																		num36 = 1;
																	}
																	continue;
																}
																goto case 6;
															case 6:
																num3++;
																num36 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
																{
																	num36 = 0;
																}
																continue;
															case 11:
																candidateDependModule11 = array7[num3].FirstOrDefault(_003C_003Ec__DisplayClass70_5._003CFindModule_003Eb__5);
																num36 = 4;
																continue;
															case 3:
																goto end_IL_0488;
															}
															break;
														}
														continue;
														IL_04fa:
														int num37 = 7;
														goto IL_0432;
														IL_04da:
														_003C_003Ec__DisplayClass70_5 = new _003C_003Ec__DisplayClass70_3();
														num37 = 2;
														goto IL_0432;
														IL_0432:
														num36 = num37;
														goto IL_0436;
														continue;
														end_IL_0488:
														break;
													}
												}
												finally
												{
													((IDisposable)enumerator8).Dispose();
													int num38 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
													{
														num38 = 0;
													}
													switch (num38)
													{
													case 0:
														break;
													}
												}
												break;
											case 8:
												goto IL_05f1;
											default:
												array6 = dictionary3.Values.Except(new HashSet<CandidateDependModule>[1] { value11 }).ToArray();
												num35 = 3;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
												{
													num35 = 3;
												}
												continue;
											case 3:
												if (array6.Length == 0)
												{
													num35 = 10;
													continue;
												}
												goto case 7;
											case 5:
												goto end_IL_02b0;
											}
											break;
										}
										continue;
										IL_05f1:
										current11 = enumerator.Current;
										num35 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
										{
											num35 = 9;
										}
										goto IL_027a;
										continue;
										end_IL_02b0:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator).Dispose();
									int num41 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
									{
										num41 = 0;
									}
									switch (num41)
									{
									case 0:
										break;
									}
								}
								goto default;
							case 21:
								enumerator7 = value10.GetEnumerator();
								num19 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
								{
									num19 = 5;
								}
								continue;
							case 10:
								hashSet3 = new HashSet<Guid>();
								num19 = 21;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
								{
									num19 = 14;
								}
								continue;
							case 17:
								try
								{
									while (true)
									{
										IL_08de:
										int num31;
										if (!enumerator4.MoveNext())
										{
											int num30 = 2;
											num31 = num30;
											goto IL_071f;
										}
										goto IL_08b5;
										IL_071f:
										while (true)
										{
											switch (num31)
											{
											case 4:
												enumerator = dictionary3.GetEnumerator();
												num31 = 3;
												continue;
											case 3:
												try
												{
													while (true)
													{
														int num32;
														if (!enumerator.MoveNext())
														{
															num32 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
															{
																num32 = 1;
															}
															goto IL_0778;
														}
														goto IL_07ea;
														IL_07ea:
														current10 = enumerator.Current;
														num32 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
														{
															num32 = 3;
														}
														goto IL_0778;
														IL_0778:
														while (true)
														{
															switch (num32)
															{
															case 4:
																break;
															default:
																if (candidateDependModule10 != null)
																{
																	num32 = 5;
																	continue;
																}
																break;
															case 5:
																current10.Value.Remove(candidateDependModule10);
																num32 = 4;
																continue;
															case 2:
																goto IL_07ea;
															case 3:
																candidateDependModule10 = current10.Value.FirstOrDefault(_003C_003Ec__DisplayClass70_4._003CFindModule_003Eb__4);
																num32 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
																{
																	num32 = 0;
																}
																continue;
															case 1:
																goto end_IL_079a;
															}
															break;
														}
														continue;
														end_IL_079a:
														break;
													}
												}
												finally
												{
													((IDisposable)enumerator).Dispose();
													int num33 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
													{
														num33 = 0;
													}
													switch (num33)
													{
													case 0:
														break;
													}
												}
												goto IL_08de;
											case 1:
												break;
											case 5:
												_003C_003Ec__DisplayClass70_4.itemToRemove = enumerator4.Current;
												num31 = 4;
												continue;
											default:
												goto IL_08de;
											case 2:
												goto end_IL_08de;
											}
											break;
										}
										goto IL_08b5;
										IL_08b5:
										_003C_003Ec__DisplayClass70_4 = new _003C_003Ec__DisplayClass70_2();
										num31 = 5;
										goto IL_071f;
										continue;
										end_IL_08de:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator4).Dispose();
									int num34 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
									{
										num34 = 0;
									}
									switch (num34)
									{
									case 0:
										break;
									}
								}
								goto case 3;
							case 19:
								enumerator4 = hashSet3.GetEnumerator();
								num19 = 17;
								continue;
							case 12:
								value10 = enumerable;
								num19 = 15;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
								{
									num19 = 14;
								}
								continue;
							case 22:
								break;
							case 11:
								if (!searchContext.ChosenComponentModules.ContainsKey(_003C_003Ec__DisplayClass70_3.remainingModule))
								{
									num19 = 28;
									continue;
								}
								goto IL_09c0;
							case 7:
							case 9:
								enumerator2 = searchContext.ChosenComponentModules.Values.GetEnumerator();
								num19 = 2;
								continue;
							case 6:
							case 26:
								goto IL_09c0;
							case 3:
								hashSet8 = new HashSet<CandidateDependModule>();
								num19 = 18;
								continue;
							case 14:
								hashSet = (dictionary2[_003C_003Ec__DisplayClass70_3.remainingModule] = new HashSet<CandidateDependModule>());
								num19 = 23;
								continue;
							case 5:
								try
								{
									while (true)
									{
										IL_0af7:
										int num26;
										if (!Xtuo5mz2tWrRwGmUMM2(enumerator7))
										{
											num26 = 9;
											goto IL_0a2b;
										}
										goto IL_0a74;
										IL_0a2b:
										while (true)
										{
											switch (num26)
											{
											case 10:
												enumerator2 = values.GetEnumerator();
												num26 = 8;
												continue;
											case 1:
												break;
											case 2:
												value9 = hashSet;
												num26 = 4;
												continue;
											case 3:
												if (bxgLweBF4alAQMvkIPkO(values) > 0)
												{
													num26 = 10;
													continue;
												}
												goto case 5;
											case 7:
												hashSet = (dictionary3[Guid.Empty] = new HashSet<CandidateDependModule>());
												num26 = 2;
												continue;
											case 5:
												if (!dictionary3.TryGetValue(Guid.Empty, out value9))
												{
													num26 = 7;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
													{
														num26 = 4;
													}
													continue;
												}
												goto case 4;
											default:
												goto IL_0af7;
											case 6:
												values = searchContext.ChosenComponentModules.Values;
												num26 = 3;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
												{
													num26 = 0;
												}
												continue;
											case 8:
												try
												{
													while (true)
													{
														int num27;
														if (!enumerator2.MoveNext())
														{
															num27 = 7;
															goto IL_0b48;
														}
														goto IL_0cd8;
														IL_0b48:
														while (true)
														{
															switch (num27)
															{
															case 10:
																hashSet3.Add(zhf61FzAs08ZdStq71m(current9));
																num27 = 6;
																continue;
															case 1:
															case 6:
																break;
															case 11:
																if (!biNyKKBFAH2ZLqXDRfMf(CheckModuleHelper.CheckSignatures((ModuleDependency)uJ6ZVgBFHGWZftlNPcOQ(iMlyy1ztkAWCr8rEdWj(moduleVersion)), (ModuleSignature)Myq9P5BFkln6ljxvfiBh(current9), _003C_003Ec__DisplayClass70_3.remainingModule)))
																{
																	goto case 10;
																}
																goto default;
															case 8:
																value8 = hashSet;
																num27 = 9;
																continue;
															case 5:
															case 9:
																if (!zxK5JxBF6vqpPYmhsZoS(lTCXFgzmDwbANeh2YWG(searchContext)))
																{
																	num27 = 0;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
																	{
																		num27 = 0;
																	}
																	continue;
																}
																goto case 11;
															case 13:
															{
																HashSet<CandidateDependModule> hashSet4 = value8;
																CandidateDependModule candidateDependModule8 = new CandidateDependModule();
																YLGZ44BFxB4FuA8IiUUQ(candidateDependModule8, g6LHQuBF76gEdOIm0C5X(current9));
																candidateDependModule8.ModuleItemUid = zhf61FzAs08ZdStq71m(current9);
																candidateDependModule8.Version = current9.Version;
																MjCaSABFDI60LPKqXDpH(candidateDependModule8, true);
																hashSet4.Add(candidateDependModule8);
																num27 = 1;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
																{
																	num27 = 0;
																}
																continue;
															}
															case 12:
																key5 = MeY255BFZT4ltNIPAYVj(current8);
																num27 = 2;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
																{
																	num27 = 2;
																}
																continue;
															case 3:
																goto IL_0cd8;
															case 4:
																if (dictionary3.TryGetValue(key5, out value8))
																{
																	num27 = 5;
																	continue;
																}
																goto case 14;
															case 14:
																hashSet = (dictionary3[key5] = new HashSet<CandidateDependModule>());
																num27 = 1;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
																{
																	num27 = 8;
																}
																continue;
															case 2:
																moduleVersion = (ModuleVersion)vHy53qzduNL4la1OiPP(moduleMetadataLoader, MJd4j0BFSxyqrmO88VXq(current8), MeY255BFZT4ltNIPAYVj(current8));
																num27 = 4;
																continue;
															default:
																num27 = 13;
																continue;
															case 7:
																goto end_IL_0ba7;
															}
															break;
														}
														continue;
														IL_0cd8:
														current8 = enumerator2.Current;
														num27 = 12;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
														{
															num27 = 5;
														}
														goto IL_0b48;
														continue;
														end_IL_0ba7:
														break;
													}
												}
												finally
												{
													((IDisposable)enumerator2).Dispose();
													int num28 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
													{
														num28 = 0;
													}
													switch (num28)
													{
													case 0:
														break;
													}
												}
												goto IL_0af7;
											case 4:
											{
												HashSet<CandidateDependModule> hashSet6 = value9;
												CandidateDependModule candidateDependModule9 = new CandidateDependModule();
												YLGZ44BFxB4FuA8IiUUQ(candidateDependModule9, g6LHQuBF76gEdOIm0C5X(current9));
												RMP0R2BF0y2Fdpy2KsiU(candidateDependModule9, zhf61FzAs08ZdStq71m(current9));
												lCITBgBFaM1sJH8Ic0xa(candidateDependModule9, LXTnMLBFmiUQfSubUX0W(current9));
												MjCaSABFDI60LPKqXDpH(candidateDependModule9, true);
												hashSet6.Add(candidateDependModule9);
												num26 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
												{
													num26 = 0;
												}
												continue;
											}
											case 9:
												goto end_IL_0af7;
											}
											break;
										}
										goto IL_0a74;
										IL_0a74:
										current9 = enumerator7.Current;
										num26 = 6;
										goto IL_0a2b;
										continue;
										end_IL_0af7:
										break;
									}
								}
								finally
								{
									if (enumerator7 != null)
									{
										int num29 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
										{
											num29 = 1;
										}
										while (true)
										{
											switch (num29)
											{
											case 1:
												enumerator7.Dispose();
												num29 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
												{
													num29 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
								goto case 19;
							case 1:
								try
								{
									while (true)
									{
										IL_0ecc:
										int num24;
										if (!Xtuo5mz2tWrRwGmUMM2(enumerator3))
										{
											num24 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
											{
												num24 = 2;
											}
											goto IL_0e9f;
										}
										goto IL_0eb9;
										IL_0eb9:
										current7 = enumerator3.Current;
										num24 = 3;
										goto IL_0e9f;
										IL_0e9f:
										while (true)
										{
											switch (num24)
											{
											case 1:
												goto IL_0ecc;
											case 3:
												value6.Add(current7);
												num24 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
												{
													num24 = 1;
												}
												continue;
											case 2:
												goto end_IL_0ecc;
											}
											break;
										}
										goto IL_0eb9;
										continue;
										end_IL_0ecc:
										break;
									}
								}
								finally
								{
									if (enumerator3 != null)
									{
										int num25 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
										{
											num25 = 0;
										}
										while (true)
										{
											switch (num25)
											{
											default:
												enumerator3.Dispose();
												num25 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
												{
													num25 = 1;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
								}
								goto IL_09c0;
							case 2:
								try
								{
									while (true)
									{
										int num20;
										if (!enumerator2.MoveNext())
										{
											num20 = 4;
											goto IL_0fa6;
										}
										goto IL_0fde;
										IL_0fa6:
										while (true)
										{
											switch (num20)
											{
											case 5:
												break;
											default:
												goto IL_0fde;
											case 3:
												if (searchContext.CandidateModules.TryGetValue(MeY255BFZT4ltNIPAYVj(current6), out value7))
												{
													num20 = 2;
													continue;
												}
												break;
											case 1:
												try
												{
													while (true)
													{
														IL_107d:
														int num21;
														if (!enumerator3.MoveNext())
														{
															num21 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
															{
																num21 = 0;
															}
															goto IL_102c;
														}
														goto IL_1046;
														IL_1046:
														current5 = enumerator3.Current;
														num21 = 2;
														goto IL_102c;
														IL_102c:
														while (true)
														{
															switch (num21)
															{
															case 3:
																goto IL_1046;
															case 2:
																value6.Add(current5);
																num21 = 1;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
																{
																	num21 = 0;
																}
																continue;
															case 1:
																goto IL_107d;
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
													if (enumerator3 == null)
													{
														num22 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
														{
															num22 = 1;
														}
														goto IL_10cd;
													}
													goto IL_10e3;
													IL_10e3:
													OvaV7SzejkY4BOybd2x(enumerator3);
													num22 = 2;
													goto IL_10cd;
													IL_10cd:
													switch (num22)
													{
													case 1:
														goto end_IL_10a8;
													case 2:
														goto end_IL_10a8;
													}
													goto IL_10e3;
													end_IL_10a8:;
												}
												break;
											case 2:
												enumerator3 = value7.Where(_003C_003Ec__DisplayClass70_3._003CFindModule_003Eb__3).GetEnumerator();
												num20 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
												{
													num20 = 1;
												}
												continue;
											case 4:
												goto end_IL_0fc8;
											}
											break;
										}
										continue;
										IL_0fde:
										current6 = enumerator2.Current;
										num20 = 3;
										goto IL_0fa6;
										continue;
										end_IL_0fc8:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num23 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
									{
										num23 = 0;
									}
									switch (num23)
									{
									case 0:
										break;
									}
								}
								goto case 16;
							case 20:
								if (dictionary2.TryGetValue(_003C_003Ec__DisplayClass70_3.remainingModule, out value6))
								{
									num19 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
									{
										num19 = 5;
									}
									continue;
								}
								goto case 14;
							case 23:
								value6 = hashSet;
								num19 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
								{
									num19 = 0;
								}
								continue;
							default:
								enumerator3 = hashSet8.OrderByDescending((CandidateDependModule a) => (Version)_003C_003Ec.TYYBGhfcMq6plEXGrfOE(a)).GetEnumerator();
								num19 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
								{
									num19 = 1;
								}
								continue;
							case 4:
								goto end_IL_09c0;
							}
							break;
						}
						goto IL_0972;
						IL_0972:
						_003C_003Ec__DisplayClass70_3 = new _003C_003Ec__DisplayClass70_1();
						num19 = 24;
						goto IL_00ae;
						continue;
						end_IL_09c0:
						break;
					}
				}
				finally
				{
					if (enumerator6 != null)
					{
						int num42 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num42 = 1;
						}
						while (true)
						{
							switch (num42)
							{
							case 1:
								enumerator6.Dispose();
								num42 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
								{
									num42 = 0;
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
			case 10:
				dictionary2 = new Dictionary<Guid, HashSet<CandidateDependModule>>();
				num2 = 18;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 12;
				}
				continue;
			case 18:
				enumerator6 = searchContext.AllModules.Except(searchContext.ChosenComponentModules.Keys).GetEnumerator();
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 11;
				}
				continue;
			case 17:
				if (!searchContext.CandidateModules.TryGetValue(clientComponentModel.ModuleItemUid, out value5))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 2:
			case 7:
				num3++;
				num2 = 3;
				continue;
			default:
				enumerator4 = searchContext.AllModules.GetEnumerator();
				num2 = 8;
				continue;
			case 8:
				try
				{
					while (true)
					{
						int num12;
						if (!enumerator4.MoveNext())
						{
							num12 = 18;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
							{
								num12 = 33;
							}
							goto IL_13b9;
						}
						goto IL_199f;
						IL_199f:
						current4 = enumerator4.Current;
						num12 = 5;
						goto IL_13b9;
						IL_13b9:
						while (true)
						{
							int num13;
							switch (num12)
							{
							default:
								clientComponentModel3 = array4[num14];
								num12 = 18;
								continue;
							case 32:
							{
								Dictionary<Guid, ClientComponentModel> chosenComponentModules4 = searchContext.ChosenComponentModules;
								Guid key4 = current4;
								ClientComponentModel clientComponentModel6 = new ClientComponentModel();
								n8FEILBFPLdNFpd5yqyN(clientComponentModel6, eHcW1YBFpwFvr1R4vjtR(candidateDependModule4));
								M82BL7zJJj9ytsx4xAS(clientComponentModel6, TRRkqPBF3DeBYb8ZFdtB(candidateDependModule4));
								clientComponentModel6.Owners = candidateDependModule4.Owners;
								chosenComponentModules4[key4] = clientComponentModel6;
								num12 = 8;
								continue;
							}
							case 29:
								array4 = array5;
								num12 = 14;
								continue;
							case 13:
							case 31:
								if (num14 < array4.Length)
								{
									num12 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
									{
										num12 = 0;
									}
									continue;
								}
								goto case 27;
							case 30:
							{
								Dictionary<Guid, ClientComponentModel> chosenComponentModules2 = searchContext.ChosenComponentModules;
								Guid key2 = current4;
								ClientComponentModel clientComponentModel4 = new ClientComponentModel();
								n8FEILBFPLdNFpd5yqyN(clientComponentModel4, candidateDependModule7.HeaderUid);
								M82BL7zJJj9ytsx4xAS(clientComponentModel4, TRRkqPBF3DeBYb8ZFdtB(candidateDependModule7));
								clientComponentModel4.Owners = candidateDependModule7.Owners;
								chosenComponentModules2[key2] = clientComponentModel4;
								num12 = 19;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
								{
									num12 = 14;
								}
								continue;
							}
							case 8:
							case 9:
							case 12:
							case 19:
								break;
							case 25:
								if (!dictionary.TryGetValue(current4, out value3))
								{
									num13 = 12;
									goto IL_13b5;
								}
								goto case 23;
							case 10:
								if (array5.Length == 0)
								{
									num12 = 24;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
									{
										num12 = 0;
									}
									continue;
								}
								goto case 3;
							case 23:
								array5 = componentsWithModule.Except(new ClientComponentModel[1] { clientComponentModel }).ToArray();
								num12 = 10;
								continue;
							case 3:
								list2 = null;
								num13 = 29;
								goto IL_13b5;
							case 2:
							{
								Dictionary<Guid, ClientComponentModel> chosenComponentModules3 = searchContext.ChosenComponentModules;
								Guid key3 = current4;
								ClientComponentModel clientComponentModel5 = new ClientComponentModel();
								n8FEILBFPLdNFpd5yqyN(clientComponentModel5, candidateDependModule5.HeaderUid);
								M82BL7zJJj9ytsx4xAS(clientComponentModel5, candidateDependModule5.ModuleItemUid);
								clientComponentModel5.Owners = candidateDependModule5.Owners;
								chosenComponentModules3[key3] = clientComponentModel5;
								num12 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
								{
									num12 = 1;
								}
								continue;
							}
							case 7:
								if (dEdIiqBFtxAsy0SKVqNc(list2) != 0)
								{
									num12 = 17;
									continue;
								}
								goto case 15;
							case 16:
								candidateDependModule7 = value3[0];
								num12 = 30;
								continue;
							case 18:
								if (!searchContext.CandidateModules.TryGetValue(MeY255BFZT4ltNIPAYVj(clientComponentModel3), out value4))
								{
									num12 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
									{
										num12 = 22;
									}
									continue;
								}
								goto case 21;
							case 22:
							case 26:
								num14++;
								num12 = 13;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
								{
									num12 = 5;
								}
								continue;
							case 6:
								if (!searchContext.ChosenModules.Contains(current4))
								{
									num12 = 25;
									continue;
								}
								break;
							case 1:
								try
								{
									while (true)
									{
										IL_1892:
										int num15;
										if (!enumerator5.MoveNext())
										{
											num15 = 10;
											goto IL_1767;
										}
										goto IL_1830;
										IL_1800:
										num15 = 8;
										goto IL_1767;
										IL_1830:
										_003C_003Ec__DisplayClass70_2 = new _003C_003Ec__DisplayClass70_0();
										int num16 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
										{
											num16 = 3;
										}
										goto IL_176b;
										IL_1767:
										num16 = num15;
										goto IL_176b;
										IL_176b:
										while (true)
										{
											switch (num16)
											{
											case 3:
												_003C_003Ec__DisplayClass70_2.candidate = enumerator5.Current;
												num16 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
												{
													num16 = 1;
												}
												continue;
											case 1:
												candidateDependModule6 = value3.Find(_003C_003Ec__DisplayClass70_2._003CFindModule_003Eb__2);
												num16 = 14;
												continue;
											case 2:
												if (list2 != null)
												{
													goto IL_1800;
												}
												goto case 7;
											case 6:
											case 13:
												list2.Add(candidateDependModule6);
												num16 = 11;
												continue;
											case 4:
												if (list2 != null)
												{
													num16 = 13;
													continue;
												}
												goto case 9;
											case 14:
												if (candidateDependModule6 == null)
												{
													num16 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
													{
														num16 = 5;
													}
													continue;
												}
												goto case 2;
											case 5:
											case 11:
											case 12:
												goto IL_1892;
											case 8:
												if (list2.Contains(candidateDependModule6))
												{
													num16 = 12;
													continue;
												}
												goto case 7;
											case 9:
												list2 = new List<CandidateDependModule>();
												num16 = 4;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
												{
													num16 = 6;
												}
												continue;
											case 7:
												if (candidateDependModule6.Valid)
												{
													num16 = 4;
													continue;
												}
												goto IL_1892;
											case 10:
												goto end_IL_1892;
											}
											break;
										}
										goto IL_1830;
										continue;
										end_IL_1892:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator5).Dispose();
									int num17 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
									{
										num17 = 0;
									}
									switch (num17)
									{
									case 0:
										break;
									}
								}
								goto case 22;
							case 15:
								result = false;
								num12 = 20;
								continue;
							case 5:
								if (!searchContext.ChosenComponentModules.ContainsKey(current4))
								{
									num12 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
									{
										num12 = 3;
									}
									continue;
								}
								break;
							case 11:
								goto IL_199f;
							case 27:
								if (list2 != null)
								{
									num12 = 7;
									continue;
								}
								goto case 16;
							case 21:
								enumerator5 = value4.GetEnumerator();
								num12 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
								{
									num12 = 1;
								}
								continue;
							case 14:
								num14 = 0;
								num12 = 31;
								continue;
							case 17:
							case 28:
								candidateDependModule5 = list2[0];
								num12 = 2;
								continue;
							case 24:
								candidateDependModule4 = value3[0];
								num13 = 32;
								goto IL_13b5;
							case 33:
								goto end_IL_1563;
							case 20:
								{
									return result;
								}
								IL_13b5:
								num12 = num13;
								continue;
							}
							break;
						}
						continue;
						end_IL_1563:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator4).Dispose();
					int num18 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num18 = 0;
					}
					switch (num18)
					{
					case 0:
						break;
					}
				}
				goto case 2;
			case 5:
				num3 = 0;
				num2 = 9;
				continue;
			case 13:
				return true;
			case 12:
				try
				{
					while (true)
					{
						IL_1b33:
						int num10;
						if (!Xtuo5mz2tWrRwGmUMM2(enumerator3))
						{
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
							{
								num10 = 0;
							}
							goto IL_1ab1;
						}
						goto IL_1b59;
						IL_1b59:
						current3 = enumerator3.Current;
						num10 = 4;
						goto IL_1ab1;
						IL_1ab1:
						while (true)
						{
							switch (num10)
							{
							case 2:
								dictionary[eHcW1YBFpwFvr1R4vjtR(current3)] = value2;
								num10 = 6;
								continue;
							case 4:
								if (!dictionary.TryGetValue(eHcW1YBFpwFvr1R4vjtR(current3), out value2))
								{
									num10 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
									{
										num10 = 1;
									}
									continue;
								}
								goto case 6;
							case 6:
								value2.Add(current3);
								num10 = 3;
								continue;
							case 3:
								goto IL_1b33;
							case 5:
								goto IL_1b59;
							case 1:
								value2 = new List<CandidateDependModule>();
								num10 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
								{
									num10 = 1;
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
					if (enumerator3 != null)
					{
						int num11 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num11 = 0;
						}
						while (true)
						{
							switch (num11)
							{
							default:
								enumerator3.Dispose();
								num11 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
								{
									num11 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto default;
			case 1:
				try
				{
					while (true)
					{
						int num5;
						if (!enumerator.MoveNext())
						{
							int num4 = 11;
							num5 = num4;
							goto IL_1c48;
						}
						goto IL_1fc1;
						IL_1c48:
						while (true)
						{
							switch (num5)
							{
							case 1:
								return result;
							case 24:
								return result;
							case 25:
								num3++;
								num5 = 4;
								continue;
							case 12:
							case 15:
								candidateDependModule3 = array2[0];
								num5 = 18;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
								{
									num5 = 1;
								}
								continue;
							case 20:
								if (list == null)
								{
									num5 = 21;
									continue;
								}
								goto case 16;
							case 27:
								enumerator2 = searchContext.ChosenComponentModules.Values.GetEnumerator();
								num5 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
								{
									num5 = 6;
								}
								continue;
							case 10:
							case 13:
								break;
							case 6:
								try
								{
									while (true)
									{
										int num6;
										if (!enumerator2.MoveNext())
										{
											num6 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
											{
												num6 = 0;
											}
											goto IL_1d8c;
										}
										goto IL_1ea1;
										IL_1ea1:
										current2 = enumerator2.Current;
										num6 = 2;
										goto IL_1d8c;
										IL_1d8c:
										while (true)
										{
											switch (num6)
											{
											case 4:
											case 7:
												list.Add(candidateDependModule);
												num6 = 11;
												continue;
											case 8:
											case 11:
												break;
											case 9:
												if (aSCXe9BFynUJVFOkKp78(candidateDependModule))
												{
													num6 = 6;
													continue;
												}
												break;
											case 2:
												if (searchContext.CandidateModules.TryGetValue(MeY255BFZT4ltNIPAYVj(current2), out value))
												{
													num6 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
													{
														num6 = 0;
													}
													continue;
												}
												break;
											case 13:
												list = new List<CandidateDependModule>();
												num6 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
												{
													num6 = 4;
												}
												continue;
											case 12:
												if (candidateDependModule != null)
												{
													num6 = 3;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
													{
														num6 = 3;
													}
													continue;
												}
												break;
											case 5:
												goto IL_1ea1;
											case 10:
												if (list.Contains(candidateDependModule))
												{
													num6 = 8;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
													{
														num6 = 8;
													}
													continue;
												}
												goto case 9;
											case 6:
												if (list != null)
												{
													num6 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
													{
														num6 = 7;
													}
													continue;
												}
												goto case 13;
											case 3:
												if (list != null)
												{
													int num7 = 10;
													num6 = num7;
													continue;
												}
												goto case 9;
											default:
												candidateDependModule = value.Find(_003C_003Ec__DisplayClass70_._003CFindModule_003Eb__8);
												num6 = 12;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
												{
													num6 = 7;
												}
												continue;
											case 1:
												goto end_IL_1de1;
											}
											break;
										}
										continue;
										end_IL_1de1:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
									{
										num8 = 0;
									}
									switch (num8)
									{
									case 0:
										break;
									}
								}
								goto case 25;
							case 8:
								result = false;
								num5 = 24;
								continue;
							case 23:
								goto IL_1fc1;
							case 17:
								list = null;
								num5 = 26;
								continue;
							case 7:
								_003C_003Ec__DisplayClass70_ = new _003C_003Ec__DisplayClass70_4();
								num5 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
								{
									num5 = 9;
								}
								continue;
							case 22:
								candidateDependModule2 = list[0];
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
								{
									num5 = 5;
								}
								continue;
							case 26:
								array3 = array2;
								num5 = 14;
								continue;
							case 2:
							case 21:
								if (array2.Length != 0)
								{
									num5 = 12;
									continue;
								}
								goto case 8;
							case 14:
								num3 = 0;
								num5 = 19;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
								{
									num5 = 9;
								}
								continue;
							default:
								result = false;
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
								{
									num5 = 1;
								}
								continue;
							case 9:
								_003C_003Ec__DisplayClass70_.componentVersion = array3[num3];
								num5 = 27;
								continue;
							case 18:
								searchContext.ChosenComponentModules[current.Key] = new ClientComponentModel
								{
									ModuleUid = eHcW1YBFpwFvr1R4vjtR(candidateDependModule3),
									ModuleItemUid = TRRkqPBF3DeBYb8ZFdtB(candidateDependModule3),
									Owners = candidateDependModule3.Owners
								};
								num5 = 13;
								continue;
							case 16:
								if (list.Count == 0)
								{
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
									{
										num5 = 0;
									}
									continue;
								}
								goto case 22;
							case 5:
							{
								Dictionary<Guid, ClientComponentModel> chosenComponentModules = searchContext.ChosenComponentModules;
								Guid key = current.Key;
								ClientComponentModel clientComponentModel2 = new ClientComponentModel();
								n8FEILBFPLdNFpd5yqyN(clientComponentModel2, eHcW1YBFpwFvr1R4vjtR(candidateDependModule2));
								clientComponentModel2.ModuleItemUid = TRRkqPBF3DeBYb8ZFdtB(candidateDependModule2);
								clientComponentModel2.Owners = candidateDependModule2.Owners;
								chosenComponentModules[key] = clientComponentModel2;
								num5 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
								{
									num5 = 10;
								}
								continue;
							}
							case 4:
							case 19:
								if (num3 >= array3.Length)
								{
									num5 = 13;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
									{
										num5 = 20;
									}
									continue;
								}
								goto case 7;
							case 3:
								array2 = current.Value.OrderByDescending((CandidateDependModule a) => (Version)_003C_003Ec.TYYBGhfcMq6plEXGrfOE(a)).ToArray();
								num5 = 17;
								continue;
							case 11:
								goto end_IL_1d4e;
							}
							break;
						}
						continue;
						IL_1fc1:
						current = enumerator.Current;
						num5 = 3;
						goto IL_1c48;
						continue;
						end_IL_1d4e:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num9 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num9 = 0;
					}
					switch (num9)
					{
					case 0:
						break;
					}
				}
				goto case 13;
			case 14:
			case 15:
				clientComponentModel = array[num3];
				num2 = 17;
				continue;
			case 16:
				enumerator = dictionary2.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				break;
			}
			IOrderedEnumerable<CandidateDependModule> orderedEnumerable = from a in value5
				where a.Valid
				orderby (Version)_003C_003Ec.TYYBGhfcMq6plEXGrfOE(a) descending
				select a;
			dictionary = new Dictionary<Guid, List<CandidateDependModule>>();
			enumerator3 = orderedEnumerable.GetEnumerator();
			num2 = 12;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
			{
				num2 = 12;
			}
		}
	}

	private void GetComponentFromModule(Guid moduleUid, Guid componentUid, SearchContext searchContext)
	{
		//Discarded unreachable code: IL_0106, IL_0157
		int num = 9;
		int num2 = num;
		ModuleVersion module = default(ModuleVersion);
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		_003C_003Ec__DisplayClass71_0 _003C_003Ec__DisplayClass71_ = default(_003C_003Ec__DisplayClass71_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 5:
				module = GetModule(moduleUid, searchContext);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 10;
				}
				continue;
			default:
				if (componentMetadata != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 6;
					}
					continue;
				}
				break;
			case 4:
				return;
			case 2:
				componentMetadata = ((ModuleInfoMetadata)iMlyy1ztkAWCr8rEdWj(module)).Components.FirstOrDefault(_003C_003Ec__DisplayClass71_._003CGetComponentFromModule_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 0;
				}
				continue;
			case 8:
				_003C_003Ec__DisplayClass71_.componentUid = componentUid;
				num2 = 5;
				continue;
			case 7:
				return;
			case 6:
				GetModuleClientComponentModel(module, componentMetadata, searchContext);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 1;
				}
				continue;
			case 9:
				_003C_003Ec__DisplayClass71_ = new _003C_003Ec__DisplayClass71_0();
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 8;
				}
				continue;
			case 10:
				if (module == null)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 2;
				}
				continue;
			case 3:
				break;
			}
			GetComponentFromConfiguration(_003C_003Ec__DisplayClass71_.componentUid, searchContext);
			num2 = 7;
		}
	}

	private ModuleVersion GetModule(Guid moduleUid, SearchContext searchContext)
	{
		//Discarded unreachable code: IL_01aa, IL_01ba, IL_01c9, IL_01ff, IL_020e, IL_02c2, IL_02fa
		int num = 10;
		int num2 = num;
		IEnumerator<ModuleVersionHeader> enumerator = default(IEnumerator<ModuleVersionHeader>);
		IEnumerable<ModuleVersionHeader> value = default(IEnumerable<ModuleVersionHeader>);
		ModuleVersion defaultModuleVersion = default(ModuleVersion);
		IEnumerable<ModuleVersionHeader> enumerable = default(IEnumerable<ModuleVersionHeader>);
		ModuleVersionHeader current = default(ModuleVersionHeader);
		ModuleVersion result = default(ModuleVersion);
		while (true)
		{
			switch (num2)
			{
			case 7:
				enumerator = value.GetEnumerator();
				num2 = 3;
				break;
			case 5:
				return null;
			case 9:
				if (defaultModuleVersion != null)
				{
					if (searchContext.IncompatibleModuleItems.Contains(((ModuleVersionHeader)wyDj5JBFOvUp3aNhic5o(defaultModuleVersion)).VersionUid))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 1;
				}
				break;
			case 10:
				defaultModuleVersion = moduleMetadataLoader.GetDefaultModuleVersion(moduleUid);
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return defaultModuleVersion;
			case 2:
				if (!searchContext.ModuleVersions.TryGetValue(moduleUid, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			case 6:
				value = enumerable;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 7;
				}
				break;
			case 8:
				return null;
			case 1:
				searchContext.Errors.Add(SR.T((string)PC0R82zrUHU2qMy6Gg0(-1411196499 ^ -1411236385), moduleUid));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 2;
				}
				break;
			default:
				enumerable = (searchContext.ModuleVersions[moduleUid] = moduleMetadataLoader.GetModuleVersionHeaders(moduleUid));
				num2 = 6;
				break;
			case 3:
				try
				{
					while (true)
					{
						IL_0276:
						int num3;
						if (!Xtuo5mz2tWrRwGmUMM2(enumerator))
						{
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
							{
								num3 = 3;
							}
							goto IL_01d8;
						}
						goto IL_0219;
						IL_0219:
						current = enumerator.Current;
						num3 = 4;
						goto IL_01d8;
						IL_01d8:
						while (true)
						{
							switch (num3)
							{
							case 2:
								return result;
							case 1:
								break;
							case 5:
							{
								result = (ModuleVersion)vHy53qzduNL4la1OiPP(moduleMetadataLoader, g6LHQuBF76gEdOIm0C5X(current), zhf61FzAs08ZdStq71m(current));
								int num4 = 2;
								num3 = num4;
								continue;
							}
							case 4:
								if (!searchContext.IncompatibleModuleItems.Contains(zhf61FzAs08ZdStq71m(current)))
								{
									num3 = 5;
									continue;
								}
								goto IL_0276;
							default:
								goto IL_0276;
							case 3:
								goto end_IL_0276;
							}
							break;
						}
						goto IL_0219;
						continue;
						end_IL_0276:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								OvaV7SzejkY4BOybd2x(enumerator);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
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
				goto case 8;
			}
		}
	}

	private void GetModuleClientComponentModel(ModuleVersion module, ComponentMetadata component, SearchContext searchContext)
	{
		//Discarded unreachable code: IL_00c6, IL_00d5, IL_00fc, IL_010b, IL_01f7, IL_0206
		int num = 13;
		int num2 = num;
		ComponentGraph.Vertex vertex = default(ComponentGraph.Vertex);
		Guid guid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 11:
			{
				Dictionary<Guid, ClientComponentModel> components = searchContext.Components;
				Guid key = EKWac9zzFvThoYiiFo5(vertex);
				ClientComponentModel obj = new ClientComponentModel
				{
					ModuleUid = o91ZZ6BFe7tmdgKxfgXN(vertex)
				};
				M82BL7zJJj9ytsx4xAS(obj, EKWac9zzFvThoYiiFo5(vertex));
				obj.Owners = vertex.Owners;
				aJiRH2BFWqD71eFO0MDW(obj, vertex.Async);
				components.Add(key, obj);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 3;
				}
				break;
			}
			case 1:
				guid = zhf61FzAs08ZdStq71m(wyDj5JBFOvUp3aNhic5o(module));
				num2 = 5;
				break;
			case 15:
				return;
			case 3:
				searchContext.ChosenModules.Add(o91ZZ6BFe7tmdgKxfgXN(vertex));
				num2 = 9;
				break;
			case 14:
				searchContext.Errors.Add(SR.T((string)PC0R82zrUHU2qMy6Gg0(0x1FFEF86A ^ 0x1FFE19F0), BcBEmvzUHSE6Hf3AR79(component)));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 5;
				}
				break;
			case 13:
				if (module == null)
				{
					num2 = 12;
					break;
				}
				uir9COBFbdBxBXhvM3Cg(searchContext.Options, InterfaceBuilderViewMode.Runtime);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 1;
				}
				break;
			case 12:
				return;
			case 4:
				searchContext.Errors.Add(SR.T((string)PC0R82zrUHU2qMy6Gg0(-867826612 ^ -867768874), BcBEmvzUHSE6Hf3AR79(component)));
				num2 = 2;
				break;
			case 9:
				if (FindComponent(guid, guid, guid, component.Uid, ((ModuleInfoMetadata)iMlyy1ztkAWCr8rEdWj(module)).Dependency.Components, searchContext))
				{
					num2 = 10;
					break;
				}
				goto case 7;
			case 7:
				searchContext.Errors.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146534727), BcBEmvzUHSE6Hf3AR79(component)));
				num2 = 6;
				break;
			case 8:
				return;
			case 6:
				return;
			case 10:
				if (FindModuleImpl(guid, guid, guid, cMLTumBFhHIoYiMbgbG3(component), module, searchContext))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 2:
				return;
			default:
				if (FindCustomTypes(searchContext))
				{
					num2 = 15;
					break;
				}
				goto case 14;
			case 5:
				vertex = (ComponentGraph.Vertex)f7OjbUBFJtFSCSk1JvW9(cKHlxVzcgw9q1aIwTx5(searchContext), cMLTumBFhHIoYiMbgbG3(component), guid, uUi5StBFMCssTCDkHA2T(component), false);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 9;
				}
				break;
			}
		}
	}

	private bool FindModuleComponent(Guid parent, Guid owner, Guid moduleUid, Guid parentComponentUid, ComponentDependency dependency, SearchContext searchContext)
	{
		//Discarded unreachable code: IL_0095, IL_00a4, IL_00c6, IL_00d5, IL_00e4, IL_0204, IL_0279, IL_0305, IL_0342, IL_039b, IL_03a5, IL_044b, IL_0483, IL_0493, IL_04a2, IL_04ad, IL_0549, IL_055c, IL_056b, IL_0767, IL_079f, IL_07ae, IL_087c
		int num = 17;
		_003C_003Ec__DisplayClass74_0 _003C_003Ec__DisplayClass74_ = default(_003C_003Ec__DisplayClass74_0);
		ModuleVersionHeader[] array2 = default(ModuleVersionHeader[]);
		bool flag = default(bool);
		ModuleVersionHeader[] array = default(ModuleVersionHeader[]);
		IEnumerable<ModuleVersionHeader> value = default(IEnumerable<ModuleVersionHeader>);
		IEnumerable<ModuleVersionHeader> source = default(IEnumerable<ModuleVersionHeader>);
		IEnumerator<ComponentGraph.Vertex> enumerator = default(IEnumerator<ComponentGraph.Vertex>);
		HashSet<string>.Enumerator enumerator3 = default(HashSet<string>.Enumerator);
		_003C_003Ec__DisplayClass74_1 _003C_003Ec__DisplayClass74_2 = default(_003C_003Ec__DisplayClass74_1);
		ModuleInfoMetadata moduleInfoMetadata = default(ModuleInfoMetadata);
		HashSet<Guid> value3 = default(HashSet<Guid>);
		Guid guid = default(Guid);
		IEnumerator<Guid> enumerator2 = default(IEnumerator<Guid>);
		Guid current = default(Guid);
		ClientComponentModel value2 = default(ClientComponentModel);
		string current2 = default(string);
		bool result = default(bool);
		IEnumerable<ModuleVersionHeader> enumerable = default(IEnumerable<ModuleVersionHeader>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					_003C_003Ec__DisplayClass74_.owner = owner;
					num2 = 3;
					continue;
				case 27:
					_003C_003Ec__DisplayClass74_.parentComponentUid = parentComponentUid;
					num2 = 12;
					continue;
				case 23:
					if (array2.Length == 0 && flag)
					{
						num2 = 26;
						continue;
					}
					goto case 4;
				case 17:
					break;
				case 9:
					flag = true;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 4;
					}
					continue;
				case 28:
					if (_003C_003Ec__DisplayClass74_.searchContext.CandidateDependencies.TryGetValue(_003C_003Ec__DisplayClass74_.dependencyHeaderUid, out _003C_003Ec__DisplayClass74_.itemUids))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 14;
				default:
					array = value.Where(_003C_003Ec__DisplayClass74_._003CFindModuleComponent_003Eb__3).ToArray();
					num2 = 19;
					continue;
				case 14:
					source = value;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 2;
					}
					continue;
				case 21:
					_003C_003Ec__DisplayClass74_.searchContext = searchContext;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 15;
					}
					continue;
				case 13:
					source = array;
					num2 = 9;
					continue;
				case 7:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 16;
								goto IL_0212;
							}
							goto IL_0576;
							IL_0212:
							while (true)
							{
								int num6;
								switch (num3)
								{
								case 4:
									enumerator3 = _003C_003Ec__DisplayClass74_2.vertex.ViewItemUidList.GetEnumerator();
									num3 = 20;
									continue;
								case 5:
								case 18:
									_003C_003Ec__DisplayClass74_.searchContext.ChosenModules.Add(o91ZZ6BFe7tmdgKxfgXN(_003C_003Ec__DisplayClass74_2.vertex));
									num3 = 15;
									continue;
								default:
									moduleInfoMetadata = (ModuleInfoMetadata)iMlyy1ztkAWCr8rEdWj(moduleMetadataLoader.GetSpecificModuleVersion(o91ZZ6BFe7tmdgKxfgXN(_003C_003Ec__DisplayClass74_2.vertex), EKWac9zzFvThoYiiFo5(_003C_003Ec__DisplayClass74_2.vertex)));
									num6 = 9;
									goto IL_020e;
								case 10:
								case 11:
									break;
								case 7:
									_003C_003Ec__DisplayClass74_2.vertex = enumerator.Current;
									num3 = 19;
									continue;
								case 14:
									value3 = new HashSet<Guid>();
									num3 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
									{
										num3 = 13;
									}
									continue;
								case 19:
									guid = EKWac9zzFvThoYiiFo5(_003C_003Ec__DisplayClass74_2.vertex);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
									{
										num3 = 0;
									}
									continue;
								case 21:
									try
									{
										while (true)
										{
											IL_03c3:
											int num4;
											if (!enumerator2.MoveNext())
											{
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
												{
													num4 = 0;
												}
												goto IL_03a9;
											}
											goto IL_03e9;
											IL_03e9:
											current = enumerator2.Current;
											num4 = 3;
											goto IL_03a9;
											IL_03a9:
											while (true)
											{
												switch (num4)
												{
												case 1:
													goto IL_03c3;
												case 2:
													goto IL_03e9;
												case 3:
													value2.Owners.Add(current);
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
													{
														num4 = 1;
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
										if (enumerator2 != null)
										{
											int num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
											{
												num5 = 0;
											}
											while (true)
											{
												switch (num5)
												{
												default:
													OvaV7SzejkY4BOybd2x(enumerator2);
													num5 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
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
									goto case 5;
								case 20:
									try
									{
										while (true)
										{
											IL_04f7:
											int num7;
											if (!enumerator3.MoveNext())
											{
												num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
												{
													num7 = 0;
												}
												goto IL_04b1;
											}
											goto IL_04cb;
											IL_04cb:
											current2 = enumerator3.Current;
											num7 = 3;
											goto IL_04b1;
											IL_04b1:
											while (true)
											{
												switch (num7)
												{
												case 1:
													goto IL_04cb;
												case 3:
													value2.RenderUidList.Add(current2);
													num7 = 2;
													continue;
												case 2:
													goto IL_04f7;
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
										((IDisposable)enumerator3).Dispose();
										int num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
										{
											num8 = 0;
										}
										switch (num8)
										{
										case 0:
											break;
										}
									}
									goto case 2;
								case 17:
									goto IL_0576;
								case 12:
									value3.Add(_003C_003Ec__DisplayClass74_2.vertex.ItemUid);
									num6 = 3;
									goto IL_020e;
								case 13:
									_003C_003Ec__DisplayClass74_.searchContext.CandidateDependencies[_003C_003Ec__DisplayClass74_.dependencyHeaderUid] = value3;
									num3 = 12;
									continue;
								case 8:
								{
									Dictionary<Guid, ClientComponentModel> components = _003C_003Ec__DisplayClass74_.searchContext.Components;
									Guid key = EKWac9zzFvThoYiiFo5(_003C_003Ec__DisplayClass74_2.vertex);
									ClientComponentModel obj = new ClientComponentModel
									{
										ModuleUid = o91ZZ6BFe7tmdgKxfgXN(_003C_003Ec__DisplayClass74_2.vertex)
									};
									M82BL7zJJj9ytsx4xAS(obj, guid);
									obj.RenderUidList = _003C_003Ec__DisplayClass74_2.vertex.ViewItemUidList;
									obj.Owners = _003C_003Ec__DisplayClass74_2.vertex.Owners;
									components[key] = obj;
									num3 = 18;
									continue;
								}
								case 15:
									if (!_003C_003Ec__DisplayClass74_.searchContext.CandidateDependencies.TryGetValue(_003C_003Ec__DisplayClass74_.dependencyHeaderUid, out value3))
									{
										num3 = 14;
										continue;
									}
									goto case 12;
								case 3:
									result = true;
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
									{
										num3 = 0;
									}
									continue;
								case 6:
									if (!_003C_003Ec__DisplayClass74_.searchContext.Components.TryGetValue(guid, out value2))
									{
										num3 = 8;
										continue;
									}
									goto case 4;
								case 9:
									if (!FindComponent(guid, guid, _003C_003Ec__DisplayClass74_2.vertex.Async ? guid : _003C_003Ec__DisplayClass74_.owner, _003C_003Ec__DisplayClass74_.dependencyHeaderUid, ((ModuleDependency)uJ6ZVgBFHGWZftlNPcOQ(moduleInfoMetadata)).Components, _003C_003Ec__DisplayClass74_.searchContext))
									{
										num3 = 10;
										continue;
									}
									goto case 6;
								case 2:
									enumerator2 = _003C_003Ec__DisplayClass74_2.vertex.Owners.Where(_003C_003Ec__DisplayClass74_2._003CFindModuleComponent_003Eb__6).GetEnumerator();
									num3 = 21;
									continue;
								case 16:
									goto end_IL_030f;
								case 1:
									{
										return result;
									}
									IL_020e:
									num3 = num6;
									continue;
								}
								break;
							}
							continue;
							IL_0576:
							_003C_003Ec__DisplayClass74_2 = new _003C_003Ec__DisplayClass74_1();
							num3 = 7;
							goto IL_0212;
							continue;
							end_IL_030f:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num9 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
							{
								num9 = 1;
							}
							while (true)
							{
								switch (num9)
								{
								case 1:
									OvaV7SzejkY4BOybd2x(enumerator);
									num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
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
					}
					goto case 24;
				case 11:
					flag = false;
					num2 = 28;
					continue;
				case 4:
					if (array2.Length != 0)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 18;
				case 3:
					if (!_003C_003Ec__DisplayClass74_.searchContext.ModuleVersions.TryGetValue(moduleUid, out value))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 20;
				case 1:
					enumerable = (_003C_003Ec__DisplayClass74_.searchContext.ModuleVersions[moduleUid] = moduleMetadataLoader.GetModuleVersionHeaders(moduleUid));
					num2 = 22;
					continue;
				case 5:
				case 8:
					source = value;
					num2 = 2;
					continue;
				case 16:
					_003C_003Ec__DisplayClass74_.parent = parent;
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 19;
					}
					continue;
				case 22:
					value = enumerable;
					num2 = 20;
					continue;
				case 26:
					array2 = value.Where(_003C_003Ec__DisplayClass74_._003CFindModuleComponent_003Eb__1).ToArray();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
				case 6:
				case 10:
					array2 = source.Where(_003C_003Ec__DisplayClass74_._003CFindModuleComponent_003Eb__0).ToArray();
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 18;
					}
					continue;
				case 15:
					_003C_003Ec__DisplayClass74_.dependency = dependency;
					num2 = 27;
					continue;
				case 24:
					return false;
				case 20:
					_003C_003Ec__DisplayClass74_.dependencyHeaderUid = _003C_003Ec__DisplayClass74_.dependency.HeaderUid;
					num2 = 11;
					continue;
				case 18:
					return false;
				case 25:
					enumerator = array2.Select(_003C_003Ec__DisplayClass74_._003CFindModuleComponent_003Eb__2).GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 7;
					}
					continue;
				case 19:
					if (array.Length == 0)
					{
						num2 = 5;
						continue;
					}
					goto case 13;
				}
				break;
			}
			_003C_003Ec__DisplayClass74_ = new _003C_003Ec__DisplayClass74_0();
			num = 16;
		}
	}

	private bool GetDataClassFromModule(Dependency dependency, SearchContext searchContext, IDictionary<Guid, ClientDataClassModel> result)
	{
		_003C_003Ec__DisplayClass75_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass75_0();
		CS_0024_003C_003E8__locals0.dependency = dependency;
		Guid moduleUid = CS_0024_003C_003E8__locals0.dependency.ModuleUid;
		if (!searchContext.ModuleVersions.TryGetValue(moduleUid, out var value))
		{
			IEnumerable<ModuleVersionHeader> enumerable = (searchContext.ModuleVersions[moduleUid] = moduleMetadataLoader.GetModuleVersionHeaders(moduleUid));
			value = enumerable;
		}
		foreach (ModuleVersionHeader item in value)
		{
			if (searchContext.Components.ContainsKey(item.VersionUid))
			{
				return true;
			}
			if (item.Signature.DataClasses.FirstOrDefault((DataClassDependency a) => _003C_003Ec__DisplayClass75_0.LYbKWKQWVYkxjA9NW7pd(_003C_003Ec__DisplayClass75_0.fLn3grQWI1o07jM45KsT(a), CS_0024_003C_003E8__locals0.dependency.HeaderUid)) != null)
			{
				result[CS_0024_003C_003E8__locals0.dependency.HeaderUid] = new ClientDataClassModel
				{
					ModuleItemUid = item.VersionUid
				};
				return true;
			}
		}
		return false;
	}

	private bool GetFunctionFromModule(FunctionDependency dependency, SearchContext searchContext, IDictionary<Guid, ClientFunctionModel> result)
	{
		_003C_003Ec__DisplayClass76_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass76_0();
		CS_0024_003C_003E8__locals0.dependency = dependency;
		Guid moduleUid = CS_0024_003C_003E8__locals0.dependency.ModuleUid;
		if (!searchContext.ModuleVersions.TryGetValue(moduleUid, out var value))
		{
			IEnumerable<ModuleVersionHeader> enumerable = (searchContext.ModuleVersions[moduleUid] = moduleMetadataLoader.GetModuleVersionHeaders(moduleUid));
			value = enumerable;
		}
		foreach (ModuleVersionHeader item in value)
		{
			if (searchContext.Components.ContainsKey(item.VersionUid))
			{
				return true;
			}
			if (item.Signature.Functions.FirstOrDefault((FunctionDependency a) => _003C_003Ec__DisplayClass76_0.ypiJQxQWXNHXiOriQKFW(a.HeaderUid, _003C_003Ec__DisplayClass76_0.NrA0WjQWKVT7QL4XRkwb(CS_0024_003C_003E8__locals0.dependency))) != null)
			{
				result[CS_0024_003C_003E8__locals0.dependency.HeaderUid] = new ClientFunctionModel
				{
					HeaderUid = CS_0024_003C_003E8__locals0.dependency.HeaderUid,
					ModuleItemUid = item.VersionUid,
					ModuleUid = CS_0024_003C_003E8__locals0.dependency.ModuleUid
				};
				return true;
			}
		}
		return false;
	}

	public RecursiveComponentModel FindComponent(ObjectFormFindComponentModel model, FindComponentOptions options)
	{
		//Discarded unreachable code: IL_0103, IL_017e, IL_01c8, IL_01d2, IL_02d6, IL_02e9, IL_0319, IL_0375, IL_037f, IL_0462, IL_0475, IL_0484, IL_050d, IL_0520, IL_052f, IL_05d0, IL_061c
		int num = 6;
		string text2 = default(string);
		Guid guid2 = default(Guid);
		ClientComponentModel clientComponentModel = default(ClientComponentModel);
		RecursiveComponentModel value = default(RecursiveComponentModel);
		List<ClientComponentModel>.Enumerator enumerator = default(List<ClientComponentModel>.Enumerator);
		HashSet<string>.Enumerator enumerator3 = default(HashSet<string>.Enumerator);
		string current3 = default(string);
		List<KeyValuePair<string, string>> list = default(List<KeyValuePair<string, string>>);
		string value2 = default(string);
		string text = default(string);
		ClientComponentModel current2 = default(ClientComponentModel);
		Guid guid = default(Guid);
		List<KeyValuePair<string, string>>.Enumerator enumerator2 = default(List<KeyValuePair<string, string>>.Enumerator);
		KeyValuePair<string, string> current = default(KeyValuePair<string, string>);
		SearchContext searchContext = default(SearchContext);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					text2 = guid2.ToString();
					num2 = 8;
					continue;
				case 4:
					guid2 = vfO5wYBFrkyDXxYc8S0I(model);
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 7;
					}
					continue;
				case 12:
					clientComponentModel = (ClientComponentModel)F0eBFgBFltXsWqDlFFQT(value);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					value = (RecursiveComponentModel)value.Clone();
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 2;
					}
					continue;
				case 10:
					moduleApplicationCacheResult[model.MetadataUid] = value;
					num = 14;
					break;
				case 5:
					if (moduleApplicationCacheResult.TryGetValue(pbqZmDBFdOsBTyucX6Fi(model), out value))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto IL_053d;
				default:
					if (!XYMrWbBF9tQNR5t8Wiok(options))
					{
						num2 = 7;
						continue;
					}
					goto case 10;
				case 7:
				case 14:
					return value;
				case 3:
					try
					{
						while (true)
						{
							IL_04cb:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 3;
								goto IL_018c;
							}
							goto IL_04a8;
							IL_018c:
							while (true)
							{
								switch (num3)
								{
								case 9:
									try
									{
										while (true)
										{
											int num6;
											if (!enumerator3.MoveNext())
											{
												num6 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
												{
													num6 = 1;
												}
												goto IL_01d6;
											}
											goto IL_0238;
											IL_0238:
											current3 = enumerator3.Current;
											num6 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
											{
												num6 = 4;
											}
											goto IL_01d6;
											IL_01d6:
											while (true)
											{
												switch (num6)
												{
												case 5:
													list.Add(new KeyValuePair<string, string>(current3, value2));
													num6 = 3;
													continue;
												case 3:
													break;
												case 2:
													goto IL_0238;
												default:
													value2 = (string)IMOPrgBFgciaGhbEpB3c(current3, text, text2);
													num6 = 5;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
													{
														num6 = 2;
													}
													continue;
												case 4:
													if (current3.Contains(text))
													{
														num6 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
														{
															num6 = 0;
														}
														continue;
													}
													break;
												case 1:
													goto end_IL_0212;
												}
												break;
											}
											continue;
											end_IL_0212:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator3).Dispose();
										int num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
										{
											num7 = 0;
										}
										switch (num7)
										{
										case 0:
											break;
										}
									}
									goto case 6;
								default:
									if (!current2.Owners.Remove(guid))
									{
										int num8 = 7;
										num3 = num8;
										continue;
									}
									goto case 8;
								case 10:
									enumerator3 = current2.RenderUidList.GetEnumerator();
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
									{
										num3 = 9;
									}
									continue;
								case 6:
									enumerator2 = list.GetEnumerator();
									num3 = 2;
									continue;
								case 4:
								case 7:
									list = new List<KeyValuePair<string, string>>();
									num3 = 10;
									continue;
								case 2:
									try
									{
										while (true)
										{
											int num4;
											if (!enumerator2.MoveNext())
											{
												num4 = 3;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
												{
													num4 = 0;
												}
												goto IL_0383;
											}
											goto IL_0423;
											IL_0423:
											current = enumerator2.Current;
											num4 = 4;
											goto IL_0383;
											IL_0383:
											while (true)
											{
												switch (num4)
												{
												case 4:
													current2.RenderUidList.Remove(current.Key);
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
													{
														num4 = 0;
													}
													continue;
												case 1:
													break;
												default:
													current2.RenderUidList.Add(current.Value);
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
													{
														num4 = 1;
													}
													continue;
												case 2:
													goto IL_0423;
												case 3:
													goto end_IL_03cf;
												}
												break;
											}
											continue;
											end_IL_03cf:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
										{
											num5 = 0;
										}
										switch (num5)
										{
										case 0:
											break;
										}
									}
									goto IL_04cb;
								case 8:
									current2.Owners.Add(guid2);
									num3 = 4;
									continue;
								case 5:
									break;
								case 1:
									goto IL_04cb;
								case 3:
									return value;
								}
								break;
							}
							goto IL_04a8;
							IL_04a8:
							current2 = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
							{
								num3 = 0;
							}
							goto IL_018c;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
				case 11:
				case 17:
				case 22:
					return value;
				case 20:
					if (!SHwxCpBFI8kUKZhtBG8g(guid, Guid.Empty))
					{
						num = 11;
						break;
					}
					goto case 15;
				case 21:
					enumerator = value.ComponentCache.GetEnumerator();
					num = 3;
					break;
				case 18:
					if (SHwxCpBFI8kUKZhtBG8g(guid, guid2))
					{
						num2 = 20;
						continue;
					}
					goto case 11;
				case 13:
					text = guid.ToString();
					num2 = 9;
					continue;
				case 19:
					((ClientComponentModel)F0eBFgBFltXsWqDlFFQT(value)).ItemUid = guid2;
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 17;
					}
					continue;
				case 6:
					if (XYMrWbBF9tQNR5t8Wiok(options))
					{
						num2 = 5;
						continue;
					}
					goto IL_053d;
				case 15:
					if (SHwxCpBFI8kUKZhtBG8g(guid2, Guid.Empty))
					{
						num2 = 13;
						continue;
					}
					goto case 11;
				case 2:
					value = FindComponentInternal(model, searchContext);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					guid = E9tAxZBFV0HgOdgjNQ3I(clientComponentModel);
					num = 4;
					break;
				case 1:
					{
						if (clientComponentModel == null)
						{
							num2 = 22;
							continue;
						}
						goto case 16;
					}
					IL_053d:
					searchContext = new SearchContext(options);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	private RecursiveComponentModel FindComponentInternal(ObjectFormFindComponentModel model, SearchContext searchContext)
	{
		//Discarded unreachable code: IL_00bb, IL_00c5, IL_016a, IL_01a2, IL_01b1, IL_0306, IL_0333, IL_0342, IL_034d, IL_043b, IL_044e, IL_045d, IL_04d7, IL_04e1, IL_0596, IL_05d6, IL_05e5, IL_05f1, IL_0600
		int num = 22;
		int num2 = num;
		RecursiveComponentModel recursiveComponentModel = default(RecursiveComponentModel);
		ClientComponentModel value = default(ClientComponentModel);
		IEnumerator<ClientFunctionModel> enumerator = default(IEnumerator<ClientFunctionModel>);
		ClientFunctionModel current = default(ClientFunctionModel);
		_003C_003Ec__DisplayClass78_0 _003C_003Ec__DisplayClass78_ = default(_003C_003Ec__DisplayClass78_0);
		ClientComponentModel[] array = default(ClientComponentModel[]);
		KeyValuePair<Guid, ClientComponentModel> keyValuePair = default(KeyValuePair<Guid, ClientComponentModel>);
		Dictionary<Guid, ClientComponentModel>.Enumerator enumerator3 = default(Dictionary<Guid, ClientComponentModel>.Enumerator);
		KeyValuePair<Guid, ClientComponentModel> current3 = default(KeyValuePair<Guid, ClientComponentModel>);
		ClientComponentModel value2 = default(ClientComponentModel);
		IEnumerator<ClientDataClassModel> enumerator2 = default(IEnumerator<ClientDataClassModel>);
		ClientDataClassModel current2 = default(ClientDataClassModel);
		while (true)
		{
			switch (num2)
			{
			case 9:
				In1G9QBFu5mGyHOPsJhK(recursiveComponentModel, value);
				num2 = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 2;
				}
				break;
			case 14:
				FillEntityDependencies(recursiveComponentModel);
				num2 = 19;
				break;
			case 15:
				try
				{
					while (true)
					{
						IL_00e3:
						int num3;
						if (!Xtuo5mz2tWrRwGmUMM2(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
							{
								num3 = 0;
							}
							goto IL_00c9;
						}
						goto IL_0121;
						IL_0121:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num3 = 1;
						}
						goto IL_00c9;
						IL_00c9:
						while (true)
						{
							switch (num3)
							{
							case 3:
								goto IL_00e3;
							case 1:
								value.Functions.Add(current);
								num3 = 3;
								continue;
							case 2:
								goto IL_0121;
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
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								OvaV7SzejkY4BOybd2x(enumerator);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
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
				goto default;
			case 12:
				FindComponentFromConfiguration(model, _003C_003Ec__DisplayClass78_.searchContext);
				num2 = 18;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 16;
				}
				break;
			case 13:
				if (array.All(_003C_003Ec__DisplayClass78_._003CFindComponentInternal_003Eb__1))
				{
					num2 = 24;
					break;
				}
				goto case 20;
			case 11:
				_003C_003Ec__DisplayClass78_._003C_003E4__this = this;
				num2 = 7;
				break;
			case 3:
				value = keyValuePair.Value;
				num2 = 4;
				break;
			case 6:
				return FindComponentInternal(model, _003C_003Ec__DisplayClass78_.searchContext);
			case 24:
				if (!FindModule(array, _003C_003Ec__DisplayClass78_.searchContext))
				{
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 8;
					}
					break;
				}
				enumerator3 = _003C_003Ec__DisplayClass78_.searchContext.ChosenComponentModules.GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				break;
			case 21:
				_003C_003Ec__DisplayClass78_.searchContext = searchContext;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 11;
				}
				break;
			case 19:
				return recursiveComponentModel;
			case 8:
				return FindComponentInternal(model, _003C_003Ec__DisplayClass78_.searchContext);
			case 17:
				_003C_003Ec__DisplayClass78_.searchContext.AllModules.AddRange(_003C_003Ec__DisplayClass78_.searchContext.ChosenModules);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 9;
				}
				break;
			case 18:
				keyValuePair = _003C_003Ec__DisplayClass78_.searchContext.Components.First();
				num2 = 3;
				break;
			case 2:
				try
				{
					while (true)
					{
						IL_03e9:
						int num7;
						if (!enumerator3.MoveNext())
						{
							num7 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
							{
								num7 = 0;
							}
							goto IL_0351;
						}
						goto IL_03c6;
						IL_03c6:
						current3 = enumerator3.Current;
						num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num7 = 0;
						}
						goto IL_0351;
						IL_0351:
						while (true)
						{
							switch (num7)
							{
							default:
								value2 = current3.Value;
								num7 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
								{
									num7 = 1;
								}
								continue;
							case 3:
								_003C_003Ec__DisplayClass78_.searchContext.Components.Add(MeY255BFZT4ltNIPAYVj(value2), value2);
								num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
								{
									num7 = 1;
								}
								continue;
							case 2:
								break;
							case 1:
								goto IL_03e9;
							case 4:
								goto end_IL_03e9;
							}
							break;
						}
						goto IL_03c6;
						continue;
						end_IL_03e9:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator3).Dispose();
					int num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num8 = 0;
					}
					switch (num8)
					{
					case 0:
						break;
					}
				}
				goto case 9;
			case 23:
				iooQkoBFjwiNesIufA6I(_003C_003Ec__DisplayClass78_.searchContext);
				num2 = 8;
				break;
			case 7:
				recursiveComponentModel = new RecursiveComponentModel();
				num2 = 12;
				break;
			case 20:
				_003C_003Ec__DisplayClass78_.searchContext.Clear();
				num2 = 6;
				break;
			case 22:
				_003C_003Ec__DisplayClass78_ = new _003C_003Ec__DisplayClass78_0();
				num2 = 21;
				break;
			case 1:
				LsVbNKBF55JDN8n02vIg(_003C_003Ec__DisplayClass78_.searchContext.AllModules);
				num2 = 17;
				break;
			case 5:
				try
				{
					while (true)
					{
						IL_054a:
						int num5;
						if (!Xtuo5mz2tWrRwGmUMM2(enumerator2))
						{
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
							{
								num5 = 0;
							}
							goto IL_04e5;
						}
						goto IL_04ff;
						IL_04ff:
						current2 = enumerator2.Current;
						num5 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num5 = 1;
						}
						goto IL_04e5;
						IL_04e5:
						while (true)
						{
							switch (num5)
							{
							case 2:
								goto IL_04ff;
							case 3:
								value.DataClasses.Add(current2);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
								{
									num5 = 1;
								}
								continue;
							case 1:
								goto IL_054a;
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
					int num6;
					if (enumerator2 == null)
					{
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num6 = 0;
						}
						goto IL_059a;
					}
					goto IL_05b0;
					IL_05b0:
					OvaV7SzejkY4BOybd2x(enumerator2);
					num6 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num6 = 2;
					}
					goto IL_059a;
					IL_059a:
					switch (num6)
					{
					default:
						goto end_IL_0575;
					case 1:
						break;
					case 0:
						goto end_IL_0575;
					case 2:
						goto end_IL_0575;
					}
					goto IL_05b0;
					end_IL_0575:;
				}
				goto case 1;
			case 4:
				enumerator = _003C_003Ec__DisplayClass78_.searchContext.Functions.Values.Where(_003C_003Ec__DisplayClass78_._003CFindComponentInternal_003Eb__3).GetEnumerator();
				num2 = 15;
				break;
			default:
				enumerator2 = _003C_003Ec__DisplayClass78_.searchContext.DataClasses.Values.Where(_003C_003Ec__DisplayClass78_._003CFindComponentInternal_003Eb__4).GetEnumerator();
				num2 = 5;
				break;
			case 10:
				array = _003C_003Ec__DisplayClass78_.searchContext.Components.Values.Where((ClientComponentModel component) => _003C_003Ec.pgSCdFfcxyg867jk9orx(component.ModuleItemUid, Guid.Empty)).ToArray();
				num2 = 13;
				break;
			case 16:
				recursiveComponentModel.ComponentCache = (from a in _003C_003Ec__DisplayClass78_.searchContext.Components.Except(new KeyValuePair<Guid, ClientComponentModel>[1] { keyValuePair })
					select a.Value).ToList();
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	private void FindComponentFromConfiguration(ObjectFormFindComponentModel model, SearchContext searchContext)
	{
		//Discarded unreachable code: IL_00e8, IL_00f7, IL_0102, IL_019d, IL_01d5, IL_0229, IL_0238, IL_03d7, IL_03e6, IL_03f1, IL_048c, IL_04cc, IL_04db, IL_04e7, IL_04f6, IL_0521, IL_0530
		int num = 5;
		string text = default(string);
		ComponentGraph.Vertex vertex = default(ComponentGraph.Vertex);
		Guid guid = default(Guid);
		IEnumerator<ClientFunctionModel> enumerator = default(IEnumerator<ClientFunctionModel>);
		ClientFunctionModel current2 = default(ClientFunctionModel);
		IEnumerator<ClientDataClassModel> enumerator2 = default(IEnumerator<ClientDataClassModel>);
		IEnumerable<ClientDataClassModel> item2 = default(IEnumerable<ClientDataClassModel>);
		IEnumerable<ClientFunctionModel> item = default(IEnumerable<ClientFunctionModel>);
		ClientDataClassModel current = default(ClientDataClassModel);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					searchContext.Errors.Add(SR.T((string)PC0R82zrUHU2qMy6Gg0(-195614443 ^ -195573731), text));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 1;
					}
					continue;
				case 17:
					return;
				case 11:
					return;
				case 3:
					vertex = (ComponentGraph.Vertex)f7OjbUBFJtFSCSk1JvW9(cKHlxVzcgw9q1aIwTx5(searchContext), guid, vfO5wYBFrkyDXxYc8S0I(model), Guid.Empty, false);
					num = 2;
					break;
				case 13:
					try
					{
						while (true)
						{
							IL_0143:
							int num5;
							if (!Xtuo5mz2tWrRwGmUMM2(enumerator))
							{
								num5 = 2;
								goto IL_0106;
							}
							goto IL_0120;
							IL_0106:
							while (true)
							{
								switch (num5)
								{
								case 3:
									goto IL_0143;
								case 1:
									searchContext.Functions[JjPtnYBFoMWBXtGgW9M3(current2)] = current2;
									num5 = 3;
									continue;
								case 2:
									goto end_IL_0143;
								}
								break;
							}
							goto IL_0120;
							IL_0120:
							current2 = enumerator.Current;
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
							{
								num5 = 1;
							}
							goto IL_0106;
							continue;
							end_IL_0143:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									OvaV7SzejkY4BOybd2x(enumerator);
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
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
					goto case 9;
				case 19:
					searchContext.Errors.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886589671), text));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					if (vKChURzsrUf3vkTTcIY(searchContext.Errors) <= 0)
					{
						num2 = 15;
						continue;
					}
					goto case 14;
				case 8:
					searchContext.Errors.Add(SR.T((string)PC0R82zrUHU2qMy6Gg0(-1411196499 ^ -1411237833), iOJgvJBFYRfKgNOAL24x(model)));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 17;
					}
					continue;
				case 9:
					enumerator2 = item2.GetEnumerator();
					num2 = 6;
					continue;
				case 16:
					if (FindComponent(model.ItemUid, vfO5wYBFrkyDXxYc8S0I(model), vfO5wYBFrkyDXxYc8S0I(model), guid, model.ComponentDependencies, searchContext))
					{
						num2 = 11;
						continue;
					}
					goto case 8;
				case 4:
					item = GetFunctions(text, model.FunctionDependencies, searchContext, throwException: true).functionModels;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 10;
					}
					continue;
				case 5:
					text = (string)xVcZMkBFsklcoOtoitoL(iOJgvJBFYRfKgNOAL24x(model), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824365623), B1upWEBFUphXlqLMPgfk(ql646BBFLR5BP1kDsgj2(model)));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
				{
					Dictionary<Guid, ClientComponentModel> components = searchContext.Components;
					Guid key = EKWac9zzFvThoYiiFo5(vertex);
					ClientComponentModel clientComponentModel = new ClientComponentModel();
					gHf6qOBFF83pESH2yeSb(clientComponentModel, EKWac9zzFvThoYiiFo5(vertex));
					aJiRH2BFWqD71eFO0MDW(clientComponentModel, q4h85NBFBxYqKkIqQqF1(vertex));
					clientComponentModel.RenderUidList = vertex.ViewItemUidList;
					components.Add(key, clientComponentModel);
					num2 = 18;
					continue;
				}
				default:
					((FindComponentOptions)lTCXFgzmDwbANeh2YWG(searchContext)).ViewMode = InterfaceBuilderViewMode.Runtime;
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 16;
					}
					continue;
				case 6:
					try
					{
						while (true)
						{
							IL_0422:
							int num3;
							if (!enumerator2.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
								{
									num3 = 1;
								}
								goto IL_03f5;
							}
							goto IL_040f;
							IL_040f:
							current = enumerator2.Current;
							num3 = 2;
							goto IL_03f5;
							IL_03f5:
							while (true)
							{
								switch (num3)
								{
								case 3:
									goto IL_0422;
								case 2:
									searchContext.DataClasses[KQ588fBFfP6HcAVOGSkp(current)] = current;
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
									{
										num3 = 1;
									}
									continue;
								case 1:
									goto end_IL_0422;
								}
								break;
							}
							goto IL_040f;
							continue;
							end_IL_0422:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator2 == null)
						{
							num4 = 2;
							goto IL_0490;
						}
						goto IL_04a6;
						IL_0490:
						switch (num4)
						{
						case 2:
							goto end_IL_047b;
						case 1:
							goto end_IL_047b;
						}
						goto IL_04a6;
						IL_04a6:
						OvaV7SzejkY4BOybd2x(enumerator2);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num4 = 1;
						}
						goto IL_0490;
						end_IL_047b:;
					}
					goto default;
				case 10:
					if (searchContext.Errors.Count > 0)
					{
						num2 = 19;
						continue;
					}
					item2 = GetDataClasses(text, model.DataClassDependencies, searchContext, throwException: true).dataClassModels;
					num2 = 12;
					continue;
				case 18:
					enumerator = item.GetEnumerator();
					num = 13;
					break;
				case 7:
					return;
				case 15:
					guid = pbqZmDBFdOsBTyucX6Fi(model);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	internal static bool GJVOnczTaR8Vx1UiM5r()
	{
		return P0XQefzXow7msOjblcG == null;
	}

	internal static FindComponentService ny0295zkI79qcRsEqK3()
	{
		return P0XQefzXow7msOjblcG;
	}

	internal static int ehvH7RznYpL4PA3dcfB(object P_0)
	{
		return ((HashSet<Guid>)P_0).Count;
	}

	internal static void a1VJ1AzO2HAIBOnZwkj(object P_0, int timeout, object P_2)
	{
		((ISession)P_0).ExecuteWithTimeout(timeout, (Action)P_2);
	}

	internal static bool Xtuo5mz2tWrRwGmUMM2(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void OvaV7SzejkY4BOybd2x(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object bJZRQIzPaXpi6pREbbm(object P_0)
	{
		return ((ComponentMetadataItemWrapper)P_0).Signature;
	}

	internal static Guid bwoDqGz1JjsA7K0CQeq(object P_0)
	{
		return ((CustomTypeImplementationModel)P_0).TypeUid;
	}

	internal static void SEdqeFzN2Wids1PlI5K(object P_0, Guid value)
	{
		((CustomTypeModel)P_0).TypeUid = value;
	}

	internal static bool Tpq3Slz3nJ8ch1Jm4Y6(object P_0)
	{
		return ((CustomTypeImplementationModel)P_0).IsCollection;
	}

	internal static void kmWlLozpIDaOhPsyqEK(object P_0, bool value)
	{
		((CustomTypeModel)P_0).IsCollection = value;
	}

	internal static Guid A3K5WQza9pDvO3NWvq1(object P_0)
	{
		return ((ComponentMetadataItemWrapper)P_0).Uid;
	}

	internal static void vFLZn2zDunAfWQQI5BK(object P_0, Guid value)
	{
		((CustomTypeModel)P_0).ItemUid = value;
	}

	internal static object iMlyy1ztkAWCr8rEdWj(object P_0)
	{
		return ((ModuleVersion)P_0).Metadata;
	}

	internal static object CvRW6lzwwq0EQ5KXDKY(object P_0)
	{
		return ((ComponentMetadata)P_0).CustomTypeImplementation;
	}

	internal static void BJfHPkz4usOYVkh496y(object P_0, Guid value)
	{
		((CustomTypeModel)P_0).SubTypeUid = value;
	}

	internal static void UCkqCpz6l2NnPWwCrjt(object P_0, Guid value)
	{
		((CustomTypeModel)P_0).HeaderUid = value;
	}

	internal static void hHaIsgzHbTKOkWBZkvL(object P_0, Guid value)
	{
		((CustomTypeModel)P_0).ModuleUid = value;
	}

	internal static Guid zhf61FzAs08ZdStq71m(object P_0)
	{
		return ((ModuleVersionHeader)P_0).VersionUid;
	}

	internal static int n3qm1lz7Myf3kxLsn3P(object P_0)
	{
		return ((List<ComponentMetadataItemWrapper>)P_0).Count;
	}

	internal static object GxSR99zx3ss5c8h2MMw(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object MTyav2z0mMKCuXrTiIo(object P_0)
	{
		return ((ICleanUIObjectsModel)P_0).Modules;
	}

	internal static object lTCXFgzmDwbANeh2YWG(object P_0)
	{
		return ((SearchContext)P_0).Options;
	}

	internal static int Er7FNezy60ZGrjl8Cre(object P_0)
	{
		return ((List<ItemRuntimeModel>)P_0).Count;
	}

	internal static Guid OLpPL4zMhFxCvpk9kMd(object P_0)
	{
		return ((ItemRuntimeModel)P_0).ItemUid;
	}

	internal static void M82BL7zJJj9ytsx4xAS(object P_0, Guid value)
	{
		((ClientComponentModel)P_0).ModuleItemUid = value;
	}

	internal static Guid NBVX77z9qIdCwXt3ICf(object P_0)
	{
		return ((ItemRuntimeModel)P_0).HeaderUid;
	}

	internal static object vHy53qzduNL4la1OiPP(object P_0, Guid moduleUid, Guid versionUid)
	{
		return ((IModuleMetadataLoader)P_0).GetSpecificModuleVersion(moduleUid, versionUid);
	}

	internal static Guid x23RTCzl072F9mR0SP8(object P_0)
	{
		return ((ModuleReference)P_0).ModuleUid;
	}

	internal static object PC0R82zrUHU2qMy6Gg0(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static InterfaceBuilderViewMode RQgC0czgFSWQ4XvqAxr(object P_0)
	{
		return ((FindComponentOptions)P_0).ViewMode;
	}

	internal static object QOMAZEz50QRLoH9oiWM(object P_0)
	{
		return ((ComponentMetadataItemHeader)P_0).Emulation;
	}

	internal static object z3Gya3zjOeKvblRLCEF(object P_0)
	{
		return ((ComponentMetadataItemHeader)P_0).Published;
	}

	internal static object DFASlozYEBdlcbhTFVo(object P_0)
	{
		return ((ComponentMetadataItem)P_0).Metadata;
	}

	internal static Guid sjUd4ZzLHZM6ksBmvHP(object P_0)
	{
		return ((ComponentMetadataItem)P_0).Uid;
	}

	internal static object BcBEmvzUHSE6Hf3AR79(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static int vKChURzsrUf3vkTTcIY(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static object cKHlxVzcgw9q1aIwTx5(object P_0)
	{
		return ((SearchContext)P_0).ComponentGraph;
	}

	internal static Guid EKWac9zzFvThoYiiFo5(object P_0)
	{
		return ((ComponentGraph.Vertex)P_0).ItemUid;
	}

	internal static void gHf6qOBFF83pESH2yeSb(object P_0, Guid value)
	{
		((ClientComponentModel)P_0).ItemUid = value;
	}

	internal static bool q4h85NBFBxYqKkIqQqF1(object P_0)
	{
		return ((ComponentGraph.Vertex)P_0).Async;
	}

	internal static void aJiRH2BFWqD71eFO0MDW(object P_0, bool value)
	{
		((ClientComponentModel)P_0).Async = value;
	}

	internal static Guid JjPtnYBFoMWBXtGgW9M3(object P_0)
	{
		return ((ClientFunctionModel)P_0).HeaderUid;
	}

	internal static void uir9COBFbdBxBXhvM3Cg(object P_0, InterfaceBuilderViewMode value)
	{
		((FindComponentOptions)P_0).ViewMode = value;
	}

	internal static Guid cMLTumBFhHIoYiMbgbG3(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Guid S8hxbYBFGlZbv2GJuYvK(object P_0)
	{
		return ((Dependency)P_0).HeaderUid;
	}

	internal static bool SODVc5BFE1jGqDmIIqZJ(object P_0)
	{
		return ((ClientComponentModel)P_0).Async;
	}

	internal static Guid KQ588fBFfP6HcAVOGSkp(object P_0)
	{
		return ((ClientDataClassModel)P_0).HeaderUid;
	}

	internal static int sDdEm3BFQbJHm5tfqV9U(object P_0)
	{
		return ((Dictionary<Guid, ClientComponentModel>)P_0).Count;
	}

	internal static void GhjFjEBFCndCXlt42s75(object P_0)
	{
		((List<string>)P_0).Reverse();
	}

	internal static object OnTNHEBFvIM8M49ecnRy()
	{
		return Logger.Log;
	}

	internal static void qAo95vBF8H25WWCSTQYN(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static Guid MeY255BFZT4ltNIPAYVj(object P_0)
	{
		return ((ClientComponentModel)P_0).ModuleItemUid;
	}

	internal static void In1G9QBFu5mGyHOPsJhK(object P_0, object P_1)
	{
		((RecursiveComponentModel)P_0).Header = (ClientComponentModel)P_1;
	}

	internal static bool SHwxCpBFI8kUKZhtBG8g(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid E9tAxZBFV0HgOdgjNQ3I(object P_0)
	{
		return ((ClientComponentModel)P_0).ItemUid;
	}

	internal static Guid MJd4j0BFSxyqrmO88VXq(object P_0)
	{
		return ((ClientComponentModel)P_0).ModuleUid;
	}

	internal static Guid DrepmcBFiXaxOYhG0UYT(object P_0)
	{
		return ((ClientFunctionModel)P_0).ModuleItemUid;
	}

	internal static Guid RoQqCaBFRmwxZQEEr95e(object P_0)
	{
		return ((CustomTypeModel)P_0).ItemUid;
	}

	internal static Guid anstrnBFq6qDS1uSunmG(object P_0)
	{
		return ((ClientImplementationModel)P_0).ItemUid;
	}

	internal static Guid u9VTAiBFKr2hcEsUT9CQ(object P_0)
	{
		return ((ClientImplementationModel)P_0).ModuleItemUid;
	}

	internal static Guid zZ5tqXBFXc8CW3jfJJC3(object P_0)
	{
		return ((ClientImplementationModel)P_0).ModuleUid;
	}

	internal static object nlTaJcBFT5Ie2t4OOk9o(object P_0)
	{
		return ((ComponentMetadataItem)P_0).Signature;
	}

	internal static object Myq9P5BFkln6ljxvfiBh(object P_0)
	{
		return ((ModuleVersionHeader)P_0).Signature;
	}

	internal static Guid YxYSFPBFnmNjPCHUXxcv(object P_0)
	{
		return ((ComponentMetadataItemWrapper)P_0).HeaderUid;
	}

	internal static object wyDj5JBFOvUp3aNhic5o(object P_0)
	{
		return ((ModuleVersion)P_0).Header;
	}

	internal static object ar2MpGBF2WR9Iqk4CT2u(object P_0, Guid headerUid, Guid itemUid, Guid moduleUid, Guid parent, object P_5, Guid owner, bool async)
	{
		return ((ComponentGraph)P_0).AddVertex(headerUid, itemUid, moduleUid, parent, (string)P_5, owner, async);
	}

	internal static Guid o91ZZ6BFe7tmdgKxfgXN(object P_0)
	{
		return ((ComponentGraph.Vertex)P_0).ModuleUid;
	}

	internal static void n8FEILBFPLdNFpd5yqyN(object P_0, Guid value)
	{
		((ClientComponentModel)P_0).ModuleUid = value;
	}

	internal static Guid OMUDSfBF1aZmZMxuFVxw(object P_0)
	{
		return ((LinkToModule)P_0).ModuleUid;
	}

	internal static bool PjqLdUBFN5nTFGxfWBq3(object P_0, Guid moduleUid)
	{
		return ((IModuleMetadataLoader)P_0).IsSystemModule(moduleUid);
	}

	internal static Guid TRRkqPBF3DeBYb8ZFdtB(object P_0)
	{
		return ((CandidateDependModule)P_0).ModuleItemUid;
	}

	internal static Guid eHcW1YBFpwFvr1R4vjtR(object P_0)
	{
		return ((CandidateDependModule)P_0).HeaderUid;
	}

	internal static void lCITBgBFaM1sJH8Ic0xa(object P_0, object P_1)
	{
		((CandidateDependModule)P_0).Version = (Version)P_1;
	}

	internal static void MjCaSABFDI60LPKqXDpH(object P_0, bool value)
	{
		((CandidateDependModule)P_0).Valid = value;
	}

	internal static int dEdIiqBFtxAsy0SKVqNc(object P_0)
	{
		return ((List<CandidateDependModule>)P_0).Count;
	}

	internal static int ctifHNBFwwoa6iudFPtk(object P_0)
	{
		return ((HashSet<CandidateDependModule>)P_0).Count;
	}

	internal static int bxgLweBF4alAQMvkIPkO(object P_0)
	{
		return ((Dictionary<Guid, ClientComponentModel>.ValueCollection)P_0).Count;
	}

	internal static bool zxK5JxBF6vqpPYmhsZoS(object P_0)
	{
		return ((FindComponentOptions)P_0).CheckCompatibility;
	}

	internal static object uJ6ZVgBFHGWZftlNPcOQ(object P_0)
	{
		return ((ModuleInfoMetadata)P_0).Dependency;
	}

	internal static bool biNyKKBFAH2ZLqXDRfMf(object P_0)
	{
		return ((CompatibilityResult)P_0).IsValid;
	}

	internal static Guid g6LHQuBF76gEdOIm0C5X(object P_0)
	{
		return ((ModuleVersionHeader)P_0).HeaderUid;
	}

	internal static void YLGZ44BFxB4FuA8IiUUQ(object P_0, Guid value)
	{
		((CandidateDependModule)P_0).HeaderUid = value;
	}

	internal static void RMP0R2BF0y2Fdpy2KsiU(object P_0, Guid value)
	{
		((CandidateDependModule)P_0).ModuleItemUid = value;
	}

	internal static object LXTnMLBFmiUQfSubUX0W(object P_0)
	{
		return ((ModuleVersionHeader)P_0).Version;
	}

	internal static bool aSCXe9BFynUJVFOkKp78(object P_0)
	{
		return ((CandidateDependModule)P_0).Valid;
	}

	internal static Guid uUi5StBFMCssTCDkHA2T(object P_0)
	{
		return ((AbstractMetadata)P_0).ModuleUid;
	}

	internal static object f7OjbUBFJtFSCSk1JvW9(object P_0, Guid headerUid, Guid itemUid, Guid moduleUid, bool async)
	{
		return ((ComponentGraph)P_0).AddHeadVertex(headerUid, itemUid, moduleUid, async);
	}

	internal static bool XYMrWbBF9tQNR5t8Wiok(object P_0)
	{
		return ((FindComponentOptions)P_0).CacheResult;
	}

	internal static Guid pbqZmDBFdOsBTyucX6Fi(object P_0)
	{
		return ((ObjectFormFindComponentModel)P_0).MetadataUid;
	}

	internal static object F0eBFgBFltXsWqDlFFQT(object P_0)
	{
		return ((RecursiveComponentModel)P_0).Header;
	}

	internal static Guid vfO5wYBFrkyDXxYc8S0I(object P_0)
	{
		return ((ObjectFormFindComponentModel)P_0).ItemUid;
	}

	internal static object IMOPrgBFgciaGhbEpB3c(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void LsVbNKBF55JDN8n02vIg(object P_0)
	{
		((HashSet<Guid>)P_0).Clear();
	}

	internal static void iooQkoBFjwiNesIufA6I(object P_0)
	{
		((SearchContext)P_0).Clear();
	}

	internal static object iOJgvJBFYRfKgNOAL24x(object P_0)
	{
		return ((ObjectFormFindComponentModel)P_0).MetadataDisplayName;
	}

	internal static object ql646BBFLR5BP1kDsgj2(object P_0)
	{
		return ((ObjectFormFindComponentModel)P_0).Form;
	}

	internal static object B1upWEBFUphXlqLMPgfk(object P_0)
	{
		return ((FormViewItem)P_0).DisplayName;
	}

	internal static object xVcZMkBFsklcoOtoitoL(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}
}
