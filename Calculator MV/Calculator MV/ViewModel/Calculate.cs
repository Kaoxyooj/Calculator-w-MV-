using Calculator_MV.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_MV.ViewModel
{
    class Calculate : INotifyPropertyChanged
    {
        UIModel ui;
        //Operator operate;
        //string one;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Value1 { get { return ui.Value1; } set { ui.Value1 = value; NotifyPropertyChanged("Value1"); } }
        public string Value2 { get { return ui.Value2; } set { ui.Value2 = value; NotifyPropertyChanged("Value2"); } }
        public string Operator { get { return ui.operate; } set { ui.operate = value; NotifyPropertyChanged(""); } }
        public double Answer { get { return ui.answer; } set { ui.answer = value; NotifyPropertyChanged(""); } }
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public Calculate()
        {
            this.ui = new UIModel(string.Empty, string.Empty, string.Empty);
        }
    }
}
