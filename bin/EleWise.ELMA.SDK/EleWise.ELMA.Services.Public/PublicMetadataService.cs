using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services.Public;

[Service(EnableInterceptors = false, Type = ComponentType.Server)]
public class PublicMetadataService
{
	private IEnumerable<IPublicMetadataProvider> _providers;

	private IMetadataRuntimeService _metadataRuntimeService;

	internal static PublicMetadataService OW4WL1B0Dy3Zo2CrN71H;

	public PublicMetadataService(IEnumerable<IPublicMetadataProvider> providers, IMetadataRuntimeService metadataRuntimeService)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		if (providers == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD431AE));
		}
		if (metadataRuntimeService == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A605402));
		}
		_providers = providers;
		_metadataRuntimeService = metadataRuntimeService;
	}

	public IEnumerable<IPublicMetadataGroupInfo> GetGroupInfoList()
	{
		return _providers.SelectMany((IPublicMetadataProvider p) => p.GetGroups()).ToArray();
	}

	public IEnumerable<IPublicMetadataInfo> GetMetadataInfoList()
	{
		return _providers.SelectMany((IPublicMetadataProvider p) => p.GetMetadataInfoList()).ToArray();
	}

	public IEnumerable<IMetadata> GetMetadataList()
	{
		return (from i in GetMetadataInfoList()
			select (IMetadata)_003C_003Ec.fHYvBGQntClom5cMY6GO(i) into m
			where m != null
			select m).ToArray();
	}

	public IMetadata LoadMetadata(Guid uid)
	{
		int num = 2;
		int num2 = num;
		IPublicMetadataInfo publicMetadataInfo = default(IPublicMetadataInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (publicMetadataInfo == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return publicMetadataInfo.GetMetadata();
			case 2:
				publicMetadataInfo = LoadMetadataInfo(uid);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return null;
			}
		}
	}

	public IPublicMetadataInfo LoadMetadataInfo(Guid uid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass5_.uid = uid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return GetMetadataInfoList().FirstOrDefault(_003C_003Ec__DisplayClass5_._003CLoadMetadataInfo_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Type GetTypeByUid(Guid uid)
	{
		Type typeByUidOrNull = GetTypeByUidOrNull(uid);
		if (X0CB1MB04oU42UN0xP5I(typeByUidOrNull, null))
		{
			throw new TypeNotFoundException(uid);
		}
		return typeByUidOrNull;
	}

	public Type GetTypeByUidOrNull(Guid uid)
	{
		//Discarded unreachable code: IL_006a
		int num = 2;
		IMetadata metadata = default(IMetadata);
		Type typeByUidOrNull = default(Type);
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		IPublicMetadataInfo publicMetadataInfo = default(IPublicMetadataInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (metadata != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 7:
					typeByUidOrNull = _metadataRuntimeService.GetTypeByUidOrNull(_003C_003Ec__DisplayClass7_.uid);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 6;
					}
					continue;
				case 9:
					if (publicMetadataInfo != null)
					{
						num2 = 3;
						continue;
					}
					goto case 6;
				case 1:
					_003C_003Ec__DisplayClass7_.uid = uid;
					num2 = 7;
					continue;
				case 3:
					goto end_IL_0012;
				case 8:
					if (!(typeByUidOrNull == null))
					{
						num2 = 6;
						continue;
					}
					break;
				default:
					return _metadataRuntimeService.GetTypeByUidOrNull(cAZvnMB0HsJWbQKVutXL(metadata));
				case 6:
					return typeByUidOrNull;
				case 2:
					_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					break;
				}
				publicMetadataInfo = GetMetadataInfoList().FirstOrDefault(_003C_003Ec__DisplayClass7_._003CGetTypeByUidOrNull_003Eb__0);
				num2 = 9;
				continue;
				end_IL_0012:
				break;
			}
			metadata = (IMetadata)Bb6Lh0B06FciwKP6kDmB(publicMetadataInfo);
			num = 5;
		}
	}

	internal static bool e4FOH2B0tZwuP3dSXA1S()
	{
		return OW4WL1B0Dy3Zo2CrN71H == null;
	}

	internal static PublicMetadataService ud5XgVB0wAXy7E4V1hAg()
	{
		return OW4WL1B0Dy3Zo2CrN71H;
	}

	internal static bool X0CB1MB04oU42UN0xP5I(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object Bb6Lh0B06FciwKP6kDmB(object P_0)
	{
		return ((IPublicMetadataInfo)P_0).GetMetadata();
	}

	internal static Guid cAZvnMB0HsJWbQKVutXL(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}
}
