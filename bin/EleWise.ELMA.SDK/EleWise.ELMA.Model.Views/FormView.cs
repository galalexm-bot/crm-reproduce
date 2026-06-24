using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[Obsolete("Использовать FormViewItem")]
public class FormView : RootViewItem
{
	private static FormView B7TAr9oN4EY141DNrnPu;

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
				case 1:
					_003CViewType_003Ek__BackingField = value;
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

	[DefaultValue(false)]
	public bool CanUseCommonView
	{
		[CompilerGenerated]
		get
		{
			return _003CCanUseCommonView_003Ek__BackingField;
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
					_003CCanUseCommonView_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool CanUseCommonRazorView
	{
		[CompilerGenerated]
		get
		{
			return _003CCanUseCommonRazorView_003Ek__BackingField;
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
					_003CCanUseCommonRazorView_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool CanUseTabView
	{
		[CompilerGenerated]
		get
		{
			return _003CCanUseTabView_003Ek__BackingField;
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
					_003CCanUseTabView_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool CanUseTabRazorView
	{
		[CompilerGenerated]
		get
		{
			return _003CCanUseTabRazorView_003Ek__BackingField;
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
					_003CCanUseTabRazorView_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(true)]
	public bool UseStandartView
	{
		[CompilerGenerated]
		get
		{
			return _003CUseStandartView_003Ek__BackingField;
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
					_003CUseStandartView_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool UseRazorView
	{
		[CompilerGenerated]
		get
		{
			return _003CUseRazorView_003Ek__BackingField;
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
					_003CUseRazorView_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
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
	public bool ViewInTab
	{
		[CompilerGenerated]
		get
		{
			return _003CViewInTab_003Ek__BackingField;
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
					_003CViewInTab_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
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
	public bool ViewInCommon
	{
		[CompilerGenerated]
		get
		{
			return _003CViewInCommon_003Ek__BackingField;
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
					_003CViewInCommon_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue("")]
	[EleWise.ELMA.Globalization.Localizable]
	public string ViewInTabName
	{
		[CompilerGenerated]
		get
		{
			return _003CViewInTabName_003Ek__BackingField;
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
					_003CViewInTabName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue("")]
	public string RazorTabViewName
	{
		[CompilerGenerated]
		get
		{
			return _003CRazorTabViewName_003Ek__BackingField;
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
					_003CRazorTabViewName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue("")]
	public string RazorCommonViewName
	{
		[CompilerGenerated]
		get
		{
			return _003CRazorCommonViewName_003Ek__BackingField;
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
					_003CRazorCommonViewName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
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
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public string OnLoadScriptName
	{
		[CompilerGenerated]
		get
		{
			return _003COnLoadScriptName_003Ek__BackingField;
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
					_003COnLoadScriptName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
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

	public FormView()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lvTM4coNA6JR7Bke6BXK();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				UseStandartView = true;
				num = 2;
				break;
			case 1:
				ViewType = ViewType.Custom;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public FormView(ClassMetadata metadata, ViewType viewType, ItemType itemType)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_0067, IL_0076
		SingletonReader.JJCZtPuTvSt();
		this._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				if (metadata != null)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num = 3;
					}
					break;
				}
				return;
			case 4:
				return;
			case 2:
				ViewType = viewType;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 3:
				CreateItems(this, metadata, viewType, itemType);
				num = 4;
				break;
			}
		}
	}

	public FormView CloneAsReadOnly()
	{
		FormView formView = ClassSerializationHelper.CloneObjectByXml(this);
		LcCw79oN7TvyhG8W6hwb(formView, true);
		return formView;
	}

	public virtual void CheckPublicApplicationCompatibility([NotNull] ClassMetadata metadata, [NotNull] IEnumerable<IPropertyMetadata> properties, [NotNull] List<IPublicApplicationCompatibilityError> errors)
	{
		if (properties == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103D8E17));
		}
		if (errors == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16631395));
		}
		if (!string.IsNullOrEmpty(OnLoadScriptName))
		{
			errors.Add(new PublicApplicationCompatibilityError
			{
				Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123753996))
			});
		}
		CheckPublicApplicationCompatibility(this, metadata, properties, null, errors);
	}

	private void CreateItems(RootViewItem parent, ClassMetadata metadata, ViewType viewType, ItemType itemType)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_0059, IL_0068, IL_00de, IL_00ed, IL_01d0, IL_01df, IL_02cc, IL_02db, IL_031a, IL_0329, IL_038c, IL_03ab, IL_03ba, IL_03e7, IL_03f8
		int num = 1;
		int num2 = num;
		IEnumerator<IPropertyMetadata> enumerator = default(IEnumerator<IPropertyMetadata>);
		IPropertyMetadata current = default(IPropertyMetadata);
		ViewAttribute viewAttribute = default(ViewAttribute);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		PropertyViewItem propertyViewItem = default(PropertyViewItem);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		IEnumerable<IPropertyMetadata> enumerable2 = default(IEnumerable<IPropertyMetadata>);
		while (true)
		{
			IEnumerable<IPropertyMetadata> enumerable;
			switch (num2)
			{
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!NYXknPoNrTNUICuxgU5j(enumerator))
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
							{
								num3 = 15;
							}
							goto IL_0077;
						}
						goto IL_0210;
						IL_0210:
						current = enumerator.Current;
						num3 = 8;
						goto IL_0077;
						IL_0077:
						while (true)
						{
							switch (num3)
							{
							case 19:
								viewAttribute = (ViewAttribute)px7lBHoNJKXjGZe9gOP3(propertyMetadata.ViewSettings, viewType, itemType);
								num3 = 2;
								continue;
							case 10:
								nxHXikoN9BxeAbVu1G3v(JpDh6moNm9dPWLlGaRMX(propertyViewItem), viewAttribute.Visible);
								num3 = 18;
								continue;
							case 14:
								if (propertyMetadata == null)
								{
									int num4 = 7;
									num3 = num4;
									continue;
								}
								goto case 19;
							case 20:
								CoIVtPoNMss6Aejya6Os(JpDh6moNm9dPWLlGaRMX(propertyViewItem), jrp5NBoNyhyeCnM5G4r2(current));
								num3 = 16;
								continue;
							case 21:
								((EventedList<ViewItem>)dGsjiboNlrAw4uh3N9Cj(parent)).Add((ViewItem)propertyViewItem);
								num3 = 6;
								continue;
							case 7:
							case 13:
								((ViewAttributes)JpDh6moNm9dPWLlGaRMX(propertyViewItem)).ReadOnly = viewType == ViewType.Display;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
								{
									num3 = 0;
								}
								continue;
							case 6:
								tablePartMetadata = current as TablePartMetadata;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
								{
									num3 = 5;
								}
								continue;
							case 4:
								break;
							case 11:
								goto IL_0210;
							case 5:
								if (tablePartMetadata != null)
								{
									num3 = 12;
									continue;
								}
								break;
							case 8:
							{
								PropertyViewItem propertyViewItem2 = new PropertyViewItem();
								AQ1rlBoN0FEPs41YIevN(propertyViewItem2, Vlm13loNxL2XHw0MkO2W(current));
								propertyViewItem = propertyViewItem2;
								num3 = 20;
								continue;
							}
							case 16:
								propertyMetadata = current as PropertyMetadata;
								num3 = 14;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
								{
									num3 = 4;
								}
								continue;
							case 12:
								CreateItems(this, tablePartMetadata, viewType, itemType);
								num3 = 4;
								continue;
							case 2:
								if (viewAttribute == null)
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 10;
							default:
								if (JsGlh5oNdgs5eKL5HbDk(JpDh6moNm9dPWLlGaRMX(propertyViewItem)))
								{
									num3 = 21;
									continue;
								}
								goto case 6;
							case 1:
							case 3:
								((ViewAttributes)JpDh6moNm9dPWLlGaRMX(propertyViewItem)).ReadOnly = viewType == ViewType.Display;
								num3 = 17;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
								{
									num3 = 0;
								}
								continue;
							case 18:
								propertyViewItem.Attributes.ReadOnly = viewAttribute.ReadOnly;
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
								{
									num3 = 9;
								}
								continue;
							case 15:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num5 = 0;
						}
						goto IL_0390;
					}
					goto IL_03c5;
					IL_03c5:
					enumerator.Dispose();
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num5 = 2;
					}
					goto IL_0390;
					IL_0390:
					switch (num5)
					{
					default:
						goto end_IL_036b;
					case 0:
						goto end_IL_036b;
					case 1:
						break;
					case 2:
						goto end_IL_036b;
					}
					goto IL_03c5;
					end_IL_036b:;
				}
			case 5:
				enumerable = enumerable2;
				break;
			case 4:
				return;
			case 3:
				enumerable2 = metadata.Properties.Cast<IPropertyMetadata>().ToList();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 5;
				}
				continue;
			case 1:
				if (metadata is EntityMetadata)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			default:
				enumerable = ((EntityMetadata)metadata).GetPropertiesAndTableParts();
				break;
			}
			enumerator = enumerable.GetEnumerator();
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
			{
				num2 = 2;
			}
		}
	}

	private static void CheckPublicApplicationCompatibility(object viewItem, object metadata, IEnumerable<IPropertyMetadata> properties, object parentPropertyName, List<IPublicApplicationCompatibilityError> errors)
	{
		if (viewItem == null)
		{
			return;
		}
		using IEnumerator<PropertyViewItem> enumerator = ((RootViewItem)viewItem).Items.OfType<PropertyViewItem>().GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass57_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass57_0();
			CS_0024_003C_003E8__locals0.propViewItem = enumerator.Current;
			IPropertyMetadata propertyMetadata = properties.FirstOrDefault((IPropertyMetadata p) => _003C_003Ec__DisplayClass57_0.aLEkWpCvh4CrEExcOcLP(_003C_003Ec__DisplayClass57_0.KwV8D5CvolKqKxPtKKnJ(p), _003C_003Ec__DisplayClass57_0.IaH9MWCvbJDcCnqCGeJq(CS_0024_003C_003E8__locals0.propViewItem)));
			if (propertyMetadata == null)
			{
				continue;
			}
			string text = ((!string.IsNullOrEmpty((string)parentPropertyName)) ? ((string)parentPropertyName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFEE2AE)) : "") + propertyMetadata.DisplayName;
			PropertyMetadata propertyMetadata2 = propertyMetadata as PropertyMetadata;
			ITablePartMetadata tablePartMetadata = propertyMetadata as ITablePartMetadata;
			if (propertyMetadata2 != null)
			{
				ITypeDescriptor typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid);
				if (typeDescriptor == null)
				{
					errors.Add(new PublicApplicationCompatibilityError
					{
						Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC32058), text)
					});
					continue;
				}
				if (!(typeDescriptor is IPublicApplicationTypeDescriptor publicApplicationTypeDescriptor))
				{
					_003C_003Ec__DisplayClass57_1 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass57_1();
					CS_0024_003C_003E8__locals2.typeCode = string.Concat(typeDescriptor.Uid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638401429), typeDescriptor.SubTypeUid);
					PublicAppTypeCompatibilityError publicAppTypeCompatibilityError = errors.OfType<PublicAppTypeCompatibilityError>().FirstOrDefault((PublicAppTypeCompatibilityError e) => _003C_003Ec__DisplayClass57_1.XBehjBCvCmkw39shm0yi(_003C_003Ec__DisplayClass57_1.NPyRJrCvQOTf8lktl7iR(e), CS_0024_003C_003E8__locals2.typeCode));
					if (publicAppTypeCompatibilityError != null)
					{
						publicAppTypeCompatibilityError.PropertyNames.Add(text);
					}
					else
					{
						IPropertyTypeInfo propertyTypeInfo = typeDescriptor as IPropertyTypeInfo;
						publicAppTypeCompatibilityError = new PublicAppTypeCompatibilityError(CS_0024_003C_003E8__locals2.typeCode, (propertyTypeInfo != null) ? propertyTypeInfo.GetPropertyTypeDisplayName(propertyMetadata2) : typeDescriptor.Name, null, text);
						errors.Add(publicAppTypeCompatibilityError);
					}
				}
				else
				{
					publicApplicationTypeDescriptor.CheckPublicApplicationCompatibility((ClassMetadata)metadata, propertyMetadata2, CS_0024_003C_003E8__locals0.propViewItem, (string)parentPropertyName, errors);
				}
			}
			else if (tablePartMetadata != null)
			{
				if (!CS_0024_003C_003E8__locals0.propViewItem.IsReadOnly())
				{
					_003C_003Ec__DisplayClass57_2 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass57_2();
					CS_0024_003C_003E8__locals1.typeCode = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68B9DD12);
					PublicAppTypeCompatibilityError publicAppTypeCompatibilityError2 = errors.OfType<PublicAppTypeCompatibilityError>().FirstOrDefault((PublicAppTypeCompatibilityError e) => _003C_003Ec__DisplayClass57_2.veqjjcCvIurGlPPVMoR8(e.TypeCode, CS_0024_003C_003E8__locals1.typeCode));
					if (publicAppTypeCompatibilityError2 != null)
					{
						publicAppTypeCompatibilityError2.PropertyNames.Add(text);
					}
					else
					{
						publicAppTypeCompatibilityError2 = new PublicAppTypeCompatibilityError(CS_0024_003C_003E8__locals1.typeCode, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A74B22)), false, text);
						errors.Add(publicAppTypeCompatibilityError2);
					}
				}
				ClassMetadata classMetadata = (ClassMetadata)tablePartMetadata;
				IEnumerable<IPropertyMetadata> enumerable2;
				if (!(tablePartMetadata is IEntityMetadata entityMetadata))
				{
					IEnumerable<IPropertyMetadata> enumerable = classMetadata.Properties.Cast<IPropertyMetadata>().ToArray();
					enumerable2 = enumerable;
				}
				else
				{
					enumerable2 = entityMetadata.GetPropertiesAndTableParts();
				}
				IEnumerable<IPropertyMetadata> properties2 = enumerable2;
				CheckPublicApplicationCompatibility(CS_0024_003C_003E8__locals0.propViewItem, classMetadata, properties2, text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A5CF2B), errors);
			}
			if (!CS_0024_003C_003E8__locals0.propViewItem.IsReadOnly() && !string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.propViewItem.Attributes.OnChangeScriptName))
			{
				PublicAppPropertyScriptError publicAppPropertyScriptError = errors.OfType<PublicAppPropertyScriptError>().FirstOrDefault((PublicAppPropertyScriptError e) => _003C_003Ec.Mr3Rs6CvXMuO2JPhs0ub(_003C_003Ec.Il2QvICvqc1sYXOx6ycW(e), _003C_003Ec.xy25fiCvKSgnogp4laQx(0x5DD55050 ^ 0x5DD738D8)));
				if (publicAppPropertyScriptError != null)
				{
					publicAppPropertyScriptError.PropertyNames.Add(text);
					continue;
				}
				publicAppPropertyScriptError = new PublicAppPropertyScriptError(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345299636), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C22ECB)), text);
				errors.Add(publicAppPropertyScriptError);
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem == null;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}

	internal static void lvTM4coNA6JR7Bke6BXK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool gjfOipoN6MAL8nOlfAHH()
	{
		return B7TAr9oN4EY141DNrnPu == null;
	}

	internal static FormView WjstUboNH1RS4dBX9O8Z()
	{
		return B7TAr9oN4EY141DNrnPu;
	}

	internal static void LcCw79oN7TvyhG8W6hwb(object P_0, bool value)
	{
		((ViewItem)P_0).SetReadOnly(value);
	}

	internal static Guid Vlm13loNxL2XHw0MkO2W(object P_0)
	{
		return ((IPropertyMetadata)P_0).PropertyUid;
	}

	internal static void AQ1rlBoN0FEPs41YIevN(object P_0, Guid value)
	{
		((PropertyViewItem)P_0).PropertyUid = value;
	}

	internal static object JpDh6moNm9dPWLlGaRMX(object P_0)
	{
		return ((PropertyViewItem)P_0).Attributes;
	}

	internal static bool jrp5NBoNyhyeCnM5G4r2(object P_0)
	{
		return ((IPropertyMetadata)P_0).Required;
	}

	internal static void CoIVtPoNMss6Aejya6Os(object P_0, bool value)
	{
		((ViewAttributes)P_0).Required = value;
	}

	internal static object px7lBHoNJKXjGZe9gOP3(object P_0, ViewType viewType, ItemType itemType)
	{
		return ((PropertyViewSettings)P_0).GetForView(viewType, itemType);
	}

	internal static void nxHXikoN9BxeAbVu1G3v(object P_0, bool value)
	{
		((ViewAttributes)P_0).Visible = value;
	}

	internal static bool JsGlh5oNdgs5eKL5HbDk(object P_0)
	{
		return ((ViewAttributes)P_0).Visible;
	}

	internal static object dGsjiboNlrAw4uh3N9Cj(object P_0)
	{
		return ((RootViewItem)P_0).Items;
	}

	internal static bool NYXknPoNrTNUICuxgU5j(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}
}
