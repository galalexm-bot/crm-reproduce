using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Packaging;
using Microsoft.Build.Evaluation;

namespace EleWise.ELMA.BuildTools.MSBuild;

internal class ParsedProjectItem : IParsedProjectItem
{
	private static readonly Type EnumItemType = typeof(ParsedProjectItemType);

	private readonly ProjectItem item;

	private readonly IParsedProject project;

	public ProjectItem ProjectItem => item;

	public IParsedProject Project => project;

	public string UnevaluatedInclude => item.get_UnevaluatedInclude();

	public string EvaluatedInclude => item.get_EvaluatedInclude();

	public string ItemTypeId => item.get_ItemType();

	public ParsedProjectItemType ItemType
	{
		get
		{
			if (Enum.IsDefined(EnumItemType, ItemTypeId))
			{
				return (ParsedProjectItemType)Enum.Parse(EnumItemType, ItemTypeId);
			}
			return ParsedProjectItemType.Unknown;
		}
	}

	public IEnumerable<IProjectMetadata> Metadata => from m in item.get_Metadata()
		select new ProjectMetadata(m);

	public ParsedProjectItem(ProjectItem item, IParsedProject project)
	{
		this.item = item;
		this.project = project;
	}
}
