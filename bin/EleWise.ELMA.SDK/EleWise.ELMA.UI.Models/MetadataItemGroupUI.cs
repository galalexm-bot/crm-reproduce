using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Models;

[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>d68e41c4-aa8a-441b-8c6c-069026b1809b</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("MetadataItemGroupUI")]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
[CustomCode(typeof(MetadataItemGroupUI), "EleWise.ELMA.UI.Models.MetadataItemGroupUI.CustomCodeTemplate.cs")]
[MetadataType(typeof(EntityMetadata))]
[Uid("73efc2ea-167d-45e8-ac21-ed3b77ab9a2b")]
[DisplayFormat(null)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[TitleProperty("35190fb9-6737-4b28-8a7d-6425f70e1dda")]
[ShowInCatalogList(false)]
[DisplayName("SR.M('Группа элементов метаданных компонентов')")]
public class MetadataItemGroupUI : Entity<long>, ISoftDeletable
{
	public const string UID_S = "73efc2ea-167d-45e8-ac21-ed3b77ab9a2b";

	internal static Guid _UID;

	private Guid _uid;

	private string _name;

	private Guid _metadataTypeUid;

	private Guid _moduleUid;

	private MetadataItemGroupUI _parent;

	private ISet<MetadataItemGroupUI> _groups;

	private bool _isDeleted;

	private string _displayName;

	private static MetadataItemGroupUI jRD4XHBWNYvKCugYYWm7;

	public static Guid UID => _UID;

	[DisplayName("SR.M('Уникальный идентификатор')")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	[GuidSettings(FieldName = "Uid")]
	[NotNull]
	[Uid("cbaf796d-4b0a-48c9-81a2-6a6a0f7bc99b")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[SystemProperty]
	public virtual Guid Uid
	{
		get
		{
			return _uid;
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
					_uid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Order(1)]
	[Uid("35190fb9-6737-4b28-8a7d-6425f70e1dda")]
	[DisplayName("SR.M('Наименование')")]
	[StringRangeLength(0, "2000")]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[RequiredField]
	public virtual string Name
	{
		get
		{
			return _name;
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
				case 1:
					_name = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
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

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Required(true)]
	[Uid("cf9c798e-88d2-4d45-960d-41ac6facd188")]
	[Order(2)]
	[NotNull]
	[DisplayName("SR.M('Тип компонента')")]
	[RequiredField]
	[GuidSettings(DefaultValueStr = "66457ad6-ce6e-4cd5-ae3a-d46dc83a0e85", FieldName = "MetadataTypeUid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	public virtual Guid MetadataTypeUid
	{
		get
		{
			return _metadataTypeUid;
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
				case 1:
					_metadataTypeUid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
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

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[GuidSettings(FieldName = "ModuleUid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[Order(3)]
	[DisplayName("SR.M('Уникальный идентификатор модуля')")]
	[NotNull]
	[Uid("3e2a51d6-7959-439b-a94f-86756de2396f")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	public virtual Guid ModuleUid
	{
		get
		{
			return _moduleUid;
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
				case 1:
					_moduleUid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
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

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName("SR.M('Родительская группа')")]
	[Uid("75b0ae38-3cce-4421-9708-69853c20e065")]
	[EntityProperty]
	[Order(4)]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Parent")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "73efc2ea-167d-45e8-ac21-ed3b77ab9a2b")]
	public virtual MetadataItemGroupUI Parent
	{
		get
		{
			return _parent;
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
					_parent = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(5)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "73efc2ea-167d-45e8-ac21-ed3b77ab9a2b")]
	[Uid("e556d7b5-b042-4f4d-912a-7fac1be34b91")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "75b0ae38-3cce-4421-9708-69853c20e065", CascadeMode = CascadeMode.SaveUpdate)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Дочерние группы')")]
	public virtual ISet<MetadataItemGroupUI> Groups
	{
		get
		{
			return _groups;
		}
		set
		{
			_groups = value;
		}
	}

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName("SR.M('Удален')")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[Order(6)]
	[Uid("7fe38a47-5ed7-4e53-a9c1-9c1de5ab5682")]
	[NotNull]
	[BoolSettings(FieldName = "IsDeleted")]
	public virtual bool IsDeleted
	{
		get
		{
			return _isDeleted;
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
					_isDeleted = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName("SR.M('Отображаемое имя')")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Order(7)]
	[Uid("de247a4d-3213-4d69-b62f-2bdd9f871dfb")]
	[StringSettings(FieldName = "DisplayName")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	public virtual string DisplayName
	{
		get
		{
			return _displayName;
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
					_displayName = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual bool HardDelete
	{
		[CompilerGenerated]
		get
		{
			return _003CHardDelete_003Ek__BackingField;
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
					_003CHardDelete_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public MetadataItemGroupUI()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				_groups = (ISet<MetadataItemGroupUI>)(object)new HashedSet<MetadataItemGroupUI>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				_metadataTypeUid = new Guid((string)NT3aUmBWa1VximeBUcuB(-1876063057 ^ -1876072021));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public override string ToString()
	{
		return (string)b1mGkABWDtejeC38L3oo(this);
	}

	static MetadataItemGroupUI()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				_UID = new Guid((string)NT3aUmBWa1VximeBUcuB(0x63ABA4E8 ^ 0x63AB4174));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				wT2DMQBWtdLsKgJoqjWx();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object NT3aUmBWa1VximeBUcuB(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool c24iZ3BW3VTkGL6DdIG4()
	{
		return jRD4XHBWNYvKCugYYWm7 == null;
	}

	internal static MetadataItemGroupUI z5sxNsBWpFodPiJimJhx()
	{
		return jRD4XHBWNYvKCugYYWm7;
	}

	internal static object b1mGkABWDtejeC38L3oo(object P_0)
	{
		return ((MetadataItemGroupUI)P_0).Name;
	}

	internal static void wT2DMQBWtdLsKgJoqjWx()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
