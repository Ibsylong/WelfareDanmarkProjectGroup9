using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WelfareDanmarkProjectGroup9.Models
{
    public class Counter
    {
        [DataType(DataType.Text)]
        public int Number { get; set; }
    }
}
