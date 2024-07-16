using System;

namespace Who_Milyoner
{

    class Milyoner
    {
        static void Main(string[] args)

        {
            int correct = 0;// Variable for the correct measure
            Console.Write("Please chose pi number?(a:22/7 b:3,14):");
            string q1 = Console.ReadLine().ToLower(); //Question 1 and use lower variable methıd

            switch (q1)
            {

                case "a":
                    Console.WriteLine("Congratulations Correct Answer");
                    correct=correct+1;//if answer correct correct variable plus +1
                    break;
                    case "b":
                    Console.WriteLine("Unfortunatley you didn't know!");
                    correct = correct; //İf answer correct correct variable nothing  plus 
                    break;
             
            } 
            Console.Write("What is the long river at the world?(a:misssipi b:amazon):");
            string q2 = Console.ReadLine().ToLower();//Question 2 and use lower variable method
            switch (q2)
            {

                case "a":
                    Console.WriteLine("Unfortunatley you didn't know!");
                    correct=correct; // İf answer correct correct variable nothing plus
                    break;
                    case "b":
                    Console.WriteLine("Congratulations Correct Answer");
                    correct = correct+1;//if answer correct correct variable plus +1
                    break;
            }
            if (correct != 0) // Correct variable is not 0 to be conntinue
            {
                Console.Write("Please chose which book's arthur is Yaşar Kemal?(a:Yılkı Atı b:İnce Memed):");
                string q3 = Console.ReadLine().ToLower();
                switch (q3) //Question 3 and use lower variable method
                {

                    case "a":
                        Console.WriteLine("Unfortunatley you didn't know!");
                        correct = correct;//İf answer correct correct variable nothing  plus 
                        break;
                    case "b":
                        Console.WriteLine("Congratulations Correct Answer");
                        correct = correct + 1;//if answer correct correct variable plus +1
                        break;
                }
                if (correct >= 2)// if correct >=2 the user is win
                {
                    Console.WriteLine($"Congratulations! You have won 1 million TL! :{correct}");
                }
                else Console.WriteLine($"You loss :( maybe later you will win goodbay your score :{correct}");//if correct <2 the user loss
            }
            else
            {
            Console.WriteLine($"You loss :( maybe later you will win goodbay your score :{correct}");// if correct 0 the user loss and he/she didnt see question 3
            }
        }
       
    }
}

//Bir bilgi yarışması yapıyoruz!

//2 cevap şıklı 3 adet sorumuz var ! ( Aşağıdaki sorular örnektir, kendi sorularınızla programı editleyebilirsiniz.)

//1 -> Kızınca tüküren hayvan hangisidir ?

//a) Lama b) Deve 

//2 -> Dünya'ya en yakın gezegen hangisidir ? 

//a) Venüs b) Mars 

//3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ? 

//a) 7 b) 12 

//Yarışmacı 3 sorudan 2'sini doğru cevaplar  ise 1 Milyon TL'lik büyük ödülü kazanacak!

//Bu uygulamada kullanıcının doğru cevaplarını saymak için bir değişkene ihtiyacımız olduğunu unutmayın !

//Akış -> Kullanıcıya birinci soruyu soruyoruz ve cevabı alıyoruz. ( A ya da B şeklinde - Büyük küçük harf duyarlılığı olmasın!) , Ardından cevabın doğruluk durumuna göre bir mesaj ile kullanıcıya durumu bildiriyoruz. 

//İlk 2 soruya cevap veren kullanıcının büyük ödülü kazanma ihtimali ortadan kalktığı için 3. soruyu sormuyoruz.

//Final neticesinde kullanıcıya büyük ödülü kazanıp kazanmadığını bir konsol mesajıyla bildiriyoruz.