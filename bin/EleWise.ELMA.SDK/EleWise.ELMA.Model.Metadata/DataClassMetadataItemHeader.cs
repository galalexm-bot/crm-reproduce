using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[DisplayName("SR.M('Заголовок элемента метаданных датакласса')")]
[Uid("85a8928f-0ee2-48aa-8340-db98eb1011eb")]
[CustomCode(typeof(DataClassMetadataItemHeader), "EleWise.ELMA.Model.Metadata.DataClassMetadataItemHeader.CustomCodeTemplate.cs")]
[DisplayFormat(null)]
[Entity("DataClassMetadataItemHeader")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>06ab7a23-4831-49a3-a5b5-a51da26cb89d</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[TitleProperty("f968532d-e316-4fb9-9bab-8202e5bebd8f")]
[ShowInCatalogList(false)]
[MetadataType(typeof(EntityMetadata))]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
public class DataClassMetadataItemHeader : Entity<long>, ISoftDeletable
{
	public const string UID_S = "85a8928f-0ee2-48aa-8340-db98eb1011eb";

	private static Guid _UID;

	private Guid _uid;

	private string _name;

	private string _displayName;

	private DateTime _creationDate;

	private long? _creationAuthorId;

	private DataClassMetadataItem _draft;

	private DataClassMetadataItem _published;

	private Guid _moduleUid;

	private bool _isDeleted;

	private bool _isDirtyItem;

	private MetadataItemGroupUI _group;

	private static DataClassMetadataItemHeader umQpFobNWqii6RC5SuGM;

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
				case 1:
					_003CHardDelete_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
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

	public static Guid UID => _UID;

	[NotNull]
	[Uid("876e0716-0aa2-4447-9da7-2a074219078a")]
	[EntityProperty]
	[SystemProperty]
	[GuidSettings(FieldName = "Uid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[DisplayName("SR.M('Уникальный идентификатор')")]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[StringRangeLength(0, "100")]
	[DisplayName("SR.M('Наименование')")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[StringSettings(MaxValueString = "100", FieldName = "Name")]
	[Filterable]
	[FastSearch(true)]
	[Uid("f968532d-e316-4fb9-9bab-8202e5bebd8f")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Order(1)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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
				case 0:
					return;
				case 1:
					_name = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[DisplayName("SR.M('Отображаемое имя')")]
	[StringRangeLength(0, "100")]
	[Order(2)]
	[StringSettings(MaxValueString = "100", FieldName = "DisplayName")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Uid("b5762fe4-fd52-43a4-9d70-987e2b372259")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
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
				case 1:
					_displayName = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
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

	[Order(3)]
	[NotNull]
	[Uid("9f60e2e8-c940-4e4b-9742-a3892823d36d")]
	[Filterable]
	[Required(true)]
	[EntityProperty]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[DisplayName("SR.M('Дата создания')")]
	[RequiredField]
	public virtual DateTime CreationDate
	{
		get
		{
			return _creationDate;
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
					_creationDate = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
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
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName("SR.M('Идентификатор автора создания')")]
	[CanBeNull]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("be8b4235-828e-4f1d-a85f-7612082ab5e2")]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Order(4)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[Int64Settings(FieldName = "CreationAuthorId")]
	public virtual long? CreationAuthorId
	{
		get
		{
			return _creationAuthorId;
		}
		set
		{
			_creationAuthorId = value;
		}
	}

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Черновик')")]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Uid("72c61acf-c559-48fb-acc2-e5fa581e26ee")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(5)]
	[EntitySettings(FieldName = "Draft")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "28d9194c-c187-4cd3-acae-36644c0cbbb5")]
	public virtual DataClassMetadataItem Draft
	{
		get
		{
			return _draft;
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
					_draft = value;
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

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(6)]
	[Uid("0c45128c-f588-4660-af21-8b19a7f6f732")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "28d9194c-c187-4cd3-acae-36644c0cbbb5")]
	[DisplayName("SR.M('Опубликованная версия')")]
	[EntitySettings(FieldName = "Published")]
	public virtual DataClassMetadataItem Published
	{
		get
		{
			return _published;
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
					_published = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
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
	[DisplayName("SR.M('Уникальный идентификатор модуля')")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("f654a04f-c686-4122-8741-5440da334d76")]
	[NotNull]
	[Order(7)]
	[GuidSettings(FieldName = "ModuleUid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
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
				case 0:
					return;
				case 1:
					_moduleUid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Order(8)]
	[BoolSettings(FieldName = "IsDeleted")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[NotNull]
	[DisplayName("SR.M('Удален')")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("dd499eab-4cab-483e-ba4f-203ae68cec6d")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Uid("bf9341ed-5e9e-49a2-af4a-833cced9c047")]
	[Order(9)]
	[BoolSettings(FieldName = "IsDirtyItem")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[NotNull]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Есть неопубликованные изменения')")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	public virtual bool IsDirtyItem
	{
		get
		{
			return _isDirtyItem;
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
					_isDirtyItem = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "73efc2ea-167d-45e8-ac21-ed3b77ab9a2b")]
	[Order(10)]
	[Uid("a6dd2738-8966-4ff5-b2c4-3de5fe6005de")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Группа')")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Group")]
	public virtual MetadataItemGroupUI Group
	{
		get
		{
			return _group;
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
					_group = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DataClassMetadataItemHeader()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PJiuTPbNhqOoZhyi4kQF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
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
			_creationDate = Ei3d1PbNGmZm4HHnj3T9();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
			{
				num = 1;
			}
		}
	}

	public override string ToString()
	{
		return (string)oXYQQsbNEAW5uOlyHhNy(this);
	}

	static DataClassMetadataItemHeader()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				PJiuTPbNhqOoZhyi4kQF();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_UID = new Guid((string)LAg7RobNftEuCuXEADkC(0x68BBB53E ^ 0x68B95322));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool qaxRlEbNoUqNPmokw3SJ()
	{
		return umQpFobNWqii6RC5SuGM == null;
	}

	internal static DataClassMetadataItemHeader ubbPdPbNbX8ReNLNrgcY()
	{
		return umQpFobNWqii6RC5SuGM;
	}

	internal static void PJiuTPbNhqOoZhyi4kQF()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static DateTime Ei3d1PbNGmZm4HHnj3T9()
	{
		return DateTime.Now;
	}

	internal static object oXYQQsbNEAW5uOlyHhNy(object P_0)
	{
		return ((DataClassMetadataItemHeader)P_0).Name;
	}

	internal static object LAg7RobNftEuCuXEADkC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
