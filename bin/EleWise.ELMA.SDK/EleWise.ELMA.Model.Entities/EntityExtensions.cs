using System.ComponentModel;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Model.Entities;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class EntityExtensions
{
	private static RunWithSoftDeletableService runWithSoftDeletableService;

	internal static EntityExtensions Yc6cvph8CAMfTy2PD3mv;

	private static RunWithSoftDeletableService RunWithSoftDeletableService
	{
		get
		{
			int num = 1;
			int num2 = num;
			RunWithSoftDeletableService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = runWithSoftDeletableService;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (runWithSoftDeletableService = Locator.GetServiceNotNull<RunWithSoftDeletableService>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static T CheckSoftDeletable<T>(T entity) where T : class, ISoftDeletable
	{
		if (entity != null && entity.IsDeleted && !RunWithSoftDeletableService.Turned)
		{
			return null;
		}
		return entity;
	}

	internal static bool kMUXWMh8vxSxDxnLjFNY()
	{
		return Yc6cvph8CAMfTy2PD3mv == null;
	}

	internal static EntityExtensions N3km9Rh88D50FwAuFlSW()
	{
		return Yc6cvph8CAMfTy2PD3mv;
	}
}
