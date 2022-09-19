// See https://aka.ms/new-console-template for more information

//double a = 2;

//if(int.TryParse(a.ToString(), out int c))
//{
//    Console.WriteLine(c);
//}
//else
//{
//    Console.WriteLine("false");
//}

Dictionary<int, Dictionary<string, List<string>>> dictPro_IsDefault = new Dictionary<int, Dictionary<string, List<string>>>();
dictPro_IsDefault.Add(1, new Dictionary<string, List<string>>());
dictPro_IsDefault.Add(2, new Dictionary<string, List<string>>());
dictPro_IsDefault[1].Add("GroupCode", new List<string> { "ProCode", "ss" });
dictPro_IsDefault[2].Add("GroupCode2", new List<string> { "ProCode2", "ss2" });

Console.WriteLine(dictPro_IsDefault[2]["GroupCode2"].Contains("ProCode"));