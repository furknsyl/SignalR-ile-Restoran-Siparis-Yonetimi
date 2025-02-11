using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWebUI.Dtos.DiningTableDtos
{
    public class UpdateDiningTableDto
    {
        public int DiningTableID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
