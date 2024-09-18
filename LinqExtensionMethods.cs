using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    public static class LinqExtensionMethods
    {

        //Linq methods are written with functional programming --> recall that topic and related

        //FluentApi --> معناه انك تكتب الميثودز بشكل باللغة الانجليزية يكون سهل يتقري و يتفهم

        //هنا في الكلاس ده عملنا و كتبنا بايدينا الميثودز بتاعت اللينكيو
        //طب الشكل الاساسي عامة بيبقي عبارة عن اي ؟

        //اي ميثود لينكيو بترجع 
        //IEnumerable<حاجة>
        //هي اكستنشن فانكشن بالتالي بتاخد مني دايما اول بارمتر الي بيكون بعده ال (.) بيكون
        //IEnumerable<الكلاس او النوع الي الليست متكونة منه>
        //و كمان بياخد مني بارمتر تاني بيبقي علي حسب
        //في الغالب بيكون سيلكتور او ديليجت يعني 
        //و ممكن مثلا يكون مجرد رقم بس زي الايلمنت ات مثلا 

        //خد بالك ميثودز اللينكيو في العادي او الي انا فاهمه انها شغالة 
        //defered excuation
        //Recall difference between defered excuation and immediate excuation

        //Any Linq method(extension method) has an first paramter as IEnumerable<اي حاجة>


        //تفصيل

        //Where
        //public static IEnumerable<T> Where<T>(this IEnumerable<T> Source , Func<T,bool> predicate ){/*code*/}
        //output --> هنا الاوتبوت و الانبوت هما الاتنين هيكونوا اي اينيومرابل من الكلاس الي الليست متكونة منه
        //       --> لان الوير يدوب بتقص او بتحدد جزء معين من الليست و ترجعهولك بس هي مازالت ليست مغيرتش في النوع
        //input  --> اول انبوت هو زي مقولنا بتدخله في الذيس , اي اينيومرابل من الكلاس او النوع الي شغال عليه
        //       --> الانبوت التاني بيكون برديكيت او ديليجت يعني
        //       --> الديليجت ده الانبوت بتاعه اوبجكت من النوع الي متكونة منه الليست و الاوتبوت دايما بوليان 
        //       --> لان الهدف من البريديكت اصلا بحدد بيه هل الشرط ترو ولا فولز بالنسبة لكل عنصر في الليست و علي اساسه
        //       --> يا اما ارجعه و احطه في الليست الي هرجعها يا اما هسكيبه
        //       --> T --> هو نوع الكلاس او التايب الي متكونة منه الليست و زي ما قولنا الي داخل هو ليسن من النوعده
        //       -->   --> والخارج هو ليست برضه من النوع ده



        //Select()
        //public static IEnumerable<Tresult> Select<Tsource , Tresult>(this IEnumerable<Tsource> Source , Func<Tsource,Tresult> selector){//}
        //Tsource ---> هو نوع الكلاس او التايب الي متكونة منه الليست و ده الي بنباصيه للميثود 
        //        ---> بنباصي للميثود اي اينيومرابل من نوع التي سورس ده و ليكن اي اينيومرابل اوف امبلوييه مثلا
        //        ---> IEnumerable<Employee>.Select()  --> Employee is the Tsource
        //Tresult ---> هو النوع الي هنرجع منه اي اينومرابل 
        //        ---> لان زي ما اتفقنا كدة كدة اي لينكيو ميثود بترجع اي اينومرابل او حاجة معينة
        //        ---> ساعتها بقا علي حسب الي انا عايز اختاره بس برجعه , الاسامي بس , الاسامي بشرط معين , الليست كلها , السالري و هكذا
        //        ---> طيب دلوقتي التي سورس بنحددها من الانبوت تمام طيب التي ريزلت بنحددها ازاي؟
        //        ---> ده زي ما وضح فوق كدة من الاوتبوت بتاع السلكتور
        //        ---> الاوتبوت بتاع السيلكتور ---> بنرجع منه اي اينومرابل و هو ده الريترن بتاع الميثود
        //        ---> .Select(x (selector input --> employee) => x.anything or x (سواء ده او ده نوع الاوتبوت ده هو التي ريزلت))
        //        ---> في الاخر بقا بنرجع من الميثود اي اينيومرابل من التب ريزلت ده



        // السيليكتور هو عبارة عن ديليجت
        // هو ديلجيت من نوع 
        // Func<Tsource,Tresult> 
        // و ده بيلت ان جينيرك ديليجت 
        // Func<Tsourc , Tresult> Tsourc => Tresult

        // متنساش الميثود تشينينج 
        // انت تقدر تعمل تشينينج لاي عدد من المرات براحتك ممكن تعمل تشين ل 5 ميثودز جمب بعض عادي جداا
        // كدة كدة هيتنفذوا بالترتيب و كل اوتبوت انبوت للي بعدها
        // بس لازم تاخد بالك ان الانبوت بتاع كل ميثود يكون مظبوط
        // var test = List.Where(x => x.ddd == dd).skip(10).take(10).select(x => x.sss) ;
        // بيتنفذوا زي ما انت شايف من الشمال لليمين


        // ممكن مع الريتيؤن بتاع اي ميثود تطبع معاهاحاجة ساعتها هتعدل بس في اللامبدا اكسبريشن
        // و نحط ريتيرن بادي بس
        // var test = Reposetory.GetRepo().Where(x => { Console.WriteLine("Im"); return x.IsMarried; });

        //Method1 --> methods returns any operation on married employess
        public static IEnumerable<Employee> MarriedCheck(this IEnumerable<Employee> Emps, Func<Employee, bool> Delg)
        {

            List<Employee> result = new List<Employee>() { };


            foreach (Employee emp in Emps)
            {

                if (emp.IsMarried && Delg(emp)) { result.Add(emp); }
                
            }


            return result;
        }







        //Method2 --> returning like select information with male employees
        public static IEnumerable<Tresult> MaleSelector<Tresult>(this IEnumerable<Employee> Emps , Func<Employee , Tresult> selector ) {
        
            List<Tresult> List = new List<Tresult>();

            foreach (Employee emp in Emps) {

                if (emp.Gender == 'M') {

                    List.Add(selector(emp));
                }
            }


            return List;
        }








        //انا هنا مخصص السيلكت ده علي الامبلوييه لكن لو كنت عايز اعملها جنرال 
        //كنت خليتها زي السيليكت المشروحة الفوق كدة
        //SelectV2<Tsource,Tresult>(this IEnumerable<Tsource> , Func<Tsource , Tresult> selector){ /*code*/}
        //Method3 ----> selectV2
        public static IEnumerable<Tresult> SelectV2<Tresult>( this IEnumerable<Employee> Emps , Func<Employee , Tresult> DelgSelector ) {
        
            List<Tresult> Result = new List<Tresult>();

            foreach (Employee emp in Emps) {

                Result.Add(DelgSelector(emp));
            }

         
            return Result;
        }






        //Method4 -----> ElementAtV2()
        public static Employee ElementAtV2(this IEnumerable<Employee> Emps , int index) {

            Employee Result = new Employee(); int counter = 0;

            foreach (Employee emp in Emps) {
                
                if (counter == index) { Result = emp;break; }
                counter++;
            }

            return Result;
        }






    }
}
