using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Globalization.ExtensionPoints;
using EleWise.ELMA.Globalization.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Globalization.Components;

[Component(Order = 10)]
internal class EntityExportLocalizationFileExtension : IExportLocalizationFileExtensionPoint
{
	private readonly IMetadataEditorService metadataEditorService;

	internal static EntityExportLocalizationFileExtension USbnqQGQF5nAxn31Jghd;

	public Guid Uid => EntityLocalizationLoadCustomSettings.ExtensionUid;

	public string Header => Tabs[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EFB304)];

	public IDictionary<string, string> Tabs => new Dictionary<string, string>
	{
		{
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317559444),
			SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36045257))
		},
		{
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE11E9CF),
			SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A63BAFE))
		}
	};

	public EntityExportLocalizationFileExtension(IMetadataEditorService metadataEditorService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Yk46EyGQoxZkfTOlMod8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
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
			this.metadataEditorService = metadataEditorService;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
			{
				num = 1;
			}
		}
	}

	public IDictionary<string, IEnumerable<LocalizableData>> GetAllData()
	{
		return new Dictionary<string, IEnumerable<LocalizableData>>
		{
			{
				Tabs[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AE7364)],
				FillCatalogListGrid()
			},
			{
				Tabs[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A6E35E)],
				FillEnumListGrid()
			}
		};
	}

	public object GetSettingObj(IDictionary<string, string> settingsJsonData)
	{
		EntityGlobalizationSettings entityGlobalizationSettings = new EntityGlobalizationSettings();
		JsonSerializer jsonSerializer = new JsonSerializer();
		entityGlobalizationSettings.EntityUids = jsonSerializer.Deserialize<Guid[]>(settingsJsonData[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637D9627)]);
		entityGlobalizationSettings.EnumUids = jsonSerializer.Deserialize<Guid[]>(settingsJsonData[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A7457B7)]);
		return entityGlobalizationSettings;
	}

	private IEnumerable<LocalizableData> FillEnumListGrid()
	{
		return from m in metadataEditorService.GetMetadataList(inherited: true).OfType<EnumMetadata>()
			where _003C_003Ec.vcK00pv5p4WFrcbkobxW(m)
			select m into md
			select new LocalizableData(_003C_003Ec.g2xa7rv5aph5n06l4ysw(md), (string)_003C_003Ec.dxAVuOv5DhdifoBVsRx8(md)) into o
			orderby (string)_003C_003Ec.p075iCv5tLUXSJnobP1t(o)
			select o;
	}

	private IEnumerable<LocalizableData> FillCatalogListGrid()
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0.customObjMd = metadataEditorService.GetMetadataList(inherited: false).OfType<EntityMetadata>().Where(delegate(EntityMetadata m)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return _003C_003Ec.xBtC1ev546vX0cnyEH2L(m);
				case 1:
					if (_003C_003Ec.BaFqxvv5wb0ZuCPe1pUC(m) == EntityMetadataType.InterfaceImplementation)
					{
						return false;
					}
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num4 = 0;
					}
					break;
				}
			}
		})
			.ToList();
		return from md in metadataEditorService.GetMetadataList(inherited: true).OfType<EntityMetadata>().Where(delegate(EntityMetadata m)
			{
				//Discarded unreachable code: IL_008f, IL_0140
				int num = 8;
				int num2 = num;
				_003C_003Ec__DisplayClass11_1 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_1);
				while (true)
				{
					switch (num2)
					{
					case 9:
						if (_003C_003Ec__DisplayClass11_0.DPFVMbv50RQqmAU3waUr(_003C_003Ec__DisplayClass11_.m))
						{
							return false;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 0;
						}
						break;
					case 1:
					case 3:
						if (!_003C_003Ec__DisplayClass11_.m.ShowInDesigner)
						{
							num2 = 4;
							break;
						}
						goto case 6;
					case 6:
						if (_003C_003Ec__DisplayClass11_0.DPFVMbv50RQqmAU3waUr(_003C_003Ec__DisplayClass11_.m))
						{
							return true;
						}
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num2 = 9;
						}
						break;
					case 2:
						if (_003C_003Ec__DisplayClass11_.m.Type == EntityMetadataType.Interface)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
							{
								num2 = 1;
							}
							break;
						}
						goto case 4;
					default:
						return CS_0024_003C_003E8__locals0.customObjMd.Exists(_003C_003Ec__DisplayClass11_._003CFillCatalogListGrid_003Eb__4);
					case 4:
						return false;
					case 5:
						if (_003C_003Ec__DisplayClass11_0.qLvDcMv5xRtn39T8sQYQ(_003C_003Ec__DisplayClass11_.m) == EntityMetadataType.Entity)
						{
							num2 = 3;
							break;
						}
						goto case 2;
					case 8:
						_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_1();
						num2 = 7;
						break;
					case 7:
						_003C_003Ec__DisplayClass11_.m = m;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 5;
						}
						break;
					}
				}
			})
			select new LocalizableData(_003C_003Ec.g2xa7rv5aph5n06l4ysw(md), (string)_003C_003Ec.dxAVuOv5DhdifoBVsRx8(md)) into o
			orderby (string)_003C_003Ec.p075iCv5tLUXSJnobP1t(o)
			select o;
	}

	internal static void Yk46EyGQoxZkfTOlMod8()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool PdCY0QGQBSL0jbqnOZ1c()
	{
		return USbnqQGQF5nAxn31Jghd == null;
	}

	internal static EntityExportLocalizationFileExtension a2AKeWGQWjRbUqBGE1Ye()
	{
		return USbnqQGQF5nAxn31Jghd;
	}
}
