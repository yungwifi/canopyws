using System;
namespace canopyws.Models
{
    public class PayFrequencyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GlCode { get; set; }
        public int StandardHours { get; set; }
        public int PayFrequencyFactor { get; set; }
        public string LagValue { get; set; }
    }
}
