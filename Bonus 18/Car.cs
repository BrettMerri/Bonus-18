using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_18
{
    class Car
    {
        #region Variables

        private string Make;
        private string Model;
        private int Year;
        private double Price;

        #endregion

        #region Properties

        public string CarMake
        {
            get
            {
                return Make;
            }
            set
            {
                Make = value;
            }
        }

        public string CarModel
        {
            get
            {
                return Model;
            }
            set
            {
                Model = value;
            }
        }

        public int CarYear
        {
            get
            {
                return Year;
            }
            set
            {
                Year = value;
            }
        }

        public double CarPrice
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
        }

        #endregion

        #region Constructors

        public Car()
        {
            Make = string.Empty;
            Model = string.Empty;
            Year = 0;
            Price = 0;
        }
        
        public Car(string MakeInput, string ModelInput, int YearInput, double PriceInput)
        {
            Make = MakeInput;
            Model = ModelInput;
            Year = YearInput;
            Price = PriceInput;
        }

        #endregion
    }
}
