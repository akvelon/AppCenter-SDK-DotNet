﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.AppCenter.Data
{
    public class PaginatedDocuments<T> : IEnumerable<DocumentWrapper<T>>
    {
        public IEnumerator<DocumentWrapper<T>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
