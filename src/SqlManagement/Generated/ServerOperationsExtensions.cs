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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.Sql;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql
{
    /// <summary>
    /// The SQL Database Management API includes operations for managing SQL
    /// Database servers for a subscription.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715271.aspx for
    /// more information)
    /// </summary>
    public static partial class ServerOperationsExtensions
    {
        /// <summary>
        /// The Set Server Administrator Password operation sets the
        /// administrative password of a SQL Database server for a
        /// subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715272.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IServerOperations.
        /// </param>
        /// <param name='serverName'>
        /// The server that will have the change made to the administrative user
        /// </param>
        /// <param name='parameters'>
        /// Parameters for the Manage Administrator Password operation
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse ChangeAdministratorPassword(this IServerOperations operations, string serverName, ServerChangeAdministratorPasswordParameters parameters)
        {
            try
            {
                return operations.ChangeAdministratorPasswordAsync(serverName, parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// The Set Server Administrator Password operation sets the
        /// administrative password of a SQL Database server for a
        /// subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715272.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IServerOperations.
        /// </param>
        /// <param name='serverName'>
        /// The server that will have the change made to the administrative user
        /// </param>
        /// <param name='parameters'>
        /// Parameters for the Manage Administrator Password operation
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> ChangeAdministratorPasswordAsync(this IServerOperations operations, string serverName, ServerChangeAdministratorPasswordParameters parameters)
        {
            return operations.ChangeAdministratorPasswordAsync(serverName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Create Server operation adds a new SQL Database server to a
        /// subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715274.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IServerOperations.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Server operation.
        /// </param>
        /// <returns>
        /// The response returned from the Create Server operation
        /// </returns>
        public static ServerCreateResponse Create(this IServerOperations operations, ServerCreateParameters parameters)
        {
            try
            {
                return operations.CreateAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// The Create Server operation adds a new SQL Database server to a
        /// subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715274.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IServerOperations.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Server operation.
        /// </param>
        /// <returns>
        /// The response returned from the Create Server operation
        /// </returns>
        public static Task<ServerCreateResponse> CreateAsync(this IServerOperations operations, ServerCreateParameters parameters)
        {
            return operations.CreateAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Drop Server operation drops a SQL Database server from a
        /// subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715285.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IServerOperations.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server to be deleted
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this IServerOperations operations, string serverName)
        {
            try
            {
                return operations.DeleteAsync(serverName).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// The Drop Server operation drops a SQL Database server from a
        /// subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715285.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IServerOperations.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server to be deleted
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this IServerOperations operations, string serverName)
        {
            return operations.DeleteAsync(serverName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Servers operation enumerates SQL Database servers that are
        /// provisioned for a subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715269.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IServerOperations.
        /// </param>
        /// <returns>
        /// The response structure for the Server List operation
        /// </returns>
        public static ServerListResponse List(this IServerOperations operations)
        {
            try
            {
                return operations.ListAsync().Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// The Get Servers operation enumerates SQL Database servers that are
        /// provisioned for a subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715269.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IServerOperations.
        /// </param>
        /// <returns>
        /// The response structure for the Server List operation
        /// </returns>
        public static Task<ServerListResponse> ListAsync(this IServerOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
    }
}
