using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Web.Mvc.Menu;

namespace EleWise.ELMA.BPM.Web.Content.Menu;

public static class StartMenuHelper
{
	public class GroupItemPositions
	{
		public class GroupItemPosition
		{
			public int ItemIndex { get; private set; }

			public bool TwoRows { get; private set; }

			public int ColSpan { get; private set; }

			internal GroupItemPosition(int itemIndex, bool twoRows, int colSpan)
			{
				ItemIndex = itemIndex;
				TwoRows = twoRows;
				ColSpan = colSpan;
			}
		}

		internal class GroupItemPositionsBuilder
		{
			internal List<GroupItemPosition> positions = new List<GroupItemPosition>();

			public GroupItemPositionsBuilder Item(int itemIndex, int colSpan = 1)
			{
				positions.Add(new GroupItemPosition(itemIndex, twoRows: false, colSpan));
				return this;
			}

			public GroupItemPositionsBuilder Item2(int itemIndex, int colSpan = 1)
			{
				positions.Add(new GroupItemPosition(itemIndex, twoRows: true, colSpan));
				return this;
			}
		}

		public GroupItemPosition[] Row1 { get; private set; }

		public GroupItemPosition[] Row2 { get; private set; }

		internal GroupItemPositions Row(Action<GroupItemPositionsBuilder> b)
		{
			GroupItemPositionsBuilder groupItemPositionsBuilder = new GroupItemPositionsBuilder();
			b?.Invoke(groupItemPositionsBuilder);
			if (Row1 == null)
			{
				Row1 = groupItemPositionsBuilder.positions.ToArray();
			}
			else if (Row2 == null)
			{
				Row2 = groupItemPositionsBuilder.positions.ToArray();
			}
			return this;
		}
	}

	public const int MaxGroupColumns = 5;

	public const int MaxRowColumns = 9;

	private static T Max<T>(this IEnumerable<T> source, T defaultValue)
	{
		if (!source.Any())
		{
			return defaultValue;
		}
		return source.Max();
	}

	public static void CalculateStartMenuGroups(this List<MenuItemNode> treeItems, out List<int> groupsColumns, out int row1Groups, out int row1Columns, out int row2Groups, out int row2Columns)
	{
		List<int> gColumns = treeItems.Select((MenuItemNode i) => Math.Min((i.Items.Count((MenuItemNode ii) => !ii.Disabled) + 1) / 2, 5)).ToList();
		int num = gColumns.Sum();
		int num2 = (num + 1) / 2;
		int r1Columns = 0;
		int r1Groups;
		for (r1Groups = 0; r1Groups < gColumns.Count && r1Columns + gColumns[r1Groups] <= 9; r1Groups++)
		{
			if (gColumns[r1Groups] > num2)
			{
				if (r1Columns + gColumns[r1Groups] > num - r1Columns || r1Groups >= gColumns.Count)
				{
					break;
				}
				Action action = delegate
				{
					r1Columns += gColumns[r1Groups];
					r1Groups++;
				};
				if (r1Columns + gColumns[r1Groups] < num - r1Columns)
				{
					action();
				}
				else if (r1Groups * 2 + 1 == gColumns.Count)
				{
					if (gColumns.Take(r1Groups).Max(0) >= gColumns.Skip(r1Groups + 1).Max(0))
					{
						action();
					}
				}
				else if (r1Groups < gColumns.Count - r1Groups)
				{
					action();
				}
				break;
			}
			num2 -= gColumns[r1Groups];
			r1Columns += gColumns[r1Groups];
		}
		int r2Groups = gColumns.Count - r1Groups;
		int r2Columns = num - r1Columns;
		if (r2Columns > 9)
		{
			r2Groups = 0;
			for (r2Columns = 0; r2Columns + gColumns[r1Groups + r2Groups] <= 9; r2Groups++)
			{
				r2Columns += gColumns[r1Groups + r2Groups];
			}
			Action action2 = delegate
			{
				r1Columns -= gColumns[r1Groups - 1];
				r2Columns += gColumns[r1Groups - 1];
				r1Groups--;
				r2Groups++;
			};
			if (r1Columns - gColumns[r1Groups - 1] > r2Columns)
			{
				action2();
			}
			else if (r1Columns - gColumns[r1Groups - 1] == r2Columns)
			{
				if (r1Groups == r2Groups + 1)
				{
					if (gColumns.Take(r1Groups - 1).Max(0) < gColumns.Skip(r1Groups).Take(r2Groups).Max(0))
					{
						action2();
					}
				}
				else if (r1Groups > r2Groups + 1)
				{
					action2();
				}
			}
		}
		if (r1Columns < 3 && r2Columns < 3)
		{
			r1Groups = gColumns.Count;
			r1Columns = num;
			r2Groups = 0;
			r2Columns = 0;
		}
		groupsColumns = gColumns;
		row1Groups = r1Groups;
		row1Columns = r1Columns;
		row2Groups = r2Groups;
		row2Columns = r2Columns;
	}

