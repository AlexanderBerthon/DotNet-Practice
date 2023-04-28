// See https://aka.ms/new-console-template for more information

string username = Environment.UserName;
Console.WriteLine(username);
File.Create("C:\\Users\\" + username + "\\Desktop\\newfile.txt");