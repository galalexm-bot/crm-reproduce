using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
public class AssemblyModelsMetadata : IDisposable, ICloneable
{
	[NonSerialized]
	private AbstractMetadata[] cachedMetadata;

	[NonSerialized]
	private bool disposed;

	internal static AssemblyModelsMetadata LcLJ9rbxOCqs1wB7jQIR;

	public virtual long Id
	{
		[CompilerGenerated]
		get
		{
			return _003CId_003Ek__BackingField;
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
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
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

	public virtual string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
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

	public virtual AssemblyModelsMetadataStatus Status
	{
		[CompilerGenerated]
		get
		{
			return _003CStatus_003Ek__BackingField;
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
					_003CStatus_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Свойство устарело и больше не используется. Используйте MetadataStream", true)]
	public virtual byte[] Metadata
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					object obj = i7pAvcbxPyO6vRWWKN7L(this);
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return ((MemoryStream)obj).ToArray();
				}
				default:
					return null;
				}
			}
		}
		set
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
					f7fL0jbx10vrbrbhwpSx(this, null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					L6OZAZbx3RLU03QPOZYj(MetadataStream, value, 0, value.Length);
					num2 = 5;
					break;
				case 4:
					return;
				case 0:
					return;
				case 5:
					UNGAlkbxp1OVV5rYKHDy(i7pAvcbxPyO6vRWWKN7L(this), 0L, SeekOrigin.Begin);
					num2 = 4;
					break;
				case 2:
					if (value != null)
					{
						f7fL0jbx10vrbrbhwpSx(this, cjVe1ybxNhC3hfy5rUWu(value.Length));
						num2 = 3;
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	public virtual MemoryStream MetadataStream
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataStream_003Ek__BackingField;
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
					_003CMetadataStream_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Not used", true)]
	public virtual IEnumerable<LocalizedXmlDocumentation> LocalizedXmlDocumentation
	{
		get
		{
			return Enumerable.Empty<LocalizedXmlDocumentation>();
		}
		set
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Свойство устарело и больше не используется. Используйте AssemblyRawStream", true)]
	public virtual byte[] AssemblyRaw
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					object obj = d1cfxkbxagOZjCwdOFhW(this);
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return ((MemoryStream)obj).ToArray();
				}
				default:
					return null;
				}
			}
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					((Stream)d1cfxkbxagOZjCwdOFhW(this)).Seek(0L, SeekOrigin.Begin);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 4;
					}
					break;
				default:
					L6OZAZbx3RLU03QPOZYj(d1cfxkbxagOZjCwdOFhW(this), value, 0, value.Length);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					okbplGbxDw50ltCiFt92(this, null);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 5;
					}
					break;
				case 5:
					return;
				case 2:
					if (value != null)
					{
						okbplGbxDw50ltCiFt92(this, cjVe1ybxNhC3hfy5rUWu(value.Length));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 1;
						}
					}
					break;
				case 4:
					return;
				}
			}
		}
	}

	public virtual MemoryStream AssemblyRawStream
	{
		[CompilerGenerated]
		get
		{
			return _003CAssemblyRawStream_003Ek__BackingField;
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
					_003CAssemblyRawStream_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Свойство устарело и больше не используется. Используйте DebugRawStream", true)]
	public virtual byte[] DebugRaw
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					MemoryStream debugRawStream = DebugRawStream;
					if (debugRawStream == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return (byte[])eGWrdHbxtPZf38tuqAlx(debugRawStream);
				}
				default:
					return null;
				}
			}
		}
		set
		{
			int num = 3;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 4:
						UNGAlkbxp1OVV5rYKHDy(aj6SlgbxwD1RH70RAkYV(this), 0L, SeekOrigin.Begin);
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num2 = 5;
						}
						break;
					case 3:
						if (value != null)
						{
							DebugRawStream = (MemoryStream)cjVe1ybxNhC3hfy5rUWu(value.Length);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
							{
								num2 = 1;
							}
							break;
						}
						goto end_IL_0012;
					case 2:
						DebugRawStream = null;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 0;
						}
						break;
					case 5:
						return;
					case 1:
						L6OZAZbx3RLU03QPOZYj(DebugRawStream, value, 0, value.Length);
						num2 = 4;
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 2;
			}
		}
	}

	public virtual MemoryStream DebugRawStream
	{
		[CompilerGenerated]
		get
		{
			return _003CDebugRawStream_003Ek__BackingField;
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
					_003CDebugRawStream_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
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

	[Obsolete("Свойство устарело и больше не используется. Используйте DocumentationRawStream", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual byte[] DocumentationRaw
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					object obj = iNyuUMbx4p5Mk9JKpG3i(this);
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return (byte[])eGWrdHbxtPZf38tuqAlx(obj);
				}
				default:
					return null;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_0066, IL_0075
			int num = 5;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					UNGAlkbxp1OVV5rYKHDy(iNyuUMbx4p5Mk9JKpG3i(this), 0L, SeekOrigin.Begin);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					return;
				case 1:
					L6OZAZbx3RLU03QPOZYj(iNyuUMbx4p5Mk9JKpG3i(this), value, 0, value.Length);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 2;
					}
					break;
				default:
					DocumentationRawStream = null;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 6;
					}
					break;
				case 5:
					if (value != null)
					{
						num2 = 4;
						break;
					}
					goto default;
				case 6:
					return;
				case 4:
					DocumentationRawStream = (MemoryStream)cjVe1ybxNhC3hfy5rUWu(value.Length);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	public virtual MemoryStream DocumentationRawStream
	{
		[CompilerGenerated]
		get
		{
			return _003CDocumentationRawStream_003Ek__BackingField;
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
					_003CDocumentationRawStream_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
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

	public virtual AbstractMetadata[] RestoreMetadata()
	{
		//Discarded unreachable code: IL_007d, IL_01cc, IL_01db
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass43_0 _003C_003Ec__DisplayClass43_ = default(_003C_003Ec__DisplayClass43_0);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return cachedMetadata;
			case 5:
				cMMFeTbx7PbHSRaFtNlc(new Action(_003C_003Ec__DisplayClass43_._003CRestoreMetadata_003Eb__0));
				num2 = 9;
				break;
			default:
				_003C_003Ec__DisplayClass43_.container = null;
				num2 = 5;
				break;
			case 8:
				if (dLF4oqbx6a7S5DMLf8Ff(MetadataStream) != 0L)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 12;
			case 4:
				if (!_003C_003Ec__DisplayClass43_.xml.Contains((string)GRhQvybxAXcqB1hPpEQt(-281842504 ^ -281963300)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 11;
			case 11:
				_003C_003Ec__DisplayClass43_.xml = _003C_003Ec__DisplayClass43_.xml.Replace((string)GRhQvybxAXcqB1hPpEQt(0x12A5FAC7 ^ 0x12A702A3), (string)GRhQvybxAXcqB1hPpEQt(-1767720453 ^ -1767882405));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass43_ = new _003C_003Ec__DisplayClass43_0();
				num2 = 2;
				break;
			case 6:
				return cachedMetadata;
			case 12:
				return Array.Empty<AbstractMetadata>();
			case 10:
				if (cachedMetadata == null)
				{
					_003C_003Ec__DisplayClass43_.xml = (string)HqR1HtbxHa4Mg70ogrL4(MetadataStream, Encoding.UTF8);
					num2 = 4;
					break;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 7;
				}
				break;
			case 2:
				if (i7pAvcbxPyO6vRWWKN7L(this) != null)
				{
					num2 = 8;
					break;
				}
				goto case 12;
			case 9:
				cachedMetadata = (AbstractMetadata[])R1jdmhbxx3WlbCk1uOWf(_003C_003Ec__DisplayClass43_.container);
				num2 = 6;
				break;
			}
		}
	}

	public virtual void SetMetadata(AbstractMetadata[] metadata)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_;
		while (true)
		{
			switch (num2)
			{
			default:
				cachedMetadata = metadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				_003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
				_003C_003Ec__DisplayClass44_._003C_003E4__this = this;
				_003C_003Ec__DisplayClass44_.container = new MetadataContainer
				{
					Metadata = metadata
				};
				SR.LocalizableString.RunWithSRLocalizer(delegate
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							_003C_003Ec__DisplayClass44_0.T8wjdyC41jjyHEeRgZPC(_003C_003Ec__DisplayClass44_._003C_003E4__this, ClassSerializationHelper.SerializeObjectByXmlToMemoryStream(_003C_003Ec__DisplayClass44_.container));
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static explicit operator IRootMetadata[](AssemblyModelsMetadata assemblyModelsMetadata)
	{
		return assemblyModelsMetadata.RestoreMetadata().Cast<IRootMetadata>().ToArray();
	}

	public static explicit operator AssemblyModelsMetadata(IRootMetadata[] metadata)
	{
		AssemblyModelsMetadata assemblyModelsMetadata = new AssemblyModelsMetadata();
		xVX5xibx0Q6Fxg2iGIeU(assemblyModelsMetadata, metadata.Cast<AbstractMetadata>().ToArray());
		return assemblyModelsMetadata;
	}

	public virtual void Dispose()
	{
		//Discarded unreachable code: IL_006c
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 8:
				case 9:
				{
					MemoryStream debugRawStream = DebugRawStream;
					if (debugRawStream != null)
					{
						ayw9c9bxmPEJMq1VMpMi(debugRawStream);
						num2 = 7;
						break;
					}
					goto end_IL_0012;
				}
				case 4:
				case 11:
				{
					object obj2 = i7pAvcbxPyO6vRWWKN7L(this);
					if (obj2 == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 3;
						}
						break;
					}
					ayw9c9bxmPEJMq1VMpMi(obj2);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 0:
					return;
				case 1:
				{
					object obj = d1cfxkbxagOZjCwdOFhW(this);
					if (obj == null)
					{
						num2 = 9;
						break;
					}
					ayw9c9bxmPEJMq1VMpMi(obj);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 6;
					}
					break;
				}
				case 6:
					if (!disposed)
					{
						num2 = 5;
						break;
					}
					return;
				case 2:
					return;
				case 5:
					disposed = true;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 1;
					}
					break;
				case 7:
				case 10:
				{
					MemoryStream documentationRawStream = DocumentationRawStream;
					if (documentationRawStream == null)
					{
						num2 = 4;
						break;
					}
					ayw9c9bxmPEJMq1VMpMi(documentationRawStream);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 2;
					}
					break;
				}
				case 3:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 10;
		}
	}

	public virtual object Clone()
	{
		AssemblyModelsMetadata assemblyModelsMetadata = new AssemblyModelsMetadata();
		pOlT1ibxMXYxxNmF2bYP(assemblyModelsMetadata, Yp8iOObxyCQxZDnI1yWZ(this));
		k1rp6Mbx9aZmJO619Ugi(assemblyModelsMetadata, EuQZWybxJuxZLH9M4Cc4(this));
		okbplGbxDw50ltCiFt92(assemblyModelsMetadata, ((MemoryStream)d1cfxkbxagOZjCwdOFhW(this)).CloneMemoryStream());
		AJHLM9bxlOU7JTjcUeOg(assemblyModelsMetadata, vxcd6lbxdrqTeMteIcZq(aj6SlgbxwD1RH70RAkYV(this)));
		SPGOpJbxrGmEIFedZuJk(assemblyModelsMetadata, vxcd6lbxdrqTeMteIcZq(DocumentationRawStream));
		f7fL0jbx10vrbrbhwpSx(assemblyModelsMetadata, ((MemoryStream)i7pAvcbxPyO6vRWWKN7L(this)).CloneMemoryStream());
		return assemblyModelsMetadata;
	}

	public AssemblyModelsMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j8m2Wlbxg8bKxECa2id9();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool lGV0scbx25IAtBQgoWgW()
	{
		return LcLJ9rbxOCqs1wB7jQIR == null;
	}

	internal static AssemblyModelsMetadata VM4MGtbxexH25EJ5438O()
	{
		return LcLJ9rbxOCqs1wB7jQIR;
	}

	internal static object i7pAvcbxPyO6vRWWKN7L(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).MetadataStream;
	}

	internal static void f7fL0jbx10vrbrbhwpSx(object P_0, object P_1)
	{
		((AssemblyModelsMetadata)P_0).MetadataStream = (MemoryStream)P_1;
	}

	internal static object cjVe1ybxNhC3hfy5rUWu(int requiredSize)
	{
		return MemoryHelper.GetMemoryStream(requiredSize);
	}

	internal static void L6OZAZbx3RLU03QPOZYj(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static long UNGAlkbxp1OVV5rYKHDy(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static object d1cfxkbxagOZjCwdOFhW(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).AssemblyRawStream;
	}

	internal static void okbplGbxDw50ltCiFt92(object P_0, object P_1)
	{
		((AssemblyModelsMetadata)P_0).AssemblyRawStream = (MemoryStream)P_1;
	}

	internal static object eGWrdHbxtPZf38tuqAlx(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static object aj6SlgbxwD1RH70RAkYV(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).DebugRawStream;
	}

	internal static object iNyuUMbx4p5Mk9JKpG3i(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).DocumentationRawStream;
	}

	internal static long dLF4oqbx6a7S5DMLf8Ff(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object HqR1HtbxHa4Mg70ogrL4(object P_0, object P_1)
	{
		return ((MemoryStream)P_0).AsString((Encoding)P_1);
	}

	internal static object GRhQvybxAXcqB1hPpEQt(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void cMMFeTbx7PbHSRaFtNlc(object P_0)
	{
		SR.LocalizableString.RunWithSRLocalizer((Action)P_0);
	}

	internal static object R1jdmhbxx3WlbCk1uOWf(object P_0)
	{
		return ((MetadataContainer)P_0).Metadata;
	}

	internal static void xVX5xibx0Q6Fxg2iGIeU(object P_0, object P_1)
	{
		((AssemblyModelsMetadata)P_0).SetMetadata((AbstractMetadata[])P_1);
	}

	internal static void ayw9c9bxmPEJMq1VMpMi(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	internal static long Yp8iOObxyCQxZDnI1yWZ(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).Id;
	}

	internal static void pOlT1ibxMXYxxNmF2bYP(object P_0, long value)
	{
		((AssemblyModelsMetadata)P_0).Id = value;
	}

	internal static object EuQZWybxJuxZLH9M4Cc4(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).Name;
	}

	internal static void k1rp6Mbx9aZmJO619Ugi(object P_0, object P_1)
	{
		((AssemblyModelsMetadata)P_0).Name = (string)P_1;
	}

	internal static object vxcd6lbxdrqTeMteIcZq(object P_0)
	{
		return ((MemoryStream)P_0).CloneMemoryStream();
	}

	internal static void AJHLM9bxlOU7JTjcUeOg(object P_0, object P_1)
	{
		((AssemblyModelsMetadata)P_0).DebugRawStream = (MemoryStream)P_1;
	}

	internal static void SPGOpJbxrGmEIFedZuJk(object P_0, object P_1)
	{
		((AssemblyModelsMetadata)P_0).DocumentationRawStream = (MemoryStream)P_1;
	}

	internal static void j8m2Wlbxg8bKxECa2id9()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
