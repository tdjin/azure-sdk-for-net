// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using Azure;
    using KeyVault;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The storage account item containing storage account metadata.
    /// </summary>
    public partial class StorageAccountItem
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountItem class.
        /// </summary>
        public StorageAccountItem() { }

        /// <summary>
        /// Initializes a new instance of the StorageAccountItem class.
        /// </summary>
        /// <param name="id">Storage identifier.</param>
        /// <param name="resourceId">Storage account resource Id.</param>
        /// <param name="attributes">The storage account management
        /// attributes.</param>
        /// <param name="tags">Application specific metadata in the form of
        /// key-value pairs.</param>
        public StorageAccountItem(string id = default(string), string resourceId = default(string), StorageAccountAttributes attributes = default(StorageAccountAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Id = id;
            ResourceId = resourceId;
            Attributes = attributes;
            Tags = tags;
        }

        /// <summary>
        /// Gets storage identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; protected set; }

        /// <summary>
        /// Gets storage account resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; protected set; }

        /// <summary>
        /// Gets the storage account management attributes.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public StorageAccountAttributes Attributes { get; protected set; }

        /// <summary>
        /// Gets application specific metadata in the form of key-value pairs.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; protected set; }

    }
}

