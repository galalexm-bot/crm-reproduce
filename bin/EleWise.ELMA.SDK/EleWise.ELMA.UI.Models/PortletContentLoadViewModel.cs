using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Results;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models;

public class PortletContentLoadViewModel<TContext, TPersonalization> : PortletContentViewModel<TContext, TPersonalization>, IPortletContentLoadViewModel, IPortletContentViewModel, IFormViewModel where TContext : IEntity where TPersonalization : IPortletPersonalization
{
	internal static object xrUX7CBbIxug9iAFAuD5;

	public new FormViewLoadBuilder<TContext> Form
	{
		get
		{
			return (FormViewLoadBuilder<TContext>)base.Form;
		}
		protected set
		{
			base.Form = value;
		}
	}

	protected override FormViewItem View
	{
		get
		{
			return base.View;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					base.View = value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					Form = ((value != null) ? new FormViewLoadBuilder<TContext>(value, _descriptor.Metadata.Context) : null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PortletContentLoadViewModel(PortletContentDescriptor descriptor, TPersonalization settings)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(descriptor, settings);
		base.Result = new PortletContentLoadResult(this);
	}

	public PortletContentLoadViewModel(PortletContentDescriptor descriptor, TContext context, TPersonalization personalization, FormViewItem view)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(descriptor, context, personalization, view);
	}

	internal static bool i48aINBbVUxog4SiU45a()
	{
		return xrUX7CBbIxug9iAFAuD5 == null;
	}

	internal static object lBaqkEBbSgxnw5dVGYWf()
	{
		return xrUX7CBbIxug9iAFAuD5;
	}
}
