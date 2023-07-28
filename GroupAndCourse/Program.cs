using GroupAndCourse;
Course C = new Course();
Group G1 = new Group();
Group G2 = new Group();
Group G3 = new Group();
Group G4 = new Group();
Group G5 = new Group();
string answer;
do
{
    Console.WriteLine("1.Qrup elave et");
    Console.WriteLine("2.Bütün qruplara bax");
    Console.WriteLine("3.Verilmiş point aralığındaki qruplara bax");
    Console.WriteLine("4.Verilmiş nömrəli qrupa bax");
    Console.WriteLine("5.Menudan cix");
     answer = Console.ReadLine();

    switch (answer)
    {
        case "1":

            C.AddGroup(G1);
            C.AddGroup(G2);
            C.AddGroup(G3);
            C.AddGroup(G4);
            C.AddGroup(G5);
            break;
        case "2":
            C.ListGroup(C.groups); break;
        case "3":
            Console.WriteLine("MinPoint qeyd edin");
            int MinPoint = int.Parse(Console.ReadLine());
            Console.WriteLine("MaxPoint qeyd edin");
            int MaxPoint = int.Parse(Console.ReadLine());
            C.GetGroupsByPointRange(MinPoint, MaxPoint);
            break;
        case "4":
            Console.WriteLine("hansi nomreli qrupa baxmaq isteyirsiz?");
        
          string no=Console.ReadLine();
            C.GetGroupByNo(no); break;
        default: break;

    }
} while (!(answer == "5"));