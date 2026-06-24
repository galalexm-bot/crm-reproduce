using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.React.ExtensionPoints;

[ExtensionPoint]
public interface IElementWrapper
{
	System.Type Type { get; }

	bool CanWrap(IViewItem viewItem, IViewModel owner, ElementWrapperType wrapperType);
}
