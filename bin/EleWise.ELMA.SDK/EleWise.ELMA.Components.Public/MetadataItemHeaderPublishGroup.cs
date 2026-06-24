using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints.Publication;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Publication;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Components.Publication;

[Component(Type = ComponentType.Server, Order = 100)]
internal class MetadataItemHeaderPublishGroupHandler : IPublishGroupHandler
{
	private readonly MetadataItemManager metadataItemManager;

	private static MetadataItemHeaderPublishGroupHandler P2VjVAfEbyjdCfIKhTfD;

	public MetadataItemHeaderPublishGroupHandler(MetadataItemManager metadataItemManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pEnbBHfEEefKUvbdUOyP();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.metadataItemManager = metadataItemManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public PublishDataResult Publish(ReferenceOnEntity[] data, string comment)
	{
		//Discarded unreachable code: IL_006b, IL_00df, IL_01a8, IL_01b7, IL_01db, IL_01ea
		int num = 6;
		int num2 = num;
		long[] array = default(long[]);
		IEnumerable<ReferenceOnEntity> source = default(IEnumerable<ReferenceOnEntity>);
		PublishDataResult result = default(PublishDataResult);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			switch (num2)
			{
			case 8:
				try
				{
					MetadataPublishResult metadataPublishResult = metadataItemManager.Publish(comment, array);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
						{
							PublishDataResult publishDataResult = new PublishDataResult(source.ToList());
							FQK8VKfEQEH4kWmfsV6E(publishDataResult, true);
							publishDataResult.NeedRestart = L2lMyZfEC9tj37ITJ2CB(metadataPublishResult);
							result = publishDataResult;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num3 = 0;
							}
							break;
						}
						default:
							return result;
						case 0:
							return result;
						}
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							Cyn5PmfEulHogFZmZF4R(BP6gLgfEvOudqDBH09Ac(), qoYqL3fEZVgeCSLk19nF(PDBMTJfE8QhNg97YNaBd(-3333094 ^ -3669730)), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
							{
								num4 = 0;
							}
							continue;
						case 2:
							return result;
						}
						List<string> list = new List<string>();
						object obj2 = esEpqrfEId30Qb5XUwgL(ex);
						object obj3 = PDBMTJfE8QhNg97YNaBd(0x5F3078B6 ^ 0x5F303194);
						object obj4 = s8VNCPfEVCMB1sdYPQH9(ex);
						list.Add((string)obj2 + (string)obj3 + (string)((obj4 != null) ? esEpqrfEId30Qb5XUwgL(obj4) : null));
						PublishDataResult publishDataResult2 = new PublishDataResult(null, list);
						FQK8VKfEQEH4kWmfsV6E(publishDataResult2, false);
						result = publishDataResult2;
						num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num4 = 2;
						}
					}
				}
			case 6:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 5;
				break;
			default:
				return result;
			case 5:
				_003C_003Ec__DisplayClass2_.metadataItemHeaderTypeUid = InterfaceActivator.UID<IMetadataItemHeader>();
				num2 = 4;
				break;
			case 1:
			{
				PublishDataResult obj = new PublishDataResult
				{
					IsSuccess = true
				};
				Ifdp4hfEfMOOhWoMtEKi(obj, false);
				return obj;
			}
			case 2:
				num2 = 8;
				break;
			case 3:
				if (array.Length != 0)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 4:
				source = data.Where(_003C_003Ec__DisplayClass2_._003CPublish_003Eb__0);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 6;
				}
				break;
			case 7:
				array = source.Select((ReferenceOnEntity x) => _003C_003Ec.STEAkw8l1V6tjeQbIhD2(x)).ToArray();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	internal static void pEnbBHfEEefKUvbdUOyP()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool M9mjDWfEhEURiRYuZU5P()
	{
		return P2VjVAfEbyjdCfIKhTfD == null;
	}

	internal static MetadataItemHeaderPublishGroupHandler LLyQ99fEGCqNEJtlDS1M()
	{
		return P2VjVAfEbyjdCfIKhTfD;
	}

	internal static void Ifdp4hfEfMOOhWoMtEKi(object P_0, bool value)
	{
		((PublishDataResult)P_0).NeedRestart = value;
	}

	internal static void FQK8VKfEQEH4kWmfsV6E(object P_0, bool value)
	{
		((PublishDataResult)P_0).IsSuccess = value;
	}

	internal static bool L2lMyZfEC9tj37ITJ2CB(object P_0)
	{
		return ((MetadataPublishResult)P_0).NeedRestart;
	}

	internal static object BP6gLgfEvOudqDBH09Ac()
	{
		return Logger.Log;
	}

	internal static object PDBMTJfE8QhNg97YNaBd(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object qoYqL3fEZVgeCSLk19nF(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void Cyn5PmfEulHogFZmZF4R(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object esEpqrfEId30Qb5XUwgL(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object s8VNCPfEVCMB1sdYPQH9(object P_0)
	{
		return ((Exception)P_0).InnerException;
	}
}
