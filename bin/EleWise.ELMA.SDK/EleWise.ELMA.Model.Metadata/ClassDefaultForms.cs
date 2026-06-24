using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
public class ClassDefaultForms
{
	[OptionalField]
	private List<ActionForm> actionGuids;

	private ClassMetadata owner;

	[OptionalField]
	private List<DefaultFormSetting> formSettings;

	internal static ClassDefaultForms iGjGRBbthoaxn88GVXgT;

	public Guid CreateUid
	{
		[CompilerGenerated]
		get
		{
			return _003CCreateUid_003Ek__BackingField;
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
					_003CCreateUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid EditUid
	{
		[CompilerGenerated]
		get
		{
			return _003CEditUid_003Ek__BackingField;
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
					_003CEditUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
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

	public Guid DisplayUid
	{
		[CompilerGenerated]
		get
		{
			return _003CDisplayUid_003Ek__BackingField;
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
					_003CDisplayUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
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

	public List<ActionForm> ActionGuids
	{
		get
		{
			return actionGuids;
		}
		set
		{
			actionGuids = value;
		}
	}

	public List<DefaultFormSetting> FormSettings
	{
		get
		{
			return formSettings;
		}
		set
		{
			formSettings = value;
		}
	}

	public FormViewItem Create => GetForm(CreateUid);

	public FormViewItem Edit => GetForm(EditUid);

	public FormViewItem Display => GetForm(DisplayUid);

	public ClassDefaultForms()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		k7LFTRbtfmBulZ2mwbxh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				FormSettings = new List<DefaultFormSetting>();
				num = 2;
				continue;
			case 2:
				return;
			}
			ActionGuids = new List<ActionForm>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
			{
				num = 0;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerialize()
	{
		//Discarded unreachable code: IL_00a0, IL_00af, IL_00c8
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (ShouldSerializeEditUid())
					{
						goto end_IL_0012;
					}
					goto case 3;
				case 3:
					if (!ylScGIbtCnWRj0vjU0XD(this))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				case 1:
					if (!cUB5kfbtQlZHBwOCnbNp(this))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				case 4:
					return DRkefXbt8ydiJE3BFJlB(this);
				case 5:
				case 6:
					return true;
				case 2:
					if (RYungUbtvWxu2iO7P9wc(this))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeCreateUid()
	{
		return CreateUid != Guid.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeEditUid()
	{
		return EditUid != Guid.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeDisplayUid()
	{
		return GOi8vSbtZgAEIB0SXK2P(DisplayUid, Guid.Empty);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeActionGuids()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (ActionGuids != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return XwykP5btuKcgyNfJVeQX(ActionGuids) > 0;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeFormSettings()
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return FormSettings.Count > 0;
			case 1:
				return false;
			case 2:
				if (FormSettings == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	public List<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>> ToDictionary()
	{
		List<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>> list = new List<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>>();
		if (CreateUid != Guid.Empty)
		{
			list.Add(new Tuple<ViewType, Guid, Guid, Guid, Guid, bool>(ViewType.Create, Guid.Empty, CreateUid, Guid.Empty, Guid.Empty, item6: false));
		}
		if (EditUid != Guid.Empty)
		{
			list.Add(new Tuple<ViewType, Guid, Guid, Guid, Guid, bool>(ViewType.Edit, Guid.Empty, EditUid, Guid.Empty, Guid.Empty, item6: false));
		}
		if (DisplayUid != Guid.Empty)
		{
			list.Add(new Tuple<ViewType, Guid, Guid, Guid, Guid, bool>(ViewType.Display, Guid.Empty, DisplayUid, Guid.Empty, Guid.Empty, item6: false));
		}
		if (ActionGuids != null)
		{
			foreach (ActionForm actionGuid in ActionGuids)
			{
				list.Add(new Tuple<ViewType, Guid, Guid, Guid, Guid, bool>(ViewType.Custom, actionGuid.ActionTypeUid, actionGuid.ActionUid, actionGuid.GroupUid, actionGuid.Target, actionGuid.DeletedFromChild));
			}
			return list;
		}
		return list;
	}

	public Dictionary<Guid, string> FormSettingsToDictionary()
	{
		Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();
		if (FormSettings == null)
		{
			return dictionary;
		}
		foreach (DefaultFormSetting formSetting in FormSettings)
		{
			dictionary.Add(formSetting.Uid, formSetting.Value);
		}
		return dictionary;
	}

	public void FromDictionary(List<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>> dictionary)
	{
		FromDictionary(dictionary, reset: true);
	}

	public void FormSettingsFromDictionary(Dictionary<Guid, string> dict, bool reset = true)
	{
		if (FormSettings == null)
		{
			return;
		}
		if (reset)
		{
			FormSettings.Clear();
		}
		using Dictionary<Guid, string>.Enumerator enumerator = dict.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass34_0();
			CS_0024_003C_003E8__locals0.pair = enumerator.Current;
			DefaultFormSetting defaultFormSetting = FormSettings.FirstOrDefault((DefaultFormSetting s) => _003C_003Ec__DisplayClass34_0.I7V22kCtFjkG2YbA4X5K(_003C_003Ec__DisplayClass34_0.WadNWxCDz6tk52ouhDNi(s), CS_0024_003C_003E8__locals0.pair.Key));
			if (defaultFormSetting == null)
			{
				defaultFormSetting = new DefaultFormSetting
				{
					Uid = CS_0024_003C_003E8__locals0.pair.Key
				};
				FormSettings.Add(defaultFormSetting);
			}
			defaultFormSetting.Value = CS_0024_003C_003E8__locals0.pair.Value;
		}
	}

	public void FromDictionary(List<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>> dictionary, bool reset)
	{
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
		_003C_003Ec__DisplayClass35_.dictionary = dictionary;
		Func<ViewType, Guid, Guid> func = delegate(ViewType viewType, Guid defaultUid)
		{
			//Discarded unreachable code: IL_0099, IL_00a8, IL_00f6
			int num3 = 3;
			Tuple<ViewType, Guid, Guid, Guid, Guid, bool> tuple = default(Tuple<ViewType, Guid, Guid, Guid, Guid, bool>);
			_003C_003Ec__DisplayClass35_1 _003C_003Ec__DisplayClass35_2 = default(_003C_003Ec__DisplayClass35_1);
			while (true)
			{
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 5:
						return defaultUid;
					case 6:
						if (tuple.Item3 != Guid.Empty)
						{
							goto end_IL_0012;
						}
						goto default;
					case 3:
						_003C_003Ec__DisplayClass35_2 = new _003C_003Ec__DisplayClass35_1();
						num4 = 2;
						break;
					case 1:
						if (tuple != null)
						{
							num4 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
							{
								num4 = 4;
							}
							break;
						}
						goto case 5;
					default:
						return defaultUid;
					case 7:
						return tuple.Item3;
					case 4:
						tuple = _003C_003Ec__DisplayClass35_.dictionary.FirstOrDefault(_003C_003Ec__DisplayClass35_2._003CFromDictionary_003Eb__2);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num4 = 0;
						}
						break;
					case 2:
						_003C_003Ec__DisplayClass35_2.viewType = viewType;
						num4 = 4;
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num3 = 7;
			}
		};
		CreateUid = func(ViewType.Create, (!reset) ? CreateUid : Guid.Empty);
		EditUid = func(ViewType.Edit, EditUid);
		DisplayUid = func(ViewType.Display, DisplayUid);
		IEnumerable<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>> enumerable = _003C_003Ec__DisplayClass35_.dictionary.Where((Tuple<ViewType, Guid, Guid, Guid, Guid, bool> d) => d.Item1 == ViewType.Custom && d.Item2 != Guid.Empty && d.Item4 != Guid.Empty && d.Item5 != Guid.Empty);
		if (reset)
		{
			ActionGuids.Clear();
		}
		foreach (Tuple<ViewType, Guid, Guid, Guid, Guid, bool> item in enumerable)
		{
			_003C_003Ec__DisplayClass35_2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass35_2();
			CS_0024_003C_003E8__locals0.view = item;
			ActionForm actionForm = ActionGuids.FirstOrDefault(delegate(ActionForm a)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						return _003C_003Ec__DisplayClass35_2.zcx25mCtuLMlYNWEgEhA(_003C_003Ec__DisplayClass35_2.Ffl2ccCtV5n4SfCD6HnM(a), CS_0024_003C_003E8__locals0.view.Item2);
					case 1:
						if (_003C_003Ec__DisplayClass35_2.zcx25mCtuLMlYNWEgEhA(_003C_003Ec__DisplayClass35_2.TuOINLCtZsTu2xJ2qQxg(a), CS_0024_003C_003E8__locals0.view.Item4))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_003f;
					default:
						{
							if (_003C_003Ec__DisplayClass35_2.mlk0DGCtIji6wGY4nPt3(a) == CS_0024_003C_003E8__locals0.view.Item5)
							{
								num2 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
								{
									num2 = 2;
								}
								break;
							}
							goto IL_003f;
						}
						IL_003f:
						return false;
					}
				}
			});
			if (actionForm == null)
			{
				actionForm = new ActionForm
				{
					ActionTypeUid = CS_0024_003C_003E8__locals0.view.Item2,
					ActionUid = CS_0024_003C_003E8__locals0.view.Item3,
					GroupUid = CS_0024_003C_003E8__locals0.view.Item4,
					Target = CS_0024_003C_003E8__locals0.view.Item5,
					DeletedFromChild = CS_0024_003C_003E8__locals0.view.Item6
				};
				ActionGuids.Add(actionForm);
			}
			else
			{
				actionForm.ActionUid = item.Item3;
				actionForm.DeletedFromChild = item.Item6;
			}
		}
	}

	public FormViewItem GetForm(ViewType viewType)
	{
		int num = 1;
		int num2 = num;
		Guid formUid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 1:
				formUid = GetFormUid(viewType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return GetForm(formUid);
			}
		}
	}

	public void SetOwner(ClassMetadata owner)
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
				this.owner = owner;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public Guid GetFormUid(ViewType viewType)
	{
		//Discarded unreachable code: IL_007a, IL_0089
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return CreateUid;
			default:
				goto IL_003d;
			case 1:
				{
					switch (viewType)
					{
					case ViewType.Create:
						break;
					case ViewType.Edit:
						return EditUid;
					case ViewType.Display:
						return DisplayUid;
					case ViewType.Create | ViewType.Edit:
						goto IL_003d;
					default:
						goto IL_005b;
					}
					goto case 2;
				}
				IL_005b:
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
				IL_003d:
				return Guid.Empty;
			}
		}
	}

	public FormViewItem GetForm(Guid formUid)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = default(_003C_003Ec__DisplayClass39_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!GOi8vSbtZgAEIB0SXK2P(_003C_003Ec__DisplayClass39_.formUid, Guid.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return owner.GetForms().FirstOrDefault(_003C_003Ec__DisplayClass39_._003CGetForm_003Eb__0);
			case 4:
				_003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
				num2 = 3;
				break;
			default:
				return null;
			case 1:
				if (owner != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 3:
				_003C_003Ec__DisplayClass39_.formUid = formUid;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public string GetFormSetting(Guid settingUid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = default(_003C_003Ec__DisplayClass40_0);
		DefaultFormSetting defaultFormSetting = default(DefaultFormSetting);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass40_.settingUid = settingUid;
				num2 = 4;
				break;
			case 3:
				return null;
			case 2:
				_003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				defaultFormSetting = FormSettings.FirstOrDefault(_003C_003Ec__DisplayClass40_._003CGetFormSetting_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (defaultFormSetting != null)
				{
					return (string)zBDT2HbtIAhT7C8NciCO(defaultFormSetting);
				}
				num2 = 3;
				break;
			}
		}
	}

	public void SetFormSetting(Guid settingUid, string val)
	{
		//Discarded unreachable code: IL_0125
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = default(_003C_003Ec__DisplayClass41_0);
		DefaultFormSetting defaultFormSetting = default(DefaultFormSetting);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass41_.settingUid = settingUid;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 7;
				}
				break;
			case 1:
				return;
			case 4:
			case 6:
				defaultFormSetting.Value = val;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				if (defaultFormSetting != null)
				{
					num2 = 6;
					break;
				}
				goto case 8;
			case 8:
			{
				DefaultFormSetting defaultFormSetting2 = new DefaultFormSetting();
				jGlS38btVdj6seo0QinI(defaultFormSetting2, _003C_003Ec__DisplayClass41_.settingUid);
				defaultFormSetting = defaultFormSetting2;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 5;
				}
				break;
			}
			case 3:
				_003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
				num2 = 2;
				break;
			case 7:
				defaultFormSetting = FormSettings.FirstOrDefault(_003C_003Ec__DisplayClass41_._003CSetFormSetting_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				FormSettings.Add(defaultFormSetting);
				num2 = 4;
				break;
			}
		}
	}

	internal static void k7LFTRbtfmBulZ2mwbxh()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool t1QJ59btGYZgbgw7EObT()
	{
		return iGjGRBbthoaxn88GVXgT == null;
	}

	internal static ClassDefaultForms NBAYZ5btEGkfes7iMXCM()
	{
		return iGjGRBbthoaxn88GVXgT;
	}

	internal static bool cUB5kfbtQlZHBwOCnbNp(object P_0)
	{
		return ((ClassDefaultForms)P_0).ShouldSerializeCreateUid();
	}

	internal static bool ylScGIbtCnWRj0vjU0XD(object P_0)
	{
		return ((ClassDefaultForms)P_0).ShouldSerializeDisplayUid();
	}

	internal static bool RYungUbtvWxu2iO7P9wc(object P_0)
	{
		return ((ClassDefaultForms)P_0).ShouldSerializeActionGuids();
	}

	internal static bool DRkefXbt8ydiJE3BFJlB(object P_0)
	{
		return ((ClassDefaultForms)P_0).ShouldSerializeFormSettings();
	}

	internal static bool GOi8vSbtZgAEIB0SXK2P(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static int XwykP5btuKcgyNfJVeQX(object P_0)
	{
		return ((List<ActionForm>)P_0).Count;
	}

	internal static object zBDT2HbtIAhT7C8NciCO(object P_0)
	{
		return ((DefaultFormSetting)P_0).Value;
	}

	internal static void jGlS38btVdj6seo0QinI(object P_0, Guid value)
	{
		((DefaultFormSetting)P_0).Uid = value;
	}
}
