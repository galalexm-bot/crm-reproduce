using System;
using System.Reflection;

namespace EleWise.ELMA.Tasks.Components;

public class SubtaskDefaultFieldCheckAttribute : Attribute
{
	private Type actionContainer;

	private string methodName;

	public MethodInfo Method => actionContainer.GetMethod(methodName);

	public Type ActionContainer => actionContainer;

	public string MethodName => methodName;

	public SubtaskDefaultFieldCheckAttribute(Type actionContainer, string methodName)
	{
		this.actionContainer = actionContainer;
		this.methodName = methodName;
	}
}
