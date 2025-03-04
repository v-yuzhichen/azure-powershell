﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------
//

namespace Microsoft.Azure.PowerShell.Authenticators.Identity
{
    /// <summary>
    /// Options controlling the storage of the token cache.
    /// </summary>
    public class TokenCachePersistenceOptions
    {
        /// <summary>
        /// Name uniquely identifying the <see cref="TokenCachePersistenceOptions"/>.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// If set to true the token cache may be persisted as an unencrypted file if no OS level user encryption is available. When set to false the token cache
        /// will throw a <see cref="UnsafeAllowUnencryptedStorage"/> in the event no OS level user encryption is available.
        /// </summary>
        public bool UnsafeAllowUnencryptedStorage { get; set; }
    }
}
