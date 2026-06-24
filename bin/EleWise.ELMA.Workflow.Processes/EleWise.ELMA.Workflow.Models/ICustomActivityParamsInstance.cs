using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Workflow.Models;

[AutoImplementClassBase(typeof(CustomActivityParamsInstanceBase))]
public interface ICustomActivityParamsInstance : IAutoImplement
{
	[MethodImplementationName("GetExecutionContextCore")]
	[DisplayName(typeof(__Resources_ICustomActivityParamsInstance), "M_GetExecutionContext_DisplayName")]
	[UseImplementationType]
	IActivityExecutionContext GetExecutionContext();
}
