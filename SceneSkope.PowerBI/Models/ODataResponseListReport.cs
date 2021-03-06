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
    /// Odata response wrapper for a Power BI Report collection
    /// </summary>
    public partial class ODataResponseListReport
    {
        /// <summary>
        /// Initializes a new instance of the ODataResponseListReport class.
        /// </summary>
        public ODataResponseListReport()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataResponseListReport class.
        /// </summary>
        /// <param name="odatacontext">OData context</param>
        /// <param name="value">The report collection</param>
        public ODataResponseListReport(string odatacontext = default(string), IList<Report> value = default(IList<Report>))
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
        /// Gets or sets oData context
        /// </summary>
        [JsonProperty(PropertyName = "odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// Gets or sets the report collection
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Report> Value { get; set; }

    }
}
