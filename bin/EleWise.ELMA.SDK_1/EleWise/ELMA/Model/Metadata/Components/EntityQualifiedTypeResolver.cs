// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Components.EntityQualifiedTypeResolver
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.Model.Metadata.Components
{
  /// <summary>
  /// Реализация <see cref="T:EleWise.ELMA.Model.Metadata.ExtensionPoints.IQualifiedTypeResolverExtension" /> для сущностей
  /// </summary>
  [Component(Order = 1000)]
  internal class EntityQualifiedTypeResolver : IQualifiedTypeResolverExtension
  {
    private readonly Guid uid;
    private readonly IMetadataRuntimeService metadataRuntimeService;
    internal static EntityQualifiedTypeResolver O9vvbQhBUaGnmkj9kbnx;

    /// <summary>ctor</summary>
    /// <param name="metadataRuntimeService">Служба управления метаданными в режиме Runtime</param>
    public EntityQualifiedTypeResolver(IMetadataRuntimeService metadataRuntimeService)
    {
      EntityQualifiedTypeResolver.aiBtvghBzZaKKZIsXVYy();
      this.uid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951441012));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.metadataRuntimeService = metadataRuntimeService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public Guid Uid => this.uid;

    /// <inheritdoc />
    public bool CheckType(Type type) => TypeOf<IEntity>.Raw.IsAssignableFrom(type);

    /// <inheritdoc />
    public IEnumerable<byte> GetQualifiedTypeData(Type type) => (IEnumerable<byte>) MetadataLoader.LoadMetadata(type, false, false).Uid.ToByteArray();

    /// <inheritdoc />
    public Type GetType(IEnumerable<byte> data) => this.metadataRuntimeService.GetTypeByUid(new Guid(data.ToArray<byte>()));

    internal static void aiBtvghBzZaKKZIsXVYy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool FAOsemhBsq3Kn09TLwcq() => EntityQualifiedTypeResolver.O9vvbQhBUaGnmkj9kbnx == null;

    internal static EntityQualifiedTypeResolver NyCP5thBcYo3v0UUOlLh() => EntityQualifiedTypeResolver.O9vvbQhBUaGnmkj9kbnx;
  }
}
