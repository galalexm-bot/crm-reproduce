using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Packaging;
using Microsoft.Build.Construction;

namespace EleWise.ELMA.BuildTools.MSBuild;

internal class ParsedSolution : IParsedSolution
{
	private readonly SolutionFile solutionFile;

	private readonly string slnPath;

	public IEnumerable<IParsedProject> Projects => (from prj in solutionFile.get_ProjectsInOrder()
		where (int)prj.get_ProjectType() != 2
		select new ParsedProject(prj)).ToList();

	public string SlnPath => slnPath;

	public ParsedSolution(SolutionFile solutionFile, string slnPath)
	{
		this.solutionFile = solutionFile;
		this.slnPath = slnPath;
	}
}
