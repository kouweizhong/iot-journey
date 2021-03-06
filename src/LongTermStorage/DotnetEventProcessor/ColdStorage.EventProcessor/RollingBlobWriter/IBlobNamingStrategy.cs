﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Practices.IoTJourney.ColdStorage.EventProcessor.RollingBlobWriter
{
    public interface IBlobNamingStrategy
    {
        string GetNamePrefix();
    }
}