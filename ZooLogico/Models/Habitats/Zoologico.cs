using System;
using ZooLogico.Models.Animais;
namespace ZooLogico.Models.Habitats {
    public class Zoologico {
        public Aquario aquario;
        public AquarioGelado aquarioGelado;
        public CasaArvore casaArvore;
        public CavernaPedra cavernaPedra;
        public Gaiola gaiola;
        public Pasto pasto;
        public Piscina piscina;
        public Zoologico () {
            this.aquario = new Aquario ();
            this.aquarioGelado = new AquarioGelado ();
            this.casaArvore = new CasaArvore ();
            this.cavernaPedra = new CavernaPedra ();
            this.gaiola = new Gaiola ();
            this.pasto = new Pasto ();
            this.piscina = new Piscina ();
        }

    }
}