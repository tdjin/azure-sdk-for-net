// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.WindowsAzure.Management.Sql;

namespace Microsoft.WindowsAzure.Management.Sql.Models
{
    /// <summary>
    /// A standard service response including an HTTP status code and request
    /// ID.
    /// </summary>
    public partial class DatabaseUpdateResponse : OperationResponse
    {
        private string _collationName;
        
        /// <summary>
        /// Gets or sets the database resource's collation name.
        /// </summary>
        public string CollationName
        {
            get { return this._collationName; }
            set { this._collationName = value; }
        }
        
        private DateTime _creationDate;
        
        /// <summary>
        /// Gets or sets the date this database was created.
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }
        
        private string _edition;
        
        /// <summary>
        /// Gets or sets the database resource's edition.
        /// </summary>
        public string Edition
        {
            get { return this._edition; }
            set { this._edition = value; }
        }
        
        private int _id;
        
        /// <summary>
        /// Gets or sets the id of the database.
        /// </summary>
        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private bool _isFederationRoot;
        
        /// <summary>
        /// Gets or sets a value indicating whether the database is a
        /// federation root.
        /// </summary>
        public bool IsFederationRoot
        {
            get { return this._isFederationRoot; }
            set { this._isFederationRoot = value; }
        }
        
        private bool _isSystemObject;
        
        /// <summary>
        /// Gets or sets a value indicating whether the database is a system
        /// object.
        /// </summary>
        public bool IsSystemObject
        {
            get { return this._isSystemObject; }
            set { this._isSystemObject = value; }
        }
        
        private long _maximumDatabaseSizeInGB;
        
        /// <summary>
        /// Gets or sets the maximum size of this database, in Gigabytes.
        /// </summary>
        public long MaximumDatabaseSizeInGB
        {
            get { return this._maximumDatabaseSizeInGB; }
            set { this._maximumDatabaseSizeInGB = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Gets or sets the name of the database.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _serviceObjectiveAssignmentErrorCode;
        
        /// <summary>
        /// Gets or sets the error code for this service objective.
        /// </summary>
        public string ServiceObjectiveAssignmentErrorCode
        {
            get { return this._serviceObjectiveAssignmentErrorCode; }
            set { this._serviceObjectiveAssignmentErrorCode = value; }
        }
        
        private string _serviceObjectiveAssignmentErrorDescription;
        
        /// <summary>
        /// Gets or sets the error description, if any.
        /// </summary>
        public string ServiceObjectiveAssignmentErrorDescription
        {
            get { return this._serviceObjectiveAssignmentErrorDescription; }
            set { this._serviceObjectiveAssignmentErrorDescription = value; }
        }
        
        private string _serviceObjectiveAssignmentState;
        
        /// <summary>
        /// Gets or sets the state of the current assignment.
        /// </summary>
        public string ServiceObjectiveAssignmentState
        {
            get { return this._serviceObjectiveAssignmentState; }
            set { this._serviceObjectiveAssignmentState = value; }
        }
        
        private string _serviceObjectiveAssignmentStateDescription;
        
        /// <summary>
        /// Gets or sets the state description.
        /// </summary>
        public string ServiceObjectiveAssignmentStateDescription
        {
            get { return this._serviceObjectiveAssignmentStateDescription; }
            set { this._serviceObjectiveAssignmentStateDescription = value; }
        }
        
        private string _serviceObjectiveAssignmentSuccessDate;
        
        /// <summary>
        /// Gets or sets the date the service's assignment succeeded.
        /// </summary>
        public string ServiceObjectiveAssignmentSuccessDate
        {
            get { return this._serviceObjectiveAssignmentSuccessDate; }
            set { this._serviceObjectiveAssignmentSuccessDate = value; }
        }
        
        private string _serviceObjectiveId;
        
        /// <summary>
        /// Gets or sets the id of this service objective.
        /// </summary>
        public string ServiceObjectiveId
        {
            get { return this._serviceObjectiveId; }
            set { this._serviceObjectiveId = value; }
        }
        
        private string _sizeMB;
        
        /// <summary>
        /// Gets or sets the size of this database in megabytes (MB).
        /// </summary>
        public string SizeMB
        {
            get { return this._sizeMB; }
            set { this._sizeMB = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Gets or sets the state of the database.
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Gets or sets the type of resource.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DatabaseUpdateResponse class.
        /// </summary>
        public DatabaseUpdateResponse()
        {
        }
    }
}
