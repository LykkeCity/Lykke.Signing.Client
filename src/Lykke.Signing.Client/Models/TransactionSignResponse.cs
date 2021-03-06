// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Lykke.Signing.Client.Models
{
    using Lykke.Signing;
    using Lykke.Signing.Client;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TransactionSignResponse
    {
        /// <summary>
        /// Initializes a new instance of the TransactionSignResponse class.
        /// </summary>
        public TransactionSignResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransactionSignResponse class.
        /// </summary>
        public TransactionSignResponse(string signedTransaction = default(string))
        {
            SignedTransaction = signedTransaction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signedTransaction")]
        public string SignedTransaction { get; set; }

    }
}
