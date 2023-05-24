using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_2_Shatilov.AppData
{
    //Класс для связи EntityFramework с приложением
    internal class ConDB
    {
        //Переменная для связи с БД
        private static AttendanceEntities context;
        //Свойство для работы с переменной context, в случае когда значение переменной null создается новый объект
        internal static AttendanceEntities Context { get { return context is null? context = new AttendanceEntities():context; } }
    }
}
