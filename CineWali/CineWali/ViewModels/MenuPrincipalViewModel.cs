using CineWali.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CineWali.ViewModels
{
    class MenuPrincipalViewModel
    {
        public ObservableCollection<Filme> filmes { get; set; }

        public ObservableCollection<Filme> GetFilmes()
        {
            return new ObservableCollection<Filme>
             {
                 new Filme{Nome = "Tenet", Sinopse = "", Capa = "https://images-na.ssl-images-amazon.com/images/I/91q8qvm88VL.jpg", Classification = ""},
                 new Filme{Nome = "Batman Cavalheiro das Trevas", Sinopse = "", Capa = "https://i.pinimg.com/originals/cc/47/a5/cc47a507854dfe4ea145ebb4c9ae51c4.jpg", Classification = ""},
                 new Filme{Nome = "Um Lugar Silencioso", Sinopse = "", Capa = "https://upload.wikimedia.org/wikipedia/pt/2/2f/Lugar_Silencioso_2018.png", Classification = ""},
                 new Filme{Nome = "Sonic O Filme", Sinopse = "", Capa = "https://upload.wikimedia.org/wikipedia/pt/1/16/Sonic_the_Hedgehog_1991_capa.png", Classification = ""}
             };
        }


        public MenuPrincipalViewModel()
        {
            filmes = GetFilmes();
        }
    }
}
