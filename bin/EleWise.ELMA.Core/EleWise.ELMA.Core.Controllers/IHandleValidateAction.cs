namespace EleWise.ELMA.Core.Controllers;

public interface IHandleValidateAction
{
	void OnBeforeValidateAction();

	void OnAfterValidateAction();
}
