// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.PageScriptExecutionHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services.Scope;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Scripts
{
  /// <summary>Выполнение скриптов страниц</summary>
  [Component]
  internal sealed class PageScriptExecutionHandler : IScriptExecutionHandler
  {
    private readonly FormDescriptorProvider formDescriptorProvider;
    private readonly IEnumerable<IObjectFormProvider> objectFormProviders;
    private readonly IExecutionScopeFactory executionScopeFactory;
    private static PageScriptExecutionHandler awU9ApYZdeDTkbKoxJw;

    /// <summary>Ctor</summary>
    /// <param name="formDescriptorProvider">Провайдер дескриптора форм</param>
    /// <param name="objectFormProviders">Провайдеры форм</param>
    /// <param name="executionScopeFactory">Фабрика для создания контекста выполнения</param>
    public PageScriptExecutionHandler(
      FormDescriptorProvider formDescriptorProvider,
      IEnumerable<IObjectFormProvider> objectFormProviders,
      IExecutionScopeFactory executionScopeFactory)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.formDescriptorProvider = formDescriptorProvider;
      this.objectFormProviders = objectFormProviders;
      this.executionScopeFactory = executionScopeFactory;
    }

    /// <inheritdoc />
    public bool Check(ScriptExecutionParams parameters) => PageScriptExecutionHandler.Dew06DYSVgqLgoI3hGr(PageScriptExecutionHandler.IqUeWiYVERjHsC1bmpF((object) parameters)) == PageMetadata.TypeUid;

    /// <inheritdoc />
    public ScriptExecutionResult ExecuteScript(ScriptExecutionParams parameters)
    {
      int num1 = 9;
      IExecutionScope executionScope;
      Type controllerType;
      string errorTitle;
      ScriptMethodInfo scriptMethodInfo;
      PageDescriptor pageDescriptor;
      PropertyViewInfoContainer viewInfoContainer;
      IEnumerator<PropertyViewInfo> enumerator;
      Type type;
      object obj;
      FormViewItem formViewItem;
      IObjectFormProvider objectFormProvider;
      ModelInfo modelInfo;
      MethodInfo method;
      object controllerInstance;
      IPageLoadViewModel viewModel;
      while (true)
      {
        switch (num1)
        {
          case 1:
            pageDescriptor = PageScriptExecutionHandler.CMUmTPYi2KJclVtUpFN((object) this.formDescriptorProvider, PageScriptExecutionHandler.Dew06DYSVgqLgoI3hGr((object) modelInfo), modelInfo.SubTypeUid, false) as PageDescriptor;
            num1 = 15;
            continue;
          case 2:
            viewModel = (IPageLoadViewModel) Activator.CreateInstance(type, PageScriptExecutionHandler.yyjfoYYk0wPts16F5yt((object) pageDescriptor), obj, (object) formViewItem, (object) viewInfoContainer);
            num1 = 14;
            continue;
          case 3:
            goto label_27;
          case 4:
            if (viewInfoContainer != null)
            {
              num1 = 7;
              continue;
            }
            goto label_29;
          case 5:
label_21:
            if (viewModel.Context == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 18 : 8;
              continue;
            }
            goto case 4;
          case 6:
            executionScope = ((IExecutionScopeBuilder) PageScriptExecutionHandler.mtcKTUY2sw2YlcKOGuH((object) this.executionScopeFactory)).AddRegistration(controllerType, Array.Empty<Type>()).StartScope();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
          case 7:
            enumerator = viewInfoContainer.GetAll().GetEnumerator();
            num1 = 16;
            continue;
          case 8:
            modelInfo = parameters.ModelInfo;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
            continue;
          case 9:
            num1 = 8;
            continue;
          case 10:
          case 18:
            goto label_29;
          case 11:
            // ISSUE: type reference
            type = PageScriptExecutionHandler.TCUFtQYTmF3ds9mTsfD(__typeref (PageLoadViewModel<>)).MakeGenericType(PageScriptExecutionHandler.tIfwwiYngHyaI7vuoAx(PageScriptExecutionHandler.yyjfoYYk0wPts16F5yt((object) pageDescriptor)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 21 : 16;
            continue;
          case 12:
label_33:
            if (controllerInstance == null)
            {
              num1 = 23;
              continue;
            }
            scriptMethodInfo = ScriptMethodInfoHelper.Deserialize(parameters.ScriptName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 17 : 13;
            continue;
          case 13:
            controllerType = pageDescriptor.ControllerType;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 6 : 3;
            continue;
          case 14:
            controllerInstance = (object) null;
            num1 = 13;
            continue;
          case 15:
            if (pageDescriptor != null)
            {
              // ISSUE: reference to a compiler-generated method
              objectFormProvider = this.objectFormProviders.FirstOrDefault<IObjectFormProvider>((Func<IObjectFormProvider, bool>) (provider => provider.Check(modelInfo.TypeUid, PageScriptExecutionHandler.\u003C\u003Ec__DisplayClass5_0.CjwjWnfYDCxugM51h1gR((object) modelInfo))));
              num1 = 20;
              continue;
            }
            num1 = 3;
            continue;
          case 16:
            goto label_39;
          case 17:
            method = (MethodInfo) PageScriptExecutionHandler.Dwq176Y1dDtBFYW49bw(controllerType, PageScriptExecutionHandler.Myhq4bYP4Pp3o00883d((object) scriptMethodInfo));
            num1 = 22;
            continue;
          case 19:
            try
            {
              ScriptExecutionService.ScriptExecution((System.Action) (() =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      PageScriptExecutionHandler.\u003C\u003Ec__DisplayClass5_0.ACfMtpfYt0RbR60m2HCK((object) method, controllerInstance, (object) new object[1]
                      {
                        (object) viewModel
                      });
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }), errorTitle);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  goto label_21;
              }
            }
            catch (Exception ex)
            {
              int num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
                num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    PageScriptExecutionHandler.NPFwSTYap4dTWjgCUkR(PageScriptExecutionHandler.OufXlAYpnCpwIxPF2L4(), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672072641), (object) scriptMethodInfo.Name, (object) controllerType), (object) ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_19;
                }
              }
label_19:
              throw;
            }
          case 20:
            if (objectFormProvider != null)
            {
              formViewItem = (FormViewItem) PageScriptExecutionHandler.tZNTbrYXyfNuXZlJVsM((object) objectFormProvider, (object) null, PageScriptExecutionHandler.OQP83sYRPwEUOLcJKA1((object) modelInfo));
              num1 = 11;
              continue;
            }
            num1 = 24;
            continue;
          case 21:
            (object, ClassMetadata) objectInfo = objectFormProvider.GetObjectInfo(PageScriptExecutionHandler.Dew06DYSVgqLgoI3hGr((object) modelInfo), modelInfo.SubTypeUid, (string) PageScriptExecutionHandler.WcXJGTYOssIE3jfu1ps((object) parameters));
            obj = objectInfo.Item1;
            viewInfoContainer = new PropertyViewInfoContainer(objectInfo.Item2);
            num1 = 2;
            continue;
          case 22:
            errorTitle = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740319698), PageScriptExecutionHandler.owwRXcY3VFkKj7rkYJT(PageScriptExecutionHandler.MIaWT4YNo1Krq1pWKSK((object) pageDescriptor)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 19;
            continue;
          case 23:
            goto label_63;
          case 24:
            goto label_25;
          default:
            try
            {
              controllerInstance = executionScope.Resolve(controllerType);
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
                num5 = 0;
              switch (num5)
              {
                default:
                  goto label_33;
              }
            }
            finally
            {
              if (executionScope != null)
              {
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_11;
                    default:
                      PageScriptExecutionHandler.h7L8tyYeMctaZCbohJB((object) executionScope);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 1;
                      continue;
                  }
                }
              }
label_11:;
            }
        }
      }
