using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Models;

public class PortletContentItemViewModel<TContext, TPersonalization> : IPortletContentItemViewModel where TContext : IEntity where TPersonalization : IPortletPersonalization
{
	private RootViewItem _view;

	internal static object q8qtCHBbKW2cjygSaeg2;

	public TContext Context { get; private set; }

	public TPersonalization Settings { get; private set; }

	public FormViewBuilder<TContext> Form { get; protected set; }

	IEntity IPortletContentItemViewModel.Context => Context;

	IPortletPersonalization IPortletContentItemViewModel.Settings => Settings;

	RootViewItem IPortletContentItemViewModel.View => View;

	protected virtual RootViewItem View => _view;

	public PortletContentItemViewModel(TContext context, TPersonalization settings, RootViewItem view)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Contract.ArgumentNotNull(context, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138941458));
		Contract.ArgumentNotNull(settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459617361));
		Contract.ArgumentNotNull(view, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317734830));
		Context = context;
		Settings = settings;
		_view = view;
		EntityMetadata metadata = (EntityMetadata)MetadataLoader.LoadMetadata(context.GetType());
		Form = new FormViewBuilder<TContext>(view, metadata);
	}

	internal static bool XoBdFBBbXGs0xOy5cHao()
	{
		return q8qtCHBbKW2cjygSaeg2 == null;
	}

	internal static object hKsxAIBbTDmCneTyDebS()
	{
		return q8qtCHBbKW2cjygSaeg2;
	}
}
