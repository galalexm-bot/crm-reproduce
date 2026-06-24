using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.React.Components;
using EleWise.ELMA.Core.React.ExtensionPoints;
using EleWise.ELMA.Core.React.Models;
using EleWise.ELMA.Core.UI.Model;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Services;

[Service]
internal sealed class ReactComponentCreatorService : IReactComponentCreatorService
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public System.Type typeVic;

		internal bool _003CCreate_003Eb__0(IReactRenderer r)
		{
			return r.CanRender(typeVic);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<IReactRenderer, bool> _003C_003E9__4_0;

		internal bool _003CError_003Eb__4_0(IReactRenderer r)
		{
			return ((object)r).GetType() == typeof(ErrorRenderer);
		}
	}

	private readonly System.Collections.Generic.IEnumerable<IReactRenderer> renderers;

	public ReactComponentCreatorService(System.Collections.Generic.IEnumerable<IReactRenderer> renderers)
	{
		this.renderers = renderers;
	}

	public IRenderContent Create(System.Type typeVic, IInputs inputs, IViewModel owner)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals0.typeVic = typeVic;
		IReactRenderer reactRenderer = Enumerable.FirstOrDefault<IReactRenderer>(renderers, (Func<IReactRenderer, bool>)((IReactRenderer r) => r.CanRender(CS_0024_003C_003E8__locals0.typeVic)));
		if (reactRenderer != null)
		{
			return reactRenderer.Render(CS_0024_003C_003E8__locals0.typeVic, owner, inputs);
		}
		throw new System.Exception(SR.T("Не найден рендерер для компонента {0}", CS_0024_003C_003E8__locals0.typeVic.get_Name()));
	}

	public IRenderContent Create<T>(IInputs inputs, IViewModel owner)
	{
		return Create(typeof(T), inputs, owner);
	}

	public IRenderContent Error(IErrorInputs inputs, IViewModel owner)
	{
		IReactRenderer reactRenderer = Enumerable.FirstOrDefault<IReactRenderer>(renderers, (Func<IReactRenderer, bool>)((IReactRenderer r) => ((object)r).GetType() == typeof(ErrorRenderer)));
		if (reactRenderer != null)
		{
			return reactRenderer.Render(typeof(IErrorComponent), owner, inputs);
		}
		throw new System.Exception(SR.T("Не найден рендерер для компонента отображения ошибки"));
	}
}
