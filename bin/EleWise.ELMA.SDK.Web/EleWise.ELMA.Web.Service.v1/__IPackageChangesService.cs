using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Web.Service.v1;

internal class __IPackageChangesService
{
	private static string initDataSetsDescriptionProp;

	public static string PackageChangesDescription => SR.T("Сервис для отслеживания изменений");

	public static string InitDataSetsDescription => SR.T("Передать наборы данных, с которыми работает приложение");

	public static string InitDataSetsResultDescription => SR.T("True, если данные переданы на сервер");

	public static string InitDataSetsDataSetsParamDescription => SR.T("Список наборов данных, с которыми работает приложение");

	public static string ChangesDescription => SR.T("Получить изменения после указанной даты");

	public static string ChangesResultDescription => SR.T("Ответ с изменениями");

	public static string ChangesFromServerTimeParamDescription => SR.T("Серверная дата начала интервала проверки");

	public static string PackagesDescription => SR.T("Получить данные на сервере по идентификатору ответа после метода Changes");

	public static string PackagesResultDescription => SR.T("Ответ с пакетами данных");

	public static string PackagesPackageUidParamDescription => SR.T("Идентификатор пакета");

	public static string PackagesFromParamDescription => SR.T("Номер стартового пакета");

	public static string PackagesLengthParamDescription => SR.T("Количество пакетов");

	public static string PackagesCommitDescription => SR.T("Синхонизировать данные на сервере по идентификатору ответа после метода Packages");

	public static string PackagesCommitResultDescription => SR.T("True, если данные синхронизированы на сервере");

	public static string PackagesCommitPackageUidDescription => SR.T("Идентификатор пакета");

	public static string SyncDescription => SR.T("Синхонизировать данные на сервере с данными на клиенте");

	public static string SyncResultDescription => SR.T("True, если данные успешно сохранены");

	public static string SyncChangesParamDescription => SR.T("Запрос на синхронизацию");

	public static string InitDataSetsDescriptionProp
	{
		get
		{
			if (initDataSetsDescriptionProp == null)
			{
				initDataSetsDescriptionProp = InitDataSetsDescription;
				IEnumerable<IUpdatePackageService> extensionPoints = ComponentManager.Current.GetExtensionPoints<IUpdatePackageService>();
				if (extensionPoints.Any())
				{
					initDataSetsDescriptionProp += string.Format(SR.T("\r\nДоступные значения для наборов данных:\r\n{0}"), string.Join("\r\n", extensionPoints.Select((IUpdatePackageService p) => $"  {p.ServiceUid} ({p.ServiceName})")));
				}
			}
			return initDataSetsDescriptionProp;
		}
	}
}
