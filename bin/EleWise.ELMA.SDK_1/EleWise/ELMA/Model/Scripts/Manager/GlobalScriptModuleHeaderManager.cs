// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Manager.GlobalScriptModuleHeaderManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts.Manager
{
  public class GlobalScriptModuleHeaderManager : EntityManager<IGlobalScriptModuleHeader, long>
  {
    private readonly string headerPublished;
    private readonly string assemblyStatus;
    private readonly string assemblyName;
    private readonly string headerNamespace;
    internal static GlobalScriptModuleHeaderManager eQuWiBbnptDKtvmKIfb3;

    /// <summary>Провайдер преобразования БД</summary>
    public ITransformationProvider TransformationProvider
    {
      get => this.\u003CTransformationProvider\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CTransformationProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Менеджер процессов</summary>
    public GlobalScriptModuleManager GlobalScriptModuleManager => Locator.GetServiceNotNull<GlobalScriptModuleManager>();

    /// <summary>Экземпляр менеджера</summary>
    public static GlobalScriptModuleHeaderManager Instance => Locator.GetServiceNotNull<GlobalScriptModuleHeaderManager>();

    /// <inheritdoc />
    public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
    {
      int num = 7;
      while (true)
      {
        IGlobalScriptModuleHeaderFilter moduleHeaderFilter;
        DetachedCriteria detachedCriteria;
        switch (num)
        {
          case 1:
            detachedCriteria = ((DetachedCriteria) GlobalScriptModuleHeaderManager.Y2g6LgbnHlVVrBuRORRv(GlobalScriptModuleHeaderManager.tFJmccbn4y6rDMk8sv3N(InterfaceActivator.TypeOf<AssemblyModelsMetadata>()), GlobalScriptModuleHeaderManager.fqARP6bn6Tr9WWwE2qOP((object) this.assemblyStatus, (object) AssemblyModelsMetadataStatus.GlobalModule))).SetProjection((IProjection) GlobalScriptModuleHeaderManager.E36INLbnAOTqR3wlKan1((object) this.assemblyName));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 6 : 9;
            continue;
          case 2:
            if (!GlobalScriptModuleHeaderManager.QrYk8qbntc2FnIjoid8X((object) moduleHeaderFilter))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 3;
              continue;
            }
            break;
          case 3:
          case 10:
            if (moduleHeaderFilter.LoadedOnly)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
              continue;
            }
            goto label_12;
          case 4:
            goto label_13;
          case 5:
            goto label_2;
          case 6:
            moduleHeaderFilter = filter as IGlobalScriptModuleHeaderFilter;
            num = 8;
            continue;
          case 7:
            base.SetupFilter(criteria, filter);
            num = 6;
            continue;
          case 8:
            if (moduleHeaderFilter == null)
            {
              num = 4;
              continue;
            }
            goto case 2;
          case 9:
            GlobalScriptModuleHeaderManager.ABrLL8bnx3hZhSlCQsaD((object) criteria, GlobalScriptModuleHeaderManager.rqjJLLbn7XWwGQgTfFoc((object) this.headerNamespace, (object) detachedCriteria));
            num = 5;
            continue;
        }
        criteria.Add((ICriterion) GlobalScriptModuleHeaderManager.Nfd4OWbnwmwZm9gdq7GA((object) this.headerPublished));
        num = 10;
      }
label_13:
      return;
label_2:
      return;
label_12:;
    }

    public virtual IEnumerable<IGlobalScriptModuleHeader> LoadRuntimeLoadedHeaders()
    {
      IGlobalScriptModuleHeaderFilter filter = InterfaceActivator.Create<IGlobalScriptModuleHeaderFilter>();
      filter.Deleted = new bool?(false);
      filter.PublishedOnly = true;
      filter.LoadedOnly = true;
      return (IEnumerable<IGlobalScriptModuleHeader>) this.Find((IEntityFilter) filter, (FetchOptions) null);
    }

    /// <summary>
    /// Проверить, можно ли использовать указанное имя пользовательского расширения
    /// </summary>
    /// <param name="id">Id пользовательского расширения. Если ПР новое, то 0</param>
    /// <param name="name">Имя пользовательского расширения</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns>True, если имя использовать можно</returns>
    public virtual bool CheckGlobalScriptModuleName(long id, string name, out string errorMessage)
    {
      int num = 3;
      ICriteria criteria;
      while (true)
      {
        switch (num)
        {
          case 1:
            criteria = ((ICriteria) GlobalScriptModuleHeaderManager.q1NRYXbnJBn0WfyOW3Vo((object) this, (object) null)).Add((ICriterion) GlobalScriptModuleHeaderManager.YFus6vbn9HDXUqTHNK2E((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786890868), (object) name));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 6 : 0;
            continue;
          case 2:
            if (!GlobalScriptModuleHeaderManager.rcX8XNbnye28oVt19ATh(GlobalScriptModuleHeaderManager.PRclmdbnmUmRH3UFUdiF((object) name), (object) string.Empty))
            {
              num = 5;
              continue;
            }
            goto case 8;
          case 3:
            if (!GlobalScriptModuleHeaderManager.UjuXu6bn0pbaTgW95DUL((object) name))
            {
              num = 2;
              continue;
            }
            goto case 8;
          case 4:
            errorMessage = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813455157));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
            continue;
          case 5:
            errorMessage = string.Empty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
            continue;
          case 6:
            if (id > 0L)
            {
              num = 7;
              continue;
            }
            goto case 10;
          case 7:
            GlobalScriptModuleHeaderManager.ABrLL8bnx3hZhSlCQsaD((object) criteria, GlobalScriptModuleHeaderManager.JkaQm0bndn4FK7965Qc4(GlobalScriptModuleHeaderManager.fqARP6bn6Tr9WWwE2qOP(GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(-1290212282 ^ -644262414 ^ 1786853610), (object) id)));
            num = 10;
            continue;
          case 8:
            errorMessage = EleWise.ELMA.SR.T((string) GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(272623989 ^ 272441809));
            num = 9;
            continue;
          case 9:
            goto label_7;
          case 10:
            if (GlobalScriptModuleHeaderManager.BW9xgfbnlMlvCxqWA2Q5((object) this, (object) criteria))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 4 : 4;
              continue;
            }
            goto label_15;
          default:
            goto label_14;
        }
      }
