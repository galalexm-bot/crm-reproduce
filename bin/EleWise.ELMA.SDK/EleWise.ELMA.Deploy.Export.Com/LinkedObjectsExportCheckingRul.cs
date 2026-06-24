using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.Enums;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.Export.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export.Components;

[Component]
internal sealed class LinkedObjectsExportCheckingRule : IExportCheckingRule
{
	private IFindLinkedObjectService findLinkedObjectService;

	internal static LinkedObjectsExportCheckingRule AqURk7EULNQE5GUi04C2;

	public LinkedObjectsExportCheckingRule(IFindLinkedObjectService findLinkedObjectService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FwsauKEUclfs0brkDyNn();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.findLinkedObjectService = findLinkedObjectService;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
			{
				num = 0;
			}
		}
	}

	public IExportCheckingResult Check(IExportCheckingContext context)
	{
		int num = 7;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		ExportCheckingMessageType? defaultExportLinkChecking = default(ExportCheckingMessageType?);
		ILinkedExportCheckingContext linkedExportCheckingContext = default(ILinkedExportCheckingContext);
		while (true)
		{
			switch (num2)
			{
			case 6:
				CPwticEUzsVEOMksWK4u(context, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A7A75C));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			case 3:
				return _003C_003Ec__DisplayClass2_.result;
			case 7:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 6;
				break;
			case 2:
				_003C_003Ec__DisplayClass2_.result = new BaseExportCheckingResult();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				if (defaultExportLinkChecking.HasValue)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 8:
				defaultExportLinkChecking = _003C_003Ec__DisplayClass2_.exportContext.DefaultExportLinkChecking;
				num2 = 9;
				break;
			case 5:
				if (linkedExportCheckingContext != null)
				{
					num2 = 8;
					break;
				}
				goto case 1;
			default:
				linkedExportCheckingContext = (_003C_003Ec__DisplayClass2_.exportContext = context as ILinkedExportCheckingContext);
				num2 = 5;
				break;
			case 4:
			{
				ICollection<ILinkedObject> findedObjects = findLinkedObjectService.FindLinkedObjects((LinkedObjectsSearchParams)aWV1x3EsFQW2w9hP7kEM(_003C_003Ec__DisplayClass2_.exportContext)).FindedObjects;
				if (findedObjects == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					findedObjects.ForEach(_003C_003Ec__DisplayClass2_._003CCheck_003Eb__0);
					num2 = 3;
				}
				break;
			}
			}
		}
	}

	internal static void FwsauKEUclfs0brkDyNn()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool U25i3NEUUNy4wYGIch4g()
	{
		return AqURk7EULNQE5GUi04C2 == null;
	}

	internal static LinkedObjectsExportCheckingRule fRx5ZkEUsAmZ2qfqa9ee()
	{
		return AqURk7EULNQE5GUi04C2;
	}

	internal static void CPwticEUzsVEOMksWK4u(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object aWV1x3EsFQW2w9hP7kEM(object P_0)
	{
		return ((ILinkedExportCheckingContext)P_0).SearchParams;
	}
}
