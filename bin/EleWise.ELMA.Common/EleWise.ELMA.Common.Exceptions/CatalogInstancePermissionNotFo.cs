using System;

namespace EleWise.ELMA.Common.Exceptions;

public class CatalogInstancePermissionNotFound : Exception
{
	public CatalogInstancePermissionNotFound(Type type)
		: base(SR.T("Привилегии на экземпляр объекта для типа {0} не реализованы", type.Name))
	{
	}

	public CatalogInstancePermissionNotFound(Type type, Guid permissionId)
		: base(SR.T("Привилегия {0} на экземпляр объекта для типа {1} не реализованы", permissionId, type.Name))
	{
	}
}
