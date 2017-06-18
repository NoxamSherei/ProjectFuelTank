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
        public int UserTypeId;
        //nazwa typu uzytkownika
        public string UserTypeName;
        #region Uprawnienia
        //PROFIL
        //Może zarzacac profilem innych;
        public bool ProfilManage;
        
        //GRAFIK
        //Może zarzadzać grafikiem
        public bool GraphicManage;
        //Może wpisac sie na grafik
        public bool GraphicRegister;
        
        //PUNKTACJA
        //Może ustawiać punktacje
        public bool GointsManager;

        //MYJNIA
        //Może sie rejestrować na Myjnie
        public bool CarWashRegister;
        
        //PALIWO
        //moze zobaczyć ceny paliwa
        public bool FuelCostChecking;
        //może zobaczyć stan Paliwa
        public bool FuelSurvey;

        //RAPORTY
        //Może wystawić Raport
        public bool CanSendTransactionRaport;
        //Może przegladac raporty
        public bool CheckRaports;

        //ZARZADZANIE CENAMI
        //może Ustawiać ceny Paliwa
        public bool FuelCostManage;
        //może zmieniać ceny Myjni
        public bool WashCostManage;
        #endregion
    }
}
