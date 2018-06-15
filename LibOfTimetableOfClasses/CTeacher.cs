﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    public class CTeacher
    {
        List <MTeacher> teacherList = new List <MTeacher>();

        public bool AddTeacher(string surname, string name, string middleName, string academicDegree, string AcademicRank, byte SizeOfTeachingExperience)
        {
            throw new Exception();
        }

        public bool SaveTeacher(Guid ID, string surname, string name, string middleName, string academicDegree, string academicRank, byte sizeOfTeachingExperience)
        {
            if (teacherList.Count > 0)
            {
                int i = 0;
                while (!ID.Equals(teacherList[i].Id) || i < teacherList.Count) i++;
                if ((i == teacherList.Count - 1) && (!ID.Equals(teacherList[i].Id))) return false;
                else
                {
                    teacherList[i].Surname = surname;
                    teacherList[i].Name = name;
                    teacherList[i].MiddleName = middleName;
                    teacherList[i].AcademicDegree = academicDegree;
                    teacherList[i].AcademicRank = academicRank;
                    teacherList[i].SizeOfTeachingExperience = sizeOfTeachingExperience;
                    return true;
                }
            }
            else return false;
        }

        public bool DeleteTeacher(Guid ID)
        {
            if (teacherList.Count > 0)
            {
                int i = 0;
                while (!ID.Equals(teacherList[i].Id) || i < teacherList.Count) i++;
                if ((i == teacherList.Count - 1) && (!ID.Equals(teacherList[i].Id))) return false;
                else
                {
                    teacherList.RemoveAt(i);
                    return true;
                }
            }
            else return false;
        }

        public string[,] GetData()
        {
            string[,] DataTeachers = new string[teacherList.Count + 1, sizeof(MTeacher.Keys)];
            //формируем заголовок таблицы
            for (int j = 0; j < DataTeachers.GetLength(1); j++)
                DataTeachers[0, j] = ((MTeacher.Keys)j).ToString();
            //заполняем таблицу
            for (int i = 1; i < DataTeachers.GetLength(0); i++)
                for (int j = 0; j < DataTeachers.GetLength(1); j++)
                    DataTeachers[i, j] = teacherList[i - 1][(MTeacher.Keys)j].ToString();
            return DataTeachers;
        }

        public string[,] GetSortedData(string columnName, bool order)
        {
            throw new Exception();
        }
    }
}
