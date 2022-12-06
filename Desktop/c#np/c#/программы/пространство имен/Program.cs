/* Console.WriteLine("Значение 123456 в разных форматах: ");
Console.WriteLine("d7: {0:d7}", 123456); //форматирование деситичных чисел
Console.WriteLine("c: {0:c}", 123456); //форматирование денежных значений
Console.WriteLine("n: {0:n}", 123456); //базовое число форматирование (с запятыми)
Console.WriteLine("f3: {0:f3}", 123456); //числа с фиксированной точкой, число поле ф сколько чисел после точки */

string Msg = string.Format("f2: {0:f2}", 1234);
Console.WriteLine(Msg);