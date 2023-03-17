﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable enable

namespace WebScheduler.DataMigrations.CompiledModels
{
    internal partial class OrleansMembershipTableEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "WebScheduler.DataMigrations.OrleansMembershipTable",
                typeof(OrleansMembershipTable),
                baseEntityType);

            var deploymentId = runtimeEntityType.AddProperty(
                "DeploymentId",
                typeof(string),
                propertyInfo: typeof(OrleansMembershipTable).GetProperty("DeploymentId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrleansMembershipTable).GetField("<DeploymentId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                maxLength: 150);
            deploymentId.AddAnnotation("MySql:CharSet", "utf8");

            var address = runtimeEntityType.AddProperty(
                "Address",
                typeof(string),
                propertyInfo: typeof(OrleansMembershipTable).GetProperty("Address", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrleansMembershipTable).GetField("<Address>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                maxLength: 45);

            var port = runtimeEntityType.AddProperty(
                "Port",
                typeof(int),
                propertyInfo: typeof(OrleansMembershipTable).GetProperty("Port", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrleansMembershipTable).GetField("<Port>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw);

            var generation = runtimeEntityType.AddProperty(
                "Generation",
                typeof(int),
                propertyInfo: typeof(OrleansMembershipTable).GetProperty("Generation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrleansMembershipTable).GetField("<Generation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw);

            var hostName = runtimeEntityType.AddProperty(
                "HostName",
                typeof(string),
                propertyInfo: typeof(OrleansMembershipTable).GetProperty("HostName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrleansMembershipTable).GetField("<HostName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 150);
            hostName.AddAnnotation("MySql:CharSet", "utf8");

            var iamAliveTime = runtimeEntityType.AddProperty(
                "IamAliveTime",
                typeof(DateTime),
                propertyInfo: typeof(OrleansMembershipTable).GetProperty("IamAliveTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrleansMembershipTable).GetField("<IamAliveTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            iamAliveTime.AddAnnotation("Relational:ColumnName", "IAmAliveTime");
            iamAliveTime.AddAnnotation("Relational:ColumnType", "datetime");

            var proxyPort = runtimeEntityType.AddProperty(
                "ProxyPort",
                typeof(int?),
                propertyInfo: typeof(OrleansMembershipTable).GetProperty("ProxyPort", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrleansMembershipTable).GetField("<ProxyPort>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);

            var siloName = runtimeEntityType.AddProperty(
                "SiloName",
                typeof(string),
                propertyInfo: typeof(OrleansMembershipTable).GetProperty("SiloName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrleansMembershipTable).GetField("<SiloName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 150);
            siloName.AddAnnotation("MySql:CharSet", "utf8");

            var startTime = runtimeEntityType.AddProperty(
                "StartTime",
                typeof(DateTime),
                propertyInfo: typeof(OrleansMembershipTable).GetProperty("StartTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrleansMembershipTable).GetField("<StartTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            startTime.AddAnnotation("Relational:ColumnType", "datetime");

            var status = runtimeEntityType.AddProperty(
                "Status",
                typeof(int),
                propertyInfo: typeof(OrleansMembershipTable).GetProperty("Status", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrleansMembershipTable).GetField("<Status>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var suspectTimes = runtimeEntityType.AddProperty(
                "SuspectTimes",
                typeof(string),
                propertyInfo: typeof(OrleansMembershipTable).GetProperty("SuspectTimes", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrleansMembershipTable).GetField("<SuspectTimes>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 8000);

            var key = runtimeEntityType.AddKey(
                new[] { deploymentId, address, port, generation });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
            key.AddAnnotation("Relational:Name", "PRIMARY");

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("DeploymentId")! },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("DeploymentId")! })!,
                principalEntityType,
                required: true);

            var deployment = declaringEntityType.AddNavigation("Deployment",
                runtimeForeignKey,
                onDependent: true,
                typeof(OrleansMembershipVersionTable),
                propertyInfo: typeof(OrleansMembershipTable).GetProperty("Deployment", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrleansMembershipTable).GetField("<Deployment>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var orleansMembershipTables = principalEntityType.AddNavigation("OrleansMembershipTables",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<OrleansMembershipTable>),
                propertyInfo: typeof(OrleansMembershipVersionTable).GetProperty("OrleansMembershipTables", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrleansMembershipVersionTable).GetField("<OrleansMembershipTables>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_MembershipTable_MembershipVersionTable_DeploymentId");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "OrleansMembershipTable");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}