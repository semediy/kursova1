// See https://aka.ms/new-console-template for more information

int largeNumber = 300;
byte smallNumber = (byte)largeNumber; // Переповнення, оскільки byte не може зберігати значення більше 255
Console.WriteLine(smallNumber); // Виведе 44 (результат переповнення)