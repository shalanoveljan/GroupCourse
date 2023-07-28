using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace GroupAndCourse
{
    internal class Course
    {
        public string name { get; set; }
        public Group[] groups=new Group[0];
       


        public  void  AddGroup(Group group)
        {
           
            Console.WriteLine("please enter Group_no");
            group.NO = Console.ReadLine();
            if (group.NO != null)
            {
                if (Group.Check(group.NO))
                {
                    Console.WriteLine("please enter group_avgPoint");
                    group.Avgpoint = Convert.ToInt32(Console.ReadLine());
                    Array.Resize(ref groups, groups.Length + 1);
                    groups[groups.Length - 1] = group;
                    Console.WriteLine("group elave edildi");
                }
            }
            else
            {
                Console.WriteLine("grupun nomresi yanlis qeyd edilib");
            }
        }


        public  void ListGroup(Group[] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {

                Console.WriteLine("{0}----->{1}", groups[i].NO, groups[i].Avgpoint);
            }

        }

        public  void GetGroupByNo(string no)
        {
            
            for (int i = 0; i < groups.Length; i++)
            {
                if (groups[i].NO == no)
                {

                    Console.WriteLine("{0}----->{1}", groups[i].NO, groups[i].Avgpoint);
                    //Console.WriteLine(groups[no]);
                }
                else
                {
                    Console.WriteLine($"{no} nomreli qrup Course-da yoxdur");
                }
            }

        }

        public  void GetGroupsByPointRange(int minPoint, int maxPoint)
        {
            for (int i = minPoint; i < maxPoint; i++)
            {
                

                Console.WriteLine("{0}----->{1}", groups[i].NO, groups[i].Avgpoint);
            }

        }
    }
}
