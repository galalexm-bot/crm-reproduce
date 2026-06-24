using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.ViewModel;

public interface IComponentViewItemViewModel : IViewItemViewModel, IViewModel
{
	UIViewModel UIViewModel { get; }

	ViewItem CurrentViewItem { get; }

	bool IsDesignMode { get; }

	AdditionalModel[] AdditionalModels { get; }

	void ShowPartialViewItem(Guid uid);
}
