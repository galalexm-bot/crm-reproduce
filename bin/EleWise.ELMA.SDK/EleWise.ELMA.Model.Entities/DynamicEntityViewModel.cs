using System;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Entities;

public class DynamicEntityViewModel<T> : EntityModel<T> where T : class, IEntity
{
	protected string viewItemId;

	protected FormViewItem view;

	protected DynamicFormSettings dynamicFormSettings;

	internal static object f5Z2dkh85736elRHAbde;

	public virtual DynamicFormSettings DynamicFormSettings
	{
		get
		{
			//Discarded unreachable code: IL_012f, IL_013e
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (dynamicFormSettings == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 4;
				case 1:
					dynamicFormSettings.FormId = FormId;
					num2 = 5;
					break;
				case 5:
					GetViewItem();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return dynamicFormSettings;
				case 6:
					if (!string.IsNullOrEmpty(FormId))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				case 4:
					return dynamicFormSettings;
				case 2:
					dynamicFormSettings = new DynamicFormSettings
					{
						DynamicFormsProviderUid = EntityDynamicFormProvider.UID,
						DynamicFormsProviderData = EntityDynamicFormProvider.CreateData(base.Entity, ViewType, ItemType),
						ViewProviderUid = EntityObjectViewItemProvider.UID,
						ViewItemId = ViewItemId
					};
					num2 = 6;
					break;
				}
			}
		}
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
					dynamicFormSettings = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
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

	public virtual FormViewItem View
	{
		get
		{
			return GetViewItem();
		}
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
					view = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
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

	public virtual string ViewItemId
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!string.IsNullOrEmpty(viewItemId))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 0;
						}
						break;
					}
					viewItemId = EntityObjectViewItemProvider.CreateViewItemId(base.Entity, ViewType, ItemType);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return viewItemId;
				default:
					return viewItemId;
				}
			}
		}
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
					viewItemId = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string FormId
	{
		[CompilerGenerated]
		get
		{
			return _003CFormId_003Ek__BackingField;
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
					_003CFormId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
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

	public virtual ItemType ItemType => ItemType.Default;

	public Guid? FormUid { get; set; }

	public bool FormReadOnly
	{
		[CompilerGenerated]
		get
		{
			return _003CFormReadOnly_003Ek__BackingField;
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
					_003CFormReadOnly_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DynamicEntityViewModel(T model, ViewType viewType)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(model);
		ViewType = viewType;
		if (base.Entity == null)
		{
			base.Entity = InterfaceActivator.Create<T>();
		}
	}

	public DynamicEntityViewModel()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				base.Entity = InterfaceActivator.Create<T>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public DynamicEntityViewModel(T entity)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		base.Entity = entity;
	}

	private FormViewItem GetViewItem()
	{
		//Discarded unreachable code: IL_0181, IL_0190, IL_019f, IL_022f, IL_0258, IL_02aa
		int num = 9;
		Guid? formUid = default(Guid?);
		ClassMetadata classMetadata = default(ClassMetadata);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					if (!(formUid.Value != Guid.Empty))
					{
						num2 = 3;
						continue;
					}
					goto case 20;
				case 16:
					view = DynamicFormHelper.FormWithExecutedLoadScripts(view, base.Entity, classMetadata, DynamicFormSettings);
					num2 = 22;
					continue;
				case 2:
					if (FormReadOnly)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 18;
				case 7:
					FormReadOnly = true;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 2;
					}
					continue;
				case 9:
					if (view != null)
					{
						num2 = 8;
						continue;
					}
					type = EntityHelper.GetType(base.Entity);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 5;
					}
					continue;
				case 18:
					return view;
				case 11:
					view = (FormViewItem)view.CloneAsReadOnly();
					num = 5;
					break;
				case 3:
				case 12:
				case 23:
					view = EntityObjectViewItemProvider.GetViewItem(type, ViewType, ItemType) as FormViewItem;
					num = 17;
					break;
				case 14:
				case 21:
				case 22:
					if (view == null)
					{
						num2 = 19;
						continue;
					}
					if (ViewType == ViewType.Display)
					{
						num2 = 7;
						continue;
					}
					goto case 2;
				case 20:
					view = classMetadata.GetForms().FirstOrDefault((FormViewItem q) => q.Uid == FormUid.Value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					return view;
				case 6:
					if (view.RuntimeVersion != 0)
					{
						num2 = 21;
						continue;
					}
					goto case 16;
				case 1:
					formUid = FormUid;
					num2 = 15;
					continue;
				case 19:
					return null;
				default:
					if (view == null)
					{
						num2 = 14;
						continue;
					}
					goto case 6;
				case 13:
					classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(type);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					ViewType = ViewType.Display;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 18;
					}
					continue;
				case 4:
					formUid = FormUid;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
					if (!formUid.HasValue)
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 4;
				}
				break;
			}
		}
	}

	internal static bool CJ9N6sh8jg0uMOtHBUsb()
	{
		return f5Z2dkh85736elRHAbde == null;
	}

	internal static object dG9p5Nh8YafUDCb0WMWB()
	{
		return f5Z2dkh85736elRHAbde;
	}
}
