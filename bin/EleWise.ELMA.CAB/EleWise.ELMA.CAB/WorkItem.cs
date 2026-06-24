#define TRACE
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using EleWise.ELMA.CAB.BuilderStrategies;
using EleWise.ELMA.CAB.Collections;
using EleWise.ELMA.CAB.Commands;
using EleWise.ELMA.CAB.Events;
using EleWise.ELMA.CAB.Instrumentation;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Services;
using EleWise.ELMA.CAB.SmartParts;
using EleWise.ELMA.CAB.Utility;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB;

public class WorkItem : IBuilderAware, IDisposable
{
	private class ClassNameTraceSourceAttribute : TraceSourceAttribute
	{
		public ClassNameTraceSourceAttribute()
			: base(typeof(WorkItem).FullName)
		{
		}
	}

	private delegate void ExtensionCallback(WorkItem workItem);

	private delegate void ExtensionCallbackCancellable(WorkItem workItem, CancelEventArgs args);

	private readonly ILifetimeContainer lifetime = (ILifetimeContainer)new LifetimeContainer();

	private readonly ListDictionary<object, ISmartPartInfo> smartPartInfos = new ListDictionary<object, ISmartPartInfo>();

	private bool buildUpFinished;

	private Builder _builder;

	private ManagedObjectCollection<Command> commandCollection;

	private ManagedObjectCollection<EventTopic> eventTopicCollection;

	private ManagedObjectCollection<object> itemsCollection;

	private IReadWriteLocator locator;

	private WorkItem parent;

	private ServiceCollection serviceCollection;

	private ManagedObjectCollection<object> smartPartCollection;

	private State _state;

	private WorkItemStatus status;

	private TraceSource traceSource;

	private UIExtensionSiteCollection uiExtensionSiteCollection;

	private ManagedObjectCollection<WorkItem> workItemCollection;

	private ManagedObjectCollection<IWorkspace> workspaceCollection;

	public ManagedObjectCollection<Command> Commands => commandCollection;

	public string ID
	{
		get
		{
			if (_state == null)
			{
				return null;
			}
			return _state.ID;
		}
		set
		{
			if (_state != null)
			{
				ReleaseState();
			}
			AttachState(new State(value));
			OnIdChanged();
		}
	}

	public ManagedObjectCollection<object> Items => itemsCollection;

	[Browsable(false)]
	[Dependency(/*Could not decode attribute arguments.*/)]
	public WorkItem Parent
	{
		get
		{
			return parent;
		}
		set
		{
			if (buildUpFinished)
			{
				throw new InvalidOperationException();
			}
			parent = value;
		}
	}

	[Browsable(false)]
	public WorkItem RootWorkItem
	{
		get
		{
			WorkItem workItem = this;
			while (workItem.Parent != null)
			{
				workItem = workItem.Parent;
			}
			return workItem;
		}
	}

	public ServiceCollection Services => serviceCollection;

	public ManagedObjectCollection<object> SmartParts => smartPartCollection;

	public State State => _state;

	public WorkItemStatus Status => status;

	[ClassNameTraceSource]
	public TraceSource TraceSource
	{
		set
		{
			traceSource = value;
		}
	}

	public UIExtensionSiteCollection UIExtensionSites => uiExtensionSiteCollection;

	public ManagedObjectCollection<WorkItem> WorkItems => workItemCollection;

	public ManagedObjectCollection<IWorkspace> Workspaces => workspaceCollection;

	public ManagedObjectCollection<EventTopic> EventTopics => eventTopicCollection;

	protected Builder InnerBuilder => _builder;

	protected IReadWriteLocator InnerLocator => locator;

	private IWorkItemActivationService ActivationService => Services.Get<IWorkItemActivationService>();

	public event EventHandler Activated;

	public event CancelEventHandler Activating;

	public event EventHandler Deactivated;

	public event CancelEventHandler Deactivating;

	public event EventHandler Disposed;

	public event EventHandler<DataEventArgs<string>> IdChanged;

	public event EventHandler Initialized;

	public event EventHandler RunStarted;

	public event EventHandler Terminated;

	public event EventHandler Terminating;

	internal event EventHandler<DataEventArgs<object>> ObjectAdded;

	internal event EventHandler<DataEventArgs<object>> ObjectRemoved;

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public void Run()
	{
		OnRunStarted();
	}

