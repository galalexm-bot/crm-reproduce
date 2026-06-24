namespace EleWise.ELMA.Security.Services;

public interface IPropertyExpressionDescriptorWithInstanceUid : IPropertyExpressionDescriptor
{
	PermissionRoleType RoleType { get; }

	string GetExpressionName(object obj);
}
