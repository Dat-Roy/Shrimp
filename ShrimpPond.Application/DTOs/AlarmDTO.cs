using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShrimpPond.Application.DTOs
{
    public class AlarmDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Detail { set; get; } = string.Empty;
        public DateTime AlarmDate { get; set; }
    }
}
