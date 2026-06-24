// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Components.DefaultQualifiedTypeResolver
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EleWise.ELMA.Model.Metadata.Components
{
  /// <summary>
  /// Реализация по умолчанию для <see cref="T:EleWise.ELMA.Model.Metadata.ExtensionPoints.IQualifiedTypeResolverExtension" />
  /// </summary>
  [Component(Order = 2147483647)]
  internal class DefaultQualifiedTypeResolver : IQualifiedTypeResolverExtension
  {
    private readonly Guid uid;
    internal static DefaultQualifiedTypeResolver ci3q9IhByFY0kA41E27y;

    /// <inheritdoc />
    public Guid Uid => this.uid;

    /// <inheritdoc />
    public bool CheckType(Type type) => true;

    /// <inheritdoc />
    public IEnumerable<byte> GetQualifiedTypeData(Type type) => (IEnumerable<byte>) Encoding.UTF8.GetBytes(type.AssemblyQualifiedName);

    /// <inheritdoc />
    public Type GetType(IEnumerable<byte> data) => ReflectionType.GetType(Encoding.UTF8.GetString(data.ToArray<byte>()));

    public DefaultQualifiedTypeResolver()
    {
      DefaultQualifiedTypeResolver.TupQxJhB9K36iTuxRsl6();
      this.uid = new Guid((string) DefaultQualifiedTypeResolver.sHlnyphBdXYfV7gukeFP(1319452732 ^ 1319526382));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void TupQxJhB9K36iTuxRsl6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object sHlnyphBdXYfV7gukeFP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool mKXFiShBMFVJtlZdFtZ1() => DefaultQualifiedTypeResolver.ci3q9IhByFY0kA41E27y == null;

    internal static DefaultQualifiedTypeResolver VF7CTWhBJHgYItnQXGie() => DefaultQualifiedTypeResolver.ci3q9IhByFY0kA41E27y;
  }
}
