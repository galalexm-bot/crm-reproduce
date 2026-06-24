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

[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>2d179eea-4974-4ba6-afb1-8a05dd299284</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[DisplayFormat(null)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Entity("ModuleMetadataItem")]
[Uid("13937373-6487-40c1-ae91-ecbbf0706ce9")]
[MetadataType(typeof(EntityMetadata))]
[DisplayName("SR.M('Элемент метаданных модуля')")]
[ShowInCatalogList(false)]
public class ModuleMetadataItem : Entity<long>
{
	public const string UID_S = "13937373-6487-40c1-ae91-ecbbf0706ce9";

	private static Guid _UID;

	private Guid _uid;

	private DateTime _creationDate;

	private long? _creationAuthorId;

	private ModuleMetadataItemHeader _header;

	private string _comment;

	private object _metadata;

	private byte[] _assemblyRaw;

	private byte[] _clientAssemblyRaw;

	private byte[] _debugRaw;

	private byte[] _clientDebugRaw;

	private string _version;

	private string _assemblyName;

	private byte[] _clientRaw;

	private object _signature;

	internal static ModuleMetadataItem Mu3bslbpLqGsHx3yCYfE;

	public static Guid UID => _UID;

	[EntityProperty]
	[Uid("8d4fde4f-5a89-4197-91e0-a17a7866de5c")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[SystemProperty]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[DisplayName("SR.M('UID')")]
	[GuidSettings(FieldName = "Uid")]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
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

	[EntityProperty]
	[Filterable]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[NotNull]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("39515524-4b7c-4686-8020-48ba420c1e62")]
	[Order(1)]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName("SR.M('Дата создания')")]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
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

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[CanBeNull]
	[Uid("5da89232-9a3a-45d4-ad4d-74fb4209a70a")]
	[Order(2)]
	[Int64Settings(FieldName = "CreationAuthorId")]
	[DisplayName("SR.M('Идентификатор автора создания')")]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
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

	[DisplayName("SR.M('Заголовок')")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Order(3)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "58dcab94-c60f-491c-8b91-5275e5576ad1")]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("c25125de-bd15-4d86-b698-e47782819678")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Header")]
	public virtual ModuleMetadataItemHeader Header
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
				case 1:
					_header = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
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

	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Комментарий')")]
	[TextSettings(FieldName = "Comment")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Property("317e3d72-9c47-4b68-926d-ba77a2579bc2")]
	[Order(4)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("3fc9c15c-73d7-4c1a-8d6b-5a590c5904cd")]
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
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("51f0f1e6-31df-41d8-ab5d-b74319f2cdcc")]
	[DisplayName("SR.M('Метаданные')")]
	[XmlSerializableObjectSettings(FieldName = "Metadata")]
	[Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(5)]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName("SR.M('Серверная сборка модуля')")]
	[EntityProperty]
	[Order(6)]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[BlobSettings(FieldName = "AssemblyRaw")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("66bab740-acb1-4969-bec1-077395c53d25")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(7)]
	[Uid("98a7dee6-f4e4-42d8-ae57-579b69f67f86")]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[BlobSettings(FieldName = "ClientAssemblyRaw")]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Клиентская сборка модуля')")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
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
	[DisplayName("SR.M('Отладочная информация')")]
	[Description("SR.M('Отладочные данные для серверной сборки модуля')")]
	[BlobSettings(FieldName = "DebugRaw")]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(8)]
	[Uid("4a4c150d-0b8a-404f-bc58-4099f97b19a6")]
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
				case 0:
					return;
				case 1:
					_debugRaw = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(9)]
	[BlobSettings(FieldName = "ClientDebugRaw")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName("SR.M('Клиентская отладочная информация')")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Description("SR.M('Отладочные данные для клиентской сборки модуля')")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("31980e24-23ff-46ab-834c-1d0da0251c9d")]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[EntityProperty]
	public virtual byte[] ClientDebugRaw
	{
		get
		{
			return _clientDebugRaw;
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
					_clientDebugRaw = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
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

	[StringSettings(MaxValueString = "50", FieldName = "Version")]
	[Description("SR.M('Версия модуля и его сборок в формате major.minor[.build[.revision]]')")]
	[DisplayName("SR.M('Версия')")]
	[StringRangeLength(0, "50")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(10)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("9c9f94d1-f3be-43f0-b010-feec6d8a03eb")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	public virtual string Version
	{
		get
		{
			return _version;
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
					_version = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Order(11)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName("SR.M('Имя сборки')")]
	[Uid("1471326b-b351-405c-954a-c940685114bc")]
	[EntityProperty]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringRangeLength(0, "200")]
	[StringSettings(MaxValueString = "200", FieldName = "AssemblyName")]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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

	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[BlobSettings(FieldName = "ClientRaw")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(12)]
	[DisplayName("SR.M('Клиентская сборка')")]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("024e3844-ccdd-42ee-a4ed-0b03fb1d2dd2")]
	public virtual byte[] ClientRaw
	{
		get
		{
			return _clientRaw;
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
					_clientRaw = value;
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

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
	[XmlSerializableObjectSettings(FieldName = "Signature")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Сигнатура')")]
	[Order(13)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("d822290b-9884-46f5-8b67-17761963cf17")]
	[Description("SR.M('Публичная сигнатура модуля')")]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	public virtual object Signature
	{
		get
		{
			return _signature;
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
					_signature = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ModuleMetadataItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lD3sL2bpcgenPtMcOF98();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				_creationDate = NDGe5Sbpz5jM3wtPyIIa();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	static ModuleMetadataItem()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				_UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87443205));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void lD3sL2bpcgenPtMcOF98()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static DateTime NDGe5Sbpz5jM3wtPyIIa()
	{
		return DateTime.Now;
	}

	internal static bool AGsLD3bpU85QmQDNIt6p()
	{
		return Mu3bslbpLqGsHx3yCYfE == null;
	}

	internal static ModuleMetadataItem wYJXBTbpsS4GMbrdhNwh()
	{
		return Mu3bslbpLqGsHx3yCYfE;
	}
}
