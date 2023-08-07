﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize master
            var masterList = new List<MarticalArt>()
            {
                new MarticalArt(){ Id=1, Name="Amy", Age=18, Menpai="Mafia",Kungfu="SuperPunch", Level=9},
                new MarticalArt(){ Id=2, Name="Bill", Age=22, Menpai="Eagle",Kungfu="SuperKick", Level=7},
                new MarticalArt(){ Id=3, Name="Candy", Age=45, Menpai="Mafia",Kungfu="RKO", Level=9},
                new MarticalArt(){ Id=4, Name="David", Age=13, Menpai="Hawk",Kungfu="SuperPunch", Level=4},
                new MarticalArt(){ Id=5, Name="Eren", Age=19, Menpai="Mafia",Kungfu="RKO", Level=5},
                new MarticalArt(){ Id=6, Name="Frank", Age=58, Menpai="Troy",Kungfu="619", Level=9},
                new MarticalArt(){ Id=7, Name="Gary", Age=48, Menpai="Hawk",Kungfu="619", Level=9},
                new MarticalArt(){ Id=8, Name="Harris", Age=32, Menpai="Hawk",Kungfu="SuperPunch", Level=15},
                new MarticalArt(){ Id=9, Name="Ivy", Age=40, Menpai="Eagle",Kungfu="SuperKick", Level=13},
                new MarticalArt(){ Id=10, Name="Jay", Age=17, Menpai="Eagle",Kungfu="619", Level=24},
                new MarticalArt(){ Id=11, Name="Kevin", Age=36, Menpai="Troy",Kungfu="SuperPunch", Level=5}
            };

            //Initialize kungfu
            var kungfuList = new List<Kungfu>()
            {
                new Kungfu(){Name="SuperPunch", K_Id=1, Power=10 },
                new Kungfu(){Name="SuperKick", K_Id=2, Power=19 },
                new Kungfu(){Name="RKO", K_Id=3, Power=45 },
                new Kungfu(){Name="619", K_Id=4, Power=31 }
            };

            //check all level higher than 8
            //var res = new List<MarticalArt>();
            //foreach (var temp in masterList)
            //{
            //    if (temp.Level > 8)
            //    {
            //        res.Add(temp);
            //    }
            //}

            //Use LinQ to check (The expression)
            //var res = from m in masterList //check from the masterList
            //          where m.Level > 8 && m.Age>30//the select condition
            //          select m.Name; //return result selected m

            //Use LinQ in expansion expression
            //var res = masterList.Where(Filter);
            var res = masterList.Where(m=>m.Level>8 && m.Age>49); //Lambda expression
            foreach (var m in res)
            {
                Console.WriteLine(m.ToString());
                //Console.WriteLine(m);//Same as above
            }

            bool Filter(MarticalArt marticalArt)
            {
                return marticalArt.Level > 8;
            }
        }
    }
}
