using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions;

[Component(Order = 75)]
internal class UIFormDependencyExtension : IFormDependencyExtension
{
	internal static UIFormDependencyExtension zeUyQ8GwWZPWHjFHgL7d;

	public bool CheckType(Guid uid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return kvfE4xGwhLtTV8ybkA7U(uid, PortletMetadata.TypeUid);
			case 1:
				if (kvfE4xGwhLtTV8ybkA7U(uid, PageMetadata.TypeUid))
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool ExistForm(Guid objectUid, Guid formUid)
	{
		int num = 2;
		int num2 = num;
		IFormMetadataItemHeader formMetadataItemHeader = default(IFormMetadataItemHeader);
		while (true)
		{
			switch (num2)
			{
			default:
				return vpfUMkGwG1hJNOvHndoT(formMetadataItemHeader) != null;
			case 1:
				if (formMetadataItemHeader == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				formMetadataItemHeader = AbstractNHEntityManager<IFormMetadataItemHeader, long>.Instance.LoadOrNull(formUid);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IEnumerable<Guid> GetFormUids(Guid uid)
	{
		return new List<Guid> { uid };
	}

	public IEnumerable<IFormDependencyData> GetDependenciesForBaseClasses(Guid dependObjectUid, Guid dependObjectFormUid, IMetadata usesObjectMetadata, Guid usesObjectFormUid, FormDependencyDataType type)
	{
		return new List<IFormDependencyData>();
	}

	public IEnumerable<IFormDependencyData> GetDependenciesForBaseClasses(Guid dependObjectUid, Guid dependObjectFormUid, Guid usesObjectUid, Guid usesObjectFormUid, FormDependencyDataType type)
	{
		return new List<IFormDependencyData>();
	}

	public void GenerateNewDependencies(IMetadata dependObjectMetadata)
	{
		//Discarded unreachable code: IL_006d, IL_00d1, IL_00e0, IL_0204
		int num = 14;
		int num2 = num;
		Guid typeUid = default(Guid);
		FormViewItem formViewItem = default(FormViewItem);
		PortletMetadata portletMetadata = default(PortletMetadata);
		List<IFormDependencyData> list = default(List<IFormDependencyData>);
		FormMetadata formMetadata = default(FormMetadata);
		PageMetadata pageMetadata = default(PageMetadata);
		while (true)
		{
			switch (num2)
			{
			case 16:
				typeUid = PortletMetadata.TypeUid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				formViewItem = (FormViewItem)oeTgXMGwfMHJjJQCyJih(XXQjZcGwQNFBLava8wcs(portletMetadata));
				num2 = 9;
				break;
			case 15:
				FormDependencyHelper.Update(typeUid, (IFormDependencyData[])CLJbqZGwvmA2DG9cDQx8(list));
				num2 = 8;
				break;
			case 13:
				if (formMetadata != null)
				{
					num2 = 17;
					break;
				}
				return;
			case 12:
				formViewItem = (FormViewItem)oeTgXMGwfMHJjJQCyJih(VBhCZlGwEEAt7KcVTQBp(pageMetadata));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				pageMetadata = formMetadata as PageMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 1;
				}
				break;
			case 14:
				formMetadata = dependObjectMetadata as FormMetadata;
				num2 = 13;
				break;
			case 2:
				portletMetadata = formMetadata as PortletMetadata;
				num2 = 3;
				break;
			case 1:
				if (pageMetadata != null)
				{
					num2 = 18;
					break;
				}
				goto case 16;
			default:
				if (formViewItem != null)
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 15;
			case 3:
				if (portletMetadata == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 5;
			case 11:
				list = new List<IFormDependencyData>();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 4;
				}
				break;
			case 8:
				return;
			case 7:
				return;
			case 17:
				formViewItem = null;
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 11;
				}
				break;
			case 18:
				typeUid = PageMetadata.TypeUid;
				num2 = 12;
				break;
			case 10:
				list.AddRange(FormDependencyHelper.GenerateFormDependencies(typeUid, formViewItem, AaM30nGwCYplEmBWS6uq(formMetadata)));
				num2 = 15;
				break;
			}
		}
	}

	public void GenerateNewDependencies(Guid dependObjectUid)
	{
		//Discarded unreachable code: IL_0104, IL_0113, IL_0123, IL_0132
		int num = 9;
		int num2 = num;
		IFormMetadataItemHeader formMetadataItemHeader = default(IFormMetadataItemHeader);
		FormMetadata formMetadata = default(FormMetadata);
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (formMetadataItemHeader == null)
				{
					num2 = 3;
					continue;
				}
				goto case 5;
			case 6:
				return;
			case 9:
				formMetadataItemHeader = AbstractNHEntityManager<IFormMetadataItemHeader, long>.Instance.LoadOrNull(dependObjectUid);
				num2 = 8;
				continue;
			case 1:
				return;
			case 4:
				GenerateNewDependencies(formMetadata);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 6;
				}
				continue;
			case 5:
				if (vpfUMkGwG1hJNOvHndoT(formMetadataItemHeader) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 2:
				return;
			case 3:
				return;
			case 7:
				if (formMetadata == null)
				{
					return;
				}
				num2 = 4;
				continue;
			}
			if (((IFormMetadataItem)vpfUMkGwG1hJNOvHndoT(formMetadataItemHeader)).Metadata == null)
			{
				num2 = 2;
				continue;
			}
			formMetadata = ((IFormMetadataItem)vpfUMkGwG1hJNOvHndoT(formMetadataItemHeader)).Metadata as FormMetadata;
			num2 = 6;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
			{
				num2 = 7;
			}
		}
	}

	public UIFormDependencyExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PdJmWDGw8IC8FT5iiNP0();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool kvfE4xGwhLtTV8ybkA7U(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool iEMYepGwogoZuGEaes5J()
	{
		return zeUyQ8GwWZPWHjFHgL7d == null;
	}

	internal static UIFormDependencyExtension TYU5fMGwbVwCdY8kjXyE()
	{
		return zeUyQ8GwWZPWHjFHgL7d;
	}

	internal static object vpfUMkGwG1hJNOvHndoT(object P_0)
	{
		return ((IFormMetadataItemHeader)P_0).Draft;
	}

	internal static object VBhCZlGwEEAt7KcVTQBp(object P_0)
	{
		return ((PageMetadata)P_0).Content;
	}

	internal static object oeTgXMGwfMHJjJQCyJih(object P_0)
	{
		return ((FormPartMetadata)P_0).View;
	}

	internal static object XXQjZcGwQNFBLava8wcs(object P_0)
	{
		return ((PortletMetadata)P_0).Content;
	}

	internal static Guid AaM30nGwCYplEmBWS6uq(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object CLJbqZGwvmA2DG9cDQx8(object P_0)
	{
		return ((List<IFormDependencyData>)P_0).ToArray();
	}

	internal static void PdJmWDGw8IC8FT5iiNP0()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
