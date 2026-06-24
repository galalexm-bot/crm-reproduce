using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bridge.Html5;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Dispatcher;

[Component]
internal sealed class OpenPageAsyncCommandHandler : AbstractAsyncCommandHandler
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public string propertyName;

		internal bool _003CGenerateUrlParameters_003Eb__0(PropertyMetadata property)
		{
			return ((INamedMetadata)property).get_Name() == propertyName;
		}
	}

	private readonly IDescriptorService descriptorService;

	private readonly IMetadataServiceContext metadataServiceContext;

	private readonly IExtendEntityService extendEntityService;

	private readonly IProxyGeneratorService proxyGeneratorService;

	public OpenPageAsyncCommandHandler(IDescriptorService descriptorService, IMetadataServiceContext metadataServiceContext, IExtendEntityService extendEntityService, IProxyGeneratorService proxyGeneratorService)
	{
		this.descriptorService = descriptorService;
		this.metadataServiceContext = metadataServiceContext;
		this.extendEntityService = extendEntityService;
		this.proxyGeneratorService = proxyGeneratorService;
	}

	public override System.Threading.Tasks.Task HandleAsync(ActionCommand command)
	{
		if (command.ActionTypeId != "OpenPageAsyncTypeCommand")
		{
			return System.Threading.Tasks.Task.get_CompletedTask();
		}
		IViewModel viewModel = command.Args[0] as IViewModel;
		if (viewModel?.RenderOwner == null)
		{
			return System.Threading.Tasks.Task.get_CompletedTask();
		}
		object[] obj = command.Args[1] as object[];
		if (!(((obj != null) ? obj[0] : null) is OpenPageModel openPageModel))
		{
			return System.Threading.Tasks.Task.get_CompletedTask();
		}
		string text = GenerateUrlParameters(openPageModel, viewModel.RenderOwner);
		Window.Location.Href = openPageModel.BaseUrl + text;
		return System.Threading.Tasks.Task.get_CompletedTask();
	}

	private string GenerateUrlParameters(OpenPageModel model, IViewModel viewModel)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		Enumerator<InputComputedValue> enumerator = Enumerable.OfType<InputComputedValue>((System.Collections.IEnumerable)(object)model.DynamicProperties).ToList().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				InputComputedValue current = enumerator.get_Current();
				_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
				CS_0024_003C_003E8__locals0.propertyName = current.Name.Replace("Input___", "");
				object dynamicPropertyValue = StartProcessAsyncCommandHandler.GetDynamicPropertyValue(current, viewModel.Controller, viewModel, descriptorService, metadataServiceContext, extendEntityService, proxyGeneratorService);
				PropertyMetadata obj = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)model.ContextMetadata.get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata property) => ((INamedMetadata)property).get_Name() == CS_0024_003C_003E8__locals0.propertyName));
				ViewModelPropertyMetadata val = (ViewModelPropertyMetadata)(object)((obj is ViewModelPropertyMetadata) ? obj : null);
				if (val == null)
				{
					continue;
				}
				if (!text.StartsWith("?"))
				{
					text = "?";
				}
				TypeSettings settings = ((IPropertyMetadata)val).get_Settings();
				if (settings != null)
				{
					EntitySettings val2;
					if ((val2 = (EntitySettings)(object)((settings is EntitySettings) ? settings : null)) != null)
					{
						if (val2.get_RelationType() == 0)
						{
							object plainPropertyValue = dynamicPropertyValue.GetPlainPropertyValue("Id");
							text += $"{CS_0024_003C_003E8__locals0.propertyName}.Id={plainPropertyValue}&";
							continue;
						}
						int num = 0;
						{
							System.Collections.IEnumerator enumerator2 = ((System.Collections.IEnumerable)dynamicPropertyValue).GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									object plainPropertyValue2 = enumerator2.get_Current().GetPlainPropertyValue("Id");
									text += $"{CS_0024_003C_003E8__locals0.propertyName}[{num}].Id={plainPropertyValue2}&";
									num++;
								}
							}
							finally
							{
								System.IDisposable disposable = enumerator2 as System.IDisposable;
								if (disposable != null)
								{
									disposable.Dispose();
								}
							}
						}
						continue;
					}
					if (settings is DataClassSettings)
					{
						continue;
					}
				}
				text += $"{CS_0024_003C_003E8__locals0.propertyName}={dynamicPropertyValue}&";
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (!string.IsNullOrEmpty(text))
		{
			return text.Substring(0, text.get_Length() - 1);
		}
		return "";
	}
}
