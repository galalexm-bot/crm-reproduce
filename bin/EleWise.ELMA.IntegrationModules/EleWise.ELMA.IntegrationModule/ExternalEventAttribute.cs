using System;

namespace EleWise.ELMA.IntegrationModules.Metadata;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class ExternalEventAttribute : Attribute
{
	private Guid uid;

	private string name;

	private string scriptName;

	public Guid Uid => uid;

	public string Name => name;

	public string ScriptName => scriptName;

	public ExternalEventAttribute(string uid, string name, string scriptName)
	{
		this.uid = new Guid(uid);
		this.name = name;
		this.scriptName = scriptName;
	}
}