	protected internal void InitializeRootWorkItem(Builder builder)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		_builder = builder;
		locator = (IReadWriteLocator)new Locator();
		InitializeFields();
		InitializeCollectionFacades();
		InitializeState();
	}

	[InjectionMethod]
	public void InitializeWorkItem()
	{
		if (buildUpFinished)
		{
			throw new InvalidOperationException();
		}
		InitializeFields();
		InitializeCollectionFacades();
		InitializeState();
		InitializeServices();
	}

	private void InitializeFields()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		if (_builder == null)
		{
			_builder = parent._builder;
		}
		if (locator == null)
		{
			locator = (IReadWriteLocator)new Locator((IReadableLocator)(object)parent.locator);
		}
		if (!((IReadableLocator)locator).Contains((object)typeof(ILifetimeContainer), (SearchMode)1))
		{
			locator.Add((object)typeof(ILifetimeContainer), (object)lifetime);
		}
		ObjectBuiltNotificationPolicy objectBuiltNotificationPolicy = ((BuilderBase<BuilderStage>)(object)_builder).get_Policies().Get<ObjectBuiltNotificationPolicy>((Type)null, (string)null);
		if (objectBuiltNotificationPolicy != null)
		{
			objectBuiltNotificationPolicy.AddedDelegates[this] = OnObjectAdded;
			objectBuiltNotificationPolicy.RemovedDelegates[this] = OnObjectRemoved;
		}
		LocateWorkItem(typeof(WorkItem));
		LocateWorkItem(GetType());
		status = WorkItemStatus.Inactive;
	}

	private void LocateWorkItem(Type workItemType)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		DependencyResolutionLocatorKey val = new DependencyResolutionLocatorKey(workItemType, (string)null);
		if (!((IReadableLocator)locator).Contains((object)val, (SearchMode)1))
		{
			locator.Add((object)val, (object)this);
		}
	}

	private void InitializeCollectionFacades()
	{
		if (serviceCollection == null)
		{
			serviceCollection = new ServiceCollection(lifetime, locator, (IBuilder<BuilderStage>)(object)_builder, (parent == null) ? null : parent.serviceCollection);
		}
		if (commandCollection == null)
		{
			commandCollection = new ManagedObjectCollection<Command>(lifetime, locator, (IBuilder<BuilderStage>)(object)_builder, (SearchMode)0, CreateCommand, null, (parent == null) ? null : parent.commandCollection);
		}
		if (workItemCollection == null)
		{
			workItemCollection = new ManagedObjectCollection<WorkItem>(lifetime, locator, (IBuilder<BuilderStage>)(object)_builder, (SearchMode)1, null, null, (parent == null) ? null : parent.workItemCollection);
		}
		if (workspaceCollection == null)
		{
			workspaceCollection = new ManagedObjectCollection<IWorkspace>(lifetime, locator, (IBuilder<BuilderStage>)(object)_builder, (SearchMode)0, null, null, (parent == null) ? null : parent.workspaceCollection);
		}
		if (itemsCollection == null)
		{
			itemsCollection = new ManagedObjectCollection<object>(lifetime, locator, (IBuilder<BuilderStage>)(object)_builder, (SearchMode)1, null, null, (parent == null) ? null : parent.itemsCollection);
		}
		if (smartPartCollection == null)
		{
			smartPartCollection = new ManagedObjectCollection<object>(lifetime, locator, (IBuilder<BuilderStage>)(object)_builder, (SearchMode)1, null, (object obj) => obj.GetType().GetCustomAttributes(typeof(SmartPartAttribute), inherit: true).Length > 0, (parent == null) ? null : parent.smartPartCollection);
		}
		if (eventTopicCollection == null)
		{
			if (parent == null)
			{
				eventTopicCollection = new ManagedObjectCollection<EventTopic>(lifetime, locator, (IBuilder<BuilderStage>)(object)_builder, (SearchMode)1, CreateEventTopic, null, null);
			}
			else
			{
				eventTopicCollection = RootWorkItem.eventTopicCollection;
			}
		}
		if (uiExtensionSiteCollection == null)
		{
			uiExtensionSiteCollection = ((parent == null) ? new UIExtensionSiteCollection(this) : new UIExtensionSiteCollection(parent.uiExtensionSiteCollection));
		}
	}

	private void InitializeState()
	{
		ID = Guid.NewGuid().ToString();
	}

	protected virtual Command CreateCommand(Type t, string name)
	{
		return new Command();
	}

	protected virtual EventTopic CreateEventTopic(Type t, string topicName)
	{
		return new EventTopic();
	}

	protected virtual void InitializeServices()
	{
	}

	public void Activate()
	{
		ChangeStatus(WorkItemStatus.Active);
	}

	public void Deactivate()
	{
		ChangeStatus(WorkItemStatus.Inactive);
	}

	public void DeleteState()
	{
		IStatePersistenceService statePersistenceService = Services.Get<IStatePersistenceService>();
		if (statePersistenceService == null)
		{
			throw new ServiceMissingException(typeof(IStatePersistenceService), this);
		}
		statePersistenceService.Remove(ID);
	}

	public void Load()
	{
		IStatePersistenceService statePersistenceService = Services.Get<IStatePersistenceService>();
		if (statePersistenceService == null)
		{
			throw new ServiceMissingException(typeof(IStatePersistenceService), this);
		}
		using (new WriterLock(_state.syncRoot))
		{
			State state = statePersistenceService.Load(ID);
			state.syncRoot = ReleaseState();
			AttachState(state);
		}
	}

	public virtual void OnBuiltUp(string id)
	{
		if (buildUpFinished)
		{
			throw new InvalidOperationException();
		}
		buildUpFinished = true;
		if (parent != null)
		{
			FinishInitialization();
		}
	}

	public virtual void OnTearingDown()
	{
		ObjectBuiltNotificationPolicy objectBuiltNotificationPolicy = ((BuilderBase<BuilderStage>)(object)_builder).get_Policies().Get<ObjectBuiltNotificationPolicy>((Type)null, (string)null);
		if (objectBuiltNotificationPolicy != null)
		{
			objectBuiltNotificationPolicy.AddedDelegates.Remove(this);
			objectBuiltNotificationPolicy.RemovedDelegates.Remove(this);
		}
	}

	public TSmartPartInfo GetSmartPartInfo<TSmartPartInfo>(object smartPart) where TSmartPartInfo : ISmartPartInfo
	{
		Guard.ArgumentNotNull(smartPart, "smartPart");
		return FindSmartPartInfo<TSmartPartInfo>(smartPart);
	}

	protected internal void FinishInitialization()
	{
		Services.Get<IWorkItemExtensionService>()?.InitializeExtensions(this);
		OnInitialized();
	}

	public void RegisterSmartPartInfo(object smartPart, ISmartPartInfo info)
	{
		Guard.ArgumentNotNull(smartPart, "smartPart");
		Guard.ArgumentNotNull(info, "info");
		Predicate<ISmartPartInfo> findSPI = (ISmartPartInfo match) => match.GetType() == info.GetType();
		if (this != RootWorkItem)
		{
			RegisterSmartPartInfoInWorkItem(smartPart, info, findSPI, RootWorkItem);
		}
		RegisterSmartPartInfoInWorkItem(smartPart, info, findSPI, this);
	}

	private static void RegisterSmartPartInfoInWorkItem(object smartPart, ISmartPartInfo info, Predicate<ISmartPartInfo> findSPI, WorkItem workItem)
	{
		if (smartPart == null)
		{
			throw new ArgumentNullException("smartPart");
		}
		if (findSPI == null)
		{
			throw new ArgumentNullException("findSPI");
		}
		if (workItem == null)
		{
			throw new ArgumentNullException("workItem");
		}
		if (!workItem.smartPartInfos.ContainsKey(smartPart))
		{
			workItem.smartPartInfos.Add(smartPart);
			workItem.smartPartInfos[smartPart].Add(info);
			return;
		}
		ISmartPartInfo smartPartInfo = workItem.smartPartInfos[smartPart].Find(findSPI);
		if (smartPartInfo != null)
		{
			workItem.smartPartInfos[smartPart].Remove(smartPartInfo);
		}
		workItem.smartPartInfos[smartPart].Add(info);
	}

	public void Save()
	{
		IStatePersistenceService statePersistenceService = Services.Get<IStatePersistenceService>();
		if (statePersistenceService == null)
		{
			throw new ServiceMissingException(typeof(IStatePersistenceService), this);
		}
		using (new WriterLock(_state.syncRoot))
		{
			statePersistenceService.Save(_state);
			_state.AcceptChanges();
		}
	}

	public void Terminate()
	{
		ThrowIfWorkItemTerminated();
		Dispose();
	}

	protected internal void BuildUp()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		Type type = GetType();
		string text = Guid.NewGuid().ToString();
		PropertySetterPolicy val = new PropertySetterPolicy();
		val.get_Properties().Add("Parent", (IPropertySetterInfo)new PropertySetterInfo("Parent", (IParameter)new ValueParameter(typeof(WorkItem), (object)null)));
		PolicyList val2 = new PolicyList((PolicyList[])(object)new PolicyList[0]);
		val2.Set<ISingletonPolicy>((ISingletonPolicy)new SingletonPolicy(false), type, text);
		val2.Set<IPropertySetterPolicy>((IPropertySetterPolicy)(object)val, type, text);
		((BuilderBase<BuilderStage>)(object)_builder).BuildUp(locator, type, text, (object)this, (PolicyList[])(object)new PolicyList[1] { val2 });
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposing || status == WorkItemStatus.Terminated)
		{
			return;
		}
		ChangeStatus(WorkItemStatus.Terminated);
		((BuilderBase<BuilderStage>)(object)_builder).TearDown<WorkItem>(locator, this);
		uiExtensionSiteCollection.Dispose();
		ObjectBuiltNotificationPolicy objectBuiltNotificationPolicy = ((BuilderBase<BuilderStage>)(object)_builder).get_Policies().Get<ObjectBuiltNotificationPolicy>((Type)null, (string)null);
		if (objectBuiltNotificationPolicy != null)
		{
			objectBuiltNotificationPolicy.AddedDelegates.Remove(this);
			objectBuiltNotificationPolicy.RemovedDelegates.Remove(this);
		}
		if (_state != null)
		{
			ReleaseState();
		}
		if (parent != null)
		{
			List<object> list = (from pair in (IEnumerable<KeyValuePair<object, object>>)parent.locator
				where pair.Value == this
				select pair.Key).ToList();
			foreach (object item in list)
			{
				parent.locator.Remove(item);
			}
			parent.lifetime.Remove((object)this);
			foreach (object key in smartPartInfos.Keys)
			{
				RootWorkItem.smartPartInfos.Remove(key);
			}
		}
		lifetime.Remove((object)this);
		List<object> list2 = new List<object>();
		list2.AddRange((IEnumerable<object>)lifetime);
		foreach (object item2 in list2)
		{
			if (lifetime.Contains(item2))
			{
				((BuilderBase<BuilderStage>)(object)_builder).TearDown<object>(locator, item2);
			}
		}
		((IDisposable)lifetime).Dispose();
		OnDisposed();
	}

	private void AttachState(State state)
	{
		if (state == null)
		{
			throw new ArgumentNullException("state");
		}
		_state = state;
		_state.StateChanged += stateDataStateChanged;
		Items.Add(_state);
	}

	private ReaderWriterLock ReleaseState()
	{
		ReaderWriterLock syncRoot = _state.syncRoot;
		_state.StateChanged -= stateDataStateChanged;
		Items.Remove(_state);
		_state.Dispose();
		_state = null;
		return syncRoot;
	}

	protected virtual void OnActivated()
	{
		if (this.Activated != null)
		{
			this.Activated(this, EventArgs.Empty);
		}
		if (traceSource != null)
		{
			traceSource.TraceInformation(string.Format(CultureInfo.CurrentCulture, Resources.TraceWorkItemStatusChangedToActivated, new object[1] { ID }));
		}
	}

	protected virtual void OnActivating(CancelEventArgs args)
	{
		if (traceSource != null)
		{
			traceSource.TraceInformation(string.Format(CultureInfo.CurrentCulture, Resources.TraceWorkItemStatusActivating, new object[1] { ID }));
		}
		if (this.Activating != null)
		{
			this.Activating(this, args);
		}
	}

	protected virtual void OnDeactivated()
	{
		if (this.Deactivated != null)
		{
			this.Deactivated(this, EventArgs.Empty);
		}
		if (traceSource != null)
		{
			traceSource.TraceInformation(string.Format(CultureInfo.CurrentCulture, Resources.TraceWorkItemStatusChangedToDeactivated, new object[1] { ID }));
		}
	}

	protected virtual void OnDeactivating(CancelEventArgs args)
	{
		if (traceSource != null)
		{
			traceSource.TraceInformation(string.Format(CultureInfo.CurrentCulture, Resources.TraceWorkItemStatusDeactivating, new object[1] { ID }));
		}
		if (this.Deactivating != null)
		{
			this.Deactivating(this, args);
		}
	}

	protected virtual void OnDisposed()
	{
		if (this.Disposed != null)
		{
			this.Disposed(this, EventArgs.Empty);
		}
		if (traceSource != null)
		{
			traceSource.TraceInformation(string.Format(CultureInfo.CurrentCulture, Resources.TraceWorkItemStatusChangedToDisposed, new object[1] { ID }));
		}
	}

	protected virtual void OnIdChanged()
	{
		if (this.IdChanged != null)
		{
			this.IdChanged(this, new DataEventArgs<string>(ID));
		}
	}

	protected virtual void OnInitialized()
	{
		if (this.Initialized != null)
		{
			this.Initialized(this, EventArgs.Empty);
		}
		if (traceSource != null)
		{
			traceSource.TraceInformation(string.Format(CultureInfo.CurrentCulture, Resources.TraceWorkItemStatusChangedToInitialized, new object[1] { ID }));
		}
	}

	protected virtual void OnObjectAdded(object item)
	{
		if (this.ObjectAdded != null)
		{
			this.ObjectAdded(this, new DataEventArgs<object>(item));
		}
	}

	protected virtual void OnObjectRemoved(object item)
	{
		if (this.ObjectRemoved != null)
		{
			this.ObjectRemoved(this, new DataEventArgs<object>(item));
		}
	}

	protected virtual void OnRunStarted()
	{
		if (this.RunStarted != null)
		{
			this.RunStarted(this, EventArgs.Empty);
		}
		if (traceSource != null)
		{
			traceSource.TraceInformation(string.Format(CultureInfo.CurrentCulture, Resources.TraceWorkItemRunStarted, new object[1] { ID }));
		}
	}

	protected virtual void OnTerminated()
	{
		if (this.Terminated != null)
		{
			this.Terminated(this, EventArgs.Empty);
		}
		if (traceSource != null)
		{
			traceSource.TraceInformation(string.Format(CultureInfo.CurrentCulture, Resources.TraceWorkItemStatusChangedToTerminated, new object[1] { ID }));
		}
	}

	protected virtual void OnTerminating()
	{
		if (traceSource != null)
		{
			traceSource.TraceInformation(string.Format(CultureInfo.CurrentCulture, Resources.TraceWorkItemStatusTerminating, new object[1] { ID }));
		}
		if (this.Terminating != null)
		{
			this.Terminating(this, EventArgs.Empty);
		}
	}

	private TSmartPartInfo FindSmartPartInfo<TSmartPartInfo>(object smartPart) where TSmartPartInfo : ISmartPartInfo
	{
		if (smartPart == null)
		{
			throw new ArgumentNullException("smartPart");
		}
		TSmartPartInfo result = default(TSmartPartInfo);
		if (RootWorkItem.smartPartInfos.ContainsKey(smartPart))
		{
			return (TSmartPartInfo)RootWorkItem.smartPartInfos[smartPart].Find((ISmartPartInfo info) => info.GetType() == typeof(TSmartPartInfo));
		}
		return result;
	}

	private void stateDataStateChanged(object sender, StateChangedEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		string id = StateChangedTopic.BuildStateChangedTopicString(e.Key);
		EventTopics.Get(id)?.Fire(this, e, this, PublicationScope.WorkItem);
	}

	private void ChangeStatus(WorkItemStatus newStatus)
	{
		ThrowIfWorkItemTerminated();
		WorkItemStatus workItemStatus = status;
		if (workItemStatus == newStatus)
		{
			return;
		}
		CancelEventArgs cancelEventArgs = new CancelEventArgs();
		FireIfActivating(newStatus, cancelEventArgs);
		FireIfDeactivating(newStatus, cancelEventArgs);
		FireIfTerminating(newStatus);
		if (!cancelEventArgs.Cancel)
		{
			status = newStatus;
			if (ActivationService != null)
			{
				ActivationService.ChangeStatus(this);
			}
			FireStatusEvents();
		}
	}

	private void FireIfActivating(WorkItemStatus newStatus, CancelEventArgs args)
	{
		if (newStatus == WorkItemStatus.Active)
		{
			OnActivating(args);
		}
	}

	private void FireIfDeactivating(WorkItemStatus newStatus, CancelEventArgs args)
	{
		if (newStatus == WorkItemStatus.Inactive)
		{
			OnDeactivating(args);
		}
	}

	private void FireIfTerminating(WorkItemStatus newStatus)
	{
		if (newStatus == WorkItemStatus.Terminated)
		{
			OnTerminating();
		}
	}

	private void FireStatusEvents()
	{
		if (status == WorkItemStatus.Active)
		{
			OnActivated();
		}
		else if (status == WorkItemStatus.Inactive)
		{
			OnDeactivated();
		}
		else if (status == WorkItemStatus.Terminated)
		{
			OnTerminated();
		}
	}

	private void ThrowIfActivationServiceNotPresent()
	{
		if (ActivationService == null)
		{
			throw new ServiceMissingException(typeof(IWorkItemActivationService), this);
		}
	}

	private void ThrowIfWorkItemTerminated()
	{
		if (Status == WorkItemStatus.Terminated)
		{
			throw new InvalidOperationException(Resources.WorkItemTerminated);
		}
	}
}
