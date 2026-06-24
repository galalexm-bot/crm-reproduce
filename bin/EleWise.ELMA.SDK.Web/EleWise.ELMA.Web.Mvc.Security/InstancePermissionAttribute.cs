using System;

namespace EleWise.ELMA.Web.Mvc.Security;

[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
public class InstancePermissionAttribute : Attribute
{
	private Guid permissionId;

	private Type type;

	public Guid PermissionId => permissionId;

	public Type Type => type;

	public InstancePermissionAttribute(string permissionId)
	{
		this.permissionId = Guid.Parse(permissionId);
	}

	public InstancePermissionAttribute(Type type, string permissionId)
		: this(permissionId)
	{
		this.type = type;
	}
}
