using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Models;

public class PageItemViewModel<TContext> : IPageItemViewModel where TContext : IEntity
{
	private RootViewItem _view;

	private static object vEo04BBbGanimCkpsWte;

	public TContext Context { get; private set; }

	public FormViewBuilder<TContext> Form { get; protected set; }

	IEntity IPageItemViewModel.Context => Context;

	RootViewItem IPageItemViewModel.View => View;

	protected virtual RootViewItem View => _view;

	public PageItemViewModel(TContext context, RootViewItem view)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Contract.ArgumentNotNull(context, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE13F63));
		Contract.ArgumentNotNull(view, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A638B2));
		Context = context;
		_view = view;
		EntityMetadata metadata = (EntityMetadata)MetadataLoader.LoadMetadata(context.GetType());
		Form = new FormViewBuilder<TContext>(view, metadata);
	}

	internal static bool TY08O3BbE4k2pEvcAkJU()
	{
		return vEo04BBbGanimCkpsWte == null;
	}

	internal static object fpoctxBbfd6NZvO6c6T1()
	{
		return vEo04BBbGanimCkpsWte;
	}
}
