using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Mappings;

[Serializable]
public class PropertyMapItem : EntityDTO<long>
{
	[OptionalField]
	private object _leftValue;

	[OptionalField]
	private object _rightValue;

	internal static PropertyMapItem is3M8hhb6T2BbimBPnmI;

	[XmlElement("LeftPropertyUid")]
	public virtual Guid LeftPropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CLeftPropertyUid_003Ek__BackingField;
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
					_003CLeftPropertyUid_003Ek__BackingField = value;
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

	[XmlElement("LeftValue")]
	public virtual object LeftValue
	{
		get
		{
			return _leftValue;
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
					_leftValue = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("RightPropertyUid")]
	public virtual Guid RightPropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CRightPropertyUid_003Ek__BackingField;
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
					_003CRightPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("RightValue")]
	public virtual object RightValue
	{
		get
		{
			return _rightValue;
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
					_rightValue = value;
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

	[XmlArray]
	public List<PropertyMetadata> ParentProperties { get; set; }

	[XmlElement("ThisMarker")]
	public virtual bool ThisMarker
	{
		[CompilerGenerated]
		get
		{
			return _003CThisMarker_003Ek__BackingField;
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
					_003CThisMarker_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
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

	public PropertyMapItem()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		VmJjblhb7IXqRVxTYX8m();
		ParentProperties = new List<PropertyMetadata>();
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

	internal static bool upav7NhbHmXPBuIr8J1u()
	{
		return is3M8hhb6T2BbimBPnmI == null;
	}

	internal static PropertyMapItem iEtyK0hbAD91lKkMkY6C()
	{
		return is3M8hhb6T2BbimBPnmI;
	}

	internal static void VmJjblhb7IXqRVxTYX8m()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
