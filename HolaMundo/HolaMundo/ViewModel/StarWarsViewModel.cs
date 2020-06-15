using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using HolaMundo.Model;
using HolaMundo.Services;

namespace HolaMundo.ViewModel 
{
    public class StarWarsViewModel : INotifyPropertyChanged
    {
        private bool isBusy;
        public bool IsBusy
        {
            get
            {
                return isBusy;
            }
            set
            {
                isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        private People personajePrincipal;
        public People PersonajePrincipal
        {
            get
            {
                return personajePrincipal;
            }
            set
            {
                personajePrincipal = value;
                OnPropertyChanged("PersonajePrincipal");
            }
        }

        public async Task LoadViewModel()
        {
            IsBusy = true;
            DatabaseService databaseService = new DatabaseService();

            //PeopleService peopleService = new PeopleService();
            //PersonajePrincipal = await peopleService.GetPeople("1");

            //List<People> listapersonajes = new List<People>();
            //listapersonajes.Add(PersonajePrincipal);

            // await databaseService.Store(listapersonajes);


            //
            PersonajePrincipal = (await databaseService.GetPeople())[0];

            IsBusy = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
