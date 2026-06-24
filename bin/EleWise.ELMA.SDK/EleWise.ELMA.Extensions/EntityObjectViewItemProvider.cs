using System;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

[Component]
public class EntityObjectViewItemProvider : IObjectViewItemProvider
{
	public static readonly Guid UID;

	internal static EntityObjectViewItemProvider hWOkRkGHwZ6ceSNF69w6;

	public IMetadataRuntimeService MetadataRuntimeService
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataRuntimeService_003Ek__BackingField;
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
					_003CMetadataRuntimeService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
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

	public virtual Guid ProviderUid => UID;

	public static string CreateViewItemId(IEntity entity, ViewType viewType, ItemType itemType)
	{
		int num = 3;
		int num2 = num;
		Type type = default(Type);
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		FormViewItem formViewItem = default(FormViewItem);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (entity == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 5;
					}
					break;
				}
				type = pvM9miGHHmkOqJEAeW04(entity);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return null;
			case 3:
				_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass7_.viewType = viewType;
				num2 = 4;
				break;
			default:
				formViewItem = ((ClassMetadata)MetadataLoader.LoadMetadata(type)).GetForms().FirstOrDefault(_003C_003Ec__DisplayClass7_._003CCreateViewItemId_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return (string)u66YqCGHxAW7XwTc19s9(CDeXkoGHAyAPfwC4ioHx(0x34185E55 ^ 0x34180A89), new object[5]
				{
					(int)_003C_003Ec__DisplayClass7_.viewType,
					formViewItem?.Uid ?? Guid.Empty,
					(int)itemType,
					InterfaceActivator.UID(type),
					Kq4bVoGH7CZrqHfBvKCN(entity)
				});
			}
		}
	}

	public virtual ViewItem GetViewItem(string viewItemId)
	{
		int num = 5;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		Guid uid = default(Guid);
		string[] array = default(string[]);
		Guid result = default(Guid);
		Type typeByUid = default(Type);
		Guid result2 = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 4;
					continue;
				case 1:
					uid = new Guid(array[3]);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					result = Guid.Empty;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return GetViewItem(typeByUid, result, _003C_003Ec__DisplayClass8_.itemType, _003C_003Ec__DisplayClass8_._003CGetViewItem_003Eb__2);
				case 11:
					typeByUid = MetadataRuntimeService.GetTypeByUid(uid);
					num2 = 6;
					continue;
				case 8:
					return GetViewItem(typeByUid, result2, _003C_003Ec__DisplayClass8_.itemType, _003C_003Ec__DisplayClass8_._003CGetViewItem_003Eb__0);
				case 4:
					_003C_003Ec__DisplayClass8_._003C_003E4__this = this;
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 7;
					}
					continue;
				case 9:
					return null;
				case 13:
					if (YPAfXdGH0PBNxrtkB3iX(viewItemId))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num2 = 12;
						}
					}
					else
					{
						array = viewItemId.Split(new string[1] { (string)CDeXkoGHAyAPfwC4ioHx(-105199646 ^ -105213122) }, StringSplitOptions.None);
						num2 = 10;
					}
					continue;
				case 10:
					if (array.Length >= 4)
					{
						_003C_003Ec__DisplayClass8_.viewType = (ViewType)rKJ0xBGHmZUCuh08DUTa(array[0]);
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 9;
					}
					continue;
				case 6:
					if (!Guid.TryParse(array.Last(), out result2))
					{
						if (NR76RcGHykxgaAdllbIa(result, Guid.Empty))
						{
							return GetViewItem(typeByUid, _003C_003Ec__DisplayClass8_.viewType, _003C_003Ec__DisplayClass8_.itemType, _003C_003Ec__DisplayClass8_._003CGetViewItem_003Eb__1);
						}
						num2 = 3;
					}
					else
					{
						num2 = 8;
					}
					continue;
				case 12:
					return null;
				case 7:
					_003C_003Ec__DisplayClass8_.itemType = (ItemType)rKJ0xBGHmZUCuh08DUTa(array[2]);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			Guid.TryParse(array[1], out result);
			num = 7;
		}
	}

	protected static FormViewItem TransformateStatic(ClassMetadata metadata, FormViewItem formViewItem, ViewType viewType, ItemType itemType)
	{
		int num = 1;
		FormViewItemTransformation formViewItemTransformation = default(FormViewItemTransformation);
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					formViewItemTransformation = new FormViewItemTransformation();
					num2 = 5;
					continue;
				case 6:
					if (formViewItemTransformation.Items.Any())
					{
						num2 = 4;
						continue;
					}
					goto case 3;
				case 8:
					_003C_003Ec__DisplayClass9_.viewType = viewType;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					_003C_003Ec__DisplayClass9_.formViewItem = (FormViewItem)KP0DwwGHMH2i7hTsMhpI(_003C_003Ec__DisplayClass9_.formViewItem, formViewItemTransformation);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass9_.itemType = itemType;
					num = 7;
					break;
				default:
					_003C_003Ec__DisplayClass9_.formViewItem = formViewItem;
					num = 8;
					break;
				case 3:
					return _003C_003Ec__DisplayClass9_.formViewItem;
				case 1:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					formViewItemTransformation.Items.AddRange(from t in _003C_003Ec__DisplayClass9_.formViewItem.GetAllItems().OfType<DefaultContainerViewItem>().Select(_003C_003Ec__DisplayClass9_._003CTransformateStatic_003Eb__0)
						where t != null
						select t);
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	protected virtual FormViewItem Transformate(ClassMetadata metadata, FormViewItem formViewItem, ViewType viewType, ItemType itemType)
	{
		return (FormViewItem)JjLGyNGHJUc35NixMgtS(metadata, formViewItem, viewType, itemType);
	}

	protected static FormViewItem GetFormViewItem(Type entityType, ViewType viewType, ItemType itemType, Func<ClassMetadata, FormViewItem, FormViewItem> transformate)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0.transformate = transformate;
		return (FormViewItem)GetViewItem(entityType, viewType, itemType, (ClassMetadata cm, FormViewItem fvi) => CS_0024_003C_003E8__locals0.transformate(cm, fvi));
	}

	protected static ViewItem GetViewItem(Type entityType, ViewType viewType, ItemType itemType, Func<ClassMetadata, FormViewItem, ViewItem> transformate)
	{
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entityType);
		FormViewItem formViewItem = ((classMetadata.FormsScheme == ClassFormsScheme.FormConstructor) ? classMetadata.DefaultForms.GetForm(viewType) : null);
		if (formViewItem != null && viewType == ViewType.Display)
		{
			formViewItem = (FormViewItem)formViewItem.CloneAsReadOnly();
		}
		return transformate(classMetadata, formViewItem);
	}

	protected static ViewItem GetViewItem(Type entityType, Guid? formUid, ItemType itemType, Func<ClassMetadata, FormViewItem, ViewItem> transformate)
	{
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
		CS_0024_003C_003E8__locals0.formUid = formUid;
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entityType);
		FormViewItem arg = classMetadata.GetForms().FirstOrDefault(delegate(FormViewItem q)
		{
			//Discarded unreachable code: IL_00a0, IL_00af
			int num = 3;
			int num2 = num;
			Guid? formUid2 = default(Guid?);
			Guid uid = default(Guid);
			while (true)
			{
				switch (num2)
				{
				case 2:
					formUid2 = CS_0024_003C_003E8__locals0.formUid;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					return false;
				default:
					return _003C_003Ec__DisplayClass13_0.bNj80O8GyfUqLrt78pNx(uid, formUid2.GetValueOrDefault());
				case 3:
					uid = q.Uid;
					num2 = 2;
					break;
				case 4:
					if (formUid2.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				}
			}
		});
		return transformate(classMetadata, arg);
	}

	public static ViewItem GetViewItem(Type entityType, ViewType viewType, ItemType itemType)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass14_.itemType = itemType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
				num2 = 2;
				break;
			default:
				return GetViewItem(entityType, _003C_003Ec__DisplayClass14_.viewType, _003C_003Ec__DisplayClass14_.itemType, _003C_003Ec__DisplayClass14_._003CGetViewItem_003Eb__0);
			case 2:
				_003C_003Ec__DisplayClass14_.viewType = viewType;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public EntityObjectViewItemProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wYftwRGH9kO9bMetM1xW();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EntityObjectViewItemProvider()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				UID = new Guid((string)CDeXkoGHAyAPfwC4ioHx(0x5A4C7B29 ^ 0x5A487F0B));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				wYftwRGH9kO9bMetM1xW();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool IrHMQ3GH4V1uR6xBaW3d()
	{
		return hWOkRkGHwZ6ceSNF69w6 == null;
	}

	internal static EntityObjectViewItemProvider CSpw9oGH6kXEMci2Awo1()
	{
		return hWOkRkGHwZ6ceSNF69w6;
	}

	internal static Type pvM9miGHHmkOqJEAeW04(object P_0)
	{
		return EntityHelper.GetType(P_0);
	}

	internal static object CDeXkoGHAyAPfwC4ioHx(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Kq4bVoGH7CZrqHfBvKCN(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static object u66YqCGHxAW7XwTc19s9(object P_0, object P_1)
	{
		return string.Join((string)P_0, (object[])P_1);
	}

	internal static bool YPAfXdGH0PBNxrtkB3iX(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static long rKJ0xBGHmZUCuh08DUTa(object P_0)
	{
		return long.Parse((string)P_0);
	}

	internal static bool NR76RcGHykxgaAdllbIa(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object KP0DwwGHMH2i7hTsMhpI(object P_0, object P_1)
	{
		return ((FormViewItem)P_0).Transformate((ViewItemTransformation)P_1);
	}

	internal static object JjLGyNGHJUc35NixMgtS(object P_0, object P_1, ViewType viewType, ItemType itemType)
	{
		return TransformateStatic((ClassMetadata)P_0, (FormViewItem)P_1, viewType, itemType);
	}

	internal static void wYftwRGH9kO9bMetM1xW()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
