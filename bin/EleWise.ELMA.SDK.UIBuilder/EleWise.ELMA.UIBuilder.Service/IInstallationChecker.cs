using System;
using System.Threading.Tasks;
using EleWise.ELMA.UIBuilder.Model;

namespace EleWise.ELMA.UIBuilder.Services;

[Obsolete("Удалить когда появится другой способ индикации установки дизайнера")]
public interface IInstallationChecker
{
	Task<InstallationState> GetDesignerInstallationState();

	Task<InstallationState> GetDesignerTestState();
}
