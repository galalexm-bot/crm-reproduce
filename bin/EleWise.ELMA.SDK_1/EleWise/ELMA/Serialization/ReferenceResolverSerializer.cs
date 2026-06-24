// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.ReferenceResolverSerializer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Serialization
{
  /// <summary>Класс для объявления резолвера ссылок</summary>
  internal static class ReferenceResolverSerializer
  {
    /// <summary>
    /// Название свойства, определяющее идентификатор объекта при (де)сериализации
    /// </summary>
    internal const string IdRefPropertyName = "$id";
    /// <summary>
    /// Название свойства, определяющее ссылку на объект при (де)сериализации
    /// </summary>
    internal const string RefPropertyName = "$ref";
    internal static ReferenceResolverSerializer JsfZqmB9CdSwu6qa1hRj;

    /// <summary>Текущий экземпляр резолвера ссылок</summary>
    internal static IReferenceResolver CurrentResolver => DisposableCallContext.GetCurrent<IReferenceResolver>((string) ReferenceResolverSerializer.YpVdyOB9ZvPken3lwCqL(1925118608 << 2 ^ -889550946));

    /// <summary>Создать Disposable экземпляр</summary>
    /// <param name="needResolver">Нужно ли создавать экземпляр резолвера</param>
    /// <returns>Disposable экземпляр</returns>
    internal static IDisposable CreateResolver(bool needResolver)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!needResolver)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (IDisposable) ReferenceResolverSerializer.ldbx2gB9ud36nkMHKf1C();
label_5:
      object key = ReferenceResolverSerializer.YpVdyOB9ZvPken3lwCqL(-53329496 >> 4 ^ -3388988);
      // ISSUE: reference to a compiler-generated field
      Func<IReferenceResolver, IReferenceResolver> func = ReferenceResolverSerializer.\u003C\u003Ec.\u003C\u003E9__5_0;
      Func<IReferenceResolver, IReferenceResolver> instanceFunc;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        ReferenceResolverSerializer.\u003C\u003Ec.\u003C\u003E9__5_0 = instanceFunc = (Func<IReferenceResolver, IReferenceResolver>) (old =>
        {
          int num2 = 1;
          IReferenceResolver resolver;
          while (true)
          {
            switch (num2)
            {
              case 1:
                resolver = old;
                if (resolver == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
                  continue;
                }
                goto label_2;
              default:
                goto label_5;
            }
          }
label_2:
          return resolver;
label_5:
          return (IReferenceResolver) new ReferenceResolver();
        });
      }
      else
        goto label_6;
label_8:
      return DisposableCallContext.Create<IReferenceResolver>((string) key, instanceFunc);
label_6:
      instanceFunc = func;
      goto label_8;
    }

    internal static object YpVdyOB9ZvPken3lwCqL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool aoiYWDB9vEhbF56hvOv6() => ReferenceResolverSerializer.JsfZqmB9CdSwu6qa1hRj == null;

    internal static ReferenceResolverSerializer WviUuGB98A5gYsNMGbtk() => ReferenceResolverSerializer.JsfZqmB9CdSwu6qa1hRj;

    internal static object ldbx2gB9ud36nkMHKf1C() => (object) DisposableCallContext.CreateEmptyCallContext();
  }
}
