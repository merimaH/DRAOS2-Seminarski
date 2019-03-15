using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace RoboticParkingSystem
{
    class Client
    {
        private static int brojKlijenata = 0;
        
        private String firstName;
        private String lasteName;
        private String adress;
        private Image fingerprint;
        private String registracija;
        private Payment payment;
        private String vozacka;
        private int id; // id za uparivanje sa paymentima

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Registracija
        {
            get { return registracija; }
            set { registracija = value; }
        }

        public String  Vozacka
        {
            get { return vozacka; }
            set { vozacka = value; }
        }

        
        private int pinCode;
        
        public int PinCode
        {
            get { return pinCode; }
            set { pinCode = value; }
        }

        public Payment Payment
        {
            get { return payment; }
            set { payment = value; }
        }

        public String Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public Image Fingerprint
        {
            get { return fingerprint; }
            set { fingerprint = value; }
        }
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public String LastName
        {
            get { return lasteName; }
            set { lasteName = value; }
        }
        public Client(String firstName,String lastName,String adress,Image fingerprint,String registracija, String vozacka,Payment payment)
        {
            Client.brojKlijenata += 1;
            this.id = Client.brojKlijenata;
            this.firstName = firstName;
            this.lasteName = lastName;
            this.adress = adress;
            this.fingerprint = fingerprint;
            this.registracija = registracija;
            this.vozacka = vozacka;
            this.payment = payment;
        }
        public Client(String firstName, String lastName, String adress, Image fingerprint, String registracija, String vozacka)
        {
            Client.brojKlijenata += 1;
            this.id = Client.brojKlijenata;
            this.firstName = firstName;
            this.lasteName = lastName;
            this.adress = adress;
            this.fingerprint = fingerprint;
            this.registracija = registracija;
            this.vozacka = vozacka;
            this.payment = null;
        }




    }
}