label_7:
      return false;
label_14:
      return false;
label_15:
      return true;
    }

    /// <summary>
    /// Проверить, можно ли использовать указанное имя пользовательского расширения
    /// </summary>
    /// <param name="id">Id заголовка пользовательского расширения. Если пользовательское расширение новое, то 0</param>
    /// <param name="name">Имя пользовательского расширения</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns>True, если имя использовать можно</returns>
    public virtual bool CheckGlobalScriptModuleClassName(
      long id,
      string name,
      out string errorMessage)
    {
      int num = 11;
      while (true)
      {
        ICriteria criteria;
        switch (num)
        {
          case 1:
          case 12:
            if (!GlobalScriptModuleHeaderManager.BW9xgfbnlMlvCxqWA2Q5((object) this, (object) criteria))
            {
              num = 6;
              continue;
            }
            break;
          case 2:
          case 10:
            errorMessage = EleWise.ELMA.SR.T((string) GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(993438473 ^ 993289133));
            num = 9;
            continue;
          case 3:
            goto label_2;
          case 4:
            errorMessage = string.Empty;
            num = 5;
            continue;
          case 5:
            criteria = (ICriteria) GlobalScriptModuleHeaderManager.ABrLL8bnx3hZhSlCQsaD(GlobalScriptModuleHeaderManager.UdTY20bnrMo4y0B1tXYs(GlobalScriptModuleHeaderManager.UdTY20bnrMo4y0B1tXYs((object) this.CreateCriteria(), GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(1917256330 ^ 1917300598), GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(372753449 ^ 372575651)), GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(-1876063057 ^ -1875950281), GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(322893104 - -1992822529 ^ -1979331187)), GlobalScriptModuleHeaderManager.YFus6vbn9HDXUqTHNK2E(GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(2045296739 + 1688595713 ^ -561224526), (object) name));
            num = 8;
            continue;
          case 6:
            goto label_3;
          case 7:
            GlobalScriptModuleHeaderManager.ABrLL8bnx3hZhSlCQsaD((object) criteria, GlobalScriptModuleHeaderManager.JkaQm0bndn4FK7965Qc4(GlobalScriptModuleHeaderManager.fqARP6bn6Tr9WWwE2qOP(GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(92412609 - 1050237057 ^ -957856994), (object) id)));
            num = 12;
            continue;
          case 8:
            if (id <= 0L)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 0;
              continue;
            }
            goto case 7;
          case 9:
            goto label_15;
          case 11:
            if (GlobalScriptModuleHeaderManager.UjuXu6bn0pbaTgW95DUL((object) name))
            {
              num = 10;
              continue;
            }
            goto case 13;
          case 13:
            if (!GlobalScriptModuleHeaderManager.rcX8XNbnye28oVt19ATh((object) name.Trim(), (object) string.Empty))
            {
              num = 4;
              continue;
            }
            goto case 2;
        }
        errorMessage = EleWise.ELMA.SR.T((string) GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(1113862659 ^ 1114045433));
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 3 : 0;
      }
