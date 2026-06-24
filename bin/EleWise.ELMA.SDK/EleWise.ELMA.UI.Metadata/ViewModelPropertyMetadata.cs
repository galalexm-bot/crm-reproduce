using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Metadata;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Свойство модели отображения')")]
[DataContract]
[Uid("{10A685EE-CCA1-4379-9A3C-A8294ADA90AB}")]
public class ViewModelPropertyMetadata : PropertyMetadata, IViewModelPropertyMetadata, IPropertyMetadata, INamedMetadata, IOrderedMetadata, IMetadata, IXsiType
{
	public const string UidS = "{10A685EE-CCA1-4379-9A3C-A8294ADA90AB}";

	public const string InputPrefix = "Input___";

	public const string OutputPrefix = "Output___";

	internal static ViewModelPropertyMetadata pfr0C7BGFgwPK7HR6dpr;

	[BoolSettings(FieldName = "ClientOnly")]
	[DefaultValue(false)]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[XmlElement("ClientOnly")]
	[Uid("{4289CACE-6470-4D03-B0E7-89CD59F02CC8}")]
	public virtual bool ClientOnly
	{
		[CompilerGenerated]
		get
		{
			return _003CClientOnly_003Ek__BackingField;
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
					_003CClientOnly_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
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

	[DefaultValue(false)]
	[XmlElement("Input")]
	[BoolSettings(FieldName = "Input")]
	[Uid("{91E42246-1BA5-4233-9154-A953239BCD87}")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	public virtual bool Input
	{
		[CompilerGenerated]
		get
		{
			return _003CInput_003Ek__BackingField;
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
					_003CInput_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[BoolSettings(FieldName = "Output")]
	[DefaultValue(false)]
	[Uid("{393AC91D-BF6A-419F-9D66-0CB7CE9626E3}")]
	[XmlElement("Output")]
	public virtual bool Output
	{
		[CompilerGenerated]
		get
		{
			return _003COutput_003Ek__BackingField;
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
					_003COutput_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
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

	[SimpleTypeSettings(FieldName = "ComputedValue")]
	[Property("{66C7898B-E56B-49E0-BFB8-9F9C4A7A0C52}")]
	[Uid("{7AC07C69-6EAD-4228-88D5-4E6BFD25B377}")]
	[XmlElement("ComputedValue")]
	public virtual ComputedValue ComputedValue
	{
		[CompilerGenerated]
		get
		{
			return _003CComputedValue_003Ek__BackingField;
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
					_003CComputedValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Uid("{1BFBBF0B-E024-499E-80A1-CFB500250C4D}")]
	[Property("{5C281E64-DDC8-4BC9-991A-84D9DC4E7649}")]
	[ListOfSimpleTypeSettings(FieldName = "ComputedValues")]
	[XmlElement("ComputedValues")]
	public virtual List<ComputedValue> ComputedValues { get; set; }

	public ViewModelPropertyMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				ComputedValues = new List<ComputedValue>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeComputedValue()
	{
		return s08LrXBGor2GhM7eQydU(this);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public virtual bool ShouldSerializeComputedValues()
	{
		return EgNe0gBGbayTd8k4vYfv(ComputedValues) > 0;
	}

	internal static bool EZM7tVBGBvujHQYawfoo()
	{
		return pfr0C7BGFgwPK7HR6dpr == null;
	}

	internal static ViewModelPropertyMetadata kywsHKBGWZRDxjmjmdKR()
	{
		return pfr0C7BGFgwPK7HR6dpr;
	}

	internal static bool s08LrXBGor2GhM7eQydU(object P_0)
	{
		return ((ViewModelPropertyMetadata)P_0).ClientOnly;
	}

	internal static int EgNe0gBGbayTd8k4vYfv(object P_0)
	{
		return ((List<ComputedValue>)P_0).Count;
	}
}
