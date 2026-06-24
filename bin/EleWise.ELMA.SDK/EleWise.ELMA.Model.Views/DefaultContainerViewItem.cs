using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views.Toolbox;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_DefaultContainerViewItem), "DisplayName")]
public class DefaultContainerViewItem : ViewItem
{
	private class ToolboxItem : AdditionalViewItemToolboxItem<DefaultContainerViewItem>
	{
		private static object eWY3WoCfKD66T6h1DIoM;

		public override bool IsAvailable(IMetadata metadata)
		{
			return !(metadata is FormContextMetadata);
		}

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			nnjhFjCfkrRknJg5Zc2W();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool lGnrYPCfX655vPXcxWPg()
		{
			return eWY3WoCfKD66T6h1DIoM == null;
		}

		internal static ToolboxItem pGgnUmCfTf0TKV6wRl5O()
		{
			return (ToolboxItem)eWY3WoCfKD66T6h1DIoM;
		}

		internal static void nnjhFjCfkrRknJg5Zc2W()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	public static readonly Guid ItemUid;

	private static DefaultContainerViewItem tVYkIao2obZffZfq2TZM;

	public override Guid Uid
	{
		get
		{
			return ItemUid;
		}
		set
		{
		}
	}

	[DefaultValue(0)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public int StartColumnIndex
	{
		[CompilerGenerated]
		get
		{
			return _003CStartColumnIndex_003Ek__BackingField;
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
					_003CStartColumnIndex_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public bool ReadOnly
	{
		[CompilerGenerated]
		get
		{
			return _003CReadOnly_003Ek__BackingField;
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
					_003CReadOnly_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
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

	[DefaultValue(false)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public bool OnlyUserProperties
	{
		[CompilerGenerated]
		get
		{
			return _003COnlyUserProperties_003Ek__BackingField;
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
					_003COnlyUserProperties_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual int CheckPropertyAddOrder => int.MaxValue;

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(parentViewItem is FormViewItem))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				if (!(parentViewItem is ColumnsLayoutViewItem))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 2:
				return parentViewItem is ColumnViewItem;
			}
			break;
		}
		return true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	private List<PropertyViewItem> GetProperties(ClassMetadata metadata, ViewType viewType, ItemType itemType, RootViewItem parentViewItem = null, Func<IPropertyMetadata, bool> propertieFilter = null, List<Guid> existsProperties = null)
	{
		_003C_003Ec__DisplayClass19_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
		CS_0024_003C_003E8__locals0.metadata = metadata;
		CS_0024_003C_003E8__locals0.propertieFilter = propertieFilter;
		CS_0024_003C_003E8__locals0.viewType = viewType;
		CS_0024_003C_003E8__locals0.itemType = itemType;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.existsProperties = existsProperties;
		CS_0024_003C_003E8__locals0.parentViewItem = parentViewItem;
		List<IPropertyMetadata> list = ((CS_0024_003C_003E8__locals0.metadata is IEntityMetadata entityMetadata) ? entityMetadata.GetPropertiesAndTableParts().ToList() : CS_0024_003C_003E8__locals0.metadata.Properties.Cast<IPropertyMetadata>().ToList());
		IPropertyMetadata propertyMetadata = list.FirstOrDefault((IPropertyMetadata p) => p.Uid == _003C_003Ec__DisplayClass19_0.y6Yok3CfesL74FC3ZjqW(CS_0024_003C_003E8__locals0.metadata));
		if (propertyMetadata != null && CS_0024_003C_003E8__locals0.metadata.TitlePropertyUid != Guid.Empty && list.IndexOf(propertyMetadata) > 0)
		{
			list.Remove(propertyMetadata);
			list.Insert(0, propertyMetadata);
		}
		return (from p in list.Where(delegate(IPropertyMetadata p)
			{
				//Discarded unreachable code: IL_0052, IL_0061
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (CS_0024_003C_003E8__locals0.propertieFilter == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
							{
								num2 = 1;
							}
							break;
						}
						goto default;
					default:
						return CS_0024_003C_003E8__locals0.propertieFilter(p);
					case 1:
						return true;
					}
				}
			}).Select(delegate(IPropertyMetadata p)
			{
				PropertyViewSettings propertyViewSettings = ((p is PropertyMetadata) ? (p as PropertyMetadata).ViewSettings : null);
				if (propertyViewSettings == null)
				{
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_1();
					CS_0024_003C_003E8__locals0.tablePart = p as TablePartMetadata;
					if (CS_0024_003C_003E8__locals0.tablePart != null && CS_0024_003C_003E8__locals0.tablePart.IsActivePermissionMetadata() && CS_0024_003C_003E8__locals0.tablePart.Properties.FirstOrDefault((PropertyMetadata a) => _003C_003Ec__DisplayClass19_1.ol8SUUCf322F6mq5qPPh(a.Uid, CS_0024_003C_003E8__locals0.tablePart.ParentPropertyUid)) != null)
					{
						propertyViewSettings = CS_0024_003C_003E8__locals0.tablePart.Properties.FirstOrDefault((PropertyMetadata a) => _003C_003Ec__DisplayClass19_1.ol8SUUCf322F6mq5qPPh(_003C_003Ec__DisplayClass19_1.RHyfDdCfpsi0eBW9SrEx(a), CS_0024_003C_003E8__locals0.tablePart.ParentPropertyUid)).ViewSettings;
					}
				}
				ViewAttribute viewAttribute = propertyViewSettings?.GetForView(CS_0024_003C_003E8__locals0.viewType, CS_0024_003C_003E8__locals0.itemType);
				return new
				{
					Property = p,
					PropertyUid = p.PropertyUid,
					Visible = (viewAttribute?.Visible ?? true),
					ReadOnly = (CS_0024_003C_003E8__locals0._003C_003E4__this.ReadOnly || (viewAttribute?.ReadOnly ?? (CS_0024_003C_003E8__locals0.viewType == ViewType.Display)))
				};
			})
			where p.Visible && (CS_0024_003C_003E8__locals0.existsProperties == null || !CS_0024_003C_003E8__locals0.existsProperties.Contains(p.PropertyUid))
			select p).Select(p =>
		{
			PropertyViewItem propertyViewItem = new PropertyViewItem
			{
				Uid = p.PropertyUid,
				PropertyUid = p.PropertyUid,
				Parent = CS_0024_003C_003E8__locals0.parentViewItem,
				Attributes = 
				{
					ReadOnly = p.ReadOnly
				}
			};
			if (p.Property is ITablePartMetadata tablePartMetadata)
			{
				CS_0024_003C_003E8__locals0._003C_003E4__this.GetProperties((ClassMetadata)tablePartMetadata, CS_0024_003C_003E8__locals0.viewType, CS_0024_003C_003E8__locals0.itemType, CS_0024_003C_003E8__locals0.parentViewItem).Each(propertyViewItem.Items.Add);
			}
			return propertyViewItem;
		}).ToList();
	}

	public bool CheckOnlySystemProperties(ClassMetadata metadata, ViewType viewType)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = default(_003C_003Ec__DisplayClass20_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass20_.viewType = viewType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return MetadataLoader.GetBaseClassMetadataList(metadata, includeExtensions: true).Any(_003C_003Ec__DisplayClass20_._003CCheckOnlySystemProperties_003Eb__0);
			default:
				_003C_003Ec__DisplayClass20_._003C_003E4__this = this;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	private bool VisibleSystemProperties(ClassMetadata metadata, ViewType viewType)
	{
		//Discarded unreachable code: IL_0045, IL_004f, IL_005e
		int num = 3;
		int num2 = num;
		List<IPropertyMetadata> source;
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = default(_003C_003Ec__DisplayClass21_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				source = metadata.Properties.Cast<IPropertyMetadata>().ToList();
				break;
			case 3:
				_003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
				num2 = 2;
				continue;
			default:
				if (metadata is EntityMetadata)
				{
					num2 = 4;
					continue;
				}
				goto case 1;
			case 2:
				_003C_003Ec__DisplayClass21_.viewType = viewType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				source = ((EntityMetadata)metadata).GetPropertiesAndTableParts().ToList();
				break;
			}
			break;
		}
		return source.Where(_003C_003Ec__DisplayClass21_._003CVisibleSystemProperties_003Eb__0).Any();
	}

	public virtual IEnumerable<PropertyViewItem> NotIncludedProperies(FormViewItem formViewItem, ViewType viewType, ItemType itemType, object entity, RootViewItem parentViewItem)
	{
		_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.viewType = viewType;
		CS_0024_003C_003E8__locals0.itemType = itemType;
		CS_0024_003C_003E8__locals0.parentViewItem = parentViewItem;
		CS_0024_003C_003E8__locals0.formViewItem = formViewItem;
		CS_0024_003C_003E8__locals0.metadata = (CS_0024_003C_003E8__locals0.formViewItem.MetadataUid.HasValue ? (MetadataLoader.LoadMetadata(CS_0024_003C_003E8__locals0.formViewItem.MetadataUid.Value) as ClassMetadata) : null);
		if (CS_0024_003C_003E8__locals0.metadata == null)
		{
			return new PropertyViewItem[0];
		}
		string name = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x20247A05), CS_0024_003C_003E8__locals0.formViewItem.MetadataUid, CS_0024_003C_003E8__locals0.formViewItem.Uid, CS_0024_003C_003E8__locals0.viewType);
		return Locator.GetServiceNotNull<IContextBoundVariableService>().GetOrAdd(name, delegate
		{
			Func<IPropertyMetadata, bool> propertieFilter = null;
			if (CS_0024_003C_003E8__locals0._003C_003E4__this.OnlyUserProperties)
			{
				_003C_003Ec__DisplayClass22_1 _003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_1();
				_003C_003Ec__DisplayClass22_.mdRuntime = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				propertieFilter = delegate(IPropertyMetadata propertyMetadata)
				{
					//Discarded unreachable code: IL_00c5, IL_00d4
					int num = 8;
					TablePartMetadata tablePartMetadata = default(TablePartMetadata);
					_003C_003Ec__DisplayClass22_2 _003C_003Ec__DisplayClass22_2 = default(_003C_003Ec__DisplayClass22_2);
					EntityMetadata entityMetadata = default(EntityMetadata);
					while (true)
					{
						int num2 = num;
						while (true)
						{
							switch (num2)
							{
							case 8:
								goto end_IL_0012;
							case 2:
								return _003C_003Ec__DisplayClass22_1.I3EPftCfrXkebZbg6GF5(_003C_003Ec__DisplayClass22_1.tCMOcvCfl1Wc1USiOgxm(tablePartMetadata));
							case 3:
								if (_003C_003Ec__DisplayClass22_1.DfVrRsCfg5byxDWNHtar(_003C_003Ec__DisplayClass22_2.propertyMetadata) == null)
								{
									num2 = 4;
								}
								else
								{
									entityMetadata = MetadataLoader.LoadMetadata(_003C_003Ec__DisplayClass22_1.DfVrRsCfg5byxDWNHtar(_003C_003Ec__DisplayClass22_2.propertyMetadata)) as EntityMetadata;
									num2 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
									{
										num2 = 0;
									}
								}
								continue;
							case 1:
								if (tablePartMetadata == null)
								{
									num2 = 3;
									continue;
								}
								goto case 2;
							case 5:
								tablePartMetadata = _003C_003Ec__DisplayClass22_2.propertyMetadata as TablePartMetadata;
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
								{
									num2 = 1;
								}
								continue;
							case 9:
								if (entityMetadata.ImplementedExtensionUids != null)
								{
									num2 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
									{
										num2 = 4;
									}
									continue;
								}
								break;
							default:
								if (entityMetadata != null)
								{
									num2 = 9;
									continue;
								}
								break;
							case 7:
								_003C_003Ec__DisplayClass22_2.propertyMetadata = propertyMetadata;
								num2 = 5;
								continue;
							case 4:
								return false;
							case 6:
								return (from extensionUid in entityMetadata.ImplementedExtensionUids
									where _003C_003Ec.PoAFVMCQhLlwMmJSKIOI(extensionUid)
									select _003C_003Ec__DisplayClass22_.mdRuntime.GetTypeByUid(extensionUid, loadImplementation: false)).Any(_003C_003Ec__DisplayClass22_2._003CNotIncludedProperies_003Eb__5);
							}
							return false;
							continue;
							end_IL_0012:
							break;
						}
						_003C_003Ec__DisplayClass22_2 = new _003C_003Ec__DisplayClass22_2();
						num = 7;
					}
				};
			}
			return CS_0024_003C_003E8__locals0._003C_003E4__this.GetProperties(CS_0024_003C_003E8__locals0.metadata, CS_0024_003C_003E8__locals0.viewType, CS_0024_003C_003E8__locals0.itemType, CS_0024_003C_003E8__locals0.parentViewItem, propertieFilter, (from p in CS_0024_003C_003E8__locals0.formViewItem.GetAllItems(ignoreHide: false).OfType<PropertyViewItem>()
				select _003C_003Ec.IJr2w8CQGnhd7AFk60KF(p)).ToList());
		});
	}

	public virtual IEnumerable<PropertyViewItem> NotIncludedProperies(FormViewItem formViewItem, ViewType viewType, ItemType itemType, object entity)
	{
		return NotIncludedProperies(formViewItem, viewType, itemType, entity, null);
	}

	public virtual FormViewItemTransformation Transformation(FormViewItem formViewItem, ViewType viewType, ItemType itemType, object entity)
	{
		//Discarded unreachable code: IL_0089, IL_0098, IL_0207, IL_0216, IL_0291
		int num = 11;
		ColumnViewItem columnViewItem = default(ColumnViewItem);
		_003C_003Ec__DisplayClass24_1 _003C_003Ec__DisplayClass24_ = default(_003C_003Ec__DisplayClass24_1);
		ColumnViewItem item = default(ColumnViewItem);
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_2 = default(_003C_003Ec__DisplayClass24_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 25:
				{
					ColumnViewItem columnViewItem2 = new ColumnViewItem();
					hb1o7Do28n42pjQFt95i(columnViewItem2, FrR16Do2vDCQNavbMYEX());
					columnViewItem = columnViewItem2;
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				case 6:
					_003C_003Ec__DisplayClass24_.CS_0024_003C_003E8__locals1.transformation.Items.Add(ViewItemTransformation.Add(_003C_003Ec__DisplayClass24_.CS_0024_003C_003E8__locals1.parent, item));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					_003C_003Ec__DisplayClass24_.columns.Add(item);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 7;
					}
					continue;
				case 9:
					_003C_003Ec__DisplayClass24_2.prevItem = OSCm5xo2EnW3loUPiXVp(this);
					num2 = 8;
					continue;
				case 17:
				case 21:
					NotIncludedProperies(formViewItem, viewType, itemType, entity, base.Parent).Each(_003C_003Ec__DisplayClass24_2._003CTransformation_003Eb__0);
					num2 = 20;
					continue;
				case 11:
					_003C_003Ec__DisplayClass24_2 = new _003C_003Ec__DisplayClass24_0();
					num2 = 10;
					continue;
				case 4:
					return null;
				case 19:
					_003C_003Ec__DisplayClass24_2.parent = OSCm5xo2EnW3loUPiXVp(columnViewItem);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 23;
					}
					continue;
				case 16:
					if (!(base.Parent is ColumnsLayoutViewItem))
					{
						num2 = 2;
						continue;
					}
					goto case 5;
				case 3:
				case 20:
					return _003C_003Ec__DisplayClass24_2.transformation;
				case 22:
					_003C_003Ec__DisplayClass24_.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass24_2;
					num = 24;
					break;
				case 12:
					if (LIDhhco2CplrKN1HlohW(_003C_003Ec__DisplayClass24_.columns) == 0)
					{
						num2 = 15;
						continue;
					}
					goto case 14;
				case 23:
					_003C_003Ec__DisplayClass24_2.prevItem = null;
					num2 = 21;
					continue;
				case 1:
				case 2:
					if (base.Parent is ColumnViewItem)
					{
						num2 = 17;
						continue;
					}
					goto case 25;
				case 10:
					if (!uRYaISo2GlfRkh57IXnk(this))
					{
						_003C_003Ec__DisplayClass24_2.transformation = new FormViewItemTransformation();
						num2 = 18;
					}
					else
					{
						num2 = 4;
					}
					continue;
				case 18:
					_003C_003Ec__DisplayClass24_2.parent = OSCm5xo2EnW3loUPiXVp(base.Parent);
					num = 9;
					break;
				case 8:
					_003C_003Ec__DisplayClass24_2.transformation.Items.Add((ViewItemTransformation)it4F37o2fRII4TWMdAAt(Uid));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 16;
					}
					continue;
				case 5:
					_003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_1();
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 22;
					}
					continue;
				default:
					NotIncludedProperies(formViewItem, viewType, itemType, entity, base.Parent).Each(_003C_003Ec__DisplayClass24_._003CTransformation_003Eb__2);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 3;
					}
					continue;
				case 14:
					_003C_003Ec__DisplayClass24_.startColumnIndex = StartColumnIndex;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					_003C_003Ec__DisplayClass24_2.transformation.Items.Add(ViewItemTransformation.Add(_003C_003Ec__DisplayClass24_2.parent, columnViewItem, _003C_003Ec__DisplayClass24_2.prevItem));
					num2 = 19;
					continue;
				case 15:
					item = new ColumnViewItem
					{
						Uid = FrR16Do2vDCQNavbMYEX()
					};
					num2 = 6;
					continue;
				case 24:
					_003C_003Ec__DisplayClass24_.columns = ((IEnumerable<ViewItem>)Rjr8Eto2QUBWWZVKTwYW(base.Parent)).Where((ViewItem i) => !_003C_003Ec.wO996cCQEmuZrhjulmRl(i)).OfType<ColumnViewItem>().ToList();
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}

	public virtual bool CheckPropertyAdd(ClassMetadata metadata)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_00fe, IL_019c, IL_01ab, IL_01bc
		int num = 12;
		int num2 = num;
		Guid? metadataUid = default(Guid?);
		Guid guid = default(Guid);
		IMetadataService serviceOrNull = default(IMetadataService);
		while (true)
		{
			switch (num2)
			{
			case 10:
				return true;
			case 9:
				metadataUid = base.FormViewItem.MetadataUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				return true;
			case 4:
				guid = lu04HFo2ZpOC71v4julu(metadata);
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 1;
				}
				break;
			case 11:
				if (metadataUid.HasValue)
				{
					serviceOrNull = MetadataServiceContext.ServiceOrNull;
					num2 = 2;
					break;
				}
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 10;
				}
				break;
			case 8:
				return false;
			case 1:
			case 3:
				if (metadata != null)
				{
					num2 = 4;
					break;
				}
				goto case 8;
			case 2:
				if (serviceOrNull != null)
				{
					num2 = 3;
					break;
				}
				goto case 7;
			case 13:
				return true;
			case 5:
				metadata = serviceOrNull.GetMetadata(DhNT5Jo2IEIIkAjVoAEw(metadata)) as ClassMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 1;
				}
				break;
			default:
				if (metadataUid.HasValue)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 5;
			case 12:
				metadataUid = base.FormViewItem.MetadataUid;
				num2 = 11;
				break;
			case 6:
				if (AiFCdmo2uq6FdqxsT4Cb(guid, metadataUid.GetValueOrDefault()))
				{
					num2 = 13;
					break;
				}
				goto case 5;
			}
		}
	}

	public virtual PropertyViewItem CreatePropertyViewItem()
	{
		return new PropertyViewItem();
	}

	public DefaultContainerViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static DefaultContainerViewItem()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				YS0TxHo2VotWaipJf47a();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				ItemUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307CFF23));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool afmXPWo2bRTqFjmmgDCB()
	{
		return tVYkIao2obZffZfq2TZM == null;
	}

	internal static DefaultContainerViewItem gD0iJjo2hZ3UbCcjScJB()
	{
		return tVYkIao2obZffZfq2TZM;
	}

	internal static bool uRYaISo2GlfRkh57IXnk(object P_0)
	{
		return ((ViewItem)P_0).Hide;
	}

	internal static Guid OSCm5xo2EnW3loUPiXVp(object P_0)
	{
		return ((ViewItem)P_0).Uid;
	}

	internal static object it4F37o2fRII4TWMdAAt(Guid itemUid)
	{
		return ViewItemTransformation.Hide(itemUid);
	}

	internal static object Rjr8Eto2QUBWWZVKTwYW(object P_0)
	{
		return ((RootViewItem)P_0).Items;
	}

	internal static int LIDhhco2CplrKN1HlohW(object P_0)
	{
		return ((List<ColumnViewItem>)P_0).Count;
	}

	internal static Guid FrR16Do2vDCQNavbMYEX()
	{
		return Guid.NewGuid();
	}

	internal static void hb1o7Do28n42pjQFt95i(object P_0, Guid value)
	{
		((ViewItem)P_0).Uid = value;
	}

	internal static Guid lu04HFo2ZpOC71v4julu(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool AiFCdmo2uq6FdqxsT4Cb(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid DhNT5Jo2IEIIkAjVoAEw(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static void YS0TxHo2VotWaipJf47a()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
