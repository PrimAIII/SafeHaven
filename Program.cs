// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);
string MyWorld = "My World is a Marvel";
Console.WriteLine(MyWorld);
MyWorld = MyWorld.Replace("World", "Life");
Console.WriteLine(MyWorld);
string SongLyrics = "Nothing else matters, except love";
var result = SongLyrics.StartsWith("love");
Console.WriteLine(result);
Console.WriteLine(SongLyrics.Contains("matters"));
string SongLyrics1 = "Love of my life, you've hurt me";
var result1 = SongLyrics1.StartsWith("Love");
Console.WriteLine(result1);
Console.WriteLine(SongLyrics1.Contains("life"));