using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Scripts;

namespace EleWise.ELMA.UIBuilder.Models;

public class ScriptProject
{
	public class Reference
	{
		public string Name { get; set; }

		public bool IsHidden { get; set; }

		public string HintPath { get; set; }

		public byte[] AssemblyRaw { get; set; }

		public byte[] DocumentationRaw { get; set; }
	}

	public class ProjectReference
	{
		public string Name { get; set; }

		public string ProjectReferencePath { get; set; }
	}

	private readonly ScriptModule module;

	private string projectName;

	private readonly List<Reference> references = new List<Reference>();

	private readonly List<ScriptWebReference> webReferences = new List<ScriptWebReference>();

	private readonly List<ProjectReference> projectReferences = new List<ProjectReference>();

	public string ProjectName
	{
		get
		{
			if (string.IsNullOrEmpty(projectName))
			{
				return module.ModuleName;
			}
			return projectName;
		}
		set
		{
			projectName = value;
		}
	}

	public ScriptProject OwnerProject { get; set; }

	public ScriptModule Module => module;

	public bool ForDebug { get; set; }

	public List<Reference> References => references;

	public List<ProjectReference> ProjectReferences => projectReferences;

	public List<ScriptWebReference> WebReferences => webReferences;

	public ScriptProject(ScriptModule module)
	{
		this.module = module;
		if (module?.WebReferences != null)
		{
			webReferences.AddRange(module.WebReferences);
		}
		ParseReferences();
	}

	private void ParseReferences()
	{
		references.Clear();
		if (module != null)
		{
			IEnumerable<Reference> collection = from refName in ReferencesListHelper.GetReferences(module.References)
				select new Reference
				{
					Name = refName
				};
			IEnumerable<Reference> collection2 = from refName in ReferencesListHelper.GetElmaReferences(module.ElmaReferences)
				select new Reference
				{
					Name = refName
				};
			references.AddRange(collection);
			references.AddRange(collection2);
		}
	}
}
