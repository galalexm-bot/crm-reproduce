using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Modules.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[XmlRoot("AssemblyInfo")]
public class AssemblyInfoMetadata : NamedMetadata, IRootMetadata, IMetadata, IXsiType
{
	[Component]
	private class Info : IMetadataTypeInfo
	{
		internal static object z0yuKQCwaacCHB1UFnu5;

		public string Name => (string)jjWj9TCw4aJZyhreCnQB(sxEyN7Cwwmda3k2Kg2QA(-420743386 ^ -420586762));

		public string Description => string.Empty;

		public Type MetadataType => mU6GbjCw6MMZBpa7T4Wp(typeof(AssemblyInfoMetadata).TypeHandle);

		public Type GeneratorType => typeof(AssemblyInfoGenerator);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			o2Eh9PCwH5js2Y6qw8DN();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object sxEyN7Cwwmda3k2Kg2QA(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object jjWj9TCw4aJZyhreCnQB(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool YiVnWdCwDjcxOFtyacrX()
		{
			return z0yuKQCwaacCHB1UFnu5 == null;
		}

		internal static Info LmM049CwtOXcsG9tK5oB()
		{
			return (Info)z0yuKQCwaacCHB1UFnu5;
		}

		internal static Type mU6GbjCw6MMZBpa7T4Wp(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void o2Eh9PCwH5js2Y6qw8DN()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private SR.LocalizableString summary;

	internal static AssemblyInfoMetadata DqABqtbAdGIjMIIb0YYP;

	public virtual bool IsComVisible
	{
		[CompilerGenerated]
		get
		{
			return _003CIsComVisible_003Ek__BackingField;
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
					_003CIsComVisible_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual bool IsComponentAssembly
	{
		[CompilerGenerated]
		get
		{
			return _003CIsComponentAssembly_003Ek__BackingField;
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
					_003CIsComponentAssembly_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual bool IsModelAssembly
	{
		[CompilerGenerated]
		get
		{
			return _003CIsModelAssembly_003Ek__BackingField;
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
					_003CIsModelAssembly_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue("")]
	public virtual string FileVersion
	{
		[CompilerGenerated]
		get
		{
			return _003CFileVersion_003Ek__BackingField;
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
					_003CFileVersion_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
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

	[DefaultValue("")]
	public virtual string Company
	{
		[CompilerGenerated]
		get
		{
			return _003CCompany_003Ek__BackingField;
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
					_003CCompany_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue("")]
	public virtual string Summary
	{
		get
		{
			return summary;
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
					summary = (SR.LocalizableString)IcSESbbAg1dLFghDm61N(value);
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

	public void LoadFromType(Type type, bool inherit = true)
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
			case 2:
				if (X4ADsRbA5M45quU60mwS(type, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				}
				LoadFromAssembly(type.Assembly);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				throw new ArgumentNullException((string)i2i8v8bAjgudkpc7knWh(-420743386 ^ -420742396));
			}
		}
	}

	public void LoadFromAssembly(Assembly asm)
	{
		int num = 5;
		ComponentAssemblyAttribute attribute10 = default(ComponentAssemblyAttribute);
		AssemblySummaryAttribute attribute = default(AssemblySummaryAttribute);
		AssemblyCompanyAttribute attribute6 = default(AssemblyCompanyAttribute);
		AssemblyModuleAttribute attribute9 = default(AssemblyModuleAttribute);
		ComVisibleAttribute attribute2 = default(ComVisibleAttribute);
		ModelAssemblyAttribute attribute11 = default(ModelAssemblyAttribute);
		GuidAttribute attribute7 = default(GuidAttribute);
		AssemblyTitleAttribute attribute4 = default(AssemblyTitleAttribute);
		AssemblyDescriptionAttribute attribute3 = default(AssemblyDescriptionAttribute);
		AssemblyFileVersionAttribute attribute5 = default(AssemblyFileVersionAttribute);
		AssemblyModuleAttribute attribute8 = default(AssemblyModuleAttribute);
		while (true)
		{
			int num2 = num;
			Guid value;
			while (true)
			{
				switch (num2)
				{
				case 9:
					ouokxEb7bR14BoBJOvVb(this, attribute10 != null);
					num2 = 19;
					break;
				case 13:
					return;
				case 11:
					attribute = AttributeHelper<AssemblySummaryAttribute>.GetAttribute(asm);
					num2 = 7;
					break;
				case 14:
					attribute6 = AttributeHelper<AssemblyCompanyAttribute>.GetAttribute(asm);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 1;
					}
					break;
				case 22:
					attribute9 = AttributeHelper<AssemblyModuleAttribute>.GetAttribute(asm);
					num2 = 8;
					break;
				case 2:
					JiGevDbAcjhvGZTO98sX(this, L3MUkfbAskRSmYbyV46M(asm));
					num2 = 18;
					break;
				case 18:
					attribute2 = AttributeHelper<ComVisibleAttribute>.GetAttribute(asm);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					break;
				case 20:
					jeYagCb7he9PMpG5EJnR(this, attribute11 != null);
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 21;
					}
					break;
				case 19:
					attribute11 = AttributeHelper<ModelAssemblyAttribute>.GetAttribute(asm);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 20;
					}
					break;
				case 15:
					attribute10 = AttributeHelper<ComponentAssemblyAttribute>.GetAttribute(asm);
					num2 = 9;
					break;
				case 5:
					attribute7 = AttributeHelper<GuidAttribute>.GetAttribute(asm);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 4;
					}
					break;
				case 23:
					attribute4 = AttributeHelper<AssemblyTitleAttribute>.GetAttribute(asm);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 12;
					}
					break;
				case 10:
					attribute3 = AttributeHelper<AssemblyDescriptionAttribute>.GetAttribute(asm);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 21;
					}
					break;
				case 6:
					attribute5 = AttributeHelper<AssemblyFileVersionAttribute>.GetAttribute(asm);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 3;
					}
					break;
				case 17:
					attribute8 = AttributeHelper<AssemblyModuleAttribute>.GetAttribute(asm);
					num2 = 16;
					break;
				case 4:
					wkWhIKbALwAjrDZx6wsJ(this, (attribute7 != null) ? new Guid((string)GCIA7CbAYlWmXCyrqJIL(attribute7)) : Guid.Empty);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 17;
					}
					break;
				case 16:
					value = attribute8?.Uid ?? Guid.Empty;
					goto end_IL_0012;
				default:
					X48r9UbAzTjKVvV8M52A(this, attribute2?.Value ?? false);
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 23;
					}
					break;
				case 12:
					u0rasjb7BYtuT0Iqt2LM(this, (attribute4 != null) ? CqkTY0b7FRiv0SjKIcgJ(attribute4) : string.Empty);
					num2 = 10;
					break;
				case 21:
					vW6QhGb7oBT72GWnbFb1(this, (attribute3 != null) ? EiJcBdb7WWRiWAjIGFYJ(attribute3) : string.Empty);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 15;
					}
					break;
				case 8:
					Cll4K7bAUN7m10fOZbWI(this, (attribute9 != null) ? ReOsX7b7Gy78oQdC50hi(attribute9) : Guid.Empty);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 6;
					}
					break;
				case 3:
					o7B0Sob7ETalwFNBtMUK(this, (attribute5 != null) ? attribute5.Version : "");
					num2 = 14;
					break;
				case 1:
					Company = (string)((attribute6 != null) ? UlsIoob7ffFDp9kGWskk(attribute6) : "");
					num2 = 11;
					break;
				case 7:
					summary = (SR.LocalizableString)((attribute != null) ? attribute.LocalizedString : cCWnlFb7QTf1snS6VVZY());
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 13;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			Cll4K7bAUN7m10fOZbWI(this, value);
			num = 2;
		}
	}

	public virtual bool IsRestartNeeded(IRootMetadata metadata)
	{
		return true;
	}

	public virtual void ApplyRestartUnrequiredChanges(bool inherit)
	{
	}

	public AssemblyInfoMetadata()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		summary = (SR.LocalizableString)cCWnlFb7QTf1snS6VVZY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool qNRBxjbAlcxpsQbwYVHk()
	{
		return DqABqtbAdGIjMIIb0YYP == null;
	}

	internal static AssemblyInfoMetadata KXHYCcbAr8VlJJ1lBQGt()
	{
		return DqABqtbAdGIjMIIb0YYP;
	}

	internal static object IcSESbbAg1dLFghDm61N(object P_0)
	{
		return (SR.LocalizableString)(string)P_0;
	}

	internal static bool X4ADsRbA5M45quU60mwS(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object i2i8v8bAjgudkpc7knWh(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object GCIA7CbAYlWmXCyrqJIL(object P_0)
	{
		return ((GuidAttribute)P_0).Value;
	}

	internal static void wkWhIKbALwAjrDZx6wsJ(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).Uid = value;
	}

	internal static void Cll4K7bAUN7m10fOZbWI(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).ModuleUid = value;
	}

	internal static object L3MUkfbAskRSmYbyV46M(object P_0)
	{
		return ComponentManager.GetAssemblyShortName((Assembly)P_0);
	}

	internal static void JiGevDbAcjhvGZTO98sX(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static void X48r9UbAzTjKVvV8M52A(object P_0, bool value)
	{
		((AssemblyInfoMetadata)P_0).IsComVisible = value;
	}

	internal static object CqkTY0b7FRiv0SjKIcgJ(object P_0)
	{
		return ((AssemblyTitleAttribute)P_0).Title;
	}

	internal static void u0rasjb7BYtuT0Iqt2LM(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static object EiJcBdb7WWRiWAjIGFYJ(object P_0)
	{
		return ((AssemblyDescriptionAttribute)P_0).Description;
	}

	internal static void vW6QhGb7oBT72GWnbFb1(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Description = (string)P_1;
	}

	internal static void ouokxEb7bR14BoBJOvVb(object P_0, bool value)
	{
		((AssemblyInfoMetadata)P_0).IsComponentAssembly = value;
	}

	internal static void jeYagCb7he9PMpG5EJnR(object P_0, bool value)
	{
		((AssemblyInfoMetadata)P_0).IsModelAssembly = value;
	}

	internal static Guid ReOsX7b7Gy78oQdC50hi(object P_0)
	{
		return ((AssemblyModuleAttribute)P_0).Uid;
	}

	internal static void o7B0Sob7ETalwFNBtMUK(object P_0, object P_1)
	{
		((AssemblyInfoMetadata)P_0).FileVersion = (string)P_1;
	}

	internal static object UlsIoob7ffFDp9kGWskk(object P_0)
	{
		return ((AssemblyCompanyAttribute)P_0).Company;
	}

	internal static object cCWnlFb7QTf1snS6VVZY()
	{
		return SR.LocalizableString.Empty;
	}
}
