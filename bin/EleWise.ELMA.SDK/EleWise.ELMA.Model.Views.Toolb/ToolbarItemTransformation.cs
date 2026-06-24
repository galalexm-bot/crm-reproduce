using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Transformations.Struct;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Toolbar;

[Serializable]
[XmlInclude(typeof(ToolbarItemTransformationMove))]
[XmlInclude(typeof(ToolbarItemTransformationAdd))]
[XmlInclude(typeof(ToolbarItemTransformationHide))]
[XmlInclude(typeof(ToolbarItemTransformationChange))]
public class ToolbarItemTransformation : Transformation<ToolbarItem, ToolbarItemTransformation, Guid, ToolbarItemTransformationAdd, ToolbarItemTransformationMove, ToolbarItemTransformationHide, ToolbarItemTransformationChange>
{
	internal static ToolbarItemTransformation EtgjtKowCbxvZiIenrbC;

	protected internal override IList<ToolbarItem> GetSubItems(ToolbarItem item)
	{
		if (!(item is RootToolbarItem rootToolbarItem))
		{
			return new ToolbarItem[0];
		}
		return rootToolbarItem.Items;
	}

	protected internal override Guid GetUid(ToolbarItem item)
	{
		return lS5do2owZFA6py6K3fRE(item);
	}

	protected internal override bool IsHide(ToolbarItem item)
	{
		return false;
	}

	protected internal override void SetHide(ToolbarItem parentItem, ToolbarItem item, bool hide = true)
	{
		//Discarded unreachable code: IL_0121
		int num = 5;
		int num2 = num;
		RootToolbarItem rootToolbarItem2 = default(RootToolbarItem);
		RootToolbarItem rootToolbarItem = default(RootToolbarItem);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
				if (rootToolbarItem2 == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 10;
			case 7:
				((EventedList<ToolbarItem>)NVufKCowuxqlE0lKpnbs(rootToolbarItem)).Remove(_003C_003Ec__DisplayClass3_.item);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 9;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass3_.item = item;
				num2 = 2;
				break;
			case 10:
				((IEnumerable<ToolbarItem>)NVufKCowuxqlE0lKpnbs(rootToolbarItem2)).ToArray().Each(_003C_003Ec__DisplayClass3_._003CSetHide_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 8:
				return;
			case 2:
				rootToolbarItem = parentItem as RootToolbarItem;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				rootToolbarItem2 = _003C_003Ec__DisplayClass3_.item as RootToolbarItem;
				num2 = 6;
				break;
			case 1:
				if (rootToolbarItem != null)
				{
					num2 = 7;
					break;
				}
				goto case 9;
			case 4:
				_003C_003Ec__DisplayClass3_._003C_003E4__this = this;
				num2 = 3;
				break;
			case 5:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 4;
				break;
			}
		}
	}

	protected internal override ToolbarItem CreateCopy(ToolbarItem item)
	{
		//Discarded unreachable code: IL_0064, IL_0073
		int num = 3;
		int num2 = num;
		RootToolbarItem rootToolbarItem = default(RootToolbarItem);
		while (true)
		{
			switch (num2)
			{
			case 3:
				rootToolbarItem = item as RootToolbarItem;
				num2 = 2;
				break;
			case 2:
				if (rootToolbarItem != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				return Clone(item);
			default:
				return (ToolbarItem)zsyPMYowIxg8GiFafxVk(rootToolbarItem);
			}
		}
	}

	protected internal override ToolbarItem Clone(ToolbarItem item)
	{
		return ClassSerializationHelper.CloneObjectByXml(item);
	}

	public ToolbarItemTransformation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EES5AbowVFugADU04Lyh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid lS5do2owZFA6py6K3fRE(object P_0)
	{
		return ((ToolbarItem)P_0).Uid;
	}

	internal static object NVufKCowuxqlE0lKpnbs(object P_0)
	{
		return ((RootToolbarItem)P_0).Items;
	}

	internal static bool B4UNdfowvQtdr4iQe40k()
	{
		return EtgjtKowCbxvZiIenrbC == null;
	}

	internal static ToolbarItemTransformation Lk9LMHow8TdQbJqlOb3L()
	{
		return EtgjtKowCbxvZiIenrbC;
	}

	internal static object zsyPMYowIxg8GiFafxVk(object P_0)
	{
		return ((RootToolbarItem)P_0).CreateCopy();
	}

	internal static void EES5AbowVFugADU04Lyh()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
