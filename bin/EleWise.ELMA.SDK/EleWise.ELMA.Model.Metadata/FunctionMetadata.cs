using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Deploy.Attributes;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Signatures;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[Uid("{44D6296F-E38E-4704-ABD6-785CC856BAB9}")]
[DataContract]
[XmlExport]
public class FunctionMetadata : NamedMetadata, ICodeItemMetadata, IMetadata, IXsiType
{
	public const string UID_S = "{44D6296F-E38E-4704-ABD6-785CC856BAB9}";

	public static Guid UID;

	internal static FunctionMetadata XZfGIvbpSl2N0XPb7JP0;

	public Guid? ScriptUid { get; set; }

	public TypeSignature ReturnType
	{
		[CompilerGenerated]
		get
		{
			return _003CReturnType_003Ek__BackingField;
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
					_003CReturnType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
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

	public TypeSignature ParameterType
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
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

	public List<DataClassDependency> DataClassDependencies { get; set; }

	public List<EntityDependency> EntityDependencies { get; set; }

	public List<EnumDependency> EnumDependencies { get; set; }

	public string Namespace
	{
		[CompilerGenerated]
		get
		{
			return _003CNamespace_003Ek__BackingField;
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
					_003CNamespace_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
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

	public string NamespaceForDisplay
	{
		[CompilerGenerated]
		get
		{
			return _003CNamespaceForDisplay_003Ek__BackingField;
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
					_003CNamespaceForDisplay_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
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

	public string FullTypeName => (string)UY4gn9bpkj9ThJDVRNEB(Namespace, UG4An8bpTZxtlZODA5g1(0x48A7E34A ^ 0x48A7AC94), Name);

	public FunctionMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kyu5Spbpq9xjuxWoLX8P();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
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
				EnumDependencies = new List<EnumDependency>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				EntityDependencies = new List<EntityDependency>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				DataClassDependencies = new List<DataClassDependency>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num = 3;
				}
				break;
			}
		}
	}

	public FunctionMetadata(Guid moduleUid)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		this._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				TIrvLubpKo5aPChZOoFs(this, moduleUid);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num = 0;
				}
				break;
			default:
				lT971dbpXUErE1JajoZX(this, moduleUid != Guid.Empty);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public override void InitNew()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				base.InitNew();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				Namespace = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AE0837);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDataClassDependencies()
	{
		return DataClassDependencies.Count != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeEntityDependencies()
	{
		return fCJkaHbpnkZDpbGAwWef(EntityDependencies) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeEnumDependencies()
	{
		return J6DUdtbpOXCruRrV8xjp(EnumDependencies) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeScriptUid()
	{
		int num = 1;
		int num2 = num;
		Guid? scriptUid = default(Guid?);
		while (true)
		{
			switch (num2)
			{
			default:
				return scriptUid.HasValue;
			case 1:
				scriptUid = ScriptUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static FunctionMetadata()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x5117E99D));
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

	internal static void kyu5Spbpq9xjuxWoLX8P()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool B3bEEbbpiwm7fT6XBKKa()
	{
		return XZfGIvbpSl2N0XPb7JP0 == null;
	}

	internal static FunctionMetadata s8sjBpbpRAi2nmAyg5fq()
	{
		return XZfGIvbpSl2N0XPb7JP0;
	}

	internal static void TIrvLubpKo5aPChZOoFs(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).ModuleUid = value;
	}

	internal static void lT971dbpXUErE1JajoZX(object P_0, bool value)
	{
		((AbstractMetadata)P_0).Internal = value;
	}

	internal static object UG4An8bpTZxtlZODA5g1(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object UY4gn9bpkj9ThJDVRNEB(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static int fCJkaHbpnkZDpbGAwWef(object P_0)
	{
		return ((List<EntityDependency>)P_0).Count;
	}

	internal static int J6DUdtbpOXCruRrV8xjp(object P_0)
	{
		return ((List<EnumDependency>)P_0).Count;
	}
}
