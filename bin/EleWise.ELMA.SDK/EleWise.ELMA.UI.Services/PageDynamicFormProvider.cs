using System;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Services;

public class PageDynamicFormProvider : UIDynamicFormProvider
{
	public static readonly Guid UID;

	private static PageDynamicFormProvider weCsPDsnLKKHySVyqhc;

	public override Guid Uid => UID;

	public static string CreateData(FormDescriptor formDescriptor, FormPartMetadata partMetadata)
	{
		return (string)hSYtE5seicI1QoOrhwF(formDescriptor, partMetadata);
	}

	protected override Type GetItemViewModelType(Type itemType, FormDescriptor descriptor)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				VB9qTts1EWG5fXEMx60(itemType, iPDVFksPu53xopgwTHM(-1146510045 ^ -1146522713));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return DQHTBGsNmjTCKUUdZWE(typeof(PageItemViewModel<>).TypeHandle).MakeGenericType(itemType);
			}
		}
	}

	protected override Type GetViewModelType(Type entityType, FormDescriptor descriptor)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return DQHTBGsNmjTCKUUdZWE(typeof(PageViewModel<>).TypeHandle).MakeGenericType(entityType);
			case 1:
				VB9qTts1EWG5fXEMx60(entityType, iPDVFksPu53xopgwTHM(0x34A6D230 ^ 0x34A601A4));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override object CreateItemViewModelType(Type itemViewModelType, FormDescriptor descriptor, IEntity entity, RootViewItem view, UIViewItemParams viewItemParams)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				VB9qTts1EWG5fXEMx60(itemViewModelType, iPDVFksPu53xopgwTHM(-1459557599 ^ -1459601991));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Activator.CreateInstance(itemViewModelType, entity, view);
			}
		}
	}

	protected override object CreateViewModelType(Type viewModelType, FormDescriptor descriptor, IEntity entity, RootViewItem view, UIViewItemParams viewItemParams)
	{
		int num = 3;
		int num2 = num;
		PageDescriptor pageDescriptor = default(PageDescriptor);
		while (true)
		{
			switch (num2)
			{
			default:
				pageDescriptor = (PageDescriptor)descriptor;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return Frt3jTspFsqBkaA9Lj7(viewModelType, new object[3]
				{
					nIt7g2s3ecvyuuDuAKB(pageDescriptor),
					entity,
					view
				});
			case 3:
				VB9qTts1EWG5fXEMx60(viewModelType, iPDVFksPu53xopgwTHM(-740338220 ^ -740326550));
				num2 = 2;
				break;
			case 2:
				VB9qTts1EWG5fXEMx60(descriptor, iPDVFksPu53xopgwTHM(-2112703338 ^ -2112698788));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override object GetResult(object viewModel)
	{
		int num = 2;
		int num2 = num;
		IPageViewModel pageViewModel = default(IPageViewModel);
		while (true)
		{
			switch (num2)
			{
			case 2:
				pageViewModel = viewModel as IPageViewModel;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return null;
			case 1:
				if (pageViewModel != null)
				{
					return tFIlARsahwClnH5TdAf(pageViewModel);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PageDynamicFormProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LADyWbsD3nDiICZoaAM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PageDynamicFormProvider()
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
				UID = new Guid((string)iPDVFksPu53xopgwTHM(-1710575414 ^ -1710594538));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				LADyWbsD3nDiICZoaAM();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object hSYtE5seicI1QoOrhwF(object P_0, object P_1)
	{
		return UIViewItemProvider.CreateViewItemId((FormDescriptor)P_0, (FormPartMetadata)P_1);
	}

	internal static bool nwWiDBsOBDWAqvP0s1A()
	{
		return weCsPDsnLKKHySVyqhc == null;
	}

	internal static PageDynamicFormProvider vIyxuhs2qhZFE7WE7yv()
	{
		return weCsPDsnLKKHySVyqhc;
	}

	internal static object iPDVFksPu53xopgwTHM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void VB9qTts1EWG5fXEMx60(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Type DQHTBGsNmjTCKUUdZWE(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object nIt7g2s3ecvyuuDuAKB(object P_0)
	{
		return ((PageDescriptor)P_0).Content;
	}

	internal static object Frt3jTspFsqBkaA9Lj7(Type P_0, object P_1)
	{
		return Activator.CreateInstance(P_0, (object[])P_1);
	}

	internal static object tFIlARsahwClnH5TdAf(object P_0)
	{
		return ((IFormViewModel)P_0).Result;
	}

	internal static void LADyWbsD3nDiICZoaAM()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
