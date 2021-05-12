using System;
using System.Collections.Generic;
using System.Text;

namespace Практика
{
    class Characteristic
    {
        string Tipe;
        int Cost;
        int Destr_income;
        int Heals;
        int Range_attack;
        DMG DMG_solders;
        DMG DMG_building;
        int Attack_speed;
        float KD_attack;
        float Time_training;
        Enum Tipe_attack;
        Enum Missile;
        int Gold_income;
        int Gold_income_kd;
        string Bonus;
        float Time_build;

        public Characteristic(string Tipe,
        int Cost,
        int Destr_income,
        int Heals,
        int Range_attack,
        string DMG_solders,
        string DMG_building,
        int Attack_speed,
        int KD_attack,
        float Time_training,
        Enum Tipe_attack,
        Enum Missile,
        int Gold_income,
        int Gold_income_kd,
        string Bonus,
        float Time_build){
            this.Tipe = Tipe;
            this.Cost = Cost;
            this.Destr_income = Destr_income;
            this.Heals = Heals;
            this.Range_attack = Range_attack;

            string[] a = DMG_solders.Split('-');
            this.DMG_solders = new DMG(int.Parse(a[0]), int.Parse(a[1]));
            a = DMG_building.Split('-');
            this.DMG_building = new DMG(int.Parse(a[0]), int.Parse(a[1]));
            this.Attack_speed = Attack_speed;
            this.KD_attack = KD_attack;
            this.Time_training = Time_training;
            this.Tipe_attack = Tipe_attack;
            this.Missile = Missile;
            this.Gold_income = Gold_income;
            this.Gold_income_kd = Gold_income_kd;
            this.Bonus = Bonus;
            this.Time_build = Time_build;
        }
    }
}
