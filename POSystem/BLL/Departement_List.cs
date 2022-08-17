using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSystem.BLL
{
    public class Departement_List //departement list
    {
        public string DeptID { get; set; }
        public string Departement { get; set; }
        public string Approbation { get; set; }
        public string Montant { get; set; }

        public Departement_List(string deptId, string departement, string approbation, string montant)
        {
            DeptID = deptId;
            Departement = departement;
            Approbation = approbation;
            Montant = montant;
        }
        public Departement_List(string departement, string approbation, string montant)
        {
            Departement = departement;
            Approbation = approbation;
            Montant = montant;
        }
    }
}
