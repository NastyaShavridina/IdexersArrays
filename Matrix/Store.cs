using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class Store
    {
        //Создать класс Store, содержащий закрытый массив элементов типа Article.

        private Article [] Articles { get; set; }

        public Store()
        {
            Articles = new Article[10]; 
        }

        public Article this[int index]
        {
            get
            {
                return Articles[index];
            }
            set
            {
                Articles[index] = value;
            }
        }
    }
}
