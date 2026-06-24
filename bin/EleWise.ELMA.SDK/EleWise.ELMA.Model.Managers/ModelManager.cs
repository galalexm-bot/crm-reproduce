using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Events;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.ScriptDesigner.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Managers;

public class ModelManager : DTOManager, IModelManager, IConfigurationService
{
	private class MetadataItemSaveEventHandler : IMetadataItemSaveEventHandler, IEventHandler
	{
		private readonly IDictionary<Guid, IMetadataItem> metadataItems;

		internal static object WAE340CjOMwSCJlpr9Da;

		public List<IMetadataItem> SavedItems { get; }

		public MetadataItemSaveEventHandler(IEnumerable<IMetadataItem> metadataItems)
		{
			SingletonReader.JJCZtPuTvSt();
			SavedItems = new List<IMetadataItem>();
			base._002Ector();
			this.metadataItems = metadataItems.ToDictionary((IMetadataItem i) => _003C_003Ec.BkZfZZZSXpCZxGTn0ghv(i));
		}

		public void BeforeSave(IMetadataItem metadataItem)
		{
			int num = 3;
			int num2 = num;
			IMetadataItem value = default(IMetadataItem);
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (metadataItems.TryGetValue(oSaKpNCjPk1WEehlcq2l(metadataItem), out value))
					{
						num2 = 2;
						break;
					}
					return;
				case 6:
					cbfeP1CjDDNSv6vSoIPX(metadataItem, ql1A9eCjakoHNDAr27kM(value));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					SavedItems.Add(metadataItem);
					num2 = 4;
					break;
				case 4:
					return;
				case 5:
					wvlm1bCjp23fx6kP6d6o(metadataItem, value.ClientScriptModule);
					num2 = 6;
					break;
				case 2:
					mgJ2CUCjNgyx17qdkBxZ(metadataItem, OoGfZpCj1T3h5YHDw8Js(value));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					Lp2VgDCj3o0U6vwJARcd(metadataItem, value.ScriptModule);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 5;
					}
					break;
				}
			}
		}

		internal static Guid oSaKpNCjPk1WEehlcq2l(object P_0)
		{
			return ((IMetadataItem)P_0).Uid;
		}

		internal static object OoGfZpCj1T3h5YHDw8Js(object P_0)
		{
			return ((IMetadataItem)P_0).Comment;
		}

		internal static void mgJ2CUCjNgyx17qdkBxZ(object P_0, object P_1)
		{
			((IMetadataItem)P_0).Comment = (string)P_1;
		}

		internal static void Lp2VgDCj3o0U6vwJARcd(object P_0, object P_1)
		{
			((IMetadataItem)P_0).ScriptModule = (ScriptModule)P_1;
		}

		internal static void wvlm1bCjp23fx6kP6d6o(object P_0, object P_1)
		{
			((IMetadataItem)P_0).ClientScriptModule = (ScriptModule)P_1;
		}

		internal static object ql1A9eCjakoHNDAr27kM(object P_0)
		{
			return ((IMetadataItem)P_0).Dependencies;
		}

		internal static void cbfeP1CjDDNSv6vSoIPX(object P_0, object P_1)
		{
			((IMetadataItem)P_0).Dependencies = P_1;
		}

		internal static bool z2UURgCj2K0IS0TEJ0mv()
		{
			return WAE340CjOMwSCJlpr9Da == null;
		}

		internal static MetadataItemSaveEventHandler LumU07CjecpjOMQBjPwl()
		{
			return (MetadataItemSaveEventHandler)WAE340CjOMwSCJlpr9Da;
		}
	}

	public const string DYNAMIC_MODEL_ASSEMBLY_NAME = "EleWise.ELMA.DynamicModel";

	public const string CONFIGURAION_MODEL_ASSEMBLY_NAME = "EleWise.ELMA.ConfigurationModel";

	public const string CONFIGURAION_MODEL_SCRIPTS_ASSEMBLY_NAME = "EleWise.ELMA.ConfigurationModel.Scripts";

	public const string ProcessContextNamespace = "EleWise.ELMA.Model.Entities.ProcessContext";

	public const string ProcessPrefix = "P_";

	[Obsolete("Not used", true)]
	public static readonly Guid CONFIGURAION_MODEL_SCRIPTMODULE_UID;

	public const string HubsAssemblyName = "EleWise.ELMA.SignalRHubs";

	internal static ModelManager xZq88GhCn4CfqIEblLvL;

	public MetadataItemManager MetadataItemManager => Locator.GetServiceNotNull<MetadataItemManager>();

	public IEntityManager<IMetadataItemHeader, long> MetadataItemHeaderManager => Locator.GetServiceNotNull<IEntityManager<IMetadataItemHeader, long>>();

	private IMetadataEditorService MetadataEditorService => Locator.GetServiceNotNull<IMetadataEditorService>();

	private IEventHandlerSubscribeService EventHandlerSubscribeService => Locator.GetServiceNotNull<IEventHandlerSubscribeService>();

	public virtual AssemblyModelsMetadata GetAssemblyModelsMetadata(string assemblyName)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return Locator.GetServiceNotNull<IMetadataRuntimeService>().GetAssemblyModelsMetadataList().FirstOrDefault(_003C_003Ec__DisplayClass15_._003CGetAssemblyModelsMetadata_003Eb__0);
			default:
				_003C_003Ec__DisplayClass15_.assemblyName = assemblyName;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual IEnumerable<AssemblyModelsMetadata> GetAssemblyModelsMetadataList()
	{
		return Locator.GetServiceNotNull<IMetadataRuntimeService>().GetAssemblyModelsMetadataList();
	}

	public virtual byte[] GetAssemblyModelsMetadataCompressed()
	{
		//Discarded unreachable code: IL_00ae, IL_022e, IL_0260, IL_026f, IL_02ba, IL_0329, IL_0348, IL_0357, IL_0384
		int num = 2;
		int num2 = num;
		IEnumerable<AssemblyModelsMetadata> assemblyModelsMetadataList = default(IEnumerable<AssemblyModelsMetadata>);
		List<AssemblyModelsMetadata> list = default(List<AssemblyModelsMetadata>);
		IEnumerator<AssemblyModelsMetadata> enumerator = default(IEnumerator<AssemblyModelsMetadata>);
		AssemblyModelsMetadata current = default(AssemblyModelsMetadata);
		AssemblyModelsMetadata assemblyModelsMetadata = default(AssemblyModelsMetadata);
		AbstractMetadata[] array = default(AbstractMetadata[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (assemblyModelsMetadataList == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					break;
				}
				list = new List<AssemblyModelsMetadata>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 5;
				}
				break;
			default:
				return null;
			case 2:
				assemblyModelsMetadataList = GetAssemblyModelsMetadataList();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return ((byte[])OMlEC3hCHUGxqWnYNHuk(list)).Zip();
			case 3:
				try
				{
					while (true)
					{
						IL_01bc:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
							{
								num3 = 1;
							}
							goto IL_00bc;
						}
						goto IL_0102;
						IL_0102:
						current = enumerator.Current;
						num3 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num3 = 3;
						}
						goto IL_00bc;
						IL_00bc:
						while (true)
						{
							switch (num3)
							{
							case 11:
								break;
							default:
								if (!bR6QxghCDX73BS9aKDet(z29Q7OhCPMhcTkZc2Z5x(current), nlotoFhCag9uM4ypVHdM(-1108654032 ^ -1108655586)))
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 6;
							case 14:
								if ((string)z29Q7OhCPMhcTkZc2Z5x(current) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70005399))
								{
									num3 = 7;
									continue;
								}
								goto case 3;
							case 4:
							{
								AssemblyModelsMetadata assemblyModelsMetadata2 = new AssemblyModelsMetadata();
								rIX5UghC1gMurgMR7LBR(assemblyModelsMetadata2, z29Q7OhCPMhcTkZc2Z5x(current));
								gWL4RXhC3LRUflZDuYo2(assemblyModelsMetadata2, YDTDOPhCNKkyOb6oqrYF(current));
								assemblyModelsMetadata = assemblyModelsMetadata2;
								num3 = 5;
								continue;
							}
							case 13:
								goto IL_01bc;
							case 12:
							{
								BiMUHZhC6q21fxMhLES2(assemblyModelsMetadata, n9IFSBhC4iP1nGSDChy6(current));
								int num4 = 2;
								num3 = num4;
								continue;
							}
							case 6:
							case 7:
							case 8:
								LpfIumhCwYgld9NaN8mQ(assemblyModelsMetadata, loksNZhCtw23224L4VxD(current));
								num3 = 12;
								continue;
							case 5:
								Dj0QiWhCpUgyONZZhWjx(assemblyModelsMetadata, array);
								num3 = 14;
								continue;
							case 1:
							case 2:
								list.Add(assemblyModelsMetadata);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
								{
									num3 = 13;
								}
								continue;
							case 3:
								if (bR6QxghCDX73BS9aKDet(z29Q7OhCPMhcTkZc2Z5x(current), nlotoFhCag9uM4ypVHdM(-70007027 ^ -70054517)))
								{
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
									{
										num3 = 8;
									}
									continue;
								}
								goto default;
							case 10:
								array = ((IEnumerable<AbstractMetadata>)WXIgKthCeVI1GKl0qQMc(current)).Select((AbstractMetadata m) => (AbstractMetadata)MetadataLoader.LoadMetadata(_003C_003Ec.gjunNUCjmiolF3QWAjoU(m), inherit: false, loadImplementation: false)).ToArray();
								num3 = 4;
								continue;
							case 9:
								goto end_IL_01bc;
							}
							break;
						}
						goto IL_0102;
						continue;
						end_IL_01bc:
						break;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num5 = 0;
						}
						goto IL_032d;
					}
					goto IL_0362;
					IL_0362:
					enumerator.Dispose();
					num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num5 = 1;
					}
					goto IL_032d;
					IL_032d:
					switch (num5)
					{
					default:
						goto end_IL_0308;
					case 0:
						goto end_IL_0308;
					case 2:
						break;
					case 1:
						goto end_IL_0308;
					}
					goto IL_0362;
					end_IL_0308:;
				}
				goto case 4;
			case 5:
				enumerator = assemblyModelsMetadataList.GetEnumerator();
				num2 = 3;
				break;
			}
		}
	}

	public virtual bool IsElmaApiTreeInitialized()
	{
		return lk8RakhCATWuJt7rs9hF(Locator.GetServiceNotNull<ElmaApiInitializerService>());
	}

	public virtual byte[] GetElmaApiTree()
	{
		return (byte[])EWgveOhC7oOLGBJV61oW(Locator.GetServiceNotNull<ElmaApiInitializerService>());
	}

	public virtual IEnumerable<MetadataItemDTO> GetMetadataItems()
	{
		return (from i in MetadataItemManager.FindDraftItems()
			select Mapper.Map<IMetadataItem, MetadataItemDTO>(i)).ToList();
	}

	public virtual List<MetadataItemDTO> SaveMetadataItems(List<MetadataItemDTO> metadataItems)
	{
		if (metadataItems == null)
		{
			return null;
		}
		List<IMetadataItem> list = metadataItems.Select((MetadataItemDTO dto) => Mapper.Map<MetadataItemDTO, IMetadataItem>(dto)).ToList();
		MetadataItemSaveEventHandler metadataItemSaveEventHandler = new MetadataItemSaveEventHandler(list);
		using (EventHandlerSubscribeService.Subscribe(metadataItemSaveEventHandler))
		{
			MetadataEditorService.SaveMetadata(list.Select((IMetadataItem item) => item.Metadata as IMetadata));
		}
		return metadataItemSaveEventHandler.SavedItems.Select((IMetadataItem i) => Mapper.Map<IMetadataItem, MetadataItemDTO>(i)).ToList();
	}

	public virtual void DeleteMetadataItem(long metadataItemId)
	{
		//Discarded unreachable code: IL_00db, IL_00ea
		int num = 2;
		int num2 = num;
		IMetadataItem metadataItem = default(IMetadataItem);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (((IMetadataItemHeader)sHmXiihCxXUsj0ObESH7(metadataItem)).Published == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto default;
			default:
				throw new InvalidOperationException(SR.T((string)nlotoFhCag9uM4ypVHdM(--1867379187 ^ 0x6F4EC635), WtpvB1hC0jWG3hCfHZaf(sHmXiihCxXUsj0ObESH7(metadataItem))));
			case 3:
				NfXhG3hCmYycmFKinkcm(metadataItem);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				metadataItem = MetadataItemManager.Load(metadataItemId);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return;
			}
		}
	}

	public virtual MetadataItemDTO LoadMetadataItemByHeaderId(long headerId)
	{
		int num = 4;
		int num2 = num;
		IMetadataItemHeader metadataItemHeader = default(IMetadataItemHeader);
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = default(_003C_003Ec__DisplayClass23_0);
		IMetadataItem current = default(IMetadataItem);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			case 5:
			{
				IEntityManager<IMetadataItemHeader, long> metadataItemHeaderManager = MetadataItemHeaderManager;
				ParameterExpression parameterExpression = (ParameterExpression)Xjo0WJhCMsuApRQC8OGb(TPWnr7hCyEotu89XiG6O(typeof(IMetadataItemHeader).TypeHandle), nlotoFhCag9uM4ypVHdM(0x463A0F3C ^ 0x463AA388));
				metadataItemHeader = metadataItemHeaderManager.Find(Expression.Lambda<Func<IMetadataItemHeader, bool>>((Expression)IEIMaPhCrupPXoKFxhw4(egkcKAhC9DjCp7d87txW(parameterExpression, (MethodInfo)SyS0ZXhCJrlR7dCpBaN0((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), sAZ2rihClTYfTNFa7Pis(Expression.Constant(_003C_003Ec__DisplayClass23_, TPWnr7hCyEotu89XiG6O(typeof(_003C_003Ec__DisplayClass23_0).TypeHandle)), OgNgWLhCdgUR07CrJTIX((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
				num2 = 2;
				break;
			}
			default:
				return null;
			case 4:
				_003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
				num2 = 3;
				break;
			case 2:
				if (metadataItemHeader != null)
				{
					current = metadataItemHeader.Current;
					num2 = 6;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass23_.headerId = headerId;
				num2 = 5;
				break;
			case 6:
				if (current != null)
				{
					return Mapper.Map<IMetadataItem, MetadataItemDTO>(current);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual MetadataItemDTO GetPublishedMetadataByUid(Guid uid)
	{
		//Discarded unreachable code: IL_005e, IL_006d
		int num = 6;
		IMetadataItem metadataItem = default(IMetadataItem);
		IMetadataItem published = default(IMetadataItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (metadataItem != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 2:
					return null;
				case 6:
					break;
				default:
					if (metadataItem.Header != null)
					{
						num2 = 3;
						continue;
					}
					goto case 4;
				case 1:
					if (published != null)
					{
						return Mapper.Map<IMetadataItem, MetadataItemDTO>(published);
					}
					num2 = 2;
					continue;
				case 4:
					return null;
				case 3:
					published = metadataItem.Header.Published;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			metadataItem = MetadataItemManager.LoadOrNull(uid);
			num = 5;
		}
	}

	public virtual MetadataPublishResult Publish(string comment, params long[] headerIds)
	{
		return MetadataItemManager.Publish(comment, headerIds);
	}

	public virtual bool IsMetadataStarted(Guid metadataUid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = default(_003C_003Ec__DisplayClass26_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().Any(_003C_003Ec__DisplayClass26_._003CIsMetadataStarted_003Eb__0);
			case 2:
				_003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass26_.metadataUid = metadataUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual List<Guid> GetMetadataStarted()
	{
		return (from k in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList()
			select _003C_003Ec.BwN5LpCjyLAgi529vkdn(k)).ToList();
	}

	public virtual bool IsPublishedProperty(Guid metadataUid, Guid propertyUid)
	{
		//Discarded unreachable code: IL_0066
		int num = 2;
		EntityMetadata entityMetadata = default(EntityMetadata);
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = default(_003C_003Ec__DisplayClass28_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return false;
				default:
					return FindProperty(entityMetadata, propertyUid);
				case 2:
					_003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					if (entityMetadata != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 4:
					entityMetadata = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().OfType<EntityMetadata>()
						.FirstOrDefault(_003C_003Ec__DisplayClass28_._003CIsPublishedProperty_003Eb__0);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
					break;
				}
				break;
			}
			_003C_003Ec__DisplayClass28_.metadataUid = metadataUid;
			num = 4;
		}
	}

	public virtual bool IsDbReservedWord(string name)
	{
		return pb0MU5hC54D1edAWUiNB(AwPF8ZhCgDmvgX6ArS7j(Locator.GetServiceNotNull<ITransformationProvider>()), name);
	}

	public virtual List<Guid> GetRestartRequiredMetadataUids()
	{
		return MetadataItemManager.GetRestartRequiredMetadataUids();
	}

	[Obsolete("Not used", true)]
	public virtual ScriptModuleDTO GetModelScriptModule()
	{
		return null;
	}

	[Obsolete("Not used", true)]
	public virtual void SaveModelScriptModule(ScriptModuleDTO scriptModuleDto)
	{
	}

	[Obsolete("Not used", true)]
	public static ScriptModuleDTO CreateModelScriptModule()
	{
		ScriptModuleDTO scriptModuleDTO = new ScriptModuleDTO();
		i2KhuyhCjpkCuhNNpnYo(scriptModuleDTO, CONFIGURAION_MODEL_SCRIPTMODULE_UID);
		scriptModuleDTO.AssemblyName = (string)nlotoFhCag9uM4ypVHdM(0x6A81B9B4 ^ 0x6A817332);
		PLyw3GhCYRpHZ8JJugq7(scriptModuleDTO, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36041899));
		return scriptModuleDTO;
	}

	[Obsolete("Not used", true)]
	public virtual void AddModelScriptModuleReferences(IEnumerable<string> references)
	{
	}

	public virtual EntityInfo GetEntityInfo(Guid typeUid, string id)
	{
		//Discarded unreachable code: IL_006d, IL_007c, IL_00d4, IL_00e3
		int num = 7;
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = default(_003C_003Ec__DisplayClass35_0);
		EntityInfo entityInfo = default(EntityInfo);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		ClassMetadata classMetadata = default(ClassMetadata);
		Guid propertyValue = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					_003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
					num2 = 6;
					continue;
				case 15:
					return null;
				case 6:
					_003C_003Ec__DisplayClass35_.id = id;
					num2 = 10;
					continue;
				case 4:
					ey4v3RhCLpn12cMI9m2O(Locator.GetServiceNotNull<ISecurityService>(), new Action(_003C_003Ec__DisplayClass35_._003CGetEntityInfo_003Eb__0));
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 18;
					}
					continue;
				case 3:
				case 16:
					return entityInfo;
				case 13:
					break;
				default:
					if (propertyMetadata == null)
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 9;
				case 2:
				case 14:
					propertyMetadata = (PropertyMetadata)JnEId5hCcNWNkWXpsE14(classMetadata);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (propertyValue != Guid.Empty)
					{
						num2 = 13;
						continue;
					}
					goto case 3;
				case 18:
					if (_003C_003Ec__DisplayClass35_.entity != null)
					{
						EntityInfo entityInfo2 = new EntityInfo();
						bwwodGhCUllyfKRV4cgh(entityInfo2, _003C_003Ec__DisplayClass35_.id);
						Rehj13hCsSZqtLu3tlg7(entityInfo2, typeUid);
						entityInfo = entityInfo2;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 15;
					}
					continue;
				case 17:
					entityInfo.Title = _003C_003Ec__DisplayClass35_.entity.ToString();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					propertyValue = _003C_003Ec__DisplayClass35_.entity.GetPropertyValue<Guid>(bEJc6JhCzgGUrK89Qhuc(propertyMetadata));
					num2 = 8;
					continue;
				case 11:
					_003C_003Ec__DisplayClass35_.entity = null;
					num2 = 4;
					continue;
				case 10:
					_003C_003Ec__DisplayClass35_.type = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(typeUid);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 5;
					}
					continue;
				case 12:
					if (!HasTitleProperty(classMetadata))
					{
						num2 = 14;
						continue;
					}
					goto case 17;
				case 5:
					_003C_003Ec__DisplayClass35_.manager = ModelHelper.GetEntityManager(_003C_003Ec__DisplayClass35_.type);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 8;
					}
					continue;
				case 1:
					classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(_003C_003Ec__DisplayClass35_.type);
					num2 = 12;
					continue;
				}
				break;
			}
			qg3TKLhvFFW9e5TCDGIs(entityInfo, propertyValue);
			num = 3;
		}
	}

	private bool FindProperty(EntityMetadata metadata, Guid propertyUid)
	{
		//Discarded unreachable code: IL_0060, IL_006f, IL_007a, IL_0106, IL_0115, IL_0138, IL_01a9, IL_01bc, IL_01f6, IL_0205
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = default(_003C_003Ec__DisplayClass36_0);
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		TablePartMetadata current = default(TablePartMetadata);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass36_.propertyUid = propertyUid;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 2;
				}
				continue;
			default:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
							{
								num3 = 0;
							}
							goto IL_007e;
						}
						goto IL_0120;
						IL_0120:
						current = enumerator.Current;
						num3 = 6;
						goto IL_007e;
						IL_007e:
						while (true)
						{
							switch (num3)
							{
							case 6:
								if (wh4veChvWPH0743NQHqP(DsQPF8hvBOM2nhdLZYe6(current), _003C_003Ec__DisplayClass36_.propertyUid))
								{
									num3 = 3;
									continue;
								}
								goto case 5;
							default:
								result = true;
								num3 = 8;
								continue;
							case 1:
								break;
							case 7:
								goto IL_0120;
							case 5:
								if (FindProperty(current, _003C_003Ec__DisplayClass36_.propertyUid))
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							case 3:
								result = true;
								num3 = 4;
								continue;
							case 2:
								goto end_IL_00db;
							case 4:
								return result;
							case 8:
								return result;
							}
							break;
						}
						continue;
						end_IL_00db:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
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
			case 5:
				if (!metadata.Properties.Any(_003C_003Ec__DisplayClass36_._003CFindProperty_003Eb__0))
				{
					num2 = 4;
					continue;
				}
				goto case 1;
			case 3:
				_003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
				num2 = 2;
				continue;
			case 1:
				return true;
			case 4:
				enumerator = metadata.TableParts.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				break;
			}
			break;
		}
		return false;
	}

	private bool HasTitleProperty(ClassMetadata metadata)
	{
		//Discarded unreachable code: IL_0088, IL_0097
		int num = 1;
		int num2 = num;
		ClassMetadata metadata2 = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 4:
				metadata2 = (ClassMetadata)Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadata(metadata.BaseClassUid);
				num2 = 3;
				break;
			default:
				return true;
			case 3:
				return HasTitleProperty(metadata2);
			case 2:
				return false;
			case 1:
				if (!jgPZGUhvomZPPs6HIocN(metadata.TitlePropertyUid, Guid.Empty))
				{
					if (!jgPZGUhvomZPPs6HIocN(d1vP9shvbxN5pYewdnaZ(metadata), Guid.Empty))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 4;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ModelManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JKJJGyhvhDrOHKtRUHR7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ModelManager()
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
				JKJJGyhvhDrOHKtRUHR7();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				CONFIGURAION_MODEL_SCRIPTMODULE_UID = new Guid((string)nlotoFhCag9uM4ypVHdM(0x53CB464B ^ 0x53C87E0B));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool Fxg5XBhCOhsVMGTDiPgt()
	{
		return xZq88GhCn4CfqIEblLvL == null;
	}

	internal static ModelManager Tmd1hShC2sa6bkKYRhlh()
	{
		return xZq88GhCn4CfqIEblLvL;
	}

	internal static object WXIgKthCeVI1GKl0qQMc(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).RestoreMetadata();
	}

	internal static object z29Q7OhCPMhcTkZc2Z5x(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).Name;
	}

	internal static void rIX5UghC1gMurgMR7LBR(object P_0, object P_1)
	{
		((AssemblyModelsMetadata)P_0).Name = (string)P_1;
	}

	internal static AssemblyModelsMetadataStatus YDTDOPhCNKkyOb6oqrYF(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).Status;
	}

	internal static void gWL4RXhC3LRUflZDuYo2(object P_0, AssemblyModelsMetadataStatus value)
	{
		((AssemblyModelsMetadata)P_0).Status = value;
	}

	internal static void Dj0QiWhCpUgyONZZhWjx(object P_0, object P_1)
	{
		((AssemblyModelsMetadata)P_0).SetMetadata((AbstractMetadata[])P_1);
	}

	internal static object nlotoFhCag9uM4ypVHdM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool bR6QxghCDX73BS9aKDet(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object loksNZhCtw23224L4VxD(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).AssemblyRawStream;
	}

	internal static void LpfIumhCwYgld9NaN8mQ(object P_0, object P_1)
	{
		((AssemblyModelsMetadata)P_0).AssemblyRawStream = (MemoryStream)P_1;
	}

	internal static object n9IFSBhC4iP1nGSDChy6(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).DocumentationRawStream;
	}

	internal static void BiMUHZhC6q21fxMhLES2(object P_0, object P_1)
	{
		((AssemblyModelsMetadata)P_0).DocumentationRawStream = (MemoryStream)P_1;
	}

	internal static object OMlEC3hCHUGxqWnYNHuk(object P_0)
	{
		return ClassSerializationHelper.SerializeObject(P_0);
	}

	internal static bool lk8RakhCATWuJt7rs9hF(object P_0)
	{
		return ((ElmaApiInitializerService)P_0).IsApiTreeInitialized();
	}

	internal static object EWgveOhC7oOLGBJV61oW(object P_0)
	{
		return ((ElmaApiInitializerService)P_0).GetZippedApiTree();
	}

	internal static object sHmXiihCxXUsj0ObESH7(object P_0)
	{
		return ((IMetadataItem)P_0).Header;
	}

	internal static object WtpvB1hC0jWG3hCfHZaf(object P_0)
	{
		return ((IMetadataItemHeader)P_0).DisplayName;
	}

	internal static void NfXhG3hCmYycmFKinkcm(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static Type TPWnr7hCyEotu89XiG6O(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Xjo0WJhCMsuApRQC8OGb(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object SyS0ZXhCJrlR7dCpBaN0(RuntimeMethodHandle P_0, RuntimeTypeHandle P_1)
	{
		return MethodBase.GetMethodFromHandle(P_0, P_1);
	}

	internal static object egkcKAhC9DjCp7d87txW(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object OgNgWLhCdgUR07CrJTIX(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object sAZ2rihClTYfTNFa7Pis(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object IEIMaPhCrupPXoKFxhw4(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object AwPF8ZhCgDmvgX6ArS7j(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static bool pb0MU5hC54D1edAWUiNB(object P_0, object P_1)
	{
		return ((Dialect)P_0).IsReservedWord((string)P_1);
	}

	internal static void i2KhuyhCjpkCuhNNpnYo(object P_0, Guid value)
	{
		((ScriptModuleDTO)P_0).Uid = value;
	}

	internal static void PLyw3GhCYRpHZ8JJugq7(object P_0, object P_1)
	{
		((ScriptModuleDTO)P_0).ModuleName = (string)P_1;
	}

	internal static void ey4v3RhCLpn12cMI9m2O(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegies((Action)P_1);
	}

	internal static void bwwodGhCUllyfKRV4cgh(object P_0, object P_1)
	{
		((EntityInfo)P_0).Id = (string)P_1;
	}

	internal static void Rehj13hCsSZqtLu3tlg7(object P_0, Guid value)
	{
		((EntityInfo)P_0).TypeUid = value;
	}

	internal static object JnEId5hCcNWNkWXpsE14(object P_0)
	{
		return ((ClassMetadata)P_0).GetUidProperty();
	}

	internal static Guid bEJc6JhCzgGUrK89Qhuc(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void qg3TKLhvFFW9e5TCDGIs(object P_0, Guid value)
	{
		((EntityInfo)P_0).Uid = value;
	}

	internal static Guid DsQPF8hvBOM2nhdLZYe6(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartPropertyUid;
	}

	internal static bool wh4veChvWPH0743NQHqP(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool jgPZGUhvomZPPs6HIocN(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid d1vP9shvbxN5pYewdnaZ(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static void JKJJGyhvhDrOHKtRUHR7()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
