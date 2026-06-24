using System;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

public class PropertyViewItemBuilder<TModel, TValue>
{
	private ClassMetadata classMetadata;

	private IPropertyMetadata propertyMetadata;

	private PropertyViewItem[] viewItems;

	private PropertyViewInfoContainer propertyContainer;

	private static object Sl36GToPzDLwkLF0Qy6C;

	public ValidationPropertyViewItemBuilder<TModel, TValue> Validation { get; private set; }

	public PropertyViewItemBuilder(ClassMetadata classMetadata, IPropertyMetadata propertyMetadata, PropertyViewItem viewItem)
	{
		//Discarded unreachable code: IL_0036, IL_003b
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(classMetadata, propertyMetadata, new PropertyViewItem[1] { viewItem });
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
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
			Validation = new ValidationPropertyViewItemBuilder<TModel, TValue>(classMetadata, propertyMetadata, new PropertyViewItem[1] { viewItem });
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
			{
				num = 0;
			}
		}
	}

	public PropertyViewItemBuilder(ClassMetadata classMetadata, IPropertyMetadata propertyMetadata, PropertyViewItem[] viewItems)
	{
		//Discarded unreachable code: IL_002e, IL_0033
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(classMetadata, propertyMetadata, viewItems, (PropertyViewInfoContainer)null);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PropertyViewItemBuilder(ClassMetadata classMetadata, IPropertyMetadata propertyMetadata, PropertyViewItem[] viewItems, PropertyViewInfoContainer propertyContainer)
	{
		//Discarded unreachable code: IL_001a
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 5:
				this.propertyMetadata = propertyMetadata;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 1:
				this.viewItems = viewItems;
				num = 4;
				break;
			case 3:
			{
				this.classMetadata = classMetadata;
				int num2 = 5;
				num = num2;
				break;
			}
			case 4:
				Validation = new ValidationPropertyViewItemBuilder<TModel, TValue>(classMetadata, propertyMetadata, viewItems, propertyContainer);
				num = 2;
				break;
			case 2:
				this.propertyContainer = propertyContainer;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public PropertyViewItemBuilder<TModel, TValue> ReadOnly(bool readOnly = true)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.readOnly = readOnly;
		UpdatePropertyInfo(delegate(PropertyViewInfo info)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 1:
					info.ReadOnly = CS_0024_003C_003E8__locals0.readOnly;
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num4 = 0;
					}
					break;
				case 0:
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
				case 1:
					i.Attributes.ReadOnly = CS_0024_003C_003E8__locals0.readOnly;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				default:
					i.SetReadOnly(CS_0024_003C_003E8__locals0.readOnly);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		return this;
	}

	public PropertyViewItemBuilder<TModel, TValue> Required(bool required = true)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0.required = required;
		UpdatePropertyInfo(delegate(PropertyViewInfo info)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					info.Required = CS_0024_003C_003E8__locals0.required;
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
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
				case 1:
					i.Attributes.Required = CS_0024_003C_003E8__locals0.required;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
		return this;
	}

	public PropertyViewItemBuilder<TModel, TValue> Visible(bool visible = true)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.visible = visible;
		UpdatePropertyInfo(delegate(PropertyViewInfo info)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					info.Visible = CS_0024_003C_003E8__locals0.visible;
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num4 = 0;
					}
					break;
				}
			}
		});
		UpdateViewItems(delegate(PropertyViewItem i)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					i.Attributes.Visible = CS_0024_003C_003E8__locals0.visible;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				case 1:
					i.SetVisible(CS_0024_003C_003E8__locals0.visible);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
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
			//Discarded unreachable code: IL_00a7
			int num = 4;
			int num2 = num;
			PropertyViewInfo propertyViewInfo = default(PropertyViewInfo);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					if (propertyViewInfo == null)
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 1:
					action(propertyViewInfo);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 4:
					propertyViewInfo = propertyContainer.Get(propertyName);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 3;
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

	internal static bool q3G3b8o1FbMmnpUl7LGq()
	{
		return Sl36GToPzDLwkLF0Qy6C == null;
	}

	internal static object eOfqFYo1BUc1lGPZWNFU()
	{
		return Sl36GToPzDLwkLF0Qy6C;
	}
}
