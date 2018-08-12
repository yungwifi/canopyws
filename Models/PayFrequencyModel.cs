using System;
namespace canopyws.Models
{
    public class PayFrequencyModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GlCode { get; set; }
        public string StandardHours { get; set; }
        public string PayFrequencyFactor { get; set; }
        public string LagValue { get; set; }
    }
}
