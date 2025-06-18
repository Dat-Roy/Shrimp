
namespace ShrimpPond.Domain.Alarm
{
    public class Alarm
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Detail { set; get; } = string.Empty;
        public DateTime AlarmDate { get; set; }
        public int FarmID { get; set; }
        public Domain.Farm.Farm Farm { get; set; }

    }
}