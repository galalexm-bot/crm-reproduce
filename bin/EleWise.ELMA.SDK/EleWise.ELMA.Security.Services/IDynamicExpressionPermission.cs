namespace EleWise.ELMA.Security.Services;

public interface IDynamicExpressionPermission
{
	IPropertyExpressionDescriptor[] GetPropertyDescriptors(object target);
}
