using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Views.Builders;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Component(Order = int.MinValue)]
public class ReadOnlyAttributeTransformate : IFormViewItemTransformate
{
	internal static ReadOnlyAttributeTransformate Vynoj0okbKct9a5pvDNs;

	public FormViewItem Transformate(FormViewItem formViewItem, object model)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass0_.formViewItem = formViewItem;
				num2 = 3;
				break;
			case 3:
				if (!_003C_003Ec__DisplayClass0_.formViewItem.IsReadOnly())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 2;
					}
					break;
				}
				return _003C_003Ec__DisplayClass0_.formViewItem.Transformate(_003C_003Ec__DisplayClass0_._003CTransformate_003Eb__0);
			case 2:
				return _003C_003Ec__DisplayClass0_.formViewItem;
			}
		}
	}

	public ReadOnlyAttributeTransformate()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		z0KbaxokE7dYIc2lQB44();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool HGyvEgokhNY8ldJS7U9e()
	{
		return Vynoj0okbKct9a5pvDNs == null;
	}

	internal static ReadOnlyAttributeTransformate IFwW4gokGEvAZGBVbJkJ()
	{
		return Vynoj0okbKct9a5pvDNs;
	}

	internal static void z0KbaxokE7dYIc2lQB44()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
