using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.Diagrams;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

public class SwimlaneContextViewScheme
{
	[XmlType("SwimlaneContextViewSchemeItem")]
	public class Item
	{
		internal static Item djvU3xvsZXDqUDqJfdb2;

		public Guid PropertyUid
		{
			[CompilerGenerated]
			get
			{
				return _003CPropertyUid_003Ek__BackingField;
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
						_003CPropertyUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
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

		public bool IsCustom
		{
			[CompilerGenerated]
			get
			{
				return _003CIsCustom_003Ek__BackingField;
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
						_003CIsCustom_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Item()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			gA7iyyvs83EB3GSO81mB();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool gYea45vsv73PVSCbVJ4d()
		{
			return djvU3xvsZXDqUDqJfdb2 == null;
		}

		internal static Item mEZTC2vsY5ndx9OHySXk()
		{
			return djvU3xvsZXDqUDqJfdb2;
		}

		internal static void gA7iyyvs83EB3GSO81mB()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal static SwimlaneContextViewScheme g7fn30O9nPwGYSaxLON4;

	public Guid SwimlaneUid
	{
		[CompilerGenerated]
		get
		{
			return _003CSwimlaneUid_003Ek__BackingField;
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
					_003CSwimlaneUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<Item> Items { get; set; }

	public SwimlaneContextViewScheme()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		M9uxwtO9f64nUJ0757Ih();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
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
			Items = new List<Item>();
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
			{
				num = 1;
			}
		}
	}

	public void RefreshItemsFromTasks(WorkflowDiagram diagram)
	{
		int num = 9;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		List<Item> source = default(List<Item>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					PeZLhgO9WtrucITeGaNR(Items);
					num2 = 2;
					continue;
				case 9:
					_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
					num2 = 8;
					continue;
				case 7:
					Items.AddRange(source.Where(_003C_003Ec__DisplayClass10_._003CRefreshItemsFromTasks_003Eb__4));
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
					Contract.ArgumentNotNull(_003C_003Ec__DisplayClass10_.diagram, (string)K6g9GjO99xpHjgRqg5NN(0x6871CA ^ 0x6A71C0));
					num2 = 4;
					continue;
				case 8:
					_003C_003Ec__DisplayClass10_.diagram = diagram;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					return;
				case 4:
					source = Items.Where((Item i) => _003C_003Ec.Fa1sj5vscTXemaVlBwjO(i)).ToList();
					num2 = 6;
					continue;
				case 2:
					_003C_003Ec__DisplayClass10_.taskItemUids = ((IEnumerable)CcnI3JO9j8SI6eA5opS5(_003C_003Ec__DisplayClass10_.diagram)).OfType<BPMNFlowElement>().Where(_003C_003Ec__DisplayClass10_._003CRefreshItemsFromTasks_003Eb__1).SelectMany((BPMNFlowElement e) => e.GetVisiblePropertyUids())
						.Distinct()
						.ToList();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					Items.AddRange(_003C_003Ec__DisplayClass10_.taskItemUids.Select(delegate(Guid uid)
					{
						Item item = new Item();
						_003C_003Ec.r1dtMnvsPlrdfYtwxvIO(item, uid);
						return item;
					}));
					num2 = 7;
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass10_._003C_003E4__this = this;
			num = 3;
		}
	}

	internal static void M9uxwtO9f64nUJ0757Ih()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool MD48F1O9H44uFQu6Ge5h()
	{
		return g7fn30O9nPwGYSaxLON4 == null;
	}

	internal static SwimlaneContextViewScheme R4aDQ8O9LbrX1lBXiuA4()
	{
		return g7fn30O9nPwGYSaxLON4;
	}

	internal static object K6g9GjO99xpHjgRqg5NN(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void PeZLhgO9WtrucITeGaNR(object P_0)
	{
		((List<Item>)P_0).Clear();
	}

	internal static object CcnI3JO9j8SI6eA5opS5(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}
}
