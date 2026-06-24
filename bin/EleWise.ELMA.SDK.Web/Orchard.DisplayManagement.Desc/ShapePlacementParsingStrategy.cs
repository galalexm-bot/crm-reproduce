using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;
using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;

namespace Orchard.DisplayManagement.Descriptors.ShapePlacementStrategy;

public class ShapePlacementParsingStrategy : IShapeTableProvider, IDependency
{
	private readonly IExtensionManager _extensionManager;

	private readonly ShellDescriptor _shellDescriptor;

	private readonly IPlacementFileParser _placementFileParser;

	public ShapePlacementParsingStrategy(IExtensionManager extensionManager, ShellDescriptor shellDescriptor, IPlacementFileParser placementFileParser)
	{
		_extensionManager = extensionManager;
		_shellDescriptor = shellDescriptor;
		_placementFileParser = placementFileParser;
	}

	public void Discover(ShapeTableBuilder builder)
	{
		foreach (ExtensionDescriptor item in Once(from fd in _extensionManager.AvailableFeatures()
			where FeatureIsTheme(fd) || FeatureIsEnabled(fd)
			select fd))
		{
			foreach (FeatureDescriptor item2 in item.Features.Where((FeatureDescriptor fd) => fd.Id == fd.Extension.Id))
			{
				ProcessFeatureDescriptor(builder, item2);
			}
		}
	}

	private void ProcessFeatureDescriptor(ShapeTableBuilder builder, FeatureDescriptor featureDescriptor)
	{
		string virtualPath = featureDescriptor.Extension.Location + "/" + featureDescriptor.Extension.Id + "/Placement.info";
		PlacementFile placementFile = _placementFileParser.Parse(virtualPath);
		if (placementFile != null)
		{
			ProcessPlacementFile(builder, featureDescriptor, placementFile);
		}
	}

	private void ProcessPlacementFile(ShapeTableBuilder builder, FeatureDescriptor featureDescriptor, PlacementFile placementFile)
	{
		Feature feature = new Feature
		{
			Descriptor = featureDescriptor
		};
		foreach (Tuple<PlacementShapeLocation, IEnumerable<PlacementMatch>> item3 in DrillDownShapeLocations(placementFile.Nodes, Enumerable.Empty<PlacementMatch>()))
		{
			PlacementShapeLocation item = item3.Item1;
			IEnumerable<PlacementMatch> item2 = item3.Item2;
			GetShapeType(item, out var shapeType, out var differentiator);
			Func<ShapePlacementContext, bool> predicate = (ShapePlacementContext ctx) => true;
			if (differentiator != "")
			{
				predicate = (ShapePlacementContext ctx) => (ctx.Differentiator ?? "") == differentiator;
			}
			if (item2.Any())
			{
				predicate = item2.SelectMany((PlacementMatch match) => match.Terms).Aggregate(predicate, BuildPredicate);
			}
			PlacementInfo placementInfo = new PlacementInfo();
			foreach (string item4 in from s in item.Location.Split(';')
				select s.Trim())
			{
				if (!item4.Contains('='))
				{
					placementInfo.Location = item4;
					continue;
				}
				int num = item4.IndexOf('=');
				string text = item4.Substring(0, num).ToLower();
				string text2 = item4.Substring(num + 1);
				switch (text)
				{
				case "shape":
					placementInfo.ShapeType = text2;
					break;
				case "alternate":
					placementInfo.Alternates = new string[1] { text2 };
					break;
				case "wrapper":
					placementInfo.Wrappers = new string[1] { text2 };
					break;
				}
			}
			builder.Describe(shapeType).From(feature).Placement(delegate(ShapePlacementContext ctx)
			{
				bool num2 = predicate(ctx);
				if (num2)
				{
					string text4 = (ctx.Source = featureDescriptor.Extension.Location + "/" + featureDescriptor.Extension.Id + "/Placement.info");
				}
				return num2;
			}, placementInfo);
		}
	}

