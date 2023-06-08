namespace TakeCtrl.Api.Entities
{
    public class Firewall
    {
        public int Id { get; set; }
        public string UUID { get; set; }
        public string Description { get; set; }
        public int StartPort { get; set; }
        public int EndPort { get; set; }
        public string Protocol { get; set; }
        public bool isEnabled { get; set; }
    }
}
