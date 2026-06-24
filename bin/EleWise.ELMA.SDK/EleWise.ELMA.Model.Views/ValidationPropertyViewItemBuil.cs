using System;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

public class ValidationPropertyViewItemBuilder<TModel, TValue>
{
	private ClassMetadata classMetadata;

	private IPropertyMetadata propertyMetadata;

	private PropertyViewItem[] viewItems;

	private PropertyViewInfoContainer propertyContainer;

	private static object eTbHC1oTk3JbI3RlsIGO;

	public ValidationPropertyViewItemBuilder(ClassMetadata classMetadata, IPropertyMetadata propertyMetadata, PropertyViewItem viewItem)
	{
		//Discarded unreachable code: IL_0036, IL_003b
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(classMetadata, propertyMetadata, new PropertyViewItem[1] { viewItem });
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ValidationPropertyViewItemBuilder(ClassMetadata classMetadata, IPropertyMetadata propertyMetadata, PropertyViewItem[] viewItems)
	{
		//Discarded unreachable code: IL_002e, IL_0033
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(classMetadata, propertyMetadata, viewItems, (PropertyViewInfoContainer)null);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ValidationPropertyViewItemBuilder(ClassMetadata classMetadata, IPropertyMetadata propertyMetadata, PropertyViewItem[] viewItems, PropertyViewInfoContainer propertyContainer)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				this.viewItems = viewItems;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				this.propertyMetadata = propertyMetadata;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				this.propertyContainer = propertyContainer;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 4:
				this.classMetadata = classMetadata;
				num = 2;
				break;
			}
		}
	}

	public ValidationPropertyViewItemBuilder<TModel, TValue> Ok()
	{
		UpdatePropertyInfo(delegate(PropertyViewInfo info)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				case 1:
					info.IsValid = true;
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num4 = 0;
					}
					break;
				default:
					info.ValidationMessage = "";
					num4 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num4 = 0;
					}
					break;
				case 2:
					return;
				}
			}
		});
		UpdateViewItems(delegate(PropertyViewItem i)
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
					i.Attributes.ValidationError = "";
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		return this;
	}

	public ValidationPropertyViewItemBuilder<TModel, TValue> Error(string message)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0.message = message;
		if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.message))
		{
			CS_0024_003C_003E8__locals0.message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487266688));
		}
		UpdatePropertyInfo(delegate(PropertyViewInfo info)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					info.ValidationMessage = CS_0024_003C_003E8__locals0.message;
					num4 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num4 = 0;
					}
					break;
				case 2:
					return;
				case 1:
					info.IsValid = false;
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num4 = 0;
					}
					break;
				}
			}
		});
		UpdateViewItems(delegate(PropertyViewItem i)
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
					i.Attributes.ValidationError = CS_0024_003C_003E8__locals0.message;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		return this;
	}

	private void UpdatePropertyInfo(Action<PropertyViewInfo> action)
	{
		if (propertyContainer == null)
		{
			return;
		}
		if (propertyMetadata != null)
		{
			Update(propertyMetadata.Name);
		}
		else
		{
			if (classMetadata == null)
			{
				return;
			}
			foreach (PropertyMetadata property in classMetadata.Properties)
			{
				Update(property.Name);
			}
		}
		void Update(string propertyName)
		{
			int num = 2;
			int num2 = num;
			PropertyViewInfo propertyViewInfo = default(PropertyViewInfo);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (propertyViewInfo == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num2 = 3;
						}
					}
					else
					{
						action(propertyViewInfo);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 0;
						}
					}
					break;
				case 0:
					return;
				case 3:
					return;
				case 2:
					propertyViewInfo = propertyContainer.Get(propertyName);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	private void UpdateViewItems(Action<PropertyViewItem> action)
	{
		if (viewItems == null)
		{
			return;
		}
		PropertyViewItem[] array = viewItems;
		foreach (PropertyViewItem propertyViewItem in array)
		{
			if (propertyViewItem != null)
			{
				action(propertyViewItem);
			}
		}
	}

	internal static bool AC0QiCoTnFBZoL2kIUNw()
	{
		return eTbHC1oTk3JbI3RlsIGO == null;
	}

	internal static object GPLuUhoTODYteTVhvqUa()
	{
		return eTbHC1oTk3JbI3RlsIGO;
	}
}
