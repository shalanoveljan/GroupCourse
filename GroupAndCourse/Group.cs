using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAndCourse
{
    internal class Group
    {
        private string _no { get; set; }
        public int Avgpoint;

        public string NO
        {
            get
            {
                return _no;
            }
            set
            {
                if(Check(value))
                _no = value;
                else
                {
                    Console.WriteLine("qrup nomresi null olaraq qaldi");
                }

            }
        }
            


          public static bool Check(string no)
        {
            bool result = false;
            bool Digit = false;
            bool Upper = false;
            if (no.Length == 4)
            {
                if (char.IsUpper(no[0]))
                {
                    Digit= true;
                    for (int i = 1; i < no.Length; i++)
                    {
                        if (char.IsDigit(no[i]))
                        {
                            Upper=true;
                        }
                    }


                }
            }
            else
            {
                Console.WriteLine("Group nomresinin uzunlugu 4 olmalidi");
            }
            result=Digit && Upper;
            return result;
        }
        
    }
}
    

