// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiPropertyClassNode
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  public class PublicApiPropertyClassNode : IPublicApiNode
  {
    protected readonly string fieldName;
    protected readonly bool hideProperty;
    protected readonly bool obsoleteProperty;
    protected readonly string obsoleteMessage;
    internal static PublicApiPropertyClassNode QNhPYqhAwiVTWGaul8pL;

    public PublicApiPropertyClassNode(string parentPath, string className, string propertyName)
    {
      PublicApiPropertyClassNode.Pg8fVfhAH6rs6QkTsWd5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            ((PublicApiCodeGenerator) PublicApiPropertyClassNode.q75kndhA7JvbQStDZ0ua()).AddPropertyClassNode(this.ClassName, this.Path);
            num = 4;
            continue;
          case 2:
            this.PropertyName = propertyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          case 3:
            this.ParentPath = parentPath;
            num = 5;
            continue;
          case 4:
            goto label_3;
          case 5:
            this.ClassName = className;
            num = 2;
            continue;
          default:
            this.fieldName = (string) PublicApiPropertyClassNode.p1fvPBhAAi8NON3e6ToY(-643786247 ^ -643622053) + propertyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public PublicApiPropertyClassNode(
      string parentPath,
      string className,
      string propertyName,
      bool hideProperty)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(parentPath, className, propertyName);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.hideProperty = hideProperty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public PublicApiPropertyClassNode(
      string parentPath,
      string className,
      string propertyName,
      string obsoleteMessage)
    {
      PublicApiPropertyClassNode.Pg8fVfhAH6rs6QkTsWd5();
      // ISSUE: explicit constructor call
      this.\u002Ector(parentPath, className, propertyName, true);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.obsoleteMessage = obsoleteMessage;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.obsoleteProperty = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    protected PublicApiPropertyClassNode(
      string parentPath,
      string className,
      string propertyName,
      string typeName,
      bool hideProperty,
      bool registerPath = true)
    {
      PublicApiPropertyClassNode.Pg8fVfhAH6rs6QkTsWd5();
      // ISSUE: explicit constructor call
      this.\u002Ector(parentPath, className, propertyName, hideProperty);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            PublicApiPropertyClassNode.Y8xSJrhAxObGQQJbY2Wq(PublicApiPropertyClassNode.q75kndhA7JvbQStDZ0ua(), (object) typeName, (object) this.Path, hideProperty);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            if (!registerPath)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 3 : 3;
              continue;
            }
            goto case 2;
        }
      }
label_7:
      return;
label_3:;
    }

    private PublicApiPropertyClassNode(
      string parentPath,
      string className,
      string propertyName,
      string typeName,
      string obsoleteMessage)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(parentPath, className, propertyName, obsoleteMessage);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            PublicApiPropertyClassNode.Y8xSJrhAxObGQQJbY2Wq(PublicApiPropertyClassNode.q75kndhA7JvbQStDZ0ua(), (object) typeName, (object) this.Path, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    private static string GetPropertyName(Type type)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (PublicApiPropertyClassNode.YPf3xlhAmAF8tglVSdnv(PublicApiPropertyClassNode.faRicRhA0hWGbOJ8YYys((object) type), 0) != 'I')
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            if (type.IsInterface)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) PublicApiPropertyClassNode.faRicRhA0hWGbOJ8YYys((object) type);
label_5:
      return (string) PublicApiPropertyClassNode.syx2LbhAy16p4NyPOe4S(PublicApiPropertyClassNode.faRicRhA0hWGbOJ8YYys((object) type), 1);
    }

    private static string GetPropertyName(object metadata) => (string) PublicApiPropertyClassNode.D81e8ZhAMHCTLm3j6ZEL(metadata);

    internal static string GetTypeName(Type type)
    {
      int num = 2;
      string fullName;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (PublicApiPropertyClassNode.YPf3xlhAmAF8tglVSdnv((object) type.Name, 0) != 'I')
            {
              num = 3;
              continue;
            }
            goto label_10;
          case 2:
            if (type.IsInterface)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
              continue;
            }
            goto case 3;
          case 3:
            fullName = type.FullName;
            if (fullName == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_9;
        }
      }
label_2:
      return fullName;
label_9:
      return (string) PublicApiPropertyClassNode.NvLjQZhAJjRR4op9xZjm((object) type.Namespace, PublicApiPropertyClassNode.p1fvPBhAAi8NON3e6ToY(-1217523399 ^ -1217524739), PublicApiPropertyClassNode.faRicRhA0hWGbOJ8YYys((object) type));
