﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Задание 1. Реализовать программу “Строительство дома”
Реализовать:
•	 Классы
■ House (Дом), Basement (Фундамент), Walls (Стены),
Door (Дверь), Window (Окно), Roof (Крыша);
■ Team (Бригада строителей), Worker (Строитель),
TeamLeader (Бригадир).
•	 Интерфейсы
■ IWorker, IPart.

Все части дома должны реализовать интерфейс IPart
(Часть дома), для рабочих и бригадира предоставляется
базовый интерфейс IWorker (Рабочий).

Бригада строителей (Team) строит дом (House). Дом
состоит из фундамента (Basement), стен (Wall), окон
(Window), дверей (Door), крыши (Part).

Согласно проекту, в доме должно быть 1 фундамент,
4 стены, 1 дверь, 4 окна и 1 крыша.
Бригада начинает работу, и строители последовательно
“строят” дом, начиная с фундамента. 
Каждый строитель не знает заранее, 
на чём завершился предыдущий этап
строительства, поэтому он “проверяет”, 
что уже построено и продолжает работу. 

Если в игру вступает бригадир
(TeamLeader), он не строит, а формирует отчёт, что уже
построено и какая часть работы выполнена.
В конечном итоге на консоль выводится сообщение, что
строительство дома завершено и отображается “рисунок
дома” (вариант отображения выбрать самостоятельно).
*/

namespace _02.home_work_03._05._20_
{
    class Program
    {
        static void Main(string[] args)
        {
            uint component;
            var house = new House();
            var team = new Team();
            var teamlead = new TeamLeader();

            //team.Build_house(house);
            ////teamlead.Chack_work(house);
            //team.Build_house(house);
            //team.Build_house(house);
            //team.Build_house(house);
            //team.Build_house(house);
            ////teamlead.Chack_work(house);
            //team.Build_house(house);
            //team.Build_house(house);
            //team.Build_house(house);
            ////teamlead.Chack_work(house);
            ///

            var basement = new Basemetn();
            component = basement.Count_part();
            house.Add_part(component);
            house.Show_part_counter();

            var walls = new Walls();
            component = walls.Count_part();
            house.Add_part(component);
            house.Show_part_counter();

            var window = new Window();
            component = window.Count_part();
            house.Add_part(component);
            house.Show_part_counter();

            var door = new Door();
            component = door.Count_part();
            house.Add_part(component);
            house.Show_part_counter();

            var roof = new Roof();
            component = roof.Count_part();
            house.Add_part(component);
            house.Show_part_counter();



        }
    }
}
