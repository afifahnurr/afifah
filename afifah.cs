using System;



class MainClass {
  public static void Main (string[] args) {
			kembali:
			Console.Clear();
            int pilihan=0;
            int m=0,n=0;
            Console.WriteLine("Selamat Datang Di Aplikasi Kalkulator");
            Console.WriteLine( );
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine( );
            Console.WriteLine("Silakan Masukan Pilihan : ");
            pilihan= int.Parse(Console.ReadLine());

            if (pilihan==1)
            {
                Console.WriteLine("Silakan Masukan Nilai M: ");
                m=int.Parse(Console.ReadLine());
                Console.WriteLine("Silakan Masukan Nilai N: ");
                n=int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil pertambahan: {0}+{1}={2}", m, n, pertambahan(m,n));
                Console.ReadKey(true);
				goto kembali;
            }
            if (pilihan==2)
            {
                Console.WriteLine("Silakan Masukan Nilai M: ");
                m=int.Parse(Console.ReadLine());
                Console.WriteLine("Silakan Masukan Nilai N: ");
                n=int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil pengurangan: {0}-{1}={2}", m, n, pengurangan(m,n));
                Console.ReadKey(true);
				goto kembali;
            }
            if (pilihan==3)
            {
                Console.WriteLine("Silakan Masukan Nilai M: ");
                m=int.Parse(Console.ReadLine());
                Console.WriteLine("Silakan Masukan Nilai N: ");
                n=int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil perkalian: {0}*{1}={2}", m, n, perkalian(m,n));
                Console.ReadKey(true);
				goto kembali;
            }
            if (pilihan==4)
            {
                Console.WriteLine("Silakan Masukan Nilai M: ");
                m=int.Parse(Console.ReadLine());
                Console.WriteLine("Silakan Masukan Nilai N: ");
                n=int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil pembagian: {0}/{1}={2}", m, n, pembagian(m,n));
             	Console.ReadKey(true);
				goto kembali;
            }
			else
			{
				Console.WriteLine("Maaf Pilihan anda tidak ada");
				Console.ReadKey(true);
				goto kembali;
			}
  }
  
  static int pertambahan(int m, int n)
  {
      return m + n;
      
  }
  
  static int pengurangan(int m, int n)
  {
      return m - n;
      
  }
  static int perkalian(int m, int n)
  {
      return m * n;
     
  }
  static int pembagian(int m, int n)
  {
      return m / n;
      
  }



  
}