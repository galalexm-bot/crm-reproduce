namespace EleWise.ELMA.Security.Services;

public interface IInstanceExpressionPermissionHolder
{
	IUser User { get; set; }

	string TypeRole { get; set; }

	object Target { get; set; }

	bool AllowChief { get; set; }
}