	private void GetShapeType(PlacementShapeLocation shapeLocation, out string shapeType, out string differentiator)
	{
		differentiator = "";
		shapeType = shapeLocation.ShapeType;
		int num = 2;
		int num2 = shapeType.LastIndexOf("__");
		int num3 = shapeType.LastIndexOf('-');
		if (num3 > num2)
		{
			num2 = num3;
			num = 1;
		}
		if (num2 > 0 && num2 < shapeType.Length - num)
		{
			differentiator = shapeType.Substring(num2 + num);
			shapeType = shapeType.Substring(0, num2);
		}
	}

	public static Func<ShapePlacementContext, bool> BuildPredicate(Func<ShapePlacementContext, bool> predicate, KeyValuePair<string, string> term)
	{
		string expression = term.Value;
		switch (term.Key)
		{
		case "ContentPart":
			return (ShapePlacementContext ctx) => ctx.Content != null && ctx.Content.ContentItem.Parts.Any((ContentPart part) => part.PartDefinition.Name == expression) && predicate(ctx);
		case "ContentType":
			if (expression.EndsWith("*"))
			{
				string prefix = expression.Substring(0, expression.Length - 1);
				return (ShapePlacementContext ctx) => ((ctx.ContentType ?? "").StartsWith(prefix) || (ctx.Stereotype ?? "").StartsWith(prefix)) && predicate(ctx);
			}
			return (ShapePlacementContext ctx) => (ctx.ContentType == expression || ctx.Stereotype == expression) && predicate(ctx);
		case "DisplayType":
			if (expression.EndsWith("*"))
			{
				string prefix2 = expression.Substring(0, expression.Length - 1);
				return (ShapePlacementContext ctx) => (ctx.DisplayType ?? "").StartsWith(prefix2) && predicate(ctx);
			}
			return (ShapePlacementContext ctx) => ctx.DisplayType == expression && predicate(ctx);
		case "Path":
		{
			string normalizedPath = (VirtualPathUtility.IsAbsolute(expression) ? VirtualPathUtility.ToAppRelative(expression) : VirtualPathUtility.Combine("~/", expression));
			if (normalizedPath.EndsWith("*"))
			{
				string prefix3 = normalizedPath.Substring(0, normalizedPath.Length - 1);
				return (ShapePlacementContext ctx) => VirtualPathUtility.ToAppRelative(string.IsNullOrEmpty(ctx.Path) ? "/" : ctx.Path).StartsWith(prefix3, StringComparison.OrdinalIgnoreCase) && predicate(ctx);
			}
			normalizedPath = VirtualPathUtility.AppendTrailingSlash(normalizedPath);
			return (ShapePlacementContext ctx) => ctx.Path.Equals(normalizedPath, StringComparison.OrdinalIgnoreCase) && predicate(ctx);
		}
		default:
			return predicate;
		}
	}

	private static IEnumerable<Tuple<PlacementShapeLocation, IEnumerable<PlacementMatch>>> DrillDownShapeLocations(IEnumerable<PlacementNode> nodes, IEnumerable<PlacementMatch> path)
	{
		foreach (PlacementShapeLocation item in nodes.OfType<PlacementShapeLocation>())
		{
			yield return new Tuple<PlacementShapeLocation, IEnumerable<PlacementMatch>>(item, path);
		}
		foreach (PlacementMatch item2 in nodes.OfType<PlacementMatch>())
		{
			foreach (Tuple<PlacementShapeLocation, IEnumerable<PlacementMatch>> item3 in DrillDownShapeLocations(item2.Nodes, path.Concat(new PlacementMatch[1] { item2 })))
			{
				yield return item3;
			}
		}
	}

	private bool FeatureIsTheme(FeatureDescriptor fd)
	{
		return DefaultExtensionTypes.IsTheme(fd.Extension.ExtensionType);
	}

	private bool FeatureIsEnabled(FeatureDescriptor fd)
	{
		return _shellDescriptor.Features.Any((ShellFeature sf) => sf.Name == fd.Id);
	}

	private static IEnumerable<ExtensionDescriptor> Once(IEnumerable<FeatureDescriptor> featureDescriptors)
	{
		ConcurrentDictionary<string, object> once = new ConcurrentDictionary<string, object>();
		return (from fd in featureDescriptors
			select fd.Extension into ed
			where once.TryAdd(ed.Id, null)
			select ed).ToList();
	}
}
