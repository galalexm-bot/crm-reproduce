using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Helpers;

public static class FormRenderHelper
{
	private static FormRenderHelper RC4mlOh5YDqi7neklwyW;

	public static bool CanRenderRuntimeVersion2<T>(ViewType viewType)
	{
		return CanRenderRuntimeVersion2(typeof(T), viewType);
	}

	public static bool CanRenderRuntimeVersion2(Type type, ViewType viewType)
	{
		//Discarded unreachable code: IL_0106, IL_0115
		int num = 7;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		while (true)
		{
			switch (num2)
			{
			case 7:
				entityMetadata = MetadataLoader.LoadMetadata(type, inherit: true, loadImplementation: false) as EntityMetadata;
				num2 = 6;
				break;
			case 6:
				if (entityMetadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 3:
				if (entityMetadata == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 1;
					}
					break;
				}
				serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				entityMetadata = MetadataLoader.LoadMetadata(RIunkrh5cHq1Y42CtJ7H(entityMetadata), inherit: true, loadImplementation: false) as EntityMetadata;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return false;
			case 1:
				if (!SajIdxh5sAO7icULfKwD(entityMetadata))
				{
					num2 = 5;
					break;
				}
				goto case 3;
			case 4:
				return false;
			default:
				return qKnISUh5zlhR8bKmvBlH(entityMetadata, viewType, serviceNotNull);
			}
		}
	}

	public static Guid GetFormUid(Type type, ViewType viewType)
	{
		//Discarded unreachable code: IL_00af
		int num = 3;
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return Guid.Empty;
				case 4:
					serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					entityMetadata = MetadataLoader.LoadMetadata(type, inherit: true, loadImplementation: false) as EntityMetadata;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 2;
					}
					break;
				default:
					return Guid.Empty;
				case 1:
					return XcLN5QhjFg3P2dSc0yh6(entityMetadata, viewType, serviceNotNull);
				case 2:
					if (entityMetadata != null)
					{
						if (entityMetadata != null)
						{
							goto end_IL_0012;
						}
						goto case 5;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public static bool CanRenderRuntimeVersion2(FormViewItem formViewItem)
	{
		return gwjLMFhjBdBQs10rs5qQ(formViewItem) == RuntimeVersion.Version2;
	}

	public static bool CanRenderRuntimeVersion2(IEntity<long> entity, Guid formUid)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0.entity = entity;
		return Locator.GetServiceNotNull<IEnumerable<IFormRenderExtension>>().FirstOrDefault((IFormRenderExtension ext) => ext.Check(CS_0024_003C_003E8__locals0.entity))?.CanRenderRuntimeVersion2(CS_0024_003C_003E8__locals0.entity, formUid) ?? false;
	}

