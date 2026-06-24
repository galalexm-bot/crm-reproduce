using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views.Toolbar;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class FormViewItemTransformation : ViewItemTransformation
{
	private readonly List<ViewItemTransformation> items;

	internal static FormViewItemTransformation tK6gEso1WwlRbaFkuXRu;

	[XmlElement("FormName")]
	public string FormName
	{
		[CompilerGenerated]
		get
		{
			return _003CFormName_003Ek__BackingField;
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
					_003CFormName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
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

	public Guid NewFormUid
	{
		[CompilerGenerated]
		get
		{
			return _003CNewFormUid_003Ek__BackingField;
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
					_003CNewFormUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
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
	public string NewFormName
	{
		[CompilerGenerated]
		get
		{
			return _003CNewFormName_003Ek__BackingField;
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
					_003CNewFormName_003Ek__BackingField = value;
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

	[DefaultValue(null)]
	public string NewFormDisplayName
	{
		[CompilerGenerated]
		get
		{
			return _003CNewFormDisplayName_003Ek__BackingField;
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
					_003CNewFormDisplayName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<ViewItemTransformation> Items => items;

	[DefaultValue(null)]
	public ToolbarItemTransformation ToolbarTransformation
	{
		[CompilerGenerated]
		get
		{
			return _003CToolbarTransformation_003Ek__BackingField;
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
					_003CToolbarTransformation_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeNewFormUid()
	{
		return Cn1qCYo1hWU7AvgYnOUQ(NewFormUid, Guid.Empty);
	}

	public FormViewItemTransformation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ufhadxo1GG51oLVg4BVP();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				items = new List<ViewItemTransformation>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void Apply(ViewItem formView)
	{
		//Discarded unreachable code: IL_0075, IL_0084, IL_0095, IL_009f, IL_0169, IL_017c, IL_018b, IL_019b, IL_01aa
		int num = 3;
		int num2 = num;
		List<ViewItemTransformation>.Enumerator enumerator = default(List<ViewItemTransformation>.Enumerator);
		ViewItemTransformation current = default(ViewItemTransformation);
		FormViewItem formViewItem = default(FormViewItem);
		EleWise.ELMA.Model.Views.Toolbar.Toolbar toolbar2 = default(EleWise.ELMA.Model.Views.Toolbar.Toolbar);
		while (true)
		{
			EleWise.ELMA.Model.Views.Toolbar.Toolbar toolbar;
			switch (num2)
			{
			case 14:
				return;
			default:
				try
				{
					while (true)
					{
						IL_00f6:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
							{
								num3 = 0;
							}
							goto IL_00a3;
						}
						goto IL_00c1;
						IL_00c1:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num3 = 0;
						}
						goto IL_00a3;
						IL_00a3:
						while (true)
						{
							switch (num3)
							{
							case 3:
								goto IL_00c1;
							case 4:
								current.Apply(formView);
								num3 = 2;
								continue;
							case 2:
								goto IL_00f6;
							case 1:
								if (current != null)
								{
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
									{
										num3 = 3;
									}
									continue;
								}
								goto IL_00f6;
							case 0:
								break;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			case 2:
				if (NewFormUid != Guid.Empty)
				{
					num2 = 8;
					continue;
				}
				goto case 15;
			case 16:
				SnfGIyo1Q0PCXvXG459h(formViewItem, toolbar2);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 3;
				}
				continue;
			case 4:
			case 11:
			case 18:
				enumerator = items.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 0;
				}
				continue;
			case 17:
				if (ToolbarTransformation == null)
				{
					num2 = 11;
					continue;
				}
				goto case 20;
			case 15:
				if (formViewItem == null)
				{
					num2 = 18;
					continue;
				}
				goto case 17;
			case 19:
				ToolbarTransformation.Apply(toolbar2);
				num2 = 6;
				continue;
			case 8:
				GhvL3xo1EwJLayV0bQWm(formView, NewFormUid);
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 9;
				}
				continue;
			case 12:
				toolbar2 = null;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 16;
				}
				continue;
			case 1:
				if (!lcgJVpo1CQruMm4cObeo(NewFormName))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 9;
			case 9:
				if (string.IsNullOrEmpty(NewFormDisplayName))
				{
					num2 = 14;
					continue;
				}
				goto case 7;
			case 5:
				hiTWado1vooGTfUqui8A(formView, NewFormName);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 9;
				}
				continue;
			case 7:
				NclZUDo18nNFmFoCE3G6((FormViewItem)formView, NewFormDisplayName);
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 10;
				}
				continue;
			case 10:
				return;
			case 6:
				if (!((IEnumerable<ToolbarItem>)r2HYuQo1fqaJsttgYH8O(toolbar2)).Any())
				{
					num2 = 12;
					continue;
				}
				goto case 16;
			case 3:
				formViewItem = formView as FormViewItem;
				num2 = 2;
				continue;
			case 20:
				toolbar = formViewItem.Toolbar;
				if (toolbar != null)
				{
					break;
				}
				num2 = 13;
				continue;
			case 13:
				toolbar = new EleWise.ELMA.Model.Views.Toolbar.Toolbar();
				break;
			}
			toolbar2 = toolbar;
			num2 = 19;
		}
	}

	public override IEnumerable<string> GetLocalizableStrings()
	{
		List<string> list = new List<string>();
		IEnumerable<string> localizableStrings = base.GetLocalizableStrings();
		if (localizableStrings != null)
		{
			list.AddRange(localizableStrings);
		}
		foreach (ViewItemTransformation item in items)
		{
			IEnumerable<string> localizableStrings2 = item.GetLocalizableStrings();
			if (localizableStrings2 == null)
			{
				continue;
			}
			foreach (string item2 in localizableStrings2)
			{
				if (!list.Contains(item2))
				{
					list.Add(item2);
				}
			}
		}
		return list;
	}

	public override void ApplyLocalization()
	{
		//Discarded unreachable code: IL_0079, IL_0088, IL_0093, IL_0115, IL_0128
		int num = 1;
		int num2 = num;
		List<ViewItemTransformation>.Enumerator enumerator = default(List<ViewItemTransformation>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 1:
				D30Hcjo1ZL3OpsZuTmSU(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				enumerator = items.GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
							{
								num3 = 1;
							}
							goto IL_0097;
						}
						goto IL_00d3;
						IL_00d3:
						enumerator.Current.ApplyLocalization();
						num3 = 2;
						goto IL_0097;
						IL_0097:
						switch (num3)
						{
						case 2:
							break;
						default:
							goto IL_00d3;
						case 1:
							return;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 3:
				return;
			}
		}
	}

	internal static bool fR8Gayo1o5DgpNqpCs73()
	{
		return tK6gEso1WwlRbaFkuXRu == null;
	}

	internal static FormViewItemTransformation Ql1qBto1bI1Y9a8SJ5Gr()
	{
		return tK6gEso1WwlRbaFkuXRu;
	}

	internal static bool Cn1qCYo1hWU7AvgYnOUQ(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void ufhadxo1GG51oLVg4BVP()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void GhvL3xo1EwJLayV0bQWm(object P_0, Guid value)
	{
		((ViewItem)P_0).Uid = value;
	}

	internal static object r2HYuQo1fqaJsttgYH8O(object P_0)
	{
		return ((RootToolbarItem)P_0).Items;
	}

	internal static void SnfGIyo1Q0PCXvXG459h(object P_0, object P_1)
	{
		((FormViewItem)P_0).Toolbar = (EleWise.ELMA.Model.Views.Toolbar.Toolbar)P_1;
	}

	internal static bool lcgJVpo1CQruMm4cObeo(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void hiTWado1vooGTfUqui8A(object P_0, object P_1)
	{
		((ViewItem)P_0).Name = (string)P_1;
	}

	internal static void NclZUDo18nNFmFoCE3G6(object P_0, object P_1)
	{
		((FormViewItem)P_0).DisplayName = (string)P_1;
	}

	internal static void D30Hcjo1ZL3OpsZuTmSU(object P_0)
	{
		((BaseTransformation<ViewItem, Guid>)P_0).ApplyLocalization();
	}
}
