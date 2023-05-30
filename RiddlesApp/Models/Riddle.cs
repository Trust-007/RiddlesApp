using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiddlesApp.Models
{
    public class Riddle
    {
        public int Id { get; set; }

        public string RiddleQuestion { get; set; }

        public string RiddleAnswer { get; set; }

        public Riddle()
        {

        }
    }
}