	private static Guid GetFormUid(object entityMetadata, ViewType viewType, object metadataRuntimeService)
	{
		//Discarded unreachable code: IL_006a, IL_0079, IL_0088, IL_0098, IL_0127, IL_0136
		int num = 4;
		int num2 = num;
		Guid guid = default(Guid);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 2:
				guid = hDoN9DhjoOy5iwTrmOHJ(kVvkj8hjWbhGmTCKnm6F(entityMetadata2), viewType);
				num2 = 9;
				break;
			case 9:
				if (FyypYBhjhrLbK4VijqrY(QG4TUPhjbgcW3XYurecX(entityMetadata2), Guid.Empty))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 5:
				entityMetadata2 = ((IMetadataService)metadataRuntimeService).GetMetadata(QG4TUPhjbgcW3XYurecX(entityMetadata2), loadImplementation: true) as EntityMetadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 11;
				}
				break;
			case 3:
				entityMetadata2 = (EntityMetadata)entityMetadata;
				num2 = 6;
				break;
			default:
				return guid;
			case 11:
				if (entityMetadata2 == null)
				{
					num2 = 10;
					break;
				}
				goto case 6;
			case 4:
				guid = Guid.Empty;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 2;
				}
				break;
			case 6:
			case 7:
				if (FyypYBhjhrLbK4VijqrY(guid, Guid.Empty))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	private static bool CanRender(object entityMetadata, ViewType viewType, object metadataRuntimeService)
	{
		//Discarded unreachable code: IL_0123, IL_0157, IL_0166, IL_0176, IL_0247, IL_0256, IL_02ee, IL_02fd, IL_0341, IL_0350, IL_035f, IL_0462, IL_0471, IL_0502, IL_0511
		int num = 13;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_2 = default(_003C_003Ec__DisplayClass6_0);
		FormViewItemTransformation formViewItemTransformation = default(FormViewItemTransformation);
		FormViewItem formViewItem = default(FormViewItem);
		EntityMetadata entityMetadata3 = default(EntityMetadata);
		_003C_003Ec__DisplayClass6_1 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_1);
		FormViewItemTransformation formViewItemTransformation2 = default(FormViewItemTransformation);
		FormViewItem formViewItem2 = default(FormViewItem);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		EntityMetadata entityMetadata4 = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 30:
					return false;
				case 29:
					if (!fPimr4hjGacMbNDY9oMc(entityMetadata))
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 32;
				case 12:
					_003C_003Ec__DisplayClass6_2.metadataRuntimeService = (IMetadataRuntimeService)metadataRuntimeService;
					num2 = 37;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 23;
					}
					continue;
				case 5:
					if (formViewItemTransformation == null)
					{
						num2 = 15;
						continue;
					}
					goto case 27;
				case 38:
					formViewItem = entityMetadata3.Forms.Find(_003C_003Ec__DisplayClass6_._003CCanRender_003Eb__5);
					num2 = 36;
					continue;
				case 37:
					_003C_003Ec__DisplayClass6_2.formUid = Guid.Empty;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 1;
					}
					continue;
				case 17:
				case 34:
					formViewItemTransformation2 = entityMetadata3.FormTransformations.Find(_003C_003Ec__DisplayClass6_._003CCanRender_003Eb__4);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 23:
					return A5nQWchjfu0t5NyLHvc6(formViewItem2);
				case 31:
					return true;
				case 6:
				case 22:
					formViewItem2 = Locator.GetServiceNotNull<IEntityFormsService>().GetAllForms((ClassMetadata)entityMetadata).FirstOrDefault(_003C_003Ec__DisplayClass6_2._003CCanRender_003Eb__0);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					entityMetadata2 = (EntityMetadata)entityMetadata;
					num2 = 4;
					continue;
				case 26:
					_003C_003Ec__DisplayClass6_2.formUid = hDoN9DhjoOy5iwTrmOHJ(kVvkj8hjWbhGmTCKnm6F(entityMetadata2), viewType);
					num2 = 35;
					continue;
				case 33:
					return qKnISUh5zlhR8bKmvBlH(entityMetadata4, viewType, _003C_003Ec__DisplayClass6_2.metadataRuntimeService);
				case 16:
				case 25:
					return false;
				case 41:
					if ((entityMetadata4 = _003C_003Ec__DisplayClass6_2.metadataRuntimeService.GetMetadata(QG4TUPhjbgcW3XYurecX(entityMetadata), loadImplementation: false) as EntityMetadata) == null)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 33;
				case 2:
					if (entityMetadata3 != null)
					{
						num2 = 39;
						continue;
					}
					goto case 6;
				case 28:
					entityMetadata2 = _003C_003Ec__DisplayClass6_2.metadataRuntimeService.GetMetadata(entityMetadata2.BaseClassUid, loadImplementation: false) as EntityMetadata;
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 24;
					}
					continue;
				case 24:
					if (entityMetadata2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 4:
				case 11:
					if (!(_003C_003Ec__DisplayClass6_2.formUid == Guid.Empty))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 26;
				case 3:
					if (formViewItemTransformation2 == null)
					{
						num2 = 6;
						continue;
					}
					goto case 8;
				default:
					if (!FyypYBhjhrLbK4VijqrY(_003C_003Ec__DisplayClass6_2.formUid, Guid.Empty))
					{
						num2 = 29;
						continue;
					}
					goto case 30;
				case 18:
					_003C_003Ec__DisplayClass6_.extensionFormUid = entityMetadata3.DefaultForms.GetFormUid(viewType);
					num2 = 10;
					continue;
				case 13:
					_003C_003Ec__DisplayClass6_2 = new _003C_003Ec__DisplayClass6_0();
					num2 = 12;
					continue;
				case 39:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_1();
					num2 = 18;
					continue;
				case 14:
					if (formViewItem2 == null)
					{
						formViewItemTransformation = ((ClassMetadata)entityMetadata).FormTransformations.Find(_003C_003Ec__DisplayClass6_2._003CCanRender_003Eb__1);
						num2 = 5;
					}
					else
					{
						num2 = 23;
					}
					continue;
				case 36:
					if (formViewItem == null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 21;
				case 20:
					return true;
				case 15:
				case 19:
					if (!HcBDilhjEh1SvvKlcrpl(QG4TUPhjbgcW3XYurecX(entityMetadata), Guid.Empty))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 41;
				case 10:
					if (!HcBDilhjEh1SvvKlcrpl(_003C_003Ec__DisplayClass6_.extensionFormUid, Guid.Empty))
					{
						num2 = 7;
						continue;
					}
					goto case 38;
				case 21:
					return A5nQWchjfu0t5NyLHvc6(formViewItem);
				case 7:
					_003C_003Ec__DisplayClass6_.extensionFormUid = _003C_003Ec__DisplayClass6_2.formUid;
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 34;
					}
					continue;
				case 35:
					if (QG4TUPhjbgcW3XYurecX(entityMetadata2) == Guid.Empty)
					{
						num2 = 40;
						continue;
					}
					goto case 28;
				case 32:
					entityMetadata3 = (from uid in ((EntityMetadata)_003C_003Ec__DisplayClass6_2.metadataRuntimeService.GetMetadata(((EntityMetadata)entityMetadata).ImplementationUid)).ImplementedExtensionUids.EmptyIfNull()
						where uid.IsConfigMetadata()
						select uid).Select(_003C_003Ec__DisplayClass6_2._003CCanRender_003Eb__3).FirstOrDefault();
					num = 2;
					break;
				case 8:
					if (formViewItemTransformation2.Items.OfType<ViewItemTransformationChange>().Any((ViewItemTransformationChange transformationChange) => _003C_003Ec.xjRbHGv0YI0EloZhQx64(_003C_003Ec.Mdp2mhv05pqlucZYcTuP(transformationChange), _003C_003Ec.GIUH52v0jC2OgmCitrvs(-675505729 ^ -675395903))))
					{
						num = 31;
						break;
					}
					goto case 6;
				case 27:
					if (!formViewItemTransformation.Items.OfType<ViewItemTransformationChange>().Any((ViewItemTransformationChange transformationChange) => _003C_003Ec.xjRbHGv0YI0EloZhQx64(_003C_003Ec.Mdp2mhv05pqlucZYcTuP(transformationChange), _003C_003Ec.GIUH52v0jC2OgmCitrvs(0x5F3078B6 ^ 0x5F32A7C8))))
					{
						num2 = 19;
						continue;
					}
					goto case 20;
				}
				break;
			}
		}
	}

	internal static bool SajIdxh5sAO7icULfKwD(object P_0)
	{
		return ((ClassMetadata)P_0).IsInterfaceType;
	}

	internal static Guid RIunkrh5cHq1Y42CtJ7H(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static bool qKnISUh5zlhR8bKmvBlH(object P_0, ViewType viewType, object P_2)
	{
		return CanRender(P_0, viewType, P_2);
	}

	internal static bool XBYSesh5LmortkB49DIt()
	{
		return RC4mlOh5YDqi7neklwyW == null;
	}

	internal static FormRenderHelper c04Wh4h5UTKNkq9ix5lM()
	{
		return RC4mlOh5YDqi7neklwyW;
	}

	internal static Guid XcLN5QhjFg3P2dSc0yh6(object P_0, ViewType viewType, object P_2)
	{
		return GetFormUid(P_0, viewType, P_2);
	}

	internal static RuntimeVersion gwjLMFhjBdBQs10rs5qQ(object P_0)
	{
		return ((FormViewItem)P_0).RuntimeVersion;
	}

	internal static object kVvkj8hjWbhGmTCKnm6F(object P_0)
	{
		return ((ClassMetadata)P_0).DefaultForms;
	}

	internal static Guid hDoN9DhjoOy5iwTrmOHJ(object P_0, ViewType viewType)
	{
		return ((ClassDefaultForms)P_0).GetFormUid(viewType);
	}

	internal static Guid QG4TUPhjbgcW3XYurecX(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static bool FyypYBhjhrLbK4VijqrY(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool fPimr4hjGacMbNDY9oMc(object P_0)
	{
		return ((IMetadata)P_0).IsSystem();
	}

	internal static bool HcBDilhjEh1SvvKlcrpl(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool A5nQWchjfu0t5NyLHvc6(object P_0)
	{
		return CanRenderRuntimeVersion2((FormViewItem)P_0);
	}
}
