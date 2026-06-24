using System.Collections.Generic;

namespace Orchard.DisplayManagement.Descriptors.ShapeTemplateStrategy;

public class BasicShapeTemplateHarvester : IShapeTemplateHarvester, IDependency
{
	public IEnumerable<string> SubPaths()
	{
		return new string[5] { "Views", "Views/Items", "Views/Parts", "Views/Fields", "Views/Elements" };
	}

	public IEnumerable<HarvestShapeHit> HarvestShape(HarvestShapeInfo info)
	{
		int num = info.FileName.LastIndexOf('-');
		int num2 = info.FileName.LastIndexOf('.');
		if (num2 <= 0 || num2 < num)
		{
			yield return new HarvestShapeHit
			{
				ShapeType = Adjust(info.SubPath, info.FileName, null)
			};
			yield break;
		}
		string displayType = info.FileName.Substring(num2 + 1);
		yield return new HarvestShapeHit
		{
			ShapeType = Adjust(info.SubPath, info.FileName.Substring(0, num2), displayType),
			DisplayType = displayType
		};
	}

	private static string Adjust(string subPath, string fileName, string displayType)
	{
		string text = "";
		if (subPath.StartsWith("Views/") && subPath != "Views/Items")
		{
			text = subPath.Substring("Views/".Length) + "_";
		}
		string text2 = text + fileName.Replace("--", "__").Replace("-", "__").Replace('.', '_');
		if (string.IsNullOrEmpty(displayType))
		{
			return text2.ToLowerInvariant();
		}
		int num = text2.IndexOf("__");
		if (num <= 0)
		{
			return (text2 + "_" + displayType).ToLowerInvariant();
		}
		return (text2.Substring(0, num) + "_" + displayType + text2.Substring(num)).ToLowerInvariant();
	}
}