label_25:
      throw new Exception((string) PageScriptExecutionHandler.IZu6N6YKG1tsMEaIbXd(PageScriptExecutionHandler.QHtdLoYqLoMQ3jv4JZp(-1872275253 >> 6 ^ -29272371)));
label_27:
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1514975337), (object) PageScriptExecutionHandler.OQP83sYRPwEUOLcJKA1((object) modelInfo)));
label_29:
      ScriptExecutionResult scriptExecutionResult = new ScriptExecutionResult();
      PageScriptExecutionHandler.beW7IUY6kpa70wnvC8K((object) scriptExecutionResult, PageScriptExecutionHandler.vT8irDYDh0X2dgPqeVn((object) viewModel));
      PageScriptExecutionHandler.l9Uu0DYHYgdhYk6RyQO((object) scriptExecutionResult, (object) viewInfoContainer);
      return scriptExecutionResult;
label_39:
      try
      {
label_45:
        if (PageScriptExecutionHandler.jlQ5qVY45LLWyyRiOV8((object) enumerator))
          goto label_47;
        else
          goto label_46;
label_40:
        PropertyViewInfo current;
        TypeSettings typeSettings;
        int num7;
        while (true)
        {
          switch (num7)
          {
            case 1:
              typeSettings = (TypeSettings) PageScriptExecutionHandler.zmWOkCYtStLDu2YcLc7(PageScriptExecutionHandler.vT8irDYDh0X2dgPqeVn((object) viewModel), current.Uid);
              num7 = 6;
              continue;
            case 2:
              goto label_47;
            case 3:
            case 5:
              goto label_45;
            case 4:
              PageScriptExecutionHandler.iudd6sYwnZbeq75pOZw((object) current, (object) typeSettings);
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 3 : 0;
              continue;
            case 6:
              if (typeSettings == null)
              {
                num7 = 5;
                continue;
              }
              goto case 4;
            default:
              goto label_29;
          }
        }
label_46:
        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
        goto label_40;
label_47:
        current = enumerator.Current;
        num7 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        {
          num7 = 0;
          goto label_40;
        }
        else
          goto label_40;
      }
      finally
      {
        int num8;
        if (enumerator == null)
          num8 = 2;
        else
          goto label_52;
label_51:
        switch (num8)
        {
          case 1:
            break;
          default:
        }
label_52:
        PageScriptExecutionHandler.h7L8tyYeMctaZCbohJB((object) enumerator);
        num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
        {
          num8 = 0;
          goto label_51;
        }
        else
          goto label_51;
      }
