namespace TakeCtrl.Api.Models.Dtos
{
    public class UsageDto
    {
        public int CpuAvg { get; set; }
        public int DiskReadAvg { get; set; }
        public int DiskWriteAvg { get; set; }
        public int NetworkInAvg { get; set; }
        public int NetworkOutAvg { get; set; }
    }
}
