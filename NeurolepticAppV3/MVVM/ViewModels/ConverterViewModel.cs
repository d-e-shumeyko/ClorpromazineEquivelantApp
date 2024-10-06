using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NeurolepticAppV3;
using PropertyChanged;
using UnitsNet;


namespace NeurolepticAppV3.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ConverterViewModel
    {

        
        public string CatogoryName { get; set; }
        public ObservableCollection<string> FromMeds { get; set; }
        public ObservableCollection<string> ToMeds { get; set; }
        public string CurrentFromMed { get; set; }
        public string CurrentToMed { get; set; }
        public float FromValue { get; set; } = 1f;
        public float ToValue { get; set; }

        public ICommand ReturnCommand =>
            new Command(() =>
            {
                Convert();
            });

        public ConverterViewModel(string catogoryName)
        {
            CatogoryName = CatogoryName;
            FromMeds = LoadMeds();
            ToMeds = LoadMeds();
            CurrentFromMed = FromMeds.FirstOrDefault();
            CurrentToMed = ToMeds.Skip(1).FirstOrDefault();
            Convert();
        }

        public void Convert()
        {
            
            float CurrentFromCoef = Neuroleptics.Neuro[CurrentFromMed];
            float CurrentToCoef = Neuroleptics.Neuro[CurrentToMed];
            var result = EquivelantCalculation(CurrentFromCoef, CurrentToCoef, FromValue);
            ToValue = result;

        }

        public float EquivelantCalculation(float currentMedCoef, float newMedCoef, float oldDose)
        {
            float newDose;
            newDose = ((oldDose * currentMedCoef) / newMedCoef);
            return newDose;

        }

       
        private ObservableCollection<string> LoadMeds()
        {
            var types =
               Neuroleptics.Neuro.Keys;
            return new ObservableCollection<string>(types);
               

        }
    }
}
