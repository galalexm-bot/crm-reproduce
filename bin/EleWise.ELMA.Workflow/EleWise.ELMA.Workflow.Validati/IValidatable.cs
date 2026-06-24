namespace EleWise.ELMA.Workflow.Validation;

public interface IValidatable
{
	void Validate(WorkflowProcessValidator validator);
}
