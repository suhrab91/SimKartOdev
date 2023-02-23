namespace SimKartÖdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pin = 4321;
            int girilenPin = 0; int girilenPuk = 0;
            int puk = 1234;



            for (int i = 2; i >= 0; i--)
            {
                Console.Write("Lütfen PIN kodunu giriniz: ");
                girilenPin = int.Parse(Console.ReadLine());

                if (girilenPin == pin)
                {
                    Console.WriteLine("Tebrikler. Sim kartınız aktif hale getirilmiştir.");
                    break;
                }
                else if (girilenPin != pin && i != 0)
                {


                    Console.WriteLine("Yanlış PIN kodu girdiniz. " + i + " Hakkınız kalmıştır.");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("PIN Hakkınız kalmamıştır. ");
                    for (int j = 9; j >= 0; j--)
                    {
                        Console.Write("Lütfen PUK kodunu giriniz: ");
                        girilenPuk = int.Parse(Console.ReadLine());

                        if (girilenPuk == puk)
                        {
                            Console.WriteLine("Tebrikler. Sim kartınız aktif hale getirilmiştir.");
                            break;
                        }
                        else if (girilenPuk != puk && j != 0)
                        {

                            Console.WriteLine("Yanlış PUK kodu girdiniz. " + j + " Hakkınız kalmıştır.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Hakkınız kalmamıştır. Servis sağlayıcınız ile iletişime geçiniz.");
                        }

                    }

                }
            }
;
        }
    }
}