label_2:
      return false;
label_3:
      return true;
label_15:
      return false;
    }

    /// <summary>
    /// Проверить, можно ли использовать указанное имя для таблицы параметров пользовательского расширения
    /// </summary>
    /// <param name="id">Id заголовка пользовательского расширения. Если пользовательское расширение новое, то 0</param>
    /// <param name="name">Имя таблицы параметров пользовательского расширения</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns>True, если имя использовать можно</returns>
    public virtual bool CheckGlobalScriptModuleTableName(
      long id,
      string name,
      out string errorMessage)
    {
      int num = 7;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (!GlobalScriptModuleHeaderManager.rcX8XNbnye28oVt19ATh(GlobalScriptModuleHeaderManager.PRclmdbnmUmRH3UFUdiF((object) name), (object) string.Empty))
            {
              if (!GlobalScriptModuleHeaderManager.HxSHDUbnYI7XmLemN8Ji(GlobalScriptModuleHeaderManager.mgksgybnj7MrkP1hWJlE((object) this.TransformationProvider), (object) name))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 7 : 9;
                continue;
              }
              break;
            }
            num = 4;
            continue;
          case 3:
            goto label_14;
          case 4:
          case 5:
            errorMessage = (string) GlobalScriptModuleHeaderManager.f9HkGHbn5iD0dGSgWlTH(GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(1012087039 ^ 1012002907));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 1;
            continue;
          case 6:
            if (string.IsNullOrEmpty(name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 5 : 5;
              continue;
            }
            goto case 2;
          case 7:
            GlobalScriptModuleHeaderManager.TWhwk2bngmqHq6HSJlLo((object) this.TransformationProvider, GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(647913418 ^ 647796078));
            num = 6;
            continue;
          case 8:
            goto label_4;
          case 9:
            errorMessage = string.Empty;
            num = 3;
            continue;
        }
        errorMessage = (string) GlobalScriptModuleHeaderManager.f9HkGHbn5iD0dGSgWlTH((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606733368));
        num = 8;
      }
label_4:
      return false;
label_6:
      return false;
