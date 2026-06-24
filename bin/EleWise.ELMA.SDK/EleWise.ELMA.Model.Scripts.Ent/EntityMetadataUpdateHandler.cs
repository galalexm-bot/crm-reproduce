using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.Entities;

[Component]
internal sealed class EntityMetadataUpdateHandler : BaseMetadataUpdateHandler
{
	internal static EntityMetadataUpdateHandler WNRENZbeYnJAIQP5YPy8;

	public override bool Check(IMetadata metadata)
	{
		//Discarded unreachable code: IL_0069, IL_0078
		int num = 2;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return Uw3tyabesSGScZY7OwsQ(entityMetadata) == EntityMetadata.UID;
			case 1:
				return false;
			case 2:
				if ((entityMetadata = metadata as EntityMetadata) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public override void UpdateMetadata(IMetadataUpdateResult updateResult)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 1;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				if (iSkdVjbecDMYF8PcJU3E(entityMetadata) == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 2:
				return;
			case 1:
				if ((entityMetadata = updateResult.Metadata as EntityMetadata) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 4:
				KjF39ObPFJlXXIhBfVX2(entityMetadata, DxQfDlbez5g40bqq4LaW(entityMetadata));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public override void UpdateForm(IMetadataUpdateResult updateResult, Guid formUid)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_007a, IL_016d, IL_017c
		int num = 12;
		FormViewItem formViewItem = default(FormViewItem);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 2:
					return;
				case 1:
					obj = null;
					goto IL_01b4;
				case 3:
					if (formViewItem == null)
					{
						return;
					}
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 6;
					}
					continue;
				case 11:
					_003C_003Ec__DisplayClass2_.formUid = formUid;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					sXNNvcbPbuKBmxkPMF90(formViewItem, TTfTpkbPoFAA2ugKkuWe(propertyMetadata), entityMetadata);
					num2 = 2;
					continue;
				case 7:
					if (propertyMetadata != null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 4:
					if (entityMetadata == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					obj = entityMetadata.ViewModelMetadata;
					goto IL_01b4;
				case 12:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 11;
					continue;
				case 13:
					kWSvuAbPWPwYT9nHM4KT(formViewItem, RuntimeVersion.Version2);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 5;
					}
					continue;
				default:
					entityMetadata = RwWdUdbPB0g0WWcglGmn(updateResult) as EntityMetadata;
					num2 = 4;
					continue;
				case 8:
					return;
				case 9:
					formViewItem = entityMetadata.Forms.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CUpdateForm_003Eb__1);
					num2 = 3;
					continue;
				case 6:
					return;
				case 10:
					{
						propertyMetadata = entityMetadata.ViewModelMetadata.Properties.Find((PropertyMetadata property) => _003C_003Ec.ErRISnCahvTI6ZDWQfVL(property.Name, _003C_003Ec.GMsUMQCabfZyZqSnQdTi(0x638095EB ^ 0x63804BA7)));
						num = 7;
						break;
					}
					IL_01b4:
					if (obj != null)
					{
						num2 = 10;
						continue;
					}
					return;
				}
				break;
			}
		}
	}

	public override void UpdateScriptModules(IMetadataUpdateResult updateResult)
	{
		//Discarded unreachable code: IL_003e, IL_0071, IL_0080, IL_0091, IL_009b, IL_0172, IL_01aa, IL_01b9
		int num = 4;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		IEnumerator<ScriptModule> enumerator = default(IEnumerator<ScriptModule>);
		ScriptModule current = default(ScriptModule);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				return;
			case 6:
				obj = null;
				break;
			case 3:
				if (entityMetadata != null)
				{
					num2 = 2;
					continue;
				}
				goto case 6;
			case 4:
				entityMetadata = RwWdUdbPB0g0WWcglGmn(updateResult) as EntityMetadata;
				num2 = 3;
				continue;
			case 0:
				return;
			case 5:
				try
				{
					while (true)
					{
						IL_00dc:
						int num3;
						if (!OQatlDbPCxgAtgtLQYAt(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
							{
								num3 = 0;
							}
							goto IL_009f;
						}
						goto IL_00b9;
						IL_00b9:
						current = enumerator.Current;
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num3 = 2;
						}
						goto IL_009f;
						IL_009f:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 3:
								break;
							case 1:
								goto IL_00dc;
							case 2:
								GZ85wUbPQ0eC6gRgy92n(current, Hq8CkSbPfCChqogYVo6u(this, current.SourceCode, xdJmEWbPEc5Cy4ulLJGY(Pvwex4bPhKMVXrOifSpm(entityMetadata), Vntnh5bPGHk8sTW9oy8y(0x26FFCB59 ^ 0x26FE9847))));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						}
						goto IL_00b9;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								enumerator.Dispose();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
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
				obj = entityMetadata.ViewModelMetadata;
				break;
			case 1:
				return;
			}
			if (obj == null)
			{
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 0;
				}
				continue;
			}
			enumerator = updateResult.ScriptModules.Where(delegate(ScriptModule sm)
			{
				//Discarded unreachable code: IL_0079
				int num5 = 1;
				Guid? guid2 = default(Guid?);
				Guid? guid3 = default(Guid?);
				Guid uID = default(Guid);
				while (true)
				{
					int num6 = num5;
					while (true)
					{
						Guid? guid;
						switch (num6)
						{
						default:
							guid2 = null;
							num6 = 5;
							continue;
						case 2:
							return false;
						case 5:
							guid = guid2;
							break;
						case 6:
							return true;
						case 3:
							if (guid3.HasValue)
							{
								if (guid3.HasValue)
								{
									return _003C_003Ec.BpnPE0CaEwiXJJGU5C3F(guid3.GetValueOrDefault(), uID);
								}
								num6 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
								{
									num6 = 6;
								}
							}
							else
							{
								num6 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
								{
									num6 = 2;
								}
							}
							continue;
						case 4:
							goto end_IL_0012;
						case 1:
							if (sm == null)
							{
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
								{
									num6 = 0;
								}
								continue;
							}
							guid = _003C_003Ec.L9m40XCaGfTEHwph2xhv(sm);
							break;
						}
						guid3 = guid;
						num6 = 4;
						continue;
						end_IL_0012:
						break;
					}
					uID = EntityScriptModuleType.UID;
					num5 = 3;
				}
			}).GetEnumerator();
			num2 = 5;
		}
	}

	private static void UpdateForm(object form, Guid modelPropertyUid, object entityMetadata)
	{
		//Discarded unreachable code: IL_0071, IL_0080, IL_00a8, IL_00b7, IL_01a1, IL_01b0, IL_01bf, IL_01ef, IL_01fe, IL_020f, IL_021e
		int num = 5;
		int num2 = num;
		GridViewItem gridViewItem = default(GridViewItem);
		ViewItem viewItem = default(ViewItem);
		ViewItem[] array = default(ViewItem[]);
		ButtonViewItem buttonViewItem = default(ButtonViewItem);
		int num3 = default(int);
		PropertyViewItem propertyViewItem = default(PropertyViewItem);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 19:
				if ((gridViewItem = viewItem as GridViewItem) == null)
				{
					num2 = 17;
					continue;
				}
				goto case 10;
			case 5:
				array = ((RootViewItem)form).GetAllItems(ignoreHide: false).ToArray();
				num2 = 4;
				continue;
			case 8:
				XDhqrKbPuHQMGHc3qOMn(buttonViewItem, modelPropertyUid);
				num2 = 18;
				continue;
			case 13:
			case 15:
				viewItem = array[num3];
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 6;
				}
				continue;
			case 4:
				num3 = 0;
				num2 = 14;
				continue;
			case 12:
			case 17:
				if ((buttonViewItem = viewItem as ButtonViewItem) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 8;
			case 10:
				sqKtfUbPZjJ3nrwdA8ww(gridViewItem, entityMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 9;
				}
				continue;
			case 7:
				xcXMGnbP8WhYsF7h8q4Y(propertyViewItem, modelPropertyUid);
				num2 = 11;
				continue;
			case 3:
				if (!tEWTjrbPvTVP4K3ONd4L(propertyViewItem.GetType(), TypeOf<PropertyViewItem>.Raw))
				{
					num2 = 19;
					continue;
				}
				goto case 7;
			case 16:
				return;
			case 6:
				if ((propertyViewItem = viewItem as PropertyViewItem) != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 2;
			case 1:
			case 9:
			case 11:
			case 18:
				num3++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (num3 < array.Length)
			{
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 3;
				}
				continue;
			}
			return;
		}
	}

	private static void UpdatePropertyViewItem(object propertyViewItem, Guid modelPropertyUid)
	{
		//Discarded unreachable code: IL_00e3
		int num = 1;
		Guid? metadataUid = default(Guid?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				default:
					if (!metadataUid.HasValue)
					{
						if (((PropertyViewItem)propertyViewItem).PropertyParents == null)
						{
							goto end_IL_0012;
						}
						goto case 7;
					}
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					metadataUid = ((RootViewItem)propertyViewItem).MetadataUid;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					Yqqv2mbPVQD75t08tQU4(propertyViewItem);
					num2 = 3;
					break;
				case 7:
					L0Dc9pbPIbcQyOx9Ls7r(((PropertyViewItem)propertyViewItem).PropertyParents);
					num2 = 6;
					break;
				case 3:
					return;
				case 2:
				case 6:
					((PropertyViewItem)propertyViewItem).PropertyParents.Add(modelPropertyUid);
					num2 = 5;
					break;
				case 8:
					((PropertyViewItem)propertyViewItem).PropertyParents = new List<Guid>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 2;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	private static void UpdateNestedPropertyViewItem(object propertyViewItem)
	{
		//Discarded unreachable code: IL_005a, IL_0069, IL_0074, IL_00c3, IL_011f, IL_0217, IL_026a, IL_02a2, IL_02b1
		int num = 1;
		int num2 = num;
		IEnumerator<PropertyViewItem> enumerator = default(IEnumerator<PropertyViewItem>);
		PropertyViewItem current = default(PropertyViewItem);
		Guid? metadataUid = default(Guid?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = ((IEnumerable)TDtk4HbPS5drx3rYqnOS(propertyViewItem)).OfType<PropertyViewItem>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!OQatlDbPCxgAtgtLQYAt(enumerator))
					{
						num3 = 8;
						goto IL_0078;
					}
					goto IL_0221;
					IL_0078:
					while (true)
					{
						switch (num3)
						{
						case 2:
							Yqqv2mbPVQD75t08tQU4(current);
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num3 = 4;
							}
							continue;
						case 11:
						case 12:
							current.PropertyParents.AddRange(((PropertyViewItem)propertyViewItem).PropertyParents);
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
							{
								num3 = 2;
							}
							continue;
						case 1:
							current.PropertyParents = new List<Guid>();
							num3 = 12;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
							{
								num3 = 3;
							}
							continue;
						case 4:
						case 7:
						case 10:
							break;
						case 3:
							current.PropertyParents.Add(((PropertyViewItem)propertyViewItem).PropertyUid);
							num3 = 5;
							continue;
						case 9:
							L0Dc9pbPIbcQyOx9Ls7r(current.PropertyParents);
							num3 = 11;
							continue;
						case 6:
							if (!metadataUid.HasValue)
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
								{
									num3 = 7;
								}
								continue;
							}
							goto case 13;
						case 13:
							if (current.PropertyParents == null)
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 9;
						default:
							metadataUid = current.MetadataUid;
							num3 = 6;
							continue;
						case 5:
							if (IFudhCbPiNZJS2WQ0doq(TDtk4HbPS5drx3rYqnOS(current)) <= 0)
							{
								num3 = 10;
								continue;
							}
							goto case 2;
						case 14:
							goto IL_0221;
						case 8:
							return;
						}
						break;
					}
					continue;
					IL_0221:
					current = enumerator.Current;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num3 = 0;
					}
					goto IL_0078;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							j2b90jbPRTpwQks7hYaY(enumerator);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
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
		}
	}

	private static void UpdateGridViewItem(object gridViewItem, object entityMetadata)
	{
		//Discarded unreachable code: IL_0065, IL_0074, IL_007f, IL_0181, IL_0194, IL_01a3, IL_01ed, IL_01f7, IL_030f, IL_0322, IL_0331
		int num = 2;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		List<TablePartMetadata>.Enumerator enumerator2 = default(List<TablePartMetadata>.Enumerator);
		string text2 = default(string);
		TablePartMetadata current2 = default(TablePartMetadata);
		string text3 = default(string);
		string text = default(string);
		PropertyMetadata current = default(PropertyMetadata);
		string newValue = default(string);
		string oldValue = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					enumerator = ((ClassMetadata)entityMetadata).Properties.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator2.MoveNext())
							{
								num5 = 4;
								goto IL_0083;
							}
							goto IL_00f3;
							IL_0083:
							while (true)
							{
								switch (num5)
								{
								default:
									text2 = (string)xdJmEWbPEc5Cy4ulLJGY(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE10C8CB), G87TUXbPKMufaIwk4KEA(current2));
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
									{
										num5 = 0;
									}
									continue;
								case 2:
									break;
								case 3:
									goto IL_00f3;
								case 1:
									text3 = (string)xdJmEWbPEc5Cy4ulLJGY(Vntnh5bPGHk8sTW9oy8y(0x57A5235E ^ 0x57A7C252), current2.TablePartPropertyName);
									num5 = 5;
									continue;
								case 5:
									text = (string)UHghgNbPXaDuOGxG7iCq(text, text2, text3);
									num5 = 2;
									continue;
								case 4:
									goto end_IL_00dd;
								}
								break;
							}
							continue;
							IL_00f3:
							current2 = enumerator2.Current;
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num5 = 0;
							}
							goto IL_0083;
							continue;
							end_IL_00dd:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					break;
				case 4:
					enumerator2 = ((EntityMetadata)entityMetadata).TableParts.GetEnumerator();
					num2 = 3;
					continue;
				case 2:
					text = (string)mTC7ZXbPqkuwFALVbZZm(gridViewItem);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					try
					{
						while (true)
						{
							IL_027e:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
								{
									num3 = 1;
								}
								goto IL_01fb;
							}
							goto IL_021d;
							IL_021d:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
							{
								num3 = 0;
							}
							goto IL_01fb;
							IL_01fb:
							while (true)
							{
								switch (num3)
								{
								case 4:
									break;
								case 2:
									newValue = (string)xdJmEWbPEc5Cy4ulLJGY(Vntnh5bPGHk8sTW9oy8y(-1426094279 ^ -1426233803), Pvwex4bPhKMVXrOifSpm(current));
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
									{
										num3 = 5;
									}
									continue;
								case 3:
									goto IL_027e;
								default:
									oldValue = (string)Vntnh5bPGHk8sTW9oy8y(0x7247028A ^ 0x7245E38E) + (string)Pvwex4bPhKMVXrOifSpm(current);
									num3 = 2;
									continue;
								case 5:
									text = text.Replace(oldValue, newValue);
									num3 = 3;
									continue;
								case 1:
									goto end_IL_027e;
								}
								break;
							}
							goto IL_021d;
							continue;
							end_IL_027e:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
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
				case 6:
					return;
				case 5:
					break;
				}
				break;
			}
			YXox7rbPT6ZpH67d3LTJ(gridViewItem, text);
			num = 6;
		}
	}

	private static void UpdateButtonViewItem(object buttonViewItem, Guid modelPropertyUid)
	{
		//Discarded unreachable code: IL_0141
		int num = 2;
		int num2 = num;
		string[] array = default(string[]);
		string text2 = default(string);
		string text = default(string);
		FormBindingModel formBindingModel = default(FormBindingModel);
		while (true)
		{
			switch (num2)
			{
			case 4:
				ET5xjKbPPlP1HoDkQ9ju(buttonViewItem, fjT8MBbPetHM3vubcmYr(Vntnh5bPGHk8sTW9oy8y(-740338220 ^ -740445100), array));
				num2 = 7;
				break;
			case 8:
				array[array.Length - 2] = text2;
				num2 = 4;
				break;
			case 7:
				return;
			case 9:
				return;
			case 6:
				array = (string[])UiwmaKbP2gl3W7VSWkWJ(text, new string[1] { (string)Vntnh5bPGHk8sTW9oy8y(-538519530 ^ -538691178) }, StringSplitOptions.None);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (string.IsNullOrWhiteSpace(text))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 6;
			case 5:
				formBindingModel = ClassSerializationHelper.DeserializeObjectByXml<FormBindingModel>(array.ElementAt(array.Length - 2));
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 7;
				}
				break;
			default:
				text2 = ClassSerializationHelper.SerializeObjectByXml(formBindingModel);
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 6;
				}
				break;
			case 10:
				formBindingModel.PropertyParents = new Guid[1] { modelPropertyUid };
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (!idHBYUbPnVWTBob16BNX(sHRST6bPkONgVT8AVYSb(buttonViewItem), Vntnh5bPGHk8sTW9oy8y(0x31326106 ^ 0x31308026)))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				text = (string)k0Be0DbPOxvpiNAeUpYA(buttonViewItem);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public EntityMetadataUpdateHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid Uw3tyabesSGScZY7OwsQ(object P_0)
	{
		return ((EntityMetadata)P_0).TypeUid;
	}

	internal static bool TEOKiNbeLBiNARSeW6nd()
	{
		return WNRENZbeYnJAIQP5YPy8 == null;
	}

	internal static EntityMetadataUpdateHandler BeIrE8beUvLpBDucIIgv()
	{
		return WNRENZbeYnJAIQP5YPy8;
	}

	internal static object iSkdVjbecDMYF8PcJU3E(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static object DxQfDlbez5g40bqq4LaW(object P_0)
	{
		return ((EntityMetadata)P_0).CreateViewModelMetadata();
	}

	internal static void KjF39ObPFJlXXIhBfVX2(object P_0, object P_1)
	{
		((EntityMetadata)P_0).ViewModelMetadata = (DataClassMetadata)P_1;
	}

	internal static object RwWdUdbPB0g0WWcglGmn(object P_0)
	{
		return ((IMetadataUpdateResult)P_0).Metadata;
	}

	internal static void kWSvuAbPWPwYT9nHM4KT(object P_0, RuntimeVersion value)
	{
		((FormViewItem)P_0).RuntimeVersion = value;
	}

	internal static Guid TTfTpkbPoFAA2ugKkuWe(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void sXNNvcbPbuKBmxkPMF90(object P_0, Guid modelPropertyUid, object P_2)
	{
		UpdateForm(P_0, modelPropertyUid, P_2);
	}

	internal static object Pvwex4bPhKMVXrOifSpm(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object Vntnh5bPGHk8sTW9oy8y(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object xdJmEWbPEc5Cy4ulLJGY(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object Hq8CkSbPfCChqogYVo6u(object P_0, object P_1, object P_2)
	{
		return ((BaseMetadataUpdateHandler)P_0).UpdateServerSourceCode((string)P_1, (string)P_2);
	}

	internal static void GZ85wUbPQ0eC6gRgy92n(object P_0, object P_1)
	{
		((ScriptModule)P_0).SourceCode = (string)P_1;
	}

	internal static bool OQatlDbPCxgAtgtLQYAt(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool tEWTjrbPvTVP4K3ONd4L(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static void xcXMGnbP8WhYsF7h8q4Y(object P_0, Guid modelPropertyUid)
	{
		UpdatePropertyViewItem(P_0, modelPropertyUid);
	}

	internal static void sqKtfUbPZjJ3nrwdA8ww(object P_0, object P_1)
	{
		UpdateGridViewItem(P_0, P_1);
	}

	internal static void XDhqrKbPuHQMGHc3qOMn(object P_0, Guid modelPropertyUid)
	{
		UpdateButtonViewItem(P_0, modelPropertyUid);
	}

	internal static void L0Dc9pbPIbcQyOx9Ls7r(object P_0)
	{
		((List<Guid>)P_0).Clear();
	}

	internal static void Yqqv2mbPVQD75t08tQU4(object P_0)
	{
		UpdateNestedPropertyViewItem(P_0);
	}

	internal static object TDtk4HbPS5drx3rYqnOS(object P_0)
	{
		return ((RootViewItem)P_0).Items;
	}

	internal static int IFudhCbPiNZJS2WQ0doq(object P_0)
	{
		return ((EventedList<ViewItem>)P_0).Count;
	}

	internal static void j2b90jbPRTpwQks7hYaY(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object mTC7ZXbPqkuwFALVbZZm(object P_0)
	{
		return ((GridViewItem)P_0).Query;
	}

	internal static object G87TUXbPKMufaIwk4KEA(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartPropertyName;
	}

	internal static object UHghgNbPXaDuOGxG7iCq(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void YXox7rbPT6ZpH67d3LTJ(object P_0, object P_1)
	{
		((GridViewItem)P_0).Query = (string)P_1;
	}

	internal static object sHRST6bPkONgVT8AVYSb(object P_0)
	{
		return ((ButtonViewItem)P_0).ActionTypeProviderId;
	}

	internal static bool idHBYUbPnVWTBob16BNX(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object k0Be0DbPOxvpiNAeUpYA(object P_0)
	{
		return ((ButtonViewItem)P_0).ActionId;
	}

	internal static object UiwmaKbP2gl3W7VSWkWJ(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static object fjT8MBbPetHM3vubcmYr(object P_0, object P_1)
	{
		return string.Join((string)P_0, (string[])P_1);
	}

	internal static void ET5xjKbPPlP1HoDkQ9ju(object P_0, object P_1)
	{
		((ButtonViewItem)P_0).ActionId = (string)P_1;
	}
}
