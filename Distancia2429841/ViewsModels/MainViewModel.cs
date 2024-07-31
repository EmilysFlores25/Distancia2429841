using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia2429841.ViewsModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _puntox1;
        [ObservableProperty]
        private double _puntoy1;
        [ObservableProperty]
        private double _puntox2;
        [ObservableProperty]
        private double _puntoy2;
        [ObservableProperty]
        private string _distancia;


        [RelayCommand]
        private void CalDistancia()
        {
            var distancia = Math.Sqrt(
                Math.Pow(Puntox1 - Puntox2, 2) +
                Math.Pow(Puntoy1 - Puntoy2, 2)
            );
            Distancia = distancia.ToString("F2");
        }
    }
}
