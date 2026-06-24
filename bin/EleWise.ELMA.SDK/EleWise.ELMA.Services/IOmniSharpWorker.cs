using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.Services;

public interface IOmniSharpWorker
{
	string CompletionLibsPath { get; }

	string ClientCompletionLibsPath { get; }

	void Start(bool needRestart);

	void Stop();

	Task<string> GetResult(string command, string postData, string fileName);

	Task InitWorkspace(string fileName, string projectPath);

	Task AddReferences(IEnumerable<string> assembliesPath, IEnumerable<string> webReferencesPath, string projectPath, string fileName);

	Task RemoveReferences(IEnumerable<string> assembliesPath, IEnumerable<string> webReferencesPath, string projectPath, string fileName);
}
