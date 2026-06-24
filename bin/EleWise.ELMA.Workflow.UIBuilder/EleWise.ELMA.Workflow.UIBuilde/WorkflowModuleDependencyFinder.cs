using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.UI.Components.Dependency;
using EleWise.ELMA.UI.Components.Dependency.Models;
using EleWise.ELMA.Workflow.Models;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace EleWise.ELMA.Workflow.UIBuilder.Components;

[Component]
internal sealed class WorkflowModuleDependencyFinder : IDependencyFinder
{
	private class DependencyWithScriptModule
	{
		public MetadataDependencyContainer Dependencies { get; set; }

		public long ClientScriptModuleId { get; set; }

		public long ScriptModuleId { get; set; }
	}

	private readonly ISessionProvider sessionProvider;

	private ISession Session => sessionProvider.GetSession(string.Empty);

	public WorkflowModuleDependencyFinder(ISessionProvider sessionProvider)
	{
		this.sessionProvider = sessionProvider;
	}

	public IEnumerable<Dependency> GetDependencies(IEnumerable<IDependencyRequest> dependencyRequests)
	{
		IEnumerable<Dependency> enumerable = Enumerable.Empty<Dependency>();
		if (!dependencyRequests.Any())
		{
			return enumerable;
		}
		ICollection<DependencyWithScriptModule> dependenciesWithScriptModulesList = null;
		Session.ExecuteWithTimeout(0, delegate
		{
			dependenciesWithScriptModulesList = Session.CreateCriteria<IWorkflowProcess>().CreateAlias("ScriptModule", "sm").CreateAlias("ClientScriptModule", "csm")
				.Add((ICriterion)(object)Restrictions.IsNotNull("Dependencies"))
				.Add((ICriterion)(object)Restrictions.IsNotNull("ClientScriptModule"))
				.SetProjection((IProjection[])(object)new IProjection[3]
				{
					Projections.Alias((IProjection)(object)Projections.Property("Dependencies"), "Dependencies"),
					Projections.Alias((IProjection)(object)Projections.Property("sm.Id"), "ScriptModuleId"),
					Projections.Alias((IProjection)(object)Projections.Property("csm.Id"), "ClientScriptModuleId")
				})
				.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(DependencyWithScriptModule)))
				.List<DependencyWithScriptModule>();
		});
		foreach (DependencyWithScriptModule item in dependenciesWithScriptModulesList)
		{
			MetadataDependencyContainer dependencies = item.Dependencies;
			foreach (IDependencyRequest dependencyRequest in dependencyRequests)
			{
				Guid moduleUid = dependencyRequest.ModuleUid;
				IEnumerable<FunctionDependency> second = dependencies.FunctionDependencies.Where((FunctionDependency a) => a.ModuleUid == moduleUid);
				IEnumerable<DataClassDependency> second2 = dependencies.DataClassDependencies.Where((DataClassDependency a) => a.ModuleUid == moduleUid);
				IEnumerable<Dependency> second3 = dependencies.FormDependencies.SelectMany(delegate(FormViewItemDependencyContainer a)
				{
					IEnumerable<ComponentDependency> first = a.ComponentDependencies.Where((ComponentDependency c) => c.ModuleUid == moduleUid);
					IEnumerable<DataClassDependency> second6 = a.DataClassDependencies.Where((DataClassDependency d) => d.ModuleUid == moduleUid);
					return ((IEnumerable<Dependency>)first).Concat((IEnumerable<Dependency>)second6);
				});
				enumerable = enumerable.Concat(second).Concat(second2).Concat(second3);
			}
		}
		ICollection<ScriptModuleDependencyContainer> serverScriptModuleDependencyContainers = null;
		Session.ExecuteWithTimeout(0, delegate
		{
			serverScriptModuleDependencyContainers = Session.CreateCriteria<ScriptModule>().Add((ICriterion)(object)Restrictions.In("Id", (ICollection)dependenciesWithScriptModulesList.Select((DependencyWithScriptModule s) => s.ScriptModuleId).ToArray())).Add((ICriterion)(object)Restrictions.IsNotNull("Dependencies"))
				.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("Dependencies") })
				.List<ScriptModuleDependencyContainer>();
		});
		ICollection<ScriptModuleDependencyContainer> clientScriptModuleDependencyContainers = null;
		Session.ExecuteWithTimeout(0, delegate
		{
			clientScriptModuleDependencyContainers = Session.CreateCriteria<ScriptModule>().Add((ICriterion)(object)Restrictions.In("Id", (ICollection)dependenciesWithScriptModulesList.Select((DependencyWithScriptModule s) => s.ClientScriptModuleId).ToArray())).Add((ICriterion)(object)Restrictions.IsNotNull("Dependencies"))
				.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("Dependencies") })
				.List<ScriptModuleDependencyContainer>();
		});
		IEnumerable<Dependency> second4 = ScriptModuleDependencies(serverScriptModuleDependencyContainers, dependencyRequests);
		IEnumerable<Dependency> second5 = ScriptModuleDependencies(clientScriptModuleDependencyContainers, dependencyRequests);
		return enumerable.Concat(second4).Concat(second5);
	}

	private static IEnumerable<Dependency> ScriptModuleDependencies(IEnumerable<ScriptModuleDependencyContainer> scriptModuleDependencyContainers, IEnumerable<IDependencyRequest> dependencyRequests)
	{
		IEnumerable<Dependency> enumerable = Enumerable.Empty<Dependency>();
		foreach (ScriptModuleDependencyContainer scriptModuleDependencyContainer in scriptModuleDependencyContainers)
		{
			foreach (IDependencyRequest dependencyRequest in dependencyRequests)
			{
				Guid moduleUid = dependencyRequest.ModuleUid;
				IEnumerable<DataClassDependency> second = scriptModuleDependencyContainer.DataClassDependencies.Where((DataClassDependency a) => a.ModuleUid == moduleUid);
				enumerable = enumerable.Concat(second);
			}
		}
		return enumerable;
	}
}
