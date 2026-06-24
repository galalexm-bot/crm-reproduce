using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

[Component]
public class EntityDynamicFormProvider : IDynamicFormsProvider
{
	public static readonly Guid UID;

	internal static EntityDynamicFormProvider ATSD1jG4uUuCpmFoqfG4;

	public Guid Uid => UID;

	public Type GetEntityType(DynamicFormSettings settings)
	{
		//Discarded unreachable code: IL_00b2, IL_00c1
		int num = 2;
		Guid result = default(Guid);
		Type typeByUid = default(Type);
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (Guid.TryParse((string)OplRWZG4iXwCqRkGp3gN(settings), out result))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto default;
				case 6:
					if (!MTPusAG4ROJCi20yP0Jl(typeByUid, null))
					{
						num2 = 4;
						continue;
					}
					return typeByUid.CastAsRealType();
				default:
					return null;
				case 3:
					typeByUid = serviceNotNull.GetTypeByUid(result);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 6;
					}
					continue;
				case 4:
					return null;
				case 2:
					if (YjmhDiG4Sfatwk7XhorN(settings.DynamicFormsProviderData))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					return null;
				}
				break;
			}
			serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
			num = 5;
		}
	}

	public static string CreateData(IEntity entity, ViewType viewType, ItemType itemType)
	{
		int num = 1;
		int num2 = num;
		Guid guid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				if (entity != null)
				{
					guid = InterfaceActivator.UID(entity.CastAsRealType().GetType());
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
				}
				break;
			case 2:
				return guid.ToString();
			}
		}
	}

	public string GetPropertyValueChangeScriptName(IEntity entity, RootViewItem view, DynamicFormSettings settings, string propertyName)
	{
		//Discarded unreachable code: IL_00b1
		int num = 1;
		int num2 = num;
		Guid uid = default(Guid);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		Type typeByUid = default(Type);
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 6:
				return null;
			case 7:
				if (entity == null)
				{
					num2 = 5;
					continue;
				}
				obj = (EntityMetadata)MetadataLoader.LoadMetadata(entity.GetType());
				break;
			case 4:
				uid = new Guid(settings.DynamicFormsProviderData);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				if (propertyMetadata != null)
				{
					return (string)Jje7rVG4qEYOpnUDxYN6(propertyMetadata);
				}
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 6;
				}
				continue;
			case 5:
				obj = (EntityMetadata)MetadataLoader.LoadMetadata(typeByUid);
				break;
			case 1:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(uid);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 6;
				}
				continue;
			default:
				_003C_003Ec__DisplayClass5_.propertyName = propertyName;
				num2 = 4;
				continue;
			}
			propertyMetadata = ((ClassMetadata)obj).Properties.FirstOrDefault(_003C_003Ec__DisplayClass5_._003CGetPropertyValueChangeScriptName_003Eb__0);
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
			{
				num2 = 3;
			}
		}
	}

	public void ExecuteScript(IEntity entity, RootViewItem view, DynamicFormSettings settings, string scriptName, DynamicFormResultData resultData)
	{
		//Discarded unreachable code: IL_015e, IL_0327, IL_0336, IL_0346, IL_0355
		int num = 17;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_2 = default(_003C_003Ec__DisplayClass6_0);
		_003C_003Ec__DisplayClass6_1 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_1);
		ClassMetadata classMetadata = default(ClassMetadata);
		IEntity entity3 = default(IEntity);
		IEntity entity2 = default(IEntity);
		IEntityScriptingService serviceNotNull = default(IEntityScriptingService);
		Dictionary<string, object> dictionary = default(Dictionary<string, object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 17:
					_003C_003Ec__DisplayClass6_2 = new _003C_003Ec__DisplayClass6_0();
					num2 = 16;
					continue;
				case 6:
					_003C_003Ec__DisplayClass6_.tpPropUid = f4yLI2G4KKi9SYs6NvMV((ITablePartMetadata)classMetadata);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 10;
					}
					continue;
				case 11:
					entity3 = entity;
					num2 = 19;
					continue;
				case 8:
					classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					return;
				case 14:
					return;
				case 15:
					_003C_003Ec__DisplayClass6_2.formView = view;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					return;
				case 10:
					entity2 = (IEntity)BAVxS9G4XvbyRrFaBa3w(entity2, _003C_003Ec__DisplayClass6_.tpPropUid);
					num = 25;
					break;
				case 18:
				case 19:
					if (!(classMetadata is ITablePartMetadata))
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 7;
				case 24:
					serviceNotNull.ExecuteScript(entity3, scriptName, dictionary, _003C_003Ec__DisplayClass6_2._003CExecuteScript_003Eb__0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
				case 20:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_1();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					if (_003C_003Ec__DisplayClass6_2.formView != null)
					{
						dictionary = new Dictionary<string, object>();
						num2 = 8;
					}
					else
					{
						num2 = 3;
					}
					continue;
				default:
					entity2 = entity;
					num2 = 11;
					continue;
				case 22:
					dictionary[(string)XTab79G4kkO8Iipm4Ct9(-675505729 ^ -675532351)] = entity;
					num = 24;
					break;
				case 16:
					if (entity != null)
					{
						serviceNotNull = Locator.GetServiceNotNull<IEntityScriptingService>();
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num2 = 5;
						}
					}
					else
					{
						num2 = 9;
					}
					continue;
				case 4:
				case 13:
					if (entity3 != entity)
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 24;
				case 25:
					if (entity2 != null)
					{
						num2 = 23;
						continue;
					}
					goto case 21;
				case 1:
					return;
				case 7:
					if (entity2 != null)
					{
						num = 12;
						break;
					}
					goto case 4;
				case 5:
					if (serviceNotNull == null)
					{
						return;
					}
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 11;
					}
					continue;
				case 23:
					entity3 = entity2;
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 21;
					}
					continue;
				case 21:
					classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(GvEOBTG4Tn2Zq8BWrnEK(classMetadata.Properties.First(_003C_003Ec__DisplayClass6_._003CExecuteScript_003Eb__1)));
					num2 = 18;
					continue;
				}
				break;
			}
		}
	}

	public EntityDynamicFormProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sesTenG4nH01CMyEYIA9();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EntityDynamicFormProvider()
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
				UID = new Guid((string)XTab79G4kkO8Iipm4Ct9(0x26FFCB59 ^ 0x26FC346D));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				sesTenG4nH01CMyEYIA9();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool YjmhDiG4Sfatwk7XhorN(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object OplRWZG4iXwCqRkGp3gN(object P_0)
	{
		return ((DynamicFormSettings)P_0).DynamicFormsProviderData;
	}

	internal static bool MTPusAG4ROJCi20yP0Jl(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool pyVTg5G4IiRADRk5Oiun()
	{
		return ATSD1jG4uUuCpmFoqfG4 == null;
	}

	internal static EntityDynamicFormProvider ca2TUuG4V9Ys5dHPFElF()
	{
		return ATSD1jG4uUuCpmFoqfG4;
	}

	internal static object Jje7rVG4qEYOpnUDxYN6(object P_0)
	{
		return ((PropertyMetadata)P_0).OnChangeScriptName;
	}

	internal static Guid f4yLI2G4KKi9SYs6NvMV(object P_0)
	{
		return ((ITablePartMetadata)P_0).ParentPropertyUid;
	}

	internal static object BAVxS9G4XvbyRrFaBa3w(object P_0, Guid propertyUid)
	{
		return ((IEntity)P_0).GetPropertyValue(propertyUid);
	}

	internal static Guid GvEOBTG4Tn2Zq8BWrnEK(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object XTab79G4kkO8Iipm4Ct9(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void sesTenG4nH01CMyEYIA9()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
