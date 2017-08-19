using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Basic { get; set; }
        public double Medical { get; set; }
        public double Conveyance { get; set; }
        public double increment { get; set; }
        public int NumberOFIncrement { get; set; }
        private double NewBasic { get; set; }
        private double incbasic { get; set; }
        public double setIncrement()
        {
            NewBasic = Basic;
            double bonus = 0;
            bonus= (Basic * (increment / 100));
            NewBasic=bonus+NewBasic;
            Basic = NewBasic;
            return NewBasic;
        }

        public double calculateMedical()
        {
            double newMedical = 0;
            newMedical = NewBasic * (Medical / 100);
            return newMedical;
        }

        public double calculateConvenacne()
        {
            double newConvenance = 0;
            newConvenance = NewBasic * (Conveyance / 100);
            return newConvenance;
        }

        public double calculateTotal()
        {
            double totalValue = 0;
            return totalValue = setIncrement() + calculateConvenacne() + calculateMedical();


        }




    }
}
