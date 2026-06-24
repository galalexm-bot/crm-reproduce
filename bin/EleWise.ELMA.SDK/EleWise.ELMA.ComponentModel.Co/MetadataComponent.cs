using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Events;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ComponentModel.Components;

internal class MetadataComponent : MemoryMetadataComponent
{
	private sealed class MetadataPublishFinishedEventHandler : IMetadataPublishFinishedEventHandler, IEventHandler
	{
		private readonly object metadataComponent;

		private static object taxwnX85fnV6XHbOR0bn;

		public MetadataPublishFinishedEventHandler(MetadataComponent metadataComponent)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
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
				this.metadataComponent = metadataComponent;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num = 1;
				}
			}
		}

		public void PublishExecuted(MetadataPublishedEventArgs e)
		{
			//Discarded unreachable code: IL_006d, IL_007e, IL_008d, IL_0098, IL_0162, IL_01a2, IL_01b1, IL_01bd, IL_020b, IL_0274, IL_032a
			int num = 11;
			IEnumerator<string> enumerator = default(IEnumerator<string>);
			string current = default(string);
			AbstractMetadata[] array2 = default(AbstractMetadata[]);
			AbstractMetadata[] array = default(AbstractMetadata[]);
			int num3 = default(int);
			AbstractMetadata abstractMetadata = default(AbstractMetadata);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 15:
						return;
					case 14:
						return;
					case 18:
						try
						{
							while (true)
							{
								IL_00d9:
								int num4;
								if (!Vla2lS85Iuvl8GpLBjNn(enumerator))
								{
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
									{
										num4 = 3;
									}
									goto IL_009c;
								}
								goto IL_00b6;
								IL_00b6:
								current = enumerator.Current;
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
								{
									num4 = 2;
								}
								goto IL_009c;
								IL_009c:
								while (true)
								{
									switch (num4)
									{
									case 1:
										break;
									default:
										goto IL_00d9;
									case 2:
										B1x1gb85uIQuP7VFBCpr(metadataComponent, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576148086), current);
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
										{
											num4 = 0;
										}
										continue;
									case 3:
										goto end_IL_00d9;
									}
									break;
								}
								goto IL_00b6;
								continue;
								end_IL_00d9:
								break;
							}
						}
						finally
						{
							int num5;
							if (enumerator == null)
							{
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
								{
									num5 = 1;
								}
								goto IL_0166;
							}
							goto IL_017c;
							IL_017c:
							qH2fVy85VY4yik6wInOv(enumerator);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
							{
								num5 = 0;
							}
							goto IL_0166;
							IL_0166:
							switch (num5)
							{
							default:
								goto end_IL_0141;
							case 2:
								break;
							case 1:
								goto end_IL_0141;
							case 0:
								goto end_IL_0141;
							}
							goto IL_017c;
							end_IL_0141:;
						}
						goto default;
					case 6:
						array2 = array;
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 2;
						}
						continue;
					case 2:
						if (array == null)
						{
							num2 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
							{
								num2 = 15;
							}
							continue;
						}
						goto case 6;
					case 5:
						num3++;
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num2 = 8;
						}
						continue;
					case 16:
						if (NRNNFD858qivhU58S2d3(metadataComponent, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107980240)))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 8;
					case 8:
						O4o9wa85ZGWREqj3cKDU(metadataComponent, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108655586));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 1;
						}
						continue;
					case 13:
						break;
					case 12:
					case 17:
						if (num3 >= array2.Length)
						{
							return;
						}
						num2 = 4;
						continue;
					default:
						array = (AbstractMetadata[])FNWCIC85icnHIsPHJW6q(CtlDyQ85SqTXKX0GCnsj(XjhiJ885vRInsuVcGnX8(e)));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 2;
						}
						continue;
					case 4:
					case 9:
						abstractMetadata = array2[num3];
						num2 = 13;
						continue;
					case 3:
						num3 = 0;
						num2 = 12;
						continue;
					case 11:
					{
						object obj2 = XjhiJ885vRInsuVcGnX8(e);
						if (obj2 == null)
						{
							num2 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
							{
								num2 = 10;
							}
							continue;
						}
						obj = ((MetadataAssemblyPublishResult)obj2).DynamicAssembly;
						goto IL_0389;
					}
					case 10:
						obj = null;
						goto IL_0389;
					case 1:
						{
							enumerator = ((AbstractMetadataEditorComponent)metadataComponent).ProjectNames.Where((string n) => n != z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A67C31)).GetEnumerator();
							num2 = 18;
							continue;
						}
						IL_0389:
						if (obj == null)
						{
							return;
						}
						num2 = 16;
						continue;
					}
					break;
				}
				udeZoM85qMHRORHfDl3h(metadataComponent, qTaboq85RUayxNsPSkfS(0x53CACA3 ^ 0x53CA68D), abstractMetadata);
				num = 5;
			}
		}

		internal static bool hYCOMi85QP3t2s5H5oaC()
		{
			return taxwnX85fnV6XHbOR0bn == null;
		}

		internal static MetadataPublishFinishedEventHandler Us7BuE85CjPke8H9E19A()
		{
			return (MetadataPublishFinishedEventHandler)taxwnX85fnV6XHbOR0bn;
		}

		internal static object XjhiJ885vRInsuVcGnX8(object P_0)
		{
			return ((MetadataPublishedEventArgs)P_0).PublishResult;
		}

		internal static bool NRNNFD858qivhU58S2d3(object P_0, object P_1)
		{
			return ((AbstractMetadataEditorComponent)P_0).ProjectExists((string)P_1);
		}

		internal static void O4o9wa85ZGWREqj3cKDU(object P_0, object P_1)
		{
			((AbstractMetadataEditorComponent)P_0).AddProject((string)P_1);
		}

		internal static void B1x1gb85uIQuP7VFBCpr(object P_0, object P_1, object P_2)
		{
			((AbstractMetadataEditorComponent)P_0).AddProjectReference((string)P_1, (string)P_2);
		}

		internal static bool Vla2lS85Iuvl8GpLBjNn(object P_0)
		{
			return ((IEnumerator)P_0).MoveNext();
		}

		internal static void qH2fVy85VY4yik6wInOv(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static object CtlDyQ85SqTXKX0GCnsj(object P_0)
		{
			return ((MetadataAssemblyPublishResult)P_0).DynamicAssembly;
		}

		internal static object FNWCIC85icnHIsPHJW6q(object P_0)
		{
			return ((AssemblyModelsMetadata)P_0).RestoreMetadata();
		}

		internal static object qTaboq85RUayxNsPSkfS(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void udeZoM85qMHRORHfDl3h(object P_0, object P_1, object P_2)
		{
			((AbstractMetadataEditorComponent)P_0).AddOrReplaceMetadata((string)P_1, (IMetadata)P_2);
		}
	}

	private readonly IMetadataRuntimeService metadataRuntimeService;

	private readonly MetadataItemManager metadataItemManager;

	private readonly MetadataItemHeaderManager metadataItemHeaderManager;

	private readonly IComplexCacheService complexCacheService;

	private static MetadataComponent qbKlHYfu8WyGViFm3r8g;

	public override string ProjectName { get; }

	private IDictionary<Guid, IMetadata> DraftItems => complexCacheService.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92A2FFB), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x768E936), () => (from i in metadataItemManager.FindDraftItems()
		select i.Metadata).OfType<IMetadata>().ToDictionary((IMetadata m) => _003C_003Ec.Ud8REm85pHbW3G04d8cq(m)));

	public MetadataComponent(string modelAssemblyName, IMetadataRuntimeService metadataRuntimeService, MetadataItemManager metadataItemManager, MetadataItemHeaderManager metadataItemHeaderManager, IComplexCacheService complexCacheService, IEventHandlerSubscribeService eventHandlerSubscribeService)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		nphwH6fuIZAY8Zo8MUst();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 6:
				this.metadataRuntimeService = metadataRuntimeService;
				num = 5;
				break;
			case 7:
				this.metadataItemManager = metadataItemManager;
				num = 2;
				break;
			case 2:
				this.metadataItemHeaderManager = metadataItemHeaderManager;
				num = 6;
				break;
			case 3:
				owGQmQfuSOp0PpJVxeqT(modelAssemblyName, VbluF0fuVc0viuRjfEIQ(0x1637C429 ^ 0x163653C7));
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num = 4;
				}
				break;
			case 4:
				ProjectName = modelAssemblyName;
				num = 7;
				break;
			case 5:
				this.complexCacheService = complexCacheService;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				eventHandlerSubscribeService.Subscribe(new MetadataPublishFinishedEventHandler(this));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void SaveMetadata(IEnumerable<IMetadata> metadataList)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		if (metadataList == null)
		{
			return;
		}
		CS_0024_003C_003E8__locals0.currentItems = metadataItemHeaderManager.FindByIdArray(metadataList.Select((IMetadata m) => m.Uid).ToArray()).ToDictionary((IMetadataItemHeader h) => _003C_003Ec.tMYSMP85NvXgkiQSrDnb(h), (IMetadataItemHeader h) => (IMetadataItem)_003C_003Ec.jZKRh8853oo0btqeUbe2(h));
		IMetadataItem[] metadataItems = metadataList.Select(delegate(IMetadata m)
		{
			int num = 1;
			int num2 = num;
			IMetadataItem value = default(IMetadataItem);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return value;
				default:
				{
					InstanceOf<IMetadataItem> instanceOf = new InstanceOf<IMetadataItem>();
					_003C_003Ec__DisplayClass4_0.eNf0Mw85nTXgMsqV325d(instanceOf.New, m.Uid);
					value = instanceOf.New;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 2;
					}
					continue;
				}
				case 1:
					if (!CS_0024_003C_003E8__locals0.currentItems.TryGetValue(m.Uid, out value))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					break;
				}
				_003C_003Ec__DisplayClass4_0.RMMxC285OKHcQtdWmWo8(value, m);
				num2 = 3;
			}
		}).ToArray();
		metadataItemManager.Save(metadataItems);
		ClearCacheDraftItems();
		base.SaveMetadata(metadataList);
	}

	public override void PublishMetadata(IEnumerable<IMetadata> metadataList, string comment)
	{
		if (metadataList != null && metadataList.Any())
		{
			ValidateMetadataItem(metadataList);
			long[] headerIds = (from h in metadataItemHeaderManager.FindByIdArray(metadataList.Select((IMetadata m) => _003C_003Ec.Ud8REm85pHbW3G04d8cq(m)).ToArray())
				select h.Id).ToArray();
			metadataItemManager.Publish(comment, headerIds);
		}
	}

	public override MetadataItemDTO GetMetadataItemDTO(IMetadata metadata)
	{
		throw new NotImplementedException();
	}

	public override IEnumerable<MetadataItemDTO> GetMetadataItemDTOList()
	{
		throw new NotImplementedException();
	}

	public override IMetadata GetMetadata(string projectName, Guid metadataUid)
	{
		//Discarded unreachable code: IL_0085, IL_0094
		int num = 1;
		int num2 = num;
		IMetadata value = default(IMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				if (!DraftItems.TryGetValue(metadataUid, out value))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 2:
				return value;
			case 3:
				return base.GetMetadata(projectName, metadataUid);
			case 1:
				if (W4nVFffuiNeYAe0BSI4d(projectName, ProjectName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public override IEnumerable<IMetadata> GetMetadataList(string projectName, bool inherited)
	{
		if (projectName == ProjectName && !inherited)
		{
			return DraftItems.Values;
		}
		return base.GetMetadataList(projectName, inherited);
	}

	protected override void LoadProject()
	{
		//Discarded unreachable code: IL_00d8, IL_00e7, IL_00f2, IL_01fd, IL_020c, IL_023d, IL_0272, IL_02ee, IL_02fd, IL_0386, IL_03a5, IL_03b4, IL_03e1, IL_0549, IL_0559, IL_0568, IL_0626, IL_0666, IL_0675, IL_0681, IL_0690
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		NamespaceMetadata namespaceMetadata = default(NamespaceMetadata);
		IEnumerator<AssemblyModelsMetadata> enumerator2 = default(IEnumerator<AssemblyModelsMetadata>);
		AssemblyModelsMetadata current = default(AssemblyModelsMetadata);
		AbstractMetadata abstractMetadata = default(AbstractMetadata);
		int num4 = default(int);
		AbstractMetadata[] array2 = default(AbstractMetadata[]);
		AbstractMetadata[] array = default(AbstractMetadata[]);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current2 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (flag)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 9;
			case 6:
			case 17:
				RidwaDfuNdo2f9fuYh0C(this, So5RY7fuRJwoQRaIsMiB(this));
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 9;
				}
				break;
			case 2:
				X03Jh0fueb041JgoDhcH(namespaceMetadata, VbluF0fuVc0viuRjfEIQ(0x8317432 ^ 0x8314A5E));
				num2 = 4;
				break;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!euhkaZfunRuUJ2wT1pll(enumerator2))
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
							{
								num3 = 1;
							}
							goto IL_00f6;
						}
						goto IL_0340;
						IL_0340:
						current = enumerator2.Current;
						num3 = 19;
						goto IL_00f6;
						IL_00f6:
						while (true)
						{
							switch (num3)
							{
							case 5:
								jK1u4OfukB2dZ3YpuqEr(this, UC2j1afuKMZ9fiXPgeEx(current), abstractMetadata);
								num3 = 16;
								continue;
							case 3:
								num4 = 0;
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
								{
									num3 = 4;
								}
								continue;
							case 9:
								dfJtMKfuqmasOQkBfB2t(this, UC2j1afuKMZ9fiXPgeEx(current));
								num3 = 8;
								continue;
							case 10:
							case 18:
								T4YhtgfuXA1OKMEpUjdO(this, So5RY7fuRJwoQRaIsMiB(this), UC2j1afuKMZ9fiXPgeEx(current));
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
								{
									num3 = 7;
								}
								continue;
							case 16:
								num4++;
								num3 = 13;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
								{
									num3 = 6;
								}
								continue;
							case 17:
								array2 = array;
								num3 = 3;
								continue;
							case 11:
								if (array != null)
								{
									num3 = 17;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
									{
										num3 = 15;
									}
									continue;
								}
								break;
							case 6:
							case 15:
								break;
							case 8:
								if (!W4nVFffuiNeYAe0BSI4d(current.Name, VbluF0fuVc0viuRjfEIQ(-867826612 ^ -867824030)))
								{
									num3 = 18;
									continue;
								}
								goto case 14;
							case 19:
								if (W4nVFffuiNeYAe0BSI4d(UC2j1afuKMZ9fiXPgeEx(current), So5RY7fuRJwoQRaIsMiB(this)))
								{
									num3 = 15;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
									{
										num3 = 15;
									}
									continue;
								}
								goto case 9;
							case 2:
								abstractMetadata = array2[num4];
								num3 = 5;
								continue;
							case 4:
							case 13:
								if (num4 >= array2.Length)
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
									{
										num3 = 6;
									}
									continue;
								}
								goto case 2;
							default:
								array = (AbstractMetadata[])K3WJUjfuT2Wh0B27wUjl(current);
								num3 = 11;
								continue;
							case 12:
								goto IL_0340;
							case 14:
								flag = true;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								goto end_IL_0247;
							}
							break;
						}
						continue;
						end_IL_0247:
						break;
					}
				}
				finally
				{
					int num5;
					if (enumerator2 == null)
					{
						num5 = 2;
						goto IL_038a;
					}
					goto IL_03bf;
					IL_038a:
					switch (num5)
					{
					case 2:
						goto end_IL_0375;
					case 1:
						goto end_IL_0375;
					}
					goto IL_03bf;
					IL_03bf:
					jHKKuJfuOK9pGJQApawE(enumerator2);
					num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num5 = 0;
					}
					goto IL_038a;
					end_IL_0375:;
				}
				goto case 7;
			case 14:
				return;
			case 13:
				OOARYQfu1q9oOXix92AF(namespaceMetadata, true);
				num2 = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 7;
				}
				break;
			case 8:
				aRHHqYfu2jNjnW0QLOJw(namespaceMetadata, So5RY7fuRJwoQRaIsMiB(this));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				dfJtMKfuqmasOQkBfB2t(this, So5RY7fuRJwoQRaIsMiB(this));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 15:
				namespaceMetadata = new NamespaceMetadata();
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 9;
				}
				break;
			case 10:
				namespaceMetadata.InitNew();
				num2 = 8;
				break;
			case 4:
				namespaceMetadata.DisplayName = (string)u0ZZWOfuPAs1kUCBiaSd(VbluF0fuVc0viuRjfEIQ(-3333094 ^ -3663608));
				num2 = 13;
				break;
			case 16:
				SaveMetadata(namespaceMetadata);
				num2 = 6;
				break;
			default:
				flag = false;
				num2 = 11;
				break;
			case 11:
				enumerator2 = metadataRuntimeService.GetAssemblyModelsMetadataList().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 3;
				}
				break;
			case 9:
				if (!DraftItems.Values.OfType<NamespaceMetadata>().All((NamespaceMetadata i) => UQwBbkfuprLrxIV6in1n(DvKyQkfuD57tn9mUZGW4(i), So5RY7fuRJwoQRaIsMiB(this))))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 17;
					}
					break;
				}
				goto case 15;
			case 12:
				try
				{
					while (true)
					{
						IL_05da:
						int num6;
						if (!euhkaZfunRuUJ2wT1pll(enumerator))
						{
							num6 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
							{
								num6 = 0;
							}
							goto IL_0577;
						}
						goto IL_05c3;
						IL_05c3:
						current2 = enumerator.Current;
						int num7 = 3;
						num6 = num7;
						goto IL_0577;
						IL_0577:
						while (true)
						{
							switch (num6)
							{
							case 3:
								T4YhtgfuXA1OKMEpUjdO(this, VbluF0fuVc0viuRjfEIQ(0x3CE17B75 ^ 0x3CE1715B), current2);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
								{
									num6 = 0;
								}
								continue;
							case 1:
								goto IL_05da;
							case 2:
								goto end_IL_05da;
							}
							break;
						}
						goto IL_05c3;
						continue;
						end_IL_05da:
						break;
					}
				}
				finally
				{
					int num8;
					if (enumerator == null)
					{
						num8 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num8 = 1;
						}
						goto IL_062a;
					}
					goto IL_0640;
					IL_0640:
					enumerator.Dispose();
					num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num8 = 0;
					}
					goto IL_062a;
					IL_062a:
					switch (num8)
					{
					default:
						goto end_IL_0605;
					case 2:
						break;
					case 1:
						goto end_IL_0605;
					case 0:
						goto end_IL_0605;
					}
					goto IL_0640;
					end_IL_0605:;
				}
				goto case 9;
			case 5:
				enumerator = base.ProjectNames.Where((string n) => _003C_003Ec.R2e94385D5V0WSmyrq6G(n, _003C_003Ec.uTWhlh85aslTPyAAQoVW(--1418440330 ^ 0x548BA4A4))).GetEnumerator();
				num2 = 12;
				break;
			}
		}
	}

	protected override void AddOrReplaceMetadata(string projectName, IMetadata metadata)
	{
		//Discarded unreachable code: IL_00ac
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				base.AddOrReplaceMetadata(projectName, metadata);
				num2 = 3;
				break;
			case 0:
				return;
			case 1:
				lastMetadataUpdate = Yujoevfu3CZPuDhGQtkZ();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (!(projectName != (string)So5RY7fuRJwoQRaIsMiB(this)))
				{
					num2 = 4;
					break;
				}
				goto case 2;
			case 3:
			case 4:
				ClearCacheDraftItems();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override void RemoveMetadata(string projectName, IMetadata metadata)
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				ClearCacheDraftItems();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			case 1:
				lastMetadataUpdate = DateTime.Now;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (UQwBbkfuprLrxIV6in1n(projectName, So5RY7fuRJwoQRaIsMiB(this)))
				{
					num2 = 3;
					break;
				}
				goto default;
			case 3:
				base.RemoveMetadata(projectName, metadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void ValidateMetadataItem(IEnumerable<IMetadata> metadataList)
	{
		foreach (IEntityMetadata item in metadataList.OfType<IEntityMetadata>())
		{
			IEnumerable<IPropertyMetadata> propertiesAndTableParts = item.GetPropertiesAndTableParts();
			List<MetadataItemValidationError> list = new List<MetadataItemValidationError>();
			foreach (IValidatableMetadata item2 in propertiesAndTableParts.OfType<IValidatableMetadata>())
			{
				MetadataItemValidationError[] array = item2.Validate();
				if (array != null && array.Length != 0)
				{
					list.AddSequense(array);
				}
			}
			if (list.Count <= 0)
			{
				continue;
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C97C1D2)));
			string value = ((item is NamedMetadata namedMetadata) ? namedMetadata.DisplayName : (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218540776) + item.Uid));
			stringBuilder.Append(value);
			if (list.Count == 1)
			{
				stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA594215));
				stringBuilder.AppendLine(list.ElementAt(0).Message);
			}
			else
			{
				stringBuilder.AppendLine(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42656341));
				foreach (MetadataItemValidationError item3 in list)
				{
					stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87351979));
					stringBuilder.AppendLine(item3.Message);
				}
			}
			throw new MetadataPublishingException(stringBuilder.ToString())
			{
				ValidationErrors = list.ToArray()
			};
		}
	}

	private void ClearCacheDraftItems()
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
				MIEl0lfua4Yqnh1Ey7xW(complexCacheService, VbluF0fuVc0viuRjfEIQ(0x5F3078B6 ^ 0x5F35450E));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void nphwH6fuIZAY8Zo8MUst()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object VbluF0fuVc0viuRjfEIQ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void owGQmQfuSOp0PpJVxeqT(object P_0, object P_1)
	{
		Contract.NotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static bool l5rMT2fuZiPYYiDNKDZ6()
	{
		return qbKlHYfu8WyGViFm3r8g == null;
	}

	internal static MetadataComponent kevyPQfuuFvt3JDlJUS1()
	{
		return qbKlHYfu8WyGViFm3r8g;
	}

	internal static bool W4nVFffuiNeYAe0BSI4d(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object So5RY7fuRJwoQRaIsMiB(object P_0)
	{
		return ((AbstractMetadataEditorComponent)P_0).ProjectName;
	}

	internal static void dfJtMKfuqmasOQkBfB2t(object P_0, object P_1)
	{
		((AbstractMetadataEditorComponent)P_0).AddProject((string)P_1);
	}

	internal static object UC2j1afuKMZ9fiXPgeEx(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).Name;
	}

	internal static void T4YhtgfuXA1OKMEpUjdO(object P_0, object P_1, object P_2)
	{
		((AbstractMetadataEditorComponent)P_0).AddProjectReference((string)P_1, (string)P_2);
	}

	internal static object K3WJUjfuT2Wh0B27wUjl(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).RestoreMetadata();
	}

	internal static void jK1u4OfukB2dZ3YpuqEr(object P_0, object P_1, object P_2)
	{
		((AbstractMetadataEditorComponent)P_0).AddOrReplaceMetadata((string)P_1, (IMetadata)P_2);
	}

	internal static bool euhkaZfunRuUJ2wT1pll(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void jHKKuJfuOK9pGJQApawE(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void aRHHqYfu2jNjnW0QLOJw(object P_0, object P_1)
	{
		((NamespaceMetadata)P_0).Namespace = (string)P_1;
	}

	internal static void X03Jh0fueb041JgoDhcH(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static object u0ZZWOfuPAs1kUCBiaSd(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void OOARYQfu1q9oOXix92AF(object P_0, bool value)
	{
		((NamespaceMetadata)P_0).AllowCreateModels = value;
	}

	internal static void RidwaDfuNdo2f9fuYh0C(object P_0, object P_1)
	{
		((AbstractMetadataEditorComponent)P_0).CurrentProjectName = (string)P_1;
	}

	internal static DateTime Yujoevfu3CZPuDhGQtkZ()
	{
		return DateTime.Now;
	}

	internal static bool UQwBbkfuprLrxIV6in1n(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void MIEl0lfua4Yqnh1Ey7xW(object P_0, object P_1)
	{
		((IComplexCacheService)P_0).RefreshTimestamp((string)P_1);
	}

	internal static object DvKyQkfuD57tn9mUZGW4(object P_0)
	{
		return ((NamespaceMetadata)P_0).Namespace;
	}
}
