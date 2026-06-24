using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions;

[Component(Order = int.MaxValue)]
internal sealed class CommonEQLTemplateProvider : IEQLTemplateProvider
{
	private readonly IEnumerable<IObjectFormProvider> objectFormProviders;

	internal static CommonEQLTemplateProvider NDkswlG30i2HoNbP5ZYI;

	public CommonEQLTemplateProvider(IEnumerable<IObjectFormProvider> objectFormProviders)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.objectFormProviders = objectFormProviders;
	}

	public bool Check(Guid typeUid, Guid subTypeUid)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass2_.subTypeUid = subTypeUid;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass2_.typeUid = typeUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
			{
				IObjectFormProvider objectFormProvider = objectFormProviders.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CCheck_003Eb__0);
				if (objectFormProvider == null)
				{
					num2 = 4;
					break;
				}
				return Pel8ulG3MYAbiD0A55MF(objectFormProvider, _003C_003Ec__DisplayClass2_.typeUid, _003C_003Ec__DisplayClass2_.subTypeUid);
			}
			case 4:
				return false;
			}
		}
	}

	public object GetObjectInfo(Guid typeUid, Guid subTypeUid, string model)
	{
		//Discarded unreachable code: IL_0074, IL_0083
		int num = 6;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		IObjectFormProvider objectFormProvider = default(IObjectFormProvider);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					_003C_003Ec__DisplayClass3_.typeUid = typeUid;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					if (objectFormProvider != null)
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 1:
					objectFormProvider = objectFormProviders.FirstOrDefault(_003C_003Ec__DisplayClass3_._003CGetObjectInfo_003Eb__0);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 3;
					}
					break;
				default:
					_003C_003Ec__DisplayClass3_.subTypeUid = subTypeUid;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					return null;
				case 4:
					return objectFormProvider.GetObjectInfo(_003C_003Ec__DisplayClass3_.typeUid, _003C_003Ec__DisplayClass3_.subTypeUid, model).Item1;
				case 6:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 5;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	internal static bool Pel8ulG3MYAbiD0A55MF(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IObjectFormProvider)P_0).Check(typeUid, subTypeUid);
	}

	internal static bool XeV0X8G3mSqNJASCB8PM()
	{
		return NDkswlG30i2HoNbP5ZYI == null;
	}

	internal static CommonEQLTemplateProvider Qvt3DjG3yU3WBvfDOg1v()
	{
		return NDkswlG30i2HoNbP5ZYI;
	}
}
