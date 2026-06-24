using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views.Toolbox;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_GridViewItem), "DisplayName")]
[DebuggerTypeProxy(typeof(DebugView))]
public class GridViewItem : RootViewItem, IHideEmptyViewItem, ICountViewItem, ISelectionItemViewItem
{
	public new class DebugView
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly GridViewItem viewItem;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ClassMetadata entity;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IPropertyMetadata property;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private readonly ViewItem.DebugView _viewItemDebugView;

		internal static DebugView gTl6uLCEAJMkZRGkGvmf;

		public bool ShowCount
		{
			get
			{
				return gu4gIPCEmtHBtn1hDjHg(viewItem);
			}
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
						nX06KGCEyCsG8gOh6bCV(viewItem, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Query
		{
			get
			{
				return (string)xgpVQJCEM2ZKyS8axjxX(viewItem);
			}
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
						P4ucADCEJWxgopaJgoiO(viewItem, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Guid[] SelectedColumns => viewItem.SelectedColumns;

		public ClassMetadata Entity
		{
			get
			{
				int num = 1;
				int num2 = num;
				ClassMetadata classMetadata2;
				ClassMetadata classMetadata = default(ClassMetadata);
				while (true)
				{
					switch (num2)
					{
					case 1:
						classMetadata2 = entity;
						if (classMetadata2 == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					default:
						classMetadata = (entity = (ClassMetadata)MetadataLoader.LoadMetadata(Ry8eOhCE9R2Cvu0J9xUc(viewItem)));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 2;
						}
						continue;
					case 2:
						classMetadata2 = classMetadata;
						break;
					}
					break;
				}
				return classMetadata2;
			}
		}

		public IPropertyMetadata Property
		{
			get
			{
				//Discarded unreachable code: IL_00bb, IL_0128, IL_0147, IL_01e1
				int num = 4;
				int num2 = num;
				IEntityMetadata entityMetadata = default(IEntityMetadata);
				Guid? propertyUid = default(Guid?);
				Guid guid2 = default(Guid);
				while (true)
				{
					Guid guid;
					switch (num2)
					{
					case 11:
						if (property is ITablePartMetadata)
						{
							num2 = 13;
							break;
						}
						goto case 8;
					case 9:
						property = entityMetadata.GetPropertiesAndTableParts().OfType<ITablePartMetadata>().FirstOrDefault(delegate(ITablePartMetadata tp)
						{
							int num5 = 2;
							Guid tablePartPropertyUid = default(Guid);
							Guid? propertyUid3 = default(Guid?);
							while (true)
							{
								int num6 = num5;
								while (true)
								{
									switch (num6)
									{
									case 1:
										break;
									case 2:
										tablePartPropertyUid = tp.TablePartPropertyUid;
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
										{
											num6 = 1;
										}
										continue;
									default:
										return false;
									case 3:
										if (propertyUid3.HasValue)
										{
											return x4VpTSCErcRS3TZatHqL(tablePartPropertyUid, propertyUid3.GetValueOrDefault());
										}
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
										{
											num6 = 0;
										}
										continue;
									}
									break;
								}
								propertyUid3 = viewItem.PropertyUid;
								num5 = 3;
							}
						});
						num2 = 2;
						break;
					default:
						entityMetadata = Entity as IEntityMetadata;
						num2 = 5;
						break;
					case 2:
					case 10:
						return property;
					case 1:
						if (property == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 2;
					case 12:
						propertyUid = viewItem.PropertyUid;
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 2;
						}
						break;
					case 8:
						guid = Iq3X0NCEdSepPlqeHApQ(property);
						goto IL_01f6;
					case 4:
						if (Entity == null)
						{
							num2 = 3;
							break;
						}
						if (property != null)
						{
							num2 = 11;
							break;
						}
						goto case 6;
					case 3:
						return null;
					case 5:
						if (entityMetadata != null)
						{
							num2 = 9;
							break;
						}
						goto case 2;
					case 7:
						if (!propertyUid.HasValue)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
							{
								num2 = 6;
							}
							break;
						}
						if (!JjXujyCElC8hWongeKwu(guid2, propertyUid.GetValueOrDefault()))
						{
							num2 = 10;
							break;
						}
						goto case 6;
					case 6:
					case 14:
						property = Entity.Properties.FirstOrDefault(delegate(PropertyMetadata p)
						{
							int num3 = 3;
							int num4 = num3;
							Guid uid = default(Guid);
							Guid? propertyUid2 = default(Guid?);
							while (true)
							{
								switch (num4)
								{
								case 3:
									uid = p.Uid;
									num4 = 2;
									break;
								case 2:
									propertyUid2 = viewItem.PropertyUid;
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
									{
										num4 = 0;
									}
									break;
								case 1:
									return false;
								default:
									if (propertyUid2.HasValue)
									{
										return x4VpTSCErcRS3TZatHqL(uid, propertyUid2.GetValueOrDefault());
									}
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
									{
										num4 = 1;
									}
									break;
								}
							}
						});
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num2 = 1;
						}
						break;
					case 13:
						{
							guid = ((ITablePartMetadata)property).TablePartPropertyUid;
							goto IL_01f6;
						}
						IL_01f6:
						guid2 = guid;
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num2 = 11;
						}
						break;
					}
				}
			}
		}

		public DebugView(GridViewItem viewItem)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			oxIrf9CE0A0MOCuF4PbL();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					_viewItemDebugView = new ViewItem.DebugView(viewItem);
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num = 0;
					}
					break;
				case 2:
					return;
				default:
					this.viewItem = viewItem;
					num = 2;
					break;
				}
			}
		}

		internal static void oxIrf9CE0A0MOCuF4PbL()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool pJnfptCE7ZpLiac0nx8A()
		{
			return gTl6uLCEAJMkZRGkGvmf == null;
		}

		internal static DebugView jN3IgxCExVYOtd0yl15A()
		{
			return gTl6uLCEAJMkZRGkGvmf;
		}

		internal static bool gu4gIPCEmtHBtn1hDjHg(object P_0)
		{
			return ((GridViewItem)P_0).ShowCount;
		}

		internal static void nX06KGCEyCsG8gOh6bCV(object P_0, bool value)
		{
			((GridViewItem)P_0).ShowCount = value;
		}

		internal static object xgpVQJCEM2ZKyS8axjxX(object P_0)
		{
			return ((GridViewItem)P_0).Query;
		}

		internal static void P4ucADCEJWxgopaJgoiO(object P_0, object P_1)
		{
			((GridViewItem)P_0).Query = (string)P_1;
		}

		internal static Guid Ry8eOhCE9R2Cvu0J9xUc(object P_0)
		{
			return ((GridViewItem)P_0).EntityUid;
		}

		internal static Guid Iq3X0NCEdSepPlqeHApQ(object P_0)
		{
			return ((IMetadata)P_0).Uid;
		}

		internal static bool JjXujyCElC8hWongeKwu(Guid P_0, Guid P_1)
		{
			return P_0 != P_1;
		}

		internal static bool x4VpTSCErcRS3TZatHqL(Guid P_0, Guid P_1)
		{
			return P_0 == P_1;
		}
	}

	[Component(Order = 500)]
	private class ToolboxItem : CommonViewItemToolboxItem<GridViewItem>
	{
		internal static object gkJdJaCEguXvD0Niw7fI;

		public override string Name => SR.T((string)voRtlQCEYE7BftmfJcQL(-309639236 ^ -309782036));

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			dYDLsnCEL8lNbw6ulsF8();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object voRtlQCEYE7BftmfJcQL(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool QvjjsnCE5KTA2RAfxxGU()
		{
			return gkJdJaCEguXvD0Niw7fI == null;
		}

		internal static ToolboxItem PmAZOfCEjt8KstcVh7o2()
		{
			return (ToolboxItem)gkJdJaCEguXvD0Niw7fI;
		}

		internal static void dYDLsnCEL8lNbw6ulsF8()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	internal static GridViewItem Ix5hPEon2Pu4dvyjsMf8;

	[DefaultValue(null)]
	public TableView TableView
	{
		[CompilerGenerated]
		get
		{
			return _003CTableView_003Ek__BackingField;
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
					_003CTableView_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("Entity")]
	public virtual Guid EntityUid
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityUid_003Ek__BackingField;
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
					_003CEntityUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("Property")]
	[DefaultValue(null)]
	public virtual Guid? PropertyUid { get; set; }

	[DefaultValue(true)]
	public virtual bool ShowCount
	{
		[CompilerGenerated]
		get
		{
			return _003CShowCount_003Ek__BackingField;
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
					_003CShowCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
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

	[DefaultValue(null)]
	public virtual string Query
	{
		[CompilerGenerated]
		get
		{
			return _003CQuery_003Ek__BackingField;
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
					_003CQuery_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
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

	[Obsolete("Use Items instead", false)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[XmlForceArray]
	public virtual Guid[] SelectedColumns
	{
		get
		{
			return (from p in base.Items.OfType<GridPropertyColumnViewItem>()
				select _003C_003Ec.PO5blbCfFmnLu6h169Rn(p)).ToArray();
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					value.Select(delegate(Guid v)
					{
						//Discarded unreachable code: IL_0091, IL_0254, IL_0263, IL_02fc
						int num3 = 13;
						DynamicSlotViewItem dynamicSlotViewItem = default(DynamicSlotViewItem);
						PropertyValueViewItem propertyValueViewItem = default(PropertyValueViewItem);
						PropertyCaptionViewItem propertyCaptionViewItem = default(PropertyCaptionViewItem);
						GridPropertyColumnViewItem gridPropertyColumnViewItem = default(GridPropertyColumnViewItem);
						Guid? propertyUid = default(Guid?);
						while (true)
						{
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								case 25:
									if (!oQ58u2on7ApWiGVI0luC(v, Guid.Empty))
									{
										num3 = 2;
										break;
									}
									goto case 21;
								case 18:
									((EventedList<ViewItem>)eYJ7bdonMTjPdT9se6IR(dynamicSlotViewItem)).Add((ViewItem)propertyValueViewItem);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
									{
										num4 = 0;
									}
									continue;
								case 17:
									propertyCaptionViewItem.PropertyParents.AddRange(gridPropertyColumnViewItem.PropertyParents);
									num4 = 10;
									continue;
								case 16:
									gridPropertyColumnViewItem.Items.Add(propertyCaptionViewItem);
									num4 = 9;
									continue;
								case 5:
									SsCH7Bon0ddb1dhT3E8W(dynamicSlotViewItem, gridPropertyColumnViewItem);
									num4 = 8;
									continue;
								case 13:
								{
									GridPropertyColumnViewItem gridPropertyColumnViewItem2 = new GridPropertyColumnViewItem();
									WylZsbonxYrShKgtlJYL(gridPropertyColumnViewItem2, v);
									gridPropertyColumnViewItem = gridPropertyColumnViewItem2;
									num3 = 12;
									break;
								}
								case 3:
								{
									List<Guid> propertyParents = gridPropertyColumnViewItem.PropertyParents;
									propertyUid = PropertyUid;
									propertyParents.Add(propertyUid.Value);
									num4 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
									{
										num4 = 4;
									}
									continue;
								}
								case 9:
									return gridPropertyColumnViewItem;
								case 21:
									WylZsbonxYrShKgtlJYL(propertyValueViewItem, gridPropertyColumnViewItem.PropertyUid);
									num4 = 6;
									continue;
								case 12:
									SsCH7Bon0ddb1dhT3E8W(gridPropertyColumnViewItem, this);
									num4 = 27;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
									{
										num4 = 2;
									}
									continue;
								case 1:
								{
									PropertyCaptionViewItem propertyCaptionViewItem2 = new PropertyCaptionViewItem();
									plPFm5onyQs9Fa4pyBXI(propertyCaptionViewItem2, new ViewAttributes());
									propertyCaptionViewItem = propertyCaptionViewItem2;
									num4 = 15;
									continue;
								}
								case 15:
									SsCH7Bon0ddb1dhT3E8W(propertyCaptionViewItem, gridPropertyColumnViewItem);
									num4 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
									{
										num4 = 25;
									}
									continue;
								case 2:
								case 11:
									((EventedList<ViewItem>)eYJ7bdonMTjPdT9se6IR(gridPropertyColumnViewItem)).Add((ViewItem)dynamicSlotViewItem);
									num3 = 16;
									break;
								default:
									if (!propertyUid.HasValue)
									{
										num4 = 24;
										continue;
									}
									goto case 3;
								case 10:
									BVuIgBonlH4cWgB0nYq5(propertyCaptionViewItem.Attributes, false);
									num4 = 9;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
									{
										num4 = 11;
									}
									continue;
								case 19:
									Od5Pl9on9XfkU21PYnP7(JVxqIconJmT1AnDlKIQF(propertyValueViewItem), false);
									num4 = 23;
									continue;
								case 26:
									gridPropertyColumnViewItem.PropertyParents.Add(SQZcdJonwuYaooiTkjT8(this));
									num4 = 12;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
									{
										num4 = 20;
									}
									continue;
								case 6:
									propertyValueViewItem.PropertyParents.AddRange(gridPropertyColumnViewItem.PropertyParents);
									num4 = 19;
									continue;
								case 23:
									WylZsbonxYrShKgtlJYL(propertyCaptionViewItem, HgcyHHondV7h0qgFmI39(gridPropertyColumnViewItem));
									num4 = 17;
									continue;
								case 4:
								case 20:
								case 24:
									dynamicSlotViewItem = new DynamicSlotViewItem();
									num4 = 5;
									continue;
								case 14:
								{
									PropertyValueViewItem propertyValueViewItem2 = new PropertyValueViewItem();
									plPFm5onyQs9Fa4pyBXI(propertyValueViewItem2, new ViewAttributes());
									propertyValueViewItem = propertyValueViewItem2;
									num4 = 22;
									continue;
								}
								case 22:
									propertyValueViewItem.InitNew(dynamicSlotViewItem);
									num4 = 18;
									continue;
								case 27:
									if (oQ58u2on7ApWiGVI0luC(EntityUid, Guid.Empty))
									{
										num4 = 26;
										continue;
									}
									goto case 7;
								case 7:
									propertyUid = PropertyUid;
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
									{
										num4 = 0;
									}
									continue;
								case 8:
									Y37qc9onmVsk5eyPONIG(dynamicSlotViewItem, GridPropertyColumnViewItem.ContentSlotUid);
									num4 = 14;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
									{
										num4 = 0;
									}
									continue;
								}
								break;
							}
						}
					}).ForEach(base.Items.Add);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					cgKGp2ontqFrVpLlV5ki(base.Items);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	public List<TableViewSortDescriptor> SortDescriptors { get; set; }

	public bool EnableSelection
	{
		[CompilerGenerated]
		get
		{
			return _003CEnableSelection_003Ek__BackingField;
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
					_003CEnableSelection_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid SelectablePropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CSelectablePropertyUid_003Ek__BackingField;
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
					_003CSelectablePropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<Guid> SelectablePropertyParents { get; set; }

	public GridViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		U9dLl1on1DBk1XA1d6nh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				Sap100onNjWrYN7rIgHO(this, true);
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num = 1;
				}
				break;
			case 2:
			{
				TableView tableView = new TableView();
				nnIojwonphe3NpLitAWw(tableView, lbVUsoon3alf2Lh605VY());
				asS1qOona9isRUmwjEVP(tableView, ViewType.List);
				TableView = tableView;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num = 0;
				}
				break;
			}
			case 3:
				SortDescriptors = new List<TableViewSortDescriptor>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return mBYXcRonD18kXfum4eRJ(parentViewItem, this);
			case 1:
				if (parentViewItem == null)
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is IGridColumnViewItem;
	}

	public string GetFilterQuery(IEntity entity)
	{
		int num = 2;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 2:
				obj = Query;
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				obj = (from p in ((ClassMetadata)MetadataLoader.LoadMetadata(SQZcdJonwuYaooiTkjT8(this))).Properties.Where(delegate(PropertyMetadata p)
					{
						//Discarded unreachable code: IL_0035
						int num3 = 1;
						int num4 = num3;
						Guid guid = default(Guid);
						Guid? propertyUid = default(Guid?);
						while (true)
						{
							switch (num4)
							{
							case 4:
								return false;
							case 3:
								return FosY8iongtF2E8EJMZuH(guid, propertyUid.GetValueOrDefault());
							case 2:
								if (propertyUid.HasValue)
								{
									num4 = 3;
									break;
								}
								goto case 4;
							case 1:
								guid = P30RXbonrS1rHHuPD93b(p);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
								{
									num4 = 0;
								}
								break;
							default:
								propertyUid = PropertyUid;
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
								{
									num4 = 2;
								}
								break;
							}
						}
					})
					select (string)_003C_003Ec.RBSehVCfoi3FOBbIvakv(_003C_003Ec.M4nK6ICfBWBvGjkFl7lR(p), _003C_003Ec.JXUHayCfW5XN6NtDRoxc(0x1C9495B4 ^ 0x1C910F1A))).FirstOrDefault();
				if (obj != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				obj = SadoXhon4bZIFAcaef8G(-2099751081 ^ -2099639939);
				break;
			}
			break;
		}
		return (string)Q8XKq2on6ZfavHl7sRUk(new TextTemplateGenerator((string)obj), entity);
	}

	public IEntityFilter GetFilter(IEntity entity)
	{
		Filter filter = new Filter();
		lInO7AonHdcVEq6o4tLt(filter, GetFilterQuery(entity));
		return filter;
	}

	public override bool IsHideEmpty(RootViewItem parent = null)
	{
		//Discarded unreachable code: IL_0070, IL_007f
		int num = 2;
		int num2 = num;
		while (true)
		{
			RootViewItem rootViewItem;
			RootViewItem rootViewItem2;
			switch (num2)
			{
			case 5:
				rootViewItem = parent;
				if (rootViewItem == null)
				{
					num2 = 4;
					break;
				}
				goto IL_00e6;
			case 2:
				if (base.HideEmptySettings != 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 1;
					}
					break;
				}
				rootViewItem2 = parent;
				if (rootViewItem2 != null)
				{
					goto IL_00c1;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return base.HideEmptySettings == HideEmptyEnum.HideEmpty;
			case 3:
				rootViewItem2 = base.Parent;
				goto IL_00c1;
			case 4:
				rootViewItem = base.Parent;
				goto IL_00e6;
			default:
				{
					return false;
				}
				IL_00c1:
				if (rootViewItem2 == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
				IL_00e6:
				return rootViewItem.IsHideEmpty();
			}
		}
	}

	protected override IEnumerable<PropertyInfo> GetPropertiesForCopy()
	{
		return from p in base.GetPropertiesForCopy()
			where _003C_003Ec.GAFScACfhTBW43LbV09H(_003C_003Ec.mMJ4IUCfbGKbkC0hfV7a(p), _003C_003Ec.JXUHayCfW5XN6NtDRoxc(-561074844 ^ -561301594))
			select p;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeSelectedColumns()
	{
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeSelectablePropertyParents()
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (SelectablePropertyParents == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return q2BqsFonAd8rFq2CoaIL(SelectablePropertyParents) > 0;
			default:
				return false;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeSelectablePropertyUid()
	{
		return oQ58u2on7ApWiGVI0luC(SelectablePropertyUid, Guid.Empty);
	}

	internal static void U9dLl1on1DBk1XA1d6nh()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void Sap100onNjWrYN7rIgHO(object P_0, bool value)
	{
		((GridViewItem)P_0).ShowCount = value;
	}

	internal static Guid lbVUsoon3alf2Lh605VY()
	{
		return Guid.NewGuid();
	}

	internal static void nnIojwonphe3NpLitAWw(object P_0, Guid value)
	{
		((TableView)P_0).Uid = value;
	}

	internal static void asS1qOona9isRUmwjEVP(object P_0, ViewType value)
	{
		((TableView)P_0).ViewType = value;
	}

	internal static bool qs6pQ4oneL5PJSPxLwHy()
	{
		return Ix5hPEon2Pu4dvyjsMf8 == null;
	}

	internal static GridViewItem VqE2hEonPW3qQaW2nh4v()
	{
		return Ix5hPEon2Pu4dvyjsMf8;
	}

	internal static bool mBYXcRonD18kXfum4eRJ(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}

	internal static void cgKGp2ontqFrVpLlV5ki(object P_0)
	{
		((EventedList<ViewItem>)P_0).Clear();
	}

	internal static Guid SQZcdJonwuYaooiTkjT8(object P_0)
	{
		return ((GridViewItem)P_0).EntityUid;
	}

	internal static object SadoXhon4bZIFAcaef8G(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Q8XKq2on6ZfavHl7sRUk(object P_0, object P_1)
	{
		return ((TextGenerator)P_0).Generate(P_1);
	}

	internal static void lInO7AonHdcVEq6o4tLt(object P_0, object P_1)
	{
		((Filter)P_0).Query = (string)P_1;
	}

	internal static int q2BqsFonAd8rFq2CoaIL(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static bool oQ58u2on7ApWiGVI0luC(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void WylZsbonxYrShKgtlJYL(object P_0, Guid value)
	{
		((PropertyViewItem)P_0).PropertyUid = value;
	}

	internal static void SsCH7Bon0ddb1dhT3E8W(object P_0, object P_1)
	{
		((ViewItem)P_0).InitNew((ViewItem)P_1);
	}

	internal static void Y37qc9onmVsk5eyPONIG(object P_0, Guid value)
	{
		((SlotViewItem)P_0).PlaceholderUid = value;
	}

	internal static void plPFm5onyQs9Fa4pyBXI(object P_0, object P_1)
	{
		((PropertyViewItem)P_0).Attributes = (ViewAttributes)P_1;
	}

	internal static object eYJ7bdonMTjPdT9se6IR(object P_0)
	{
		return ((RootViewItem)P_0).Items;
	}

	internal static object JVxqIconJmT1AnDlKIQF(object P_0)
	{
		return ((PropertyViewItem)P_0).Attributes;
	}

	internal static void Od5Pl9on9XfkU21PYnP7(object P_0, bool value)
	{
		((ViewAttributes)P_0).ValidationMessage = value;
	}

	internal static Guid HgcyHHondV7h0qgFmI39(object P_0)
	{
		return ((PropertyViewItem)P_0).PropertyUid;
	}

	internal static void BVuIgBonlH4cWgB0nYq5(object P_0, bool value)
	{
		((ViewAttributes)P_0).Required = value;
	}

	internal static Guid P30RXbonrS1rHHuPD93b(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool FosY8iongtF2E8EJMZuH(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
