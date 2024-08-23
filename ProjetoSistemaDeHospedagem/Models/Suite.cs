using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSistemaDeHospedagem.Models
{
    public class Suite
    {
        public Suite() {}

        public Suite(string suiteType, int capacity, decimal roomRate)
        {
            SuiteType = suiteType;
            Capacity = capacity;
            RoomRate = roomRate;
        }

        public string SuiteType { get; set; }
        public int Capacity { get; set; }
        public decimal RoomRate { get; set; }
    }
}