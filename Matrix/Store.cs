using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer
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

        public Article this[string index]
        {
            get
            {
                foreach (var a in Articles)
                {
                    if (a.ProductName == index)
                    {
                        return a;
                    }
                }

                return null;
            }
        }

    }
}
