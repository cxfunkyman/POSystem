using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSystem.BLL
{
    public class PO_List //po creation list
    {
        public string RadioPO { get; set; }
        public string Numero { get; set; }
        public string Fournisseur { get; set; }
        public string DemandePar { get; set; }
        public string Soumission { get; set; }
        public string Commentaire { get; set; }
        public string RadioStatut { get; set; }
        public string Approbe { get; set; }
        public string DeuxiemeApprovation { get; set; }
        public string Search { get; set; }

        //default constructor
        public PO_List()
        {

        }

        //Parameterized Constructor
        public PO_List(string search, string radioPO, string fournisseur, string demandePar, string soumission, string commentaire)
        {
            Search = search;
            RadioPO = radioPO;
            Fournisseur = fournisseur;
            DemandePar = demandePar;
            Soumission = soumission;
            Commentaire = commentaire;
        }
        public PO_List(string search, string radioStatut)
        {
            Search = search;
            RadioStatut = radioStatut;
        }
        public PO_List(string search, string approbe, string deuxiemeApprovation)
        {
            Search = search;
            Approbe = approbe;
            DeuxiemeApprovation = deuxiemeApprovation;
        }




    }
}
