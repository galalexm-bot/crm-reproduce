namespace EleWise.ELMA.Model.Views;

public static class ViewItemExtensions
{
	private static ViewItemExtensions YhLCfmoKWWZ3Q35sl60i;

	public static bool IsReadOnly(this ViewItem viewItem)
	{
		//Discarded unreachable code: IL_0071, IL_0080, IL_00e0
		int num = 1;
		int num2 = num;
		bool? flag3 = default(bool?);
		bool? flag5 = default(bool?);
		bool? flag = default(bool?);
		while (true)
		{
			bool? flag2;
			bool? flag4;
			switch (num2)
			{
			case 7:
			{
				if (viewItem == null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				RootViewItem parent = viewItem.Parent;
				if (parent == null)
				{
					num2 = 9;
					continue;
				}
				flag2 = cUE0gIoKhxfZKHjPFU2E(parent);
				break;
			}
			case 2:
				if (flag3.HasValue)
				{
					num2 = 3;
					continue;
				}
				goto case 4;
			case 4:
				return false;
			case 3:
				return flag3.GetValueOrDefault();
			case 5:
				if (flag5.HasValue)
				{
					return flag5.GetValueOrDefault();
				}
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 7;
				}
				continue;
			case 6:
				flag2 = flag;
				break;
			case 8:
				flag = null;
				num2 = 6;
				continue;
			case 9:
				flag = null;
				num2 = 11;
				continue;
			default:
				flag3 = null;
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 6;
				}
				continue;
			case 1:
			{
				IReadOnlyViewItem obj = viewItem as IReadOnlyViewItem;
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				flag4 = obj.ReadOnly;
				goto IL_015e;
			}
			case 10:
				flag4 = flag3;
				goto IL_015e;
			case 11:
				{
					flag2 = flag;
					break;
				}
				IL_015e:
				flag5 = flag4;
				num2 = 5;
				continue;
			}
			flag3 = flag2;
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
			{
				num2 = 2;
			}
		}
	}

	internal static bool cUE0gIoKhxfZKHjPFU2E(object P_0)
	{
		return ((RootViewItem)P_0).IsReadOnly();
	}

	internal static bool lJVLA7oKoGZ7ga97MSUN()
	{
		return YhLCfmoKWWZ3Q35sl60i == null;
	}

	internal static ViewItemExtensions BuODZWoKbHCaFEFNEjr3()
	{
		return YhLCfmoKWWZ3Q35sl60i;
	}
}
