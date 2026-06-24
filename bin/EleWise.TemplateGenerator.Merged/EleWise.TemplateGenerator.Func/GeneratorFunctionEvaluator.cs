using System;
using System.Collections.Generic;
using System.Reflection;

namespace EleWise.TemplateGenerator.Functions;

public class GeneratorFunctionEvaluator : IGeneratorFunctionEvaluator
{
	private GenerationContext context;

	private Dictionary<string, KeyValuePair<MethodInfo, object>> functionMethods = new Dictionary<string, KeyValuePair<MethodInfo, object>>();

	protected GenerationContext Context => context;

	public GeneratorFunctionEvaluator(GenerationContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		this.context = context;
		RegisterFunctions();
	}

	public virtual FormatedValue Evaluate(string name, List<FormatedValue> parameters)
	{
		if (!functionMethods.TryGetValue(name.ToUpper(), out var value))
		{
			string text = context.Localization.FunctionLocalizationStore.CheckName(name);
			if (text != null)
			{
				functionMethods.TryGetValue(text.ToUpper(), out value);
			}
		}
		if (value.Key != null)
		{
			FunctionEvaluationContext functionEvaluationContext = new FunctionEvaluationContext
			{
				GenerationContext = Context,
				DataSource = context.DataSource,
				Parameters = parameters
			};
			return (FormatedValue)value.Key.Invoke(value.Value, new object[1] { functionEvaluationContext });
		}
		return null;
	}

	protected virtual void RegisterFunctions()
	{
		RegisterFunctionsContainerType(typeof(DefaultFunctions));
	}

	protected void RegisterFunctionsContainerType(Type type)
	{
		MethodInfo[] methods = type.GetMethods(BindingFlags.Static | BindingFlags.Public);
		foreach (MethodInfo methodInfo in methods)
		{
			if (methodInfo.ReturnType == typeof(FormatedValue) && methodInfo.GetParameters().Length == 1 && methodInfo.GetParameters()[0].ParameterType == typeof(FunctionEvaluationContext))
			{
				RegisterFunction(methodInfo.Name, methodInfo);
			}
		}
	}

	protected void RegisterFunction(string name, MethodInfo method, object invoker = null)
	{
		functionMethods[name.ToUpper()] = new KeyValuePair<MethodInfo, object>(method, invoker);
	}
}
