using System.Windows.Forms;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.ProcessMetricExtensions;

[ExtensionPoint(ComponentType.All)]
public interface IProcessMetricColumn
{
	int ColumnIndex { get; set; }

	DataGridViewTextBoxColumn Column { get; }

	object GetColumnValue(ProcessMetric metric);
}
