using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class EntityMetadataExtensions
{
	public static Guid PermissionMetadataUid;

	public const string PermissionPostfix = "Permission";

	private static EntityMetadataExtensions aPdmyFGaihaq59gUdX0B;

	public static bool CanUsePermissions(this EntityMetadata metadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (metadata != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return CWxtNGGaK0jJaKUJBKMI(metadata) != null;
			}
		}
	}

	public static string GetPermissionPropertyDefaultName(EntityMetadata metadata)
	{
		return (string)qbZm64GaXUTkYcM5nWke(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B355325), GetPermissionPropertyNameIndex(metadata));
	}

	public static EntityMetadata GetBaseMetadata(Guid uid)
	{
		return (((IMetadataService)l25tXfGaTPylBOyc2Jgy()).GetMetadata(uid, loadImplementation: false) as EntityMetadata).GetBaseMetadata();
	}

	public static EntityMetadata GetBaseMetadata(this EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_005f, IL_008f, IL_009e
		int num = 1;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (TicalFGanByw4cEl4BPT(ykTq8EGakJ3jXoEWD02m(entityMetadata), Guid.Empty))
				{
					num2 = 6;
					break;
				}
				goto case 3;
			default:
				if (entityMetadata == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 7;
			case 5:
			case 6:
				entityMetadata = ((IMetadataService)l25tXfGaTPylBOyc2Jgy()).GetMetadata(ykTq8EGakJ3jXoEWD02m(entityMetadata), loadImplementation: false) as EntityMetadata;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
			case 4:
				return entityMetadata;
			case 1:
				entityMetadata = metadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static bool IsActivePermissionMetadata(this EntityMetadata metadata)
	{
		int num = 2;
		int num2 = num;
		Guid tablePartPropertyUid = default(Guid);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return tablePartPropertyUid.Equals(PermissionMetadataUid);
			case 2:
				tablePartMetadata = metadata as TablePartMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (tablePartMetadata == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				tablePartPropertyUid = tablePartMetadata.TablePartPropertyUid;
				num2 = 3;
				break;
			}
		}
	}

	public static void DisablePermissionMetadata(this EntityMetadata metadata)
	{
		int num = 2;
		int num2 = num;
		TablePartMetadata activePermissionMetadata = default(TablePartMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				activePermissionMetadata = metadata.GetActivePermissionMetadata();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			case 1:
				if (activePermissionMetadata != null)
				{
					TIdY4VGa2upeefQd8CTO(activePermissionMetadata, CreateNewGuid());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public static void ActivatePermissionMetadata(this EntityMetadata metadata, string permissionPropertyName)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				_003C_003Ec__DisplayClass9_.permissionPropertyName = permissionPropertyName;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				fQuXspGaefOAB6OIbFYN(metadata, tablePartMetadata);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 3;
				}
				break;
			default:
				tablePartMetadata = metadata.GetBaseMetadata().TableParts.FirstOrDefault(_003C_003Ec__DisplayClass9_._003CActivatePermissionMetadata_003Eb__0);
				num2 = 4;
				break;
			}
		}
	}

	public static void ActivatePermissionMetadata(this EntityMetadata metadata, TablePartMetadata tablePartMetadata)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_00a4, IL_00b3
		int num = 4;
		TablePartMetadata tablePartMetadata2 = default(TablePartMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					return;
				case 3:
					throw new MetadataException((string)utqQVGGa1aionmu8mMKn(sWcV0vGaPP7QWEEEJnMr(0x53CB464B ^ 0x53C8BE0D)));
				case 4:
					if (tablePartMetadata != null)
					{
						tablePartMetadata2 = (TablePartMetadata)CWxtNGGaK0jJaKUJBKMI(metadata);
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto end_IL_0012;
				case 1:
					throw new MetadataException(SR.T((string)sWcV0vGaPP7QWEEEJnMr(0x1C9495B4 ^ 0x1C976D10), tablePartMetadata.Name, kjwNM2Ga3XClfRAXh0PW(metadata)));
				default:
					tablePartMetadata.TablePartPropertyUid = PermissionMetadataUid;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 4;
					}
					break;
				case 2:
					if (!TicalFGanByw4cEl4BPT(JGg29PGaNujtHyA7UwNq(tablePartMetadata2), JGg29PGaNujtHyA7UwNq(tablePartMetadata)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 6:
					if (tablePartMetadata2 == null)
					{
						num2 = 5;
						break;
					}
					goto case 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public static TablePartMetadata GetActivePermissionMetadata(this EntityMetadata metadata)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return GetActivePermissionMetadataFromMetadata(MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().FirstOrDefault(_003C_003Ec__DisplayClass11_._003CGetActivePermissionMetadata_003Eb__0));
			case 4:
				_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
				num2 = 3;
				break;
			case 3:
				_003C_003Ec__DisplayClass11_.baseMetadata = (EntityMetadata)fEEweXGapw1tmIhRWu1V(metadata);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				if (M4J3dAGaDZ6kFHo4El48(_003C_003Ec__DisplayClass11_.baseMetadata))
				{
					num2 = 2;
					break;
				}
				goto IL_005b;
			case 1:
				tablePartMetadata = (TablePartMetadata)mhrE1VGaaTtISPUkHvdo(_003C_003Ec__DisplayClass11_.baseMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				{
					if (tablePartMetadata == null)
					{
						num2 = 5;
						break;
					}
					goto IL_005b;
				}
				IL_005b:
				return tablePartMetadata;
			}
		}
	}

	internal static TablePartMetadata GetActivePermissionMetadataFromMetadata(EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_0087, IL_0096, IL_00a6, IL_00b5, IL_00f8, IL_0107
		int num = 5;
		IEnumerable<TablePartMetadata> enumerable = default(IEnumerable<TablePartMetadata>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (metadata != null)
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 3:
					if (enumerable.Any())
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 10;
						}
						break;
					}
					goto default;
				default:
					return null;
				case 10:
					if (enumerable.Count() == 1)
					{
						num2 = 8;
						break;
					}
					throw new MetadataException(SR.T((string)sWcV0vGaPP7QWEEEJnMr(-35995181 ^ -36095997), kjwNM2Ga3XClfRAXh0PW(metadata)));
				case 1:
					if (O5Cv0rGatKDII4Fjmjen(metadata.TableParts) == 0)
					{
						num2 = 2;
						break;
					}
					enumerable = metadata.TableParts.Where((TablePartMetadata p1) => p1.IsActivePermissionMetadata());
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 5;
					}
					break;
				case 9:
					if (enumerable == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 8:
					return enumerable.First();
				case 4:
					if (metadata.TableParts == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 1;
				case 2:
				case 6:
					return null;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public static void InitNewPermissionMetadata(this EntityMetadata metadata, TablePartMetadata permissionMetadata, string metadataName, string propertyName)
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
				metadata.InitNewPermissionMetadata(permissionMetadata, metadataName, propertyName, activate: true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void InitNewPermissionMetadata(this EntityMetadata metadata, TablePartMetadata permissionMetadata, string metadataName, string propertyName, bool activate)
	{
		//Discarded unreachable code: IL_0195, IL_01e1, IL_01f0
		int num = 7;
		EntityMetadata entityMetadata = default(EntityMetadata);
		string tableName = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				string text;
				switch (num2)
				{
				default:
					return;
				case 11:
					bSktZmGaxNBxnXtMsO8y(permissionMetadata, propertyName);
					num2 = 13;
					continue;
				case 8:
					QvJ93WGa0CSX5A4WuHbV(permissionMetadata, SR.T((string)sWcV0vGaPP7QWEEEJnMr(0x4EA5403C ^ 0x4EA6BAFC), entityMetadata.DisplayName));
					num2 = 16;
					continue;
				case 15:
					permissionMetadata.TableName = tableName;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 6;
					}
					continue;
				case 4:
					d5vr6NGaMRbv5om3SF8j(permissionMetadata, false);
					num2 = 3;
					continue;
				case 14:
					if (fk9okqGaHQteRgRNYKE6(kjwNM2Ga3XClfRAXh0PW(permissionMetadata)) > 28)
					{
						num2 = 12;
						continue;
					}
					text = permissionMetadata.Name;
					goto IL_0273;
				case 16:
					vtYX9kGamemEXFxuMhgj(permissionMetadata, false);
					num2 = 9;
					continue;
				case 10:
					IC4jfiGa7IFvWyBgduBv(permissionMetadata, FbI8imGaA55QnMChiv3L(entityMetadata));
					num = 11;
					break;
				case 13:
					permissionMetadata.DisplayName = SR.T((string)sWcV0vGaPP7QWEEEJnMr(-1123633026 ^ -1123728654), entityMetadata.DisplayName);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 15;
					}
					continue;
				case 7:
					entityMetadata = (EntityMetadata)fEEweXGapw1tmIhRWu1V(metadata);
					num = 6;
					break;
				case 12:
					text = ((string)kjwNM2Ga3XClfRAXh0PW(permissionMetadata)).Substring(0, 28);
					goto IL_0273;
				case 1:
					fQuXspGaefOAB6OIbFYN(metadata, permissionMetadata);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					n3FPdFGaypg5RmDucLWa(permissionMetadata, false);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 2;
					}
					continue;
				case 0:
					return;
				case 3:
					wBt7ZRGaJLJjfybb9S89(permissionMetadata, entityMetadata);
					num2 = 2;
					continue;
				case 5:
					return;
				case 2:
					if (!activate)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 6:
					{
						yZOytRGa6WqjcrOT0Xvs(permissionMetadata, (!BdHK2HGawxJXM0NsIGdR(metadataName)) ? metadataName : LARtMbGa4uymplrSA7ID(entityMetadata.Name, sWcV0vGaPP7QWEEEJnMr(-16752921 ^ -16538477)));
						num2 = 14;
						continue;
					}
					IL_0273:
					tableName = text;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 10;
					}
					continue;
				}
				break;
			}
		}
	}

	public static void AddPermissionInterfaces(this EntityMetadata permissionMetadata, EntityMetadata baseMetadata)
	{
		//Discarded unreachable code: IL_005a, IL_0064, IL_0088, IL_0097, IL_01d5, IL_01e4, IL_01f4, IL_0277, IL_02db, IL_02ea, IL_030b, IL_034b, IL_035a, IL_0366, IL_0375, IL_03ea, IL_041a, IL_0429, IL_0435, IL_0444
		int num = 1;
		int num2 = num;
		IEnumerator<IEntityPermissionsTypeExtensionPoint> enumerator = default(IEnumerator<IEntityPermissionsTypeExtensionPoint>);
		IEnumerator<PropertyMetadata> enumerator2 = default(IEnumerator<PropertyMetadata>);
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				enumerator = ((ComponentManager)m94rvVGa96TMyk7k4M3N()).GetExtensionPoints<IEntityPermissionsTypeExtensionPoint>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
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
					if (!enumerator.MoveNext())
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num3 = 0;
						}
						goto IL_0068;
					}
					goto IL_0380;
					IL_0380:
					enumerator2 = enumerator.Current.GetDefaultPermissionMetadataProperties(baseMetadata).GetEnumerator();
					num3 = 2;
					goto IL_0068;
					IL_0068:
					switch (num3)
					{
					default:
						return;
					case 0:
						return;
					case 2:
						try
						{
							while (true)
							{
								int num4;
								if (!HabaQGGarbRoAc9E01mZ(enumerator2))
								{
									num4 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
									{
										num4 = 9;
									}
									goto IL_00a6;
								}
								goto IL_01fe;
								IL_01fe:
								_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
								num4 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
								{
									num4 = 2;
								}
								goto IL_00a6;
								IL_00a6:
								while (true)
								{
									switch (num4)
									{
									case 1:
										if (!TicalFGanByw4cEl4BPT(n8PCR2GalgrBxbrDbH7s(propertyMetadata), n8PCR2GalgrBxbrDbH7s(_003C_003Ec__DisplayClass15_.defaultProperty)))
										{
											num4 = 10;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
											{
												num4 = 3;
											}
											continue;
										}
										goto default;
									case 2:
										throw new MetadataException(SR.T((string)sWcV0vGaPP7QWEEEJnMr(0x7EC153F ^ 0x7EFEE39), _003C_003Ec__DisplayClass15_.defaultProperty.Name, kjwNM2Ga3XClfRAXh0PW(classMetadata)));
									case 8:
									case 10:
										break;
									case 13:
									{
										PropertyMetadata propertyMetadata2 = permissionMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass15_._003CAddPermissionInterfaces_003Eb__0);
										propertyMetadata = permissionMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass15_._003CAddPermissionInterfaces_003Eb__1);
										if (propertyMetadata2 == null)
										{
											num4 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
											{
												num4 = 11;
											}
											continue;
										}
										break;
									}
									case 12:
										goto IL_01fe;
									case 3:
									case 7:
										if (TicalFGanByw4cEl4BPT(fg46OmGadeiKnaCIo3ee(propertyMetadata), _003C_003Ec__DisplayClass15_.defaultProperty.TypeUid))
										{
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
											{
												num4 = 0;
											}
											continue;
										}
										goto case 1;
									case 6:
										permissionMetadata.Properties.Add(_003C_003Ec__DisplayClass15_.defaultProperty);
										num4 = 8;
										continue;
									case 4:
										_003C_003Ec__DisplayClass15_.defaultProperty = enumerator2.Current;
										num4 = 13;
										continue;
									default:
									{
										classMetadata = ((IMetadataService)l25tXfGaTPylBOyc2Jgy()).GetMetadata(n8PCR2GalgrBxbrDbH7s(_003C_003Ec__DisplayClass15_.defaultProperty), loadImplementation: true) as ClassMetadata;
										int num5 = 2;
										num4 = num5;
										continue;
									}
									case 11:
										if (propertyMetadata != null)
										{
											num4 = 7;
											continue;
										}
										goto case 6;
									case 9:
										goto end_IL_0159;
									}
									break;
								}
								continue;
								end_IL_0159:
								break;
							}
						}
						finally
						{
							int num6;
							if (enumerator2 == null)
							{
								num6 = 2;
								goto IL_030f;
							}
							goto IL_0325;
							IL_030f:
							switch (num6)
							{
							case 2:
								goto end_IL_02fa;
							case 1:
								goto end_IL_02fa;
							}
							goto IL_0325;
							IL_0325:
							enumerator2.Dispose();
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
							{
								num6 = 1;
							}
							goto IL_030f;
							end_IL_02fa:;
						}
						continue;
					case 3:
						break;
					case 1:
						continue;
					}
					goto IL_0380;
				}
			}
			finally
			{
				int num7;
				if (enumerator == null)
				{
					num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num7 = 0;
					}
					goto IL_03ee;
				}
				goto IL_0404;
				IL_0404:
				enumerator.Dispose();
				num7 = 2;
				goto IL_03ee;
				IL_03ee:
				switch (num7)
				{
				default:
					goto end_IL_03c9;
				case 1:
					break;
				case 0:
					goto end_IL_03c9;
				case 2:
					goto end_IL_03c9;
				}
				goto IL_0404;
				end_IL_03c9:;
			}
		}
	}

	public static Guid GetImplementationUid(this IEntityMetadata metadata)
	{
		//Discarded unreachable code: IL_0062
		int num = 1;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				entityMetadata = metadata as EntityMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return entityMetadata.ImplementationUid;
			case 2:
				return QF503fGagqkTdQ7f4MUo(metadata);
			default:
				if (entityMetadata == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public static Guid GetBaseClassUid(this IEntityMetadata metadata)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 3;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (entityMetadata == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return ykTq8EGakJ3jXoEWD02m(entityMetadata);
			case 1:
				return Guid.Empty;
			case 3:
				entityMetadata = metadata as EntityMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private static int? GetPermissionPropertyNameIndex(object metadata)
	{
		int? num = null;
		foreach (PropertyMetadata property in ((ClassMetadata)metadata).Properties)
		{
			int result;
			if (property.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538632134))
			{
				if (!num.HasValue)
				{
					num = 1;
				}
			}
			else if (property.Name.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x63836DC7)) && int.TryParse(property.Name.Substring(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6DA227).Length), out result) && result > num)
			{
				num = result;
			}
		}
		return num;
	}

	public static bool IsSystem(this IMetadata metadata)
	{
		return qx5HCJGa5c4jG7moke0X(QF503fGagqkTdQ7f4MUo(metadata));
	}

	public static bool IsSystem(this Type type)
	{
		return qx5HCJGa5c4jG7moke0X(InterfaceActivator.UID(type, loadImplementation: false));
	}

	public static bool IsSystemMetadata(this Guid typeUid)
	{
		return olUxD1GajyiCiNfZkZQw(l25tXfGaTPylBOyc2Jgy(), typeUid);
	}

	public static bool IsConfig(this IMetadata metadata)
	{
		return UtIHCTGaYqCD3SdlqPuJ(QF503fGagqkTdQ7f4MUo(metadata));
	}

	public static bool IsConfig(this Type type)
	{
		return InterfaceActivator.UID(type, loadImplementation: false).IsConfigMetadata();
	}

	public static bool IsConfigMetadata(this Guid typeUid)
	{
		return rG9eEiGaLt1hp0EHxlb3(l25tXfGaTPylBOyc2Jgy(), typeUid);
	}

	public static string GetDisplayName(this ICodeItemMetadata metadata)
	{
		return (string)W3v935GaU8aWP6Y8GYjb(MetadataServiceContext.Service, metadata);
	}

	static EntityMetadataExtensions()
	{
		int num = 2;
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
				PermissionMetadataUid = new Guid((string)sWcV0vGaPP7QWEEEJnMr(-882126494 ^ -882365778));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				DEqgX8GasBrdMDr2jBWf();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object CWxtNGGaK0jJaKUJBKMI(object P_0)
	{
		return ((EntityMetadata)P_0).GetActivePermissionMetadata();
	}

	internal static bool nXKexuGaRkDQAlWShKgS()
	{
		return aPdmyFGaihaq59gUdX0B == null;
	}

	internal static EntityMetadataExtensions WsoayIGaqUAnY6Z3tJuh()
	{
		return aPdmyFGaihaq59gUdX0B;
	}

	internal static object qbZm64GaXUTkYcM5nWke(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object l25tXfGaTPylBOyc2Jgy()
	{
		return MetadataServiceContext.Service;
	}

	internal static Guid ykTq8EGakJ3jXoEWD02m(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static bool TicalFGanByw4cEl4BPT(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid CreateNewGuid()
	{
		return Guid.NewGuid();
	}

	internal static void TIdY4VGa2upeefQd8CTO(object P_0, Guid value)
	{
		((TablePartMetadata)P_0).TablePartPropertyUid = value;
	}

	internal static void fQuXspGaefOAB6OIbFYN(object P_0, object P_1)
	{
		((EntityMetadata)P_0).ActivatePermissionMetadata((TablePartMetadata)P_1);
	}

	internal static object sWcV0vGaPP7QWEEEJnMr(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object utqQVGGa1aionmu8mMKn(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static Guid JGg29PGaNujtHyA7UwNq(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object kjwNM2Ga3XClfRAXh0PW(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object fEEweXGapw1tmIhRWu1V(object P_0)
	{
		return ((EntityMetadata)P_0).GetBaseMetadata();
	}

	internal static object mhrE1VGaaTtISPUkHvdo(object P_0)
	{
		return GetActivePermissionMetadataFromMetadata((EntityMetadata)P_0);
	}

	internal static bool M4J3dAGaDZ6kFHo4El48(object P_0)
	{
		return ((IMetadata)P_0).IsSystem();
	}

	internal static int O5Cv0rGatKDII4Fjmjen(object P_0)
	{
		return ((List<TablePartMetadata>)P_0).Count;
	}

	internal static bool BdHK2HGawxJXM0NsIGdR(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object LARtMbGa4uymplrSA7ID(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void yZOytRGa6WqjcrOT0Xvs(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static int fk9okqGaHQteRgRNYKE6(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object FbI8imGaA55QnMChiv3L(object P_0)
	{
		return ((ClassMetadata)P_0).Namespace;
	}

	internal static void IC4jfiGa7IFvWyBgduBv(object P_0, object P_1)
	{
		((ClassMetadata)P_0).Namespace = (string)P_1;
	}

	internal static void bSktZmGaxNBxnXtMsO8y(object P_0, object P_1)
	{
		((TablePartMetadata)P_0).TablePartPropertyName = (string)P_1;
	}

	internal static void QvJ93WGa0CSX5A4WuHbV(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Description = (string)P_1;
	}

	internal static void vtYX9kGamemEXFxuMhgj(object P_0, bool value)
	{
		((EntityMetadata)P_0).ShowInCatalogList = value;
	}

	internal static void n3FPdFGaypg5RmDucLWa(object P_0, bool value)
	{
		((ClassMetadata)P_0).ShowInTypeTree = value;
	}

	internal static void d5vr6NGaMRbv5om3SF8j(object P_0, bool value)
	{
		((ClassMetadata)P_0).ShowInDesigner = value;
	}

	internal static void wBt7ZRGaJLJjfybb9S89(object P_0, object P_1)
	{
		((EntityMetadata)P_0).AddPermissionInterfaces((EntityMetadata)P_1);
	}

	internal static object m94rvVGa96TMyk7k4M3N()
	{
		return ComponentManager.Current;
	}

	internal static Guid fg46OmGadeiKnaCIo3ee(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Guid n8PCR2GalgrBxbrDbH7s(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static bool HabaQGGarbRoAc9E01mZ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static Guid QF503fGagqkTdQ7f4MUo(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static bool qx5HCJGa5c4jG7moke0X(Guid typeUid)
	{
		return typeUid.IsSystemMetadata();
	}

	internal static bool olUxD1GajyiCiNfZkZQw(object P_0, Guid typeUid)
	{
		return ((IMetadataService)P_0).IsSystem(typeUid);
	}

	internal static bool UtIHCTGaYqCD3SdlqPuJ(Guid typeUid)
	{
		return typeUid.IsConfigMetadata();
	}

	internal static bool rG9eEiGaLt1hp0EHxlb3(object P_0, Guid typeUid)
	{
		return ((IMetadataService)P_0).IsConfig(typeUid);
	}

	internal static object W3v935GaU8aWP6Y8GYjb(object P_0, object P_1)
	{
		return ((IMetadataService)P_0).GetDisplayName((ICodeItemMetadata)P_1);
	}

	internal static void DEqgX8GasBrdMDr2jBWf()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