label_10:
      return (string) PublicApiPropertyClassNode.NvLjQZhAJjRR4op9xZjm((object) type.Namespace, PublicApiPropertyClassNode.p1fvPBhAAi8NON3e6ToY(1669212571 ^ 1669215071), PublicApiPropertyClassNode.syx2LbhAy16p4NyPOe4S(PublicApiPropertyClassNode.faRicRhA0hWGbOJ8YYys((object) type), 1));
    }

    internal static string GetTypeName(EntityMetadata metadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (PublicApiPropertyClassNode.AyRPIPhAdkegK0SWEVQy(PublicApiPropertyClassNode.yRFvDChA9qXDdLRF1i3b((object) metadata)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) PublicApiPropertyClassNode.NvLjQZhAJjRR4op9xZjm(PublicApiPropertyClassNode.yRFvDChA9qXDdLRF1i3b((object) metadata), PublicApiPropertyClassNode.p1fvPBhAAi8NON3e6ToY(1232639661 >> 3 ^ 154077201), PublicApiPropertyClassNode.D81e8ZhAMHCTLm3j6ZEL((object) metadata));
label_3:
      return (string) PublicApiPropertyClassNode.D81e8ZhAMHCTLm3j6ZEL((object) metadata);
    }

    public PublicApiPropertyClassNode(string parentPath, string className, Type type)
    {
      PublicApiPropertyClassNode.Pg8fVfhAH6rs6QkTsWd5();
      // ISSUE: explicit constructor call
      this.\u002Ector(parentPath, className, (string) PublicApiPropertyClassNode.oYxyRVhAlpoOCoGEQZKm(type), type);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public PublicApiPropertyClassNode(
      string parentPath,
      string className,
      Type type,
      bool hideProperty)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(parentPath, className, (string) PublicApiPropertyClassNode.oYxyRVhAlpoOCoGEQZKm(type), type, hideProperty);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>ctor</summary>
    /// <param name="parentPath">Путь родителя</param>
    /// <param name="className">Имя класса</param>
    /// <param name="propertyName">Имя свойства</param>
    /// <param name="type">Тип</param>
    /// <param name="hideProperty">Спрятать свойство</param>
    /// <param name="registerPath">Регистрировать путь</param>
    public PublicApiPropertyClassNode(
      string parentPath,
      string className,
      string propertyName,
      Type type,
      bool hideProperty = false,
      bool registerPath = true)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(parentPath, className, propertyName, (string) PublicApiPropertyClassNode.aDO1EShArdZTh9XGZ0Gu(type), hideProperty, registerPath);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.EntityMetadata = MetadataLoader.LoadMetadata(type) as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public PublicApiPropertyClassNode(
      string parentPath,
      string className,
      Type type,
      string obsoleteMessage)
    {
      PublicApiPropertyClassNode.Pg8fVfhAH6rs6QkTsWd5();
      // ISSUE: explicit constructor call
      this.\u002Ector(parentPath, className, (string) PublicApiPropertyClassNode.oYxyRVhAlpoOCoGEQZKm(type), (string) PublicApiPropertyClassNode.aDO1EShArdZTh9XGZ0Gu(type), obsoleteMessage);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.EntityMetadata = MetadataLoader.LoadMetadata(type) as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public PublicApiPropertyClassNode(string parentPath, string className, EntityMetadata metadata)
    {
      PublicApiPropertyClassNode.Pg8fVfhAH6rs6QkTsWd5();
      // ISSUE: explicit constructor call
      this.\u002Ector(parentPath, className, PublicApiPropertyClassNode.GetPropertyName((object) metadata), metadata);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public PublicApiPropertyClassNode(
      string parentPath,
      string className,
      EntityMetadata metadata,
      bool hideProperty,
      bool registerPath = true)
    {
      PublicApiPropertyClassNode.Pg8fVfhAH6rs6QkTsWd5();
      // ISSUE: explicit constructor call
      this.\u002Ector(parentPath, className, (string) PublicApiPropertyClassNode.dntLdehAgFUpGCQ29twp((object) metadata), (string) PublicApiPropertyClassNode.cQuWGMhA5Yct8OIKWKBS((object) metadata), hideProperty, registerPath);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.EntityMetadata = metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public PublicApiPropertyClassNode(
      string parentPath,
      string className,
      string propertyName,
      EntityMetadata metadata)
    {
      PublicApiPropertyClassNode.Pg8fVfhAH6rs6QkTsWd5();
      // ISSUE: explicit constructor call
      this.\u002Ector(parentPath, className, propertyName, (string) PublicApiPropertyClassNode.cQuWGMhA5Yct8OIKWKBS((object) metadata), false);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.EntityMetadata = metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public PublicApiPropertyClassNode(
      string parentPath,
      string className,
      string propertyName,
      EntityMetadata metadata,
      bool hideProperty,
      bool registerPath = true)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(parentPath, className, propertyName, PublicApiPropertyClassNode.GetTypeName(metadata), hideProperty, registerPath);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.EntityMetadata = metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public string ParentPath
    {
      get => this.\u003CParentPath\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CParentPath\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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

    public string Path => this.ParentPath + (string) PublicApiPropertyClassNode.p1fvPBhAAi8NON3e6ToY(1470440286 ^ 1470445978) + this.PropertyName;

    public string ClassName
    {
      get => this.\u003CClassName\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CClassName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
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

    public string PropertyName
    {
      get => this.\u003CPropertyName\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPropertyName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
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

    public virtual string Description
    {
      get => this.\u003CDescription\u003Ek__BackingField;
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
              this.\u003CDescription\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
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

    public virtual string Remarks
    {
      get => this.\u003CRemarks\u003Ek__BackingField;
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
              this.\u003CRemarks\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
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

    public virtual string Code
    {
      get => this.\u003CCode\u003Ek__BackingField;
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
              this.\u003CCode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
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

    public IEnumerable<ISyntaxNode> Generate(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      ISyntaxNode second = this.PropertyResultClass(tree);
      return second != null ? this.Property(tree).Concat<ISyntaxNode>(second) : Enumerable.Empty<ISyntaxNode>();
    }

    /// <summary>Метаданные</summary>
    internal EntityMetadata EntityMetadata { get; }

    protected virtual IEnumerable<ISyntaxNode> Property(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new PublicApiPropertyClassNode.\u003CProperty\u003Ed__51(-2)
      {
        \u003C\u003E4__this = this
      };
    }

    protected virtual ISyntaxNode PropertyResultClass(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      return PublicApiCodeGenerator.Current.UseHiddenProperty<ISyntaxNode>(this.hideProperty, (Func<ISyntaxNode>) (() =>
      {
        int num = 1;
        ISyntaxNode[] array;
        while (true)
        {
          switch (num)
          {
            case 1:
              array = tree[this.Path].SelectMany<IPublicApiNode, ISyntaxNode>((Func<IPublicApiNode, IEnumerable<ISyntaxNode>>) (n => n.Generate(tree))).ToArray<ISyntaxNode>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            default:
              if (array.Length != 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 2;
                continue;
              }
              goto label_5;
          }
        }
label_4:
        return this.ClassName.ClassDeclaration(Accessibility.Public, members: (IEnumerable<ISyntaxNode>) array).MakeClassHide();
label_5:
        return (ISyntaxNode) null;
      }));
    }

    internal static void Pg8fVfhAH6rs6QkTsWd5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object p1fvPBhAAi8NON3e6ToY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object q75kndhA7JvbQStDZ0ua() => (object) PublicApiCodeGenerator.Current;

    internal static bool xXDUZOhA4UySXTnGBwrP() => PublicApiPropertyClassNode.QNhPYqhAwiVTWGaul8pL == null;

    internal static PublicApiPropertyClassNode YNnTvuhA68TUbQtFBoIC() => PublicApiPropertyClassNode.QNhPYqhAwiVTWGaul8pL;

    internal static void Y8xSJrhAxObGQQJbY2Wq([In] object obj0, [In] object obj1, [In] object obj2, bool hidden) => ((PublicApiCodeGenerator) obj0).AddPropertyTypeNode((string) obj1, (string) obj2, hidden);

    internal static object faRicRhA0hWGbOJ8YYys([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static char YPf3xlhAmAF8tglVSdnv([In] object obj0, [In] int obj1) => ((string) obj0)[obj1];

    internal static object syx2LbhAy16p4NyPOe4S([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static object D81e8ZhAMHCTLm3j6ZEL([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object NvLjQZhAJjRR4op9xZjm([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object yRFvDChA9qXDdLRF1i3b([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

    internal static bool AyRPIPhAdkegK0SWEVQy([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object oYxyRVhAlpoOCoGEQZKm(Type type) => (object) PublicApiPropertyClassNode.GetPropertyName(type);

    internal static object aDO1EShArdZTh9XGZ0Gu(Type type) => (object) PublicApiPropertyClassNode.GetTypeName(type);

    internal static object dntLdehAgFUpGCQ29twp([In] object obj0) => (object) PublicApiPropertyClassNode.GetPropertyName(obj0);

    internal static object cQuWGMhA5Yct8OIKWKBS([In] object obj0) => (object) PublicApiPropertyClassNode.GetTypeName((EntityMetadata) obj0);
  }
}
