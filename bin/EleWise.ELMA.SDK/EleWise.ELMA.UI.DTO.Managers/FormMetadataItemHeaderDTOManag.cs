using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.UI.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.DTO.Managers;

public class FormMetadataItemHeaderDTOManager : DTOManager, IFormMetadataItemHeaderDTOManager, IConfigurationService
{
	private static FormMetadataItemHeaderDTOManager X1y49J90QPwq6DGi7Ym;

	public FormMetadataItemHeaderManager Manager
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
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

	public virtual long GetPublishingVersionNumber(long headerId)
	{
		return OetfEb9M76BBwWdhp4F(Manager, headerId);
	}

	public virtual void Delete(long headerId)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				num2 = 2;
				break;
			case 2:
				_003C_003Ec__DisplayClass9_._003C_003E4__this = this;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass9_.headerId = headerId;
				num2 = 4;
				break;
			case 4:
				penDaK9JvX6QPdyHPnD(SecurityService, new Action(_003C_003Ec__DisplayClass9_._003CDelete_003Eb__0));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual bool ValidateName(long headerId, Guid metadataType, string name, out string errorMessage)
	{
		return Manager.ValidateName(headerId, metadataType, name, out errorMessage);
	}

	public virtual bool ValidateDisplayName(long headerId, Guid metadataType, string displayName, out string errorMessage)
	{
		return Manager.ValidateDisplayName(headerId, metadataType, displayName, out errorMessage);
	}

	public virtual string GetDisplayName(Guid uid)
	{
		int num = 5;
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return _003C_003Ec__DisplayClass12_.displayName;
				case 2:
					SecurityService.RunWithElevatedPrivilegies(_003C_003Ec__DisplayClass12_._003CGetDisplayName_003Eb__0);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					break;
				case 3:
					_003C_003Ec__DisplayClass12_.displayName = "";
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					_003C_003Ec__DisplayClass12_._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					_003C_003Ec__DisplayClass12_.uid = uid;
					num2 = 3;
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
			num = 4;
		}
	}

	public FormMetadataItemHeaderDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FgZ7ft99yYHChx8Xdli();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool G66PFi9mmi2WIpG5C0F()
	{
		return X1y49J90QPwq6DGi7Ym == null;
	}

	internal static FormMetadataItemHeaderDTOManager uqjTHt9ydMhYj1e37BW()
	{
		return X1y49J90QPwq6DGi7Ym;
	}

	internal static long OetfEb9M76BBwWdhp4F(object P_0, long headerId)
	{
		return ((FormMetadataItemHeaderManager)P_0).GetPublishingVersionNumber(headerId);
	}

	internal static void penDaK9JvX6QPdyHPnD(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegies((Action)P_1);
	}

	internal static void FgZ7ft99yYHChx8Xdli()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
