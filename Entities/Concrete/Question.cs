using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Question : IEntity
    {
        public int Id { get; set; }
        public string QuestionName { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string? QuestionImage { get; set; }
        public int Answer { get; set; } // 0dan baslayaraq optionlar - yeni dogru cavabin id-si
    }
}
