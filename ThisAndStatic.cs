using System;

public class this dan static
{
    static public void Main ()
    {
       

    Rumus.tampil();

    Rumus rumus = new Rumus();
    rumus.set(5," ganteng ");
    rumus.get();


    }
    


    class Rumus 
    {

        public int hasil;
        public string? nama =null;

        public static void tampil(){
            Console.WriteLine("belajar static");
        }

        public int set(int hasil,string nama){
            this.nama=nama;
            return this.hasil = hasil;

        }

        public void get(){
            Console.WriteLine(this.hasil);
        }
    }



}