// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Redis.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Sku parameters supplied to the create redis operation.
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku() { }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">What type of redis cache to deploy. Valid
        /// values: (Basic, Standard, Premium). Possible values include:
        /// 'Basic', 'Standard', 'Premium'</param>
        /// <param name="family">Which family to use. Valid values: (C, P).
        /// Possible values include: 'C', 'P'</param>
        /// <param name="capacity">What size of redis cache to deploy. Valid
        /// values: for C family (0, 1, 2, 3, 4, 5, 6), for P family (1, 2,
        /// 3, 4)</param>
        public Sku(string name, string family, int capacity)
        {
            Name = name;
            Family = family;
            Capacity = capacity;
        }

        /// <summary>
        /// Gets or sets what type of redis cache to deploy. Valid values:
        /// (Basic, Standard, Premium). Possible values include: 'Basic',
        /// 'Standard', 'Premium'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets which family to use. Valid values: (C, P). Possible
        /// values include: 'C', 'P'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "family")]
        public string Family { get; set; }

        /// <summary>
        /// Gets or sets what size of redis cache to deploy. Valid values: for
        /// C family (0, 1, 2, 3, 4, 5, 6), for P family (1, 2, 3, 4)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "capacity")]
        public int Capacity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (Family == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Family");
            }
        }
    }
}