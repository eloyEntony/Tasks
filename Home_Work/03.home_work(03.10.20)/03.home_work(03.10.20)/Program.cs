﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Разработать приложение «Резервная копия»
        Цель: произвести расчет необходимого количества внешних носителей информации при переносе за один раз
        важной информации (565 Гб, файлы по 780 Мб) с рабочего компьютера на домашний компьютер и затрачиваемое на данный процесс время.

        Вы имеете в распоряжении следующие типы носителей информации:
        ■ Flash-память,
        ■ DVD-диск,
        ■ съемный HDD.

        Каждый носитель информации является объектом соответствующего класса:
        
        ■ Flash-память — класс «Flash»;
        ■ класс DVD-диск — класс «DVD»;
        ■ класс съемный HDD — класс «HDD».

        Все три класса являются производными от абстрактного класса «Носитель информации» — класс «Storage».

        Базовый класс («Storage») содержит следующие закрытые поля:
        ■ наименование носителя;
        ■ модель.

        Класс обладает всеми необходимыми свойствами для доступа к полям, а также абстрактными методами:

        ■ получение объема памяти;
        ■ копирование данных (файлов/папок) на устройство,
        ■ получение информации о свободном объеме памяти
        на устройстве;
        ■ получение общей/полной информации об устройстве.

        Кроме того, каждый из производных классов дополняется следующими полями:

        ■ класс Flash-память: скорость USB 3.0, объем памяти;
        ■ класс DVD-диск: скорость чтения / записи, тип (односторонний (4.7 Гб) /двусторонний (9 Гб));
        ■ класс съемный HDD: скорость USB 2.0, количество разделов, объем разделов.

        Работа с объектами соответствующих классов производится через ссылки на базовый класс («Storage»), которые хранятся в массиве.
        
        Приложение должно предоставлять следующие возможности:

        ■ расчет общего количества памяти всех устройств;
        ■ копирование информации на устройства;
        ■ расчет времени необходимого для копирования;
        ■ расчет необходимого количества носителей информации представленных типов для переноса информации. 
     
     */

namespace _03.home_work_03._10._20_
{
    class Program
    {
        static void Main(string[] args)
        {
            Work_with_file work = new Work_with_file();

            var list = new List<Storage>();

            Storage flash = new Flash("Flash", "ZD213", 1600);
            double tmp;
                                

            flash.Show_info();
            flash.Copy_fails(300);

            tmp = flash.Get_info_free_memory();
            Console.WriteLine(" Free memory  => {0} Mb", tmp);
            Console.WriteLine("\n===============================================");

            Storage dvd = new DVD("DVD", "FFF", 3.5, 4.5, 2);
            dvd.Show_info();
            dvd.Copy_fails(500);
            tmp = dvd.Get_info_free_memory();
            Console.WriteLine(" Free memory  => {0} Mb", tmp);
            Console.WriteLine("\n===============================================");

            Storage hdd = new HDD("HDD", "Toshiba", 2, 3000);
            hdd.Show_info();
            hdd.Copy_fails(100);
            tmp = hdd.Get_info_free_memory();
            Console.WriteLine(" Free memory  => {0} Mb", tmp);
            Console.WriteLine("\n===============================================");

            list.Add(flash);
            list.Add(dvd);
            list.Add(hdd);

            work.Calculation_of_the_total_amount_of_memory_of_all_devices(list);

            work.Calculation_of_the_time_required_for_copying(16000);

            work.Calculation_of_the_required_number_of_information_carriers_of_the_presented_types_for_information_transfer(5000, 16000);
        }
    }
}
