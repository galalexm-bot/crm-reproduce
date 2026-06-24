namespace EleWise.ELMA.Scheduling;

public interface ITriggerExtension : ITrigger
{
	int? JobResultTimeout { get; }
}
