using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.BuildTools.MSBuild.Utils;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.Logging;
using Microsoft.Build.Construction;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Framework;

namespace EleWise.ELMA.BuildTools.MSBuild;

internal class ParsedProject : IParsedProject
{
	private readonly Project project;

	private readonly ProjectInSolution solutionProject;

	public Guid Uid { get; }

	public string ProjectFileName
	{
		get
		{
			ProjectInSolution obj = solutionProject;
			object obj2 = ((obj != null) ? obj.get_AbsolutePath() : null);
			if (obj2 == null)
			{
				Project obj3 = project;
				obj2 = ((obj3 != null) ? obj3.get_FullPath() : null);
			}
			return (string)obj2;
		}
	}

	public string AssemblyName { get; }

	public string DirectoryPath => project.get_DirectoryPath();

	public IEnumerable<IParsedProjectItem> Items => (from i in project.get_Items()
		select new ParsedProjectItem(i, this)).ToArray();

	public IDictionary<string, IProjectConfiguration> Configs { get; }

	public ParsedProject(ProjectInSolution prj)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		solutionProject = prj;
		string projectFileName = prj.get_AbsolutePath();
		project = (Project)(((object)ProjectCollection.get_GlobalProjectCollection().get_LoadedProjects().FirstOrDefault((Project l) => l.get_FullPath() == projectFileName)) ?? ((object)new Project(projectFileName)));
		ProjectProperty property = project.GetProperty("AssemblyName");
		AssemblyName = ((property != null) ? property.get_EvaluatedValue() : null) ?? Path.GetFileNameWithoutExtension(projectFileName);
		Uid = (Guid.TryParse(prj.get_ProjectGuid(), out var result) ? result : Guid.NewGuid());
		Configs = solutionProject.get_ProjectConfigurations().ToDictionary((KeyValuePair<string, ProjectConfigurationInSolution> v) => v.Key, (KeyValuePair<string, ProjectConfigurationInSolution> v) => CreateConfigInfo(v.Value));
	}

	public ParsedProject(Project prj)
	{
		string fullPath = prj.get_FullPath();
		project = prj;
		ProjectProperty property = project.GetProperty("AssemblyName");
		AssemblyName = ((property != null) ? property.get_EvaluatedValue() : null) ?? Path.GetFileNameWithoutExtension(fullPath);
		Uid = Guid.NewGuid();
	}

	private IProjectConfiguration CreateConfigInfo(ProjectConfigurationInSolution config)
	{
		return new ProjectConfiguration
		{
			FullName = config.get_FullName(),
			ConfigurationName = config.get_ConfigurationName(),
			PlatformName = config.get_PlatformName(),
			IncludeInBuild = config.get_IncludeInBuild()
		};
	}

	public string GetPropertyValue(string propertyName)
	{
		return project.GetPropertyValue(propertyName);
	}

	public void SetGlobalProperty(string propertyName, string value)
	{
		project.SetGlobalProperty(propertyName, value);
	}

	public void ReevaluateIfNecessary()
	{
		project.ReevaluateIfNecessary();
	}

	public void AddItem(ParsedProjectItemType type, string include, IDictionary<string, string> metadata = null)
	{
		string text = type.ToString();
		project.AddItem(text, include, (IEnumerable<KeyValuePair<string, string>>)metadata);
	}

	public void RemoveItem(IParsedProjectItem item)
	{
		if (item is ParsedProjectItem parsedProjectItem)
		{
			project.RemoveItem(parsedProjectItem.ProjectItem);
		}
	}

	public void SetProperty(string name, string value)
	{
		project.SetProperty(name, value);
	}

	public void Save(string path = null)
	{
		if (string.IsNullOrWhiteSpace(path))
		{
			project.Save();
		}
		else
		{
			project.Save(path);
		}
	}

	public string[] Build()
	{
		SimpleBuildProjectLogger simpleBuildProjectLogger = new SimpleBuildProjectLogger();
		if (!project.Build((ILogger)(object)simpleBuildProjectLogger))
		{
			IEnumerable<string> messages = simpleBuildProjectLogger.GetMessages(LogLevel.Error);
			return messages.ToArray();
		}
		return Array.Empty<string>();
	}
}
