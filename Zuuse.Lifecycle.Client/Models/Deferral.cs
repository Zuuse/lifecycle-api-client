// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Zuuse.Lifecycle.Client.Models
{
    /// <summary> The Deferral. </summary>
    public partial class Deferral
    {
        /// <summary> Initializes a new instance of Deferral. </summary>
        public Deferral()
        {
        }

        /// <summary> Initializes a new instance of Deferral. </summary>
        /// <param name="location"> . </param>
        /// <param name="function"> . </param>
        /// <param name="yearsDeferred"> . </param>
        internal Deferral(TaxonomyPosition location, TaxonomyPosition function, int? yearsDeferred)
        {
            Location = location;
            Function = function;
            YearsDeferred = yearsDeferred;
        }

        public TaxonomyPosition Location { get; set; }
        public TaxonomyPosition Function { get; set; }
        public int? YearsDeferred { get; set; }
    }
}
