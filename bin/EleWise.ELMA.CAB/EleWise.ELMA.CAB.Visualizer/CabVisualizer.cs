using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using EleWise.ELMA.CAB.BuilderStrategies;
using EleWise.ELMA.CAB.Commands;
using EleWise.ELMA.CAB.Configuration;
using EleWise.ELMA.CAB.Instrumentation;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Services;
using EleWise.ELMA.CAB.UIElements;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB.Visualizer;

public class CabVisualizer : IVisualizer, IDisposable
{
	private readonly List<object> visualizations = new List<object>();

	private Builder cabBuilder;

	private WorkItem cabRootWorkItem;

	private VisualizationElementCollection configuration;

	private WorkItem rootWorkItem;

	protected ICollection<object> Visualizations => visualizations.AsReadOnly();

	protected virtual VisualizationElementCollection Configuration
	{
		get
		{
			if (configuration == null)
			{
				configuration = LoadConfiguration();
			}
			return configuration;
		}
	}

	protected WorkItem RootWorkItem => rootWorkItem;

	public Builder CabBuilder => cabBuilder;

	public WorkItem CabRootWorkItem => cabRootWorkItem;

	public void Initialize(WorkItem cabRootWorkItem, Builder cabBuilder)
	{
		if (this.cabRootWorkItem != null)
		{
			throw new InvalidOperationException(Resources.VisualizerAlreadyInitialized);
		}
		this.cabRootWorkItem = cabRootWorkItem;
		this.cabBuilder = cabBuilder;
		Builder builder = CreateBuilder();
		AddBuilderStrategies(builder);
		CreateRootWorkItem(builder);
		AddRequiredServices();
		AddServices();
		rootWorkItem.BuildUp();
		CreateVisualizationShell();
		LoadVisualizerPlugins();
		rootWorkItem.Run();
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private VisualizationElementCollection LoadConfiguration()
	{
		object section = ConfigurationManager.GetSection("CompositeUI");
		SettingsSection settingsSection = section as SettingsSection;
		if (section != null && settingsSection == null)
		{
			throw new ConfigurationErrorsException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidConfigurationSectionType, new object[2]
			{
				"CompositeUI",
				typeof(SettingsSection)
			}));
		}
		if (settingsSection == null)
		{
			settingsSection = new SettingsSection();
		}
		return settingsSection.Visualizer;
	}

	protected virtual void CreateVisualizationShell()
	{
	}

	protected virtual void AddBuilderStrategies(Builder builder)
	{
	}

	protected virtual void AddServices()
	{
	}

	private Builder CreateBuilder()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		Builder val = new Builder();
		((BuilderBase<BuilderStage>)(object)val).get_Strategies().AddNew<EventBrokerStrategy>((BuilderStage)2);
		((BuilderBase<BuilderStage>)(object)val).get_Strategies().AddNew<CommandStrategy>((BuilderStage)2);
		((BuilderBase<BuilderStage>)(object)val).get_Policies().SetDefault<ISingletonPolicy>((ISingletonPolicy)new SingletonPolicy(true));
		return val;
	}

	private void CreateRootWorkItem(Builder builder)
	{
		rootWorkItem = new WorkItem();
		RootWorkItem.InitializeRootWorkItem(builder);
	}

	private void AddRequiredServices()
	{
		RootWorkItem.Services.AddNew<TraceSourceCatalogService, ITraceSourceCatalogService>();
		RootWorkItem.Services.AddNew<WorkItemTypeCatalogService, IWorkItemTypeCatalogService>();
		RootWorkItem.Services.AddNew<SimpleWorkItemActivationService, IWorkItemActivationService>();
		RootWorkItem.Services.AddNew<CommandAdapterMapService, ICommandAdapterMapService>();
		RootWorkItem.Services.AddNew<UIElementAdapterFactoryCatalog, IUIElementAdapterFactoryCatalog>();
		RootWorkItem.Services.Add((IVisualizer)this);
	}

	private void LoadVisualizerPlugins()
	{
		foreach (VisualizationElement item in Configuration)
		{
			AddNewVisualization(item.Type);
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			rootWorkItem.Services.Remove<IVisualizer>();
			rootWorkItem.Dispose();
		}
	}

	protected TVisualization AddNewVisualization<TVisualization>()
	{
		return (TVisualization)AddNewVisualization(typeof(TVisualization));
	}

	protected object AddNewVisualization(Type type)
	{
		object obj = RootWorkItem.Items.AddNew(type);
		visualizations.Add(obj);
		return obj;
	}
}
