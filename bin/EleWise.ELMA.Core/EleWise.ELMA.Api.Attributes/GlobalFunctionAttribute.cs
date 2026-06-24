using System;

namespace EleWise.ELMA.Api.Attributes;

[AttributeUsage(/*Could not decode attribute arguments.*/)]
internal sealed class GlobalFunctionAttribute : System.Attribute
{
	private readonly string functionStringUid;

	private Guid? functionUid;

	public Guid FunctionUid
	{
		get
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			if (functionUid.get_HasValue())
			{
				return functionUid.get_Value();
			}
			functionUid = new Guid(functionStringUid);
			return functionUid.get_Value();
		}
	}

	public GlobalFunctionAttribute(string functionUid)
	{
		functionStringUid = functionUid;
	}
}
