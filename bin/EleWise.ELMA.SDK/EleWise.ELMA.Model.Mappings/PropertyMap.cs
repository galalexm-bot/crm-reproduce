using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Mappings;

[Serializable]
public class PropertyMap : EntityDTO<long>
{
	internal static PropertyMap sqqApahb3EpegqfooUyk;

	[XmlElement("LeftClassUid")]
	public virtual Guid LeftClassUid
	{
		[CompilerGenerated]
		get
		{
			return _003CLeftClassUid_003Ek__BackingField;
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
					_003CLeftClassUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
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

	[XmlElement("RightClassUid")]
	public virtual Guid RightClassUid
	{
		[CompilerGenerated]
		get
		{
			return _003CRightClassUid_003Ek__BackingField;
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
					_003CRightClassUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
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

	[XmlArray]
	public List<PropertyMapItem> Items { get; set; }

	public void Merge(ClassMetadata leftMetadata, Func<IPropertyMetadata, bool> clause)
	{
		List<Guid> list = new List<Guid>();
		FillProperties(list, leftMetadata, clause);
		Merge(list);
	}

	public void Merge(IEnumerable<Guid> uids)
	{
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.uids = uids;
		Items.AddRange(CS_0024_003C_003E8__locals0.uids.Where(delegate(Guid uid)
		{
			int num3 = 2;
			int num4 = num3;
			_003C_003Ec__DisplayClass13_1 _003C_003Ec__DisplayClass13_2 = default(_003C_003Ec__DisplayClass13_1);
			while (true)
			{
				switch (num4)
				{
				default:
					return !CS_0024_003C_003E8__locals0._003C_003E4__this.Items.Any(_003C_003Ec__DisplayClass13_2._003CMerge_003Eb__3);
				case 1:
					_003C_003Ec__DisplayClass13_2.uid = uid;
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num4 = 0;
					}
					break;
				case 2:
					_003C_003Ec__DisplayClass13_2 = new _003C_003Ec__DisplayClass13_1();
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num4 = 0;
					}
					break;
				}
			}
		}).Select(delegate(Guid uid)
		{
			PropertyMapItem propertyMapItem = new PropertyMapItem();
			_003C_003Ec.pJvO85CrWG1xjoJ9bpvB(propertyMapItem, uid);
			return propertyMapItem;
		}));
		Items.RemoveAll(delegate(PropertyMapItem i)
		{
			int num = 1;
			int num2 = num;
			_003C_003Ec__DisplayClass13_2 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_2);
			while (true)
			{
				switch (num2)
				{
				default:
					_003C_003Ec__DisplayClass13_.i = i;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return !CS_0024_003C_003E8__locals0.uids.Any(_003C_003Ec__DisplayClass13_._003CMerge_003Eb__4);
				case 1:
					_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_2();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
	}

	public void InitNew(ClassMetadata leftMetadata)
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
				Merge(leftMetadata, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PropertyMap Reverse()
	{
		PropertyMap obj = new PropertyMap
		{
			LeftClassUid = dy8lV2hbDlKoTEscHOt7(this)
		};
		XRxRIghbwq5OgnSSGvNt(obj, gvMlmPhbtBdYfVBffwMA(this));
		obj.Items.AddRange(Items.Select(delegate(PropertyMapItem i)
		{
			PropertyMapItem propertyMapItem = new PropertyMapItem();
			_003C_003Ec.pJvO85CrWG1xjoJ9bpvB(propertyMapItem, _003C_003Ec.as75O8CrovPBuNLf8VBg(i));
			_003C_003Ec.BKdoCoCrhCJoSbbbgunk(propertyMapItem, _003C_003Ec.ELXudVCrbLyEoejX2KCv(i));
			_003C_003Ec.pZ9PLgCrEbyhs8XNHCA4(propertyMapItem, _003C_003Ec.OQCIbNCrGfKtla6Vcp0R(i));
			propertyMapItem.RightValue = _003C_003Ec.kSVr66CrfZMXu67QVn57(i);
			propertyMapItem.ThisMarker = i.ThisMarker;
			propertyMapItem.ParentProperties = new List<PropertyMetadata>(i.ParentProperties);
			return propertyMapItem;
		}));
		return obj;
	}

	public PropertyMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KFAJrJhb4Z59x9AVltUW();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
		{
			num = 1;
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
				Items = new List<PropertyMapItem>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private static void FillProperties(List<Guid> allUids, object m, Func<IPropertyMetadata, bool> clause)
	{
		_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_0();
		CS_0024_003C_003E8__locals0.clause = clause;
		allUids.AddRange(from p in ((ClassMetadata)m).Properties.Where(delegate(PropertyMetadata p)
			{
				//Discarded unreachable code: IL_002d, IL_003c
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (CS_0024_003C_003E8__locals0.clause == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 2;
					case 2:
						return CS_0024_003C_003E8__locals0.clause(p);
					default:
						return true;
					}
				}
			})
			select _003C_003Ec.XoqqVsCrQuqMYBcRpfh3(p));
		if (!(m is EntityMetadata entityMetadata))
		{
			return;
		}
		foreach (TablePartMetadata tablePart in entityMetadata.TableParts)
		{
			if (CS_0024_003C_003E8__locals0.clause == null || CS_0024_003C_003E8__locals0.clause(tablePart))
			{
				allUids.Add(tablePart.TablePartPropertyUid);
				FillProperties(allUids, tablePart, CS_0024_003C_003E8__locals0.clause);
			}
		}
	}

	internal static bool UMOG1chbpaOv92R2fasD()
	{
		return sqqApahb3EpegqfooUyk == null;
	}

	internal static PropertyMap zhOaXbhbaI06wMfGsANM()
	{
		return sqqApahb3EpegqfooUyk;
	}

	internal static Guid dy8lV2hbDlKoTEscHOt7(object P_0)
	{
		return ((PropertyMap)P_0).RightClassUid;
	}

	internal static Guid gvMlmPhbtBdYfVBffwMA(object P_0)
	{
		return ((PropertyMap)P_0).LeftClassUid;
	}

	internal static void XRxRIghbwq5OgnSSGvNt(object P_0, Guid value)
	{
		((PropertyMap)P_0).RightClassUid = value;
	}

	internal static void KFAJrJhb4Z59x9AVltUW()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
