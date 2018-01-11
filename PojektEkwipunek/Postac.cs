﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektEkwipunek
{
    public abstract class Postac
    {
        public Postac(string imie, int level)
        {
            Imie = imie;
            Level = level;
            Id = Guid.NewGuid();
            Ekwipunek = new List<Przedmiot>();

        }
        public KlasaPostaci Klasa { get; protected set; }
        public Guid Id { get; private set; }
        public string Imie { get; private set; }
        public int Level { get; private set; }
        public double Moc { get; protected set; }
        public double Obrona { get; protected set; }
        public double Udzwig { get; protected set; }
        public double Inteligencja { get; protected set; }
        public string Opis { get; set; }
        public double Obciazenie { get; private set; }
        public List<Przedmiot> Ekwipunek { get; private set; }
        public Przedmiot NakrycieGlowy { get; private set; }
        public Przedmiot LewaReka { get; private set; }
        public Przedmiot PrawaReka { get; private set; }
        public Przedmiot Stroj { get; private set; }
        public Przedmiot Buty { get; private set; }

        public void Zaloz(CzescCiala czescCiala, Przedmiot przedmiot)
        {
            if (przedmiot == null)
            {
                throw new Exception("Musisz podac przedmiot");
            }
            if (Ekwipunek.Find(x => x.Id == przedmiot.Id) == null)// nie ma tg predmiotu w ekwipunku
            {
                throw new Exception("Nie ma tego przedmiotu w ekwipunku");
            }
            if ((int)Klasa.Typ != (int)przedmiot.OgraniczeniaKlasowe && przedmiot.OgraniczeniaKlasowe != KtoMozeNosic.Wszyscy)
            {
                throw new Exception("Ta postac nie moze nosic tego przedmiotu");
            }

            NieodpowiednieMiejsceExeption nieOdpowiednieMiejsce = new NieodpowiednieMiejsceExeption("To nie jest odpowiednie miejsce na ten przedmiot");
            ZajeteMiejsceExeption zajeteMiejsce = new ZajeteMiejsceExeption("To miejsce jet juz zajete");
            switch (czescCiala)
            {
                case CzescCiala.Glowa:
                    if (NakrycieGlowy != null)
                    {
                        throw zajeteMiejsce;
                    }
                    if (przedmiot.Typ != TypPrzedmiotu.NakrycieGlowy)
                    {
                        throw nieOdpowiednieMiejsce;
                    }
                        NakrycieGlowy = przedmiot;
                    break;
                case CzescCiala.LewaReka:
                    if (LewaReka != null)
                    {
                        throw zajeteMiejsce;
                    }
                    if(przedmiot.Typ != TypPrzedmiotu.Bron)
                    {
                        throw nieOdpowiednieMiejsce;
                    }
                    LewaReka = przedmiot;
                    break;
                case CzescCiala.PrawaReka:
                    if (PrawaReka != null)
                    {
                        throw zajeteMiejsce;
                    }
                    if (przedmiot.Typ != TypPrzedmiotu.Bron)
                    {
                        throw nieOdpowiednieMiejsce;
                    }
                    PrawaReka = przedmiot;
                    break;
                case CzescCiala.Tulow:
                    if (Stroj != null)
                    {
                        throw zajeteMiejsce;
                    }
                    if (przedmiot.Typ != TypPrzedmiotu.Stroj)
                    {
                        throw nieOdpowiednieMiejsce;
                    }
                    Stroj = przedmiot;
                    break;
                case CzescCiala.Stopy:
                    if (Buty != null)
                    {
                        throw zajeteMiejsce;
                    }
                    if (przedmiot.Typ != TypPrzedmiotu.Buty)
                    {
                        throw nieOdpowiednieMiejsce;
                    }
                    Buty = przedmiot;
                    break;

                default:
                    break;
            }
        }

        public void Zdejmij(CzescCiala czescCiala)
        {
            switch (czescCiala)
            {
                case CzescCiala.Glowa:
                    NakrycieGlowy = null;
                    break;
                case CzescCiala.LewaReka:
                    LewaReka = null;
                    break;
                case CzescCiala.PrawaReka:
                    PrawaReka = null;
                    break;
                case CzescCiala.Tulow:
                    Stroj = null;
                    break;
                case CzescCiala.Stopy:
                    Buty = null;
                    break;
                default:
                    break;
            }
        }

        public bool DodajPrzedmiotDoEkwipunku(Przedmiot przedmiot)
        {
            //nie dodawac tg samego przedmiotu dwa razy
            if (Ekwipunek.Find(przedmiotWEkwipunku => { return przedmiotWEkwipunku.Id == przedmiot.Id; }) != null)
            {
                return false;
                // ToDo przerobic na rzucanie wyjatkow
            }
            if (Udzwig < Obciazenie + przedmiot.Waga)
            {
                return false;
            }


            Obciazenie += przedmiot.Waga;
            Ekwipunek.Add(przedmiot);

            return true;
        }
        public bool UsunPrzedmiotZEkwipunku(Przedmiot przedmiot)
        {
            if (Ekwipunek.Find(przedmiotWEkwipunku => { return przedmiotWEkwipunku.Id == przedmiot.Id; }) == null)
            {
                return false;
            }
            Obciazenie -= przedmiot.Waga;
            Ekwipunek.Remove(przedmiot);

            return true;
        }
        protected void LevelUp(int level)
        {
            if (level > 1)
            {
                Moc = Moc + .05 * Moc * level;
                Obrona = Obrona + .05 * Obrona * level;
                Udzwig = Udzwig + .05 * Udzwig * level;
            }

        }
    }

}
