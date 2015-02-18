using ConsolidatingKnowledge.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidatingKnowledge.VM
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
       
        private int _id;
        private string _nome;
        private RelayCommand command;
        private DelegateCommand<int> commando;

        public DelegateCommand<int> Commando
        {
            get
            {
                if (commando == null)
                {
                    commando = new DelegateCommand<int>(UpdateName);
                }

                return commando;
            }
            set { commando = value; }
        }
        //public RelayCommand Command
        //{
        //    get
        //    {
        //        if (command == null)
        //        {
        //            command = new RelayCommand(UpdateName);
        //        }

        //        return command;
        //    }
        //    set { command = value; }
        //}


        public int Id
        {
            get { return _id; }
            set
            {
                if (value != this._id)
                {
                    _id = value;
                    OnNotifyPropertyChanged();
                }
            }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                OnNotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnNotifyPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        private void UpdateName(int Id)
        {
            this.Nome = "Felipe";
            int id = int.Parse(Id.ToString());
        }
    }
}
