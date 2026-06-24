using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Extensions;

[ExtensionPoint(ComponentType.All)]
public interface IDocumentationChapter
{
	DocumentationChapters Chapter { get; }

	string ChapterName { get; }

	string ChapterShortName { get; }

	void GenerateDocumentation(IWorkflowProcess process, bool subFolders, StringBuilder sb, StringBuilder contentSb);
}
