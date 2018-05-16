// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace SceneSkope.PowerBI.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Odata response wrapper for a Power BI Capacity List
    /// </summary>
    public partial class ODataResponseListCapacity
    {
        /// <summary>
        /// Initializes a new instance of the ODataResponseListCapacity class.
        /// </summary>
        public ODataResponseListCapacity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataResponseListCapacity class.
        /// </summary>
        /// <param name="value">The Capacity List</param>
        public ODataResponseListCapacity(string odatacontext = default(string), IList<Capacity> value = default(IList<Capacity>))
        {
            Odatacontext = odatacontext;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// Gets or sets the Capacity List
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Capacity> Value { get; set; }

    }
}
