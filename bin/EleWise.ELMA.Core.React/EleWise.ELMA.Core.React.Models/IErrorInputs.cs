using System;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

public interface IErrorInputs : IInputs
{
	Func<string> Message { get; set; }

	Func<bool> StackShow { get; set; }
}
