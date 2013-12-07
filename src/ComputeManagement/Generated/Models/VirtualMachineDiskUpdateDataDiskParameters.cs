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
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Parameters supplied to the Update Virtual Machine Data Disk operation.
    /// </summary>
    public partial class VirtualMachineDiskUpdateDataDiskParameters
    {
        private string _diskLabel;
        
        /// <summary>
        /// Optional. Specifies the description of the data disk. When you
        /// attach a disk, either by directly referencing a media using the
        /// MediaLink element or specifying the target disk size, you can use
        /// the DiskLabel element to customize the name property of the target
        /// data disk.
        /// </summary>
        public string DiskLabel
        {
            get { return this._diskLabel; }
            set { this._diskLabel = value; }
        }
        
        private string _diskName;
        
        /// <summary>
        /// Optional. Specifies the name of the disk. Windows Azure uses the
        /// specified disk to create the data disk for the machine and
        /// populates this field with the disk name.
        /// </summary>
        public string DiskName
        {
            get { return this._diskName; }
            set { this._diskName = value; }
        }
        
        private VirtualHardDiskHostCaching _hostCaching;
        
        /// <summary>
        /// Required. Specifies the platform caching behavior of data disk blob
        /// for read/write efficiency. The default vault is ReadOnly. Possible
        /// values are: None, ReadOnly, ReadWrite.  Warning: Setting this
        /// property impacts the consistency of the disk.
        /// </summary>
        public VirtualHardDiskHostCaching HostCaching
        {
            get { return this._hostCaching; }
            set { this._hostCaching = value; }
        }
        
        private double _logicalDiskSizeInGB;
        
        /// <summary>
        /// Optional. Specifies the size, in GB, of an empty disk to be
        /// attached to the role. The disk can be created as part of disk
        /// attach or create VM role call by specifying the value for this
        /// property.  Windows Azure creates the empty disk based on size
        /// preference and attaches the newly created disk to the Role.
        /// </summary>
        public double LogicalDiskSizeInGB
        {
            get { return this._logicalDiskSizeInGB; }
            set { this._logicalDiskSizeInGB = value; }
        }
        
        private int? _logicalUnitNumber;
        
        /// <summary>
        /// Optional. Specifies the Logical Unit Number (LUN) for the disk. The
        /// LUN specifies the slot in which the data drive appears when
        /// mounted for usage by the virtual machine.  Valid LUN values are 0
        /// through 15.
        /// </summary>
        public int? LogicalUnitNumber
        {
            get { return this._logicalUnitNumber; }
            set { this._logicalUnitNumber = value; }
        }
        
        private Uri _mediaLinkUri;
        
        /// <summary>
        /// Required. Specifies the location of the blob in Windows Azure blob
        /// store where the media for the disk is located. The blob location
        /// must belong to the storage account in the subscription specified
        /// by the SubscriptionId value in the operation call. Example:
        /// http://example.blob.core.windows.net/disks/mydisk.vhd
        /// </summary>
        public Uri MediaLinkUri
        {
            get { return this._mediaLinkUri; }
            set { this._mediaLinkUri = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineDiskUpdateDataDiskParameters class.
        /// </summary>
        public VirtualMachineDiskUpdateDataDiskParameters()
        {
        }
    }
}
