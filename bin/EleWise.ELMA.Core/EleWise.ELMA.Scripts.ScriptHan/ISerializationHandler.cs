using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.DTO;

namespace EleWise.ELMA.Scripts.ScriptHandlers;

[ExtensionPoint]
public interface ISerializationHandler
{
	void BeforeSerialize(ReactiveProxy proxy);
}
