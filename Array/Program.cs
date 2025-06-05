int[] numbers = new int[10]; // 10 elemanlı bir liste oluşturuyoruz.

for (int i = 0; i < numbers.Length; i++) //içerisine 0'dan 9'a kadar sayıları atıyoruz.
{
    numbers[i] = i;
}

Console.WriteLine("Lütfen eklemek istediğiniz sayıyı giriniz");

int sayı = Convert.ToInt32(Console.ReadLine()); // Kullanıcıdan bir sayı alıyoruz.

Array.Resize(ref numbers, numbers.Length + 1); // Liste boyutunu 1 artırıyoruz.

numbers[numbers.Length - 1] = sayı; // Kullanıcının girdiği sayıyı listenin sonuna ekliyoruz.

Array.Sort(numbers); // Listeyi küçükten büyüğe sıralıyoruz.
Array.Reverse(numbers); // Listeyi ters çevirip büyükten küçüğe sıralıyoruz.

Console.WriteLine("Büyükten küçüğe sıralanmış liste:");

foreach (int number in numbers) // Liste elemanlarını yazdırıyoruz.
{
    Console.WriteLine(number);
}

