using System;
using Bridge;
using Bridge.React;
using EleWise.ELMA.Core.Model;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

public class InputsChildren : InputsWithChildren<Union<ReactElement[], Func<IData, ReactElement[]>>>
{
}
