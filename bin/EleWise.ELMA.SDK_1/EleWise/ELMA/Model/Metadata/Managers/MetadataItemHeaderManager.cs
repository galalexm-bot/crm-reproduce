// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.MetadataItemHeaderManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  public class MetadataItemHeaderManager : EntityManager<IMetadataItemHeader, long>
  {
    /// <summary>
    /// Название поля в таблице заголовков элементов метаданных, соответствующее свойству "Уникальный идентификатор"
    /// </summary>
    private readonly string uidFiledName;
    internal static MetadataItemHeaderManager tZIskLhF070OHhBNFgcH;

    /// <summary>
    /// Загрузить список заголовков элементов метаданных по списку их уникальных идентификаторов
    /// </summary>
    /// <param name="uids">Список уникальных идентификаторов заголовков элементов метаданных</param>
    /// <returns>Список заголовков элементов метаданных</returns>
    public virtual IEnumerable<IMetadataItemHeader> Load(IEnumerable<Guid> uids)
    {
      Contract.ArgumentNotNull((object) uids, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867000999));
      return (IEnumerable<IMetadataItemHeader>) this.CreateCriteria().Add((ICriterion) Restrictions.In(this.uidFiledName, (ICollection) uids.ToArray<Guid>())).List<IMetadataItemHeader>();
    }

    public override ExportRuleList ExportRules()
    {
      int num = 1;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            type = InterfaceActivator.TypeOf<IMetadataItemHeader>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      ExportRuleList exportRuleList = new ExportRuleList();
      ExportRule exportRule1 = new ExportRule();
      MetadataItemHeaderManager.zPtjLMhFM0E76d6aoY82((object) exportRule1, type);
      MetadataItemHeaderManager.QGwkWPhFJNAag37WOR8u((object) exportRule1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822813958));
      exportRule1.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule1);
      ExportRule exportRule2 = new ExportRule();
      MetadataItemHeaderManager.zPtjLMhFM0E76d6aoY82((object) exportRule2, type);
      MetadataItemHeaderManager.QGwkWPhFJNAag37WOR8u((object) exportRule2, MetadataItemHeaderManager.Mwd54fhF9RZxE7CCBei1(-951514650 ^ -951559096));
      MetadataItemHeaderManager.gFmS4VhFdnnHFYX87wjB((object) exportRule2, ExportRuleType.Export);
      exportRuleList.Add(exportRule2);
      ExportRule exportRule3 = new ExportRule();
      MetadataItemHeaderManager.zPtjLMhFM0E76d6aoY82((object) exportRule3, type);
      MetadataItemHeaderManager.QGwkWPhFJNAag37WOR8u((object) exportRule3, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70233352));
      MetadataItemHeaderManager.gFmS4VhFdnnHFYX87wjB((object) exportRule3, ExportRuleType.Export);
      exportRuleList.Add(exportRule3);
      ExportRule exportRule4 = new ExportRule();
      MetadataItemHeaderManager.zPtjLMhFM0E76d6aoY82((object) exportRule4, type);
      MetadataItemHeaderManager.QGwkWPhFJNAag37WOR8u((object) exportRule4, MetadataItemHeaderManager.Mwd54fhF9RZxE7CCBei1(-1837662597 ^ -1837791025));
      MetadataItemHeaderManager.gFmS4VhFdnnHFYX87wjB((object) exportRule4, ExportRuleType.Export);
      exportRuleList.Add(exportRule4);
      ExportRule exportRule5 = new ExportRule();
      MetadataItemHeaderManager.zPtjLMhFM0E76d6aoY82((object) exportRule5, type);
      MetadataItemHeaderManager.QGwkWPhFJNAag37WOR8u((object) exportRule5, MetadataItemHeaderManager.Mwd54fhF9RZxE7CCBei1(-649342099 - -1150814748 ^ 501419851));
      exportRule5.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule5);
      ExportRule exportRule6 = new ExportRule();
      MetadataItemHeaderManager.zPtjLMhFM0E76d6aoY82((object) exportRule6, type);
      MetadataItemHeaderManager.QGwkWPhFJNAag37WOR8u((object) exportRule6, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97907524));
      exportRule6.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule6);
      ExportRule exportRule7 = new ExportRule();
      MetadataItemHeaderManager.zPtjLMhFM0E76d6aoY82((object) exportRule7, type);
      MetadataItemHeaderManager.QGwkWPhFJNAag37WOR8u((object) exportRule7, MetadataItemHeaderManager.Mwd54fhF9RZxE7CCBei1(-105199646 ^ -105204702));
      exportRule7.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule7);
      ExportRule exportRule8 = new ExportRule();
      MetadataItemHeaderManager.zPtjLMhFM0E76d6aoY82((object) exportRule8, type);
      exportRule8.PropertyName = (string) MetadataItemHeaderManager.Mwd54fhF9RZxE7CCBei1(372753449 ^ 372619955);
      MetadataItemHeaderManager.gFmS4VhFdnnHFYX87wjB((object) exportRule8, ExportRuleType.Export);
      exportRuleList.Add(exportRule8);
      ExportRule exportRule9 = new ExportRule();
      MetadataItemHeaderManager.zPtjLMhFM0E76d6aoY82((object) exportRule9, type);
      exportRule9.PropertyName = (string) MetadataItemHeaderManager.Mwd54fhF9RZxE7CCBei1(-2112703338 ^ -2112771694);
      MetadataItemHeaderManager.gFmS4VhFdnnHFYX87wjB((object) exportRule9, ExportRuleType.Export);
      exportRuleList.Add(exportRule9);
      ExportRule exportRule10 = new ExportRule();
      exportRule10.ParentType = type;
      MetadataItemHeaderManager.QGwkWPhFJNAag37WOR8u((object) exportRule10, MetadataItemHeaderManager.Mwd54fhF9RZxE7CCBei1(647913418 ^ 647901272));
      MetadataItemHeaderManager.gFmS4VhFdnnHFYX87wjB((object) exportRule10, ExportRuleType.Export);
      exportRuleList.Add(exportRule10);
      return exportRuleList;
    }

    public MetadataItemHeaderManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: type reference
      ParameterExpression parameterExpression = (ParameterExpression) MetadataItemHeaderManager.m85rkhhFrrDXicp1pWNr(MetadataItemHeaderManager.r6JvInhFlqHcArnMMyYa(__typeref (IMetadataItemHeader)), MetadataItemHeaderManager.Mwd54fhF9RZxE7CCBei1(-606654180 ^ -606626392));
      // ISSUE: method reference
      // ISSUE: type reference
      this.uidFiledName = LinqUtils.NameOf<IMetadataItemHeader>(System.Linq.Expressions.Expression.Lambda<Func<IMetadataItemHeader, object>>((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Convert((System.Linq.Expressions.Expression) MetadataItemHeaderManager.IpCOs5hF5jW7mCDE5Fps((object) parameterExpression, (object) (MethodInfo) MetadataItemHeaderManager.iRpwcBhFg21FZ57IGGbN(__methodref (IMetadataItemHeader.get_Uid))), MetadataItemHeaderManager.r6JvInhFlqHcArnMMyYa(__typeref (object))), parameterExpression));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void zPtjLMhFM0E76d6aoY82([In] object obj0, Type value) => ((ExportRule) obj0).ParentType = value;

    internal static void QGwkWPhFJNAag37WOR8u([In] object obj0, [In] object obj1) => ((ExportRule) obj0).PropertyName = (string) obj1;

    internal static object Mwd54fhF9RZxE7CCBei1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void gFmS4VhFdnnHFYX87wjB([In] object obj0, ExportRuleType value) => ((ExportRule) obj0).ExportRuleType = value;

    internal static bool jPqnhbhFmOCO6pTlJuZr() => MetadataItemHeaderManager.tZIskLhF070OHhBNFgcH == null;

    internal static MetadataItemHeaderManager W5ye0PhFyQ9m332YmHW0() => MetadataItemHeaderManager.tZIskLhF070OHhBNFgcH;

    internal static Type r6JvInhFlqHcArnMMyYa([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object m85rkhhFrrDXicp1pWNr([In] Type obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Parameter(obj0, (string) obj1);

    internal static object iRpwcBhFg21FZ57IGGbN([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object IpCOs5hF5jW7mCDE5Fps([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) obj0, (MethodInfo) obj1);
  }
}
