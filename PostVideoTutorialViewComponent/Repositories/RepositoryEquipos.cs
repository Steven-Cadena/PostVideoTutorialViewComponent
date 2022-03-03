﻿using PostVideoTutorialViewComponent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostVideoTutorialViewComponent.Repositories
{
    
    public class RepositoryEquipos
    {
        private List<Equipo> equipos;
        public RepositoryEquipos() 
        {
            this.equipos = new List<Equipo>
            {
                new Equipo{ IdEquipo = 1, Nombre = "Real Madrid C.F", Presidente = "Florentino Perez Rodriguez" ,Estadio = "Estadio Santiago Bernabéu", 
                    Imagen = "data:image/png;base64,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"},
                new Equipo{ IdEquipo = 2, Nombre = "F.C Barcelona", Presidente = "Joan Laporta" ,Estadio = "Camp Nou",
                Imagen = "http://assets.stickpng.com/images/584a9b3bb080d7616d298777.png"},
                new Equipo{ IdEquipo = 3, Nombre = "Atalanta", Presidente = "Gian Piero Gasperini" ,Estadio = "Gewiss Stadium",
                Imagen ="https://w7.pngwing.com/pngs/692/93/png-transparent-atalanta-b-c-2017-18-serie-a-juventus-stadium-stadio-atleti-azzurri-d-italia-a-c-milan-others.png"},
                new Equipo{ IdEquipo = 4, Nombre = "Inter de Milán", Presidente = "Steven Zhang" ,Estadio = "Estadio de San Siro",
                Imagen ="https://img2.freepng.es/20180605/gvf/kisspng-inter-milan-a-c-milan-dream-league-soccer-serie-a-milan-5b16f34374d656.7073799815282307234786.jpg"},
                new Equipo{ IdEquipo = 5, Nombre = "Paris Saint Germain", Presidente = "Nasser Al-Khelaïfi" ,Estadio = "Parque de los Príncipes",
                Imagen ="https://1000marcas.net/wp-content/uploads/2020/10/PSG-logo.png"},
                new Equipo{ IdEquipo = 6, Nombre = "Olympique de Lyon", Presidente = "Jean-Michel Aulas" ,Estadio = "Parc Olympique Lyonnais",
                Imagen ="data:image/png;base64,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"}
            };
        }
        public List<Equipo> GetEquipos() 
        {
            return this.equipos;
        }

        public Equipo FindEquipo(int idequipo) 
        {
            List<Equipo> listequipo = this.GetEquipos();
            return listequipo.FirstOrDefault(z => z.IdEquipo == idequipo);
        }
    }
}
