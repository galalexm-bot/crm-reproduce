using System;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.UI.DTO.Models;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.DTO.Managers;

public class FormMetadataItemDTOManager : DTOManager, IFormMetadataItemDTOManager, IConfigurationService
{
	private static FormMetadataItemDTOManager thokMm9wY1mUdfwXmsQ;

	public FormMetadataItemManager Manager
	{
		[CompilerGenerated]
		get
		{
			return _003CManager_003Ek__BackingField;
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
					_003CManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
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

	public ISecurityService SecurityService
	{
		[CompilerGenerated]
		get
		{
			return _003CSecurityService_003Ek__BackingField;
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
					_003CSecurityService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
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

	public virtual FormMetadataItemDTO Load(long id)
	{
		return Mapper.Map<IFormMetadataItem, FormMetadataItemDTO>(Manager.Load(id));
	}

	public virtual FormMetadataItemDTO Save(FormMetadataItemDTO objDto)
	{
		int num = 3;
		int num2 = num;
		IFormMetadataItem formMetadataItem = default(IFormMetadataItem);
		while (true)
		{
			switch (num2)
			{
			case 2:
				formMetadataItem = Mapper.Map<FormMetadataItemDTO, IFormMetadataItem>(objDto);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return Mapper.Map<IFormMetadataItem, FormMetadataItemDTO>(formMetadataItem);
			case 1:
				Manager.Save(formMetadataItem);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				pp7Gi49A2NsGfredKYR(objDto, OdLLWy9HXapY3rHJn7m(-70037984 ^ -69999974));
				num2 = 2;
				break;
			}
		}
	}

	public virtual void Publish(long headerId, string comment, bool forEmulation)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			case 4:
				_003C_003Ec__DisplayClass10_.headerId = headerId;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass10_.forEmulation = forEmulation;
				num2 = 3;
				break;
			default:
				_003C_003Ec__DisplayClass10_.comment = comment;
				num2 = 6;
				break;
			case 3:
				u1aCRA97JHK850XRbio(SecurityService, new Action(_003C_003Ec__DisplayClass10_._003CPublish_003Eb__0));
				num2 = 5;
				break;
			case 2:
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass10_._003C_003E4__this = this;
				num2 = 4;
				break;
			}
		}
	}

	public virtual void Publish(long[] headerIds, string comment)
	{
		//Discarded unreachable code: IL_006a, IL_0079, IL_00de, IL_00ed
		int num = 3;
		int num2 = num;
		long headerId = default(long);
		long[] array = default(long[]);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 4:
			case 7:
				headerId = array[num3];
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return;
			case 1:
				Publish(headerId, comment, forEmulation: false);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 6;
				}
				break;
			case 3:
				pp7Gi49A2NsGfredKYR(headerIds, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886609083));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (num3 >= array.Length)
				{
					return;
				}
				num2 = 7;
				break;
			case 6:
				num3++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				num3 = 0;
				num2 = 8;
				break;
			case 2:
				array = headerIds;
				num2 = 9;
				break;
			}
		}
	}

	public FormMetadataItemDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		h3duLa9xuDIA45aajDg();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool NBcNEk94ADViCo31Khb()
	{
		return thokMm9wY1mUdfwXmsQ == null;
	}

	internal static FormMetadataItemDTOManager CqUd8V96C40yuNSu8ct()
	{
		return thokMm9wY1mUdfwXmsQ;
	}

	internal static object OdLLWy9HXapY3rHJn7m(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void pp7Gi49A2NsGfredKYR(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void u1aCRA97JHK850XRbio(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegies((Action)P_1);
	}

	internal static void h3duLa9xuDIA45aajDg()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
