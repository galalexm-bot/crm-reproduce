using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.React.Models;
using EleWise.ELMA.Core.UI.Model;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Services;

[ServiceContract]
public interface IReactComponentCreatorService
{
	IRenderContent Create(System.Type typeVic, IInputs inputs, IViewModel owner);

	IRenderContent Create<T>(IInputs inputs, IViewModel owner);

	IRenderContent Error(IErrorInputs inputs, IViewModel owner);
}
