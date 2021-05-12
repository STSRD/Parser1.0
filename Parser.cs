using System;
using System.Collections.Generic;
using System.Text;
using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.Spreadsheets;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Практика
{
    enum Attack_type
    {
        range,
        mele
    };

    enum shell_type
    {
        nothing,
        arrow,
        bolt,
        magic,
        bomb,

    };

    static class Parser
    {
        static private Attack_type convert_string_to_attack_type(string type) {
            switch (type)
            {
                case "Дальняя":
                    return Attack_type.range;
                case "Ближняя":
                    return Attack_type.mele;
                default:
                    return Attack_type.mele;
            }
        }

        static private shell_type convert_string_to_shell_type(string type)
        {
            switch (type)
            {
                case "Стрела":
                    return shell_type.arrow;
                case "Болт":
                    return shell_type.bolt;
                case "Мигия":
                    return shell_type.magic;
                case "Бомба":
                    return shell_type.bomb;
                default:
                    return shell_type.nothing;
            }
        }

        static public Races ParserBuildings(string link) {
            //возвращаемый массив
            List<Building> building = new List<Building>();

            //Чтение данных
            List<string[]> date = new List<string[]>();
            using (TextFieldParser tfp = new TextFieldParser(link)) {
                tfp.TextFieldType = FieldType.Delimited;
                tfp.SetDelimiters(",");

                while (!tfp.EndOfData) {
                    string[] builds = tfp.ReadFields();
                    date.Add(builds);
                }
            }

            //Подсчет строений
            int koll_buildings = date[0].Length / 13;

            //запись списка зданий рассы
            List<Building> buildings = new List<Building>();

            for (int i = 0; i < koll_buildings; i++)
            {
                //запись характеристик зданий
                List<Characteristic> characteristics = new List<Characteristic>();
                for (int j = 0; j < 13; j++)
                {
                    int poz = 1 + i * 13 + j;
                    characteristics.Add(new Characteristic(date[8][poz], int.Parse(date[9][poz]), int.Parse(date[10][poz]), int.Parse(date[11][poz]), int.Parse(date[12][poz]), date[12][poz], date[14][poz], 
                    int.Parse(date[15][poz]), int.Parse(date[16][poz]), float.Parse(date[17][poz]), convert_string_to_attack_type(date[18][poz]), convert_string_to_shell_type(date[19][poz]), 
                    int.Parse(date[20][poz]), int.Parse(date[21][poz]), date[22][poz], float.Parse(date[23][poz])));
                }

                //запись информации о здании
                if (date[5][1+i * 13] != "" && date[5][1 + i * 13] != "-")
                {
                    buildings.Add(new Building(date[1][1 + i * 13], date[2][1 + i * 13], date[4][1 + i * 13], true, characteristics));
                }
                else {
                    buildings.Add(new Building(date[1][1 + i * 13], date[2][1 + i * 13], date[4][1 + i * 13], false, characteristics));
                }
            }
            //запись рассы
            Races races = new Races(date[0][1], buildings);

            return races;



        }
    }
}
