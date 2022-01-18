using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModels
{
    internal class CalculatorViewModel
    {
        #region Fields
        #endregion 

        #region Ctor
        public CalculatorViewModel()
        {
            _valueText = "0";
        }
        #endregion

        #region Properties
        private string _valueText;
        public string valueText { get { return _valueText; } set { _valueText = value; } }
        #endregion
    }
}
