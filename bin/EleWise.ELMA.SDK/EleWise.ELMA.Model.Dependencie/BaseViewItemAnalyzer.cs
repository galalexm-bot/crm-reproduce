using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies.Analyzers;

[Component]
internal abstract class BaseViewItemAnalyzer<T> : IViewItemAnalyzer
{
	private static object pF4BiIhRdR3RgkRkkgTb;

	public DependencyAnalysisResult Analyse(ClassMetadata contextMetadata, IMetadata metadata, FormViewItem form, DependencyServiceOptions options)
	{
		int num = 1;
		int num2 = num;
		IEnumerable<T> viewItems = default(IEnumerable<T>);
		DependencyAnalysisResult dependencyAnalysisResult;
		while (true)
		{
			switch (num2)
			{
			case 1:
				viewItems = form.FindItems(ignoreHide: false, CheckViewItem).Cast<T>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				dependencyAnalysisResult = ProcessViewItems(viewItems, contextMetadata, metadata, options);
				if (dependencyAnalysisResult != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				dependencyAnalysisResult = new DependencyAnalysisResult();
				break;
			}
			break;
		}
		return dependencyAnalysisResult;
	}

	protected virtual bool CheckViewItem(ViewItem viewItem)
	{
		return viewItem is T;
	}

	protected abstract DependencyAnalysisResult ProcessViewItems(IEnumerable<T> viewItems, ClassMetadata contextMetadata, IMetadata metadata, DependencyServiceOptions options);

	protected BaseViewItemAnalyzer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool IOBc3ehRlgn8TiPOCW1m()
	{
		return pF4BiIhRdR3RgkRkkgTb == null;
	}

	internal static object qYdvFlhRrOLDRR006AIa()
	{
		return pF4BiIhRdR3RgkRkkgTb;
	}
}
