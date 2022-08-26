Console.WriteLine("Какое число программистов увидел робот");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(a)); 

string Sum(int b)
{ 
string result; 
if (b == 1 || b % 10 == 1 && b % 100 != 11)
 { 
result = "В зале " + a + " программист"; 
} 
else if ( b % 100 != 11 && b % 100 != 12 && b % 100 != 13 && b % 100 != 14 &&  b % 10 > 1 && b % 10 < 5 )
{ 
result = "В зале " + a + " программиста"; 
} 
else{ 
result = "В зале " + a + " программистов"; 
} 
return result;
}

