label_14:
      return true;
    }

    public override ExportRuleList ExportRules()
    {
      int num = 5;
      ExportRuleList exportRuleList1;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            ExportRuleList exportRuleList2 = exportRuleList1;
            ExportRule exportRule1 = new ExportRule();
            GlobalScriptModuleHeaderManager.nINSEZbnUoPM3v2rtxkQ((object) exportRule1, type);
            ExportRule exportRule2 = exportRule1;
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = (ParameterExpression) GlobalScriptModuleHeaderManager.JcGLF5bncy7KoK0cv1ZY(GlobalScriptModuleHeaderManager.JR1mfUbnsXNYqpbZOtka(__typeref (IGlobalScriptModuleHeader)), GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(-1710575414 ^ -1710613378));
            // ISSUE: method reference
            string str1 = LinqUtils.NameOf<IGlobalScriptModuleHeader>(System.Linq.Expressions.Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((System.Linq.Expressions.Expression) GlobalScriptModuleHeaderManager.VZYI1cbOFIYULGmlKWws((object) parameterExpression1, (object) (MethodInfo) GlobalScriptModuleHeaderManager.zhtfuQbnzhinfd4yFxox(__methodref (IGlobalScriptModuleHeader.get_Draft))), parameterExpression1));
            GlobalScriptModuleHeaderManager.FgL7pvbOWV3MPxawRZVB((object) exportRule2, (object) str1);
            GlobalScriptModuleHeaderManager.eltPQsbOBmL5lH0xBUe0((object) exportRule1, ExportRuleType.Export);
            ExportRule exportRule3 = exportRule1;
            exportRuleList2.Add(exportRule3);
            num = 3;
            continue;
          case 3:
            ExportRuleList exportRuleList3 = exportRuleList1;
            ExportRule exportRule4 = new ExportRule();
            GlobalScriptModuleHeaderManager.nINSEZbnUoPM3v2rtxkQ((object) exportRule4, type);
            ExportRule exportRule5 = exportRule4;
            // ISSUE: type reference
            ParameterExpression parameterExpression2 = (ParameterExpression) GlobalScriptModuleHeaderManager.JcGLF5bncy7KoK0cv1ZY(GlobalScriptModuleHeaderManager.JR1mfUbnsXNYqpbZOtka(__typeref (IGlobalScriptModuleHeader)), GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(864270449 << 6 ^ -521228044));
            // ISSUE: method reference
            string str2 = LinqUtils.NameOf<IGlobalScriptModuleHeader>(System.Linq.Expressions.Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) parameterExpression2, (MethodInfo) GlobalScriptModuleHeaderManager.zhtfuQbnzhinfd4yFxox(__methodref (IGlobalScriptModuleHeader.get_Name))), parameterExpression2));
            GlobalScriptModuleHeaderManager.FgL7pvbOWV3MPxawRZVB((object) exportRule5, (object) str2);
            exportRule4.ExportRuleType = ExportRuleType.Export;
            ExportRule exportRule6 = exportRule4;
            exportRuleList3.Add(exportRule6);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 6 : 6;
            continue;
          case 4:
            exportRuleList1 = new ExportRuleList();
            num = 7;
            continue;
          case 5:
            type = GlobalScriptModuleHeaderManager.G1J3oUbnLYquVKXEI0TE((object) this);
            num = 4;
            continue;
          case 6:
            ExportRuleList exportRuleList4 = exportRuleList1;
            ExportRule exportRule7 = new ExportRule();
            exportRule7.ParentType = type;
            ExportRule exportRule8 = exportRule7;
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = (ParameterExpression) GlobalScriptModuleHeaderManager.JcGLF5bncy7KoK0cv1ZY(GlobalScriptModuleHeaderManager.JR1mfUbnsXNYqpbZOtka(__typeref (IGlobalScriptModuleHeader)), GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(87862435 ^ 87818263));
            // ISSUE: method reference
            string str3 = LinqUtils.NameOf<IGlobalScriptModuleHeader>(System.Linq.Expressions.Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) parameterExpression3, (MethodInfo) GlobalScriptModuleHeaderManager.zhtfuQbnzhinfd4yFxox(__methodref (IGlobalScriptModuleHeader.get_Namespace))), parameterExpression3));
            GlobalScriptModuleHeaderManager.FgL7pvbOWV3MPxawRZVB((object) exportRule8, (object) str3);
            GlobalScriptModuleHeaderManager.eltPQsbOBmL5lH0xBUe0((object) exportRule7, ExportRuleType.Export);
            ExportRule exportRule9 = exportRule7;
            exportRuleList4.Add(exportRule9);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          case 7:
            ExportRuleList exportRuleList5 = exportRuleList1;
            ExportRule exportRule10 = new ExportRule();
            GlobalScriptModuleHeaderManager.nINSEZbnUoPM3v2rtxkQ((object) exportRule10, type);
            ExportRule exportRule11 = exportRule10;
            // ISSUE: type reference
            ParameterExpression parameterExpression4 = (ParameterExpression) GlobalScriptModuleHeaderManager.JcGLF5bncy7KoK0cv1ZY(GlobalScriptModuleHeaderManager.JR1mfUbnsXNYqpbZOtka(__typeref (IGlobalScriptModuleHeader)), GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(-2112703338 ^ -2112743390));
            // ISSUE: method reference
            string str4 = LinqUtils.NameOf<IGlobalScriptModuleHeader>(System.Linq.Expressions.Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((System.Linq.Expressions.Expression) GlobalScriptModuleHeaderManager.VZYI1cbOFIYULGmlKWws((object) parameterExpression4, (object) (MethodInfo) GlobalScriptModuleHeaderManager.zhtfuQbnzhinfd4yFxox(__methodref (IGlobalScriptModuleHeader.get_Description))), parameterExpression4));
            exportRule11.PropertyName = str4;
            GlobalScriptModuleHeaderManager.eltPQsbOBmL5lH0xBUe0((object) exportRule10, ExportRuleType.Export);
            ExportRule exportRule12 = exportRule10;
            exportRuleList5.Add(exportRule12);
            num = 2;
            continue;
          default:
            ExportRuleList exportRuleList6 = exportRuleList1;
            ExportRule exportRule13 = new ExportRule();
            GlobalScriptModuleHeaderManager.nINSEZbnUoPM3v2rtxkQ((object) exportRule13, type);
            ExportRule exportRule14 = exportRule13;
            // ISSUE: type reference
            ParameterExpression parameterExpression5 = (ParameterExpression) GlobalScriptModuleHeaderManager.JcGLF5bncy7KoK0cv1ZY(GlobalScriptModuleHeaderManager.JR1mfUbnsXNYqpbZOtka(__typeref (IGlobalScriptModuleHeader)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108006230));
            // ISSUE: method reference
            // ISSUE: type reference
            string str5 = LinqUtils.NameOf<IGlobalScriptModuleHeader>(System.Linq.Expressions.Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((System.Linq.Expressions.Expression) GlobalScriptModuleHeaderManager.GgvJVVbOo3FdjBy6panG(GlobalScriptModuleHeaderManager.VZYI1cbOFIYULGmlKWws((object) parameterExpression5, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IGlobalScriptModuleHeader.get_Uid))), GlobalScriptModuleHeaderManager.JR1mfUbnsXNYqpbZOtka(__typeref (object))), parameterExpression5));
            exportRule14.PropertyName = str5;
            GlobalScriptModuleHeaderManager.eltPQsbOBmL5lH0xBUe0((object) exportRule13, ExportRuleType.Export);
            ExportRule exportRule15 = exportRule13;
            exportRuleList6.Add(exportRule15);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 1;
            continue;
        }
      }
