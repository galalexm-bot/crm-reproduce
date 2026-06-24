using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Services;

[Component]
internal class HierarchicalMetadataService : IHierarchicalMetadataService
{
	internal static HierarchicalMetadataService x38iZ0b8I5OCBCPwGrRk;

	public string ProcessingParentForForm(Guid propertyUid, Guid propertyTypeUid, Guid propertySubTypeUid, RelationType? relationType, EntityMetadata entityMd)
	{
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		CS_0024_003C_003E8__locals0.propertyTypeUid = propertyTypeUid;
		CS_0024_003C_003E8__locals0.propertySubTypeUid = propertySubTypeUid;
		if (entityMd == null || entityMd.Properties == null)
		{
			return null;
		}
		if (!CanBeParentForChild(CS_0024_003C_003E8__locals0.propertyUid, CS_0024_003C_003E8__locals0.propertyTypeUid, CS_0024_003C_003E8__locals0.propertySubTypeUid, relationType, entityMd).Any())
		{
			return null;
		}
		if (Locator.GetService<IMetadataEditorService>() == null)
		{
			return null;
		}
		MetadataLoader.GetPropertiesAndTableParts(entityMd).OfType<PropertyMetadata>().Where(delegate(PropertyMetadata pMd)
		{
			//Discarded unreachable code: IL_0049, IL_0058, IL_007e, IL_008d, IL_010c, IL_013f
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return _003C_003Ec__DisplayClass0_0.wFEfxdC28N9hb5NYRsoh(_003C_003Ec__DisplayClass0_0.NF3bchC2vtlf6XlyBkjM(pMd) as EntitySettings) == RelationType.OneToOne;
				case 2:
				case 5:
				case 7:
				case 9:
					return false;
				case 4:
					if (!(_003C_003Ec__DisplayClass0_0.DP1E50C2QnBlDgAHxD4y(pMd) != CS_0024_003C_003E8__locals0.propertyUid))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 8;
				case 3:
					if (_003C_003Ec__DisplayClass0_0.aKRSIYC2feds7cGTyRbC(pMd))
					{
						num2 = 2;
						break;
					}
					goto case 4;
				case 1:
					if (_003C_003Ec__DisplayClass0_0.NF3bchC2vtlf6XlyBkjM(pMd) is EntitySettings)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 6:
					if (!(pMd.SubTypeUid == CS_0024_003C_003E8__locals0.propertySubTypeUid))
					{
						num2 = 5;
						break;
					}
					goto case 1;
				case 8:
					if (!(_003C_003Ec__DisplayClass0_0.sl91NiC2CjP1rFta9hDu(pMd) == CS_0024_003C_003E8__locals0.propertyTypeUid))
					{
						num2 = 7;
						break;
					}
					goto case 6;
				}
			}
		})
			.ToList();
		return null;
	}

	public List<KeyValuePair<string, int>> ProcessingChildsForForm(Guid propertyUid, Guid propertyTypeUid, Guid propertySubTypeUid, RelationType? relationType, EntityMetadata entityMd)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		CS_0024_003C_003E8__locals0.propertyTypeUid = propertyTypeUid;
		CS_0024_003C_003E8__locals0.propertySubTypeUid = propertySubTypeUid;
		if (entityMd == null || entityMd.Properties == null)
		{
			return null;
		}
		if (!CanBeChild(CS_0024_003C_003E8__locals0.propertyTypeUid, CS_0024_003C_003E8__locals0.propertySubTypeUid, relationType))
		{
			return null;
		}
		if (Locator.GetService<IMetadataEditorService>() == null)
		{
			return null;
		}
		MetadataLoader.GetPropertiesAndTableParts(entityMd).OfType<PropertyMetadata>().Where(delegate(PropertyMetadata pMd)
		{
			//Discarded unreachable code: IL_0071, IL_00d5, IL_00e4
			int num = 7;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (_003C_003Ec__DisplayClass1_0.eLEkeYC2KPX9sTb5K4Ft(_003C_003Ec__DisplayClass1_0.CQJaweC2qUIFKUcQVs78(pMd), CS_0024_003C_003E8__locals0.propertyTypeUid))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 4:
					return _003C_003Ec__DisplayClass1_0.uY77XcC2TgnDTyBol92t(_003C_003Ec__DisplayClass1_0.UFPNR1C2XH5AopfFXbKj(pMd) as EntitySettings) == RelationType.OneToOne;
				case 2:
				case 5:
					return false;
				case 3:
					if (_003C_003Ec__DisplayClass1_0.UFPNR1C2XH5AopfFXbKj(pMd) is EntitySettings)
					{
						num2 = 4;
						break;
					}
					goto case 2;
				case 7:
					if (!_003C_003Ec__DisplayClass1_0.sg4xpvC2SF1jlcMcxNjk(pMd))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 2;
				default:
					if (!_003C_003Ec__DisplayClass1_0.eLEkeYC2KPX9sTb5K4Ft(pMd.SubTypeUid, CS_0024_003C_003E8__locals0.propertySubTypeUid))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 3;
				case 6:
					if (!_003C_003Ec__DisplayClass1_0.NE6et0C2RAqhXjHMartW(_003C_003Ec__DisplayClass1_0.pPJAjPC2iko8Xgmq9Cn6(pMd), CS_0024_003C_003E8__locals0.propertyUid))
					{
						num2 = 2;
						break;
					}
					goto case 1;
				}
			}
		})
			.ToList();
		return null;
	}

	public Dictionary<Guid, string> CanBeParentForChild(Guid propertyUid, Guid propertyTypeUid, Guid propertySubTypeUid, RelationType? relationType, ClassMetadata entityMd)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		CS_0024_003C_003E8__locals0.propertyTypeUid = propertyTypeUid;
		CS_0024_003C_003E8__locals0.propertySubTypeUid = propertySubTypeUid;
		CS_0024_003C_003E8__locals0.result = new Dictionary<Guid, string>();
		if (entityMd == null || entityMd.Properties == null)
		{
			return CS_0024_003C_003E8__locals0.result;
		}
		if (!CanBeChild(CS_0024_003C_003E8__locals0.propertyTypeUid, CS_0024_003C_003E8__locals0.propertySubTypeUid, relationType))
		{
			return CS_0024_003C_003E8__locals0.result;
		}
		if (Locator.GetService<IMetadataEditorService>() == null)
		{
			return CS_0024_003C_003E8__locals0.result;
		}
		List<PropertyMetadata> list = MetadataLoader.GetPropertiesAndTableParts(entityMd).OfType<PropertyMetadata>().Where(delegate(PropertyMetadata pMd)
		{
			//Discarded unreachable code: IL_0041, IL_0119, IL_0128
			int num3 = 2;
			while (true)
			{
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 5:
						if (_003C_003Ec__DisplayClass2_0.xatO73C2PvGZ7jnvrZMw(_003C_003Ec__DisplayClass2_0.KhXD4AC2eoycgE7MiqWn(pMd), CS_0024_003C_003E8__locals0.propertyUid))
						{
							num4 = 6;
							break;
						}
						goto case 1;
					case 7:
						if (_003C_003Ec__DisplayClass2_0.wBtll9C2NcjPWJofE92C(pMd.SubTypeUid, CS_0024_003C_003E8__locals0.propertySubTypeUid))
						{
							num4 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
							{
								num4 = 3;
							}
							break;
						}
						goto case 1;
					case 6:
						if (_003C_003Ec__DisplayClass2_0.wBtll9C2NcjPWJofE92C(_003C_003Ec__DisplayClass2_0.jDL4tHC21Tt6eqA0lJq6(pMd), CS_0024_003C_003E8__locals0.propertyTypeUid))
						{
							num4 = 7;
							break;
						}
						goto case 1;
					case 3:
						if (!(pMd.Settings is EntitySettings))
						{
							goto end_IL_0012;
						}
						goto default;
					default:
						return (pMd.Settings as EntitySettings).RelationType == RelationType.OneToOne;
					case 1:
					case 4:
						return false;
					case 2:
						if (_003C_003Ec__DisplayClass2_0.svXrUZC22Of2lbTTOwif(pMd))
						{
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num4 = 0;
							}
							break;
						}
						goto case 5;
					}
					continue;
					end_IL_0012:
					break;
				}
				num3 = 4;
			}
		})
			.ToList();
		if (list.Any())
		{
			list.ForEach(delegate(PropertyMetadata pMd)
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
						CS_0024_003C_003E8__locals0.result.Add(_003C_003Ec__DisplayClass2_0.KhXD4AC2eoycgE7MiqWn(pMd), pMd.DisplayName);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			});
		}
		return CS_0024_003C_003E8__locals0.result;
	}

	public Dictionary<Guid, string> CanBeParentForChild(PropertyMetadata propertyMetadata, ClassMetadata entityMd)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.propertyMetadata = propertyMetadata;
		CS_0024_003C_003E8__locals0.result = new Dictionary<Guid, string>();
		if (CS_0024_003C_003E8__locals0.propertyMetadata == null || CS_0024_003C_003E8__locals0.propertyMetadata.TypeUid != EntityDescriptor.UID)
		{
			return CS_0024_003C_003E8__locals0.result;
		}
		if (!(CS_0024_003C_003E8__locals0.propertyMetadata.Settings is EntitySettings))
		{
			return CS_0024_003C_003E8__locals0.result;
		}
		if (!CanBeChild(CS_0024_003C_003E8__locals0.propertyMetadata))
		{
			return CS_0024_003C_003E8__locals0.result;
		}
		List<PropertyMetadata> list = MetadataLoader.GetPropertiesAndTableParts(entityMd).OfType<PropertyMetadata>().Where(delegate(PropertyMetadata pMd)
		{
			//Discarded unreachable code: IL_0066, IL_0075, IL_009e, IL_00ad
			int num3 = 5;
			while (true)
			{
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						if (_003C_003Ec__DisplayClass3_0.D2WDh0C2HiiuwS3ESh6t(_003C_003Ec__DisplayClass3_0.gSjiNiC260u8Ne4Bgv0N(pMd), _003C_003Ec__DisplayClass3_0.gSjiNiC260u8Ne4Bgv0N(CS_0024_003C_003E8__locals0.propertyMetadata)))
						{
							num4 = 3;
							break;
						}
						goto case 1;
					case 5:
						if (!_003C_003Ec__DisplayClass3_0.XRn2WXC2tsEIJi9rMnq8(pMd))
						{
							goto end_IL_0012;
						}
						goto case 1;
					case 4:
						if (_003C_003Ec__DisplayClass3_0.KE3G9UC24dHo8h1UWnmG(_003C_003Ec__DisplayClass3_0.hHW59sC2w3g2XkcRFf8F(pMd), _003C_003Ec__DisplayClass3_0.hHW59sC2w3g2XkcRFf8F(CS_0024_003C_003E8__locals0.propertyMetadata)))
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
							{
								num4 = 0;
							}
							break;
						}
						goto case 1;
					case 7:
						return (_003C_003Ec__DisplayClass3_0.B4L7DBC27u3vrYkSSBoZ(pMd) as EntitySettings).RelationType == RelationType.OneToOne;
					case 1:
					case 6:
						return false;
					case 3:
						if (!_003C_003Ec__DisplayClass3_0.D2WDh0C2HiiuwS3ESh6t(_003C_003Ec__DisplayClass3_0.sugenEC2Ax6aP8lmDNYJ(pMd), _003C_003Ec__DisplayClass3_0.sugenEC2Ax6aP8lmDNYJ(CS_0024_003C_003E8__locals0.propertyMetadata)))
						{
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
							{
								num4 = 0;
							}
							break;
						}
						goto case 2;
					case 2:
						if (!(_003C_003Ec__DisplayClass3_0.B4L7DBC27u3vrYkSSBoZ(pMd) is EntitySettings))
						{
							num4 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
							{
								num4 = 6;
							}
							break;
						}
						goto case 7;
					}
					continue;
					end_IL_0012:
					break;
				}
				num3 = 4;
			}
		})
			.ToList();
		if (list.Any())
		{
			list.ForEach(delegate(PropertyMetadata pMd)
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
						CS_0024_003C_003E8__locals0.result.Add(_003C_003Ec__DisplayClass3_0.hHW59sC2w3g2XkcRFf8F(pMd), (string)_003C_003Ec__DisplayClass3_0.ViH36PC2xC1U3LZCoFWa(pMd));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			});
		}
		return CS_0024_003C_003E8__locals0.result;
	}

	public bool CanBeChild(Guid propertyTypeUid, Guid propertySubTypeUid, RelationType? relationType)
	{
		if (propertyTypeUid != EntityDescriptor.UID || !relationType.HasValue)
		{
			return false;
		}
		IMetadataEditorService service = Locator.GetService<IMetadataEditorService>();
		if (service == null)
		{
			return false;
		}
		EntityMetadata entityMetadata = (EntityMetadata)service.GetMetadata(propertySubTypeUid);
		if (entityMetadata != null && entityMetadata.Hierarchical && entityMetadata.HierarchyType == HierarchyType.Elements && (relationType == RelationType.OneToOne || relationType == RelationType.ManyToMany))
		{
			return true;
		}
		return false;
	}

	public bool CanBeChild(PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00ed, IL_0147, IL_0156
		int num = 1;
		EntitySettings entitySettings = default(EntitySettings);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (entitySettings.RelationType != 0)
					{
						num2 = 8;
						continue;
					}
					goto case 7;
				case 1:
					if (propertyMetadata != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 9;
				case 6:
					if (entityMetadata != null)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 2;
				case 4:
					if (S8xklbb8TA1Jiy1GiMif(entityMetadata) == HierarchyType.Elements)
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 11:
					if (!eA5TwEb8Xov7knZksyou(entityMetadata))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 4;
				case 7:
					return true;
				case 2:
					return false;
				case 8:
					if (entitySettings.RelationType == RelationType.ManyToMany)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 2;
				case 10:
					return false;
				case 12:
					entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(OW5n2lb8KH3vgVw45xnj(propertyMetadata));
					num2 = 6;
					continue;
				case 9:
					return false;
				case 5:
					if (entitySettings != null)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				}
				if (Sm83Mrb8RPQjEDN8OZlQ(K6UPaGb8iwZM5BSTl5GM(propertyMetadata), EntityDescriptor.UID))
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					entitySettings = imMtLAb8qv6OqcVA1msT(propertyMetadata) as EntitySettings;
					num2 = 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public Dictionary<long, string> GetAllHierarchicalEntities(IEntityMetadata metadata, long? parentId, int indent, int deep)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.metadata = metadata;
		if (!(CS_0024_003C_003E8__locals0.metadata is EntityMetadata entityMetadata))
		{
			throw new NullReferenceException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824473271));
		}
		if (deep > 30)
		{
			deep = 30;
		}
		if (indent > 30)
		{
			indent = 30;
		}
		if (deep < 0)
		{
			deep = 0;
		}
		if (indent < 0)
		{
			indent = 0;
		}
		if (indent == 0)
		{
			if (deep == 0)
			{
				deep = 30;
			}
		}
		else if (deep + indent > 30 || deep == 0)
		{
			deep = 30 - indent;
		}
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string tableName = entityMetadata.TableName;
		if (!serviceNotNull.TableExists(tableName))
		{
			throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7245B672), tableName));
		}
		string text = z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7FA224);
		if (!serviceNotNull.ColumnExists(tableName, text))
		{
			throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108738786), tableName, text));
		}
		string text2 = null;
		if (((ClassMetadata)CS_0024_003C_003E8__locals0.metadata).TitlePropertyUid != Guid.Empty)
		{
			PropertyMetadata propertyMetadata = ((ClassMetadata)CS_0024_003C_003E8__locals0.metadata).Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass6_0.vUSTuIC29uQYAlq4hrba(_003C_003Ec__DisplayClass6_0.b7Dy63C2JteElv8KgbOp(p), ((ClassMetadata)CS_0024_003C_003E8__locals0.metadata).TitlePropertyUid));
			if (propertyMetadata != null && propertyMetadata.Settings is SimpleTypeSettings simpleTypeSettings && !string.IsNullOrWhiteSpace(simpleTypeSettings.FieldName))
			{
				text2 = simpleTypeSettings.FieldName;
			}
		}
		string sqlHierarchicalChilds = serviceNotNull.GetSqlHierarchicalChilds(tableName, text, text2, parentId, indent, deep);
		Dictionary<long, string> dictionary = new Dictionary<long, string>();
		using IDataReader dataReader = serviceNotNull.ExecuteQuery(sqlHierarchicalChilds);
		while (dataReader.Read())
		{
			long num = Convert.ToInt64(dataReader[0]);
			if (num > 0 && !dictionary.ContainsKey(num))
			{
				string value = (string.IsNullOrWhiteSpace(text2) ? SR.Untitled : Convert.ToString(dataReader[1]));
				dictionary.Add(num, value);
			}
		}
		return dictionary;
	}

	private bool IsHierarchicalProperty(IPropertyMetadata pMd)
	{
		//Discarded unreachable code: IL_0135, IL_0144, IL_0154
		int num = 6;
		IMetadataEditorService service = default(IMetadataEditorService);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return true;
				case 7:
				case 9:
					return false;
				case 10:
					return false;
				case 5:
					if (!(pMd.TypeUid != EntityDescriptor.UID))
					{
						service = Locator.GetService<IMetadataEditorService>();
						num2 = 8;
					}
					else
					{
						num2 = 10;
					}
					break;
				case 3:
					if (entityMetadata == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num2 = 9;
						}
						break;
					}
					goto case 4;
				case 6:
					if (pMd != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 10;
				case 1:
					if (S8xklbb8TA1Jiy1GiMif(entityMetadata) == HierarchyType.Elements)
					{
						goto end_IL_0012;
					}
					goto case 7;
				case 8:
					if (service == null)
					{
						num2 = 7;
						break;
					}
					goto default;
				default:
					entityMetadata = service.GetMetadata(pMd.SubTypeUid) as EntityMetadata;
					num2 = 3;
					break;
				case 4:
					if (eA5TwEb8Xov7knZksyou(entityMetadata))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 7;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public HierarchicalMetadataService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tQsyfDb8kLw8jt0XTnWy();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid K6UPaGb8iwZM5BSTl5GM(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool Sm83Mrb8RPQjEDN8OZlQ(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object imMtLAb8qv6OqcVA1msT(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static Guid OW5n2lb8KH3vgVw45xnj(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static bool eA5TwEb8Xov7knZksyou(object P_0)
	{
		return ((EntityMetadata)P_0).Hierarchical;
	}

	internal static HierarchyType S8xklbb8TA1Jiy1GiMif(object P_0)
	{
		return ((EntityMetadata)P_0).HierarchyType;
	}

	internal static bool gQdjRhb8VPeaAfQfTDiv()
	{
		return x38iZ0b8I5OCBCPwGrRk == null;
	}

	internal static HierarchicalMetadataService g9YYDBb8Slj4DaK1TIRV()
	{
		return x38iZ0b8I5OCBCPwGrRk;
	}

	internal static void tQsyfDb8kLw8jt0XTnWy()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
