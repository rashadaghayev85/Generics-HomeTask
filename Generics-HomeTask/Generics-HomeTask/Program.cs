#region Practice


using Generics_HomeTask;

using System.Data;

//IntList nums = new IntList();
//nums.Add(1);
//nums.Add(2);
//nums.Add(3);
//nums.Add(4);
//nums.Add(5);





//int[] result = nums.Delete(2);

//foreach (int item in result)
//{
//    Console.WriteLine(item);
//}

//StringList words = new StringList();
//words.Add("a");
//words.Add("b");
//words.Add("c");
//words.Add("d");
//words.Add("e");
//words.Add("f");
//words.Add("g");
//words.Add("h"); 
//words.Add("i");

// words.Delete("b");
//string[] response= words.Delete("h");  
//foreach (string item in response)
//{
//    Console.WriteLine(item);
//}

//DataList<int>datas=new DataList<int>();
//datas.Add(1);
//datas.Add(2);
//int[] product = datas.GetAll();

//foreach (int item in product)
//{
//    Console.WriteLine(item);
//}



DataList<string> datas = new DataList<string>();
datas.Add("Rashad");
datas.Add("Aghayev");
datas.Add("salam");


string[] product = datas.Delete("Aghayev");

foreach (string item in product)
{
    Console.WriteLine(item);
}













#endregion