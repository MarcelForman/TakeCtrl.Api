namespace TakeCtrl.Api.Entities
{
    public class Usage
    {
        public int Id { get; set; }
        public string UUID { get; set; }
        public string Type { get; set; }
        public double? Percent { get; set; }
        public double? IopsRead { get; set; }
        public double? IopsWrite { get; set; }
        public double? MbitOut { get; set; }
        public double? MbitIn { get; set;}
        public DateTime? Date { get; set; }
    }
}
