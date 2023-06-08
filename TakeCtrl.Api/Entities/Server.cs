using System.ComponentModel.DataAnnotations;

namespace TakeCtrl.Api.Entities
{
    public class Server
    {
        //public int Id { get; set; }
        [Key] public string UUID { get; set; }
        public string Name { get; set; }
        public int CPUAmount { get; set; }
        public int DiskSize { get; set; }
        public int MemorySize { get; set; }
        public string Status { get; set; }
        public string IPAddress { get; set; }
    }
}
