namespace EleWise.ELMA.Model.BackgroundOperations;

public interface ICallbackDelegate
{
	string[] ArgumentNames { get; set; }

	string DelegateSignature { get; set; }
}
