using System;

namespace EleWise.ELMA.CRM.Security;

public class CrmCustomPermission<T>
{
	protected Func<T, bool> _permissionCheckFunc;

	private string _name;

	public string Name => _name;

	public CrmCustomPermission(string name, Func<T, bool> permissionCheckFunc)
	{
		_name = name;
		_permissionCheckFunc = permissionCheckFunc;
	}

	public bool Check(T permission)
	{
		if (_permissionCheckFunc == null || permission == null)
		{
			return false;
		}
		return _permissionCheckFunc(permission);
	}
}
