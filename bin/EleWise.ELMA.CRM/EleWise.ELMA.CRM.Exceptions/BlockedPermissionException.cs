using System;

namespace EleWise.ELMA.CRM.Exceptions;

[Serializable]
public class BlockedPermissionException : Exception
{
	public override string Message => SR.T("В данный момент производится обновление разрешений пользователей CRM. Внесение изменений в список разрешений заблокировано.   ");
}
