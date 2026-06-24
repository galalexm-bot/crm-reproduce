// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Convertors.TypeConverterService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Types.Convertors
{
  /// <summary>Сервис для работы с преобразователями типов</summary>
  [Service]
  internal sealed class TypeConverterService : ITypeConverterService
  {
    private ConcurrentDictionary<Guid, IEnumerable<Guid>> cachedTargetSelections;
    /// <summary>Конвертеры типов</summary>
    private readonly IEnumerable<ITypeConvertor> typeConverters;
    internal static TypeConverterService NwDKufo5MEFxUjyFMEOj;

    /// <summary>Конструктор</summary>
    /// <param name="typeConverters">Конвертеры типов</param>
    public TypeConverterService(IEnumerable<ITypeConvertor> typeConverters)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.cachedTargetSelections = new ConcurrentDictionary<Guid, IEnumerable<Guid>>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.typeConverters = typeConverters;
    }

    /// <summary>
    /// Проверяет возможность преобразования типа-источника в целевой тип
    /// </summary>
    /// <param name="sourceTypeUid">Идентификатор типа-источника</param>
    /// <param name="targetTypeUid">Идентификатор целевого типа</param>
    /// <returns><c>True</c>, если преобразование возможно</returns>
    public bool CanConvert(Guid sourceTypeUid, Guid targetTypeUid) => this.GetConvertFromTypeUids(targetTypeUid).Contains<Guid>(sourceTypeUid);

    /// <inheritdoc />
    public ITypeConvertor GetConverterToTargetType(Guid targetTypeUid)
    {
      int num = 1;
      Guid targetTypeUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            targetTypeUid1 = targetTypeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 0;
            continue;
        }
      }
label_4:
      IEnumerable<ITypeConvertor> typeConverters = this.typeConverters;
      // ISSUE: reference to a compiler-generated field
      Func<ITypeConvertor, IEnumerable<Guid>> func = TypeConverterService.\u003C\u003Ec.\u003C\u003E9__4_0;
      Func<ITypeConvertor, IEnumerable<Guid>> collectionSelector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        TypeConverterService.\u003C\u003Ec.\u003C\u003E9__4_0 = collectionSelector = (Func<ITypeConvertor, IEnumerable<Guid>>) (tc => (IEnumerable<Guid>) tc.TargetTypeUids);
      }
      else
        goto label_7;
label_6:
      // ISSUE: object of a compiler-generated type is created
      return typeConverters.SelectMany(collectionSelector, (tc, uid) => new \u003C\u003Ef__AnonymousType5<ITypeConvertor, Guid>(tc, uid)).Where(tc => tc.uid == targetTypeUid1).Select(res => res.tc).FirstOrDefault<ITypeConvertor>();
label_7:
      collectionSelector = func;
      goto label_6;
    }

    /// <summary>
    /// Получить список идентификаторов типов свойств из которых можно конвертировать в данный
    /// </summary>
    /// <param name="targetTypeUid">Идентификатор целевого типа</param>
    /// <returns>Список идентификаторов типов</returns>
    private IEnumerable<Guid> GetConvertFromTypeUids(Guid targetTypeUid) => this.cachedTargetSelections.GetOrAdd(targetTypeUid, (Func<Guid, IEnumerable<Guid>>) (guid => (IEnumerable<Guid>) this.typeConverters.SelectMany((Func<ITypeConvertor, IEnumerable<Guid>>) (tc => (IEnumerable<Guid>) tc.TargetTypeUids), (tc, uid) => new \u003C\u003Ef__AnonymousType5<ITypeConvertor, Guid>(tc, uid)).Where(res => res.uid == guid).SelectMany(res => (IEnumerable<Guid>) res.tc.SourceTypeUids).Distinct<Guid>().ToList<Guid>()));

    internal static bool rTxf7po5JW1c0TRoN1x2() => TypeConverterService.NwDKufo5MEFxUjyFMEOj == null;

    internal static TypeConverterService UrwRcfo59LLWtPr4MF7L() => TypeConverterService.NwDKufo5MEFxUjyFMEOj;
  }
}
