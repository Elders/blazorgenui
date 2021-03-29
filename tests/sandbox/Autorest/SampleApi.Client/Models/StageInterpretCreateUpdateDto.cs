// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace SampleApi.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class StageInterpretCreateUpdateDto
    {
        /// <summary>
        /// Initializes a new instance of the StageInterpretCreateUpdateDto
        /// class.
        /// </summary>
        public StageInterpretCreateUpdateDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StageInterpretCreateUpdateDto
        /// class.
        /// </summary>
        public StageInterpretCreateUpdateDto(string interpretId = default(string), string stageId = default(string), int? concertLength = default(int?), System.DateTimeOffset? concertStart = default(System.DateTimeOffset?), System.DateTimeOffset? concertEnd = default(System.DateTimeOffset?))
        {
            InterpretId = interpretId;
            StageId = stageId;
            ConcertLength = concertLength;
            ConcertStart = concertStart;
            ConcertEnd = concertEnd;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "interpretId")]
        public string InterpretId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageId")]
        public string StageId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "concertLength")]
        public int? ConcertLength { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "concertStart")]
        public System.DateTimeOffset? ConcertStart { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "concertEnd")]
        public System.DateTimeOffset? ConcertEnd { get; set; }

    }
}
