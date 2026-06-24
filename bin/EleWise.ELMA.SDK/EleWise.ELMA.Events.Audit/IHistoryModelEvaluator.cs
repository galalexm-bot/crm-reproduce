using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Events.Audit;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IHistoryModelEvaluator
{
	void Evaluate(IHistoryBaseModel historyModel);
}
