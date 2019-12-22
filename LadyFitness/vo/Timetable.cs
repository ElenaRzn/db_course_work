
using System;
using System.Collections.Generic;

namespace LadyFitness.vo
{
    public class Timetable
    {

        Dictionary<int, string> week = new Dictionary<int, string>
        {
            { 1, "понедельник" },
            { 2, "вторник" },
            { 3, "среда" },
            { 4, "четверг" },
            { 5, "пятница" },
            { 6, "суббота" },
            { 7, "воскресенье" }
        };
        public string WeekDay { get; set; }

        public string Train { get; set; }

        public string Trainer { get; set; }

        public string Room { get; set; }

        public DateTime Time { get; set; }

        public Timetable(int weekDay, string train, string trainer, string room, DateTime time) 
        {
            this.WeekDay = week[weekDay];
            this.Train = train;
            this.Trainer = trainer;
            this.Room = room;
            this.Time = time;
        }
    }
}
