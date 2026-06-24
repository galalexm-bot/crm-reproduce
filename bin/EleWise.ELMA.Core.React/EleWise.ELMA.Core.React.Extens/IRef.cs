using System;
using Bridge.Html5;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.ExtensionPoints;

public interface IRef : IInputs
{
	Action<HTMLElement> Ref { get; set; }
}
