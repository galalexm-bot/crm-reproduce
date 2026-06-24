using System;
using System.Text;
using System.Text.RegularExpressions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;

namespace EleWise.ELMA.UIBuilder.Db;

internal sealed class ComponentUpdateDbStructure : DbStructureExtension
{
	private static readonly Regex regex = new Regex("(?<=\\[\")(?<typeRef>\\w+)\\$(?<propertyName>\\w+)(?=\"\\])");

	public override Guid ProviderUid => Guid.Empty;

	internal void UpdateComponents()
	{
		IDataClassMetadataTypeReferenceService serviceNotNull = Locator.GetServiceNotNull<IDataClassMetadataTypeReferenceService>();
		foreach (ItemWithScriptModuleWrapper itemsWithClientScriptModule in ComponentMetadataItemManager.Instance.GetItemsWithClientScriptModules())
		{
			ScriptModule scriptModule = itemsWithClientScriptModule.ScriptModule;
			if (scriptModule != null)
			{
				byte[] assemblyRaw = scriptModule.AssemblyRaw;
				if (assemblyRaw != null)
				{
					byte[] array2 = (scriptModule.AssemblyRaw = ProcessScriptModuleRaw(serviceNotNull, assemblyRaw));
				}
				byte[] debugRaw = scriptModule.DebugRaw;
				if (debugRaw != null)
				{
					byte[] array4 = (scriptModule.DebugRaw = ProcessScriptModuleRaw(serviceNotNull, debugRaw));
				}
				scriptModule.Save();
			}
		}
	}

	private static byte[] ProcessScriptModuleRaw(IDataClassMetadataTypeReferenceService typeReferenceService, byte[] raw)
	{
		string @string = Encoding.UTF8.GetString(raw);
		string s = regex.Replace(@string, delegate(Match match)
		{
			GroupCollection groups = match.Groups;
			string value = groups["propertyName"].Value;
			string value2 = groups["typeRef"].Value;
			Guid? metadataUid = typeReferenceService.GetMetadataUid(value2);
			return metadataUid.HasValue ? $"{value}${metadataUid.Value:n}" : match.Value;
		});
		return Encoding.UTF8.GetBytes(s);
	}
}
