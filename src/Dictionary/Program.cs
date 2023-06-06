// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string input = "abababc";

Dictionary<char, int> dict = new();

for(int i=0; i<input.Length; i++)
{
    var element = input[i];
    if (dict.ContainsKey(element))
    {
        dict[element]++;
    }
    else
    {
        dict.Add(element,1); 
    }
}
string s = "";
foreach(var element in dict)
{
    s += element.Key.ToString() + element.Value.ToString();
}
for (int i = 0; i < dict.Count; i++)
{
    s += dict.Keys.ToList()[i].ToString() + dict.Values.ToList()[i].ToString();

}
char a = 'b';

if (a.ToString().ToUpper() == a.ToString())
    Console.WriteLine("true");
else
    Console.WriteLine("false");
Console.WriteLine(s);
