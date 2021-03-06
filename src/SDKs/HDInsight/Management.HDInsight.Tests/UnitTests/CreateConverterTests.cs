﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Management.HDInsight.Tests.UnitTests
{
    using Microsoft.Azure.Management.HDInsight.Models;
    using Microsoft.HDInsight;
    using Microsoft.HDInsight.Models;
    using System.Collections.Generic;
    using Xunit;

    public class CreateConverterTests
    {
        [Fact]
        public void CanConvertHadoopClusterToMarchSpec()
        {
            ClusterCreateParameters createParams = GetClusterCreateParamsWithMinRequiredValues();

            ExtendedParameterValidators.ValidateSpecConversion(createParams);
        }

        [Fact]
        public void CanConvertHadoopClusterWithCustomMetastoresToMarchSpec()
        {
            ClusterCreateParameters createParams = GetClusterCreateParamsWithMinRequiredValues();
            createParams.HiveMetastore = new Metastore("server.database.windows.net", "hiveDb", "username", "password");
            createParams.OozieMetastore = new Metastore("server.database.windows.net", "oozieDb", "username", "password");

            ExtendedParameterValidators.ValidateSpecConversion(createParams);
        }

        [Fact]
        public void CanConvertHadoopClusterWithScriptActions()
        {
            ClusterCreateParameters createParams = GetClusterCreateParamsWithMinRequiredValues();
            Dictionary<ClusterNodeType, List<ScriptAction>> scriptActions = new Dictionary<ClusterNodeType, List<ScriptAction>>
            {
                {
                    ClusterNodeType.WorkerNode, new List<ScriptAction>
                    {
                        new ScriptAction {Name = "scriptAction1", Parameters = "params1", Uri = "http://foo.bar"},
                        new ScriptAction {Name = "scriptAction2", Parameters = "params2", Uri = "http://foo.bar"}
                    }
                },
                {
                    ClusterNodeType.HeadNode, new List<ScriptAction>
                    {
                        new ScriptAction {Name = "scriptAction1", Parameters = "params1", Uri = "http://foo.bar"}
                    }
                },
                {
                    ClusterNodeType.ZookeeperNode, new List<ScriptAction>
                    {
                        new ScriptAction {Name = "scriptAction3", Parameters = "params1", Uri = "http://foo.bar"}
                    }
                }
            };

            foreach(KeyValuePair<ClusterNodeType, List<ScriptAction>> kv in scriptActions)
            {
                createParams.ScriptActions.Add(kv.Key, kv.Value);
            }

            ExtendedParameterValidators.ValidateSpecConversion(createParams);
        }

        [Fact]
        public void CanConvertSandboxCluster()
        {
            ClusterCreateParameters createParams = GetClusterCreateParamsWithMinRequiredValues();
            createParams.ClusterType = "SaNdBoX";
            ExtendedParameterValidators.ValidateSpecConversion(createParams);
        }

        [Fact]
        public void CanConvertRServerCluster()
        {
            ClusterCreateParameters createParams = GetClusterCreateParamsWithMinRequiredValues();
            createParams.ClusterType = "RsErVeR";
            ExtendedParameterValidators.ValidateSpecConversion(createParams);
        }

        [Fact]
        public void CanConvertHadoopClusterWithCustomVnet()
        {
            ClusterCreateParameters createParams = GetClusterCreateParamsWithMinRequiredValues();
            createParams.VirtualNetworkId = "vnetId";
            createParams.SubnetName = "subnet";
            ExtendedParameterValidators.ValidateSpecConversion(createParams);
        }

        [Fact]
        public void ConvertParametersWithMissingNoProvidedPropertiesShouldNotThrow()
        {
            ClusterCreateParameters createParams = new ClusterCreateParameters();

            ClusterCreateParametersExtended extendedParams = CreateParametersConverter.GetExtendedClusterCreateParameters("testCluster", createParams);
        }

        private static ClusterCreateParameters GetClusterCreateParamsWithMinRequiredValues()
        {
            return new ClusterCreateParameters
            {
                Location = "West US",
                ClusterSizeInNodes = 4,
                SshUserName = "sshUser",
                SshPassword = "sshPassword",
                SshPublicKey = "sshPublicKey",

                UserName = "admin",
                Password = "Password1!",
                DefaultStorageInfo = new AzureStorageInfo("storageAccount", "key"),
                ClusterType = "Hadoop"
            };
        }
    }
}