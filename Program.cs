Random rnd = new Random();
int[] array1 = {1,2,3,4,5,6,7,8,9};
// Console.WriteLine(array1[2]);
string[] string1 = {"Tim","Martin","Nikki","Sara"};
// Console.WriteLine(string1[2]);
bool[] alternating = {true,false,true,false,true,false,true,false,true,false};
// Console.WriteLine(alternating[2]);

List<string> flavors = new List<string>();
flavors.Add("strawberry");
flavors.Add("vanilla");
flavors.Add("chocolate");
flavors.Add("mint");
flavors.Add("lemon");

int count = 0;
foreach (string flavor in flavors)
{
    count++;
}
Console.WriteLine(count);
Console.WriteLine(flavors[2]);
flavors.Remove("chocolate");
count = 0;
foreach (string flavor in flavors)
{
    count++;
}
Console.WriteLine(count);
Dictionary<string,string> userinfo = new Dictionary<string,string>();
string randomflavor = "";
foreach (string person in string1)
{
    randomflavor = flavors[rnd.Next(flavors.Count())];
    userinfo.Add(person, randomflavor);
}
Console.WriteLine(userinfo["Tim"]);