	public static void CalculateStartMenuGroups(this List<MenuItemNode> treeItems, out int[] row1GroupsColumns, out int[] row2GroupsColumns)
	{
		treeItems.CalculateStartMenuGroups(out var groupsColumns, out var row1Groups, out var row1Columns, out var row2Groups, out var row2Columns);
		Func<int, int, int, int> func = delegate(int i, int maxAdd, int add)
		{
			if (groupsColumns[i] + maxAdd > 5)
			{
				add -= 5 - groupsColumns[i];
				groupsColumns[i] = 5;
			}
			else
			{
				groupsColumns[i] += maxAdd;
				add -= maxAdd;
			}
			return add;
		};
		if (row1Columns < row2Columns)
		{
			int num = row2Columns - row1Columns;
			int arg = (num + row1Groups - 1) / row1Groups;
			int num2 = row1Groups - 1;
			while (num2 >= 0 && num > 0)
			{
				num = func(num2, arg, num);
				num2--;
			}
		}
		else if (row2Groups > 0 && row1Columns > row2Columns)
		{
			int num3 = row1Columns - row2Columns;
			int arg2 = (num3 + row2Groups - 1) / row2Groups;
			int num4 = row1Groups + row2Groups - 1;
			while (num4 >= row1Groups && num3 > 0)
			{
				num3 = func(num4, arg2, num3);
				num4--;
			}
		}
		row1GroupsColumns = groupsColumns.Take(row1Groups).ToArray();
		row2GroupsColumns = groupsColumns.Skip(row1Groups).Take(row2Groups).ToArray();
	}

	public static GroupItemPositions GetGroupItemPositions(this List<MenuItemNode> treeItems, int columns)
	{
		if (columns == 0 || treeItems.Count == 0)
		{
			return new GroupItemPositions();
		}
		switch (columns)
		{
		case 1:
		{
			int count = treeItems.Count;
			if (count == 1)
			{
				return new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0);
				});
			}
			return new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
			{
				b.Item(0);
			}).Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
			{
				b.Item(1);
			});
		}
		case 2:
			return treeItems.Count switch
			{
				1 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0, 2);
				}), 
				2 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0).Item2(1);
				}), 
				3 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(0).Item(1);
				}).Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(2, 2);
				}), 
				_ => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(0).Item(1);
				}).Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(2).Item(3);
				}), 
			};
		case 3:
			return treeItems.Count switch
			{
				1 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0, 3);
				}), 
				2 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0, 2).Item2(1);
				}), 
				3 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0).Item2(1).Item2(2);
				}), 
				4 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0).Item(1).Item2(3);
				}).Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(2);
				}), 
				5 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(0).Item(1).Item2(4);
				}).Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(2).Item(3);
				}), 
				_ => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(0).Item(1).Item(2);
				}).Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(3).Item(4).Item(5);
				}), 
			};
		case 4:
			return treeItems.Count switch
			{
				1 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0, 4);
				}), 
				2 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0, 2).Item2(1, 2);
				}), 
				3 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0).Item2(1, 2).Item2(2);
				}), 
				4 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0).Item2(1).Item2(2)
						.Item2(3);
				}), 
				5 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0).Item(1).Item(2)
						.Item2(4);
				}).Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(3, 2);
				}), 
				6 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0).Item(1).Item(2)
						.Item2(5);
				}).Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(3).Item(4);
				}), 
				7 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(0).Item(1).Item(2)
						.Item2(6);
				}).Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(3).Item(4).Item(5);
				}), 
				_ => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(0).Item(1).Item(2)
						.Item(3);
				}).Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(4).Item(5).Item(6)
						.Item(7);
				}), 
			};
		default:
			return treeItems.Count switch
			{
				1 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0, 5);
				}), 
				2 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0, 3).Item2(1, 2);
				}), 
				3 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0).Item2(1, 3).Item2(2);
				}), 
				4 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0).Item2(1).Item2(2)
						.Item2(3, 2);
				}), 
				5 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0).Item2(1).Item2(2)
						.Item2(3)
						.Item2(4);
				}), 
				6 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0).Item2(1).Item(2)
						.Item2(4)
						.Item2(5);
				}).Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(3);
				}), 
				7 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0).Item2(1).Item(2)
						.Item(3)
						.Item2(6);
				}).Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(4).Item(5);
				}), 
				8 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item2(0).Item(1).Item(2)
						.Item(3)
						.Item2(7);
				}).Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(4).Item(5).Item(6);
				}), 
				9 => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(0).Item(1).Item(2)
						.Item(3)
						.Item2(8);
				}).Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(4).Item(5).Item(6)
						.Item(7);
				}), 
				_ => new GroupItemPositions().Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(0).Item(1).Item(2)
						.Item(3)
						.Item(4);
				}).Row(delegate(GroupItemPositions.GroupItemPositionsBuilder b)
				{
					b.Item(5).Item(6).Item(7)
						.Item(8)
						.Item(9);
				}), 
			};
		}
	}
}
