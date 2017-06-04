using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    class Invoice//Faktura
    {
        //PK Faktury
        public int invoiceId;
        //Nazwa kodowa Faktury
        public string InvoiceName;
        //Tranzakcje w Fakturze(pobrane z tego  Ilosc, Cena, Vat)
        public int invoiceTransactionId;
        //Dane Firmy do faktury (Nazwa, NIP, Adres, Bank, nr Konta)
        public int companyId;
        //Dane Nabywcy do Faktury (Imie nazwisko\NazwaFirmy, NIP, Adres, Tel, Fax, Email, KrajowyRejestrSadowy)
        //(wymagane ImieNazwisko\Nazwa Firmy, NIP, Adres)
        public int clientId;
        //Nazwa banku klienta
        public string clientBankName;
        //Numer Banku Klienta
        public string BankNumber;
        //Data Wystawienia
        public string ExposureDate;
        //Cena netto
        public string costNetto;
        //cena vat
        public string costVat;
        //cena brutto=netto+vat
        public string costBrutto;
        //dodatkowe informacje do faktury
        public string describe;
    }
}
