using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class UserType
    {
        //PK Usertype
        public int userTypeId;
        //nazwa typu uzytkownika
        public string userTypeName;
        #region Uprawnienia
        //PROFIL
        //Może zarzacac profilem innych;
        public bool profilManage;
        
        //GRAFIK
        //Może zarzadzać grafikiem
        public bool graphicManage;
        //Może wpisac sie na grafik
        public bool graphicRegister;
        
        //PUNKTACJA
        //Może ustawiać punktacje
        public bool pointsManager;

        //MYJNIA
        //Może sie rejestrować na Myjnie
        public bool carWashRegister;
        
        //PALIWO
        //moze zobaczyć ceny paliwa
        public bool fuelCostChecking;
        //może zobaczyć stan Paliwa
        public bool fuelSurvey;

        //RAPORTY
        //Może wystawić Raport
        public bool canSendTransactionRaport;
        //Może przegladac raporty
        public bool checkRaports;

        //ZARZADZANIE CENAMI
        //może Ustawiać ceny Paliwa
        public bool fuelCostManage;
        //może zmieniać ceny Myjni
        public bool washCostManage;
        #endregion
    }
}
