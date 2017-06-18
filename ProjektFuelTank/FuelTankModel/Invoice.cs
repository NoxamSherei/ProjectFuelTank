using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class Invoice//Faktura
    {
        //PK Faktury
        public int InvoiceId;
        //Nazwa kodowa Faktury
        public string InvoiceName;
        //Tranzakcje w Fakturze(pobrane z tego  Ilosc, Cena, Vat)
        public int InvoiceTransactionId;
        //Dane Firmy do faktury (Nazwa, NIP, Adres, Bank, nr Konta)
        public int CompanyId;
        //Dane Nabywcy do Faktury (Imie nazwisko\NazwaFirmy, NIP, Adres, Tel, Fax, Email, KrajowyRejestrSadowy)
        //(wymagane ImieNazwisko\Nazwa Firmy, NIP, Adres)
        public int ClientId;
        //Nazwa banku klienta
        public string ClientBankName;
        //Numer Banku Klienta
        public string BankNumber;
        //Data Wystawienia
        public string ExposureDate;
        //Cena netto
        public string CostNetto;
        //cena vat
        public string CostVat;
        //cena brutto=netto+vat
        public string CostBrutto;
        //dodatkowe informacje do faktury
        public string Describe;
    }
}
