// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace SceneSkope.PowerBI.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Power BI Gateway
    /// </summary>
    public partial class Gateway
    {
        /// <summary>
        /// Initializes a new instance of the Gateway class.
        /// </summary>
        public Gateway()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Gateway class.
        /// </summary>
        /// <param name="id">The gateway id</param>
        /// <param name="name">The gateway name</param>
        /// <param name="type">The gateway type</param>
        /// <param name="gatewayAnnotation">The gateway annotation</param>
        /// <param name="publicKey">The gateway public key</param>
        /// <param name="gatewayStatus">The gateway connectivity status</param>
        public Gateway(string id = default(string), string name = default(string), string type = default(string), string gatewayAnnotation = default(string), GatewayPublicKey publicKey = default(GatewayPublicKey), string gatewayStatus = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            GatewayAnnotation = gatewayAnnotation;
            PublicKey = publicKey;
            GatewayStatus = gatewayStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the gateway id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the gateway name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the gateway type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the gateway annotation
        /// </summary>
        [JsonProperty(PropertyName = "gatewayAnnotation")]
        public string GatewayAnnotation { get; set; }

        /// <summary>
        /// Gets or sets the gateway public key
        /// </summary>
        [JsonProperty(PropertyName = "publicKey")]
        public GatewayPublicKey PublicKey { get; set; }

        /// <summary>
        /// Gets or sets the gateway connectivity status
        /// </summary>
        [JsonProperty(PropertyName = "gatewayStatus")]
        public string GatewayStatus { get; set; }

    }
}
