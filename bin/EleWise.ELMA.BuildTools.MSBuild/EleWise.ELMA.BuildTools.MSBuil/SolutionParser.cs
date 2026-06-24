using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using EleWise.ELMA.Packaging;
using Microsoft.Build.Construction;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Framework;
using Microsoft.Build.Locator;

namespace EleWise.ELMA.BuildTools.MSBuild;

[Export(typeof(ISolutionParser))]
internal class SolutionParser : ISolutionParser
{
	private ProjectCollection projectCollection;

	public void Init(IBuildToolInstance instance = null, bool force = false)
	{
		if (instance == null)
		{
			MSBuildLocator.RegisterDefaults();
		}
		else
		{
			MSBuildLocator.RegisterMSBuildPath(instance.MSBuildPath);
		}
		if (force)
		{
			LoadMsBuildLibsNow();
		}
	}

	public IEnumerable<IBuildToolInstance> QueryBuildToolsInstances()
	{
		return from i in MSBuildLocator.QueryVisualStudioInstances()
			select new BuildToolInstance
			{
				Name = i.get_Name(),
				Version = i.get_Version(),
				MSBuildPath = i.get_MSBuildPath(),
				VisualStudioRootPath = i.get_VisualStudioRootPath()
			};
	}

	public IParsedSolution Parse(string solutionFileName)
	{
		SolutionFile solutionFile = SolutionFile.Parse(solutionFileName);
		return new ParsedSolution(solutionFile, solutionFileName);
	}

	public IParsedProject ParseProject(string csprojPath)
	{
		Project prj = GetProjectCollection().get_LoadedProjects().FirstOrDefault((Project p) => p.get_FullPath() == csprojPath) ?? projectCollection.LoadProject(csprojPath);
		return new ParsedProject(prj);
	}

	public IParsedProject ParseProject(XmlReader csprojXml)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		Project prj = new Project(csprojXml);
		return new ParsedProject(prj);
	}

	private ProjectCollection GetProjectCollection()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		object obj = ((object)projectCollection) ?? ((object)new ProjectCollection());
		ProjectCollection result = (ProjectCollection)obj;
		projectCollection = (ProjectCollection)obj;
		return result;
	}

	private void LoadMsBuildLibsNow()
	{
		Type[] _ = new Type[2]
		{
			typeof(ProjectElement),
			typeof(ILogger)
		};
		UnusedMethod(_);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	private void UnusedMethod(Type[] _)
	{
	}
}
