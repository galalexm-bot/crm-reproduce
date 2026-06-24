using System;
using System.Collections.Generic;
using System.Linq;
using NuGet;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public class ManifestValidationHelper
{
	private class PackageDependencyManifestHelper
	{
		public ElmaStoreComponentManifest Component { get; set; }

		public PackageDependencyManifest Dependency { get; set; }
	}

	private class ElmaStoreComponentDependencyHelper
	{
		public ElmaStoreComponentManifest Component { get; set; }

		public ElmaStoreComponentDependency Dependency { get; set; }
	}

	private class PackageManifestHelper
	{
		public ElmaStoreComponentManifest Component { get; set; }

		public PackageManifest Manifest { get; set; }
	}

	private class ProcessManifestHelper
	{
		public ElmaStoreComponentManifest Component { get; set; }

		public ProcessManifest Manifest { get; set; }
	}

	private class EntityManifestHelper
	{
		public ElmaStoreComponentManifest Component { get; set; }

		public EntityManifest Manifest { get; set; }
	}

	private class StoredProcedureManifestHelper
	{
		public ElmaStoreComponentManifest Component { get; set; }

		public StoredProcedureManifest Manifest { get; set; }
	}

	private class ExtensionPointManifestHelper
	{
		public ElmaStoreComponentManifest Component { get; set; }

		public PackageManifest PackageManifest { get; set; }

		public ExtensionPointManifest Manifest { get; set; }
	}

	private class ComponentManifestHelper
	{
		public ElmaStoreComponentManifest Component { get; set; }

		public ComponentManifest Manifest { get; set; }
	}

	public static bool CheckByDependencies(List<ElmaStoreComponentManifest> components, List<ElmaStoreComponentManifest> allComponents, out List<string> errors)
	{
		List<ElmaStoreComponentManifest> incompatible;
		return CheckByDependencies(components, allComponents, out incompatible, out errors);
	}

	public static bool CheckByDependencies(List<ElmaStoreComponentManifest> components, List<ElmaStoreComponentManifest> allComponents, out List<ElmaStoreComponentManifest> incompatible)
	{
		List<string> errors;
		return CheckByDependencies(components, allComponents, out incompatible, out errors);
	}

	public static bool CheckByDependencies(List<ElmaStoreComponentManifest> components, List<ElmaStoreComponentManifest> allComponents, out List<ElmaStoreComponentManifest> incompatible, out List<string> errors)
	{
		errors = new List<string>();
		incompatible = new List<ElmaStoreComponentManifest>();
		bool result = true;
		List<ElmaStoreComponentManifest> realyAllComponents = new List<ElmaStoreComponentManifest>();
		if (allComponents != null)
		{
			realyAllComponents.AddRange(allComponents);
		}
		if (components != null)
		{
			realyAllComponents.AddRange(components);
		}
		foreach (ElmaStoreComponentManifest component in components)
		{
			List<ElmaStoreComponentDependency> list = component.Dependencies.Where((ElmaStoreComponentDependency d) => realyAllComponents.All((ElmaStoreComponentManifest c) => c.Id != d.Id)).ToList();
			if (list.Count <= 0)
			{
				continue;
			}
			foreach (ElmaStoreComponentDependency item in list)
			{
				incompatible.Add(component);
				errors.Add(SR.T("Компонент {0}({1}) требует установки компонента {2}", component.Title, component.Id, item.Id));
			}
			result = false;
		}
		return result;
	}

	public static bool Check(Dictionary<ElmaStoreComponentManifest, bool> components)
	{
		List<string> errors;
		List<string> warnings;
		return Check(components, out errors, out warnings);
	}

	public static bool Check(Dictionary<ElmaStoreComponentManifest, bool> components, out List<string> errors, out List<string> warnings)
	{
		List<ElmaStoreComponentManifest> incompatible;
		return Check(components, out errors, out warnings, out incompatible);
	}

	public static bool Check(Dictionary<ElmaStoreComponentManifest, bool> components, out List<ElmaStoreComponentManifest> incompatible)
	{
		List<string> errors;
		List<string> warnings;
		return Check(components, out errors, out warnings, out incompatible);
	}

	public static bool Check(Dictionary<ElmaStoreComponentManifest, bool> components, out List<string> errors, out List<string> warnings, out List<ElmaStoreComponentManifest> incompatible)
	{
		errors = new List<string>();
		warnings = new List<string>();
		incompatible = new List<ElmaStoreComponentManifest>();
		List<ElmaStoreComponentDependencyHelper> list = components.Keys.Select((ElmaStoreComponentManifest c) => new ElmaStoreComponentDependencyHelper
		{
			Dependency = new ElmaStoreComponentDependency
			{
				Id = c.Id,
				ManifestVersion = GetComponentVersion((SemanticVersion)(((object)c.SemanticVersion) ?? ((object)new SemanticVersion("1.0.0.0"))))
			},
			Component = c
		}).ToList();
		List<KeyValuePair<ElmaStoreComponentManifest, bool>> source = components.Where((KeyValuePair<ElmaStoreComponentManifest, bool> c) => !c.Value).ToList();
		list.AddRange(source.SelectMany((KeyValuePair<ElmaStoreComponentManifest, bool> c) => c.Key.Dependencies.Select((ElmaStoreComponentDependency d) => new ElmaStoreComponentDependencyHelper
		{
			Component = c.Key,
			Dependency = d
		})));
		foreach (IGrouping<string, ElmaStoreComponentDependencyHelper> item in from c in list
			group c by c.Dependency.Id into g
			where g.Count() > 1
			select g)
		{
			if (!HasIntersection((from g in item
				select g.Dependency.ManifestVersion into g
				where g != null
				select g).ToList()))
			{
				incompatible.AddRange(from g in item
					select g.Component into c
					where c != null
					select c);
				errors.Add(SR.T("Компоненты не совместимы, так как в зависимостях существуют ссылки на разные версии компонентов ({0}).", string.Join(", ", item.Select((ElmaStoreComponentDependencyHelper g) => $"{g.Dependency.Id} {g.Dependency.ManifestVersion}"))));
				return false;
			}
		}
		List<PackageDependencyManifestHelper> list2 = components.Keys.SelectMany((ElmaStoreComponentManifest c) => c.Packages.Select((PackageManifest p) => new PackageDependencyManifestHelper
		{
			Dependency = new PackageDependencyManifest
			{
				Id = p.Id,
				ManifestVersion = GetFromVersion(p.SemanticVersion)
			},
			Component = c
		})).ToList();
		list2.AddRange(source.SelectMany((KeyValuePair<ElmaStoreComponentManifest, bool> c) => c.Key.Processes.SelectMany((ProcessManifest p) => p.Dependencies.Select((PackageDependencyManifest d) => new PackageDependencyManifestHelper
		{
			Component = c.Key,
			Dependency = d
		}))));
		list2.AddRange(source.SelectMany((KeyValuePair<ElmaStoreComponentManifest, bool> c) => c.Key.Reports.SelectMany((ReportManifest p) => p.Dependencies.Select((PackageDependencyManifest d) => new PackageDependencyManifestHelper
		{
			Component = c.Key,
			Dependency = d
		}))));
		foreach (IGrouping<string, PackageDependencyManifestHelper> item2 in from d in list2
			where d.Dependency != null
			select d into c
			group c by c.Dependency.Id into g
			where g.Count() > 1
			select g)
		{
			if (!HasIntersection(item2.Select((PackageDependencyManifestHelper g) => g.Dependency.ManifestVersion).ToList()))
			{
				incompatible.AddRange(item2.Select((PackageDependencyManifestHelper g) => g.Component));
				errors.Add(SR.T("Компоненты не совместимы, так как в зависимостях существуют ссылки на разные версии пакетов ({0}).", string.Join(", ", item2.Select((PackageDependencyManifestHelper g) => $"{g.Dependency.Id} {g.Dependency.ManifestVersion}"))));
				return false;
			}
		}
		List<PackageManifestHelper> source2 = (from c in components.Keys.SelectMany((ElmaStoreComponentManifest c) => c.Packages.Select((PackageManifest m) => new PackageManifestHelper
			{
				Component = c,
				Manifest = m
			}))
			group c by c.Manifest.Id into g
			select g.OrderByDescending((PackageManifestHelper p) => p.Manifest.SemanticVersion).FirstOrDefault() into p
			where p != null
			select p).ToList();
		List<ProcessManifestHelper> source3 = (from c in components.Keys.SelectMany((ElmaStoreComponentManifest c) => c.Processes.Select((ProcessManifest m) => new ProcessManifestHelper
			{
				Component = c,
				Manifest = m
			}))
			group c by c.Manifest.Id into g
			select g.OrderByDescending((ProcessManifestHelper p) => p.Manifest.Version).FirstOrDefault() into g
			where g != null
			select g).ToList();
		List<EntityManifestHelper> list3 = source2.SelectMany((PackageManifestHelper m) => m.Manifest.Entities.Select((EntityManifest e) => new EntityManifestHelper
		{
			Component = m.Component,
			Manifest = e
		})).ToList();
		list3.AddRange(source3.Select((ProcessManifestHelper p) => new EntityManifestHelper
		{
			Component = p.Component,
			Manifest = p.Manifest.Context
		}).ToList());
		List<IGrouping<Guid, EntityManifestHelper>> source4 = (from e in list3
			where e != null && e.Manifest != null
			group e by e.Manifest.Uid).ToList();
		if (source4.Any((IGrouping<Guid, EntityManifestHelper> g) => g.Count() > 1))
		{
			warnings.Add(SR.T("В разных модулях добавляются одинаковые сущности. Возможны конфликты при импорте таких сущностей."));
		}
		List<EntityManifestHelper> source5 = (from e in source4
			select e.FirstOrDefault() into e
			where e != null
			select e).ToList();
		List<IGrouping<string, EntityManifestHelper>> list4 = (from e in source5
			group e by e.Manifest.TableName into g
			where g.Count((EntityManifestHelper t) => t.Manifest.EntityMetadataType == 0 || t.Manifest.EntityMetadataType == 1) > 1
			select g).ToList();
		if (list4.Count > 0)
		{
			incompatible.AddRange(list4.SelectMany((IGrouping<string, EntityManifestHelper> g) => g.Select((EntityManifestHelper h) => h.Component)));
			errors.Add(SR.T("В разных сущностях указана одна и таже таблица для хранения ({0}).", string.Join(", ", list4.Select((IGrouping<string, EntityManifestHelper> g) => string.Join(";", g.Select((EntityManifestHelper e) => $"{e.Manifest.Uid}-{e.Manifest.Name}"))))));
			return false;
		}
		List<IGrouping<string, EntityManifestHelper>> list5 = (from e in source5
			group e by $"{e.Manifest.Namespace}.{e.Manifest.Name}" into g
			where g.Count() > 1
			select g).ToList();
		if (list5.Count > 0)
		{
			incompatible.AddRange(list5.SelectMany((IGrouping<string, EntityManifestHelper> g) => g.Select((EntityManifestHelper h) => h.Component)));
			errors.Add(SR.T("В разных сущностях указано одно и тоже имя класса ({0}).", string.Join(", ", list5.Select((IGrouping<string, EntityManifestHelper> g) => string.Join(";", g.Select((EntityManifestHelper e) => $"{e.Manifest.Uid}-{e.Manifest.Name}"))))));
			return false;
		}
		List<IGrouping<string, StoredProcedureManifestHelper>> list6 = (from p in source2.SelectMany((PackageManifestHelper m) => m.Manifest.StoredProcedures.Select((StoredProcedureManifest e) => new StoredProcedureManifestHelper
			{
				Component = m.Component,
				Manifest = e
			}))
			group p by $"{p.Manifest.Database}{p.Manifest.Name}" into g
			where g.Count() > 1
			select g).ToList();
		if (list6.Count > 0)
		{
			incompatible.AddRange(list6.SelectMany((IGrouping<string, StoredProcedureManifestHelper> g) => g.Select((StoredProcedureManifestHelper h) => h.Component)));
			errors.Add(SR.T("Разные модули системы не могут добавлять одни и те же хранимые процедуры и функции ({0})", string.Join(", ", list6.Select((IGrouping<string, StoredProcedureManifestHelper> g) => string.Join(";", g.Select((StoredProcedureManifestHelper e) => e.Manifest.Name))))));
			return false;
		}
		List<IGrouping<string, ExtensionPointManifestHelper>> list7 = (from e in source2.SelectMany((PackageManifestHelper m) => m.Manifest.ExtensionPoints.Select((ExtensionPointManifest e) => new ExtensionPointManifestHelper
			{
				Component = m.Component,
				PackageManifest = m.Manifest,
				Manifest = e
			}))
			group e by e.Manifest.Name into g
			where g.Count() > 1
			select g).ToList();
		if (list7.Count > 0)
		{
			incompatible.AddRange(list7.SelectMany((IGrouping<string, ExtensionPointManifestHelper> g) => g.Select((ExtensionPointManifestHelper h) => h.Component)));
			errors.Add(SR.T("Разные модули не могут объявлять одинаковые точки расширения: {0}", string.Join(", ", list7.Select((IGrouping<string, ExtensionPointManifestHelper> g) => SR.T("{0} ({1})", g.Key, string.Join("; ", g.Select((ExtensionPointManifestHelper e) => e.PackageManifest.Id)))))));
			return false;
		}
		foreach (IGrouping<string, ComponentManifestHelper> item3 in (from c in source2.SelectMany((PackageManifestHelper m) => m.Manifest.Components.Select((ComponentManifest c) => new ComponentManifestHelper
			{
				Manifest = c,
				Component = m.Component
			}))
			group c by c.Manifest.ExtensionPoint).ToList())
		{
			List<ComponentManifestHelper> list8 = item3.ToList();
			ComponentManifestHelper componentManifestHelper = list8.FirstOrDefault();
			if (componentManifestHelper == null)
			{
				continue;
			}
			foreach (ComponentManifestHelper item4 in list8)
			{
				if (!item4.Manifest.Equals(componentManifestHelper.Manifest))
				{
					incompatible.Add(item4.Component);
					errors.Add(SR.T("Найдены разные реализации одной и той же точки расширения ({0}:{1}).", item4.Manifest.ExtensionPoint, item4.Manifest.Name));
					return false;
				}
			}
		}
		return true;
	}

	public static IVersionSpec GetFromVersion(SemanticVersion version)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Expected O, but got Unknown
		VersionSpec val = new VersionSpec();
		val.set_IsMinInclusive(true);
		val.set_MinVersion(new SemanticVersion(version.get_Version().Major + "." + version.get_Version().Minor));
		val.set_IsMaxInclusive(false);
		val.set_MaxVersion(new SemanticVersion(version.get_Version().Major + "." + (version.get_Version().Minor + 1)));
		return (IVersionSpec)val;
	}

	public static IVersionSpec GetComponentVersion(SemanticVersion version)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0036: Expected O, but got Unknown
		VersionSpec val = new VersionSpec();
		val.set_IsMinInclusive(true);
		val.set_MinVersion(new SemanticVersion(((object)version).ToString()));
		val.set_IsMaxInclusive(true);
		val.set_MaxVersion(new SemanticVersion(((object)version).ToString()));
		return (IVersionSpec)val;
	}

	public static bool HasIntersection(List<IVersionSpec> intervalas)
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		IGrouping<SemanticVersion, IVersionSpec> grouping = (from i in intervalas
			group i by i.get_MinVersion() into v
			orderby v.Key descending
			select v).FirstOrDefault();
		if (grouping == null)
		{
			return false;
		}
		IVersionSpec val = grouping.FirstOrDefault((IVersionSpec v) => !v.get_IsMinInclusive()) ?? grouping.FirstOrDefault();
		if (val == null)
		{
			return false;
		}
		IGrouping<SemanticVersion, IVersionSpec> grouping2 = (from i in intervalas
			group i by i.get_MaxVersion() into v
			orderby v.Key
			select v).FirstOrDefault();
		if (grouping2 == null)
		{
			return false;
		}
		IVersionSpec val2 = grouping2.FirstOrDefault((IVersionSpec v) => !v.get_IsMaxInclusive()) ?? grouping2.FirstOrDefault();
		if (val2 == null)
		{
			return false;
		}
		VersionSpec val3 = new VersionSpec();
		val3.set_IsMinInclusive(val.get_IsMinInclusive());
		val3.set_MinVersion((SemanticVersion)(((object)val.get_MinVersion()) ?? ((object)new SemanticVersion(int.MinValue, int.MinValue, int.MinValue, int.MinValue))));
		val3.set_IsMaxInclusive(val2.get_IsMaxInclusive());
		val3.set_MaxVersion((SemanticVersion)(((object)val2.get_MaxVersion()) ?? ((object)new SemanticVersion(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue))));
		VersionSpec val4 = val3;
		if (val4.get_IsMinInclusive() && val4.get_IsMaxInclusive())
		{
			if (val4.get_MinVersion() > val4.get_MaxVersion())
			{
				return false;
			}
			return true;
		}
		if (val4.get_IsMinInclusive())
		{
			if (val4.get_MinVersion() >= val4.get_MaxVersion())
			{
				return false;
			}
			return true;
		}
		if (val4.get_IsMaxInclusive())
		{
			if (val4.get_MinVersion() > val4.get_MaxVersion())
			{
				return false;
			}
			return true;
		}
		if (val4.get_MinVersion() >= val4.get_MaxVersion())
		{
			return false;
		}
		return true;
	}

	public static bool HasIntersection(List<SemanticVersion> versions)
	{
		return HasIntersection(versions.Select((SemanticVersion v) => GetFromVersion(v)).ToList());
	}
}