label_2:
      return exportRuleList1;
    }

    /// <summary>Получить содержимое сборки глобального модуля</summary>
    /// <param name="headerUid">Идентификатор заголовка глобального модуля</param>
    /// <returns>Скомпилированное содержимое сборки глобального модуля</returns>
    public byte[] GetAssemblyRaw(Guid headerUid)
    {
      int num = 3;
      IGlobalScriptModuleHeader scriptModuleHeader;
      IGlobalScriptModule globalScriptModule;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (scriptModuleHeader == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
              continue;
            }
            goto case 4;
          case 3:
            scriptModuleHeader = this.LoadOrNull(headerUid);
            num = 2;
            continue;
          case 4:
            if (scriptModuleHeader.Published != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 5 : 5;
              continue;
            }
            goto label_5;
          case 5:
            globalScriptModule = this.GlobalScriptModuleManager.LoadOrNull(((IEntity<long>) GlobalScriptModuleHeaderManager.FqUHcnbObRp2NWlnFiNH((object) scriptModuleHeader)).Id);
            num = 6;
            continue;
          case 6:
            if (globalScriptModule != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (byte[]) GlobalScriptModuleHeaderManager.sdilkrbOhadC05PS4OVo((object) globalScriptModule.ScriptModule);
label_5:
      return (byte[]) null;
    }

    public GlobalScriptModuleHeaderManager()
    {
      GlobalScriptModuleHeaderManager.Cx26VtbOG9HJZqGXvKWg();
      this.headerPublished = (string) GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(1461625753 ^ 1461509379);
      this.assemblyStatus = (string) GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(572119659 - -337058038 ^ 909144807);
      this.assemblyName = (string) GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(1654249598 >> 2 ^ 413533663);
      this.headerNamespace = (string) GlobalScriptModuleHeaderManager.im3aaEbnMRmTVLfZxexZ(1033719030 - 2012070891 ^ -978448569);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool RfTnUKbnaGaC1RTAQ249() => GlobalScriptModuleHeaderManager.eQuWiBbnptDKtvmKIfb3 == null;

    internal static GlobalScriptModuleHeaderManager DpA9mdbnDnkUWfFiTqsB() => GlobalScriptModuleHeaderManager.eQuWiBbnptDKtvmKIfb3;

    internal static bool QrYk8qbntc2FnIjoid8X([In] object obj0) => ((IGlobalScriptModuleHeaderFilter) obj0).PublishedOnly;

    internal static object Nfd4OWbnwmwZm9gdq7GA([In] object obj0) => (object) Restrictions.IsNotNull((string) obj0);

    internal static object tFJmccbn4y6rDMk8sv3N([In] Type obj0) => (object) DetachedCriteria.For(obj0);

    internal static object fqARP6bn6Tr9WWwE2qOP([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object Y2g6LgbnHlVVrBuRORRv([In] object obj0, [In] object obj1) => (object) ((DetachedCriteria) obj0).Add((ICriterion) obj1);

    internal static object E36INLbnAOTqR3wlKan1([In] object obj0) => (object) Projections.Property((string) obj0);

    internal static object rqjJLLbn7XWwGQgTfFoc([In] object obj0, [In] object obj1) => (object) Subqueries.PropertyIn((string) obj0, (DetachedCriteria) obj1);

    internal static object ABrLL8bnx3hZhSlCQsaD([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static bool UjuXu6bn0pbaTgW95DUL([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object PRclmdbnmUmRH3UFUdiF([In] object obj0) => (object) ((string) obj0).Trim();

    internal static bool rcX8XNbnye28oVt19ATh([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

    internal static object im3aaEbnMRmTVLfZxexZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object q1NRYXbnJBn0WfyOW3Vo([In] object obj0, [In] object obj1) => (object) ((EntityManager<IGlobalScriptModuleHeader, long>) obj0).CreateCriteria((IEntityFilter) obj1);

    internal static object YFus6vbn9HDXUqTHNK2E([In] object obj0, [In] object obj1) => (object) ElmaRestrictions.InsensitiveLike((string) obj0, obj1);

    internal static object JkaQm0bndn4FK7965Qc4([In] object obj0) => (object) Restrictions.Not((ICriterion) obj0);

    internal static bool BW9xgfbnlMlvCxqWA2Q5([In] object obj0, [In] object obj1) => ((EntityManager<IGlobalScriptModuleHeader, long>) obj0).ReturnExists((ICriteria) obj1);

    internal static object UdTY20bnrMo4y0B1tXYs([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ICriteria) obj0).CreateAlias((string) obj1, (string) obj2);

    internal static void TWhwk2bngmqHq6HSJlLo([In] object obj0, [In] object obj1) => Contract.ServiceNotNull(obj0, (string) obj1);

    internal static object f9HkGHbn5iD0dGSgWlTH([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object mgksgybnj7MrkP1hWJlE([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static bool HxSHDUbnYI7XmLemN8Ji([In] object obj0, [In] object obj1) => ((Dialect) obj0).IsReservedWord((string) obj1);

    internal static Type G1J3oUbnLYquVKXEI0TE([In] object obj0) => ((EntityManager<IGlobalScriptModuleHeader, long>) obj0).ImplementationType;

    internal static void nINSEZbnUoPM3v2rtxkQ([In] object obj0, Type value) => ((ExportRule) obj0).ParentType = value;

    internal static Type JR1mfUbnsXNYqpbZOtka([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object JcGLF5bncy7KoK0cv1ZY([In] Type obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Parameter(obj0, (string) obj1);

    internal static object zhtfuQbnzhinfd4yFxox([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object VZYI1cbOFIYULGmlKWws([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) obj0, (MethodInfo) obj1);

    internal static void eltPQsbOBmL5lH0xBUe0([In] object obj0, ExportRuleType value) => ((ExportRule) obj0).ExportRuleType = value;

    internal static void FgL7pvbOWV3MPxawRZVB([In] object obj0, [In] object obj1) => ((ExportRule) obj0).PropertyName = (string) obj1;

    internal static object GgvJVVbOo3FdjBy6panG([In] object obj0, [In] Type obj1) => (object) System.Linq.Expressions.Expression.Convert((System.Linq.Expressions.Expression) obj0, obj1);

    internal static object FqUHcnbObRp2NWlnFiNH([In] object obj0) => (object) ((IGlobalScriptModuleHeader) obj0).Published;

    internal static object sdilkrbOhadC05PS4OVo([In] object obj0) => (object) ((ScriptModule) obj0).AssemblyRaw;

    internal static void Cx26VtbOG9HJZqGXvKWg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
