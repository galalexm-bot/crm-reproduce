using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

public class FormViewBuilder<TModel>
{
	private RootViewItem view;

	private ClassMetadata metadata;

	private IFormNotifier notifier;

	private PropertyViewInfoContainer propertyContainer;

	private static object FPQDKgoPjRxZF5YGg0GG;

	public IFormNotifier Notifier
	{
		get
		{
			int num = 1;
			int num2 = num;
			IFormNotifier formNotifier = default(IFormNotifier);
			IFormNotifier formNotifier2;
			while (true)
			{
				switch (num2)
				{
				default:
					formNotifier = (notifier = DynamicFormHelper.GetContextFormNotifier());
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					formNotifier2 = notifier;
					if (formNotifier2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					formNotifier2 = formNotifier;
					break;
				}
				break;
			}
			return formNotifier2;
		}
	}

	public FormViewBuilder(RootViewItem view, ClassMetadata metadata)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(view, metadata, (PropertyViewInfoContainer)null);
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

	public FormViewBuilder(RootViewItem view, ClassMetadata metadata, PropertyViewInfoContainer propertyContainer)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 3:
				if (metadata == null)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num = 0;
					}
					break;
				}
				this.view = view;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num = 2;
				}
				break;
			case 1:
				return;
			default:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7F7B2C));
			case 4:
				this.propertyContainer = propertyContainer;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num = 1;
				}
				break;
			case 2:
				this.metadata = metadata;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num = 3;
				}
				break;
			}
		}
	}

	public PropertyViewItemBuilder<TModel, TValue> For<TValue>(Expression<Func<TModel, TValue>> expression)
	{
		return For(expression, null);
	}

	public PropertyViewItemBuilder<TModel, TValue> For<TValue>(Expression<Func<TModel, TValue>> expression, string name)
	{
		_003C_003Ec__DisplayClass3_0<TValue> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0<TValue>();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.name = name;
		CS_0024_003C_003E8__locals0.memberExpression = expression.Body as MemberExpression;
		if (CS_0024_003C_003E8__locals0.memberExpression == null)
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269C3C32), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633621787)));
		}
		IEnumerable<IPropertyMetadata> enumerable2;
		if (!(metadata is EntityMetadata))
		{
			IEnumerable<IPropertyMetadata> enumerable = metadata.Properties.Cast<IPropertyMetadata>().ToList();
			enumerable2 = enumerable;
		}
		else
		{
			enumerable2 = ((EntityMetadata)metadata).GetPropertiesAndTableParts();
		}
		IEnumerable<IPropertyMetadata> source = enumerable2;
		CS_0024_003C_003E8__locals0.propertyMetadata = source.FirstOrDefault((IPropertyMetadata p) => p.Name == CS_0024_003C_003E8__locals0.memberExpression.Member.Name);
		if (CS_0024_003C_003E8__locals0.propertyMetadata == null)
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146371591), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867076827), CS_0024_003C_003E8__locals0.memberExpression.Member.Name));
		}
		if (view != null && string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals0.name) && view.GetAllProperties(ignoreHide: false).All((PropertyViewItem p) => p.PropertyUid != CS_0024_003C_003E8__locals0.propertyMetadata.PropertyUid))
		{
			DefaultContainerViewItem defaultContainerViewItem = (from i in view.GetAllItems(ignoreHide: false).OfType<DefaultContainerViewItem>()
				orderby i.CheckPropertyAddOrder
				select i).FirstOrDefault((DefaultContainerViewItem i) => i.CheckPropertyAdd(CS_0024_003C_003E8__locals0._003C_003E4__this.metadata));
			if (defaultContainerViewItem != null)
			{
				PropertyViewItem propertyViewItem = defaultContainerViewItem.CreatePropertyViewItem();
				propertyViewItem.PropertyUid = CS_0024_003C_003E8__locals0.propertyMetadata.PropertyUid;
				RootViewItem rootViewItem = defaultContainerViewItem.Parent;
				if (rootViewItem is ColumnsLayoutViewItem)
				{
					rootViewItem = (RootViewItem)rootViewItem.Items.FirstOrDefault((ViewItem i) => !i.Hide);
				}
				((rootViewItem is ColumnViewItem) ? rootViewItem : view).Items.Add(propertyViewItem);
			}
			else
			{
				PropertyViewItem item = new PropertyViewItem
				{
					PropertyUid = CS_0024_003C_003E8__locals0.propertyMetadata.PropertyUid,
					Hide = true
				};
				view.Items.Add(item);
			}
		}
		return new PropertyViewItemBuilder<TModel, TValue>(null, CS_0024_003C_003E8__locals0.propertyMetadata, view?.GetAllProperties(ignoreHide: false).Where(delegate(PropertyViewItem p)
		{
			//Discarded unreachable code: IL_0035, IL_005a, IL_0069
			int num = 4;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						return p.Name == CS_0024_003C_003E8__locals0.name;
					default:
						return true;
					case 3:
						return false;
					case 4:
						if (!(p.PropertyUid == CS_0024_003C_003E8__locals0.propertyMetadata.PropertyUid))
						{
							break;
						}
						goto case 2;
					case 2:
						if (string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals0.name))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 1;
					}
					break;
				}
				num = 3;
			}
		}).ToArray(), propertyContainer);
	}

	public PropertyViewItemBuilder<TModel, object> ForAll()
	{
		return new PropertyViewItemBuilder<TModel, object>(metadata, null, view?.GetAllProperties().ToArray(), propertyContainer);
	}

	public void ClosePopup()
	{
		DynamicFormHelper.ClosePopup = true;
	}

	internal static bool irmY2yoPYVR0ZnZAC1rJ()
	{
		return FPQDKgoPjRxZF5YGg0GG == null;
	}

	internal static object lAi8pKoPLHGLPgRAHvNA()
	{
		return FPQDKgoPjRxZF5YGg0GG;
	}
}
