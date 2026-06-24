using System.Windows.Forms;
using DevComponents.DotNetBar;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Workflow.ProcessMetricExtensions;

[ExtensionPoint(ComponentType.All)]
public interface IProcessMetricContextMenu
{
	UserControl parentView { get; set; }

	ButtonItem menuItem { get; }

	void UpdateEnabledStatus();
}
