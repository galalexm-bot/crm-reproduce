using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Signatures;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Views;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.React.ExtensionPoints;
using EleWise.ELMA.Core.React.Models;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Core.React.Components;

[Component]
public abstract class AbstractViewModelContextHandler : IViewModelContextHandler
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public string objectExpression;

		public IViewModel viewModel;

		public EntitySettings settings;

		internal bool _003CInitProperty_003Eb__1(ComputedValue i)
		{
			return i.Name == objectExpression;
		}

		internal string _003CInitProperty_003Eb__2()
		{
			if (viewModel.Controller == null)
			{
				return null;
			}
			GlobalScopeHelper.Push(viewModel);
			try
			{
				return settings.get_ComputedEqlQuery();
			}
			finally
			{
				GlobalScopeHelper.Pop(viewModel);
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_1
	{
		public string inputName;

		internal bool _003CInitProperty_003Eb__0(ComputedValue i)
		{
			return i.Name == inputName;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public IContextCreationParameters parameters;

		public Func<IController> _003C_003E9__0;

		public Func<IController> _003C_003E9__1;

		internal IController _003CInitPropertySettings_003Eb__0()
		{
			return parameters.ViewModel.Controller;
		}

		internal IController _003CInitPropertySettings_003Eb__1()
		{
			return parameters.ViewModel.Controller;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<System.Type, bool> _003C_003E9__14_0;

		internal bool _003CInitDynamicProperties_003Eb__14_0(System.Type q)
		{
			return AttributeHelper<DynamicPropertyContainerAttribute>.GetAttribute(q, inherited: true) != null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public string propertyName;

		public ComputedValue inp;

		public AbstractViewModelContextHandler _003C_003E4__this;

		internal object _003CGetPropertyValue_003Eb__0()
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			IViewModel scope = GlobalScopeHelper.GetScope();
			if (scope == null)
			{
				throw new System.Exception(SR.T("Не найден скоуп для свойства {0}, вычисляемого с помощью метода {1}", propertyName, inp.MethodName));
			}
			if (!(scope is IMetadataViewModel viewModel))
			{
				return null;
			}
			return viewModel.GetPropertyContext<object>(_003C_003E4__this.metadataServiceContext, inp.PropertyUid, Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)inp.PropertyParents)).Invoke();
		}

		internal object _003CGetPropertyValue_003Eb__1()
		{
			IViewModel scope = GlobalScopeHelper.GetScope();
			if (scope == null)
			{
				throw new System.Exception(SR.T("Не найден скоуп для свойства {0}, вычисляемого с помощью метода {1}", propertyName, inp.MethodName));
			}
			string methodName = inp.MethodName;
			IDataStack plainPropertyValue = scope.GetPlainPropertyValue<IDataStack>("Stack");
			if (scope is IFormViewModel formViewModel)
			{
				return ViewModelHelper.CallControllerMethod(formViewModel.Controllers, methodName, plainPropertyValue);
			}
			return ViewModelHelper.CallControllerMethod(scope.Controller, methodName, plainPropertyValue);
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public string testId;

		internal object _003CGetTestIdValue_003Eb__0()
		{
			return testId;
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public IContextCreationParameters parameters;

		internal IController _003CGetActionForInput_003Eb__0()
		{
			return parameters.ViewModel.RenderOwner.Controller;
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_1
	{
		public IFormViewModel formViewModel;
	}

	private sealed class _003C_003Ec__DisplayClass18_2
	{
		public string methodName;

		public _003C_003Ec__DisplayClass18_1 CS_0024_003C_003E8__locals1;

		public Func<KeyValuePair<Guid, IController>, bool> _003C_003E9__2;

		internal IController _003CGetActionForInput_003Eb__1()
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			return Enumerable.FirstOrDefault<KeyValuePair<Guid, IController>>((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, IController>>)CS_0024_003C_003E8__locals1.formViewModel.Controllers, (Func<KeyValuePair<Guid, IController>, bool>)((KeyValuePair<Guid, IController> c) => ((object)c.get_Value()).get_Item(methodName) != null)).get_Value();
		}

		internal bool _003CGetActionForInput_003Eb__2(KeyValuePair<Guid, IController> c)
		{
			return ((object)c.get_Value()).get_Item(methodName) != null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public IViewModel scope;

		public ComputedValue inp;

		public AbstractViewModelContextHandler _003C_003E4__this;

		internal object _003CGetValueFunc_003Eb__0()
		{
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			if (scope == null)
			{
				scope = GlobalScopeHelper.GetScope();
				if (scope == null)
				{
					throw new System.Exception(SR.T("Не найден скоуп для метода {0}", inp.MethodName));
				}
			}
			if (!(scope is IMetadataViewModel viewModel))
			{
				return null;
			}
			return viewModel.GetPropertyContext<object>(_003C_003E4__this.metadataServiceContext, inp.PropertyUid, Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)inp.PropertyParents)).Invoke();
		}

		internal object _003CGetValueFunc_003Eb__1()
		{
			if (scope == null)
			{
				scope = GlobalScopeHelper.GetScope();
				if (scope == null)
				{
					throw new System.Exception(SR.T("Не найден скоуп для метода {0}", inp.MethodName));
				}
			}
			string methodName = inp.MethodName;
			IDataStack plainPropertyValue = scope.GetPlainPropertyValue<IDataStack>("Stack");
			if (scope is IFormViewModel formViewModel)
			{
				return ViewModelHelper.CallControllerMethod(formViewModel.Controllers, methodName, plainPropertyValue);
			}
			return ViewModelHelper.CallControllerMethod(scope.Controller, methodName, plainPropertyValue);
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public AbstractViewModelContextHandler _003C_003E4__this;

		public Guid typeUid;

		public ComputedValue inp;

		public IViewModel renderOwner;

		public IDataStack stack;

		internal object _003CDefineInputs_003Eb__0()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return ComputedValueHelper.GetValue(_003C_003E4__this.descriptorService, typeUid, inp.Value, _003C_003E4__this.convertContext, (inp is InputComputedValue inputComputedValue) ? new bool?(inputComputedValue.Nullable) : null);
		}

		internal object _003CDefineInputs_003Eb__1()
		{
			return ExecuteMethod(renderOwner, inp.MethodName, stack);
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public IViewModel renderOwner;

		public ComputedValue inp;

		public IDataStack stack;

		internal object _003CDefineSetterCallback_003Eb__0()
		{
			return ExecuteMethod(renderOwner, inp.MethodName, stack);
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public IContextCreationParameters parameters;

		public IFormViewModel formViewModel;

		internal IController _003CGetActionForProperty_003Eb__0()
		{
			return parameters.ViewModel.Controller;
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_1
	{
		public string methodName;

		public _003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals1;

		public Func<KeyValuePair<Guid, IController>, bool> _003C_003E9__2;

		internal IController _003CGetActionForProperty_003Eb__1()
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			return Enumerable.FirstOrDefault<KeyValuePair<Guid, IController>>((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, IController>>)CS_0024_003C_003E8__locals1.formViewModel.Controllers, (Func<KeyValuePair<Guid, IController>, bool>)((KeyValuePair<Guid, IController> c) => ((object)c.get_Value()).get_Item(methodName) != null)).get_Value();
		}

		internal bool _003CGetActionForProperty_003Eb__2(KeyValuePair<Guid, IController> c)
		{
			return ((object)c.get_Value()).get_Item(methodName) != null;
		}
	}

	protected readonly IMetadataServiceContext metadataServiceContext;

	private readonly ICurrentPageService currentPageService;

	private readonly IConvertService convertService;

	private readonly IActionExecutionFacade actionExecutionFacade;

	private readonly IDescriptorService descriptorService;

	private readonly ModuleMetadataItemManager moduleMetadataItemManager;

	private readonly ConvertContext convertContext;

	private static readonly string TestPropertyName;

	private static Guid entitySettingsComputedEqlPropertyMetadataUid;

	protected AbstractViewModelContextHandler(IMetadataServiceContext metadataServiceContext, ICurrentPageService currentPageService, IConvertService convertService, IActionExecutionFacade actionExecutionFacade, IDescriptorService descriptorService, ModuleMetadataItemManager moduleMetadataItemManager, IExtendEntityService extendEntityService, IProxyGeneratorService proxyGeneratorService)
	{
		this.metadataServiceContext = metadataServiceContext;
		this.currentPageService = currentPageService;
		this.convertService = convertService;
		this.actionExecutionFacade = actionExecutionFacade;
		this.descriptorService = descriptorService;
		this.moduleMetadataItemManager = moduleMetadataItemManager;
		convertContext = new ConvertContext
		{
			ExtendEntityService = extendEntityService,
			ProxyGeneratorService = proxyGeneratorService
		};
	}

	public abstract bool Check(IViewModel viewModel);

	public abstract IContext CreateContext(IContextCreationParameters parameters, IViewItem viewItem);

	protected void InitProperty(PropertyMetadata property, ReactiveProxy context, IContextCreationParameters parameters)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals0.viewModel = parameters.ViewModel;
		IViewItem viewItem = null;
		if (CS_0024_003C_003E8__locals0.viewModel is IViewItemViewModel viewItemViewModel)
		{
			viewItem = viewItemViewModel.ViewItem;
		}
		if (viewItem == null)
		{
			return;
		}
		IViewModel renderOwner = CS_0024_003C_003E8__locals0.viewModel.RenderOwner;
		PropertyInfoExpression propertyExpression = metadataServiceContext.GetPropertyExpression((IPropertyMetadata)(object)property, context.Metadata);
		CS_0024_003C_003E8__locals0.objectExpression = propertyExpression.ObjectExpression;
		if (renderOwner != null && viewItem.DynamicProperties != null)
		{
			_003C_003Ec__DisplayClass12_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass12_1();
			string text = "Input___";
			ViewModelPropertyMetadata val = (ViewModelPropertyMetadata)(object)((property is ViewModelPropertyMetadata) ? property : null);
			if (val != null && val.get_Output())
			{
				text = "Output___";
			}
			CS_0024_003C_003E8__locals1.inputName = text + CS_0024_003C_003E8__locals0.objectExpression;
			ComputedValue computedValue = Enumerable.FirstOrDefault<ComputedValue>((System.Collections.Generic.IEnumerable<ComputedValue>)viewItem.DynamicProperties, (Func<ComputedValue, bool>)((ComputedValue i) => i.Name == CS_0024_003C_003E8__locals1.inputName)) ?? Enumerable.FirstOrDefault<ComputedValue>((System.Collections.Generic.IEnumerable<ComputedValue>)viewItem.DynamicProperties, (Func<ComputedValue, bool>)((ComputedValue i) => i.Name == CS_0024_003C_003E8__locals0.objectExpression));
			if (!InputIsNullOrEmpty(computedValue))
			{
				if (((IPropertyMetadata)property).get_TypeUid() == ActionDescriptor.UID)
				{
					object actionForInput = GetActionForInput(property, computedValue, parameters);
					if (actionForInput != null)
					{
						ClosureHelper.Closure<object, PropertyInfoExpression, object>(context, ConvertHelper.RedefineProp, new object[3] { context, propertyExpression, actionForInput });
					}
				}
				else if (val != null && val.get_Output())
				{
					if (computedValue.ComputedValueType == 3)
					{
						RelationType? relationTypeOrNull = ((IPropertyMetadata)val).get_Settings().GetRelationTypeOrNull();
						if (relationTypeOrNull.get_HasValue() && relationTypeOrNull == RelationType.ManyToMany)
						{
							ClosureHelper.Closure<IViewModel, IContext, Guid, PropertyInfoExpression, ComputedValue, IDataStack>(this, DefineInputs, new object[6]
							{
								renderOwner,
								context,
								((IPropertyMetadata)property).get_TypeUid(),
								propertyExpression,
								computedValue,
								parameters.OuterStack
							});
						}
						else
						{
							ClosureHelper.Closure<IViewModel, IContext, Guid, PropertyInfoExpression, ComputedValue, IDataStack>(this, DefineSetterProperty, new object[6]
							{
								renderOwner,
								context,
								((IPropertyMetadata)property).get_TypeUid(),
								propertyExpression,
								computedValue,
								parameters.OuterStack
							});
						}
					}
					else
					{
						ClosureHelper.Closure<IViewModel, IContext, Guid, PropertyInfoExpression, ComputedValue, IDataStack>(this, DefineSetterCallback, new object[6]
						{
							renderOwner,
							context,
							((IPropertyMetadata)property).get_TypeUid(),
							propertyExpression,
							computedValue,
							parameters.OuterStack
						});
					}
				}
				else
				{
					ClosureHelper.Closure<IViewModel, IContext, Guid, PropertyInfoExpression, ComputedValue, IDataStack>(this, DefineInputs, new object[6]
					{
						renderOwner,
						context,
						((IPropertyMetadata)property).get_TypeUid(),
						propertyExpression,
						computedValue,
						parameters.OuterStack
					});
				}
				return;
			}
		}
		if (((IPropertyMetadata)property).get_TypeUid() == ActionDescriptor.UID)
		{
			object actionForProperty = GetActionForProperty(property, parameters);
			if (actionForProperty != null)
			{
				ClosureHelper.Closure<object, PropertyInfoExpression, object>(context, ConvertHelper.RedefineProp, new object[3] { context, propertyExpression, actionForProperty });
			}
			return;
		}
		ViewModelPropertyMetadata val2 = (ViewModelPropertyMetadata)(object)((property is ViewModelPropertyMetadata) ? property : null);
		if (val2 == null)
		{
			return;
		}
		ref EntitySettings settings = ref CS_0024_003C_003E8__locals0.settings;
		TypeSettings settings2 = ((IPropertyMetadata)val2).get_Settings();
		if ((settings = (EntitySettings)(object)((settings2 is EntitySettings) ? settings2 : null)) != null && CS_0024_003C_003E8__locals0.settings.get_IsComputedEqlValue())
		{
			_ = CS_0024_003C_003E8__locals0.viewModel.ComponentDispatcher;
			ComputedValue computedEqlProperty = val2.GetComputedEqlProperty();
			if (computedEqlProperty != null && computedEqlProperty.ComputedValueType != 0)
			{
				ReactiveProxy reactiveProxy = ObjectExtensions.As<ReactiveProxy>((object)CS_0024_003C_003E8__locals0.settings);
				ClassMetadata val3 = reactiveProxy.Metadata;
				if (val3 == null)
				{
					string plainPropertyValue = reactiveProxy.GetPlainPropertyValue<string>("$t");
					IMetadata metadataByHash = metadataServiceContext.GetMetadataByHash(plainPropertyValue);
					val3 = (ClassMetadata)(object)((metadataByHash is ClassMetadata) ? metadataByHash : null);
				}
				ValueTuple<ClassMetadata, IPropertyMetadata> propertyWithOwner = metadataServiceContext.GetPropertyWithOwner(val3, entitySettingsComputedEqlPropertyMetadataUid);
				ClassMetadata item = propertyWithOwner.Item1;
				IPropertyMetadata item2 = propertyWithOwner.Item2;
				PropertyInfoExpression propertyExpression2 = metadataServiceContext.GetPropertyExpression(item2, item);
				ClosureHelper.Closure<ComputedValue, object, string>(this, WriteGetterConfigurable, new object[3] { computedEqlProperty, CS_0024_003C_003E8__locals0.settings, propertyExpression2.ObjectExpression });
			}
		}
		else if (!val2.get_Input() && val2.get_ClientOnly() && val2.get_ComputedValue() != null && val2.get_ComputedValue().get_ComputedValueType() != 0 && ((val2.get_ComputedValue().get_ComputedValueType() == 1 && !string.IsNullOrWhiteSpace(val2.get_ComputedValue().get_MethodName())) || (val2.get_ComputedValue().get_ComputedValueType() == 2 && !string.IsNullOrWhiteSpace(val2.get_ComputedValue().get_CalculateScript()))))
		{
			ComputedValue computedValue2 = DynamicPropertyHelper.ComputedValueMapToObject(val2.get_ComputedValue());
			ClosureHelper.Closure<IViewModel, ComputedValue, object, PropertyInfoExpression>(this, WriteComputedGetter, new object[4] { CS_0024_003C_003E8__locals0.viewModel, computedValue2, context, propertyExpression });
		}
	}

	protected void InitPropertySettings(PropertyMetadata property, IContextCreationParameters parameters)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
		CS_0024_003C_003E8__locals0.parameters = parameters;
		ViewModelPropertyMetadata val;
		if ((val = (ViewModelPropertyMetadata)(object)((property is ViewModelPropertyMetadata) ? property : null)) == null || !(CS_0024_003C_003E8__locals0.parameters.ViewModel is IViewModelWithDynamicPropertySettings viewModelWithDynamicPropertySettings))
		{
			return;
		}
		TypeSettings val2 = ((IPropertyMetadata)val).get_Settings().Clone<TypeSettings>();
		System.Collections.Generic.IEnumerator<ComputedValue> enumerator = ((System.Collections.Generic.IEnumerable<ComputedValue>)val.get_ComputedValues()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ComputedValue current = enumerator.get_Current();
				ActionInputComputedValue val3;
				if ((val3 = (ActionInputComputedValue)(object)((current is ActionInputComputedValue) ? current : null)) != null && ((InputComputedValue)val3).get_TypeUid() == ActionDescriptor.UID)
				{
					ActionInputComputedValue obj = DynamicPropertyHelper.ComputedValueMapToObject((ComputedValue)(object)val3) as ActionInputComputedValue;
					ActionValue actionValue = ActionComputedValueHelper.CreateActionValue(obj, null);
					IActionExecutionContext actionExecutionContext = new EmptyActionExecutionContext(property, () => CS_0024_003C_003E8__locals0.parameters.ViewModel.Controller);
					if (!string.IsNullOrWhiteSpace(actionValue.MethodName))
					{
						actionExecutionContext = new ClientFunctionExecutionContext(actionValue.MethodName, () => CS_0024_003C_003E8__locals0.parameters.ViewModel.Controller, CS_0024_003C_003E8__locals0.parameters.OuterStack);
					}
					TypeSignature returnType = obj.ReturnType;
					TypeSignature parameterType = obj.ParameterType;
					object obj2 = CreateClosureForAction(returnType, parameterType, actionExecutionContext);
					if (obj2 != null)
					{
						Tuple<object, string> dynamicPropertyInfo = DynamicPropertyHelper.GetDynamicPropertyInfo(val, current.get_Name());
						PropertyInfoExpression propertyInfoExpression = new PropertyInfoExpression
						{
							ObjectExpression = dynamicPropertyInfo.get_Item2(),
							ExpressionForSerialize = dynamicPropertyInfo.get_Item2()
						};
						ClosureHelper.Closure<object, PropertyInfoExpression, object>(val2, ConvertHelper.RedefineProp, new object[3] { val2, propertyInfoExpression, obj2 });
					}
				}
				else
				{
					if (current.get_ComputedValueType() == 0)
					{
						continue;
					}
					Tuple<object, string> dynamicPropertyInfo2 = DynamicPropertyHelper.GetDynamicPropertyInfo(val, current.get_Name());
					object item = dynamicPropertyInfo2.get_Item1();
					if (item != null)
					{
						string item2 = dynamicPropertyInfo2.get_Item2();
						if (item.HasProperty(item2))
						{
							ComputedValue computedValue = DynamicPropertyHelper.ComputedValueMapToObject(current);
							ClosureHelper.Closure<ComputedValue, object, string>(this, WriteGetter, new object[3] { computedValue, item, item2 });
						}
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		viewModelWithDynamicPropertySettings.DynamicSettings.set_Item((IPropertyMetadata)(object)val, val2);
	}

	protected void InitDynamicProperties(IContextCreationParameters parameters, IViewItem viewItem)
	{
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		if (viewItem.GetPlainPropertyValue<bool>("over") || viewItem.Hide)
		{
			return;
		}
		if (viewItem is FormViewItem formViewItem && formViewItem.Toolbar != null)
		{
			InitDynamicProperties(parameters, formViewItem.Toolbar);
		}
		if (viewItem is RootViewItem rootViewItem)
		{
			System.Collections.Generic.IEnumerator<ViewItem> enumerator = rootViewItem.Items.GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					ViewItem current = enumerator.get_Current();
					InitDynamicProperties(parameters, current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		bool flag = true;
		System.Collections.Generic.IEnumerator<ComputedValue> enumerator2 = ((System.Collections.Generic.IEnumerable<ComputedValue>)viewItem.DynamicProperties).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator2).MoveNext())
			{
				ComputedValue current2 = enumerator2.get_Current();
				if (current2.Name.Contains("Attributes.TypeSettings."))
				{
					continue;
				}
				Tuple<object, string> dynamicPropertyInfo = DynamicPropertyHelper.GetDynamicPropertyInfo(viewItem, current2.Name);
				object item = dynamicPropertyInfo.get_Item1();
				if (item == null)
				{
					continue;
				}
				string item2 = dynamicPropertyInfo.get_Item2();
				if (item2 == TestPropertyName && current2.ComputedValueType == 1)
				{
					flag = false;
				}
				if (!item.HasProperty(item2))
				{
					continue;
				}
				if (current2.ComputedValueType == 0)
				{
					ValueTuple<bool, ActionValue> val = ActionComputedValueHelper.IsAction(current2);
					bool item3 = val.Item1;
					ActionValue item4 = val.Item2;
					if (!item3)
					{
						continue;
					}
					PropertyInfo property = item.GetType().GetProperty(item2);
					if (property == null)
					{
						continue;
					}
					IActionExecutionContext actionExecutionContext = null;
					System.Type type = null;
					TypeSignature typeSignature = null;
					TypeSignature typeSignature2 = null;
					if (property.get_PropertyType() == typeof(DefaultAction))
					{
						type = typeof(DefaultAction);
					}
					else if (property.get_PropertyType().get_IsGenericType())
					{
						System.Type[] genericArguments = property.get_PropertyType().GetGenericArguments();
						System.Type genericTypeDefinition = property.get_PropertyType().GetGenericTypeDefinition();
						if (genericTypeDefinition == typeof(ActionWithParam<>))
						{
							type = typeof(ActionWithParam<>).MakeGenericType(genericArguments);
							typeSignature = convertService.ToSignature(Enumerable.FirstOrDefault<System.Type>((System.Collections.Generic.IEnumerable<System.Type>)genericArguments));
						}
						else if (genericTypeDefinition == typeof(ActionWithResult<>))
						{
							type = typeof(ActionWithResult<>).MakeGenericType(genericArguments);
							typeSignature2 = convertService.ToSignature(Enumerable.FirstOrDefault<System.Type>((System.Collections.Generic.IEnumerable<System.Type>)genericArguments));
						}
						else if (genericTypeDefinition == typeof(ActionWithParamResult<, >))
						{
							type = typeof(ActionWithParamResult<, >).MakeGenericType(genericArguments);
							typeSignature = convertService.ToSignature(Enumerable.FirstOrDefault<System.Type>((System.Collections.Generic.IEnumerable<System.Type>)genericArguments));
							typeSignature2 = convertService.ToSignature(Enumerable.LastOrDefault<System.Type>((System.Collections.Generic.IEnumerable<System.Type>)genericArguments));
						}
					}
					if (item4 == null)
					{
						actionExecutionContext = new EmptyActionExecutionContext();
					}
					switch (item4.CodeType)
					{
					case 0:
						if (!string.IsNullOrWhiteSpace(item4.MethodName))
						{
							actionExecutionContext = new ClientFunctionExecutionContext(item4.MethodName);
						}
						break;
					case 1:
						if (!string.IsNullOrWhiteSpace(item4.MethodName))
						{
							Guid metadataUid2 = parameters.MetadataUid;
							Guid metadataTypeUid = parameters.MetadataTypeUid;
							if (!(metadataUid2 == Guid.Empty) && !(metadataTypeUid == Guid.Empty))
							{
								actionExecutionContext = new ServerFunctionExecutionContext(item4.MethodName, metadataTypeUid, metadataUid2, new Signature
								{
									Nullable = typeSignature2.Nullable,
									RelationType = typeSignature2.RelationType,
									TypeUid = typeSignature2.TypeUid,
									SubTypeUid = typeSignature2.SubTypeUid
								}, new Signature
								{
									Nullable = typeSignature.Nullable,
									RelationType = typeSignature.RelationType,
									TypeUid = typeSignature.TypeUid,
									SubTypeUid = typeSignature.SubTypeUid
								});
							}
						}
						break;
					case 3:
					{
						Guid metadataUid = parameters.MetadataUid;
						if (!(metadataUid == Guid.Empty))
						{
							Guid functionItemUid = currentPageService.GetFunctionItemUid(metadataUid, item4.FunctionHeaderUid);
							if (functionItemUid == Guid.Empty)
							{
								functionItemUid = currentPageService.GetFunctionItemUid(parameters.MetadataModuleUid, item4.FunctionHeaderUid);
							}
							actionExecutionContext = new GlobalFunctionExecutionContext(functionItemUid, new Signature
							{
								Nullable = typeSignature2.Nullable,
								RelationType = typeSignature2.RelationType,
								TypeUid = typeSignature2.TypeUid,
								SubTypeUid = typeSignature2.SubTypeUid
							}, new Signature
							{
								Nullable = typeSignature.Nullable,
								RelationType = typeSignature.RelationType,
								TypeUid = typeSignature.TypeUid,
								SubTypeUid = typeSignature.SubTypeUid
							});
						}
						break;
					}
					}
					if (type != null && actionExecutionContext != null)
					{
						IAction action = (IAction)Activator.CreateInstance(type, new object[2] { actionExecutionContext, actionExecutionFacade });
						PropertyInfoExpression propertyInfoExpression = new PropertyInfoExpression
						{
							ObjectExpression = item2,
							ExpressionForSerialize = item2
						};
						ClosureHelper.Closure<object, PropertyInfoExpression, object>(item, ConvertHelper.RedefineProp, new object[3] { item, propertyInfoExpression, action });
					}
					continue;
				}
				ClosureHelper.Closure<ComputedValue, object, string>(this, GetPropertyValue, new object[3] { current2, item, item2 });
				List<System.Type> val2 = Enumerable.Where<System.Type>((System.Collections.Generic.IEnumerable<System.Type>)item.GetType().GetInterfaces(), (Func<System.Type, bool>)((System.Type q) => AttributeHelper<DynamicPropertyContainerAttribute>.GetAttribute(q, inherited: true) != null)).ToList();
				if (val2.get_Count() <= 0)
				{
					continue;
				}
				Enumerator<System.Type> enumerator3 = val2.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						PropertyInfo property2 = enumerator3.get_Current().GetProperty(item2);
						if (property2 != null)
						{
							ClosureHelper.Closure<ComputedValue, object, string>(this, GetPropertyValue, new object[3]
							{
								current2,
								item,
								property2.get_ScriptFieldName()
							});
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator3).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator2)?.Dispose();
		}
		if (flag)
		{
			ClosureHelper.Closure<IViewItem, string, IContextCreationParameters>(this, GetTestIdValue, new object[3] { viewItem, TestPropertyName, parameters });
		}
		((object)viewItem).set_Item("over", (object)true);
	}

	private void GetPropertyValue(ComputedValue inp, object context, string propertyName)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		_003C_003Ec__DisplayClass15_.propertyName = propertyName;
		_003C_003Ec__DisplayClass15_.inp = inp;
		_003C_003Ec__DisplayClass15_._003C_003E4__this = this;
		ComputedValueType computedValueType = (ComputedValueType)_003C_003Ec__DisplayClass15_.inp.ComputedValueType;
		if ((uint)(computedValueType - 1) > 1u)
		{
			_ = 3;
		}
	}

	private void GetTestIdValue(IViewItem viewItem, string propertyName, IContextCreationParameters parameters)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
		string headerName = moduleMetadataItemManager.GetHeaderName(parameters.MetadataModuleUid);
		IMetadata metadata = ((IMetadataViewModel)parameters.ViewModel).UIViewModel.get_Metadata();
		NamedMetadata val;
		string text = (((val = (NamedMetadata)(object)((metadata is NamedMetadata) ? metadata : null)) != null) ? ((INamedMetadata)val).get_Name() : "");
		string name = viewItem.Name;
		_003C_003Ec__DisplayClass16_.testId = string.Concat(new string[5] { headerName, "-", text, "-", name });
	}

	private static bool InputIsNullOrEmpty(ComputedValue computedValue)
	{
		if (computedValue == null)
		{
			return true;
		}
		switch (computedValue.ComputedValueType)
		{
		case 0:
			if (computedValue.Value == null)
			{
				return true;
			}
			break;
		case 1:
			if (string.IsNullOrEmpty(computedValue.MethodName))
			{
				return true;
			}
			break;
		case 2:
			if (string.IsNullOrEmpty(computedValue.CalculateScript))
			{
				return true;
			}
			break;
		}
		return false;
	}

	private object GetActionForInput(PropertyMetadata property, ComputedValue computedValue, IContextCreationParameters parameters)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
		CS_0024_003C_003E8__locals0.parameters = parameters;
		IViewModel renderOwner = CS_0024_003C_003E8__locals0.parameters.ViewModel.RenderOwner;
		if (renderOwner == null)
		{
			return null;
		}
		switch (computedValue.ComputedValueType)
		{
		case 0:
		{
			TypeSettings settings = ((IPropertyMetadata)property).get_Settings();
			ActionSettings val;
			if ((val = (ActionSettings)(object)((settings is ActionSettings) ? settings : null)) == null)
			{
				break;
			}
			_003C_003Ec__DisplayClass18_1 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_1();
			IMetadataViewModel metadataViewModel = renderOwner as IMetadataViewModel;
			ActionValue actionValue = ActionComputedValueHelper.CreateActionValue(computedValue, null);
			Func<IController> controllerFunc = () => CS_0024_003C_003E8__locals0.parameters.ViewModel.RenderOwner.Controller;
			if ((_003C_003Ec__DisplayClass18_.formViewModel = CS_0024_003C_003E8__locals0.parameters.ViewModel.RenderOwner as IFormViewModel) != null)
			{
				_003C_003Ec__DisplayClass18_2 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass18_2();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass18_;
				CS_0024_003C_003E8__locals1.methodName = ScriptMethodInfoHelper.Deserialize(actionValue.MethodName).Name;
				if (!string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals1.methodName))
				{
					controllerFunc = () => Enumerable.FirstOrDefault<KeyValuePair<Guid, IController>>((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, IController>>)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.formViewModel.Controllers, (Func<KeyValuePair<Guid, IController>, bool>)((KeyValuePair<Guid, IController> c) => ((object)c.get_Value()).get_Item(CS_0024_003C_003E8__locals1.methodName) != null)).get_Value();
				}
			}
			IActionExecutionContext actionExecutionContext = GetActionExecutionContext(property, actionValue, val, (metadataViewModel != null) ? metadataViewModel.UIViewModel.get_Uid() : Guid.Empty, (metadataViewModel != null) ? metadataViewModel.UIViewModel.get_TypeUid() : Guid.Empty, (metadataViewModel != null) ? metadataViewModel.UIViewModel.get_Metadata().get_ModuleUid() : Guid.Empty, CS_0024_003C_003E8__locals0.parameters.OuterStack, controllerFunc);
			TypeSignature returnTypeSignature = DynamicPropertyHelper.TypeSignatureMapToObject(val.get_ReturnType());
			TypeSignature parameterTypeSignature = DynamicPropertyHelper.TypeSignatureMapToObject(val.get_ParameterType());
			return CreateClosureForAction(returnTypeSignature, parameterTypeSignature, actionExecutionContext);
		}
		case 3:
			return ((IMetadataViewModel)renderOwner).GetPropertyContext<object>(metadataServiceContext, computedValue.PropertyUid, Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)computedValue.PropertyParents)).Invoke();
		case 2:
			return ViewModelHelper.CallControllerMethod(renderOwner.Controller, computedValue.MethodName, null);
		}
		return null;
	}

	private void WriteComputedGetter(IViewModel viewModel, ComputedValue inp, object context, PropertyInfoExpression expression)
	{
		Func<object> valueFunc = GetValueFunc(inp, viewModel);
		ConvertHelper.RedefineProp(context, expression, valueFunc);
	}

	private void WriteGetter(ComputedValue inp, object context, string propertyName)
	{
		GetValueFunc(inp);
	}

	private void WriteGetterConfigurable(ComputedValue inp, object context, string propertyName)
	{
		GetValueFunc(inp);
	}

	private Func<object> GetValueFunc(ComputedValue inp, IViewModel viewModel = null)
	{
		_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_0();
		CS_0024_003C_003E8__locals0.inp = inp;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		Func<object> result = null;
		CS_0024_003C_003E8__locals0.scope = viewModel;
		switch (CS_0024_003C_003E8__locals0.inp.ComputedValueType)
		{
		case 3:
			result = delegate
			{
				//IL_0062: Unknown result type (might be due to invalid IL or missing references)
				if (CS_0024_003C_003E8__locals0.scope == null)
				{
					CS_0024_003C_003E8__locals0.scope = GlobalScopeHelper.GetScope();
					if (CS_0024_003C_003E8__locals0.scope == null)
					{
						throw new System.Exception(SR.T("Не найден скоуп для метода {0}", CS_0024_003C_003E8__locals0.inp.MethodName));
					}
				}
				return (!(CS_0024_003C_003E8__locals0.scope is IMetadataViewModel viewModel2)) ? null : viewModel2.GetPropertyContext<object>(CS_0024_003C_003E8__locals0._003C_003E4__this.metadataServiceContext, CS_0024_003C_003E8__locals0.inp.PropertyUid, Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)CS_0024_003C_003E8__locals0.inp.PropertyParents)).Invoke();
			};
			break;
		case 1:
		case 2:
			result = delegate
			{
				if (CS_0024_003C_003E8__locals0.scope == null)
				{
					CS_0024_003C_003E8__locals0.scope = GlobalScopeHelper.GetScope();
					if (CS_0024_003C_003E8__locals0.scope == null)
					{
						throw new System.Exception(SR.T("Не найден скоуп для метода {0}", CS_0024_003C_003E8__locals0.inp.MethodName));
					}
				}
				string methodName = CS_0024_003C_003E8__locals0.inp.MethodName;
				IDataStack plainPropertyValue = CS_0024_003C_003E8__locals0.scope.GetPlainPropertyValue<IDataStack>("Stack");
				return (CS_0024_003C_003E8__locals0.scope is IFormViewModel formViewModel) ? ViewModelHelper.CallControllerMethod(formViewModel.Controllers, methodName, plainPropertyValue) : ViewModelHelper.CallControllerMethod(CS_0024_003C_003E8__locals0.scope.Controller, methodName, plainPropertyValue);
			};
			break;
		}
		return result;
	}

	private void DefineInputs(IViewModel renderOwner, IContext context, Guid typeUid, PropertyInfoExpression expression, ComputedValue inp, IDataStack stack)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass23_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.typeUid = typeUid;
		CS_0024_003C_003E8__locals0.inp = inp;
		CS_0024_003C_003E8__locals0.renderOwner = renderOwner;
		CS_0024_003C_003E8__locals0.stack = stack;
		ConvertHelper.DefineInput(context, expression);
		Func<object> value;
		switch (CS_0024_003C_003E8__locals0.inp.ComputedValueType)
		{
		case 0:
			value = () => ComputedValueHelper.GetValue(CS_0024_003C_003E8__locals0._003C_003E4__this.descriptorService, CS_0024_003C_003E8__locals0.typeUid, CS_0024_003C_003E8__locals0.inp.Value, CS_0024_003C_003E8__locals0._003C_003E4__this.convertContext, (CS_0024_003C_003E8__locals0.inp is InputComputedValue inputComputedValue) ? new bool?(inputComputedValue.Nullable) : null);
			break;
		case 3:
			value = ((IMetadataViewModel)CS_0024_003C_003E8__locals0.renderOwner).GetPropertyContext<object>(metadataServiceContext, CS_0024_003C_003E8__locals0.inp.PropertyUid, Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)CS_0024_003C_003E8__locals0.inp.PropertyParents));
			break;
		case 1:
		case 2:
			value = () => ExecuteMethod(CS_0024_003C_003E8__locals0.renderOwner, CS_0024_003C_003E8__locals0.inp.MethodName, CS_0024_003C_003E8__locals0.stack);
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		ConvertHelper.RedefineProp(context, expression, value);
	}

	private void DefineSetterCallback(IViewModel renderOwner, IContext context, Guid typeUid, PropertyInfoExpression expression, ComputedValue inp, IDataStack stack)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass24_0();
		CS_0024_003C_003E8__locals0.renderOwner = renderOwner;
		CS_0024_003C_003E8__locals0.inp = inp;
		CS_0024_003C_003E8__locals0.stack = stack;
		if (CS_0024_003C_003E8__locals0.inp is ActionInputComputedValue actionInputComputedValue)
		{
			IActionExecutionContext actionExecutionContext = new EmptyActionExecutionContext();
			if (!string.IsNullOrWhiteSpace(actionInputComputedValue.MethodName))
			{
				actionExecutionContext = new ClientFunctionExecutionContext(actionInputComputedValue.MethodName, null, null);
			}
			else
			{
				ValueTuple<bool, ActionValue> val = ActionComputedValueHelper.IsAction(actionInputComputedValue);
				bool item = val.Item1;
				ActionValue item2 = val.Item2;
				if (item)
				{
					actionExecutionContext = new ClientFunctionExecutionContext(item2.MethodName, null, null);
				}
			}
			object obj = CreateClosureForAction(actionInputComputedValue, actionExecutionContext);
			if (obj != null)
			{
				ConvertHelper.DefinePropSetterCallback(context, expression, obj);
			}
		}
		else if (CS_0024_003C_003E8__locals0.inp.ComputedValueType == 1 && CS_0024_003C_003E8__locals0.inp is InputComputedValue)
		{
			Func<object> value = () => ExecuteMethod(CS_0024_003C_003E8__locals0.renderOwner, CS_0024_003C_003E8__locals0.inp.MethodName, CS_0024_003C_003E8__locals0.stack);
			ConvertHelper.DefinePropSetterCallback(context, expression, value);
		}
	}

	private void DefineSetterProperty(IViewModel renderOwner, IContext context, Guid typeUid, PropertyInfoExpression expression, ComputedValue inp, IDataStack stack)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (renderOwner is IMetadataViewModel viewModel)
		{
			ValueTuple<object, PropertyInfoExpression> propertyContext = viewModel.GetPropertyContext(metadataServiceContext, inp.PropertyUid, Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)inp.PropertyParents));
			object item = propertyContext.Item1;
			PropertyInfoExpression item2 = propertyContext.Item2;
			ConvertHelper.DefinePropSetters(context, expression, item, item2);
		}
	}

	private object CreateClosureForAction(ActionInputComputedValue actionInputComputedValue, IActionExecutionContext actionExecutionContext)
	{
		System.Type type = convertService.ToType(actionInputComputedValue.ReturnType);
		System.Type type2 = convertService.ToType(actionInputComputedValue.ParameterType);
		if (type2 == null)
		{
			return ClosureHelper.CreateForActionWithParam((IAction)Activator.CreateInstance((type == null) ? typeof(DefaultAction) : typeof(ActionWithResult<>).MakeGenericType(new System.Type[1] { type }), new object[2] { actionExecutionContext, actionExecutionFacade }));
		}
		return ClosureHelper.CreateForActionWithParam((IAction)Activator.CreateInstance((type == null) ? typeof(ActionWithParam<>).MakeGenericType(new System.Type[1] { type2 }) : typeof(ActionWithParamResult<, >).MakeGenericType(new System.Type[2] { type2, type }), new object[2] { actionExecutionContext, actionExecutionFacade }));
	}

	private static object ExecuteMethod(IViewModel renderOwner, string methodName, IDataStack stack)
	{
		GlobalScopeHelper.Push(renderOwner);
		try
		{
			if (renderOwner is IFormViewModel formViewModel)
			{
				return ViewModelHelper.CallControllerMethod(formViewModel.Controllers, methodName, stack);
			}
			return ViewModelHelper.CallControllerMethod(renderOwner.Controller, methodName, stack);
		}
		finally
		{
			GlobalScopeHelper.Pop(renderOwner);
		}
	}

	private object GetActionForProperty(PropertyMetadata property, IContextCreationParameters parameters)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass28_0();
		CS_0024_003C_003E8__locals0.parameters = parameters;
		TypeSettings settings = ((IPropertyMetadata)property).get_Settings();
		ActionSettings val = (ActionSettings)(object)((settings is ActionSettings) ? settings : null);
		if (val == null)
		{
			return null;
		}
		Func<IController> controllerFunc = () => CS_0024_003C_003E8__locals0.parameters.ViewModel.Controller;
		if ((CS_0024_003C_003E8__locals0.formViewModel = CS_0024_003C_003E8__locals0.parameters.ViewModel as IFormViewModel) != null)
		{
			_003C_003Ec__DisplayClass28_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass28_1();
			CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals1.methodName = ScriptMethodInfoHelper.Deserialize(val.get_DefaultValue().get_MethodName())?.Name;
			if (!string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals1.methodName))
			{
				controllerFunc = () => Enumerable.FirstOrDefault<KeyValuePair<Guid, IController>>((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, IController>>)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.formViewModel.Controllers, (Func<KeyValuePair<Guid, IController>, bool>)((KeyValuePair<Guid, IController> c) => ((object)c.get_Value()).get_Item(CS_0024_003C_003E8__locals1.methodName) != null)).get_Value();
			}
		}
		ActionValue actionValue = null;
		ActionValue defaultValue = val.get_DefaultValue();
		if (defaultValue != null)
		{
			actionValue = new ActionValue
			{
				CodeType = defaultValue.get_CodeType(),
				MethodName = defaultValue.get_MethodName(),
				FunctionHeaderUid = defaultValue.get_FunctionHeaderUid()
			};
		}
		IActionExecutionContext actionExecutionContext = GetActionExecutionContext(property, actionValue, val, CS_0024_003C_003E8__locals0.parameters.MetadataUid, CS_0024_003C_003E8__locals0.parameters.MetadataTypeUid, CS_0024_003C_003E8__locals0.parameters.MetadataModuleUid, CS_0024_003C_003E8__locals0.parameters.OuterStack, controllerFunc);
		TypeSignature returnTypeSignature = DynamicPropertyHelper.TypeSignatureMapToObject(val.get_ReturnType());
		TypeSignature parameterTypeSignature = DynamicPropertyHelper.TypeSignatureMapToObject(val.get_ParameterType());
		return CreateClosureForAction(returnTypeSignature, parameterTypeSignature, actionExecutionContext);
	}

	private IActionExecutionContext GetActionExecutionContext(PropertyMetadata propertyMetadata, ActionValue actionValue, ActionSettings settings, Guid metadataUid, Guid metadataTypeUid, Guid metadataModuleUid, IDataStack outerStack, Func<IController> controllerFunc)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		if (actionValue == null)
		{
			return new EmptyActionExecutionContext(propertyMetadata, controllerFunc);
		}
		switch (actionValue.CodeType)
		{
		case 0:
			if (!string.IsNullOrWhiteSpace(actionValue.MethodName))
			{
				return new ClientFunctionExecutionContext(actionValue.MethodName, controllerFunc, outerStack);
			}
			break;
		case 1:
			if (!string.IsNullOrWhiteSpace(actionValue.MethodName) && !(metadataUid == Guid.Empty) && !(metadataTypeUid == Guid.Empty))
			{
				TypeSignature returnType3 = settings.get_ReturnType();
				Signature returnType4 = new Signature
				{
					Nullable = returnType3.get_Nullable(),
					RelationType = returnType3.get_RelationType(),
					TypeUid = returnType3.get_TypeUid(),
					SubTypeUid = returnType3.get_SubTypeUid()
				};
				TypeSignature parameterType3 = settings.get_ParameterType();
				Signature parameterType4 = new Signature
				{
					Nullable = parameterType3.get_Nullable(),
					RelationType = parameterType3.get_RelationType(),
					TypeUid = parameterType3.get_TypeUid(),
					SubTypeUid = parameterType3.get_SubTypeUid()
				};
				return new ServerFunctionExecutionContext(actionValue.MethodName, metadataTypeUid, metadataUid, returnType4, parameterType4);
			}
			break;
		case 3:
			if (!(metadataUid == Guid.Empty))
			{
				Guid functionHeaderUid = actionValue.FunctionHeaderUid;
				Guid functionItemUid = currentPageService.GetFunctionItemUid(metadataUid, functionHeaderUid);
				if (functionItemUid == Guid.Empty)
				{
					functionItemUid = currentPageService.GetFunctionItemUid(metadataModuleUid, functionHeaderUid);
				}
				TypeSignature returnType = settings.get_ReturnType();
				Signature returnType2 = new Signature
				{
					Nullable = returnType.get_Nullable(),
					RelationType = returnType.get_RelationType(),
					TypeUid = returnType.get_TypeUid(),
					SubTypeUid = returnType.get_SubTypeUid()
				};
				TypeSignature parameterType = settings.get_ParameterType();
				Signature parameterType2 = new Signature
				{
					Nullable = parameterType.get_Nullable(),
					RelationType = parameterType.get_RelationType(),
					TypeUid = parameterType.get_TypeUid(),
					SubTypeUid = parameterType.get_SubTypeUid()
				};
				return new GlobalFunctionExecutionContext(functionItemUid, returnType2, parameterType2);
			}
			break;
		}
		return new EmptyActionExecutionContext();
	}

	private object CreateClosureForAction(TypeSignature returnTypeSignature, TypeSignature parameterTypeSignature, IActionExecutionContext actionExecutionContext)
	{
		System.Type type = convertService.ToType(returnTypeSignature);
		System.Type type2 = convertService.ToType(parameterTypeSignature);
		if (type2 == null)
		{
			return ClosureHelper.CreateForActionWithParam((IAction)Activator.CreateInstance((type == null) ? typeof(DefaultAction) : typeof(ActionWithResult<>).MakeGenericType(new System.Type[1] { type }), new object[2] { actionExecutionContext, actionExecutionFacade }));
		}
		return ClosureHelper.CreateForActionWithParam((IAction)Activator.CreateInstance((type == null) ? typeof(ActionWithParam<>).MakeGenericType(new System.Type[1] { type2 }) : typeof(ActionWithParamResult<, >).MakeGenericType(new System.Type[2] { type2, type }), new object[2] { actionExecutionContext, actionExecutionFacade }));
	}

	static AbstractViewModelContextHandler()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		ParameterExpression val = Expression.Parameter(typeof(ViewItem), "q");
		TestPropertyName = DynamicPropertyHelper<ViewItem>.GetExpression<string>(Expression.Lambda<Func<ViewItem, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		entitySettingsComputedEqlPropertyMetadataUid = new Guid("78522a13-1039-6bc2-309f-0af0ac917810");
	}
}
