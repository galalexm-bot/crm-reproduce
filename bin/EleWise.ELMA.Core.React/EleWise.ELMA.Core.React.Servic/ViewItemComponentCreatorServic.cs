using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Core.UI.Model;
using EleWise.ELMA.Core.UI.Renderers;
using EleWise.ELMA.Core.UI.Services;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Core.React.Services;

[Service]
public class ViewItemComponentCreatorService : IViewItemComponentCreatorService
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public ViewItem viewItem;

		internal bool _003CCreate_003Eb__0(IViewItemRenderer r)
		{
			return r.CanRender(viewItem);
		}
	}

	private readonly System.Collections.Generic.IEnumerable<IViewItemRenderer> renderers;

	private readonly IReactiveModelFactory reactiveModelFactory;

	public ViewItemComponentCreatorService(System.Collections.Generic.IEnumerable<IViewItemRenderer> renderers, IReactiveModelFactory reactiveModelFactory)
	{
		this.renderers = renderers;
		this.reactiveModelFactory = reactiveModelFactory;
	}

	public IRenderContent Create(ViewItem viewItem, IViewModel owner, IInputs inputs = null)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.viewItem = viewItem;
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.viewItem, "viewItem");
		IViewItemRenderer val = Enumerable.FirstOrDefault<IViewItemRenderer>(renderers, (Func<IViewItemRenderer, bool>)((IViewItemRenderer r) => r.CanRender(CS_0024_003C_003E8__locals0.viewItem)));
		if (val == null)
		{
			throw new System.Exception(SR.T("Не найдена точка расширения для отрисовки элемента представления формы {0}", CS_0024_003C_003E8__locals0.viewItem));
		}
		return val.Render(CS_0024_003C_003E8__locals0.viewItem, owner, inputs);
	}

	public IRenderContent Create(Guid uid, IViewModel owner, IInputs inputs = null)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		ComponentViewItem componentViewItem = reactiveModelFactory.CreateModel<ComponentViewItem>();
		componentViewItem.Uid = uid;
		componentViewItem.HeaderUid = uid;
		return Create((ViewItem)componentViewItem, owner, inputs);
	}
}
