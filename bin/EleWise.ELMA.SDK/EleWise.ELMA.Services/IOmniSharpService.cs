using System.Threading.Tasks;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.Services;

public interface IOmniSharpService
{
	void Start(bool needRestart);

	void Stop();

	Task<OmniSharpItem> InitWorkspace(InitWorkspaceRequest request);

	Task<string> GetResult(OmniSharpRequest request);

	Task AddReferences(AddReferencesRequest request);

	Task RemoveReferences(RemoveReferencesRequest request);
}
