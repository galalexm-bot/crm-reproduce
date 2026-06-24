using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Entities.EntityReferences;

[Serializable]
[Component]
[TypeConverter(typeof(ReferenceOnEntityTypeConverter))]
[XmlRoot("ReferenceOnEntityType")]
public class ReferenceOnEntityType : IXsiType
{
	internal static ReferenceOnEntityType PBHqDjhVBkVi5drTmMP0;

	[XmlElement("TypeUid")]
	public Guid TypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeUid_003Ek__BackingField;
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
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
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

	[XmlIgnore]
	public Type EntityType
	{
		get
		{
			//Discarded unreachable code: IL_0035, IL_0044, IL_00af, IL_00e1, IL_0119, IL_0128
			int num = 1;
			int num2 = num;
			Type type = default(Type);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!iPBonjhVbf8P02uToOPs(TypeUid, Guid.Empty))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 3:
					return type;
				case 4:
					try
					{
						type = ((IMetadataRuntimeService)mnoP2ihVhmUgZVGLZmrc()).GetTypeByUid(TypeUid, loadImplementation: true);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
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
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								return type;
							case 0:
								return type;
							case 1:
								type = null;
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					}
				case 2:
					return null;
				default:
					num2 = 4;
					break;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_003d, IL_0068, IL_0077, IL_0114, IL_012b, IL_013a
			int num = 1;
			int num2 = num;
			EntityMetadata entityMetadata = default(EntityMetadata);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (WQ5qPihVGTSyx4Ai0PTI(value, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 2:
					return;
				}
				try
				{
					IMetadata metadata = MetadataLoader.LoadMetadata(value);
					int num3 = 3;
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							TypeUid = nWk9hihVfwCARpBjNrie(metadata);
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
							{
								num3 = 1;
							}
							break;
						case 3:
							entityMetadata = metadata as EntityMetadata;
							num3 = 4;
							break;
						case 4:
							if (entityMetadata != null)
							{
								num3 = 5;
								break;
							}
							goto case 1;
						case 5:
							TypeUid = kViebvhVErnxQUs7YPse(entityMetadata);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
							{
								num3 = 0;
							}
							break;
						case 2:
							return;
						}
					}
				}
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
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
			}
		}
	}

	[XmlIgnore]
	public string DisplayName
	{
		get
		{
			//Discarded unreachable code: IL_0082, IL_00c8, IL_00d7, IL_0113, IL_014b, IL_015a
			int num = 1;
			int num2 = num;
			string result = default(string);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (EntityType != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					try
					{
						ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(EntityType);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								result = (string)GrE941hVCjgfVLWwB1tD(classMetadata);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
								{
									num3 = 1;
								}
								continue;
							case 2:
								if (classMetadata != null)
								{
									num3 = 3;
									continue;
								}
								break;
							case 0:
								break;
							case 1:
								return result;
							}
							break;
						}
					}
					catch (Exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								return result;
							}
							result = null;
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
							{
								num4 = 1;
							}
						}
					}
					break;
				case 2:
					break;
				}
				break;
			}
			return "";
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_0058, IL_0067
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 2:
				if (this == obj)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					break;
				}
				if (!WQ5qPihVGTSyx4Ai0PTI(obj.GetType(), SdgueihVQLfEcgxdQ2L3(typeof(ReferenceOnEntityType).TypeHandle)))
				{
					return iPBonjhVbf8P02uToOPs(((ReferenceOnEntityType)obj).TypeUid, TypeUid);
				}
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (obj != null)
				{
					num2 = 2;
					break;
				}
				goto default;
			case 4:
				return false;
			case 1:
				return true;
			}
		}
	}

	public override int GetHashCode()
	{
		int num = 1;
		int num2 = num;
		Guid typeUid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			default:
				return typeUid.ToString().GetHashCode();
			case 1:
				typeUid = TypeUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static ReferenceOnEntityType Create(Type type)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				return new ReferenceOnEntityType
				{
					EntityType = type
				};
			case 2:
				if (!okaHUJhVvsXun0juJ07j(type, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public override string ToString()
	{
		int num = 1;
		int num2 = num;
		Guid typeUid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			default:
				return typeUid.ToString();
			case 1:
				typeUid = TypeUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ReferenceOnEntityType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Vk6S93hVWbKqJZfb2LkQ()
	{
		return PBHqDjhVBkVi5drTmMP0 == null;
	}

	internal static ReferenceOnEntityType vcaReZhVorQBYEKhRW84()
	{
		return PBHqDjhVBkVi5drTmMP0;
	}

	internal static bool iPBonjhVbf8P02uToOPs(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object mnoP2ihVhmUgZVGLZmrc()
	{
		return MetadataServiceContext.MetadataRuntimeService;
	}

	internal static bool WQ5qPihVGTSyx4Ai0PTI(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid kViebvhVErnxQUs7YPse(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static Guid nWk9hihVfwCARpBjNrie(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static Type SdgueihVQLfEcgxdQ2L3(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object GrE941hVCjgfVLWwB1tD(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static bool okaHUJhVvsXun0juJ07j(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}
}
