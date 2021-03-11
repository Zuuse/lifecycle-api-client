// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Zuuse.Lifecycle.Client.Models
{
    /// <summary> The TaxonomyNames. </summary>
    public partial class TaxonomyNames
    {
        /// <summary> Initializes a new instance of TaxonomyNames. </summary>
        internal TaxonomyNames()
        {
            LocationTaxonomyNames = new ChangeTrackingList<string>();
            FunctionalTaxonomyNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of TaxonomyNames. </summary>
        /// <param name="locationTaxonomyNames"> . </param>
        /// <param name="functionalTaxonomyNames"> . </param>
        internal TaxonomyNames(IReadOnlyList<string> locationTaxonomyNames, IReadOnlyList<string> functionalTaxonomyNames)
        {
            LocationTaxonomyNames = locationTaxonomyNames;
            FunctionalTaxonomyNames = functionalTaxonomyNames;
        }

        public IReadOnlyList<string> LocationTaxonomyNames { get; }
        public IReadOnlyList<string> FunctionalTaxonomyNames { get; }
    }
}
