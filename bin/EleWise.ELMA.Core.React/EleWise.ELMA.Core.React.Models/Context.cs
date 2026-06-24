using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

[Component(CreateInstancePerResolve = true)]
public class Context : Inputs, IContext
{
}
