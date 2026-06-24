namespace EleWise.ELMA.Services;

internal interface IClearableContextBoundVariableService : IContextBoundVariableService, IAbstractBoundVariableService
{
	void ClearContext();
}
