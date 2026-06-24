using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems;

[Serializable]
public class DesignerParameterInfo
{
	private static DesignerParameterInfo x3BRZxI1pra6k5ouBDF;

	public string ParameterTypeName
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (zJRO0mIaFxZVmTxXvC4(ParameterType, null))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return null;
				case 1:
					return ParameterType.AssemblyQualifiedName;
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
					ParameterType = ((value != null) ? Type.GetType(value) : null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int Order
	{
		[CompilerGenerated]
		get
		{
			return _003COrder_003Ek__BackingField;
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
					_003COrder_003Ek__BackingField = value;
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

	[XmlIgnore]
	public Type ParameterType
	{
		[CompilerGenerated]
		get
		{
			return _003CParameterType_003Ek__BackingField;
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
					_003CParameterType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
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

	public bool Required
	{
		[CompilerGenerated]
		get
		{
			return _003CRequired_003Ek__BackingField;
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
					_003CRequired_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ParameterTypeDisplayName
	{
		[CompilerGenerated]
		get
		{
			return _003CParameterTypeDisplayName_003Ek__BackingField;
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
					_003CParameterTypeDisplayName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid? ParameterTypeUid { get; set; }

	public string ParameterDisplayName
	{
		[CompilerGenerated]
		get
		{
			return _003CParameterDisplayName_003Ek__BackingField;
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
					_003CParameterDisplayName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ParameterName
	{
		[CompilerGenerated]
		get
		{
			return _003CParameterName_003Ek__BackingField;
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
					_003CParameterName_003Ek__BackingField = value;
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

	public bool IsMain
	{
		[CompilerGenerated]
		get
		{
			return _003CIsMain_003Ek__BackingField;
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
					_003CIsMain_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return _003CDescription_003Ek__BackingField;
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
					_003CDescription_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsEntity
	{
		get
		{
			//Discarded unreachable code: IL_0066, IL_0098, IL_00af, IL_00be
			int num = 2;
			int num2 = num;
			Type type = default(Type);
			while (true)
			{
				switch (num2)
				{
				case 1:
					try
					{
						type = ParameterType.GetInterface((string)JUVFUbIDTeDnhV7pqhy(-629844702 ^ -629861922));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					break;
				case 2:
					type = null;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			return type != null;
		}
	}

	public byte[] CurrentItem
	{
		[CompilerGenerated]
		get
		{
			return _003CCurrentItem_003Ek__BackingField;
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
					_003CCurrentItem_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
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

	public List<byte[]> BackItems { get; set; }

	public string SelectedValueName
	{
		[CompilerGenerated]
		get
		{
			return _003CSelectedValueName_003Ek__BackingField;
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
					_003CSelectedValueName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
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

	public string SelectedValueDisplayName
	{
		[CompilerGenerated]
		get
		{
			return _003CSelectedValueDisplayName_003Ek__BackingField;
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
					_003CSelectedValueDisplayName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsLocal
	{
		[CompilerGenerated]
		get
		{
			return _003CIsLocal_003Ek__BackingField;
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
					_003CIsLocal_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
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

	public bool IsSelected => !SelectedValueName.IsNullOrEmpty();

	public DesignerParameterInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oTVvcpIpJT0efibfcnO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public DesignerParameterInfo(string name, Type type, string description, int order)
	{
		//Discarded unreachable code: IL_002a
		oTVvcpIpJT0efibfcnO();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				ParameterName = name;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num = 3;
				}
				break;
			case 5:
			{
				Order = order;
				int num2 = 4;
				num = num2;
				break;
			}
			case 2:
				Description = description;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				ParameterType = type;
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num = 0;
				}
				break;
			case 4:
				TryGetTypeUid(ParameterType);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public DesignerParameterInfo(string name, Type type)
	{
		//Discarded unreachable code: IL_002a
		oTVvcpIpJT0efibfcnO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
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
			{
				ParameterType = type;
				int num2 = 3;
				num = num2;
				continue;
			}
			case 3:
				TryGetTypeUid(ParameterType);
				num = 2;
				continue;
			}
			ParameterName = name;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
			{
				num = 1;
			}
		}
	}

	public DesignerParameterInfo(string name, string displayName, Type type)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oTVvcpIpJT0efibfcnO();
		base._002Ector();
		int num = 4;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
		{
			num = 4;
		}
		while (true)
		{
			switch (num)
			{
			default:
				ParameterDisplayName = displayName;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				return;
			case 1:
				TryGetTypeUid(ParameterType);
				num = 3;
				break;
			case 2:
				ParameterType = type;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num = 0;
				}
				break;
			case 4:
				ParameterName = name;
				num = 2;
				break;
			}
		}
	}

	private void TryGetTypeUid(Type parameterType)
	{
		//Discarded unreachable code: IL_006b, IL_011b, IL_0185, IL_0194, IL_0240, IL_024f, IL_02a4, IL_03d0, IL_03e7, IL_03f6, IL_0423, IL_0432
		int num = 1;
		int num2 = num;
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		EntityMetadata entityMetadata = default(EntityMetadata);
		IMetadata metadata = default(IMetadata);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		EnumMetadata enumMetadata = default(EnumMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					int num3;
					if (parameterType.GetInterface(TuigheItlt9xg21f6wZ(typeof(IEnumerable<>).TypeHandle).Name) != null)
					{
						num3 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num3 = 23;
						}
						goto IL_006f;
					}
					goto IL_019f;
					IL_019f:
					typeDescriptor = (ITypeDescriptor)VwrDpkIHful3cgmk3SC(Locator.GetServiceNotNull<IMetadataRuntimeService>(), parameterType);
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num3 = 1;
					}
					goto IL_006f;
					IL_006f:
					while (true)
					{
						switch (num3)
						{
						case 6:
							ParameterTypeDisplayName = SR.T((string)JUVFUbIDTeDnhV7pqhy(-1217523399 ^ -1217504549), kC3BvmI611C5qqkVMbW(entityMetadata));
							num3 = 16;
							continue;
						case 16:
							return;
						case 19:
							ParameterTypeDisplayName = typeDescriptor.Name;
							num3 = 21;
							continue;
						case 23:
							if (!parameterType.IsArray)
							{
								num3 = 7;
								continue;
							}
							break;
						case 7:
							if (zJRO0mIaFxZVmTxXvC4(parameterType, TuigheItlt9xg21f6wZ(typeof(string).TypeHandle)))
							{
								num3 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
								{
									num3 = 3;
								}
								continue;
							}
							break;
						case 24:
							break;
						default:
							if (!(metadata is EntityMetadata))
							{
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
								{
									num3 = 3;
								}
								continue;
							}
							goto case 12;
						case 5:
							ParameterTypeDisplayName = (string)kC3BvmI611C5qqkVMbW(entityMetadata2);
							num3 = 25;
							continue;
						case 20:
							ParameterTypeUid = w2Ux5RI4wkwbuqTD5C8(entityMetadata);
							num3 = 6;
							continue;
						case 21:
							ParameterTypeUid = GYDbDjIAflaL4MZopRv(typeDescriptor);
							num3 = 13;
							continue;
						case 8:
							return;
						case 22:
							if (entityMetadata != null)
							{
								num3 = 20;
								continue;
							}
							return;
						case 2:
							if (metadata == null)
							{
								num3 = 8;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
								{
									num3 = 4;
								}
								continue;
							}
							goto default;
						case 11:
							enumMetadata = metadata as EnumMetadata;
							num3 = 10;
							continue;
						case 13:
							return;
						case 9:
							if (parameterType.IsGenericType)
							{
								num3 = 15;
								continue;
							}
							break;
						case 1:
							if (typeDescriptor != null)
							{
								num3 = 19;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
								{
									num3 = 12;
								}
								continue;
							}
							goto case 4;
						case 12:
							entityMetadata2 = metadata as EntityMetadata;
							num3 = 17;
							continue;
						case 3:
						case 25:
							if (metadata is EnumMetadata)
							{
								num3 = 11;
								continue;
							}
							return;
						case 10:
							ParameterTypeUid = HJKEkbI7btWpJPdogmd(enumMetadata);
							num3 = 14;
							continue;
						case 17:
							ParameterTypeUid = w2Ux5RI4wkwbuqTD5C8(entityMetadata2);
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num3 = 2;
							}
							continue;
						case 14:
							ParameterTypeDisplayName = (string)kC3BvmI611C5qqkVMbW(enumMetadata);
							num3 = 18;
							continue;
						case 15:
							entityMetadata = MetadataLoader.LoadMetadata(parameterType.GetGenericArguments()[0], inherit: false, loadImplementation: false) as EntityMetadata;
							num3 = 17;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
							{
								num3 = 22;
							}
							continue;
						case 4:
							metadata = MetadataLoader.LoadMetadata(parameterType, inherit: false, loadImplementation: false);
							num3 = 2;
							continue;
						case 18:
							return;
						}
						break;
					}
					goto IL_019f;
				}
				catch
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
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
			case 4:
				return;
			case 3:
				return;
			default:
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (n8g0tiIwVNpf6XbaZ5x(parameterType, TuigheItlt9xg21f6wZ(typeof(void).TypeHandle)))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void oTVvcpIpJT0efibfcnO()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool f8LXadINVmakb8SfvFI()
	{
		return x3BRZxI1pra6k5ouBDF == null;
	}

	internal static DesignerParameterInfo gtE9MpI3AxRsVS7oC6o()
	{
		return x3BRZxI1pra6k5ouBDF;
	}

	internal static bool zJRO0mIaFxZVmTxXvC4(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object JUVFUbIDTeDnhV7pqhy(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type TuigheItlt9xg21f6wZ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool n8g0tiIwVNpf6XbaZ5x(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid w2Ux5RI4wkwbuqTD5C8(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static object kC3BvmI611C5qqkVMbW(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object VwrDpkIHful3cgmk3SC(object P_0, Type runtimeType)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(runtimeType);
	}

	internal static Guid GYDbDjIAflaL4MZopRv(object P_0)
	{
		return ((ITypeDescriptor)P_0).Uid;
	}

	internal static Guid HJKEkbI7btWpJPdogmd(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}
}
