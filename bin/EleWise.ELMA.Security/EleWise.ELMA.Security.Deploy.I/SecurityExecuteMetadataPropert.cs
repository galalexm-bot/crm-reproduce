using System.Collections.Generic;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Deploy.Import;

internal class SecurityExecuteMetadataPropertyExtension : BaseExecuteMetadataPropertyExtension
{
	private OrganizationItemManager organizationItemManager;

	private UserGroupManager userGroupManager;

	private static SecurityExecuteMetadataPropertyExtension bDpsW93b5JkuQDDuYJB;

	public SecurityExecuteMetadataPropertyExtension(OrganizationItemManager organizationItemManager, UserGroupManager userGroupManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Tt7p303fL6fn16AgcKf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				this.userGroupManager = userGroupManager;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.organizationItemManager = organizationItemManager;
				num = 2;
				break;
			}
		}
	}

	public override void MetadataPropertyProcessing(IPropertyMetadata importedProperty, IPropertyMetadata baseProperty, ClassMetadata importedMetadata, ReadMetadataParameters parameters)
	{
		//Discarded unreachable code: IL_00f1, IL_0100
		int num = 7;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		_003C_003Ec__DisplayClass3_1 _003C_003Ec__DisplayClass3_3 = default(_003C_003Ec__DisplayClass3_1);
		EntityUserSettings entityUserSettings = default(EntityUserSettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					_003C_003Ec__DisplayClass3_.importedProperty = importedProperty;
					num2 = 5;
					continue;
				case 6:
					_003C_003Ec__DisplayClass3_.parameters = parameters;
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
					{
						num2 = 3;
					}
					continue;
				default:
					_003C_003Ec__DisplayClass3_3 = new _003C_003Ec__DisplayClass3_1();
					num2 = 11;
					continue;
				case 11:
					_003C_003Ec__DisplayClass3_3.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass3_;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					if (entityUserSettings != null)
					{
						num2 = 4;
						continue;
					}
					return;
				case 1:
					_003C_003Ec__DisplayClass3_3.workersForDel = new List<Worker>();
					num2 = 9;
					continue;
				case 13:
					return;
				case 5:
					break;
				case 7:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 6;
					continue;
				case 15:
					_003C_003Ec__DisplayClass3_.importedMetadata = importedMetadata;
					num2 = 8;
					continue;
				case 2:
					_003C_003Ec__DisplayClass3_3.workersForDel.ForEach(delegate(Worker worker)
					{
						int num3 = 2;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 1:
								_003C_003Ec__DisplayClass3_3.CS_0024_003C_003E8__locals1.entityUserSettings.Workers.Remove(worker);
								num4 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
								{
									num4 = 0;
								}
								break;
							case 0:
								return;
							case 2:
							{
								ReadMetadataParameters parameters2 = _003C_003Ec__DisplayClass3_3.CS_0024_003C_003E8__locals1.parameters;
								object t = _003C_003Ec__DisplayClass3_0.uBM5XWpCbjDG7Soq6Ol6(-163225536 ^ -163306894);
								object[] obj = new object[7]
								{
									_003C_003Ec__DisplayClass3_0.G79VXkpCSA0MocihR2EB(_003C_003Ec__DisplayClass3_3.CS_0024_003C_003E8__locals1.importedProperty),
									_003C_003Ec__DisplayClass3_0.X0pjH4pC9oSnNFMDJ1Kx(_003C_003Ec__DisplayClass3_3.CS_0024_003C_003E8__locals1.importedProperty),
									null,
									null,
									null,
									null,
									null
								};
								IPropertyMetadata baseProperty2 = _003C_003Ec__DisplayClass3_3.CS_0024_003C_003E8__locals1.baseProperty;
								obj[2] = ((baseProperty2 != null) ? _003C_003Ec__DisplayClass3_0.V4cqYKpCf5de9neroUYW(baseProperty2) : _003C_003Ec__DisplayClass3_0.V4cqYKpCf5de9neroUYW(_003C_003Ec__DisplayClass3_3.CS_0024_003C_003E8__locals1.importedProperty));
								obj[3] = _003C_003Ec__DisplayClass3_3.CS_0024_003C_003E8__locals1.importedMetadata.DisplayName;
								obj[4] = _003C_003Ec__DisplayClass3_0.McYpRepC1kJBK9riDnIN(_003C_003Ec__DisplayClass3_3.CS_0024_003C_003E8__locals1.importedMetadata);
								obj[5] = (_003C_003Ec__DisplayClass3_0.kFPa7lpUp7dqsWogFXa9(_003C_003Ec__DisplayClass3_0.vKqm3gpCzDVBoNTdvxbd(worker), _003C_003Ec__DisplayClass3_0.euRZf0pUkLhR8a7iBtiK()) ? SR.T((string)_003C_003Ec__DisplayClass3_0.uBM5XWpCbjDG7Soq6Ol6(-2119527672 ^ -2119537338)) : (_003C_003Ec__DisplayClass3_0.kFPa7lpUp7dqsWogFXa9(_003C_003Ec__DisplayClass3_0.vKqm3gpCzDVBoNTdvxbd(worker), _003C_003Ec__DisplayClass3_0.MN5V4SpU5Mtwm0dYby1V()) ? _003C_003Ec__DisplayClass3_0.AHh3fLpUAfNKub271fsI(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA4E904F ^ 0xA4F83B3)) : string.Empty));
								obj[6] = _003C_003Ec__DisplayClass3_0.Egavj0pUWDPlPy7reUcA(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x28EBA022 ^ 0x28EAE2D4), worker.WorkerId);
								_003C_003Ec__DisplayClass3_0.ntKEmnpUX4kQIXlb3FRx(parameters2, new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T((string)t, obj)));
								num4 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
								{
									num4 = 1;
								}
								break;
							}
							}
						}
					});
					num2 = 14;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
					{
						num2 = 11;
					}
					continue;
				case 14:
					return;
				case 3:
					_003C_003Ec__DisplayClass3_._003C_003E4__this = this;
					num2 = 12;
					continue;
				case 4:
					if (_003C_003Ec__DisplayClass3_.entityUserSettings.Workers == null)
					{
						num2 = 13;
						continue;
					}
					goto default;
				case 9:
					_003C_003Ec__DisplayClass3_3.CS_0024_003C_003E8__locals1.entityUserSettings.Workers.ForEach(_003C_003Ec__DisplayClass3_3._003CMetadataPropertyProcessing_003Eb__0);
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
				{
					_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_2 = _003C_003Ec__DisplayClass3_;
					IPropertyMetadata importedProperty2 = _003C_003Ec__DisplayClass3_.importedProperty;
					entityUserSettings = (_003C_003Ec__DisplayClass3_2.entityUserSettings = ((importedProperty2 != null) ? Oaauy431Y7MRsTlER7i(importedProperty2) : null) as EntityUserSettings);
					num2 = 10;
					continue;
				}
				}
				break;
			}
			_003C_003Ec__DisplayClass3_.baseProperty = baseProperty;
			num = 15;
		}
	}

	internal static void Tt7p303fL6fn16AgcKf()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool VVnqOe3ShfwNxxlJEAD()
	{
		return bDpsW93b5JkuQDDuYJB == null;
	}

	internal static SecurityExecuteMetadataPropertyExtension FMylm639tTudfsJAWYB()
	{
		return bDpsW93b5JkuQDDuYJB;
	}

	internal static object Oaauy431Y7MRsTlER7i(object P_0)
	{
		return ((IPropertyMetadata)P_0).Settings;
	}
}
