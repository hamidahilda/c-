using System;

public class HelloWorld
{
    static public void Main ()
    {
        

Kalkulator hitung = new Kalkulator();

// hitung.tambah();
// hitung.kurang();

Console.Write("masukan sisi : ");
int a = Convert.ToInt32( Console.ReadLine() );


Rumus rumus = new Rumus();
int luas = rumus.persegi (a);

Console.WriteLine($"luas persegi dengan a ={a} dan adalah {luas}");

    }
    

class Kalkulator
{
public void tambah(){
    Console.WriteLine("tambah");}
public void kurang(){
    Console.WriteLine("kurang");}
}
class Rumus
{
public void lingkaran(){
Console.WriteLine("lingkaran");}
public int persegi(int a){
return a*a;}
}


}