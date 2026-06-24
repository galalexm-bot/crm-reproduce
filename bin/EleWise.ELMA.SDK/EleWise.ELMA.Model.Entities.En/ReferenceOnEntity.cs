using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities.EntityReferences;

[Serializable]
[XmlRoot("ReferenceOnEntity")]
[Component]
[TypeConverter(typeof(ReferenceOnEntityConverter))]
public sealed class ReferenceOnEntity : IXsiType
{
	public static string Delimiter;

	private long? objectId;

	private Guid objectUid;

	[NonSerialized]
	[XmlIgnore]
	private IEntity _object;

	internal static ReferenceOnEntity bVFAeYhIthv1g5NCiXt0;

	[XmlElement("ObjectId")]
	public long ObjectId
	{
		get
		{
			//Discarded unreachable code: IL_00f8, IL_0107, IL_0166, IL_0175
			int num = 8;
			int num2 = num;
			IEntity entity = default(IEntity);
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 4:
				case 5:
					if (objectId.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return 0L;
				case 8:
					if (!objectId.HasValue)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 7;
						}
						break;
					}
					goto case 1;
				case 3:
					entity = ((IEntityManager)fDoKVrhI0uZceZPMVYcf(ModelHelper.GetEntityType(ObjectTypeUId))).LoadOrNull(objectUid) as IEntity;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 6;
					}
					break;
				case 2:
					Object = entity;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 5;
					}
					break;
				case 6:
					if (entity == null)
					{
						num2 = 4;
						break;
					}
					goto case 2;
				case 7:
					if (!(objectUid != Guid.Empty))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				default:
					return objectId.Value;
				}
			}
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
					objectId = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid ObjectUid
	{
		get
		{
			return objectUid;
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
					objectUid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("ObjectTypeUId")]
	public Guid ObjectTypeUId
	{
		[CompilerGenerated]
		get
		{
			return _003CObjectTypeUId_003Ek__BackingField;
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
					_003CObjectTypeUId_003Ek__BackingField = value;
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

	[XmlIgnore]
	public Type ObjectType
	{
		get
		{
			//Discarded unreachable code: IL_0042, IL_0051, IL_00a9, IL_00db, IL_0113, IL_0122
			int num = 3;
			int num2 = num;
			Type type = default(Type);
			while (true)
			{
				switch (num2)
				{
				default:
					return null;
				case 2:
					num2 = 4;
					break;
				case 3:
					if (!U8XvsShImeNlCN2SQeOj(ObjectTypeUId, Guid.Empty))
					{
						num2 = 2;
						break;
					}
					goto default;
				case 4:
					try
					{
						type = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(ObjectTypeUId);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => type, 
							_ => type, 
						};
					}
					catch (Exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								type = null;
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
								{
									num4 = 0;
								}
								break;
							default:
								return type;
							case 0:
								return type;
							}
						}
					}
				case 1:
					return type;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_0073, IL_00e5, IL_00fc, IL_010b
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					if (tcAGifhIy1kYcqbGEmHE(value, null))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 1;
						}
						break;
					}
					return;
				case 1:
					try
					{
						IMetadata metadata = MetadataLoader.LoadMetadata(value);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								ObjectTypeUId = qtXOPOhIMjSyBQv6Xmcc(metadata);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
								{
									num3 = 1;
								}
								break;
							default:
								if (metadata != null)
								{
									num3 = 2;
									break;
								}
								return;
							case 1:
								return;
							}
						}
					}
					catch (Exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
						return;
					}
				case 0:
					return;
				}
			}
		}
	}

	[XmlIgnore]
	public IEntity Object
	{
		get
		{
			//Discarded unreachable code: IL_007b, IL_00b9, IL_0116, IL_0125, IL_01d3, IL_01e2, IL_024c, IL_0288, IL_02f5
			int num = 10;
			int num2 = num;
			Type objectType = default(Type);
			Filter filter = default(Filter);
			_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = default(_003C_003Ec__DisplayClass23_0);
			while (true)
			{
				switch (num2)
				{
				case 4:
				case 9:
					return _object;
				case 7:
					if (ObjectId > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 6;
				case 5:
					objectType = ObjectType;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 8;
					}
					break;
				case 2:
					try
					{
						ISecurityService service = Locator.GetService<ISecurityService>();
						int num3 = 4;
						while (true)
						{
							switch (num3)
							{
							case 6:
								MglxP5hIJnu1mQLYqlGa(filter, true);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
								{
									num3 = 2;
								}
								continue;
							case 9:
								filter.DisableSecurity = true;
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
								{
									num3 = 1;
								}
								continue;
							case 7:
								_object = ((IEnumerable<IEntity>)AkX1TDhIdw5h6Ypq2Pr7(_003C_003Ec__DisplayClass23_.manager, filter, new FetchOptions(0, 1))).FirstOrDefault();
								num3 = 8;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num3 = 8;
								}
								continue;
							case 2:
								oRpRVEhI9HqpXV8L0Zxv(filter, ObjectId);
								num3 = 7;
								continue;
							case 4:
								if (service == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 5;
							case 3:
								break;
							case 5:
								service.RunWithElevatedPrivilegiesAndWithDeleted(_003C_003Ec__DisplayClass23_._003Cget_Object_003Eb__0);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
								{
									num3 = 3;
								}
								continue;
							default:
								filter = new Filter();
								num3 = 9;
								continue;
							case 8:
								break;
							}
							break;
						}
					}
					catch (SecurityException)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								_object = null;
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
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
					goto case 4;
				case 3:
					_003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				case 8:
					if (!(objectType == null))
					{
						num2 = 7;
						break;
					}
					goto case 6;
				case 1:
					_003C_003Ec__DisplayClass23_._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 5;
					}
					break;
				case 6:
					return null;
				default:
					_003C_003Ec__DisplayClass23_.manager = ModelHelper.GetEntityManager(objectType);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 2;
					}
					break;
				case 10:
					if (_object != null)
					{
						num2 = 9;
						break;
					}
					goto case 3;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_00b1
			int num = 8;
			PropertyInfo property = default(PropertyInfo);
			IEntity entity = default(IEntity);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						property = entity.GetType().GetProperty((string)KyF2blhIAdgqlMns1h8N(-1979251663 ^ -1979218577));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 0;
						}
						continue;
					case 4:
						ObjectId = EZ6BXyhIgBr0rOFFAv8B(PXE7tOhIruNrhtn9cspq(property, value, null));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 6;
						}
						continue;
					default:
						_object = null;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 2;
						}
						continue;
					case 2:
						return;
					case 7:
						entity = value.CastAsRealType();
						num2 = 5;
						continue;
					case 5:
						ObjectType = entity.GetType();
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 3;
						}
						continue;
					case 1:
						if (!xC6joPhIl6YvSXZygq3m(property, null))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 4;
					case 8:
						if (value == null)
						{
							return;
						}
						num = 7;
						break;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public string ObjectDispalyName
	{
		get
		{
			//Discarded unreachable code: IL_007b, IL_00a2, IL_00b1, IL_00f5, IL_0104, IL_012f, IL_0146, IL_0155
			int num = 2;
			int num2 = num;
			string result = default(string);
			while (true)
			{
				switch (num2)
				{
				default:
					return "";
				case 2:
					if (tcAGifhIy1kYcqbGEmHE(ObjectType, null))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				case 1:
					try
					{
						ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(ObjectType);
						int num3 = 3;
						while (true)
						{
							switch (num3)
							{
							case 2:
								return result;
							default:
								goto end_IL_007f;
							case 3:
								if (classMetadata == null)
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
									{
										num3 = 4;
									}
									continue;
								}
								break;
							case 1:
								break;
							case 4:
								goto end_IL_007f;
							case 0:
								goto end_IL_007f;
							}
							result = (string)DXk8VmhI5dpZ2MTnkRCR(classMetadata);
							num3 = 2;
							continue;
							end_IL_007f:
							break;
						}
					}
					catch (Exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto default;
				}
			}
		}
	}

	public ReferenceOnEntity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FRuSmPhI6wDtuPFpTgus();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ReferenceOnEntity(IEntity @object)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
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
			Object = @object;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
			{
				num = 1;
			}
		}
	}

	public ReferenceOnEntity(long objectId, Guid objectTypeUId)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FRuSmPhI6wDtuPFpTgus();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				ObjectTypeUId = objectTypeUId;
				num = 2;
				continue;
			}
			ObjectId = objectId;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
			{
				num = 0;
			}
		}
	}

	public ReferenceOnEntity(Guid objectUid, Guid objectTypeUId)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FRuSmPhI6wDtuPFpTgus();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
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
				ObjectTypeUId = objectTypeUId;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num = 0;
				}
				break;
			case 2:
				this.objectUid = objectUid;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public ReferenceOnEntity(string stringValue)
	{
		//Discarded unreachable code: IL_002a, IL_007e, IL_008d, IL_0144, IL_01b1, IL_01c0, IL_01d0, IL_01df, IL_01ef
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
		{
			num = 1;
		}
		Guid result = default(Guid);
		string[] array = default(string[]);
		long result2 = default(long);
		while (true)
		{
			switch (num)
			{
			case 3:
				ObjectTypeUId = result;
				num = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num = 13;
				}
				break;
			case 4:
				if (array.Length < 2)
				{
					num = 6;
					break;
				}
				goto case 10;
			case 8:
				if (!long.TryParse(array[1], out result2))
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num = 0;
					}
					break;
				}
				goto case 3;
			case 12:
				throw new ArgumentNullException((string)KyF2blhIAdgqlMns1h8N(-70007027 ^ -70220551));
			case 5:
				array = (string[])ST3XyAhI7NRP2m4yWckd(stringValue, new string[1] { Delimiter }, StringSplitOptions.RemoveEmptyEntries);
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num = 1;
				}
				break;
			case 7:
				return;
			default:
				throw new ArgumentException((string)MyUMbthIxXNEXVKSldob(KyF2blhIAdgqlMns1h8N(0x1C9495B4 ^ 0x1C97D1BA)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859067307));
			case 10:
				if (fyltnahIHipFIkj1EAw3(array[0]))
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num = 2;
					}
					break;
				}
				goto case 11;
			case 13:
			{
				ObjectId = result2;
				int num2 = 7;
				num = num2;
				break;
			}
			case 1:
				if (!fyltnahIHipFIkj1EAw3(stringValue))
				{
					num = 5;
					break;
				}
				goto case 12;
			case 2:
			case 6:
			case 14:
				throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218545574));
			case 9:
				if (Guid.TryParse(array[0], out result))
				{
					num = 8;
					break;
				}
				goto default;
			case 11:
				if (!fyltnahIHipFIkj1EAw3(array[1]))
				{
					num = 9;
					break;
				}
				goto case 2;
			}
		}
	}

	public static ReferenceOnEntity Create(Type type, long id)
	{
		ReferenceOnEntity referenceOnEntity = new ReferenceOnEntity();
		BqvLYlhIjOhKQ7hSFBmU(referenceOnEntity, type);
		xTo8SchIYF6DmaLG3gQ2(referenceOnEntity, id);
		return referenceOnEntity;
	}

	public static ReferenceOnEntity Create(Guid typeUid, long id)
	{
		ReferenceOnEntity referenceOnEntity = new ReferenceOnEntity();
		kFJCg1hILj4jqlInPfFa(referenceOnEntity, typeUid);
		xTo8SchIYF6DmaLG3gQ2(referenceOnEntity, id);
		return referenceOnEntity;
	}

	public static ReferenceOnEntity Create(IEntity obj)
	{
		//Discarded unreachable code: IL_005c, IL_006b
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			default:
			{
				ReferenceOnEntity referenceOnEntity = new ReferenceOnEntity();
				oePrlJhIUT0RCxhxJT6I(referenceOnEntity, obj);
				return referenceOnEntity;
			}
			case 1:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public bool Equals(ReferenceOnEntity other)
	{
		//Discarded unreachable code: IL_00ad
		int num = 2;
		Guid objectTypeUId = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return true;
				case 4:
					return false;
				case 1:
					if (this != other)
					{
						if (f1JcJihIsN76kHSuVXEx(other) != ObjectId)
						{
							return false;
						}
						goto end_IL_0012;
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 3;
					}
					break;
				default:
					return objectTypeUId.Equals(ObjectTypeUId);
				case 2:
					if (other != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 4;
				case 5:
					objectTypeUId = other.ObjectTypeUId;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_006b
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return true;
			case 3:
				return false;
			case 2:
				return false;
			case 1:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			}
			if (this != obj)
			{
				if (!tcAGifhIy1kYcqbGEmHE(obj.GetType(), r3J6VVhIc8IsYQLw44Qc(typeof(ReferenceOnEntity).TypeHandle)))
				{
					return Equals((ReferenceOnEntity)obj);
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 1;
				}
			}
			else
			{
				num2 = 4;
			}
		}
	}

	public override string ToString()
	{
		return (string)KT7edmhIzsKxIDir1Rc8(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x363270D7), ObjectTypeUId, Delimiter, ObjectId);
	}

	public static ReferenceOnEntity Parse(string value)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		ReferenceOnEntity entity = default(ReferenceOnEntity);
		while (true)
		{
			switch (num2)
			{
			case 2:
				throw new Exception((string)KyF2blhIAdgqlMns1h8N(0x92F12D5 ^ 0x92C56B9));
			default:
				return entity;
			case 1:
				if (TryParse(value, out entity))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public static bool TryParse(string value, out ReferenceOnEntity entity)
	{
		//Discarded unreachable code: IL_0102, IL_0111, IL_0121, IL_0130, IL_013f
		int num = 6;
		int num2 = num;
		Guid result2 = default(Guid);
		string[] array = default(string[]);
		long result = default(long);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return false;
			case 8:
				result2 = Guid.Empty;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (Guid.TryParse(array[0], out result2))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			case 5:
				array = (string[])Ro26HWhVFeTKIaD2dTen(value, new char[1] { ';' });
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 9;
				}
				break;
			case 7:
				return false;
			case 3:
				entity = new ReferenceOnEntity(result, result2);
				num2 = 10;
				break;
			case 9:
				if (array.Length >= 2)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			case 1:
				return false;
			case 2:
				if (long.TryParse(array[1], out result))
				{
					num2 = 3;
					break;
				}
				goto case 7;
			case 6:
				entity = null;
				num2 = 5;
				break;
			case 10:
				return true;
			}
		}
	}

	public override int GetHashCode()
	{
		int num = 1;
		int num2 = num;
		long num3 = default(long);
		while (true)
		{
			switch (num2)
			{
			default:
				return (num3.GetHashCode() * 397) ^ ObjectTypeUId.GetHashCode();
			case 1:
				num3 = ObjectId;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static ReferenceOnEntity()
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
				Delimiter = (string)KyF2blhIAdgqlMns1h8N(-1978478350 ^ -1978498002);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				FRuSmPhI6wDtuPFpTgus();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void FRuSmPhI6wDtuPFpTgus()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool zoZsZthIwKPAUtxyXgRd()
	{
		return bVFAeYhIthv1g5NCiXt0 == null;
	}

	internal static ReferenceOnEntity FGF0phhI4fpOFAeunx9N()
	{
		return bVFAeYhIthv1g5NCiXt0;
	}

	internal static bool fyltnahIHipFIkj1EAw3(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object KyF2blhIAdgqlMns1h8N(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ST3XyAhI7NRP2m4yWckd(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static object MyUMbthIxXNEXVKSldob(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object fDoKVrhI0uZceZPMVYcf(Type entityType)
	{
		return ModelHelper.GetEntityManager(entityType);
	}

	internal static bool U8XvsShImeNlCN2SQeOj(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool tcAGifhIy1kYcqbGEmHE(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid qtXOPOhIMjSyBQv6Xmcc(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static void MglxP5hIJnu1mQLYqlGa(object P_0, bool value)
	{
		((Filter)P_0).DisableSoftDeletable = value;
	}

	internal static void oRpRVEhI9HqpXV8L0Zxv(object P_0, object P_1)
	{
		((Filter)P_0).Id = P_1;
	}

	internal static object AkX1TDhIdw5h6Ypq2Pr7(object P_0, object P_1, object P_2)
	{
		return ((IEntityManager)P_0).Find((IEntityFilter)P_1, (FetchOptions)P_2);
	}

	internal static bool xC6joPhIl6YvSXZygq3m(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static object PXE7tOhIruNrhtn9cspq(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static long EZ6BXyhIgBr0rOFFAv8B(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object DXk8VmhI5dpZ2MTnkRCR(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void BqvLYlhIjOhKQ7hSFBmU(object P_0, Type value)
	{
		((ReferenceOnEntity)P_0).ObjectType = value;
	}

	internal static void xTo8SchIYF6DmaLG3gQ2(object P_0, long value)
	{
		((ReferenceOnEntity)P_0).ObjectId = value;
	}

	internal static void kFJCg1hILj4jqlInPfFa(object P_0, Guid value)
	{
		((ReferenceOnEntity)P_0).ObjectTypeUId = value;
	}

	internal static void oePrlJhIUT0RCxhxJT6I(object P_0, object P_1)
	{
		((ReferenceOnEntity)P_0).Object = (IEntity)P_1;
	}

	internal static long f1JcJihIsN76kHSuVXEx(object P_0)
	{
		return ((ReferenceOnEntity)P_0).ObjectId;
	}

	internal static Type r3J6VVhIc8IsYQLw44Qc(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object KT7edmhIzsKxIDir1Rc8(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object Ro26HWhVFeTKIaD2dTen(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}
}
