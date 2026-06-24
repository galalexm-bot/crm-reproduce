using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Uid("28d9194c-c187-4cd3-acae-36644c0cbbb5")]
[DisplayName(typeof(__Resources_DataClassMetadataItem), "DisplayName")]
[MetadataType(typeof(EntityMetadata))]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[DisplayFormat(null)]
[Filterable]
[FilterType(typeof(DataClassMetadataItemFilter))]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>ffaf2bb7-5f3a-4e1c-a26e-6ae3c3ed2d87</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("DataClassMetadataItem")]
public class DataClassMetadataItem : Entity<long>
{
	public const string UID_S = "28d9194c-c187-4cd3-acae-36644c0cbbb5";

	private static Guid _UID;

	private Guid _uid;

	private DateTime _creationDate;

	private long? _creationAuthorId;

	private object _metadata;

	private DataClassMetadataItemHeader _header;

	private string _comment;

	private byte[] _assemblyRaw;

	private byte[] _debugRaw;

	private byte[] _documentationRaw;

	private string _assemblyName;

	private string _assemblyVersion;

	private byte[] _clientAssemblyRaw;

	private long? _versionNumber;

	private static DataClassMetadataItem utNACpb3jWhhXfiY1PYu;

	public static Guid UID => _UID;

	[NotNull]
	[SystemProperty]
	[EntityProperty]
	[Uid("8e58e7b1-d578-4965-8c8f-e75638dbff14")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[DisplayName(typeof(__Resources_DataClassMetadataItem), "P_Uid_DisplayName")]
	[GuidSettings(FieldName = "Uid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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

	[Required(true)]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[NotNull]
	[Uid("4c3339a7-93e5-4862-a1b5-2e0ac63cc3e3")]
	[Order(1)]
	[DisplayName(typeof(__Resources_DataClassMetadataItem), "P_CreationDate_DisplayName")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
	[RequiredField]
	[EntityProperty]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[Filterable]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EntityProperty]
	[CanBeNull]
	[Uid("9d566e43-feb2-482b-b8c1-0eea00e189ee")]
	[DisplayName(typeof(__Resources_DataClassMetadataItem), "P_CreationAuthorId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "CreationAuthorId")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(2)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
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

	[Description(typeof(__Resources_DataClassMetadataItem), "P_Metadata_Description")]
	[DisplayName(typeof(__Resources_DataClassMetadataItem), "P_Metadata_DisplayName")]
	[EntityProperty]
	[Order(3)]
	[Uid("8946cae6-a5c2-4a01-a077-7cc31e27b13b")]
	[Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
	[XmlSerializableObjectSettings(FieldName = "Metadata")]
	public virtual object Metadata
	{
		get
		{
			return _metadata;
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
					_metadata = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Uid("141cf1a3-da06-4cae-b4b8-9c8db42b77a4")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "85a8928f-0ee2-48aa-8340-db98eb1011eb")]
	[Order(4)]
	[EntitySettings(CascadeMode = CascadeMode.All, FieldName = "Header")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_DataClassMetadataItem), "P_Header_DisplayName")]
	public virtual DataClassMetadataItemHeader Header
	{
		get
		{
			return _header;
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
					_header = value;
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

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Description(typeof(__Resources_DataClassMetadataItem), "P_Comment_Description")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Order(5)]
	[Uid("cfd79856-a75d-4bd3-807d-769b1fdbf445")]
	[DisplayName(typeof(__Resources_DataClassMetadataItem), "P_Comment_DisplayName")]
	[StringRangeLength(0, "1000")]
	[StringSettings(MaxValueString = "1000", MultiLine = true, FieldName = "Comment")]
	public virtual string Comment
	{
		get
		{
			return _comment;
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
					_comment = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
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
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[Order(6)]
	[Uid("775a2d41-b821-4ada-afa1-c23db2d80c84")]
	[BlobSettings(FieldName = "AssemblyRaw")]
	[DisplayName(typeof(__Resources_DataClassMetadataItem), "P_AssemblyRaw_DisplayName")]
	public virtual byte[] AssemblyRaw
	{
		get
		{
			return _assemblyRaw;
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
					_assemblyRaw = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_DataClassMetadataItem), "P_DebugRaw_DisplayName")]
	[Order(7)]
	[Uid("6a6e3177-550d-479a-aa27-ffb173dac160")]
	[BlobSettings(FieldName = "DebugRaw")]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	public virtual byte[] DebugRaw
	{
		get
		{
			return _debugRaw;
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
					_debugRaw = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
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
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_DataClassMetadataItem), "P_DocumentationRaw_DisplayName")]
	[Order(8)]
	[Uid("1637827a-1e94-48f2-a4c7-ef69aa519182")]
	[BlobSettings(FieldName = "DocumentationRaw")]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	public virtual byte[] DocumentationRaw
	{
		get
		{
			return _documentationRaw;
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
					_documentationRaw = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(__Resources_DataClassMetadataItem), "P_AssemblyName_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[StringRangeLength(0, "200")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "200", FieldName = "AssemblyName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[Order(10)]
	[Filterable]
	[Uid("5b91ca93-8145-437e-84d2-d7d2e90b28c8")]
	public virtual string AssemblyName
	{
		get
		{
			return _assemblyName;
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
					_assemblyName = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
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

	[Uid("50771a21-c114-4399-8f28-4736f711dba2")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[Filterable]
	[Order(11)]
	[StringSettings(MaxValueString = "40", FieldName = "AssemblyVersion")]
	[DisplayName(typeof(__Resources_DataClassMetadataItem), "P_AssemblyVersion_DisplayName")]
	[StringRangeLength(0, "40")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	public virtual string AssemblyVersion
	{
		get
		{
			return _assemblyVersion;
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
					_assemblyVersion = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
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

	[Uid("6175a85f-6e3b-482c-8ca6-fbee8d3b827a")]
	[Order(9)]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[BlobSettings(FieldName = "ClientAssemblyRaw")]
	[DisplayName(typeof(__Resources_DataClassMetadataItem), "P_ClientAssemblyRaw_DisplayName")]
	public virtual byte[] ClientAssemblyRaw
	{
		get
		{
			return _clientAssemblyRaw;
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
					_clientAssemblyRaw = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
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

	[Uid("e0014785-70c4-4364-b65e-4a6bb0e5afb5")]
	[CanBeNull]
	[Order(12)]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "VersionNumber")]
	[DisplayName(typeof(__Resources_DataClassMetadataItem), "P_VersionNumber_DisplayName")]
	public virtual long? VersionNumber
	{
		get
		{
			return _versionNumber;
		}
		set
		{
			_versionNumber = value;
		}
	}

	public DataClassMetadataItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CpymDkb3UROeZXBKwfKm();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				_creationDate = XOSFRob3s4mhjFHFt2je();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	static DataClassMetadataItem()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				_UID = new Guid((string)Q1M8WPb3cDf9j9B4xJGj(0x3630F361 ^ 0x36321ACD));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void CpymDkb3UROeZXBKwfKm()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static DateTime XOSFRob3s4mhjFHFt2je()
	{
		return DateTime.Now;
	}

	internal static bool O0MU58b3Y3q43FWdHcJl()
	{
		return utNACpb3jWhhXfiY1PYu == null;
	}

	internal static DataClassMetadataItem IRI67tb3L3RUAlcsq8qb()
	{
		return utNACpb3jWhhXfiY1PYu;
	}

	internal static object Q1M8WPb3cDf9j9B4xJGj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
