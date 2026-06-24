using System;
using Bridge;

namespace EleWise.ELMA.TestFramework.Helpers;

internal static class QUnitHelper
{
	[ObjectLiteral]
	internal class ModuleHooks
	{
		private Union<Action, Func<Promise>> _003CBefore_003Ek__BackingField;

		private Action _003CBeforeEach_003Ek__BackingField;

		private Action _003CAfterEach_003Ek__BackingField;

		private Union<Action, Func<Promise>> _003CAfter_003Ek__BackingField;

		[Name("before")]
		public Union<Action, Func<Promise>> Before
		{
			get
			{
				return _003CBefore_003Ek__BackingField;
			}
			set
			{
				_003CBefore_003Ek__BackingField = value;
			}
		}

		[Name("beforeEach")]
		public Action BeforeEach
		{
			get
			{
				return _003CBeforeEach_003Ek__BackingField;
			}
			set
			{
				_003CBeforeEach_003Ek__BackingField = value;
			}
		}

		[Name("afterEach")]
		public Action AfterEach
		{
			get
			{
				return _003CAfterEach_003Ek__BackingField;
			}
			set
			{
				_003CAfterEach_003Ek__BackingField = value;
			}
		}

		[Name("after")]
		public Union<Action, Func<Promise>> After
		{
			get
			{
				return _003CAfter_003Ek__BackingField;
			}
			set
			{
				_003CAfter_003Ek__BackingField = value;
			}
		}
	}

	[Template("QUnit.module({name}, {callback})")]
	public static extern void Module(string name, Action<ModuleHooks> callback);

	[Template("QUnit.module({name}, {hooks})")]
	public static extern void Module(string name, ModuleHooks hooks);

	[Template("QUnit.module({name}, {hooks}, {callback})")]
	public static extern void Module(string name, ModuleHooks hooks, Action callback);

	[Template("QUnit.module.skip({name})")]
	public static extern void SkipModule(string name);

	[Template("qunitLoader()")]
	internal static extern void Load();
}
