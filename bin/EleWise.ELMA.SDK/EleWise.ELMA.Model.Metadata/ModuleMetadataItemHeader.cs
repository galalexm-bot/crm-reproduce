using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[TitleProperty("45ad4dc9-7401-4a57-8a8d-0c55759df61c")]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
[CustomCode(typeof(ModuleMetadataItemHeader), "EleWise.ELMA.Model.Metadata.ModuleMetadataItemHeader.CustomCodeTemplate.cs")]
[Uid("58dcab94-c60f-491c-8b91-5275e5576ad1")]
[DisplayName("SR.M('Заголовок метаданных модуля')")]
[DisplayFormat(null)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[MetadataType(typeof(EntityMetadata))]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>018d9e87-6901-4f74-8d39-4fa99af52a3d</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ModuleMetadataItemHeader")]
public class ModuleMetadataItemHeader : Entity<long>, ISoftDeletable
{
	public const string UID_S = "58dcab94-c60f-491c-8b91-5275e5576ad1";

	internal static Guid _UID;

	private Guid _uid;

	private string _name;

	private DateTime _creationDate;

	private string _displayName;

	private long? _creationAuthorId;

	private string _description;

	private bool _isDeleted;

	private ModuleMetadataItem _published;

	private ModuleMetadataItem _draft;

	internal static ModuleMetadataItemHeader A4hWBLbN7dmX8XmAyxsU;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public static Guid UID => _UID;

	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[NotNull]
	[Uid("4ab139a2-991d-4ef3-bf27-4a4e5a139fe2")]
	[GuidSettings(FieldName = "Uid")]
	[EntityProperty]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[DisplayName("SR.M('UID')")]
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
				case 1:
					_uid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
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

	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[EntityProperty]
	[Filterable]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "512", FieldName = "Name")]
	[Required(true)]
	[Uid("45ad4dc9-7401-4a57-8a8d-0c55759df61c")]
	[Order(1)]
	[RequiredField]
	[DisplayName("SR.M('Наименование')")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[StringRangeLength(0, "512")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[Uid("9f3eff0e-c8ff-4aa6-835c-daca21d91040")]
	[NotNull]
	[Order(4)]
	[DisplayName("SR.M('Дата создания')")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
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
				case 0:
					return;
				case 1:
					_creationDate = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Order(2)]
	[Uid("e2036e69-87d7-4ad8-881d-21d16883c424")]
	[EntityProperty]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[StringSettings(FieldName = "DisplayName")]
	[DisplayName("SR.M('Отображаемое имя')")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Int64Settings(FieldName = "CreationAuthorId")]
	[Uid("dc33ae3b-f44e-4d01-8f7e-7562ed2ad914")]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[DisplayName("SR.M('Идентификатор автора создания')")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[CanBeNull]
	[Order(5)]
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

	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("03edae85-8e71-46a1-bf8c-a4775755952d")]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName("SR.M('Описание')")]
	[StringSettings(FieldName = "Description")]
	[Order(3)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	public virtual string Description
	{
		get
		{
			return _description;
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
					_description = value;
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

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[BoolSettings(FieldName = "IsDeleted")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[DisplayName("SR.M('Удален')")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[NotNull]
	[Order(8)]
	[Uid("e5e95598-d738-42da-b25f-a0eb059484b8")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "13937373-6487-40c1-ae91-ecbbf0706ce9")]
	[Order(7)]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Published")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("7c190302-c237-4350-a170-278fefe5ec12")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Опубликованная версия')")]
	[EntityProperty]
	public virtual ModuleMetadataItem Published
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
				case 0:
					return;
				case 1:
					_published = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName("SR.M('Черновик')")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Draft")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("8019f9c4-5497-401d-a10c-c296a69204ce")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "13937373-6487-40c1-ae91-ecbbf0706ce9")]
	[Order(6)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	public virtual ModuleMetadataItem Draft
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
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

	public ModuleMetadataItemHeader()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		l5NtSWbNmR9HowmFQij8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
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
			_creationDate = DateTime.Now;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
			{
				num = 1;
			}
		}
	}

	public override string ToString()
	{
		return Name;
	}

	static ModuleMetadataItemHeader()
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
				_UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824461527));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				l5NtSWbNmR9HowmFQij8();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool GmF8G2bNxY1uHMlodEK5()
	{
		return A4hWBLbN7dmX8XmAyxsU == null;
	}

	internal static ModuleMetadataItemHeader vpjX2dbN0PCGWPpFyDZB()
	{
		return A4hWBLbN7dmX8XmAyxsU;
	}

	internal static void l5NtSWbNmR9HowmFQij8()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
