using EleWise.ELMA.Model.Signatures;

namespace EleWise.ELMA.Model.Views;

public interface IActionInputComputedValue : IInputComputedValue, IComputedValue
{
	TypeSignature ReturnType { get; set; }

	TypeSignature ParameterType { get; set; }
}
