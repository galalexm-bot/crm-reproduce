using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[Component]
public class TableView : IXsiRoot
{
	private static TableView n6nVIQo1Yg85c5MbL23E;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
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

	[DefaultValue(ViewType.Custom)]
	public ViewType ViewType
	{
		[CompilerGenerated]
		get
		{
			return _003CViewType_003Ek__BackingField;
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
					_003CViewType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(true)]
	public bool Pageable
	{
		[CompilerGenerated]
		get
		{
			return _003CPageable_003Ek__BackingField;
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
					_003CPageable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(15)]
	public int PageSize
	{
		[CompilerGenerated]
		get
		{
			return _003CPageSize_003Ek__BackingField;
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
					_003CPageSize_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(true)]
	public bool Customizable
	{
		[CompilerGenerated]
		get
		{
			return _003CCustomizable_003Ek__BackingField;
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
					_003CCustomizable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(true)]
	public bool ShowHeader
	{
		[CompilerGenerated]
		get
		{
			return _003CShowHeader_003Ek__BackingField;
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
					_003CShowHeader_003Ek__BackingField = value;
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

	[DefaultValue(false)]
	public bool Resizeable
	{
		[CompilerGenerated]
		get
		{
			return _003CResizeable_003Ek__BackingField;
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
					_003CResizeable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
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
	public bool Reorderable
	{
		[CompilerGenerated]
		get
		{
			return _003CReorderable_003Ek__BackingField;
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
					_003CReorderable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
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

	[DefaultValue(true)]
	public bool Sortable
	{
		[CompilerGenerated]
		get
		{
			return _003CSortable_003Ek__BackingField;
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
					_003CSortable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(null)]
	public List<TableViewSortDescriptor> SortDescriptors { get; set; }

	[DefaultValue(false)]
	public bool Groupable
	{
		[CompilerGenerated]
		get
		{
			return _003CGroupable_003Ek__BackingField;
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
					_003CGroupable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool GroupableExpand
	{
		[CompilerGenerated]
		get
		{
			return _003CGroupableExpand_003Ek__BackingField;
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
					_003CGroupableExpand_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
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

	[DefaultValue(null)]
	public List<TableViewGroupDescriptor> GroupDescriptors { get; set; }

	[DefaultValue(false)]
	public bool CanAdd
	{
		[CompilerGenerated]
		get
		{
			return _003CCanAdd_003Ek__BackingField;
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
					_003CCanAdd_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
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
	public bool CanEdit
	{
		[CompilerGenerated]
		get
		{
			return _003CCanEdit_003Ek__BackingField;
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
					_003CCanEdit_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool CanDelete
	{
		[CompilerGenerated]
		get
		{
			return _003CCanDelete_003Ek__BackingField;
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
					_003CCanDelete_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(TableRowEditMode.PopUp)]
	public virtual TableRowEditMode AddRowMode
	{
		[CompilerGenerated]
		get
		{
			return _003CAddRowMode_003Ek__BackingField;
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
					_003CAddRowMode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(TableRowEditMode.PopUpAndTable)]
	public virtual TableRowEditMode EditRowMode
	{
		[CompilerGenerated]
		get
		{
			return _003CEditRowMode_003Ek__BackingField;
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
					_003CEditRowMode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
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

	public TableView()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		J9x4y8o1sRa5R8fv4Vst();
		base._002Ector();
		int num = 5;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				ShowHeader = true;
				num = 6;
				break;
			case 5:
				ViewType = ViewType.Custom;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num = 2;
				}
				break;
			case 4:
				Pageable = true;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num = 2;
				}
				break;
			case 3:
				t59giLo1cQgebqHE684b(this, TableRowEditMode.PopUp);
				num = 8;
				break;
			case 8:
				EditRowMode = TableRowEditMode.PopUpAndTable;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num = 1;
				}
				break;
			case 6:
				Sortable = true;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				PageSize = 15;
				num = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num = 4;
				}
				break;
			case 1:
				return;
			case 7:
				Customizable = true;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeSortDescriptors()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return wV2KdCo1zeXjCIGvPTp8(SortDescriptors) > 0;
			case 1:
				if (SortDescriptors == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeGroupDescriptors()
	{
		//Discarded unreachable code: IL_0063, IL_0072
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return GroupDescriptors.Count > 0;
			default:
				return false;
			case 1:
				if (GroupDescriptors == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	internal static void J9x4y8o1sRa5R8fv4Vst()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void t59giLo1cQgebqHE684b(object P_0, TableRowEditMode value)
	{
		((TableView)P_0).AddRowMode = value;
	}

	internal static bool AQ15Y0o1LRHyf4hwPV5X()
	{
		return n6nVIQo1Yg85c5MbL23E == null;
	}

	internal static TableView g08tXNo1U4MnDJci7wsB()
	{
		return n6nVIQo1Yg85c5MbL23E;
	}

	internal static int wV2KdCo1zeXjCIGvPTp8(object P_0)
	{
		return ((List<TableViewSortDescriptor>)P_0).Count;
	}
}
