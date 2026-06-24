namespace EleWise.ELMA.BridgeCompiler.JavaScriptParser;

public static class Constants
{
	public static class Symbols
	{
		public const string BracePos = "(";

		public const string BraceNeg = ")";
	}

	public static class Js
	{
		public const string Define = "define";

		public const string Require = "require";

		public const string Factory = "factory";

		public const string Root = "root";

		public const string This = "this";

		public const string ThisDOTNAME = "this.";
	}

	public static class Bridge
	{
		public static class NS
		{
			public static class Funcs
			{
				public new const string Equals = "Bridge.equals";
			}

			public const string Bridge = "Bridge";

			public const string DOTNAME = "Bridge.";

			public const string Assembly = "assembly";

			public const string Define = "define";
		}

		internal class Ops
		{
			public const string CAST = "cast";

			public const string AS = "as";

			public const string IS = "is";
		}

		public const string SourceMapStart = "/*##|";

		public const string SourceMapStartImportant = "/*!##|";

		public const string SourceMapEnd = "|##*/";

		public const string AsyncBodyFunc = "$asyncBody();";

		public const string AsyncBody = "$asyncBody";

		public const string Generic = "$";
	}

	public static class CoreModule
	{
		public static class ProxyGenerator
		{
			public const string GenerateProxy = "EleWise_ELMA_Core.EleWise.ELMA.DTO.ProxyGeneratorService.GetProxyGeneratorService(this).GenerateProxyByStringUid";
		}

		public const string ContextName = "Context";

		public const string ControllerName = "Controller";

		public const string ContextClassName = "_Context";

		public const string ViewModelContextClassName = "ViewModelContext";

		public const string ElmaCore = "EleWise_ELMA_Core";

		public const string ElmaCoreReact = "EleWise_ELMA_Core_React";

		public const string CoreReactDOTNAME = "EleWise_ELMA_Core_React.";

		public const string EmptyModule = "_EmptyModule";

		public const string Reactive = "Reactive";

		public const string TestFramework = "EleWise_ELMA_TestFramework";

		public const string TestDOTNAME = "EleWise_ELMA_TestFramework.";

		public static readonly string MobxAsyncActionFunc = "if(mobx._getGlobalState().allowStateChanges){$asyncBody=mobx.action($asyncBody);}$asyncBody();";

		public const string DOTNAME = "EleWise_ELMA_Core.";
	}

	public static class NS
	{
		public static class ELMA
		{
			public static class Common
			{
				public static class Models
				{
					public const string DOTNAME = "EleWise.ELMA.Common.";

					public const string NS = "EleWise.ELMA.Common.Models";

					public const string EnumWrapper = "EleWise.ELMA.Common.Models.EnumWrapper";
				}

				public const string DOTNAME = "EleWise.ELMA.";

				public const string NS = "EleWise.ELMA.Common";
			}

			public static class Core
			{
				public static class Controllers
				{
					public const string DOTNAME = "EleWise.ELMA.Core.";

					public const string NS = "EleWise.ELMA.Core.Controllers";

					public const string BaseController = "BaseController";

					public const string BaseController1 = "BaseController$1";

					public const string BaseController2 = "BaseController$2";

					public const string BaseCustomController2 = "BaseCustomController$2";

					public const string BaseCustomController1 = "BaseCustomController$1";

					public const string BaseController1NS = "EleWise.ELMA.Core.Controllers.BaseController$1";

					public const string BaseController2NS = "EleWise.ELMA.Core.Controllers.BaseController$2";

					public const string BaseCustomController2NS = "EleWise.ELMA.Core.Controllers.BaseCustomController$2";

					public const string ComponentController = "ComponentController";
				}

				public static class React
				{
					public const string DOTNAME = "EleWise.ELMA.Core.";

					public const string NS = "EleWise.ELMA.Core.React";

					public const string BaseCustomView = "BaseCustomView";

					public const string BaseCustomView1 = "BaseCustomView$1";

					public const string BaseCustomView2 = "BaseCustomView$2";

					public const string BaseCustomView1NS = "EleWise.ELMA.Core.React.Models.BaseCustomView$1";

					public const string BaseCustomView2NS = "EleWise.ELMA.Core.React.Models.BaseCustomView$2";
				}

				public const string DOTNAME = "EleWise.ELMA.";

				public const string NS = "EleWise.ELMA.Core";
			}

			public static class DTO
			{
				public static class DTOHelper
				{
					public const string DOTNAME = "EleWise.ELMA.DTO.";

					public const string NS = "EleWise.ELMA.DTO.DTOHelper";

					public const string ProxyCast = "EleWise.ELMA.DTO.DTOHelper.ProxyCast";

					public const string ProxyIs = "EleWise.ELMA.DTO.DTOHelper.ProxyIs";

					public const string ProxyAs = "EleWise.ELMA.DTO.DTOHelper.ProxyAs";

					public const string ProxyType = "EleWise.ELMA.DTO.DTOHelper.ProxyType";
				}

				public const string DOTNAME = "EleWise.ELMA.";

				public const string NS = "EleWise.ELMA.DTO";

				public const string ReactiveProxy = "EleWise.ELMA.DTO.ReactiveProxy";
			}

			public static class TestFramework
			{
				public static class TestBuilder
				{
					public const string When = "When";

					public const string Then = "Then";

					public const string And = "And";

					public const string Given = "Given";
				}

				public static class API
				{
					public const string DOTNAME = "EleWise.ELMA.TestFramework.";

					public const string FullNamespace = "EleWise.ELMA.TestFramework.API";

					public const string ComponentTest = "ComponentTest";

					public const string ComponentTest1 = "ComponentTest$2";

					public const string ComponentTest2 = "ComponentTest$3";

					public const string BaseController1NS = "EleWise.ELMA.TestFramework.API.ComponentTest$2";

					public const string BaseController2NS = "EleWise.ELMA.TestFramework.API.ComponentTest$3";

					public const string ComponentTestModel = "IComponentTestModel";

					public const string ComponentTestModel1 = "IComponentTestModel$1";

					public const string ComponentTestModel2 = "IComponentTestModel$2";
				}

				public const string DOTNAME = "EleWise.ELMA.";

				public const string FullNamespace = "EleWise.ELMA.TestFramework";
			}

			public const string DOTNAME = "EleWise.";

			public const string NS = "EleWise.ELMA";
		}

		public const string EleWise = "EleWise";
	}

	public const string Dot = ".";

	public const string Comma = ",";

	public const string emptyCallFunction = "emptyCallFunction()";
}
