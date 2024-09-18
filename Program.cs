using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace Linq1
{

    static class ExtClass { static int MySum(this int x, int y) { return x + y; } }
    internal class Program
    {
       

        static void Main(string[] args)
        {

            #region ExpressionVsStatement

            //// Declaration statement.
            //int counter;

            //// Assignment statement.
            //counter = 1;

            //// Declare and initialize
            //const double pi = 3.14159; // Declare and initialize  constant.

            //// foreach statement
            //foreach (var item in new int[] { 1, 2, 3 })
            //{

            //}

            //// for statement
            //for (int i = 0; i < 10; i++)
            //{

            //}

            //// if , if - else if -else , 
            //if (true)
            //{

            //}

            //// switch, jump, do, while 


            //// Expresion 
            //var radius = 10;

            //var area = 3.14 * (radius * radius); // expression  3.14 * (radius * radius) yield a value

            //// method invocation (this method yield void
            //Console.WriteLine(area);

            //// new object creation 
            //var names = new string[] { "ali", "ahmad", "reem" };

            //// statement can include expression and not the other way around




            ///*Expressions
            // Definition: An expression is a piece of code that evaluates to a value. 
            // It can be as simple as a single value or more complex involving operators and function calls.
             
            // Examples:
             
            // 5 (a constant expression)
            // 2 + 3 (an arithmetic expression that evaluates to 5)
            // Math.Max(3, 5) (a method call that evaluates to the maximum of the two arguments)
            // a * b (where a and b are variables, and the expression evaluates to their product)
            // Usage: Expressions can be used wherever a value is expected, such as in assignments or as arguments to functions. For example:
             
            // csharp
            // Copy code
            // int result = 2 + 3; // Here, `2 + 3` is an expression that evaluates to `5`*/



            ///*statements
            //Definition: A statement is a complete unit of execution. It performs an action but does not return a value.
            //Statements typically involve some operation or control flow.
            
            //Examples:
            
            //Assignment statement: int x = 5; (assigns the value 5 to x)
            //If statement:
            //csharp
            //Copy code
            //if (x > 0) 
            //{
            //   Console.WriteLine("Positive");
            //}
            //This checks a condition and executes a block of code based on that condition.
            //For loop:
            //csharp
            //Copy code
            //for (int i = 0; i < 10; i++)
            //{
            //   Console.WriteLine(i);
            //}
            //This executes a block of code multiple times based on the loop’s condition.
            //Return statement: return x; (exits from a method and optionally returns a value)
            //Usage: Statements are used to perform actions such as creating variables, controlling program flow, 
            //or calling methods. They form the core structure of the program logic.*/

            #endregion

            #region note

            //when do that ,( return ; ) its the same as return null
            
            static void DoSomething()
            {
                return;
            }

            //طلع كمان ينفع ندكلير فانكشن جوا المين و تقريبا جوا اي فانكشن كمان

            #endregion

            #region PureVsImpure functions


            ////ببساطة البيور فانكشن هي الفانكشن الي اولا الي الانبوتس الي داخلين ليه ك بارمترز بيفضلوا زي ما هما
            ////و كمان ملهاش تفاعل مع العالم الخارجي و ملهاش سايد ايفيكت 
            ////و الام بيور طبعا العكس دي مفهومة
            ////بمعني

            ////مثلا لو عندي فانكشن زي دي 
            //int x = 5;
            //void PrintNum(ref int x) { x++; Console.WriteLine(x); }
            //PrintNum(ref x);

            ////هنا الي حصل انه انا دخلتله قيمة الاكس كانت ب 5 يعني دخلت ب 5 و طلعت ب 6 معني كدة الانبوت دخل بقيمة 
            ////و طلع بقيمة تانية و كدة دي تبقي ام بيور فانكشن
            ////و كمان كدة عمل سايد ايفيكت لاني لو جيت استخدم الاكس ده في حتة تانية هلاقي قيمته متغيرة
            ////و كمان هو اتفاعل مع العالم الخارجي بالتالي هو كدة ام بيور فانكشن وش و كذلم الامر بقا مع اي حاجة تانية
            ////نفس الفكرة



            #endregion

            #region note & revision

            //List<int> List1 = new List<int>() { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 };
            //foreach (var item in List1) { Console.WriteLine(item); }


            ////مينفعش نعمل اوبجكت من الانترفيس لكن ينفع نعمل منه ريفرنس يشاور علي اوبجكت من الحاجات الي بيورث ليها نفسه
            //ICollection<int> col1 = new List<int>() { 1 , 2 , 3 , 4 , 5 , 6}; 
            //List1.AddRange(col1);
            //foreach (var item in List1) { Console.WriteLine(item); } //هيزودهم عالقديم مش هيمسح القديم 


            //List1.Clear();
            //foreach (var item in List1) { Console.WriteLine(item); }  // بيمسح كل حاجة


            ////المهم يعني
            //List<int> Source = new List<int>() { 5, 4, 3, 2, 1 };
            ////List<int> dest = new List<int>(); ---> هيكريت ليست فاضية 

            ////الجملة الي جاية دي بتخليني اخد نسخة من القيم الي في ليست السورس احطها هنا في الليست دي
            ////خد بالك انا كدة مساوتش الرفرنسز ببعض بدليل انك هتلاقي الهاش كود مختلف و لكن حطيت نفس القيم بس
            //List<int> dest = new List<int>(Source);
            //foreach (var item in dest) { Console.WriteLine(item); }


            ////عشان نبعت الفانكشن ك برامتر لازم نبعت ديليجت

            #endregion

            #region note

            //IEnumerable<Employee> vs. List<Employee> --> Recall it
            //Higher order function --> has a function as a paramter or returns function
            //Linq is Language INtergated Query

            #endregion

            #region Functiona programming vs Procedural programming , Procedural programming with ext methods

            //ممكن تراجع النظري منها بس من الفيديو 2
            //شارح فيها مفس فكرة فانكشنز الفلترة للموظفين من غير ديليجتس و ب ديليجتس
            //نفس الي كان مشروح وانت عامله في الاي تي اي ---> ممكن تراجعه من الفولدر بتاعها لو ناسيه

            #endregion

            #region recall ext methods

            //int x = 55;
            //Console.WriteLine(x.MySum(5));



            #endregion

            #region Notes
            //Linq can only work with types with IEnumreables (built in ---> Array , List , ....)
            //or made IEnumreables by the user
            //Can not work with ArrayList as it does not ihnhert from IEnumrables
            //لان اي عملية فلترة مثلا بال 
            //Where 
            //بترجع
            //IEnumrable<حاجة>
            //All Linq are Pure functionssss ---> مبتغيرش في الانبوت
            //Lazy excuation vs Immidaite excuation ---> شارحها بالتفصيل و ازاي بتحصل في الميموري
            //                                      ---> و ازاي اللينكيو بتحصل في الميموري , راجها من الفيديو
            //مميزات لينكيو و ليه استخدمها و امتي
            #endregion

            #region Linq 

            #region about Linq 

            ////شوفت انت الفلتريشن الي كنا عاملينه فوق ده و اللينكيو بتعمل نفس القصة بالظبط و لكن بيلت ان تقدر تستخدمها 
            ////علطوول
            ////نقدر نطبق اللينكيو علي اي حاجة بشرط انها تكون 
            ////Enummerable
            ////List<int> , List<Employee> ,,,,,

            //// 2 ways to use Linq , Method or Extension syntax , Query syntax

            //// 1- Method or Extension syntax
            ////   ---> var list1 = Elist.Where(x => x > 5) 
            ////Or ---> var list1 = Enumerable.Where(Elist , x => x > 5)


            //// 2- Query syntax   --> عكس الاس كيو ال , الفروم الاول بعدها السيلكت
            ////      var list1 = from n in Elist
            ////                  where n.Age > 25
            ////                  select n; 
            ////
            ////foreach (Employee item in list1) { Console.WriteLine(item); }

            ////افتكر تاني 
            ////Linq works with Enumrables onlyyy
            ////بالتالي اقدر استقبل الي راجع منها في 
            ////IEnumerable<حاجة>
            ////وانا متطمن

            ////كمان اللينكيو بتاخد دايما انانيموس فانكشن
            ////و كلها معمولة بالفانكشنل برجرامينج ----> راجعها
            ////راجع مزاياها و بنلجأ ليها امتي


            //var Elist = Reposetory.GetRepo();
            ////foreach (Employee item in Elist) { Console.WriteLine(item); }
            #endregion

            #region Where
            ////Where

            ////Where(Predicate) ---> predicate is an Ananymous function --> predicate input is
            ////                                                         --> the type used inside the list(Employee ,,,,)
            ////                                                         --> its output must be bool
            //// list5 = Elist.Where(x => x.Age > 30);   --> x is Employee as its array of employees and its the input
            ////                                         --> of the predicate
            ////                                         --> x.Age > 30 --> its a boolian and its the output of the 
            ////                                         --> predicate

            //// خد بالك انا هنا بتكلم علي انبوت و اوتبوت البرديكيت الي هو الانانيموس فانكشن الي بديها لل وير
            //// مش الوير نفسها لان الوير نفسها بديلها برديكيت و الاوتبوت بتاعها بيكون ليست برضه بس علي حسب الكومديشن بقا



            //var list2 = Elist.Where(x => x.Salary > 20000);
            //foreach (Employee item in list2) { Console.WriteLine(item); }

            //Console.WriteLine("==========================================");    

            //list2 = Elist.Where(x => x.IsMarried);
            //foreach (Employee item in list2) { Console.WriteLine(item); }

            //Console.WriteLine("==========================================");

            //list2 = Elist.Where(x => x.Gender == 'F'  && x.IsMarried  );
            //foreach (Employee item in list2) { Console.WriteLine(item); }

            //Console.WriteLine("==========================================");

            //list2 = from n in Elist
            //        where n.IsMarried & n.Gender == 'M'
            //        select n;
            //foreach (Employee item in list2) { Console.WriteLine(item); }

            //Console.WriteLine("==========================================");
            #endregion


            #region Select
            //var Elist = Reposetory.GetRepo();
            //var list3 = Elist.Where(x => x.IsMarried).Select(x => x.Gender);
            //foreach (var item in list3) { Console.WriteLine(item); }

            //Console.WriteLine("==========================================");


            //var list4 = Elist.Where(x => x.Salary > 15000).Select(x => x.Name);
            //foreach (var item in list4) { Console.WriteLine(item); }

            //Console.WriteLine("==========================================");

            //var list5 = Enumerable.Where(Elist, x => x.Age < 30); // دي الطريقة التانية من الاكستينشن ميثود هي هي 


            //var list6 = from n in Elist
            //            where n.Gender == 'M'
            //            select n;
            //foreach (var item in list6) { Console.WriteLine(item); } // هنا هيطبع كل حاجة

            //Console.WriteLine("==========================================");

            //var list7 = from n in Elist
            //        where n.Gender == 'M'
            //        select n.Name;
            //foreach (var item in list6) { Console.WriteLine(item); } // هنا هيطبع كل حاجة

            //Console.WriteLine("==========================================");


            ////Review select() 


            ////Select(Selector) ---> predicate is an Ananymous function --> redicate input is 
            ////                                                         --> the type used inside the list(Employee ,,,,)
            ////                                                         --> its output , we can determine it
            ////                                                         --> can select the names only or the ages
            ////                                                         --> or every thing so the output of the selector
            ////                                                         --> may be string , num , employe ,,,,,,

            //// خد بالك تاني هنا بتكلم علي انبوت و اوتبوت السليكتور الي هو الانانيموس فانكشن الي بديها لل سيلكت
            //// مش السيلكت نفسها لان السلكت نفسها بديلها برديكيت و الاوتبوت بتاعها بيكون غير معروف ممكن يكون جدول الاسامي
            //// او جدول الاعمار بس او علي حسب الكونديشن ----> عشان كدة اذا حضر السيليكت حضر الفار يا سادة
            //// الفار === var




            ////2 -Review using Select to project type to another type from vid4
            //var list8 = Elist.Select(x =>
            //{

            //    return new Employee { Age = 30, IsMarried = true };
            //});
            ////هنا انت محولتش هو هو نفس التايب و لكن انا بوضح الفكرة بس انك ممكن تريتيرن نوع تايب تاني زي مثلا
            ////return new EmplpyeeV02 { MaritalState = x.IsMarried , Total salary = x.Salary + 1000 }
            ////و كدة تكون بترجع بقا تايب جديد تاني خالص ----> طبعا التايب الجديد ده هو كلاس مودود عادي و معمول مسبقا 
            ////يا حناكة


            //// خد بالك كدة كدة الي الوير و السيليكت بتعمله 
            ////بتمشي علي كل عنصر في الليست و تتشيك عليه او تسيلكت منه علي حسب الكونديشن
            ////var list4 = Elist.Where(x => x.Salary > 15000).Select(x => x.Name);
            ////بيمشي علي كل عنصر و يشيك هل مرتبه اعلي من 15000 ولا لا و يختار اسمه و يسلكته
            ////لو كانت جملة وير بس كان هيختار و يرجع كل الميمبر مش الاسم بس



            //var list9 = Elist.Where(x => x.Age == 30);
            //foreach (var item in list9) { Console.WriteLine(item); }


            ////3 -Transforming from Salary to Salary + 1520
            //var list10 = Elist.Where(x => x.Gender == 'M').Select(x => x.Salary + 1520);
            //foreach (var item in list10) { Console.WriteLine(item); }


            #endregion

            #region Select many

            // // بستخدمها لما بكون عايز اختار او اسليكت بشكل داخلي من الحاجات الي عملتلها سيليكت
            // // يعني مثلا زي الليست بتاعت المهارات الي عند الموظف ---> السيلكت اخرها تجيبلي الليستة بتاعت اي موظف مثلا
            // // لكن لو مثلا عايز اختار مهارة معينة عند موظف معين او اختارهم كلهم بس اختار كل مهارة لكل مظف لوحدها 
            // // و اعرضها في سطر لوحدها

            // var Elist = Reposetory.GetRepo();

            // // هنا جملة سيليكت عادية هتختارلي الليستة بتاعت كل موظف بس و متعرفش تختار اكتر من كدة
            // var list1 = Elist.Select(x => x.Skills);
            // foreach (var item in list1) { Console.WriteLine(item); }


            // // هنا دي جملة سيليكت ميني قدرت بيها اختار كل مهارة عند كل موظف لوحده يعني هملت سيلكت داخلي للسيلكت الاساسي
            // var list2 = Elist.SelectMany(x => x.Skills);
            // Console.WriteLine(list2);
            // foreach (var item in list2) { Console.WriteLine(item); }


            // //مثال تاني عالسيلكت ميني
            // string[] strArr = new string[] { "I Love Egypt", "I Love Syria", "I Love Japan" };
            // var str = strArr.Select(x => x.ToString());
            // foreach (var item in str) { Console.WriteLine(item); }  // هيسلكت كل عنصر من اللاراي بس


            // var str2 = strArr.SelectMany(x => x.Split(' '));
            // foreach (var item in str2) { Console.WriteLine(item); }  // اما هنا هيختار كل كلمة لوحدها من كل عنصر
            //                                                          // في الارراي علي حسب الكونديشن هنا مثلا عند كل 
            //                                                          // ' ' ----> مسافة فاضية

            // //Select many using query sysntax

            // str = from Employees in Elist
            //       from Skill in Employees.Skills
            //       select Skill;
            // foreach (var item in str) { Console.WriteLine(item); }  // بس هنا هيعرضهم كلهم متكررين

            // Console.WriteLine("============================================================");

            //str = (from Employees in Elist
            //       from Skill in Employees.Skills
            //       select Skill).Distinct();
            // foreach (var item in str) { Console.WriteLine(item); }  //  هنا هيعرضهم بدون تكرار





            #endregion

            #region Zip

            //Recall

            #endregion

            #region Order

            //// OrderBy  --> بيرتب تنازلي من غير ما اقوله اسيندينج
            //// OrderByDecsending --> بيرتب تصاعدي
            //// ThenBy --> secondry sirting --> اذا تساووا في الاوردر باي رتب بيها
            //// ThenByDecsending --> نفس الكلام بس تصاعدي

            ////Reverse() --> بيعكس الترتيب بس لازم تستقبله في متغير متنساش لانه مش بيغير في الاصلي

            ////Recall Custom sorting --> IComeperer() 

            //var Elist = Reposetory.GetRepo();

            //var list1 = Elist.OrderBy(x => x.Salary);
            //foreach (var item in list1) { Console.WriteLine(item); }

            //list1 = from Employee in Elist
            //        orderby Employee.Salary descending
            //        select Employee;
            //foreach (var item in list1) { Console.WriteLine(item); }


            //// هنا انا بسيلكت الاسم بس ينفع والله العظيم والله العظيم ينفع بس خد بالم من التايب الي بتستقبل بيه الريترن
            //var list2 = from Employee in Elist
            //            orderby Employee.Salary descending
            //            select Employee.Name;
            //foreach (var item in list2) { Console.WriteLine(item); }


            //var list3 = Elist.OrderBy(Employeee => Employeee.Salary).ThenBy(x => x.Age);
            //foreach (var item in list3) { Console.WriteLine($"Im {item}"); }

            //var list4 = Elist.Where(x => x.IsMarried).OrderBy(x => x.Age).Select(x => x.Name);
            //foreach (var item in list4) { Console.WriteLine($"Im       {item}"); }

            ////Reverse
            //string[] StrList = new string[]{ "Ahmed", "Ali", "Bahaa", "Ziad", "Zain" };
            //foreach (string item in StrList) { Console.WriteLine(item); }

            //var ReversedStrList = StrList.Reverse();
            //foreach (string item in ReversedStrList) { Console.WriteLine(item); }

            ////ملحوظة 
            ////ال Reverse
            ////مش شغال مع الليست ----> شغال مع الارراي

            //list4.Print("Im ");

            #endregion

            #region (Data partetioning ) Skip , Take , chunck 

            //var Elist = Reposetory.GetRepo();

            ////Skip , SkipWhile

            ////Skip --> بتستثني اول كذا عنصر علي حسب انت عايز تستثني اول كام واحد
            //var list1 = Elist.Skip(5);
            //list1.Print("Im");


            ////SkipLast --> نفس الفكرة لكن بتسكيب من الاخر
            //var list2 = Elist.SkipLast(5).Select(x => x.Name);
            //list2.Print("Meeeeeee");

            //// المفروض 
            //// SkipWhile()
            //// تشتغل من غير ما احتاج ارتبها و لكن هي مش عارف هنا واقفة ليه
            ////SkipWhile() --> هنا مش بيسكب من الاول بس او الاخر بس لكن بيسكب حسب كونديشن معين
            //var list3 = Elist.OrderBy(x => x.Age).SkipWhile(x => x.Age < 25);
            ////foreach (var x in list3) { Console.WriteLine(x); }
            //list3.Print("Im not  :");


            ////Take , TakeLast , TakeWhile() ---> نفس الفكرة بالظبط بس بياخد بدل ما يستثني

            //var list4 = Elist.Skip(3).Take(3);
            //list4.Print("Taking ");


            //// Chunk
            //// بتستخدم انها تقسم الليست بتاعتي او التجميعة كلها لمجموعة من النجميعات الصغيرة علي حسب عدد معين
            //// انا الي بحدده 
            //// لو قولتله مثلا 4 ف هياخد كل اربعة في مجموعة و لو 5 مثلا هياخد كل 5 فيfor مجموعة و هكذاا

            //var Chunked = Elist.Chunk(4).ToList();

            //for (int i = 0; i < Chunked.Count(); i++)
            //{
            //    Chunked[i].Print("MoMo ");
            //    Console.WriteLine();    
            //}

            //متنساش تبص علي المثال الي شارحه في نص الفيديو كدة

            #endregion

            #region Any , All , Contains()


            ////Any 
            ////من الاخر هي ميثود ببتشيك علي كونديشن معين انت بتديهولها و بتشوف هل في اي حد عندك في الليست بينطبق
            ////علي الكونديشن ده ولا لا ---> لو في بترجع تروو و لو مفيش بترجع فولس

            //var Elist = Reposetory.GetRepo();

            //bool Check = Elist.Any(Employee => Employee.Salary > 40000);
            //Console.WriteLine(Check);

            //bool Check1 = Elist.Any(Employee => Employee.Gender == 'M');
            //Console.WriteLine(Check1);

            //bool Check2 = Elist.Any(Employee => Employee.Salary > 40000);
            //Console.WriteLine(Check2);



            ////All
            ////نفس الفكرة ولكن بتشوف هل كل العناصر عندك بينطبق عليها الكونديشن ده ولا لا و برضه بترجع بوليان كدة كدة

            //bool Check3 = Elist.All(Employee => Employee.Salary > 9000);
            //Console.WriteLine(Check3);

            //bool Check4 = Elist.All(Employee => Employee.Name.Length < 7);
            //Console.WriteLine(Check4);


            ////Where --> بترجع ليست 
            ////Select --> بترجع حاجة مش معروفة عشان كدة لازم في الغالب تستقبلها في فار
            ////Order --> بترجع ليست
            ////All , Any --> بترجع بوليان




            ////All.Any
            //bool Check5 = Elist.All(Employee => Employee.Skills.Any(str => str.Length < 3));
            //Console.WriteLine(Check5);

            ////في المثال الي فوق ده بشوف هل كل الموظفين عندهم اي مهارة طولها كسترينج اقل من 3
            ////خد بالك انا هنا عملت تشينينج بال
            ////All , Any
            ////و خد بالك تاني ال
            ////All,Any
            ////هما ميثودز تبع اللينكيو يعني زي ما قولنا لازم يشتغلوا مع حاجات 
            ////Enumerables
            ////بس , عشان كدة مثلا لما جيت استخدم التشينينج و استخدم 
            ////Any
            ////جوا مكنش ينفع تستخدمها الا مع السكيلز لانها ليست و الوحيدة من الميمبرز بتوع الامبلوييه الي
            ////Enumerables
            ////الميثود الخارجية الي هي الاووول اتطبقت علي الامبلوييز الي في الليست عشان كدة اشتغلت عادي لانها واخدة
            ////ليست و الليست انيومرابل زي ما قولنا
            ////لكن لما جينا طيقنا الاني بالتشينيج اتطبقت علي السكيلز بس لانها الوحيدة من عناصر الامبلوييه الي انيومبرابل




            ////Contains()
            ////هي هي ال
            ////Any
            ////ولكن بتفرق بس في الكومبليكستي لو استخدمتها مع هاش سيت بتكون
            ////O(1)
            ////اما لو استخدمتها مع ليست مثلا او اي حاجة تانية اعتقد
            ////الكومبليكستي بتاعتها بتكون زيها زي ال
            ////Any
            ////الاتنين بيكونوا
            ////O(n)

            ////راجع برضه الفرق بينهم كويس و افهمها اكتر


            ////With query syntax ---> Recalll ( Any , All , Contains ) with query syntax

            //var Check6 = from Employee in Elist    
            //              where Employee.Skills.All(str => str.Length < 7)
            //              select Employee;
            //Check6.Print("Checked ");

            //// هنا مثلا في المثال الي فات بيختار الموظفين الي عندهم كل المواد عنده ك سترينج طولها اقل من 7






            //var Check7 = from Employee in Elist
            //             where Employee.Skills.Any(str => str.Length == 2) 
            //             select Employee;
            //Check7.Print("NewChecked");

            //// اما هنا مثلا بختار الموظفين الي عندهم اي مادة طولها ك سترينج بيساوي 2 

            #endregion

            #region note
            //// خد بالك سطور اللينكيو(اتاكد) مش بتتنفذ غير لما تعمل عليها ايتريشنز ب فور ايتش او فور
            //// راجع القصة دي و راجعها في الميموري بتحصل ازاي
            #endregion

            #region GroupBy  , ToLookup

            ///*بالطبع! في سي شارب يمكن استخدامها تنظيم وتجميع البيانات بناءً على مفتاح معين.  */
            ///*هذه الوظيفة تُستخدم بشكل شائع في الاستعلامات على المجموعات */

            ////بص يا عم الحج بكل بساطة , الجروب باي هي كل الي بتعمله انها بتقسم الليست بتاعتك
            ////لمجموعات كل مجموعة عبارة عن ليست لوحدها و كل مجموهة ليها المفتاح الخاص بيها علي حسب انت عايز
            ////تجمع علي اساس ايه , الاسم ولا العمر ولا المرتب ولا لا لا
            ////زي ما قولنا هو بيرجع ليست فيها مجموعة من الليستات يعني زي تو دي ارراي كدة 
            ////بالتالي لو عايز تعمل عليهم ايتريشنز لازم تعمل فور جوا فور 

            //var Elist = Reposetory.GetRepo();

            //var list1 = Elist.GroupBy(Employee => Employee.Name);

            //foreach (var group in list1) { 

            //    Console.WriteLine(group.Key);
            //    foreach (var Employee in group) { Console.WriteLine(Employee); }
            //    Console.WriteLine();    
            //}

            //Console.WriteLine("=============================================================");    


            //var list2 = Elist.GroupBy(Employee => Employee.Gender);

            //foreach (var group in list2) { 

            //    Console.WriteLine(group.Key);
            //    foreach (var Employee in group ) { Console.WriteLine(Employee); }
            //    Console.WriteLine();

            //}

            ////Output
            ///*

            //M  
            //Name : Ahmed            Age : 25         Salary : 15000       Gender : M     IsMarried : True
            //Name : Salem            Age : 23         Salary : 12000       Gender : M     IsMarried : False
            //Name : kareem            Age : 30         Salary : 25000       Gender : M     IsMarried : True
            //Name : Alaa            Age : 29         Salary : 32000       Gender : M     IsMarried : True
            //Name : Ahmed            Age : 35         Salary : 38000       Gender : M     IsMarried : True
            //Name : Fady            Age : 25         Salary : 25000       Gender : M     IsMarried : False


            //F
            //Name : Salma            Age : 27         Salary : 14000       Gender : F     IsMarried : True
            //Name : Zahraa            Age : 23         Salary : 10000       Gender : F     IsMarried : False
            //Name : Yomna            Age : 23         Salary : 12000       Gender : F     IsMarried : False


            //*/


            //// هنا مثلا اول جروب الي فوق كلهم ميل و المفتاح بتاعهم 
            //// M

            //// و الجروب الي تحت كلهم فيميل و المفتاح بتاعهم 
            //// F

            //// زي ما قولنا هو بيقسم الليست بتاعتك لجروبز و كل جروب في مجموعة من الموظفين مشتركين في المفتاح الي 
            //// انت حددته



            //// differnce between GroupBy , ToLookup
            //// مفيش فرق بينهم في النتيجة 
            //// الفرق بس في طريقة التنفيذ
            //// GroupBy --> user dereferd excuation
            //// Tolookup --> immediate excuation
            //// Recalllllllllll it 


            //Recall  GroupBy , ToLookup with query syntax
            #endregion

            #region Note
            ////Impleminting IComparable<Employee> interface in Employee class to so can compare between
            ////the employees based on Age , Salary , Name ,,,, --> we determine that
            //var Elist = Reposetory.GetRepo();
            //var MaxEmployee = Elist.Max();
            //Console.WriteLine(MaxEmployee);    

            //IEnumerable<something>    ---->   هو انترفيس بيتورث بيخلي الحاجة بتاعتي ينفع اعمل عليها ايتريشنز , افهمها اكتر

            /*IEnumerable<T> is a fundamental interface in the .NET Framework that provides a way to iterate over a collection of objects.
             * It is part of the System.Collections.Generic namespace and is widely used in LINQ (Language Integrated Query) 
             * and other data manipulation tasks in C# and other .NET languages.*/

            #endregion

            #region Join

            //Join
            //GroupJoin


            //الجوين زي ما انت عارف في السيكوال بيضملك او بيجمعلك مصدرين مختلفين للداتا زي جدولين مثلا
            //يضمهم لحاجة واحدة و لازم يكون في حاجة مشتركة بينهم


            //var Elist = Reposetory.GetRepo();

            ////We will create another class to try joins --> Department
            ////And create list of it
            //List<Department> DeptList = new List<Department>() {

            //   new Department(){ DeptName = "Software" , DeptId = 10},
            //   new Department(){ DeptName = "Hardware" , DeptId = 20}
            //};





            ////Join structure
            ////Easier to do it with Query syntax

            //var list = from Emp in Elist
            //           join Dep in DeptList on Emp.DeptId equals Dep.DeptId
            //           select new EmployeeDepResult()
            //           {

            //               EmpName = Emp.Name,
            //               DepName = Dep.DeptName,
            //           };
            //list.Print("");



            ////Its very long and difficult with Method syntax so i skipped it , but you can recall it

            ////Recalll Group join


            #endregion

            #region Generation Operations

            ////Empty , DefaultIfEmpty , Default keyword , Range , Repeat



            ////Empty
            ////الامبتي بتتيح ليا اني اكريت زي ليست فاضية من نوع معين او اوبجكت معين
            ////طيب اي الفرق بينها و بين الليست الفاضية العادية ؟
            ////الفرق بينهم ان الليست العادية هي شغالة 
            ////immediate excuation
            ////بمعني انه اتكريتت الليست خلاص بمجرد ما عملتها فحتي لو لسة هتسخدمها بعد الف سطر و في جاب كبير بين
            ////الكريتة و الطباعة هي كدة كدة اتكريتت خلاص
            ////اما ال الامبتي 
            //// ف هي شغالة بال 
            ////defered excuation
            ////بمعني انك مجرد ما كتبتها انت كدة لسة مكريتهاش لا انت بس عملت بروميس او عقد لحد ما تبدأ تستخدمها ساعتها 
            ////هتتكريت ----> افهم اكتر الموضوع ده مفيد في اي لانه اكيد مفيد في حاجات كتير

            //var DepList = new List<Department>(); // --> Empty List --> immediate excuation

            //var DepEmpty = Enumerable.Empty<Department>(); // Empty from Enumerables --> defered excuation

            ////في الحالتين كدة كدة بتاخد قيم ب ناال
            ////all ref types have def value --> Null



            ////DefaultIfEmpty
            ////هي حاجة بتدي القيمة الديفولت للمتغير او الاوبجكت بتاعك لو فاضي
            ////بيديك امكانية كمان انك تحدد قيمة الديفولت دي كام
            ////هنا الموضوع لو انا بساوي ليست ب ليست تانية لو الليست التانية دي فاضية هو ساعتها بيحط في الليست بتاعتي 
            ////القيم الديفولت

            //var DepList1 = new List<Department>() { /*new Department { DeptId = 10 , DeptName = "Software" }*/ };  
            //var DepList2 = DepList1.DefaultIfEmpty(); // --> لو ديب ليست1 فاضية حط في ديب ليست 2 القيم الديفولت

            //foreach (var item in DepList2) { if (item is null) Console.WriteLine("Null"); }
            ////الي عمله هنا انه حط عنصر واحد في الليست و خلاه ب نااال و كدة يكون فعلا حط القيمة الديفولت لليست


            //DepList2 = DepList1.DefaultIfEmpty(new Department{ DeptId =30 , DeptName = "Default Departmrnt name" });
            //DepList2.Print("");
            ////هنا انا حددتله القيمة الديفولت الي عايز ادخلها







            ////Default keyword
            ////اي داتا تايب عندك عنده قيمة ديفولت سواء فاليو تايب او ريفرنس تايب
            ////القيمة الديفولت للرفرنس تايب زي ما قولنا دايما نااال

            //Console.WriteLine($"int def is {default(int)}");
            //Console.WriteLine($"char def is {default(char)}");
            //Console.WriteLine($"string def is {default(string)}");
            //Console.WriteLine($"DateTime def is {default(DateTime)}");







            ////Range ---> Recall
            ////هي بتديني امكانية اني اكريت رينج من ارقام او اوبجكتس علي حسب انا عايز قد اي


            //var range = Enumerable.Range(0 , 10);  // --> range is IEnumerable<int> --> so can use print() with it    
            //range.Print("");

            //var DepRange = Enumerable.Range(0, 10).Select(i => new Department { DeptId = i , DeptName = $"Dep : {i}" });
            //DepRange.Print("");
            ////هنا مثلا انا استخدمتها عشان اعمل رينج من الديبارتمنتس








            ////Repeat ---> recallll
            ////الريبيت بيسمحلي اني اكرر قيمة او اوبجكت عدد معين من المرات
            ///*بالطبع! في  هي طريقة تستخدم لإنشاء مجموعة تحتوي على تكرار لعنصر معين لعدد محدد من المرات..*/
            ///* يتم استخدامها عندما تحتاج إلى إنشاء تسلسل من عناصر مكررة*/

            ////طيب السؤال برضه منا ممكن اعمل ليست و احط فيها الدنيا دي كلها عادي و اعمل فور لوب و املي بيهم اليست كلهم نفس القيم
            ////بص يا عم الحج
            ////لو عملت ليست عادية ---> ساعتها الليست دي جواها كذا اوبجكت كل واحد له ريفرنس مختلف
            ////و كمان كل ريفرنس بيشاور علي اوبجكت مختلف في الميموري رغم انهم نفس القسمة لكن هما في الميموري موجود عشرة اوبجكتس مثلا 
            ////في عشرة ريفرنسيز بيشاوروا عليهم

            ////لكن لما استخدم الريبيت الي بيحصل كالتالي
            ////الي بيحصل انك مش بيكريت عشر كائنات لا هو بيكريت كائن او اوبجكت واحد بس في الهيب و بيخلي ال 10 ريفرنسيز كلهم
            ////يشاوروا علي نفس الكائن ده بالتالي اي تغيير هعمله باي ريفرنس من ال 10 هيأثر عليهم كلهم
            ////لانهم كلهم في النهاية بيشاوروا علي نفس الكائن و كدة اكون عملت عشر نسخ من الكائن و انا مخزن نسخة واحدة منه في الهيب
            ////references -- > stored in stack
            ////values , objects( new() ) ---> stored in heap

            ////خد بالك ينفع اكتر من ريفرنس يشاور علي نفس الاوبجكت عادي جداا لك مينفعش نفس الريفرنس يشاور علي اكتر من اوبجكت
            ////ركز في دي اووي


            //Department dep1 = new Department { DeptName = "Im repeated" , DeptId = 300 };
            //var RepeatedDeps = Enumerable.Repeat(dep1, 20).ToList();
            //RepeatedDeps.Print("");
            //// انا فوق عملت اوبجكت من نوع ديبارتمنت و باصيته للميثود و باصيتلها عدد مرات التكرر
            //// خد بالك انا بكرر قيمة يعني هنا انت بتديلي قيمة سواء رقم او سترينج او اوبجكت وهو بيكرره يعني مش منطقي اني اديله ليست مثلا --> اتاكد




            //RepeatedDeps[0].DeptName = " koko "; // -->  لو غيرت في حاجة هنا هتغير في كل النسخ الموجودة
            //RepeatedDeps.Print("");


            ////RepeatedDeps[2] = new Department { DeptName = "Im not repeated", DeptId = 500 };
            ////اما لو غيرت في احد النسخ بس كاملة بتتفير لوحدها ----> راجعها


            #endregion

            #region Element Operations 



            ////ElemenAt() , ElementAtOrDefault() 
            ////العادية بترجعلي الايلمنت الي عند اندكس معين هديهوله
            ////والتانية لو انا معنديش ايلمنت بنفس الاندكس ده بترجعلي الديفولت الي هو طبعا نااال
            ////خد بالك الاتنين دول بيرجعولي ايلمنت واحد بس يعني مثلا هترجعلي هنا ايمبلوييه
            ////بتاخد مني ايندكس و ترجعلي الايلمنت الي عند الايندكس ده او الديلفولت

            //var Elist = Reposetory.GetRepo();

            //var list = Elist.ElementAt(3);
            //Console.WriteLine(list);    

            ////list = Elist.ElementAt(9);   // will crash as its out of range

            //list = Elist.ElementAtOrDefault(9);
            //if (list is null) { Console.WriteLine("Default value is Null"); }





            ////First() , FirstOrDefault() 
            ////الاولي بترجعلي اول عنصر 
            ////لو انا مديتهوش شرط او كونديشن هيرجعلي اول عنصر عامة لكن لو اديتله كونديشن , هيرجعلي اول عنصر بيحقق الكونديشن ده في الليست
            ////التاني نفس الفكرة لو الليست فاضية يعني بالتالي مفيش اول قيمة اصلا , بيرجع ليا الديفولت الي هي الناال
            ////في جميع الحالات هو برضه بيرجع ايلمنت واحد بس

            //var list1 =Elist.First();
            //Console.WriteLine(list1);      // --> الي بيرجع هنا ايمبلوييه وده مش اينومرابل بالتالي مقدرش استخدم معاه البرينت هطبعه عادي بالكونسل

            //list1 = Elist.FirstOrDefault();
            //Console.WriteLine(list1);




            ////Last() , LastOrDefault()
            ////نفس الفكرة بالظيط بس بدل ما بيجيب من وش الليست هيجيب الي قعر الليست و برضه ممكن تختار بكونديشن او من غير






            ////Single() , SingleOrDefault()
            ////الاولي بترجعلي الحاجة الوحيدة في الليست الي بتحقق كونديشن معين
            ////و خد بالك سواء الاولي او التاني الاتني لازم الكونديشن بتاعم يكون متحقق من عنصر واحد بس في الليست
            ////لو في اكتر من عنصر محققه بيضرب اكسيبشن
            ////الفرق بس الديفولت لو الليست كانت فاضية خالص بيرجع الديفولن فاليو الي هي نااال

            ////var list2 = Elist.Single();   -----> الجملة دي تنفع لو الليست بتاعتك فيها ايلمنت واحد لكن طالما عندك اكنر من ايلمنت لازم كونديشن 

            //list1 = Elist.Single( x => x.Name == "Salem");
            //Console.WriteLine(list1);

            //List<Employee> employees = new List<Employee>();    
            //list1 = employees.SingleOrDefault();  // no exception happened


            //list1 = Elist.Single( x => x.Age == 35);
            //Console.WriteLine(list1);   


            #endregion

            #region Equality Operations

            ////SequanceEquale() 
            ////هي ميثود بتقارن متسلسلات او ليستات يعني ببعض هل هما فيهم نفس العناصر بالظبط بنفس الترتيب ولا لا
            ////لو هما هما هيرجع ترو 
            ////لو مختلفين هيرجع فولز

            ////اول حاجة لو الليست دي جواها عناصر فاليو تايب ساعتها مفيش اي مشكلة و هتشتغل تمام
            ////و هتقارن فعلا و لو متطبقي هترجع ترو

            //List<int> list1 = new List<int>() { 1 , 2 , 4 , 5 , 6 };
            //List<int> list2 = new List<int>() { 1 , 2 , 4 , 5 , 6 };
            //List<int> list3 = new List<int>() { 1 , 2 , 4 , 7 , 8 };

            //bool CheckEquality = list1.SequenceEqual(list2);
            //Console.WriteLine(CheckEquality);   // True

            //CheckEquality = list1.SequenceEqual(list3); 
            //Console.WriteLine(CheckEquality); // False




            ////اما بقا لو بتقارن ريفرنس تايب لو تحدبدا كلاس انت عامله هنا هتظهر مشكلة 
            ////هتلاقيه بيرجع فولز حتي لو الكائنين جواهم نفس القيم بالظبط متطايقين , طب ده بيحصل ليه؟
            ////بكل بساطة لان الكومبيلر ميعرفش يقول امتي اوبجكت يساوي اوبجكت , ساعتها انت الي بتحدد دي بنفسك
            ////بتحدد امتي الاوبجكت ده يساوي الاوبجكت ده ----> مثلا ممكن لو نفس الاي دي او نفس الاسم او نفس الاسم و الاي دي 
            //// وهكذا
            ////هناخد مثلا مثال علي الديبارتمنت ---> هتلاقينا عنده عاملين امبلمنتيشن للانترفيس اي ايكوال
            ////بنحدد بيه امتي الاوبجكت بيساوي الاوبجكت


            //IEnumerable<Department> DepList1 = new List<Department>() { new Department { DeptId = 10 , DeptName ="SW" },
            //                                                           new Department { DeptId = 20 , DeptName ="HW" },
            //                                                           new Department { DeptId = 30 , DeptName ="HWSW" },
            //                                                           new Department { DeptId = 40 , DeptName ="SWHW" },                                                                                                                      
            //                                                                                                           };

            //IEnumerable<Department> DepList2 = new List<Department>() { new Department { DeptId = 10 , DeptName ="SW" },
            //                                                           new Department { DeptId = 20 , DeptName ="HW" },
            //                                                           new Department { DeptId = 30 , DeptName ="HWSW" },
            //                                                           new Department { DeptId = 40 , DeptName ="SWHW" },
            //                                                                                                           };


            //Console.WriteLine(DepList1.SequenceEqual(DepList2)); // before using IEqualityComparer<Department>     
            //                                                     // will retuen false even that DepList1 and DepList2 are identical
            //                                                     // in members values inside each object



            ////After inherting IEqualityComparer<Department> interface to Department class and implementing it
            //Console.WriteLine(DepList1.SequenceEqual(DepList2)); // will return true



            ////Recalllllll overriding Equals() and GetHashCode() methods on class Department After inherting the IEqualityCompare<> interface

            #endregion

            #region Concatination

            ////Recall it

            //List<int> list  = new List<int>(){ 1 , 2 , 3 , 4  };
            //List<int> list1 = new List<int>(){ 5 , 6 , 7 , 8  };

            //var list2 = list.Concat(list1);
            //list2.Print("");



            //IEnumerable<Department> DeptList1 = new List<Department>() { new Department { DeptId = 10, DeptName = "SW" } };

            //IEnumerable<Department> DeptList2 = new List<Department>() { new Department { DeptId = 20, DeptName = "HW" } }; 


            ////Concating the 2 lists in new list

            //IEnumerable<Department> ConcatDeptList = DeptList1.Concat(DeptList2);
            //ConcatDeptList.Print("");

            ////Recallllllllll its video and details

            #endregion

            #region Aggregate Operations

            ////Aggregate()
            ////هي ميثود لتجميع الداتا علي حسب الي انت عايزه بالطريقة الي انت عايزها
            ////هي طويلة اوي الصراحة فانا مركزنش عليها فانت ممكن تشوفها تاني كدة





            ////Count()
            ////هي برضه ميثود للتجميع و بترجع نتيجة التجميع ده و بيكون رقم و انت تقدر تجمع كل حاجة او تحددله كونديشن للحاجات الي عايزه يجمعها

            //IEnumerable<Department> DList1 = new List<Department> { new Department { DeptId = 50,  DeptName = "D1" } };

            //IEnumerable<Department> DList2 = new List<Department> { new Department { DeptId = 100, DeptName = "D2" } };

            //int sum = DList1.Count();
            //Console.WriteLine(sum);


            //var Elist = Reposetory.GetRepo();

            //int EmpSum = Elist.Count(); 
            //Console.WriteLine(EmpSum);


            //EmpSum = Elist.Count( x => x.IsMarried);
            //Console.WriteLine(EmpSum);  


            //EmpSum = Elist.Where(x => x.IsMarried).Count();
            //Console.WriteLine(EmpSum);


            //var EmpSum1 = Elist.LongCount();  //Recall how to cast it
            //Console.WriteLine(EmpSum1);

            //EmpSum = Elist.Where(x => x.Age > 25).Select(x => x.Name).Count();
            //Console.WriteLine(EmpSum);


            //var select = Elist.Select(x => x);  // ----> selecting every thing
            //select.Print("");

            //var select1 = Elist.Select(x => x.IsMarried); // ----> selecting the IsMarried only
            //select1.Print("");

            ////Recallllll the type casting




            ////Max() , Maxby() 
            ////هما الاتنين نفس الحاجة و نفس الفكرة بس واحدة بترجعلي قيمة الماكس ده و واحدة بترجع العنصر الي عنده القيمة الماكس دي
            ////في جميع الحالات بترجع حاجة واحدة برضه يعني مش ليست او انيومرايبل مثلا بالتالي مقدرش استخدم معاها البرينت فممكن اطبعها علطول

            //var MaxAge = Elist.Max(x => x.Age);    // ---> max age
            //Console.WriteLine(MaxAge);

            //var MaxAgeEmployee = Elist.MaxBy(x => x.Age);  // ---> employee with max age
            //Console.WriteLine(MaxAgeEmployee);  

            //var MaxWithCondition = Elist.Where(x => !x.IsMarried).Max(x => x.Age); 
            //Console.WriteLine(MaxWithCondition);

            //var EmployeeWithMaxSalaryInMales = Elist.Where(x => x.Gender == 'M').MaxBy(x => x.Age);   
            //Console.WriteLine(EmployeeWithMaxSalaryInMales);




            ////Min() , MinBy()   --> نفس الفكرة بالظبط بس بدل الاكبر , هتكون الاقل




            ////Sum() , Avg() ---> نفس فكرة الي فوق عادي بالظبط بس بيرجع المجموع و المتوسط والاتنين بيرجعوا رقم بس

            //int SumOfEmployeesAges = Elist.Sum(x => x.Age);  // بيحسب مجموع اعمارالموظفين كلهم
            //Console.WriteLine(SumOfEmployeesAges);


            //int SumOfMaleEmployeesAges = Elist.Where(x => x.Gender == 'M').Sum(x => x.Age); 
            //Console.WriteLine( SumOfMaleEmployeesAges);


            //decimal AvgSalariesOfEmployeesMoreThan30Yrs = Elist.Where(x => x.Age > 30).Average(x => x.Salary);
            //Console.WriteLine(AvgSalariesOfEmployeesMoreThan30Yrs);


            //decimal SumOfSalariesOfFemalesGreaterThan23Yrs = Elist.Where(x => x.Gender == 'F' && x.Age > 23).Sum(x => x.Salary);
            //Console.WriteLine(SumOfSalariesOfFemalesGreaterThan23Yrs);


            #endregion

            #region Set operations 

            ////Neeeeeeeed to recallllll it

            ////Distinct , DidtinctBy() 

            ////Distinct --> كل الي بتعمله انها بس بتجيبلك الداتا او الكوليكشن من غير تكرار
            ////         --> يعني العناصر المتساوية بيجيبها مرة واحدة بس , و زي مانت عارف لو الليستة دي ارقام مثلا او سترينجات
            ////         --> فهو هيعرف يجيبلك المتساوي و المتشابه لوحده لانه بيكون متعرف فيه ال الايكواليتي كومبراتور باي ديفولت
            ////         --> لكن لو كانت داتا تايب انت الي عاملها مثلا زي الايمبلوييه يعني الليست عبارة عن ليست من ايمبلوييه
            ////         --> فلازم انت تعرف الايكواليتي كومبراتور بنفسك يعني تعرف الكومبيلور امتي اقدر اقول ان الموظف ده بيساوي الموظف ده


            ////DistinctBy() ---> لو انت بقا مش عايو تعمل كدة يعني مش عامل ايكواليتي كومبراتور عندك مثلا في الامبلوييه
            ////             ---> ساعتها الكومبيلر مش هيعرف يحدد امتي الموظف يساوي موظف و وقتها بقا لازم تستخدم الديستنكت باي
            ////             ---> الي انت بتقوله فيها بس او بتباصيله سيليكتور يعرفه امتي يحدد ان الموظف ده و ده متشابهين ف ميكررهمش
            ////             ---> او حتي لو عامل ايكواليتي اوبريتور بس عايز تنفذ الديستنكت علي كونديشن معين


            //IEnumerable<Department> DepList1 = new List<Department>() { 

            //    new Department(){ DeptId = 10  , DeptName = "SoftWare" }, new Department () { DeptId =20 , DeptName = "HardWare" } ,
            //    new Department(){ DeptId = 30  , DeptName = "DevOps"   }, new Department () { DeptId =40 , DeptName = "Embedded" }
            //};


            //IEnumerable<Department> DepList2 = new List<Department>() {

            //    new Department(){ DeptId = 50  , DeptName = "AI" }, new Department () { DeptId =20 , DeptName = "HardWare" } ,
            //    new Department(){ DeptId = 30  , DeptName = "DevOps"   }, new Department () { DeptId =60 , DeptName = "Testing" } ,
            //    new Department(){ DeptId = 20  , DeptName = "HardWare" },
            //    new Department(){ DeptId = 20  , DeptName = "HardWare" },
            //    new Department(){ DeptId = 20  , DeptName = "HardWare" },
            //    new Department(){ DeptId = 20  , DeptName = "HardWare" },
            //    new Department(){ DeptId = 20  , DeptName = "HardWare" },

            //};




            ////الايكواليتي شغال عادي

            ////الديستينكت  العادية لسبب ما مش راضية تشتغل مع الليست او ديبارتمنت دي مع اني اتاكدت من الايكواليتي
            //var Result = DepList1.Distinct();
            ////  Result.Print("");

            //Result = DepList2.Distinct();
            ////  Result.Print("   ");




            ////DitinctBy()
            //Result = DepList2.DistinctBy(x => x.DeptId);
            ////  Result.Print("");

            ////   Result = DepList2.DistinctBy(x => x.DeptName == "SoftWare");   ---> Recall this
            ////   Result.Print("   ");




            ////Intercect() , IntercectBy()
            ////نفس التفاصيل الي فوق بالظبط بس الفرق انهم بتجيب المشترك بين ليستتين او انا بحددله اي الي يحدد بيه المشترك برضه


            ////برضه الانترسيكت العادية مش شغالة عشان في مشكلة مش راضي يحدد بيها المشترك
            //Result = DepList1.Intersect(DepList2);
            //Result.Print("");


            ////دي الطريقة الي بنكتب بيها الانترسيكت باي
            //Result = DepList2.IntersectBy(DepList1.Select(x => x.DeptId) , x => x.DeptId);
            //Result.Print("=== ");




            ////Exept() , ExceptBy() 
            ////نفس الفكرة بالظبط بس بتعمل العكس
            ////بتجيب الحاجات الي مش مشتركة يعني موجودة في اول ليست و مش موجودة في التانية
            ////و برضه هنا الاكسيبت العادية مش راضية تشتغل


            ////Union() , UnionBy()
            ////بتوحد الليستين و تخليهم في ليستة واحدة زي ما هما كدة حتي لو فيها حاجاات ناال
            ////اليونيون باي بقا نفس الفكرة لكنها بس 

            //var res = DepList1.Union(DepList2);
            //res.Print("-/-/ ");

            //res = DepList2.UnionBy(DepList1 , x => x.DeptId );  // هنا بيجيبهم من غير تكرار
            //res.Print("---**---**--");



            #endregion

            #region Expression tree

            // vid 16 --> راجعه هو كله كلام نظري

            #endregion

            #region Difference between IEnumerable and IQuereable

            //Recall it --> كلام نظري كله

            #endregion

            #region Converting Data Types

            //Need to recallll ---> كام تفصيلة برضه شبه نظري مهمة

            #endregion

            #region Note : Generic class trying , other

            //GenericClass<int>.Method1(66);
            //GenericClass<string>.Method1("Ahmed");
            //GenericClass<int>.Method1(66); 

            //Employee employee = new Employee();
            //employee = new Employee { Age = 50, DeptId = 2, Gender = 'M', IsMarried = true, Name = "Amer", Salary = 35000, Id = 10 };
            //GenericClass<Employee>.Method1(employee);


            ////All Linq methods are inside the static prtial class ---> Enumerable 

            ///*In C#, a partial class is a feature that allows you to split the definition of a single class into multiple files. 
            // * This can be useful for several reasons:*/


            #endregion

            #region MyMadeLinqExtension method trying

            //var Elist = Reposetory.GetRepo();

            //var test1 = Elist.MarriedCheck(x => x.Age > 22);
            //test1.Print("--> ");


            //var test2 = Elist.MaleSelector(x => x.Name);
            ////test2.Print("male emp : ");


            //var test3 = Elist.Where(x => x.IsMarried).SelectV2(x => x.Name);
            //test3.Print("Im ");

            //Elist.Print("");

            //var test4 = Elist.ElementAtV2(3);
            //Console.WriteLine(test4);


            #endregion

            #region note

            // لما احط 
            // .ToList()
            // في اخر جملة اللينكيو 
            // بتعملي 
            // immediate excuation

            #endregion

            #region Linq Anatomy

            // اخر فيديو خالص ---> راجعه هيفيدك برضه

            #endregion



            /*-----------------------------------------. تمت بحمد الله .-------------------------------------------------*/



            //Select many & Zip

            



            #endregion
           

        }


       


        #region Class Department


        //Class for trying joins ---> we can make classes inside class even the programme class
        //but never can do it inside any method including the main method
        class Department    
        {

            public int DeptId { get; set; }
            public string DeptName { get; set; }






            //انا هنا حققت الايكواليتي بالاوفر رايد للفانكشن دي و ممكن تعمل للهاش كود برضه بس دي للبيست براكتيس بس
            //معملتش هنا امبلمنتيشن للانترفيس أي ايكواليتي كومبراتور

            public override bool Equals(object? obj)
            {
                if (ReferenceEquals(null, obj)) { return false; }
                if (ReferenceEquals(this, obj)) { return true; }
                if (obj.GetType() != this.GetType()) { return false; }

                var other = obj as Department;

                return this.DeptName == other.DeptName && this.DeptId == other.DeptId;

                
            }




            //Recall that method         
            public int GetHashCode(Department obj)
            {
                // Use a prime number for hashing to reduce collisions.
                const int prime = 23;
                unchecked
                {
                    int hash = 17;
                    hash = hash * prime + DeptId.GetHashCode();
                    hash = hash * prime + (DeptName?.GetHashCode() ?? 0);
                    return hash;
                }
            }






            //Recall doing it with IEqualityCompartor<Department>


            ////Recall that method
            //public bool Equals(Department? x, Department? y)
            //{
            //    return x.DeptId == y.DeptId && x.DeptName == y.DeptName;
            //}


            ////the method used to enshure the equality with specific condotions
            //public override bool Equals(object? obj)
            //{

            //    if (obj is Department other) {

            //        if (ReferenceEquals(this, other)) return true;
            //        else
            //        return this.DeptId == other.DeptId && this.DeptName == other.DeptName; 

            //    }

            //   return false;

            //}






            public override string ToString()
            {
                return $"Department name : {DeptName}    ,    Department Id : {DeptId} ";
            }
        }


        #endregion


        #region Class EmployeeDepResult

        //Just a class to store the join result inside it
        class EmployeeDepResult {
        
            public string EmpName { get; set; }
            public string DepName { get; set; }


            public override string ToString()
            {
                return $"Employee name : {EmpName}  ,  The department : {DepName}";
            }
        }

        #endregion


        #region Generic class

        public static class GenericClass<T> {

            public static void Method1(T param1 ) { Console.WriteLine($"Im {typeof(T)} and my value is {param1}"); }
        }

        #endregion


    }




}

