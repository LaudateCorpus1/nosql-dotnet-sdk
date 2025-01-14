/*-
 * Copyright (c) 2020, 2022 Oracle and/or its affiliates. All rights reserved.
 *
 * Licensed under the Universal Permissive License v 1.0 as shown at
 *  https://oss.oracle.com/licenses/upl/
 */

namespace Oracle.NoSQL.SDK
{
    using System;

    internal interface IOptions
    {
        string Compartment { get; }

        TimeSpan? Timeout { get; }

        void Validate();
    }

    internal interface IReadOptions : IOptions
    {
        Consistency? Consistency { get; }
    }

    internal interface IWriteOptions : IOptions
    {
        bool ReturnExisting { get; }
    }

    internal interface IWriteManyOptions : IOptions
    {
        bool AbortIfUnsuccessful { get; }
    }

}
