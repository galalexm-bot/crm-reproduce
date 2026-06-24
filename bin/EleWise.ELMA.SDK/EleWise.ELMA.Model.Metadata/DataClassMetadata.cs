using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Deploy.Attributes;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[XmlExport]
[DataContract]
[Uid("{6F1B7544-AA48-4820-823C-3579B8AF0A22}")]
public class DataClassMetadata : ClassMetadata
{
	[Component]
	private class Info : IMetadataTypeInfo
	{
		internal static object qXJ5lGCDt1Xc6QAQvvMV;

		public string Name => (string)jUmsUcCDHHvMFoG1LvOZ(SrKBoSCD6XiI88Ko7HaP(-1858887263 ^ -1858728763));

		public string Description => (string)jUmsUcCDHHvMFoG1LvOZ(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -489034065));

		public Type MetadataType => typeof(DataClassMetadata);

		public Type GeneratorType => typeof(DataClassGenerator);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object SrKBoSCD6XiI88Ko7HaP(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object jUmsUcCDHHvMFoG1LvOZ(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool es06DtCDwK8MvUEh6b2f()
		{
			return qXJ5lGCDt1Xc6QAQvvMV == null;
		}

		internal static Info jE8GnECD4Pb9vusPjNZK()
		{
			return (Info)qXJ5lGCDt1Xc6QAQvvMV;
		}
	}

	public const string UID_S = "{6F1B7544-AA48-4820-823C-3579B8AF0A22}";

	public static readonly Guid UID;

	public const string DefaultNamespace = "EleWise.ELMA.DataClasses";

	[XmlIgnore]
	internal bool? isInterfaceType;

	private string[] dataClassInterfaces;

	internal static DataClassMetadata vw3Mx6baI7DI3hUKa240;

	[XmlForceElement]
	[Obsolete("TODO: ELMA-29857 Убрать после выноса EleWise.ELMA.SDK.DTO", false)]
	public string TypeRef
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeRef_003Ek__BackingField;
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
					_003CTypeRef_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<DataClassDependency> IncludeList { get; set; }

	public TypeToMap TypeToMap
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeToMap_003Ek__BackingField;
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
					_003CTypeToMap_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
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

	public override bool IsInterfaceType
	{
		get
		{
			int num = 1;
			int num2 = num;
			bool? flag = default(bool?);
			while (true)
			{
				switch (num2)
				{
				case 1:
					flag = isInterfaceType;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return false;
				}
				if (!flag.HasValue)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				return flag.GetValueOrDefault();
			}
		}
	}

	public DataClassMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		iDimprbaihsfM9YHdSbA();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
		{
			num = 0;
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
				IncludeList = new List<DataClassDependency>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public DataClassMetadata(Guid moduleUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		iDimprbaihsfM9YHdSbA();
		this._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				Internal = moduleUid != Guid.Empty;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num = 1;
				}
				break;
			default:
				BHyZohbaRMH78bV4CVbL(this, moduleUid);
				num = 2;
				break;
			}
		}
	}

	public override bool IsRestartNeeded(IRootMetadata metadata)
	{
		return false;
	}

	public override void InitNew()
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
				du6NUmbaKs77cRCMlRLL(this, EvncrgbaqidZMoMogS35(-289714582 ^ -289775962));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				TableViews.Add((TableView)CpDwEobaXohsd0UlV7ee(this));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				base.InitNew();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override void LoadFromType(Type type, bool inherit = true)
	{
		//Discarded unreachable code: IL_0099, IL_0148, IL_01ad, IL_0210, IL_027d
		int num = 17;
		string text2 = default(string);
		EntityMetadataUidAttribute attribute2 = default(EntityMetadataUidAttribute);
		object obj = default(object);
		Type type2 = default(Type);
		string text = default(string);
		int num3 = default(int);
		IEnumerable<string> collection = default(IEnumerable<string>);
		UidAttribute attribute = default(UidAttribute);
		object[] array = default(object[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 12:
					text2 = (string)m3OKodbaOHKOrJLoC9gc();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					if (attribute2 != null)
					{
						num2 = 6;
						continue;
					}
					base.LoadFromType(type, inherit);
					num2 = 3;
					continue;
				case 15:
					ProcessDataClassFormAttribute(obj, type2);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 8;
					}
					continue;
				case 20:
					if (type2.FullName == text2)
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 2;
				case 14:
					if (j7JwdMba14Wvho44mXQu(type2.FullName, text))
					{
						num2 = 4;
						continue;
					}
					goto case 20;
				case 27:
					if (ImplementedInterfaces != null)
					{
						num2 = 24;
						continue;
					}
					goto case 28;
				case 0:
					return;
				case 23:
					num3 = 0;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 29;
					}
					continue;
				case 13:
					type2 = obj.GetType();
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 6;
					}
					continue;
				case 17:
					break;
				case 18:
					ImplementedInterfaces.AddRange(collection);
					num2 = 12;
					continue;
				case 21:
					TypeRef = (string)nhlrdQbaNGyPyNSFh0q6(type);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					attribute = AttributeHelper<UidAttribute>.GetAttribute(type, inherited: false);
					num2 = 26;
					continue;
				case 28:
					ImplementedInterfaces = new List<string>();
					num2 = 7;
					continue;
				case 2:
				case 8:
				case 11:
					num3++;
					num2 = 9;
					continue;
				case 5:
					array = (object[])eXPucDbae8Pm8jZPfNwP(type, false);
					num2 = 23;
					continue;
				case 25:
					return;
				case 9:
				case 29:
					if (num3 < array.Length)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 21;
				case 1:
					text = (string)yaMEKFba2eLydQhSv1yT();
					num2 = 5;
					continue;
				case 10:
				case 22:
					obj = array[num3];
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 5;
					}
					continue;
				case 4:
					ProcessIncludeAttribute(obj, type2);
					num2 = 11;
					continue;
				case 6:
					LoadFromEntityMetadata(IheeVWbaTXxWjHSCZOk2(attribute2));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 25;
					}
					continue;
				case 19:
					if (Gj1n2pbaPTntSNI5Kqui(type2.FullName))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 14;
				case 26:
					UIIqRJbanx46cPdeYctZ(this, attribute?.Uid ?? gQsG6KbakfeIeHocKUl2(type));
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 27;
					}
					continue;
				case 7:
				case 24:
					collection = (from a in type.GetInterfaces()
						select a.FullName).Except(dataClassInterfaces ?? (dataClassInterfaces = (from a in TypeOf<DataClass>.Raw.GetInterfaces()
						select a.FullName).ToArray()));
					num2 = 18;
					continue;
				}
				break;
			}
			attribute2 = AttributeHelper<EntityMetadataUidAttribute>.GetAttribute(type, inherited: false);
			num = 16;
		}
	}

	internal static string GetTypeRef(Type dataClassType)
	{
		//Discarded unreachable code: IL_00b8, IL_00c7
		int num = 6;
		long id = default(long);
		Guid guid = default(Guid);
		MetadataItemUidAttribute attribute = default(MetadataItemUidAttribute);
		Guid metadataUid = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return id.ToString();
				default:
					if (!GgKt7UbapkUcut4l14AE(guid, Guid.Empty))
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 3:
					return null;
				case 5:
					attribute = AttributeHelper<MetadataItemUidAttribute>.GetAttribute(dataClassType.Assembly);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 4;
					}
					break;
				case 6:
					metadataUid = AttributeHelper<UidAttribute>.GetAttribute(dataClassType, inherited: false).Uid;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 5;
					}
					break;
				case 4:
					if (attribute != null)
					{
						guid = lydYhqba3GgHR8aNT6cO(attribute);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 3;
					}
					break;
				case 1:
					return null;
				case 8:
				{
					IDataClassTypeReferenceManager service = Locator.GetService<IDataClassTypeReferenceManager>();
					if (service == null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
						{
							num2 = 7;
						}
					}
					else
					{
						id = ((DataClassTypeReference)jfUdsVbaacQpmBhH8xna(service, guid, metadataUid)).Id;
						num2 = 2;
					}
					break;
				}
				case 7:
					return null;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	protected override TableView CreateDefaultTableView()
	{
		TableView tableView = base.CreateDefaultTableView();
		yRaXvcbaD9kYls5HgHQB(tableView, true);
		xbb7j3batkDK7mMoANdr(tableView, true);
		MJ5ANAbawl90uenTZvWX(tableView, true);
		OpRTYlba4CThv9ZiW03r(tableView, true);
		tableView.CanDelete = true;
		return tableView;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeIncludeList()
	{
		return cXnhLFba6xUYb1ntNkyg(IncludeList) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTypeToMap()
	{
		return TypeToMap != null;
	}

	private void LoadFromEntityMetadata(Guid guid)
	{
		int num = 27;
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					nD1QGabac96bKhpCHilM(this, PqOZBFbasB9xllqHQijV(dataClassMetadata));
					num2 = 35;
					continue;
				case 19:
					nGf43obaJnlqiD4HqJM0(this, NE8ty2baMKBfuH3oeyDE(dataClassMetadata));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 32;
					}
					continue;
				case 14:
					return;
				case 21:
					TypeRef = (string)HHVWhHba7vqJJ7dryODt(dataClassMetadata);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					continue;
				case 31:
					SxdFADbajKdN5JnXB4W6(this, VAZSruba5S1rPsF0HEju(dataClassMetadata));
					num2 = 16;
					continue;
				case 23:
					NamedImages = dataClassMetadata.NamedImages;
					num2 = 17;
					continue;
				case 3:
					IncludeList = dataClassMetadata.IncludeList;
					num2 = 21;
					continue;
				case 10:
					mUg4qdbDGfh6fIuXZBV8(this, FjtTFybDhpVjsLOi5xg5(dataClassMetadata));
					num = 6;
					break;
				case 1:
					Description = (string)gT2CJ2baxN2DRXgfXi4c(dataClassMetadata);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 8;
					}
					continue;
				case 8:
					Forms = dataClassMetadata.Forms;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					continue;
				case 20:
					AllowCreateHeirs = RCnjXBbaU1jhR66TkLG3(dataClassMetadata);
					num2 = 7;
					continue;
				case 27:
					dataClassMetadata = (DataClassMetadata)AmYCqubaHypnFZcuh7Ut((EntityMetadata)MetadataServiceContext.Service.GetMetadata(guid, loadImplementation: false));
					num2 = 26;
					continue;
				case 11:
					VeWkPtbaYpoaRLtTJlEv(this, dataClassMetadata.InheritForms);
					num2 = 29;
					continue;
				case 34:
					Properties = dataClassMetadata.Properties;
					num2 = 19;
					continue;
				case 25:
					du6NUmbaKs77cRCMlRLL(this, dataClassMetadata.Namespace);
					num2 = 34;
					continue;
				case 6:
					OnViewLoadScriptName = (string)tUpcHLbDE6OagdJ6ETTr(dataClassMetadata);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 6;
					}
					continue;
				case 22:
					FormViews = dataClassMetadata.FormViews;
					num2 = 31;
					continue;
				case 33:
					DisplayName = dataClassMetadata.DisplayName;
					num2 = 5;
					continue;
				case 9:
					XlXLC0balZpdDTyWpbon(this, erKtUJbadr3rk71IvSju(dataClassMetadata));
					num2 = 33;
					continue;
				case 4:
					TitlePropertyUid = dataClassMetadata.TitlePropertyUid;
					num2 = 18;
					continue;
				case 16:
					ImplementedInterfaces = dataClassMetadata.ImplementedInterfaces;
					num2 = 11;
					continue;
				case 30:
					XmlComments = dataClassMetadata.XmlComments;
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 13;
					}
					continue;
				case 5:
					GFLeqNbagQwHGVcSIcch(this, IyL1FjbariLTjHoTDaxT(dataClassMetadata));
					num2 = 15;
					continue;
				case 2:
					xfegw7bDWF7C1un3YSbb(this, hcaaR6bDBDSRFOYh8yrW(dataClassMetadata));
					num2 = 4;
					continue;
				case 32:
					DefaultForms = (ClassDefaultForms)xKuHHNba9u07e7TQaIOf(dataClassMetadata);
					num2 = 9;
					continue;
				case 15:
					FormTransformations = dataClassMetadata.FormTransformations;
					num2 = 22;
					continue;
				case 28:
					zGpjivbayYsQvK2HYFhH(this, HCcROqbamplI0bHKuj5Q(dataClassMetadata));
					num2 = 25;
					continue;
				default:
					Id = dataClassMetadata.Id;
					num = 24;
					break;
				case 18:
					UsekyrbDbTY4UAlJC21U(this, VRgOpgbDoIOmvajU9dhO(dataClassMetadata));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 10;
					}
					continue;
				case 12:
					Internal = c4DBAUba0XfC3mK8tSLS(dataClassMetadata);
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 28;
					}
					continue;
				case 13:
					PropertiesDiffContainer = dataClassMetadata.PropertiesDiffContainer;
					num2 = 2;
					continue;
				case 26:
					UIIqRJbanx46cPdeYctZ(this, XQi4FAbaAGLGXRNXNrMW(dataClassMetadata));
					num2 = 3;
					continue;
				case 24:
					Images = dataClassMetadata.Images;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 12;
					}
					continue;
				case 29:
					BHyZohbaRMH78bV4CVbL(this, je2MpmbaLwebILt5U8lm(dataClassMetadata));
					num2 = 23;
					continue;
				case 35:
					CMVUYcbDFvbRyjoRgCN2(this, kO3p9NbazkmkDSRKW8eJ(dataClassMetadata));
					num2 = 13;
					continue;
				case 17:
					TableViews = dataClassMetadata.TableViews;
					num2 = 30;
					continue;
				}
				break;
			}
		}
	}

	internal void ProcessIncludeAttribute(object attribute, Type attributeType)
	{
		int num = 8;
		int num2 = num;
		_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = default(_003C_003Ec__DisplayClass30_0);
		PropertyInfo property = default(PropertyInfo);
		Guid typeUid = default(Guid);
		DataClassMetadata metadata = default(DataClassMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
				return;
			case 8:
				_003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
				num2 = 7;
				break;
			case 0:
				return;
			case 2:
				if (!hueHg5bDf27W861etRuU(property, null))
				{
					typeUid = (Guid)sPImf4bDQrifurVrs72G(property, attribute);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 4;
					}
				}
				break;
			case 7:
				property = attributeType.GetProperty((string)EvncrgbaqidZMoMogS35(0xD3DEF7E ^ 0xD3D80EC), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (!IncludeList.Exists(_003C_003Ec__DisplayClass30_._003CProcessIncludeAttribute_003Eb__0))
				{
					IncludeList.Add(_003C_003Ec__DisplayClass30_.dependency);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 4;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 5:
				metadata = (DataClassMetadata)iZcysubDCVBuKAfNv7wx(Locator.GetServiceNotNull<DataClassDescriptor>(), typeUid);
				num2 = 3;
				break;
			case 3:
				_003C_003Ec__DisplayClass30_.dependency = metadata.GetSignature(simple: true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return;
			}
		}
	}

	private void ProcessDataClassFormAttribute(object attribute, Type attributeType)
	{
		//Discarded unreachable code: IL_01ed, IL_01fc
		int num = 11;
		PropertyInfo property2 = default(PropertyInfo);
		ViewType result = default(ViewType);
		PropertyInfo property = default(PropertyInfo);
		Guid result2 = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					return;
				case 8:
					Enum.TryParse<ViewType>(property2.GetValue(attribute).ToString(), out result);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					break;
				case 0:
					return;
				case 10:
					if (hueHg5bDf27W861etRuU(property2, null))
					{
						num2 = 5;
						continue;
					}
					property = attributeType.GetProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7245EE66), BindingFlags.Instance | BindingFlags.NonPublic);
					num2 = 6;
					continue;
				case 9:
					return;
				case 11:
					property2 = attributeType.GetProperty((string)EvncrgbaqidZMoMogS35(-1123633026 ^ -1123789658), BindingFlags.Instance | BindingFlags.NonPublic);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					if (hueHg5bDf27W861etRuU(property, null))
					{
						return;
					}
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 8;
					}
					continue;
				case 7:
					switch (result)
					{
					case ViewType.Edit:
						WFwAA7bD8XnbY4Mxkjfy(DefaultForms, result2);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 1;
						}
						break;
					case ViewType.Create:
						v3JMWmbDvUmUYOv20N9n(xKuHHNba9u07e7TQaIOf(this), result2);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
						{
							num2 = 0;
						}
						break;
					default:
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 1;
						}
						break;
					case ViewType.Display:
						FCR7HEbDZFBhl2O6fTvg(xKuHHNba9u07e7TQaIOf(this), result2);
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 2;
						}
						break;
					case ViewType.Create | ViewType.Edit:
						return;
					}
					continue;
				case 1:
					return;
				case 3:
					return;
				case 5:
					return;
				}
				break;
			}
			Guid.TryParse(sPImf4bDQrifurVrs72G(property, attribute).ToString(), out result2);
			num = 7;
		}
	}

	static DataClassMetadata()
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
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F78BA2));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				iDimprbaihsfM9YHdSbA();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void iDimprbaihsfM9YHdSbA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool wiJSLfbaVKEd1KFaNYQM()
	{
		return vw3Mx6baI7DI3hUKa240 == null;
	}

	internal static DataClassMetadata p6T9MTbaSFgERkfrrMQR()
	{
		return vw3Mx6baI7DI3hUKa240;
	}

	internal static void BHyZohbaRMH78bV4CVbL(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).ModuleUid = value;
	}

	internal static object EvncrgbaqidZMoMogS35(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void du6NUmbaKs77cRCMlRLL(object P_0, object P_1)
	{
		((ClassMetadata)P_0).Namespace = (string)P_1;
	}

	internal static object CpDwEobaXohsd0UlV7ee(object P_0)
	{
		return ((ClassMetadata)P_0).CreateDefaultTableView();
	}

	internal static Guid IheeVWbaTXxWjHSCZOk2(object P_0)
	{
		return ((EntityMetadataUidAttribute)P_0).Uid;
	}

	internal static Guid gQsG6KbakfeIeHocKUl2(Type type)
	{
		return DataClassDescriptor.GetSubtypeUid(type);
	}

	internal static void UIIqRJbanx46cPdeYctZ(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).Uid = value;
	}

	internal static object m3OKodbaOHKOrJLoC9gc()
	{
		return TypeOf<DataClassFormAttribute>.FullName;
	}

	internal static object yaMEKFba2eLydQhSv1yT()
	{
		return TypeOf<IncludeAttribute>.FullName;
	}

	internal static object eXPucDbae8Pm8jZPfNwP(object P_0, bool P_1)
	{
		return ((MemberInfo)P_0).GetCustomAttributes(P_1);
	}

	internal static bool Gj1n2pbaPTntSNI5Kqui(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool j7JwdMba14Wvho44mXQu(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object nhlrdQbaNGyPyNSFh0q6(Type dataClassType)
	{
		return GetTypeRef(dataClassType);
	}

	internal static Guid lydYhqba3GgHR8aNT6cO(object P_0)
	{
		return ((MetadataItemUidAttribute)P_0).ItemUid;
	}

	internal static bool GgKt7UbapkUcut4l14AE(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object jfUdsVbaacQpmBhH8xna(object P_0, Guid itemUid, Guid metadataUid)
	{
		return ((IDataClassTypeReferenceManager)P_0).FindByItemUid(itemUid, metadataUid);
	}

	internal static void yRaXvcbaD9kYls5HgHQB(object P_0, bool value)
	{
		((TableView)P_0).Resizeable = value;
	}

	internal static void xbb7j3batkDK7mMoANdr(object P_0, bool value)
	{
		((TableView)P_0).Groupable = value;
	}

	internal static void MJ5ANAbawl90uenTZvWX(object P_0, bool value)
	{
		((TableView)P_0).CanAdd = value;
	}

	internal static void OpRTYlba4CThv9ZiW03r(object P_0, bool value)
	{
		((TableView)P_0).CanEdit = value;
	}

	internal static int cXnhLFba6xUYb1ntNkyg(object P_0)
	{
		return ((List<DataClassDependency>)P_0).Count;
	}

	internal static object AmYCqubaHypnFZcuh7Ut(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static Guid XQi4FAbaAGLGXRNXNrMW(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object HHVWhHba7vqJJ7dryODt(object P_0)
	{
		return ((DataClassMetadata)P_0).TypeRef;
	}

	internal static object gT2CJ2baxN2DRXgfXi4c(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static bool c4DBAUba0XfC3mK8tSLS(object P_0)
	{
		return ((AbstractMetadata)P_0).Internal;
	}

	internal static object HCcROqbamplI0bHKuj5Q(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void zGpjivbayYsQvK2HYFhH(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static object NE8ty2baMKBfuH3oeyDE(object P_0)
	{
		return ((ClassMetadata)P_0).CustomCode;
	}

	internal static void nGf43obaJnlqiD4HqJM0(object P_0, object P_1)
	{
		((ClassMetadata)P_0).CustomCode = (string)P_1;
	}

	internal static object xKuHHNba9u07e7TQaIOf(object P_0)
	{
		return ((ClassMetadata)P_0).DefaultForms;
	}

	internal static object erKtUJbadr3rk71IvSju(object P_0)
	{
		return ((ClassMetadata)P_0).DisplayFormat;
	}

	internal static void XlXLC0balZpdDTyWpbon(object P_0, object P_1)
	{
		((ClassMetadata)P_0).DisplayFormat = (string)P_1;
	}

	internal static ClassFormsScheme IyL1FjbariLTjHoTDaxT(object P_0)
	{
		return ((ClassMetadata)P_0).FormsScheme;
	}

	internal static void GFLeqNbagQwHGVcSIcch(object P_0, ClassFormsScheme value)
	{
		((ClassMetadata)P_0).FormsScheme = value;
	}

	internal static long VAZSruba5S1rPsF0HEju(object P_0)
	{
		return ((ClassMetadata)P_0).GroupId;
	}

	internal static void SxdFADbajKdN5JnXB4W6(object P_0, long value)
	{
		((ClassMetadata)P_0).GroupId = value;
	}

	internal static void VeWkPtbaYpoaRLtTJlEv(object P_0, bool value)
	{
		((ClassMetadata)P_0).InheritForms = value;
	}

	internal static Guid je2MpmbaLwebILt5U8lm(object P_0)
	{
		return ((AbstractMetadata)P_0).ModuleUid;
	}

	internal static bool RCnjXBbaU1jhR66TkLG3(object P_0)
	{
		return ((ClassMetadata)P_0).AllowCreateHeirs;
	}

	internal static Guid PqOZBFbasB9xllqHQijV(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static void nD1QGabac96bKhpCHilM(object P_0, Guid value)
	{
		((ClassMetadata)P_0).BaseClassUid = value;
	}

	internal static object kO3p9NbazkmkDSRKW8eJ(object P_0)
	{
		return ((ClassMetadata)P_0).NamespaceForDisplay;
	}

	internal static void CMVUYcbDFvbRyjoRgCN2(object P_0, object P_1)
	{
		((ClassMetadata)P_0).NamespaceForDisplay = (string)P_1;
	}

	internal static bool hcaaR6bDBDSRFOYh8yrW(object P_0)
	{
		return ((ClassMetadata)P_0).ShowInDesigner;
	}

	internal static void xfegw7bDWF7C1un3YSbb(object P_0, bool value)
	{
		((ClassMetadata)P_0).ShowInDesigner = value;
	}

	internal static object VRgOpgbDoIOmvajU9dhO(object P_0)
	{
		return ((ClassMetadata)P_0).ScriptModuleTypeName;
	}

	internal static void UsekyrbDbTY4UAlJC21U(object P_0, object P_1)
	{
		((ClassMetadata)P_0).ScriptModuleTypeName = (string)P_1;
	}

	internal static bool FjtTFybDhpVjsLOi5xg5(object P_0)
	{
		return ((ClassMetadata)P_0).ShowInTypeTree;
	}

	internal static void mUg4qdbDGfh6fIuXZBV8(object P_0, bool value)
	{
		((ClassMetadata)P_0).ShowInTypeTree = value;
	}

	internal static object tUpcHLbDE6OagdJ6ETTr(object P_0)
	{
		return ((ClassMetadata)P_0).OnViewLoadScriptName;
	}

	internal static bool hueHg5bDf27W861etRuU(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object sPImf4bDQrifurVrs72G(object P_0, object P_1)
	{
		return ((PropertyInfo)P_0).GetValue(P_1);
	}

	internal static object iZcysubDCVBuKAfNv7wx(object P_0, Guid typeUid)
	{
		return ((DataClassDescriptor)P_0).GetMetadataByUid(typeUid);
	}

	internal static void v3JMWmbDvUmUYOv20N9n(object P_0, Guid value)
	{
		((ClassDefaultForms)P_0).CreateUid = value;
	}

	internal static void WFwAA7bD8XnbY4Mxkjfy(object P_0, Guid value)
	{
		((ClassDefaultForms)P_0).EditUid = value;
	}

	internal static void FCR7HEbDZFBhl2O6fTvg(object P_0, Guid value)
	{
		((ClassDefaultForms)P_0).DisplayUid = value;
	}
}
