using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Grids;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Workflow.Helpers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Web.Extensions;

namespace EleWise.ELMA.Workflow.Web.Integration.Tasks;

[Component(Order = 10)]
public abstract class TasksGridExtensionBase : IDynamicGridExtension
{
	private class InstanceTemplateBuilder
	{
		private readonly DynamicGridBuilder<ITaskBase> builder;

		private readonly bool instanceLinkAvailable;

		private bool resolved;

		private List<long> accessibleInstanceIds = new List<long>();

		public InstanceTemplateBuilder(DynamicGridBuilder<ITaskBase> builder)
		{
			this.builder = builder;
			List<IEntityLink> source = ComponentManager.Current.GetExtensionPoints<IEntityLink>().ToList();
			instanceLinkAvailable = source.Any((IEntityLink e) => e.EntityType == typeof(IWorkflowInstance) || e.TypeUid == InterfaceActivator.UID<IWorkflowInstance>());
		}

		public object Render(ITaskBase task)
		{
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			if (instanceLinkAvailable && !resolved)
			{
				resolved = true;
				List<long> source = (from i in (from t in builder.Grid.GridData.DataSource.OfType<IWorkflowTaskBase>()
						where t.WorkflowBookmark != null
						select t.WorkflowBookmark.Instance into i
						where i != null
						select i).Distinct()
					select i.Id).ToList();
				if (source.Any())
				{
					accessibleInstanceIds = source;
				}
			}
			if (!(task is IWorkflowTaskBase workflowTaskBase) || workflowTaskBase.WorkflowBookmark == null || workflowTaskBase.WorkflowBookmark.Instance == null)
			{
				return null;
			}
			if (instanceLinkAvailable && accessibleInstanceIds.Contains(workflowTaskBase.WorkflowBookmark.Instance.Id))
			{
				TagBuilder val = new TagBuilder("a");
				string text = builder.Html.Url().Entity(InterfaceActivator.UID<IWorkflowInstance>(), workflowTaskBase.WorkflowBookmark.Instance.Id.ToString(CultureInfo.InvariantCulture));
				val.MergeAttribute("href", text);
				val.SetInnerText(SR.T(workflowTaskBase.WorkflowBookmark.Instance.InstanceName()));
				return val.ToString((TagRenderMode)0);
			}
			return builder.Html.Encode(SR.T(workflowTaskBase.WorkflowBookmark.Instance.InstanceName()));
		}
	}

	private static readonly string SubjectUid = InterfaceActivator.PropertyUid((ITaskBase t) => t.Subject).ToString();

	public abstract bool MatchUniqueName(string uniqueName);

	protected virtual bool CheckState(DynamicGridBuilder<ITaskBase> tasksGridBuilder, string uniqueName)
	{
		if (tasksGridBuilder.State != null && tasksGridBuilder.State.ColumnStates != null)
		{
			return tasksGridBuilder.State.ColumnStates.Any((ColumnState c) => c.UniqueName == uniqueName);
		}
		return false;
	}

	protected virtual bool SaveCustomColumnToState(GridState state, ColumnState columnState)
	{
		return true;
	}

