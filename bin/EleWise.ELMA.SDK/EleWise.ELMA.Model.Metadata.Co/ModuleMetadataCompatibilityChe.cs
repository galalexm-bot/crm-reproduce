using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using EleWise.ELMA.Model.Signatures;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Components;

[Component]
internal sealed class ModuleMetadataCompatibilityChecker : CompatibilityChecker<ModuleSignature>
{
	private readonly IEnumerable<ICompatibilityChecker<DataClassDependency>> dataClassCheckers;

	private readonly IEnumerable<ICompatibilityChecker<FunctionDependency>> functionCheckers;

	private readonly IEnumerable<ICompatibilityChecker<ComponentSignature>> componentCheckers;

	public ModuleMetadataCompatibilityChecker(IEnumerable<ICompatibilityChecker<DataClassDependency>> dataClassCheckers, IEnumerable<ICompatibilityChecker<FunctionDependency>> functionCheckers, IEnumerable<ICompatibilityChecker<ComponentSignature>> componentCheckers)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.dataClassCheckers = dataClassCheckers;
		this.functionCheckers = functionCheckers;
		this.componentCheckers = componentCheckers;
	}

	public override ICollection<string> CheckCompatibility(ModuleSignature old, ModuleSignature @new)
	{
		List<string> first = CheckDataClasses(old.DataClasses, @new.DataClasses);
		List<string> second = CheckFunctions(old.Functions, @new.Functions);
		return Enumerable.Concat(second: CheckComponents(old.Components, @new.Components), first: first.Concat(second)).ToList();
	}

	private List<string> CheckDataClasses(ICollection<DataClassDependency> old, ICollection<DataClassDependency> @new)
	{
		Dictionary<Guid, DataClassDependency> dictionary = @new.ToDictionary((DataClassDependency d) => _003C_003Ec.GYydMRCdXUYhFKU3YJWY(d), (DataClassDependency d) => d);
		List<string> list = new List<string>();
		using IEnumerator<DataClassDependency> enumerator = old.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
			_003C_003Ec__DisplayClass5_.oldDependency = enumerator.Current;
			_003C_003Ec__DisplayClass5_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass5_;
			if (!dictionary.TryGetValue(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.oldDependency.HeaderUid, out CS_0024_003C_003E8__locals0.newDependency))
			{
				list.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFDDA7E), CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.oldDependency.Name));
			}
			else
			{
				list.AddRange(dataClassCheckers.SelectMany((ICompatibilityChecker<DataClassDependency> c) => c.CheckCompatibility(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.oldDependency, CS_0024_003C_003E8__locals0.newDependency)));
			}
		}
		return list;
	}

	private List<string> CheckFunctions(ICollection<FunctionDependency> old, ICollection<FunctionDependency> @new)
	{
		Dictionary<Guid, FunctionDependency> dictionary = @new.ToDictionary((FunctionDependency d) => d.HeaderUid, (FunctionDependency d) => d);
		List<string> list = new List<string>();
		using IEnumerator<FunctionDependency> enumerator = old.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
			_003C_003Ec__DisplayClass6_.oldDependency = enumerator.Current;
			_003C_003Ec__DisplayClass6_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass6_;
			if (!dictionary.TryGetValue(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.oldDependency.HeaderUid, out CS_0024_003C_003E8__locals0.newDependency))
			{
				list.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -282046914), CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.oldDependency.Name));
			}
			else
			{
				list.AddRange(functionCheckers.SelectMany((ICompatibilityChecker<FunctionDependency> c) => c.CheckCompatibility(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.oldDependency, CS_0024_003C_003E8__locals0.newDependency)));
			}
		}
		return list;
	}

	private List<string> CheckComponents(ICollection<ComponentSignature> old, ICollection<ComponentSignature> @new)
	{
		List<string> list = new List<string>();
		Dictionary<Guid, ComponentSignature> dictionary = @new.ToDictionary((ComponentSignature c) => c.HeaderUid, (ComponentSignature c) => c);
		using IEnumerator<ComponentSignature> enumerator = old.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
			_003C_003Ec__DisplayClass7_.oldComponent = enumerator.Current;
			_003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass7_;
			if (!dictionary.TryGetValue(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.oldComponent.HeaderUid, out CS_0024_003C_003E8__locals0.newComponent))
			{
				list.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B3589F5), CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.oldComponent.Name));
			}
			else
			{
				list.AddRange(componentCheckers.SelectMany((ICompatibilityChecker<ComponentSignature> c) => c.CheckCompatibility(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.oldComponent, CS_0024_003C_003E8__locals0.newComponent)));
			}
		}
		return list;
	}
}
