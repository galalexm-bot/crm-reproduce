using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Results;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models;

public class PageViewModel<TContext> : FormViewModel<TContext>, IPageViewModel, IFormViewModel where TContext : IEntity
{
	private static object LVSHOJBb8TPUbO213bjS;

	PageContentDescriptor IPageViewModel.PageContentDescriptor => (PageContentDescriptor)base.Descriptor;

	public PageViewModel(PageContentDescriptor descriptor)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(descriptor, (PropertyViewInfoContainer)null);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PageViewModel(PageContentDescriptor descriptor, PropertyViewInfoContainer propertyContainer)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector((IFormPartDescriptor)descriptor, propertyContainer);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PageViewModel(PageContentDescriptor descriptor, TContext context, FormViewItem view)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(descriptor, context, view, (PropertyViewInfoContainer)null);
	}

	public PageViewModel(PageContentDescriptor descriptor, TContext context, FormViewItem view, PropertyViewInfoContainer propertyContainer)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector((IFormPartDescriptor)descriptor, context, view, propertyContainer);
	}

	public void RedirectToPage(string pageId)
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
				base.Result = new RedirectToPageResult(pageId);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void RedirectToUrl(string url)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				base.Result = new RedirectToUrlResult(url);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool dwjkQoBbZoVNSALtDXnu()
	{
		return LVSHOJBb8TPUbO213bjS == null;
	}

	internal static object WfjdZdBbuloLQLwHhI0j()
	{
		return LVSHOJBb8TPUbO213bjS;
	}
}