label_63:
      return (ScriptExecutionResult) null;
    }

    internal static object IqUeWiYVERjHsC1bmpF([In] object obj0) => (object) ((ScriptExecutionParams) obj0).ModelInfo;

    internal static Guid Dew06DYSVgqLgoI3hGr([In] object obj0) => ((ModelInfo) obj0).TypeUid;

    internal static bool TdG1iHYusdCitRdIvjN() => PageScriptExecutionHandler.awU9ApYZdeDTkbKoxJw == null;

    internal static PageScriptExecutionHandler SMSr44YIJqmKDGREyRL() => PageScriptExecutionHandler.awU9ApYZdeDTkbKoxJw;

    internal static object CMUmTPYi2KJclVtUpFN(
      [In] object obj0,
      Guid metadataType,
      Guid headerUid,
      bool forEmulation)
    {
      return (object) ((FormDescriptorProvider) obj0).GetDescriptorByHeaderUid(metadataType, headerUid, forEmulation);
    }

    internal static Guid OQP83sYRPwEUOLcJKA1([In] object obj0) => ((ModelInfo) obj0).SubTypeUid;

    internal static object QHtdLoYqLoMQ3jv4JZp(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object IZu6N6YKG1tsMEaIbXd([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object tZNTbrYXyfNuXZlJVsM([In] object obj0, [In] object obj1, Guid formUid) => (object) ((IObjectFormProvider) obj0).GetFormByUid(obj1, formUid);

    internal static Type TCUFtQYTmF3ds9mTsfD([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object yyjfoYYk0wPts16F5yt([In] object obj0) => (object) ((PageDescriptor) obj0).Content;

    internal static Type tIfwwiYngHyaI7vuoAx([In] object obj0) => ((FormPartDescriptor<PageDescriptor, PageContentMetadata>) obj0).ContextType;

    internal static object WcXJGTYOssIE3jfu1ps([In] object obj0) => (object) ((ScriptExecutionParams) obj0).Model;

    internal static object mtcKTUY2sw2YlcKOGuH([In] object obj0) => (object) ((IExecutionScopeFactory) obj0).CreateScope();

    internal static void h7L8tyYeMctaZCbohJB([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object Myhq4bYP4Pp3o00883d([In] object obj0) => (object) ((ScriptMethodInfo) obj0).Name;

    internal static object Dwq176Y1dDtBFYW49bw(Type type, [In] object obj1) => (object) ScriptHelper.GetMethodInfo(type, (string) obj1);

    internal static object MIaWT4YNo1Krq1pWKSK([In] object obj0) => (object) ((FormDescriptor) obj0).Metadata;

    internal static object owwRXcY3VFkKj7rkYJT([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object OufXlAYpnCpwIxPF2L4() => (object) EleWise.ELMA.Logging.Logger.Log;

    internal static void NPFwSTYap4dTWjgCUkR([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object vT8irDYDh0X2dgPqeVn([In] object obj0) => (object) ((IFormViewModel) obj0).Context;

    internal static object zmWOkCYtStLDu2YcLc7([In] object obj0, Guid propertyUid) => (object) ((IEntity) obj0).LoadPropertyInstanceSettings(propertyUid);

    internal static void iudd6sYwnZbeq75pOZw([In] object obj0, [In] object obj1) => ((PropertyViewInfo) obj0).Settings = (TypeSettings) obj1;

    internal static bool jlQ5qVY45LLWyyRiOV8([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void beW7IUY6kpa70wnvC8K([In] object obj0, [In] object obj1) => ((ScriptExecutionResult) obj0).Model = obj1;

    internal static void l9Uu0DYHYgdhYk6RyQO([In] object obj0, [In] object obj1) => ((ScriptExecutionResult) obj0).PropertyContainer = (PropertyViewInfoContainer) obj1;
  }
}
