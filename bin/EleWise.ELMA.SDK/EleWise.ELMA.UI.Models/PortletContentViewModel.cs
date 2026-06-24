using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Descriptors;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Models;

public class PortletContentViewModel<TContext, TPersonalization> : FormViewModel<TContext>, IPortletContentViewModel, IFormViewModel where TContext : IEntity where TPersonalization : IPortletPersonalization
{
	internal static object sm1GiUBbiL2iDixM9pBY;

	public TPersonalization Settings { get; private set; }

	public PortletContentDescriptor PortletContentDescriptor => (PortletContentDescriptor)base.Descriptor;

	IPortletPersonalization IPortletContentViewModel.Settings => Settings;

	public PortletContentViewModel(PortletContentDescriptor descriptor, TPersonalization settings)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector((IFormPartDescriptor)descriptor);
		Contract.ArgumentNotNull(settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629817428));
		Settings = settings;
	}

	public PortletContentViewModel(PortletContentDescriptor descriptor, TContext context, TPersonalization settings, FormViewItem view)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector((IFormPartDescriptor)descriptor, context, view);
		Settings = settings;
	}

	internal static bool THcPXUBbR5cHCcTQnaOk()
	{
		return sm1GiUBbiL2iDixM9pBY == null;
	}

	internal static object S6gsYaBbqMqc2en6E8pN()
	{
		return sm1GiUBbiL2iDixM9pBY;
	}
}
