using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Results;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models;

public class PageLoadViewModel<TContext> : PageViewModel<TContext>, IPageLoadViewModel, IPageViewModel, IFormViewModel where TContext : IEntity
{
	private static object VX5QcvBbQE025FaNv14l;

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

	public ToolbarLoadBuilder<TContext> Toolbar { get; protected set; }

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
				case 2:
					base.View = value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				case 1:
					Form = ((value != null) ? new FormViewLoadBuilder<TContext>(value, _descriptor.Metadata.Context, base.PropertyContainer) : null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected Toolbar PageLoadViewModelToolbar
	{
		get
		{
			return Toolbar.Toolbar;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					Toolbar = new ToolbarLoadBuilder<TContext>(value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PageLoadViewModel(PageContentDescriptor descriptor)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(descriptor, (PropertyViewInfoContainer)null);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PageLoadViewModel(PageContentDescriptor descriptor, PropertyViewInfoContainer propertyContainer)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(descriptor, propertyContainer);
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				base.Result = new PageLoadResult(this);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 1:
				PageLoadViewModelToolbar = ((descriptor.Metadata.View.Toolbar != null) ? ClassSerializationHelper.CloneObjectByXml(descriptor.Metadata.View.Toolbar) : null);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public PageLoadViewModel(PageContentDescriptor descriptor, TContext context, FormViewItem view)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(descriptor, context, view, (PropertyViewInfoContainer)null);
	}

	public PageLoadViewModel(PageContentDescriptor descriptor, TContext context, FormViewItem view, PropertyViewInfoContainer propertyContainer)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(descriptor, context, view, propertyContainer);
		PageLoadViewModelToolbar = ((descriptor.Metadata.View.Toolbar != null) ? ClassSerializationHelper.CloneObjectByXml(descriptor.Metadata.View.Toolbar) : null);
	}

	internal static bool RQw8kRBbCsSaxkKODpCZ()
	{
		return VX5QcvBbQE025FaNv14l == null;
	}

	internal static object Dwn9dOBbvphKBk6CgpSO()
	{
		return VX5QcvBbQE025FaNv14l;
	}
}