	public void Apply<T>(DynamicGridBuilder<T> builder) where T : class
	{
		bool isTableView = StateExtensions.LoadState<bool?>("UserTaskTableView" + builder.Grid.UniqueName).GetValueOrDefault();
		DynamicGridBuilder<ITaskBase> tasksGridBuilder = builder as DynamicGridBuilder<ITaskBase>;
		InstanceTemplateBuilder instanceTemplateBuilder = new InstanceTemplateBuilder(tasksGridBuilder);
		if (tasksGridBuilder == null)
		{
			return;
		}
		tasksGridBuilder.FetchColumn<IWorkflowTaskBase>((IWorkflowTaskBase m) => m.WorkflowBookmark, (IWorkflowTaskBase m) => m.WorkflowBookmark.Instance, (IWorkflowTaskBase m) => m.WorkflowBookmark.Instance.Process.Header);
		ColumnState instanceColumnState = (CheckState(tasksGridBuilder, CustomWorkflowTaskBaseColumns.InstanceName.UniqueName) ? tasksGridBuilder.State.ColumnStates[CustomWorkflowTaskBaseColumns.InstanceName.UniqueName] : null);
		ColumnState processColumnState = (CheckState(tasksGridBuilder, CustomWorkflowTaskBaseColumns.ProcessName.UniqueName) ? tasksGridBuilder.State.ColumnStates[CustomWorkflowTaskBaseColumns.ProcessName.UniqueName] : null);
		tasksGridBuilder.Columns(delegate(DynamicColumnsBuilder<ITaskBase> c)
		{
			DynamicColumnBuilder<ITaskBase, string> dynamicColumnBuilder;
			DynamicColumnBuilder<ITaskBase, string> dynamicColumnBuilder2;
			if (instanceColumnState != null && processColumnState != null)
			{
				int num = tasksGridBuilder.State.ColumnsOrder.FirstOrDefault((Tuple<string, int> m) => m.Item1 == CustomWorkflowTaskBaseColumns.InstanceName.UniqueName)?.Item2 ?? (-1);
				int num2 = tasksGridBuilder.State.ColumnsOrder.FirstOrDefault((Tuple<string, int> m) => m.Item1 == CustomWorkflowTaskBaseColumns.ProcessName.UniqueName)?.Item2 ?? (-1);
				dynamicColumnBuilder = c.For((ITaskBase m) => "").Visible(num >= 0).Order(num);
				dynamicColumnBuilder2 = c.For((ITaskBase m) => "").Visible(num2 >= 0).Order(num2);
			}
			else
			{
				GridColumn column = c.GetColumn((ITaskBase m) => m.Subject);
				dynamicColumnBuilder = c.InsertAfter(column, (ITaskBase m) => "", displayOnlyWithExistingColumn: true);
				dynamicColumnBuilder2 = c.InsertAfter(dynamicColumnBuilder, (ITaskBase m) => "", displayOnlyWithExistingColumn: true);
			}
			bool instanceState = instanceColumnState == null || !instanceColumnState.Hidden;
			bool processState = processColumnState == null || !processColumnState.Hidden;
			dynamicColumnBuilder.Header(CustomWorkflowTaskBaseColumns.InstanceName.DisplayName).Uid(CustomWorkflowTaskBaseColumns.InstanceName.UniqueName).Template(delegate(ITaskBase m)
			{
				bool flag2 = true;
				if (isTableView)
				{
					flag2 = instanceState && CalcVisibility(m);
				}
				return (!flag2) ? string.Empty : instanceTemplateBuilder.Render(m);
			})
				.Sortable(sortable: false)
				.ToState(SaveCustomColumnToState(tasksGridBuilder.State, instanceColumnState));
			dynamicColumnBuilder2.Header(CustomWorkflowTaskBaseColumns.ProcessName.DisplayName).Uid(CustomWorkflowTaskBaseColumns.ProcessName.UniqueName).Template(delegate(ITaskBase m)
			{
				bool flag = true;
				if (isTableView)
				{
					flag = processState && CalcVisibility(m);
				}
				return (flag && ((IWorkflowTaskBase)m).WorkflowBookmark != null) ? HttpUtility.HtmlEncode(SR.T(((IWorkflowTaskBase)m).WorkflowBookmark.Instance.Process.Header.Name)) : string.Empty;
			})
				.Sortable(sortable: false)
				.ToState(SaveCustomColumnToState(tasksGridBuilder.State, processColumnState));
			Grid grid = tasksGridBuilder.Grid;
			dynamicColumnBuilder.CellVisible((ITaskBase t) => !grid.UseCardGridTemplate || CalcVisibility(t));
			dynamicColumnBuilder2.CellVisible((ITaskBase t) => !grid.UseCardGridTemplate || CalcVisibility(t));
		});
	}

	protected bool CalcVisibility(ITaskBase m)
	{
		IEnumerable<IProcessColumnsVisibleHandler> extensionPoints = ComponentManager.Current.GetExtensionPoints<IProcessColumnsVisibleHandler>();
		ITaskBase t = m.CastAsRealType();
		bool flag = ((IWorkflowTaskBase)m).WorkflowBookmark != null;
		IMetadata metadata = MetadataLoader.LoadMetadata(t.GetType());
		return extensionPoints.FirstOrDefault((IProcessColumnsVisibleHandler h) => (h.TypeUid != Guid.Empty && h.TypeUid == metadata.Uid) || (h.EntityType != null && h.EntityType.IsInstanceOfType(t)))?.IsVisible(t) ?? flag;
	}
}
