using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class SubTypeDescriptor : ITypeDescriptor, IXsiType, IPublicApplicationTypeDescriptor
{
	private ITypeDescriptor baseTypeDescriptor;

	private Guid subTypeUid;

	private string name;

	private static SubTypeDescriptor VE7FLIolIRuOwhWjf4bd;

	public Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
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

	public Guid SubTypeUid => subTypeUid;

	public Guid ParentUid => Uid;

	public bool IsGroup => false;

	public string Name => name;

	public virtual bool Visible => true;

	public bool CanBeNullable
	{
		[CompilerGenerated]
		get
		{
			return _003CCanBeNullable_003Ek__BackingField;
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
					_003CCanBeNullable_003Ek__BackingField = value;
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

	public bool? DefaultNullableValue { get; set; }

	public Type SettingsType
	{
		[CompilerGenerated]
		get
		{
			return _003CSettingsType_003Ek__BackingField;
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
					_003CSettingsType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool UseForId => false;

	public bool UseForEntity
	{
		[CompilerGenerated]
		get
		{
			return _003CUseForEntity_003Ek__BackingField;
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
					_003CUseForEntity_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
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

	public virtual bool IsAvailibleEditPropertyTable => false;

	public SubTypeDescriptor(ITypeDescriptor baseTypeDescriptor, Guid subTypeUid, string name)
	{
		//Discarded unreachable code: IL_0033, IL_0038
		sQ3BmOoliHLEf98L59k4();
		this._002Ector(baseTypeDescriptor, i9ScV4olRCBcqidCP6uS(baseTypeDescriptor), subTypeUid, name);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
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
			E930GLolqhbVxTlyWKmx(baseTypeDescriptor, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EE8A4F));
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
			{
				num = 1;
			}
		}
	}

	public SubTypeDescriptor(ITypeDescriptor baseTypeDescriptor, Guid typeUid, Guid subTypeUid, string name)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		sQ3BmOoliHLEf98L59k4();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 2:
				SettingsType = i658gBolXVRNDSG3volE(baseTypeDescriptor);
				num = 9;
				break;
			case 9:
				UseForEntity = nUTHi7olThH53YtpNdEh(baseTypeDescriptor);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num = 0;
				}
				break;
			case 7:
				Uid = typeUid;
				num = 2;
				break;
			case 3:
				E930GLolqhbVxTlyWKmx(baseTypeDescriptor, wfjNI9olKt4h8f33lIX4(0x57A5235E ^ 0x57A7BC2E));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num = 1;
				}
				break;
			case 5:
				return;
			default:
				CanBeNullable = N9bikPolkB50iUvg838b(baseTypeDescriptor);
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num = 8;
				}
				break;
			case 4:
				this.name = name;
				num = 7;
				break;
			case 6:
				this.subTypeUid = subTypeUid;
				num = 4;
				break;
			case 8:
				DefaultNullableValue = baseTypeDescriptor.DefaultNullableValue;
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num = 5;
				}
				break;
			case 1:
				this.baseTypeDescriptor = baseTypeDescriptor;
				num = 6;
				break;
			}
		}
	}

	public bool IsVisibleForMetadata(ClassMetadata classMetadata)
	{
		return true;
	}

	public Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
	{
		return Guid.Empty;
	}

	public TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		return null;
	}

	public IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata)
	{
		return null;
	}

	public virtual bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		return val == null;
	}

	public virtual bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
	{
		return HpTf9VolnccDUmwwDVgP(this, propertyMetadata, val);
	}

	public bool HasRealColumn(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return true;
	}

	public bool IsPublicApplicationDisplayEnabled(Guid subTypeUid)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 3;
		int num2 = num;
		IPublicApplicationTypeDescriptor publicApplicationTypeDescriptor = default(IPublicApplicationTypeDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (publicApplicationTypeDescriptor == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				publicApplicationTypeDescriptor = baseTypeDescriptor as IPublicApplicationTypeDescriptor;
				num2 = 2;
				break;
			case 1:
				return publicApplicationTypeDescriptor.IsPublicApplicationDisplayEnabled(subTypeUid);
			default:
				return true;
			}
		}
	}

	public bool IsPublicApplicationEditorEnabled(Guid subTypeUid)
	{
		int num = 1;
		int num2 = num;
		IPublicApplicationTypeDescriptor publicApplicationTypeDescriptor = default(IPublicApplicationTypeDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 1:
				publicApplicationTypeDescriptor = baseTypeDescriptor as IPublicApplicationTypeDescriptor;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return MIOtbrolO1NIvgVIaCvf(publicApplicationTypeDescriptor, subTypeUid);
			}
			if (publicApplicationTypeDescriptor != null)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			return true;
		}
	}

	public void CheckPublicApplicationCompatibility(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, PropertyViewItem viewItem, string parentPropertyName, List<IPublicApplicationCompatibilityError> errors)
	{
		if (baseTypeDescriptor is IPublicApplicationTypeDescriptor publicApplicationTypeDescriptor)
		{
			publicApplicationTypeDescriptor.CheckPublicApplicationCompatibility(classMetadata, propertyMetadata, viewItem, parentPropertyName, errors);
		}
	}

	internal static void sQ3BmOoliHLEf98L59k4()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Guid i9ScV4olRCBcqidCP6uS(object P_0)
	{
		return ((ITypeDescriptor)P_0).Uid;
	}

	internal static void E930GLolqhbVxTlyWKmx(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool kN5l6volVNlfH0HM8Bor()
	{
		return VE7FLIolIRuOwhWjf4bd == null;
	}

	internal static SubTypeDescriptor JMB5twolSbdCF3xRgCMn()
	{
		return VE7FLIolIRuOwhWjf4bd;
	}

	internal static object wfjNI9olKt4h8f33lIX4(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type i658gBolXVRNDSG3volE(object P_0)
	{
		return ((ITypeDescriptor)P_0).SettingsType;
	}

	internal static bool nUTHi7olThH53YtpNdEh(object P_0)
	{
		return ((ITypeDescriptor)P_0).UseForEntity;
	}

	internal static bool N9bikPolkB50iUvg838b(object P_0)
	{
		return ((ITypeDescriptor)P_0).CanBeNullable;
	}

	internal static bool HpTf9VolnccDUmwwDVgP(object P_0, object P_1, object P_2)
	{
		return ((SubTypeDescriptor)P_0).IsEmpty((PropertyMetadata)P_1, P_2);
	}

	internal static bool MIOtbrolO1NIvgVIaCvf(object P_0, Guid subTypeUid)
	{
		return ((IPublicApplicationTypeDescriptor)P_0).IsPublicApplicationEditorEnabled(subTypeUid);
	}
}
